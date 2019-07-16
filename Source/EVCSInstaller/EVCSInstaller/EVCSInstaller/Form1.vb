Imports System.IO

Public Class frmInstaller

    Function GetByteArrayFromIcon(ByVal icoSource As Icon) As Byte()
        Dim msIcon As System.IO.MemoryStream

        msIcon = New System.IO.MemoryStream

        icoSource.Save(msIcon)

        Return msIcon.ToArray
    End Function

    Dim installDir As String
    Dim filecontent() As Byte

    Private Sub chkAdvancedOptions_CheckedChanged(sender As Object, e As EventArgs) Handles chkAdvancedOptions.CheckedChanged
        If chkAdvancedOptions.Checked = True Then
            pnlAdvancedOptions.Show()
        Else
            pnlAdvancedOptions.Hide()
        End If
    End Sub

    Private Sub frmInstaller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        installDir = Environ("USERPROFILE") & "\AppData\Roaming"
        txtLocation.Text = installDir & "\EventSolutions"
    End Sub

    Private Sub btnLocateFolder_Click(sender As Object, e As EventArgs) Handles btnLocateFolder.Click
        dlgSaveDirectory.ShowDialog()
        installDir = dlgSaveDirectory.SelectedPath
        txtLocation.Text = installDir & "\EventSolutions"
    End Sub

    Private Sub btnInstall_Click(sender As Object, e As EventArgs) Handles btnInstall.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtLocation.Text = "" Then
            MsgBox("Entries are missing.")
        Else
            prgBar.Value = 5
        End If
        If Directory.Exists(installDir) Then
            prgBar.Value = prgBar.Value + 5

            My.Computer.FileSystem.CreateDirectory(installDir & "\EventSolutions")
            prgBar.Value = prgBar.Value + 5
            My.Computer.FileSystem.CreateDirectory(installDir & "\EventSolutions\clientstore")
            prgBar.Value = prgBar.Value + 5
            My.Computer.FileSystem.CreateDirectory(installDir & "\EventSolutions\equipmentstore")
            prgBar.Value = prgBar.Value + 5
            My.Computer.FileSystem.CreateDirectory(installDir & "\EventSolutions\hirestore")
            prgBar.Value = prgBar.Value + 5
            My.Computer.FileSystem.CreateDirectory(installDir & "\EventSolutions\settings")
            prgBar.Value = prgBar.Value + 5
            My.Computer.FileSystem.CreateDirectory(installDir & "\EventSolutions\userstore")
            prgBar.Value = prgBar.Value + 5
            My.Computer.FileSystem.CreateDirectory(installDir & "\EventSolutions\appdata")
            prgBar.Value = prgBar.Value + 5

            If File.Exists(installDir & "\EventSolutions\settings\settings.evdf") Then
                My.Computer.FileSystem.DeleteFile(installDir & "\EventSolutions\settings\settings.evdf")
                prgBar.Value = prgBar.Value + 5
            End If
            Using writefile As New StreamWriter(installDir & "\EventSolutions\settings\settings.evdf", True)
                writefile.WriteLine(nudEquipment.Value)
                prgBar.Value = prgBar.Value + 5
                writefile.WriteLine(nudClient.Value)
                prgBar.Value = prgBar.Value + 5
                writefile.WriteLine(nudHire.Value)
                prgBar.Value = prgBar.Value + 5
                writefile.WriteLine(nudCalendar.Value)
                prgBar.Value = prgBar.Value + 5
            End Using

            filecontent = System.Text.Encoding.Unicode.GetBytes(My.Resources.README)
            prgBar.Value = prgBar.Value + 5
            My.Computer.FileSystem.WriteAllBytes(installDir & "\EventSolutions\settings\README.txt", filecontent, True)
            prgBar.Value = prgBar.Value + 5

            Using filewrite As New StreamWriter(installDir & "\EventSolutions\userstore\userstore.txt", True)
                filewrite.WriteLine(Encrypt(txtUsername.Text))
                prgBar.Value = prgBar.Value + 5
                filewrite.WriteLine(Encrypt(txtPassword.Text))
                prgBar.Value = prgBar.Value + 5
                filewrite.WriteLine(Encrypt("Administrator"))
                prgBar.Value = prgBar.Value + 5
            End Using

            filecontent = GetByteArrayFromIcon(My.Resources.icon)
            prgBar.Value = prgBar.Value + 5
            My.Computer.FileSystem.WriteAllBytes(installDir & "\EventSolutions\appdata\evico.ico", filecontent, True)
            prgBar.Value = prgBar.Value + 5

            filecontent = My.Resources.EventSolutionsCatalogueSystem
            prgBar.Value = prgBar.Value + 5
            My.Computer.FileSystem.WriteAllBytes(installDir & "\EventSolutions\appdata\EventSolutionsCatalogueSystem.exe", filecontent, True)
            prgBar.Value = prgBar.Value + 5

            'Write shortcut. Modified from https://bytescout.com/blog/create-shortcuts-in-c-and-vbnet.html
            Dim objShell, strPath, objLink
            prgBar.Value = prgBar.Value + 5
            objShell = CreateObject("Wscript.Shell")
            prgBar.Value = prgBar.Value + 5
            strPath = "C:\ProgramData\Microsoft\Windows\Start Menu"
            prgBar.Value = prgBar.Value + 5
            objLink = objShell.CreateShortcut(strPath & "\EVCS.lnk")
            prgBar.Value = prgBar.Value + 5
            objLink.TargetPath = installDir & "\EventSolutions\appdata\EventSolutionsCatalogueSystem.exe"
            prgBar.Value = prgBar.Value + 5
            objLink.IconLocation = installDir & "\EventSolutions\appdata\evico.ico"
            prgBar.Value = prgBar.Value + 5
            objLink.Save()
            prgBar.Value = prgBar.Value + 5

            MsgBox("Install complete.")

        Else
            MsgBox("The directory does not exist.")
            prgBar.Value = 0
        End If
    End Sub
End Class
