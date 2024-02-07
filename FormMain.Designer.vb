<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TimerDice = New System.Windows.Forms.Timer(Me.components)
        Me.LabelQuestion = New System.Windows.Forms.Label()
        Me.TextBoxAnswer = New System.Windows.Forms.TextBox()
        Me.ButtonAnswerEnter = New System.Windows.Forms.Button()
        Me.LabelTurn = New System.Windows.Forms.Label()
        Me.ButtonStartGame = New System.Windows.Forms.Button()
        Me.ButtonAnswer0 = New System.Windows.Forms.Button()
        Me.ButtonAnswer1 = New System.Windows.Forms.Button()
        Me.ButtonAnswer2 = New System.Windows.Forms.Button()
        Me.ButtonAnswer3 = New System.Windows.Forms.Button()
        Me.ButtonStartTurn = New System.Windows.Forms.Button()
        Me.LabelRoll = New System.Windows.Forms.Label()
        Me.ButtonYes = New System.Windows.Forms.Button()
        Me.ButtonNo = New System.Windows.Forms.Button()
        Me.LabelChange = New System.Windows.Forms.Label()
        Me.ButtonSUVAT = New System.Windows.Forms.Button()
        Me.PictureBoxSpecialSquare2 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSpecialSquare3 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSpecialSquare4 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSpecialSquare1 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCounter2 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxDice = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCounter1 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxBoard = New System.Windows.Forms.PictureBox()
        Me.TimerComputer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBoxSpecialSquare2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSpecialSquare3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSpecialSquare4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSpecialSquare1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCounter2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxDice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCounter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerDice
        '
        '
        'LabelQuestion
        '
        Me.LabelQuestion.BackColor = System.Drawing.Color.Transparent
        Me.LabelQuestion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQuestion.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelQuestion.Location = New System.Drawing.Point(656, 263)
        Me.LabelQuestion.Name = "LabelQuestion"
        Me.LabelQuestion.Size = New System.Drawing.Size(596, 117)
        Me.LabelQuestion.TabIndex = 13
        Me.LabelQuestion.Text = "LabelQuestion"
        Me.LabelQuestion.Visible = False
        '
        'TextBoxAnswer
        '
        Me.TextBoxAnswer.Location = New System.Drawing.Point(904, 441)
        Me.TextBoxAnswer.Name = "TextBoxAnswer"
        Me.TextBoxAnswer.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAnswer.TabIndex = 14
        Me.TextBoxAnswer.Visible = False
        '
        'ButtonAnswerEnter
        '
        Me.ButtonAnswerEnter.BackColor = System.Drawing.Color.DarkRed
        Me.ButtonAnswerEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAnswerEnter.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAnswerEnter.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.ButtonAnswerEnter.Location = New System.Drawing.Point(913, 471)
        Me.ButtonAnswerEnter.Name = "ButtonAnswerEnter"
        Me.ButtonAnswerEnter.Size = New System.Drawing.Size(79, 34)
        Me.ButtonAnswerEnter.TabIndex = 15
        Me.ButtonAnswerEnter.Text = "Enter"
        Me.ButtonAnswerEnter.UseVisualStyleBackColor = False
        Me.ButtonAnswerEnter.Visible = False
        '
        'LabelTurn
        '
        Me.LabelTurn.AutoSize = True
        Me.LabelTurn.BackColor = System.Drawing.Color.Transparent
        Me.LabelTurn.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTurn.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelTurn.Location = New System.Drawing.Point(678, 166)
        Me.LabelTurn.Name = "LabelTurn"
        Me.LabelTurn.Size = New System.Drawing.Size(84, 20)
        Me.LabelTurn.TabIndex = 18
        Me.LabelTurn.Text = "LabelTurn"
        Me.LabelTurn.Visible = False
        '
        'ButtonStartGame
        '
        Me.ButtonStartGame.BackColor = System.Drawing.Color.DarkRed
        Me.ButtonStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStartGame.Font = New System.Drawing.Font("Tempus Sans ITC", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStartGame.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.ButtonStartGame.Location = New System.Drawing.Point(868, 327)
        Me.ButtonStartGame.Name = "ButtonStartGame"
        Me.ButtonStartGame.Size = New System.Drawing.Size(168, 60)
        Me.ButtonStartGame.TabIndex = 19
        Me.ButtonStartGame.Text = "Start game"
        Me.ButtonStartGame.UseVisualStyleBackColor = False
        '
        'ButtonAnswer0
        '
        Me.ButtonAnswer0.BackColor = System.Drawing.Color.DarkRed
        Me.ButtonAnswer0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAnswer0.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAnswer0.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.ButtonAnswer0.Location = New System.Drawing.Point(778, 383)
        Me.ButtonAnswer0.Name = "ButtonAnswer0"
        Me.ButtonAnswer0.Size = New System.Drawing.Size(120, 78)
        Me.ButtonAnswer0.TabIndex = 20
        Me.ButtonAnswer0.Text = "1"
        Me.ButtonAnswer0.UseVisualStyleBackColor = False
        Me.ButtonAnswer0.Visible = False
        '
        'ButtonAnswer1
        '
        Me.ButtonAnswer1.BackColor = System.Drawing.Color.DarkRed
        Me.ButtonAnswer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAnswer1.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAnswer1.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.ButtonAnswer1.Location = New System.Drawing.Point(778, 471)
        Me.ButtonAnswer1.Name = "ButtonAnswer1"
        Me.ButtonAnswer1.Size = New System.Drawing.Size(120, 78)
        Me.ButtonAnswer1.TabIndex = 21
        Me.ButtonAnswer1.Text = "2"
        Me.ButtonAnswer1.UseVisualStyleBackColor = False
        Me.ButtonAnswer1.Visible = False
        '
        'ButtonAnswer2
        '
        Me.ButtonAnswer2.BackColor = System.Drawing.Color.DarkRed
        Me.ButtonAnswer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAnswer2.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAnswer2.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.ButtonAnswer2.Location = New System.Drawing.Point(1010, 383)
        Me.ButtonAnswer2.Name = "ButtonAnswer2"
        Me.ButtonAnswer2.Size = New System.Drawing.Size(120, 78)
        Me.ButtonAnswer2.TabIndex = 22
        Me.ButtonAnswer2.Text = "3"
        Me.ButtonAnswer2.UseVisualStyleBackColor = False
        Me.ButtonAnswer2.Visible = False
        '
        'ButtonAnswer3
        '
        Me.ButtonAnswer3.BackColor = System.Drawing.Color.DarkRed
        Me.ButtonAnswer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAnswer3.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAnswer3.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.ButtonAnswer3.Location = New System.Drawing.Point(1010, 471)
        Me.ButtonAnswer3.Name = "ButtonAnswer3"
        Me.ButtonAnswer3.Size = New System.Drawing.Size(120, 78)
        Me.ButtonAnswer3.TabIndex = 23
        Me.ButtonAnswer3.Text = "4"
        Me.ButtonAnswer3.UseVisualStyleBackColor = False
        Me.ButtonAnswer3.Visible = False
        '
        'ButtonStartTurn
        '
        Me.ButtonStartTurn.BackColor = System.Drawing.Color.DarkRed
        Me.ButtonStartTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStartTurn.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStartTurn.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.ButtonStartTurn.Location = New System.Drawing.Point(817, 160)
        Me.ButtonStartTurn.Name = "ButtonStartTurn"
        Me.ButtonStartTurn.Size = New System.Drawing.Size(105, 33)
        Me.ButtonStartTurn.TabIndex = 25
        Me.ButtonStartTurn.Text = "Start turn"
        Me.ButtonStartTurn.UseVisualStyleBackColor = False
        Me.ButtonStartTurn.Visible = False
        '
        'LabelRoll
        '
        Me.LabelRoll.AutoSize = True
        Me.LabelRoll.BackColor = System.Drawing.Color.Transparent
        Me.LabelRoll.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRoll.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelRoll.Location = New System.Drawing.Point(932, 166)
        Me.LabelRoll.Name = "LabelRoll"
        Me.LabelRoll.Size = New System.Drawing.Size(141, 20)
        Me.LabelRoll.TabIndex = 26
        Me.LabelRoll.Text = "Roll the dice ----->"
        Me.LabelRoll.Visible = False
        '
        'ButtonYes
        '
        Me.ButtonYes.BackColor = System.Drawing.Color.DarkRed
        Me.ButtonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonYes.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonYes.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.ButtonYes.Location = New System.Drawing.Point(846, 344)
        Me.ButtonYes.Name = "ButtonYes"
        Me.ButtonYes.Size = New System.Drawing.Size(81, 33)
        Me.ButtonYes.TabIndex = 31
        Me.ButtonYes.Text = "Yes"
        Me.ButtonYes.UseVisualStyleBackColor = False
        Me.ButtonYes.Visible = False
        '
        'ButtonNo
        '
        Me.ButtonNo.BackColor = System.Drawing.Color.DarkRed
        Me.ButtonNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNo.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNo.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.ButtonNo.Location = New System.Drawing.Point(983, 344)
        Me.ButtonNo.Name = "ButtonNo"
        Me.ButtonNo.Size = New System.Drawing.Size(81, 33)
        Me.ButtonNo.TabIndex = 32
        Me.ButtonNo.Text = "No"
        Me.ButtonNo.UseVisualStyleBackColor = False
        Me.ButtonNo.Visible = False
        '
        'LabelChange
        '
        Me.LabelChange.BackColor = System.Drawing.Color.Transparent
        Me.LabelChange.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChange.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelChange.Location = New System.Drawing.Point(830, 291)
        Me.LabelChange.Name = "LabelChange"
        Me.LabelChange.Size = New System.Drawing.Size(261, 50)
        Me.LabelChange.TabIndex = 33
        Me.LabelChange.Text = "Do you want to change the position of the snakes and ladders?"
        Me.LabelChange.Visible = False
        '
        'ButtonSUVAT
        '
        Me.ButtonSUVAT.BackColor = System.Drawing.Color.DarkRed
        Me.ButtonSUVAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSUVAT.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSUVAT.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.ButtonSUVAT.Location = New System.Drawing.Point(1116, 577)
        Me.ButtonSUVAT.Name = "ButtonSUVAT"
        Me.ButtonSUVAT.Size = New System.Drawing.Size(118, 65)
        Me.ButtonSUVAT.TabIndex = 34
        Me.ButtonSUVAT.Text = "SUVAT calculator"
        Me.ButtonSUVAT.UseVisualStyleBackColor = False
        Me.ButtonSUVAT.Visible = False
        '
        'PictureBoxSpecialSquare2
        '
        Me.PictureBoxSpecialSquare2.BackColor = System.Drawing.Color.Plum
        Me.PictureBoxSpecialSquare2.Location = New System.Drawing.Point(180, 648)
        Me.PictureBoxSpecialSquare2.Name = "PictureBoxSpecialSquare2"
        Me.PictureBoxSpecialSquare2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBoxSpecialSquare2.TabIndex = 30
        Me.PictureBoxSpecialSquare2.TabStop = False
        Me.PictureBoxSpecialSquare2.Visible = False
        '
        'PictureBoxSpecialSquare3
        '
        Me.PictureBoxSpecialSquare3.BackColor = System.Drawing.Color.Plum
        Me.PictureBoxSpecialSquare3.Location = New System.Drawing.Point(228, 648)
        Me.PictureBoxSpecialSquare3.Name = "PictureBoxSpecialSquare3"
        Me.PictureBoxSpecialSquare3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBoxSpecialSquare3.TabIndex = 29
        Me.PictureBoxSpecialSquare3.TabStop = False
        Me.PictureBoxSpecialSquare3.Visible = False
        '
        'PictureBoxSpecialSquare4
        '
        Me.PictureBoxSpecialSquare4.BackColor = System.Drawing.Color.Plum
        Me.PictureBoxSpecialSquare4.Location = New System.Drawing.Point(270, 647)
        Me.PictureBoxSpecialSquare4.Name = "PictureBoxSpecialSquare4"
        Me.PictureBoxSpecialSquare4.Size = New System.Drawing.Size(20, 20)
        Me.PictureBoxSpecialSquare4.TabIndex = 28
        Me.PictureBoxSpecialSquare4.TabStop = False
        Me.PictureBoxSpecialSquare4.Visible = False
        '
        'PictureBoxSpecialSquare1
        '
        Me.PictureBoxSpecialSquare1.BackColor = System.Drawing.Color.Plum
        Me.PictureBoxSpecialSquare1.Location = New System.Drawing.Point(135, 648)
        Me.PictureBoxSpecialSquare1.Name = "PictureBoxSpecialSquare1"
        Me.PictureBoxSpecialSquare1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBoxSpecialSquare1.TabIndex = 27
        Me.PictureBoxSpecialSquare1.TabStop = False
        Me.PictureBoxSpecialSquare1.Visible = False
        '
        'PictureBoxCounter2
        '
        Me.PictureBoxCounter2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxCounter2.Image = Global.Project.My.Resources.Resources.BulbSmall
        Me.PictureBoxCounter2.Location = New System.Drawing.Point(79, 647)
        Me.PictureBoxCounter2.Name = "PictureBoxCounter2"
        Me.PictureBoxCounter2.Size = New System.Drawing.Size(25, 25)
        Me.PictureBoxCounter2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxCounter2.TabIndex = 16
        Me.PictureBoxCounter2.TabStop = False
        '
        'PictureBoxDice
        '
        Me.PictureBoxDice.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxDice.Enabled = False
        Me.PictureBoxDice.Image = Global.Project.My.Resources.Resources.Dice_1
        Me.PictureBoxDice.Location = New System.Drawing.Point(1079, 124)
        Me.PictureBoxDice.Name = "PictureBoxDice"
        Me.PictureBoxDice.Size = New System.Drawing.Size(100, 100)
        Me.PictureBoxDice.TabIndex = 6
        Me.PictureBoxDice.TabStop = False
        Me.PictureBoxDice.Visible = False
        '
        'PictureBoxCounter1
        '
        Me.PictureBoxCounter1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxCounter1.Image = Global.Project.My.Resources.Resources.CarSmall
        Me.PictureBoxCounter1.Location = New System.Drawing.Point(26, 648)
        Me.PictureBoxCounter1.Name = "PictureBoxCounter1"
        Me.PictureBoxCounter1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBoxCounter1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxCounter1.TabIndex = 5
        Me.PictureBoxCounter1.TabStop = False
        '
        'PictureBoxBoard
        '
        Me.PictureBoxBoard.Image = Global.Project.My.Resources.Resources.BoardLarge
        Me.PictureBoxBoard.Location = New System.Drawing.Point(42, 42)
        Me.PictureBoxBoard.Name = "PictureBoxBoard"
        Me.PictureBoxBoard.Size = New System.Drawing.Size(600, 600)
        Me.PictureBoxBoard.TabIndex = 4
        Me.PictureBoxBoard.TabStop = False
        '
        'TimerComputer
        '
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.SandBackground
        Me.ClientSize = New System.Drawing.Size(1264, 686)
        Me.Controls.Add(Me.ButtonSUVAT)
        Me.Controls.Add(Me.LabelChange)
        Me.Controls.Add(Me.ButtonNo)
        Me.Controls.Add(Me.ButtonYes)
        Me.Controls.Add(Me.PictureBoxSpecialSquare2)
        Me.Controls.Add(Me.PictureBoxSpecialSquare3)
        Me.Controls.Add(Me.PictureBoxSpecialSquare4)
        Me.Controls.Add(Me.PictureBoxSpecialSquare1)
        Me.Controls.Add(Me.LabelRoll)
        Me.Controls.Add(Me.ButtonStartTurn)
        Me.Controls.Add(Me.ButtonAnswer3)
        Me.Controls.Add(Me.ButtonAnswer2)
        Me.Controls.Add(Me.ButtonAnswer1)
        Me.Controls.Add(Me.ButtonAnswer0)
        Me.Controls.Add(Me.ButtonStartGame)
        Me.Controls.Add(Me.LabelTurn)
        Me.Controls.Add(Me.PictureBoxCounter2)
        Me.Controls.Add(Me.ButtonAnswerEnter)
        Me.Controls.Add(Me.TextBoxAnswer)
        Me.Controls.Add(Me.LabelQuestion)
        Me.Controls.Add(Me.PictureBoxDice)
        Me.Controls.Add(Me.PictureBoxCounter1)
        Me.Controls.Add(Me.PictureBoxBoard)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMain"
        CType(Me.PictureBoxSpecialSquare2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSpecialSquare3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSpecialSquare4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSpecialSquare1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCounter2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxDice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCounter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBoxBoard As PictureBox
    Friend WithEvents PictureBoxCounter1 As PictureBox
    Friend WithEvents TimerDice As Timer
    Friend WithEvents LabelQuestion As Label
    Friend WithEvents TextBoxAnswer As TextBox
    Friend WithEvents ButtonAnswerEnter As Button
    Friend WithEvents PictureBoxCounter2 As PictureBox
    Friend WithEvents LabelTurn As Label
    Friend WithEvents ButtonStartGame As Button
    Friend WithEvents ButtonAnswer0 As Button
    Friend WithEvents ButtonAnswer1 As Button
    Friend WithEvents ButtonAnswer2 As Button
    Friend WithEvents ButtonAnswer3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBoxDice As PictureBox
    Friend WithEvents ButtonStartTurn As Button
    Friend WithEvents LabelRoll As Label
    Friend WithEvents PictureBoxSpecialSquare1 As PictureBox
    Friend WithEvents PictureBoxSpecialSquare4 As PictureBox
    Friend WithEvents PictureBoxSpecialSquare3 As PictureBox
    Friend WithEvents PictureBoxSpecialSquare2 As PictureBox
    Friend WithEvents ButtonYes As Button
    Friend WithEvents ButtonNo As Button
    Friend WithEvents LabelChange As Label
    Friend WithEvents ButtonSUVAT As Button
    Friend WithEvents TimerComputer As Timer
End Class
