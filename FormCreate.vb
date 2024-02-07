Public Class FormCreate

    ' If all details are filled in, and password and confirm password match with them being longer than 4 characters, an algorithm will create their UserName, and a SQL query will add a new entry to the Users table.
    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click
        Dim UserName As String
        Dim FirstName As String
        Dim LastName As String
        Dim Password As String
        If String.IsNullOrWhiteSpace(TextBoxFirstName.Text) Or String.IsNullOrWhiteSpace(TextBoxLastName.Text) Or String.IsNullOrWhiteSpace(TextBoxPassword.Text) Or String.IsNullOrWhiteSpace(TextBoxConfirmPassword.Text) Then
            MessageBox.Show("Please fill in all details")
            TextBoxPassword.Text = Nothing
            TextBoxConfirmPassword.Text = Nothing
        Else
            UserName = (TextBoxFirstName.Text(0) & TextBoxLastName.Text).ToLower
            FirstName = StrConv(TextBoxFirstName.Text, VbStrConv.ProperCase)
            LastName = StrConv(TextBoxLastName.Text, VbStrConv.ProperCase)
            If TextBoxPassword.Text = TextBoxConfirmPassword.Text Then
                Password = TextBoxConfirmPassword.Text
                If Len(Password) >= 5 Then
                    Dim DbAccess As New DbControl
                    DbAccess.ExecuteQuery("INSERT INTO Users ([UserName], [Password], [FirstName], [LastName]) VALUES ('" & UserName & "', '" & Password & "', '" & FirstName & "', '" & LastName & "')")
                    MessageBox.Show("User created" & vbNewLine & vbNewLine & "UserName = " & UserName)
                    If FormSetup.CreateButton = 1 Then
                        FormSetup.TextBoxUsername1.Text = UserName
                        FormSetup.TextBoxPassword1.Text = ""
                    Else
                        FormSetup.TextBoxUsername2.Text = UserName
                        FormSetup.TextBoxPassword2.Text = ""
                    End If
                    Me.Close()
                Else
                    MessageBox.Show("Passwords have to be at least 5 characters long")
                    TextBoxPassword.Text = Nothing
                    TextBoxConfirmPassword.Text = Nothing
                End If
            Else
                MessageBox.Show("Passwords do not match")
                TextBoxPassword.Text = Nothing
                TextBoxConfirmPassword.Text = Nothing
            End If
        End If
    End Sub

    ' Closes the form when this is pressed.
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

End Class