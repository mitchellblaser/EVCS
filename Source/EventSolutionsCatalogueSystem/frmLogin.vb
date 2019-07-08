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
                    errorLevel = 0
                    If passwordLine = txtPass.Text Then
                        loginPass = 1
                        errorLevel = 0
                        loggedInUser = txtUser.Text
                        loggedInPrivilege = privilegeLine
                        frmMainMenu.Show()
                        Me.Hide()
                    Else
                        errorLevel = 2
                    End If
                Else
                    errorLevel = 1
                End If
            End While
        End Using

        If loginPass = 0 Then
            If errorLevel = 1 Then
                MsgBox("Username not Recognized.")
            ElseIf errorLevel = 2 Then
                MsgBox("Username and Password do not Match.")
            End If
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            evLogin()
        End If
    End Sub
End Class
