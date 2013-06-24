Imports System.Data.OleDb

Public Class frmSales
    Public SalesID As Integer
    Private WithEvents ProductLookup As frmProductLookup
    Private WithEvents Pay As frmPay
    Dim blnPaid As Boolean
    Dim State As FormState
    Dim conn As New OleDbConnection(My.Settings.DataConnectionString)

    Public WriteOnly Property getFormState()
        Set(ByVal value)
            State = value
        End Set
    End Property

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub SalesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles SalesBindingNavigatorSaveItem.Click
        Try
            If blnPaid = False Then
                MessageBox.Show("Please pay before saving the record.", "Save failed.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Exit Sub
            End If

            Me.Validate()
            Me.SalesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SalesDataSet)

            Dim intProductDetailID As Integer

            For Each row As DataGridViewRow In Me.SalesDetailDataGridView.Rows
                intProductDetailID = row.Cells(Me.ProductDetailID.Index).Value

                'Deduct Item Sold (Qty) from Items Details Table
                If intProductDetailID <> 0 Then
                    Dim QtyOnHand As Integer
                    Dim QtyOrdered As Integer
                    Dim OrderNo As Integer
                    Dim QtyperUnit As Integer
                    Dim ItemTypeID As Integer
                    Dim ItemID As Integer
                    Dim ItemName As String

                    Dim rdr As OleDbDataReader

                    rdr = GetData("SELECT ProductDetailID, ProductID, OrderNo, QtyperUnit, QtyOnHand FROM ProductDetail  WHERE ProductDetailID = " & intProductDetailID)

                    rdr.Read()

                    ItemID = rdr("ProductID")
                    QtyOnHand = rdr("QtyOnHand")
                    OrderNo = rdr("OrderNo")
                    QtyperUnit = rdr("QtyperUnit")

                    QtyOrdered = row.Cells(Me.Qty.Index).Value

                    ItemTypeID = GetFieldValue("SELECT ItemTypeID FROM Product INNER JOIN ProductDetail ON Product.ProductID = ProductDetail.ProductID WHERE ProductDetailID  = " & intProductDetailID, "ItemTypeID")
                    ItemName = GetFieldValue("SELECT ProductName FROM Product INNER JOIN ProductDetail ON Product.ProductID = ProductDetail.ProductID WHERE ProductDetailID  = " & intProductDetailID, "ProductName")

                    If QtyOrdered > QtyOnHand And OrderNo <> 1 And ItemTypeID = 2 Then
                        If DeductOnhand(intProductDetailID, QtyOrdered, OrderNo, True, QtyOnHand, ItemID) = False Then
                            MsgBox("No available quantity for the Item '" & ItemName & "'.", MsgBoxStyle.Exclamation)

                            Exit Sub
                        End If
                    End If

                    Me.TableAdapterManager.UpdateAll(Me.SalesDataSet)

                    'Deduct QtyOnHand from QtyOrdered
                    ExecNonQuery("UPDATE ProductDetail SET QtyOnHand = " & QtyOnHand - QtyOrdered & " WHERE ProductDetailID  = " & intProductDetailID)
                End If
            Next row

            MessageBox.Show("Record successfully saved...", "Saving record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'btnNew_Click(sender, e)

            btnNew.Enabled = True
            btnPay.Enabled = False
            btnSettle.Enabled = False
            btnCancel.Enabled = False
            btnVoid.Enabled = True
            btnPrint.Enabled = True
            SalesDetailDataGridView.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmSales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Qry_CustomerLookupTableAdapter.Fill(Me.CustomerLookupDataSet.qry_CustomerLookup)
        Me.Qry_ProductLookupTableAdapter.Fill(Me.ProductLookupDataSet.qry_ProductLookup)

        If State = FormState.adStateAddMode Then
            Me.SalesTableAdapter.Fill(Me.SalesDataSet.Sales)
            Me.SalesDetailTableAdapter.Fill(Me.SalesDataSet.SalesDetail)

            BindingNavigatorAddNewItem.PerformClick()
        Else
            Me.SalesTableAdapter.FillBy(Me.SalesDataSet.Sales, SalesID)
            Me.SalesDetailTableAdapter.FillBy(Me.SalesDataSet.SalesDetail, SalesID)
        End If
    End Sub

    Private Sub SalesDetailDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SalesDetailDataGridView.CellContentClick
        Dim dgv As DataGridView = CType(sender, DataGridView)

        If dgv.Columns(e.ColumnIndex).Name = "AddProduct" Then
            ProductLookup = New frmProductLookup

            ProductLookup.OrderType = "SalesOrder"
            ProductLookup.Show(Me)
        End If
    End Sub

    Private Sub ProductLookup_ProductIDSelected(ByVal ProductDetailID As Integer, ByVal SellingPrice As Double, ByVal UnitID As Integer) Handles ProductLookup.ProductIDSelected
        Dim rowNum As Integer = SalesDetailDataGridView.CurrentCell.RowIndex

        SalesDetailDataGridView(1, rowNum).Value = ProductDetailID
        SalesDetailDataGridView(3, rowNum).Value = toMoney(SellingPrice)

        SalesDetailDataGridView(6, rowNum).Value = toMoney(SellingPrice)

        Total()

        SalesDetailBindingSource.EndEdit()
    End Sub

    Private Sub SalesDetailDataGridView_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SalesDetailDataGridView.CellEndEdit
        Dim SalesDetails As DataGridView = DirectCast(sender, DataGridView)

        Dim intQty As Integer
        Dim curSellingPrice As Decimal
        Dim DiscountAmount As Decimal
        Dim DiscountPercent As Decimal

        intQty = SalesDetails("Qty", e.RowIndex).Value
        curSellingPrice = SalesDetails("SellingPrice", e.RowIndex).Value

        If SalesDetails.Columns(e.ColumnIndex).Name = "DiscountPercent" Then
            DiscountPercent = SalesDetails("DiscountPercent", e.RowIndex).Value

            SalesDetails("DiscountAmount", e.RowIndex).Value = toNumber(curSellingPrice * (DiscountPercent / 100))
            DiscountAmount = SalesDetails("DiscountAmount", e.RowIndex).Value
        ElseIf SalesDetails.Columns(e.ColumnIndex).Name = "DiscountAmount" Then
            DiscountAmount = SalesDetails("DiscountAmount", e.RowIndex).Value

            SalesDetails("DiscountPercent", e.RowIndex).Value = toNumber(DiscountAmount / curSellingPrice * 100)

            DiscountPercent = SalesDetails("DiscountPercent", e.RowIndex).Value
        End If

        SalesDetails("Amount", e.RowIndex).Value = toMoney(intQty * curSellingPrice - DiscountAmount)

        Total()
    End Sub

    Private Sub Total()
        Dim Net As Double = 0
        Dim TotalDiscountPercent As Double = 0
        Dim TotalDiscountAmount As Double = 0
        Dim i As Integer = 0

        For i = 0 To SalesDetailDataGridView.Rows.Count - 1
            Net = Net + Convert.ToDouble(SalesDetailDataGridView.Rows(i).Cells("Amount").Value)
            TotalDiscountPercent = TotalDiscountPercent + Convert.ToDouble(SalesDetailDataGridView.Rows(i).Cells("DiscountPercent").Value)
            TotalDiscountAmount = TotalDiscountAmount + Convert.ToDouble(SalesDetailDataGridView.Rows(i).Cells("DiscountAmount").Value)
        Next i

        DiscountAmountTextBox.Text = toMoney(TotalDiscountAmount)
        DiscountPercentTextBox.Text = toMoney(TotalDiscountPercent)

        NetTextBox.Text = toMoney(Net)
        TaxBaseTextBox.Text = toMoney(Net / 1.12)
        VATTextBox.Text = toMoney(Net - TaxBaseTextBox.Text)
    End Sub

    Private Sub btnAddCustomer_Click(sender As System.Object, e As System.EventArgs) Handles btnAddCustomer.Click
        Dim Customer As New frmAddCustomer

        Customer.ShowDialog()

        Me.Qry_CustomerLookupTableAdapter.Fill(Me.CustomerLookupDataSet.qry_CustomerLookup)
    End Sub

    Private Sub SalesDetailDataGridView_CellValidating(sender As Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles SalesDetailDataGridView.CellValidating
        Dim SalesDetails As DataGridView = DirectCast(sender, DataGridView)

        If SalesDetails("Qty", e.RowIndex).EditedFormattedValue = "" Or SalesDetails("SellingPrice", e.RowIndex).EditedFormattedValue = "" Then
            MessageBox.Show("Please enter numeric value.", "Enter value", MessageBoxButtons.OK, MessageBoxIcon.Information)

            e.Cancel = True
        End If
    End Sub

    Private Sub btnSettle_Click(sender As System.Object, e As System.EventArgs) Handles btnSettle.Click
        SalesBindingNavigatorSaveItem_Click(sender, e)
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        If MessageBox.Show("Are you sure you want to cancel this order?", "Cancel...", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            SalesDataSet.SalesDetail.RejectChanges()
            SalesDataSet.Sales.RejectChanges()

            btnNew_Click(sender, e)
        End If
    End Sub

    Private Sub btnVoid_Click(sender As System.Object, e As System.EventArgs) Handles btnVoid.Click
        If MessageBox.Show("Are you sure you want to voide this sale?", "Void", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

        SalesID = Me.SalesIDTextBox.Text

        ExecNonQuery("UPDATE Sales SET Void = 1 WHERE ReceiptID = " & SalesID)

        conn.Open()

        Dim strSQL As String

        strSQL = "SELECT ProductDetail.ProductID, ReceiptID, Qty " _
                & "FROM ProductDetail INNER JOIN " _
                & "SalesDetail ON ProductDetail.ProductDetailID = SalesDetail.ProductDetailID " _
                & "WHERE SalesID = " & SalesID

        Dim cmd As OleDbCommand = New OleDbCommand(strSQL, conn)
        'create data reader
        Dim rdr As OleDbDataReader = cmd.ExecuteReader

        While rdr.Read()
            ExecNonQuery("UPDATE ProductDetail SET QtyOnHand = QtyOnHand + " & rdr("Qty") & " WHERE ProductID = " & rdr("ProductID"))
        End While

        MessageBox.Show("Successfully void.", "Void", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Close()
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        blnPaid = False

        Me.SalesDataSet.Sales.DateColumn.DefaultValue = Date.Now

        Me.BindingNavigatorAddNewItem.PerformClick()

        blnPaid = False

        btnNew.Enabled = False
        btnPay.Enabled = True
        btnSettle.Enabled = True
        btnPrint.Enabled = False
        btnCancel.Enabled = True
        btnSettle.Enabled = True
        SalesDetailDataGridView.ReadOnly = False
    End Sub

    Private Sub btnPay_Click(sender As System.Object, e As System.EventArgs) Handles btnPay.Click
        Pay = New frmPay

        With Pay

            .ShowDialog()
        End With
    End Sub

    Private Function DeductOnhand(ByVal ProductDetailID As Integer, ByVal QtyNeeded As Integer, ByVal Order As Integer, ByVal blnDeduct As Boolean, ByRef QtyOnHand As Integer, ByVal ProductID As Integer) As Boolean
        Dim cmProducts As CurrencyManager

        Dim Onhand As Boolean
        Dim OrderTemp As Integer
        Dim QtyNeededTemp As Double

        Dim sqlQRY As String = "SELECT ProductDetailID, ProductID, OrderNo, QtyperUnit, QtyOnHand FROM ProductDetail WHERE [ProductID] = " & ProductID & " ORDER BY OrderNo ASC"

        Dim conn As OleDbConnection = New OleDbConnection(cnString)

        conn.Open()

        'create data adapter
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(sqlQRY, conn)

        da.SelectCommand = New OleDbCommand(sqlQRY, conn)

        'this will create an update command for data adapter
        Dim cb As OleDbCommandBuilder = New OleDbCommandBuilder(da)

        Dim ds As DataSet = New DataSet

        'fill dataset
        da.Fill(ds, "ProductDetail")

        cmProducts = Me.BindingContext(ds.Tables("ProductDetail"))
        cmProducts.Position = 0

        Dim ItemsView As DataView

        ItemsView = New DataView(ds.Tables("ProductDetail"), "", _
                                   "OrderNo", DataViewRowState.CurrentRows)

        Dim rowIndex As Integer

        Do Until DeductOnhand = True
            OrderTemp = Order
            QtyNeededTemp = QtyNeeded

            rowIndex = ItemsView.Find(OrderTemp)

            If rowIndex = -1 Then
                MessageBox.Show("No match found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                cmProducts.Position = rowIndex
            End If

            Do Until Onhand = True 'Or OrderTemp = 1
                If ItemsView(rowIndex)("QtyOnHand") >= QtyNeededTemp Then
                    If blnDeduct = False Then
                        DeductOnhand = True
                        Exit Function
                    Else
                        Onhand = True
                    End If

                    If QtyNeededTemp > 0 And QtyNeededTemp < 1 Then
                        QtyNeededTemp = 1
                    Else
                        QtyNeededTemp = CInt(QtyNeededTemp)
                    End If
                Else
                    OrderTemp = OrderTemp - 1
                    If OrderTemp < 1 Then Exit Do
                    QtyNeededTemp = (QtyNeededTemp - ItemsView(rowIndex)("QtyOnHand")) / ItemsView(rowIndex)("QtyperUnit")

                    ItemsView = New DataView(ds.Tables("ProductDetail"), "", _
                                        "OrderNo", DataViewRowState.CurrentRows)

                    cmProducts.Position = 0
                    rowIndex = ItemsView.Find(OrderTemp)

                    If rowIndex = -1 Then
                        Console.WriteLine("No match found.")
                    Else
                        cmProducts.Position = rowIndex
                    End If
                End If
            Loop

            If Onhand = True Then
                Do
                    ItemsView(rowIndex)("QtyOnHand") = ItemsView(rowIndex)("QtyOnHand") - QtyNeededTemp

                    da.Update(ds, "ProductDetail")

                    OrderTemp = OrderTemp + 1

                    ItemsView = New DataView(ds.Tables("ProductDetail"), "", _
                                        "OrderNo", DataViewRowState.CurrentRows)

                    cmProducts.Position = 0
                    rowIndex = ItemsView.Find(OrderTemp)

                    If rowIndex = -1 Then
                        Console.WriteLine("No match found.")
                    Else
                        cmProducts.Position = rowIndex
                    End If

                    ItemsView(rowIndex)("QtyOnHand") = ItemsView(rowIndex)("QtyOnHand") + (QtyNeededTemp * ItemsView(rowIndex)("QtyperUnit"))

                    da.Update(ds, "ProductDetail")

                    Onhand = False

                    If OrderTemp = Order Then
                        DeductOnhand = True

                        QtyOnHand = ItemsView(rowIndex)("QtyOnHand")

                        Exit Do
                    Else
                        DeductOnhand = False
                        Exit Do
                    End If
                Loop
            Else
                DeductOnhand = False
            End If
        Loop
    End Function

    Private Sub Pay_AmountPaid(Amount As Double, PaymentType As String) Handles Pay.AmountPaid
        If Amount > 0 Then
            blnPaid = True

            If PaymentType = "Cash" Then
                txtCash.Text = Format(Amount, "Standard")
            Else
                txtCheck.Text = Format(Amount, "Standard")
            End If

            Dim curTotalPaid As Double

            curTotalPaid = toNumber(txtCash.Text) + toNumber(txtCheck.Text)
            If curTotalPaid > toNumber(NetTextBox.Text) Then
                txtChange.Text = toMoney(curTotalPaid - toNumber(NetTextBox.Text))
            Else
                txtChange.Text = "0.00"
            End If
        End If
    End Sub

End Class