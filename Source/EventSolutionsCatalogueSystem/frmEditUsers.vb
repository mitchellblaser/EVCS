Imports System.IO

Public Class frmEditUsers

    Dim newUsername As String
    Dim newPassword As String
    Dim newLevel As String

    Dim deleteIndex As Integer

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click

        Dim listWriter(3) As String
        Dim newItem As ListViewItem

        frmAddUserBox.ShowDialog()

        newUsername = frmAddUserBox.newUsername
        newPassword = frmAddUserBox.newPassword
        newLevel = frmAddUserBox.newLevel

        listWriter(0) = newUsername
        listWriter(1) = StrDup(Len(newPassword), "*")
        listWriter(2) = newLevel

        newItem = New ListViewItem(listWriter)
        lstUsers.Items.Add(newItem)

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
            lstUsers.MultiSelect = False
            updateList()
        End If
    End Sub

    Function updateList()

        Dim eofcheck As String
        Dim listWriter(3) As String

        Dim newItem As ListViewItem

        lstUsers.Items.Clear()

        Using fileread As New StreamReader(frmLogin.userStorePath, True)
            While True
                eofcheck = fileread.ReadLine()
                If eofcheck Is Nothing Then
                    Exit While
                Else
                    listWriter(0) = Decrypt(eofcheck)
                    listWriter(1) = StrDup(Len(Decrypt(fileread.ReadLine())), "*")
                    listWriter(2) = Decrypt(fileread.ReadLine())

                    newItem = New ListViewItem(listWriter)
                    lstUsers.Items.Add(newItem)
                End If
            End While
        End Using
    End Function

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        Dim targetUsername As String

        Dim readUsername As String
        Dim readPassword As String
        Dim readPrivelige As String

        Dim writeList As New List(Of String)

        MsgBox(lstUsers.Items(deleteIndex).Text)

        targetUsername = lstUsers.Items(deleteIndex).Text

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

    Private Sub lstUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsers.SelectedIndexChanged
        For Each itm As ListViewItem In lstUsers.SelectedItems
            If itm.Selected Then
                deleteIndex = itm.Index
            End If
        Next

        MsgBox(deleteIndex)

    End Sub
End Class