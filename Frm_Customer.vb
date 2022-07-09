Imports System.Data.SqlClient

Public Class Frm_Customer
    Dim con As New SqlConnection("Data Source=RENU;Initial Catalog=InventoryDB;Persist Security Info=True;User ID=sa;Password=admin123")
    Public Sub auto()
        If (con.State <> ConnectionState.Open) Then con.Open()
        Dim query As String = "select max(custid)+1 from customertbl;"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        custid.Text = cmd.ExecuteScalar()
        If (con.State = ConnectionState.Open) Then con.Close()
    End Sub
    Public Sub populate()
        If (con.State <> ConnectionState.Open) Then con.Open()
        Dim sql = "select custid as ID, custname as NAME, custphone as PHONE from customertbl "
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        catdgv.DataSource = ds.Tables(0)
        If (con.State = ConnectionState.Open) Then con.Close()
    End Sub


    Private Sub PB_add_Click(sender As Object, e As EventArgs) Handles PB_add.Click
        If custid.Text = "" Or custname.Text = "" Or custphone.Text = "" Then
            MessageBox.Show("INCOMPLETE DATA")
        Else
            Try
                If (con.State <> ConnectionState.Open) Then con.Open()
                Dim query As String
                query = "insert into  customertbl values('" & custname.Text & "', '" & custphone.Text & "' )"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                If (con.State = ConnectionState.Open) Then con.Close()
                custname.Text = ""
                custphone.Text = ""
                populate()
                auto()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                populate()
            End Try
        End If
    End Sub

    Private Sub PB_update_Click(sender As Object, e As EventArgs) Handles PB_update.Click
        If custid.Text = "" Or custname.Text = "" Or custphone.Text = "" Then
            MessageBox.Show("ENTER DATA TO UPDATE")
        Else
            If (con.State <> ConnectionState.Open) Then con.Open()
            Dim sql = "update customertbl set custname='" & custname.Text & "',custphone= '" & custphone.Text & "' where custid=" & custid.Text & "  "
            Dim cmd As New SqlCommand(sql, con)
            Dim result As DialogResult = MessageBox.Show("DO YOU REALLY WANT TO UPDATE THE DATA", "", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                cmd.ExecuteNonQuery()
                If (con.State = ConnectionState.Open) Then con.Close()
                custname.Text = ""
                custphone.Text = ""
                populate()
                auto()
            End If
        End If
    End Sub

    Private Sub PB_delete_Click(sender As Object, e As EventArgs) Handles PB_delete.Click
        Dim id As String
        If (con.State <> ConnectionState.Open) Then con.Open()
        Dim query1 = "select custid from customertbl where custid= '" & custid.Text & " ' "
        Dim cmd1 As SqlCommand
        cmd1 = New SqlCommand(query1, con)
        id = cmd1.ExecuteScalar()
        If id = 0 Then
            MessageBox.Show("THIS CUSTOMER-ID DOESN'T EXISTS")
        ElseIf custid.Text = "" Then
        MessageBox.Show("ENTER DATA TO DELETE")
        Else
            If (con.State <> ConnectionState.Open) Then con.Open()
            Dim query As String
            query = "delete from customertbl where custid= " & custid.Text & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            Dim result As DialogResult = MessageBox.Show("DO YOU REALLY WANT TO DELETE THE DATA", "", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                cmd.ExecuteNonQuery()
                If (con.State = ConnectionState.Open) Then con.Close()
                custname.Text = ""
                custphone.Text = ""
                populate()
                auto()
            End If
        End If
    End Sub

    Private Sub PB_clear_Click(sender As Object, e As EventArgs) Handles PB_clear.Click
        custname.Text = ""
        custphone.Text = ""
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
    Private Sub custid_Enter(sender As Object, e As EventArgs) Handles custid.Enter
        custid.BackColor = Color.PeachPuff
        Lbl_ID.BackColor = Color.BlanchedAlmond
        Lbl_ID.ForeColor = Color.Chocolate
    End Sub

    Private Sub custname_Enter(sender As Object, e As EventArgs) Handles custname.Enter
        custname.BackColor = Color.PeachPuff
        Lbl_Name.BackColor = Color.BlanchedAlmond
        Lbl_Name.ForeColor = Color.Chocolate
    End Sub

    Private Sub custphone_Enter(sender As Object, e As EventArgs) Handles custphone.Enter
        custphone.BackColor = Color.PeachPuff
        Lbl_phno.BackColor = Color.BlanchedAlmond
        Lbl_phno.ForeColor = Color.Chocolate
    End Sub

    Private Sub custid_Leave(sender As Object, e As EventArgs) Handles custid.Leave
        custid.BackColor = Color.Snow
        Lbl_ID.BackColor = Color.Chocolate
        Lbl_ID.ForeColor = Color.Snow
    End Sub

    Private Sub custname_Leave(sender As Object, e As EventArgs) Handles custname.Leave
        custname.BackColor = Color.Snow
        Lbl_Name.BackColor = Color.Chocolate
        Lbl_Name.ForeColor = Color.Snow
    End Sub

    Private Sub custphone_Leave(sender As Object, e As EventArgs) Handles custphone.Leave
        custphone.BackColor = Color.Snow
        Lbl_phno.BackColor = Color.Chocolate
        Lbl_phno.ForeColor = Color.Snow
        If custphone.Text.Length <> 10 Then
            MessageBox.Show("PHONE NUMBER MORE THAN 10 DIGITS")
        End If
    End Sub


    Private Sub Frm_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        auto()
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
            custid.Enabled = True
            PB_delete.Enabled = True
            PB_update.Enabled = True
            PB_add.Enabled = False
        Else
            custid.Enabled = False
            PB_delete.Enabled = False
            PB_update.Enabled = False
            PB_add.Enabled = True
        End If
    End Sub

    Private Sub custphone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles custphone.KeyPress
        If Asc(e.KeyChar) = 8 And Asc(e.KeyChar) = 46 Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("ONLY NUMERIC DIGITS ARE ALLOWED ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


End Class