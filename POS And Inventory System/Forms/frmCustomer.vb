Public Class frmCustomer
    Public Property CustomerID As Integer

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

    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles CustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CustomerDataSet)

        MessageBox.Show("Record successfully saved.", "Saving...", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub frmCustomer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CustomerTableAdapter.Fill(Me.CustomerDataSet.Customer)

        If State = FormState.adStateAddMode Then
            BindingNavigatorAddNewItem.PerformClick()
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class