<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminLogin))
        Label2 = New Label()
        Label3 = New Label()
        Admin_Password_TextBox = New TextBox()
        AdminID_Textbox = New TextBox()
        Panel1 = New Panel()
        Label1 = New Label()
        Admin_login_Button = New Button()
        Admin_exit = New Button()
        Billing_Exit = New PictureBox()
        Panel1.SuspendLayout()
        CType(Billing_Exit, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 14.25F)
        Label2.Location = New Point(92, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 23)
        Label2.TabIndex = 1
        Label2.Text = "Admin ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 14.25F)
        Label3.Location = New Point(92, 200)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 23)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' Admin_Password_TextBox
        ' 
        Admin_Password_TextBox.Font = New Font("Tahoma", 14.25F)
        Admin_Password_TextBox.Location = New Point(206, 200)
        Admin_Password_TextBox.Name = "Admin_Password_TextBox"
        Admin_Password_TextBox.Size = New Size(183, 30)
        Admin_Password_TextBox.TabIndex = 5
        Admin_Password_TextBox.UseSystemPasswordChar = True
        ' 
        ' AdminID_Textbox
        ' 
        AdminID_Textbox.Font = New Font("Tahoma", 14.25F)
        AdminID_Textbox.Location = New Point(206, 132)
        AdminID_Textbox.Name = "AdminID_Textbox"
        AdminID_Textbox.Size = New Size(183, 30)
        AdminID_Textbox.TabIndex = 6
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(196), CByte(0), CByte(0))
        Panel1.Controls.Add(Billing_Exit)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(519, 80)
        Panel1.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 20.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(196))
        Label1.Location = New Point(151, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(209, 33)
        Label1.TabIndex = 0
        Label1.Text = "ADMIN LOGIN"
        ' 
        ' Admin_login_Button
        ' 
        Admin_login_Button.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Admin_login_Button.Font = New Font("Tahoma", 14.25F)
        Admin_login_Button.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Admin_login_Button.Location = New Point(117, 270)
        Admin_login_Button.Margin = New Padding(4)
        Admin_login_Button.Name = "Admin_login_Button"
        Admin_login_Button.Size = New Size(92, 36)
        Admin_login_Button.TabIndex = 8
        Admin_login_Button.Text = "Log In"
        Admin_login_Button.UseVisualStyleBackColor = False
        ' 
        ' Admin_exit
        ' 
        Admin_exit.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Admin_exit.Font = New Font("Tahoma", 14.25F)
        Admin_exit.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Admin_exit.Location = New Point(303, 270)
        Admin_exit.Margin = New Padding(4)
        Admin_exit.Name = "Admin_exit"
        Admin_exit.Size = New Size(70, 36)
        Admin_exit.TabIndex = 9
        Admin_exit.Text = "Back"
        Admin_exit.UseVisualStyleBackColor = False
        ' 
        ' Billing_Exit
        ' 
        Billing_Exit.Image = CType(resources.GetObject("Billing_Exit.Image"), Image)
        Billing_Exit.Location = New Point(484, 0)
        Billing_Exit.Name = "Billing_Exit"
        Billing_Exit.Size = New Size(35, 34)
        Billing_Exit.SizeMode = PictureBoxSizeMode.StretchImage
        Billing_Exit.TabIndex = 2
        Billing_Exit.TabStop = False
        ' 
        ' AdminLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(196))
        ClientSize = New Size(519, 358)
        Controls.Add(Admin_exit)
        Controls.Add(Admin_login_Button)
        Controls.Add(Panel1)
        Controls.Add(AdminID_Textbox)
        Controls.Add(Admin_Password_TextBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Name = "AdminLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminLogin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(Billing_Exit, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Admin_Password_TextBox As TextBox
    Friend WithEvents AdminID_Textbox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Admin_login_Button As Button
    Friend WithEvents Admin_exit As Button
    Friend WithEvents Billing_Exit As PictureBox
End Class
