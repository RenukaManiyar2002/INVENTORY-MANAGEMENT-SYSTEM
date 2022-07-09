<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Order
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Order))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_close = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.custidcb = New System.Windows.Forms.ComboBox()
        Me.prodidcb = New System.Windows.Forms.ComboBox()
        Me.Txt_qty = New System.Windows.Forms.TextBox()
        Me.Lbl_qty = New System.Windows.Forms.Label()
        Me.custnamecb = New System.Windows.Forms.ComboBox()
        Me.prodnamecb = New System.Windows.Forms.ComboBox()
        Me.Txt_orderid = New System.Windows.Forms.TextBox()
        Me.Lbl_custname = New System.Windows.Forms.Label()
        Me.Lbl_custid = New System.Windows.Forms.Label()
        Me.Lbl_prodname = New System.Windows.Forms.Label()
        Me.Lbl_prodid = New System.Windows.Forms.Label()
        Me.Lbl_orderid = New System.Windows.Forms.Label()
        Me.billdgv = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lbl_amt = New System.Windows.Forms.Label()
        Me.Amtlbl = New System.Windows.Forms.Label()
        Me.Txt_price = New System.Windows.Forms.TextBox()
        Me.Lbl_price = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.orderdgv = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Lbl_add_to_bill = New System.Windows.Forms.Label()
        Me.Lbl_print = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.billdgv, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label3.Size = New System.Drawing.Size(1920, 57)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Order"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_close
        '
        Me.Lbl_close.BackColor = System.Drawing.Color.Snow
        Me.Lbl_close.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_close.Location = New System.Drawing.Point(1746, 1)
        Me.Lbl_close.Name = "Lbl_close"
        Me.Lbl_close.Size = New System.Drawing.Size(84, 59)
        Me.Lbl_close.TabIndex = 48
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
        Me.Label1.Size = New System.Drawing.Size(1920, 60)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Galaxy inventory"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'custidcb
        '
        Me.custidcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.custidcb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.custidcb.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.custidcb.FormattingEnabled = True
        Me.custidcb.Location = New System.Drawing.Point(290, 196)
        Me.custidcb.Name = "custidcb"
        Me.custidcb.Size = New System.Drawing.Size(341, 42)
        Me.custidcb.TabIndex = 0
        '
        'prodidcb
        '
        Me.prodidcb.DisplayMember = "-1"
        Me.prodidcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.prodidcb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.prodidcb.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.prodidcb.FormattingEnabled = True
        Me.prodidcb.Location = New System.Drawing.Point(290, 316)
        Me.prodidcb.Margin = New System.Windows.Forms.Padding(4)
        Me.prodidcb.Name = "prodidcb"
        Me.prodidcb.Size = New System.Drawing.Size(341, 42)
        Me.prodidcb.Sorted = True
        Me.prodidcb.TabIndex = 2
        Me.prodidcb.TabStop = False
        Me.prodidcb.ValueMember = "-1"
        '
        'Txt_qty
        '
        Me.Txt_qty.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Txt_qty.Location = New System.Drawing.Point(290, 503)
        Me.Txt_qty.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_qty.Name = "Txt_qty"
        Me.Txt_qty.Size = New System.Drawing.Size(341, 42)
        Me.Txt_qty.TabIndex = 4
        '
        'Lbl_qty
        '
        Me.Lbl_qty.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_qty.Location = New System.Drawing.Point(0, 503)
        Me.Lbl_qty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_qty.Name = "Lbl_qty"
        Me.Lbl_qty.Size = New System.Drawing.Size(238, 51)
        Me.Lbl_qty.TabIndex = 59
        Me.Lbl_qty.Text = "QUANTITY"
        '
        'custnamecb
        '
        Me.custnamecb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.custnamecb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.custnamecb.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.custnamecb.FormattingEnabled = True
        Me.custnamecb.Location = New System.Drawing.Point(290, 255)
        Me.custnamecb.Margin = New System.Windows.Forms.Padding(4)
        Me.custnamecb.Name = "custnamecb"
        Me.custnamecb.Size = New System.Drawing.Size(341, 42)
        Me.custnamecb.TabIndex = 1
        '
        'prodnamecb
        '
        Me.prodnamecb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.prodnamecb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.prodnamecb.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.prodnamecb.FormattingEnabled = True
        Me.prodnamecb.Location = New System.Drawing.Point(290, 378)
        Me.prodnamecb.Margin = New System.Windows.Forms.Padding(4)
        Me.prodnamecb.Name = "prodnamecb"
        Me.prodnamecb.Size = New System.Drawing.Size(341, 42)
        Me.prodnamecb.TabIndex = 3
        '
        'Txt_orderid
        '
        Me.Txt_orderid.Enabled = False
        Me.Txt_orderid.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Txt_orderid.Location = New System.Drawing.Point(290, 134)
        Me.Txt_orderid.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_orderid.Name = "Txt_orderid"
        Me.Txt_orderid.Size = New System.Drawing.Size(341, 42)
        Me.Txt_orderid.TabIndex = 56
        '
        'Lbl_custname
        '
        Me.Lbl_custname.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_custname.Location = New System.Drawing.Point(0, 255)
        Me.Lbl_custname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_custname.Name = "Lbl_custname"
        Me.Lbl_custname.Size = New System.Drawing.Size(288, 51)
        Me.Lbl_custname.TabIndex = 55
        Me.Lbl_custname.Text = "CUSTOMER NAME"
        '
        'Lbl_custid
        '
        Me.Lbl_custid.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_custid.Location = New System.Drawing.Point(0, 196)
        Me.Lbl_custid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_custid.Name = "Lbl_custid"
        Me.Lbl_custid.Size = New System.Drawing.Size(259, 51)
        Me.Lbl_custid.TabIndex = 54
        Me.Lbl_custid.Text = "CUSTOMER ID"
        '
        'Lbl_prodname
        '
        Me.Lbl_prodname.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_prodname.Location = New System.Drawing.Point(0, 381)
        Me.Lbl_prodname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_prodname.Name = "Lbl_prodname"
        Me.Lbl_prodname.Size = New System.Drawing.Size(288, 51)
        Me.Lbl_prodname.TabIndex = 53
        Me.Lbl_prodname.Text = "PRODUCT NAME"
        '
        'Lbl_prodid
        '
        Me.Lbl_prodid.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_prodid.Location = New System.Drawing.Point(0, 316)
        Me.Lbl_prodid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_prodid.Name = "Lbl_prodid"
        Me.Lbl_prodid.Size = New System.Drawing.Size(259, 51)
        Me.Lbl_prodid.TabIndex = 52
        Me.Lbl_prodid.Text = "PRODUCT ID"
        '
        'Lbl_orderid
        '
        Me.Lbl_orderid.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_orderid.Location = New System.Drawing.Point(3, 137)
        Me.Lbl_orderid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_orderid.Name = "Lbl_orderid"
        Me.Lbl_orderid.Size = New System.Drawing.Size(238, 51)
        Me.Lbl_orderid.TabIndex = 51
        Me.Lbl_orderid.Text = "ORDER ID"
        '
        'billdgv
        '
        Me.billdgv.AllowUserToAddRows = False
        Me.billdgv.AllowUserToDeleteRows = False
        Me.billdgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.billdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.billdgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.billdgv.BackgroundColor = System.Drawing.Color.Snow
        Me.billdgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.billdgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.billdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.billdgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.billdgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.billdgv.GridColor = System.Drawing.SystemColors.ControlText
        Me.billdgv.Location = New System.Drawing.Point(982, 196)
        Me.billdgv.Margin = New System.Windows.Forms.Padding(5)
        Me.billdgv.Name = "billdgv"
        Me.billdgv.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.billdgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.billdgv.RowHeadersVisible = False
        Me.billdgv.RowHeadersWidth = 62
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Cornsilk
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.billdgv.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.billdgv.RowTemplate.Height = 33
        Me.billdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.billdgv.Size = New System.Drawing.Size(924, 316)
        Me.billdgv.TabIndex = 65
        '
        'Column1
        '
        Me.Column1.HeaderText = "ORDER ID"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "PRODUCT NAME"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "PRICE"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "QUANTITY"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "TOTAL"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Lbl_amt
        '
        Me.Lbl_amt.AutoSize = True
        Me.Lbl_amt.BackColor = System.Drawing.Color.Snow
        Me.Lbl_amt.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_amt.Location = New System.Drawing.Point(1304, 706)
        Me.Lbl_amt.Name = "Lbl_amt"
        Me.Lbl_amt.Size = New System.Drawing.Size(255, 41)
        Me.Lbl_amt.TabIndex = 66
        Me.Lbl_amt.Text = "AMOUNT: RS."
        '
        'Amtlbl
        '
        Me.Amtlbl.AutoSize = True
        Me.Amtlbl.BackColor = System.Drawing.Color.Snow
        Me.Amtlbl.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Amtlbl.Location = New System.Drawing.Point(1559, 706)
        Me.Amtlbl.Name = "Amtlbl"
        Me.Amtlbl.Size = New System.Drawing.Size(0, 41)
        Me.Amtlbl.TabIndex = 67
        '
        'Txt_price
        '
        Me.Txt_price.Enabled = False
        Me.Txt_price.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Txt_price.Location = New System.Drawing.Point(290, 444)
        Me.Txt_price.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_price.Name = "Txt_price"
        Me.Txt_price.Size = New System.Drawing.Size(341, 42)
        Me.Txt_price.TabIndex = 69
        '
        'Lbl_price
        '
        Me.Lbl_price.Font = New System.Drawing.Font("Modern No. 20", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_price.Location = New System.Drawing.Point(0, 444)
        Me.Lbl_price.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_price.Name = "Lbl_price"
        Me.Lbl_price.Size = New System.Drawing.Size(238, 51)
        Me.Lbl_price.TabIndex = 68
        Me.Lbl_price.Text = "PRICE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Chocolate
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(1452, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 35)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "BILL"
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.orderdgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.orderdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.orderdgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.orderdgv.GridColor = System.Drawing.SystemColors.ControlText
        Me.orderdgv.Location = New System.Drawing.Point(14, 763)
        Me.orderdgv.Margin = New System.Windows.Forms.Padding(5)
        Me.orderdgv.Name = "orderdgv"
        Me.orderdgv.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.orderdgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.orderdgv.RowHeadersVisible = False
        Me.orderdgv.RowHeadersWidth = 62
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Cornsilk
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.orderdgv.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.orderdgv.RowTemplate.Height = 33
        Me.orderdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.orderdgv.Size = New System.Drawing.Size(1892, 226)
        Me.orderdgv.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Chocolate
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(714, 706)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(241, 35)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "PRODUCT LIST"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'Lbl_add_to_bill
        '
        Me.Lbl_add_to_bill.Image = CType(resources.GetObject("Lbl_add_to_bill.Image"), System.Drawing.Image)
        Me.Lbl_add_to_bill.Location = New System.Drawing.Point(703, 323)
        Me.Lbl_add_to_bill.Name = "Lbl_add_to_bill"
        Me.Lbl_add_to_bill.Size = New System.Drawing.Size(167, 135)
        Me.Lbl_add_to_bill.TabIndex = 74
        '
        'Lbl_print
        '
        Me.Lbl_print.Image = CType(resources.GetObject("Lbl_print.Image"), System.Drawing.Image)
        Me.Lbl_print.Location = New System.Drawing.Point(703, 156)
        Me.Lbl_print.Name = "Lbl_print"
        Me.Lbl_print.Size = New System.Drawing.Size(167, 141)
        Me.Lbl_print.TabIndex = 75
        '
        'Frm_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(1920, 1046)
        Me.Controls.Add(Me.Lbl_print)
        Me.Controls.Add(Me.Lbl_add_to_bill)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.orderdgv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_price)
        Me.Controls.Add(Me.Lbl_price)
        Me.Controls.Add(Me.Amtlbl)
        Me.Controls.Add(Me.Lbl_amt)
        Me.Controls.Add(Me.billdgv)
        Me.Controls.Add(Me.custidcb)
        Me.Controls.Add(Me.prodidcb)
        Me.Controls.Add(Me.Txt_qty)
        Me.Controls.Add(Me.Lbl_qty)
        Me.Controls.Add(Me.custnamecb)
        Me.Controls.Add(Me.prodnamecb)
        Me.Controls.Add(Me.Txt_orderid)
        Me.Controls.Add(Me.Lbl_custname)
        Me.Controls.Add(Me.Lbl_custid)
        Me.Controls.Add(Me.Lbl_prodname)
        Me.Controls.Add(Me.Lbl_prodid)
        Me.Controls.Add(Me.Lbl_orderid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Lbl_close)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Order"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.billdgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.orderdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Lbl_close As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents custidcb As ComboBox
    Friend WithEvents prodidcb As ComboBox
    Friend WithEvents Txt_qty As TextBox
    Friend WithEvents Lbl_qty As Label
    Friend WithEvents custnamecb As ComboBox
    Friend WithEvents prodnamecb As ComboBox
    Friend WithEvents Txt_orderid As TextBox
    Friend WithEvents Lbl_custname As Label
    Friend WithEvents Lbl_custid As Label
    Friend WithEvents Lbl_prodname As Label
    Friend WithEvents Lbl_prodid As Label
    Friend WithEvents Lbl_orderid As Label
    Friend WithEvents billdgv As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Lbl_amt As Label
    Friend WithEvents Amtlbl As Label
    Friend WithEvents Txt_price As TextBox
    Friend WithEvents Lbl_price As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents orderdgv As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Lbl_add_to_bill As Label
    Friend WithEvents Lbl_print As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
End Class
