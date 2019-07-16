''''''''''''''''''''''''''''''''''''''
'  EventSolutions Catalogue System   '
'  (c) Mitchell Blaser, July 2019.   '
'                                    '
'  frmEditUsers.vb                   '
'  Form which handles user account   '
'    authentication and allows other '
'    classes to access their         '
'    information (such as privelige) '
''''''''''''''''''''''''''''''''''''''

Imports System.IO                                                                               'Import System.IO. We need this line at the top of every file where we use a StreamReader or StreamWriter.

Public Class frmEditUsers
    Dim newUsername As String                                                                   'Declare variables needed later in the program
    Dim newPassword As String
    Dim newLevel As String

    Dim deleteIndex As Integer

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click     'When the Add User Button is Clicked

        Dim listWriter(3) As String                                                             'Make an array of three strings
        Dim newItem As ListViewItem                                                             'Make a new list view entry item

        frmAddUserBox.ShowDialog()                                                              'Show the dialog to get information for the new user.

        newUsername = frmAddUserBox.newUsername                                                 'Assign information from the dialog to the three local variables (declared above)
        newPassword = frmAddUserBox.newPassword
        newLevel = frmAddUserBox.newLevel

        listWriter(0) = newUsername                                                             'Add the username to the array
        listWriter(1) = StrDup(Len(newPassword), "*")                                           'Add a series of '*' characters (the length of the password) to the array
        listWriter(2) = newLevel                                                                'Add the privelige level to the array

        newItem = New ListViewItem(listWriter)                                                  'Make a new list view item from the array
        lstUsers.Items.Add(newItem)                                                             'Add the item above to the list view.

        Using filewrite As New StreamWriter(evRootPath & userStoreLocation, True)               'Open the user store and write the new details to the file as well.
            filewrite.WriteLine(Encrypt(newUsername))
            filewrite.WriteLine(Encrypt(newPassword))
            filewrite.WriteLine(Encrypt(newLevel))
        End Using

    End Sub                                                                                     'Note: for this sub we could have used the updateList() function, but it wasn't as efficient as doing it twice in the code.

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click         'When the Close button is clicked
        Me.Close()                                                                              'Close the form, we don't need to access any variables that might exist on this form after it's closed.
        frmMainMenu.Show()                                                                      'Show the main menu
    End Sub

    Private Sub frmEditUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load         'When the form loads itself
        If frmLogin.loggedInPrivilege <> "Administrator" Then                                   'Check if the currently looged in user is an administrator. They shouldn't be able to add another user if they don't have permission.
            MsgBox("Contact an Administrator to add a user to the system.")                     'Display an error and close.
            Me.Close()
        Else                                                                                    'If they are an administrator,
            updateList()                                                                        'Leave the form open and launch the function updateList()
        End If
    End Sub

    Function updateList()                                                                       'Make a new function called updateList.

        Dim eofcheck As String                                                                  'Declare some new variables.
        Dim listWriter(3) As String

        Dim newItem As ListViewItem                                                             'Declare another ListViewItem.

        lstUsers.Items.Clear()                                                                  'Clear the list box so we're ready to load in the new data

        Using fileread As New StreamReader(evRootPath & userStoreLocation, True)                'Make a new StreamReader that points to the userstore file.
            While True                                                                          'Loop recursively.
                eofcheck = fileread.ReadLine()                                                  'Do the End Of File check as discussed in frmLogin.vb
                If eofcheck Is Nothing Then                                                     '(read in, if is nothing (which would be an eof), kill the while loop)
                    Exit While
                Else
                    listWriter(0) = Decrypt(eofcheck)                                           'Decrypt the line we already read in and put it in the array
                    listWriter(1) = StrDup(Len(Decrypt(fileread.ReadLine())), "*")              'Mask the password with asterisks.
                    listWriter(2) = Decrypt(fileread.ReadLine())                                'Add the permission line by decrypting the output of the readline() directly to save space.

                    newItem = New ListViewItem(listWriter)                                      'Make the ListViewItem with the array and
                    lstUsers.Items.Add(newItem)                                                 'write it to the listview.
                End If
            End While
        End Using
    End Function

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click 'Subroutine to delete a user entry.
        Dim targetUsername As String                                                            'Declare some variables. This one is used to search for the user to delete, 

        Dim readUsername As String                                                              'while these are used to temporarily read in all of the data from the file.
        Dim readPassword As String
        Dim readPrivelige As String

        Dim writeList As New List(Of String)                                                    'This one is different, as we also use a variable called writeList. Each list element is the string of one line.

        targetUsername = lstUsers.Items(deleteIndex).Text                                       'Set our search target to the selected index of the list box (select item -> delete)

        Using fileread As New StreamReader(evRootPath & userStoreLocation, True)                'Open the userstore file.

            While True                                                                          'Read through the file. Use the error checking method explained above.
                readUsername = fileread.ReadLine()
                If readUsername Is Nothing Then
                    Exit While
                Else
                    readUsername = Decrypt(readUsername)                                        'Decrypt the file's contents as we read it in.
                    readPassword = Decrypt(fileread.ReadLine())
                    readPrivelige = Decrypt(fileread.ReadLine())

                    If readUsername <> targetUsername Then                                      'If the item we just read in isn't equal to the one we want to delete,
                        writeList.Add(readUsername)                                             'we add the item to the writeList. Effectively, this will give us a list
                        writeList.Add(readPassword)                                             'of lines, just without the lines we want to delete.
                        writeList.Add(readPrivelige)
                    End If

                End If
            End While
        End Using

        My.Computer.FileSystem.DeleteFile(evRootPath & userStoreLocation)                       'We then delete the file, because a version of it already exists, and we want to write a new file, not append an old one.

        Using filewrite As New StreamWriter(evRootPath & userStoreLocation, True)               'Make a new StreamWriter that points to the now empty userstore location
            For i As Integer = 0 To writeList.Count - 1                                         'Loop through our writelist until the end, writing one line back out to the file at a time.
                filewrite.WriteLine(Encrypt(writeList.Item(i)))                                 'While we write it out, we encrypt it again also. The userstore should be secure so nobody can just log in to it.
            Next
        End Using

        updateList()                                                                            'Call the updateList() function after the file has been modified. Essentially read the ifle back in and repopulate the list view.

    End Sub

    Private Sub lstUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsers.SelectedIndexChanged
        For Each itm As ListViewItem In lstUsers.SelectedItems                                  'Whenever a new item is seleceted in the listview, we change the deleteindex so we're ready for the delete sub to start.
            If itm.Selected Then                                                                'NOTE: Only one item can be selected in the listview at a time because of the way I've configured it, so we can just get the index and not a list of indexes.
                deleteIndex = itm.Index
            End If
        Next

    End Sub
End Class