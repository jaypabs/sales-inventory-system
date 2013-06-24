Public Class frmProduct
    Public Property ProductID As Integer

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

    Private Sub ProductBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ProductBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProductDataSet)

        MessageBox.Show("Record successfully saved.", "Saving...", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub frmProduct_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UnitDataSet.Unit' table. You can move, or remove it, as needed.
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.BrandTableAdapter.Fill(Me.BrandDataSet.Brand)
        Me.SubCategoryTableAdapter.Fill(Me.CategoryDataSet.SubCategory)
        Me.CategoryTableAdapter.Fill(Me.CategoryDataSet.Category)
        Me.ItemTypeTableAdapter.Fill(Me.ItemTypeDataSet.ItemType)
        Me.ProductTableAdapter.Fill(Me.ProductDataSet.Product)
        Me.ProductDetailTableAdapter.Fill(Me.ProductDataSet.ProductDetail)

        If State = FormState.adStateAddMode Then
            BindingNavigatorAddNewItem.PerformClick()
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ItemTypeIDComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ItemTypeIDComboBox.SelectedIndexChanged
        Select Case ItemTypeIDComboBox.SelectedValue
            Case 1
                ProductDetailDataGridView.Columns("OrderNo").Visible = False
                ProductDetailDataGridView.Columns("QtyperUnit").Visible = False
            Case 2
                ProductDetailDataGridView.Columns("OrderNo").Visible = True
                ProductDetailDataGridView.Columns("QtyperUnit").Visible = True
        End Select
    End Sub
End Class