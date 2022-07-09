Imports System.Data.SqlClient

Public Class Frm_Order
    Dim Con As New SqlConnection("Data Source=RENU;Initial Catalog=InventoryDB;Persist Security Info=True;User ID=sa;Password=admin123")
    Public Sub populate()
        If (Con.State <> ConnectionState.Open) Then Con.Open()
        Dim sql = "select orderid as 'ID',custid as 'CUSTOMER ID', custname as 'CUSTOMER NAME',price as 'PRICE' from ordertbl "
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        orderdgv.DataSource = ds.Tables(0)
        If (Con.State = ConnectionState.Open) Then Con.Close()
    End Sub
    Private Sub Lbl_close_Click(sender As Object, e As EventArgs) Handles Lbl_close.Click
        Dim result As DialogResult = MessageBox.Show("DO YOU REALLY WANT TO CLOSE", "", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub Fillproductname()
        If (Con.State <> ConnectionState.Open) Then Con.Open()
        Dim sql = "select ProdName from Product_Tbl"
        Dim cmd As New SqlCommand(sql, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        prodnamecb.DataSource = Tbl
        prodnamecb.DisplayMember = "ProdName"
        prodnamecb.ValueMember = "ProdName"
        prodnamecb.SelectedIndex = 0
        If (Con.State = ConnectionState.Open) Then Con.Close()
    End Sub
    Private Sub Fillproductid()
        If (Con.State <> ConnectionState.Open) Then Con.Open()
        Dim sql = "select ProdId from Product_Tbl"
        Dim cmd As New SqlCommand(sql, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        prodidcb.DataSource = Tbl
        prodidcb.DisplayMember = "ProdId"
        prodidcb.ValueMember = "ProdId"
        prodidcb.SelectedIndex = 0
        If (Con.State = ConnectionState.Open) Then Con.Close()
    End Sub
    Private Sub Fillcustid()
        If (Con.State <> ConnectionState.Open) Then Con.Open()
        Dim sql = "select custid from customertbl"
        Dim cmd As New SqlCommand(sql, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        custidcb.DataSource = Tbl
        custidcb.DisplayMember = "custid"
        custidcb.ValueMember = "custid"
        custidcb.SelectedIndex = 0
        If (Con.State = ConnectionState.Open) Then Con.Close()
    End Sub
    Private Sub Fillcustname()
        If (Con.State <> ConnectionState.Open) Then Con.Open()
        Dim sql = "select custname from customertbl"
        Dim cmd As New SqlCommand(sql, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        custnamecb.DataSource = Tbl
        custnamecb.DisplayMember = "custname"
        custnamecb.ValueMember = "custname"
        custnamecb.SelectedIndex = 0
        If (Con.State = ConnectionState.Open) Then Con.Close()
    End Sub

    Private Sub Fetchprodname()
        Try
            If (Con.State <> ConnectionState.Open) Then Con.Open()
            Dim query = "select ProdName from Product_Tbl where ProdId = '" & prodidcb.SelectedValue & "'"
            Dim query1 = "select ProdPrice from Product_Tbl where ProdId = '" & prodidcb.SelectedValue & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            Dim cmd1 As SqlCommand
            cmd1 = New SqlCommand(query1, Con)
            prodnamecb.Text = cmd.ExecuteScalar()
            Txt_price.Text = cmd1.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If (Con.State = ConnectionState.Open) Then Con.Close()
        End Try
    End Sub
    Private Sub prodidcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles prodidcb.SelectionChangeCommitted
        Fetchprodname()
    End Sub

    Private Sub Fetchprodid()
        Try
            If (Con.State <> ConnectionState.Open) Then Con.Open()
            Dim query = "select ProdId from Product_Tbl where ProdName = '" & prodnamecb.SelectedValue & "'"
            Dim query1 = "select ProdPrice from Product_Tbl where ProdName = '" & prodnamecb.SelectedValue & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            Dim cmd1 As SqlCommand
            cmd1 = New SqlCommand(query1, Con)
            prodidcb.Text = cmd.ExecuteScalar()
            Txt_price.Text = cmd1.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If (Con.State = ConnectionState.Open) Then Con.Close()
        End Try
    End Sub
    Private Sub prodnamecb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles prodnamecb.SelectionChangeCommitted
        Fetchprodid()
    End Sub
    Private Sub Fetchcustname()
        Try
            If (Con.State <> ConnectionState.Open) Then Con.Open()
            Dim query = "select custname from customertbl where custid = '" & custidcb.SelectedValue & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            custnamecb.Text = cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If (Con.State = ConnectionState.Open) Then Con.Close()
        End Try
    End Sub
    Private Sub custidcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles custidcb.SelectionChangeCommitted
        Fetchcustname()
    End Sub
    Private Sub Fetchcustid()
        Try
            If (Con.State <> ConnectionState.Open) Then Con.Open()
            Dim query = "select custid from customertbl where custname = '" & custnamecb.SelectedValue & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            custidcb.Text = cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If (Con.State = ConnectionState.Open) Then Con.Close()
        End Try
    End Sub
    Private Sub custnamecb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles custnamecb.SelectionChangeCommitted
        Fetchcustid()
    End Sub
    Private Sub Frm_order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fillproductid()
        Fillproductname()
        Fillcustname()
        Fillcustid()
        auto()
        Fetchprodname()
        Fetchprodid()
        Fetchcustname()
        Fetchcustid()
        populate()
        Txt_qty.Text = ""
        prodidcb.SelectedIndex = -1
        prodnamecb.SelectedIndex = -1
        custnamecb.SelectedIndex = -1
        custidcb.SelectedIndex = -1
        Txt_price.Text = ""
    End Sub
    Public Sub auto()
        If (Con.State <> ConnectionState.Open) Then Con.Open()
        Dim query As String = "select max(orderid)+1 from ordertbl;"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        Txt_orderid.Text = cmd.ExecuteScalar()
        If (Con.State = ConnectionState.Open) Then Con.Close()
    End Sub

    Dim Grtot = 0, i = 0, Total = 0
    Public Sub checkqty()
        If (Con.State <> ConnectionState.Open) Then Con.Open()
        Dim dami As Integer = Txt_qty.Text
        Using mycmd As New SqlCommand("Update Product_Tbl set ProdQty = ProdQty - @dami where ProdId ='" & prodidcb.SelectedValue & "'", Con)
            mycmd.Parameters.Add("@dami", SqlDbType.Int).Value = CInt(Txt_qty.Text)
            mycmd.Parameters.Add("@ProdId", SqlDbType.VarChar).Value = prodidcb.Text
            mycmd.ExecuteNonQuery()
        End Using
        MessageBox.Show("stocks decrease!!")
        If (Con.State = ConnectionState.Open) Then Con.Close()
    End Sub
    Private Sub Lbl_close_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_close.MouseEnter
        Lbl_close.BackColor = System.Drawing.Color.Chocolate
    End Sub

    Private Sub Lbl_close_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_close.MouseLeave
        Lbl_close.BackColor = System.Drawing.Color.Snow
    End Sub
    Private Sub Txt_orderid_Enter(sender As Object, e As EventArgs) Handles Txt_orderid.Enter
        Txt_orderid.BackColor = Color.PeachPuff
        Lbl_orderid.BackColor = Color.BlanchedAlmond
    End Sub
    Private Sub Txt_orderid_Leave(sender As Object, e As EventArgs) Handles Txt_orderid.Leave
        Txt_orderid.BackColor = Color.Snow
        Lbl_orderid.BackColor = Color.Chocolate
    End Sub

    Private Sub prodidcb_Enter(sender As Object, e As EventArgs) Handles prodidcb.Enter
        prodidcb.BackColor = Color.PeachPuff
        Lbl_prodid.BackColor = Color.BlanchedAlmond
    End Sub
    Private Sub prodidcb_Leave(sender As Object, e As EventArgs) Handles prodidcb.Leave
        prodidcb.BackColor = Color.Snow
        Lbl_prodid.BackColor = Color.Chocolate
    End Sub
    Private Sub prodnamecb_Enter(sender As Object, e As EventArgs) Handles prodnamecb.Enter
        prodnamecb.BackColor = Color.PeachPuff
        Lbl_prodname.BackColor = Color.BlanchedAlmond
    End Sub

    Private Sub prodnamecb_Leave(sender As Object, e As EventArgs) Handles prodnamecb.Leave
        prodnamecb.BackColor = Color.Snow
        Lbl_prodname.BackColor = Color.Chocolate
    End Sub

    Private Sub custidcb_Enter(sender As Object, e As EventArgs) Handles custidcb.Enter
        custidcb.BackColor = Color.PeachPuff
        Lbl_custid.BackColor = Color.BlanchedAlmond
    End Sub

    Private Sub custidcb_Leave(sender As Object, e As EventArgs) Handles custidcb.Leave
        custidcb.BackColor = Color.Snow
        Lbl_custid.BackColor = Color.Chocolate
    End Sub

    Private Sub custnamecb_Enter(sender As Object, e As EventArgs) Handles custnamecb.Enter
        custnamecb.BackColor = Color.PeachPuff
        Lbl_custname.BackColor = Color.BlanchedAlmond
    End Sub
    Private Sub custnamecb_Leave(sender As Object, e As EventArgs) Handles custnamecb.Leave
        custnamecb.BackColor = Color.Snow
        Lbl_custname.BackColor = Color.Chocolate
    End Sub
    Public Sub insert()
        If Txt_orderid.Text = "" Or Txt_qty.Text = "" Then
            MessageBox.Show("INCOMPLETE DATA")
        Else
            Try
                If (Con.State <> ConnectionState.Open) Then Con.Open()
                Dim query As String
                query = "insert into ordertbl  values('" & custidcb.SelectedValue & "','" & custnamecb.SelectedValue & "','" & Amtlbl.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                If (Con.State = ConnectionState.Open) Then Con.Close()
                Txt_qty.Text = ""
                prodidcb.SelectedIndex = -1
                prodnamecb.SelectedIndex = -1
                custnamecb.SelectedIndex = -1
                custidcb.SelectedIndex = -1
                Txt_price.Text = ""
                populate()
                auto()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                populate()
            End Try
        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("GALAXY  INVENTORY ",
                              New Font("Times New Roman", 40),
                              Brushes.Chocolate, 150, 40)
        e.Graphics.DrawString(" YOUR ORDER ",
                            New Font("Times New Roman", 40),
                            Brushes.Chocolate, 220, 101)
        Dim bim As New Bitmap(Me.billdgv.Width, Me.billdgv.Height)
        billdgv.DrawToBitmap(bim, New Rectangle(0, 0, Me.billdgv.Width, Me.billdgv.Height))
        e.Graphics.DrawImage(bim, 110, 180)
        insert()
    End Sub


    Private Sub Lbl_print_Click(sender As Object, e As EventArgs) Handles Lbl_print.Click
        If PrintPreviewDialog1 Is Nothing Then
            PrintPreviewDialog1 = New PrintPreviewDialog
        End If
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Show()

    End Sub
    Private Sub Lbl_add_to_bill_Click(sender As Object, e As EventArgs) Handles Lbl_add_to_bill.Click
        If (Con.State <> ConnectionState.Open) Then Con.Open()
        If Txt_qty.Text = "" Then
            MessageBox.Show("ENTER PRODUCT QUANTITY")
        Else
            Dim proqty As Integer
            Dim ordqty As Integer = Convert.ToInt32(Txt_qty.Text)
            If (Con.State <> ConnectionState.Open) Then Con.Open()
            Dim query = "select ProdQty from Product_Tbl where ProdId= '" & prodidcb.Text & " ' "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            proqty = Convert.ToInt32(cmd.ExecuteScalar())
            If proqty < ordqty Then
                MessageBox.Show("EXCEEDING PRODUCT QUANTIITY")
            ElseIf proqty = 0 Then
                MessageBox.Show("OUT OF STOCK")
            Else
                Dim rnum As Integer = billdgv.Rows.Add()
                i = i + 1
                Total = Convert.ToInt32(Txt_price.Text) * Convert.ToInt32(Txt_qty.Text)
                billdgv.Rows.Item(rnum).Cells("column1").Value = Txt_orderid.Text
                billdgv.Rows.Item(rnum).Cells("column2").Value = prodnamecb.Text
                billdgv.Rows.Item(rnum).Cells("column3").Value = Txt_price.Text
                billdgv.Rows.Item(rnum).Cells("column4").Value = Txt_qty.Text
                billdgv.Rows.Item(rnum).Cells("column5").Value = Total
                Grtot = Grtot + Total
                Amtlbl.Text = Grtot
                checkqty()
            End If
        End If
        If (Con.State = ConnectionState.Open) Then Con.Close()
    End Sub
    Private Sub Txt_qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_qty.KeyPress
        If Asc(e.KeyChar) = 8 And Asc(e.KeyChar) = 46 Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("ONLY NUMERIC DIGITS ARE ALLOWED ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Lbl_print_MouseHover(sender As Object, e As EventArgs) Handles Lbl_print.MouseHover
        ToolTip1.SetToolTip(Lbl_print, "PRINT BILL")
        Lbl_print.BackColor = Color.PeachPuff
    End Sub
    Private Sub Lbl_add_to_bill_MouseHover(sender As Object, e As EventArgs) Handles Lbl_add_to_bill.MouseHover
        ToolTip2.SetToolTip(Lbl_add_to_bill, "ADD TO BILL")
        Lbl_add_to_bill.BackColor = Color.PeachPuff
    End Sub
    Private Sub Txt_qty_Enter(sender As Object, e As EventArgs) Handles Txt_qty.Enter
        Txt_qty.BackColor = Color.PeachPuff
        Lbl_qty.BackColor = Color.BlanchedAlmond
    End Sub
    Private Sub Txt_qty_Leave(sender As Object, e As EventArgs) Handles Txt_qty.Leave
        Txt_qty.BackColor = Color.Snow
        Lbl_qty.BackColor = Color.Chocolate
    End Sub
End Class