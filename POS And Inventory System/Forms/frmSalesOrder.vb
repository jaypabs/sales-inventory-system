Public Class frmSalesOrder
    Public Property SalesOrderID As Integer
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

    Private Sub SalesOrderBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles SalesOrderBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SalesOrderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SalesOrderDataSet)

        MessageBox.Show("Record successfully saved.", "Saving...", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SalesOrder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Qry_ProductLookupTableAdapter.Fill(Me.ProductLookupDataSet.qry_ProductLookup)
        Me.Qry_CustomerLookupTableAdapter.Fill(Me.CustomerLookupDataSet.qry_CustomerLookup)

        If State = FormState.adStateAddMode Then
            Me.SalesOrderTableAdapter.Fill(Me.SalesOrderDataSet.SalesOrder)
            Me.SalesOrderDetailTableAdapter.Fill(Me.SalesOrderDataSet.SalesOrderDetail)

            BindingNavigatorAddNewItem.PerformClick()

            SONumberTextBox.Text = SalesOrderIDTextBox.Text
            CashierTextBox.Text = CurrUser.USERNAME
            CreatedByTextBox.Text = CurrUser.USERNAME
            DateCreatedDateTimePicker.Value = Date.Today
            OrderStatusComboBox.Items.Clear()
            OrderStatusComboBox.Items.Add("For Approval")
            OrderStatusComboBox.Items.Add("Approved")
            OrderStatusComboBox.Text = "For Approval"
        Else
            Me.SalesOrderTableAdapter.FillBy(Me.SalesOrderDataSet.SalesOrder, SalesOrderID)
            Me.SalesOrderDetailTableAdapter.FillBy(Me.SalesOrderDataSet.SalesOrderDetail, SalesOrderID)

            If OrderStatusComboBox.Text = "For Approval" Then
                EnableControls(True)
            Else
                EnableControls(False)
                btnSave.Visible = False
                SalesOrderDetailDataGridView.Columns("AddProduct").Visible = False
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub SalesOrderDetailDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SalesOrderDetailDataGridView.CellContentClick
        Dim dgv As DataGridView = CType(sender, DataGridView)

        If dgv.Columns(e.ColumnIndex).Name = "AddProduct" Then
            ProductLookup = New frmProductLookup

            ProductLookup.OrderType = "SalesOrder"
            ProductLookup.Show(Me)
        End If
    End Sub

    Private Sub ProductLookup_ProductIDSelected(ByVal ProductDetailID As Integer, ByVal SellingPrice As Double, ByVal UnitID As Integer) Handles ProductLookup.ProductIDSelected
        Dim rowNum As Integer = SalesOrderDetailDataGridView.CurrentCell.RowIndex

        SalesOrderDetailDataGridView(1, rowNum).Value = ProductDetailID
        SalesOrderDetailDataGridView(3, rowNum).Value = UnitID
        SalesOrderDetailDataGridView(5, rowNum).Value = toMoney(SellingPrice)

        SalesOrderDetailDataGridView(8, rowNum).Value = toMoney(SellingPrice)

        Total()

        SalesOrderDetailBindingSource.EndEdit()
    End Sub

    Private Sub Total()
        Dim Net As Double = 0
        Dim TotalDiscountPercent As Double = 0
        Dim TotalDiscountAmount As Double = 0
        Dim i As Integer = 0

        For i = 0 To SalesOrderDetailDataGridView.Rows.Count - 1
            Net = Net + Convert.ToDouble(SalesOrderDetailDataGridView.Rows(i).Cells("Amount").Value)
            TotalDiscountPercent = TotalDiscountPercent + Convert.ToDouble(SalesOrderDetailDataGridView.Rows(i).Cells("DiscountPercent").Value)
            TotalDiscountAmount = TotalDiscountAmount + Convert.ToDouble(SalesOrderDetailDataGridView.Rows(i).Cells("DiscountAmount").Value)
        Next i

        NetTextBox.Text = toMoney(Net)
        DiscountAmountTextBox.Text = toMoney(TotalDiscountAmount)
        DiscountPercentTextBox.Text = toMoney(TotalDiscountPercent)
    End Sub

    Private Sub SalesOrderDetailDataGridView_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SalesOrderDetailDataGridView.CellEndEdit
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

    Private Sub SalesOrderDetailDataGridView_CellValidating(sender As Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles SalesOrderDetailDataGridView.CellValidating
        Dim SalesDetails As DataGridView = DirectCast(sender, DataGridView)

        If SalesDetails("Qty", e.RowIndex).EditedFormattedValue = "" Or SalesDetails("SellingPrice", e.RowIndex).EditedFormattedValue = "" Then
            MessageBox.Show("Please enter numeric value.", "Enter value", MessageBoxButtons.OK, MessageBoxIcon.Information)

            e.Cancel = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        SalesOrderBindingNavigatorSaveItem_Click(sender, e)
    End Sub

    Private Sub EnableControls(ByVal IsEnable As Boolean)
        For Each frmControl As Control In Me.Controls
            If TypeOf frmControl Is TextBox Or TypeOf frmControl Is ComboBox Or TypeOf frmControl Is DateTimePicker Or TypeOf frmControl Is DataGridView Then
                frmControl.Enabled = IsEnable
            End If
        Next
    End Sub
End Class