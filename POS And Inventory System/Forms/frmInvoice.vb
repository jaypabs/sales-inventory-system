Imports System.Data.OleDb

Public Class frmInvoice
    Public Property InvoiceID As Integer
    Private WithEvents SOLookup As frmSOLookup
    Private WithEvents ProductLookup As frmProductLookup

    Dim State As FormState
    Dim conn As New OleDbConnection(My.Settings.DataConnectionString)

    Public WriteOnly Property getFormState()
        Set(ByVal value)
            State = value
        End Set
    End Property

    Private Sub InvoiceBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Try
            conn.Open()

            Dim intProductDetailID As Integer
            Dim intQtyDlvd As Integer
            Dim strSQL As String
            Dim dt As DataTable
            Dim totQtyDlvdSO As Integer 'From sales order details
            Dim totQtyDlvdInv As Integer 'Total Qty Delivered - Invoice table
            Dim SalesOrderID As Integer = GetFieldValue(String.Format("SELECT SalesOrderID FROM SalesOrder WHERE SONumber = {0}", SONumberTextBox.Text), "SalesOrderID")

            Me.TableAdapterManager.Connection = conn

            'Using ts As New System.Transactions.TransactionScope

            Dim command As OleDbCommand = conn.CreateCommand
            command.Connection = conn

            Me.Validate()
            Me.InvoiceBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.InvoiceDataSet)

            For Each row As DataGridViewRow In Me.InvoiceDetailDataGridView.Rows
                intQtyDlvd = row.Cells(Me.Qty.Index).Value
                intProductDetailID = row.Cells(Me.ProductDetailID.Index).Value

                'Receive Item from PO
                If SONumberTextBox.Text <> "" And DeliveryStatusComboBox.Text = "Approved" And intProductDetailID <> 0 Then
                    'Get the total item recieve. Including the previous item recieved.
                    strSQL = String.Format("SELECT SUM(Qty) AS TotalQtyDlvd FROM InvoiceDetail WHERE SalesOrderID = {0} AND ProductDetailID  = {1}", SalesOrderID, intProductDetailID)

                    dt = GetDataTable(conn, strSQL)

                    Dim rowDetail As DataRow

                    For Each rowDetail In dt.Rows
                        If IsDBNull(rowDetail("TotalQtyDlvd")) Then
                            totQtyDlvdInv = 0
                        Else
                            totQtyDlvdInv = rowDetail("TotalQtyDlvd")
                        End If
                    Next rowDetail

                    'Get the total item delivered.
                    strSQL = String.Format("SELECT QtyDlvd FROM SalesOrderDetail WHERE SalesOrderID = {0} AND ProductDetailID  = {1}", SalesOrderID, intProductDetailID)

                    dt = GetDataTable(conn, strSQL)

                    For Each rowDetail In dt.Rows
                        If IsDBNull(rowDetail("QtyDlvd")) Then
                            totQtyDlvdSO = 0
                        Else
                            totQtyDlvdSO = rowDetail("QtyDlvd")
                        End If
                    Next rowDetail

                    'Item received should not exceed on SO
                    'If totQtyDlvdInv > totQtyDlvdSO Then
                    '    MsgBox("The number of Item Delivered should not exceed as declared in S.O.", MsgBoxStyle.Exclamation)

                    '    Exit Sub
                    'End If

                    If totQtyDlvdInv < totQtyDlvdSO Or totQtyDlvdInv = 0 Then
                        'Set status to 3 = Received (Incomplete)
                        ExecNonQueryTrans(conn, "UPDATE SalesOrder SET OrderStatus = 'Received (Incomplete)' WHERE SalesOrderID = " & SalesOrderID)
                    Else
                        'Set status to 4 = Received (Complete)
                        ExecNonQueryTrans(conn, "UPDATE SalesOrder SET OrderStatus = 'Received (Complete)' WHERE SalesOrderID = " & SalesOrderID)
                    End If

                    'Add Qty Received in SalesOrderDetail table
                    command.CommandText = String.Format("UPDATE SalesOrderDetail SET QtyDlvd = QtyDlvd + {0} WHERE SalesOrderID = {1} AND ProductDetailID  = {2}", intQtyDlvd, SalesOrderID, intProductDetailID)
                    command.ExecuteNonQuery()

                    'Deduct SO Qty in ProductDetail table
                    command.CommandText = String.Format("UPDATE ProductDetail SET QtyOnSO = QtyOnSO - {0}  WHERE ProductDetailID  = {1}", intQtyDlvd, intProductDetailID)
                    command.ExecuteNonQuery()
                End If

                If DeliveryStatusComboBox.Text = "Approved" And intProductDetailID <> 0 Then
                    'Deduct delivered Item to Items table
                    ExecNonQueryTrans(conn, String.Format("UPDATE ProductDetail SET QtyOnHand = QtyOnHand - {0} WHERE ProductDetailID  = {1}", intQtyDlvd, intProductDetailID))
                End If
            Next row

            '    ts.Complete()
            'End Using

            MessageBox.Show("Record successfuly saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Saving", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub InvoiceBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs) Handles InvoiceBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InvoiceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InvoiceDataSet)

    End Sub

    Private Sub frmInvoice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Qry_ProductLookupTableAdapter.Fill(Me.ProductLookupDataSet.qry_ProductLookup)
        Me.Qry_CustomerLookupTableAdapter.Fill(Me.CustomerLookupDataSet.qry_CustomerLookup)
        Me.InvoiceTableAdapter.Fill(Me.InvoiceDataSet.Invoice)
        Me.InvoiceDetailTableAdapter.Fill(Me.InvoiceDataSet.InvoiceDetail)

        If State = FormState.adStateAddMode Then
            Me.InvoiceTableAdapter.Fill(Me.InvoiceDataSet.Invoice)
            Me.InvoiceDetailTableAdapter.Fill(Me.InvoiceDataSet.InvoiceDetail)

            BindingNavigatorAddNewItem.PerformClick()

            CreatedByTextBox.Text = CurrUser.USERNAME
            DeliveryStatusComboBox.Text = "For Approval"
        Else
            Me.InvoiceTableAdapter.FillBy(Me.InvoiceDataSet.Invoice, InvoiceID)
            Me.InvoiceDetailTableAdapter.FillBy(Me.InvoiceDataSet.InvoiceDetail, InvoiceID)

            If DeliveryStatusComboBox.Text = "For Approval" Then
                EnableControls(True)
            Else
                EnableControls(False)
                btnSave.Visible = False
                InvoiceDetailDataGridView.Columns("AddProduct").Visible = False
            End If
        End If
    End Sub

    Private Sub btnSOLookup_Click(sender As System.Object, e As System.EventArgs) Handles btnSOLookup.Click
        SOLookup = New frmSOLookup

        SOLookup.ShowDialog()
    End Sub

    Private Sub SOLookup_SOIDSelected(value As Integer) Handles SOLookup.SOIDSelected
        Dim strSQL As String = "SELECT SONumber, CustomerID " & _
                "FROM SalesOrder WHERE SalesOrderID = " & value

        conn.Open()

        Dim cmd As OleDbCommand = New OleDbCommand(strSQL, conn)
        'create data reader
        Dim rdr As OleDbDataReader = cmd.ExecuteReader

        rdr.Read()

        Me.SONumberTextBox.Text = rdr("SONumber")
        Me.CustomerIDComboBox.SelectedValue = rdr("CustomerID")

        Me.SONumberTextBox.Focus()

        conn.Close()

        AddSOItem(value)

        InvoiceDetailDataGridView.Columns("AddProduct").Visible = False
    End Sub

    Private Sub AddSOItem(ByVal SalesOrderID As Integer)
        Dim strSQL As String

        conn.Open()

        strSQL = "SELECT ProductDetailID, Qty, QtyDlvd, UnitID, SellingPrice, DiscountPercent, DiscountAmount, Amount " & _
                "FROM SalesOrderDetail WHERE SalesOrderID = " & SalesOrderID

        Dim cmd As OleDbCommand = New OleDbCommand(strSQL, conn)
        'create data reader
        Dim rdr As OleDbDataReader = cmd.ExecuteReader

        Do While rdr.Read
            Me.InvoiceBindingSource.EndEdit()

            Dim QtyLeft As Integer = rdr("Qty") - rdr("QtyDlvd")

            Dim newRow As InvoiceDataSet.InvoiceDetailRow = InvoiceDataSet.InvoiceDetail.NewInvoiceDetailRow

            newRow.InvoiceID = InvoiceIDTextBox.Text
            newRow.ProductDetailID = rdr("ProductDetailID")
            newRow.Qty = QtyLeft
            newRow.UnitID = rdr("UnitID")
            newRow.SellingPrice = toMoney(rdr("SellingPrice"))
            newRow.Amount = toMoney(rdr("Amount"))
            newRow.SalesOrderID = SONumberTextBox.Text

            InvoiceDataSet.InvoiceDetail.Rows.Add(newRow)

            Total()
        Loop
    End Sub

    Private Sub Total()
        Dim Net As Double = 0
        Dim TotalDiscountPercent As Double = 0
        Dim TotalDiscountAmount As Double = 0
        Dim i As Integer = 0

        For i = 0 To InvoiceDetailDataGridView.Rows.Count - 1
            Net = Net + Convert.ToDouble(InvoiceDetailDataGridView.Rows(i).Cells("Amount").Value)
            TotalDiscountPercent = TotalDiscountPercent + Convert.ToDouble(InvoiceDetailDataGridView.Rows(i).Cells("DiscountPercent").Value)
            TotalDiscountAmount = TotalDiscountAmount + Convert.ToDouble(InvoiceDetailDataGridView.Rows(i).Cells("DiscountAmount").Value)
        Next i

        NetTextBox.Text = toMoney(Net)
        DiscountAmountTextBox.Text = toMoney(TotalDiscountAmount)
        DiscountPercentTextBox.Text = toMoney(TotalDiscountPercent)

        TaxBaseTextBox.Text = toMoney(Net / 1.12)
        VATTextBox.Text = toMoney(Net - TaxBaseTextBox.Text)
    End Sub

    Private Sub btnSettle_Click(sender As System.Object, e As System.EventArgs) Handles btnSettle.Click
        Me.Close()
    End Sub

    Private Sub btnPay_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        InvoiceBindingNavigatorSaveItem_Click(sender, e)
    End Sub

    Private Sub InvoiceDetailDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles InvoiceDetailDataGridView.CellContentClick
        Dim dgv As DataGridView = CType(sender, DataGridView)

        If dgv.Columns(e.ColumnIndex).Name = "AddProduct" Then
            ProductLookup = New frmProductLookup

            ProductLookup.OrderType = "SalesOrder"
            ProductLookup.Show(Me)
        End If
    End Sub

    Private Sub InvoiceDetailDataGridView_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles InvoiceDetailDataGridView.CellEndEdit
        Dim SalesDetails As DataGridView = DirectCast(sender, DataGridView)

        Dim intQty As Integer
        Dim curSellingPrice As Decimal
        Dim DiscountAmount As Decimal
        Dim DiscountPercent As Decimal

        intQty = SalesDetails("Qty", e.RowIndex).Value
        curSellingPrice = SalesDetails("SellingPrice", e.RowIndex).Value

        If SalesDetails.Columns(e.ColumnIndex).Name = "DiscountPercent" Then
            DiscountPercent = SalesDetails("DiscountPercent", e.RowIndex).Value

            SalesDetails("DiscountAmount", e.RowIndex).Value = toMoney(toNumber(curSellingPrice * (DiscountPercent / 100)))
            DiscountAmount = SalesDetails("DiscountAmount", e.RowIndex).Value
        ElseIf SalesDetails.Columns(e.ColumnIndex).Name = "DiscountAmount" Then
            DiscountAmount = SalesDetails("DiscountAmount", e.RowIndex).Value

            SalesDetails("DiscountPercent", e.RowIndex).Value = toNumber(DiscountAmount / curSellingPrice * 100)

            DiscountPercent = SalesDetails("DiscountPercent", e.RowIndex).Value
        End If

        SalesDetails("Amount", e.RowIndex).Value = toMoney(intQty * curSellingPrice - DiscountAmount)

        Total()
    End Sub

    Private Sub InvoiceDetailDataGridView_CellValidating(sender As Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles InvoiceDetailDataGridView.CellValidating
        Dim SalesDetails As DataGridView = DirectCast(sender, DataGridView)

        If SalesDetails("Qty", e.RowIndex).EditedFormattedValue = "" Or SalesDetails("SellingPrice", e.RowIndex).EditedFormattedValue = "" Then
            MessageBox.Show("Please enter numeric value.", "Enter value", MessageBoxButtons.OK, MessageBoxIcon.Information)

            e.Cancel = True
        End If
    End Sub

    Private Sub ProductLookup_ProductIDSelected(ProductDetailID As Integer, Price As Double, UnitID As Integer) Handles ProductLookup.ProductIDSelected
        Dim rowNum As Integer = InvoiceDetailDataGridView.CurrentCell.RowIndex

        InvoiceDetailDataGridView(1, rowNum).Value = ProductDetailID
        InvoiceDetailDataGridView(3, rowNum).Value = UnitID
        InvoiceDetailDataGridView(4, rowNum).Value = toMoney(Price)

        InvoiceDetailDataGridView(7, rowNum).Value = toMoney(Price)

        Total()

        InvoiceDetailBindingSource.EndEdit()
    End Sub

    Private Sub EnableControls(ByVal IsEnable As Boolean)
        For Each frmControl As Control In Me.Controls
            If TypeOf frmControl Is TextBox Or TypeOf frmControl Is ComboBox Or TypeOf frmControl Is DateTimePicker Or TypeOf frmControl Is DataGridView Then
                frmControl.Enabled = IsEnable
            End If
        Next
    End Sub
End Class