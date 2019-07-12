Public Class frmDataView
    Private Sub btnFile_Click(sender As Object, e As EventArgs) Handles btnFile.Click
        pnlFile.Visible = True
        pnlSearchSort.Visible = False
        pnlView.Visible = False

        btnFile.BackColor = Color.FromArgb(255, 16, 181, 232)
        btnSearchSort.BackColor = Color.FromArgb(255, 25, 118, 210)
        btnView.BackColor = Color.FromArgb(255, 25, 118, 210)

    End Sub

    Private Sub btnSearchSort_Click(sender As Object, e As EventArgs) Handles btnSearchSort.Click
        pnlFile.Visible = False
        pnlSearchSort.Visible = True
        pnlView.Visible = False

        btnFile.BackColor = Color.FromArgb(255, 25, 118, 210)
        btnSearchSort.BackColor = Color.FromArgb(255, 16, 181, 232)
        btnView.BackColor = Color.FromArgb(255, 25, 118, 210)

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        pnlFile.Visible = False
        pnlSearchSort.Visible = False
        pnlView.Visible = True

        btnFile.BackColor = Color.FromArgb(255, 25, 118, 210)
        btnSearchSort.BackColor = Color.FromArgb(255, 25, 118, 210)
        btnView.BackColor = Color.FromArgb(255, 16, 181, 232)

    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub


End Class