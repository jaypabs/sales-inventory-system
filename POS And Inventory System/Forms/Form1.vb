Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles ComboBox1.SelectedValueChanged

    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted

    End Sub
End Class
