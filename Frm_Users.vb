Imports System.Data.SqlClient

Public Class Frm_Users
    Dim Con As New SqlConnection("Data Source=RENU;Initial Catalog=InventoryDB;Persist Security Info=True;User ID=sa;Password=admin123")

    Public Sub populate()
        If (Con.State <> ConnectionState.Open) Then Con.Open()
        Dim sql = "select username as 'USERNAME',password as 'PASSWORD',type as 'TYPE' from usertbl "
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        userdgv.DataSource = ds.Tables(0)
        If (Con.State = ConnectionState.Open) Then Con.Close()
    End Sub
    Private Sub PB_add_Click(sender As Object, e As EventArgs) Handles PB_add.Click
        If uname.Text = "" Or upass.Text = "" Then
            MessageBox.Show("INCOMPLETE DATA")
        Else
            If (Con.State <> ConnectionState.Open) Then Con.Open()
            Dim name As String
            Dim user As String
            user = uname.Text
            Dim query1 = "select username from usertbl where username= '" & uname.Text & " ' "
            Dim cmd1 As SqlCommand
            cmd1 = New SqlCommand(query1, Con)
            name = cmd1.ExecuteScalar()
            If name = user Then
                MessageBox.Show("USER ALREADY EXISTS")
            Else
                Try
                    Dim query As String
                    query = "insert into usertbl values('" & uname.Text & "','" & upass.Text & "','" & CB_type.Text & "')"
                    Dim cmd As SqlCommand
                    cmd = New SqlCommand(query, Con)
                    cmd.ExecuteNonQuery()
                    If (Con.State = ConnectionState.Open) Then Con.Close()
                    populate()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    populate()
                    uname.Text = ""
                    upass.Text = ""
                    CB_type.SelectedIndex = -1
                End Try
            End If
        End If
    End Sub

    Private Sub PB_update_Click(sender As Object, e As EventArgs) Handles PB_update.Click
        If uname.Text = "" Or upass.Text = "" Then
            MessageBox.Show("ENTER DATA TO UPDATE")
        Else
            If (Con.State <> ConnectionState.Open) Then Con.Open()
            'update usertbl set type= 'ORDER MANAGEMENT', password= 123 where username = 'Raj'
            Dim sql = "update usertbl set type= '" & CB_type.Text & "', password= '" & upass.Text & "' where username='" & uname.Text & "' "
            'Dim sql = "update usertbl set password='" & upass.Text & "', type ='" & (CB_type.SelectedValue) & "' where username='" & uname.Text & "' "
            Dim cmd As New SqlCommand(sql, Con)
            Dim result As DialogResult = MessageBox.Show("DO YOU REALLY WANT TO UPDATE THE DATA", "", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                cmd.ExecuteNonQuery()
                If (Con.State = ConnectionState.Open) Then Con.Close()
                populate()
                uname.Text = ""
                upass.Text = ""
                CB_type.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub PB_delete_Click(sender As Object, e As EventArgs) Handles PB_delete.Click
        If uname.Text = "" Then
            MessageBox.Show("ENTER DATA TO DELETE")
        Else
            If (Con.State <> ConnectionState.Open) Then Con.Open()
            Dim query As String
            query = "delete from usertbl where username='" & uname.Text & "' "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            Dim result As DialogResult = MessageBox.Show("DO YOU REALLY WANT TO DELETE THE DATA", "", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                cmd.ExecuteNonQuery()
                populate()
                If (Con.State = ConnectionState.Open) Then Con.Close()
                uname.Text = ""
                upass.Text = ""
                CB_type.SelectedIndex = -1
            End If
        End If

    End Sub

    Private Sub PB_clear_Click(sender As Object, e As EventArgs) Handles PB_clear.Click
        uname.Text = ""
        upass.Text = ""
        CB_type.SelectedIndex = -1
    End Sub
    Private Sub Frm_Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub
    Private Sub Lbl_close_Click(sender As Object, e As EventArgs) Handles Lbl_close.Click
        Dim result As DialogResult = MessageBox.Show("DO YOU REALLY WANT TO CLOSE", "", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Lbl_close_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_close.MouseEnter
        Lbl_close.BackColor = System.Drawing.Color.Chocolate
    End Sub
    Private Sub Lbl_close_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_close.MouseLeave
        Lbl_close.BackColor = System.Drawing.Color.Snow
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
    Private Sub CB_eye_CheckedChanged(sender As Object, e As EventArgs) Handles CB_eye.CheckedChanged
        If CB_eye.Checked = True Then
            upass.PasswordChar = ""
            CB_eye.Image = Image.FromFile("C:\Users\renuka\OneDrive\Desktop\Galaxy Inventory Management\Galaxy Inventory Management\Images\show.png")
        Else
            upass.PasswordChar = "*"
            CB_eye.Image = Image.FromFile("C:\Users\renuka\OneDrive\Desktop\Galaxy Inventory Management\Galaxy Inventory Management\Images\hide.png")
        End If
    End Sub
    Private Sub upass_Enter(sender As Object, e As EventArgs) Handles upass.Enter
        upass.BackColor = Color.PeachPuff
        Lbl_pass.BackColor = Color.BlanchedAlmond
        Lbl_pass.ForeColor = Color.Chocolate
    End Sub

    Private Sub upass_Leave(sender As Object, e As EventArgs) Handles upass.Leave
        upass.BackColor = Color.Snow
        Lbl_pass.BackColor = Color.Chocolate
        Lbl_pass.ForeColor = Color.Snow
    End Sub
    Private Sub CB_type_Enter(sender As Object, e As EventArgs) Handles CB_type.Enter
        CB_type.BackColor = Color.PeachPuff
        Lbl_type.BackColor = Color.BlanchedAlmond
        Lbl_type.ForeColor = Color.Chocolate
    End Sub

    Private Sub CB_type_Leave(sender As Object, e As EventArgs) Handles CB_type.Leave
        CB_type.BackColor = Color.Snow
        Lbl_type.BackColor = Color.Chocolate
        Lbl_type.ForeColor = Color.Snow
    End Sub

    Private Sub uname_Enter(sender As Object, e As EventArgs) Handles uname.Enter
        uname.BackColor = Color.PeachPuff
        Lbl_uname.BackColor = Color.BlanchedAlmond
        Lbl_uname.ForeColor = Color.Chocolate
    End Sub

    Private Sub uname_Leave(sender As Object, e As EventArgs) Handles uname.Leave
        uname.BackColor = Color.Snow
        Lbl_uname.BackColor = Color.Chocolate
        Lbl_uname.ForeColor = Color.Snow
    End Sub
End Class