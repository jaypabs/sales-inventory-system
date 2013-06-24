Public Class MySettingsChanger
    Public Shared Sub SetConnectionString(ByVal cnnString As String)
        My.Settings.RunTimeConnectionString = cnnString
    End Sub
End Class