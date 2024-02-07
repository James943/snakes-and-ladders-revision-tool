Public Class Ladder

    Inherits Path

    ' Creates coordinate columns and rows for the selected board size, and finds 4 coordinates for the bottom and top of both sides of the ladder, using the bottom and top numbers inherited from the parent Path class. 2 straight lines are drawn for both sides of the ladder between the bottom and top using a random colour from a selection, creating one ladder.
    Public Sub Draw()
        Dim Column(8) As Integer
        Dim Row(16) As Integer
        Column(0) = 41
        For i = 0 To 7
            Column(i + 1) = Column(i) + 61
        Next
        If FormSetup.BoardSize = "Small" Then
            Row(0) = 432
            For j = 0 To 7
                Row(j + 1) = Row(j) - 32
            Next
        ElseIf FormSetup.BoardSize = "Medium" Then
            Row(0) = 492
            For j = 0 To 11
                Row(j + 1) = Row(j) - 32
            Next
        Else
            Row(0) = 553
            For j = 0 To 15
                Row(j + 1) = Row(j) - 32
            Next
        End If
        Dim PointBottem1 As Point
        Dim PointTop1 As Point
        Dim PointBottem2 As Point
        Dim PointTop2 As Point
        If BottomNumber < 9 Then
            PointBottem1 = New Point(Column(BottomNumber), Row(0))
        ElseIf BottomNumber = 9 Then
            PointBottem1 = New Point(Column(8), Row(1))
        ElseIf BottomNumber > 9 And BottomNumber < 19 Then
            PointBottem1 = New Point(Column(18 - BottomNumber), Row(2))
        ElseIf BottomNumber = 19 Then
            PointBottem1 = New Point(Column(0), Row(3))
        ElseIf BottomNumber > 19 And BottomNumber < 29 Then
            PointBottem1 = New Point(Column(BottomNumber - 20), Row(4))
        ElseIf BottomNumber = 29 Then
            PointBottem1 = New Point(Column(8), Row(5))
        ElseIf BottomNumber > 29 And BottomNumber < 39 Then
            PointBottem1 = New Point(Column(38 - BottomNumber), Row(6))
        ElseIf BottomNumber = 39 Then
            PointBottem1 = New Point(Column(0), Row(7))
        ElseIf BottomNumber > 39 And BottomNumber < 49 Then
            PointBottem1 = New Point(Column(BottomNumber - 40), Row(8))
        ElseIf BottomNumber = 49 Then
            PointBottem1 = New Point(Column(8), Row(9))
        ElseIf BottomNumber > 49 And BottomNumber < 59 Then
            PointBottem1 = New Point(Column(58 - BottomNumber), Row(10))
        ElseIf BottomNumber = 59 Then
            PointBottem1 = New Point(Column(0), Row(11))
        ElseIf BottomNumber > 59 And BottomNumber < 69 Then
            PointBottem1 = New Point(Column(BottomNumber - 60), Row(12))
        ElseIf BottomNumber = 69 Then
            PointBottem1 = New Point(Column(8), Row(13))
        ElseIf BottomNumber > 69 And BottomNumber < 79 Then
            PointBottem1 = New Point(Column(78 - BottomNumber), Row(14))
        Else
            PointBottem1 = New Point(Column(0), Row(15))
        End If
        If TopNumber = 9 Then
            PointTop1 = New Point(Column(8), Row(1))
        ElseIf TopNumber > 9 And TopNumber < 19 Then
            PointTop1 = New Point(Column(18 - TopNumber), Row(2))
        ElseIf TopNumber = 19 Then
            PointTop1 = New Point(Column(0), Row(3))
        ElseIf TopNumber > 19 And TopNumber < 29 Then
            PointTop1 = New Point(Column(TopNumber - 20), Row(4))
        ElseIf TopNumber = 29 Then
            PointTop1 = New Point(Column(8), Row(5))
        ElseIf TopNumber > 29 And TopNumber < 39 Then
            PointTop1 = New Point(Column(38 - TopNumber), Row(6))
        ElseIf TopNumber = 39 Then
            PointTop1 = New Point(Column(0), Row(7))
        ElseIf TopNumber > 39 And TopNumber < 49 Then
            PointTop1 = New Point(Column(TopNumber - 40), Row(8))
        ElseIf TopNumber = 49 Then
            PointTop1 = New Point(Column(8), Row(9))
        ElseIf TopNumber > 49 And TopNumber < 59 Then
            PointTop1 = New Point(Column(58 - TopNumber), Row(10))
        ElseIf TopNumber = 59 Then
            PointTop1 = New Point(Column(0), Row(11))
        ElseIf TopNumber > 59 And TopNumber < 69 Then
            PointTop1 = New Point(Column(TopNumber - 60), Row(12))
        ElseIf TopNumber = 69 Then
            PointTop1 = New Point(Column(8), Row(13))
        ElseIf TopNumber > 69 And TopNumber < 79 Then
            PointTop1 = New Point(Column(78 - TopNumber), Row(14))
        ElseIf TopNumber = 79 Then
            PointTop1 = New Point(Column(0), Row(15))
        Else
            PointTop1 = New Point(Column(TopNumber - 80), Row(16))
        End If
        PointBottem2 = New Point(PointBottem1.X + 20, PointBottem1.Y)
        PointTop2 = New Point(PointTop1.X + 20, PointTop1.Y)
        Dim Pen As Pen
        Dim RandomNumber As Integer
        Randomize()
        RandomNumber = Int(Rnd() * 5) + 1
        If RandomNumber <= 2 Then
            Pen = New Pen(Color.Beige, 2)
        ElseIf RandomNumber = 3 Then
            Pen = New Pen(Color.LavenderBlush, 2)
        ElseIf RandomNumber = 4 Then
            Pen = New Pen(Color.Gainsboro, 2)
        Else
            Pen = New Pen(Color.PeachPuff, 2)
        End If
        FormMain.PictureBoxBoard.CreateGraphics.DrawLine(Pen, PointBottem1, PointTop1)
        FormMain.PictureBoxBoard.CreateGraphics.DrawLine(Pen, PointBottem2, PointTop2)
    End Sub

End Class
