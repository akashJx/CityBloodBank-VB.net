<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.UsrNameTxtBox = New System.Windows.Forms.TextBox()
        Me.PswdTxtBox = New System.Windows.Forms.TextBox()
        Me.UsrNameLabel = New System.Windows.Forms.Label()
        Me.PswdLabel = New System.Windows.Forms.Label()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UsrNameTxtBox
        '
        Me.UsrNameTxtBox.Location = New System.Drawing.Point(295, 83)
        Me.UsrNameTxtBox.Name = "UsrNameTxtBox"
        Me.UsrNameTxtBox.Size = New System.Drawing.Size(190, 20)
        Me.UsrNameTxtBox.TabIndex = 0
        '
        'PswdTxtBox
        '
        Me.PswdTxtBox.Location = New System.Drawing.Point(295, 147)
        Me.PswdTxtBox.Name = "PswdTxtBox"
        Me.PswdTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.PswdTxtBox.Size = New System.Drawing.Size(190, 20)
        Me.PswdTxtBox.TabIndex = 1
        '
        'UsrNameLabel
        '
        Me.UsrNameLabel.AutoSize = True
        Me.UsrNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsrNameLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsrNameLabel.ForeColor = System.Drawing.Color.White
        Me.UsrNameLabel.Location = New System.Drawing.Point(295, 64)
        Me.UsrNameLabel.Name = "UsrNameLabel"
        Me.UsrNameLabel.Size = New System.Drawing.Size(81, 19)
        Me.UsrNameLabel.TabIndex = 2
        Me.UsrNameLabel.Text = "Username"
        '
        'PswdLabel
        '
        Me.PswdLabel.AutoSize = True
        Me.PswdLabel.BackColor = System.Drawing.Color.Transparent
        Me.PswdLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PswdLabel.ForeColor = System.Drawing.Color.White
        Me.PswdLabel.Location = New System.Drawing.Point(294, 125)
        Me.PswdLabel.Name = "PswdLabel"
        Me.PswdLabel.Size = New System.Drawing.Size(81, 19)
        Me.PswdLabel.TabIndex = 3
        Me.PswdLabel.Text = "Password"
        '
        'LoginBtn
        '
        Me.LoginBtn.Location = New System.Drawing.Point(295, 186)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(75, 23)
        Me.LoginBtn.TabIndex = 4
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CityBloodBank.My.Resources.Resources.Bank
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(513, 267)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.PswdLabel)
        Me.Controls.Add(Me.UsrNameLabel)
        Me.Controls.Add(Me.PswdTxtBox)
        Me.Controls.Add(Me.UsrNameTxtBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginForm"
        Me.Text = "City Blood Bank"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsrNameTxtBox As TextBox
    Friend WithEvents PswdTxtBox As TextBox
    Friend WithEvents UsrNameLabel As Label
    Friend WithEvents PswdLabel As Label
    Friend WithEvents LoginBtn As Button
End Class
