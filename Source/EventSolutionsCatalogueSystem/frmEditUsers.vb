Imports System.IO

Public Class frmEditUsers

    Dim newUsername As String
    Dim newPassword As String
    Dim newLevel As String

    Dim deleteIndex As Integer

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
        If frmLogin.loggedInPrivilege <> "Administrator" Then
            MsgBox("Contact an Administrator to add a user to the system.")
            Me.Close()
        Else
            updateList()
        End If
    End Sub

    Function updateList()

        Dim eofcheck As String

        lstUsernames.Items.Clear()
        lstPasswords.Items.Clear()
        lstPriveliges.Items.Clear()

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
    End Function

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
        Dim targetUsername As String

        Dim readUsername As String
        Dim readPassword As String
        Dim readPrivelige As String

        Dim writeList As New List(Of String)

        targetUsername = lstUsernames.Items(deleteIndex)

        Using fileread As New StreamReader(frmLogin.userStorePath, True)

            While True
                readUsername = fileread.ReadLine()
                If readUsername Is Nothing Then
                    Exit While
                Else
                    readUsername = Decrypt(readUsername)
                    readPassword = Decrypt(fileread.ReadLine())
                    readPrivelige = Decrypt(fileread.ReadLine())

                    If readUsername <> targetUsername Then
                        writeList.Add(readUsername)
                        writeList.Add(readPassword)
                        writeList.Add(readPrivelige)
                    End If

                End If
            End While
        End Using

        My.Computer.FileSystem.DeleteFile(frmLogin.userStorePath)

        Using filewrite As New StreamWriter(frmLogin.userStorePath, True)
            For i As Integer = 0 To writeList.Count - 1
                filewrite.WriteLine(Encrypt(writeList.Item(i)))
            Next
        End Using

        updateList()

    End Sub

End Class