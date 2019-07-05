Imports System.IO
Imports System.Text

Public Class frmLogin
    Public evRootPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\EventSolutions"
    Public userStorePath As String = evRootPath & "\userstore\userstore.txt"
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        evLogin()
    End Sub

    Function Decrypt(ByVal value)

        Dim encIterator As Integer = 7

        Dim i As Integer = 0
        Dim valueLength As Integer = 0
        Dim decryptedOutput As String = ""

        valueLength = Len(value)

        While i < valueLength

            decryptedOutput = decryptedOutput & Chr(Asc(value(i)) - 7)

            i = i + 1
        End While

        Return decryptedOutput

    End Function


    Sub evLogin()

        Dim usernameLine As String
        Dim passwordLine As String
        Dim privilegeLine As String

        Using fileRead As New StreamReader(userStorePath, True) 'Recursively loop until a username matches what's been entered
            usernameLine = Decrypt(fileRead.ReadLine())
            passwordLine = Decrypt(fileRead.ReadLine())
            privilegeLine = Decrypt(fileRead.ReadLine())

            If usernameLine = txtUser.Text Then
                If passwordLine = txtPass.Text Then
                    frmMainMenu.Show()
                    Me.Hide()
                Else
                    MsgBox("Username and Password do not match.")
                End If
            Else
                MsgBox("Username not recognized.")
            End If
        End Using

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
