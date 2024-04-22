<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Billing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Billing))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Billing_Exit = New PictureBox()
        billing_head = New Label()
        Panel2 = New Panel()
        billing_edit_button = New Button()
        billing_delete_button = New Button()
        billing_reset_button = New Button()
        Billing_Exit_Button = New Button()
        billing_add_button = New Button()
        billing_price_txtbox = New TextBox()
        billing_price = New Label()
        billing_item_id = New Label()
        billing_itemid_txtbox = New TextBox()
        billing_quantity_txtbox = New TextBox()
        billing_quantity = New Label()
        billing_itemname = New Label()
        billing_itemname_txtbox = New TextBox()
        BillDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Panel3 = New Panel()
        billing_total = New Label()
        billing_total_txtbox = New TextBox()
        Label1 = New Label()
        Feedback_LinkLabel = New LinkLabel()
        Billing_Print_Button = New Button()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        Panel1.SuspendLayout()
        CType(Billing_Exit, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(BillDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Panel1.Controls.Add(Billing_Exit)
        Panel1.Controls.Add(billing_head)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(879, 94)
        Panel1.TabIndex = 0
        ' 
        ' Billing_Exit
        ' 
        Billing_Exit.Image = CType(resources.GetObject("Billing_Exit.Image"), Image)
        Billing_Exit.Location = New Point(844, 0)
        Billing_Exit.Name = "Billing_Exit"
        Billing_Exit.Size = New Size(35, 34)
        Billing_Exit.SizeMode = PictureBoxSizeMode.StretchImage
        Billing_Exit.TabIndex = 1
        Billing_Exit.TabStop = False
        ' 
        ' billing_head
        ' 
        billing_head.AutoSize = True
        billing_head.Font = New Font("Tahoma", 20.25F, FontStyle.Bold)
        billing_head.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        billing_head.Location = New Point(358, 31)
        billing_head.Name = "billing_head"
        billing_head.Size = New Size(131, 33)
        billing_head.TabIndex = 0
        billing_head.Text = "BILLING"
        billing_head.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(billing_edit_button)
        Panel2.Controls.Add(billing_delete_button)
        Panel2.Controls.Add(billing_reset_button)
        Panel2.Controls.Add(billing_add_button)
        Panel2.Controls.Add(billing_price_txtbox)
        Panel2.Controls.Add(billing_price)
        Panel2.Controls.Add(billing_item_id)
        Panel2.Controls.Add(billing_itemid_txtbox)
        Panel2.Controls.Add(billing_quantity_txtbox)
        Panel2.Controls.Add(billing_quantity)
        Panel2.Controls.Add(billing_itemname)
        Panel2.Controls.Add(billing_itemname_txtbox)
        Panel2.Location = New Point(423, 129)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(391, 328)
        Panel2.TabIndex = 1
        ' 
        ' billing_edit_button
        ' 
        billing_edit_button.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        billing_edit_button.Font = New Font("Tahoma", 13.25F)
        billing_edit_button.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        billing_edit_button.Location = New Point(46, 240)
        billing_edit_button.Name = "billing_edit_button"
        billing_edit_button.Size = New Size(97, 46)
        billing_edit_button.TabIndex = 26
        billing_edit_button.Text = "Edit"
        billing_edit_button.UseVisualStyleBackColor = False
        ' 
        ' billing_delete_button
        ' 
        billing_delete_button.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        billing_delete_button.Font = New Font("Tahoma", 13.25F)
        billing_delete_button.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        billing_delete_button.Location = New Point(244, 240)
        billing_delete_button.Name = "billing_delete_button"
        billing_delete_button.Size = New Size(101, 46)
        billing_delete_button.TabIndex = 27
        billing_delete_button.Text = "Delete"
        billing_delete_button.UseVisualStyleBackColor = False
        ' 
        ' billing_reset_button
        ' 
        billing_reset_button.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        billing_reset_button.Font = New Font("Tahoma", 13.25F)
        billing_reset_button.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        billing_reset_button.Location = New Point(241, 174)
        billing_reset_button.Name = "billing_reset_button"
        billing_reset_button.Size = New Size(104, 46)
        billing_reset_button.TabIndex = 21
        billing_reset_button.Text = "Reset"
        billing_reset_button.UseVisualStyleBackColor = False
        ' 
        ' Billing_Exit_Button
        ' 
        Billing_Exit_Button.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Billing_Exit_Button.Font = New Font("Tahoma", 13.25F)
        Billing_Exit_Button.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Billing_Exit_Button.Location = New Point(739, 472)
        Billing_Exit_Button.Name = "Billing_Exit_Button"
        Billing_Exit_Button.Size = New Size(75, 39)
        Billing_Exit_Button.TabIndex = 25
        Billing_Exit_Button.Text = "Back"
        Billing_Exit_Button.UseVisualStyleBackColor = False
        ' 
        ' billing_add_button
        ' 
        billing_add_button.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        billing_add_button.Font = New Font("Tahoma", 13.25F)
        billing_add_button.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        billing_add_button.Location = New Point(46, 174)
        billing_add_button.Name = "billing_add_button"
        billing_add_button.Size = New Size(104, 46)
        billing_add_button.TabIndex = 20
        billing_add_button.Text = "Add"
        billing_add_button.UseVisualStyleBackColor = False
        ' 
        ' billing_price_txtbox
        ' 
        billing_price_txtbox.Font = New Font("Tahoma", 13.25F)
        billing_price_txtbox.Location = New Point(213, 124)
        billing_price_txtbox.Name = "billing_price_txtbox"
        billing_price_txtbox.Size = New Size(162, 29)
        billing_price_txtbox.TabIndex = 19
        ' 
        ' billing_price
        ' 
        billing_price.AutoSize = True
        billing_price.Font = New Font("Tahoma", 14.25F)
        billing_price.Location = New Point(244, 87)
        billing_price.Name = "billing_price"
        billing_price.Size = New Size(50, 23)
        billing_price.TabIndex = 17
        billing_price.Text = "Price"
        ' 
        ' billing_item_id
        ' 
        billing_item_id.AutoSize = True
        billing_item_id.Font = New Font("Tahoma", 14.25F)
        billing_item_id.Location = New Point(53, 12)
        billing_item_id.Name = "billing_item_id"
        billing_item_id.Size = New Size(75, 23)
        billing_item_id.TabIndex = 16
        billing_item_id.Text = "Item ID"
        ' 
        ' billing_itemid_txtbox
        ' 
        billing_itemid_txtbox.Font = New Font("Tahoma", 13.25F)
        billing_itemid_txtbox.Location = New Point(25, 48)
        billing_itemid_txtbox.Name = "billing_itemid_txtbox"
        billing_itemid_txtbox.Size = New Size(162, 29)
        billing_itemid_txtbox.TabIndex = 18
        ' 
        ' billing_quantity_txtbox
        ' 
        billing_quantity_txtbox.Font = New Font("Tahoma", 13.25F)
        billing_quantity_txtbox.Location = New Point(25, 124)
        billing_quantity_txtbox.Name = "billing_quantity_txtbox"
        billing_quantity_txtbox.Size = New Size(162, 29)
        billing_quantity_txtbox.TabIndex = 15
        ' 
        ' billing_quantity
        ' 
        billing_quantity.AutoSize = True
        billing_quantity.Font = New Font("Tahoma", 14.25F)
        billing_quantity.Location = New Point(53, 87)
        billing_quantity.Name = "billing_quantity"
        billing_quantity.Size = New Size(80, 23)
        billing_quantity.TabIndex = 13
        billing_quantity.Text = "Quantity"
        ' 
        ' billing_itemname
        ' 
        billing_itemname.AutoSize = True
        billing_itemname.Font = New Font("Tahoma", 14.25F)
        billing_itemname.Location = New Point(240, 12)
        billing_itemname.Name = "billing_itemname"
        billing_itemname.Size = New Size(104, 23)
        billing_itemname.TabIndex = 12
        billing_itemname.Text = "Item Name"
        ' 
        ' billing_itemname_txtbox
        ' 
        billing_itemname_txtbox.Font = New Font("Tahoma", 13.25F)
        billing_itemname_txtbox.Location = New Point(212, 48)
        billing_itemname_txtbox.Name = "billing_itemname_txtbox"
        billing_itemname_txtbox.Size = New Size(162, 29)
        billing_itemname_txtbox.TabIndex = 14
        ' 
        ' BillDGV
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        BillDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        BillDGV.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        BillDGV.BorderStyle = BorderStyle.FixedSingle
        BillDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        DataGridViewCellStyle2.Font = New Font("Tahoma", 10F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        BillDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        BillDGV.ColumnHeadersHeight = 37
        BillDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Tahoma", 10F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        BillDGV.DefaultCellStyle = DataGridViewCellStyle3
        BillDGV.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        BillDGV.Location = New Point(37, 129)
        BillDGV.Name = "BillDGV"
        BillDGV.RowHeadersVisible = False
        BillDGV.Size = New Size(339, 413)
        BillDGV.TabIndex = 2
        BillDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        BillDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        BillDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        BillDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        BillDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        BillDGV.ThemeStyle.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        BillDGV.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        BillDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BillDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single
        BillDGV.ThemeStyle.HeaderStyle.Font = New Font("Tahoma", 9.25F, FontStyle.Bold)
        BillDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White
        BillDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        BillDGV.ThemeStyle.HeaderStyle.Height = 37
        BillDGV.ThemeStyle.ReadOnly = False
        BillDGV.ThemeStyle.RowsStyle.BackColor = Color.White
        BillDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        BillDGV.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        BillDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        BillDGV.ThemeStyle.RowsStyle.Height = 25
        BillDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        BillDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 610)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(879, 14)
        Panel3.TabIndex = 5
        ' 
        ' billing_total
        ' 
        billing_total.AutoSize = True
        billing_total.Font = New Font("Tahoma", 14.25F)
        billing_total.Location = New Point(429, 482)
        billing_total.Name = "billing_total"
        billing_total.Size = New Size(51, 23)
        billing_total.TabIndex = 22
        billing_total.Text = "Total"
        ' 
        ' billing_total_txtbox
        ' 
        billing_total_txtbox.Font = New Font("Tahoma", 13.25F)
        billing_total_txtbox.Location = New Point(499, 482)
        billing_total_txtbox.Name = "billing_total_txtbox"
        billing_total_txtbox.Size = New Size(138, 29)
        billing_total_txtbox.TabIndex = 24
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(461, 551)
        Label1.Name = "Label1"
        Label1.Size = New Size(250, 17)
        Label1.TabIndex = 26
        Label1.Text = "Share your thoughts with us. Give us a "
        ' 
        ' Feedback_LinkLabel
        ' 
        Feedback_LinkLabel.AutoSize = True
        Feedback_LinkLabel.Location = New Point(705, 551)
        Feedback_LinkLabel.Name = "Feedback_LinkLabel"
        Feedback_LinkLabel.Size = New Size(66, 17)
        Feedback_LinkLabel.TabIndex = 27
        Feedback_LinkLabel.TabStop = True
        Feedback_LinkLabel.Text = "Feedback"
        ' 
        ' Billing_Print_Button
        ' 
        Billing_Print_Button.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Billing_Print_Button.Font = New Font("Tahoma", 13.25F)
        Billing_Print_Button.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Billing_Print_Button.Location = New Point(658, 472)
        Billing_Print_Button.Name = "Billing_Print_Button"
        Billing_Print_Button.Size = New Size(75, 39)
        Billing_Print_Button.TabIndex = 28
        Billing_Print_Button.Text = "Print"
        Billing_Print_Button.UseVisualStyleBackColor = False
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' Billing
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        ClientSize = New Size(879, 624)
        Controls.Add(Billing_Print_Button)
        Controls.Add(Feedback_LinkLabel)
        Controls.Add(Label1)
        Controls.Add(Billing_Exit_Button)
        Controls.Add(billing_total_txtbox)
        Controls.Add(billing_total)
        Controls.Add(Panel3)
        Controls.Add(BillDGV)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Tahoma", 10F)
        FormBorderStyle = FormBorderStyle.None
        Name = "Billing"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Billing"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(Billing_Exit, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(BillDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents billing_head As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents billing_quantity_txtbox As TextBox
    Friend WithEvents billing_quantity As Label
    Friend WithEvents billing_itemname As Label
    Friend WithEvents billing_itemname_txtbox As TextBox
    Friend WithEvents billing_price_txtbox As TextBox
    Friend WithEvents billing_price As Label
    Friend WithEvents billing_item_id As Label
    Friend WithEvents billing_itemid_txtbox As TextBox
    Friend WithEvents billing_reset_button As Button
    Friend WithEvents billing_add_button As Button
    Friend WithEvents BillDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents billing_total As Label
    Friend WithEvents billing_total_txtbox As TextBox
    Friend WithEvents Billing_Exit_Button As Button
    Friend WithEvents billing_edit_button As Button
    Friend WithEvents billing_delete_button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Feedback_LinkLabel As LinkLabel
    Friend WithEvents Billing_Exit As PictureBox
    Friend WithEvents Billing_Print_Button As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument


End Class
