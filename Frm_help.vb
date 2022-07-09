Public Class Frm_help
    Private Sub Lbl_close_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_close.MouseLeave
        Lbl_close.BackColor = Color.FromArgb(129, 103, 151)
        Lbl_close.ForeColor = Color.FromArgb(27, 36, 48)
    End Sub
    Private Sub Lbl_close_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_close.MouseEnter
        Lbl_close.BackColor = Color.FromArgb(71, 181, 255)
        Lbl_close.ForeColor = Color.FromArgb(6, 40, 61)
    End Sub

    Private Sub Lbl_close_Click(sender As Object, e As EventArgs) Handles Lbl_close.Click
        Me.Close()
    End Sub
End Class