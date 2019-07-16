''''''''''''''''''''''''''''''''''''''
'  EventSolutions Catalogue System   '
'  (c) Mitchell Blaser, July 2019.   '
'                                    '
'  crypto.vb                         '
'  Module that handles the           '
'    encryption and decryption of    '
'    strings. Has two different      '
'    functions and returns the       '
'    result back to the calling      '
'    code.                           '
''''''''''''''''''''''''''''''''''''''

Module crypto                                                                           'Make the new module
    Public Function Encrypt(ByVal value)                                                'Make the encryption function. We use ByVal here because we don't need to change the variable's value.

        Dim encIterator As Integer = 7                                                  'This sets the amount to shift up the letters by.

        '                                                                               'Declare some variables needed for the encryption below.
        Dim i As Integer = 0
        Dim valueLength As Integer = 0
        Dim encryptedOutput As String = ""                                              'Start encrypted output as an empty string.

        valueLength = Len(value)                                                        'Get the length of the value that was passed into our function

        While i < valueLength                                                           'Loop i for each character until we reach the end of the string
            encryptedOutput = encryptedOutput & Chr(Asc(value(i)) + encIterator)        'EncryptedOutput gets the new encrypted character added onto it.
            '                                                                           'To get the encrypted character, we turn the char into it's ascii code, and add the value of encIterator to it. Then it gets bundled up again into a character and gets added to the string.

            i = i + 1                                                                   'Increment i by 1.
        End While

        Return encryptedOutput                                                          'Return the encrypted string to the calling code.

    End Function

    Public Function Decrypt(ByVal value)                                                'Make the decryption function. We use ByVal here because we don't need to change the variable's value.

        Dim encIterator As Integer = 7                                                  'This sets the amount to shift up the letters by. Must be the same as when the file was encrypted or it'll result in garbage data.

        '                                                                               'Declare some variables needed for the encryption below.
        Dim i As Integer = 0
        Dim valueLength As Integer = 0
        Dim decryptedOutput As String = ""                                              'Start decrypted output as an empty string.

        valueLength = Len(value)                                                        'Get the length of the value that was passed into our function

        While i < valueLength                                                           'Loop i for each character until we reach the end of the string

            decryptedOutput = decryptedOutput & Chr(Asc(value(i)) - encIterator)        'EncryptedOutput gets the new decrypted character added onto it.
            '                                                                           'To get the decrypted character, we turn the char into it's ascii code, and subtract the value of encIterator to it. Then it gets bundled up again into a character and gets added to the string.

            i = i + 1                                                                   'Increment i by 1.
        End While

        Return decryptedOutput                                                          'Return the encrypted string to the calling code.

    End Function
End Module
