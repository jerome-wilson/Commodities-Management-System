Imports Microsoft.Data.SqlClient

Public Class Login

    Private Con As String = "Data Source=DESKTOP-QB6D8F6\SQLEXPRESS;Initial Catalog=CommoditiesDatabase;Integrated Security=True;Trust Server Certificate=True"

    Public Sub SetCredentials(username As String, password As String)
        txt_username.Text = username
        txt_password.Text = password
    End Sub

    Private Sub Button_signin_Click(sender As Object, e As EventArgs) Handles Button_signin.Click

        Dim enteredUsername As String = txt_username.Text
        Dim enteredPassword As String = txt_password.Text

        If CheckCredentials(enteredUsername, enteredPassword) Then
            Dim itemPageForm As New Itemspage()
            itemPageForm.Show()
            Me.Hide()
            itemPageForm.Activate()
            itemPageForm.items_itemid_txtbox.Focus()

        Else
            MessageBox.Show("Invalid credentials")
            txt_password.Clear()
            txt_password.Focus()
        End If
        txt_username.Clear()
        txt_password.Clear()
    End Sub

    Private Function CheckCredentials(username As String, password As String) As Boolean
        Using connection As New SqlConnection(Con)
            Try
                connection.Open()
                Dim query As String = "SELECT COUNT(1) FROM Regi WHERE Username = @Username AND ConfirmPassword = @Password"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@Password", password)
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    If count = 1 Then
                        Return True
                    Else
                        Return False
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error checking credentials: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    Private Sub Button_exit_Click(sender As Object, e As EventArgs) Handles Button_exit.Click
        Application.Exit()
    End Sub

    Private Sub txt_username_TextChanged(sender As Object, e As EventArgs) Handles txt_username.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Registation_page_directory_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Registation_page_directory.LinkClicked
        Dim registrationForm As New Registration()
        registrationForm.LoginInstance = Me
        registrationForm.Show()
        registrationForm.FocusUserNameTextBox()
        Me.Hide()
    End Sub


    Private Sub txt_username_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_username.KeyDown
        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True

            txt_password.Focus()
        End If
    End Sub

    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Keys.Enter Then

            Button_signin.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub


End Class
