<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registration))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        Registration_Name_TextBox = New TextBox()
        Registration_Email_Textbox = New TextBox()
        Registration_UserName_TextBox = New TextBox()
        Registration_Address_TextBox = New TextBox()
        Registration_Phone_TextBox = New TextBox()
        Registration_EnterPassword_Textbox = New TextBox()
        Registration_Gender_Combobox = New ComboBox()
        Panel1 = New Panel()
        Registration_Exit = New PictureBox()
        Registration_Label = New Label()
        Label7 = New Label()
        Registration_ConfirmPassword_Textbox = New TextBox()
        Registration_Register_Button = New Button()
        Registration_Exit_Button = New Button()
        Registration_View_Button = New Button()
        Panel1.SuspendLayout()
        CType(Registration_Exit, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 14.25F)
        Label1.Location = New Point(93, 204)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 23)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 14.25F)
        Label2.Location = New Point(80, 273)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 23)
        Label2.TabIndex = 1
        Label2.Text = "Gender"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 14.25F)
        Label3.Location = New Point(97, 350)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 23)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 14.25F)
        Label4.Location = New Point(58, 139)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 23)
        Label4.TabIndex = 3
        Label4.Text = "Username"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 14.25F)
        Label5.Location = New Point(503, 134)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 23)
        Label5.TabIndex = 4
        Label5.Text = "Address"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 14.25F)
        Label6.Location = New Point(517, 204)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 23)
        Label6.TabIndex = 5
        Label6.Text = "Phone"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 14.25F)
        Label8.Location = New Point(440, 277)
        Label8.Name = "Label8"
        Label8.Size = New Size(139, 23)
        Label8.TabIndex = 7
        Label8.Text = "Enter Password"
        ' 
        ' Registration_Name_TextBox
        ' 
        Registration_Name_TextBox.Font = New Font("Tahoma", 14.25F)
        Registration_Name_TextBox.Location = New Point(185, 204)
        Registration_Name_TextBox.Name = "Registration_Name_TextBox"
        Registration_Name_TextBox.Size = New Size(174, 30)
        Registration_Name_TextBox.TabIndex = 8
        ' 
        ' Registration_Email_Textbox
        ' 
        Registration_Email_Textbox.Font = New Font("Tahoma", 14.25F)
        Registration_Email_Textbox.Location = New Point(185, 343)
        Registration_Email_Textbox.Name = "Registration_Email_Textbox"
        Registration_Email_Textbox.Size = New Size(174, 30)
        Registration_Email_Textbox.TabIndex = 10
        ' 
        ' Registration_UserName_TextBox
        ' 
        Registration_UserName_TextBox.Font = New Font("Tahoma", 14.25F)
        Registration_UserName_TextBox.Location = New Point(185, 135)
        Registration_UserName_TextBox.Name = "Registration_UserName_TextBox"
        Registration_UserName_TextBox.Size = New Size(174, 30)
        Registration_UserName_TextBox.TabIndex = 11
        ' 
        ' Registration_Address_TextBox
        ' 
        Registration_Address_TextBox.Font = New Font("Tahoma", 14.25F)
        Registration_Address_TextBox.Location = New Point(614, 131)
        Registration_Address_TextBox.Name = "Registration_Address_TextBox"
        Registration_Address_TextBox.Size = New Size(174, 30)
        Registration_Address_TextBox.TabIndex = 12
        ' 
        ' Registration_Phone_TextBox
        ' 
        Registration_Phone_TextBox.Font = New Font("Tahoma", 14.25F)
        Registration_Phone_TextBox.Location = New Point(614, 204)
        Registration_Phone_TextBox.Name = "Registration_Phone_TextBox"
        Registration_Phone_TextBox.Size = New Size(174, 30)
        Registration_Phone_TextBox.TabIndex = 13
        ' 
        ' Registration_EnterPassword_Textbox
        ' 
        Registration_EnterPassword_Textbox.Font = New Font("Tahoma", 14.25F)
        Registration_EnterPassword_Textbox.Location = New Point(614, 277)
        Registration_EnterPassword_Textbox.Name = "Registration_EnterPassword_Textbox"
        Registration_EnterPassword_Textbox.Size = New Size(174, 30)
        Registration_EnterPassword_Textbox.TabIndex = 14
        Registration_EnterPassword_Textbox.UseSystemPasswordChar = True
        ' 
        ' Registration_Gender_Combobox
        ' 
        Registration_Gender_Combobox.Font = New Font("Tahoma", 14.25F)
        Registration_Gender_Combobox.FormattingEnabled = True
        Registration_Gender_Combobox.Items.AddRange(New Object() {"Male", "Female", "Other", "Prefer not to say"})
        Registration_Gender_Combobox.Location = New Point(185, 270)
        Registration_Gender_Combobox.Name = "Registration_Gender_Combobox"
        Registration_Gender_Combobox.Size = New Size(174, 31)
        Registration_Gender_Combobox.TabIndex = 15
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Panel1.Controls.Add(Registration_Exit)
        Panel1.Controls.Add(Registration_Label)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(878, 87)
        Panel1.TabIndex = 16
        ' 
        ' Registration_Exit
        ' 
        Registration_Exit.Image = CType(resources.GetObject("Registration_Exit.Image"), Image)
        Registration_Exit.Location = New Point(843, 0)
        Registration_Exit.Name = "Registration_Exit"
        Registration_Exit.Size = New Size(35, 34)
        Registration_Exit.SizeMode = PictureBoxSizeMode.StretchImage
        Registration_Exit.TabIndex = 23
        Registration_Exit.TabStop = False
        ' 
        ' Registration_Label
        ' 
        Registration_Label.AutoSize = True
        Registration_Label.Font = New Font("Tahoma", 20.25F, FontStyle.Bold)
        Registration_Label.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Registration_Label.Location = New Point(326, 23)
        Registration_Label.Name = "Registration_Label"
        Registration_Label.Size = New Size(229, 33)
        Registration_Label.TabIndex = 17
        Registration_Label.Text = "REGISTRATION"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 14.25F)
        Label7.Location = New Point(420, 350)
        Label7.Name = "Label7"
        Label7.Size = New Size(159, 23)
        Label7.TabIndex = 17
        Label7.Text = "Confirm Password"
        ' 
        ' Registration_ConfirmPassword_Textbox
        ' 
        Registration_ConfirmPassword_Textbox.Font = New Font("Tahoma", 14.25F)
        Registration_ConfirmPassword_Textbox.Location = New Point(614, 347)
        Registration_ConfirmPassword_Textbox.Name = "Registration_ConfirmPassword_Textbox"
        Registration_ConfirmPassword_Textbox.Size = New Size(174, 30)
        Registration_ConfirmPassword_Textbox.TabIndex = 18
        Registration_ConfirmPassword_Textbox.UseSystemPasswordChar = True
        ' 
        ' Registration_Register_Button
        ' 
        Registration_Register_Button.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Registration_Register_Button.Font = New Font("Tahoma", 14.25F)
        Registration_Register_Button.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Registration_Register_Button.Location = New Point(374, 430)
        Registration_Register_Button.Name = "Registration_Register_Button"
        Registration_Register_Button.Size = New Size(116, 46)
        Registration_Register_Button.TabIndex = 19
        Registration_Register_Button.Text = "Register"
        Registration_Register_Button.UseVisualStyleBackColor = False
        ' 
        ' Registration_Exit_Button
        ' 
        Registration_Exit_Button.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Registration_Exit_Button.Font = New Font("Tahoma", 14.25F)
        Registration_Exit_Button.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Registration_Exit_Button.Location = New Point(215, 430)
        Registration_Exit_Button.Name = "Registration_Exit_Button"
        Registration_Exit_Button.Size = New Size(116, 46)
        Registration_Exit_Button.TabIndex = 20
        Registration_Exit_Button.Text = "Back"
        Registration_Exit_Button.UseVisualStyleBackColor = False
        ' 
        ' Registration_View_Button
        ' 
        Registration_View_Button.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Registration_View_Button.Font = New Font("Tahoma", 14.25F)
        Registration_View_Button.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Registration_View_Button.Location = New Point(531, 430)
        Registration_View_Button.Name = "Registration_View_Button"
        Registration_View_Button.Size = New Size(116, 46)
        Registration_View_Button.TabIndex = 22
        Registration_View_Button.Text = "View"
        Registration_View_Button.UseVisualStyleBackColor = False
        ' 
        ' Registration
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        ClientSize = New Size(878, 537)
        Controls.Add(Registration_View_Button)
        Controls.Add(Registration_Exit_Button)
        Controls.Add(Registration_Register_Button)
        Controls.Add(Registration_ConfirmPassword_Textbox)
        Controls.Add(Label7)
        Controls.Add(Panel1)
        Controls.Add(Registration_Gender_Combobox)
        Controls.Add(Registration_EnterPassword_Textbox)
        Controls.Add(Registration_Phone_TextBox)
        Controls.Add(Registration_Address_TextBox)
        Controls.Add(Registration_UserName_TextBox)
        Controls.Add(Registration_Email_Textbox)
        Controls.Add(Registration_Name_TextBox)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Tahoma", 10F)
        FormBorderStyle = FormBorderStyle.None
        Name = "Registration"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registration"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(Registration_Exit, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Registration_Name_TextBox As TextBox
    Friend WithEvents Registration_Email_Textbox As TextBox
    Friend WithEvents Registration_UserName_TextBox As TextBox
    Friend WithEvents Registration_Address_TextBox As TextBox
    Friend WithEvents Registration_Phone_TextBox As TextBox
    Friend WithEvents Registration_EnterPassword_Textbox As TextBox
    Friend WithEvents Registration_Gender_Combobox As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Registration_Label As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Registration_ConfirmPassword_Textbox As TextBox
    Friend WithEvents Registration_Register_Button As Button
    Friend WithEvents Registration_Exit_Button As Button

    Private Sub Registration_Name_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Registration_Name_TextBox.TextChanged

    End Sub

    Private Sub Registration_Gender_Combobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Registration_Gender_Combobox.SelectedIndexChanged

    End Sub

    Private Sub Registration_Email_Textbox_TextChanged(sender As Object, e As EventArgs) Handles Registration_Email_Textbox.TextChanged

    End Sub

    Private Sub Registration_UserName_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Registration_UserName_TextBox.TextChanged

    End Sub

    Private Sub Registration_Address_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Registration_Address_TextBox.TextChanged

    End Sub

    Private Sub Registration_Phone_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Registration_Phone_TextBox.TextChanged

    End Sub

    Private Sub Registration_EnterPassword_Textbox_TextChanged(sender As Object, e As EventArgs) Handles Registration_EnterPassword_Textbox.TextChanged

    End Sub

    Private Sub Registration_ConfirmPassword_Textbox_TextChanged(sender As Object, e As EventArgs) Handles Registration_ConfirmPassword_Textbox.TextChanged

    End Sub

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Friend WithEvents Registration_View_Button As Button
    Friend WithEvents Registration_Exit As PictureBox
End Class
