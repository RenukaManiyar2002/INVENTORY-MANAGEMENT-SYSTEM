<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Customer))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PB_clear = New System.Windows.Forms.PictureBox()
        Me.PB_delete = New System.Windows.Forms.PictureBox()
        Me.PB_update = New System.Windows.Forms.PictureBox()
        Me.PB_add = New System.Windows.Forms.PictureBox()
        Me.custname = New System.Windows.Forms.TextBox()
        Me.Lbl_Name = New System.Windows.Forms.Label()
        Me.custid = New System.Windows.Forms.TextBox()
        Me.Lbl_ID = New System.Windows.Forms.Label()
        Me.catdgv = New System.Windows.Forms.DataGridView()
        Me.Lbl_close = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TT_addbtn = New System.Windows.Forms.ToolTip(Me.components)
        Me.TT_updatebtn = New System.Windows.Forms.ToolTip(Me.components)
        Me.TT_deletebtn = New System.Windows.Forms.ToolTip(Me.components)
        Me.TT_clearbtn = New System.Windows.Forms.ToolTip(Me.components)
        Me.custphone = New System.Windows.Forms.TextBox()
        Me.Lbl_phno = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PB_clear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.catdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB_clear
        '
        Me.PB_clear.BackgroundImage = CType(resources.GetObject("PB_clear.BackgroundImage"), System.Drawing.Image)
        Me.PB_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PB_clear.Location = New System.Drawing.Point(379, 532)
        Me.PB_clear.Name = "PB_clear"
        Me.PB_clear.Size = New System.Drawing.Size(175, 130)
        Me.PB_clear.TabIndex = 43
        Me.PB_clear.TabStop = False
        '
        'PB_delete
        '
        Me.PB_delete.BackgroundImage = CType(resources.GetObject("PB_delete.BackgroundImage"), System.Drawing.Image)
        Me.PB_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PB_delete.Enabled = False
        Me.PB_delete.Location = New System.Drawing.Point(379, 357)
        Me.PB_delete.Name = "PB_delete"
        Me.PB_delete.Size = New System.Drawing.Size(175, 141)
        Me.PB_delete.TabIndex = 42
        Me.PB_delete.TabStop = False
        '
        'PB_update
        '
        Me.PB_update.BackgroundImage = CType(resources.GetObject("PB_update.BackgroundImage"), System.Drawing.Image)
        Me.PB_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PB_update.Enabled = False
        Me.PB_update.Location = New System.Drawing.Point(83, 532)
        Me.PB_update.Name = "PB_update"
        Me.PB_update.Size = New System.Drawing.Size(175, 130)
        Me.PB_update.TabIndex = 41
        Me.PB_update.TabStop = False
        '
        'PB_add
        '
        Me.PB_add.BackgroundImage = CType(resources.GetObject("PB_add.BackgroundImage"), System.Drawing.Image)
        Me.PB_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PB_add.Location = New System.Drawing.Point(83, 357)
        Me.PB_add.Name = "PB_add"
        Me.PB_add.Size = New System.Drawing.Size(175, 141)
        Me.PB_add.TabIndex = 40
        Me.PB_add.TabStop = False
        '
        'custname
        '
        Me.custname.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.custname.ForeColor = System.Drawing.Color.Chocolate
        Me.custname.Location = New System.Drawing.Point(301, 231)
        Me.custname.Name = "custname"
        Me.custname.Size = New System.Drawing.Size(289, 42)
        Me.custname.TabIndex = 38
        '
        'Lbl_Name
        '
        Me.Lbl_Name.AutoSize = True
        Me.Lbl_Name.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_Name.ForeColor = System.Drawing.Color.Snow
        Me.Lbl_Name.Location = New System.Drawing.Point(12, 231)
        Me.Lbl_Name.Name = "Lbl_Name"
        Me.Lbl_Name.Size = New System.Drawing.Size(287, 35)
        Me.Lbl_Name.TabIndex = 39
        Me.Lbl_Name.Text = "CUSTOMER NAME"
        '
        'custid
        '
        Me.custid.Enabled = False
        Me.custid.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.custid.ForeColor = System.Drawing.Color.Chocolate
        Me.custid.Location = New System.Drawing.Point(301, 155)
        Me.custid.Name = "custid"
        Me.custid.Size = New System.Drawing.Size(289, 42)
        Me.custid.TabIndex = 36
        '
        'Lbl_ID
        '
        Me.Lbl_ID.AutoSize = True
        Me.Lbl_ID.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_ID.ForeColor = System.Drawing.Color.Snow
        Me.Lbl_ID.Location = New System.Drawing.Point(12, 155)
        Me.Lbl_ID.Name = "Lbl_ID"
        Me.Lbl_ID.Size = New System.Drawing.Size(230, 35)
        Me.Lbl_ID.TabIndex = 37
        Me.Lbl_ID.Text = "CUSTOMER ID"
        '
        'catdgv
        '
        Me.catdgv.AllowUserToAddRows = False
        Me.catdgv.AllowUserToDeleteRows = False
        Me.catdgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.catdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.catdgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.catdgv.BackgroundColor = System.Drawing.Color.Snow
        Me.catdgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.catdgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.catdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.catdgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.catdgv.GridColor = System.Drawing.SystemColors.ControlText
        Me.catdgv.Location = New System.Drawing.Point(659, 125)
        Me.catdgv.Margin = New System.Windows.Forms.Padding(5)
        Me.catdgv.Name = "catdgv"
        Me.catdgv.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.catdgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.catdgv.RowHeadersVisible = False
        Me.catdgv.RowHeadersWidth = 62
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Cornsilk
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.catdgv.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.catdgv.RowTemplate.Height = 33
        Me.catdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.catdgv.Size = New System.Drawing.Size(597, 639)
        Me.catdgv.TabIndex = 35
        '
        'Lbl_close
        '
        Me.Lbl_close.BackColor = System.Drawing.Color.Snow
        Me.Lbl_close.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_close.Location = New System.Drawing.Point(1130, 1)
        Me.Lbl_close.Name = "Lbl_close"
        Me.Lbl_close.Size = New System.Drawing.Size(84, 60)
        Me.Lbl_close.TabIndex = 33
        Me.Lbl_close.Text = "X"
        Me.Lbl_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Chocolate
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1256, 60)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Galaxy inventory"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'custphone
        '
        Me.custphone.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.custphone.ForeColor = System.Drawing.Color.Chocolate
        Me.custphone.Location = New System.Drawing.Point(301, 309)
        Me.custphone.Name = "custphone"
        Me.custphone.Size = New System.Drawing.Size(289, 42)
        Me.custphone.TabIndex = 44
        '
        'Lbl_phno
        '
        Me.Lbl_phno.AutoSize = True
        Me.Lbl_phno.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_phno.ForeColor = System.Drawing.Color.Snow
        Me.Lbl_phno.Location = New System.Drawing.Point(12, 309)
        Me.Lbl_phno.Name = "Lbl_phno"
        Me.Lbl_phno.Size = New System.Drawing.Size(175, 35)
        Me.Lbl_phno.TabIndex = 45
        Me.Lbl_phno.Text = "PHONE NO"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Snow
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Chocolate
        Me.Label3.Location = New System.Drawing.Point(0, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1256, 60)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Customer Information"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(1256, 765)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.custphone)
        Me.Controls.Add(Me.Lbl_phno)
        Me.Controls.Add(Me.PB_clear)
        Me.Controls.Add(Me.PB_delete)
        Me.Controls.Add(Me.PB_update)
        Me.Controls.Add(Me.PB_add)
        Me.Controls.Add(Me.custname)
        Me.Controls.Add(Me.Lbl_Name)
        Me.Controls.Add(Me.custid)
        Me.Controls.Add(Me.Lbl_ID)
        Me.Controls.Add(Me.catdgv)
        Me.Controls.Add(Me.Lbl_close)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Customer"
        CType(Me.PB_clear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.catdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PB_clear As PictureBox
    Friend WithEvents PB_delete As PictureBox
    Friend WithEvents PB_update As PictureBox
    Friend WithEvents PB_add As PictureBox
    Friend WithEvents custname As TextBox
    Friend WithEvents Lbl_Name As Label
    Friend WithEvents custid As TextBox
    Friend WithEvents Lbl_ID As Label
    Friend WithEvents catdgv As DataGridView
    Friend WithEvents Lbl_close As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TT_addbtn As ToolTip
    Friend WithEvents TT_updatebtn As ToolTip
    Friend WithEvents TT_deletebtn As ToolTip
    Friend WithEvents TT_clearbtn As ToolTip
    Friend WithEvents custphone As TextBox
    Friend WithEvents Lbl_phno As Label
    Friend WithEvents Label3 As Label
End Class
