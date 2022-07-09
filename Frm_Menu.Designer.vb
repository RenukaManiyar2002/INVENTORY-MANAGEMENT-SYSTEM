<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Menu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_close = New System.Windows.Forms.Label()
        Me.Lbl_Product = New System.Windows.Forms.Label()
        Me.Lbl_Category = New System.Windows.Forms.Label()
        Me.Lbl_Customer = New System.Windows.Forms.Label()
        Me.Lbl_Order = New System.Windows.Forms.Label()
        Me.TT_Product = New System.Windows.Forms.ToolTip(Me.components)
        Me.TT_Category = New System.Windows.Forms.ToolTip(Me.components)
        Me.TT_Customer = New System.Windows.Forms.ToolTip(Me.components)
        Me.TT_Order = New System.Windows.Forms.ToolTip(Me.components)
        Me.TT_Users = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Snow
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Chocolate
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1091, 60)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Galaxy inventory"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_close
        '
        Me.Lbl_close.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_close.Location = New System.Drawing.Point(953, 1)
        Me.Lbl_close.Name = "Lbl_close"
        Me.Lbl_close.Size = New System.Drawing.Size(84, 60)
        Me.Lbl_close.TabIndex = 19
        Me.Lbl_close.Text = "X"
        Me.Lbl_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Product
        '
        Me.Lbl_Product.Image = CType(resources.GetObject("Lbl_Product.Image"), System.Drawing.Image)
        Me.Lbl_Product.Location = New System.Drawing.Point(206, 94)
        Me.Lbl_Product.Name = "Lbl_Product"
        Me.Lbl_Product.Size = New System.Drawing.Size(262, 215)
        Me.Lbl_Product.TabIndex = 26
        '
        'Lbl_Category
        '
        Me.Lbl_Category.Image = CType(resources.GetObject("Lbl_Category.Image"), System.Drawing.Image)
        Me.Lbl_Category.Location = New System.Drawing.Point(554, 94)
        Me.Lbl_Category.Name = "Lbl_Category"
        Me.Lbl_Category.Size = New System.Drawing.Size(262, 215)
        Me.Lbl_Category.TabIndex = 27
        '
        'Lbl_Customer
        '
        Me.Lbl_Customer.Image = CType(resources.GetObject("Lbl_Customer.Image"), System.Drawing.Image)
        Me.Lbl_Customer.Location = New System.Drawing.Point(566, 353)
        Me.Lbl_Customer.Name = "Lbl_Customer"
        Me.Lbl_Customer.Size = New System.Drawing.Size(262, 234)
        Me.Lbl_Customer.TabIndex = 28
        '
        'Lbl_Order
        '
        Me.Lbl_Order.Image = CType(resources.GetObject("Lbl_Order.Image"), System.Drawing.Image)
        Me.Lbl_Order.Location = New System.Drawing.Point(206, 353)
        Me.Lbl_Order.Name = "Lbl_Order"
        Me.Lbl_Order.Size = New System.Drawing.Size(262, 234)
        Me.Lbl_Order.TabIndex = 29
        '
        'TT_Product
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.MistyRose
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(265, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 32)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "PRODUCT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.MistyRose
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(604, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 32)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "CATEGORY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.MistyRose
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(292, 565)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 32)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "ORDER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.MistyRose
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(620, 565)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 32)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "CUSTOMER"
        '
        'Frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(1091, 636)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lbl_Order)
        Me.Controls.Add(Me.Lbl_Customer)
        Me.Controls.Add(Me.Lbl_Category)
        Me.Controls.Add(Me.Lbl_Product)
        Me.Controls.Add(Me.Lbl_close)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_close As Label
    Friend WithEvents Lbl_Product As Label
    Friend WithEvents Lbl_Category As Label
    Friend WithEvents Lbl_Customer As Label
    Friend WithEvents Lbl_Order As Label
    Friend WithEvents TT_Product As ToolTip
    Friend WithEvents TT_Category As ToolTip
    Friend WithEvents TT_Customer As ToolTip
    Friend WithEvents TT_Order As ToolTip
    Friend WithEvents TT_Users As ToolTip
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
