<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddUserBox
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
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblAccessLevel = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.cmbAccessLevel = New System.Windows.Forms.ComboBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(13, 13)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(12, 39)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password"
        '
        'lblAccessLevel
        '
        Me.lblAccessLevel.AutoSize = True
        Me.lblAccessLevel.Location = New System.Drawing.Point(13, 65)
        Me.lblAccessLevel.Name = "lblAccessLevel"
        Me.lblAccessLevel.Size = New System.Drawing.Size(71, 13)
        Me.lblAccessLevel.TabIndex = 2
        Me.lblAccessLevel.Text = "Access Level"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(90, 36)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(188, 20)
        Me.txtPassword.TabIndex = 5
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(90, 10)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(188, 20)
        Me.txtUsername.TabIndex = 4
        '
        'cmbAccessLevel
        '
        Me.cmbAccessLevel.FormattingEnabled = True
        Me.cmbAccessLevel.Items.AddRange(New Object() {"Standard", "Administrator"})
        Me.cmbAccessLevel.Location = New System.Drawing.Point(90, 62)
        Me.cmbAccessLevel.Name = "cmbAccessLevel"
        Me.cmbAccessLevel.Size = New System.Drawing.Size(188, 21)
        Me.cmbAccessLevel.TabIndex = 6
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(203, 89)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmAddUserBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 120)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.cmbAccessLevel)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblAccessLevel)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Name = "frmAddUserBox"
        Me.Text = "Add User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblAccessLevel As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents cmbAccessLevel As ComboBox
    Friend WithEvents btnOK As Button
End Class
