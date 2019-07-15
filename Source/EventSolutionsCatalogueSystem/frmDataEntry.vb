﻿Imports System.IO

Public Class frmDataEntry
    Dim totalPrice As Integer
    Dim openDataPath As String = ""

    Structure equipmentRecord
        Dim equipmentName As String
        Dim equipmentManufacturer As String
        Dim equipmentQuantity As Integer
        Dim equipmentPrice As Integer
    End Structure

    Structure clientRecord
        Dim clientFirst As String
        Dim clientLast As String
        Dim clientPhone As String
        Dim clientEmail As String
        Dim clientAddress As String
    End Structure

    Dim equipmentRecords(equipmentStoreSize()) As equipmentRecord 'Initialize an array of equipmentRecord(s) with the size dictated in the file 'settings/settings.evdf' (SEE 'settings/README.txt').
    Dim clientRecords(clientStoreSize()) As clientRecord 'Initialize an array of clientRecord(s) with the size dictated in the file 'settings/settings.evdf' (SEE 'settings/README.txt').

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

    Private Sub frmDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pnlClient.Visible = False
        pnlEquipment.Visible = False
        pnlHire.Visible = False

        'Check which task has been selected.
        If frmMainMenu.selectedTask = "AddClient" Then
            pnlClient.Visible = True
        ElseIf frmMainMenu.selectedTask = "AddEquipment" Then
            pnlEquipment.Visible = True
        ElseIf frmMainMenu.selectedTask = "AddHire" Then
            pnlHire.Visible = True
            'Read all files in equipment directory
            Dim Eqdi As New DirectoryInfo(evRootPath & equipmentStoreLocation)
            Dim EqfileArray As FileInfo() = Eqdi.GetFiles()
            Dim i As Integer = 0 'Declare a counter to use in the loop below
            'Process them and load into a structure.
            For Each file In EqfileArray
                Using fileread As New StreamReader(evRootPath & equipmentStoreLocation & file.Name)
                    equipmentRecords(i).equipmentName = fileread.ReadLine()
                    equipmentRecords(i).equipmentManufacturer = fileread.ReadLine()
                    equipmentRecords(i).equipmentQuantity = fileread.ReadLine()
                    equipmentRecords(i).equipmentPrice = fileread.ReadLine()
                End Using
                cmbEquipment.Items.Add(equipmentRecords(i).equipmentName)
                i = i + 1
            Next
            'Read all files in client directory
            Dim Cldi As New DirectoryInfo(evRootPath & clientStoreLocation)
            Dim ClfileArray As FileInfo() = Cldi.GetFiles()
            i = 0
            'Process them and load into a structure.
            For Each file In ClfileArray
                Using fileread As New StreamReader(evRootPath & clientStoreLocation & file.Name)
                    clientRecords(i).clientFirst = fileread.ReadLine()
                    clientRecords(i).clientLast = fileread.ReadLine()
                    clientRecords(i).clientPhone = fileread.ReadLine()
                    clientRecords(i).clientEmail = fileread.ReadLine()
                    clientRecords(i).clientAddress = fileread.ReadLine()
                End Using
                cmbClient.Items.Add(clientRecords(i).clientFirst & " " & clientRecords(i).clientLast)
                i = i + 1
            Next
        End If
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub

    Private Sub imgSave_Click(sender As Object, e As EventArgs) Handles imgSave.Click
        If frmMainMenu.selectedTask = "AddEquipment" Then
            openDataPath = evRootPath & equipmentStoreLocation & Replace(Replace(txtName.Text, " ", ""), ".", "") & ".evdf"

            Try
                My.Computer.FileSystem.DeleteFile(openDataPath) 'We need to delete the file first so we don't write more than four lines to it. It's in a try/catch statement so that if its a new file it won't error out.
            Catch ex As Exception
            End Try

            Using filewrite As New StreamWriter(openDataPath, True)
                filewrite.WriteLine(txtName.Text)
                filewrite.WriteLine(txtManufacturer.Text)
                filewrite.WriteLine(numQuantity.Value)
                filewrite.WriteLine(numPricePerDay.Value)
            End Using
            MsgBox("Successfully saved.")
        ElseIf frmMainMenu.selectedTask = "AddClient" Then
            openDataPath = evRootPath & clientStoreLocation & txtFirstName.Text & txtNameLast.Text & "_" & txtEmail.Text & ".evdf"

            Try
                My.Computer.FileSystem.DeleteFile(openDataPath)
            Catch ex As Exception
            End Try

            Using filewrite As New StreamWriter(openDataPath, True)
                filewrite.WriteLine(txtFirstName.Text)
                filewrite.WriteLine(txtNameLast.Text)
                filewrite.WriteLine(txtPhone.Text)
                filewrite.WriteLine(txtEmail.Text)
                filewrite.WriteLine(txtAddress.Text)
            End Using
            MsgBox("Successfully saved.")
        ElseIf frmMainMenu.selectedTask = "AddHire" Then
            openDataPath = evRootPath & hireStoreLocation & Replace(dtpDateOut.Value.ToShortDateString, "/", "_") & "__" & Replace(cmbClient.SelectedItem, " ", "") & ".evdf"

            Try
                My.Computer.FileSystem.DeleteFile(openDataPath)
            Catch ex As Exception
            End Try
            Using filewrite As New StreamWriter(openDataPath, True)
                filewrite.WriteLine(cmbClient.SelectedItem)
                filewrite.WriteLine(dtpDateOut.Value)
                filewrite.WriteLine(dtpDateIn.Value)
                For i As Integer = 0 To lstEquipment.Items.Count - 1
                    filewrite.WriteLine(lstEquipment.Items(i))
                    filewrite.WriteLine(lstQuantity.Items(i))
                    filewrite.WriteLine(lstPrice.Items(i))
                Next
            End Using
            MsgBox("Successfully saved.")
        End If
    End Sub

    Private Sub imgNew_Click(sender As Object, e As EventArgs) Handles imgNew.Click
        If frmMainMenu.selectedTask = "AddEquipment" Then
            txtName.Focus()
            txtName.Text = ""
            txtManufacturer.Text = ""
            numQuantity.Value = 0
            numPricePerDay.Value = 0
        ElseIf frmMainMenu.selectedTask = "AddClient" Then
            txtFirstName.Focus()
            txtFirstName.Text = ""
            txtNameLast.Text = ""
            txtPhone.Text = ""
            txtEmail.Text = ""
            txtAddress.Text = ""
        ElseIf frmMainMenu.selectedTask = "AddHire" Then
            cmbClient.Focus()
            cmbClient.Text = ""
            cmbEquipment.Text = ""
            nudQuantity.Value = 0
            dtpDateIn.Value = Date.Now
            dtpDateOut.Value = Date.Now
            lstEquipment.Items.Clear()
            lstPrice.Items.Clear()
            lstQuantity.Items.Clear()
            totalPrice = 0
            calculateHireCost()
        End If
    End Sub

    Private Sub imgOpen_Click(sender As Object, e As EventArgs) Handles imgOpen.Click
        Dim equipmentLine As String
        Dim quantityLine As Integer
        Dim priceLine As Integer

        If frmMainMenu.selectedTask = "AddEquipment" Then
            dlgOpenRecord.InitialDirectory = evRootPath & equipmentStoreLocation
            dlgOpenRecord.ShowDialog()
            openDataPath = dlgOpenRecord.FileName

            Using fileread As New StreamReader(openDataPath)
                txtName.Focus() ' We have to focus a text box (or any other element) to change the value of a combo box, so we do this first.

                txtName.Text = fileread.ReadLine()
                txtManufacturer.Text = fileread.ReadLine()
                numQuantity.Value = fileread.ReadLine()
                numPricePerDay.Value = fileread.ReadLine()

            End Using

        ElseIf frmMainMenu.selectedTask = "AddClient" Then
            dlgOpenRecord.InitialDirectory = evRootPath & clientStoreLocation
            dlgOpenRecord.ShowDialog()
            openDataPath = dlgOpenRecord.FileName

            Using readfile As New StreamReader(openDataPath)
                txtName.Focus() 'Reset the user's view back to the first box for easy data entry

                txtFirstName.Text = readfile.ReadLine()
                txtNameLast.Text = readfile.ReadLine()
                txtPhone.Text = readfile.ReadLine()
                txtEmail.Text = readfile.ReadLine()
                txtAddress.Text = readfile.ReadLine()

            End Using

        ElseIf frmMainMenu.selectedTask = "AddHire" Then
            dlgOpenRecord.InitialDirectory = evRootPath & hireStoreLocation
            dlgOpenRecord.ShowDialog()

            openDataPath = dlgOpenRecord.FileName

            Using readfile As New StreamReader(openDataPath)
                cmbClient.Focus()
                cmbClient.Text = readfile.ReadLine()
                dtpDateOut.Value = readfile.ReadLine()
                dtpDateIn.Value = readfile.ReadLine()

                lstEquipment.Items.Clear()
                lstPrice.Items.Clear()
                lstQuantity.Items.Clear()

                While True
                    equipmentLine = readfile.ReadLine()
                    If equipmentLine Is Nothing Then
                        Exit While
                    Else
                        lstEquipment.Items.Add(equipmentLine)
                        quantityLine = readfile.ReadLine()
                        lstQuantity.Items.Add(quantityLine)
                        priceLine = readfile.ReadLine()
                        lstPrice.Items.Add(priceLine)
                        totalPrice = totalPrice + priceLine * quantityLine
                    End If
                End While
            End Using
            calculateHireCost()
        Else
            MsgBox("Oops! An error has occured. Please exit and try again.")
        End If
    End Sub

    Private Sub imgDelete_Click(sender As Object, e As EventArgs) Handles imgDelete.Click
        If frmMainMenu.selectedTask = "AddEquipment" Then
            My.Computer.FileSystem.DeleteFile(openDataPath)
            MsgBox("Successfully deleted.")
            txtName.Focus()

            txtName.Text = ""
            txtManufacturer.Text = ""
            numQuantity.Value = 0
            numPricePerDay.Value = 0
        ElseIf frmMainMenu.selectedTask = "AddClient" Then
            My.Computer.FileSystem.DeleteFile(openDataPath)
            MsgBox("Successfully deleted.")

            txtFirstName.Focus()
            txtFirstName.Text = ""
            txtNameLast.Text = ""
            txtPhone.Text = ""
            txtEmail.Text = ""
            txtAddress.Text = ""
        ElseIf frmMainMenu.selectedTask = "AddHire" Then
            cmbClient.Focus()
            cmbClient.Text = ""
            cmbEquipment.Text = ""
            nudQuantity.Value = 0
            dtpDateIn.Value = Date.Now
            dtpDateOut.Value = Date.Now
            lstEquipment.Items.Clear()
            lstPrice.Items.Clear()
            lstQuantity.Items.Clear()
            totalPrice = 0
            calculateHireCost()
            My.Computer.FileSystem.DeleteFile(openDataPath)
            MsgBox("Successfully deleted.")
        Else
            MsgBox("Oops! An error has occured. Please exit and try again.")
        End If
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click

        If nudQuantity.Value <= equipmentRecords(cmbEquipment.SelectedIndex).equipmentQuantity Then
            lstEquipment.Items.Add(equipmentRecords(cmbEquipment.SelectedIndex).equipmentName)
            lstQuantity.Items.Add(nudQuantity.Value)
            lstPrice.Items.Add(equipmentRecords(cmbEquipment.SelectedIndex).equipmentPrice * nudQuantity.Value)
            totalPrice = totalPrice + equipmentRecords(cmbEquipment.SelectedIndex).equipmentPrice * nudQuantity.Value

            calculateHireCost()
        Else
            MsgBox("You have exceded the amount of items you have in stock.")
        End If
    End Sub

    Private Sub dtpDateOut_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateOut.ValueChanged
        calculateHireCost()
    End Sub

    Private Sub dtpDateIn_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateIn.ValueChanged
        calculateHireCost()
    End Sub

    Function calculateHireCost()
        Dim totalDates = dtpDateIn.Value - dtpDateOut.Value
        Dim totalDays As Integer = totalDates.TotalHours
        totalDays = (totalDays / 24) + 1
        lblTotal.Text = "Total: $" & totalDays * totalPrice
    End Function

    Private Sub lstEquipment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEquipment.SelectedIndexChanged
        lstQuantity.SelectedIndex = lstEquipment.SelectedIndex
        lstPrice.SelectedIndex = lstEquipment.SelectedIndex
    End Sub

    Private Sub lstQuantity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstQuantity.SelectedIndexChanged
        lstEquipment.SelectedIndex = lstQuantity.SelectedIndex
        lstPrice.SelectedIndex = lstQuantity.SelectedIndex
    End Sub

    Private Sub lstPrice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPrice.SelectedIndexChanged
        lstEquipment.SelectedIndex = lstPrice.SelectedIndex
        lstQuantity.SelectedIndex = lstPrice.SelectedIndex
    End Sub
End Class