Option Explicit On

Public Class frmDBPath
    Inherits Form

    Dim strFilename As String

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        SavetoXML(txtDatabaseName.Text)

        Me.Close()

        Dim Login As New frmLogin

        Login.ShowDialog()

    End Sub

    Private Sub frmDBPath_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDatabaseName.Text = Database
    End Sub

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        Try
            With odlgDatabase
                .CheckFileExists = True
                .CheckPathExists = True
                .DefaultExt = "mdb"
                .DereferenceLinks = True
                .Filter = _
                "Database files (*.mdb)|*.mdb"
                .Multiselect = False
                .RestoreDirectory = True
                .ShowHelp = True
                .ShowReadOnly = False
                .ReadOnlyChecked = False
                .Title = "Select a database to open"
                .ValidateNames = True

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Try
                        txtDatabaseName.Text = .FileName
                    Catch fileException As Exception
                        Throw fileException
                    End Try
                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
End Class