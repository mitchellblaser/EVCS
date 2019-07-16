<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataView
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
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.pnlViewCal = New System.Windows.Forms.Panel()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.lstEventsForDay = New System.Windows.Forms.ListBox()
        Me.lblDateTitle = New System.Windows.Forms.Label()
        Me.calDatePicker = New System.Windows.Forms.MonthCalendar()
        Me.pnlRibbon = New System.Windows.Forms.Panel()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnSearchSort = New System.Windows.Forms.Button()
        Me.btnFile = New System.Windows.Forms.Button()
        Me.pnlFile = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.imgDelete = New System.Windows.Forms.PictureBox()
        Me.imgOpen = New System.Windows.Forms.PictureBox()
        Me.imgNew = New System.Windows.Forms.PictureBox()
        Me.imgSave = New System.Windows.Forms.PictureBox()
        Me.pnlView = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.imgCalendarView = New System.Windows.Forms.PictureBox()
        Me.imgListView = New System.Windows.Forms.PictureBox()
        Me.pnlSearchSort = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.imgAlphabeticalSort = New System.Windows.Forms.PictureBox()
        Me.imgDateSort = New System.Windows.Forms.PictureBox()
        Me.imgSearch = New System.Windows.Forms.PictureBox()
        Me.pnlViewList = New System.Windows.Forms.Panel()
        Me.btnListInfo = New System.Windows.Forms.Button()
        Me.lstListView = New System.Windows.Forms.ListView()
        Me.clmDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmEvent = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlViewCal.SuspendLayout()
        Me.pnlRibbon.SuspendLayout()
        Me.pnlFile.SuspendLayout()
        CType(Me.imgDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlView.SuspendLayout()
        CType(Me.imgCalendarView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearchSort.SuspendLayout()
        CType(Me.imgAlphabeticalSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgDateSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlViewList.SuspendLayout()
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
        Me.Panel1.TabIndex = 3
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
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Gill Sans MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(149, 8)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(108, 27)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "Data Viewer"
        '
        'pnlViewCal
        '
        Me.pnlViewCal.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlViewCal.Controls.Add(Me.btnInfo)
        Me.pnlViewCal.Controls.Add(Me.lstEventsForDay)
        Me.pnlViewCal.Controls.Add(Me.lblDateTitle)
        Me.pnlViewCal.Controls.Add(Me.calDatePicker)
        Me.pnlViewCal.Location = New System.Drawing.Point(0, 123)
        Me.pnlViewCal.Name = "pnlViewCal"
        Me.pnlViewCal.Size = New System.Drawing.Size(680, 316)
        Me.pnlViewCal.TabIndex = 4
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(167, 271)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnInfo.TabIndex = 3
        Me.btnInfo.Text = "More Info"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'lstEventsForDay
        '
        Me.lstEventsForDay.FormattingEnabled = True
        Me.lstEventsForDay.Location = New System.Drawing.Point(254, 30)
        Me.lstEventsForDay.Name = "lstEventsForDay"
        Me.lstEventsForDay.Size = New System.Drawing.Size(400, 264)
        Me.lstEventsForDay.TabIndex = 2
        '
        'lblDateTitle
        '
        Me.lblDateTitle.AutoSize = True
        Me.lblDateTitle.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTitle.ForeColor = System.Drawing.Color.White
        Me.lblDateTitle.Location = New System.Drawing.Point(12, 13)
        Me.lblDateTitle.Name = "lblDateTitle"
        Me.lblDateTitle.Size = New System.Drawing.Size(59, 16)
        Me.lblDateTitle.TabIndex = 1
        Me.lblDateTitle.Text = "Select Date"
        '
        'calDatePicker
        '
        Me.calDatePicker.Location = New System.Drawing.Point(15, 30)
        Me.calDatePicker.MaxSelectionCount = 1
        Me.calDatePicker.Name = "calDatePicker"
        Me.calDatePicker.TabIndex = 0
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
        Me.pnlRibbon.TabIndex = 5
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
        Me.pnlFile.Controls.Add(Me.Label6)
        Me.pnlFile.Controls.Add(Me.Label5)
        Me.pnlFile.Controls.Add(Me.Label4)
        Me.pnlFile.Controls.Add(Me.Label3)
        Me.pnlFile.Controls.Add(Me.imgDelete)
        Me.pnlFile.Controls.Add(Me.imgOpen)
        Me.pnlFile.Controls.Add(Me.imgNew)
        Me.pnlFile.Controls.Add(Me.imgSave)
        Me.pnlFile.Location = New System.Drawing.Point(0, 27)
        Me.pnlFile.Name = "pnlFile"
        Me.pnlFile.Size = New System.Drawing.Size(680, 58)
        Me.pnlFile.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(178, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 12)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Delete"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(124, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 12)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Open"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(69, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 12)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "New"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(11, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 12)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Save"
        '
        'imgDelete
        '
        Me.imgDelete.Image = Global.EventSolutionsCatalogueSystem.My.Resources.Resources.trash_disabled
        Me.imgDelete.Location = New System.Drawing.Point(174, 3)
        Me.imgDelete.Name = "imgDelete"
        Me.imgDelete.Size = New System.Drawing.Size(40, 40)
        Me.imgDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgDelete.TabIndex = 6
        Me.imgDelete.TabStop = False
        '
        'imgOpen
        '
        Me.imgOpen.Image = Global.EventSolutionsCatalogueSystem.My.Resources.Resources.open_disabled
        Me.imgOpen.Location = New System.Drawing.Point(117, 3)
        Me.imgOpen.Name = "imgOpen"
        Me.imgOpen.Size = New System.Drawing.Size(40, 40)
        Me.imgOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgOpen.TabIndex = 2
        Me.imgOpen.TabStop = False
        '
        'imgNew
        '
        Me.imgNew.Image = Global.EventSolutionsCatalogueSystem.My.Resources.Resources.new_disabled
        Me.imgNew.Location = New System.Drawing.Point(61, 3)
        Me.imgNew.Name = "imgNew"
        Me.imgNew.Size = New System.Drawing.Size(40, 40)
        Me.imgNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgNew.TabIndex = 1
        Me.imgNew.TabStop = False
        '
        'imgSave
        '
        Me.imgSave.Image = Global.EventSolutionsCatalogueSystem.My.Resources.Resources.save_disabled
        Me.imgSave.Location = New System.Drawing.Point(5, 3)
        Me.imgSave.Name = "imgSave"
        Me.imgSave.Size = New System.Drawing.Size(40, 40)
        Me.imgSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgSave.TabIndex = 0
        Me.imgSave.TabStop = False
        '
        'pnlView
        '
        Me.pnlView.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pnlView.Controls.Add(Me.Label8)
        Me.pnlView.Controls.Add(Me.Label7)
        Me.pnlView.Controls.Add(Me.imgCalendarView)
        Me.pnlView.Controls.Add(Me.imgListView)
        Me.pnlView.Location = New System.Drawing.Point(0, 26)
        Me.pnlView.Name = "pnlView"
        Me.pnlView.Size = New System.Drawing.Size(680, 58)
        Me.pnlView.TabIndex = 8
        Me.pnlView.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(61, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 12)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Calendar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(15, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 12)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "List"
        '
        'imgCalendarView
        '
        Me.imgCalendarView.Image = Global.EventSolutionsCatalogueSystem.My.Resources.Resources.calendar
        Me.imgCalendarView.Location = New System.Drawing.Point(62, 3)
        Me.imgCalendarView.Name = "imgCalendarView"
        Me.imgCalendarView.Size = New System.Drawing.Size(40, 40)
        Me.imgCalendarView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgCalendarView.TabIndex = 1
        Me.imgCalendarView.TabStop = False
        '
        'imgListView
        '
        Me.imgListView.Image = Global.EventSolutionsCatalogueSystem.My.Resources.Resources.list
        Me.imgListView.Location = New System.Drawing.Point(5, 3)
        Me.imgListView.Name = "imgListView"
        Me.imgListView.Size = New System.Drawing.Size(40, 40)
        Me.imgListView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgListView.TabIndex = 0
        Me.imgListView.TabStop = False
        '
        'pnlSearchSort
        '
        Me.pnlSearchSort.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pnlSearchSort.Controls.Add(Me.Label2)
        Me.pnlSearchSort.Controls.Add(Me.Label1)
        Me.pnlSearchSort.Controls.Add(Me.lblSearch)
        Me.pnlSearchSort.Controls.Add(Me.imgAlphabeticalSort)
        Me.pnlSearchSort.Controls.Add(Me.imgDateSort)
        Me.pnlSearchSort.Controls.Add(Me.imgSearch)
        Me.pnlSearchSort.Location = New System.Drawing.Point(1, 26)
        Me.pnlSearchSort.Name = "pnlSearchSort"
        Me.pnlSearchSort.Size = New System.Drawing.Size(679, 58)
        Me.pnlSearchSort.TabIndex = 7
        Me.pnlSearchSort.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(109, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Alphabetical"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(49, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Most Recent"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.lblSearch.ForeColor = System.Drawing.Color.Black
        Me.lblSearch.Location = New System.Drawing.Point(8, 43)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(34, 12)
        Me.lblSearch.TabIndex = 6
        Me.lblSearch.Text = "Search"
        '
        'imgAlphabeticalSort
        '
        Me.imgAlphabeticalSort.Image = Global.EventSolutionsCatalogueSystem.My.Resources.Resources.alphabetical
        Me.imgAlphabeticalSort.Location = New System.Drawing.Point(117, 3)
        Me.imgAlphabeticalSort.Name = "imgAlphabeticalSort"
        Me.imgAlphabeticalSort.Size = New System.Drawing.Size(40, 40)
        Me.imgAlphabeticalSort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgAlphabeticalSort.TabIndex = 2
        Me.imgAlphabeticalSort.TabStop = False
        '
        'imgDateSort
        '
        Me.imgDateSort.Image = Global.EventSolutionsCatalogueSystem.My.Resources.Resources.datetime
        Me.imgDateSort.Location = New System.Drawing.Point(61, 3)
        Me.imgDateSort.Name = "imgDateSort"
        Me.imgDateSort.Size = New System.Drawing.Size(40, 40)
        Me.imgDateSort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgDateSort.TabIndex = 1
        Me.imgDateSort.TabStop = False
        '
        'imgSearch
        '
        Me.imgSearch.Image = Global.EventSolutionsCatalogueSystem.My.Resources.Resources.search
        Me.imgSearch.Location = New System.Drawing.Point(5, 3)
        Me.imgSearch.Name = "imgSearch"
        Me.imgSearch.Size = New System.Drawing.Size(40, 40)
        Me.imgSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgSearch.TabIndex = 0
        Me.imgSearch.TabStop = False
        '
        'pnlViewList
        '
        Me.pnlViewList.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlViewList.Controls.Add(Me.btnListInfo)
        Me.pnlViewList.Controls.Add(Me.lstListView)
        Me.pnlViewList.Location = New System.Drawing.Point(0, 123)
        Me.pnlViewList.Name = "pnlViewList"
        Me.pnlViewList.Size = New System.Drawing.Size(680, 316)
        Me.pnlViewList.TabIndex = 5
        Me.pnlViewList.Visible = False
        '
        'btnListInfo
        '
        Me.btnListInfo.Location = New System.Drawing.Point(593, 286)
        Me.btnListInfo.Name = "btnListInfo"
        Me.btnListInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnListInfo.TabIndex = 1
        Me.btnListInfo.Text = "More Info"
        Me.btnListInfo.UseVisualStyleBackColor = True
        '
        'lstListView
        '
        Me.lstListView.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lstListView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmDate, Me.clmEvent})
        Me.lstListView.ForeColor = System.Drawing.Color.White
        Me.lstListView.FullRowSelect = True
        Me.lstListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstListView.Location = New System.Drawing.Point(12, 14)
        Me.lstListView.MultiSelect = False
        Me.lstListView.Name = "lstListView"
        Me.lstListView.Size = New System.Drawing.Size(656, 266)
        Me.lstListView.TabIndex = 0
        Me.lstListView.UseCompatibleStateImageBehavior = False
        Me.lstListView.View = System.Windows.Forms.View.Details
        '
        'clmDate
        '
        Me.clmDate.Text = "Date"
        Me.clmDate.Width = 120
        '
        'clmEvent
        '
        Me.clmEvent.Text = "Event"
        Me.clmEvent.Width = 532
        '
        'frmDataView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 438)
        Me.Controls.Add(Me.pnlRibbon)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlViewCal)
        Me.Controls.Add(Me.pnlViewList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDataView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDataView"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlViewCal.ResumeLayout(False)
        Me.pnlViewCal.PerformLayout()
        Me.pnlRibbon.ResumeLayout(False)
        Me.pnlFile.ResumeLayout(False)
        Me.pnlFile.PerformLayout()
        CType(Me.imgDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgOpen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlView.ResumeLayout(False)
        Me.pnlView.PerformLayout()
        CType(Me.imgCalendarView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearchSort.ResumeLayout(False)
        Me.pnlSearchSort.PerformLayout()
        CType(Me.imgAlphabeticalSort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgDateSort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlViewList.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents picClose As PictureBox
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblMenu As Label
    Friend WithEvents pnlViewCal As Panel
    Friend WithEvents pnlRibbon As Panel
    Friend WithEvents pnlView As Panel
    Friend WithEvents imgCalendarView As PictureBox
    Friend WithEvents imgListView As PictureBox
    Friend WithEvents pnlSearchSort As Panel
    Friend WithEvents imgAlphabeticalSort As PictureBox
    Friend WithEvents imgDateSort As PictureBox
    Friend WithEvents imgSearch As PictureBox
    Friend WithEvents pnlFile As Panel
    Friend WithEvents imgOpen As PictureBox
    Friend WithEvents imgNew As PictureBox
    Friend WithEvents imgSave As PictureBox
    Friend WithEvents btnView As Button
    Friend WithEvents btnSearchSort As Button
    Friend WithEvents btnFile As Button
    Friend WithEvents imgDelete As PictureBox
    Friend WithEvents pnlViewList As Panel
    Friend WithEvents calDatePicker As MonthCalendar
    Friend WithEvents lblDateTitle As Label
    Friend WithEvents lstEventsForDay As ListBox
    Friend WithEvents lstListView As ListView
    Friend WithEvents clmDate As ColumnHeader
    Friend WithEvents clmEvent As ColumnHeader
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnListInfo As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSearch As Label
End Class
