Public Class frmPurchaseOrder
    Public Property PurchaseOrderID As Integer
    Private WithEvents ProductLookup As frmProductLookup
    Dim State As FormState

    Public WriteOnly Property getFormState()
        Set(ByVal value)
            State = value
        End Set
    End Property

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case msg.WParam.ToInt32()
            Case 13 ' enter Key 
                If TypeOf Me.ActiveControl Is TextBox Then
                    SendKeys.Send("{Tab}")
                    Return True
                End If
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function 'ProcessCmdKey 

    Private Sub PurchaseOrderBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles PurchaseOrderBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PurchaseOrderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PurchaseOrderDataSet)

        MessageBox.Show("Record successfully saved.", "Saving...", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub frmPurchaseOrder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.Qry_ProductLookupTableAdapter.Fill(Me.ProductLookupDataSet.qry_ProductLookup)

        If State = FormState.adStateAddMode Then
            Me.PurchaseOrderTableAdapter.Fill(Me.PurchaseOrderDataSet.PurchaseOrder)
            Me.PurchaseOrderDetailTableAdapter.Fill(Me.PurchaseOrderDataSet.PurchaseOrderDetail)

            BindingNavigatorAddNewItem.PerformClick()

            PONumberTextBox.Text = PurchaseOrderIDTextBox.Text
            CreatedByTextBox.Text = CurrUser.USERNAME
            DateCreatedDateTimePicker.Value = Date.Today
            OrderStatusComboBox.Items.Clear()
            OrderStatusComboBox.Items.Add("For Approval")
            OrderStatusComboBox.Items.Add("Approved")
            OrderStatusComboBox.Text = "For Approval"
        Else
            Me.PurchaseOrderTableAdapter.FillBy(Me.PurchaseOrderDataSet.PurchaseOrder, PurchaseOrderID)
            Me.PurchaseOrderDetailTableAdapter.FillBy(Me.PurchaseOrderDataSet.PurchaseOrderDetail, PurchaseOrderID)

            If OrderStatusComboBox.Text = "For Approval" Then
                EnableControls(True)
            Else
                EnableControls(False)
                btnSave.Visible = False
                PurchaseOrderDetailDataGridView.Columns("AddProduct").Visible = False
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub PurchaseOrderDetailDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PurchaseOrderDetailDataGridView.CellContentClick
        Dim dgv As DataGridView = CType(sender, DataGridView)

        If dgv.Columns(e.ColumnIndex).Name = "AddProduct" Then
            ProductLookup = New frmProductLookup

            ProductLookup.Show(Me)
        End If
    End Sub

    Private Sub ProductLookup_ProductIDSelected(ByVal ProductDetailID As Integer, ByVal SupplierPrice As Double, ByVal UnitID As Integer) Handles ProductLookup.ProductIDSelected
        Dim rowNum As Integer = PurchaseOrderDetailDataGridView.CurrentCell.RowIndex

        PurchaseOrderDetailDataGridView(1, rowNum).Value = ProductDetailID
        PurchaseOrderDetailDataGridView(3, rowNum).Value = UnitID
        PurchaseOrderDetailDataGridView(5, rowNum).Value = toMoney(SupplierPrice)

        PurchaseOrderDetailDataGridView(6, rowNum).Value = toMoney(SupplierPrice)

        Total()

        PurchaseOrderDetailBindingSource.EndEdit()
    End Sub

    Private Sub Total()
        Dim Subtotal As Double = 0
        Dim TotalDiscountPercent As Double = 0
        Dim TotalDiscountAmount As Double = 0
        Dim i As Integer = 0

        For i = 0 To PurchaseOrderDetailDataGridView.Rows.Count - 1
            Subtotal = Subtotal + Convert.ToDouble(PurchaseOrderDetailDataGridView.Rows(i).Cells("Amount").Value)
       Next i

        SubTotalTextBox.Text = toMoney(Subtotal)
        DiscountAmountTextBox.Text = toMoney(TotalDiscountAmount)
        DiscountPercentTextBox.Text = toMoney(TotalDiscountPercent)

        NetAmountTextBox.Text = toMoney(toNumber(SubTotalTextBox.Text) - toNumber(DiscountAmountTextBox.Text))
    End Sub

    Private Sub PurchaseOrderDetailDataGridView_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PurchaseOrderDetailDataGridView.CellEndEdit
        Dim PurchaseDetails As DataGridView = DirectCast(sender, DataGridView)

        Dim intQty As Integer
        Dim curSellingPrice As Decimal

        intQty = PurchaseDetails("Qty", e.RowIndex).Value
        curSellingPrice = PurchaseDetails("SupplierPrice", e.RowIndex).Value

        PurchaseDetails("Amount", e.RowIndex).Value = toMoney(intQty * curSellingPrice)

        Total()
    End Sub

    Private Sub PurchaseOrderDetailDataGridView_CellValidating(sender As Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles PurchaseOrderDetailDataGridView.CellValidating
        Dim PurchaseDetails As DataGridView = DirectCast(sender, DataGridView)

        If PurchaseDetails("Qty", e.RowIndex).EditedFormattedValue = "" Or PurchaseDetails("SupplierPrice", e.RowIndex).EditedFormattedValue = "" Then
            MessageBox.Show("Please enter numeric value.", "Enter value", MessageBoxButtons.OK, MessageBoxIcon.Information)

            e.Cancel = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        PurchaseOrderBindingNavigatorSaveItem_Click(sender, e)
    End Sub

    Private Sub EnableControls(ByVal IsEnable As Boolean)
        For Each frmControl As Control In Me.Controls
            If TypeOf frmControl Is TextBox Or TypeOf frmControl Is ComboBox Or TypeOf frmControl Is DateTimePicker Or TypeOf frmControl Is DataGridView Then
                frmControl.Enabled = IsEnable
            End If
        Next
    End Sub
End Class