Module Module1

    Sub Main()

        Dim str1, str2, NEXTChar As String
        Dim COUNT As Integer
        Dim validBinaryString As Boolean

        str1 = ""
        str2 = ""
        NEXTChar = ""
        COUNT = 0
        validBinaryString = True

        Console.Write("Enter Binary Number: ")
        str1 = Console.ReadLine()

        If Len(str1) <= 8 And Len(str1) > 0 Then
            For COUNT = 1 To Len(str1)
                NEXTChar = Mid(str1, COUNT, 1)
                If NEXTChar <> "1" And NEXTChar <> "0" Then
                    validBinaryString = False
                End If

            Next
        Else : validBinaryString = False

        End If

        If validBinaryString = False Then
            Console.Write("Not a valid Binary Number.... ")
        End If

        Console.ReadKey()
    End Sub

End Module
