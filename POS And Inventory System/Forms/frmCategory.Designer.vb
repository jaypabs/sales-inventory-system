<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategory
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
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim ActiveLabel As System.Windows.Forms.Label
        Dim CategoryIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategory))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CategoryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryDataSet = New Sales_And_Inventory_System.CategoryDataSet()
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
        Me.CategoryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CategoryTableAdapter = New Sales_And_Inventory_System.CategoryDataSetTableAdapters.CategoryTableAdapter()
        Me.TableAdapterManager = New Sales_And_Inventory_System.CategoryDataSetTableAdapters.TableAdapterManager()
        Me.SubCategoryTableAdapter = New Sales_And_Inventory_System.CategoryDataSetTableAdapters.SubCategoryTableAdapter()
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.ActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.SubCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubCategoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.CategoryID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CategoryIDTextBox = New System.Windows.Forms.TextBox()
        CategoryLabel = New System.Windows.Forms.Label()
        ActiveLabel = New System.Windows.Forms.Label()
        CategoryIDLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.CategoryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CategoryBindingNavigator.SuspendLayout()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(29, 69)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(52, 13)
        CategoryLabel.TabIndex = 12
        CategoryLabel.Text = "Category:"
        '
        'ActiveLabel
        '
        ActiveLabel.AutoSize = True
        ActiveLabel.Location = New System.Drawing.Point(242, 69)
        ActiveLabel.Name = "ActiveLabel"
        ActiveLabel.Size = New System.Drawing.Size(40, 13)
        ActiveLabel.TabIndex = 14
        ActiveLabel.Text = "Active:"
        '
        'CategoryIDLabel
        '
        CategoryIDLabel.AutoSize = True
        CategoryIDLabel.Location = New System.Drawing.Point(110, 189)
        CategoryIDLabel.Name = "CategoryIDLabel"
        CategoryIDLabel.Size = New System.Drawing.Size(66, 13)
        CategoryIDLabel.TabIndex = 15
        CategoryIDLabel.Text = "Category ID:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(411, 39)
        Me.Panel1.TabIndex = 9
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(342, 9)
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
        Me.Label1.Size = New System.Drawing.Size(85, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Category"
        '
        'CategoryBindingNavigator
        '
        Me.CategoryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CategoryBindingNavigator.BindingSource = Me.CategoryBindingSource
        Me.CategoryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CategoryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CategoryBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CategoryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CategoryBindingNavigatorSaveItem})
        Me.CategoryBindingNavigator.Location = New System.Drawing.Point(0, 350)
        Me.CategoryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CategoryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CategoryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CategoryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CategoryBindingNavigator.Name = "CategoryBindingNavigator"
        Me.CategoryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CategoryBindingNavigator.Size = New System.Drawing.Size(411, 25)
        Me.CategoryBindingNavigator.TabIndex = 10
        Me.CategoryBindingNavigator.Text = "BindingNavigator1"
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
        'CategoryBindingNavigatorSaveItem
        '
        Me.CategoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CategoryBindingNavigatorSaveItem.Image = CType(resources.GetObject("CategoryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CategoryBindingNavigatorSaveItem.Name = "CategoryBindingNavigatorSaveItem"
        Me.CategoryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CategoryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoryTableAdapter = Me.CategoryTableAdapter
        Me.TableAdapterManager.SubCategoryTableAdapter = Me.SubCategoryTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sales_And_Inventory_System.CategoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SubCategoryTableAdapter
        '
        Me.SubCategoryTableAdapter.ClearBeforeFill = True
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoryBindingSource, "Category", True))
        Me.CategoryTextBox.Location = New System.Drawing.Point(101, 66)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.Size = New System.Drawing.Size(104, 20)
        Me.CategoryTextBox.TabIndex = 13
        '
        'ActiveCheckBox
        '
        Me.ActiveCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CategoryBindingSource, "Active", True))
        Me.ActiveCheckBox.Location = New System.Drawing.Point(288, 68)
        Me.ActiveCheckBox.Name = "ActiveCheckBox"
        Me.ActiveCheckBox.Size = New System.Drawing.Size(21, 18)
        Me.ActiveCheckBox.TabIndex = 15
        Me.ActiveCheckBox.UseVisualStyleBackColor = True
        '
        'SubCategoryBindingSource
        '
        Me.SubCategoryBindingSource.DataMember = "Category_SubCategory"
        Me.SubCategoryBindingSource.DataSource = Me.CategoryBindingSource
        '
        'SubCategoryDataGridView
        '
        Me.SubCategoryDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubCategoryDataGridView.AutoGenerateColumns = False
        Me.SubCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubCategoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CategoryID, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1})
        Me.SubCategoryDataGridView.DataSource = Me.SubCategoryBindingSource
        Me.SubCategoryDataGridView.Location = New System.Drawing.Point(0, 110)
        Me.SubCategoryDataGridView.Name = "SubCategoryDataGridView"
        Me.SubCategoryDataGridView.Size = New System.Drawing.Size(411, 220)
        Me.SubCategoryDataGridView.TabIndex = 15
        '
        'CategoryID
        '
        Me.CategoryID.DataPropertyName = "CategoryID"
        Me.CategoryID.HeaderText = "CategoryID"
        Me.CategoryID.Name = "CategoryID"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Subcategory"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sub Category"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Active"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Active"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'CategoryIDTextBox
        '
        Me.CategoryIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoryBindingSource, "CategoryID", True))
        Me.CategoryIDTextBox.Location = New System.Drawing.Point(182, 186)
        Me.CategoryIDTextBox.Name = "CategoryIDTextBox"
        Me.CategoryIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CategoryIDTextBox.TabIndex = 16
        '
        'frmCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 375)
        Me.Controls.Add(Me.SubCategoryDataGridView)
        Me.Controls.Add(CategoryLabel)
        Me.Controls.Add(Me.CategoryTextBox)
        Me.Controls.Add(ActiveLabel)
        Me.Controls.Add(Me.ActiveCheckBox)
        Me.Controls.Add(Me.CategoryBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(CategoryIDLabel)
        Me.Controls.Add(Me.CategoryIDTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCategory"
        Me.Text = "Category"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CategoryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CategoryBindingNavigator.ResumeLayout(False)
        Me.CategoryBindingNavigator.PerformLayout()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CategoryDataSet As Sales_And_Inventory_System.CategoryDataSet
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoryTableAdapter As Sales_And_Inventory_System.CategoryDataSetTableAdapters.CategoryTableAdapter
    Friend WithEvents TableAdapterManager As Sales_And_Inventory_System.CategoryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CategoryBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CategoryBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CategoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ActiveCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SubCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubCategoryTableAdapter As Sales_And_Inventory_System.CategoryDataSetTableAdapters.SubCategoryTableAdapter
    Friend WithEvents SubCategoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CategoryIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
