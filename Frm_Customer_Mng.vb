Imports System.Data.SqlClient

Public Class Frm_Customer_Mng
    Public Sub populate()
        Dim con As New SqlConnection("Data Source=RENU;Initial Catalog=InventoryDB;Persist Security Info=True;User ID=sa;Password=admin123")
        con.Open()
        Dim sql = "select custid as ID, custname as NAME, custphone as PHONE from customertbl "
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        catdgv.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub Lbl_Customer_MouseHover(sender As Object, e As EventArgs) Handles Lbl_Customer.MouseHover
        TT_Customer.SetToolTip(Lbl_Customer, "CUSTOMER")
    End Sub
    Public Sub customer()
        Dim con As New SqlConnection("Data Source=RENU;Initial Catalog=InventoryDB;Persist Security Info=True;User ID=sa;Password=admin123")
        con.Open()
        Dim query As String = "select count(custid) from customertbl;"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        Lbl_cust.Text = "Customer" & Environment.NewLine & cmd.ExecuteScalar()
        con.Close()
    End Sub
    Private Sub Frm_Customer_Mng_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customer()
        populate()
    End Sub

    Private Sub Lbl_Customer_Click(sender As Object, e As EventArgs) Handles Lbl_Customer.Click
        Dim open = New Frm_Customer()
        open.Show()
    End Sub
    Private Sub Lbl_Customer_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_Customer.MouseEnter
        Lbl_Customer.BackColor = Color.PeachPuff
    End Sub
    Private Sub Lbl_Customer_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_Customer.MouseLeave
        Lbl_Customer.BackColor = Color.Chocolate
    End Sub

    Private Sub Lbl_close_Click(sender As Object, e As EventArgs) Handles Lbl_close.Click
        Dim open = New Frm_login()
        open.Show()
        Me.Hide()
    End Sub
    Private Sub Lbl_close_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_close.MouseEnter
        Lbl_close.BackColor = System.Drawing.Color.Chocolate
    End Sub

    Private Sub Lbl_close_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_close.MouseLeave
        Lbl_close.BackColor = System.Drawing.Color.Snow
    End Sub

End Class