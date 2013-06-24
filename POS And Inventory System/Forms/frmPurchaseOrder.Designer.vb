<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseOrder
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
        Dim PurchaseOrderIDLabel As System.Windows.Forms.Label
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim DatePurchasedLabel As System.Windows.Forms.Label
        Dim SubTotalLabel As System.Windows.Forms.Label
        Dim DiscountPercentLabel As System.Windows.Forms.Label
        Dim DiscountAmountLabel As System.Windows.Forms.Label
        Dim NetAmountLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim PONumberLabel As System.Windows.Forms.Label
        Dim DateCreatedLabel As System.Windows.Forms.Label
        Dim CreatedByLabel As System.Windows.Forms.Label
        Dim ApprovedByLabel As System.Windows.Forms.Label
        Dim DateApprovedLabel As System.Windows.Forms.Label
        Dim OrderStatusLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPurchaseOrder))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PurchaseOrderBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.PurchaseOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseOrderDataSet = New Sales_And_Inventory_System.PurchaseOrderDataSet()
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
        Me.PurchaseOrderBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PurchaseOrderIDTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierIDComboBox = New System.Windows.Forms.ComboBox()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New Sales_And_Inventory_System.SupplierDataSet()
        Me.DatePurchasedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountPercentTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountAmountTextBox = New System.Windows.Forms.TextBox()
        Me.NetAmountTextBox = New System.Windows.Forms.TextBox()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.PurchaseOrderDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseOrderDetailDataGridView = New System.Windows.Forms.DataGridView()
        Me.AddProduct = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ProductDetailID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.QryProductLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductLookupDataSet = New Sales_And_Inventory_System.ProductLookupDataSet()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.QtyRecd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseOrderTableAdapter = New Sales_And_Inventory_System.PurchaseOrderDataSetTableAdapters.PurchaseOrderTableAdapter()
        Me.TableAdapterManager = New Sales_And_Inventory_System.PurchaseOrderDataSetTableAdapters.TableAdapterManager()
        Me.PurchaseOrderDetailTableAdapter = New Sales_And_Inventory_System.PurchaseOrderDataSetTableAdapters.PurchaseOrderDetailTableAdapter()
        Me.Qry_ProductLookupTableAdapter = New Sales_And_Inventory_System.ProductLookupDataSetTableAdapters.qry_ProductLookupTableAdapter()
        Me.SupplierTableAdapter = New Sales_And_Inventory_System.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PONumberTextBox = New System.Windows.Forms.TextBox()
        Me.DateCreatedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CreatedByTextBox = New System.Windows.Forms.TextBox()
        Me.ApprovedByTextBox = New System.Windows.Forms.TextBox()
        Me.DateApprovedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.OrderStatusComboBox = New System.Windows.Forms.ComboBox()
        PurchaseOrderIDLabel = New System.Windows.Forms.Label()
        SupplierIDLabel = New System.Windows.Forms.Label()
        DatePurchasedLabel = New System.Windows.Forms.Label()
        SubTotalLabel = New System.Windows.Forms.Label()
        DiscountPercentLabel = New System.Windows.Forms.Label()
        DiscountAmountLabel = New System.Windows.Forms.Label()
        NetAmountLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        PONumberLabel = New System.Windows.Forms.Label()
        DateCreatedLabel = New System.Windows.Forms.Label()
        CreatedByLabel = New System.Windows.Forms.Label()
        ApprovedByLabel = New System.Windows.Forms.Label()
        DateApprovedLabel = New System.Windows.Forms.Label()
        OrderStatusLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PurchaseOrderBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PurchaseOrderBindingNavigator.SuspendLayout()
        CType(Me.PurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseOrderDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseOrderDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseOrderDetailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryProductLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PurchaseOrderIDLabel
        '
        PurchaseOrderIDLabel.AutoSize = True
        PurchaseOrderIDLabel.Location = New System.Drawing.Point(112, 251)
        PurchaseOrderIDLabel.Name = "PurchaseOrderIDLabel"
        PurchaseOrderIDLabel.Size = New System.Drawing.Size(98, 13)
        PurchaseOrderIDLabel.TabIndex = 12
        PurchaseOrderIDLabel.Text = "Purchase Order ID:"
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.AutoSize = True
        SupplierIDLabel.Location = New System.Drawing.Point(26, 50)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(48, 13)
        SupplierIDLabel.TabIndex = 14
        SupplierIDLabel.Text = "Supplier:"
        '
        'DatePurchasedLabel
        '
        DatePurchasedLabel.AutoSize = True
        DatePurchasedLabel.Location = New System.Drawing.Point(26, 78)
        DatePurchasedLabel.Name = "DatePurchasedLabel"
        DatePurchasedLabel.Size = New System.Drawing.Size(57, 13)
        DatePurchasedLabel.TabIndex = 16
        DatePurchasedLabel.Text = "P.O. Date:"
        '
        'SubTotalLabel
        '
        SubTotalLabel.AutoSize = True
        SubTotalLabel.Location = New System.Drawing.Point(539, 376)
        SubTotalLabel.Name = "SubTotalLabel"
        SubTotalLabel.Size = New System.Drawing.Size(56, 13)
        SubTotalLabel.TabIndex = 18
        SubTotalLabel.Text = "Sub Total:"
        '
        'DiscountPercentLabel
        '
        DiscountPercentLabel.AutoSize = True
        DiscountPercentLabel.Location = New System.Drawing.Point(640, 402)
        DiscountPercentLabel.Name = "DiscountPercentLabel"
        DiscountPercentLabel.Size = New System.Drawing.Size(44, 13)
        DiscountPercentLabel.TabIndex = 20
        DiscountPercentLabel.Text = "Percent"
        '
        'DiscountAmountLabel
        '
        DiscountAmountLabel.AutoSize = True
        DiscountAmountLabel.Location = New System.Drawing.Point(694, 402)
        DiscountAmountLabel.Name = "DiscountAmountLabel"
        DiscountAmountLabel.Size = New System.Drawing.Size(43, 13)
        DiscountAmountLabel.TabIndex = 22
        DiscountAmountLabel.Text = "Amount"
        '
        'NetAmountLabel
        '
        NetAmountLabel.AutoSize = True
        NetAmountLabel.Location = New System.Drawing.Point(539, 454)
        NetAmountLabel.Name = "NetAmountLabel"
        NetAmountLabel.Size = New System.Drawing.Size(66, 13)
        NetAmountLabel.TabIndex = 24
        NetAmountLabel.Text = "Net Amount:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(42, 379)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 26
        RemarksLabel.Text = "Remarks:"
        '
        'PONumberLabel
        '
        PONumberLabel.AutoSize = True
        PONumberLabel.Location = New System.Drawing.Point(358, 51)
        PONumberLabel.Name = "PONumberLabel"
        PONumberLabel.Size = New System.Drawing.Size(41, 13)
        PONumberLabel.TabIndex = 28
        PONumberLabel.Text = "P.O. #:"
        '
        'DateCreatedLabel
        '
        DateCreatedLabel.AutoSize = True
        DateCreatedLabel.Location = New System.Drawing.Point(326, 78)
        DateCreatedLabel.Name = "DateCreatedLabel"
        DateCreatedLabel.Size = New System.Drawing.Size(73, 13)
        DateCreatedLabel.TabIndex = 29
        DateCreatedLabel.Text = "Date Created:"
        '
        'CreatedByLabel
        '
        CreatedByLabel.AutoSize = True
        CreatedByLabel.Location = New System.Drawing.Point(32, 405)
        CreatedByLabel.Name = "CreatedByLabel"
        CreatedByLabel.Size = New System.Drawing.Size(62, 13)
        CreatedByLabel.TabIndex = 30
        CreatedByLabel.Text = "Created By:"
        '
        'ApprovedByLabel
        '
        ApprovedByLabel.AutoSize = True
        ApprovedByLabel.Location = New System.Drawing.Point(23, 431)
        ApprovedByLabel.Name = "ApprovedByLabel"
        ApprovedByLabel.Size = New System.Drawing.Size(71, 13)
        ApprovedByLabel.TabIndex = 31
        ApprovedByLabel.Text = "Approved By:"
        '
        'DateApprovedLabel
        '
        DateApprovedLabel.AutoSize = True
        DateApprovedLabel.Location = New System.Drawing.Point(12, 458)
        DateApprovedLabel.Name = "DateApprovedLabel"
        DateApprovedLabel.Size = New System.Drawing.Size(82, 13)
        DateApprovedLabel.TabIndex = 32
        DateApprovedLabel.Text = "Date Approved:"
        '
        'OrderStatusLabel
        '
        OrderStatusLabel.AutoSize = True
        OrderStatusLabel.Location = New System.Drawing.Point(510, 50)
        OrderStatusLabel.Name = "OrderStatusLabel"
        OrderStatusLabel.Size = New System.Drawing.Size(69, 13)
        OrderStatusLabel.TabIndex = 41
        OrderStatusLabel.Text = "Order Status:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(748, 39)
        Me.Panel1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Purchase Order"
        '
        'PurchaseOrderBindingNavigator
        '
        Me.PurchaseOrderBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PurchaseOrderBindingNavigator.BindingSource = Me.PurchaseOrderBindingSource
        Me.PurchaseOrderBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PurchaseOrderBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PurchaseOrderBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PurchaseOrderBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PurchaseOrderBindingNavigatorSaveItem})
        Me.PurchaseOrderBindingNavigator.Location = New System.Drawing.Point(0, 411)
        Me.PurchaseOrderBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PurchaseOrderBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PurchaseOrderBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PurchaseOrderBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PurchaseOrderBindingNavigator.Name = "PurchaseOrderBindingNavigator"
        Me.PurchaseOrderBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PurchaseOrderBindingNavigator.Size = New System.Drawing.Size(572, 25)
        Me.PurchaseOrderBindingNavigator.TabIndex = 12
        Me.PurchaseOrderBindingNavigator.Text = "BindingNavigator1"
        Me.PurchaseOrderBindingNavigator.Visible = False
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
        'PurchaseOrderBindingSource
        '
        Me.PurchaseOrderBindingSource.DataMember = "PurchaseOrder"
        Me.PurchaseOrderBindingSource.DataSource = Me.PurchaseOrderDataSet
        '
        'PurchaseOrderDataSet
        '
        Me.PurchaseOrderDataSet.DataSetName = "PurchaseOrderDataSet"
        Me.PurchaseOrderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'PurchaseOrderBindingNavigatorSaveItem
        '
        Me.PurchaseOrderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PurchaseOrderBindingNavigatorSaveItem.Image = CType(resources.GetObject("PurchaseOrderBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PurchaseOrderBindingNavigatorSaveItem.Name = "PurchaseOrderBindingNavigatorSaveItem"
        Me.PurchaseOrderBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PurchaseOrderBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PurchaseOrderIDTextBox
        '
        Me.PurchaseOrderIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchaseOrderBindingSource, "PurchaseOrderID", True))
        Me.PurchaseOrderIDTextBox.Location = New System.Drawing.Point(216, 248)
        Me.PurchaseOrderIDTextBox.Name = "PurchaseOrderIDTextBox"
        Me.PurchaseOrderIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PurchaseOrderIDTextBox.TabIndex = 13
        '
        'SupplierIDComboBox
        '
        Me.SupplierIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PurchaseOrderBindingSource, "SupplierID", True))
        Me.SupplierIDComboBox.DataSource = Me.SupplierBindingSource
        Me.SupplierIDComboBox.DisplayMember = "Name"
        Me.SupplierIDComboBox.FormattingEnabled = True
        Me.SupplierIDComboBox.Location = New System.Drawing.Point(91, 47)
        Me.SupplierIDComboBox.Name = "SupplierIDComboBox"
        Me.SupplierIDComboBox.Size = New System.Drawing.Size(224, 21)
        Me.SupplierIDComboBox.TabIndex = 15
        Me.SupplierIDComboBox.ValueMember = "SupplierID"
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.SupplierDataSet
        '
        'SupplierDataSet
        '
        Me.SupplierDataSet.DataSetName = "SupplierDataSet"
        Me.SupplierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatePurchasedDateTimePicker
        '
        Me.DatePurchasedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PurchaseOrderBindingSource, "PODate", True))
        Me.DatePurchasedDateTimePicker.Location = New System.Drawing.Point(91, 74)
        Me.DatePurchasedDateTimePicker.Name = "DatePurchasedDateTimePicker"
        Me.DatePurchasedDateTimePicker.Size = New System.Drawing.Size(224, 20)
        Me.DatePurchasedDateTimePicker.TabIndex = 17
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchaseOrderBindingSource, "SubTotal", True))
        Me.SubTotalTextBox.Location = New System.Drawing.Point(643, 373)
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.Size = New System.Drawing.Size(94, 20)
        Me.SubTotalTextBox.TabIndex = 19
        Me.SubTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DiscountPercentTextBox
        '
        Me.DiscountPercentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchaseOrderBindingSource, "DiscountPercent", True))
        Me.DiscountPercentTextBox.Location = New System.Drawing.Point(643, 425)
        Me.DiscountPercentTextBox.Name = "DiscountPercentTextBox"
        Me.DiscountPercentTextBox.Size = New System.Drawing.Size(43, 20)
        Me.DiscountPercentTextBox.TabIndex = 21
        Me.DiscountPercentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DiscountAmountTextBox
        '
        Me.DiscountAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchaseOrderBindingSource, "DiscountAmount", True))
        Me.DiscountAmountTextBox.Location = New System.Drawing.Point(692, 425)
        Me.DiscountAmountTextBox.Name = "DiscountAmountTextBox"
        Me.DiscountAmountTextBox.Size = New System.Drawing.Size(45, 20)
        Me.DiscountAmountTextBox.TabIndex = 23
        Me.DiscountAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NetAmountTextBox
        '
        Me.NetAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchaseOrderBindingSource, "NetAmount", True))
        Me.NetAmountTextBox.Location = New System.Drawing.Point(643, 451)
        Me.NetAmountTextBox.Name = "NetAmountTextBox"
        Me.NetAmountTextBox.Size = New System.Drawing.Size(94, 20)
        Me.NetAmountTextBox.TabIndex = 25
        Me.NetAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchaseOrderBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(100, 376)
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(378, 20)
        Me.RemarksTextBox.TabIndex = 27
        '
        'PurchaseOrderDetailBindingSource
        '
        Me.PurchaseOrderDetailBindingSource.DataMember = "PurchaseOrderPurchaseOrderDetail"
        Me.PurchaseOrderDetailBindingSource.DataSource = Me.PurchaseOrderBindingSource
        '
        'PurchaseOrderDetailDataGridView
        '
        Me.PurchaseOrderDetailDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PurchaseOrderDetailDataGridView.AutoGenerateColumns = False
        Me.PurchaseOrderDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PurchaseOrderDetailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AddProduct, Me.ProductDetailID, Me.Qty, Me.UnitID, Me.QtyRecd, Me.SupplierPrice, Me.Amount})
        Me.PurchaseOrderDetailDataGridView.DataSource = Me.PurchaseOrderDetailBindingSource
        Me.PurchaseOrderDetailDataGridView.Location = New System.Drawing.Point(0, 110)
        Me.PurchaseOrderDetailDataGridView.Name = "PurchaseOrderDetailDataGridView"
        Me.PurchaseOrderDetailDataGridView.Size = New System.Drawing.Size(748, 257)
        Me.PurchaseOrderDetailDataGridView.TabIndex = 27
        '
        'AddProduct
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = "Add Product"
        Me.AddProduct.DefaultCellStyle = DataGridViewCellStyle1
        Me.AddProduct.HeaderText = "Add Product"
        Me.AddProduct.Name = "AddProduct"
        '
        'ProductDetailID
        '
        Me.ProductDetailID.DataPropertyName = "ProductDetailID"
        Me.ProductDetailID.DataSource = Me.QryProductLookupBindingSource
        Me.ProductDetailID.DisplayMember = "ProductName"
        Me.ProductDetailID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
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
        '
        'QtyRecd
        '
        Me.QtyRecd.DataPropertyName = "QtyRecd"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.QtyRecd.DefaultCellStyle = DataGridViewCellStyle3
        Me.QtyRecd.HeaderText = "Qty Recd"
        Me.QtyRecd.Name = "QtyRecd"
        '
        'SupplierPrice
        '
        Me.SupplierPrice.DataPropertyName = "SupplierPrice"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SupplierPrice.DefaultCellStyle = DataGridViewCellStyle4
        Me.SupplierPrice.HeaderText = "Supplier Price"
        Me.SupplierPrice.Name = "SupplierPrice"
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "Amount"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle5
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        '
        'PurchaseOrderTableAdapter
        '
        Me.PurchaseOrderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PurchaseOrderDetailTableAdapter = Me.PurchaseOrderDetailTableAdapter
        Me.TableAdapterManager.PurchaseOrderTableAdapter = Me.PurchaseOrderTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sales_And_Inventory_System.PurchaseOrderDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PurchaseOrderDetailTableAdapter
        '
        Me.PurchaseOrderDetailTableAdapter.ClearBeforeFill = True
        '
        'Qry_ProductLookupTableAdapter
        '
        Me.Qry_ProductLookupTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(539, 428)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Discount:"
        '
        'PONumberTextBox
        '
        Me.PONumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchaseOrderBindingSource, "PONumber", True))
        Me.PONumberTextBox.Location = New System.Drawing.Point(405, 48)
        Me.PONumberTextBox.Name = "PONumberTextBox"
        Me.PONumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PONumberTextBox.TabIndex = 29
        '
        'DateCreatedDateTimePicker
        '
        Me.DateCreatedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PurchaseOrderBindingSource, "DateCreated", True))
        Me.DateCreatedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateCreatedDateTimePicker.Location = New System.Drawing.Point(405, 74)
        Me.DateCreatedDateTimePicker.Name = "DateCreatedDateTimePicker"
        Me.DateCreatedDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.DateCreatedDateTimePicker.TabIndex = 30
        '
        'CreatedByTextBox
        '
        Me.CreatedByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchaseOrderBindingSource, "CreatedBy", True))
        Me.CreatedByTextBox.Location = New System.Drawing.Point(100, 402)
        Me.CreatedByTextBox.Name = "CreatedByTextBox"
        Me.CreatedByTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CreatedByTextBox.TabIndex = 31
        '
        'ApprovedByTextBox
        '
        Me.ApprovedByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchaseOrderBindingSource, "ApprovedBy", True))
        Me.ApprovedByTextBox.Location = New System.Drawing.Point(100, 428)
        Me.ApprovedByTextBox.Name = "ApprovedByTextBox"
        Me.ApprovedByTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApprovedByTextBox.TabIndex = 32
        '
        'DateApprovedDateTimePicker
        '
        Me.DateApprovedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PurchaseOrderBindingSource, "DateApproved", True))
        Me.DateApprovedDateTimePicker.Location = New System.Drawing.Point(100, 454)
        Me.DateApprovedDateTimePicker.Name = "DateApprovedDateTimePicker"
        Me.DateApprovedDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateApprovedDateTimePicker.TabIndex = 33
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 494)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(748, 40)
        Me.Panel2.TabIndex = 41
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(585, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 34)
        Me.btnSave.TabIndex = 40
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(667, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 34)
        Me.btnClose.TabIndex = 28
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'OrderStatusComboBox
        '
        Me.OrderStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchaseOrderBindingSource, "OrderStatus", True))
        Me.OrderStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OrderStatusComboBox.FormattingEnabled = True
        Me.OrderStatusComboBox.Items.AddRange(New Object() {"For Approval", "Approved", "Received (Incomplete)", "Received (Complete)", "Cancelled"})
        Me.OrderStatusComboBox.Location = New System.Drawing.Point(585, 47)
        Me.OrderStatusComboBox.Name = "OrderStatusComboBox"
        Me.OrderStatusComboBox.Size = New System.Drawing.Size(121, 21)
        Me.OrderStatusComboBox.TabIndex = 42
        '
        'frmPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 534)
        Me.Controls.Add(OrderStatusLabel)
        Me.Controls.Add(Me.OrderStatusComboBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(DateApprovedLabel)
        Me.Controls.Add(Me.DateApprovedDateTimePicker)
        Me.Controls.Add(ApprovedByLabel)
        Me.Controls.Add(Me.ApprovedByTextBox)
        Me.Controls.Add(CreatedByLabel)
        Me.Controls.Add(Me.CreatedByTextBox)
        Me.Controls.Add(DateCreatedLabel)
        Me.Controls.Add(Me.DateCreatedDateTimePicker)
        Me.Controls.Add(PONumberLabel)
        Me.Controls.Add(Me.PONumberTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PurchaseOrderDetailDataGridView)
        Me.Controls.Add(PurchaseOrderIDLabel)
        Me.Controls.Add(Me.PurchaseOrderIDTextBox)
        Me.Controls.Add(SupplierIDLabel)
        Me.Controls.Add(Me.SupplierIDComboBox)
        Me.Controls.Add(DatePurchasedLabel)
        Me.Controls.Add(Me.DatePurchasedDateTimePicker)
        Me.Controls.Add(SubTotalLabel)
        Me.Controls.Add(Me.SubTotalTextBox)
        Me.Controls.Add(DiscountPercentLabel)
        Me.Controls.Add(Me.DiscountPercentTextBox)
        Me.Controls.Add(DiscountAmountLabel)
        Me.Controls.Add(Me.DiscountAmountTextBox)
        Me.Controls.Add(NetAmountLabel)
        Me.Controls.Add(Me.NetAmountTextBox)
        Me.Controls.Add(RemarksLabel)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Controls.Add(Me.PurchaseOrderBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPurchaseOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPurchaseOrder"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PurchaseOrderBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PurchaseOrderBindingNavigator.ResumeLayout(False)
        Me.PurchaseOrderBindingNavigator.PerformLayout()
        CType(Me.PurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseOrderDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseOrderDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseOrderDetailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryProductLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PurchaseOrderDataSet As Sales_And_Inventory_System.PurchaseOrderDataSet
    Friend WithEvents PurchaseOrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PurchaseOrderTableAdapter As Sales_And_Inventory_System.PurchaseOrderDataSetTableAdapters.PurchaseOrderTableAdapter
    Friend WithEvents TableAdapterManager As Sales_And_Inventory_System.PurchaseOrderDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PurchaseOrderBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PurchaseOrderBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PurchaseOrderIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DatePurchasedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SubTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiscountPercentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiscountAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NetAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PurchaseOrderDetailTableAdapter As Sales_And_Inventory_System.PurchaseOrderDataSetTableAdapters.PurchaseOrderDetailTableAdapter
    Friend WithEvents PurchaseOrderDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PurchaseOrderDetailDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ProductLookupDataSet As Sales_And_Inventory_System.ProductLookupDataSet
    Friend WithEvents QryProductLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Qry_ProductLookupTableAdapter As Sales_And_Inventory_System.ProductLookupDataSetTableAdapters.qry_ProductLookupTableAdapter
    Friend WithEvents SupplierDataSet As Sales_And_Inventory_System.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As Sales_And_Inventory_System.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PONumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateCreatedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CreatedByTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApprovedByTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateApprovedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents OrderStatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AddProduct As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ProductDetailID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents QtyRecd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
