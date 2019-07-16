Module crypto
    Public Function Encrypt(ByVal value)

        Dim encIterator As Integer = 7

        Dim i As Integer = 0
        Dim valueLength As Integer = 0
        Dim encryptedOutput As String = ""

        valueLength = Len(value)

        While i < valueLength
            encryptedOutput = encryptedOutput & Chr(Asc(value(i)) + 7)

            i = i + 1
        End While

        Return encryptedOutput

    End Function

    Public Function Decrypt(ByVal value)

        Dim encIterator As Integer = 7

        Dim i As Integer = 0
        Dim valueLength As Integer = 0
        Dim decryptedOutput As String = ""

        valueLength = Len(value)

        While i < valueLength

            decryptedOutput = decryptedOutput & Chr(Asc(value(i)) - 7)

            i = i + 1
        End While

        Return decryptedOutput

    End Function
End Module
