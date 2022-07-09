<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Product_Mng
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Product_Mng))
        Me.Lbl_close = New System.Windows.Forms.Label()
        Me.Lbl_product = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TT_Customer = New System.Windows.Forms.ToolTip(Me.components)
        Me.Lbl_category = New System.Windows.Forms.Label()
        Me.Lbl_icon = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl_close
        '
        Me.Lbl_close.BackColor = System.Drawing.Color.Snow
        Me.Lbl_close.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_close.Location = New System.Drawing.Point(1081, 1)
        Me.Lbl_close.Name = "Lbl_close"
        Me.Lbl_close.Size = New System.Drawing.Size(84, 60)
        Me.Lbl_close.TabIndex = 62
        Me.Lbl_close.Text = "X"
        Me.Lbl_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_product
        '
        Me.Lbl_product.BackColor = System.Drawing.Color.PeachPuff
        Me.Lbl_product.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_product.Location = New System.Drawing.Point(395, 183)
        Me.Lbl_product.Name = "Lbl_product"
        Me.Lbl_product.Size = New System.Drawing.Size(266, 187)
        Me.Lbl_product.TabIndex = 60
        Me.Lbl_product.Text = "Label2"
        Me.Lbl_product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Label3.Size = New System.Drawing.Size(1195, 60)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Product Information"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Galaxy inventory"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_category
        '
        Me.Lbl_category.BackColor = System.Drawing.Color.PeachPuff
        Me.Lbl_category.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_category.Location = New System.Drawing.Point(767, 183)
        Me.Lbl_category.Name = "Lbl_category"
        Me.Lbl_category.Size = New System.Drawing.Size(266, 187)
        Me.Lbl_category.TabIndex = 63
        Me.Lbl_category.Text = "Label2"
        Me.Lbl_category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_icon
        '
        Me.Lbl_icon.Image = CType(resources.GetObject("Lbl_icon.Image"), System.Drawing.Image)
        Me.Lbl_icon.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_icon.Name = "Lbl_icon"
        Me.Lbl_icon.Size = New System.Drawing.Size(262, 215)
        Me.Lbl_icon.TabIndex = 64
        '
        'Frm_Product_Mng
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(1195, 720)
        Me.Controls.Add(Me.Lbl_icon)
        Me.Controls.Add(Me.Lbl_category)
        Me.Controls.Add(Me.Lbl_close)
        Me.Controls.Add(Me.Lbl_product)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Product_Mng"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Product_Mng"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lbl_close As Label
    Friend WithEvents Lbl_product As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TT_Customer As ToolTip
    Friend WithEvents Lbl_category As Label
    Friend WithEvents Lbl_icon As Label
End Class
