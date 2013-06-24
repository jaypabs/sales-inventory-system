Public Class frmCategory

    Private Sub CategoryBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles CategoryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CategoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CategoryDataSet)

        MessageBox.Show("Record successfully saved.", "Saving...", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub frmCategory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CategoryTableAdapter.Fill(Me.CategoryDataSet.Category)
        Me.SubCategoryTableAdapter.Fill(Me.CategoryDataSet.SubCategory)

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub SubCategoryDataGridView_Enter(sender As Object, e As System.EventArgs) Handles SubCategoryDataGridView.Enter
        Me.CategoryBindingSource.EndEdit()
    End Sub
End Class