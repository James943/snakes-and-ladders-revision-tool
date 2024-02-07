Public Class FormSUVAT

    ' If the CheckEntered function is ok, then the Calculate sub is called.
    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        LabelAnswer.Text = ""
        If CheckEntered() = True Then
            Calculate()
        End If
    End Sub

    ' The contents of the 5 textboxes are checked, and only if values are entered as stated in the instructions will the function return true and the answer calculated.
    Private Function CheckEntered()
        Dim NumberOfValues As Integer
        Dim NumberOfXs As Integer
        Dim NumberOfQuestionMarks As Integer
        If IsNumeric(TextBoxS.Text) Then
            NumberOfValues += 1
        ElseIf TextBoxS.Text.ToUpper = "X" Then
            NumberOfXs += 1
        ElseIf TextBoxS.Text = "?" Then
            NumberOfQuestionMarks += 1
        End If
        If IsNumeric(TextBoxU.Text) Then
            NumberOfValues += 1
        ElseIf TextBoxU.Text.ToUpper = "X" Then
            NumberOfXs += 1
        ElseIf TextBoxU.Text = "?" Then
            NumberOfQuestionMarks += 1
        End If
        If IsNumeric(TextBoxV.Text) Then
            NumberOfValues += 1
        ElseIf TextBoxV.Text.ToUpper = "X" Then
            NumberOfXs += 1
        ElseIf TextBoxV.Text = "?" Then
            NumberOfQuestionMarks += 1
        End If
        If IsNumeric(TextBoxA.Text) Then
            NumberOfValues += 1
        ElseIf TextBoxA.Text.ToUpper = "X" Then
            NumberOfXs += 1
        ElseIf TextBoxA.Text = "?" Then
            NumberOfQuestionMarks += 1
        End If
        If IsNumeric(TextBoxT.Text) Then
            NumberOfValues += 1
        ElseIf TextBoxT.Text.ToUpper = "X" Then
            NumberOfXs += 1
        ElseIf TextBoxT.Text = "?" Then
            NumberOfQuestionMarks += 1
        End If
        If NumberOfValues <> 3 Or NumberOfXs <> 1 Or NumberOfQuestionMarks <> 1 Then
            MessageBox.Show("Please enter exactly 3 known values, 1 X in the value that is not used, and 1 ? in the value that you are trying to calculate")
            Return False
        Else
            Return True
        End If
    End Function

    ' An appropriate SUVAT formula is chosen based of which textboxes had the ? and X in, and the answer is calculated using the formula and the values in the 3 other textboxes.
    Private Sub Calculate()
        If TextBoxS.Text = "?" Then
            If TextBoxU.Text.ToUpper = "X" Then
                LabelAnswer.Text = "s = " & Val(TextBoxV.Text) * Val(TextBoxT.Text) - 0.5 * Val(TextBoxA.Text) * Val(TextBoxT.Text) ^ 2 & " m"
            ElseIf TextBoxV.Text.ToUpper = "X" Then
                LabelAnswer.Text = "s = " & Val(TextBoxU.Text) * Val(TextBoxT.Text) + 0.5 * Val(TextBoxA.Text) * Val(TextBoxT.Text) ^ 2 & " m"
            ElseIf TextBoxA.Text.ToUpper = "X" Then
                LabelAnswer.Text = "s = " & Val(TextBoxT.Text) / 2 * (Val(TextBoxU.Text) + Val(TextBoxV.Text)) & " m"
            Else
                LabelAnswer.Text = "s = " & (Val(TextBoxU.Text) ^ 2 + Val(TextBoxV.Text) ^ 2) / (2 * Val(TextBoxA.Text)) & " m"
            End If
        ElseIf TextBoxU.Text = "?" Then
            If TextBoxS.Text.ToUpper = "X" Then
                LabelAnswer.Text = "u = " & Val(TextBoxV.Text) - Val(TextBoxA.Text) * Val(TextBoxT.Text) & " ms^-1"
            ElseIf TextBoxV.Text.ToUpper = "X" Then
                LabelAnswer.Text = "u = " & (Val(TextBoxS.Text) - Val(TextBoxA.Text) * Val(TextBoxT.Text) ^ 2) / (2 * Val(TextBoxT.Text)) & " ms^-1"
            ElseIf TextBoxA.Text.ToUpper = "X" Then
                LabelAnswer.Text = "u = " & (2 * Val(TextBoxS.Text)) / Val(TextBoxT.Text) + Val(TextBoxV.Text) & " ms^-1"
            Else
                LabelAnswer.Text = "u = " & ((2 * Val(TextBoxA.Text) * Val(TextBoxS.Text)) - Val(TextBoxV.Text) ^ 2) ^ 0.5 & " ms^-1"
            End If
        ElseIf TextBoxV.Text = "?" Then
            If TextBoxS.Text.ToUpper = "X" Then
                LabelAnswer.Text = "v = " & Val(TextBoxU.Text) + Val(TextBoxA.Text) * Val(TextBoxT.Text) & " ms^-1"
            ElseIf TextBoxU.Text.ToUpper = "X" Then
                LabelAnswer.Text = "v = " & (Val(TextBoxS.Text) + Val(TextBoxA.Text) * Val(TextBoxT.Text) ^ 2) / (2 * Val(TextBoxT.Text)) & " ms^-1"
            ElseIf TextBoxA.Text.ToUpper = "X" Then
                LabelAnswer.Text = "v = " & (2 * Val(TextBoxS.Text)) / Val(TextBoxT.Text) - Val(TextBoxU.Text) & " ms^-1"
            Else
                LabelAnswer.Text = "v = " & (Val(TextBoxU.Text) ^ 2 + (2 * Val(TextBoxA.Text) * Val(TextBoxS.Text))) ^ 0.5 & " ms^-1"
            End If
        ElseIf TextBoxA.Text = "?" Then
            If TextBoxS.Text.ToUpper = "X" Then
                LabelAnswer.Text = "a = " & (Val(TextBoxV.Text) - Val(TextBoxU.Text)) / Val(TextBoxT.Text) & " ms^-2"
            ElseIf TextBoxU.Text.ToUpper = "X" Then
                LabelAnswer.Text = "a = " & (2 * (Val(TextBoxV.Text) * Val(TextBoxT.Text) - Val(TextBoxS.Text))) / Val(TextBoxT.Text) ^ 2 & " ms^-2"
            ElseIf TextBoxV.Text.ToUpper = "X" Then
                LabelAnswer.Text = "a = " & (2 * (Val(TextBoxS.Text) - Val(TextBoxU.Text) * Val(TextBoxT.Text))) / Val(TextBoxT.Text) ^ 2 & " ms^-2"
            Else
                LabelAnswer.Text = "a = " & (Val(TextBoxV.Text) ^ 2 - Val(TextBoxU.Text) ^ 2) / (2 * Val(TextBoxS.Text)) & " ms^-2"
            End If
        Else
            If TextBoxS.Text.ToUpper = "X" Then
                LabelAnswer.Text = "t = " & (Val(TextBoxV.Text) - Val(TextBoxU.Text)) / Val(TextBoxA.Text) & " s"
            ElseIf TextBoxU.Text.ToUpper = "X" Then
                LabelAnswer.Text = "t = " & (Val(TextBoxV.Text) - (Val(TextBoxV.Text) ^ 2 - (2 * Val(TextBoxA.Text) * Val(TextBoxS.Text))) ^ 0.5) / Val(TextBoxA.Text) & " s"
            ElseIf TextBoxV.Text.ToUpper = "X" Then
                LabelAnswer.Text = "t = " & ((2 * Val(TextBoxA.Text) * Val(TextBoxS.Text) + Val(TextBoxU.Text) ^ 2) ^ 0.5 - Val(TextBoxU.Text)) / Val(TextBoxA.Text) & " s"
            Else
                LabelAnswer.Text = "t = " & (2 * Val(TextBoxS.Text)) / (Val(TextBoxU.Text) + Val(TextBoxV.Text)) & " s"
            End If
        End If
        LabelAnswer.Visible = True
    End Sub

    ' Closes the form when this is pressed.
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

End Class