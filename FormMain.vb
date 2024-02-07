Public Class FormMain

    Private Column(8) As Integer
    Private Row(16) As Integer
    Private Snake1 As New Snake
    Private Snake2 As New Snake
    Private Snake3 As New Snake
    Private Snake4 As New Snake
    Private Snake5 As New Snake
    Private Ladder1 As New Ladder
    Private Ladder2 As New Ladder
    Private Ladder3 As New Ladder
    Private Ladder4 As New Ladder
    Private Ladder5 As New Ladder
    Private SpecialSquareNumber(3) As Integer
    Private Turn As String
    Private TypeOfQuestion As String
    Private UsedCalculator As Boolean
    Private Question As String
    Private Answer As Double
    Private Timer As Integer
    Private Dot As String
    Private Player1CorrectAnswers As Integer
    Private Player1IncorrectAnswers As Integer
    Private Player2CorrectAnswers As Integer
    Private Player2IncorrectAnswers As Integer
    Private DiceNumber As Integer
    Private TotalNumber(1) As Integer

    ' Calls the SetUpBoard sub when the form opens.
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetUpBoard()
    End Sub

    ' Adds coordinate columns to the board and rows depending on what size was selected. Moves both counters to the start square.
    Private Sub SetUpBoard()
        Column(0) = 41
        For i = 0 To 7
            Column(i + 1) = Column(i) + 61
        Next
        If FormSetup.BoardSize = "Small" Then
            Row(0) = 420
            For j = 0 To 7
                Row(j + 1) = Row(j) - 32
            Next
        ElseIf FormSetup.BoardSize = "Medium" Then
            Row(0) = 480
            For j = 0 To 11
                Row(j + 1) = Row(j) - 32
            Next
        Else
            Row(0) = 541
            For j = 0 To 15
                Row(j + 1) = Row(j) - 32
            Next
        End If
        PictureBoxCounter1.Parent = PictureBoxBoard
        PictureBoxCounter1.Location = New Point(Column(0), Row(0) - 15)
        PictureBoxCounter2.Parent = PictureBoxBoard
        PictureBoxCounter2.Location = New Point(Column(0), Row(0) + 15)
    End Sub

    ' Calls more subs, enables and disables relevant labels, and starts the computer's turn if they are chosen to go first.
    Private Sub ButtonStartGame_Click(sender As Object, e As EventArgs) Handles ButtonStartGame.Click
        ButtonStartGame.Visible = False
        PictureBoxDice.Visible = True
        AddSpecialSquares()
        AddSnakesAndLadders()
        DecideWhoGoesFirst()
        LabelTurn.Visible = True
        ButtonStartTurn.Visible = True
        If Turn = "Computer" Then
            ButtonStartTurn.PerformClick()
        End If
    End Sub

    ' Decides how many special squares to use based on the board size, and loops through each of them giving them a random location on the board.
    Private Sub AddSpecialSquares()
        Dim MaxNumber As Integer
        Dim NumberOfSpecialSquaresPlus1 As Integer
        If FormSetup.BoardSize = "Small" Then
            MaxNumber = 47
            NumberOfSpecialSquaresPlus1 = 2
        ElseIf FormSetup.BoardSize = "Medium" Then
            MaxNumber = 67
            NumberOfSpecialSquaresPlus1 = 3
        Else
            MaxNumber = 87
            NumberOfSpecialSquaresPlus1 = 4
        End If
        Dim PictureBoxSpecialSquare() As PictureBox
        PictureBoxSpecialSquare = New PictureBox() {PictureBoxSpecialSquare1, PictureBoxSpecialSquare2, PictureBoxSpecialSquare3, PictureBoxSpecialSquare4}
        For i = 0 To NumberOfSpecialSquaresPlus1 - 1
            Randomize()
            SpecialSquareNumber(i) = Int(Rnd() * MaxNumber) + 1
            If SpecialSquareNumber(i) < 9 Then
                PictureBoxSpecialSquare(i).Location = New Point(Column(SpecialSquareNumber(i)), Row(0))
            ElseIf SpecialSquareNumber(i) = 9 Then
                PictureBoxSpecialSquare(i).Location = New Point(Column(8), Row(1))
            ElseIf SpecialSquareNumber(i) > 9 And SpecialSquareNumber(i) < 19 Then
                PictureBoxSpecialSquare(i).Location = New Point(Column(18 - SpecialSquareNumber(i)), Row(2))
            ElseIf SpecialSquareNumber(i) = 19 Then
                PictureBoxSpecialSquare(i).Location = New Point(Column(0), Row(3))
            ElseIf SpecialSquareNumber(i) > 19 And SpecialSquareNumber(i) < 29 Then
                PictureBoxSpecialSquare(i).Location = New Point(Column(SpecialSquareNumber(i) - 20), Row(4))
            ElseIf SpecialSquareNumber(i) = 29 Then
                PictureBoxSpecialSquare(i).Location = New Point(Column(8), Row(5))
            ElseIf SpecialSquareNumber(i) > 29 And SpecialSquareNumber(i) < 39 Then
                PictureBoxSpecialSquare(i).Location = New Point(Column(38 - SpecialSquareNumber(i)), Row(6))
            ElseIf SpecialSquareNumber(i) = 39 Then
                PictureBoxSpecialSquare(i).Location = New Point(Column(0), Row(7))
            ElseIf SpecialSquareNumber(i) > 39 And SpecialSquareNumber(i) < 49 Then
                PictureBoxSpecialSquare(i).Location = New Point(Column(SpecialSquareNumber(i) - 40), Row(8))
            ElseIf SpecialSquareNumber(i) = 49 Then
                PictureBoxSpecialSquare(i).Location = New Point(Column(8), Row(9))
            ElseIf SpecialSquareNumber(i) > 49 And SpecialSquareNumber(i) < 59 Then
                PictureBoxSpecialSquare(i).Location = New Point(Column(58 - SpecialSquareNumber(i)), Row(10))
            ElseIf SpecialSquareNumber(i) = 59 Then
                PictureBoxSpecialSquare(i).Location = New Point(Column(0), Row(11))
            ElseIf SpecialSquareNumber(i) > 59 And SpecialSquareNumber(i) < 69 Then
                PictureBoxSpecialSquare(i).Location = New Point(Column(SpecialSquareNumber(i) - 60), Row(12))
            ElseIf SpecialSquareNumber(i) = 69 Then
                PictureBoxSpecialSquare(i).Location = New Point(Column(8), Row(13))
            ElseIf SpecialSquareNumber(i) > 69 And SpecialSquareNumber(i) < 79 Then
                PictureBoxSpecialSquare(i).Location = New Point(Column(78 - SpecialSquareNumber(i)), Row(14))
            ElseIf SpecialSquareNumber(i) = 79 Then
                PictureBoxSpecialSquare(i).Location = New Point(Column(0), Row(15))
            Else
                PictureBoxSpecialSquare(i).Location = New Point(Column(SpecialSquareNumber(i) - 80), Row(16))
            End If
            PictureBoxSpecialSquare(i).Location = New Point(PictureBoxSpecialSquare(i).Location.X + 40, PictureBoxSpecialSquare(i).Location.Y + 42)
            PictureBoxSpecialSquare(i).Visible = True
        Next
    End Sub

    ' Draws a certain amount of snakes and ladders on the board for the chosen board size, making sure they do not share they do not share same points, by the random setting of their numbers being looped, until they are not the same.
    Public Sub AddSnakesAndLadders()
        Snake1.GetNumbers()
        Snake1.Draw()
        Do
            Snake2.GetNumbers()
        Loop Until Snake2.TopNumber <> Snake1.TopNumber
        Snake2.Draw()
        Do
            Snake3.GetNumbers()
        Loop Until Snake3.TopNumber <> Snake1.TopNumber And Snake3.TopNumber <> Snake2.TopNumber
        Snake3.Draw()
        If FormSetup.BoardSize <> "Small" Then
            Do
                Snake4.GetNumbers()
            Loop Until Snake4.TopNumber <> Snake1.TopNumber And Snake4.TopNumber <> Snake2.TopNumber And Snake4.TopNumber <> Snake3.TopNumber
            Snake4.Draw()
        End If
        If FormSetup.BoardSize = "Large" Then
            Do
                Snake5.GetNumbers()
            Loop Until Snake5.TopNumber <> Snake1.TopNumber And Snake5.TopNumber <> Snake2.TopNumber And Snake5.TopNumber <> Snake3.TopNumber And Snake5.TopNumber <> Snake4.TopNumber
            Snake5.Draw()
        End If
        Do
            Ladder1.GetNumbers()
        Loop Until Ladder1.BottomNumber <> Snake1.TopNumber And Ladder1.BottomNumber <> Snake2.TopNumber And Ladder1.BottomNumber <> Snake3.TopNumber And Ladder1.BottomNumber <> Snake4.TopNumber And Ladder1.BottomNumber <> Snake5.TopNumber
        Ladder1.Draw()
        Do
            Ladder2.GetNumbers()
        Loop Until Ladder2.BottomNumber <> Snake1.TopNumber And Ladder2.BottomNumber <> Snake2.TopNumber And Ladder2.BottomNumber <> Snake3.TopNumber And Ladder2.BottomNumber <> Snake4.TopNumber And Ladder2.BottomNumber <> Snake5.TopNumber And Ladder2.BottomNumber <> Ladder1.BottomNumber
        Ladder2.Draw()
        Do
            Ladder3.GetNumbers()
        Loop Until Ladder3.BottomNumber <> Snake1.TopNumber And Ladder3.BottomNumber <> Snake2.TopNumber And Ladder3.BottomNumber <> Snake3.TopNumber And Ladder3.BottomNumber <> Snake4.TopNumber And Ladder3.BottomNumber <> Snake5.TopNumber And Ladder3.BottomNumber <> Ladder1.BottomNumber And Ladder3.BottomNumber <> Ladder2.BottomNumber
        Ladder3.Draw()
        If FormSetup.BoardSize <> "Small" Then
            Do
                Ladder4.GetNumbers()
            Loop Until Ladder4.BottomNumber <> Snake1.TopNumber And Ladder4.BottomNumber <> Snake2.TopNumber And Ladder4.BottomNumber <> Snake3.TopNumber And Ladder4.BottomNumber <> Snake4.TopNumber And Ladder4.BottomNumber <> Snake5.TopNumber And Ladder4.BottomNumber <> Ladder1.BottomNumber And Ladder4.BottomNumber <> Ladder2.BottomNumber And Ladder4.BottomNumber <> Ladder3.BottomNumber
            Ladder4.Draw()
        End If
        If FormSetup.BoardSize = "Large" Then
            Do
                Ladder5.GetNumbers()
            Loop Until Ladder5.BottomNumber <> Snake1.TopNumber And Ladder5.BottomNumber <> Snake2.TopNumber And Ladder5.BottomNumber <> Snake3.TopNumber And Ladder5.BottomNumber <> Snake4.TopNumber And Ladder5.BottomNumber <> Snake5.TopNumber And Ladder5.BottomNumber <> Ladder1.BottomNumber And Ladder5.BottomNumber <> Ladder2.BottomNumber And Ladder5.BottomNumber <> Ladder3.BottomNumber And Ladder5.BottomNumber <> Ladder4.BottomNumber
            Ladder5.Draw()
        End If
    End Sub

    ' Decide who gets to go first from a 50% chance and displays the name of that player.
    Private Sub DecideWhoGoesFirst()
        Dim RandomNumber As Integer
        Randomize()
        RandomNumber = Int(Rnd() * 2) + 1
        If RandomNumber = 1 Then
            Turn = "Player1"
            MessageBox.Show(FormSetup.Player1FirstName & " goes first")
            LabelTurn.Text = FormSetup.Player1FirstName & "'s turn"
        Else
            If FormSetup.Player2FirstName = "Computer" Then
                Turn = "Computer"
                MessageBox.Show("The computer goes first")
                LabelTurn.Text = "Computer's turn"
            Else
                Turn = "Player2"
                MessageBox.Show(FormSetup.Player2FirstName & " goes first")
                LabelTurn.Text = FormSetup.Player2FirstName & "'s turn"
            End If
        End If
    End Sub

    ' Decides if a SUVAT question will be asked in a 1 in 3 chance instead of a multiple choice question and calls the AskQuestion sub.
    Private Sub ButtonStartTurn_Click(sender As Object, e As EventArgs) Handles ButtonStartTurn.Click
        ButtonStartTurn.Visible = False
        Dim RandomNumber As Integer
        Randomize()
        RandomNumber = Int(Rnd() * 3) + 1
        If RandomNumber = 1 Then
            TypeOfQuestion = "SUVAT"
        Else
            TypeOfQuestion = "Easy"
        End If
        AskQuestion()
    End Sub

    ' Calls the AskSUVAT sub if the type of question is SUVAT. If not then an SQL query retrieves a random question from the table in the database corresponding to the difficulty of the question. The question is displayed to the user, and if it is a multiple choice question then the 4 answers are shuffled and put on buttons. If the computer is being asked a question then a 5 second timer will start.
    Private Sub AskQuestion()
        UsedCalculator = False
        If TypeOfQuestion = "SUVAT" Then
            AskSUVAT()
        Else
            Dim TotalQuestions As Integer
            If TypeOfQuestion = "Easy" Then
                TotalQuestions = 12
            ElseIf TypeOfQuestion = "Medium" Then
                TotalQuestions = 3
            Else
                TotalQuestions = 3
            End If
            Randomize()
            Question = (Int(Rnd() * TotalQuestions) + 1).ToString
            Dim DbAccess As New DbControl
            DbAccess.ExecuteQuery("SELECT * FROM Questions" & TypeOfQuestion & " WHERE QuestionID = " & Question)
            While DbAccess.DbReader.Read
                LabelQuestion.Text = DbAccess.DbReader("Question")
                LabelQuestion.Visible = True
                If TypeOfQuestion = "Easy" Then
                    ButtonAnswer0.Visible = True
                    ButtonAnswer1.Visible = True
                    ButtonAnswer2.Visible = True
                    ButtonAnswer3.Visible = True
                    Dim RandomNumber As Integer
                    Randomize()
                    RandomNumber = Int(Rnd() * 4) + 1
                    If RandomNumber = 1 Then
                        ButtonAnswer0.Text = "A: " & DbAccess.DbReader("AnswerTrue")
                        ButtonAnswer1.Text = "B: " & DbAccess.DbReader("AnswerFalse1")
                        ButtonAnswer2.Text = "C: " & DbAccess.DbReader("AnswerFalse2")
                        ButtonAnswer3.Text = "D: " & DbAccess.DbReader("AnswerFalse3")
                    ElseIf RandomNumber = 2 Then
                        ButtonAnswer0.Text = "A: " & DbAccess.DbReader("AnswerFalse1")
                        ButtonAnswer1.Text = "B: " & DbAccess.DbReader("AnswerTrue")
                        ButtonAnswer2.Text = "C: " & DbAccess.DbReader("AnswerFalse2")
                        ButtonAnswer3.Text = "D: " & DbAccess.DbReader("AnswerFalse3")
                    ElseIf RandomNumber = 3 Then
                        ButtonAnswer0.Text = "A: " & DbAccess.DbReader("AnswerFalse1")
                        ButtonAnswer1.Text = "B: " & DbAccess.DbReader("AnswerFalse2")
                        ButtonAnswer2.Text = "C: " & DbAccess.DbReader("AnswerTrue")
                        ButtonAnswer3.Text = "D: " & DbAccess.DbReader("AnswerFalse3")
                    Else
                        ButtonAnswer0.Text = "A: " & DbAccess.DbReader("AnswerFalse1")
                        ButtonAnswer1.Text = "B: " & DbAccess.DbReader("AnswerFalse2")
                        ButtonAnswer2.Text = "C: " & DbAccess.DbReader("AnswerFalse3")
                        ButtonAnswer3.Text = "D: " & DbAccess.DbReader("AnswerTrue")
                    End If
                Else
                    TextBoxAnswer.Visible = True
                    ButtonAnswerEnter.Visible = True
                End If
            End While
        End If
        If Turn = "Computer" Then
            LabelTurn.Text = "The computer is thinking"
            TimerComputer.Start()
        Else
            ButtonSUVAT.Enabled = True
            ButtonSUVAT.Visible = True
        End If
    End Sub

    ' Random values within a range are assigned to each S, U, V, A, and T. A random question is chosen which uses 3 of the previously created value and is asked to find another. The answer is calculated and rounded using the values and an appropriate formula for the question.
    Private Sub AskSUVAT()
        Dim S As Double
        Dim U As Double
        Dim V As Double
        Dim A As Double
        Dim T As Double
        Dim Calculate As Integer
        Dim NotUsed As Integer
        Randomize()
        S = Math.Round(Rnd() * 200, 2)
        U = Math.Round(Rnd() * 50, 2)
        V = U + Math.Round(Rnd() * 50, 2)
        A = Math.Round(Rnd() * 20, 2)
        T = Math.Round(Rnd() * 40, 2)
        Calculate = Int(Rnd() * 5) + 1
        Do
            NotUsed = Int(Rnd() * 5) + 1
        Loop While NotUsed = Calculate Or (Calculate = 2 And NotUsed = 5) Or (Calculate = 3 And NotUsed = 5) Or (Calculate = 5 And NotUsed = 2) Or (Calculate = 5 And NotUsed = 3)
        If Calculate = 1 Then
            If NotUsed = 2 Then
                Question = "A car reaches a speed of " & V & " ms^-1 in " & T & " s. Its acceleration was " & A & " ms^-2. What is the distance the car travelled to reach this speed in m?"
                Answer = V * T - 0.5 * A * T ^ 2
            ElseIf NotUsed = 3 Then
                Question = "A car accelerates at " & A & " ms^-2 from an initial velocity of " & U & " ms^-1. How far did the car travel " & T & " s after it started to accelerate in m?"
                Answer = U * T + 0.5 * A * T ^ 2
            ElseIf NotUsed = 4 Then
                Question = "A plane's intial velocity is " & U & " ms^-1. After " & T & " s, the plane's velocity is " & V & " ms^-1. What is the distance the plane travelled in this time in m?"
                Answer = T / 2 * (U + V)
            Else
                Question = "A boat accelerates at " & A & " ms^-2 from a velocity of " & U & " ms^-1 to reach a velocity of " & V & " ms^-1. How far did the boat travel during this acceleration in m?"
                Answer = (U ^ 2 + V ^ 2) / (2 * A)
            End If
        ElseIf Calculate = 2 Then
            If NotUsed = 1 Then
                Question = "A boat accelerates at " & A & " ms^-2 for " & T & " s and reaches a speed of " & V & " ms^-1. What was the boats initial velocity in ms^-1?"
                Answer = V - A * T
            ElseIf NotUsed = 3 Then
                Question = "A car travels " & S & " m in " & T & " s. If it's acceleration was " & A & " ms^-2, what was the car's initial speed in ms^-1?"
                Answer = (S - A * T ^ 2) / (2 * T)
            Else
                Question = "During take off a plane travels " & S & " m in " & T & " s. Just before take off the plane is a moving at " & V & " ms^-1. How fast was the plane moving before the take off acceleration began in ms^-1?"
                Answer = (2 * S) / T + V
            End If
        ElseIf Calculate = 3 Then
            If NotUsed = 1 Then
                Question = "A plane starts to accelerate at " & A & " ms^-2 from a speed of " & U & " ms^-1. After " & T & " s, what is the plane's velocity in ms^-1?"
                Answer = U + A * T
            ElseIf NotUsed = 2 Then
                Question = "Once a train leaves a town, it accelerates at " & A & " ms^-2 for " & T & " s. If it travels " & S & " m, what is the trains final velocity in ms^-1?"
                Answer = (S + A * T ^ 2) / (2 * T)
            Else
                Question = "A train travelling at " & U & " ms^-1 starts to roll down a hill that it " & S & " m long. If it takes " & T & " s, how fast is the train moving at the bottom of the hill in ms^-1?"
                Answer = (2 * S) / T - U
            End If
        ElseIf Calculate = 4 Then
            If NotUsed = 1 Then
                Question = "A Formula 1 car accelerates from " & U & " ms^-1 to " & V & " ms^-1 in " & T & " s. What is its acceleration in ms^-2?"
                Answer = (V - U) / T
            ElseIf NotUsed = 2 Then
                Question = "In " & T & " s , a boat moves " & S & " m in a straight line. Its final velocity was " & V & " ms^-1. How fast did it accelerate in ms^-2?"
                Answer = (2 * (V * T - S)) / T ^ 2
            ElseIf NotUsed = 3 Then
                Question = "Usain Bolt runs " & S & " m in " & T & " s. What is his acceleration in ms^-2 if his initial velocity was " & U & " ms^-1?"
                Answer = (2 * (S - U * T)) / T ^ 2
            Else
                Question = "Over a " & S & " m straight section of track, a Formula 1 car accelerates from " & U & " ms^-1 to " & V & " ms-1. What is the car's acceleraion in ms^-2?"
                Answer = (V ^ 2 - U ^ 2) / (2 * S)
            End If
        Else
            If NotUsed = 1 Then
                Question = "A greyhound accelerates from " & U & " ms^-1 to " & V & " ms^-1. If it is accelerating at " & A & " ms^-2, how long did this take in s?"
                Answer = (V - U) / A
            Else
                Question = "A cheetah accelerates at a constant rate to catch a stationary zebra that is " & S & " m away. It's initial velocity was " & U & " ms^-1 and it is moving at " & V & " ms^-1 just before it reaches the zebra. In s how long did it take the cheetah to reach the zebra from when it started to accelerate?"
                Answer = (2 * S) / (U + V)
            End If
        End If
        Answer = Math.Round(Answer, 2)
        LabelQuestion.Text = Question & " Give you answer to the correct amount of decimal places."
        LabelQuestion.Visible = True
        TextBoxAnswer.Visible = True
        ButtonAnswerEnter.Visible = True
    End Sub

    ' After 5 seconds the ComputerSolveQuestion sub is called. During the timer a sequence of dots alternates letting the user know the computer is thinking.
    Private Sub TimerComputer_Tick(sender As Object, e As EventArgs) Handles TimerComputer.Tick
        Timer = Timer + 2
        If Timer Mod 10 = 0 Then
            Dot = Dot + "."
            If Dot.Length = 4 Then
                Dot = ""
            End If
            LabelTurn.Text = "The computer is thinking " & Dot
        End If
        If Timer = 100 Then
            TimerComputer.Stop()
            Timer = 0
            Dot = ""
            ComputerSolveQuestion()
        End If
    End Sub

    ' A chance that is decided by their selected difficulty determines if they answer the question correctly. If it is right then they will either roll the dice or move up a ladder depending on the type of question asked. If it is wrong then their turn will end or they will move down a ladder depending on the type of question asked.
    Private Sub ComputerSolveQuestion()
        Dim RandomNumber As Integer
        Randomize()
        RandomNumber = Int(Rnd() * 10) + 1
        Dim Chance As Integer
        If FormSetup.ComputerDifficulty = "Easy" Then
            Chance = 5
        ElseIf FormSetup.ComputerDifficulty = "Normal" Then
            Chance = 7
        Else
            Chance = 9
        End If
        If RandomNumber <= Chance Then
            MessageBox.Show("The computer got the question right")
            Player2CorrectAnswers += 1
            HideQuestion()
            If TypeOfQuestion = "Easy" Or TypeOfQuestion = "SUVAT" Then
                TimerDice.Start()
            ElseIf TypeOfQuestion = "Medium" Then
                MoveUpLadder(1)
            Else
                EndTurn()
            End If
        Else
            MessageBox.Show("The computer got the question wrong")
            Player2IncorrectAnswers += 1
            HideQuestion()
            If TypeOfQuestion = "Hard" Then
                MoveDownSnake(1)
            Else
                EndTurn()
            End If
        End If
    End Sub

    ' Warns the player the consequences of using the SUVAT calculator, and if they choose to proceed, the calculator will open.
    Private Sub ButtonSUVAT_Click(sender As Object, e As EventArgs) Handles ButtonSUVAT.Click
        If MessageBox.Show("Using the SUVAT Calculator will halve the score you roll on the dice if you get the question correct." & vbNewLine & vbNewLine & "Are you sure you want to use the SUVAT Calculator?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            FormSUVAT.Show()
            ButtonSUVAT.Enabled = False
            UsedCalculator = True
        End If
    End Sub

    ' Checks this if the multiple choice answer on this button is correct. If it is the computer's turn, pressing this button won't do anything.
    Private Sub ButtonAnswer0_Click(sender As Object, e As EventArgs) Handles ButtonAnswer0.Click
        If Turn <> "Computer" Then
            CheckAnswer(0)
        End If
    End Sub

    ' Checks this if the multiple choice answer on this button is correct. If it is the computer's turn, pressing this button won't do anything.
    Private Sub ButtonAnswer1_Click(sender As Object, e As EventArgs) Handles ButtonAnswer1.Click
        If Turn <> "Computer" Then
            CheckAnswer(1)
        End If
    End Sub

    ' Checks this if the multiple choice answer on this button is correct. If it is the computer's turn, pressing this button won't do anything.
    Private Sub ButtonAnswer2_Click(sender As Object, e As EventArgs) Handles ButtonAnswer2.Click
        If Turn <> "Computer" Then
            CheckAnswer(2)
        End If
    End Sub

    ' Checks this if the multiple choice answer on this button is correct. If it is the computer's turn, pressing this button won't do anything.
    Private Sub ButtonAnswer3_Click(sender As Object, e As EventArgs) Handles ButtonAnswer3.Click
        If Turn <> "Computer" Then
            CheckAnswer(3)
        End If
    End Sub

    ' Checks if the answer entered in the textbox is correct. If it is the computer's turn, pressing this button won't do anything.
    Private Sub ButtonAnswerEnter_Click(sender As Object, e As EventArgs) Handles ButtonAnswerEnter.Click
        If Turn <> "Computer" Then
            CheckAnswer(9)
        End If
    End Sub

    ' If a SUVAT question if being asked then if the value entered in the answer box is the same as the answer the program calculated, then it is correct. If it is not a SUVAT question, an SQL query will retrieve the correct answer to the asked question from the database. If it matches what multiple choice answer the user pressed or what answer they entered the answer box, then they get the question correct. If the user gets a question correct, they get to roll the dice or move up a ladder depending on the type of question asked. If they get the question wrong then they have an option to send a message to their teacher, and they move down a ladder or their turn ends depending on the type of question asked.
    Private Sub CheckAnswer(Number As Integer)
        If TypeOfQuestion = "SUVAT" Then
            If Val(TextBoxAnswer.Text) = Answer Then
                MessageBox.Show("Correct")
                UpdateCorrectAnswers()
                HideQuestion()
                PictureBoxDice.Enabled = True
                LabelRoll.Visible = True
            Else
                If MessageBox.Show("Incorrect" & vbNewLine & vbNewLine & "The correct answer was:   " & Answer & vbNewLine & vbNewLine & "Do you want to send a message to your teacher regarding this question?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    SubmitMessage(Answer, TextBoxAnswer.Text)
                End If
                UpdateIncorrectAnswers()
                HideQuestion()
                EndTurn()
            End If
        Else
            Dim DbAccess As New DbControl
            DbAccess.ExecuteQuery("SELECT * FROM Questions" & TypeOfQuestion & " WHERE QuestionID = " & Question)
            While DbAccess.DbReader.Read
                If TypeOfQuestion = "Easy" Then
                    Dim ButtonAnswer() As Button
                    ButtonAnswer = New Button() {ButtonAnswer0, ButtonAnswer1, ButtonAnswer2, ButtonAnswer3}
                    If ButtonAnswer(Number).Text.Contains(DbAccess.DbReader("AnswerTrue")) Then
                        MessageBox.Show("Correct")
                        UpdateCorrectAnswers()
                        HideQuestion()
                        PictureBoxDice.Enabled = True
                        LabelRoll.Visible = True
                    Else
                        If MessageBox.Show("Incorrect" & vbNewLine & vbNewLine & "The correct answer was:   " & DbAccess.DbReader("AnswerTrue") & vbNewLine & vbNewLine & "Do you want to send a message to your teacher regarding this question?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            SubmitMessage(DbAccess.DbReader("AnswerTrue"), ButtonAnswer(Number).Text)
                        End If
                        UpdateIncorrectAnswers()
                        HideQuestion()
                        EndTurn()
                    End If
                ElseIf TypeOfQuestion = "Medium" Then
                    If TextBoxAnswer.Text = DbAccess.DbReader("Answer") Then
                        MessageBox.Show("Correct")
                        UpdateCorrectAnswers()
                        HideQuestion()
                        If Turn = "Player1" Then
                            MoveUpLadder(0)
                        Else
                            MoveUpLadder(1)
                        End If
                    Else
                        If MessageBox.Show("Incorrect" & vbNewLine & vbNewLine & "The correct answer was:   " & DbAccess.DbReader("Answer") & vbNewLine & vbNewLine & "Do you want to send a message to your teacher regarding this question?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            SubmitMessage(DbAccess.DbReader("Answer"), TextBoxAnswer.Text)
                        End If
                        UpdateIncorrectAnswers()
                        HideQuestion()
                        EndTurn()
                    End If
                Else
                    If TextBoxAnswer.Text = DbAccess.DbReader("Answer") Then
                        MessageBox.Show("Correct")
                        UpdateCorrectAnswers()
                        HideQuestion()
                        EndTurn()
                    Else
                        If MessageBox.Show("Incorrect" & vbNewLine & vbNewLine & "The correct answer was:   " & DbAccess.DbReader("Answer") & vbNewLine & vbNewLine & "Do you want to send a message to your teacher regarding this question?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            SubmitMessage(DbAccess.DbReader("Answer"), TextBoxAnswer.Text)
                        End If
                        UpdateIncorrectAnswers()
                        HideQuestion()
                        If Turn = "Player1" Then
                            MoveDownSnake(0)
                        Else
                            MoveDownSnake(1)
                        End If
                    End If
                End If
            End While
        End If
    End Sub

    ' Increases the player's number of correct answers by 1 if they answer a question correctly.
    Private Sub UpdateCorrectAnswers()
        If Turn = "Player1" Then
            Player1CorrectAnswers += 1
        Else
            Player2CorrectAnswers += 1
        End If
    End Sub

    ' Increases the player's number of incorrect answers by 1 if they answer a question incorrectly.
    Private Sub UpdateIncorrectAnswers()
        If Turn = "Player1" Then
            Player1IncorrectAnswers += 1
        Else
            Player2IncorrectAnswers += 1
        End If
    End Sub

    ' An SQL query adds a new entry into the messages table in the database that includes the UserID of the current player, details about the question and answer, and a message the user typed into a input box, so the teacher can help them out.
    Private Sub SubmitMessage(ActualAnswer As String, StudentAnswer As String)
        Dim Message As String
        Message = InputBox("Please enter your message:")
        If Message <> Nothing Then
            Dim DbAccess As New DbControl
            If Turn = "Player1" Then
                DbAccess.ExecuteQuery("INSERT INTO Messages ([UserID], [TypeOfQuestion], [Question], [ActualAnswer], [StudentAnswer], [Message]) VALUES ('" & FormSetup.Player1UserID & "', '" & TypeOfQuestion & "', '" & Question & "', '" & ActualAnswer & "', '" & StudentAnswer & "', '" & Message & "')")
            Else
                DbAccess.ExecuteQuery("INSERT INTO Messages ([UserID], [TypeOfQuestion], [Question], [ActualAnswer], [StudentAnswer], [Message]) VALUES ('" & FormSetup.Player2UserID & "', '" & TypeOfQuestion & "', '" & Question & "', '" & ActualAnswer & "', '" & StudentAnswer & "', '" & Message & "')")
            End If
            MessageBox.Show("Message sent")
        End If
    End Sub

    ' Hides items on the form after a question has been answered.
    Private Sub HideQuestion()
        FormSUVAT.Close()
        ButtonSUVAT.Visible = False
        LabelQuestion.Visible = False
        ButtonAnswer0.Visible = False
        ButtonAnswer1.Visible = False
        ButtonAnswer2.Visible = False
        ButtonAnswer3.Visible = False
        ButtonAnswerEnter.Visible = False
        TextBoxAnswer.Visible = False
        TextBoxAnswer.Text = ""
    End Sub

    ' Starts a timer that rolls the dice.
    Private Sub PictureBoxDice_Click(sender As Object, e As EventArgs) Handles PictureBoxDice.Click
        TimerDice.Start()
        PictureBoxDice.Enabled = False
        LabelRoll.Visible = False
    End Sub

    ' Every 1/10 of a second the RollDice sub is called. After 1 second the timer stops and the user is inform the current player rolled whatever the dice finished on, however if they used the SUVAT Calculator they will only move half the dice value rounded up.
    Private Sub TimerDice_Tick(sender As Object, e As EventArgs) Handles TimerDice.Tick
        Timer = Timer + 10
        RollDice()
        If Timer = 100 Then
            TimerDice.Stop()
            Timer = 0
            If Turn = "Computer" Then
                MessageBox.Show("The computer rolled " & DiceNumber)
            Else
                If UsedCalculator = False Then
                    MessageBox.Show("You rolled " & DiceNumber)
                Else
                    MessageBox.Show("You rolled " & DiceNumber & ", however you used the SUVAT Calculator so you will only move " & Math.Ceiling(DiceNumber / 2) & " spaces.")
                    DiceNumber = Math.Ceiling(DiceNumber / 2)
                End If
            End If
            If Turn = "Player1" Then
                MoveCounter(0)
            Else
                MoveCounter(1)
            End If
        End If
    End Sub

    ' The dice randomly changes its value and its picture to one of its sides.
    Private Sub RollDice()
        Randomize()
        DiceNumber = Int(Rnd() * 6) + 1
        If DiceNumber = 1 Then
            PictureBoxDice.Image = My.Resources.Dice_1
        ElseIf DiceNumber = 2 Then
            PictureBoxDice.Image = My.Resources.Dice_2
        ElseIf DiceNumber = 3 Then
            PictureBoxDice.Image = My.Resources.Dice_3
        ElseIf DiceNumber = 4 Then
            PictureBoxDice.Image = My.Resources.Dice_4
        ElseIf DiceNumber = 5 Then
            PictureBoxDice.Image = My.Resources.Dice_5
        Else
            PictureBoxDice.Image = My.Resources.Dice_6
        End If
    End Sub

    ' If the player rolled the dice, the amount a user rolls is added to their total number, their counter moves to that specific column and row on the board, and the CheckMove sub is called to see if they landed on anything. If the user total number reaches the total number of squares for the selected board size then their counter will move to the finish tile and the ShowWinner sub is called.
    Private Sub MoveCounter(Player As Integer)
        TotalNumber(Player) = TotalNumber(Player) + DiceNumber
        Dim PictureBoxCounter() As PictureBox
        PictureBoxCounter = New PictureBox() {PictureBoxCounter1, PictureBoxCounter2}
        If TotalNumber(Player) < 9 Then
            PictureBoxCounter(Player).Location = New Point(Column(TotalNumber(Player)), Row(0))
        ElseIf TotalNumber(Player) = 9 Then
            PictureBoxCounter(Player).Location = New Point(Column(8), Row(1))
        ElseIf TotalNumber(Player) > 9 And TotalNumber(Player) < 19 Then
            PictureBoxCounter(Player).Location = New Point(Column(18 - TotalNumber(Player)), Row(2))
        ElseIf TotalNumber(Player) = 19 Then
            PictureBoxCounter(Player).Location = New Point(Column(0), Row(3))
        ElseIf TotalNumber(Player) > 19 And TotalNumber(Player) < 29 Then
            PictureBoxCounter(Player).Location = New Point(Column(TotalNumber(Player) - 20), Row(4))
        ElseIf TotalNumber(Player) = 29 Then
            PictureBoxCounter(Player).Location = New Point(Column(8), Row(5))
        ElseIf TotalNumber(Player) > 29 And TotalNumber(Player) < 39 Then
            PictureBoxCounter(Player).Location = New Point(Column(38 - TotalNumber(Player)), Row(6))
        ElseIf TotalNumber(Player) = 39 Then
            PictureBoxCounter(Player).Location = New Point(Column(0), Row(7))
        ElseIf TotalNumber(Player) > 39 And TotalNumber(Player) < 49 Then
            PictureBoxCounter(Player).Location = New Point(Column(TotalNumber(Player) - 40), Row(8))
        ElseIf TotalNumber(Player) = 49 Then
            PictureBoxCounter(Player).Location = New Point(Column(8), Row(9))
        ElseIf TotalNumber(Player) > 49 And TotalNumber(Player) < 59 Then
            PictureBoxCounter(Player).Location = New Point(Column(58 - TotalNumber(Player)), Row(10))
        ElseIf TotalNumber(Player) = 59 Then
            PictureBoxCounter(Player).Location = New Point(Column(0), Row(11))
        ElseIf TotalNumber(Player) > 59 And TotalNumber(Player) < 69 Then
            PictureBoxCounter(Player).Location = New Point(Column(TotalNumber(Player) - 60), Row(12))
        ElseIf TotalNumber(Player) = 69 Then
            PictureBoxCounter(Player).Location = New Point(Column(8), Row(13))
        ElseIf TotalNumber(Player) > 69 And TotalNumber(Player) < 79 Then
            PictureBoxCounter(Player).Location = New Point(Column(78 - TotalNumber(Player)), Row(14))
        ElseIf TotalNumber(Player) = 79 Then
            PictureBoxCounter(Player).Location = New Point(Column(0), Row(15))
        ElseIf TotalNumber(Player) > 79 And TotalNumber(Player) < 88 Then
            PictureBoxCounter(Player).Location = New Point(Column(TotalNumber(Player) - 80), Row(16))
        Else
            PictureBoxCounter(Player).Location = New Point(Column(8), Row(16))
            ShowWinner()
        End If
        If FormSetup.BoardSize = "Small" And TotalNumber(Player) > 47 Then
            PictureBoxCounter(Player).Location = New Point(Column(8), Row(8))
            ShowWinner()
        End If
        If FormSetup.BoardSize = "Medium" And TotalNumber(Player) > 67 Then
            PictureBoxCounter(Player).Location = New Point(Column(8), Row(12))
            ShowWinner()
        End If
        DiceNumber = 0
        CheckMove(Player)
    End Sub

    ' If the player lands on a special square then they are given a choice to whether or not they want to change the position of the snakes and ladders. If a computer lands on a special square then there is a 50% chance whether or not the positions will change. If the player does not land on one, the CheckSnakeOrLadder sub is called.
    Private Sub CheckMove(Player As Integer)
        If TotalNumber(Player) = SpecialSquareNumber(0) Or TotalNumber(Player) = SpecialSquareNumber(1) Or TotalNumber(Player) = SpecialSquareNumber(2) Or TotalNumber(Player) = SpecialSquareNumber(3) Then
            LabelChange.Visible = True
            ButtonYes.Visible = True
            ButtonNo.Visible = True
            If Turn = "Computer" Then
                MessageBox.Show("The Computer landed on a special square and has decided")
                Dim RandomNumber As Integer
                Randomize()
                RandomNumber = Int(Rnd() * 2) + 1
                If RandomNumber = 1 Then
                    ButtonYes.PerformClick()
                Else
                    ButtonNo.PerformClick()
                End If
            Else
                MessageBox.Show("You landed on a special square")
            End If
        Else
            CheckSnakeOrLadder(Player)
        End If
    End Sub

    ' If the player chooses to change the positions of the snakes and ladders then their drawings will be cleared, and the AddSnakesAndLadders sub is called, which redraws them is new random locations. The CheckSnakeOrLadder sub is then called.
    Private Sub ButtonYes_Click(sender As Object, e As EventArgs) Handles ButtonYes.Click
        MessageBox.Show("The position of the snakes and ladders will change")
        PictureBoxBoard.Refresh()
        AddSnakesAndLadders()
        LabelChange.Visible = False
        ButtonYes.Visible = False
        ButtonNo.Visible = False
        If Turn = "Player1" Then
            CheckSnakeOrLadder(0)
        Else
            CheckSnakeOrLadder(1)
        End If
    End Sub

    ' If the player chooses to keep the current positions of the snakes and ladders then a message box will show and the question hides. The CheckSnakeOrLadder sub is then called.
    Private Sub ButtonNo_Click(sender As Object, e As EventArgs) Handles ButtonNo.Click
        MessageBox.Show("The position of the snakes and ladders will not change")
        LabelChange.Visible = False
        ButtonYes.Visible = False
        ButtonNo.Visible = False
        If Turn = "Player1" Then
            CheckSnakeOrLadder(0)
        Else
            CheckSnakeOrLadder(1)
        End If
    End Sub

    ' If a player lands on a snake then they are asked a hard question. If they land on a ladder they are asked a medium question. If they don't land on anything the EndTurn sub is called.
    Private Sub CheckSnakeOrLadder(Player As Integer)
        If TotalNumber(Player) = Snake1.TopNumber Or TotalNumber(Player) = Snake2.TopNumber Or TotalNumber(Player) = Snake3.TopNumber Or TotalNumber(Player) = Snake4.TopNumber Or TotalNumber(Player) = Snake5.TopNumber Then
            If Turn = "Computer" Then
                MessageBox.Show("The computer landed on a snake")
            Else
                MessageBox.Show("You landed on a snake")
            End If
            TypeOfQuestion = "Hard"
            AskQuestion()
        ElseIf TotalNumber(Player) = Ladder1.BottomNumber Or TotalNumber(Player) = Ladder2.BottomNumber Or TotalNumber(Player) = Ladder3.BottomNumber Or TotalNumber(Player) = Ladder4.BottomNumber Or TotalNumber(Player) = Ladder5.BottomNumber Then
            If Turn = "Computer" Then
                MessageBox.Show("The computer landed on a ladder")
            Else
                MessageBox.Show("You landed on a ladder")
            End If
            TypeOfQuestion = "Medium"
            AskQuestion()
        Else
            EndTurn()
        End If
    End Sub

    ' If a player gets a hard question wrong, their total number equals the bottom number of the snake, and the MoveCounter sub is called to move them down.
    Private Sub MoveDownSnake(Player As Integer)
        If TotalNumber(Player) = Snake1.TopNumber Then
            TotalNumber(Player) = Snake1.BottomNumber
        ElseIf TotalNumber(Player) = Snake2.TopNumber Then
            TotalNumber(Player) = Snake2.BottomNumber
        ElseIf TotalNumber(Player) = Snake3.TopNumber Then
            TotalNumber(Player) = Snake3.BottomNumber
        ElseIf TotalNumber(Player) = Snake4.TopNumber Then
            TotalNumber(Player) = Snake4.BottomNumber
        ElseIf TotalNumber(Player) = Snake5.TopNumber Then
            TotalNumber(Player) = Snake5.BottomNumber
        End If
        If Turn = "Computer" Then
            MessageBox.Show("The computer moved down the snake")
        Else
            MessageBox.Show("You moved down the snake")
        End If
        MoveCounter(Player)
    End Sub

    ' If a player gets a hard question right, then their total number equals the top number of the ladder, and the MoveCounter sub is called to move them up.
    Private Sub MoveUpLadder(Player As Integer)
        If TotalNumber(Player) = Ladder1.BottomNumber Then
            TotalNumber(Player) = Ladder1.TopNumber
        ElseIf TotalNumber(Player) = Ladder2.BottomNumber Then
            TotalNumber(Player) = Ladder2.TopNumber
        ElseIf TotalNumber(Player) = Ladder3.BottomNumber Then
            TotalNumber(Player) = Ladder3.TopNumber
        ElseIf TotalNumber(Player) = Ladder4.BottomNumber Then
            TotalNumber(Player) = Ladder4.TopNumber
        ElseIf TotalNumber(Player) = Ladder5.BottomNumber Then
            TotalNumber(Player) = Ladder5.TopNumber
        End If
        If Turn = "Computer" Then
            MessageBox.Show("The computer moved up the ladder")
        Else
            MessageBox.Show("You moved up the ladder")
        End If
        MoveCounter(Player)
    End Sub

    ' The turn switches to computer or other player, and they are notified with a label saying it their first name's turn.
    Private Sub EndTurn()
        If Turn = "Player1" Then
            LabelTurn.Text = FormSetup.Player2FirstName & "'s turn"
            If FormSetup.Player2FirstName = "Computer" Then
                Turn = "Computer"
            Else
                Turn = "Player2"
            End If
        Else
            LabelTurn.Text = FormSetup.Player1FirstName & "'s turn"
            Turn = "Player1"
        End If
        ButtonStartTurn.Visible = True
    End Sub

    ' The percentage of questions answered correctly is calculated for both players and a SQL query saves the UserID of the winner, their results, the UserID of the looser, their results, and their final position to the results table in the database. The user then returns to the start menu.
    Private Sub ShowWinner()
        Dim Player1Percentage As Integer
        Player1Percentage = (Player1CorrectAnswers / (Player1CorrectAnswers + Player1IncorrectAnswers)) * 100
        Dim Player2Percentage As Integer
        Player2Percentage = (Player2CorrectAnswers / (Player2CorrectAnswers + Player2IncorrectAnswers)) * 100
        Dim BoardSquares As Integer
        If FormSetup.BoardSize = "Small" Then
            BoardSquares = 48
        ElseIf FormSetup.BoardSize = "Medium" Then
            BoardSquares = 68
        Else
            BoardSquares = 88
        End If
        Dim DbAccess As New DbControl
        If Turn = "Computer" Then
            MessageBox.Show("The computer has won the game")
            DbAccess.ExecuteQuery("INSERT INTO Results ([WinnerUserID], [WinnerCorrectAnswers], [WinnerIncorrectAnswers], [WinnerPercentage], [LooserUserID], [LooserCorrectAnswers], [LooserIncorrectAnswers], [LooserPercentage], [LooserFinalPosition]) VALUES ('1', '" & Player2CorrectAnswers & "', '" & Player2IncorrectAnswers & "', '" & Player2Percentage & "%', '" & FormSetup.Player1UserID & "', '" & Player1CorrectAnswers & "', '" & Player1IncorrectAnswers & "', '" & Player1Percentage & "%', '" & TotalNumber(0) & "/" & BoardSquares & "')")
        ElseIf Turn = "Player1" Then
            MessageBox.Show(FormSetup.Player1FirstName & " has won the game")
            DbAccess.ExecuteQuery("INSERT INTO Results ([WinnerUserID], [WinnerCorrectAnswers], [WinnerIncorrectAnswers], [WinnerPercentage], [LooserUserID], [LooserCorrectAnswers], [LooserIncorrectAnswers], [LooserPercentage], [LooserFinalPosition]) VALUES ('" & FormSetup.Player1UserID & "', '" & Player1CorrectAnswers & "', '" & Player1IncorrectAnswers & "', '" & Player1Percentage & "%', '" & FormSetup.Player2UserID & "', '" & Player2CorrectAnswers & "', '" & Player2IncorrectAnswers & "', '" & Player2Percentage & "%', '" & TotalNumber(1) & "/" & BoardSquares & "')")
        Else
            MessageBox.Show(FormSetup.Player2FirstName & " has won the game")
            DbAccess.ExecuteQuery("INSERT INTO Results ([WinnerUserID], [WinnerCorrectAnswers], [WinnerIncorrectAnswers], [WinnerPercentage], [LooserUserID], [LooserCorrectAnswers], [LooserIncorrectAnswers], [LooserPercentage], [LooserFinalPosition]) VALUES ('" & FormSetup.Player2UserID & "', '" & Player2CorrectAnswers & "', '" & Player2IncorrectAnswers & "', '" & Player2Percentage & "%', '" & FormSetup.Player1UserID & "', '" & Player1CorrectAnswers & "', '" & Player1IncorrectAnswers & "', '" & Player1Percentage & "%', '" & TotalNumber(0) & "/" & BoardSquares & "')")
        End If
        MessageBox.Show("Results has been saved" & vbNewLine & vbNewLine & "Game finished")
        FormStart.Show()
        Me.Close()
    End Sub

End Class