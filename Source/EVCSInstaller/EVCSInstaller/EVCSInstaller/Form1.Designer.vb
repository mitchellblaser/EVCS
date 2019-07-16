<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInstaller
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInstaller))
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.prgBar = New System.Windows.Forms.ProgressBar()
        Me.btnInstall = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picTitle = New System.Windows.Forms.PictureBox()
        Me.chkAdvancedOptions = New System.Windows.Forms.CheckBox()
        Me.pnlAdvancedOptions = New System.Windows.Forms.Panel()
        Me.btnLocateFolder = New System.Windows.Forms.Button()
        Me.nudEquipment = New System.Windows.Forms.NumericUpDown()
        Me.nudClient = New System.Windows.Forms.NumericUpDown()
        Me.nudHire = New System.Windows.Forms.NumericUpDown()
        Me.nudCalendar = New System.Windows.Forms.NumericUpDown()
        Me.lblCalendar = New System.Windows.Forms.Label()
        Me.lblHire = New System.Windows.Forms.Label()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.lblEquipment = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.dlgSaveDirectory = New System.Windows.Forms.FolderBrowserDialog()
        Me.pnlLeft.SuspendLayout()
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAdvancedOptions.SuspendLayout()
        CType(Me.nudEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.pnlLeft.Controls.Add(Me.prgBar)
        Me.pnlLeft.Controls.Add(Me.btnInstall)
        Me.pnlLeft.Controls.Add(Me.lblTitle)
        Me.pnlLeft.Controls.Add(Me.picTitle)
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(387, 506)
        Me.pnlLeft.TabIndex = 0
        '
        'prgBar
        '
        Me.prgBar.Location = New System.Drawing.Point(32, 458)
        Me.prgBar.Margin = New System.Windows.Forms.Padding(4)
        Me.prgBar.Maximum = 150
        Me.prgBar.Name = "prgBar"
        Me.prgBar.Size = New System.Drawing.Size(317, 28)
        Me.prgBar.TabIndex = 10
        '
        'btnInstall
        '
        Me.btnInstall.Location = New System.Drawing.Point(95, 422)
        Me.btnInstall.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInstall.Name = "btnInstall"
        Me.btnInstall.Size = New System.Drawing.Size(189, 28)
        Me.btnInstall.TabIndex = 9
        Me.btnInstall.Text = "Install"
        Me.btnInstall.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Gill Sans MT", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(41, 164)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(290, 52)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Catalogue System"
        '
        'picTitle
        '
        Me.picTitle.Image = Global.EVCSInstaller.My.Resources.Resources.logo
        Me.picTitle.Location = New System.Drawing.Point(25, 110)
        Me.picTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.picTitle.Name = "picTitle"
        Me.picTitle.Size = New System.Drawing.Size(335, 58)
        Me.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTitle.TabIndex = 1
        Me.picTitle.TabStop = False
        '
        'chkAdvancedOptions
        '
        Me.chkAdvancedOptions.AutoSize = True
        Me.chkAdvancedOptions.Location = New System.Drawing.Point(403, 126)
        Me.chkAdvancedOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAdvancedOptions.Name = "chkAdvancedOptions"
        Me.chkAdvancedOptions.Size = New System.Drawing.Size(133, 21)
        Me.chkAdvancedOptions.TabIndex = 3
        Me.chkAdvancedOptions.Text = "Advanced Install"
        Me.chkAdvancedOptions.UseVisualStyleBackColor = True
        '
        'pnlAdvancedOptions
        '
        Me.pnlAdvancedOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAdvancedOptions.Controls.Add(Me.btnLocateFolder)
        Me.pnlAdvancedOptions.Controls.Add(Me.nudEquipment)
        Me.pnlAdvancedOptions.Controls.Add(Me.nudClient)
        Me.pnlAdvancedOptions.Controls.Add(Me.nudHire)
        Me.pnlAdvancedOptions.Controls.Add(Me.nudCalendar)
        Me.pnlAdvancedOptions.Controls.Add(Me.lblCalendar)
        Me.pnlAdvancedOptions.Controls.Add(Me.lblHire)
        Me.pnlAdvancedOptions.Controls.Add(Me.lblClient)
        Me.pnlAdvancedOptions.Controls.Add(Me.lblEquipment)
        Me.pnlAdvancedOptions.Controls.Add(Me.lblLocation)
        Me.pnlAdvancedOptions.Controls.Add(Me.txtLocation)
        Me.pnlAdvancedOptions.Location = New System.Drawing.Point(393, 206)
        Me.pnlAdvancedOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlAdvancedOptions.Name = "pnlAdvancedOptions"
        Me.pnlAdvancedOptions.Size = New System.Drawing.Size(353, 294)
        Me.pnlAdvancedOptions.TabIndex = 2
        Me.pnlAdvancedOptions.Visible = False
        '
        'btnLocateFolder
        '
        Me.btnLocateFolder.Location = New System.Drawing.Point(300, 26)
        Me.btnLocateFolder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLocateFolder.Name = "btnLocateFolder"
        Me.btnLocateFolder.Size = New System.Drawing.Size(41, 25)
        Me.btnLocateFolder.TabIndex = 12
        Me.btnLocateFolder.Text = "..."
        Me.btnLocateFolder.UseVisualStyleBackColor = True
        '
        'nudEquipment
        '
        Me.nudEquipment.Location = New System.Drawing.Point(8, 84)
        Me.nudEquipment.Margin = New System.Windows.Forms.Padding(4)
        Me.nudEquipment.Name = "nudEquipment"
        Me.nudEquipment.Size = New System.Drawing.Size(333, 22)
        Me.nudEquipment.TabIndex = 5
        Me.nudEquipment.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'nudClient
        '
        Me.nudClient.Location = New System.Drawing.Point(8, 142)
        Me.nudClient.Margin = New System.Windows.Forms.Padding(4)
        Me.nudClient.Name = "nudClient"
        Me.nudClient.Size = New System.Drawing.Size(333, 22)
        Me.nudClient.TabIndex = 6
        Me.nudClient.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'nudHire
        '
        Me.nudHire.Location = New System.Drawing.Point(8, 198)
        Me.nudHire.Margin = New System.Windows.Forms.Padding(4)
        Me.nudHire.Name = "nudHire"
        Me.nudHire.Size = New System.Drawing.Size(333, 22)
        Me.nudHire.TabIndex = 7
        Me.nudHire.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'nudCalendar
        '
        Me.nudCalendar.Location = New System.Drawing.Point(8, 257)
        Me.nudCalendar.Margin = New System.Windows.Forms.Padding(4)
        Me.nudCalendar.Name = "nudCalendar"
        Me.nudCalendar.Size = New System.Drawing.Size(333, 22)
        Me.nudCalendar.TabIndex = 8
        Me.nudCalendar.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'lblCalendar
        '
        Me.lblCalendar.AutoSize = True
        Me.lblCalendar.Location = New System.Drawing.Point(4, 238)
        Me.lblCalendar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCalendar.Name = "lblCalendar"
        Me.lblCalendar.Size = New System.Drawing.Size(325, 17)
        Me.lblCalendar.TabIndex = 9
        Me.lblCalendar.Text = "Maximum Calendar Entries (Can be changed later)"
        '
        'lblHire
        '
        Me.lblHire.AutoSize = True
        Me.lblHire.Location = New System.Drawing.Point(4, 178)
        Me.lblHire.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHire.Name = "lblHire"
        Me.lblHire.Size = New System.Drawing.Size(294, 17)
        Me.lblHire.TabIndex = 7
        Me.lblHire.Text = "Maximum Hire Entries (Can be changed later)"
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.Location = New System.Drawing.Point(4, 122)
        Me.lblClient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(303, 17)
        Me.lblClient.TabIndex = 5
        Me.lblClient.Text = "Maximum Client Entries (Can be changed later)"
        '
        'lblEquipment
        '
        Me.lblEquipment.AutoSize = True
        Me.lblEquipment.Location = New System.Drawing.Point(4, 64)
        Me.lblEquipment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEquipment.Name = "lblEquipment"
        Me.lblEquipment.Size = New System.Drawing.Size(335, 17)
        Me.lblEquipment.TabIndex = 3
        Me.lblEquipment.Text = "Maximum Equipment Entries (Can be changed later)"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(4, 6)
        Me.lblLocation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(102, 17)
        Me.lblLocation.TabIndex = 1
        Me.lblLocation.Text = "Install Location"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(8, 26)
        Me.txtLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(287, 22)
        Me.txtLocation.TabIndex = 4
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(399, 11)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(160, 17)
        Me.lblUsername.TabIndex = 9
        Me.lblUsername.Text = "Administrator Username"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(403, 31)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(332, 22)
        Me.txtUsername.TabIndex = 1
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(399, 69)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(153, 17)
        Me.lblPassword.TabIndex = 11
        Me.lblPassword.Text = "Adminstrator Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(403, 89)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(332, 22)
        Me.txtPassword.TabIndex = 2
        '
        'frmInstaller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 506)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.pnlAdvancedOptions)
        Me.Controls.Add(Me.chkAdvancedOptions)
        Me.Controls.Add(Me.pnlLeft)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmInstaller"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EVCS - Install"
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAdvancedOptions.ResumeLayout(False)
        Me.pnlAdvancedOptions.PerformLayout()
        CType(Me.nudEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCalendar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlLeft As Panel
    Friend WithEvents picTitle As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnInstall As Button
    Friend WithEvents chkAdvancedOptions As CheckBox
    Friend WithEvents pnlAdvancedOptions As Panel
    Friend WithEvents lblLocation As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents lblEquipment As Label
    Friend WithEvents lblClient As Label
    Friend WithEvents lblCalendar As Label
    Friend WithEvents lblHire As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents nudEquipment As NumericUpDown
    Friend WithEvents nudClient As NumericUpDown
    Friend WithEvents nudHire As NumericUpDown
    Friend WithEvents nudCalendar As NumericUpDown
    Friend WithEvents dlgSaveDirectory As FolderBrowserDialog
    Friend WithEvents btnLocateFolder As Button
    Friend WithEvents prgBar As ProgressBar
End Class
