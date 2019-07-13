<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataEntry
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.pnlRibbon = New System.Windows.Forms.Panel()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnSearchSort = New System.Windows.Forms.Button()
        Me.btnFile = New System.Windows.Forms.Button()
        Me.pnlFile = New System.Windows.Forms.Panel()
        Me.pnlView = New System.Windows.Forms.Panel()
        Me.pnlSearchSort = New System.Windows.Forms.Panel()
        Me.pnlClient = New System.Windows.Forms.Panel()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtNameLast = New System.Windows.Forms.TextBox()
        Me.lblNameLast = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.pnlEquipment = New System.Windows.Forms.Panel()
        Me.numPricePerDay = New System.Windows.Forms.NumericUpDown()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.numQuantity = New System.Windows.Forms.NumericUpDown()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtManufacturer = New System.Windows.Forms.TextBox()
        Me.lblManufacturer = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.pnlHire = New System.Windows.Forms.Panel()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.lstQuantity = New System.Windows.Forms.ListBox()
        Me.lblQuantityList = New System.Windows.Forms.Label()
        Me.lstPrice = New System.Windows.Forms.ListBox()
        Me.lstEquipment = New System.Windows.Forms.ListBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPriceList = New System.Windows.Forms.Label()
        Me.lblEquipmentList = New System.Windows.Forms.Label()
        Me.dtpDateIn = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateOut = New System.Windows.Forms.DateTimePicker()
        Me.lblDateIn = New System.Windows.Forms.Label()
        Me.lblDateOut = New System.Windows.Forms.Label()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.cmbEquipment = New System.Windows.Forms.ComboBox()
        Me.lblEquipment = New System.Windows.Forms.Label()
        Me.cmbClient = New System.Windows.Forms.ComboBox()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.lblRecord = New System.Windows.Forms.Label()
        Me.dlgOpenRecord = New System.Windows.Forms.OpenFileDialog()
        Me.imgAlphabeticalSort = New System.Windows.Forms.PictureBox()
        Me.imgDateSort = New System.Windows.Forms.PictureBox()
        Me.imgSearch = New System.Windows.Forms.PictureBox()
        Me.imgDelete = New System.Windows.Forms.PictureBox()
        Me.imgOpen = New System.Windows.Forms.PictureBox()
        Me.imgNew = New System.Windows.Forms.PictureBox()
        Me.imgSave = New System.Windows.Forms.PictureBox()
        Me.imgCalendarView = New System.Windows.Forms.PictureBox()
        Me.imgListView = New System.Windows.Forms.PictureBox()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.pnlRibbon.SuspendLayout()
        Me.pnlFile.SuspendLayout()
        Me.pnlView.SuspendLayout()
        Me.pnlSearchSort.SuspendLayout()
        Me.pnlClient.SuspendLayout()
        Me.pnlEquipment.SuspendLayout()
        CType(Me.numPricePerDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHire.SuspendLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAlphabeticalSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgDateSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCalendarView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgListView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Panel1.Controls.Add(Me.picClose)
        Me.Panel1.Controls.Add(Me.picLogo)
        Me.Panel1.Controls.Add(Me.lblMenu)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 40)
        Me.Panel1.TabIndex = 2
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(149, 8)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(95, 27)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "Data Entry"
        '
        'pnlRibbon
        '
        Me.pnlRibbon.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.pnlRibbon.Controls.Add(Me.btnView)
        Me.pnlRibbon.Controls.Add(Me.btnSearchSort)
        Me.pnlRibbon.Controls.Add(Me.btnFile)
        Me.pnlRibbon.Controls.Add(Me.pnlFile)
        Me.pnlRibbon.Controls.Add(Me.pnlView)
        Me.pnlRibbon.Controls.Add(Me.pnlSearchSort)
        Me.pnlRibbon.Location = New System.Drawing.Point(0, 39)
        Me.pnlRibbon.Name = "pnlRibbon"
        Me.pnlRibbon.Size = New System.Drawing.Size(680, 84)
        Me.pnlRibbon.TabIndex = 3
        '
        'btnView
        '
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(154, 0)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(78, 27)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnSearchSort
        '
        Me.btnSearchSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchSort.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchSort.Location = New System.Drawing.Point(77, 0)
        Me.btnSearchSort.Name = "btnSearchSort"
        Me.btnSearchSort.Size = New System.Drawing.Size(78, 27)
        Me.btnSearchSort.TabIndex = 1
        Me.btnSearchSort.Text = "Search/Sort"
        Me.btnSearchSort.UseVisualStyleBackColor = True
        '
        'btnFile
        '
        Me.btnFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFile.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFile.Location = New System.Drawing.Point(0, 0)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(78, 27)
        Me.btnFile.TabIndex = 0
        Me.btnFile.Text = "File"
        Me.btnFile.UseVisualStyleBackColor = False
        '
        'pnlFile
        '
        Me.pnlFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pnlFile.Controls.Add(Me.imgDelete)
        Me.pnlFile.Controls.Add(Me.imgOpen)
        Me.pnlFile.Controls.Add(Me.imgNew)
        Me.pnlFile.Controls.Add(Me.imgSave)
        Me.pnlFile.Location = New System.Drawing.Point(0, 27)
        Me.pnlFile.Name = "pnlFile"
        Me.pnlFile.Size = New System.Drawing.Size(680, 58)
        Me.pnlFile.TabIndex = 6
        '
        'pnlView
        '
        Me.pnlView.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pnlView.Controls.Add(Me.imgCalendarView)
        Me.pnlView.Controls.Add(Me.imgListView)
        Me.pnlView.Location = New System.Drawing.Point(0, 26)
        Me.pnlView.Name = "pnlView"
        Me.pnlView.Size = New System.Drawing.Size(680, 58)
        Me.pnlView.TabIndex = 8
        Me.pnlView.Visible = False
        '
        'pnlSearchSort
        '
        Me.pnlSearchSort.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pnlSearchSort.Controls.Add(Me.imgAlphabeticalSort)
        Me.pnlSearchSort.Controls.Add(Me.imgDateSort)
        Me.pnlSearchSort.Controls.Add(Me.imgSearch)
        Me.pnlSearchSort.Location = New System.Drawing.Point(1, 26)
        Me.pnlSearchSort.Name = "pnlSearchSort"
        Me.pnlSearchSort.Size = New System.Drawing.Size(679, 58)
        Me.pnlSearchSort.TabIndex = 7
        Me.pnlSearchSort.Visible = False
        '
        'pnlClient
        '
        Me.pnlClient.Controls.Add(Me.txtAddress)
        Me.pnlClient.Controls.Add(Me.lblAddress)
        Me.pnlClient.Controls.Add(Me.txtEmail)
        Me.pnlClient.Controls.Add(Me.lblEmail)
        Me.pnlClient.Controls.Add(Me.txtNameLast)
        Me.pnlClient.Controls.Add(Me.lblNameLast)
        Me.pnlClient.Controls.Add(Me.txtPhone)
        Me.pnlClient.Controls.Add(Me.lblPhone)
        Me.pnlClient.Controls.Add(Me.txtFirstName)
        Me.pnlClient.Controls.Add(Me.lblFirstName)
        Me.pnlClient.Location = New System.Drawing.Point(0, 123)
        Me.pnlClient.Name = "pnlClient"
        Me.pnlClient.Size = New System.Drawing.Size(679, 375)
        Me.pnlClient.TabIndex = 4
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(14, 118)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(373, 20)
        Me.txtAddress.TabIndex = 9
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.White
        Me.lblAddress.Location = New System.Drawing.Point(11, 102)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(74, 16)
        Me.lblAddress.TabIndex = 8
        Me.lblAddress.Text = "Client Address"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(207, 73)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(180, 20)
        Me.txtEmail.TabIndex = 7
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(204, 57)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(61, 16)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Client Email"
        '
        'txtNameLast
        '
        Me.txtNameLast.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameLast.Location = New System.Drawing.Point(207, 28)
        Me.txtNameLast.Name = "txtNameLast"
        Me.txtNameLast.Size = New System.Drawing.Size(180, 20)
        Me.txtNameLast.TabIndex = 3
        '
        'lblNameLast
        '
        Me.lblNameLast.AutoSize = True
        Me.lblNameLast.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameLast.ForeColor = System.Drawing.Color.White
        Me.lblNameLast.Location = New System.Drawing.Point(204, 12)
        Me.lblNameLast.Name = "lblNameLast"
        Me.lblNameLast.Size = New System.Drawing.Size(94, 16)
        Me.lblNameLast.TabIndex = 4
        Me.lblNameLast.Text = "Client Name (Last)"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(14, 73)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(180, 20)
        Me.txtPhone.TabIndex = 5
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.White
        Me.lblPhone.Location = New System.Drawing.Point(11, 57)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(67, 16)
        Me.lblPhone.TabIndex = 2
        Me.lblPhone.Text = "Client Phone"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(14, 28)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(180, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.White
        Me.lblFirstName.Location = New System.Drawing.Point(11, 12)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(95, 16)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "Client Name (First)"
        '
        'pnlEquipment
        '
        Me.pnlEquipment.Controls.Add(Me.numPricePerDay)
        Me.pnlEquipment.Controls.Add(Me.lblPrice)
        Me.pnlEquipment.Controls.Add(Me.numQuantity)
        Me.pnlEquipment.Controls.Add(Me.lblQuantity)
        Me.pnlEquipment.Controls.Add(Me.txtManufacturer)
        Me.pnlEquipment.Controls.Add(Me.lblManufacturer)
        Me.pnlEquipment.Controls.Add(Me.txtName)
        Me.pnlEquipment.Controls.Add(Me.lblName)
        Me.pnlEquipment.Location = New System.Drawing.Point(0, 123)
        Me.pnlEquipment.Name = "pnlEquipment"
        Me.pnlEquipment.Size = New System.Drawing.Size(679, 375)
        Me.pnlEquipment.TabIndex = 5
        '
        'numPricePerDay
        '
        Me.numPricePerDay.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPricePerDay.Location = New System.Drawing.Point(207, 74)
        Me.numPricePerDay.Name = "numPricePerDay"
        Me.numPricePerDay.Size = New System.Drawing.Size(180, 20)
        Me.numPricePerDay.TabIndex = 9
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.White
        Me.lblPrice.Location = New System.Drawing.Point(205, 57)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(86, 16)
        Me.lblPrice.TabIndex = 8
        Me.lblPrice.Text = "Price Per Day ($)"
        '
        'numQuantity
        '
        Me.numQuantity.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numQuantity.Location = New System.Drawing.Point(14, 74)
        Me.numQuantity.Name = "numQuantity"
        Me.numQuantity.Size = New System.Drawing.Size(180, 20)
        Me.numQuantity.TabIndex = 7
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.Color.White
        Me.lblQuantity.Location = New System.Drawing.Point(11, 57)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(91, 16)
        Me.lblQuantity.TabIndex = 6
        Me.lblQuantity.Text = "Quantity Available"
        '
        'txtManufacturer
        '
        Me.txtManufacturer.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManufacturer.Location = New System.Drawing.Point(207, 28)
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.Size = New System.Drawing.Size(180, 20)
        Me.txtManufacturer.TabIndex = 5
        '
        'lblManufacturer
        '
        Me.lblManufacturer.AutoSize = True
        Me.lblManufacturer.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManufacturer.ForeColor = System.Drawing.Color.White
        Me.lblManufacturer.Location = New System.Drawing.Point(204, 12)
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Size = New System.Drawing.Size(70, 16)
        Me.lblManufacturer.TabIndex = 4
        Me.lblManufacturer.Text = "Manufacturer"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(14, 28)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(180, 20)
        Me.txtName.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(11, 12)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(87, 16)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Equipment Name"
        '
        'pnlHire
        '
        Me.pnlHire.Controls.Add(Me.nudQuantity)
        Me.pnlHire.Controls.Add(Me.lstQuantity)
        Me.pnlHire.Controls.Add(Me.lblQuantityList)
        Me.pnlHire.Controls.Add(Me.lstPrice)
        Me.pnlHire.Controls.Add(Me.lstEquipment)
        Me.pnlHire.Controls.Add(Me.lblTotal)
        Me.pnlHire.Controls.Add(Me.lblPriceList)
        Me.pnlHire.Controls.Add(Me.lblEquipmentList)
        Me.pnlHire.Controls.Add(Me.dtpDateIn)
        Me.pnlHire.Controls.Add(Me.dtpDateOut)
        Me.pnlHire.Controls.Add(Me.lblDateIn)
        Me.pnlHire.Controls.Add(Me.lblDateOut)
        Me.pnlHire.Controls.Add(Me.btnAddItem)
        Me.pnlHire.Controls.Add(Me.cmbEquipment)
        Me.pnlHire.Controls.Add(Me.lblEquipment)
        Me.pnlHire.Controls.Add(Me.cmbClient)
        Me.pnlHire.Controls.Add(Me.lblClient)
        Me.pnlHire.Controls.Add(Me.lblRecord)
        Me.pnlHire.Location = New System.Drawing.Point(0, 123)
        Me.pnlHire.Name = "pnlHire"
        Me.pnlHire.Size = New System.Drawing.Size(679, 375)
        Me.pnlHire.TabIndex = 10
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(15, 142)
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(73, 20)
        Me.nudQuantity.TabIndex = 17
        '
        'lstQuantity
        '
        Me.lstQuantity.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstQuantity.FormattingEnabled = True
        Me.lstQuantity.ItemHeight = 16
        Me.lstQuantity.Location = New System.Drawing.Point(413, 57)
        Me.lstQuantity.Name = "lstQuantity"
        Me.lstQuantity.Size = New System.Drawing.Size(77, 180)
        Me.lstQuantity.TabIndex = 16
        '
        'lblQuantityList
        '
        Me.lblQuantityList.AutoSize = True
        Me.lblQuantityList.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantityList.ForeColor = System.Drawing.Color.White
        Me.lblQuantityList.Location = New System.Drawing.Point(410, 44)
        Me.lblQuantityList.Name = "lblQuantityList"
        Me.lblQuantityList.Size = New System.Drawing.Size(49, 16)
        Me.lblQuantityList.TabIndex = 15
        Me.lblQuantityList.Text = "Quantity"
        '
        'lstPrice
        '
        Me.lstPrice.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPrice.FormattingEnabled = True
        Me.lstPrice.ItemHeight = 16
        Me.lstPrice.Location = New System.Drawing.Point(499, 57)
        Me.lstPrice.Name = "lstPrice"
        Me.lstPrice.Size = New System.Drawing.Size(126, 180)
        Me.lstPrice.TabIndex = 14
        '
        'lstEquipment
        '
        Me.lstEquipment.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstEquipment.FormattingEnabled = True
        Me.lstEquipment.ItemHeight = 16
        Me.lstEquipment.Location = New System.Drawing.Point(230, 57)
        Me.lstEquipment.Name = "lstEquipment"
        Me.lstEquipment.Size = New System.Drawing.Size(174, 180)
        Me.lstEquipment.TabIndex = 13
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(227, 254)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(55, 16)
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.Text = "Total: $00"
        '
        'lblPriceList
        '
        Me.lblPriceList.AutoSize = True
        Me.lblPriceList.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceList.ForeColor = System.Drawing.Color.White
        Me.lblPriceList.Location = New System.Drawing.Point(496, 44)
        Me.lblPriceList.Name = "lblPriceList"
        Me.lblPriceList.Size = New System.Drawing.Size(77, 16)
        Me.lblPriceList.TabIndex = 11
        Me.lblPriceList.Text = "Price (Per Day)"
        '
        'lblEquipmentList
        '
        Me.lblEquipmentList.AutoSize = True
        Me.lblEquipmentList.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquipmentList.ForeColor = System.Drawing.Color.White
        Me.lblEquipmentList.Location = New System.Drawing.Point(227, 44)
        Me.lblEquipmentList.Name = "lblEquipmentList"
        Me.lblEquipmentList.Size = New System.Drawing.Size(57, 16)
        Me.lblEquipmentList.TabIndex = 10
        Me.lblEquipmentList.Text = "Equipment"
        '
        'dtpDateIn
        '
        Me.dtpDateIn.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateIn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateIn.Location = New System.Drawing.Point(14, 247)
        Me.dtpDateIn.Name = "dtpDateIn"
        Me.dtpDateIn.Size = New System.Drawing.Size(154, 20)
        Me.dtpDateIn.TabIndex = 9
        '
        'dtpDateOut
        '
        Me.dtpDateOut.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateOut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateOut.Location = New System.Drawing.Point(14, 195)
        Me.dtpDateOut.Name = "dtpDateOut"
        Me.dtpDateOut.Size = New System.Drawing.Size(154, 20)
        Me.dtpDateOut.TabIndex = 8
        '
        'lblDateIn
        '
        Me.lblDateIn.AutoSize = True
        Me.lblDateIn.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateIn.ForeColor = System.Drawing.Color.White
        Me.lblDateIn.Location = New System.Drawing.Point(12, 231)
        Me.lblDateIn.Name = "lblDateIn"
        Me.lblDateIn.Size = New System.Drawing.Size(42, 16)
        Me.lblDateIn.TabIndex = 7
        Me.lblDateIn.Text = "Date In"
        '
        'lblDateOut
        '
        Me.lblDateOut.AutoSize = True
        Me.lblDateOut.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateOut.ForeColor = System.Drawing.Color.White
        Me.lblDateOut.Location = New System.Drawing.Point(12, 179)
        Me.lblDateOut.Name = "lblDateOut"
        Me.lblDateOut.Size = New System.Drawing.Size(52, 16)
        Me.lblDateOut.TabIndex = 6
        Me.lblDateOut.Text = "Date Out"
        '
        'btnAddItem
        '
        Me.btnAddItem.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(93, 140)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(75, 23)
        Me.btnAddItem.TabIndex = 5
        Me.btnAddItem.Text = "Add"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'cmbEquipment
        '
        Me.cmbEquipment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbEquipment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEquipment.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEquipment.FormattingEnabled = True
        Me.cmbEquipment.Location = New System.Drawing.Point(14, 113)
        Me.cmbEquipment.Name = "cmbEquipment"
        Me.cmbEquipment.Size = New System.Drawing.Size(154, 24)
        Me.cmbEquipment.TabIndex = 4
        '
        'lblEquipment
        '
        Me.lblEquipment.AutoSize = True
        Me.lblEquipment.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquipment.ForeColor = System.Drawing.Color.White
        Me.lblEquipment.Location = New System.Drawing.Point(12, 97)
        Me.lblEquipment.Name = "lblEquipment"
        Me.lblEquipment.Size = New System.Drawing.Size(57, 16)
        Me.lblEquipment.TabIndex = 3
        Me.lblEquipment.Text = "Equipment"
        '
        'cmbClient
        '
        Me.cmbClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbClient.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClient.FormattingEnabled = True
        Me.cmbClient.Location = New System.Drawing.Point(14, 60)
        Me.cmbClient.Name = "cmbClient"
        Me.cmbClient.Size = New System.Drawing.Size(154, 24)
        Me.cmbClient.TabIndex = 2
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClient.ForeColor = System.Drawing.Color.White
        Me.lblClient.Location = New System.Drawing.Point(12, 44)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(35, 16)
        Me.lblClient.TabIndex = 1
        Me.lblClient.Text = "Client"
        '
        'lblRecord
        '
        Me.lblRecord.AutoSize = True
        Me.lblRecord.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecord.ForeColor = System.Drawing.Color.White
        Me.lblRecord.Location = New System.Drawing.Point(10, 12)
        Me.lblRecord.Name = "lblRecord"
        Me.lblRecord.Size = New System.Drawing.Size(77, 23)
        Me.lblRecord.TabIndex = 0
        Me.lblRecord.Text = "New Hire"
        '
        'imgAlphabeticalSort
        '
        Me.imgAlphabeticalSort.Image = Global.EventSolutionsCatalogueSystem.My.Resources.Resources.alphabetical_disabled
        Me.imgAlphabeticalSort.Location = New System.Drawing.Point(117, 3)
        Me.imgAlphabeticalSort.Name = "imgAlphabeticalSort"
        Me.imgAlphabeticalSort.Size = New System.Drawing.Size(50, 50)
        Me.imgAlphabeticalSort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgAlphabeticalSort.TabIndex = 2
        Me.imgAlphabeticalSort.TabStop = False
        '
        'imgDateSort
        '
        Me.imgDateSort.Image = Global.EventSolutionsCatalogueSystem.My.Resources.Resources.datetime_disabled
        Me.imgDateSort.Location = New System.Drawing.Point(61, 3)
        Me.imgDateSort.Name = "imgDateSort"
        Me.imgDateSort.Size = New System.Drawing.Size(50, 50)
        Me.imgDateSort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgDateSort.TabIndex = 1
        Me.imgDateSort.TabStop = False
        '
        'imgSearch
        '
        Me.imgSearch.Image = Global.EventSolutionsCatalogueSystem.My.Resources.Resources.search_disabled
        Me.imgSearch.Location = New System.Drawing.Point(5, 3)
        Me.imgSearch.Name = "imgSearch"
        Me.imgSearch.Size = New System.Drawing.Size(50, 50)
        Me.imgSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgSearch.TabIndex = 0
        Me.imgSearch.TabStop = False
        '
        'imgDelete
        '
        Me.imgDelete.Image = Global.EventSolutionsCatalogueSystem.My.Resources.Resources.trash
        Me.imgDelete.Location = New System.Drawing.Point(173, 3)
        Me.imgDelete.Name = "imgDelete"
        Me.imgDelete.Size = New System.Drawing.Size(50, 50)
        Me.imgDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgDelete.TabIndex = 3
        Me.imgDelete.TabStop = False
        '
        'imgOpen
        '
        Me.imgOpen.Image = Global.EventSolutionsCatalogueSystem.My.Resources.Resources.open
        Me.imgOpen.Location = New System.Drawing.Point(117, 3)
        Me.imgOpen.Name = "imgOpen"
        Me.imgOpen.Size = New System.Drawing.Size(50, 50)
        Me.imgOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgOpen.TabIndex = 2
        Me.imgOpen.TabStop = False
        '
        'imgNew
        '
        Me.imgNew.Image = Global.EventSolutionsCatalogueSystem.My.Resources.Resources._new
        Me.imgNew.Location = New System.Drawing.Point(61, 3)
        Me.imgNew.Name = "imgNew"
        Me.imgNew.Size = New System.Drawing.Size(50, 50)
        Me.imgNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgNew.TabIndex = 1
        Me.imgNew.TabStop = False
        '
        'imgSave
        '
        Me.imgSave.Image = Global.EventSolutionsCatalogueSystem.My.Resources.Resources.save
        Me.imgSave.Location = New System.Drawing.Point(5, 3)
        Me.imgSave.Name = "imgSave"
        Me.imgSave.Size = New System.Drawing.Size(50, 50)
        Me.imgSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgSave.TabIndex = 0
        Me.imgSave.TabStop = False
        '
        'imgCalendarView
        '
        Me.imgCalendarView.Image = Global.EventSolutionsCatalogueSystem.My.Resources.Resources.calendar_disabled
        Me.imgCalendarView.Location = New System.Drawing.Point(62, 3)
        Me.imgCalendarView.Name = "imgCalendarView"
        Me.imgCalendarView.Size = New System.Drawing.Size(50, 50)
        Me.imgCalendarView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgCalendarView.TabIndex = 1
        Me.imgCalendarView.TabStop = False
        '
        'imgListView
        '
        Me.imgListView.Image = Global.EventSolutionsCatalogueSystem.My.Resources.Resources.list_disabled
        Me.imgListView.Location = New System.Drawing.Point(5, 3)
        Me.imgListView.Name = "imgListView"
        Me.imgListView.Size = New System.Drawing.Size(50, 50)
        Me.imgListView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgListView.TabIndex = 0
        Me.imgListView.TabStop = False
        '
        'picClose
        '
        Me.picClose.Image = Global.EventSolutionsCatalogueSystem.My.Resources.Resources.CloseButton
        Me.picClose.Location = New System.Drawing.Point(630, -2)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(55, 44)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picClose.TabIndex = 2
        Me.picClose.TabStop = False
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
        'frmDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(679, 499)
        Me.Controls.Add(Me.pnlRibbon)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlHire)
        Me.Controls.Add(Me.pnlEquipment)
        Me.Controls.Add(Me.pnlClient)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDataEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDataEntry"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlRibbon.ResumeLayout(False)
        Me.pnlFile.ResumeLayout(False)
        Me.pnlView.ResumeLayout(False)
        Me.pnlSearchSort.ResumeLayout(False)
        Me.pnlClient.ResumeLayout(False)
        Me.pnlClient.PerformLayout()
        Me.pnlEquipment.ResumeLayout(False)
        Me.pnlEquipment.PerformLayout()
        CType(Me.numPricePerDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHire.ResumeLayout(False)
        Me.pnlHire.PerformLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAlphabeticalSort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgDateSort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgOpen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCalendarView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgListView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblMenu As Label
    Friend WithEvents pnlRibbon As Panel
    Friend WithEvents btnView As Button
    Friend WithEvents btnSearchSort As Button
    Friend WithEvents btnFile As Button
    Friend WithEvents pnlFile As Panel
    Friend WithEvents imgSave As PictureBox
    Friend WithEvents imgOpen As PictureBox
    Friend WithEvents imgNew As PictureBox
    Friend WithEvents pnlSearchSort As Panel
    Friend WithEvents imgSearch As PictureBox
    Friend WithEvents imgAlphabeticalSort As PictureBox
    Friend WithEvents imgDateSort As PictureBox
    Friend WithEvents pnlView As Panel
    Friend WithEvents imgListView As PictureBox
    Friend WithEvents imgCalendarView As PictureBox
    Friend WithEvents pnlClient As Panel
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtNameLast As TextBox
    Friend WithEvents lblNameLast As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents pnlEquipment As Panel
    Friend WithEvents txtManufacturer As TextBox
    Friend WithEvents lblManufacturer As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents numQuantity As NumericUpDown
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents pnlHire As Panel
    Friend WithEvents lblRecord As Label
    Friend WithEvents btnAddItem As Button
    Friend WithEvents cmbEquipment As ComboBox
    Friend WithEvents lblEquipment As Label
    Friend WithEvents cmbClient As ComboBox
    Friend WithEvents lblDateOut As Label
    Friend WithEvents lblDateIn As Label
    Friend WithEvents dtpDateOut As DateTimePicker
    Friend WithEvents dtpDateIn As DateTimePicker
    Friend WithEvents lblEquipmentList As Label
    Friend WithEvents lblPriceList As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lstPrice As ListBox
    Friend WithEvents lstEquipment As ListBox
    Friend WithEvents lstQuantity As ListBox
    Friend WithEvents lblQuantityList As Label
    Friend WithEvents lblClient As Label
    Friend WithEvents picClose As PictureBox
    Friend WithEvents nudQuantity As NumericUpDown
    Friend WithEvents imgDelete As PictureBox
    Friend WithEvents numPricePerDay As NumericUpDown
    Friend WithEvents dlgOpenRecord As OpenFileDialog
End Class
