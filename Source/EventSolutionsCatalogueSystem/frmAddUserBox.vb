''''''''''''''''''''''''''''''''''''''
'  EventSolutions Catalogue System   '
'  (c) Mitchell Blaser, July 2019.   '
'                                    '
'  frmAddUserBox.vb                  '
'  Form which gets launched from     '
'    frmEditUsers.vb. It's used to   '
'    get information from the user   '
'    in a little nicer of a way than '
'    a stock inputbox.               '
''''''''''''''''''''''''''''''''''''''

Imports System.IO                                                                               'Import System.IO. We need this line at the top of every file where we use a StreamReader or StreamWriter.

Public Class frmAddUserBox

    Public newUsername As String                                                                'Declare the global variables we're going to use.
    Public newPassword As String
    Public newLevel As String

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click               'We run the code in the file exclusively once the OK button is clicked.

        Dim readUsername As String                                                              'Declare some local variables to be used inside the sub.
        Dim readPassword As String
        Dim readPrivelige As String

        Dim valid As Boolean

        valid = True                                                                            'This gets set to TRUE at the start, but if a new user with the same name as an existing one is made, it will be set to false and show an error later.

        Using fileread As New StreamReader(evRootPath & userStoreLocation, True)                'Make a new StreamReader, give it the path to the userstore file.
            While True

                readUsername = fileread.ReadLine()                                              'Read in the file. From here...
                If readUsername Is Nothing Then
                    Exit While

                Else                                                                            '...to here is a check for the End Of File (EOF).

                    readUsername = Decrypt(readUsername)                                        'Decrypt the line we just read in above
                    readPassword = Decrypt(fileread.ReadLine())                                 'Read in the password line and Decrypt() it.
                    readPrivelige = Decrypt(fileread.ReadLine())                                'Read in the privelige line and Decrypt() it.

                    If txtUsername.Text = readUsername Then                                     'In our loop (through every logged user account), we check if our current position's username matches our new one.
                        valid = False                                                           'If it does, set the valid variable to false. We'll run a check for this later to make sure everything's valid.
                    End If

                End If

            End While
        End Using

        If valid = False Then                                                                   'Speaking of... Here's our check.
            MsgBox("This username already exists. Please choose a different one.")              'And a nice error message for the end user.
        Else
            newUsername = txtUsername.Text                                                      'If it's okay (see above), we set the global variables for username, password and privelige to our new settings
            newPassword = txtPassword.Text
            newLevel = cmbAccessLevel.Text

            txtUsername.Text = ""                                                               'and clear our form controls for next time.
            txtPassword.Text = ""
            cmbAccessLevel.Text = ""

            Me.Close()                                                                          'Finally, we close the form. Because it's treated as a DialogBox and not a Form the information is grabbed before the form is actually closed.
        End If                                                                                  '   It works this way because we use frmAddUserBox.ShowDialog() instead of frmAddUserBox.Show() in frmEditUsers.vb.
    End Sub
End Class