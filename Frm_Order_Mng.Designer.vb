<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Order_Mng
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Order_Mng))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_close = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_close = New System.Windows.Forms.Label()
        Me.orderdgv = New System.Windows.Forms.DataGridView()
        Me.Lbl_order = New System.Windows.Forms.Label()
        Me.TT_order = New System.Windows.Forms.ToolTip(Me.components)
        Me.Lbl_icon = New System.Windows.Forms.Label()
        CType(Me.orderdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Snow
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Chocolate
        Me.Label3.Location = New System.Drawing.Point(0, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1195, 57)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Order"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_close
        '
        Me.Lbl_close.BackColor = System.Drawing.Color.Snow
        Me.Lbl_close.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_close.Location = New System.Drawing.Point(1438, 477)
        Me.Lbl_close.Name = "Lbl_close"
        Me.Lbl_close.Size = New System.Drawing.Size(84, 59)
        Me.Lbl_close.TabIndex = 52
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
        Me.Label1.Size = New System.Drawing.Size(1195, 60)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Galaxy inventory"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_close
        '
        Me.Label_close.BackColor = System.Drawing.Color.Snow
        Me.Label_close.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_close.Location = New System.Drawing.Point(1069, 2)
        Me.Label_close.Name = "Label_close"
        Me.Label_close.Size = New System.Drawing.Size(84, 59)
        Me.Label_close.TabIndex = 54
        Me.Label_close.Text = "X"
        Me.Label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'orderdgv
        '
        Me.orderdgv.AllowUserToAddRows = False
        Me.orderdgv.AllowUserToDeleteRows = False
        Me.orderdgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.orderdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.orderdgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.orderdgv.BackgroundColor = System.Drawing.Color.Snow
        Me.orderdgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.orderdgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.orderdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.orderdgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.orderdgv.GridColor = System.Drawing.SystemColors.ControlText
        Me.orderdgv.Location = New System.Drawing.Point(534, 180)
        Me.orderdgv.Margin = New System.Windows.Forms.Padding(5)
        Me.orderdgv.Name = "orderdgv"
        Me.orderdgv.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.orderdgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.orderdgv.RowHeadersVisible = False
        Me.orderdgv.RowHeadersWidth = 62
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Cornsilk
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.orderdgv.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.orderdgv.RowTemplate.Height = 33
        Me.orderdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.orderdgv.Size = New System.Drawing.Size(636, 506)
        Me.orderdgv.TabIndex = 72
        '
        'Lbl_order
        '
        Me.Lbl_order.BackColor = System.Drawing.Color.PeachPuff
        Me.Lbl_order.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_order.Location = New System.Drawing.Point(30, 308)
        Me.Lbl_order.Name = "Lbl_order"
        Me.Lbl_order.Size = New System.Drawing.Size(266, 187)
        Me.Lbl_order.TabIndex = 73
        Me.Lbl_order.Text = "Label2"
        Me.Lbl_order.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_icon
        '
        Me.Lbl_icon.Image = CType(resources.GetObject("Lbl_icon.Image"), System.Drawing.Image)
        Me.Lbl_icon.Location = New System.Drawing.Point(0, 2)
        Me.Lbl_icon.Name = "Lbl_icon"
        Me.Lbl_icon.Size = New System.Drawing.Size(246, 216)
        Me.Lbl_icon.TabIndex = 74
        '
        'Frm_Order_Mng
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(1195, 720)
        Me.Controls.Add(Me.Lbl_icon)
        Me.Controls.Add(Me.Lbl_order)
        Me.Controls.Add(Me.orderdgv)
        Me.Controls.Add(Me.Label_close)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Lbl_close)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Order_Mng"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Order_Mng"
        CType(Me.orderdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Lbl_close As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_close As Label
    Friend WithEvents orderdgv As DataGridView
    Friend WithEvents Lbl_order As Label
    Friend WithEvents TT_order As ToolTip
    Friend WithEvents Lbl_icon As Label
End Class
