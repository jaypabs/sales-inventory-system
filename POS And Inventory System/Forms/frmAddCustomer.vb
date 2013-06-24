Public Class frmAddCustomer

    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles CustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CustomerDataSet)

    End Sub

    Private Sub frmAddCustomer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CustomerTableAdapter.Fill(Me.CustomerDataSet.Customer)

        BindingNavigatorAddNewItem.PerformClick()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        CustomerBindingNavigatorSaveItem_Click(sender, e)

        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class