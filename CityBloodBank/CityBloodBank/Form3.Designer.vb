<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim FIRST_NAMELabel As System.Windows.Forms.Label
        Dim LAST_NAMELabel As System.Windows.Forms.Label
        Dim BLOOD_GROUPLabel As System.Windows.Forms.Label
        Dim MOBILE_NOLabel As System.Windows.Forms.Label
        Dim EMAILLabel As System.Windows.Forms.Label
        Dim ADDRESSLabel As System.Windows.Forms.Label
        Dim DATE_OF_ENTRYLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
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
        Me.FIRST_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.LAST_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.BLOOD_GROUPTextBox = New System.Windows.Forms.TextBox()
        Me.MOBILE_NOTextBox = New System.Windows.Forms.TextBox()
        Me.EMAILTextBox = New System.Windows.Forms.TextBox()
        Me.ADDRESSTextBox = New System.Windows.Forms.TextBox()
        Me.DATE_OF_ENTRYDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AddNewBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.Close = New System.Windows.Forms.Button()
        FIRST_NAMELabel = New System.Windows.Forms.Label()
        LAST_NAMELabel = New System.Windows.Forms.Label()
        BLOOD_GROUPLabel = New System.Windows.Forms.Label()
        MOBILE_NOLabel = New System.Windows.Forms.Label()
        EMAILLabel = New System.Windows.Forms.Label()
        ADDRESSLabel = New System.Windows.Forms.Label()
        DATE_OF_ENTRYLabel = New System.Windows.Forms.Label()
        CType(Me.CityBloodBankDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonerDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DonerDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DonerDetailsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'FIRST_NAMELabel
        '
        FIRST_NAMELabel.AutoSize = True
        FIRST_NAMELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FIRST_NAMELabel.Location = New System.Drawing.Point(6, 63)
        FIRST_NAMELabel.Name = "FIRST_NAMELabel"
        FIRST_NAMELabel.Size = New System.Drawing.Size(82, 15)
        FIRST_NAMELabel.TabIndex = 3
        FIRST_NAMELabel.Text = "FIRST NAME:"
        '
        'LAST_NAMELabel
        '
        LAST_NAMELabel.AutoSize = True
        LAST_NAMELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LAST_NAMELabel.Location = New System.Drawing.Point(7, 86)
        LAST_NAMELabel.Name = "LAST_NAMELabel"
        LAST_NAMELabel.Size = New System.Drawing.Size(77, 15)
        LAST_NAMELabel.TabIndex = 5
        LAST_NAMELabel.Text = "LAST NAME:"
        '
        'BLOOD_GROUPLabel
        '
        BLOOD_GROUPLabel.AutoSize = True
        BLOOD_GROUPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BLOOD_GROUPLabel.Location = New System.Drawing.Point(7, 111)
        BLOOD_GROUPLabel.Name = "BLOOD_GROUPLabel"
        BLOOD_GROUPLabel.Size = New System.Drawing.Size(99, 15)
        BLOOD_GROUPLabel.TabIndex = 7
        BLOOD_GROUPLabel.Text = "BLOOD GROUP:"
        '
        'MOBILE_NOLabel
        '
        MOBILE_NOLabel.AutoSize = True
        MOBILE_NOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MOBILE_NOLabel.Location = New System.Drawing.Point(7, 144)
        MOBILE_NOLabel.Name = "MOBILE_NOLabel"
        MOBILE_NOLabel.Size = New System.Drawing.Size(77, 15)
        MOBILE_NOLabel.TabIndex = 9
        MOBILE_NOLabel.Text = "MOBILE NO:"
        '
        'EMAILLabel
        '
        EMAILLabel.AutoSize = True
        EMAILLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EMAILLabel.Location = New System.Drawing.Point(7, 170)
        EMAILLabel.Name = "EMAILLabel"
        EMAILLabel.Size = New System.Drawing.Size(46, 15)
        EMAILLabel.TabIndex = 11
        EMAILLabel.Text = "EMAIL:"
        '
        'ADDRESSLabel
        '
        ADDRESSLabel.AutoSize = True
        ADDRESSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ADDRESSLabel.Location = New System.Drawing.Point(6, 196)
        ADDRESSLabel.Name = "ADDRESSLabel"
        ADDRESSLabel.Size = New System.Drawing.Size(68, 15)
        ADDRESSLabel.TabIndex = 13
        ADDRESSLabel.Text = "ADDRESS:"
        '
        'DATE_OF_ENTRYLabel
        '
        DATE_OF_ENTRYLabel.AutoSize = True
        DATE_OF_ENTRYLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DATE_OF_ENTRYLabel.Location = New System.Drawing.Point(6, 264)
        DATE_OF_ENTRYLabel.Name = "DATE_OF_ENTRYLabel"
        DATE_OF_ENTRYLabel.Size = New System.Drawing.Size(103, 15)
        DATE_OF_ENTRYLabel.TabIndex = 15
        DATE_OF_ENTRYLabel.Text = "DATE OF ENTRY:"
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
        Me.DonerDetailsBindingNavigator.Size = New System.Drawing.Size(679, 25)
        Me.DonerDetailsBindingNavigator.TabIndex = 0
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
        'FIRST_NAMETextBox
        '
        Me.FIRST_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DonerDetailsBindingSource, "FIRST_NAME", True))
        Me.FIRST_NAMETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FIRST_NAMETextBox.Location = New System.Drawing.Point(124, 60)
        Me.FIRST_NAMETextBox.Name = "FIRST_NAMETextBox"
        Me.FIRST_NAMETextBox.Size = New System.Drawing.Size(161, 22)
        Me.FIRST_NAMETextBox.TabIndex = 4
        '
        'LAST_NAMETextBox
        '
        Me.LAST_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DonerDetailsBindingSource, "LAST_NAME", True))
        Me.LAST_NAMETextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAST_NAMETextBox.Location = New System.Drawing.Point(124, 86)
        Me.LAST_NAMETextBox.Name = "LAST_NAMETextBox"
        Me.LAST_NAMETextBox.Size = New System.Drawing.Size(161, 22)
        Me.LAST_NAMETextBox.TabIndex = 6
        '
        'BLOOD_GROUPTextBox
        '
        Me.BLOOD_GROUPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DonerDetailsBindingSource, "BLOOD_GROUP", True))
        Me.BLOOD_GROUPTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLOOD_GROUPTextBox.Location = New System.Drawing.Point(124, 113)
        Me.BLOOD_GROUPTextBox.Name = "BLOOD_GROUPTextBox"
        Me.BLOOD_GROUPTextBox.Size = New System.Drawing.Size(143, 22)
        Me.BLOOD_GROUPTextBox.TabIndex = 8
        '
        'MOBILE_NOTextBox
        '
        Me.MOBILE_NOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DonerDetailsBindingSource, "MOBILE NO", True))
        Me.MOBILE_NOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MOBILE_NOTextBox.Location = New System.Drawing.Point(125, 141)
        Me.MOBILE_NOTextBox.Name = "MOBILE_NOTextBox"
        Me.MOBILE_NOTextBox.Size = New System.Drawing.Size(142, 22)
        Me.MOBILE_NOTextBox.TabIndex = 10
        '
        'EMAILTextBox
        '
        Me.EMAILTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DonerDetailsBindingSource, "EMAIL", True))
        Me.EMAILTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMAILTextBox.Location = New System.Drawing.Point(125, 170)
        Me.EMAILTextBox.Name = "EMAILTextBox"
        Me.EMAILTextBox.Size = New System.Drawing.Size(200, 22)
        Me.EMAILTextBox.TabIndex = 12
        '
        'ADDRESSTextBox
        '
        Me.ADDRESSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DonerDetailsBindingSource, "ADDRESS", True))
        Me.ADDRESSTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADDRESSTextBox.Location = New System.Drawing.Point(124, 196)
        Me.ADDRESSTextBox.Multiline = True
        Me.ADDRESSTextBox.Name = "ADDRESSTextBox"
        Me.ADDRESSTextBox.Size = New System.Drawing.Size(200, 62)
        Me.ADDRESSTextBox.TabIndex = 14
        '
        'DATE_OF_ENTRYDateTimePicker
        '
        Me.DATE_OF_ENTRYDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DonerDetailsBindingSource, "DATE_OF_ENTRY", True))
        Me.DATE_OF_ENTRYDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DATE_OF_ENTRYDateTimePicker.Location = New System.Drawing.Point(120, 264)
        Me.DATE_OF_ENTRYDateTimePicker.Name = "DATE_OF_ENTRYDateTimePicker"
        Me.DATE_OF_ENTRYDateTimePicker.Size = New System.Drawing.Size(177, 22)
        Me.DATE_OF_ENTRYDateTimePicker.TabIndex = 16
        '
        'AddNewBtn
        '
        Me.AddNewBtn.Location = New System.Drawing.Point(13, 330)
        Me.AddNewBtn.Name = "AddNewBtn"
        Me.AddNewBtn.Size = New System.Drawing.Size(75, 23)
        Me.AddNewBtn.TabIndex = 17
        Me.AddNewBtn.Text = "Add New"
        Me.AddNewBtn.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(105, 330)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(75, 23)
        Me.SaveBtn.TabIndex = 18
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(196, 330)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(75, 23)
        Me.DeleteBtn.TabIndex = 19
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'Close
        '
        Me.Close.Location = New System.Drawing.Point(277, 330)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(75, 23)
        Me.Close.TabIndex = 20
        Me.Close.Text = "Close"
        Me.Close.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(679, 410)
        Me.Controls.Add(Me.Close)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.AddNewBtn)
        Me.Controls.Add(FIRST_NAMELabel)
        Me.Controls.Add(Me.FIRST_NAMETextBox)
        Me.Controls.Add(LAST_NAMELabel)
        Me.Controls.Add(Me.LAST_NAMETextBox)
        Me.Controls.Add(BLOOD_GROUPLabel)
        Me.Controls.Add(Me.BLOOD_GROUPTextBox)
        Me.Controls.Add(MOBILE_NOLabel)
        Me.Controls.Add(Me.MOBILE_NOTextBox)
        Me.Controls.Add(EMAILLabel)
        Me.Controls.Add(Me.EMAILTextBox)
        Me.Controls.Add(ADDRESSLabel)
        Me.Controls.Add(Me.ADDRESSTextBox)
        Me.Controls.Add(DATE_OF_ENTRYLabel)
        Me.Controls.Add(Me.DATE_OF_ENTRYDateTimePicker)
        Me.Controls.Add(Me.DonerDetailsBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.CityBloodBankDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonerDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DonerDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DonerDetailsBindingNavigator.ResumeLayout(False)
        Me.DonerDetailsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents FIRST_NAMETextBox As TextBox
    Friend WithEvents LAST_NAMETextBox As TextBox
    Friend WithEvents BLOOD_GROUPTextBox As TextBox
    Friend WithEvents MOBILE_NOTextBox As TextBox
    Friend WithEvents EMAILTextBox As TextBox
    Friend WithEvents ADDRESSTextBox As TextBox
    Friend WithEvents DATE_OF_ENTRYDateTimePicker As DateTimePicker
    Friend WithEvents AddNewBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents Close As Button
End Class
