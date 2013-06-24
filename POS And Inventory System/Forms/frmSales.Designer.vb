<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Dim SalesIDLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim DiscountAmountLabel As System.Windows.Forms.Label
        Dim DiscountPercentLabel As System.Windows.Forms.Label
        Dim NetLabel As System.Windows.Forms.Label
        Dim VATLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSales))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SalesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesDataSet = New Sales_And_Inventory_System.SalesDataSet()
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
        Me.SalesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SalesIDTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CustomerIDComboBox = New System.Windows.Forms.ComboBox()
        Me.QryCustomerLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerLookupDataSet = New Sales_And_Inventory_System.CustomerLookupDataSet()
        Me.DiscountAmountTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountPercentTextBox = New System.Windows.Forms.TextBox()
        Me.NetTextBox = New System.Windows.Forms.TextBox()
        Me.SalesDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesDetailDataGridView = New System.Windows.Forms.DataGridView()
        Me.AddProduct = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ProductDetailID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.QryProductLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductLookupDataSet = New Sales_And_Inventory_System.ProductLookupDataSet()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellingPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountPercent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qry_ProductLookupTableAdapter = New Sales_And_Inventory_System.ProductLookupDataSetTableAdapters.qry_ProductLookupTableAdapter()
        Me.SalesTableAdapter = New Sales_And_Inventory_System.SalesDataSetTableAdapters.SalesTableAdapter()
        Me.TableAdapterManager = New Sales_And_Inventory_System.SalesDataSetTableAdapters.TableAdapterManager()
        Me.SalesDetailTableAdapter = New Sales_And_Inventory_System.SalesDataSetTableAdapters.SalesDetailTableAdapter()
        Me.Qry_CustomerLookupTableAdapter = New Sales_And_Inventory_System.CustomerLookupDataSetTableAdapters.qry_CustomerLookupTableAdapter()
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSettle = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCheck = New System.Windows.Forms.TextBox()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.TaxBaseTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.VATTextBox = New System.Windows.Forms.TextBox()
        SalesIDLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        DiscountAmountLabel = New System.Windows.Forms.Label()
        DiscountPercentLabel = New System.Windows.Forms.Label()
        NetLabel = New System.Windows.Forms.Label()
        VATLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.SalesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SalesBindingNavigator.SuspendLayout()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryCustomerLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesDetailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryProductLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SalesIDLabel
        '
        SalesIDLabel.AutoSize = True
        SalesIDLabel.Location = New System.Drawing.Point(168, 248)
        SalesIDLabel.Name = "SalesIDLabel"
        SalesIDLabel.Size = New System.Drawing.Size(50, 13)
        SalesIDLabel.TabIndex = 12
        SalesIDLabel.Text = "Sales ID:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(21, 85)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 14
        DateLabel.Text = "Date:"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(21, 57)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(54, 13)
        CustomerIDLabel.TabIndex = 16
        CustomerIDLabel.Text = "Customer:"
        '
        'DiscountAmountLabel
        '
        DiscountAmountLabel.AutoSize = True
        DiscountAmountLabel.Location = New System.Drawing.Point(632, 364)
        DiscountAmountLabel.Name = "DiscountAmountLabel"
        DiscountAmountLabel.Size = New System.Drawing.Size(43, 13)
        DiscountAmountLabel.TabIndex = 20
        DiscountAmountLabel.Text = "Amount"
        '
        'DiscountPercentLabel
        '
        DiscountPercentLabel.AutoSize = True
        DiscountPercentLabel.Location = New System.Drawing.Point(688, 364)
        DiscountPercentLabel.Name = "DiscountPercentLabel"
        DiscountPercentLabel.Size = New System.Drawing.Size(44, 13)
        DiscountPercentLabel.TabIndex = 22
        DiscountPercentLabel.Text = "Percent"
        '
        'NetLabel
        '
        NetLabel.AutoSize = True
        NetLabel.Location = New System.Drawing.Point(602, 411)
        NetLabel.Name = "NetLabel"
        NetLabel.Size = New System.Drawing.Size(27, 13)
        NetLabel.TabIndex = 24
        NetLabel.Text = "Net:"
        '
        'VATLabel
        '
        VATLabel.AutoSize = True
        VATLabel.Location = New System.Drawing.Point(379, 411)
        VATLabel.Name = "VATLabel"
        VATLabel.Size = New System.Drawing.Size(54, 13)
        VATLabel.TabIndex = 46
        VATLabel.Text = "12% VAT:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(744, 39)
        Me.Panel1.TabIndex = 11
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(684, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(57, 33)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Point of Sale"
        '
        'SalesBindingNavigator
        '
        Me.SalesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SalesBindingNavigator.BindingSource = Me.SalesBindingSource
        Me.SalesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SalesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SalesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SalesBindingNavigatorSaveItem})
        Me.SalesBindingNavigator.Location = New System.Drawing.Point(0, 39)
        Me.SalesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SalesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SalesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SalesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SalesBindingNavigator.Name = "SalesBindingNavigator"
        Me.SalesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SalesBindingNavigator.Size = New System.Drawing.Size(689, 25)
        Me.SalesBindingNavigator.TabIndex = 12
        Me.SalesBindingNavigator.Text = "BindingNavigator1"
        Me.SalesBindingNavigator.Visible = False
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
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "Sales"
        Me.SalesBindingSource.DataSource = Me.SalesDataSet
        '
        'SalesDataSet
        '
        Me.SalesDataSet.DataSetName = "SalesDataSet"
        Me.SalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'SalesBindingNavigatorSaveItem
        '
        Me.SalesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SalesBindingNavigatorSaveItem.Image = CType(resources.GetObject("SalesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SalesBindingNavigatorSaveItem.Name = "SalesBindingNavigatorSaveItem"
        Me.SalesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SalesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SalesIDTextBox
        '
        Me.SalesIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "SalesID", True))
        Me.SalesIDTextBox.Location = New System.Drawing.Point(266, 245)
        Me.SalesIDTextBox.Name = "SalesIDTextBox"
        Me.SalesIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SalesIDTextBox.TabIndex = 13
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SalesBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(81, 81)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 15
        '
        'CustomerIDComboBox
        '
        Me.CustomerIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SalesBindingSource, "CustomerID", True))
        Me.CustomerIDComboBox.DataSource = Me.QryCustomerLookupBindingSource
        Me.CustomerIDComboBox.DisplayMember = "Name"
        Me.CustomerIDComboBox.FormattingEnabled = True
        Me.CustomerIDComboBox.Location = New System.Drawing.Point(81, 54)
        Me.CustomerIDComboBox.Name = "CustomerIDComboBox"
        Me.CustomerIDComboBox.Size = New System.Drawing.Size(200, 21)
        Me.CustomerIDComboBox.TabIndex = 17
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
        'DiscountAmountTextBox
        '
        Me.DiscountAmountTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DiscountAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "DiscountAmount", True))
        Me.DiscountAmountTextBox.Location = New System.Drawing.Point(635, 382)
        Me.DiscountAmountTextBox.Name = "DiscountAmountTextBox"
        Me.DiscountAmountTextBox.ReadOnly = True
        Me.DiscountAmountTextBox.Size = New System.Drawing.Size(45, 20)
        Me.DiscountAmountTextBox.TabIndex = 21
        Me.DiscountAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DiscountPercentTextBox
        '
        Me.DiscountPercentTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DiscountPercentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "DiscountPercent", True))
        Me.DiscountPercentTextBox.Location = New System.Drawing.Point(686, 382)
        Me.DiscountPercentTextBox.Name = "DiscountPercentTextBox"
        Me.DiscountPercentTextBox.ReadOnly = True
        Me.DiscountPercentTextBox.Size = New System.Drawing.Size(46, 20)
        Me.DiscountPercentTextBox.TabIndex = 23
        Me.DiscountPercentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NetTextBox
        '
        Me.NetTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.NetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "Net", True))
        Me.NetTextBox.Location = New System.Drawing.Point(635, 408)
        Me.NetTextBox.Name = "NetTextBox"
        Me.NetTextBox.ReadOnly = True
        Me.NetTextBox.Size = New System.Drawing.Size(97, 20)
        Me.NetTextBox.TabIndex = 25
        Me.NetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesDetailBindingSource
        '
        Me.SalesDetailBindingSource.DataMember = "SalesSalesDetail"
        Me.SalesDetailBindingSource.DataSource = Me.SalesBindingSource
        '
        'SalesDetailDataGridView
        '
        Me.SalesDetailDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SalesDetailDataGridView.AutoGenerateColumns = False
        Me.SalesDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalesDetailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AddProduct, Me.ProductDetailID, Me.Qty, Me.SellingPrice, Me.DiscountPercent, Me.DiscountAmount, Me.Amount})
        Me.SalesDetailDataGridView.DataSource = Me.SalesDetailBindingSource
        Me.SalesDetailDataGridView.Location = New System.Drawing.Point(0, 107)
        Me.SalesDetailDataGridView.Name = "SalesDetailDataGridView"
        Me.SalesDetailDataGridView.Size = New System.Drawing.Size(744, 241)
        Me.SalesDetailDataGridView.TabIndex = 25
        '
        'AddProduct
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = "Add Product"
        Me.AddProduct.DefaultCellStyle = DataGridViewCellStyle1
        Me.AddProduct.Frozen = True
        Me.AddProduct.HeaderText = "Add Product"
        Me.AddProduct.Name = "AddProduct"
        Me.AddProduct.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AddProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.AddProduct.Text = "Add Product"
        Me.AddProduct.UseColumnTextForButtonValue = True
        Me.AddProduct.Width = 90
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
        Me.ProductDetailID.Width = 300
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
        'SellingPrice
        '
        Me.SellingPrice.DataPropertyName = "SellingPrice"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SellingPrice.DefaultCellStyle = DataGridViewCellStyle3
        Me.SellingPrice.HeaderText = "SellingPrice"
        Me.SellingPrice.Name = "SellingPrice"
        '
        'DiscountPercent
        '
        Me.DiscountPercent.DataPropertyName = "DiscountPercent"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DiscountPercent.DefaultCellStyle = DataGridViewCellStyle4
        Me.DiscountPercent.HeaderText = "Discount (%)"
        Me.DiscountPercent.Name = "DiscountPercent"
        '
        'DiscountAmount
        '
        Me.DiscountAmount.DataPropertyName = "DiscountAmount"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DiscountAmount.DefaultCellStyle = DataGridViewCellStyle5
        Me.DiscountAmount.HeaderText = "Discount (Amt)"
        Me.DiscountAmount.Name = "DiscountAmount"
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "Amount"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle6
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        '
        'Qry_ProductLookupTableAdapter
        '
        Me.Qry_ProductLookupTableAdapter.ClearBeforeFill = True
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SalesDetailTableAdapter = Me.SalesDetailTableAdapter
        Me.TableAdapterManager.SalesTableAdapter = Me.SalesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sales_And_Inventory_System.SalesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SalesDetailTableAdapter
        '
        Me.SalesDetailTableAdapter.ClearBeforeFill = True
        '
        'Qry_CustomerLookupTableAdapter
        '
        Me.Qry_CustomerLookupTableAdapter.ClearBeforeFill = True
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Location = New System.Drawing.Point(287, 53)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(28, 21)
        Me.btnAddCustomer.TabIndex = 27
        Me.btnAddCustomer.Text = ">>"
        Me.btnAddCustomer.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel2.Controls.Add(Me.btnVoid)
        Me.Panel2.Controls.Add(Me.btnPay)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.btnNew)
        Me.Panel2.Controls.Add(Me.btnSettle)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 464)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(744, 40)
        Me.Panel2.TabIndex = 40
        '
        'btnVoid
        '
        Me.btnVoid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVoid.Location = New System.Drawing.Point(93, 4)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(75, 33)
        Me.btnVoid.TabIndex = 41
        Me.btnVoid.Tag = ""
        Me.btnVoid.Text = "&Void"
        Me.btnVoid.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPay.Location = New System.Drawing.Point(581, 3)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 34)
        Me.btnPay.TabIndex = 40
        Me.btnPay.Text = "F6 - Pa&y"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(11, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 34)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "F7 - &Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.Location = New System.Drawing.Point(500, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 34)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "F4 - &Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.Location = New System.Drawing.Point(416, 4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 34)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "F5 - &New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSettle
        '
        Me.btnSettle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSettle.Location = New System.Drawing.Point(663, 3)
        Me.btnSettle.Name = "btnSettle"
        Me.btnSettle.Size = New System.Drawing.Size(75, 34)
        Me.btnSettle.TabIndex = 28
        Me.btnSettle.Text = "F3 - &Settle"
        Me.btnSettle.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCheck)
        Me.GroupBox1.Controls.Add(Me.txtCash)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 364)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 80)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Check:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cash:"
        '
        'txtCheck
        '
        Me.txtCheck.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCheck.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "Check", True))
        Me.txtCheck.Location = New System.Drawing.Point(65, 46)
        Me.txtCheck.Name = "txtCheck"
        Me.txtCheck.ReadOnly = True
        Me.txtCheck.Size = New System.Drawing.Size(87, 20)
        Me.txtCheck.TabIndex = 1
        Me.txtCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCash.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "Cash", True))
        Me.txtCash.Location = New System.Drawing.Point(65, 19)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.ReadOnly = True
        Me.txtCash.Size = New System.Drawing.Size(87, 20)
        Me.txtCash.TabIndex = 0
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(577, 385)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Discount:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(582, 438)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Change:"
        '
        'txtChange
        '
        Me.txtChange.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtChange.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "Change", True))
        Me.txtChange.Location = New System.Drawing.Point(635, 435)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(97, 20)
        Me.txtChange.TabIndex = 44
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TaxBaseTextBox
        '
        Me.TaxBaseTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TaxBaseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "TaxBase", True))
        Me.TaxBaseTextBox.Location = New System.Drawing.Point(439, 382)
        Me.TaxBaseTextBox.Name = "TaxBaseTextBox"
        Me.TaxBaseTextBox.ReadOnly = True
        Me.TaxBaseTextBox.Size = New System.Drawing.Size(97, 20)
        Me.TaxBaseTextBox.TabIndex = 45
        Me.TaxBaseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(378, 385)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Tax Base:"
        '
        'VATTextBox
        '
        Me.VATTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.VATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesBindingSource, "VAT", True))
        Me.VATTextBox.Location = New System.Drawing.Point(439, 408)
        Me.VATTextBox.Name = "VATTextBox"
        Me.VATTextBox.ReadOnly = True
        Me.VATTextBox.Size = New System.Drawing.Size(97, 20)
        Me.VATTextBox.TabIndex = 47
        Me.VATTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 504)
        Me.Controls.Add(VATLabel)
        Me.Controls.Add(Me.VATTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TaxBaseTextBox)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnAddCustomer)
        Me.Controls.Add(Me.SalesDetailDataGridView)
        Me.Controls.Add(SalesIDLabel)
        Me.Controls.Add(Me.SalesIDTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDComboBox)
        Me.Controls.Add(DiscountAmountLabel)
        Me.Controls.Add(Me.DiscountAmountTextBox)
        Me.Controls.Add(DiscountPercentLabel)
        Me.Controls.Add(Me.DiscountPercentTextBox)
        Me.Controls.Add(NetLabel)
        Me.Controls.Add(Me.NetTextBox)
        Me.Controls.Add(Me.SalesBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSales"
        Me.Text = "Sales"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.SalesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SalesBindingNavigator.ResumeLayout(False)
        Me.SalesBindingNavigator.PerformLayout()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryCustomerLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesDetailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryProductLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SalesDataSet As Sales_And_Inventory_System.SalesDataSet
    Friend WithEvents SalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesTableAdapter As Sales_And_Inventory_System.SalesDataSetTableAdapters.SalesTableAdapter
    Friend WithEvents TableAdapterManager As Sales_And_Inventory_System.SalesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SalesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SalesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SalesDetailTableAdapter As Sales_And_Inventory_System.SalesDataSetTableAdapters.SalesDetailTableAdapter
    Friend WithEvents SalesIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CustomerIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DiscountAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiscountPercentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalesDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesDetailDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ProductLookupDataSet As Sales_And_Inventory_System.ProductLookupDataSet
    Friend WithEvents QryProductLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Qry_ProductLookupTableAdapter As Sales_And_Inventory_System.ProductLookupDataSetTableAdapters.qry_ProductLookupTableAdapter
    Friend WithEvents CustomerLookupDataSet As Sales_And_Inventory_System.CustomerLookupDataSet
    Friend WithEvents QryCustomerLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Qry_CustomerLookupTableAdapter As Sales_And_Inventory_System.CustomerLookupDataSetTableAdapters.qry_CustomerLookupTableAdapter
    Friend WithEvents btnAddCustomer As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnVoid As System.Windows.Forms.Button
    Friend WithEvents btnPay As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSettle As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCheck As System.Windows.Forms.TextBox
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents AddProduct As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ProductDetailID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SellingPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiscountPercent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiscountAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaxBaseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents VATTextBox As System.Windows.Forms.TextBox
End Class
