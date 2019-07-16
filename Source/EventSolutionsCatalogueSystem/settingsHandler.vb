''''''''''''''''''''''''''''''''''''''
'  EventSolutions Catalogue System   '
'  (c) Mitchell Blaser, July 2019.   '
'                                    '
'  settingsHandler.vb                '
'  Module which reads in settings    '
'    from the settings file and      '
'    gives other classes access      '
'    to the user-defined settings.   '
''''''''''''''''''''''''''''''''''''''

Imports System.IO 'Import the Input/Output stuff. Specifically, we're using StreamReader/StreamWriter.

Module settingsHandler 'Make the new module
    'Declare private variables. Don't give them a value.
    Dim _equipmentSize As Integer
    Dim _clientSize As Integer
    Dim _hireSize As Integer
    Dim _calendarSize As Integer

    Function equipmentStoreSize() As Integer 'Read in four lines of settings into the private variables
        Using fileread As New StreamReader(evRootPath & settingsStoreLocation, True) 'with a new instance of a StreamWriter pointed to the settings path.
            _equipmentSize = fileread.ReadLine()
            _clientSize = fileread.ReadLine()
            _hireSize = fileread.ReadLine()
            _calendarSize = fileread.ReadLine()
        End Using 'Close the file and 
        Return _equipmentSize 'Return the relevant result for the function
    End Function

    Function clientStoreSize() As Integer 'Read in four lines of settings into the private variables
        Using fileread As New StreamReader(evRootPath & settingsStoreLocation, True) 'with a new instance of a StreamWriter pointed to the settings path. 
            _equipmentSize = fileread.ReadLine()
            _clientSize = fileread.ReadLine()
            _hireSize = fileread.ReadLine()
            _calendarSize = fileread.ReadLine()
        End Using 'Close the file and
        Return _clientSize 'Return the relevant result for the function
    End Function

    Function hireStoreSize() As Integer 'Read in four lines of settings into the private variables
        Using fileread As New StreamReader(evRootPath & settingsStoreLocation, True) 'with a new instance of a StreamWriter pointed to the settings path.
            _equipmentSize = fileread.ReadLine()
            _clientSize = fileread.ReadLine()
            _hireSize = fileread.ReadLine()
            _calendarSize = fileread.ReadLine()
        End Using 'Close the file and 
        Return _hireSize 'Return the relevant result for the function
    End Function

    Function calendarStoreSize() As Integer 'Read in four lines of settings into the private variables
        Using fileread As New StreamReader(evRootPath & settingsStoreLocation, True) 'with a new instance of a StreamWriter pointed to the settings path.
            _equipmentSize = fileread.ReadLine()
            _clientSize = fileread.ReadLine()
            _hireSize = fileread.ReadLine()
            _calendarSize = fileread.ReadLine()
        End Using 'Close the file and 
        Return _calendarSize 'Return the relevant result for the function
    End Function

End Module
