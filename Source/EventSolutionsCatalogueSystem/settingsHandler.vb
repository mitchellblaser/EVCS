Imports System.IO

Module settingsHandler
    Dim _equipmentSize As Integer
    Dim _clientSize As Integer
    Dim _hireSize As Integer
    Dim _calendarSize As Integer

    Function equipmentStoreSize() As Integer
        Using fileread As New StreamReader(evRootPath & settingsStoreLocation, True)
            _equipmentSize = fileread.ReadLine()
            _clientSize = fileread.ReadLine()
            _hireSize = fileread.ReadLine()
            _calendarSize = fileread.ReadLine()
        End Using
        Return _equipmentSize
    End Function

    Function clientStoreSize() As Integer
        Using fileread As New StreamReader(evRootPath & settingsStoreLocation, True)
            _equipmentSize = fileread.ReadLine()
            _clientSize = fileread.ReadLine()
            _hireSize = fileread.ReadLine()
            _calendarSize = fileread.ReadLine()
        End Using
        Return _clientSize
    End Function

    Function hireStoreSize() As Integer
        Using fileread As New StreamReader(evRootPath & settingsStoreLocation, True)
            _equipmentSize = fileread.ReadLine()
            _clientSize = fileread.ReadLine()
            _hireSize = fileread.ReadLine()
            _calendarSize = fileread.ReadLine()
        End Using
        Return _hireSize
    End Function

    Function calendarStoreSize() As Integer
        Using fileread As New StreamReader(evRootPath & settingsStoreLocation, True)
            _equipmentSize = fileread.ReadLine()
            _clientSize = fileread.ReadLine()
            _hireSize = fileread.ReadLine()
            _calendarSize = fileread.ReadLine()
        End Using
        Return _calendarSize
    End Function

End Module
