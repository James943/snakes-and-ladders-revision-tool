Public Class FormSetup

    Public ComputerDifficulty As String
    Public Player1UserID As Integer
    Public Player1FirstName As String
    Public Player2UserID As Integer
    Public Player2FirstName As String
    Public CreateButton As Integer
    Public BoardSize As String
    Private Counter1Selected As Boolean = False
    Private Counter2Selected As Boolean = False

    ' Enables, disables and highlights appropriate settings on the form when the user chooses to play against the computer.
    Private Sub ButtonComputer_Click(sender As Object, e As EventArgs) Handles ButtonComputer.Click
        Player2FirstName = "Computer"
        ButtonComputer.FlatAppearance.BorderColor = Color.Green
        ButtonPlayer.FlatAppearance.BorderColor = Color.Black
        ButtonEasy.Enabled = True
        ButtonNormal.Enabled = True
        ButtonHard.Enabled = True
        TextBoxUsername2.Enabled = False
        TextBoxUsername2.Text = ""
        TextBoxPassword2.Enabled = False
        TextBoxPassword2.Text = ""
        ButtonLogin2.Enabled = False
        ButtonCreate2.Enabled = False
    End Sub

    ' Enables, disables, and highlights appropriate settings on the form when the user chooses to play against another. An if statement is used becasue if player is aready logged in and presses this button again, it won't change their first name back to the non signed in name.
    Private Sub ButtonPlayer_Click(sender As Object, e As EventArgs) Handles ButtonPlayer.Click
        If Player2FirstName = Nothing Or Player2FirstName = "Computer" Then
            Player2FirstName = "Player2FirstName"
            ButtonPlayer.FlatAppearance.BorderColor = Color.Green
            ButtonComputer.FlatAppearance.BorderColor = Color.Black
            ButtonEasy.Enabled = False
            ButtonNormal.Enabled = False
            ButtonHard.Enabled = False
            TextBoxUsername2.Enabled = True
            TextBoxPassword2.Enabled = True
            ButtonLogin2.Enabled = True
            ButtonCreate2.Enabled = True
        End If
    End Sub

    ' Makes it clear to the user that has chosen the computer to be easy.
    Private Sub ButtonEasy_Click(sender As Object, e As EventArgs) Handles ButtonEasy.Click
        ComputerDifficulty = "Easy"
        ButtonEasy.FlatAppearance.BorderColor = Color.Green
        ButtonNormal.FlatAppearance.BorderColor = Color.Black
        ButtonHard.FlatAppearance.BorderColor = Color.Black
    End Sub

    ' Makes it clear to the user that has chosen the computer to be normal.
    Private Sub ButtonNormal_Click(sender As Object, e As EventArgs) Handles ButtonNormal.Click
        ComputerDifficulty = "Normal"
        ButtonEasy.FlatAppearance.BorderColor = Color.Black
        ButtonNormal.FlatAppearance.BorderColor = Color.Green
        ButtonHard.FlatAppearance.BorderColor = Color.Black
    End Sub

    ' Makes it clear to the user that has chosen the computer to be hard.
    Private Sub ButtonHard_Click(sender As Object, e As EventArgs) Handles ButtonHard.Click
        ComputerDifficulty = "Hard"
        ButtonEasy.FlatAppearance.BorderColor = Color.Black
        ButtonNormal.FlatAppearance.BorderColor = Color.Black
        ButtonHard.FlatAppearance.BorderColor = Color.Green
    End Sub

    ' If the user is not logged in and they press this, then a query will check the details they entered are in the database. If they are found then they will log in, if not they are informed. If the user is already logged in then this button will log them out.
    Private Sub ButtonLogin1_Click(sender As Object, e As EventArgs) Handles ButtonLogin1.Click
        If TextBoxUsername1.Enabled = True Then
            Dim DbAccess As New DbControl
            DbAccess.ExecuteQuery("SELECT * FROM Users WHERE UserName = '" & TextBoxUsername1.Text & "' AND Password = '" & TextBoxPassword1.Text & "'")
            While DbAccess.DbReader.Read
                Player1UserID = DbAccess.DbReader("UserID")
                Player1FirstName = DbAccess.DbReader("FirstName")
            End While
            If Player1FirstName = Nothing Then
                MessageBox.Show("User not found")
                TextBoxUsername1.Text = ""
                TextBoxPassword1.Text = ""
            Else
                MessageBox.Show("User logged in" & vbNewLine & vbNewLine & "Welcome " & Player1FirstName)
                ButtonLogin1.Text = "Logout"
                TextBoxUsername1.Enabled = False
                TextBoxPassword1.Enabled = False
                ButtonCreate1.Enabled = False
                FormCreate.Close()
            End If
        Else
            ButtonLogin1.Text = "Login"
            Player1FirstName = Nothing
            TextBoxUsername1.Enabled = True
            TextBoxUsername1.Text = ""
            TextBoxPassword1.Enabled = True
            TextBoxPassword1.Text = ""
            ButtonCreate1.Enabled = True
        End If
    End Sub

    ' Opens up the form to create a new user.
    Private Sub ButtonCreate1_Click(sender As Object, e As EventArgs) Handles ButtonCreate1.Click
        CreateButton = 1
        FormCreate.Show()
    End Sub

    ' Changes player 1's counter on the main form to this counter, makes it clear that this has been selected, and makes sure that the other player's counter cannot be the same as this one.
    Private Sub ButtonAlpha1_Click(sender As Object, e As EventArgs) Handles ButtonAlpha1.Click
        FormMain.PictureBoxCounter1.Image = My.Resources.AlphaSmall
        Counter1Selected = True
        ButtonAlpha1.FlatAppearance.BorderColor = Color.Green
        ButtonJupiter1.FlatAppearance.BorderColor = Color.Black
        ButtonCar1.FlatAppearance.BorderColor = Color.Black
        ButtonBulb1.FlatAppearance.BorderColor = Color.Black
        ButtonAlpha2.Enabled = False
        ButtonJupiter2.Enabled = True
        ButtonCar2.Enabled = True
        ButtonBulb2.Enabled = True
    End Sub

    ' Changes player 1's counter on the main form to this counter, makes it clear that this has been selected, and makes sure that the other player's counter cannot be the same as this one.
    Private Sub ButtonJupiter1_Click(sender As Object, e As EventArgs) Handles ButtonJupiter1.Click
        FormMain.PictureBoxCounter1.Image = My.Resources.JupiterSmall
        Counter1Selected = True
        ButtonAlpha1.FlatAppearance.BorderColor = Color.Black
        ButtonJupiter1.FlatAppearance.BorderColor = Color.Green
        ButtonCar1.FlatAppearance.BorderColor = Color.Black
        ButtonBulb1.FlatAppearance.BorderColor = Color.Black
        ButtonAlpha2.Enabled = True
        ButtonJupiter2.Enabled = False
        ButtonCar2.Enabled = True
        ButtonBulb2.Enabled = True

    End Sub

    ' Changes player 1's counter on the main form to this counter, makes it clear that this has been selected, and makes sure that the other player's counter cannot be the same as this one.
    Private Sub ButtonCar1_Click(sender As Object, e As EventArgs) Handles ButtonCar1.Click
        FormMain.PictureBoxCounter1.Image = My.Resources.CarSmall
        Counter1Selected = True
        ButtonAlpha1.FlatAppearance.BorderColor = Color.Black
        ButtonJupiter1.FlatAppearance.BorderColor = Color.Black
        ButtonCar1.FlatAppearance.BorderColor = Color.Green
        ButtonBulb1.FlatAppearance.BorderColor = Color.Black
        ButtonAlpha2.Enabled = True
        ButtonJupiter2.Enabled = True
        ButtonCar2.Enabled = False
        ButtonBulb2.Enabled = True
    End Sub

    ' Changes player 1's counter on the main form to this counter, makes it clear that this has been selected, and makes sure that the other player's counter cannot be the same as this one.
    Private Sub ButtonBulb1_Click(sender As Object, e As EventArgs) Handles ButtonBulb1.Click
        FormMain.PictureBoxCounter1.Image = My.Resources.BulbSmall
        Counter1Selected = True
        ButtonAlpha1.FlatAppearance.BorderColor = Color.Black
        ButtonJupiter1.FlatAppearance.BorderColor = Color.Black
        ButtonCar1.FlatAppearance.BorderColor = Color.Black
        ButtonBulb1.FlatAppearance.BorderColor = Color.Green
        ButtonAlpha2.Enabled = True
        ButtonJupiter2.Enabled = True
        ButtonCar2.Enabled = True
        ButtonBulb2.Enabled = False

    End Sub

    '  If player 2 is not logged in and the computer is not choosen to be played against and this is pressed, then a query will check the details entered are in the database. If they are found then they will log in, if not they are informed. If player 2 is already logged in then this button will log them out.
    Private Sub ButtonLogin2_Click(sender As Object, e As EventArgs) Handles ButtonLogin2.Click
        If TextBoxUsername2.Enabled = True Then
            Dim DbAccess As New DbControl
            DbAccess.ExecuteQuery("SELECT * FROM Users WHERE UserName = '" & TextBoxUsername2.Text & "' AND Password = '" & TextBoxPassword2.Text & "'")
            While DbAccess.DbReader.Read
                Player2UserID = DbAccess.DbReader("UserID")
                Player2FirstName = DbAccess.DbReader("FirstName")
            End While
            If Player2FirstName = "Player2FirstName" Then
                MessageBox.Show("User not found")
                TextBoxUsername2.Text = ""
                TextBoxPassword2.Text = ""
            Else
                MessageBox.Show("User logged in" & vbNewLine & vbNewLine & "Welcome " & Player2FirstName)
                ButtonLogin2.Text = "Logout"
                TextBoxUsername2.Enabled = False
                TextBoxPassword2.Enabled = False
                ButtonCreate2.Enabled = False
                FormCreate.Close()
            End If
        Else
            ButtonLogin2.Text = "Login"
            Player2FirstName = "Player2FirstName"
            TextBoxUsername2.Enabled = True
            TextBoxUsername2.Text = ""
            TextBoxPassword2.Enabled = True
            TextBoxPassword2.Text = ""
            ButtonCreate2.Enabled = True
        End If
    End Sub

    ' Opens up the form to create a new user.
    Private Sub ButtonCreate2_Click(sender As Object, e As EventArgs) Handles ButtonCreate2.Click
        CreateButton = 2
        FormCreate.Show()
    End Sub

    ' Changes player 2's or computer's counter on the main form to this counter, makes it clear that this has been selected, and makes sure that the other player's counter cannot be the same as this one.
    Private Sub ButtonAlpha2_Click(sender As Object, e As EventArgs) Handles ButtonAlpha2.Click
        FormMain.PictureBoxCounter2.Image = My.Resources.AlphaSmall
        Counter2Selected = True
        ButtonAlpha1.Enabled = False
        ButtonJupiter1.Enabled = True
        ButtonCar1.Enabled = True
        ButtonBulb1.Enabled = True
        ButtonAlpha2.FlatAppearance.BorderColor = Color.Green
        ButtonJupiter2.FlatAppearance.BorderColor = Color.Black
        ButtonCar2.FlatAppearance.BorderColor = Color.Black
        ButtonBulb2.FlatAppearance.BorderColor = Color.Black
    End Sub

    ' Changes player 2's or computer's counter on the main form to this counter, makes it clear that this has been selected, and makes sure that the other player's counter cannot be the same as this one.
    Private Sub ButtonJupiter2_Click(sender As Object, e As EventArgs) Handles ButtonJupiter2.Click
        FormMain.PictureBoxCounter2.Image = My.Resources.JupiterSmall
        Counter2Selected = True
        ButtonAlpha1.Enabled = True
        ButtonJupiter1.Enabled = False
        ButtonCar1.Enabled = True
        ButtonBulb1.Enabled = True
        ButtonAlpha2.FlatAppearance.BorderColor = Color.Black
        ButtonJupiter2.FlatAppearance.BorderColor = Color.Green
        ButtonCar2.FlatAppearance.BorderColor = Color.Black
        ButtonBulb2.FlatAppearance.BorderColor = Color.Black
    End Sub

    ' Changes player 2's or computer's counter on the main form to this counter, makes it clear that this has been selected, and makes sure that the other player's counter cannot be the same as this one.
    Private Sub ButtonCar2_Click(sender As Object, e As EventArgs) Handles ButtonCar2.Click
        FormMain.PictureBoxCounter2.Image = My.Resources.CarSmall
        Counter2Selected = True
        ButtonAlpha1.Enabled = True
        ButtonJupiter1.Enabled = True
        ButtonCar1.Enabled = False
        ButtonBulb1.Enabled = True
        ButtonAlpha2.FlatAppearance.BorderColor = Color.Black
        ButtonJupiter2.FlatAppearance.BorderColor = Color.Black
        ButtonCar2.FlatAppearance.BorderColor = Color.Green
        ButtonBulb2.FlatAppearance.BorderColor = Color.Black
    End Sub

    ' Changes player 2's or computer's counter on the main form to this counter, makes it clear that this has been selected, and makes sure that the other player's counter cannot be the same as this one.
    Private Sub ButtonBulb2_Click(sender As Object, e As EventArgs) Handles ButtonBulb2.Click
        FormMain.PictureBoxCounter2.Image = My.Resources.BulbSmall
        Counter2Selected = True
        ButtonAlpha1.Enabled = True
        ButtonJupiter1.Enabled = True
        ButtonCar1.Enabled = True
        ButtonBulb1.Enabled = False
        ButtonAlpha2.FlatAppearance.BorderColor = Color.Black
        ButtonJupiter2.FlatAppearance.BorderColor = Color.Black
        ButtonCar2.FlatAppearance.BorderColor = Color.Black
        ButtonBulb2.FlatAppearance.BorderColor = Color.Green
    End Sub

    ' Changes the image of the board on the main form and makes it clear this has been pressed.
    Private Sub ButtonSmall_Click(sender As Object, e As EventArgs) Handles ButtonSmall.Click
        BoardSize = "Small"
        FormMain.PictureBoxBoard.Image = My.Resources.BoardSmall
        ButtonSmall.FlatAppearance.BorderColor = Color.Green
        ButtonMedium.FlatAppearance.BorderColor = Color.Black
        ButtonLarge.FlatAppearance.BorderColor = Color.Black
    End Sub

    ' Changes the image of the board on the main form and makes it clear this has been pressed.
    Private Sub ButtonMedium_Click(sender As Object, e As EventArgs) Handles ButtonMedium.Click
        BoardSize = "Medium"
        FormMain.PictureBoxBoard.Image = My.Resources.BoardMedium
        ButtonSmall.FlatAppearance.BorderColor = Color.Black
        ButtonMedium.FlatAppearance.BorderColor = Color.Green
        ButtonLarge.FlatAppearance.BorderColor = Color.Black
    End Sub

    ' Changes the image of the board on the main form and makes it clear this has been pressed.
    Private Sub ButtonLarge_Click(sender As Object, e As EventArgs) Handles ButtonLarge.Click
        BoardSize = "Large"
        FormMain.PictureBoxBoard.Image = My.Resources.BoardLarge
        ButtonSmall.FlatAppearance.BorderColor = Color.Black
        ButtonMedium.FlatAppearance.BorderColor = Color.Black
        ButtonLarge.FlatAppearance.BorderColor = Color.Green
    End Sub

    ' Switches to the main form only if all settings are complete.
    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        If Player2FirstName = Nothing Then
            MessageBox.Show("Please select who you want to play against")
        ElseIf Player2FirstName = "Computer" And ComputerDifficulty = Nothing Then
            MessageBox.Show("Please select the computer's difficulty")
        ElseIf Player1FirstName = Nothing Then
            MessageBox.Show("Player 1 is not logged in")
        ElseIf Counter1Selected = False Then
            MessageBox.Show("Please select a counter for player 1")
        ElseIf Player2FirstName = "Player2FirstName" Then
            MessageBox.Show("Player 2 is not logged in")
        ElseIf Counter2Selected = False Then
            MessageBox.Show("Please select a counter for player 2")
        ElseIf BoardSize = Nothing Then
            MessageBox.Show("Please select the board size")
        Else
            FormMain.Show()
            Me.Hide()
        End If
    End Sub

End Class