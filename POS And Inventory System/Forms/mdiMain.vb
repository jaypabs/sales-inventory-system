Imports System.Windows.Forms

Public Class mdiMain

    Private Sub frmMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub mdiMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        frmLogin.Hide()
    End Sub

    Private Sub EmployeeListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmployeeListToolStripMenuItem.Click
        Dim f As Form = Application.OpenForms.Item("frmEmployeeList")

        If f Is Nothing Then
            Dim EmployeeList As New frmEmployeeList

            EmployeeList.StartPosition = FormStartPosition.CenterScreen
            EmployeeList.MdiParent = Me
            EmployeeList.Show()
        Else
            f.BringToFront()
        End If
    End Sub

    Private Sub CustomerListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CustomerListToolStripMenuItem.Click
        Dim f As Form = Application.OpenForms.Item("frmCustomerList")

        If f Is Nothing Then
            Dim CustomerList As New frmCustomerList

            CustomerList.StartPosition = FormStartPosition.CenterScreen
            CustomerList.MdiParent = Me
            CustomerList.Show()
        Else
            f.BringToFront()
        End If
    End Sub

    Private Sub SupplierListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SupplierListToolStripMenuItem.Click
        Dim f As Form = Application.OpenForms.Item("frmSupplierList")

        If f Is Nothing Then
            Dim SupplierList As New frmSupplierList

            SupplierList.StartPosition = FormStartPosition.CenterScreen
            SupplierList.MdiParent = Me
            SupplierList.Show()
        Else
            f.BringToFront()
        End If
    End Sub

    Private Sub CategoryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CategoryToolStripMenuItem.Click
        Dim f As Form = Application.OpenForms.Item("frmCategory")

        If f Is Nothing Then
            Dim Category As New frmCategory

            Category.StartPosition = FormStartPosition.CenterScreen
            Category.MdiParent = Me
            Category.Show()
        Else
            f.BringToFront()
        End If
    End Sub

    Private Sub BrandToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BrandToolStripMenuItem.Click
        Dim f As Form = Application.OpenForms.Item("frmBrand")

        If f Is Nothing Then
            Dim Brand As New frmBrand

            Brand.StartPosition = FormStartPosition.CenterScreen
            Brand.MdiParent = Me
            Brand.Show()
        Else
            f.BringToFront()
        End If
    End Sub

    Private Sub UnitOfMeasuresToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UnitOfMeasuresToolStripMenuItem.Click
        Dim f As Form = Application.OpenForms.Item("frmUnit")

        If f Is Nothing Then
            Dim Unit As New frmUnit

            Unit.StartPosition = FormStartPosition.CenterScreen
            Unit.MdiParent = Me
            Unit.Show()
        Else
            f.BringToFront()
        End If
    End Sub

    Private Sub ProductListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProductListToolStripMenuItem.Click
        Dim f As Form = Application.OpenForms.Item("frmProductList")

        If f Is Nothing Then
            Dim ProductList As New frmProductList

            ProductList.StartPosition = FormStartPosition.CenterScreen
            ProductList.MdiParent = Me
            ProductList.Show()
        Else
            f.BringToFront()
        End If
    End Sub

    Private Sub SalesOrderListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalesOrderListToolStripMenuItem.Click
        Dim f As Form = Application.OpenForms.Item("frmSalesOrderList")

        If f Is Nothing Then
            Dim SalesOrderList As New frmSalesOrderList

            SalesOrderList.StartPosition = FormStartPosition.CenterScreen
            SalesOrderList.MdiParent = Me
            SalesOrderList.Show()
        Else
            f.BringToFront()
        End If
    End Sub

    Private Sub PurchaseOrderListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PurchaseOrderListToolStripMenuItem.Click
        Dim f As Form = Application.OpenForms.Item("frmPurchaseOrderList")

        If f Is Nothing Then
            Dim PurchaseOrderList As New frmPurchaseOrderList

            PurchaseOrderList.StartPosition = FormStartPosition.CenterScreen
            PurchaseOrderList.MdiParent = Me
            PurchaseOrderList.Show()
        Else
            f.BringToFront()
        End If
    End Sub

    Private Sub SalesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalesToolStripMenuItem.Click
        Dim f As Form = Application.OpenForms.Item("frmSales")

        If f Is Nothing Then
            Dim Sales As New frmSales

            Sales.StartPosition = FormStartPosition.CenterScreen
            Sales.MdiParent = Me
            Sales.getFormState = modGlobal.FormState.adStateAddMode
            Sales.Show()
        Else
            f.BringToFront()
        End If
    End Sub

    Private Sub CreateSalesOrderToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CreateSalesOrderToolStripMenuItem.Click
        Dim f As Form = Application.OpenForms.Item("frmSalesOrder")

        If f Is Nothing Then
            Dim SalesOrder As New frmSalesOrder

            SalesOrder.StartPosition = FormStartPosition.CenterScreen
            SalesOrder.MdiParent = Me
            SalesOrder.getFormState = modGlobal.FormState.adStateAddMode
            SalesOrder.Show()
        Else
            f.BringToFront()
        End If
    End Sub

    Private Sub CreatePurchaseOrdersToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CreatePurchaseOrdersToolStripMenuItem.Click
        Dim f As Form = Application.OpenForms.Item("frmPurchaseOrder")

        If f Is Nothing Then
            Dim PurchaseOrder As New frmPurchaseOrder

            PurchaseOrder.StartPosition = FormStartPosition.CenterScreen
            PurchaseOrder.MdiParent = Me
            PurchaseOrder.getFormState = modGlobal.FormState.adStateAddMode
            PurchaseOrder.Show()
        Else
            f.BringToFront()
        End If
    End Sub

    Private Sub SalesHistoryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalesHistoryToolStripMenuItem.Click
        Dim f As Form = Application.OpenForms.Item("frmSalesHistory")

        If f Is Nothing Then
            Dim SalesHistory As New frmSalesHistory

            SalesHistory.StartPosition = FormStartPosition.CenterScreen
            SalesHistory.MdiParent = Me
            SalesHistory.Show()
        Else
            f.BringToFront()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim About As New frmAbout

        About.ShowDialog()
    End Sub

    Private Sub tsSales_Click(sender As System.Object, e As System.EventArgs) Handles tsSales.Click
        Dim f As Form = Application.OpenForms.Item("frmSales")

        If f Is Nothing Then
            Dim Sales As New frmSales

            Sales.StartPosition = FormStartPosition.CenterScreen
            Sales.MdiParent = Me
            Sales.getFormState = modGlobal.FormState.adStateAddMode
            Sales.Show()
        Else
            f.BringToFront()
        End If
    End Sub

    Private Sub tsPurchaseOrder_Click(sender As System.Object, e As System.EventArgs) Handles tsPurchaseOrder.Click
        Dim f As Form = Application.OpenForms.Item("frmPurchaseOrder")

        If f Is Nothing Then
            Dim PurchaseOrder As New frmPurchaseOrder

            PurchaseOrder.StartPosition = FormStartPosition.CenterScreen
            PurchaseOrder.MdiParent = Me
            PurchaseOrder.getFormState = modGlobal.FormState.adStateAddMode
            PurchaseOrder.Show()
        Else
            f.BringToFront()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub tsSalesOrder_Click(sender As System.Object, e As System.EventArgs) Handles tsSalesOrder.Click
        Dim f As Form = Application.OpenForms.Item("frmSalesOrder")

        If f Is Nothing Then
            Dim SalesOrder As New frmSalesOrder

            SalesOrder.StartPosition = FormStartPosition.CenterScreen
            SalesOrder.MdiParent = Me
            SalesOrder.getFormState = modGlobal.FormState.adStateAddMode
            SalesOrder.Show()
        Else
            f.BringToFront()
        End If
    End Sub

    Private Sub CreateInvoicesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CreateInvoicesToolStripMenuItem.Click
        Dim f As Form = Application.OpenForms.Item("frmInvoice")

        If f Is Nothing Then
            Dim Invoice As New frmInvoice

            Invoice.StartPosition = FormStartPosition.CenterScreen
            Invoice.MdiParent = Me
            Invoice.getFormState = modGlobal.FormState.adStateAddMode
            Invoice.Show()
        Else
            f.BringToFront()
        End If
    End Sub

    Private Sub ReceiveProductToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReceiveProductToolStripMenuItem.Click
        Dim f As Form = Application.OpenForms.Item("frmProductReceive")

        If f Is Nothing Then
            Dim ProductReceive As New frmProductReceive

            ProductReceive.StartPosition = FormStartPosition.CenterScreen
            ProductReceive.MdiParent = Me
            ProductReceive.getFormState = modGlobal.FormState.adStateAddMode
            ProductReceive.Show()
        Else
            f.BringToFront()
        End If
    End Sub

    Private Sub InvoiceHistoryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InvoiceHistoryToolStripMenuItem.Click
        Dim f As Form = Application.OpenForms.Item("frmInvoiceHistory")

        If f Is Nothing Then
            Dim InvoiceHistory As New frmInvoiceHistory

            InvoiceHistory.StartPosition = FormStartPosition.CenterScreen
            InvoiceHistory.MdiParent = Me
            InvoiceHistory.Show()
        Else
            f.BringToFront()
        End If
    End Sub

    Private Sub ProductReceivedListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProductReceivedListToolStripMenuItem.Click
        Dim f As Form = Application.OpenForms.Item("frmProductReceiveHistory")

        If f Is Nothing Then
            Dim ProductReceiveHistory As New frmProductReceiveHistory

            ProductReceiveHistory.StartPosition = FormStartPosition.CenterScreen
            ProductReceiveHistory.MdiParent = Me
            ProductReceiveHistory.Show()
        Else
            f.BringToFront()
        End If
    End Sub

    Private Sub InventoryListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InventoryListToolStripMenuItem.Click
        Dim f As Form = Application.OpenForms.Item("frmStoreInventory")

        If f Is Nothing Then
            Dim StoreInventory As New frmStoreInventory

            StoreInventory.StartPosition = FormStartPosition.CenterScreen
            StoreInventory.MdiParent = Me
            StoreInventory.Show()
        Else
            f.BringToFront()
        End If
    End Sub

    Private Sub DailySalesReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DailySalesReportToolStripMenuItem.Click
        Dim Report As New frmReport

        With Report
            .strReport = "SalesReport"

            .MdiParent = Me.MdiParent
            .Show()
        End With
    End Sub
End Class
