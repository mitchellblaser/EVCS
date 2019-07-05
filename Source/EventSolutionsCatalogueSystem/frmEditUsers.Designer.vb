<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditUsers
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
        Me.lstUsernames = New System.Windows.Forms.ListBox()
        Me.lstPasswords = New System.Windows.Forms.ListBox()
        Me.lstPriveliges = New System.Windows.Forms.ListBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblPrivelige = New System.Windows.Forms.Label()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.SuspendLayout()
        '
        'lstUsernames
        '
        Me.lstUsernames.FormattingEnabled = True
        Me.lstUsernames.Location = New System.Drawing.Point(16, 57)
        Me.lstUsernames.Name = "lstUsernames"
        Me.lstUsernames.Size = New System.Drawing.Size(174, 355)
        Me.lstUsernames.TabIndex = 0
        '
        'lstPasswords
        '
        Me.lstPasswords.FormattingEnabled = True
        Me.lstPasswords.Location = New System.Drawing.Point(196, 57)
        Me.lstPasswords.Name = "lstPasswords"
        Me.lstPasswords.Size = New System.Drawing.Size(174, 355)
        Me.lstPasswords.TabIndex = 1
        '
        'lstPriveliges
        '
        Me.lstPriveliges.FormattingEnabled = True
        Me.lstPriveliges.Location = New System.Drawing.Point(376, 57)
        Me.lstPriveliges.Name = "lstPriveliges"
        Me.lstPriveliges.Size = New System.Drawing.Size(174, 355)
        Me.lstPriveliges.TabIndex = 2
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(170, 24)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Edit User Accounts"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(13, 41)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 4
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(193, 41)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Password"
        '
        'lblPrivelige
        '
        Me.lblPrivelige.AutoSize = True
        Me.lblPrivelige.Location = New System.Drawing.Point(373, 41)
        Me.lblPrivelige.Name = "lblPrivelige"
        Me.lblPrivelige.Size = New System.Drawing.Size(71, 13)
        Me.lblPrivelige.TabIndex = 6
        Me.lblPrivelige.Text = "Access Level"
        '
        'btnAddUser
        '
        Me.btnAddUser.Location = New System.Drawing.Point(575, 57)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(110, 23)
        Me.btnAddUser.TabIndex = 7
        Me.btnAddUser.Text = "Add User"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Location = New System.Drawing.Point(575, 86)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(110, 23)
        Me.btnDeleteUser.TabIndex = 8
        Me.btnDeleteUser.Text = "Delete User"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(575, 389)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(110, 23)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(553, 57)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(19, 355)
        Me.VScrollBar1.TabIndex = 10
        '
        'frmEditUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 429)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.lblPrivelige)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lstPriveliges)
        Me.Controls.Add(Me.lstPasswords)
        Me.Controls.Add(Me.lstUsernames)
        Me.Name = "frmEditUsers"
        Me.Text = "Edit Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstUsernames As ListBox
    Friend WithEvents lstPasswords As ListBox
    Friend WithEvents lstPriveliges As ListBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblPrivelige As Label
    Friend WithEvents btnAddUser As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents VScrollBar1 As VScrollBar
End Class
