Imports System.Data.SqlClient

Public Class Frm_Product
    Dim con As New SqlConnection("Data Source=RENU;Initial Catalog=InventoryDB;Persist Security Info=True;User ID=sa;Password=admin123")
    Public Sub auto()
        con.Open()
        Dim query As String = "select max(ProdId)+1 from Product_Tbl;"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        Lbl_AUTOID.Text = cmd.ExecuteScalar()
        con.Close()
    End Sub

    Public Sub populate()
        If (con.State <> ConnectionState.Open) Then con.Open()
        Dim sql = "select ProdId as 'ID',ProdName as 'NAME', ProdQty as 'QUANTITY',ProdPrice as 'PRICE',ProdDesc as 'DESCRIPTION',ProdCat as 'CATEGORY'  from Product_Tbl "
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        productdgv.DataSource = ds.Tables(0)
        If (con.State = ConnectionState.Open) Then con.Close()
    End Sub

    Private Sub Fillcategory()
        If (con.State <> ConnectionState.Open) Then con.Open()
        Dim sql = "select * from categorytbl"
        Dim cmd As New SqlCommand(sql, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        Cbox_category.DataSource = Tbl
        Cbox_category.DisplayMember = "catname"
        Cbox_category.ValueMember = "catname"
        If (con.State = ConnectionState.Open) Then con.Close()
    End Sub

    Private Sub PB_add_MouseHover(sender As Object, e As EventArgs) Handles PB_add.MouseHover
        TT_addbtn.SetToolTip(PB_add, "ADD BUTTON")
        PB_add.BackColor = Color.PeachPuff
    End Sub
    Private Sub PB_add_MouseLeave(sender As Object, e As EventArgs) Handles PB_add.MouseLeave
        PB_add.BackColor = Color.Chocolate
    End Sub

    Private Sub PB_update_MouseHover(sender As Object, e As EventArgs) Handles PB_update.MouseHover
        TT_updatebtn.SetToolTip(PB_update, "UPDATE BUTTON")
        PB_update.BackColor = Color.PeachPuff
    End Sub
    Private Sub PB_update_MouseLeave(sender As Object, e As EventArgs) Handles PB_update.MouseLeave
        PB_update.BackColor = Color.Chocolate
    End Sub
    Private Sub PB_delete_MouseHover(sender As Object, e As EventArgs) Handles PB_delete.MouseHover
        TT_deletebtn.SetToolTip(PB_delete, "DELETE BUTTON")
        PB_delete.BackColor = Color.PeachPuff
    End Sub
    Private Sub PB_delete_MouseLeave(sender As Object, e As EventArgs) Handles PB_delete.MouseLeave
        PB_delete.BackColor = Color.Chocolate
    End Sub
    Private Sub PB_clear_MouseHover(sender As Object, e As EventArgs) Handles PB_clear.MouseHover
        TT_clearbtn.SetToolTip(PB_clear, "CLEAR BUTTON")
        PB_clear.BackColor = Color.PeachPuff
    End Sub
    Private Sub PB_clear_MouseLeave(sender As Object, e As EventArgs) Handles PB_clear.MouseLeave
        PB_clear.BackColor = Color.Chocolate
    End Sub

    Private Sub PB_add_Click(sender As Object, e As EventArgs) Handles PB_add.Click
        If Txt_proName.Text = "" Or Txt_qty.Text = "" Or Txt_price.Text = "" Or Cbox_category.Text = "" Then
            MessageBox.Show("INCOMPLETE DATA")
        Else
            Dim name As String
            Dim prodname As String
            prodname = Txt_proName.Text
            If (con.State <> ConnectionState.Open) Then con.Open()
            Dim query = "select ProdName from Product_Tbl where ProdName= '" & Txt_proName.Text & " ' "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            name = cmd.ExecuteScalar()
            If name = prodname Then
                MessageBox.Show("THIS PRODUCT ALREADY EXISTS IN YOUR INVENTORY")
            Else
                Try
                    If (con.State <> ConnectionState.Open) Then con.Open()
                    Dim query1 As String
                    query1 = "insert into Product_Tbl  values('" & Lbl_AUTOID.Text & "','" & Txt_proName.Text & "','" & Txt_qty.Text & "','" & Txt_price.Text & "','" & Txt_desc.Text & "','" & Cbox_category.SelectedValue & "' )"
                    Dim cmd1 As SqlCommand
                    cmd1 = New SqlCommand(query1, con)
                    cmd1.ExecuteNonQuery()
                    If (con.State = ConnectionState.Open) Then con.Close()
                    clear()
                    populate()
                    auto()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    populate()
                End Try
            End If
        End If
    End Sub

    Private Sub Frm_Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        Fillcategory()
        auto()
    End Sub

    Private Sub PB_delete_Click(sender As Object, e As EventArgs) Handles PB_delete.Click
        Dim id As String
        Dim txtid As String
        txtid = Lbl_AUTOID.Text
        If (con.State <> ConnectionState.Open) Then con.Open()
        Dim query1 = "select ProdId from Product_Tbl where ProdId= '" & Lbl_AUTOID.Text & " ' "
        Dim cmd1 As SqlCommand
        cmd1 = New SqlCommand(query1, con)
        id = cmd1.ExecuteScalar()
        If id = 0 Then
            MessageBox.Show("THIS PRODUCT-ID DOESN'T EXISTS")
        ElseIf Lbl_AUTOID.Text = "" Then
            MessageBox.Show("ENTER PRODUCT-ID TO DELETE")
        Else
            If (con.State <> ConnectionState.Open) Then con.Open()
            Dim query As String
            query = "delete from Product_Tbl where ProdId= '" & Lbl_AUTOID.Text & "' "
            Dim result As DialogResult = MessageBox.Show("DO YOU REALLY WANT TO DELETE THE DATA", "", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                If (con.State = ConnectionState.Open) Then con.Close()
                populate()
                clear()
                auto()
            End If
        End If
    End Sub
    Public Sub clear()
        Txt_proName.Text = ""
        Txt_qty.Text = ""
        Txt_price.Text = ""
        Txt_desc.Text = ""
        Cbox_category.Text = ""
    End Sub
    Private Sub PB_clear_Click(sender As Object, e As EventArgs) Handles PB_clear.Click
        clear()
    End Sub

    Private Sub PB_update_Click(sender As Object, e As EventArgs) Handles PB_update.Click
        If Lbl_AUTOID.Text = "" Then
            MessageBox.Show("ENTER PRODUCT-ID TO UPDATE")
        ElseIf Txt_proName.Text = "" Or Txt_qty.Text = "" Or Txt_price.Text = "" Or Cbox_category.Text = "" Then
            MessageBox.Show("ENTER DATA TO UPDATE")
        Else
            If (con.State <> ConnectionState.Open) Then con.Open()
            Dim sql = "update Product_Tbl set ProdName='" & Txt_proName.Text & "', ProdQty= " & Txt_qty.Text & ",ProdPrice= '" & Txt_price.Text & "', ProdDesc= '" & Txt_desc.Text & "',ProdCat= '" & Cbox_category.SelectedValue & "' where prodid = " & Lbl_AUTOID.Text & " "
            Dim result As DialogResult = MessageBox.Show("DO YOU REALLY WANT TO UPDATE THE DATA", "", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                Dim cmd As New SqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                If (con.State = ConnectionState.Open) Then con.Close()
                clear()
                populate()
                auto()
            End If
        End If
    End Sub
    Private Sub Lbl_close_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_close.MouseEnter
        Lbl_close.BackColor = System.Drawing.Color.Chocolate
    End Sub

    Private Sub Lbl_close_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_close.MouseLeave
        Lbl_close.BackColor = System.Drawing.Color.Snow
    End Sub
    Private Sub Lbl_close_Click(sender As Object, e As EventArgs) Handles Lbl_close.Click
        Dim result As DialogResult = MessageBox.Show("DO YOU REALLY WANT TO CLOSE", "", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Lbl_ID_Click(sender As Object, e As EventArgs) Handles Lbl_ID.Click
        Dim result As DialogResult = MessageBox.Show("DO YOU WANT TO EDIT THE DATA?", "", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Lbl_AUTOID.Enabled = True
            PB_delete.Enabled = True
            PB_update.Enabled = True
            PB_add.Enabled = False
        Else
            Lbl_AUTOID.Enabled = False
            PB_delete.Enabled = False
            PB_update.Enabled = False
            PB_add.Enabled = True
        End If
    End Sub

    Private Sub Lbl_AUTOID_Enter(sender As Object, e As EventArgs) Handles Lbl_AUTOID.Enter
        Lbl_AUTOID.BackColor = Color.PeachPuff
        Lbl_ID.BackColor = Color.BlanchedAlmond
        Lbl_ID.ForeColor = Color.Chocolate
    End Sub
    Private Sub Lbl_AUTOID_Leave(sender As Object, e As EventArgs) Handles Lbl_AUTOID.Leave
        Lbl_AUTOID.BackColor = Color.Snow
        Lbl_ID.BackColor = Color.Chocolate
        Lbl_ID.ForeColor = Color.Snow
    End Sub

    Private Sub Txt_proName_Enter(sender As Object, e As EventArgs) Handles Txt_proName.Enter
        Txt_proName.BackColor = Color.PeachPuff
        Lbl_proname.BackColor = Color.BlanchedAlmond
        Lbl_proname.ForeColor = Color.Chocolate
    End Sub
    Private Sub Txt_proName_Leave(sender As Object, e As EventArgs) Handles Txt_proName.Leave
        Txt_proName.BackColor = Color.Snow
        Lbl_proname.BackColor = Color.Chocolate
        Lbl_proname.ForeColor = Color.Snow
    End Sub

    Private Sub Txt_qty_Enter(sender As Object, e As EventArgs) Handles Txt_qty.Enter
        Txt_qty.BackColor = Color.PeachPuff
        Lbl_qty.BackColor = Color.BlanchedAlmond
        Lbl_qty.ForeColor = Color.Chocolate
    End Sub
    Private Sub Txt_qty_Leave(sender As Object, e As EventArgs) Handles Txt_qty.Leave
        Txt_qty.BackColor = Color.Snow
        Lbl_qty.BackColor = Color.Chocolate
        Lbl_qty.ForeColor = Color.Snow
    End Sub

    Private Sub Txt_price_Enter(sender As Object, e As EventArgs) Handles Txt_price.Enter
        Txt_price.BackColor = Color.PeachPuff
        Lbl_price.BackColor = Color.BlanchedAlmond
        Lbl_price.ForeColor = Color.Chocolate
    End Sub
    Private Sub Txt_price_Leave(sender As Object, e As EventArgs) Handles Txt_price.Leave
        Txt_price.BackColor = Color.Snow
        Lbl_price.BackColor = Color.Chocolate
        Lbl_price.ForeColor = Color.Snow
    End Sub
    Private Sub Txt_desc_Enter(sender As Object, e As EventArgs) Handles Txt_desc.Enter
        Txt_desc.BackColor = Color.PeachPuff
        Lbl_desc.BackColor = Color.BlanchedAlmond
        Lbl_desc.ForeColor = Color.Chocolate
    End Sub
    Private Sub Txt_desc_Leave(sender As Object, e As EventArgs) Handles Txt_desc.Leave
        Txt_desc.BackColor = Color.Snow
        Lbl_desc.BackColor = Color.Chocolate
        Lbl_desc.ForeColor = Color.Snow
    End Sub

    Private Sub Cbox_category_Enter(sender As Object, e As EventArgs) Handles Cbox_category.Enter
        Cbox_category.BackColor = Color.PeachPuff
        Lbl_cat.BackColor = Color.BlanchedAlmond
        Lbl_cat.ForeColor = Color.Chocolate
    End Sub
    Private Sub Cbox_category_Leave(sender As Object, e As EventArgs) Handles Cbox_category.Leave
        Cbox_category.BackColor = Color.Snow
        Lbl_cat.BackColor = Color.Chocolate
        Lbl_cat.ForeColor = Color.Snow
    End Sub

    Private Sub Txt_qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_qty.KeyPress
        If Asc(e.KeyChar) = 8 And Asc(e.KeyChar) = 46 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("ONLY NUMERIC DIGITS ARE ALLOWED ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Txt_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_price.KeyPress
        If Asc(e.KeyChar) = 8 And Asc(e.KeyChar) = 46 Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("ONLY NUMERIC DIGITS ARE ALLOWED ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class

