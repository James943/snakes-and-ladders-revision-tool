Public Class Path

    Public BottomNumber As Integer
    Public TopNumber As Integer

    ' Randomly selects a number for the bottom of the snake/ladder on the selected size board, and then loops selecting a random top number until it is higher enough from the bottom number.
    Public Sub GetNumbers()
        Dim MaxSize As Integer
        If FormSetup.BoardSize = "Small" Then
            MaxSize = 39
        ElseIf FormSetup.BoardSize = "Medium" Then
            MaxSize = 59
        Else
            MaxSize = 79
        End If
        Randomize()
        BottomNumber = Int(Rnd() * MaxSize) + 1
        Do
            TopNumber = Int(Rnd() * MaxSize) + 9
        Loop Until TopNumber > (BottomNumber + 8)
    End Sub

End Class
