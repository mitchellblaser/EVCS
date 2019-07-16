''''''''''''''''''''''''''''''''''''''
'  EventSolutions Catalogue System   '
'  (c) Mitchell Blaser, July 2019.   '
'                                    '
'  fileLocations.vb                  '
'  A store for some constants which  '
'    hold the positions of the file  '
'    store paths in the system.      '
''''''''''''''''''''''''''''''''''''''

Public Module fileLocations
    Public evRootPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\EventSolutions"
    Public clientStoreLocation As String = "\clientstore\"
    Public equipmentStoreLocation As String = "\equipmentstore\"
    Public hireStoreLocation As String = "\hirestore\"
    Public settingsStoreLocation As String = "\settings\settings.evdf"
    Public userStoreLocation As String = "\userstore\userstore.txt"
End Module
