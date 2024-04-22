<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Feedback
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label1 = New Label()
        Feedback_Textbox = New TextBox()
        Feedback_Submit_Button = New Button()
        Feedback_Exit_Button = New Button()
        Label2 = New Label()
        Feedback_back_button = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 107)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 20.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Label1.Location = New Point(328, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 33)
        Label1.TabIndex = 4
        Label1.Text = "FEEDBACK"
        ' 
        ' Feedback_Textbox
        ' 
        Feedback_Textbox.Location = New Point(193, 258)
        Feedback_Textbox.Name = "Feedback_Textbox"
        Feedback_Textbox.Size = New Size(400, 24)
        Feedback_Textbox.TabIndex = 0
        ' 
        ' Feedback_Submit_Button
        ' 
        Feedback_Submit_Button.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Feedback_Submit_Button.Font = New Font("Tahoma", 13.25F)
        Feedback_Submit_Button.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Feedback_Submit_Button.Location = New Point(643, 250)
        Feedback_Submit_Button.Name = "Feedback_Submit_Button"
        Feedback_Submit_Button.Size = New Size(75, 35)
        Feedback_Submit_Button.TabIndex = 2
        Feedback_Submit_Button.Text = "Submit"
        Feedback_Submit_Button.UseVisualStyleBackColor = False
        ' 
        ' Feedback_Exit_Button
        ' 
        Feedback_Exit_Button.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Feedback_Exit_Button.Font = New Font("Tahoma", 13.25F)
        Feedback_Exit_Button.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Feedback_Exit_Button.Location = New Point(452, 383)
        Feedback_Exit_Button.Name = "Feedback_Exit_Button"
        Feedback_Exit_Button.Size = New Size(75, 36)
        Feedback_Exit_Button.TabIndex = 3
        Feedback_Exit_Button.Text = "Exit"
        Feedback_Exit_Button.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 13.25F)
        Label2.Location = New Point(39, 189)
        Label2.Name = "Label2"
        Label2.Size = New Size(279, 22)
        Label2.TabIndex = 5
        Label2.Text = "Please provide your kind feedback"
        ' 
        ' Feedback_back_button
        ' 
        Feedback_back_button.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Feedback_back_button.Font = New Font("Tahoma", 13.25F)
        Feedback_back_button.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Feedback_back_button.Location = New Point(264, 383)
        Feedback_back_button.Name = "Feedback_back_button"
        Feedback_back_button.Size = New Size(75, 36)
        Feedback_back_button.TabIndex = 6
        Feedback_back_button.Text = "Back"
        Feedback_back_button.UseVisualStyleBackColor = False
        ' 
        ' Feedback
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        ClientSize = New Size(800, 480)
        Controls.Add(Feedback_back_button)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(Feedback_Textbox)
        Controls.Add(Feedback_Submit_Button)
        Controls.Add(Feedback_Exit_Button)
        Font = New Font("Tahoma", 10F)
        FormBorderStyle = FormBorderStyle.None
        Name = "Feedback"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Feedback"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Feedback_Textbox As TextBox
    Friend WithEvents Feedback_Submit_Button As Button
    Friend WithEvents Feedback_Exit_Button As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Feedback_back_button As Button
End Class
