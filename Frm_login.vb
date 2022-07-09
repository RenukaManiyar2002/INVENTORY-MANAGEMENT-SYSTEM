Imports System.Data.SqlClient
Public Class Frm_login
    Dim Con As New SqlConnection("Data Source=RENU;Initial Catalog=InventoryDB;Persist Security Info=True;User ID=sa;Password=admin123")
    Private Sub Lbl_login_Click(sender As Object, e As EventArgs) Handles Lbl_login.Click
        If Txt_upass.Text = " " Or Txt_uname.Text = " " Then
            MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (Con.State <> ConnectionState.Open) Then Con.Open()
            Dim query As String
            query = "select * from usertbl where username='" & Txt_uname.Text & "' and password='" & Txt_upass.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            Dim query1 As String
            Dim type As String
            Dim txttype As String
            txttype = CB_type.Text
            query1 = "select type from usertbl where username='" & Txt_uname.Text & "'"
            Dim cmd1 As SqlCommand
            cmd1 = New SqlCommand(query1, Con)
            type = cmd1.ExecuteScalar()
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader()
            If (dr.Read()) Then
                dr.Close()
                If type <> txttype Then
                    MessageBox.Show("INVALID TYPE")
                Else
                    If type = "ADMIN" Then
                        Me.Hide()
                        Dim open = New MDIParent1()
                        open.Show()
                        If (Con.State = ConnectionState.Open) Then Con.Close()
                    ElseIf type = "PRODUCT DEPARTMENT" Then
                        Me.Hide()
                        Dim open = New Frm_Product_Mng()
                        open.Show()
                        If (Con.State = ConnectionState.Open) Then Con.Close()
                    ElseIf type = "CUSTOMER DEPARTMENT" Then
                        Me.Hide()
                        Dim open = New Frm_Customer_Mng()
                        open.Show()
                        If (Con.State = ConnectionState.Open) Then Con.Close()
                    ElseIf type = "ORDER DEPARTMENT" Then
                        Me.Hide()
                        Dim open = New Frm_Order_Mng()
                        open.Show()
                        If (Con.State = ConnectionState.Open) Then Con.Close()
                    End If
                End If
            Else
                dr.Close()
                MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Private Sub Lbl_createnow_Click(sender As Object, e As EventArgs) Handles Lbl_createnow.Click
        Dim open = New Frm_registration()
        open.Show()
        Me.Hide()

    End Sub

    Private Sub Txt_uname_Enter(sender As Object, e As EventArgs) Handles Txt_uname.Enter
        Txt_uname.BackColor = Color.PeachPuff
        Lbl_uname.BackColor = Color.BlanchedAlmond
    End Sub

    Private Sub Txt_upass_Enter(sender As Object, e As EventArgs) Handles Txt_upass.Enter
        Txt_upass.BackColor = Color.PeachPuff
        Lbl_pass.BackColor = Color.BlanchedAlmond
    End Sub

    Private Sub Txt_uname_Leave(sender As Object, e As EventArgs) Handles Txt_uname.Leave
        Txt_uname.BackColor = Color.Snow
        Lbl_uname.BackColor = Color.Chocolate
    End Sub

    Private Sub Txt_upass_Leave(sender As Object, e As EventArgs) Handles Txt_upass.Leave
        Txt_upass.BackColor = Color.Snow
        Lbl_pass.BackColor = Color.Chocolate
    End Sub

    Private Sub Lbl_login_MouseHover(sender As Object, e As EventArgs) Handles Lbl_login.MouseHover
        Lbl_login.BackColor = Color.PeachPuff
        Lbl_login.ForeColor = Color.Chocolate
    End Sub
    Private Sub Lbl_login_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_login.MouseLeave
        Lbl_login.BackColor = Color.Chocolate
        Lbl_login.ForeColor = Color.Black
    End Sub

    Private Sub Lbl_createnow_MouseHover(sender As Object, e As EventArgs) Handles Lbl_createnow.MouseHover
        Lbl_createnow.BackColor = Color.PeachPuff
        Lbl_createnow.ForeColor = Color.Chocolate
    End Sub
    Private Sub Lbl_createnow_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_createnow.MouseLeave
        Lbl_createnow.BackColor = Color.Chocolate
        Lbl_createnow.ForeColor = Color.Black
    End Sub
    Private Sub Frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub CB_eye_CheckedChanged(sender As Object, e As EventArgs) Handles CB_eye.CheckedChanged
        If CB_eye.Checked = True Then
            Txt_upass.PasswordChar = ""
            CB_eye.Image = Image.FromFile("C:\Users\renuka\OneDrive\Desktop\Galaxy Inventory Management\Galaxy Inventory Management\Images\show.png")
        Else
            Txt_upass.PasswordChar = "*"
            CB_eye.Image = Image.FromFile("C:\Users\renuka\OneDrive\Desktop\Galaxy Inventory Management\Galaxy Inventory Management\Images\hide.png")
        End If
    End Sub

    Private Sub Lbl_close_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_close.MouseEnter
        Lbl_close.BackColor = System.Drawing.Color.Snow
    End Sub

    Private Sub Lbl_close_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_close.MouseLeave
        Lbl_close.BackColor = System.Drawing.Color.Chocolate
    End Sub
    Private Sub Lbl_close_Click(sender As Object, e As EventArgs) Handles Lbl_close.Click
        Dim result As DialogResult = MessageBox.Show("DO YOU REALLY WANT TO CLOSE", "", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


End Class