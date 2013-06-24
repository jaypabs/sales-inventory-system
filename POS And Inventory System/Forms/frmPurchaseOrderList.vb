Imports System
Imports System.Data.OleDb

Public Class frmPurchaseOrderList
    Private da As OleDbDataAdapter
    Private ds As DataSet
    Private dtSource As DataTable
    Private PageCount As Integer
    Private maxRec As Integer
    Private pageSize As Integer
    Private currentPage As Integer
    Private recNo As Integer

    Dim sSql As String
    Dim PurchaseOrderID As Integer

    Private Sub frmPurchaseOrderList_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            sSql = "SELECT PurchaseOrderID, [Name], Address, SubTotal, DiscountAmount, NetAmount " _
                    & "FROM PurchaseOrder INNER JOIN Supplier ON PurchaseOrder.SupplierID = Supplier.SupplierID;"

            LoadDS(sSql)

            FillGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadDS(ByVal sSQL As String)
        'Open Connection.
        Dim conn As OleDbConnection = New OleDbConnection(cnString)

        'Set the DataAdapter's query.
        da = New OleDbDataAdapter(sSQL, conn)
        ds = New DataSet()

        ' Fill the DataSet.
        da.Fill(ds, "PurchaseOrder")

        ' Set the source table.
        dtSource = ds.Tables("PurchaseOrder")
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim PurchaseOrder As New frmPurchaseOrder

        PurchaseOrder.getFormState = modGlobal.FormState.adStateAddMode

        PurchaseOrder.ShowDialog()

        LoadDS(sSql)

        FillGrid()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            sSql = "SELECT PurchaseOrderID, [Name], Address, SubTotal, DiscountAmount, NetAmount " _
                    & "FROM PurchaseOrder INNER JOIN Supplier ON PurchaseOrder.SupplierID = Supplier.SupplierID;"
        Else
            sSql = "SELECT PurchaseOrderID, [Name], Address, SubTotal, DiscountAmount, NetAmount " _
                    & "FROM PurchaseOrder INNER JOIN Supplier ON PurchaseOrder.SupplierID = Supplier.SupplierID; WHERE [Name] Like '%" & txtSearch.Text & "%' OR [Address] Like '%" & txtSearch.Text & "%'"
        End If

        LoadDS(sSql)

        FillGrid()
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Chr(13) Then
            btnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub btnNextPage_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles BindingNavigatorMoveNextItem.Click

        'If the user did not click the "Fill Grid" button then Return
        If Not CheckFillButton() Then Return

        'Check if the user clicked the "Fill Grid" button.
        If pageSize = 0 Then
            MessageBox.Show("Set the Page Size, and then click the ""Fill Grid"" button!")
            Return
        End If

        currentPage = currentPage + 1

        If currentPage > PageCount Then
            currentPage = PageCount

            'Check if you are already at the last page.
            If recNo = maxRec Then
                MessageBox.Show("You are at the Last Page!")
                Return
            End If
        End If

        LoadPage()
    End Sub

    Private Sub btnPreviousPage_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles BindingNavigatorMovePreviousItem.Click

        If Not CheckFillButton() Then Return

        currentPage = currentPage - 1

        'Check if you are already at the first page.
        If currentPage < 1 Then
            MessageBox.Show("You are at the First Page!")
            currentPage = 1
            Return
        Else
            recNo = pageSize * (currentPage - 1)
        End If

        LoadPage()
    End Sub

    Private Sub LoadPage()
        Dim i As Integer
        Dim startRec As Integer
        Dim endRec As Integer
        Dim dtTemp As DataTable

        'Duplicate or clone the source table to create the temporary table.
        dtTemp = dtSource.Clone

        If currentPage = PageCount Then
            endRec = maxRec
        Else
            endRec = pageSize * currentPage
        End If

        startRec = recNo

        If dtSource.Rows.Count > 0 Then
            'Copy the rows from the source table to fill the temporary table.
            For i = startRec To endRec - 1
                dtTemp.ImportRow(dtSource.Rows(i))
                recNo = recNo + 1
            Next
        End If

        dgvList.DataSource = dtTemp

        DisplayPageInfo()
    End Sub

    Private Sub btnFirstPage_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles BindingNavigatorMoveFirstItem.Click

        If Not CheckFillButton() Then Return

        ' Check if you are already at the first page.
        If currentPage = 1 Then
            MessageBox.Show("You are at the First Page!")
            Return
        End If

        currentPage = 1
        recNo = 0

        LoadPage()
    End Sub

    Private Sub btnLastPage_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles BindingNavigatorMoveLastItem.Click

        If Not CheckFillButton() Then Return

        ' Check if you are already at the last page.
        If recNo = maxRec Then
            MessageBox.Show("You are at the Last Page!")
            Return
        End If

        currentPage = PageCount

        recNo = pageSize * (currentPage - 1)

        LoadPage()
    End Sub

    Private Sub DisplayPageInfo()
        BindingNavigatorPositionItem.Text = currentPage.ToString
        BindingNavigatorCountItem.Text = PageCount.ToString
    End Sub

    Private Sub FillGrid()

        'Set the start and max records. 
        pageSize = 20 'txtPageSize.Text
        maxRec = dtSource.Rows.Count
        PageCount = maxRec \ pageSize

        ' Adjust the page number if the last page contains a partial page.
        If (maxRec Mod pageSize) > 0 Then
            PageCount = PageCount + 1
        End If

        'Initial seeings
        currentPage = 1
        recNo = 0

        ' Display the content of the current page.
        LoadPage()
    End Sub

    Private Function CheckFillButton() As Boolean
        'Check if the user clicks the "Fill Grid" button.
        If pageSize = 0 Then
            MessageBox.Show("Set the Page Size, and then click the ""Fill Grid"" button!")
            CheckFillButton = False
        Else
            CheckFillButton = True
        End If
    End Function

    Private Sub dgvList_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvList.CellDoubleClick
        Dim i As Integer

        i = dgvList.CurrentRow.Index

        PurchaseOrderID = dgvList.Item(0, i).Value

        Dim PurchaseOrder As New frmPurchaseOrder

        With PurchaseOrder
            .getFormState = modGlobal.FormState.adStateEditMode
            .PurchaseOrderID = PurchaseOrderID

            .ShowDialog()

            LoadDS(sSql)
            FillGrid()
        End With
    End Sub
End Class