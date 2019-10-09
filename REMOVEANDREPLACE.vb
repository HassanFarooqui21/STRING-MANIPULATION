Module Module1

    Sub Main()
        Dim Str1, Str2, Char1, Char2, NextChar As String
        Dim Counter As Integer

        Str1 = ""
        Str2 = ""
        Char1 = ""
        Char2 = ""
        NextChar = ""
        Counter = 0

        Console.Write("Enter String: ")
        Str1 = Console.ReadLine

        Console.Write("Enter Character to remove: ")
        Char1 = Console.ReadLine

        Console.Write("Enter character to replace: ")
        Char2 = Console.ReadLine

        For Counter = 1 To Len(Str1)
            NextChar = Mid(Str1, Counter, 1)
            If NextChar = Char1 Then
                NextChar = Char2
            End If
            Str2 = Str2 & NextChar
        Next

        Console.WriteLine("Final String= " & Str2)
        Console.ReadKey()
    End Sub

End Module
