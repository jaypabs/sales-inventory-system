<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductReceive
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
        Dim ProductReceiveIDLabel As System.Windows.Forms.Label
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim InvoiceNoLabel As System.Windows.Forms.Label
        Dim RefNoLabel As System.Windows.Forms.Label
        Dim DateReceivedLabel As System.Windows.Forms.Label
        Dim DiscountPercentLabel As System.Windows.Forms.Label
        Dim DiscountAmountLabel As System.Windows.Forms.Label
        Dim NetLabel As System.Windows.Forms.Label
        Dim PONumberLabel As System.Windows.Forms.Label
        Dim ReceiveStatusLabel As System.Windows.Forms.Label
        Dim SubTotalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductReceive))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ProductReceiveBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductReceiveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductReceiveDataSet = New Sales_And_Inventory_System.ProductReceiveDataSet()
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
        Me.ProductReceiveBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductReceiveIDTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierIDComboBox = New System.Windows.Forms.ComboBox()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDataSet = New Sales_And_Inventory_System.SupplierDataSet()
        Me.InvoiceNoTextBox = New System.Windows.Forms.TextBox()
        Me.RefNoTextBox = New System.Windows.Forms.TextBox()
        Me.DateReceivedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DiscountPercentTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountAmountTextBox = New System.Windows.Forms.TextBox()
        Me.NetTextBox = New System.Windows.Forms.TextBox()
        Me.PONumberTextBox = New System.Windows.Forms.TextBox()
        Me.ReceiveStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProductReceiveDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductReceiveDetailDataGridView = New System.Windows.Forms.DataGridView()
        Me.QryProductLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductLookupDataSet = New Sales_And_Inventory_System.ProductLookupDataSet()
        Me.Qry_ProductLookupTableAdapter = New Sales_And_Inventory_System.ProductLookupDataSetTableAdapters.qry_ProductLookupTableAdapter()
        Me.btnSOLookup = New System.Windows.Forms.Button()
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.ProductReceiveTableAdapter = New Sales_And_Inventory_System.ProductReceiveDataSetTableAdapters.ProductReceiveTableAdapter()
        Me.TableAdapterManager = New Sales_And_Inventory_System.ProductReceiveDataSetTableAdapters.TableAdapterManager()
        Me.ProductReceiveDetailTableAdapter = New Sales_And_Inventory_System.ProductReceiveDataSetTableAdapters.ProductReceiveDetailTableAdapter()
        Me.SupplierTableAdapter = New Sales_And_Inventory_System.SupplierDataSetTableAdapters.SupplierTableAdapter()
        Me.AddProduct = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ProductDetailID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ProductReceiveIDLabel = New System.Windows.Forms.Label()
        SupplierIDLabel = New System.Windows.Forms.Label()
        InvoiceNoLabel = New System.Windows.Forms.Label()
        RefNoLabel = New System.Windows.Forms.Label()
        DateReceivedLabel = New System.Windows.Forms.Label()
        DiscountPercentLabel = New System.Windows.Forms.Label()
        DiscountAmountLabel = New System.Windows.Forms.Label()
        NetLabel = New System.Windows.Forms.Label()
        PONumberLabel = New System.Windows.Forms.Label()
        ReceiveStatusLabel = New System.Windows.Forms.Label()
        SubTotalLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ProductReceiveBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductReceiveBindingNavigator.SuspendLayout()
        CType(Me.ProductReceiveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductReceiveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductReceiveDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductReceiveDetailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryProductLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductReceiveIDLabel
        '
        ProductReceiveIDLabel.AutoSize = True
        ProductReceiveIDLabel.Location = New System.Drawing.Point(178, 216)
        ProductReceiveIDLabel.Name = "ProductReceiveIDLabel"
        ProductReceiveIDLabel.Size = New System.Drawing.Size(104, 13)
        ProductReceiveIDLabel.TabIndex = 49
        ProductReceiveIDLabel.Text = "Product Receive ID:"
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.AutoSize = True
        SupplierIDLabel.Location = New System.Drawing.Point(20, 50)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(48, 13)
        SupplierIDLabel.TabIndex = 51
        SupplierIDLabel.Text = "Supplier:"
        '
        'InvoiceNoLabel
        '
        InvoiceNoLabel.AutoSize = True
        InvoiceNoLabel.Location = New System.Drawing.Point(20, 77)
        InvoiceNoLabel.Name = "InvoiceNoLabel"
        InvoiceNoLabel.Size = New System.Drawing.Size(62, 13)
        InvoiceNoLabel.TabIndex = 53
        InvoiceNoLabel.Text = "Invoice No:"
        '
        'RefNoLabel
        '
        RefNoLabel.AutoSize = True
        RefNoLabel.Location = New System.Drawing.Point(444, 77)
        RefNoLabel.Name = "RefNoLabel"
        RefNoLabel.Size = New System.Drawing.Size(44, 13)
        RefNoLabel.TabIndex = 55
        RefNoLabel.Text = "Ref No:"
        '
        'DateReceivedLabel
        '
        DateReceivedLabel.AutoSize = True
        DateReceivedLabel.Location = New System.Drawing.Point(20, 103)
        DateReceivedLabel.Name = "DateReceivedLabel"
        DateReceivedLabel.Size = New System.Drawing.Size(82, 13)
        DateReceivedLabel.TabIndex = 57
        DateReceivedLabel.Text = "Date Received:"
        '
        'DiscountPercentLabel
        '
        DiscountPercentLabel.AutoSize = True
        DiscountPercentLabel.Location = New System.Drawing.Point(560, 370)
        DiscountPercentLabel.Name = "DiscountPercentLabel"
        DiscountPercentLabel.Size = New System.Drawing.Size(44, 13)
        DiscountPercentLabel.TabIndex = 59
        DiscountPercentLabel.Text = "Percent"
        '
        'DiscountAmountLabel
        '
        DiscountAmountLabel.AutoSize = True
        DiscountAmountLabel.Location = New System.Drawing.Point(612, 370)
        DiscountAmountLabel.Name = "DiscountAmountLabel"
        DiscountAmountLabel.Size = New System.Drawing.Size(43, 13)
        DiscountAmountLabel.TabIndex = 61
        DiscountAmountLabel.Text = "Amount"
        '
        'NetLabel
        '
        NetLabel.AutoSize = True
        NetLabel.Location = New System.Drawing.Point(530, 415)
        NetLabel.Name = "NetLabel"
        NetLabel.Size = New System.Drawing.Size(27, 13)
        NetLabel.TabIndex = 63
        NetLabel.Text = "Net:"
        '
        'PONumberLabel
        '
        PONumberLabel.AutoSize = True
        PONumberLabel.Location = New System.Drawing.Point(417, 50)
        PONumberLabel.Name = "PONumberLabel"
        PONumberLabel.Size = New System.Drawing.Size(71, 13)
        PONumberLabel.TabIndex = 67
        PONumberLabel.Text = "P.O. Number:"
        '
        'ReceiveStatusLabel
        '
        ReceiveStatusLabel.AutoSize = True
        ReceiveStatusLabel.Location = New System.Drawing.Point(405, 101)
        ReceiveStatusLabel.Name = "ReceiveStatusLabel"
        ReceiveStatusLabel.Size = New System.Drawing.Size(83, 13)
        ReceiveStatusLabel.TabIndex = 68
        ReceiveStatusLabel.Text = "Receive Status:"
        '
        'SubTotalLabel
        '
        SubTotalLabel.AutoSize = True
        SubTotalLabel.Location = New System.Drawing.Point(501, 350)
        SubTotalLabel.Name = "SubTotalLabel"
        SubTotalLabel.Size = New System.Drawing.Size(56, 13)
        SubTotalLabel.TabIndex = 73
        SubTotalLabel.Text = "Sub Total:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 39)
        Me.Panel1.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Receive Product"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 441)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(684, 40)
        Me.Panel2.TabIndex = 48
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(-103, 0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 38)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(606, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 34)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(526, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 34)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ProductReceiveBindingNavigator
        '
        Me.ProductReceiveBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductReceiveBindingNavigator.BindingSource = Me.ProductReceiveBindingSource
        Me.ProductReceiveBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductReceiveBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductReceiveBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductReceiveBindingNavigatorSaveItem})
        Me.ProductReceiveBindingNavigator.Location = New System.Drawing.Point(0, 40)
        Me.ProductReceiveBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductReceiveBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductReceiveBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductReceiveBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductReceiveBindingNavigator.Name = "ProductReceiveBindingNavigator"
        Me.ProductReceiveBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductReceiveBindingNavigator.Size = New System.Drawing.Size(684, 25)
        Me.ProductReceiveBindingNavigator.TabIndex = 49
        Me.ProductReceiveBindingNavigator.Text = "BindingNavigator1"
        Me.ProductReceiveBindingNavigator.Visible = False
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
        'ProductReceiveBindingSource
        '
        Me.ProductReceiveBindingSource.DataMember = "ProductReceive"
        Me.ProductReceiveBindingSource.DataSource = Me.ProductReceiveDataSet
        '
        'ProductReceiveDataSet
        '
        Me.ProductReceiveDataSet.DataSetName = "ProductReceiveDataSet"
        Me.ProductReceiveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ProductReceiveBindingNavigatorSaveItem
        '
        Me.ProductReceiveBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductReceiveBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductReceiveBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductReceiveBindingNavigatorSaveItem.Name = "ProductReceiveBindingNavigatorSaveItem"
        Me.ProductReceiveBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProductReceiveBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProductReceiveIDTextBox
        '
        Me.ProductReceiveIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductReceiveBindingSource, "ProductReceiveID", True))
        Me.ProductReceiveIDTextBox.Location = New System.Drawing.Point(288, 213)
        Me.ProductReceiveIDTextBox.Name = "ProductReceiveIDTextBox"
        Me.ProductReceiveIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ProductReceiveIDTextBox.TabIndex = 50
        '
        'SupplierIDComboBox
        '
        Me.SupplierIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductReceiveBindingSource, "SupplierID", True))
        Me.SupplierIDComboBox.DataSource = Me.SupplierBindingSource
        Me.SupplierIDComboBox.DisplayMember = "Name"
        Me.SupplierIDComboBox.FormattingEnabled = True
        Me.SupplierIDComboBox.Location = New System.Drawing.Point(102, 47)
        Me.SupplierIDComboBox.Name = "SupplierIDComboBox"
        Me.SupplierIDComboBox.Size = New System.Drawing.Size(200, 21)
        Me.SupplierIDComboBox.TabIndex = 52
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
        'InvoiceNoTextBox
        '
        Me.InvoiceNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductReceiveBindingSource, "InvoiceNo", True))
        Me.InvoiceNoTextBox.Location = New System.Drawing.Point(102, 74)
        Me.InvoiceNoTextBox.Name = "InvoiceNoTextBox"
        Me.InvoiceNoTextBox.Size = New System.Drawing.Size(85, 20)
        Me.InvoiceNoTextBox.TabIndex = 54
        '
        'RefNoTextBox
        '
        Me.RefNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductReceiveBindingSource, "RefNo", True))
        Me.RefNoTextBox.Location = New System.Drawing.Point(494, 74)
        Me.RefNoTextBox.Name = "RefNoTextBox"
        Me.RefNoTextBox.Size = New System.Drawing.Size(103, 20)
        Me.RefNoTextBox.TabIndex = 56
        '
        'DateReceivedDateTimePicker
        '
        Me.DateReceivedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductReceiveBindingSource, "DateReceived", True))
        Me.DateReceivedDateTimePicker.Location = New System.Drawing.Point(102, 99)
        Me.DateReceivedDateTimePicker.Name = "DateReceivedDateTimePicker"
        Me.DateReceivedDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateReceivedDateTimePicker.TabIndex = 58
        '
        'DiscountPercentTextBox
        '
        Me.DiscountPercentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductReceiveBindingSource, "DiscountPercent", True))
        Me.DiscountPercentTextBox.Location = New System.Drawing.Point(563, 386)
        Me.DiscountPercentTextBox.Name = "DiscountPercentTextBox"
        Me.DiscountPercentTextBox.Size = New System.Drawing.Size(46, 20)
        Me.DiscountPercentTextBox.TabIndex = 60
        Me.DiscountPercentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DiscountAmountTextBox
        '
        Me.DiscountAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductReceiveBindingSource, "DiscountAmount", True))
        Me.DiscountAmountTextBox.Location = New System.Drawing.Point(615, 386)
        Me.DiscountAmountTextBox.Name = "DiscountAmountTextBox"
        Me.DiscountAmountTextBox.Size = New System.Drawing.Size(46, 20)
        Me.DiscountAmountTextBox.TabIndex = 62
        Me.DiscountAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NetTextBox
        '
        Me.NetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductReceiveBindingSource, "Net", True))
        Me.NetTextBox.Location = New System.Drawing.Point(563, 412)
        Me.NetTextBox.Name = "NetTextBox"
        Me.NetTextBox.Size = New System.Drawing.Size(98, 20)
        Me.NetTextBox.TabIndex = 64
        Me.NetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PONumberTextBox
        '
        Me.PONumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductReceiveBindingSource, "PONumber", True))
        Me.PONumberTextBox.Location = New System.Drawing.Point(494, 47)
        Me.PONumberTextBox.Name = "PONumberTextBox"
        Me.PONumberTextBox.Size = New System.Drawing.Size(71, 20)
        Me.PONumberTextBox.TabIndex = 68
        '
        'ReceiveStatusComboBox
        '
        Me.ReceiveStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductReceiveBindingSource, "ReceiveStatus", True))
        Me.ReceiveStatusComboBox.FormattingEnabled = True
        Me.ReceiveStatusComboBox.Items.AddRange(New Object() {"For Approval", "Approved"})
        Me.ReceiveStatusComboBox.Location = New System.Drawing.Point(494, 98)
        Me.ReceiveStatusComboBox.Name = "ReceiveStatusComboBox"
        Me.ReceiveStatusComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ReceiveStatusComboBox.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(505, 389)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Discount:"
        '
        'ProductReceiveDetailBindingSource
        '
        Me.ProductReceiveDetailBindingSource.DataMember = "ProductReceiveProductReceiveDetail"
        Me.ProductReceiveDetailBindingSource.DataSource = Me.ProductReceiveBindingSource
        '
        'ProductReceiveDetailDataGridView
        '
        Me.ProductReceiveDetailDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductReceiveDetailDataGridView.AutoGenerateColumns = False
        Me.ProductReceiveDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductReceiveDetailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AddProduct, Me.ProductDetailID, Me.Qty, Me.UnitID, Me.SupplierPrice, Me.Amount})
        Me.ProductReceiveDetailDataGridView.DataSource = Me.ProductReceiveDetailBindingSource
        Me.ProductReceiveDetailDataGridView.Location = New System.Drawing.Point(0, 125)
        Me.ProductReceiveDetailDataGridView.Name = "ProductReceiveDetailDataGridView"
        Me.ProductReceiveDetailDataGridView.Size = New System.Drawing.Size(684, 210)
        Me.ProductReceiveDetailDataGridView.TabIndex = 70
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
        'Qry_ProductLookupTableAdapter
        '
        Me.Qry_ProductLookupTableAdapter.ClearBeforeFill = True
        '
        'btnSOLookup
        '
        Me.btnSOLookup.Location = New System.Drawing.Point(572, 45)
        Me.btnSOLookup.Name = "btnSOLookup"
        Me.btnSOLookup.Size = New System.Drawing.Size(25, 22)
        Me.btnSOLookup.TabIndex = 73
        Me.btnSOLookup.Text = "˅"
        Me.btnSOLookup.UseVisualStyleBackColor = True
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductReceiveBindingSource, "SubTotal", True))
        Me.SubTotalTextBox.Location = New System.Drawing.Point(563, 347)
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.Size = New System.Drawing.Size(98, 20)
        Me.SubTotalTextBox.TabIndex = 74
        Me.SubTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ProductReceiveTableAdapter
        '
        Me.ProductReceiveTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProductReceiveDetailTableAdapter = Me.ProductReceiveDetailTableAdapter
        Me.TableAdapterManager.ProductReceiveTableAdapter = Me.ProductReceiveTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sales_And_Inventory_System.ProductReceiveDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductReceiveDetailTableAdapter
        '
        Me.ProductReceiveDetailTableAdapter.ClearBeforeFill = True
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'AddProduct
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = "Add Product"
        Me.AddProduct.DefaultCellStyle = DataGridViewCellStyle1
        Me.AddProduct.Frozen = True
        Me.AddProduct.HeaderText = "Add Product"
        Me.AddProduct.Name = "AddProduct"
        Me.AddProduct.Width = 90
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
        Me.UnitID.HeaderText = "U/M"
        Me.UnitID.Name = "UnitID"
        Me.UnitID.Width = 90
        '
        'SupplierPrice
        '
        Me.SupplierPrice.DataPropertyName = "SupplierPrice"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SupplierPrice.DefaultCellStyle = DataGridViewCellStyle3
        Me.SupplierPrice.HeaderText = "Supplier Price"
        Me.SupplierPrice.Name = "SupplierPrice"
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "Amount"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle4
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.Width = 80
        '
        'frmProductReceive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 481)
        Me.Controls.Add(SubTotalLabel)
        Me.Controls.Add(Me.SubTotalTextBox)
        Me.Controls.Add(Me.btnSOLookup)
        Me.Controls.Add(Me.ProductReceiveDetailDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(ReceiveStatusLabel)
        Me.Controls.Add(Me.ReceiveStatusComboBox)
        Me.Controls.Add(ProductReceiveIDLabel)
        Me.Controls.Add(Me.ProductReceiveIDTextBox)
        Me.Controls.Add(SupplierIDLabel)
        Me.Controls.Add(Me.SupplierIDComboBox)
        Me.Controls.Add(InvoiceNoLabel)
        Me.Controls.Add(Me.InvoiceNoTextBox)
        Me.Controls.Add(RefNoLabel)
        Me.Controls.Add(Me.RefNoTextBox)
        Me.Controls.Add(DateReceivedLabel)
        Me.Controls.Add(Me.DateReceivedDateTimePicker)
        Me.Controls.Add(DiscountPercentLabel)
        Me.Controls.Add(Me.DiscountPercentTextBox)
        Me.Controls.Add(DiscountAmountLabel)
        Me.Controls.Add(Me.DiscountAmountTextBox)
        Me.Controls.Add(NetLabel)
        Me.Controls.Add(Me.NetTextBox)
        Me.Controls.Add(PONumberLabel)
        Me.Controls.Add(Me.PONumberTextBox)
        Me.Controls.Add(Me.ProductReceiveBindingNavigator)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProductReceive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Receive"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.ProductReceiveBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductReceiveBindingNavigator.ResumeLayout(False)
        Me.ProductReceiveBindingNavigator.PerformLayout()
        CType(Me.ProductReceiveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductReceiveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductReceiveDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductReceiveDetailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryProductLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ProductReceiveDataSet As Sales_And_Inventory_System.ProductReceiveDataSet
    Friend WithEvents ProductReceiveBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductReceiveTableAdapter As Sales_And_Inventory_System.ProductReceiveDataSetTableAdapters.ProductReceiveTableAdapter
    Friend WithEvents TableAdapterManager As Sales_And_Inventory_System.ProductReceiveDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductReceiveBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ProductReceiveBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProductReceiveDetailTableAdapter As Sales_And_Inventory_System.ProductReceiveDataSetTableAdapters.ProductReceiveDetailTableAdapter
    Friend WithEvents ProductReceiveIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents InvoiceNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RefNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateReceivedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DiscountPercentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiscountAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PONumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReceiveStatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProductReceiveDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductReceiveDetailDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ProductLookupDataSet As Sales_And_Inventory_System.ProductLookupDataSet
    Friend WithEvents QryProductLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Qry_ProductLookupTableAdapter As Sales_And_Inventory_System.ProductLookupDataSetTableAdapters.qry_ProductLookupTableAdapter
    Friend WithEvents btnSOLookup As System.Windows.Forms.Button
    Friend WithEvents SubTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierDataSet As Sales_And_Inventory_System.SupplierDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As Sales_And_Inventory_System.SupplierDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents AddProduct As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ProductDetailID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
