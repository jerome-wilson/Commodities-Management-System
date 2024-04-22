Public Class Feedback
    Private Sub Feedback_Exit_Button_Click(sender As Object, e As EventArgs) Handles Feedback_Exit_Button.Click
        Application.Exit()
    End Sub

    Private Sub Feedback_Submit_Button_Click(sender As Object, e As EventArgs) Handles Feedback_Submit_Button.Click
        MessageBox.Show("Submition Successful, THANK YOU")
        Feedback_Textbox.Clear()
    End Sub

    Private Sub Feedback_back_button_Click(sender As Object, e As EventArgs) Handles Feedback_back_button.Click
        Me.Close()
        Billing.Show()
    End Sub
End Class