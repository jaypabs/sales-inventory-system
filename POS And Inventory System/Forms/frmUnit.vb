Public Class frmUnit

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub UnitBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles UnitBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UnitBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UnitDataSet)

        MessageBox.Show("Record successfully saved.", "Saving...", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub frmUnit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)

    End Sub
End Class