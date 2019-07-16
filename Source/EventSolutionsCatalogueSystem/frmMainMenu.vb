''''''''''''''''''''''''''''''''''''''
'  EventSolutions Catalogue System   '
'  (c) Mitchell Blaser, July 2019.   '
'                                    '
'  frmMainMenu.vb                    '
'  Form which handles launching the  '
'    various tasks of the solution.  '
'    because we use two forms, with  '
'    panels to show the different    '
'    entry/view options, we have a   '
'    selectedTask variable that      '
'    holds the currently selected    '
'    activity.                       '
''''''''''''''''''''''''''''''''''''''

Public Class frmMainMenu 'Make the form's class
    Public selectedTask As String 'Declare the variable and make it public. We don't have to give it an initial value because it can't possibly be used until a button is clicked.
    Private Sub btnAddClient_Click(sender As Object, e As EventArgs) Handles btnAddClient.Click
        selectedTask = "AddClient" 'Set selectedTask to the relevant value
        frmDataEntry.Show() 'Show the relevant form
        Me.Hide() 'Hide the main menu form, but don't close it. We need selectedTask still so it has to stay open in the background.
    End Sub

    Private Sub btnAddEquipment_Click(sender As Object, e As EventArgs) Handles btnAddEquipment.Click
        selectedTask = "AddEquipment"
        frmDataEntry.Show()                     'Show the relevant form. 
        Me.Hide()                               'Hide the main menu form, but don't close it. We need selectedTask still so it has to stay open in the background.
    End Sub

    Private Sub btnAddHire_Click(sender As Object, e As EventArgs) Handles btnAddHire.Click
        selectedTask = "AddHire"                'Set selectedTask to the relevant value
        frmDataEntry.Show()                     'Show the relevant form. 
        Me.Hide()                               'Hide the main menu form, but don't close it. We need selectedTask still so it has to stay open in the background.
    End Sub

    Private Sub btnViewData_Click(sender As Object, e As EventArgs) Handles btnViewData.Click
        selectedTask = "ViewData"               'Set selectedTask to the relevant value
        frmDataView.Show()                      'Show the relevant form. 
        Me.Hide()                               'Hide the main menu form, but don't close it. We need selectedTask still so it has to stay open in the background.
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()                              'Close the main menu form.
        frmLogin.Show()                         'Show the login form.
        frmLogin.txtUser.Text = ""              'Set the login form's text boxes to be blank again. 
        frmLogin.txtPass.Text = ""              'If we didn't do that they would still have text and the user would have to clear it manually.
        frmLogin.txtUser.Focus()                'Focus the username text box (the first thing people will want to type into)
    End Sub

    Private Sub btnEditUsers_Click(sender As Object, e As EventArgs) Handles btnEditUsers.Click
        frmEditUsers.Show()                     'Show the relevant form. 
        Me.Hide()                               'Hide the main menu form, but don't close it. We need selectedTask still so it has to stay open in the background.
    End Sub
End Class