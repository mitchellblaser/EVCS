<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnAddClient = New System.Windows.Forms.Button()
        Me.btnAddEquipment = New System.Windows.Forms.Button()
        Me.btnAddHire = New System.Windows.Forms.Button()
        Me.btnViewData = New System.Windows.Forms.Button()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.btnEditUsers = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(149, 8)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(98, 27)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "Main Menu"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Panel1.Controls.Add(Me.picLogo)
        Me.Panel1.Controls.Add(Me.lblMenu)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(258, 40)
        Me.Panel1.TabIndex = 1
        '
        'picLogo
        '
        Me.picLogo.Image = Global.EventSolutionsCatalogueSystem.My.Resources.Resources.EventSolutionsLogo_Cropped
        Me.picLogo.Location = New System.Drawing.Point(9, 6)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(140, 29)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        '
        'btnAddClient
        '
        Me.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddClient.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddClient.ForeColor = System.Drawing.Color.White
        Me.btnAddClient.Location = New System.Drawing.Point(12, 52)
        Me.btnAddClient.Name = "btnAddClient"
        Me.btnAddClient.Size = New System.Drawing.Size(114, 53)
        Me.btnAddClient.TabIndex = 2
        Me.btnAddClient.Text = "Add Client"
        Me.btnAddClient.UseVisualStyleBackColor = True
        '
        'btnAddEquipment
        '
        Me.btnAddEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEquipment.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEquipment.ForeColor = System.Drawing.Color.White
        Me.btnAddEquipment.Location = New System.Drawing.Point(12, 111)
        Me.btnAddEquipment.Name = "btnAddEquipment"
        Me.btnAddEquipment.Size = New System.Drawing.Size(114, 53)
        Me.btnAddEquipment.TabIndex = 3
        Me.btnAddEquipment.Text = "Add Equipment"
        Me.btnAddEquipment.UseVisualStyleBackColor = True
        '
        'btnAddHire
        '
        Me.btnAddHire.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddHire.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddHire.ForeColor = System.Drawing.Color.White
        Me.btnAddHire.Location = New System.Drawing.Point(12, 170)
        Me.btnAddHire.Name = "btnAddHire"
        Me.btnAddHire.Size = New System.Drawing.Size(114, 53)
        Me.btnAddHire.TabIndex = 4
        Me.btnAddHire.Text = "Add Hire"
        Me.btnAddHire.UseVisualStyleBackColor = True
        '
        'btnViewData
        '
        Me.btnViewData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewData.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewData.ForeColor = System.Drawing.Color.White
        Me.btnViewData.Location = New System.Drawing.Point(132, 52)
        Me.btnViewData.Name = "btnViewData"
        Me.btnViewData.Size = New System.Drawing.Size(114, 53)
        Me.btnViewData.TabIndex = 5
        Me.btnViewData.Text = "View Data"
        Me.btnViewData.UseVisualStyleBackColor = True
        '
        'picClose
        '
        Me.picClose.Image = Global.EventSolutionsCatalogueSystem.My.Resources.Resources.CloseButton
        Me.picClose.Location = New System.Drawing.Point(208, 193)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(55, 44)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picClose.TabIndex = 6
        Me.picClose.TabStop = False
        '
        'btnEditUsers
        '
        Me.btnEditUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditUsers.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditUsers.ForeColor = System.Drawing.Color.White
        Me.btnEditUsers.Location = New System.Drawing.Point(132, 111)
        Me.btnEditUsers.Name = "btnEditUsers"
        Me.btnEditUsers.Size = New System.Drawing.Size(114, 53)
        Me.btnEditUsers.TabIndex = 7
        Me.btnEditUsers.Text = "Add/Remove Users"
        Me.btnEditUsers.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(218, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "v1.0.0"
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(258, 236)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEditUsers)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.btnViewData)
        Me.Controls.Add(Me.btnAddHire)
        Me.Controls.Add(Me.btnAddEquipment)
        Me.Controls.Add(Me.btnAddClient)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMainMenu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblMenu As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAddClient As Button
    Friend WithEvents btnAddEquipment As Button
    Friend WithEvents btnAddHire As Button
    Friend WithEvents btnViewData As Button
    Friend WithEvents picClose As PictureBox
    Friend WithEvents btnEditUsers As Button
    Friend WithEvents Label1 As Label
End Class
