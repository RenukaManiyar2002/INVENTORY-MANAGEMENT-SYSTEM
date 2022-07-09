<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Product
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Product))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TT_clearbtn = New System.Windows.Forms.ToolTip(Me.components)
        Me.TT_deletebtn = New System.Windows.Forms.ToolTip(Me.components)
        Me.TT_updatebtn = New System.Windows.Forms.ToolTip(Me.components)
        Me.PB_clear = New System.Windows.Forms.PictureBox()
        Me.PB_delete = New System.Windows.Forms.PictureBox()
        Me.PB_update = New System.Windows.Forms.PictureBox()
        Me.PB_add = New System.Windows.Forms.PictureBox()
        Me.Txt_qty = New System.Windows.Forms.TextBox()
        Me.Lbl_qty = New System.Windows.Forms.Label()
        Me.Cbox_category = New System.Windows.Forms.ComboBox()
        Me.Txt_price = New System.Windows.Forms.TextBox()
        Me.TT_addbtn = New System.Windows.Forms.ToolTip(Me.components)
        Me.Txt_proName = New System.Windows.Forms.TextBox()
        Me.Lbl_AUTOID = New System.Windows.Forms.TextBox()
        Me.Lbl_cat = New System.Windows.Forms.Label()
        Me.Lbl_desc = New System.Windows.Forms.Label()
        Me.Lbl_price = New System.Windows.Forms.Label()
        Me.Lbl_proname = New System.Windows.Forms.Label()
        Me.Lbl_ID = New System.Windows.Forms.Label()
        Me.Lbl_close = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txt_desc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.productdgv = New System.Windows.Forms.DataGridView()
        CType(Me.PB_clear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_add, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.productdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB_clear
        '
        Me.PB_clear.BackgroundImage = CType(resources.GetObject("PB_clear.BackgroundImage"), System.Drawing.Image)
        Me.PB_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PB_clear.Location = New System.Drawing.Point(1602, 189)
        Me.PB_clear.Name = "PB_clear"
        Me.PB_clear.Size = New System.Drawing.Size(175, 130)
        Me.PB_clear.TabIndex = 17
        Me.PB_clear.TabStop = False
        '
        'PB_delete
        '
        Me.PB_delete.BackgroundImage = CType(resources.GetObject("PB_delete.BackgroundImage"), System.Drawing.Image)
        Me.PB_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PB_delete.Enabled = False
        Me.PB_delete.Location = New System.Drawing.Point(1602, 14)
        Me.PB_delete.Name = "PB_delete"
        Me.PB_delete.Size = New System.Drawing.Size(175, 141)
        Me.PB_delete.TabIndex = 16
        Me.PB_delete.TabStop = False
        '
        'PB_update
        '
        Me.PB_update.BackgroundImage = CType(resources.GetObject("PB_update.BackgroundImage"), System.Drawing.Image)
        Me.PB_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PB_update.Enabled = False
        Me.PB_update.Location = New System.Drawing.Point(1308, 189)
        Me.PB_update.Name = "PB_update"
        Me.PB_update.Size = New System.Drawing.Size(175, 130)
        Me.PB_update.TabIndex = 15
        Me.PB_update.TabStop = False
        '
        'PB_add
        '
        Me.PB_add.BackgroundImage = CType(resources.GetObject("PB_add.BackgroundImage"), System.Drawing.Image)
        Me.PB_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PB_add.Location = New System.Drawing.Point(1308, 14)
        Me.PB_add.Name = "PB_add"
        Me.PB_add.Size = New System.Drawing.Size(175, 141)
        Me.PB_add.TabIndex = 14
        Me.PB_add.TabStop = False
        '
        'Txt_qty
        '
        Me.Txt_qty.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Txt_qty.ForeColor = System.Drawing.Color.Chocolate
        Me.Txt_qty.Location = New System.Drawing.Point(267, 129)
        Me.Txt_qty.Name = "Txt_qty"
        Me.Txt_qty.Size = New System.Drawing.Size(289, 42)
        Me.Txt_qty.TabIndex = 2
        '
        'Lbl_qty
        '
        Me.Lbl_qty.AutoSize = True
        Me.Lbl_qty.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_qty.ForeColor = System.Drawing.Color.Snow
        Me.Lbl_qty.Location = New System.Drawing.Point(36, 129)
        Me.Lbl_qty.Name = "Lbl_qty"
        Me.Lbl_qty.Size = New System.Drawing.Size(177, 35)
        Me.Lbl_qty.TabIndex = 12
        Me.Lbl_qty.Text = "QUANTITY"
        '
        'Cbox_category
        '
        Me.Cbox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbox_category.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Cbox_category.ForeColor = System.Drawing.Color.Chocolate
        Me.Cbox_category.FormattingEnabled = True
        Me.Cbox_category.Location = New System.Drawing.Point(971, 217)
        Me.Cbox_category.Name = "Cbox_category"
        Me.Cbox_category.Size = New System.Drawing.Size(289, 43)
        Me.Cbox_category.TabIndex = 5
        '
        'Txt_price
        '
        Me.Txt_price.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Txt_price.ForeColor = System.Drawing.Color.Chocolate
        Me.Txt_price.Location = New System.Drawing.Point(971, 140)
        Me.Txt_price.Name = "Txt_price"
        Me.Txt_price.Size = New System.Drawing.Size(289, 42)
        Me.Txt_price.TabIndex = 3
        '
        'Txt_proName
        '
        Me.Txt_proName.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Txt_proName.ForeColor = System.Drawing.Color.Chocolate
        Me.Txt_proName.Location = New System.Drawing.Point(971, 53)
        Me.Txt_proName.Name = "Txt_proName"
        Me.Txt_proName.Size = New System.Drawing.Size(289, 42)
        Me.Txt_proName.TabIndex = 1
        '
        'Lbl_AUTOID
        '
        Me.Lbl_AUTOID.Enabled = False
        Me.Lbl_AUTOID.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_AUTOID.ForeColor = System.Drawing.Color.Chocolate
        Me.Lbl_AUTOID.Location = New System.Drawing.Point(267, 53)
        Me.Lbl_AUTOID.Name = "Lbl_AUTOID"
        Me.Lbl_AUTOID.Size = New System.Drawing.Size(289, 42)
        Me.Lbl_AUTOID.TabIndex = 0
        '
        'Lbl_cat
        '
        Me.Lbl_cat.AutoSize = True
        Me.Lbl_cat.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_cat.ForeColor = System.Drawing.Color.Snow
        Me.Lbl_cat.Location = New System.Drawing.Point(690, 217)
        Me.Lbl_cat.Name = "Lbl_cat"
        Me.Lbl_cat.Size = New System.Drawing.Size(185, 35)
        Me.Lbl_cat.TabIndex = 5
        Me.Lbl_cat.Text = "CATEGORY"
        '
        'Lbl_desc
        '
        Me.Lbl_desc.AutoSize = True
        Me.Lbl_desc.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_desc.ForeColor = System.Drawing.Color.Snow
        Me.Lbl_desc.Location = New System.Drawing.Point(36, 209)
        Me.Lbl_desc.Name = "Lbl_desc"
        Me.Lbl_desc.Size = New System.Drawing.Size(226, 35)
        Me.Lbl_desc.TabIndex = 4
        Me.Lbl_desc.Text = "DESCRIPTION"
        '
        'Lbl_price
        '
        Me.Lbl_price.AutoSize = True
        Me.Lbl_price.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_price.ForeColor = System.Drawing.Color.Snow
        Me.Lbl_price.Location = New System.Drawing.Point(690, 140)
        Me.Lbl_price.Name = "Lbl_price"
        Me.Lbl_price.Size = New System.Drawing.Size(110, 35)
        Me.Lbl_price.TabIndex = 3
        Me.Lbl_price.Text = "PRICE"
        '
        'Lbl_proname
        '
        Me.Lbl_proname.AutoSize = True
        Me.Lbl_proname.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_proname.ForeColor = System.Drawing.Color.Snow
        Me.Lbl_proname.Location = New System.Drawing.Point(690, 56)
        Me.Lbl_proname.Name = "Lbl_proname"
        Me.Lbl_proname.Size = New System.Drawing.Size(263, 35)
        Me.Lbl_proname.TabIndex = 1
        Me.Lbl_proname.Text = "PRODUCT NAME"
        '
        'Lbl_ID
        '
        Me.Lbl_ID.AutoSize = True
        Me.Lbl_ID.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_ID.ForeColor = System.Drawing.Color.Snow
        Me.Lbl_ID.Location = New System.Drawing.Point(36, 53)
        Me.Lbl_ID.Name = "Lbl_ID"
        Me.Lbl_ID.Size = New System.Drawing.Size(206, 35)
        Me.Lbl_ID.TabIndex = 0
        Me.Lbl_ID.Text = "PRODUCT ID"
        '
        'Lbl_close
        '
        Me.Lbl_close.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_close.Location = New System.Drawing.Point(1693, 1)
        Me.Lbl_close.Name = "Lbl_close"
        Me.Lbl_close.Size = New System.Drawing.Size(84, 60)
        Me.Lbl_close.TabIndex = 17
        Me.Lbl_close.Text = "X"
        Me.Lbl_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Chocolate
        Me.Panel1.Controls.Add(Me.PB_clear)
        Me.Panel1.Controls.Add(Me.PB_delete)
        Me.Panel1.Controls.Add(Me.PB_update)
        Me.Panel1.Controls.Add(Me.PB_add)
        Me.Panel1.Controls.Add(Me.Txt_qty)
        Me.Panel1.Controls.Add(Me.Lbl_qty)
        Me.Panel1.Controls.Add(Me.Cbox_category)
        Me.Panel1.Controls.Add(Me.Txt_price)
        Me.Panel1.Controls.Add(Me.Txt_proName)
        Me.Panel1.Controls.Add(Me.Txt_desc)
        Me.Panel1.Controls.Add(Me.Lbl_AUTOID)
        Me.Panel1.Controls.Add(Me.Lbl_cat)
        Me.Panel1.Controls.Add(Me.Lbl_desc)
        Me.Panel1.Controls.Add(Me.Lbl_price)
        Me.Panel1.Controls.Add(Me.Lbl_proname)
        Me.Panel1.Controls.Add(Me.Lbl_ID)
        Me.Panel1.Location = New System.Drawing.Point(0, 125)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2035, 345)
        Me.Panel1.TabIndex = 15
        '
        'Txt_desc
        '
        Me.Txt_desc.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Txt_desc.ForeColor = System.Drawing.Color.Chocolate
        Me.Txt_desc.Location = New System.Drawing.Point(267, 206)
        Me.Txt_desc.Name = "Txt_desc"
        Me.Txt_desc.Size = New System.Drawing.Size(289, 42)
        Me.Txt_desc.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Snow
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Chocolate
        Me.Label2.Location = New System.Drawing.Point(0, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1920, 62)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "PRODUCT MANAGEMENT"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Chocolate
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1920, 60)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Galaxy inventory"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'productdgv
        '
        Me.productdgv.AllowUserToAddRows = False
        Me.productdgv.AllowUserToDeleteRows = False
        Me.productdgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.productdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.productdgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.productdgv.BackgroundColor = System.Drawing.Color.Snow
        Me.productdgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.productdgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.productdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.productdgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.productdgv.GridColor = System.Drawing.SystemColors.ControlText
        Me.productdgv.Location = New System.Drawing.Point(0, 507)
        Me.productdgv.Margin = New System.Windows.Forms.Padding(5)
        Me.productdgv.Name = "productdgv"
        Me.productdgv.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.productdgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.productdgv.RowHeadersVisible = False
        Me.productdgv.RowHeadersWidth = 62
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Cornsilk
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.productdgv.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.productdgv.RowTemplate.Height = 33
        Me.productdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.productdgv.Size = New System.Drawing.Size(1920, 536)
        Me.productdgv.TabIndex = 16
        '
        'Frm_Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1046)
        Me.Controls.Add(Me.Lbl_close)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.productdgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Product"
        Me.Text = "Frm_Product"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PB_clear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_add, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.productdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TT_clearbtn As ToolTip
    Friend WithEvents TT_deletebtn As ToolTip
    Friend WithEvents TT_updatebtn As ToolTip
    Friend WithEvents PB_clear As PictureBox
    Friend WithEvents PB_delete As PictureBox
    Friend WithEvents PB_update As PictureBox
    Friend WithEvents PB_add As PictureBox
    Friend WithEvents Txt_qty As TextBox
    Friend WithEvents Lbl_qty As Label
    Friend WithEvents Cbox_category As ComboBox
    Friend WithEvents Txt_price As TextBox
    Friend WithEvents TT_addbtn As ToolTip
    Friend WithEvents Txt_proName As TextBox
    Friend WithEvents Lbl_AUTOID As TextBox
    Friend WithEvents Lbl_cat As Label
    Friend WithEvents Lbl_desc As Label
    Friend WithEvents Lbl_price As Label
    Friend WithEvents Lbl_proname As Label
    Friend WithEvents Lbl_ID As Label
    Friend WithEvents Lbl_close As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Txt_desc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents productdgv As DataGridView
End Class
