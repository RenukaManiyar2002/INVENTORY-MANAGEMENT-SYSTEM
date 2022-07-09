Imports System.Data.SqlClient

Public Class Frm_Product_Mng
    Private Sub Frm_Product_Mng_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        product()
        category()
    End Sub
    Private Sub Lbl_icon_MouseHover(sender As Object, e As EventArgs) Handles Lbl_icon.MouseHover
        TT_Customer.SetToolTip(Lbl_icon, "PRODUCT")
    End Sub
    Private Sub Lbl_icon_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_icon.MouseEnter
        Lbl_icon.BackColor = Color.PeachPuff
    End Sub
    Private Sub Lbl_icon_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_icon.MouseLeave
        Lbl_icon.BackColor = Color.Chocolate
    End Sub
    Public Sub product()
        Dim con As New SqlConnection("Data Source=RENU;Initial Catalog=InventoryDB;Persist Security Info=True;User ID=sa;Password=admin123")
        con.Open()
        Dim query As String = "select count(ProdId) from Product_Tbl;"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        Lbl_product.Text = "Product" & Environment.NewLine & cmd.ExecuteScalar()
        con.Close()
    End Sub

    Public Sub category()
        Dim con As New SqlConnection("Data Source=RENU;Initial Catalog=InventoryDB;Persist Security Info=True;User ID=sa;Password=admin123")
        con.Open()
        Dim query As String = "select count(catid) from categorytbl;"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        Lbl_category.Text = "Caterory" & Environment.NewLine & cmd.ExecuteScalar()
        con.Close()
    End Sub

    Private Sub Lbl_icon_Click(sender As Object, e As EventArgs) Handles Lbl_icon.Click
        Dim open = New Frm_Product()
        open.Show()
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