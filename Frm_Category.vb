Imports System.Data.SqlClient

Public Class Frm_Category
    Dim con As New SqlConnection("Data Source=RENU;Initial Catalog=InventoryDB;Persist Security Info=True;User ID=sa;Password=admin123")
    Dim cmd As New SqlCommand

    Public Sub populate()
        If (con.State <> ConnectionState.Open) Then con.Open()
        Dim sql = "select catid as 'CATEGORY ID', catname as 'CATEGORY NAME' from categorytbl "
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

    Public Sub auto()
        If (con.State <> ConnectionState.Open) Then con.Open()
        Dim query As String = "select max(catid)+1 from categorytbl;"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        catid.Text = cmd.ExecuteScalar()
        If (con.State = ConnectionState.Open) Then con.Close()
    End Sub

    Private Sub PB_add_Click(sender As Object, e As EventArgs) Handles PB_add.Click
        If catid.Text = "" Or catname.Text = "" Then
            MessageBox.Show("INCOMPLETE DATA")
        Else
            Dim name As String
            Dim cat As String
            cat = catname.Text
            If (con.State <> ConnectionState.Open) Then con.Open()
            Dim query = "select catname from categorytbl where catname= '" & catname.Text & " ' "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            name = cmd.ExecuteScalar()
            If name = cat Then
                MessageBox.Show("THIS CATEGORY ALREADY EXISTS IN YOUR INVENTORY")
            Else
                Try
                    If (con.State <> ConnectionState.Open) Then con.Open()
                    cmd.Connection = con
                    cmd = New SqlCommand("insert into categorytbl (catname)values ('" & catname.Text & "')", con)
                    cmd.ExecuteNonQuery()
                    catname.Text = ""
                    populate()
                    auto()
                    If (con.State = ConnectionState.Open) Then con.Close()
                Catch ex As Exception
                    MessageBox.Show("Invalid" & ex.Message)
                Finally
                    populate()
                End Try
            End If
        End If
    End Sub

    Private Sub PB_update_Click(sender As Object, e As EventArgs) Handles PB_update.Click
        If catid.Text = "" Or catname.Text = "" Then
            MessageBox.Show("ENTER DATA TO UPDATE")
        Else
            If (con.State <> ConnectionState.Open) Then con.Open()
            Dim sql = "update categorytbl set catname='" & catname.Text & "'where catid=" & catid.Text & "  "
                Dim cmd As New SqlCommand(sql, con)
                Dim result As DialogResult = MessageBox.Show("DO YOU REALLY WANT TO UPDATE THE DATA", "", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                cmd.ExecuteNonQuery()
                If (con.State = ConnectionState.Open) Then con.Close()
                catname.Text = ""
                populate()
                auto()
            End If
        End If
    End Sub

    Private Sub PB_delete_Click(sender As Object, e As EventArgs) Handles PB_delete.Click

        Dim id As String
        If (con.State <> ConnectionState.Open) Then con.Open()
        Dim query1 = "select catid from categorytbl where catid= '" & catid.Text & " ' "
        Dim cmd1 As SqlCommand
        cmd1 = New SqlCommand(query1, con)
        id = cmd1.ExecuteScalar()
        If id = 0 Then
            MessageBox.Show("THIS CATEGORY-ID DOESN'T EXISTS")
        ElseIf catid.Text = "" Then
        MessageBox.Show("ENTER ID TO DELETE DATA")
        Else
            Dim name As String
            Dim cat As String
            cat = catname.Text
            If (con.State <> ConnectionState.Open) Then con.Open()
            Dim query2 = "select catname from categorytbl where catname= '" & catname.Text & " ' "
            Dim cmd2 As SqlCommand
            cmd2 = New SqlCommand(query2, con)
            name = cmd2.ExecuteScalar()
            If name <> cat Then
                MessageBox.Show("THIS CATEGORY DOESN'T EXISTS")
            Else
                If (con.State <> ConnectionState.Open) Then con.Open()
                Dim query As String
                query = "delete from categorytbl where catid= " & catid.Text & " "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                Dim result As DialogResult = MessageBox.Show("DO YOU REALLY WANT TO DELETE THE DATA", "", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Yes Then
                    cmd.ExecuteNonQuery()
                    If (con.State = ConnectionState.Open) Then con.Close()
                    catname.Text = ""
                    populate()
                    auto()
                End If
            End If
        End If
    End Sub

    Private Sub PB_clear_Click(sender As Object, e As EventArgs) Handles PB_clear.Click
        catname.Text = ""
    End Sub


    Private Sub Frm_category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        auto()
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

    Private Sub Lbl_catid_Click(sender As Object, e As EventArgs) Handles Lbl_catid.Click
        Dim result As DialogResult = MessageBox.Show("DO YOU WANT TO EDIT THE DATA?", "", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            catid.Enabled = True
            PB_delete.Enabled = True
            PB_update.Enabled = True
            PB_add.Enabled = False
        Else
            catid.Enabled = False
            PB_delete.Enabled = False
            PB_update.Enabled = False
            PB_add.Enabled = True
        End If
    End Sub

    Private Sub catid_Enter(sender As Object, e As EventArgs) Handles catid.Enter
        catid.BackColor = Color.PeachPuff
        Lbl_catid.BackColor = Color.BlanchedAlmond
        Lbl_catid.ForeColor = Color.Chocolate
    End Sub

    Private Sub catid_Leave(sender As Object, e As EventArgs) Handles catid.Leave
        catid.BackColor = Color.Snow
        Lbl_catid.BackColor = Color.Chocolate
        Lbl_catid.ForeColor = Color.Snow
    End Sub

    Private Sub catname_Enter(sender As Object, e As EventArgs) Handles catname.Enter
        catname.BackColor = Color.PeachPuff
        Lbl_catname.BackColor = Color.BlanchedAlmond
        Lbl_catname.ForeColor = Color.Chocolate
    End Sub

    Private Sub catname_Leave(sender As Object, e As EventArgs) Handles catname.Leave
        catname.BackColor = Color.Snow
        Lbl_catname.BackColor = Color.Chocolate
        Lbl_catname.ForeColor = Color.Snow
    End Sub

End Class