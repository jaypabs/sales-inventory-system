<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SalesOrderIDLabel As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim DiscountAmountLabel As System.Windows.Forms.Label
        Dim DiscountPercentLabel As System.Windows.Forms.Label
        Dim NetLabel As System.Windows.Forms.Label
        Dim SONumberLabel As System.Windows.Forms.Label
        Dim CashierLabel As System.Windows.Forms.Label
        Dim PaymentTypeLabel As System.Windows.Forms.Label
        Dim OrderStatusLabel As System.Windows.Forms.Label
        Dim CreatedByLabel As System.Windows.Forms.Label
        Dim DateCreatedLabel As System.Windows.Forms.Label
        Dim ApprovedByLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesOrder))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SalesOrderDataSet = New Sales_And_Inventory_System.SalesOrderDataSet()
        Me.SalesOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesOrderTableAdapter = New Sales_And_Inventory_System.SalesOrderDataSetTableAdapters.SalesOrderTableAdapter()
        Me.TableAdapterManager = New Sales_And_Inventory_System.SalesOrderDataSetTableAdapters.TableAdapterManager()
        Me.SalesOrderDetailTableAdapter = New Sales_And_Inventory_System.SalesOrderDataSetTableAdapters.SalesOrderDetailTableAdapter()
        Me.SalesOrderBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalesOrderBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SalesOrderIDTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIDComboBox = New System.Windows.Forms.ComboBox()
        Me.QryCustomerLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerLookupDataSet = New Sales_And_Inventory_System.CustomerLookupDataSet()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DiscountAmountTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountPercentTextBox = New System.Windows.Forms.TextBox()
        Me.NetTextBox = New System.Windows.Forms.TextBox()
        Me.SalesOrderDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesOrderDetailDataGridView = New System.Windows.Forms.DataGridView()
        Me.AddProduct = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ProductDetailID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.QryProductLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductLookupDataSet = New Sales_And_Inventory_System.ProductLookupDataSet()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.QtyDlvd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellingPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountPercent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qry_CustomerLookupTableAdapter = New Sales_And_Inventory_System.CustomerLookupDataSetTableAdapters.qry_CustomerLookupTableAdapter()
        Me.Qry_ProductLookupTableAdapter = New Sales_And_Inventory_System.ProductLookupDataSetTableAdapters.qry_ProductLookupTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SONumberTextBox = New System.Windows.Forms.TextBox()
        Me.CashierTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.OrderStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.CreatedByTextBox = New System.Windows.Forms.TextBox()
        Me.DateCreatedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ApprovedByTextBox = New System.Windows.Forms.TextBox()
        SalesOrderIDLabel = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        DiscountAmountLabel = New System.Windows.Forms.Label()
        DiscountPercentLabel = New System.Windows.Forms.Label()
        NetLabel = New System.Windows.Forms.Label()
        SONumberLabel = New System.Windows.Forms.Label()
        CashierLabel = New System.Windows.Forms.Label()
        PaymentTypeLabel = New System.Windows.Forms.Label()
        OrderStatusLabel = New System.Windows.Forms.Label()
        CreatedByLabel = New System.Windows.Forms.Label()
        DateCreatedLabel = New System.Windows.Forms.Label()
        ApprovedByLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.SalesOrderDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesOrderBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SalesOrderBindingNavigator.SuspendLayout()
        CType(Me.QryCustomerLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesOrderDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesOrderDetailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryProductLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SalesOrderIDLabel
        '
        SalesOrderIDLabel.AutoSize = True
        SalesOrderIDLabel.Location = New System.Drawing.Point(124, 253)
        SalesOrderIDLabel.Name = "SalesOrderIDLabel"
        SalesOrderIDLabel.Size = New System.Drawing.Size(79, 13)
        SalesOrderIDLabel.TabIndex = 11
        SalesOrderIDLabel.Text = "Sales Order ID:"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(37, 58)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(54, 13)
        CustomerIDLabel.TabIndex = 13
        CustomerIDLabel.Text = "Customer:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(445, 85)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(57, 13)
        DateLabel.TabIndex = 15
        DateLabel.Text = "S.O. Date:"
        '
        'DiscountAmountLabel
        '
        DiscountAmountLabel.AutoSize = True
        DiscountAmountLabel.Location = New System.Drawing.Point(635, 375)
        DiscountAmountLabel.Name = "DiscountAmountLabel"
        DiscountAmountLabel.Size = New System.Drawing.Size(43, 13)
        DiscountAmountLabel.TabIndex = 19
        DiscountAmountLabel.Text = "Amount"
        '
        'DiscountPercentLabel
        '
        DiscountPercentLabel.AutoSize = True
        DiscountPercentLabel.Location = New System.Drawing.Point(689, 375)
        DiscountPercentLabel.Name = "DiscountPercentLabel"
        DiscountPercentLabel.Size = New System.Drawing.Size(44, 13)
        DiscountPercentLabel.TabIndex = 21
        DiscountPercentLabel.Text = "Percent"
        '
        'NetLabel
        '
        NetLabel.AutoSize = True
        NetLabel.Location = New System.Drawing.Point(604, 421)
        NetLabel.Name = "NetLabel"
        NetLabel.Size = New System.Drawing.Size(27, 13)
        NetLabel.TabIndex = 23
        NetLabel.Text = "Net:"
        '
        'SONumberLabel
        '
        SONumberLabel.AutoSize = True
        SONumberLabel.Location = New System.Drawing.Point(461, 58)
        SONumberLabel.Name = "SONumberLabel"
        SONumberLabel.Size = New System.Drawing.Size(41, 13)
        SONumberLabel.TabIndex = 42
        SONumberLabel.Text = "S.O. #:"
        '
        'CashierLabel
        '
        CashierLabel.AutoSize = True
        CashierLabel.Location = New System.Drawing.Point(40, 378)
        CashierLabel.Name = "CashierLabel"
        CashierLabel.Size = New System.Drawing.Size(45, 13)
        CashierLabel.TabIndex = 43
        CashierLabel.Text = "Cashier:"
        '
        'PaymentTypeLabel
        '
        PaymentTypeLabel.AutoSize = True
        PaymentTypeLabel.Location = New System.Drawing.Point(13, 111)
        PaymentTypeLabel.Name = "PaymentTypeLabel"
        PaymentTypeLabel.Size = New System.Drawing.Size(78, 13)
        PaymentTypeLabel.TabIndex = 44
        PaymentTypeLabel.Text = "Payment Type:"
        '
        'OrderStatusLabel
        '
        OrderStatusLabel.AutoSize = True
        OrderStatusLabel.Location = New System.Drawing.Point(433, 111)
        OrderStatusLabel.Name = "OrderStatusLabel"
        OrderStatusLabel.Size = New System.Drawing.Size(69, 13)
        OrderStatusLabel.TabIndex = 46
        OrderStatusLabel.Text = "Order Status:"
        '
        'CreatedByLabel
        '
        CreatedByLabel.AutoSize = True
        CreatedByLabel.Location = New System.Drawing.Point(23, 404)
        CreatedByLabel.Name = "CreatedByLabel"
        CreatedByLabel.Size = New System.Drawing.Size(62, 13)
        CreatedByLabel.TabIndex = 47
        CreatedByLabel.Text = "Created By:"
        '
        'DateCreatedLabel
        '
        DateCreatedLabel.AutoSize = True
        DateCreatedLabel.Location = New System.Drawing.Point(12, 431)
        DateCreatedLabel.Name = "DateCreatedLabel"
        DateCreatedLabel.Size = New System.Drawing.Size(73, 13)
        DateCreatedLabel.TabIndex = 48
        DateCreatedLabel.Text = "Date Created:"
        '
        'ApprovedByLabel
        '
        ApprovedByLabel.AutoSize = True
        ApprovedByLabel.Location = New System.Drawing.Point(14, 456)
        ApprovedByLabel.Name = "ApprovedByLabel"
        ApprovedByLabel.Size = New System.Drawing.Size(71, 13)
        ApprovedByLabel.TabIndex = 49
        ApprovedByLabel.Text = "Approved By:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(753, 39)
        Me.Panel1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales Order"
        '
        'SalesOrderDataSet
        '
        Me.SalesOrderDataSet.DataSetName = "SalesOrderDataSet"
        Me.SalesOrderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesOrderBindingSource
        '
        Me.SalesOrderBindingSource.DataMember = "SalesOrder"
        Me.SalesOrderBindingSource.DataSource = Me.SalesOrderDataSet
        '
        'SalesOrderTableAdapter
        '
        Me.SalesOrderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SalesOrderDetailTableAdapter = Me.SalesOrderDetailTableAdapter
        Me.TableAdapterManager.SalesOrderTableAdapter = Me.SalesOrderTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sales_And_Inventory_System.SalesOrderDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SalesOrderDetailTableAdapter
        '
        Me.SalesOrderDetailTableAdapter.ClearBeforeFill = True
        '
        'SalesOrderBindingNavigator
        '
        Me.SalesOrderBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SalesOrderBindingNavigator.BindingSource = Me.SalesOrderBindingSource
        Me.SalesOrderBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SalesOrderBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SalesOrderBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SalesOrderBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SalesOrderBindingNavigatorSaveItem})
        Me.SalesOrderBindingNavigator.Location = New System.Drawing.Point(0, 456)
        Me.SalesOrderBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SalesOrderBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SalesOrderBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SalesOrderBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SalesOrderBindingNavigator.Name = "SalesOrderBindingNavigator"
        Me.SalesOrderBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SalesOrderBindingNavigator.Size = New System.Drawing.Size(654, 25)
        Me.SalesOrderBindingNavigator.TabIndex = 11
        Me.SalesOrderBindingNavigator.Text = "BindingNavigator1"
        Me.SalesOrderBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SalesOrderBindingNavigatorSaveItem
        '
        Me.SalesOrderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SalesOrderBindingNavigatorSaveItem.Image = CType(resources.GetObject("SalesOrderBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SalesOrderBindingNavigatorSaveItem.Name = "SalesOrderBindingNavigatorSaveItem"
        Me.SalesOrderBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SalesOrderBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SalesOrderIDTextBox
        '
        Me.SalesOrderIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesOrderBindingSource, "SalesOrderID", True))
        Me.SalesOrderIDTextBox.Location = New System.Drawing.Point(222, 250)
        Me.SalesOrderIDTextBox.Name = "SalesOrderIDTextBox"
        Me.SalesOrderIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SalesOrderIDTextBox.TabIndex = 12
        '
        'CustomerIDComboBox
        '
        Me.CustomerIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SalesOrderBindingSource, "CustomerID", True))
        Me.CustomerIDComboBox.DataSource = Me.QryCustomerLookupBindingSource
        Me.CustomerIDComboBox.DisplayMember = "Name"
        Me.CustomerIDComboBox.FormattingEnabled = True
        Me.CustomerIDComboBox.Location = New System.Drawing.Point(97, 55)
        Me.CustomerIDComboBox.Name = "CustomerIDComboBox"
        Me.CustomerIDComboBox.Size = New System.Drawing.Size(221, 21)
        Me.CustomerIDComboBox.TabIndex = 14
        Me.CustomerIDComboBox.ValueMember = "CustomerID"
        '
        'QryCustomerLookupBindingSource
        '
        Me.QryCustomerLookupBindingSource.DataMember = "qry_CustomerLookup"
        Me.QryCustomerLookupBindingSource.DataSource = Me.CustomerLookupDataSet
        '
        'CustomerLookupDataSet
        '
        Me.CustomerLookupDataSet.DataSetName = "CustomerLookupDataSet"
        Me.CustomerLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SalesOrderBindingSource, "SODate", True))
        Me.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDateTimePicker.Location = New System.Drawing.Point(508, 82)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.DateDateTimePicker.TabIndex = 16
        '
        'DiscountAmountTextBox
        '
        Me.DiscountAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesOrderBindingSource, "DiscountAmount", True))
        Me.DiscountAmountTextBox.Location = New System.Drawing.Point(638, 392)
        Me.DiscountAmountTextBox.Name = "DiscountAmountTextBox"
        Me.DiscountAmountTextBox.Size = New System.Drawing.Size(48, 20)
        Me.DiscountAmountTextBox.TabIndex = 20
        Me.DiscountAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DiscountPercentTextBox
        '
        Me.DiscountPercentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesOrderBindingSource, "DiscountPercent", True))
        Me.DiscountPercentTextBox.Location = New System.Drawing.Point(692, 392)
        Me.DiscountPercentTextBox.Name = "DiscountPercentTextBox"
        Me.DiscountPercentTextBox.Size = New System.Drawing.Size(48, 20)
        Me.DiscountPercentTextBox.TabIndex = 22
        Me.DiscountPercentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NetTextBox
        '
        Me.NetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesOrderBindingSource, "Net", True))
        Me.NetTextBox.Location = New System.Drawing.Point(637, 418)
        Me.NetTextBox.Name = "NetTextBox"
        Me.NetTextBox.Size = New System.Drawing.Size(103, 20)
        Me.NetTextBox.TabIndex = 24
        Me.NetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesOrderDetailBindingSource
        '
        Me.SalesOrderDetailBindingSource.DataMember = "SalesOrderSalesOrderDetail"
        Me.SalesOrderDetailBindingSource.DataSource = Me.SalesOrderBindingSource
        '
        'SalesOrderDetailDataGridView
        '
        Me.SalesOrderDetailDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SalesOrderDetailDataGridView.AutoGenerateColumns = False
        Me.SalesOrderDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalesOrderDetailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AddProduct, Me.ProductDetailID, Me.Qty, Me.UnitID, Me.QtyDlvd, Me.SellingPrice, Me.DiscountPercent, Me.DiscountAmount, Me.Amount})
        Me.SalesOrderDetailDataGridView.DataSource = Me.SalesOrderDetailBindingSource
        Me.SalesOrderDetailDataGridView.Location = New System.Drawing.Point(0, 138)
        Me.SalesOrderDetailDataGridView.Name = "SalesOrderDetailDataGridView"
        Me.SalesOrderDetailDataGridView.Size = New System.Drawing.Size(753, 227)
        Me.SalesOrderDetailDataGridView.TabIndex = 24
        '
        'AddProduct
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = "Add Product"
        Me.AddProduct.DefaultCellStyle = DataGridViewCellStyle1
        Me.AddProduct.Frozen = True
        Me.AddProduct.HeaderText = "Add Product"
        Me.AddProduct.Name = "AddProduct"
        Me.AddProduct.Width = 80
        '
        'ProductDetailID
        '
        Me.ProductDetailID.DataPropertyName = "ProductDetailID"
        Me.ProductDetailID.DataSource = Me.QryProductLookupBindingSource
        Me.ProductDetailID.DisplayMember = "ProductName"
        Me.ProductDetailID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ProductDetailID.Frozen = True
        Me.ProductDetailID.HeaderText = "Product"
        Me.ProductDetailID.Name = "ProductDetailID"
        Me.ProductDetailID.ReadOnly = True
        Me.ProductDetailID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductDetailID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ProductDetailID.ValueMember = "ProductDetailID"
        Me.ProductDetailID.Width = 150
        '
        'QryProductLookupBindingSource
        '
        Me.QryProductLookupBindingSource.DataMember = "qry_ProductLookup"
        Me.QryProductLookupBindingSource.DataSource = Me.ProductLookupDataSet
        '
        'ProductLookupDataSet
        '
        Me.ProductLookupDataSet.DataSetName = "ProductLookupDataSet"
        Me.ProductLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Qty
        '
        Me.Qty.DataPropertyName = "Qty"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Qty.DefaultCellStyle = DataGridViewCellStyle2
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 70
        '
        'UnitID
        '
        Me.UnitID.DataPropertyName = "UnitID"
        Me.UnitID.DataSource = Me.QryProductLookupBindingSource
        Me.UnitID.DisplayMember = "UOM"
        Me.UnitID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.UnitID.HeaderText = "U/M"
        Me.UnitID.Name = "UnitID"
        Me.UnitID.ReadOnly = True
        Me.UnitID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UnitID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.UnitID.ValueMember = "UnitID"
        Me.UnitID.Width = 70
        '
        'QtyDlvd
        '
        Me.QtyDlvd.DataPropertyName = "QtyDlvd"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.QtyDlvd.DefaultCellStyle = DataGridViewCellStyle3
        Me.QtyDlvd.HeaderText = "Qty Dlvd"
        Me.QtyDlvd.Name = "QtyDlvd"
        Me.QtyDlvd.Width = 80
        '
        'SellingPrice
        '
        Me.SellingPrice.DataPropertyName = "SellingPrice"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SellingPrice.DefaultCellStyle = DataGridViewCellStyle4
        Me.SellingPrice.HeaderText = "Selling Price"
        Me.SellingPrice.Name = "SellingPrice"
        Me.SellingPrice.Width = 90
        '
        'DiscountPercent
        '
        Me.DiscountPercent.DataPropertyName = "DiscountPercent"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DiscountPercent.DefaultCellStyle = DataGridViewCellStyle5
        Me.DiscountPercent.HeaderText = "Discount (%)"
        Me.DiscountPercent.Name = "DiscountPercent"
        '
        'DiscountAmount
        '
        Me.DiscountAmount.DataPropertyName = "DiscountAmount"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DiscountAmount.DefaultCellStyle = DataGridViewCellStyle6
        Me.DiscountAmount.HeaderText = "Discount (Amt)"
        Me.DiscountAmount.Name = "DiscountAmount"
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "Amount"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle7
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        '
        'Qry_CustomerLookupTableAdapter
        '
        Me.Qry_CustomerLookupTableAdapter.ClearBeforeFill = True
        '
        'Qry_ProductLookupTableAdapter
        '
        Me.Qry_ProductLookupTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(97, 82)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(285, 20)
        Me.TextBox1.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(576, 395)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Discount :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 483)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(753, 40)
        Me.Panel2.TabIndex = 42
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(590, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 34)
        Me.btnSave.TabIndex = 40
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(672, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 34)
        Me.btnClose.TabIndex = 28
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'SONumberTextBox
        '
        Me.SONumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesOrderBindingSource, "SONumber", True))
        Me.SONumberTextBox.Location = New System.Drawing.Point(508, 55)
        Me.SONumberTextBox.Name = "SONumberTextBox"
        Me.SONumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SONumberTextBox.TabIndex = 43
        '
        'CashierTextBox
        '
        Me.CashierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesOrderBindingSource, "Cashier", True))
        Me.CashierTextBox.Location = New System.Drawing.Point(91, 375)
        Me.CashierTextBox.Name = "CashierTextBox"
        Me.CashierTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CashierTextBox.TabIndex = 44
        '
        'PaymentTypeComboBox
        '
        Me.PaymentTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesOrderBindingSource, "PaymentType", True))
        Me.PaymentTypeComboBox.FormattingEnabled = True
        Me.PaymentTypeComboBox.Items.AddRange(New Object() {"Cash", "Check"})
        Me.PaymentTypeComboBox.Location = New System.Drawing.Point(97, 108)
        Me.PaymentTypeComboBox.Name = "PaymentTypeComboBox"
        Me.PaymentTypeComboBox.Size = New System.Drawing.Size(144, 21)
        Me.PaymentTypeComboBox.TabIndex = 45
        '
        'OrderStatusComboBox
        '
        Me.OrderStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesOrderBindingSource, "OrderStatus", True))
        Me.OrderStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OrderStatusComboBox.FormattingEnabled = True
        Me.OrderStatusComboBox.Items.AddRange(New Object() {"For Approval", "Approved", "Received (Incomplete)", "Received (Complete)", "Cancelled"})
        Me.OrderStatusComboBox.Location = New System.Drawing.Point(508, 108)
        Me.OrderStatusComboBox.Name = "OrderStatusComboBox"
        Me.OrderStatusComboBox.Size = New System.Drawing.Size(121, 21)
        Me.OrderStatusComboBox.TabIndex = 47
        '
        'CreatedByTextBox
        '
        Me.CreatedByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesOrderBindingSource, "CreatedBy", True))
        Me.CreatedByTextBox.Location = New System.Drawing.Point(91, 401)
        Me.CreatedByTextBox.Name = "CreatedByTextBox"
        Me.CreatedByTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CreatedByTextBox.TabIndex = 48
        '
        'DateCreatedDateTimePicker
        '
        Me.DateCreatedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SalesOrderBindingSource, "DateCreated", True))
        Me.DateCreatedDateTimePicker.Location = New System.Drawing.Point(91, 427)
        Me.DateCreatedDateTimePicker.Name = "DateCreatedDateTimePicker"
        Me.DateCreatedDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateCreatedDateTimePicker.TabIndex = 49
        '
        'ApprovedByTextBox
        '
        Me.ApprovedByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesOrderBindingSource, "ApprovedBy", True))
        Me.ApprovedByTextBox.Location = New System.Drawing.Point(91, 453)
        Me.ApprovedByTextBox.Name = "ApprovedByTextBox"
        Me.ApprovedByTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApprovedByTextBox.TabIndex = 50
        '
        'frmSalesOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 523)
        Me.Controls.Add(ApprovedByLabel)
        Me.Controls.Add(Me.ApprovedByTextBox)
        Me.Controls.Add(DateCreatedLabel)
        Me.Controls.Add(Me.DateCreatedDateTimePicker)
        Me.Controls.Add(CreatedByLabel)
        Me.Controls.Add(Me.CreatedByTextBox)
        Me.Controls.Add(OrderStatusLabel)
        Me.Controls.Add(Me.OrderStatusComboBox)
        Me.Controls.Add(PaymentTypeLabel)
        Me.Controls.Add(Me.PaymentTypeComboBox)
        Me.Controls.Add(CashierLabel)
        Me.Controls.Add(Me.CashierTextBox)
        Me.Controls.Add(SONumberLabel)
        Me.Controls.Add(Me.SONumberTextBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SalesOrderDetailDataGridView)
        Me.Controls.Add(SalesOrderIDLabel)
        Me.Controls.Add(Me.SalesOrderIDTextBox)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDComboBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(DiscountAmountLabel)
        Me.Controls.Add(Me.DiscountAmountTextBox)
        Me.Controls.Add(DiscountPercentLabel)
        Me.Controls.Add(Me.DiscountPercentTextBox)
        Me.Controls.Add(NetLabel)
        Me.Controls.Add(Me.NetTextBox)
        Me.Controls.Add(Me.SalesOrderBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSalesOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SalesOrder"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.SalesOrderDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesOrderBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SalesOrderBindingNavigator.ResumeLayout(False)
        Me.SalesOrderBindingNavigator.PerformLayout()
        CType(Me.QryCustomerLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesOrderDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesOrderDetailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryProductLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SalesOrderDataSet As Sales_And_Inventory_System.SalesOrderDataSet
    Friend WithEvents SalesOrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesOrderTableAdapter As Sales_And_Inventory_System.SalesOrderDataSetTableAdapters.SalesOrderTableAdapter
    Friend WithEvents TableAdapterManager As Sales_And_Inventory_System.SalesOrderDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SalesOrderBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalesOrderBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SalesOrderDetailTableAdapter As Sales_And_Inventory_System.SalesOrderDataSetTableAdapters.SalesOrderDetailTableAdapter
    Friend WithEvents SalesOrderIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DiscountAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiscountPercentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalesOrderDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesOrderDetailDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CustomerLookupDataSet As Sales_And_Inventory_System.CustomerLookupDataSet
    Friend WithEvents QryCustomerLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Qry_CustomerLookupTableAdapter As Sales_And_Inventory_System.CustomerLookupDataSetTableAdapters.qry_CustomerLookupTableAdapter
    Friend WithEvents ProductLookupDataSet As Sales_And_Inventory_System.ProductLookupDataSet
    Friend WithEvents QryProductLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Qry_ProductLookupTableAdapter As Sales_And_Inventory_System.ProductLookupDataSetTableAdapters.qry_ProductLookupTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents SONumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CashierTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaymentTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OrderStatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CreatedByTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateCreatedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ApprovedByTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddProduct As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ProductDetailID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents QtyDlvd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SellingPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiscountPercent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiscountAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
