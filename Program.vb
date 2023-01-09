Imports System

Module Program
    Sub Main()


        Dim CardValue As ArrayList = New ArrayList({"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"})


        Dim itemlist As New List(Of String)

        itemlist.AddRange({"K", "7", "3", "9", "3"})
        Dim output As New ArrayList

        Dim groups = itemlist.GroupBy(Function(value) value)
        If Not groups.Count = 5 Then
            For Each grp In groups
                If grp.Count > 1 Then
                    output.Add(CardValue.IndexOf(grp(0)))

                End If
            Next
            Console.WriteLine("[true - """ & CardValue(output.ToArray.Max) & """]")
        Else
            Console.WriteLine("false")
        End If

        If (Console.ReadLine() = "exit") Then
            Environment.Exit(0)
        End If

    End Sub


End Module
