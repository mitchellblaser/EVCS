''''''''''''''''''''''''''''''''''''''
'  EventSolutions Catalogue System   '
'  (c) Mitchell Blaser, July 2019.   '
'                                    '
'  frmDataEntry.vb                   '
'  Form which allows the end user    '
'    to edit the data stores in the  '
'    application's private folders.  '
'    This information is then        '
'    processed and can be viewed in  '
'    frmDataView.vb.                 '
''''''''''''''''''''''''''''''''''''''

Imports System.IO                                                                               'Import System.IO. We need this line at the top of every file where we use a StreamReader or StreamWriter.

Public Class frmDataEntry
    Dim totalPrice As Integer                                                                   'Declare some variables that are accessed between subs, but are still local, we keep them inside the class.
    Dim openDataPath As String = ""

    Structure equipmentRecord                                                                   'Make a structure to hold an equipment record
        Dim equipmentName As String
        Dim equipmentManufacturer As String
        Dim equipmentQuantity As Integer
        Dim equipmentPrice As Integer
    End Structure

    Structure clientRecord                                                                      'Make a structure to hold a client record
        Dim clientFirst As String
        Dim clientLast As String
        Dim clientPhone As String
        Dim clientEmail As String
        Dim clientAddress As String
    End Structure

    Dim equipmentRecords(equipmentStoreSize()) As equipmentRecord                               'Initialize an array of equipmentRecord. It queries the settingsHandler.vb for MAXSIZE values.
    Dim clientRecords(clientStoreSize()) As clientRecord                                        'Initialize an array of clientRecord. It queries the settingsHandler.vb for MAXSIZE values.

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

    Private Sub frmDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load         'Okay, from this point on there's a lot of code so prepare yourself. This is what happens when you put so much functionality in one form.

        pnlClient.Visible = False                                                               'Set all three "functionality panels" to be hidden.
        pnlEquipment.Visible = False
        pnlHire.Visible = False

        If frmMainMenu.selectedTask = "AddClient" Then                                          'Query the main menu to see which task has been selected.
            pnlClient.Visible = True                                                            '   Set the relevant panel to be visible.
        ElseIf frmMainMenu.selectedTask = "AddEquipment" Then
            pnlEquipment.Visible = True
        ElseIf frmMainMenu.selectedTask = "AddHire" Then
            pnlHire.Visible = True

            Dim Eqdi As New DirectoryInfo(evRootPath & equipmentStoreLocation)                  'Declare Eqdi (or EquipmentDirectoryInfo) and give it the path to the equipmentstore folder.
            Dim EqfileArray As FileInfo() = Eqdi.GetFiles()                                     'Get a list of all files in the directory (listed above)
            Dim i As Integer = 0                                                                'Declare an iterator. initialize it to 0.

            For Each file In EqfileArray                                                        'Loop through each file in the directory.
                Using fileread As New StreamReader(evRootPath & equipmentStoreLocation & file.Name) ' Make a new StreamReader that reads the current file.
                    equipmentRecords(i).equipmentName = fileread.ReadLine()                     'Read the relevant information and add it to the equipmentRecords() array.
                    equipmentRecords(i).equipmentManufacturer = fileread.ReadLine()
                    equipmentRecords(i).equipmentQuantity = fileread.ReadLine()
                    equipmentRecords(i).equipmentPrice = fileread.ReadLine()
                End Using                                                                       'Close the file
                cmbEquipment.Items.Add(equipmentRecords(i).equipmentName)                       'Add the equipment record to the combo box in the hire panel so that the user can select it.
                i = i + 1                                                                       'Increment i.
            Next

            Dim Cldi As New DirectoryInfo(evRootPath & clientStoreLocation)                     'Repeat the above process for the clientstore location. Declare a (ClientDirectoryInfo) variable.
            Dim ClfileArray As FileInfo() = Cldi.GetFiles()                                     'Get a list of files in the clientstore directory.
            i = 0                                                                               'Set the iterator back to 0. We're in a completely different loop now and don't want a neelessly long number.

            For Each file In ClfileArray                                                        'Loop through each file in the array.
                Using fileread As New StreamReader(evRootPath & clientStoreLocation & file.Name) 'Read the current file with a new StreamReader.
                    clientRecords(i).clientFirst = fileread.ReadLine()                          'Add the relevant data to the clientRecords() array.
                    clientRecords(i).clientLast = fileread.ReadLine()
                    clientRecords(i).clientPhone = fileread.ReadLine()
                    clientRecords(i).clientEmail = fileread.ReadLine()
                    clientRecords(i).clientAddress = fileread.ReadLine()
                End Using                                                                       'Close the file.
                cmbClient.Items.Add(clientRecords(i).clientFirst & " " & clientRecords(i).clientLast) 'Add the client record to the combo box in the hire panel so that the user can select it.
                i = i + 1                                                                       'Increment i by 1.
            Next
        End If
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()                                                                              'Close the form and show the main menu when the close button is clicked.
        frmMainMenu.Show()
    End Sub

    Private Sub imgSave_Click(sender As Object, e As EventArgs) Handles imgSave.Click
        If frmMainMenu.selectedTask = "AddEquipment" Then                                       'If the save button is clicked when Add Equipment is active
            openDataPath = evRootPath & equipmentStoreLocation & Replace(Replace(txtName.Text, " ", ""), ".", "") & ".evdf" 'Set the file path to open

            Try                                                                                 'Try to delete the file. The error checking is there in case the file didn't exist in the first place.
                My.Computer.FileSystem.DeleteFile(openDataPath)                                 'We need to delete the file first so we don't write more than four lines to it.
            Catch ex As Exception
            End Try

            Using filewrite As New StreamWriter(openDataPath, True)                             'Write the relevant data to the file.
                filewrite.WriteLine(txtName.Text)
                filewrite.WriteLine(txtManufacturer.Text)
                filewrite.WriteLine(numQuantity.Value)
                filewrite.WriteLine(numPricePerDay.Value)
            End Using                                                                           'Close the file.
            MsgBox("Successfully saved.")                                                       'Show a confirmation message to the user.
        ElseIf frmMainMenu.selectedTask = "AddClient" Then                                      'If the save button is clicked when Add Client is active
            openDataPath = evRootPath & clientStoreLocation & txtFirstName.Text & txtNameLast.Text & "_" & txtEmail.Text & ".evdf" 'Set the file path to open

            Try                                                                                 'Try to delete the file. The error checking is there in case the file didn't exist in the first place.
                My.Computer.FileSystem.DeleteFile(openDataPath)                                 'We need to delete the file first so we don't write more than four lines to it.    
            Catch ex As Exception
            End Try

            Using filewrite As New StreamWriter(openDataPath, True)                             'Write the relevant data to the file.
                filewrite.WriteLine(txtFirstName.Text)
                filewrite.WriteLine(txtNameLast.Text)
                filewrite.WriteLine(txtPhone.Text)
                filewrite.WriteLine(txtEmail.Text)
                filewrite.WriteLine(txtAddress.Text)
            End Using                                                                           'Close the file.
            MsgBox("Successfully saved.")                                                       'Show a confirmation message to the user.
        ElseIf frmMainMenu.selectedTask = "AddHire" Then                                        'If the save button is clicked when Add Hire is active
            openDataPath = evRootPath & hireStoreLocation & Replace(dtpDateOut.Value.ToShortDateString, "/", "_") & "__" & Replace(cmbClient.SelectedItem, " ", "") & ".evdf" 'Set the file path to open

            Try                                                                                 'Try to delete the file. The error checking is there in case the file didn't exist in the first place.
                My.Computer.FileSystem.DeleteFile(openDataPath)                                 'We need to delete the file first so we don't write more than four lines to it.    
            Catch ex As Exception
            End Try
            Using filewrite As New StreamWriter(openDataPath, True)                             'Write the first part of the data to the file once.
                filewrite.WriteLine(cmbClient.SelectedItem)
                filewrite.WriteLine(dtpDateOut.Value)
                filewrite.WriteLine(dtpDateIn.Value)
                For i As Integer = 0 To lstEquipment.Items.Count - 1                            'Write the list of items that the client has hired to the file one by one until the end of the list.
                    filewrite.WriteLine(lstEquipment.Items(i))
                    filewrite.WriteLine(lstQuantity.Items(i))
                    filewrite.WriteLine(lstPrice.Items(i))
                Next
            End Using                                                                           'Close the file
            MsgBox("Successfully saved.")                                                       'Show a confirmation message to the user.
        End If
    End Sub

    Private Sub imgNew_Click(sender As Object, e As EventArgs) Handles imgNew.Click
        If frmMainMenu.selectedTask = "AddEquipment" Then                                       'If the New button is clicked while Add Equipment is active
            txtName.Focus()                                                                     'Clear all form elements
            txtName.Text = ""
            txtManufacturer.Text = ""
            numQuantity.Value = 0
            numPricePerDay.Value = 0
        ElseIf frmMainMenu.selectedTask = "AddClient" Then                                      'If the New button is clicked while Add Client is active
            txtFirstName.Focus()                                                                'Clear all form elements
            txtFirstName.Text = ""
            txtNameLast.Text = ""
            txtPhone.Text = ""
            txtEmail.Text = ""
            txtAddress.Text = ""
        ElseIf frmMainMenu.selectedTask = "AddHire" Then                                        'If the New button is clicked while Add Hire is active
            cmbClient.Focus()                                                                   'Clear all form elements
            cmbClient.Text = ""
            cmbEquipment.Text = ""
            nudQuantity.Value = 0
            dtpDateIn.Value = Date.Now
            dtpDateOut.Value = Date.Now
            lstEquipment.Items.Clear()
            lstPrice.Items.Clear()
            lstQuantity.Items.Clear()
            totalPrice = 0
            calculateHireCost()
        End If
    End Sub

    Private Sub imgOpen_Click(sender As Object, e As EventArgs) Handles imgOpen.Click
        Dim equipmentLine As String                                                             'Declare some local variables used to read in files
        Dim quantityLine As Integer                                                             '      These are only used in the Open Hire section (below).
        Dim priceLine As Integer

        If frmMainMenu.selectedTask = "AddEquipment" Then                                       'If Equipment panel is active while the Open button is clicked
            dlgOpenRecord.Reset()                                                               'Reset the dialog box
            dlgOpenRecord.InitialDirectory = evRootPath & equipmentStoreLocation                'Set the initial directory to the root of the equipmentstore
            dlgOpenRecord.ShowDialog()                                                          'Show the dialog box.

            If dlgOpenRecord.CheckFileExists = False Then                                       'Error checking.
                MsgBox("Please select a file.")
            Else
                openDataPath = dlgOpenRecord.FileName                                           'If the file exists, set the path to open it.
                Try                                                                             'More error checking. This is redundant but I didn't have time to remove it.
                    Using fileread As New StreamReader(openDataPath)                            'Read in the file with the path we made above.
                        txtName.Focus()                                                         'We have to focus a text box (or any other element) to change the value of a combo box, so we do this first.

                        txtName.Text = fileread.ReadLine()                                      'Set the values of the elements to what we read from the file.
                        txtManufacturer.Text = fileread.ReadLine()
                        numQuantity.Value = fileread.ReadLine()
                        numPricePerDay.Value = fileread.ReadLine()

                    End Using
                Catch ex As Exception
                    MsgBox("Please select a file.")                                             'Display an error message on exception.
                End Try

            End If

        ElseIf frmMainMenu.selectedTask = "AddClient" Then                                      'If Client panel is active while the Open button is clicked
            dlgOpenRecord.Reset()                                                               'Reset the dialog box
            dlgOpenRecord.InitialDirectory = evRootPath & clientStoreLocation                   'Set the directory to the root of the clientstore.
            dlgOpenRecord.ShowDialog()                                                          'Show the dialog.

            If dlgOpenRecord.CheckFileExists = False Then                                       'Error checking.
                MsgBox("Please select a file.")
            Else
                openDataPath = dlgOpenRecord.FileName                                           'Set the path to open.
                Try                                                                             'More error checking. This is redundant but I didn't have time to remove it.
                    Using readfile As New StreamReader(openDataPath)                            'Open the file with the path we set above.
                        txtName.Focus()                                                         'Reset the user's view back to the first box for easy data entry

                        txtFirstName.Text = readfile.ReadLine()                                 'Set all the form's elements to the values we read from the file.
                        txtNameLast.Text = readfile.ReadLine()
                        txtPhone.Text = readfile.ReadLine()
                        txtEmail.Text = readfile.ReadLine()
                        txtAddress.Text = readfile.ReadLine()

                    End Using                                                                   'Close the file.
                Catch ex As Exception
                    MsgBox("Please select a file.")                                             'Show an error message to the user if things break.
                End Try

            End If

        ElseIf frmMainMenu.selectedTask = "AddHire" Then                                        'If Hire panel is active while the Open button is clicked
            dlgOpenRecord.Reset()                                                               'Reset the dialog box
            dlgOpenRecord.InitialDirectory = evRootPath & hireStoreLocation                     'Set the directory to the root of the hirestore
            dlgOpenRecord.ShowDialog()                                                          'Show the dialog.

            If dlgOpenRecord.CheckFileExists = False Then                                       'Error checking.
                MsgBox("Please select a file.")
            Else
                openDataPath = dlgOpenRecord.FileName                                           'Set the path to open.
                Try                                                                             'More error checking. This is redundant but I didn't have time to remove it.
                    Using readfile As New StreamReader(openDataPath)                            'Open the file with the path we set above.
                        cmbClient.Focus()                                                       'Reset the user's view back to the first box for easy data entry
                        cmbClient.Text = readfile.ReadLine()                                    'Read the new data into the form's elements.
                        dtpDateOut.Value = readfile.ReadLine()
                        dtpDateIn.Value = readfile.ReadLine()

                        lstEquipment.Items.Clear()                                              'Clear the existing list boxes.
                        lstPrice.Items.Clear()
                        lstQuantity.Items.Clear()

                        While True                                                              'Loop until the end of the hire record (remember how we saved the files earlier?)
                            equipmentLine = readfile.ReadLine()                                 'End Of File Check.
                            If equipmentLine Is Nothing Then
                                Exit While
                            Else
                                lstEquipment.Items.Add(equipmentLine)                           'Add the values to the list box.
                                quantityLine = readfile.ReadLine()
                                lstQuantity.Items.Add(quantityLine)
                                priceLine = readfile.ReadLine()
                                lstPrice.Items.Add(priceLine)
                                totalPrice = totalPrice + priceLine * quantityLine              'Calculate the total price for the item (quantity*price) and add it to the total of all items.
                            End If
                        End While
                    End Using
                    calculateHireCost()                                                         'Call the calculateHireCost() function. This calculates the total hire cost (duh)
                Catch ex As Exception
                    MsgBox("Please select a file.")                                             'Show a message if the file can't be found.
                End Try
            End If
        Else
            MsgBox("Oops! An error has occured. Please exit and try again.")                    'If the solution can't detect what part of the form is being used it will show this error. I've never had it happen though so fingers crossed.
        End If
    End Sub

    Private Sub imgDelete_Click(sender As Object, e As EventArgs) Handles imgDelete.Click
        If frmMainMenu.selectedTask = "AddEquipment" Then                                       'If Equipment panel is open when Delete button is clicked
            My.Computer.FileSystem.DeleteFile(openDataPath)                                     'We delete the open file. This path was set during either file save and/or file open.
            MsgBox("Successfully deleted.")                                                     'Show a message box.
            txtName.Focus()                                                                     'Set focus back to the first element and

            txtName.Text = ""                                                                   'Clear the form's elements.
            txtManufacturer.Text = ""
            numQuantity.Value = 0
            numPricePerDay.Value = 0
        ElseIf frmMainMenu.selectedTask = "AddClient" Then                                      'If Client panel is open when Delete button is clicked
            My.Computer.FileSystem.DeleteFile(openDataPath)                                     'Delete the open file with the path that was set during file save/open
            MsgBox("Successfully deleted.")                                                     'Show a message box.

            txtFirstName.Focus()                                                                'Set focus back to the first element and
            txtFirstName.Text = ""                                                              'Clear the form's elements.
            txtNameLast.Text = ""
            txtPhone.Text = ""
            txtEmail.Text = ""
            txtAddress.Text = ""
        ElseIf frmMainMenu.selectedTask = "AddHire" Then                                        'If Hire panel is open when Delete button is clicked
            cmbClient.Focus()                                                                   'Set focus back to the first element and
            cmbClient.Text = ""                                                                 'Clear the form's elements.
            cmbEquipment.Text = ""
            nudQuantity.Value = 0
            dtpDateIn.Value = Date.Now
            dtpDateOut.Value = Date.Now
            lstEquipment.Items.Clear()
            lstPrice.Items.Clear()
            lstQuantity.Items.Clear()
            totalPrice = 0                                                                      'Set the total cost for the hire to 0.
            calculateHireCost()                                                                 'Recalculate the total cost (this sets it back to zero)
            My.Computer.FileSystem.DeleteFile(openDataPath)                                     'Delete the file
            MsgBox("Successfully deleted.")                                                     'Show a message box.
        Else
            MsgBox("Oops! An error has occured. Please exit and try again.")                    'Show an error in case the solution breaks unexpectedly.
        End If
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click     'NOTE: This button is inside the hire panel of the form.

        If nudQuantity.Value <= equipmentRecords(cmbEquipment.SelectedIndex).equipmentQuantity Then 'Check if the quantity added to the hire exceeds the amount available (from data file)
            lstEquipment.Items.Add(equipmentRecords(cmbEquipment.SelectedIndex).equipmentName)  'Add the item to the list boxes
            lstQuantity.Items.Add(nudQuantity.Value)
            lstPrice.Items.Add(equipmentRecords(cmbEquipment.SelectedIndex).equipmentPrice * nudQuantity.Value)
            totalPrice = totalPrice + equipmentRecords(cmbEquipment.SelectedIndex).equipmentPrice * nudQuantity.Value 'Calculate the total price for the day.

            calculateHireCost()                                                                 'Call calculateHireCost() to calculate totalPrice*days
        Else
            MsgBox("You have exceded the amount of items you have in stock.")                   'If there isn't enough equipment quantity, we display an error message.
        End If
    End Sub

    Private Sub dtpDateOut_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateOut.ValueChanged
        calculateHireCost()                                                                     'When the date out gets changed, recalculate the hire cost.
    End Sub

    Private Sub dtpDateIn_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateIn.ValueChanged
        calculateHireCost()                                                                     'When the date in gets changed, recalculate the hire cost.
    End Sub

    Function calculateHireCost()                                                                'NOTE: Read this, it doesn't work the way you'd expect.
        Dim totalDates = dtpDateIn.Value - dtpDateOut.Value                                     'Make the total days variable. Unfortunately it never returns a day and it's like 0.99999999 of a day.
        Dim totalDays As Integer = totalDates.TotalHours                                        'We fix this by converting to hours and making another variable - an integer this time.
        totalDays = (totalDays / 24) + 1                                                        'divide the total hours (still called totalDays because we set it to itself) by 24, and then add one to the end of the equation.
        lblTotal.Text = "Total: $" & totalDays * totalPrice                                     'set the label down the bottom of the form to the outcome of totalDays * totalPrice. 
    End Function

    Private Sub lstEquipment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEquipment.SelectedIndexChanged
        lstQuantity.SelectedIndex = lstEquipment.SelectedIndex                                  'If the selection changes in one of the list boxes, change the others along with it.
        lstPrice.SelectedIndex = lstEquipment.SelectedIndex
    End Sub

    Private Sub lstQuantity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstQuantity.SelectedIndexChanged
        lstEquipment.SelectedIndex = lstQuantity.SelectedIndex                                  'If the selection changes in one of the list boxes, change the others along with it.
        lstPrice.SelectedIndex = lstQuantity.SelectedIndex
    End Sub

    Private Sub lstPrice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPrice.SelectedIndexChanged
        lstEquipment.SelectedIndex = lstPrice.SelectedIndex                                     'If the selection changes in one of the list boxes, change the others along with it.
        lstQuantity.SelectedIndex = lstPrice.SelectedIndex
    End Sub
End Class