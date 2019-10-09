Module Module1

    Sub Main()
        Dim str, vowel As String
        Dim count, NoOfVowels As Integer

        str = ""
        vowel = "aeiou"
        count = 0
        NoOfVowels = 0

        Console.Write("Enter the string to be checked: ")
        str = Console.ReadLine

        str = LCase(str)

        For count = 1 To Len(str)
            If InStr(vowel, Mid(str, count, 1)) > 0 Then
                NoOfVowels = 1 + NoOfVowels

            End If
        Next

        Console.WriteLine("The No. of Vowels in the entered string is: " & NoOfVowels)
        Console.ReadKey()

    End Sub

End Module
