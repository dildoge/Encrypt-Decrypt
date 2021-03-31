Public Class Cryptography
    Protected original_Text As String, results_Text As String, Length_Text As Long
    Public Function Cryptographic_encryption(ByVal Text As String) As String
        Dim Pos As Long, character_encryption, text_encryption
        original_Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890?!@#$%^&*()_+|;:,'.-`~"
        results_Text = "?!@#$%^&*()_+|;:,'.-`~1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
        For Me.Length_Text = 1 To Len(Text)
            Pos = InStr(original_Text, Mid(Text, Length_Text, 1))
            If Pos > 0 Then
                character_encryption = Mid(results_Text, Pos, 1)

                text_encryption = text_encryption + character_encryption
            Else
                text_encryption = text_encryption + Mid(Text, Length_Text, 1)
            End If
        Next
        Cryptographic_encryption = text_encryption
    End Function
    Public Function Cryptographic_decryption(ByVal Text As String) As String
        Dim Pos As Long, character_decryption, text_decryption
        results_Text = "?!@#$%^&*()_+|;:,'.-`~1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
        original_Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890?!@#$%^&*()_+|;:,'.-`~"
        For Me.Length_Text = 1 To Len(Text)
            Pos = InStr(results_Text, Mid(Text, Length_Text, 1))
            If Pos > 0 Then
                character_decryption = Mid(original_Text, Pos, 1)
                text_decryption = text_decryption + character_decryption
            Else
                text_decryption = text_decryption + Mid(Text, Length_Text, 1)
            End If
        Next
        Cryptographic_decryption = text_decryption
    End Function
End Class
