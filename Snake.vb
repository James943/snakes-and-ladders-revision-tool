Public Class Snake

    Inherits Path

    ' Creates coordinate columns and rows for the selected board size and finds the coordinates on the board for the bottom and top numbers of the snake, which where inherited from the parent Path class. 3 points in between the bottom and top point are randomly generated within a strict range to make the curve look like a snake. A random colour for the curve is determined from a selection, and then a curve is drawn through all 5 points, creating one snake.
    Public Sub Draw()
        Dim Column(8) As Integer
        Dim Row(16) As Integer
        Column(0) = 51
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
        Dim PointBottem As Point
        Dim PointLower As Point
        Dim PointMiddle As Point
        Dim PointUpper As Point
        Dim PointTop As Point
        If BottomNumber < 9 Then
            PointBottem = New Point(Column(BottomNumber), Row(0))
        ElseIf BottomNumber = 9 Then
            PointBottem = New Point(Column(8), Row(1))
        ElseIf BottomNumber > 9 And BottomNumber < 19 Then
            PointBottem = New Point(Column(18 - BottomNumber), Row(2))
        ElseIf BottomNumber = 19 Then
            PointBottem = New Point(Column(0), Row(3))
        ElseIf BottomNumber > 19 And BottomNumber < 29 Then
            PointBottem = New Point(Column(BottomNumber - 20), Row(4))
        ElseIf BottomNumber = 29 Then
            PointBottem = New Point(Column(8), Row(5))
        ElseIf BottomNumber > 29 And BottomNumber < 39 Then
            PointBottem = New Point(Column(38 - BottomNumber), Row(6))
        ElseIf BottomNumber = 39 Then
            PointBottem = New Point(Column(0), Row(7))
        ElseIf BottomNumber > 39 And BottomNumber < 49 Then
            PointBottem = New Point(Column(BottomNumber - 40), Row(8))
        ElseIf BottomNumber = 49 Then
            PointBottem = New Point(Column(8), Row(9))
        ElseIf BottomNumber > 49 And BottomNumber < 59 Then
            PointBottem = New Point(Column(58 - BottomNumber), Row(10))
        ElseIf BottomNumber = 59 Then
            PointBottem = New Point(Column(0), Row(11))
        ElseIf BottomNumber > 59 And BottomNumber < 69 Then
            PointBottem = New Point(Column(BottomNumber - 60), Row(12))
        ElseIf BottomNumber = 69 Then
            PointBottem = New Point(Column(8), Row(13))
        ElseIf BottomNumber > 69 And BottomNumber < 79 Then
            PointBottem = New Point(Column(78 - BottomNumber), Row(14))
        Else
            PointBottem = New Point(Column(0), Row(15))
        End If
        If TopNumber = 9 Then
            PointTop = New Point(Column(8), Row(1))
        ElseIf TopNumber > 9 And TopNumber < 19 Then
            PointTop = New Point(Column(18 - TopNumber), Row(2))
        ElseIf TopNumber = 19 Then
            PointTop = New Point(Column(0), Row(3))
        ElseIf TopNumber > 19 And TopNumber < 29 Then
            PointTop = New Point(Column(TopNumber - 20), Row(4))
        ElseIf TopNumber = 29 Then
            PointTop = New Point(Column(8), Row(5))
        ElseIf TopNumber > 29 And TopNumber < 39 Then
            PointTop = New Point(Column(38 - TopNumber), Row(6))
        ElseIf TopNumber = 39 Then
            PointTop = New Point(Column(0), Row(7))
        ElseIf TopNumber > 39 And TopNumber < 49 Then
            PointTop = New Point(Column(TopNumber - 40), Row(8))
        ElseIf TopNumber = 49 Then
            PointTop = New Point(Column(8), Row(9))
        ElseIf TopNumber > 49 And TopNumber < 59 Then
            PointTop = New Point(Column(58 - TopNumber), Row(10))
        ElseIf TopNumber = 59 Then
            PointTop = New Point(Column(0), Row(11))
        ElseIf TopNumber > 59 And TopNumber < 69 Then
            PointTop = New Point(Column(TopNumber - 60), Row(12))
        ElseIf TopNumber = 69 Then
            PointTop = New Point(Column(8), Row(13))
        ElseIf TopNumber > 69 And TopNumber < 79 Then
            PointTop = New Point(Column(78 - TopNumber), Row(14))
        ElseIf TopNumber = 79 Then
            PointTop = New Point(Column(0), Row(15))
        Else
            PointTop = New Point(Column(TopNumber - 80), Row(16))
        End If
        Randomize()
        PointLower = New Point((PointBottem.X) + (0.1 * (PointTop.X - PointBottem.X)) + (Int(Rnd() * (0.2 * (PointTop.X - PointBottem.X)))) + Extra(), (PointBottem.Y) - (0.1 * (PointBottem.Y - PointTop.Y)) - (Int(Rnd() * (0.2 * (PointBottem.Y - PointTop.Y)))) + Extra())
        PointMiddle = New Point((PointBottem.X) + (0.4 * (PointTop.X - PointBottem.X)) + (Int(Rnd() * (0.2 * (PointTop.X - PointBottem.X)))) + Extra(), (PointBottem.Y) - (0.4 * (PointBottem.Y - PointTop.Y)) - (Int(Rnd() * (0.2 * (PointBottem.Y - PointTop.Y)))) + Extra())
        PointUpper = New Point((PointBottem.X) + (0.7 * (PointTop.X - PointBottem.X)) + (Int(Rnd() * (0.2 * (PointTop.X - PointBottem.X)))) + Extra(), (PointBottem.Y) - (0.7 * (PointBottem.Y - PointTop.Y)) - (Int(Rnd() * (0.2 * (PointBottem.Y - PointTop.Y)))) + Extra())
        Dim Pen As Pen
        Dim RandomNumber As Integer
        Randomize()
        RandomNumber = Int(Rnd() * 9) + 1
        If RandomNumber <= 3 Then
            Pen = New Pen(Color.Green, GetSize)
        ElseIf RandomNumber = 4 Then
            Pen = New Pen(Color.DarkOliveGreen, GetSize)
        ElseIf RandomNumber = 5 Then
            Pen = New Pen(Color.OliveDrab, GetSize)
        ElseIf RandomNumber = 6 Then
            Pen = New Pen(Color.Teal, GetSize)
        ElseIf RandomNumber = 7 Then
            Pen = New Pen(Color.DarkSeaGreen, GetSize)
        ElseIf RandomNumber = 8 Then
            Pen = New Pen(Color.SeaGreen, GetSize)
        ElseIf RandomNumber = 9 Then
            Pen = New Pen(Color.YellowGreen, GetSize)
        Else
            Pen = New Pen(Color.DarkGoldenrod, GetSize)
        End If
        Dim curvePoints As Point() = {PointBottem, PointLower, PointMiddle, PointUpper, PointTop}
        FormMain.PictureBoxBoard.CreateGraphics.DrawCurve(Pen, curvePoints)
    End Sub

    ' Makes the in-between points a little more random, after I realised that before this was added, a snake whose bottom and top number share the same column, is drawn as a straight vertical line.
    Private Function Extra()
        Randomize()
        Dim RandomNumber As Integer
        Dim Multiplier As Integer
        RandomNumber = Int(Rnd() * 2) + 1
        If RandomNumber = 1 Then
            Multiplier = 1
        Else
            Multiplier = -1
        End If
        Return Multiplier * (Int(Rnd() * 10) + 10)
    End Function

    ' Gives the snake a random thickness within a suitable range.
    Private Function GetSize()
        Dim Size As Integer
        Size = Int(Rnd() * 10 + 5)
        Return Size
    End Function

End Class
