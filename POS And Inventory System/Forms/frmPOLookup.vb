Public Class frmPOLookup
    Public Event POIDSelected(ByVal value As Integer)

    Private Sub SelectPOID(ByVal value As Integer)
        RaiseEvent POIDSelected(value)
    End Sub

    Dim sSql As String
    Dim POID As Integer

    Private Sub frmPOLookup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sSql = "SELECT * FROM qry_POLookup ORDER BY PurchaseOrderID DESC"

        Call FillList()
    End Sub

    Private Sub lvList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvList.DoubleClick
        POID = lvList.FocusedItem.Text

        SelectPOID(POID)

        Me.Close()
    End Sub

    Public Sub FillList()
        With lvList
            .Clear()

            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Add("PurchaseOrderID", 0)
            .Columns.Add("P.O. Number", 100)
            .Columns.Add("P.O. Date", 100, HorizontalAlignment.Right)
            .Columns.Add("Supplier Name", 120)
            .Columns.Add("Status", 80)
            .Columns.Add("Total", 80, HorizontalAlignment.Right)

            FillListView(lvList, GetData(sSql))
        End With
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            sSql = "SELECT * FROM qry_POLookup ORDER BY PurchaseOrderID DESC"
        Else
            sSql = "SELECT * FROM qry_POLookup WHERE PONumber Like '%" & txtSearch.Text & "%' OR SupplierName Like '%" & txtSearch.Text & "%'  ORDER BY PurchaseOrderID DESC"
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