Imports System.Data.SqlClient
Public Class Frm_registration
    Dim Con As New SqlConnection("Data Source=RENU;Initial Catalog=InventoryDB;Persist Security Info=True;User ID=sa;Password=admin123")
    Private Sub Lbl_regis_now_Click(sender As Object, e As EventArgs) Handles Lbl_regis_now.Click
        If Txt_uname.Text = "" Or Txt_upass.Text = "" Or Txt_upass1.Text = "" Then
            MessageBox.Show("INCOMPLETE DATA")
        ElseIf Txt_upass.Text = Txt_upass1.Text Then
            If (Con.State <> ConnectionState.Open) Then Con.Open()
            Dim query As String
            query = "select * from usertbl where username='" & Txt_uname.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader()
            If (dr.Read()) Then
                dr.Close()
                MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                dr.Close()
                Dim query1 As String
                query1 = " insert into usertbl values ('" & Txt_uname.Text & "','" & Txt_upass.Text & "','" & CB_type.Text & "')"
                Dim cmd1 As New SqlCommand(query1, Con)
                cmd1.ExecuteNonQuery()
                MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If (Con.State = ConnectionState.Open) Then Con.Close()
            End If
        Else
            MessageBox.Show("PASSWORD AND CONFRIM PASSWORD SHOULD BE SAME")
        End If
    End Sub

    Private Sub Lbl_createnow_Click(sender As Object, e As EventArgs) Handles Lbl_createnow.Click
        Dim Login = New Frm_login()
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Txt_uname_Enter(sender As Object, e As EventArgs) Handles Txt_uname.Enter
        Txt_uname.BackColor = Color.PeachPuff
        Lbl_uname.BackColor = Color.BlanchedAlmond
    End Sub

    Private Sub Txt_upass_Enter(sender As Object, e As EventArgs) Handles Txt_upass.Enter
        Txt_upass.BackColor = Color.PeachPuff
        Lbl_pass1.BackColor = Color.BlanchedAlmond
    End Sub

    Private Sub Txt_upass1_Enter(sender As Object, e As EventArgs) Handles Txt_upass1.Enter
        Txt_upass1.BackColor = Color.PeachPuff
        Lbl_pass2.BackColor = Color.BlanchedAlmond
    End Sub

    Private Sub Txt_uname_Leave(sender As Object, e As EventArgs) Handles Txt_uname.Leave
        Txt_uname.BackColor = Color.Snow
        Lbl_uname.BackColor = Color.Chocolate
    End Sub

    Private Sub Txt_upass_Leave(sender As Object, e As EventArgs) Handles Txt_upass.Leave
        Txt_upass.BackColor = Color.Snow
        Lbl_pass1.BackColor = Color.Chocolate
    End Sub

    Private Sub Txt_upass1_Leave(sender As Object, e As EventArgs) Handles Txt_upass1.Leave
        Txt_upass1.BackColor = Color.Snow
        Lbl_pass2.BackColor = Color.Chocolate
    End Sub
    Private Sub CB_type_Enter(sender As Object, e As EventArgs) Handles CB_type.Enter
        CB_type.BackColor = Color.PeachPuff
        Lbl_type.BackColor = Color.BlanchedAlmond

    End Sub
    Private Sub CB_type_Leave(sender As Object, e As EventArgs) Handles CB_type.Leave
        CB_type.BackColor = Color.Snow
        Lbl_type.BackColor = Color.Chocolate

    End Sub

    Private Sub Lbl_regis_now_MouseHover(sender As Object, e As EventArgs) Handles Lbl_regis_now.MouseHover
        Lbl_regis_now.BackColor = Color.PeachPuff
        Lbl_regis_now.ForeColor = Color.Chocolate
    End Sub
    Private Sub Lbl_regis_now_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_regis_now.MouseLeave
        Lbl_regis_now.BackColor = Color.Chocolate
        Lbl_regis_now.ForeColor = Color.Black
    End Sub

    Private Sub Lbl_createnow_MouseHover(sender As Object, e As EventArgs) Handles Lbl_createnow.MouseHover
        Lbl_createnow.BackColor = Color.PeachPuff
        Lbl_createnow.ForeColor = Color.Chocolate
    End Sub
    Private Sub Lbl_createnow_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_createnow.MouseLeave
        Lbl_createnow.BackColor = Color.Chocolate
        Lbl_createnow.ForeColor = Color.Black
    End Sub

    Private Sub CB_eye_CheckedChanged(sender As Object, e As EventArgs) Handles CB_eye.CheckedChanged
        If CB_eye.Checked = True Then
            Txt_upass.PasswordChar = ""
            Txt_upass1.PasswordChar = ""
            CB_eye.Image = Image.FromFile("C:\Users\renuka\OneDrive\Desktop\Galaxy Inventory Management\Galaxy Inventory Management\Images\show.png")
        Else
            Txt_upass.PasswordChar = "*"
            Txt_upass1.PasswordChar = "*"
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