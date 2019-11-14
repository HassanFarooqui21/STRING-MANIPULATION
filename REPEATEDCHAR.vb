Module Module1

    Sub Main()
        Dim Str1, Xb, FinalChar, Str2, RepStr As String
        Dim Char1, AlphaB, Count As Integer

        Str1 = ""
        Xb = ""
        FinalChar = ""
        Str2 = ""
        RepStr = ""

        Char1 = 0
        AlphaB = 1
        Count = 0

        Console.Write("Enter the following string: ")
        Str1 = Console.ReadLine

        Str1 = UCase(Str1)

        If Len(Str1) < 1 Then
            Console.Write("you've entered an invalid string")
        End If

        For Count = 1 To Len(Str1)
            Xb = Mid(Str1, Count, 1)
            If Xb = " " Then
                Xb = ""
            End If
            RepStr = RepStr & Xb
        Next
        Str1 = RepStr

        If Str1 <> "" Then
            For Count = 1 To Len(Str1)
                Str2 = Str1
                Xb = Mid(Str1, Count, 1)
                Do Until InStr(Str2, Xb) = 0
                    Char1 = Char1 + 1
                    Str2 = Left(Str2, InStr(Str2, Xb) - 1) & Right(Str2, Len(Str2) - InStr(Str2, Xb))
                Loop
                If Char1 > AlphaB Then
                    FinalChar = Xb
                End If
                AlphaB = Char1
                Char1 = 0
            Next

            If FinalChar <> "" Then
                Console.WriteLine("Highest Repeated Character is: " & FinalChar)
            End If
        End If

        Console.ReadKey()
    End Sub

End Module
