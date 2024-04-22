Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Registration

    Dim connectionString As String = "Data Source=DESKTOP-QB6D8F6\SQLEXPRESS;Initial Catalog=CommoditiesDatabase;Integrated Security=True;Trust Server Certificate=True"
    Public IsEditing As Boolean = False
    Public CurrentEditingUsername As String = ""
    Public LoginInstance As Login


    Private Sub Registration_Exit_Button_Click(sender As Object, e As EventArgs) Handles Registration_Exit_Button.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub Registration_Register_Button_Click(sender As Object, e As EventArgs) Handles Registration_Register_Button.Click
        If ValidateInputs() Then
            If IsEditing Then
                If UpdateUser() Then
                    MessageBox.Show("Update successful!")
                    If LoginInstance IsNot Nothing Then
                        LoginInstance.SetCredentials(CurrentEditingUsername, Registration_EnterPassword_Textbox.Text)
                        Me.Hide()
                        LoginInstance.Show()
                    Else
                        MessageBox.Show("Login instance not set.")
                    End If
                Else
                    MessageBox.Show("Update failed. Please try again.")
                End If
            Else
                If RegisterUser() Then
                    MessageBox.Show("Registration successful!")
                    If LoginInstance IsNot Nothing Then
                        LoginInstance.SetCredentials(Registration_UserName_TextBox.Text, Registration_EnterPassword_Textbox.Text)
                        Me.Hide()
                        LoginInstance.Show()
                    Else
                        MessageBox.Show("Login instance not set.")
                    End If
                Else
                    MessageBox.Show("Registration failed. Please try again.")
                End If
            End If
            ClearInputs()
        Else
            MessageBox.Show("Please fill all the fields and ensure passwords match.")
        End If
    End Sub

    Private Function UpdateUser() As Boolean
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "UPDATE Regi SET Name = @Name, Gender = @Gender, Email = @Email, Address = @Address, Phone = @Phone WHERE Username = @Username"
                Using command As New SqlCommand(query, connection)

                    command.Parameters.AddWithValue("@Username", CurrentEditingUsername)
                    command.Parameters.AddWithValue("@Name", Registration_Name_TextBox.Text)
                    command.Parameters.AddWithValue("@Gender", Registration_Gender_Combobox.Text)
                    command.Parameters.AddWithValue("@Email", Registration_Email_Textbox.Text)
                    command.Parameters.AddWithValue("@Address", Registration_Address_TextBox.Text)
                    command.Parameters.AddWithValue("@Phone", Registration_Phone_TextBox.Text)
                    command.ExecuteNonQuery()
                End Using
                Return True
            Catch ex As Exception
                MessageBox.Show("Error updating user: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrEmpty(Registration_UserName_TextBox.Text) OrElse
            String.IsNullOrEmpty(Registration_Name_TextBox.Text) OrElse
            String.IsNullOrEmpty(Registration_Gender_Combobox.Text) OrElse
            String.IsNullOrEmpty(Registration_Email_Textbox.Text) OrElse
            String.IsNullOrEmpty(Registration_Address_TextBox.Text) OrElse
            String.IsNullOrEmpty(Registration_Phone_TextBox.Text) OrElse
            String.IsNullOrEmpty(Registration_EnterPassword_Textbox.Text) OrElse
            String.IsNullOrEmpty(Registration_ConfirmPassword_Textbox.Text) Then
            Return False
        ElseIf Registration_EnterPassword_Textbox.Text <> Registration_ConfirmPassword_Textbox.Text Then
            Return False
        End If
        Return True
    End Function

    Private Function RegisterUser() As Boolean
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO Regi (Username, Name, Gender, Email, Address, Phone, EnterPassword, ConfirmPassword) VALUES (@Username, @Name, @Gender, @Email, @Address, @Phone, @EnterPassword, @ConfirmPassword)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", Registration_UserName_TextBox.Text)
                    command.Parameters.AddWithValue("@Name", Registration_Name_TextBox.Text)
                    command.Parameters.AddWithValue("@Gender", Registration_Gender_Combobox.Text)
                    command.Parameters.AddWithValue("@Email", Registration_Email_Textbox.Text)
                    command.Parameters.AddWithValue("@Address", Registration_Address_TextBox.Text)
                    command.Parameters.AddWithValue("@Phone", Registration_Phone_TextBox.Text)
                    command.Parameters.AddWithValue("@EnterPassword", Registration_EnterPassword_Textbox.Text)
                    command.Parameters.AddWithValue("@ConfirmPassword", Registration_ConfirmPassword_Textbox.Text)
                    command.ExecuteNonQuery()
                End Using
                Return True
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    Private Sub ClearInputs()
        Registration_UserName_TextBox.Clear()
        Registration_Name_TextBox.Clear()
        Registration_Gender_Combobox.SelectedIndex = -1
        Registration_Email_Textbox.Clear()
        Registration_Address_TextBox.Clear()
        Registration_Phone_TextBox.Clear()
        Registration_EnterPassword_Textbox.Clear()
        Registration_ConfirmPassword_Textbox.Clear()
    End Sub

    Private Sub Registration_Delete_Button_Click(sender As Object, e As EventArgs)
        If DeleteLastUpdatedUser() Then

        Else
            MessageBox.Show("Failed to delete the last updated user.")
        End If
    End Sub

    Private Function DeleteLastUpdatedUser() As Boolean
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "DELETE FROM Regi WHERE ID = (SELECT MAX(ID) FROM Regi)"
                Using command As New SqlCommand(query, connection)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        Return True
                    Else
                        MessageBox.Show("No records found to delete.")
                        Return False
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    Public Sub FocusUserNameTextBox()
        Registration_UserName_TextBox.Focus()
    End Sub


    Private Sub Registration_UserName_TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Registration_UserName_TextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Registration_Name_TextBox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Registration_Name_TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Registration_Name_TextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Registration_Gender_Combobox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Registration_Gender_Combobox_KeyDown(sender As Object, e As KeyEventArgs) Handles Registration_Gender_Combobox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Registration_Email_Textbox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Registration_Email_Textbox_KeyDown(sender As Object, e As KeyEventArgs) Handles Registration_Email_Textbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Registration_Address_TextBox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Registration_Address_TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Registration_Address_TextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Registration_Phone_TextBox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Registration_Phone_TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Registration_Phone_TextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Registration_EnterPassword_Textbox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Registration_EnterPassword_Textbox_KeyDown(sender As Object, e As KeyEventArgs) Handles Registration_EnterPassword_Textbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Registration_ConfirmPassword_Textbox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Registration_ConfirmPassword_Textbox_KeyDown(sender As Object, e As KeyEventArgs) Handles Registration_ConfirmPassword_Textbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Registration_Register_Button.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub


    Private Sub Registration_View_Button_Click(sender As Object, e As EventArgs) Handles Registration_View_Button.Click
        MessageBox.Show("Please login as admin to continue")
        Dim adminLoginForm As New AdminLogin()
        adminLoginForm.Show()
        Me.Hide()
        adminLoginForm.Activate()
        adminLoginForm.AdminID_Textbox.Focus()
        AdminLogin.Show()
    End Sub

    Private Sub Registration_Exit_Click(sender As Object, e As EventArgs) Handles Registration_Exit.Click
        Application.Exit()
    End Sub
End Class
