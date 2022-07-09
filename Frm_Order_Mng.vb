Imports System.Data.SqlClient

Public Class Frm_Order_Mng
    Dim Con As New SqlConnection("Data Source=RENU;Initial Catalog=InventoryDB;Persist Security Info=True;User ID=sa;Password=admin123")
    Public Sub populate()
        Con.Open()
        Dim sql = "select orderid as 'ID',custid as 'CUSTOMER ID', custname as 'CUSTOMER NAME',price as 'PRICE' from ordertbl "
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        orderdgv.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Public Sub order()
        Dim con As New SqlConnection("Data Source=RENU;Initial Catalog=InventoryDB;Persist Security Info=True;User ID=sa;Password=admin123")
        con.Open()
        Dim query As String = "select count(orderid) from ordertbl;"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        Lbl_order.Text = "Order" & Environment.NewLine & cmd.ExecuteScalar()
        con.Close()
    End Sub
    Private Sub Frm_Order_Mng_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        order()
    End Sub
    Private Sub Lbl_icon_MouseHover(sender As Object, e As EventArgs) Handles Lbl_icon.MouseHover
        TT_order.SetToolTip(Lbl_icon, "PRODUCT")
    End Sub
    Private Sub Lbl_icon_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_icon.MouseEnter
        Lbl_icon.BackColor = Color.PeachPuff
    End Sub
    Private Sub Lbl_icon_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_icon.MouseLeave
        Lbl_icon.BackColor = Color.Chocolate
    End Sub

    Private Sub Lbl_icon_Click(sender As Object, e As EventArgs) Handles Lbl_icon.Click
        Dim open = New Frm_Order()
        open.Show()
    End Sub

    Private Sub Label_close_Click(sender As Object, e As EventArgs) Handles Label_close.Click
        Dim open = New Frm_login()
        open.Show()
        Me.Hide()
    End Sub
    Private Sub Label_close_MouseEnter(sender As Object, e As EventArgs) Handles Label_close.MouseEnter
        Label_close.BackColor = System.Drawing.Color.Chocolate
    End Sub

    Private Sub Label_close_MouseLeave(sender As Object, e As EventArgs) Handles Label_close.MouseLeave
        Label_close.BackColor = System.Drawing.Color.Snow
    End Sub

End Class