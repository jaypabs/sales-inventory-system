Option Explicit On

Public Class frmLogin
    Private JustGotFocus As Boolean = False

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReadfromXML()
        MySettingsChanger.SetConnectionString(cnString)

        FillComboBox(cboUser, "SELECT * FROM Users", "Users", "Username", "Username")
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If cboUser.Text = "" Then cboUser.Focus() : Exit Sub

        If txtPass.Text = "" Then txtPass.Focus() : Exit Sub

        Dim strPass As String

        strPass = GetFieldValue("SELECT Username,Password FROM Users WHERE Username='" & cboUser.SelectedValue & "'", "Password")

        If LCase(txtPass.Text) = LCase(strPass) Then
            With CurrUser
                .USERNAME = cboUser.Text
            End With

            Dim MainForm As New mdiMain

            MainForm.Show()
        Else
            MsgBox("Invalid password.Please try again!", MsgBoxStyle.Exclamation)
            txtPass.Focus()
        End If

        strPass = vbNullString
    End Sub

    Private Sub txtPass_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPass.Click
        Dim ClickedTextBox As TextBox = CType(sender, TextBox)

        If JustGotFocus Then
            ClickedTextBox.SelectAll()
        End If

        JustGotFocus = False
    End Sub

    Private Sub txtPass_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPass.GotFocus
        txtPass.SelectAll()

        JustGotFocus = True
    End Sub

    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = Chr(13) Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub txtPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass.TextChanged
        txtPass.SelectionStart = Len(txtPass.Text)
    End Sub

    Private Sub btnDatabaseConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDatabaseConfig.Click
        Dim DBPath As New frmDBPath

        DBPath.ShowDialog()
    End Sub

    Private Sub cboUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboUser.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPass.Focus()
        End If
    End Sub

End Class
