Public Class FormStart

    ' Switches to the next form
    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        FormSetup.Show()
        Me.Hide()
    End Sub

End Class