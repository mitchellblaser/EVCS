Imports System.IO

Public Class frmAddUserBox

    Public newUsername As String
    Public newPassword As String
    Public newLevel As String
    Public frmAccepted As Boolean

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

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Dim readUsername As String
        Dim readPassword As String
        Dim readPrivelige As String

        'Using fileread As New StreamReader(frmLogin.userStorePath, True)
        '    While True
        '        readUsername = fileread.ReadLine()
        '        If readUsername Is Nothing Then
        '            Exit While
        '        Else
        '            readUsername = Decrypt(readUsername)
        '            readPassword = Decrypt(fileread.ReadLine())
        '            readPrivelige = Decrypt(fileread.ReadLine())

        '            If readUsername <> targetUsername Then
        '                writeList.Add(readUsername)
        '                writeList.Add(readPassword)
        '                writeList.Add(readPrivelige)
        '            End If

        '        End If
        '    End While
        'End Using

        newUsername = txtUsername.Text
        newPassword = txtPassword.Text
        newLevel = cmbAccessLevel.Text

        txtUsername.Text = ""
        txtPassword.Text = ""
        cmbAccessLevel.Text = ""

        frmAccepted = True
        Me.Close()
    End Sub

    Private Sub frmAddUserBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmAccepted = False
    End Sub
End Class