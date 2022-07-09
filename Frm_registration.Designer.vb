<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_registration))
        Me.Txt_upass1 = New System.Windows.Forms.TextBox()
        Me.Txt_upass = New System.Windows.Forms.TextBox()
        Me.Txt_uname = New System.Windows.Forms.TextBox()
        Me.Lbl_createnow = New System.Windows.Forms.Label()
        Me.Lbl_regis_now = New System.Windows.Forms.Label()
        Me.Lbl_pass2 = New System.Windows.Forms.Label()
        Me.Lbl_pass1 = New System.Windows.Forms.Label()
        Me.Lbl_uname = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_eye = New System.Windows.Forms.CheckBox()
        Me.CB_type = New System.Windows.Forms.ComboBox()
        Me.Lbl_type = New System.Windows.Forms.Label()
        Me.Lbl_close = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Txt_upass1
        '
        Me.Txt_upass1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Txt_upass1.Location = New System.Drawing.Point(534, 231)
        Me.Txt_upass1.Name = "Txt_upass1"
        Me.Txt_upass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_upass1.Size = New System.Drawing.Size(272, 40)
        Me.Txt_upass1.TabIndex = 13
        '
        'Txt_upass
        '
        Me.Txt_upass.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Txt_upass.Location = New System.Drawing.Point(534, 159)
        Me.Txt_upass.Name = "Txt_upass"
        Me.Txt_upass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_upass.Size = New System.Drawing.Size(272, 40)
        Me.Txt_upass.TabIndex = 11
        '
        'Txt_uname
        '
        Me.Txt_uname.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Txt_uname.Location = New System.Drawing.Point(534, 87)
        Me.Txt_uname.Name = "Txt_uname"
        Me.Txt_uname.Size = New System.Drawing.Size(272, 40)
        Me.Txt_uname.TabIndex = 9
        '
        'Lbl_createnow
        '
        Me.Lbl_createnow.AutoSize = True
        Me.Lbl_createnow.BackColor = System.Drawing.Color.Sienna
        Me.Lbl_createnow.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_createnow.Location = New System.Drawing.Point(190, 471)
        Me.Lbl_createnow.Name = "Lbl_createnow"
        Me.Lbl_createnow.Size = New System.Drawing.Size(616, 45)
        Me.Lbl_createnow.TabIndex = 14
        Me.Lbl_createnow.Text = "HAVE ACCOUNT? LOGIN NOW"
        '
        'Lbl_regis_now
        '
        Me.Lbl_regis_now.AutoSize = True
        Me.Lbl_regis_now.BackColor = System.Drawing.Color.Sienna
        Me.Lbl_regis_now.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_regis_now.Location = New System.Drawing.Point(339, 393)
        Me.Lbl_regis_now.Name = "Lbl_regis_now"
        Me.Lbl_regis_now.Size = New System.Drawing.Size(338, 45)
        Me.Lbl_regis_now.TabIndex = 12
        Me.Lbl_regis_now.Text = "REGISTER NOW"
        '
        'Lbl_pass2
        '
        Me.Lbl_pass2.AutoSize = True
        Me.Lbl_pass2.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_pass2.Location = New System.Drawing.Point(190, 239)
        Me.Lbl_pass2.Name = "Lbl_pass2"
        Me.Lbl_pass2.Size = New System.Drawing.Size(315, 32)
        Me.Lbl_pass2.TabIndex = 10
        Me.Lbl_pass2.Text = "CONFRIM PASSWORD"
        '
        'Lbl_pass1
        '
        Me.Lbl_pass1.AutoSize = True
        Me.Lbl_pass1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_pass1.Location = New System.Drawing.Point(190, 167)
        Me.Lbl_pass1.Name = "Lbl_pass1"
        Me.Lbl_pass1.Size = New System.Drawing.Size(172, 32)
        Me.Lbl_pass1.TabIndex = 8
        Me.Lbl_pass1.Text = "PASSWORD"
        '
        'Lbl_uname
        '
        Me.Lbl_uname.AutoSize = True
        Me.Lbl_uname.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_uname.Location = New System.Drawing.Point(190, 95)
        Me.Lbl_uname.Name = "Lbl_uname"
        Me.Lbl_uname.Size = New System.Drawing.Size(277, 32)
        Me.Lbl_uname.TabIndex = 7
        Me.Lbl_uname.Text = "ENTER USERNAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Sienna
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(386, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 45)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "REGISTER"
        '
        'CB_eye
        '
        Me.CB_eye.Image = Global.Galaxy_Inventory_Management.My.Resources.Resources.hide
        Me.CB_eye.Location = New System.Drawing.Point(832, 227)
        Me.CB_eye.Name = "CB_eye"
        Me.CB_eye.Size = New System.Drawing.Size(85, 44)
        Me.CB_eye.TabIndex = 25
        Me.CB_eye.UseVisualStyleBackColor = True
        '
        'CB_type
        '
        Me.CB_type.AutoCompleteCustomSource.AddRange(New String() {"ADMIN", "PRODUCT DEPARTMENT", "CUSTOMER DEPARTMENT", "ORDER DEPARTMENT"})
        Me.CB_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_type.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CB_type.ForeColor = System.Drawing.Color.Chocolate
        Me.CB_type.FormattingEnabled = True
        Me.CB_type.Items.AddRange(New Object() {"ADMIN", "PRODUCT DEPARTMENT", "CUSTOMER DEPARTMENT", "ORDER DEPARTMENT"})
        Me.CB_type.Location = New System.Drawing.Point(534, 304)
        Me.CB_type.Name = "CB_type"
        Me.CB_type.Size = New System.Drawing.Size(311, 34)
        Me.CB_type.TabIndex = 52
        '
        'Lbl_type
        '
        Me.Lbl_type.AutoSize = True
        Me.Lbl_type.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_type.ForeColor = System.Drawing.Color.Black
        Me.Lbl_type.Location = New System.Drawing.Point(190, 303)
        Me.Lbl_type.Name = "Lbl_type"
        Me.Lbl_type.Size = New System.Drawing.Size(226, 32)
        Me.Lbl_type.TabIndex = 53
        Me.Lbl_type.Text = "MEMBER TYPE"
        '
        'Lbl_close
        '
        Me.Lbl_close.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_close.Location = New System.Drawing.Point(849, 12)
        Me.Lbl_close.Name = "Lbl_close"
        Me.Lbl_close.Size = New System.Drawing.Size(84, 60)
        Me.Lbl_close.TabIndex = 57
        Me.Lbl_close.Text = "X"
        Me.Lbl_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(978, 558)
        Me.Controls.Add(Me.Lbl_close)
        Me.Controls.Add(Me.CB_type)
        Me.Controls.Add(Me.Lbl_type)
        Me.Controls.Add(Me.CB_eye)
        Me.Controls.Add(Me.Txt_upass1)
        Me.Controls.Add(Me.Txt_upass)
        Me.Controls.Add(Me.Txt_uname)
        Me.Controls.Add(Me.Lbl_createnow)
        Me.Controls.Add(Me.Lbl_regis_now)
        Me.Controls.Add(Me.Lbl_pass2)
        Me.Controls.Add(Me.Lbl_pass1)
        Me.Controls.Add(Me.Lbl_uname)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_upass1 As TextBox
    Friend WithEvents Txt_upass As TextBox
    Friend WithEvents Txt_uname As TextBox
    Friend WithEvents Lbl_createnow As Label
    Friend WithEvents Lbl_regis_now As Label
    Friend WithEvents Lbl_pass2 As Label
    Friend WithEvents Lbl_pass1 As Label
    Friend WithEvents Lbl_uname As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_eye As CheckBox
    Friend WithEvents CB_type As ComboBox
    Friend WithEvents Lbl_type As Label
    Friend WithEvents Lbl_close As Label
End Class
