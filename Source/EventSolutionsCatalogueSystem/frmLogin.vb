''''''''''''''''''''''''''''''''''''''
'  EventSolutions Catalogue System   '
'  (c) Mitchell Blaser, July 2019.   '
'                                    '
'  frmLogin.vb                       '
'  Form which handles user account   '
'    authentication and allows other '
'    classes to access their         '
'    information (such as privelige) '
''''''''''''''''''''''''''''''''''''''

Imports System.IO 'Import the Input/Output stuff. Specifically, we're using StreamReader/StreamWriter.

Public Class frmLogin
    'Declare some publicly accessible variables in case we need to check the user on a different form.
    Public loggedInUser As String
    Public loggedInPrivilege As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Start login precedure on button click.
        evLogin()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'Quit when the login form is cancelled.
        Application.Exit()
    End Sub

    Sub evLogin()
        'Declare some local variables to store user information
        Dim usernameLine As String
        Dim passwordLine As String
        Dim privilegeLine As String

        'Declare a local variable to keep track of login issues if they happen.
        Dim errorLevel As Integer = 0

        Using fileRead As New StreamReader(evRootPath & userStoreLocation, True) 'Recursively loop until a username matches what's been entered
            While True 'Loop "forever". Not really though, this is just the easiest way to read in every line of the data in groups of three.
                usernameLine = fileRead.ReadLine() 'Read the username into the software from the file.

                If usernameLine Is Nothing Then 'If its nothing, we exit the loop. This happens when the streamreader has reached the end of the file.
                    Exit While 'Exit the loop.
                Else 'If the line has a value
                    usernameLine = Decrypt(usernameLine) 'We continue with the code byu decrypting the username line. This uses a function from /crypto.vb/.
                End If

                passwordLine = Decrypt(fileRead.ReadLine()) 'Because we know the next three lines are safe (username, password, privelige) we can read the other 
                privilegeLine = Decrypt(fileRead.ReadLine()) 'two in without checking them. They're also decrypted here.

                errorLevel = 1 'Set the error level to 1. If the username doesn't match it won't be overwritten.
                If usernameLine = txtUser.Text Then 'If the current username (read in from file) matches the username that the user entered into the text box,
                    If passwordLine = txtPass.Text Then 'We also check the password which relates to the username.
                        errorLevel = 0 'If it all checks out, we set errorlevel to 0, which indicates that there isn't a problem.
                        loggedInUser = txtUser.Text 'Set the public username variable (for checking privelige, etc.)
                        loggedInPrivilege = privilegeLine 'Set the public privelige variable (for checking privelige, etc.)
                        frmMainMenu.Show() 'Show the main menu
                        Me.Hide() 'Hide this form.
                    End If
                End If
            End While
        End Using 'close the file

        If errorLevel = 1 Then 'Check for errors; if the login details were wrong:
            MsgBox("Incorrect login details.") 'Show an error telling the user to retry.
        End If
    End Sub

End Class
