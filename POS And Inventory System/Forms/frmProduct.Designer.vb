<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduct
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
        Dim ProductIDLabel As System.Windows.Forms.Label
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim CategoryIDLabel As System.Windows.Forms.Label
        Dim SubCategoryIDLabel As System.Windows.Forms.Label
        Dim BrandIDLabel As System.Windows.Forms.Label
        Dim ItemTypeIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduct))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductDataSet = New Sales_And_Inventory_System.ProductDataSet()
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
        Me.ProductBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductIDTextBox = New System.Windows.Forms.TextBox()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryIDComboBox = New System.Windows.Forms.ComboBox()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryDataSet = New Sales_And_Inventory_System.CategoryDataSet()
        Me.SubCategoryIDComboBox = New System.Windows.Forms.ComboBox()
        Me.SubCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrandIDComboBox = New System.Windows.Forms.ComboBox()
        Me.BrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrandDataSet = New Sales_And_Inventory_System.BrandDataSet()
        Me.ProductDetailDataGridView = New System.Windows.Forms.DataGridView()
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDataSet = New Sales_And_Inventory_System.UnitDataSet()
        Me.ProductDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New Sales_And_Inventory_System.ProductDataSetTableAdapters.ProductTableAdapter()
        Me.TableAdapterManager = New Sales_And_Inventory_System.ProductDataSetTableAdapters.TableAdapterManager()
        Me.ProductDetailTableAdapter = New Sales_And_Inventory_System.ProductDataSetTableAdapters.ProductDetailTableAdapter()
        Me.ItemTypeIDComboBox = New System.Windows.Forms.ComboBox()
        Me.ItemTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemTypeDataSet = New Sales_And_Inventory_System.ItemTypeDataSet()
        Me.ItemTypeTableAdapter = New Sales_And_Inventory_System.ItemTypeDataSetTableAdapters.ItemTypeTableAdapter()
        Me.CategoryTableAdapter = New Sales_And_Inventory_System.CategoryDataSetTableAdapters.CategoryTableAdapter()
        Me.SubCategoryTableAdapter = New Sales_And_Inventory_System.CategoryDataSetTableAdapters.SubCategoryTableAdapter()
        Me.BrandTableAdapter = New Sales_And_Inventory_System.BrandDataSetTableAdapters.BrandTableAdapter()
        Me.UnitTableAdapter = New Sales_And_Inventory_System.UnitDataSetTableAdapters.UnitTableAdapter()
        Me.OrderNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyperUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ProductIDLabel = New System.Windows.Forms.Label()
        ProductNameLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        CategoryIDLabel = New System.Windows.Forms.Label()
        SubCategoryIDLabel = New System.Windows.Forms.Label()
        BrandIDLabel = New System.Windows.Forms.Label()
        ItemTypeIDLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductBindingNavigator.SuspendLayout()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDetailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemTypeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductIDLabel
        '
        ProductIDLabel.AutoSize = True
        ProductIDLabel.Location = New System.Drawing.Point(130, 285)
        ProductIDLabel.Name = "ProductIDLabel"
        ProductIDLabel.Size = New System.Drawing.Size(61, 13)
        ProductIDLabel.TabIndex = 10
        ProductIDLabel.Text = "Product ID:"
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Location = New System.Drawing.Point(28, 84)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(78, 13)
        ProductNameLabel.TabIndex = 12
        ProductNameLabel.Text = "Product Name:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(28, 110)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 14
        DescriptionLabel.Text = "Description:"
        '
        'CategoryIDLabel
        '
        CategoryIDLabel.AutoSize = True
        CategoryIDLabel.Location = New System.Drawing.Point(334, 60)
        CategoryIDLabel.Name = "CategoryIDLabel"
        CategoryIDLabel.Size = New System.Drawing.Size(52, 13)
        CategoryIDLabel.TabIndex = 16
        CategoryIDLabel.Text = "Category:"
        '
        'SubCategoryIDLabel
        '
        SubCategoryIDLabel.AutoSize = True
        SubCategoryIDLabel.Location = New System.Drawing.Point(334, 86)
        SubCategoryIDLabel.Name = "SubCategoryIDLabel"
        SubCategoryIDLabel.Size = New System.Drawing.Size(74, 13)
        SubCategoryIDLabel.TabIndex = 18
        SubCategoryIDLabel.Text = "Sub Category:"
        '
        'BrandIDLabel
        '
        BrandIDLabel.AutoSize = True
        BrandIDLabel.Location = New System.Drawing.Point(334, 113)
        BrandIDLabel.Name = "BrandIDLabel"
        BrandIDLabel.Size = New System.Drawing.Size(38, 13)
        BrandIDLabel.TabIndex = 20
        BrandIDLabel.Text = "Brand:"
        '
        'ItemTypeIDLabel
        '
        ItemTypeIDLabel.AutoSize = True
        ItemTypeIDLabel.Location = New System.Drawing.Point(28, 57)
        ItemTypeIDLabel.Name = "ItemTypeIDLabel"
        ItemTypeIDLabel.Size = New System.Drawing.Size(71, 13)
        ItemTypeIDLabel.TabIndex = 21
        ItemTypeIDLabel.Text = "Item Type ID:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(841, 39)
        Me.Panel1.TabIndex = 9
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(781, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(57, 23)
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
        Me.Label1.Size = New System.Drawing.Size(75, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product"
        '
        'ProductBindingNavigator
        '
        Me.ProductBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductBindingNavigator.BindingSource = Me.ProductBindingSource
        Me.ProductBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProductBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductBindingNavigatorSaveItem})
        Me.ProductBindingNavigator.Location = New System.Drawing.Point(0, 406)
        Me.ProductBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductBindingNavigator.Name = "ProductBindingNavigator"
        Me.ProductBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductBindingNavigator.Size = New System.Drawing.Size(841, 25)
        Me.ProductBindingNavigator.TabIndex = 10
        Me.ProductBindingNavigator.Text = "BindingNavigator1"
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
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.ProductDataSet
        '
        'ProductDataSet
        '
        Me.ProductDataSet.DataSetName = "ProductDataSet"
        Me.ProductDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ProductBindingNavigatorSaveItem
        '
        Me.ProductBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductBindingNavigatorSaveItem.Name = "ProductBindingNavigatorSaveItem"
        Me.ProductBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProductBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProductIDTextBox
        '
        Me.ProductIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProductID", True))
        Me.ProductIDTextBox.Location = New System.Drawing.Point(224, 282)
        Me.ProductIDTextBox.Name = "ProductIDTextBox"
        Me.ProductIDTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ProductIDTextBox.TabIndex = 11
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProductName", True))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(122, 81)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(206, 20)
        Me.ProductNameTextBox.TabIndex = 13
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(122, 107)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(206, 20)
        Me.DescriptionTextBox.TabIndex = 15
        '
        'CategoryIDComboBox
        '
        Me.CategoryIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductBindingSource, "CategoryID", True))
        Me.CategoryIDComboBox.DataSource = Me.CategoryBindingSource
        Me.CategoryIDComboBox.DisplayMember = "Category"
        Me.CategoryIDComboBox.FormattingEnabled = True
        Me.CategoryIDComboBox.Location = New System.Drawing.Point(428, 57)
        Me.CategoryIDComboBox.Name = "CategoryIDComboBox"
        Me.CategoryIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CategoryIDComboBox.TabIndex = 17
        Me.CategoryIDComboBox.ValueMember = "CategoryID"
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.CategoryDataSet
        '
        'CategoryDataSet
        '
        Me.CategoryDataSet.DataSetName = "CategoryDataSet"
        Me.CategoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SubCategoryIDComboBox
        '
        Me.SubCategoryIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductBindingSource, "SubCategoryID", True))
        Me.SubCategoryIDComboBox.DataSource = Me.SubCategoryBindingSource
        Me.SubCategoryIDComboBox.DisplayMember = "Subcategory"
        Me.SubCategoryIDComboBox.FormattingEnabled = True
        Me.SubCategoryIDComboBox.Location = New System.Drawing.Point(428, 83)
        Me.SubCategoryIDComboBox.Name = "SubCategoryIDComboBox"
        Me.SubCategoryIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SubCategoryIDComboBox.TabIndex = 19
        Me.SubCategoryIDComboBox.ValueMember = "SubcategoryID"
        '
        'SubCategoryBindingSource
        '
        Me.SubCategoryBindingSource.DataMember = "SubCategory"
        Me.SubCategoryBindingSource.DataSource = Me.CategoryDataSet
        '
        'BrandIDComboBox
        '
        Me.BrandIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductBindingSource, "BrandID", True))
        Me.BrandIDComboBox.DataSource = Me.BrandBindingSource
        Me.BrandIDComboBox.DisplayMember = "Brand"
        Me.BrandIDComboBox.FormattingEnabled = True
        Me.BrandIDComboBox.Location = New System.Drawing.Point(428, 110)
        Me.BrandIDComboBox.Name = "BrandIDComboBox"
        Me.BrandIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.BrandIDComboBox.TabIndex = 21
        Me.BrandIDComboBox.ValueMember = "BrandID"
        '
        'BrandBindingSource
        '
        Me.BrandBindingSource.DataMember = "Brand"
        Me.BrandBindingSource.DataSource = Me.BrandDataSet
        '
        'BrandDataSet
        '
        Me.BrandDataSet.DataSetName = "BrandDataSet"
        Me.BrandDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductDetailDataGridView
        '
        Me.ProductDetailDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductDetailDataGridView.AutoGenerateColumns = False
        Me.ProductDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDetailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderNo, Me.QtyperUnit, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.ProductDetailDataGridView.DataSource = Me.ProductDetailBindingSource
        Me.ProductDetailDataGridView.Location = New System.Drawing.Point(0, 138)
        Me.ProductDetailDataGridView.Name = "ProductDetailDataGridView"
        Me.ProductDetailDataGridView.Size = New System.Drawing.Size(841, 265)
        Me.ProductDetailDataGridView.TabIndex = 21
        '
        'UnitBindingSource
        '
        Me.UnitBindingSource.DataMember = "Unit"
        Me.UnitBindingSource.DataSource = Me.UnitDataSet
        '
        'UnitDataSet
        '
        Me.UnitDataSet.DataSetName = "UnitDataSet"
        Me.UnitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductDetailBindingSource
        '
        Me.ProductDetailBindingSource.DataMember = "Product_ProductDetail"
        Me.ProductDetailBindingSource.DataSource = Me.ProductBindingSource
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProductDetailTableAdapter = Me.ProductDetailTableAdapter
        Me.TableAdapterManager.ProductTableAdapter = Me.ProductTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sales_And_Inventory_System.ProductDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductDetailTableAdapter
        '
        Me.ProductDetailTableAdapter.ClearBeforeFill = True
        '
        'ItemTypeIDComboBox
        '
        Me.ItemTypeIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductBindingSource, "ItemTypeID", True))
        Me.ItemTypeIDComboBox.DataSource = Me.ItemTypeBindingSource
        Me.ItemTypeIDComboBox.DisplayMember = "ItemType"
        Me.ItemTypeIDComboBox.FormattingEnabled = True
        Me.ItemTypeIDComboBox.Location = New System.Drawing.Point(122, 54)
        Me.ItemTypeIDComboBox.Name = "ItemTypeIDComboBox"
        Me.ItemTypeIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ItemTypeIDComboBox.TabIndex = 22
        Me.ItemTypeIDComboBox.ValueMember = "ItemTypeID"
        '
        'ItemTypeBindingSource
        '
        Me.ItemTypeBindingSource.DataMember = "ItemType"
        Me.ItemTypeBindingSource.DataSource = Me.ItemTypeDataSet
        '
        'ItemTypeDataSet
        '
        Me.ItemTypeDataSet.DataSetName = "ItemTypeDataSet"
        Me.ItemTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemTypeTableAdapter
        '
        Me.ItemTypeTableAdapter.ClearBeforeFill = True
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'SubCategoryTableAdapter
        '
        Me.SubCategoryTableAdapter.ClearBeforeFill = True
        '
        'BrandTableAdapter
        '
        Me.BrandTableAdapter.ClearBeforeFill = True
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'OrderNo
        '
        Me.OrderNo.DataPropertyName = "OrderNo"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.OrderNo.DefaultCellStyle = DataGridViewCellStyle1
        Me.OrderNo.HeaderText = "Unit's Order"
        Me.OrderNo.Name = "OrderNo"
        Me.OrderNo.Width = 90
        '
        'QtyperUnit
        '
        Me.QtyperUnit.DataPropertyName = "QtyperUnit"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.QtyperUnit.DefaultCellStyle = DataGridViewCellStyle2
        Me.QtyperUnit.HeaderText = "Qty/Unit"
        Me.QtyperUnit.Name = "QtyperUnit"
        Me.QtyperUnit.Width = 70
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UnitID"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.UnitBindingSource
        Me.DataGridViewTextBoxColumn5.DisplayMember = "UOM"
        Me.DataGridViewTextBoxColumn5.HeaderText = "U/M"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ValueMember = "UnitID"
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Size"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Size"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Color"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Color"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 80
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "QtyOnPO"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn8.HeaderText = "Qty On P.O."
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 90
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "QtyOnhand"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn9.HeaderText = "Qty On Hand"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SupplierPrice"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn10.HeaderText = "Supplier Price"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "SellingPrice"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn11.HeaderText = "Selling Price"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 431)
        Me.Controls.Add(ItemTypeIDLabel)
        Me.Controls.Add(Me.ItemTypeIDComboBox)
        Me.Controls.Add(Me.ProductDetailDataGridView)
        Me.Controls.Add(ProductIDLabel)
        Me.Controls.Add(Me.ProductIDTextBox)
        Me.Controls.Add(ProductNameLabel)
        Me.Controls.Add(Me.ProductNameTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(CategoryIDLabel)
        Me.Controls.Add(Me.CategoryIDComboBox)
        Me.Controls.Add(SubCategoryIDLabel)
        Me.Controls.Add(Me.SubCategoryIDComboBox)
        Me.Controls.Add(BrandIDLabel)
        Me.Controls.Add(Me.BrandIDComboBox)
        Me.Controls.Add(Me.ProductBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductBindingNavigator.ResumeLayout(False)
        Me.ProductBindingNavigator.PerformLayout()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDetailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemTypeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProductDataSet As Sales_And_Inventory_System.ProductDataSet
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductTableAdapter As Sales_And_Inventory_System.ProductDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents TableAdapterManager As Sales_And_Inventory_System.ProductDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ProductBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProductDetailTableAdapter As Sales_And_Inventory_System.ProductDataSetTableAdapters.ProductDetailTableAdapter
    Friend WithEvents ProductIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SubCategoryIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BrandIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProductDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductDetailDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ItemTypeIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ItemTypeDataSet As Sales_And_Inventory_System.ItemTypeDataSet
    Friend WithEvents ItemTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemTypeTableAdapter As Sales_And_Inventory_System.ItemTypeDataSetTableAdapters.ItemTypeTableAdapter
    Friend WithEvents CategoryDataSet As Sales_And_Inventory_System.CategoryDataSet
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoryTableAdapter As Sales_And_Inventory_System.CategoryDataSetTableAdapters.CategoryTableAdapter
    Friend WithEvents SubCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubCategoryTableAdapter As Sales_And_Inventory_System.CategoryDataSetTableAdapters.SubCategoryTableAdapter
    Friend WithEvents BrandDataSet As Sales_And_Inventory_System.BrandDataSet
    Friend WithEvents BrandBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BrandTableAdapter As Sales_And_Inventory_System.BrandDataSetTableAdapters.BrandTableAdapter
    Friend WithEvents UnitDataSet As Sales_And_Inventory_System.UnitDataSet
    Friend WithEvents UnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitTableAdapter As Sales_And_Inventory_System.UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents OrderNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyperUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
