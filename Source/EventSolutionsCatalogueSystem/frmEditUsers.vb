Imports System.IO

Public Class frmEditUsers

    Dim newUsername As String
    Dim newPassword As String
    Dim newLevel As String

    Dim deleteIndex As Integer

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

        Dim eofcheck As String

        If frmLogin.loggedInPrivilege <> "Administrator" Then
            MsgBox("Contact an Administrator to add a user to the system.")
            Me.Close()

        Else
            Using fileread As New StreamReader(frmLogin.userStorePath, True)
                While True
                    eofcheck = fileread.ReadLine()
                    If eofcheck Is Nothing Then
                        Exit While
                    Else
                        lstUsernames.Items.Add(Decrypt(eofcheck))
                        lstPasswords.Items.Add(StrDup(Len(Decrypt(fileread.ReadLine())), "*"))
                        lstPriveliges.Items.Add(Decrypt(fileread.ReadLine()))
                    End If
                End While
            End Using
        End If
    End Sub



    Private Sub lstUsernames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsernames.SelectedIndexChanged
        deleteIndex = lstUsernames.SelectedIndex

        lstPasswords.SelectedIndex = deleteIndex
        lstPriveliges.SelectedIndex = deleteIndex

    End Sub

    Private Sub lstPasswords_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPasswords.SelectedIndexChanged
        deleteIndex = lstPasswords.SelectedIndex

        lstUsernames.SelectedIndex = deleteIndex
        lstPriveliges.SelectedIndex = deleteIndex

    End Sub

    Private Sub lstPriveliges_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPriveliges.SelectedIndexChanged
        deleteIndex = lstPriveliges.SelectedIndex

        lstUsernames.SelectedIndex = deleteIndex
        lstPasswords.SelectedIndex = deleteIndex

    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click



        Using fileread As New StreamReader(frmLogin.userStorePath, True)
            ''read file
        End Using
    End Sub

End Class