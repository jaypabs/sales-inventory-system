Public Class frmProductLookup
    Public Property OrderType As String

    Public Event ProductIDSelected(ByVal ProductDetailID As Integer, ByVal Price As Double, ByVal UnitID As Integer)

    Dim sSql As String
    Dim intProductDetailID As Integer

    Private Sub SelectItemID(ByVal ProductDetailID As Integer, ByVal Price As Double, ByVal UnitID As Integer)
        RaiseEvent ProductIDSelected(ProductDetailID, Price, UnitID)
    End Sub

    Private Sub frmProductLookup_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        sSql = "SELECT ProductDetailID, ProductName, Description, Category, Brand, UOM, QtyOnHand, SellingPrice, SupplierPrice, UnitID FROM qry_ProductLookup ORDER BY Description ASC"

        Call FillList()
    End Sub

    Private Sub lvList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvList.DoubleClick
        Dim Price As Double
        Dim UnitID As Integer

        intProductDetailID = lvList.FocusedItem.Text

        If OrderType = "SalesOrder" Then
            Price = lvList.FocusedItem.SubItems(7).Text
        Else 'PurchaseOrder
            Price = lvList.FocusedItem.SubItems(8).Text
        End If

        UnitID = lvList.FocusedItem.SubItems(9).Text

        SelectItemID(intProductDetailID, Price, UnitID)

        Me.Close()
    End Sub

    Public Sub FillList()
        With lvList
            .Clear()

            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Add("ProductDetailID", 0)
            .Columns.Add("Product Name", 150)
            .Columns.Add("Description", 150)
            .Columns.Add("Category", 100)
            .Columns.Add("Brand", 100)
            .Columns.Add("U/M", 80)
            .Columns.Add("Qty On Hand", 100, HorizontalAlignment.Right)
            .Columns.Add("Selling Price", 100, HorizontalAlignment.Right)
            .Columns.Add("Supplier Price", 100, HorizontalAlignment.Right)
            .Columns.Add("Unit ID", 0, HorizontalAlignment.Right)

            FillListView(lvList, GetData(sSql))
        End With
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            sSql = "SELECT ProductDetailID, Category, Brand, Description, UOM, QtyOnHand, SellingPrice, SupplierPrice, UnitID FROM qry_ProductLookup ORDER BY Description ASC"
        Else
            sSql = "SELECT ProductDetailID, Category, Brand, Description, UOM, QtyOnHand, SellingPrice, SupplierPrice, UnitID FROM qry_ProductLookup WHERE Description Like '%" & txtSearch.Text & "%' ORDER BY Description ASC"
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