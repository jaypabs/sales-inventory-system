<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStoreInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStoreInventory))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.ProductDetailBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ProductDetailBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductDetailDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProductDetailTableAdapter = New Sales_And_Inventory_System.ProductDataSetTableAdapters.ProductDetailTableAdapter()
        Me.TableAdapterManager = New Sales_And_Inventory_System.ProductDataSetTableAdapters.TableAdapterManager()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New Sales_And_Inventory_System.ProductDataSetTableAdapters.ProductTableAdapter()
        Me.UnitDataSet = New Sales_And_Inventory_System.UnitDataSet()
        Me.UnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitTableAdapter = New Sales_And_Inventory_System.UnitDataSetTableAdapters.UnitTableAdapter()
        Me.ProductDetailID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.UnitID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.QtyOnhand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActualQtyOnHand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventoryStatus = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.ProductDetailBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductDetailBindingNavigator.SuspendLayout()
        CType(Me.ProductDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDetailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(889, 39)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Store Inventory"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(5, 457)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(157, 20)
        Me.txtSearch.TabIndex = 75
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(168, 457)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(61, 21)
        Me.btnSearch.TabIndex = 76
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'ProductDetailBindingNavigator
        '
        Me.ProductDetailBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductDetailBindingNavigator.BindingSource = Me.ProductDetailBindingSource
        Me.ProductDetailBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductDetailBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductDetailBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductDetailBindingNavigatorSaveItem})
        Me.ProductDetailBindingNavigator.Location = New System.Drawing.Point(0, 39)
        Me.ProductDetailBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductDetailBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductDetailBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductDetailBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductDetailBindingNavigator.Name = "ProductDetailBindingNavigator"
        Me.ProductDetailBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductDetailBindingNavigator.Size = New System.Drawing.Size(889, 25)
        Me.ProductDetailBindingNavigator.TabIndex = 77
        Me.ProductDetailBindingNavigator.Text = "BindingNavigator1"
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
        'ProductDetailBindingSource
        '
        Me.ProductDetailBindingSource.DataMember = "ProductDetail"
        Me.ProductDetailBindingSource.DataSource = Me.ProductDataSet
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
        'ProductDetailBindingNavigatorSaveItem
        '
        Me.ProductDetailBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductDetailBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductDetailBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductDetailBindingNavigatorSaveItem.Name = "ProductDetailBindingNavigatorSaveItem"
        Me.ProductDetailBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProductDetailBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProductDetailDataGridView
        '
        Me.ProductDetailDataGridView.AllowUserToAddRows = False
        Me.ProductDetailDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductDetailDataGridView.AutoGenerateColumns = False
        Me.ProductDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDetailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductDetailID, Me.DataGridViewTextBoxColumn2, Me.UnitID, Me.QtyOnhand, Me.ActualQtyOnHand, Me.InventoryStatus})
        Me.ProductDetailDataGridView.DataSource = Me.ProductDetailBindingSource
        Me.ProductDetailDataGridView.Location = New System.Drawing.Point(0, 75)
        Me.ProductDetailDataGridView.Name = "ProductDetailDataGridView"
        Me.ProductDetailDataGridView.Size = New System.Drawing.Size(889, 376)
        Me.ProductDetailDataGridView.TabIndex = 77
        '
        'ProductDetailTableAdapter
        '
        Me.ProductDetailTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProductDetailTableAdapter = Me.ProductDetailTableAdapter
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sales_And_Inventory_System.ProductDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.ProductDataSet
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'UnitDataSet
        '
        Me.UnitDataSet.DataSetName = "UnitDataSet"
        Me.UnitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UnitBindingSource
        '
        Me.UnitBindingSource.DataMember = "Unit"
        Me.UnitBindingSource.DataSource = Me.UnitDataSet
        '
        'UnitTableAdapter
        '
        Me.UnitTableAdapter.ClearBeforeFill = True
        '
        'ProductDetailID
        '
        Me.ProductDetailID.DataPropertyName = "ProductDetailID"
        Me.ProductDetailID.HeaderText = "ProductDetailID"
        Me.ProductDetailID.Name = "ProductDetailID"
        Me.ProductDetailID.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductID"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.ProductBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "ProductName"
        Me.DataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn2.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "ProductID"
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'UnitID
        '
        Me.UnitID.DataPropertyName = "UnitID"
        Me.UnitID.DataSource = Me.UnitBindingSource
        Me.UnitID.DisplayMember = "UOM"
        Me.UnitID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.UnitID.HeaderText = "U/M"
        Me.UnitID.Name = "UnitID"
        Me.UnitID.ReadOnly = True
        Me.UnitID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UnitID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.UnitID.ValueMember = "UnitID"
        '
        'QtyOnhand
        '
        Me.QtyOnhand.DataPropertyName = "QtyOnhand"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.QtyOnhand.DefaultCellStyle = DataGridViewCellStyle5
        Me.QtyOnhand.HeaderText = "Qty On Hand"
        Me.QtyOnhand.Name = "QtyOnhand"
        Me.QtyOnhand.ReadOnly = True
        '
        'ActualQtyOnHand
        '
        Me.ActualQtyOnHand.DataPropertyName = "ActualQtyOnHand"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ActualQtyOnHand.DefaultCellStyle = DataGridViewCellStyle6
        Me.ActualQtyOnHand.HeaderText = "Actual Qty O/H"
        Me.ActualQtyOnHand.Name = "ActualQtyOnHand"
        Me.ActualQtyOnHand.Width = 140
        '
        'InventoryStatus
        '
        Me.InventoryStatus.DataPropertyName = "InventoryStatus"
        Me.InventoryStatus.HeaderText = "Status"
        Me.InventoryStatus.Items.AddRange(New Object() {"Expired", "Damaged"})
        Me.InventoryStatus.Name = "InventoryStatus"
        Me.InventoryStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InventoryStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'frmStoreInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 480)
        Me.Controls.Add(Me.ProductDetailDataGridView)
        Me.Controls.Add(Me.ProductDetailBindingNavigator)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmStoreInventory"
        Me.Text = "Store Inventory"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProductDetailBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductDetailBindingNavigator.ResumeLayout(False)
        Me.ProductDetailBindingNavigator.PerformLayout()
        CType(Me.ProductDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDetailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ProductDataSet As Sales_And_Inventory_System.ProductDataSet
    Friend WithEvents ProductDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductDetailTableAdapter As Sales_And_Inventory_System.ProductDataSetTableAdapters.ProductDetailTableAdapter
    Friend WithEvents TableAdapterManager As Sales_And_Inventory_System.ProductDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductDetailBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ProductDetailBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProductDetailDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductTableAdapter As Sales_And_Inventory_System.ProductDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents UnitDataSet As Sales_And_Inventory_System.UnitDataSet
    Friend WithEvents UnitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnitTableAdapter As Sales_And_Inventory_System.UnitDataSetTableAdapters.UnitTableAdapter
    Friend WithEvents ProductDetailID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents UnitID As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents QtyOnhand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActualQtyOnHand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InventoryStatus As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
