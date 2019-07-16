''''''''''''''''''''''''''''''''''''''
'  EventSolutions Catalogue System   '
'  (c) Mitchell Blaser, July 2019.   '
'                                    '
'  frmDataView.vb                    '
'  Form which allows the end user    '
'    to to view the data that they   '
'    edited in frmDataEntry.vb       '
''''''''''''''''''''''''''''''''''''''

Imports System.IO                                                                               'Import System.IO. We need this line at the top of every file where we use a StreamReader or StreamWriter.

Public Class frmDataView

    Structure calendarEntry                                                                     'Make a calendar entry data structure. This is kind of obsolete but is still used to some extent. Given more time this would be removed.
        Dim DateBeginning As Date
        Dim DateEnding As Date
        Dim ClientName As String
        Dim OtherInformation As String
    End Structure

    Structure calendarEvent                                                                     'Make a calendar event data structure.
        Dim dateTime As Date
        Dim calEvent As String
        Dim otherInformation As String
    End Structure

    Dim calendarEntries(calendarStoreSize()) As calendarEntry                                   'Create some lists. Read MAXSIZE from settingsHandler.vb.
    Dim calendarEvents(calendarStoreSize() * 2) As calendarEvent

    Dim calBackend(calendarStoreSize() * 2) As String
    Dim listBackend(calendarStoreSize() * 2) As String

    Private Sub btnFile_Click(sender As Object, e As EventArgs) Handles btnFile.Click           'Switch tabs in the ribbon.
        pnlFile.Visible = True                                                                  'Make the relevant panel visible and
        pnlSearchSort.Visible = False
        pnlView.Visible = False

        btnFile.BackColor = Color.FromArgb(255, 16, 181, 232)                                   'Set the color for the active/inactive tabs
        btnSearchSort.BackColor = Color.FromArgb(255, 25, 118, 210)
        btnView.BackColor = Color.FromArgb(255, 25, 118, 210)

    End Sub

    Private Sub btnSearchSort_Click(sender As Object, e As EventArgs) Handles btnSearchSort.Click 'Switch tabs in the ribbon.
        pnlFile.Visible = False                                                                 'Make the relevant panel visible and
        pnlSearchSort.Visible = True
        pnlView.Visible = False

        btnFile.BackColor = Color.FromArgb(255, 25, 118, 210)                                   'Set the color for the active/inactive tabs
        btnSearchSort.BackColor = Color.FromArgb(255, 16, 181, 232)
        btnView.BackColor = Color.FromArgb(255, 25, 118, 210)

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click           'Switch tabs in the ribbon.
        pnlFile.Visible = False                                                                 'Make the relevant panel visible and
        pnlSearchSort.Visible = False
        pnlView.Visible = True

        btnFile.BackColor = Color.FromArgb(255, 25, 118, 210)                                   'Set the color for the active/inactive tabs
        btnSearchSort.BackColor = Color.FromArgb(255, 25, 118, 210)
        btnView.BackColor = Color.FromArgb(255, 16, 181, 232)

    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()                                                                              'Close the form and show the main menu.
        frmMainMenu.Show()
    End Sub

    Dim itemsInCalendar As Integer                                                              'Declare another variable down here? I'm not sure why I did this - Might be a case of 5:00am syndrome.

    Private Sub frmDataView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For g = 0 To calendarStoreSize() * 2                                                    'Initialize the array to have blank data.
            calendarEvents(g).calEvent = "{"                                                    'Except for the sorting we need to have something there so I chose a higher ascii value that Z. You'll see that down below.
            calendarEvents(g).otherInformation = ""
        Next
        '                                                                                       'CALENDAR VIEW DECLARATIONS
        Dim CalDi As New DirectoryInfo(evRootPath & hireStoreLocation)                          'Make a (CalenderDirectoryInfo)
        Dim CalFileArray As FileInfo() = CalDi.GetFiles()                                       'and get a list of all files inside it.
        Dim i As Integer = 0                                                                    'Declare a counter to use in the loop below
        Dim f As Integer = 0                                                                    'Declare another counter to use in the loop below.
        Dim readline As String = ""                                                             'Declare some more strings to be used below.
        Dim readlines As String = ""

        '                                                                                       'LIST VIEW DECLARATIONS
        Dim listWriter(2) As String                                                             'Declare a small array
        Dim newItem As ListViewItem                                                             'Declare a new ListViewItem to write to
        Dim listIndex As Integer = 0                                                            'Make an index iterator. This will make sense in a second, trust me.

        For Each file In CalFileArray                                                           'Loop for every file in the hirestore
            Using fileread As New StreamReader(evRootPath & hireStoreLocation & file.Name)      'Read the current file in
                calendarEntries(i).ClientName = fileread.ReadLine()                             'Read in the constant information (first three lines)
                calendarEntries(i).DateBeginning = fileread.ReadLine()
                calendarEntries(i).DateEnding = fileread.ReadLine()
                While True                                                                      'Loop until the rest of the file has been read in (all of the equipment)
                    readline = fileread.ReadLine()
                    If readline Is Nothing Then                                                 'Classic EOF check. Look at frmLogin for an example.
                        Exit While
                    Else
                        readlines = readlines & readline & " [x" & fileread.ReadLine() & "] ($" & fileread.ReadLine() & ")" & vbNewLine 'Make an entry for each piece of equipment.
                    End If
                End While
                calendarEntries(i).OtherInformation = readlines                                 'Add the information from the equipment read (see ln.106 above)
                readlines = ""                                                                  'Clear readlines back to an empty string.
            End Using

            '                                                                                   'ADD DATES TO THE CALENDAR VIEW
            calDatePicker.AddBoldedDate(calendarEntries(i).DateBeginning)                       'Make one of the dates on the calendar view bold.
            calDatePicker.AddBoldedDate(calendarEntries(i).DateEnding)                          'Make the second date on the calendar view bold. There are two dates because we mark both pick up and drop off dates as events.

            calDatePicker.UpdateBoldedDates()                                                   'Call the calendar control's updateBoldedDates() function. It doesn't work unless you do this.

            calendarEvents(f).dateTime = calendarEntries(i).DateBeginning                       'Add two CalendarEvents, one for check in. Write info to the list of structures.
            calendarEvents(f).calEvent = calendarEntries(i).ClientName & " - Equipment Checked Out."
            calendarEvents(f).otherInformation = calendarEntries(i).OtherInformation
            f = f + 1                                                                           'Increment internal iterator f
            calendarEvents(f).dateTime = calendarEntries(i).DateEnding                          'The second CalendarEvent is for check out. Write info to the list of structures.
            calendarEvents(f).calEvent = calendarEntries(i).ClientName & " - Equipment Returned."
            calendarEvents(f).otherInformation = calendarEntries(i).OtherInformation
            f = f + 1                                                                           'Increment internal iterator f


            '                                                                                   'ADD DATES TO THE LIST VIEW
            listWriter(0) = calendarEntries(i).DateBeginning.Date                               'Add the data that was read from the file at first.
            listWriter(1) = calendarEntries(i).ClientName & " - Equipment Checked Out."
            listBackend(listIndex) = calendarEntries(i).OtherInformation                        'Add the other information to the list backend. This is for the more info button.
            listIndex = listIndex + 1                                                           'Increment listindex by 1
            newItem = New ListViewItem(listWriter)                                              'Make a new ListViewItem from the list
            lstListView.Items.Add(newItem)                                                      'Add the item to the list view.

            listWriter(0) = calendarEntries(i).DateEnding.Date                                  'Do the same as lines 130-135, but for the return instead of the checkout.
            listWriter(1) = calendarEntries(i).ClientName & " - Equipment Returned."
            listBackend(listIndex) = calendarEntries(i).OtherInformation
            listIndex = listIndex + 1
            newItem = New ListViewItem(listWriter)
            lstListView.Items.Add(newItem)

            i = i + 1                                                                           'Increment i by 1.
        Next
        itemsInCalendar = f
    End Sub

    Private Sub calDatePicker_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calDatePicker.DateChanged

        Dim selectedDate As Date                                                                'Declare variables.
        Dim listIndex As Integer = 0

        selectedDate = calDatePicker.SelectionStart                                             'we can only select one date so this just gets the first selected date in the list.
        lstEventsForDay.Items.Clear()                                                           'Clear the list box of any existing items.
        For i As Integer = 0 To calendarEvents.Length - 1                                       'Loop through all calendarEvents.
            If calendarEvents(i).dateTime.Date = selectedDate Then                              'If the current calendarEvent matches the date
                lstEventsForDay.Items.Add(calendarEvents(i).calEvent)                           'Add the event to the list box
                calBackend(listIndex) = calendarEvents(i).otherInformation                      'Add the additional info the calBackend list with the same index.
                listIndex = listIndex + 1                                                       'Increment the list index.
            End If
        Next

    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        If lstEventsForDay.SelectedIndex = -1 Then                                              'If the list box doesn't have a selected item
            MsgBox("Select an item first.")                                                     'Show a message
        Else
            MsgBox(lstEventsForDay.Items(lstEventsForDay.SelectedIndex) & vbNewLine & calBackend(lstEventsForDay.SelectedIndex)) 'Show a message with the details of the event.
        End If

    End Sub

    Private Sub imgListView_Click(sender As Object, e As EventArgs) Handles imgListView.Click
        pnlViewCal.Hide()                                                                       'Hide the calendar view
        pnlViewList.Show()                                                                      'Show the list view.
    End Sub

    Private Sub imgCalendarView_Click(sender As Object, e As EventArgs) Handles imgCalendarView.Click
        pnlViewList.Hide()                                                                      'Hide the list view
        pnlViewCal.Show()                                                                       'Show the calendar view.
    End Sub

    Private Sub btnListInfo_Click(sender As Object, e As EventArgs) Handles btnListInfo.Click
        If lstListView.SelectedIndices.Count = 0 Then                                           'If the list view doesn't have a selected item
            MsgBox("Select an item first.")                                                     'Show a message
        Else
            MsgBox(lstListView.SelectedItems(0).SubItems(1).Text & vbNewLine & listBackend(lstListView.SelectedIndices(0))) 'Show a message with the details of the event.
        End If
    End Sub

    Private Sub imgDateSort_Click(sender As Object, e As EventArgs) Handles imgDateSort.Click   'Selection Sort
        Dim smallestPos As Integer = -1                                                         'Declare the variables needed for the sort.
        Dim temp As Date
        Dim tempEvent As String
        Dim tempInfo As String

        Dim listWriter(2) As String                                                             'Declare the variables needed to write back to the list
        Dim newItem As ListViewItem
        Dim listIndex As Integer = 0

        For i As Integer = 0 To calendarEvents.Length - 2                                       'Sorting algorithm
            smallestPos = i
            For f = i + 1 To calendarEvents.Length - 1
                If calendarEvents(f).dateTime > calendarEvents(smallestPos).dateTime Then       'Slightly modified - Instead of comparing integers we compare DateTimes, but it works the same way.
                    smallestPos = f
                End If
            Next

            If i <> smallestPos Then                                                            'This is our swap routine. For some reason it didn't like to be in a seperate subroutine so I just left it here.
                temp = calendarEvents(smallestPos).dateTime
                calendarEvents(smallestPos).dateTime = calendarEvents(i).dateTime
                calendarEvents(i).dateTime = temp

                tempEvent = calendarEvents(smallestPos).calEvent
                calendarEvents(smallestPos).calEvent = calendarEvents(i).calEvent
                calendarEvents(i).calEvent = tempEvent

                tempInfo = calendarEvents(smallestPos).otherInformation
                calendarEvents(smallestPos).otherInformation = calendarEvents(i).otherInformation
                calendarEvents(i).otherInformation = tempInfo

            End If
        Next

        lstListView.Items.Clear()                                                               'Clear the list view
        For i = 0 To calendarEvents.Length - 1                                                  'Loop through the updated list of calendarEvents

            If calendarEvents(i).otherInformation <> "" Then                                    'If the event isn't blank (because we're technically looping from 0 to MAXSIZE)
                listWriter(0) = calendarEvents(i).dateTime.Date                                 'Write to the array
                listWriter(1) = calendarEvents(i).calEvent
                listBackend(listIndex) = calendarEvents(i).otherInformation                     'Add the otherInformation value to listBackend(listIndex)
                listIndex = listIndex + 1                                                       'Increment listIndex by 1.
                newItem = New ListViewItem(listWriter)                                          'Write out to the ListViewItem
                lstListView.Items.Add(newItem)                                                  'Add the ListViewItem to the List View.

            End If
        Next
    End Sub

    Private Sub imgAlphabeticalSort_Click(sender As Object, e As EventArgs) Handles imgAlphabeticalSort.Click 'NOTE: This has trouble working sometimes and I'm not sure why. Theoretically it should work...
        Dim smallestPos As Integer = -1                                                         'Declare variables for sorting
        Dim temp As Date
        Dim tempEvent As String
        Dim tempInfo As String

        Dim listWriter(2) As String                                                             'Declare variables for List View writing
        Dim newItem As ListViewItem
        Dim listIndex As Integer = 0


        For i As Integer = 0 To calendarEvents.Length - 2                                       'General Selection Sort Algorithm
            smallestPos = i
            For f As Integer = 0 To calendarEvents.Length - 1

                If Asc(calendarEvents(f).calEvent.ToUpper()) < Asc(calendarEvents(smallestPos).calEvent.ToUpper()) Then 'Slightly modified - we convert the strings to a list of ascii values, then compare those.
                    smallestPos = f
                End If
            Next

            If i <> smallestPos Then                                                            'This is our swap routine. For some reason it didn't like to be in a seperate subroutine so I just left it here.
                temp = calendarEvents(smallestPos).dateTime
                calendarEvents(smallestPos).dateTime = calendarEvents(i).dateTime
                calendarEvents(i).dateTime = temp

                tempEvent = calendarEvents(smallestPos).calEvent
                calendarEvents(smallestPos).calEvent = calendarEvents(i).calEvent
                calendarEvents(i).calEvent = tempEvent

                tempInfo = calendarEvents(smallestPos).otherInformation
                calendarEvents(smallestPos).otherInformation = calendarEvents(i).otherInformation
                calendarEvents(i).otherInformation = tempInfo
            End If
        Next

        lstListView.Items.Clear()                                                               'Clear the List View
        For i = 0 To calendarEvents.Length - 1                                                  'Loop through the calendar events array

            If calendarEvents(i).otherInformation <> "" Then                                    'Make sure the calendar event isn't blank.
                listWriter(0) = calendarEvents(i).dateTime.Date                                 'Write information into the listWriter list
                listWriter(1) = calendarEvents(i).calEvent
                listBackend(listIndex) = calendarEvents(i).otherInformation                     'Write otherInformation into the listBackend list
                listIndex = listIndex + 1                                                       'Increment listIndex for listBackend(listIndex)'s next run
                newItem = New ListViewItem(listWriter)                                          'Make a new ListViewItem with the listWriter
                lstListView.Items.Add(newItem)                                                  'Add the ListViewItem to the List View.

            End If
        Next

    End Sub

    Private Sub imgSearch_Click(sender As Object, e As EventArgs) Handles imgSearch.Click       'Yes, I know. It's linear search and is relatively slow compared to other methods. We're realistically not looking through that much data so it's fine for our use case.
        Dim i As Integer = 0                                                                    'Declare Variables for Search.
        Dim searchterm As String = ""

        searchterm = InputBox("Enter Search Term: ", "Search Events", "")                       'Prompt the user for a search term with an InputBox.

        If pnlViewCal.Visible = True Then                                                       'Make sure the calendar panel is visible.
            While i < lstEventsForDay.Items.Count                                               'Loop through all items in the list.
                If lstEventsForDay.Items(i).ToString.ToUpper.Contains(searchterm.ToUpper) Then  'If the item contains the string we're looking for (non-case-sensitive)
                    MsgBox(lstEventsForDay.Items(i).ToString & vbNewLine & listBackend(i))      'Show a messagebox with details.
                End If
                i = i + 1                                                                       'Increment i by 1.
            End While
        Else                                                                                    'If it's on list view instead of calendar view
            While i < lstListView.Items.Count                                                   'It does the same thing as the one above, but we search through every listing, not just the ones on that specific date.

                If lstListView.Items(i).SubItems(1).ToString.ToUpper.Contains(searchterm.ToUpper) Then
                    MsgBox(lstListView.Items(i).SubItems(1).Text & vbNewLine & listBackend(i))
                End If
                i = i + 1
            End While
        End If

    End Sub
End Class