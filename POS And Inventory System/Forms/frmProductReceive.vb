Imports System.Data.OleDb

Public Class frmProductReceive
    Public Property ProductReceiveID As Integer
    Private WithEvents POLookup As frmPOLookup
    Private WithEvents ProductLookup As frmProductLookup

    Dim State As FormState
    Dim conn As New OleDbConnection(My.Settings.DataConnectionString)

    Public WriteOnly Property getFormState()
        Set(ByVal value)
            State = value
        End Set
    End Property

    Private Sub ProductReceiveBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ProductReceiveBindingNavigatorSaveItem.Click
        Try
            conn.Open()

            Dim intProductDetailID As Integer
            Dim intQtyRecd As Integer
            Dim strSQL As String
            Dim dt As DataTable
            Dim totQtyRecdPO As Integer 'From purchase order details table
            Dim totQtyRecd As Integer 'Total Qty Received - ProductReceive table
            Dim PurchaseOrderID As Integer = GetFieldValue(String.Format("SELECT PurchaseOrderID FROM PurchaseOrder WHERE PONumber = {0}", PONumberTextBox.Text), "PurchaseOrderID")


            Me.TableAdapterManager.Connection = conn

            Dim command As OleDbCommand = conn.CreateCommand
            command.Connection = conn

            Me.Validate()
            Me.ProductReceiveBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ProductReceiveDataSet)

            For Each row As DataGridViewRow In Me.ProductReceiveDetailDataGridView.Rows
                intQtyRecd = row.Cells(Me.Qty.Index).Value
                intProductDetailID = row.Cells(Me.ProductDetailID.Index).Value

                'Receive Item from PO
                If PONumberTextBox.Text <> "" And ReceiveStatusComboBox.Text = "Approved" And intProductDetailID <> 0 Then
                    'Get the total item recieve. Including the previous item recieved.
                    strSQL = String.Format("SELECT SUM(Qty) AS TotalQtyRecd FROM ProductReceiveDetail WHERE PurchaseOrderID = {0} AND ProductDetailID  = {1}", PurchaseOrderID, intProductDetailID)

                    dt = GetDataTable(conn, strSQL)

                    Dim rowDetail As DataRow

                    For Each rowDetail In dt.Rows
                        If IsDBNull(rowDetail("TotalQtyRecd")) Then
                            totQtyRecd = 0
                        Else
                            totQtyRecd = rowDetail("TotalQtyRecd")
                        End If
                    Next rowDetail

                    'Get the total product recieved.
                    strSQL = String.Format("SELECT QtyRecd FROM PurchaseOrderDetail WHERE PurchaseOrderID = {0} AND ProductDetailID  = {1}", PurchaseOrderID, intProductDetailID)

                    dt = GetDataTable(conn, strSQL)

                    For Each rowDetail In dt.Rows
                        If IsDBNull(rowDetail("QtyRecd")) Then
                            totQtyRecdPO = 0
                        Else
                            totQtyRecdPO = rowDetail("QtyRecd")
                        End If
                    Next rowDetail

                    'Item received should not exceed on PO
                    'If totQtyRecd > totQtyRecdPO Then
                    '    MsgBox("The number of Item Receive should not exceed as declared in P.O.", MsgBoxStyle.Exclamation)

                    '    Exit Sub
                    'End If

                    If totQtyRecd < totQtyRecdPO Or totQtyRecd = 0 Then
                        'Set status to 3 = Received (Incomplete)
                        ExecNonQueryTrans(conn, "UPDATE PurchaseOrder SET OrderStatus = 'Received (Incomplete)' WHERE PurchaseOrderID = " & PurchaseOrderID)
                    Else
                        'Set status to 4 = Received (Complete)
                        ExecNonQueryTrans(conn, "UPDATE PurchaseOrder SET OrderStatus = 'Received (Complete)' WHERE PurchaseOrderID = " & PurchaseOrderID)
                    End If

                    'Add Qty Received in PurchaseOrderDetail table
                    command.CommandText = String.Format("UPDATE PurchaseOrderDetail SET QtyRecd = QtyRecd + {0} WHERE PurchaseOrderID = {1} AND ProductDetailID  = {2}", intQtyRecd, PurchaseOrderID, intProductDetailID)
                    command.ExecuteNonQuery()

                    'Deduct PO Qty in ProductDetail table
                    command.CommandText = String.Format("UPDATE ProductDetail SET QtyOnPO = QtyOnPO - {0}  WHERE ProductDetailID  = {1}", intQtyRecd, intProductDetailID)
                    'command.CommandText = String.Format("UPDATE Product SET POQTY = POQTY - {0}  WHERE ProductID  = {1}", intQtyRecd, intProductDetailID)
                    command.ExecuteNonQuery()
                End If

                If ReceiveStatusComboBox.Text = "Approved" And intProductDetailID <> 0 Then
                    'Add received Item to Items table
                    ExecNonQueryTrans(conn, String.Format("UPDATE ProductDetail SET QtyOnHand = QtyOnHand + {0} WHERE ProductDetailID  = {1}", intQtyRecd, intProductDetailID))

                End If
            Next row

            MessageBox.Show("Record successfuly saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Saving", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmProductReceive_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.Qry_ProductLookupTableAdapter.Fill(Me.ProductLookupDataSet.qry_ProductLookup)


        If State = FormState.adStateAddMode Then
            Me.ProductReceiveTableAdapter.Fill(Me.ProductReceiveDataSet.ProductReceive)
            Me.ProductReceiveDetailTableAdapter.Fill(Me.ProductReceiveDataSet.ProductReceiveDetail)

            BindingNavigatorAddNewItem.PerformClick()

            ReceiveStatusComboBox.Text = "For Approval"
        Else
            Me.ProductReceiveTableAdapter.FillBy(Me.ProductReceiveDataSet.ProductReceive, ProductReceiveID)
            Me.ProductReceiveDetailTableAdapter.FillBy(Me.ProductReceiveDataSet.ProductReceiveDetail, ProductReceiveID)

            If ReceiveStatusComboBox.Text = "For Approval" Then
                EnableControls(True)
            Else
                EnableControls(False)
                btnSave.Visible = False
                ProductReceiveDetailDataGridView.Columns("AddProduct").Visible = False
            End If
        End If
    End Sub

    Private Sub btnSOLookup_Click(sender As System.Object, e As System.EventArgs) Handles btnSOLookup.Click
        POLookup = New frmPOLookup

        POLookup.ShowDialog()
    End Sub

    Private Sub POLookup_POIDSelected(value As Integer) Handles POLookup.POIDSelected
        Dim strSQL As String = "SELECT PONumber, SupplierID " & _
        "FROM PurchaseOrder WHERE PurchaseOrderID = " & value

        conn.Open()

        Dim cmd As OleDbCommand = New OleDbCommand(strSQL, conn)
        'create data reader
        Dim rdr As OleDbDataReader = cmd.ExecuteReader

        rdr.Read()

        Me.PONumberTextBox.Text = rdr("PONumber")
        Me.SupplierIDComboBox.SelectedValue = rdr("SupplierID")

        Me.PONumberTextBox.Focus()

        conn.Close()

        AddPOItem(value)

        ProductReceiveDetailDataGridView.Columns("AddProduct").Visible = False
    End Sub

    Private Sub AddPOItem(ByVal PurchaseOrderID As Integer)
        Dim strSQL As String

        conn.Open()

        strSQL = "SELECT ProductDetailID, SupplierPrice, Qty, QtyRecd, Amount " & _
                "FROM PurchaseOrderDetail WHERE PurchaseOrderID = " & PurchaseOrderID

        Dim cmd As OleDbCommand = New OleDbCommand(strSQL, conn)
        'create data reader
        Dim rdr As OleDbDataReader = cmd.ExecuteReader

        Do While rdr.Read()
            Me.ProductReceiveBindingSource.EndEdit()

            Dim newRow As ProductReceiveDataSet.ProductReceiveDetailRow = ProductReceiveDataSet.ProductReceiveDetail.NewProductReceiveDetailRow

            newRow.ProductReceiveID = Me.ProductReceiveIDTextBox.Text
            newRow.ProductDetailID = rdr("ProductDetailID")
            newRow.Qty = rdr("Qty") - rdr("QtyRecd")
            newRow.SupplierPrice = toMoney(rdr("SupplierPrice"))
            newRow.Amount = toMoney(rdr("Amount"))

            ProductReceiveDataSet.ProductReceiveDetail.Rows.Add(newRow)

            Total()
        Loop
    End Sub

    Private Sub Total()
        Dim Subtotal As Double = 0
        Dim TotalDiscountPercent As Double = 0
        Dim TotalDiscountAmount As Double = 0
        Dim i As Integer = 0

        For i = 0 To ProductReceiveDetailDataGridView.Rows.Count - 1
            Subtotal = Subtotal + Convert.ToDouble(ProductReceiveDetailDataGridView.Rows(i).Cells("Amount").Value)
        Next i

        SubTotalTextBox.Text = toMoney(Subtotal)
        DiscountAmountTextBox.Text = toMoney(TotalDiscountAmount)
        DiscountPercentTextBox.Text = toMoney(TotalDiscountPercent)

        NetTextBox.Text = toMoney(toNumber(SubTotalTextBox.Text) - toNumber(DiscountAmountTextBox.Text))
    End Sub

    Private Sub ProductReceiveDetailDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductReceiveDetailDataGridView.CellContentClick
        Dim dgv As DataGridView = CType(sender, DataGridView)

        If dgv.Columns(e.ColumnIndex).Name = "AddProduct" Then
            ProductLookup = New frmProductLookup

            ProductLookup.Show(Me)
        End If
    End Sub

    Private Sub ProductLookup_ProductIDSelected(ProductDetailID As Integer, Price As Double, UnitID As Integer) Handles ProductLookup.ProductIDSelected
        Dim rowNum As Integer = ProductReceiveDetailDataGridView.CurrentCell.RowIndex

        ProductReceiveDetailDataGridView(1, rowNum).Value = ProductDetailID
        ProductReceiveDetailDataGridView(2, rowNum).Value = UnitID
        ProductReceiveDetailDataGridView(4, rowNum).Value = toMoney(Price)

        ProductReceiveDetailDataGridView(5, rowNum).Value = toMoney(Price)

        Total()

        ProductReceiveDetailDataGridView.EndEdit()
    End Sub

    Private Sub ProductReceiveDetailDataGridView_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductReceiveDetailDataGridView.CellEndEdit
        Dim PurchaseDetails As DataGridView = DirectCast(sender, DataGridView)

        Dim intQty As Integer
        Dim curSellingPrice As Decimal

        intQty = PurchaseDetails("Qty", e.RowIndex).Value
        curSellingPrice = PurchaseDetails("SupplierPrice", e.RowIndex).Value

        PurchaseDetails("Amount", e.RowIndex).Value = toMoney(intQty * curSellingPrice)

        Total()
    End Sub

    Private Sub ProductReceiveDetailDataGridView_CellValidating(sender As Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles ProductReceiveDetailDataGridView.CellValidating
        Dim PurchaseDetails As DataGridView = DirectCast(sender, DataGridView)

        If PurchaseDetails("Qty", e.RowIndex).EditedFormattedValue = "" Or PurchaseDetails("SupplierPrice", e.RowIndex).EditedFormattedValue = "" Then
            MessageBox.Show("Please enter numeric value.", "Enter value", MessageBoxButtons.OK, MessageBoxIcon.Information)

            e.Cancel = True
        End If
    End Sub

    Private Sub EnableControls(ByVal IsEnable As Boolean)
        For Each frmControl As Control In Me.Controls
            If TypeOf frmControl Is TextBox Or TypeOf frmControl Is ComboBox Or TypeOf frmControl Is DateTimePicker Or TypeOf frmControl Is DataGridView Then
                frmControl.Enabled = IsEnable
            End If
        Next
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        ProductReceiveBindingNavigatorSaveItem_Click(sender, e)
    End Sub
End Class