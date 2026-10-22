Imports System.IO

Module Module1
    Dim file As String = "D:\Data Files\Division\Division.data"
    Dim count As Integer = 10

    Sub Main()

        Dim sw As New StreamWriter(file)

        For i As Integer = 0 To count
            For j As Integer = 1 To count + 1
                sw.WriteLine(i & "," & j & "=" & (i / j))
            Next
        Next

        sw.Close()

    End Sub

End Module
