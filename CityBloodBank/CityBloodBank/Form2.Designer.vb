<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.AddNewBtn = New System.Windows.Forms.Button()
        Me.CityBloodBankDBDataSet = New CityBloodBank.CityBloodBankDBDataSet()
        Me.DonerDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DonerDetailsTableAdapter = New CityBloodBank.CityBloodBankDBDataSetTableAdapters.DonerDetailsTableAdapter()
        Me.TableAdapterManager = New CityBloodBank.CityBloodBankDBDataSetTableAdapters.TableAdapterManager()
        Me.DonerDetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DonerDetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BLOODGROUPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOBILENODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEOFENTRYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.CityBloodBankDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonerDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonerDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DonerDetailsBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddNewBtn
        '
        Me.AddNewBtn.Location = New System.Drawing.Point(12, 37)
        Me.AddNewBtn.Name = "AddNewBtn"
        Me.AddNewBtn.Size = New System.Drawing.Size(75, 23)
        Me.AddNewBtn.TabIndex = 0
        Me.AddNewBtn.Text = "Add New"
        Me.AddNewBtn.UseVisualStyleBackColor = True
        '
        'CityBloodBankDBDataSet
        '
        Me.CityBloodBankDBDataSet.DataSetName = "CityBloodBankDBDataSet"
        Me.CityBloodBankDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DonerDetailsBindingSource
        '
        Me.DonerDetailsBindingSource.DataMember = "DonerDetails"
        Me.DonerDetailsBindingSource.DataSource = Me.CityBloodBankDBDataSet
        '
        'DonerDetailsTableAdapter
        '
        Me.DonerDetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DonerDetailsTableAdapter = Me.DonerDetailsTableAdapter
        Me.TableAdapterManager.UpdateOrder = CityBloodBank.CityBloodBankDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DonerDetailsBindingNavigator
        '
        Me.DonerDetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DonerDetailsBindingNavigator.BindingSource = Me.DonerDetailsBindingSource
        Me.DonerDetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DonerDetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DonerDetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DonerDetailsBindingNavigatorSaveItem})
        Me.DonerDetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DonerDetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DonerDetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DonerDetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DonerDetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DonerDetailsBindingNavigator.Name = "DonerDetailsBindingNavigator"
        Me.DonerDetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DonerDetailsBindingNavigator.Size = New System.Drawing.Size(786, 25)
        Me.DonerDetailsBindingNavigator.TabIndex = 1
        Me.DonerDetailsBindingNavigator.Text = "BindingNavigator1"
        Me.DonerDetailsBindingNavigator.Visible = False
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
        'DonerDetailsBindingNavigatorSaveItem
        '
        Me.DonerDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DonerDetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("DonerDetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DonerDetailsBindingNavigatorSaveItem.Name = "DonerDetailsBindingNavigatorSaveItem"
        Me.DonerDetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DonerDetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SNODataGridViewTextBoxColumn, Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.BLOODGROUPDataGridViewTextBoxColumn, Me.MOBILENODataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn, Me.DATEOFENTRYDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DonerDetailsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(735, 334)
        Me.DataGridView1.TabIndex = 18
        '
        'SNODataGridViewTextBoxColumn
        '
        Me.SNODataGridViewTextBoxColumn.DataPropertyName = "SNO"
        Me.SNODataGridViewTextBoxColumn.HeaderText = "SNO"
        Me.SNODataGridViewTextBoxColumn.Name = "SNODataGridViewTextBoxColumn"
        '
        'FIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST_NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRST_NAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Name = "FIRSTNAMEDataGridViewTextBoxColumn"
        '
        'LASTNAMEDataGridViewTextBoxColumn
        '
        Me.LASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LAST_NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.HeaderText = "LAST_NAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.Name = "LASTNAMEDataGridViewTextBoxColumn"
        '
        'BLOODGROUPDataGridViewTextBoxColumn
        '
        Me.BLOODGROUPDataGridViewTextBoxColumn.DataPropertyName = "BLOOD_GROUP"
        Me.BLOODGROUPDataGridViewTextBoxColumn.HeaderText = "BLOOD_GROUP"
        Me.BLOODGROUPDataGridViewTextBoxColumn.Name = "BLOODGROUPDataGridViewTextBoxColumn"
        '
        'MOBILENODataGridViewTextBoxColumn
        '
        Me.MOBILENODataGridViewTextBoxColumn.DataPropertyName = "MOBILE NO"
        Me.MOBILENODataGridViewTextBoxColumn.HeaderText = "MOBILE NO"
        Me.MOBILENODataGridViewTextBoxColumn.Name = "MOBILENODataGridViewTextBoxColumn"
        '
        'EMAILDataGridViewTextBoxColumn
        '
        Me.EMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.Name = "EMAILDataGridViewTextBoxColumn"
        '
        'ADDRESSDataGridViewTextBoxColumn
        '
        Me.ADDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.Name = "ADDRESSDataGridViewTextBoxColumn"
        '
        'DATEOFENTRYDataGridViewTextBoxColumn
        '
        Me.DATEOFENTRYDataGridViewTextBoxColumn.DataPropertyName = "DATE_OF_ENTRY"
        Me.DATEOFENTRYDataGridViewTextBoxColumn.HeaderText = "DATE_OF_ENTRY"
        Me.DATEOFENTRYDataGridViewTextBoxColumn.Name = "DATEOFENTRYDataGridViewTextBoxColumn"
        '
        'LogoutBtn
        '
        Me.LogoutBtn.Location = New System.Drawing.Point(672, 37)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(75, 23)
        Me.LogoutBtn.TabIndex = 19
        Me.LogoutBtn.Text = "Logout"
        Me.LogoutBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(106, 37)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(75, 23)
        Me.DeleteBtn.TabIndex = 20
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(223, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 24)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "List Of Available Blood"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(786, 412)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.LogoutBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DonerDetailsBindingNavigator)
        Me.Controls.Add(Me.AddNewBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.CityBloodBankDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonerDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonerDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DonerDetailsBindingNavigator.ResumeLayout(False)
        Me.DonerDetailsBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddNewBtn As Button
    Friend WithEvents CityBloodBankDBDataSet As CityBloodBankDBDataSet
    Friend WithEvents DonerDetailsBindingSource As BindingSource
    Friend WithEvents DonerDetailsTableAdapter As CityBloodBankDBDataSetTableAdapters.DonerDetailsTableAdapter
    Friend WithEvents TableAdapterManager As CityBloodBankDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DonerDetailsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents DonerDetailsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BLOODGROUPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MOBILENODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATEOFENTRYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LogoutBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents Label1 As Label
End Class
