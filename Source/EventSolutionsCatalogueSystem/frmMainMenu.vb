Public Class frmMainMenu
    Public selectedTask As String
    Private Sub btnAddClient_Click(sender As Object, e As EventArgs) Handles btnAddClient.Click
        selectedTask = "AddClient"
        frmDataEntry.Show()
        Me.Close()
    End Sub

    Private Sub btnAddEquipment_Click(sender As Object, e As EventArgs) Handles btnAddEquipment.Click
        selectedTask = "AddEquipment"
        frmDataEntry.Show()
        Me.Close()
    End Sub

    Private Sub btnAddHire_Click(sender As Object, e As EventArgs) Handles btnAddHire.Click
        selectedTask = "AddHire"
        frmDataEntry.Show()
        Me.Close()
    End Sub

    Private Sub btnViewData_Click(sender As Object, e As EventArgs) Handles btnViewData.Click
        selectedTask = "ViewData"
        Me.Close()
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
        frmLogin.Show()
        frmLogin.txtUser.Text = ""
        frmLogin.txtPass.Text = ""
        frmLogin.txtUser.Focus()
    End Sub

    Private Sub btnEditUsers_Click(sender As Object, e As EventArgs) Handles btnEditUsers.Click
        frmEditUsers.Show()
    End Sub
End Class