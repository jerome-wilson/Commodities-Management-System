<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationList
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationList))
        Panel1 = New Panel()
        Label1 = New Label()
        RegisteredUserList_Guna2DataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Reg_Users_Edit_Button = New Button()
        Reg_Users_Delete_Button = New Button()
        Reg_Users_Back_Button = New Button()
        RegistrationList_Exit = New PictureBox()
        Panel1.SuspendLayout()
        CType(RegisteredUserList_Guna2DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(RegistrationList_Exit, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Panel1.Controls.Add(RegistrationList_Exit)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1246, 107)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 20.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Label1.Location = New Point(444, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(292, 33)
        Label1.TabIndex = 0
        Label1.Text = "REGISTERED USERS"
        ' 
        ' RegisteredUserList_Guna2DataGridView
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        RegisteredUserList_Guna2DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        DataGridViewCellStyle2.Font = New Font("Tahoma", 10F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        RegisteredUserList_Guna2DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        RegisteredUserList_Guna2DataGridView.ColumnHeadersHeight = 28
        RegisteredUserList_Guna2DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Tahoma", 10F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        RegisteredUserList_Guna2DataGridView.DefaultCellStyle = DataGridViewCellStyle3
        RegisteredUserList_Guna2DataGridView.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        RegisteredUserList_Guna2DataGridView.Location = New Point(49, 129)
        RegisteredUserList_Guna2DataGridView.Name = "RegisteredUserList_Guna2DataGridView"
        RegisteredUserList_Guna2DataGridView.RowHeadersVisible = False
        RegisteredUserList_Guna2DataGridView.Size = New Size(1152, 315)
        RegisteredUserList_Guna2DataGridView.TabIndex = 4
        RegisteredUserList_Guna2DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        RegisteredUserList_Guna2DataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        RegisteredUserList_Guna2DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        RegisteredUserList_Guna2DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        RegisteredUserList_Guna2DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        RegisteredUserList_Guna2DataGridView.ThemeStyle.BackColor = Color.White
        RegisteredUserList_Guna2DataGridView.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        RegisteredUserList_Guna2DataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        RegisteredUserList_Guna2DataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        RegisteredUserList_Guna2DataGridView.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        RegisteredUserList_Guna2DataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White
        RegisteredUserList_Guna2DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        RegisteredUserList_Guna2DataGridView.ThemeStyle.HeaderStyle.Height = 28
        RegisteredUserList_Guna2DataGridView.ThemeStyle.ReadOnly = False
        RegisteredUserList_Guna2DataGridView.ThemeStyle.RowsStyle.BackColor = Color.White
        RegisteredUserList_Guna2DataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        RegisteredUserList_Guna2DataGridView.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        RegisteredUserList_Guna2DataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        RegisteredUserList_Guna2DataGridView.ThemeStyle.RowsStyle.Height = 25
        RegisteredUserList_Guna2DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        RegisteredUserList_Guna2DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Reg_Users_Edit_Button
        ' 
        Reg_Users_Edit_Button.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Reg_Users_Edit_Button.Font = New Font("Tahoma", 13.25F)
        Reg_Users_Edit_Button.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Reg_Users_Edit_Button.Location = New Point(389, 471)
        Reg_Users_Edit_Button.Name = "Reg_Users_Edit_Button"
        Reg_Users_Edit_Button.Size = New Size(75, 36)
        Reg_Users_Edit_Button.TabIndex = 5
        Reg_Users_Edit_Button.Text = "Edit"
        Reg_Users_Edit_Button.UseVisualStyleBackColor = False
        ' 
        ' Reg_Users_Delete_Button
        ' 
        Reg_Users_Delete_Button.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Reg_Users_Delete_Button.Font = New Font("Tahoma", 13.25F)
        Reg_Users_Delete_Button.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Reg_Users_Delete_Button.Location = New Point(560, 471)
        Reg_Users_Delete_Button.Name = "Reg_Users_Delete_Button"
        Reg_Users_Delete_Button.Size = New Size(75, 36)
        Reg_Users_Delete_Button.TabIndex = 6
        Reg_Users_Delete_Button.Text = "Delete"
        Reg_Users_Delete_Button.UseVisualStyleBackColor = False
        ' 
        ' Reg_Users_Back_Button
        ' 
        Reg_Users_Back_Button.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Reg_Users_Back_Button.Font = New Font("Tahoma", 13.25F)
        Reg_Users_Back_Button.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Reg_Users_Back_Button.Location = New Point(735, 471)
        Reg_Users_Back_Button.Name = "Reg_Users_Back_Button"
        Reg_Users_Back_Button.Size = New Size(75, 36)
        Reg_Users_Back_Button.TabIndex = 7
        Reg_Users_Back_Button.Text = "Back"
        Reg_Users_Back_Button.UseVisualStyleBackColor = False
        ' 
        ' RegistrationList_Exit
        ' 
        RegistrationList_Exit.Image = CType(resources.GetObject("RegistrationList_Exit.Image"), Image)
        RegistrationList_Exit.Location = New Point(1211, 3)
        RegistrationList_Exit.Name = "RegistrationList_Exit"
        RegistrationList_Exit.Size = New Size(35, 34)
        RegistrationList_Exit.SizeMode = PictureBoxSizeMode.StretchImage
        RegistrationList_Exit.TabIndex = 2
        RegistrationList_Exit.TabStop = False
        ' 
        ' RegistrationList
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        ClientSize = New Size(1246, 557)
        Controls.Add(Reg_Users_Back_Button)
        Controls.Add(Reg_Users_Delete_Button)
        Controls.Add(Reg_Users_Edit_Button)
        Controls.Add(RegisteredUserList_Guna2DataGridView)
        Controls.Add(Panel1)
        Font = New Font("Tahoma", 10F)
        FormBorderStyle = FormBorderStyle.None
        Name = "RegistrationList"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RegistrationList"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(RegisteredUserList_Guna2DataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(RegistrationList_Exit, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents RegisteredUserList_Guna2DataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Reg_Users_Edit_Button As Button
    Friend WithEvents Reg_Users_Delete_Button As Button
    Friend WithEvents Reg_Users_Back_Button As Button
    Friend WithEvents RegistrationList_Exit As PictureBox
End Class
