<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Itemspage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Itemspage))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Itemspage_Exit = New PictureBox()
        items_head = New Label()
        Panel2 = New Panel()
        Itemspg_Back_Button = New Button()
        items_billing = New Button()
        items_itemid = New Label()
        items_save = New Button()
        items_itemid_txtbox = New TextBox()
        items_edit = New Button()
        items_delete = New Button()
        items_clear = New Button()
        items_price_txtbox = New TextBox()
        items_itemqty_txtbox = New TextBox()
        items_categories_combobox = New ComboBox()
        items_categories = New Label()
        items_qty = New Label()
        items_itemname = New Label()
        items_price = New Label()
        items_itemname_txtbox = New TextBox()
        items_manageingitems = New Label()
        Panel3 = New Panel()
        ItemDGV = New Guna.UI2.WinForms.Guna2DataGridView()
        items_stockslabel = New Label()
        Panel1.SuspendLayout()
        CType(Itemspage_Exit, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(ItemDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Panel1.Controls.Add(Itemspage_Exit)
        Panel1.Controls.Add(items_head)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(948, 78)
        Panel1.TabIndex = 0
        ' 
        ' Itemspage_Exit
        ' 
        Itemspage_Exit.Image = CType(resources.GetObject("Itemspage_Exit.Image"), Image)
        Itemspage_Exit.Location = New Point(913, 0)
        Itemspage_Exit.Name = "Itemspage_Exit"
        Itemspage_Exit.Size = New Size(35, 34)
        Itemspage_Exit.SizeMode = PictureBoxSizeMode.StretchImage
        Itemspage_Exit.TabIndex = 5
        Itemspage_Exit.TabStop = False
        ' 
        ' items_head
        ' 
        items_head.AutoSize = True
        items_head.Font = New Font("Tahoma", 20.25F, FontStyle.Bold)
        items_head.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        items_head.Location = New Point(422, 21)
        items_head.Name = "items_head"
        items_head.Size = New Size(103, 33)
        items_head.TabIndex = 0
        items_head.Text = "ITEMS"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Itemspg_Back_Button)
        Panel2.Controls.Add(items_billing)
        Panel2.Controls.Add(items_itemid)
        Panel2.Controls.Add(items_save)
        Panel2.Controls.Add(items_itemid_txtbox)
        Panel2.Controls.Add(items_edit)
        Panel2.Controls.Add(items_delete)
        Panel2.Controls.Add(items_clear)
        Panel2.Controls.Add(items_price_txtbox)
        Panel2.Controls.Add(items_itemqty_txtbox)
        Panel2.Controls.Add(items_categories_combobox)
        Panel2.Controls.Add(items_categories)
        Panel2.Controls.Add(items_qty)
        Panel2.Controls.Add(items_itemname)
        Panel2.Controls.Add(items_price)
        Panel2.Controls.Add(items_itemname_txtbox)
        Panel2.Location = New Point(12, 139)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(918, 191)
        Panel2.TabIndex = 1
        ' 
        ' Itemspg_Back_Button
        ' 
        Itemspg_Back_Button.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Itemspg_Back_Button.Font = New Font("Tahoma", 13.25F)
        Itemspg_Back_Button.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Itemspg_Back_Button.Location = New Point(48, 128)
        Itemspg_Back_Button.Name = "Itemspg_Back_Button"
        Itemspg_Back_Button.Size = New Size(118, 41)
        Itemspg_Back_Button.TabIndex = 5
        Itemspg_Back_Button.Text = "Back"
        Itemspg_Back_Button.UseVisualStyleBackColor = False
        ' 
        ' items_billing
        ' 
        items_billing.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        items_billing.Font = New Font("Tahoma", 13.25F)
        items_billing.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        items_billing.Location = New Point(717, 128)
        items_billing.Name = "items_billing"
        items_billing.Size = New Size(118, 41)
        items_billing.TabIndex = 5
        items_billing.Text = "Billing"
        items_billing.UseVisualStyleBackColor = False
        ' 
        ' items_itemid
        ' 
        items_itemid.AutoSize = True
        items_itemid.Font = New Font("Tahoma", 14.25F)
        items_itemid.Location = New Point(31, 21)
        items_itemid.Name = "items_itemid"
        items_itemid.Size = New Size(75, 23)
        items_itemid.TabIndex = 6
        items_itemid.Text = "Item ID"
        ' 
        ' items_save
        ' 
        items_save.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        items_save.Font = New Font("Tahoma", 13.25F)
        items_save.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        items_save.Location = New Point(179, 128)
        items_save.Name = "items_save"
        items_save.Size = New Size(118, 41)
        items_save.TabIndex = 3
        items_save.Text = "Save"
        items_save.UseVisualStyleBackColor = False
        ' 
        ' items_itemid_txtbox
        ' 
        items_itemid_txtbox.Font = New Font("Tahoma", 13.25F)
        items_itemid_txtbox.Location = New Point(31, 68)
        items_itemid_txtbox.Name = "items_itemid_txtbox"
        items_itemid_txtbox.Size = New Size(135, 29)
        items_itemid_txtbox.TabIndex = 5
        ' 
        ' items_edit
        ' 
        items_edit.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        items_edit.Font = New Font("Tahoma", 13.25F)
        items_edit.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        items_edit.Location = New Point(316, 128)
        items_edit.Name = "items_edit"
        items_edit.Size = New Size(118, 41)
        items_edit.TabIndex = 4
        items_edit.Text = "Edit"
        items_edit.UseVisualStyleBackColor = False
        ' 
        ' items_delete
        ' 
        items_delete.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        items_delete.Font = New Font("Tahoma", 13.25F)
        items_delete.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        items_delete.Location = New Point(454, 128)
        items_delete.Name = "items_delete"
        items_delete.Size = New Size(118, 41)
        items_delete.TabIndex = 5
        items_delete.Text = "Delete"
        items_delete.UseVisualStyleBackColor = False
        ' 
        ' items_clear
        ' 
        items_clear.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        items_clear.Font = New Font("Tahoma", 13.25F)
        items_clear.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        items_clear.Location = New Point(581, 128)
        items_clear.Name = "items_clear"
        items_clear.Size = New Size(118, 41)
        items_clear.TabIndex = 6
        items_clear.Text = "Clear"
        items_clear.UseVisualStyleBackColor = False
        ' 
        ' items_price_txtbox
        ' 
        items_price_txtbox.Font = New Font("Tahoma", 13.25F)
        items_price_txtbox.Location = New Point(559, 68)
        items_price_txtbox.Name = "items_price_txtbox"
        items_price_txtbox.Size = New Size(135, 29)
        items_price_txtbox.TabIndex = 12
        ' 
        ' items_itemqty_txtbox
        ' 
        items_itemqty_txtbox.Font = New Font("Tahoma", 13.25F)
        items_itemqty_txtbox.Location = New Point(377, 68)
        items_itemqty_txtbox.Name = "items_itemqty_txtbox"
        items_itemqty_txtbox.Size = New Size(135, 29)
        items_itemqty_txtbox.TabIndex = 11
        ' 
        ' items_categories_combobox
        ' 
        items_categories_combobox.Font = New Font("Tahoma", 13.25F)
        items_categories_combobox.FormattingEnabled = True
        items_categories_combobox.Items.AddRange(New Object() {"Steel", "Iron", "Nickel", "Copper", "Zinc", "Lead", "Aluminium"})
        items_categories_combobox.Location = New Point(745, 68)
        items_categories_combobox.Name = "items_categories_combobox"
        items_categories_combobox.Size = New Size(135, 30)
        items_categories_combobox.TabIndex = 10
        ' 
        ' items_categories
        ' 
        items_categories.AutoSize = True
        items_categories.Font = New Font("Tahoma", 14.25F)
        items_categories.Location = New Point(745, 21)
        items_categories.Name = "items_categories"
        items_categories.Size = New Size(97, 23)
        items_categories.TabIndex = 9
        items_categories.Text = "Categories"
        ' 
        ' items_qty
        ' 
        items_qty.AutoSize = True
        items_qty.Font = New Font("Tahoma", 14.25F)
        items_qty.Location = New Point(377, 21)
        items_qty.Name = "items_qty"
        items_qty.Size = New Size(80, 23)
        items_qty.TabIndex = 4
        items_qty.Text = "Quantity"
        ' 
        ' items_itemname
        ' 
        items_itemname.AutoSize = True
        items_itemname.Font = New Font("Tahoma", 14.25F)
        items_itemname.Location = New Point(212, 21)
        items_itemname.Name = "items_itemname"
        items_itemname.Size = New Size(104, 23)
        items_itemname.TabIndex = 3
        items_itemname.Text = "Item Name"
        ' 
        ' items_price
        ' 
        items_price.AutoSize = True
        items_price.Font = New Font("Tahoma", 14.25F)
        items_price.Location = New Point(547, 21)
        items_price.Name = "items_price"
        items_price.Size = New Size(50, 23)
        items_price.TabIndex = 5
        items_price.Text = "Price"
        ' 
        ' items_itemname_txtbox
        ' 
        items_itemname_txtbox.Font = New Font("Tahoma", 13.25F)
        items_itemname_txtbox.Location = New Point(212, 68)
        items_itemname_txtbox.Name = "items_itemname_txtbox"
        items_itemname_txtbox.Size = New Size(135, 29)
        items_itemname_txtbox.TabIndex = 8
        ' 
        ' items_manageingitems
        ' 
        items_manageingitems.AutoSize = True
        items_manageingitems.FlatStyle = FlatStyle.System
        items_manageingitems.Font = New Font("Tahoma", 15.25F)
        items_manageingitems.Location = New Point(403, 95)
        items_manageingitems.Name = "items_manageingitems"
        items_manageingitems.Size = New Size(163, 25)
        items_manageingitems.TabIndex = 2
        items_manageingitems.Text = "Managing Items"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 638)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(948, 20)
        Panel3.TabIndex = 3
        ' 
        ' ItemDGV
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        ItemDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        ItemDGV.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        DataGridViewCellStyle2.Font = New Font("Tahoma", 11F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        ItemDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        ItemDGV.ColumnHeadersHeight = 33
        ItemDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Tahoma", 10F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        ItemDGV.DefaultCellStyle = DataGridViewCellStyle3
        ItemDGV.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        ItemDGV.Location = New Point(61, 360)
        ItemDGV.Name = "ItemDGV"
        ItemDGV.RowHeadersVisible = False
        ItemDGV.Size = New Size(837, 232)
        ItemDGV.TabIndex = 0
        ItemDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        ItemDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        ItemDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        ItemDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        ItemDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        ItemDGV.ThemeStyle.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        ItemDGV.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        ItemDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        ItemDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        ItemDGV.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        ItemDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White
        ItemDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        ItemDGV.ThemeStyle.HeaderStyle.Height = 33
        ItemDGV.ThemeStyle.ReadOnly = False
        ItemDGV.ThemeStyle.RowsStyle.BackColor = Color.White
        ItemDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        ItemDGV.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        ItemDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ItemDGV.ThemeStyle.RowsStyle.Height = 25
        ItemDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        ItemDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' items_stockslabel
        ' 
        items_stockslabel.AutoSize = True
        items_stockslabel.Font = New Font("Tahoma", 14.25F)
        items_stockslabel.Location = New Point(436, 334)
        items_stockslabel.Name = "items_stockslabel"
        items_stockslabel.Size = New Size(63, 23)
        items_stockslabel.TabIndex = 4
        items_stockslabel.Text = "Stocks"
        ' 
        ' Itemspage
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        ClientSize = New Size(948, 658)
        Controls.Add(items_stockslabel)
        Controls.Add(ItemDGV)
        Controls.Add(Panel3)
        Controls.Add(items_manageingitems)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Tahoma", 10F)
        FormBorderStyle = FormBorderStyle.None
        Name = "Itemspage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Itemspage"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(Itemspage_Exit, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(ItemDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents items_head As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents items_qty As Label
    Friend WithEvents items_itemname As Label
    Friend WithEvents items_price As Label
    Friend WithEvents items_itemname_txtbox As TextBox
    Friend WithEvents items_manageingitems As Label
    Friend WithEvents items_categories_combobox As ComboBox
    Friend WithEvents items_categories As Label
    Friend WithEvents items_price_txtbox As TextBox
    Friend WithEvents items_itemqty_txtbox As TextBox
    Friend WithEvents items_save As Button
    Friend WithEvents items_edit As Button
    Friend WithEvents items_delete As Button
    Friend WithEvents items_clear As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ItemDGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents items_stockslabel As Label

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemDGV.CellContentClick

    End Sub

    Friend WithEvents items_itemid_txtbox As TextBox
    Friend WithEvents items_itemid As Label
    Friend WithEvents items_billing As Button
    Friend WithEvents Itemspg_Back_Button As Button
    Friend WithEvents Itemspage_Exit As PictureBox
End Class
