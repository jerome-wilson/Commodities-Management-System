Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports Microsoft.Identity.Client.Cache

Public Class Itemspage
    Private key As Integer = 0
    Private Con As New SqlConnection("Data Source=DESKTOP-QB6D8F6\SQLEXPRESS;Initial Catalog=CommoditiesDatabase;Integrated Security=True;Trust Server Certificate=True")

    Private Sub items_save_Click(sender As Object, e As EventArgs) Handles items_save.Click
        If items_itemid_txtbox.Text = "" OrElse items_itemname_txtbox.Text = "" OrElse items_itemqty_txtbox.Text = "" OrElse items_categories_combobox.SelectedIndex = -1 OrElse items_price_txtbox.Text = "" Then
            MessageBox.Show("Null Values not Accepted")
        Else
            Try
                Dim itemId As Integer = Convert.ToInt32(items_itemid_txtbox.Text)
                If Not IsItemIdUnique(itemId) Then
                    MessageBox.Show("Item ID must be unique.")
                    Return
                End If

                Con.Open()
                Dim query As String = "INSERT INTO ItemsTable (ItemId, ItemName, Quantity, Price, Category) VALUES (@ItemId, @ItemName, @Quantity, @Price, @Category)"
                Using cmd As New SqlCommand(query, Con)
                    cmd.Parameters.AddWithValue("@ItemId", itemId)
                    cmd.Parameters.AddWithValue("@ItemName", items_itemname_txtbox.Text)
                    cmd.Parameters.AddWithValue("@Quantity", items_itemqty_txtbox.Text)
                    cmd.Parameters.AddWithValue("@Price", items_price_txtbox.Text)
                    cmd.Parameters.AddWithValue("@Category", items_categories_combobox.SelectedItem.ToString())
                    cmd.ExecuteNonQuery()
                End Using

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                If Con.State = ConnectionState.Open Then
                    Con.Close()
                End If
                DisplayItem()
            End Try
        End If
    End Sub

    Private Sub items_delete_Click(sender As Object, e As EventArgs) Handles items_delete.Click
        If key = 0 Then
            MessageBox.Show("Please select a record to delete.")
            Return
        End If

        Try
            Con.Open()
            Dim query As String = "DELETE FROM ItemsTable WHERE ItemId = @ItemId"
            Using cmd As New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@ItemId", key)
                Dim result As Integer = cmd.ExecuteNonQuery()
                If result > 0 Then

                Else
                    MessageBox.Show("Record not found.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting the record: " & ex.Message)
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
            DisplayItem()
            Clear()
        End Try
    End Sub


    Private Sub DisplayItem()
        Try
            Con.Open()
            Dim query As String = "SELECT * FROM ItemsTable"
            Using cmd As New SqlCommand(query, Con)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                ItemDGV.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while displaying items: " & ex.Message)
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub
    Private Sub Clear()
        items_itemid_txtbox.Text = ""
        items_itemname_txtbox.Text = ""
        items_itemqty_txtbox.Text = ""
        items_price_txtbox.Text = ""
        items_categories_combobox.SelectedIndex = -1
        key = 0
    End Sub


    Private Sub items_edit_Click(sender As Object, e As EventArgs) Handles items_edit.Click
        If key = 0 Then
            Return
        End If

        If items_itemid_txtbox.Text = "" OrElse items_itemname_txtbox.Text = "" OrElse items_itemqty_txtbox.Text = "" OrElse items_categories_combobox.SelectedIndex = -1 OrElse items_price_txtbox.Text = "" Then
            MessageBox.Show("Please fill in all fields")
        Else
            Try
                Con.Open()

                Dim query As String = "UPDATE ItemsTable SET ItemName = @ItemName, Quantity = @Quantity, Price = @Price, Category = @Category WHERE ItemId = @ItemId"
                Using cmd As New SqlCommand(query, Con)

                    cmd.Parameters.AddWithValue("@ItemName", items_itemname_txtbox.Text)
                    cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(items_itemqty_txtbox.Text))
                    cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(items_price_txtbox.Text))
                    cmd.Parameters.AddWithValue("@Category", items_categories_combobox.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@ItemId", key)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record updated successfully")
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred while updating the record: " & ex.Message)
            Finally
                If Con.State = ConnectionState.Open Then
                    Con.Close()
                End If
                DisplayItem()
                Clear()
            End Try
        End If
    End Sub
    Private Sub ItemsDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemDGV.CellClick

        If e.RowIndex >= 0 Then
            Try

                key = Convert.ToInt32(ItemDGV.Rows(e.RowIndex).Cells("ItemId").Value)

                items_itemid_txtbox.Text = ItemDGV.Rows(e.RowIndex).Cells("ItemId").Value.ToString()
                items_itemname_txtbox.Text = ItemDGV.Rows(e.RowIndex).Cells("ItemName").Value.ToString()
                items_itemqty_txtbox.Text = ItemDGV.Rows(e.RowIndex).Cells("Quantity").Value.ToString()
                items_price_txtbox.Text = ItemDGV.Rows(e.RowIndex).Cells("Price").Value.ToString()
                items_categories_combobox.SelectedItem = ItemDGV.Rows(e.RowIndex).Cells("Category").Value.ToString()

            Catch ex As FormatException

                MessageBox.Show("The item ID is not in the correct format. Please ensure it's a numeric value.", "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As InvalidCastException

                MessageBox.Show("The conversion is not valid. Please check the data type of the item ID.", "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception

                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Function IsItemIdUnique(itemId As Integer) As Boolean
        Dim isUnique As Boolean = True
        Try
            Con.Open()
            Dim query As String = "SELECT COUNT(*) FROM ItemsTable WHERE ItemId = @ItemId"
            Using cmd As New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@ItemId", itemId)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    isUnique = False
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while checking Item ID uniqueness: " & ex.Message)
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
        Return isUnique
    End Function

    Private Sub Itemspage_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        items_itemid_txtbox.Focus()
    End Sub


    Private Sub items_itemid_txtbox_KeyDown(sender As Object, e As KeyEventArgs) Handles items_itemid_txtbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            items_itemname_txtbox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub items_itemname_txtbox_KeyDown(sender As Object, e As KeyEventArgs) Handles items_itemname_txtbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            items_itemqty_txtbox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub items_itemqty_txtbox_KeyDown(sender As Object, e As KeyEventArgs) Handles items_itemqty_txtbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            items_price_txtbox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub items_price_txtbox_KeyDown(sender As Object, e As KeyEventArgs) Handles items_price_txtbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            items_categories_combobox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub items_categories_combobox_KeyDown(sender As Object, e As KeyEventArgs) Handles items_categories_combobox.KeyDown
        If e.KeyCode = Keys.Enter Then
            items_save.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub items_save_KeyDown(sender As Object, e As KeyEventArgs) Handles items_save.KeyDown
        If e.KeyCode = Keys.Enter Then
            items_save.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub


    Private Sub items_clear_Click(sender As Object, e As EventArgs) Handles items_clear.Click
        Clear()
    End Sub

    Private Sub items_billing_Click(sender As Object, e As EventArgs) Handles items_billing.Click
        Me.Hide()
        Billing.Show()
    End Sub

    Private Sub Itemspage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Itemspg_Back_Button_Click(sender As Object, e As EventArgs) Handles Itemspg_Back_Button.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Itemspage_Exit_Click(sender As Object, e As EventArgs) Handles Itemspage_Exit.Click
        Application.Exit()
    End Sub
End Class