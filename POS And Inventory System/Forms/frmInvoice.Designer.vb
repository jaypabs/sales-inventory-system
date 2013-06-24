<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoice
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
        Dim InvoiceIDLabel As System.Windows.Forms.Label
        Dim InvoiceNoLabel As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim DateDeliveredLabel As System.Windows.Forms.Label
        Dim DiscountAmountLabel As System.Windows.Forms.Label
        Dim DiscountPercentLabel As System.Windows.Forms.Label
        Dim NetLabel As System.Windows.Forms.Label
        Dim TaxBaseLabel As System.Windows.Forms.Label
        Dim VATLabel As System.Windows.Forms.Label
        Dim CashLabel As System.Windows.Forms.Label
        Dim CheckLabel As System.Windows.Forms.Label
        Dim ChangeLabel As System.Windows.Forms.Label
        Dim CreatedByLabel As System.Windows.Forms.Label
        Dim DeliveryStatusLabel As System.Windows.Forms.Label
        Dim SONumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoice))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSettle = New System.Windows.Forms.Button()
        Me.InvoiceBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.InvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoiceDataSet = New Sales_And_Inventory_System.InvoiceDataSet()
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
        Me.InvoiceBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.InvoiceIDTextBox = New System.Windows.Forms.TextBox()
        Me.InvoiceNoTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIDComboBox = New System.Windows.Forms.ComboBox()
        Me.QryCustomerLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerLookupDataSet = New Sales_And_Inventory_System.CustomerLookupDataSet()
        Me.DateDeliveredDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DiscountAmountTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountPercentTextBox = New System.Windows.Forms.TextBox()
        Me.NetTextBox = New System.Windows.Forms.TextBox()
        Me.TaxBaseTextBox = New System.Windows.Forms.TextBox()
        Me.VATTextBox = New System.Windows.Forms.TextBox()
        Me.CashTextBox = New System.Windows.Forms.TextBox()
        Me.CheckTextBox = New System.Windows.Forms.TextBox()
        Me.ChangeTextBox = New System.Windows.Forms.TextBox()
        Me.CreatedByTextBox = New System.Windows.Forms.TextBox()
        Me.Qry_CustomerLookupTableAdapter = New Sales_And_Inventory_System.CustomerLookupDataSetTableAdapters.qry_CustomerLookupTableAdapter()
        Me.DeliveryStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.InvoiceDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoiceDetailDataGridView = New System.Windows.Forms.DataGridView()
        Me.AddProduct = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ProductDetailID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.QryProductLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductLookupDataSet = New Sales_And_Inventory_System.ProductLookupDataSet()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SellingPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountPercent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SONumberTextBox = New System.Windows.Forms.TextBox()
        Me.btnSOLookup = New System.Windows.Forms.Button()
        Me.Qry_ProductLookupTableAdapter = New Sales_And_Inventory_System.ProductLookupDataSetTableAdapters.qry_ProductLookupTableAdapter()
        Me.InvoiceTableAdapter = New Sales_And_Inventory_System.InvoiceDataSetTableAdapters.InvoiceTableAdapter()
        Me.TableAdapterManager = New Sales_And_Inventory_System.InvoiceDataSetTableAdapters.TableAdapterManager()
        Me.InvoiceDetailTableAdapter = New Sales_And_Inventory_System.InvoiceDataSetTableAdapters.InvoiceDetailTableAdapter()
        InvoiceIDLabel = New System.Windows.Forms.Label()
        InvoiceNoLabel = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        DateDeliveredLabel = New System.Windows.Forms.Label()
        DiscountAmountLabel = New System.Windows.Forms.Label()
        DiscountPercentLabel = New System.Windows.Forms.Label()
        NetLabel = New System.Windows.Forms.Label()
        TaxBaseLabel = New System.Windows.Forms.Label()
        VATLabel = New System.Windows.Forms.Label()
        CashLabel = New System.Windows.Forms.Label()
        CheckLabel = New System.Windows.Forms.Label()
        ChangeLabel = New System.Windows.Forms.Label()
        CreatedByLabel = New System.Windows.Forms.Label()
        DeliveryStatusLabel = New System.Windows.Forms.Label()
        SONumberLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.InvoiceBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InvoiceBindingNavigator.SuspendLayout()
        CType(Me.InvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryCustomerLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.InvoiceDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDetailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryProductLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InvoiceIDLabel
        '
        InvoiceIDLabel.AutoSize = True
        InvoiceIDLabel.Location = New System.Drawing.Point(202, 235)
        InvoiceIDLabel.Name = "InvoiceIDLabel"
        InvoiceIDLabel.Size = New System.Drawing.Size(59, 13)
        InvoiceIDLabel.TabIndex = 42
        InvoiceIDLabel.Text = "Invoice ID:"
        '
        'InvoiceNoLabel
        '
        InvoiceNoLabel.AutoSize = True
        InvoiceNoLabel.Location = New System.Drawing.Point(338, 75)
        InvoiceNoLabel.Name = "InvoiceNoLabel"
        InvoiceNoLabel.Size = New System.Drawing.Size(62, 13)
        InvoiceNoLabel.TabIndex = 44
        InvoiceNoLabel.Text = "Invoice No:"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(27, 48)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(54, 13)
        CustomerIDLabel.TabIndex = 46
        CustomerIDLabel.Text = "Customer:"
        '
        'DateDeliveredLabel
        '
        DateDeliveredLabel.AutoSize = True
        DateDeliveredLabel.Location = New System.Drawing.Point(27, 76)
        DateDeliveredLabel.Name = "DateDeliveredLabel"
        DateDeliveredLabel.Size = New System.Drawing.Size(81, 13)
        DateDeliveredLabel.TabIndex = 48
        DateDeliveredLabel.Text = "Date Delivered:"
        '
        'DiscountAmountLabel
        '
        DiscountAmountLabel.AutoSize = True
        DiscountAmountLabel.Location = New System.Drawing.Point(615, 388)
        DiscountAmountLabel.Name = "DiscountAmountLabel"
        DiscountAmountLabel.Size = New System.Drawing.Size(43, 13)
        DiscountAmountLabel.TabIndex = 50
        DiscountAmountLabel.Text = "Amount"
        '
        'DiscountPercentLabel
        '
        DiscountPercentLabel.AutoSize = True
        DiscountPercentLabel.Location = New System.Drawing.Point(675, 388)
        DiscountPercentLabel.Name = "DiscountPercentLabel"
        DiscountPercentLabel.Size = New System.Drawing.Size(44, 13)
        DiscountPercentLabel.TabIndex = 52
        DiscountPercentLabel.Text = "Percent"
        '
        'NetLabel
        '
        NetLabel.AutoSize = True
        NetLabel.Location = New System.Drawing.Point(585, 433)
        NetLabel.Name = "NetLabel"
        NetLabel.Size = New System.Drawing.Size(27, 13)
        NetLabel.TabIndex = 54
        NetLabel.Text = "Net:"
        '
        'TaxBaseLabel
        '
        TaxBaseLabel.AutoSize = True
        TaxBaseLabel.Location = New System.Drawing.Point(382, 407)
        TaxBaseLabel.Name = "TaxBaseLabel"
        TaxBaseLabel.Size = New System.Drawing.Size(55, 13)
        TaxBaseLabel.TabIndex = 56
        TaxBaseLabel.Text = "Tax Base:"
        '
        'VATLabel
        '
        VATLabel.AutoSize = True
        VATLabel.Location = New System.Drawing.Point(382, 433)
        VATLabel.Name = "VATLabel"
        VATLabel.Size = New System.Drawing.Size(54, 13)
        VATLabel.TabIndex = 58
        VATLabel.Text = "12% VAT:"
        '
        'CashLabel
        '
        CashLabel.AutoSize = True
        CashLabel.Location = New System.Drawing.Point(18, 20)
        CashLabel.Name = "CashLabel"
        CashLabel.Size = New System.Drawing.Size(34, 13)
        CashLabel.TabIndex = 60
        CashLabel.Text = "Cash:"
        '
        'CheckLabel
        '
        CheckLabel.AutoSize = True
        CheckLabel.Location = New System.Drawing.Point(18, 46)
        CheckLabel.Name = "CheckLabel"
        CheckLabel.Size = New System.Drawing.Size(41, 13)
        CheckLabel.TabIndex = 62
        CheckLabel.Text = "Check:"
        '
        'ChangeLabel
        '
        ChangeLabel.AutoSize = True
        ChangeLabel.Location = New System.Drawing.Point(565, 459)
        ChangeLabel.Name = "ChangeLabel"
        ChangeLabel.Size = New System.Drawing.Size(47, 13)
        ChangeLabel.TabIndex = 64
        ChangeLabel.Text = "Change:"
        '
        'CreatedByLabel
        '
        CreatedByLabel.AutoSize = True
        CreatedByLabel.Location = New System.Drawing.Point(16, 476)
        CreatedByLabel.Name = "CreatedByLabel"
        CreatedByLabel.Size = New System.Drawing.Size(62, 13)
        CreatedByLabel.TabIndex = 66
        CreatedByLabel.Text = "Created By:"
        '
        'DeliveryStatusLabel
        '
        DeliveryStatusLabel.AutoSize = True
        DeliveryStatusLabel.Location = New System.Drawing.Point(536, 47)
        DeliveryStatusLabel.Name = "DeliveryStatusLabel"
        DeliveryStatusLabel.Size = New System.Drawing.Size(81, 13)
        DeliveryStatusLabel.TabIndex = 67
        DeliveryStatusLabel.Text = "Delivery Status:"
        '
        'SONumberLabel
        '
        SONumberLabel.AutoSize = True
        SONumberLabel.Location = New System.Drawing.Point(335, 48)
        SONumberLabel.Name = "SONumberLabel"
        SONumberLabel.Size = New System.Drawing.Size(65, 13)
        SONumberLabel.TabIndex = 70
        SONumberLabel.Text = "SO Number:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(749, 39)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Create Invoice"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.btnSettle)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 499)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(749, 40)
        Me.Panel2.TabIndex = 41
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(586, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 34)
        Me.btnSave.TabIndex = 40
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSettle
        '
        Me.btnSettle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSettle.Location = New System.Drawing.Point(668, 3)
        Me.btnSettle.Name = "btnSettle"
        Me.btnSettle.Size = New System.Drawing.Size(75, 34)
        Me.btnSettle.TabIndex = 28
        Me.btnSettle.Text = "&Close"
        Me.btnSettle.UseVisualStyleBackColor = True
        '
        'InvoiceBindingNavigator
        '
        Me.InvoiceBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.InvoiceBindingNavigator.BindingSource = Me.InvoiceBindingSource
        Me.InvoiceBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InvoiceBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.InvoiceBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.InvoiceBindingNavigatorSaveItem})
        Me.InvoiceBindingNavigator.Location = New System.Drawing.Point(0, 39)
        Me.InvoiceBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InvoiceBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InvoiceBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InvoiceBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InvoiceBindingNavigator.Name = "InvoiceBindingNavigator"
        Me.InvoiceBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InvoiceBindingNavigator.Size = New System.Drawing.Size(744, 25)
        Me.InvoiceBindingNavigator.TabIndex = 42
        Me.InvoiceBindingNavigator.Text = "BindingNavigator1"
        Me.InvoiceBindingNavigator.Visible = False
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
        'InvoiceBindingSource
        '
        Me.InvoiceBindingSource.DataMember = "Invoice"
        Me.InvoiceBindingSource.DataSource = Me.InvoiceDataSet
        '
        'InvoiceDataSet
        '
        Me.InvoiceDataSet.DataSetName = "InvoiceDataSet"
        Me.InvoiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'InvoiceBindingNavigatorSaveItem
        '
        Me.InvoiceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InvoiceBindingNavigatorSaveItem.Image = CType(resources.GetObject("InvoiceBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InvoiceBindingNavigatorSaveItem.Name = "InvoiceBindingNavigatorSaveItem"
        Me.InvoiceBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.InvoiceBindingNavigatorSaveItem.Text = "Save Data"
        '
        'InvoiceIDTextBox
        '
        Me.InvoiceIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoiceBindingSource, "InvoiceID", True))
        Me.InvoiceIDTextBox.Location = New System.Drawing.Point(265, 232)
        Me.InvoiceIDTextBox.Name = "InvoiceIDTextBox"
        Me.InvoiceIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.InvoiceIDTextBox.TabIndex = 43
        '
        'InvoiceNoTextBox
        '
        Me.InvoiceNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoiceBindingSource, "InvoiceNo", True))
        Me.InvoiceNoTextBox.Location = New System.Drawing.Point(406, 72)
        Me.InvoiceNoTextBox.Name = "InvoiceNoTextBox"
        Me.InvoiceNoTextBox.Size = New System.Drawing.Size(121, 20)
        Me.InvoiceNoTextBox.TabIndex = 45
        '
        'CustomerIDComboBox
        '
        Me.CustomerIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.InvoiceBindingSource, "CustomerID", True))
        Me.CustomerIDComboBox.DataSource = Me.QryCustomerLookupBindingSource
        Me.CustomerIDComboBox.DisplayMember = "Name"
        Me.CustomerIDComboBox.FormattingEnabled = True
        Me.CustomerIDComboBox.Location = New System.Drawing.Point(125, 45)
        Me.CustomerIDComboBox.Name = "CustomerIDComboBox"
        Me.CustomerIDComboBox.Size = New System.Drawing.Size(200, 21)
        Me.CustomerIDComboBox.TabIndex = 47
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
        'DateDeliveredDateTimePicker
        '
        Me.DateDeliveredDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InvoiceBindingSource, "DateDelivered", True))
        Me.DateDeliveredDateTimePicker.Location = New System.Drawing.Point(125, 72)
        Me.DateDeliveredDateTimePicker.Name = "DateDeliveredDateTimePicker"
        Me.DateDeliveredDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDeliveredDateTimePicker.TabIndex = 49
        '
        'DiscountAmountTextBox
        '
        Me.DiscountAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoiceBindingSource, "DiscountAmount", True))
        Me.DiscountAmountTextBox.Location = New System.Drawing.Point(618, 404)
        Me.DiscountAmountTextBox.Name = "DiscountAmountTextBox"
        Me.DiscountAmountTextBox.Size = New System.Drawing.Size(54, 20)
        Me.DiscountAmountTextBox.TabIndex = 51
        Me.DiscountAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DiscountPercentTextBox
        '
        Me.DiscountPercentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoiceBindingSource, "DiscountPercent", True))
        Me.DiscountPercentTextBox.Location = New System.Drawing.Point(678, 403)
        Me.DiscountPercentTextBox.Name = "DiscountPercentTextBox"
        Me.DiscountPercentTextBox.Size = New System.Drawing.Size(54, 20)
        Me.DiscountPercentTextBox.TabIndex = 53
        Me.DiscountPercentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NetTextBox
        '
        Me.NetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoiceBindingSource, "Net", True))
        Me.NetTextBox.Location = New System.Drawing.Point(618, 430)
        Me.NetTextBox.Name = "NetTextBox"
        Me.NetTextBox.Size = New System.Drawing.Size(114, 20)
        Me.NetTextBox.TabIndex = 55
        Me.NetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TaxBaseTextBox
        '
        Me.TaxBaseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoiceBindingSource, "TaxBase", True))
        Me.TaxBaseTextBox.Location = New System.Drawing.Point(449, 404)
        Me.TaxBaseTextBox.Name = "TaxBaseTextBox"
        Me.TaxBaseTextBox.Size = New System.Drawing.Size(97, 20)
        Me.TaxBaseTextBox.TabIndex = 57
        Me.TaxBaseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'VATTextBox
        '
        Me.VATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoiceBindingSource, "VAT", True))
        Me.VATTextBox.Location = New System.Drawing.Point(449, 430)
        Me.VATTextBox.Name = "VATTextBox"
        Me.VATTextBox.Size = New System.Drawing.Size(97, 20)
        Me.VATTextBox.TabIndex = 59
        Me.VATTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CashTextBox
        '
        Me.CashTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoiceBindingSource, "Cash", True))
        Me.CashTextBox.Location = New System.Drawing.Point(65, 17)
        Me.CashTextBox.Name = "CashTextBox"
        Me.CashTextBox.Size = New System.Drawing.Size(97, 20)
        Me.CashTextBox.TabIndex = 61
        Me.CashTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CheckTextBox
        '
        Me.CheckTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoiceBindingSource, "Check", True))
        Me.CheckTextBox.Location = New System.Drawing.Point(65, 43)
        Me.CheckTextBox.Name = "CheckTextBox"
        Me.CheckTextBox.Size = New System.Drawing.Size(97, 20)
        Me.CheckTextBox.TabIndex = 63
        Me.CheckTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ChangeTextBox
        '
        Me.ChangeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoiceBindingSource, "Change", True))
        Me.ChangeTextBox.Location = New System.Drawing.Point(618, 456)
        Me.ChangeTextBox.Name = "ChangeTextBox"
        Me.ChangeTextBox.Size = New System.Drawing.Size(114, 20)
        Me.ChangeTextBox.TabIndex = 65
        Me.ChangeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CreatedByTextBox
        '
        Me.CreatedByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoiceBindingSource, "CreatedBy", True))
        Me.CreatedByTextBox.Location = New System.Drawing.Point(84, 473)
        Me.CreatedByTextBox.Name = "CreatedByTextBox"
        Me.CreatedByTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CreatedByTextBox.TabIndex = 67
        '
        'Qry_CustomerLookupTableAdapter
        '
        Me.Qry_CustomerLookupTableAdapter.ClearBeforeFill = True
        '
        'DeliveryStatusComboBox
        '
        Me.DeliveryStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoiceBindingSource, "DeliveryStatus", True))
        Me.DeliveryStatusComboBox.FormattingEnabled = True
        Me.DeliveryStatusComboBox.Items.AddRange(New Object() {"For Approval", "Approved"})
        Me.DeliveryStatusComboBox.Location = New System.Drawing.Point(623, 44)
        Me.DeliveryStatusComboBox.Name = "DeliveryStatusComboBox"
        Me.DeliveryStatusComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DeliveryStatusComboBox.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(560, 406)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Discount:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckTextBox)
        Me.GroupBox1.Controls.Add(CheckLabel)
        Me.GroupBox1.Controls.Add(Me.CashTextBox)
        Me.GroupBox1.Controls.Add(CashLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 385)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 78)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment"
        '
        'InvoiceDetailBindingSource
        '
        Me.InvoiceDetailBindingSource.DataMember = "InvoiceInvoiceDetail"
        Me.InvoiceDetailBindingSource.DataSource = Me.InvoiceBindingSource
        '
        'InvoiceDetailDataGridView
        '
        Me.InvoiceDetailDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InvoiceDetailDataGridView.AutoGenerateColumns = False
        Me.InvoiceDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InvoiceDetailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AddProduct, Me.ProductDetailID, Me.Qty, Me.UnitID, Me.SellingPrice, Me.DiscountPercent, Me.DiscountAmount, Me.Amount})
        Me.InvoiceDetailDataGridView.DataSource = Me.InvoiceDetailBindingSource
        Me.InvoiceDetailDataGridView.Location = New System.Drawing.Point(0, 107)
        Me.InvoiceDetailDataGridView.Name = "InvoiceDetailDataGridView"
        Me.InvoiceDetailDataGridView.Size = New System.Drawing.Size(749, 272)
        Me.InvoiceDetailDataGridView.TabIndex = 70
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
        Me.ProductDetailID.Width = 200
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
        Me.UnitID.Width = 80
        '
        'SellingPrice
        '
        Me.SellingPrice.DataPropertyName = "SellingPrice"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SellingPrice.DefaultCellStyle = DataGridViewCellStyle3
        Me.SellingPrice.HeaderText = "Selling Price"
        Me.SellingPrice.Name = "SellingPrice"
        Me.SellingPrice.Width = 90
        '
        'DiscountPercent
        '
        Me.DiscountPercent.DataPropertyName = "DiscountPercent"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DiscountPercent.DefaultCellStyle = DataGridViewCellStyle4
        Me.DiscountPercent.HeaderText = "Discount (%)"
        Me.DiscountPercent.Name = "DiscountPercent"
        Me.DiscountPercent.Width = 90
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
        Me.Amount.Width = 80
        '
        'SONumberTextBox
        '
        Me.SONumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoiceBindingSource, "SONumber", True))
        Me.SONumberTextBox.Location = New System.Drawing.Point(406, 46)
        Me.SONumberTextBox.Name = "SONumberTextBox"
        Me.SONumberTextBox.Size = New System.Drawing.Size(92, 20)
        Me.SONumberTextBox.TabIndex = 71
        '
        'btnSOLookup
        '
        Me.btnSOLookup.Location = New System.Drawing.Point(502, 45)
        Me.btnSOLookup.Name = "btnSOLookup"
        Me.btnSOLookup.Size = New System.Drawing.Size(25, 22)
        Me.btnSOLookup.TabIndex = 72
        Me.btnSOLookup.Text = "˅"
        Me.btnSOLookup.UseVisualStyleBackColor = True
        '
        'Qry_ProductLookupTableAdapter
        '
        Me.Qry_ProductLookupTableAdapter.ClearBeforeFill = True
        '
        'InvoiceTableAdapter
        '
        Me.InvoiceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.InvoiceDetailTableAdapter = Me.InvoiceDetailTableAdapter
        Me.TableAdapterManager.InvoiceTableAdapter = Me.InvoiceTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sales_And_Inventory_System.InvoiceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'InvoiceDetailTableAdapter
        '
        Me.InvoiceDetailTableAdapter.ClearBeforeFill = True
        '
        'frmInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 539)
        Me.Controls.Add(Me.btnSOLookup)
        Me.Controls.Add(SONumberLabel)
        Me.Controls.Add(Me.SONumberTextBox)
        Me.Controls.Add(Me.InvoiceDetailDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(DeliveryStatusLabel)
        Me.Controls.Add(Me.DeliveryStatusComboBox)
        Me.Controls.Add(InvoiceIDLabel)
        Me.Controls.Add(Me.InvoiceIDTextBox)
        Me.Controls.Add(InvoiceNoLabel)
        Me.Controls.Add(Me.InvoiceNoTextBox)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDComboBox)
        Me.Controls.Add(DateDeliveredLabel)
        Me.Controls.Add(Me.DateDeliveredDateTimePicker)
        Me.Controls.Add(DiscountAmountLabel)
        Me.Controls.Add(Me.DiscountAmountTextBox)
        Me.Controls.Add(DiscountPercentLabel)
        Me.Controls.Add(Me.DiscountPercentTextBox)
        Me.Controls.Add(NetLabel)
        Me.Controls.Add(Me.NetTextBox)
        Me.Controls.Add(TaxBaseLabel)
        Me.Controls.Add(Me.TaxBaseTextBox)
        Me.Controls.Add(VATLabel)
        Me.Controls.Add(Me.VATTextBox)
        Me.Controls.Add(ChangeLabel)
        Me.Controls.Add(Me.ChangeTextBox)
        Me.Controls.Add(CreatedByLabel)
        Me.Controls.Add(Me.CreatedByTextBox)
        Me.Controls.Add(Me.InvoiceBindingNavigator)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.InvoiceBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InvoiceBindingNavigator.ResumeLayout(False)
        Me.InvoiceBindingNavigator.PerformLayout()
        CType(Me.InvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryCustomerLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.InvoiceDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDetailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryProductLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnSettle As System.Windows.Forms.Button
    Friend WithEvents InvoiceDataSet As Sales_And_Inventory_System.InvoiceDataSet
    Friend WithEvents InvoiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvoiceTableAdapter As Sales_And_Inventory_System.InvoiceDataSetTableAdapters.InvoiceTableAdapter
    Friend WithEvents TableAdapterManager As Sales_And_Inventory_System.InvoiceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InvoiceBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents InvoiceBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents InvoiceIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InvoiceNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DateDeliveredDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DiscountAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiscountPercentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TaxBaseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CashTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CheckTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChangeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CreatedByTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerLookupDataSet As Sales_And_Inventory_System.CustomerLookupDataSet
    Friend WithEvents QryCustomerLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Qry_CustomerLookupTableAdapter As Sales_And_Inventory_System.CustomerLookupDataSetTableAdapters.qry_CustomerLookupTableAdapter
    Friend WithEvents DeliveryStatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents InvoiceDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvoiceDetailTableAdapter As Sales_And_Inventory_System.InvoiceDataSetTableAdapters.InvoiceDetailTableAdapter
    Friend WithEvents InvoiceDetailDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SONumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnSOLookup As System.Windows.Forms.Button
    Friend WithEvents ProductLookupDataSet As Sales_And_Inventory_System.ProductLookupDataSet
    Friend WithEvents QryProductLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Qry_ProductLookupTableAdapter As Sales_And_Inventory_System.ProductLookupDataSetTableAdapters.qry_ProductLookupTableAdapter
    Friend WithEvents AddProduct As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ProductDetailID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SellingPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiscountPercent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiscountAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
