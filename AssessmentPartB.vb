Module Module1

    Sub Main()
        Dim Str1, Str2, NEXTChar As String
        Dim COUNT, BINARYNUM, DENARYNUM As Integer
        Dim validBinaryString As Boolean

        Str1 = ""
        Str2 = ""
        NEXTChar = ""
        COUNT = 0
        BINARYNUM = 0
        DENARYNUM = 0
        validBinaryString = True

        Console.Write("Enter a Binary Number: ")
        Str1 = Console.ReadLine

        If validBinaryString = True Then

            For COUNT = 1 To Len(Str1)
                Str2 = Mid(Str1, COUNT, 1) & Str2
            Next

            For COUNT = 1 To Len(Str2)
                NEXTChar = Mid(Str2, COUNT, 1)
                BINARYNUM = 0
                If NEXTChar = "1" Then
                    BINARYNUM = 1
                End If

                If COUNT = 1 Then
                    DENARYNUM = DENARYNUM + BINARYNUM
                End If

                If COUNT = 2 Then
                    DENARYNUM = DENARYNUM + BINARYNUM * (2 * 1)
                End If

                If COUNT = 3 Then
                    DENARYNUM = DENARYNUM + BINARYNUM * (2 * 2)
                End If

                If COUNT = 4 Then
                    DENARYNUM = DENARYNUM + BINARYNUM * (2 * 2 * 2)
                End If

                If COUNT = 5 Then
                    DENARYNUM = DENARYNUM + BINARYNUM * (2 * 2 * 2 * 2)
                End If

                If COUNT = 6 Then
                    DENARYNUM = DENARYNUM + BINARYNUM * (2 * 2 * 2 * 2 * 2)
                End If

                If COUNT = 7 Then
                    DENARYNUM = DENARYNUM + BINARYNUM * (2 * 2 * 2 * 2 * 2 * 2)
                End If

                If COUNT = 8 Then
                    DENARYNUM = DENARYNUM + BINARYNUM * (2 * 2 * 2 * 2 * 2 * 2 * 2)
                End If
            Next

            Console.WriteLine(Str1 & " = " & DENARYNUM)
        End If

        Console.ReadKey()

    End Sub

End Module
