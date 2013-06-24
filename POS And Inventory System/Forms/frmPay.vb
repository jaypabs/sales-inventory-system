Public Class frmPay
    Public Event AmountPaid(ByVal Amount As Double, PaymentType As String)

    Private nonNumberEntered As Boolean = False

    Private Sub txtAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAmount.KeyDown
        nonNumberEntered = False

        If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
            If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                If e.KeyCode <> Keys.Back Then
                    nonNumberEntered = True
                End If
            End If
        End If
    End Sub

    Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        If nonNumberEntered = True Then
            e.Handled = True
        End If

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            btnOK_Click(sender, e)
        End If
    End Sub

    Private Sub AmountReceive(ByVal Amount As Double)
        Dim PaymentType As String

        If radCash.Checked = True Then
            PaymentType = "Cash"
        Else
            PaymentType = "Check"
        End If

        RaiseEvent AmountPaid(Amount, PaymentType)
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtAmount.Text >= 0 Then
            AmountReceive(txtAmount.Text)

            Me.Close()
        Else
            MsgBox("Please enter amount.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtAmount_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmount.Validated
        txtAmount.Text = toMoney(toNumber(txtAmount.Text))
    End Sub
End Class