Imports System.IO
Imports System.Text

Public Class frmLogin
    Public evRootPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\EventSolutions"
    Public userStorePath As String = evRootPath & "\userstore\userstore.txt"

    Public loggedInUser As String
    Public loggedInPrivilege As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        evLogin()
    End Sub

    Sub evLogin()

        Dim usernameLine As String
        Dim passwordLine As String
        Dim privilegeLine As String

        Dim errorLevel As Integer = 0
        Dim loginPass As Integer = 0

        Using fileRead As New StreamReader(userStorePath, True) 'Recursively loop until a username matches what's been entered
            While True
                usernameLine = fileRead.ReadLine()

                If usernameLine Is Nothing Then
                    Exit While
                Else
                    usernameLine = Decrypt(usernameLine)
                End If

                passwordLine = Decrypt(fileRead.ReadLine())
                privilegeLine = Decrypt(fileRead.ReadLine())

                If usernameLine = txtUser.Text Then
                    If passwordLine = txtPass.Text Then
                        errorLevel = 0
                        loggedInUser = txtUser.Text
                        loggedInPrivilege = privilegeLine
                        frmMainMenu.Show()
                        Me.Hide()
                    End If
                Else
                    errorLevel = 1
                End If
            End While
        End Using


        If errorLevel = 1 Then
            MsgBox("Incorrect login details.")
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
End Class
