
Imports System.Drawing.Printing

Public Class Billing

    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With BillDGV.Columns
            .Add("ItemIdColumn", "Item ID")
            .Add("ItemNameColumn", "Item Name")
            .Add("PriceColumn", "Price")
            .Add("QuantityColumn", "Quantity")
            .Add("TotalPriceColumn", "Total Price")
        End With
    End Sub

    Private Sub billing_add_button_Click(sender As Object, e As EventArgs) Handles billing_add_button.Click
        Try

            Dim itemId As String = billing_itemid_txtbox.Text
            Dim itemName As String = billing_itemname_txtbox.Text
            Dim quantity As Integer = Convert.ToInt32(billing_quantity_txtbox.Text)
            Dim price As Decimal = Convert.ToDecimal(billing_price_txtbox.Text)
            Dim totalItemPrice As Decimal = quantity * price


            BillDGV.Rows.Add(New String() {itemId, itemName, price.ToString(), quantity.ToString(), totalItemPrice.ToString()})


            UpdateTotal()
        Catch ex As FormatException
            MessageBox.Show("Please enter valid numbers for quantity and price.")
        Catch ex As OverflowException
            MessageBox.Show("The numbers entered are too large.")
        Catch ex As Exception
            MessageBox.Show($"An unexpected error occurred: {ex.Message}")
        End Try
    End Sub

    Private Sub billing_reset_button_Click(sender As Object, e As EventArgs) Handles billing_reset_button.Click

        billing_itemid_txtbox.Clear()
        billing_itemname_txtbox.Clear()
        billing_quantity_txtbox.Clear()
        billing_price_txtbox.Clear()
        billing_total_txtbox.Clear()


    End Sub

    Private Sub UpdateTotal()

        Dim total As Decimal = 0
        For Each row As DataGridViewRow In BillDGV.Rows
            total += Convert.ToDecimal(row.Cells("PriceColumn").Value) * Convert.ToInt32(row.Cells("QuantityColumn").Value)
        Next
        billing_total_txtbox.Text = total.ToString("C2")
    End Sub


    Private Sub Billing_Exit_Button_Click(sender As Object, e As EventArgs) Handles Billing_Exit_Button.Click
        Close()
        Itemspage.Show()
    End Sub

    Private Sub billing_edit_button_Click(sender As Object, e As EventArgs) Handles billing_edit_button.Click
        If BillDGV.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = BillDGV.SelectedRows(0).Index

            Dim itemId As String = BillDGV.Rows(selectedRowIndex).Cells("ItemIdColumn").Value.ToString()
            Dim itemName As String = BillDGV.Rows(selectedRowIndex).Cells("ItemNameColumn").Value.ToString()
            Dim price As Decimal = Convert.ToDecimal(BillDGV.Rows(selectedRowIndex).Cells("PriceColumn").Value)
            Dim quantity As Integer = Convert.ToInt32(BillDGV.Rows(selectedRowIndex).Cells("QuantityColumn").Value)

            billing_itemid_txtbox.Text = itemId
            billing_itemname_txtbox.Text = itemName
            billing_price_txtbox.Text = price.ToString()
            billing_quantity_txtbox.Text = quantity.ToString()

            BillDGV.Rows.RemoveAt(selectedRowIndex)

            UpdateTotal()
        Else
            MessageBox.Show("Please select a row to edit.")
        End If
    End Sub
    Private Sub billing_delete_button_Click(sender As Object, e As EventArgs) Handles billing_delete_button.Click

        If BillDGV.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = BillDGV.SelectedRows(0)

            If Not selectedRow.IsNewRow Then
                BillDGV.Rows.Remove(selectedRow)

                UpdateTotal()
            Else
                MessageBox.Show("Cannot delete the new row placeholder.")
            End If
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub Billing_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        billing_itemid_txtbox.Focus()
    End Sub

    Private Sub billing_itemid_txtbox_KeyDown(sender As Object, e As KeyEventArgs) Handles billing_itemid_txtbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            billing_itemname_txtbox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub billing_itemname_txtbox_KeyDown(sender As Object, e As KeyEventArgs) Handles billing_itemname_txtbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            billing_quantity_txtbox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub billing_quantity_txtbox_KeyDown(sender As Object, e As KeyEventArgs) Handles billing_quantity_txtbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            billing_price_txtbox.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub billing_price_txtbox_KeyDown(sender As Object, e As KeyEventArgs) Handles billing_price_txtbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            billing_add_button.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub billing_add_button_KeyDown(sender As Object, e As KeyEventArgs) Handles billing_add_button.KeyDown
        If e.KeyCode = Keys.Enter Then
            billing_add_button.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub


    Private Sub BillDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BillDGV.CellContentClick

    End Sub

    Private Sub Feedback_LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Feedback_LinkLabel.LinkClicked
        Me.Hide()
        Feedback.Show()
    End Sub

    Private Sub Billing_Exit_Click(sender As Object, e As EventArgs) Handles Billing_Exit.Click
        Application.Exit()
    End Sub

    Private Sub Billing_Print_Button_Click(sender As Object, e As EventArgs) Handles Billing_Print_Button.Click
        If String.IsNullOrEmpty(billing_itemid_txtbox.Text) Then
            MessageBox.Show("Please enter the Item ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf BillDGV.Rows.Count = 0 Then
            MessageBox.Show("There are no items in the bill to print.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else


            Try
                ' Show print preview dialog
                PrintPreviewDialog1.ShowDialog()

                ' Print the document
                PrintDocument1.Print()
            Catch ex As Exception
                MessageBox.Show("An error occurred while printing: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim backgroundColor As New SolidBrush(Color.FromArgb(255, 255, 192)) ' Light yellow
        Dim headerTextColor As New SolidBrush(Color.FromArgb(192, 0, 0)) ' Dark red
        Dim textColor As New SolidBrush(Color.Black) ' Normal text color
        Dim drawFont As New Font("Cambria", 17)
        Dim drawBrush As New SolidBrush(Color.Black)
        Dim x As Integer = 10
        Dim y As Integer = 100
        Dim columnSpacing As Integer = 100 ' Additional space between columns

        ' Draw "Garment Accessories Shop" and other header information
        e.Graphics.DrawString("Garment Accessories Shop", drawFont, drawBrush, New PointF(20, 10))
        e.Graphics.DrawString("YOUR BILL*", drawFont, drawBrush, New PointF(10, 52))

        ' Draw column headers
        For Each headerCell As DataGridViewColumn In BillDGV.Columns
            e.Graphics.DrawString(headerCell.HeaderText, drawFont, drawBrush, New PointF(x, y))
            x += headerCell.Width + columnSpacing ' Add extra space after each column
        Next

        ' Reset x to starting position and move y down to start drawing data rows
        y += drawFont.Height + 5 ' Additional space between header and row content
        For Each row As DataGridViewRow In BillDGV.Rows
            x = 10 ' Reset x to the initial position for each row
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing Then ' Check if the cell value is not null
                    e.Graphics.DrawString(cell.Value.ToString(), drawFont, drawBrush, New PointF(x, y))
                    x += cell.OwningColumn.Width + columnSpacing ' Add extra space after each column
                End If
            Next
            y += row.Height ' Move to the next row
        Next

        ' Draw total amount and footer
        e.Graphics.DrawString("Total Amount Rs " & (If(billing_total_txtbox IsNot Nothing, billing_total_txtbox.Text, "N/A")), drawFont, drawBrush, New PointF(10, y + 20))
        e.Graphics.DrawString("Thanks For Buying*", drawFont, drawBrush, New PointF(10, y + 50))

        ' Dispose of resources
        drawFont.Dispose()
        drawBrush.Dispose()
    End Sub


    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub


End Class