Public Class frmSOLookup
    Public Event SOIDSelected(ByVal value As Integer)

    Private Sub SelectSOID(ByVal value As Integer)
        RaiseEvent SOIDSelected(value)
    End Sub

    Dim sSql As String
    Dim SOID As Integer

    Private Sub frmSOLookup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sSql = "SELECT * FROM qry_SOLookup ORDER BY SalesOrderID DESC"

        Call FillList()
    End Sub

    Private Sub lvList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvList.DoubleClick
        SOID = lvList.FocusedItem.Text

        SelectSOID(SOID)

        Me.Close()
    End Sub

    Public Sub FillList()
        With lvList
            .Clear()

            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Add("SalesOrderID", 0)
            .Columns.Add("S.O. Number", 100)
            .Columns.Add("S.O. Date", 100, HorizontalAlignment.Right)
            .Columns.Add("Customer Name", 120)
            .Columns.Add("Status", 80)
            .Columns.Add("Total", 80, HorizontalAlignment.Right)

            FillListView(lvList, GetData(sSql))
        End With
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            sSql = "SELECT * FROM qry_SOLookup ORDER BY SalesOrderID DESC"
        Else
            sSql = "SELECT * FROM qry_SOLookup WHERE SONumber Like '%" & txtSearch.Text & "%' OR CustomerName Like '%" & txtSearch.Text & "%'  ORDER BY SalesOrderID DESC"
        End If

        Call FillList()
    End Sub

    Private Sub lvList_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lvList.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            lvList_DoubleClick(sender, e)
        End If
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            btnSearch_Click(sender, e)
        End If
    End Sub
End Class