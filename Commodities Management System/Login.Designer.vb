<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        label_managingusers = New Label()
        txt_username = New TextBox()
        txt_password = New TextBox()
        Label_username = New Label()
        Label_password = New Label()
        Button_signin = New Button()
        Button_exit = New Button()
        Registation_page_directory = New LinkLabel()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Panel1.Controls.Add(label_managingusers)
        Panel1.Dock = DockStyle.Top
        Panel1.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(423, 79)
        Panel1.TabIndex = 0
        ' 
        ' label_managingusers
        ' 
        label_managingusers.AutoSize = True
        label_managingusers.Font = New Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label_managingusers.Location = New Point(63, 18)
        label_managingusers.Margin = New Padding(4, 0, 4, 0)
        label_managingusers.Name = "label_managingusers"
        label_managingusers.Size = New Size(294, 33)
        label_managingusers.TabIndex = 2
        label_managingusers.Text = "USER MANAGEMENT"
        label_managingusers.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txt_username
        ' 
        txt_username.Location = New Point(170, 120)
        txt_username.Margin = New Padding(4)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(215, 30)
        txt_username.TabIndex = 0
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(170, 184)
        txt_password.Margin = New Padding(4)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(215, 30)
        txt_password.TabIndex = 1
        txt_password.UseSystemPasswordChar = True
        ' 
        ' Label_username
        ' 
        Label_username.AutoSize = True
        Label_username.Location = New Point(29, 120)
        Label_username.Margin = New Padding(4, 0, 4, 0)
        Label_username.Name = "Label_username"
        Label_username.Size = New Size(73, 23)
        Label_username.TabIndex = 3
        Label_username.Text = "User ID"
        ' 
        ' Label_password
        ' 
        Label_password.AutoSize = True
        Label_password.Location = New Point(29, 184)
        Label_password.Margin = New Padding(4, 0, 4, 0)
        Label_password.Name = "Label_password"
        Label_password.Size = New Size(88, 23)
        Label_password.TabIndex = 4
        Label_password.Text = "Password"
        ' 
        ' Button_signin
        ' 
        Button_signin.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Button_signin.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button_signin.Location = New Point(97, 245)
        Button_signin.Margin = New Padding(4)
        Button_signin.Name = "Button_signin"
        Button_signin.Size = New Size(92, 36)
        Button_signin.TabIndex = 7
        Button_signin.Text = "Sign In"
        Button_signin.UseVisualStyleBackColor = False
        ' 
        ' Button_exit
        ' 
        Button_exit.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Button_exit.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button_exit.Location = New Point(254, 245)
        Button_exit.Margin = New Padding(4)
        Button_exit.Name = "Button_exit"
        Button_exit.Size = New Size(70, 36)
        Button_exit.TabIndex = 8
        Button_exit.Text = "Exit"
        Button_exit.UseVisualStyleBackColor = False
        ' 
        ' Registation_page_directory
        ' 
        Registation_page_directory.AutoSize = True
        Registation_page_directory.Font = New Font("Tahoma", 11F)
        Registation_page_directory.Location = New Point(126, 304)
        Registation_page_directory.Name = "Registation_page_directory"
        Registation_page_directory.Size = New Size(60, 18)
        Registation_page_directory.TabIndex = 9
        Registation_page_directory.TabStop = True
        Registation_page_directory.Text = "Register"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 11F)
        Label1.Location = New Point(29, 304)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 18)
        Label1.TabIndex = 10
        Label1.Text = "New to here?"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(10F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(196))
        ClientSize = New Size(423, 356)
        Controls.Add(Label1)
        Controls.Add(Registation_page_directory)
        Controls.Add(Label_username)
        Controls.Add(txt_username)
        Controls.Add(txt_password)
        Controls.Add(Label_password)
        Controls.Add(Button_signin)
        Controls.Add(Button_exit)
        Controls.Add(Panel1)
        Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents label_managingusers As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label_username As Label
    Friend WithEvents Label_password As Label
    Friend WithEvents Button_signin As Button
    Friend WithEvents Button_exit As Button
    Friend WithEvents Registation_page_directory As LinkLabel
    Friend WithEvents Label1 As Label

End Class
