<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Users
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Users))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TT_deletebtn = New System.Windows.Forms.ToolTip(Me.components)
        Me.TT_updatebtn = New System.Windows.Forms.ToolTip(Me.components)
        Me.TT_addbtn = New System.Windows.Forms.ToolTip(Me.components)
        Me.TT_clearbtn = New System.Windows.Forms.ToolTip(Me.components)
        Me.PB_clear = New System.Windows.Forms.PictureBox()
        Me.PB_delete = New System.Windows.Forms.PictureBox()
        Me.PB_update = New System.Windows.Forms.PictureBox()
        Me.PB_add = New System.Windows.Forms.PictureBox()
        Me.userdgv = New System.Windows.Forms.DataGridView()
        Me.Lbl_close = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.upass = New System.Windows.Forms.TextBox()
        Me.uname = New System.Windows.Forms.TextBox()
        Me.Lbl_pass = New System.Windows.Forms.Label()
        Me.Lbl_uname = New System.Windows.Forms.Label()
        Me.CB_eye = New System.Windows.Forms.CheckBox()
        Me.Lbl_type = New System.Windows.Forms.Label()
        Me.CB_type = New System.Windows.Forms.ComboBox()
        CType(Me.PB_clear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Snow
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Chocolate
        Me.Label2.Location = New System.Drawing.Point(0, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1285, 60)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "User Information"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PB_clear
        '
        Me.PB_clear.BackgroundImage = CType(resources.GetObject("PB_clear.BackgroundImage"), System.Drawing.Image)
        Me.PB_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PB_clear.Location = New System.Drawing.Point(356, 544)
        Me.PB_clear.Name = "PB_clear"
        Me.PB_clear.Size = New System.Drawing.Size(175, 130)
        Me.PB_clear.TabIndex = 44
        Me.PB_clear.TabStop = False
        '
        'PB_delete
        '
        Me.PB_delete.BackgroundImage = CType(resources.GetObject("PB_delete.BackgroundImage"), System.Drawing.Image)
        Me.PB_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PB_delete.Location = New System.Drawing.Point(356, 369)
        Me.PB_delete.Name = "PB_delete"
        Me.PB_delete.Size = New System.Drawing.Size(175, 141)
        Me.PB_delete.TabIndex = 43
        Me.PB_delete.TabStop = False
        '
        'PB_update
        '
        Me.PB_update.BackgroundImage = CType(resources.GetObject("PB_update.BackgroundImage"), System.Drawing.Image)
        Me.PB_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PB_update.Location = New System.Drawing.Point(60, 544)
        Me.PB_update.Name = "PB_update"
        Me.PB_update.Size = New System.Drawing.Size(175, 130)
        Me.PB_update.TabIndex = 42
        Me.PB_update.TabStop = False
        '
        'PB_add
        '
        Me.PB_add.BackgroundImage = CType(resources.GetObject("PB_add.BackgroundImage"), System.Drawing.Image)
        Me.PB_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PB_add.Location = New System.Drawing.Point(60, 369)
        Me.PB_add.Name = "PB_add"
        Me.PB_add.Size = New System.Drawing.Size(175, 141)
        Me.PB_add.TabIndex = 41
        Me.PB_add.TabStop = False
        '
        'userdgv
        '
        Me.userdgv.AllowUserToAddRows = False
        Me.userdgv.AllowUserToDeleteRows = False
        Me.userdgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.userdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.userdgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.userdgv.BackgroundColor = System.Drawing.Color.Snow
        Me.userdgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.userdgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.userdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.userdgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.userdgv.GridColor = System.Drawing.SystemColors.ControlText
        Me.userdgv.Location = New System.Drawing.Point(695, 125)
        Me.userdgv.Margin = New System.Windows.Forms.Padding(5)
        Me.userdgv.Name = "userdgv"
        Me.userdgv.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.userdgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.userdgv.RowHeadersVisible = False
        Me.userdgv.RowHeadersWidth = 62
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Cornsilk
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.userdgv.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.userdgv.RowTemplate.Height = 33
        Me.userdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.userdgv.Size = New System.Drawing.Size(590, 632)
        Me.userdgv.TabIndex = 36
        '
        'Lbl_close
        '
        Me.Lbl_close.BackColor = System.Drawing.Color.Snow
        Me.Lbl_close.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_close.Location = New System.Drawing.Point(1154, 0)
        Me.Lbl_close.Name = "Lbl_close"
        Me.Lbl_close.Size = New System.Drawing.Size(84, 60)
        Me.Lbl_close.TabIndex = 34
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
        Me.Label1.Size = New System.Drawing.Size(1285, 60)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Galaxy inventory"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'upass
        '
        Me.upass.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.upass.ForeColor = System.Drawing.Color.Chocolate
        Me.upass.Location = New System.Drawing.Point(307, 217)
        Me.upass.Name = "upass"
        Me.upass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.upass.Size = New System.Drawing.Size(289, 42)
        Me.upass.TabIndex = 1
        '
        'uname
        '
        Me.uname.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.uname.ForeColor = System.Drawing.Color.Chocolate
        Me.uname.Location = New System.Drawing.Point(307, 148)
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(289, 42)
        Me.uname.TabIndex = 0
        '
        'Lbl_pass
        '
        Me.Lbl_pass.AutoSize = True
        Me.Lbl_pass.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_pass.ForeColor = System.Drawing.Color.Snow
        Me.Lbl_pass.Location = New System.Drawing.Point(48, 217)
        Me.Lbl_pass.Name = "Lbl_pass"
        Me.Lbl_pass.Size = New System.Drawing.Size(182, 35)
        Me.Lbl_pass.TabIndex = 48
        Me.Lbl_pass.Text = "PASSWORD"
        '
        'Lbl_uname
        '
        Me.Lbl_uname.AutoSize = True
        Me.Lbl_uname.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_uname.ForeColor = System.Drawing.Color.Snow
        Me.Lbl_uname.Location = New System.Drawing.Point(48, 151)
        Me.Lbl_uname.Name = "Lbl_uname"
        Me.Lbl_uname.Size = New System.Drawing.Size(187, 35)
        Me.Lbl_uname.TabIndex = 47
        Me.Lbl_uname.Text = "USERNAME"
        '
        'CB_eye
        '
        Me.CB_eye.Image = Global.Galaxy_Inventory_Management.My.Resources.Resources.hide
        Me.CB_eye.Location = New System.Drawing.Point(602, 219)
        Me.CB_eye.Name = "CB_eye"
        Me.CB_eye.Size = New System.Drawing.Size(85, 44)
        Me.CB_eye.TabIndex = 50
        Me.CB_eye.UseVisualStyleBackColor = True
        '
        'Lbl_type
        '
        Me.Lbl_type.AutoSize = True
        Me.Lbl_type.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_type.ForeColor = System.Drawing.Color.Snow
        Me.Lbl_type.Location = New System.Drawing.Point(48, 280)
        Me.Lbl_type.Name = "Lbl_type"
        Me.Lbl_type.Size = New System.Drawing.Size(242, 35)
        Me.Lbl_type.TabIndex = 51
        Me.Lbl_type.Text = "MEMBER TYPE"
        '
        'CB_type
        '
        Me.CB_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_type.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CB_type.ForeColor = System.Drawing.Color.Chocolate
        Me.CB_type.FormattingEnabled = True
        Me.CB_type.Items.AddRange(New Object() {"ADMIN", "PRODUCT DEPARTMENT", "CUSTOMER DEPARTMENT", "ORDER DEPARTMENT"})
        Me.CB_type.Location = New System.Drawing.Point(307, 280)
        Me.CB_type.Name = "CB_type"
        Me.CB_type.Size = New System.Drawing.Size(323, 34)
        Me.CB_type.TabIndex = 2
        '
        'Frm_Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(1285, 757)
        Me.Controls.Add(Me.CB_type)
        Me.Controls.Add(Me.Lbl_type)
        Me.Controls.Add(Me.CB_eye)
        Me.Controls.Add(Me.upass)
        Me.Controls.Add(Me.uname)
        Me.Controls.Add(Me.Lbl_pass)
        Me.Controls.Add(Me.Lbl_uname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PB_clear)
        Me.Controls.Add(Me.PB_delete)
        Me.Controls.Add(Me.PB_update)
        Me.Controls.Add(Me.PB_add)
        Me.Controls.Add(Me.userdgv)
        Me.Controls.Add(Me.Lbl_close)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Users"
        CType(Me.PB_clear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TT_deletebtn As ToolTip
    Friend WithEvents TT_updatebtn As ToolTip
    Friend WithEvents TT_addbtn As ToolTip
    Friend WithEvents TT_clearbtn As ToolTip
    Friend WithEvents PB_clear As PictureBox
    Friend WithEvents PB_delete As PictureBox
    Friend WithEvents PB_update As PictureBox
    Friend WithEvents PB_add As PictureBox
    Friend WithEvents userdgv As DataGridView
    Friend WithEvents Lbl_close As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents upass As TextBox
    Friend WithEvents uname As TextBox
    Friend WithEvents Lbl_pass As Label
    Friend WithEvents Lbl_uname As Label
    Friend WithEvents CB_eye As CheckBox
    Friend WithEvents Lbl_type As Label
    Friend WithEvents CB_type As ComboBox
End Class
