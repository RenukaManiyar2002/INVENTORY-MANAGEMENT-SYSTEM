Imports System.Data.SqlClient
Public Class MDIParent1
    Private Sub FileMenu_Click(sender As Object, e As EventArgs)
        Dim open As New Frm_Product()
        'open.MdiParent = Me
        open.ShowDialog()
        open.Top = 0
        open.Left = 0

    End Sub

    Public Sub MDIBGColor()
        Dim ctl As Control
        Dim ctlMDI As MdiClient
        ' Loop through all of the form's controls looking
        ' for the control of type MdiClient.
        For Each ctl In Me.Controls
            Try
                ' Attempt to cast the control to type MdiClient.
                ctlMDI = CType(ctl, MdiClient)
                ' Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = Me.BackColor
            Catch exc As InvalidCastException
                ' Catch and ignore the error if casting failed.
            End Try
        Next

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

    Public Sub customer()
        Dim con As New SqlConnection("Data Source=RENU;Initial Catalog=InventoryDB;Persist Security Info=True;User ID=sa;Password=admin123")
        con.Open()
        Dim query As String = "select count(custid) from customertbl;"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        Lbl_customer.Text = "Customer" & Environment.NewLine & cmd.ExecuteScalar()
        con.Close()
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
    Public Sub user()
        Dim con As New SqlConnection("Data Source=RENU;Initial Catalog=InventoryDB;Persist Security Info=True;User ID=sa;Password=admin123")
        con.Open()
        Dim query As String = "select count(ID) from usertbl;"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        Lbl_user.Text = "User" & Environment.NewLine & cmd.ExecuteScalar()
        con.Close()
    End Sub
    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.BackColor = Color.FromArgb(96, 54, 1)
        MDIBGColor()
        Timer1.Start()
    End Sub
    Private Function marqueeText(ByVal data As String)
        Dim s1 As String = data.Remove(0, 1)
        Dim s2 As String = data(0)
        Return s1 & s2
    End Function
    Private Sub Menu_Click(sender As Object, e As EventArgs) Handles Menu.Click
        Dim open As New Frm_Menu()
        open.ShowDialog()
        open.Top = 0
        open.Left = 0
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        Dim open As New Frm_Customer_Mng()
        open.ShowDialog()
        open.Top = 0
        open.Left = 0
    End Sub


    Private Sub Lbl_close_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_close.MouseEnter
        Lbl_close.BackColor = Color.FromArgb(204, 149, 68)
        Lbl_close.ForeColor = Color.FromArgb(96, 54, 1)
    End Sub
    Private Sub Lbl_close_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_close.MouseLeave
        Lbl_close.BackColor = Color.FromArgb(255, 251, 233)
        Lbl_close.ForeColor = Color.FromArgb(135, 67, 86)
    End Sub

    Private Sub Lbl_close_Click(sender As Object, e As EventArgs) Handles Lbl_close.Click
        Dim result As DialogResult = MessageBox.Show("DO YOU REALLY WANT TO CLOSE THIS APPLICATION", "", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Dim open As New Frm_Users()
        open.ShowDialog()
        open.Top = 0
        open.Left = 0
    End Sub
    Private Sub ToolStripMenuItem2_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim open As New Frm_Customer_Mng()
        open.ShowDialog()
        open.Top = 0
        open.Left = 0
    End Sub
    Private Sub ToolStripMenuItem3_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim open As New Frm_Product_Mng()
        open.ShowDialog()
        open.Top = 0
        open.Left = 0
    End Sub
    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Dim open As New Frm_Order_Mng()
        open.ShowDialog()
        open.Top = 0
        open.Left = 0
    End Sub
    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        Dim open As New Frm_about()
        open.ShowDialog()
        open.Top = 0
        open.Left = 0
    End Sub



    Private Sub ToolStripMenuItem8_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        Dim open As New Frm_help()
        open.ShowDialog()
        open.Top = 0
        open.Left = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = marqueeText(Label2.Text)
    End Sub


End Class
