Module Module1

    Sub Main()
        Dim iNumber1 As Integer
        Dim iNumber2 As Integer
        Dim iBig As Integer
        Console.Write("Enter the first number: ")
        iNumber1 = Console.ReadLine
        Console.Write("Enter the second number: ")
        iNumber2 = Console.ReadLine
        If iNumber1 > iNumber2 Then
            iBig = iNumber1
        ElseIf iNumber1 < iNumber2 Then
            iBig = iNumber2
        End If
        Console.Write(iBig)
        Console.ReadKey()

    End Sub

End Module
