Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class RegistrationList
    Dim connectionString As String = "Data Source=DESKTOP-QB6D8F6\SQLEXPRESS;Initial Catalog=CommoditiesDatabase;Integrated Security=True;Trust Server Certificate=True"

    Private Sub RegistrationList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayRegisteredUsers()
    End Sub
    Public Sub DisplayRegisteredUsers()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT Username, Name, Gender, Email, Address, Phone FROM Regi"
                Using command As New SqlCommand(query, connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        RegisteredUserList_Guna2DataGridView.DataSource = table
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error displaying registered users: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Reg_Users_Edit_Button_Click(sender As Object, e As EventArgs) Handles Reg_Users_Edit_Button.Click
        If RegisteredUserList_Guna2DataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = RegisteredUserList_Guna2DataGridView.SelectedRows(0)
            With Registration
                .Registration_UserName_TextBox.Text = selectedRow.Cells("Username").Value.ToString()
                .Registration_Name_TextBox.Text = selectedRow.Cells("Name").Value.ToString()
                .Registration_Gender_Combobox.SelectedIndex = .Registration_Gender_Combobox.Items.IndexOf(selectedRow.Cells("Gender").Value.ToString())
                .Registration_Email_Textbox.Text = selectedRow.Cells("Email").Value.ToString()
                .Registration_Address_TextBox.Text = selectedRow.Cells("Address").Value.ToString()
                .Registration_Phone_TextBox.Text = selectedRow.Cells("Phone").Value.ToString()

                .IsEditing = True
                .CurrentEditingUsername = selectedRow.Cells("Username").Value.ToString()

                .Show()
                Me.Hide()
            End With
        Else
            MessageBox.Show("Please select a row to edit.")
        End If
    End Sub

    Private Sub RegistrationList_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        If Me.Visible Then
            DisplayRegisteredUsers()
        End If
    End Sub


    Private Sub Reg_Users_Delete_Button_Click(sender As Object, e As EventArgs) Handles Reg_Users_Delete_Button.Click
        If RegisteredUserList_Guna2DataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = RegisteredUserList_Guna2DataGridView.SelectedRows(0)
            Dim username As String = selectedRow.Cells("Username").Value.ToString()
            DeleteUserByUsername(username)
            DisplayRegisteredUsers()
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub DeleteUserByUsername(username As String)
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "DELETE FROM Regi WHERE Username = @Username"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", username)
                    If command.ExecuteNonQuery() > 0 Then
                        MessageBox.Show("User deleted successfully.")
                    Else
                        MessageBox.Show("User not found.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error deleting user: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Reg_Users_Back_Button_Click(sender As Object, e As EventArgs) Handles Reg_Users_Back_Button.Click
        Me.Hide()
        Registration.Show()
    End Sub

    Private Sub RegistrationList_Exit_Click(sender As Object, e As EventArgs) Handles RegistrationList_Exit.Click
        Application.Exit()
    End Sub
End Class
