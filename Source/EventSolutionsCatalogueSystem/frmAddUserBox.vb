Public Class frmAddUserBox

    Public newUsername As String
    Public newPassword As String
    Public newLevel As String
    Public frmAccepted As Boolean

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        newUsername = txtUsername.Text
        newPassword = txtPassword.Text
        newLevel = cmbAccessLevel.Text

        frmAccepted = True
        Me.Close()
    End Sub

    Private Sub frmAddUserBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmAccepted = False
    End Sub
End Class