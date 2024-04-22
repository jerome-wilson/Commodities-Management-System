Public Class AdminLogin

    Private Sub Admin_login_Button_Click(sender As Object, e As EventArgs) Handles Admin_login_Button.Click
        Dim adminId As String = AdminID_Textbox.Text
        Dim password As String = Admin_Password_TextBox.Text

        If adminId = "admin" AndAlso password = "pass" Then
            Dim registrationListForm As New RegistrationList()
            registrationListForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid admin ID or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Admin_exit_Click(sender As Object, e As EventArgs) Handles Admin_exit.Click
        Application.Exit()
    End Sub

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AdminID_Textbox_KeyDown(sender As Object, e As KeyEventArgs) Handles AdminID_Textbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Admin_Password_TextBox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Admin_Password_TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Admin_Password_TextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Admin_login_Button.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub Admin_login_Button_KeyDown(sender As Object, e As KeyEventArgs) Handles Admin_login_Button.KeyDown
        If e.KeyCode = Keys.Enter Then
            Admin_login_Button.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub AdminLogin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        AdminID_Textbox.Focus()
    End Sub

    Private Sub Billing_Exit_Click(sender As Object, e As EventArgs) Handles Billing_Exit.Click
        Application.Exit()
    End Sub
End Class
