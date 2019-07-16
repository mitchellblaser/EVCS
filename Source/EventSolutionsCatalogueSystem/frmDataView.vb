Imports System.IO

Public Class frmDataView

    Structure calendarEntry
        Dim DateBeginning As Date
        Dim DateEnding As Date
        Dim ClientName As String
        Dim OtherInformation As String
    End Structure

    Structure calendarEvent
        Dim dateTime As Date
        Dim calEvent As String
        Dim otherInformation As String
    End Structure

    Dim calendarEntries(calendarStoreSize()) As calendarEntry
    Dim calendarEvents(calendarStoreSize() * 2) As calendarEvent

    Dim calBackend(calendarStoreSize() * 2) As String
    Dim listBackend(calendarStoreSize() * 2) As String

    Private Sub btnFile_Click(sender As Object, e As EventArgs) Handles btnFile.Click
        pnlFile.Visible = True
        pnlSearchSort.Visible = False
        pnlView.Visible = False

        btnFile.BackColor = Color.FromArgb(255, 16, 181, 232)
        btnSearchSort.BackColor = Color.FromArgb(255, 25, 118, 210)
        btnView.BackColor = Color.FromArgb(255, 25, 118, 210)

    End Sub

    Private Sub btnSearchSort_Click(sender As Object, e As EventArgs) Handles btnSearchSort.Click
        pnlFile.Visible = False
        pnlSearchSort.Visible = True
        pnlView.Visible = False

        btnFile.BackColor = Color.FromArgb(255, 25, 118, 210)
        btnSearchSort.BackColor = Color.FromArgb(255, 16, 181, 232)
        btnView.BackColor = Color.FromArgb(255, 25, 118, 210)

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        pnlFile.Visible = False
        pnlSearchSort.Visible = False
        pnlView.Visible = True

        btnFile.BackColor = Color.FromArgb(255, 25, 118, 210)
        btnSearchSort.BackColor = Color.FromArgb(255, 25, 118, 210)
        btnView.BackColor = Color.FromArgb(255, 16, 181, 232)

    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub

    Private Sub frmDataView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Read all files in equipment directory CAL
        Dim CalDi As New DirectoryInfo(evRootPath & hireStoreLocation)
        Dim CalFileArray As FileInfo() = CalDi.GetFiles()
        Dim i As Integer = 0 'Declare a counter to use in the loop below
        Dim f As Integer = 0
        Dim readline As String = ""
        Dim readlines As String

        'LIST
        Dim listWriter(2) As String
        Dim newItem As ListViewItem
        Dim listIndex As Integer = 0

        'Process them and load into a structure.
        For Each file In CalFileArray
            Using fileread As New StreamReader(evRootPath & hireStoreLocation & file.Name)
                calendarEntries(i).ClientName = fileread.ReadLine()
                calendarEntries(i).DateBeginning = fileread.ReadLine()
                calendarEntries(i).DateEnding = fileread.ReadLine()
                While True
                    readline = fileread.ReadLine()
                    If readline Is Nothing Then
                        Exit While
                    Else
                        readlines = readlines & readline & " [x" & fileread.ReadLine() & "] ($" & fileread.ReadLine() & ")" & vbNewLine
                    End If
                End While
                calendarEntries(i).OtherInformation = readlines
                readlines = ""
            End Using

            'add dates for cal view
            calDatePicker.AddBoldedDate(calendarEntries(i).DateBeginning)
            calDatePicker.AddBoldedDate(calendarEntries(i).DateEnding)

            calDatePicker.UpdateBoldedDates()

            calendarEvents(f).dateTime = calendarEntries(i).DateBeginning
            calendarEvents(f).calEvent = calendarEntries(i).ClientName & " - Equipment Checked Out."
            calendarEvents(f).otherInformation = calendarEntries(i).OtherInformation
            f = f + 1
            calendarEvents(f).dateTime = calendarEntries(i).DateEnding
            calendarEvents(f).calEvent = calendarEntries(i).ClientName & " - Equipment Returned."
            calendarEvents(f).otherInformation = calendarEntries(i).OtherInformation
            f = f + 1

            'add dates for list view

            listWriter(0) = calendarEntries(i).DateBeginning.Date
            listWriter(1) = calendarEntries(i).ClientName & " - Equipment Checked Out."
            listBackend(listIndex) = calendarEntries(i).OtherInformation
            listIndex = listIndex + 1
            newItem = New ListViewItem(listWriter)
            lstListView.Items.Add(newItem)

            listWriter(0) = calendarEntries(i).DateEnding.Date
            listWriter(1) = calendarEntries(i).ClientName & " - Equipment Returned."
            listBackend(listIndex) = calendarEntries(i).OtherInformation
            listIndex = listIndex + 1
            newItem = New ListViewItem(listWriter)
            lstListView.Items.Add(newItem)

            'increment i by 1
            i = i + 1
        Next
    End Sub

    Private Sub calDatePicker_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calDatePicker.DateChanged

        Dim selectedDate As Date
        Dim listIndex As Integer = 0

        selectedDate = calDatePicker.SelectionStart 'we can only select one so this just gets the selected date.
        lstEventsForDay.Items.Clear()
        For i As Integer = 0 To calendarEvents.Length - 1
            If calendarEvents(i).dateTime.Date = selectedDate Then
                lstEventsForDay.Items.Add(calendarEvents(i).calEvent)
                calBackend(listIndex) = calendarEvents(i).otherInformation
                listIndex = listIndex + 1
            End If
        Next

    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        If lstEventsForDay.SelectedIndex = -1 Then
            MsgBox("Select an item first.")
        Else
            MsgBox(lstEventsForDay.Items(lstEventsForDay.SelectedIndex) & vbNewLine & calBackend(lstEventsForDay.SelectedIndex))
        End If

    End Sub

    Private Sub imgListView_Click(sender As Object, e As EventArgs) Handles imgListView.Click
        pnlViewCal.Hide()
        pnlViewList.Show()
    End Sub

    Private Sub imgCalendarView_Click(sender As Object, e As EventArgs) Handles imgCalendarView.Click
        pnlViewList.Hide()
        pnlViewCal.Show()
    End Sub

    Private Sub btnListInfo_Click(sender As Object, e As EventArgs) Handles btnListInfo.Click
        If lstListView.SelectedIndices.Count = 0 Then
            MsgBox("Select an item first.")
        Else
            MsgBox(vbNewLine & lstListView.SelectedItems(0).SubItems(1).Text & vbNewLine & listBackend(lstListView.SelectedIndices(0)))
        End If
    End Sub

    Private Sub imgDateSort_Click(sender As Object, e As EventArgs) Handles imgDateSort.Click

    End Sub

    Private Sub imgAlphabeticalSort_Click(sender As Object, e As EventArgs) Handles imgAlphabeticalSort.Click

    End Sub

    Private Sub imgSearch_Click(sender As Object, e As EventArgs) Handles imgSearch.Click
        Dim i As Integer = 0
        Dim searchterm As String = ""

        searchterm = InputBox("Enter Search Term: ", "Search Events", "")

        If pnlViewCal.Visible = True Then
            While i < lstEventsForDay.Items.Count
                If lstEventsForDay.Items(i).ToString.ToUpper.Contains(searchterm.ToUpper) Then
                    MsgBox(lstEventsForDay.Items(i).ToString & vbNewLine & listBackend(i))
                End If
                i = i + 1
            End While
        End If

    End Sub
End Class