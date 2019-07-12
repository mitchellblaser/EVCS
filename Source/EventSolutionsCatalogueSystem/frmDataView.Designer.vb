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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlRibbon = New System.Windows.Forms.Panel()
        Me.pnlView = New System.Windows.Forms.Panel()
        Me.imgCalendarView = New System.Windows.Forms.PictureBox()
        Me.imgListView = New System.Windows.Forms.PictureBox()
        Me.pnlSearchSort = New System.Windows.Forms.Panel()
        Me.imgAlphabeticalSort = New System.Windows.Forms.PictureBox()
        Me.imgDateSort = New System.Windows.Forms.PictureBox()
        Me.imgSearch = New System.Windows.Forms.PictureBox()
        Me.pnlFile = New System.Windows.Forms.Panel()
        Me.imgOpen = New System.Windows.Forms.PictureBox()
        Me.imgNew = New System.Windows.Forms.PictureBox()
        Me.imgSave = New System.Windows.Forms.PictureBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnSearchSort = New System.Windows.Forms.Button()
        Me.btnFile = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRibbon.SuspendLayout()
        Me.pnlView.SuspendLayout()
        CType(Me.imgCalendarView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearchSort.SuspendLayout()
        CType(Me.imgAlphabeticalSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgDateSort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFile.SuspendLayout()
        CType(Me.imgOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSave, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 123)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(680, 316)
        Me.Panel2.TabIndex = 4
        '
        'pnlRibbon
        '
        Me.pnlRibbon.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.pnlRibbon.Controls.Add(Me.pnlView)
        Me.pnlRibbon.Controls.Add(Me.pnlSearchSort)
        Me.pnlRibbon.Controls.Add(Me.pnlFile)
        Me.pnlRibbon.Controls.Add(Me.btnView)
        Me.pnlRibbon.Controls.Add(Me.btnSearchSort)
        Me.pnlRibbon.Controls.Add(Me.btnFile)
        Me.pnlRibbon.Location = New System.Drawing.Point(0, 39)
        Me.pnlRibbon.Name = "pnlRibbon"
        Me.pnlRibbon.Size = New System.Drawing.Size(680, 84)
        Me.pnlRibbon.TabIndex = 5
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
        Me.imgSearch.Image = Global.EventSolutionsCatalogueSystem.My.Resources.Resources.search
        Me.imgSearch.Location = New System.Drawing.Point(5, 3)
        Me.imgSearch.Name = "imgSearch"
        Me.imgSearch.Size = New System.Drawing.Size(50, 50)
        Me.imgSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgSearch.TabIndex = 0
        Me.imgSearch.TabStop = False
        '
        'pnlFile
        '
        Me.pnlFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pnlFile.Controls.Add(Me.imgOpen)
        Me.pnlFile.Controls.Add(Me.imgNew)
        Me.pnlFile.Controls.Add(Me.imgSave)
        Me.pnlFile.Location = New System.Drawing.Point(0, 27)
        Me.pnlFile.Name = "pnlFile"
        Me.pnlFile.Size = New System.Drawing.Size(680, 58)
        Me.pnlFile.TabIndex = 6
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
        'frmDataView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 438)
        Me.Controls.Add(Me.pnlRibbon)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDataView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDataView"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRibbon.ResumeLayout(False)
        Me.pnlView.ResumeLayout(False)
        CType(Me.imgCalendarView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearchSort.ResumeLayout(False)
        CType(Me.imgAlphabeticalSort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgDateSort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFile.ResumeLayout(False)
        CType(Me.imgOpen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents picClose As PictureBox
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblMenu As Label
    Friend WithEvents Panel2 As Panel
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
End Class
