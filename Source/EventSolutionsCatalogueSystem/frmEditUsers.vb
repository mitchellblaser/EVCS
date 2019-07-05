Imports System.IO

Public Class frmEditUsers

    Dim newUsername As String
    Dim newPassword As String
    Dim newLevel As String

    Function Encrypt(ByVal value)

        Dim encIterator As Integer = 7

        Dim i As Integer = 0
        Dim valueLength As Integer = 0
        Dim encryptedOutput As String = ""

        valueLength = Len(value)

        While i < valueLength
            encryptedOutput = encryptedOutput & Chr(Asc(value(i)) + 7)

            i = i + 1
        End While

        Return encryptedOutput

    End Function

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        frmAddUserBox.ShowDialog()

        newUsername = frmAddUserBox.newUsername
        newPassword = frmAddUserBox.newPassword
        newLevel = frmAddUserBox.newLevel

        lstUsernames.Items.Add(newUsername)
        lstPasswords.Items.Add(StrDup(Len(newPassword), "*"))
        lstPriveliges.Items.Add(newLevel)

        Using filewrite As New StreamWriter(frmLogin.userStorePath, True)
            filewrite.WriteLine(Encrypt(newUsername))
            filewrite.WriteLine(Encrypt(newPassword))
            filewrite.WriteLine(Encrypt(newLevel))
        End Using

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmEditUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Check if user is admin
    End Sub
End Class