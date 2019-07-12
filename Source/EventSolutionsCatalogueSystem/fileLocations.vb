Public Module fileLocations
    Public evRootPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\EventSolutions"
    Public clientStoreLocation As String = "\clientstore\"
    Public equipmentStoreLocation As String = "\equipmentstore\"
    Public hireStoreLocation As String = "\hirestore\"
    Public settingsStoreLocation As String = "\settings\settings.evdf"
End Module
