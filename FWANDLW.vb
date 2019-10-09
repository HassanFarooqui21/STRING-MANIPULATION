Module Module1

    Sub Main()
        Dim Str1, Str2, Str3, firstWord, lastword As String
        Dim n As Integer

        Str1 = ""
        Str2 = ""
        Str3 = ""
        firstWord = ""
        lastword = ""
        n = 0

        Console.Write("Enter 1st String: ")
        Str1 = Console.ReadLine

        Console.Write("Enter 2nd String: ")
        Str2 = Console.ReadLine

        n = InStr(Str1, " ")
        firstWord = Left(Str1, n - 1)

        n = InStr(Str2, " ")
        lastword = Right(Str2, Len(Str2) - n)

        Str3 = firstWord & " " & lastword
        Console.WriteLine(Str3)

        Console.ReadKey()

    End Sub

End Module
