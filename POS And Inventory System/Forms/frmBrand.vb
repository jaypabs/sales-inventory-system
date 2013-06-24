Public Class frmBrand

    Private Sub BrandBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles BrandBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BrandBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BrandDataSet)

        MessageBox.Show("Record successfully saved.", "Saving...", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub frmBrand_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.BrandTableAdapter.Fill(Me.BrandDataSet.Brand)

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class