Module Module1

    Sub Main()
        Dim alpha, str1 As String
        Dim count As Integer
        Dim pangram As Boolean

        alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        str1 = ""
        count = 0
        pangram = False

        Console.WriteLine("Enter the string to be checked: ")
        str1 = Console.ReadLine
        str1 = UCase(str1)
        If Len(str1) >= 26 Then
            pangram = True
            For count = 1 To 26
                If InStr(str1, Mid(alpha, count, 1)) = 0 Then
                    pangram = False
                End If
            Next
        End If
        If pangram = True Then
            Console.WriteLine("the entered string is a pangram")
        Else
            Console.WriteLine("the entered string is not a pangram")
        End If
        Console.ReadKey()
    End Sub

End Module

