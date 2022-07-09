Public Class Frm_Menu
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


    Private Sub Lbl_Product_Click(sender As Object, e As EventArgs) Handles Lbl_Product.Click
        Dim open As New Frm_Product()
        open.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Lbl_Category_Click(sender As Object, e As EventArgs) Handles Lbl_Category.Click
        Dim open As New Frm_Category()
        open.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Lbl_Customer_Click(sender As Object, e As EventArgs) Handles Lbl_Customer.Click
        Dim open As New Frm_Customer()
        open.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Lbl_Order_Click(sender As Object, e As EventArgs) Handles Lbl_Order.Click
        Using open As New Frm_Order()
            open.ShowDialog()
            Me.Close()
        End Using
    End Sub
    Private Sub Lbl_Product_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_Product.MouseEnter
        Lbl_Product.BackColor = Color.PeachPuff
    End Sub
    Private Sub Lbl_Product_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_Product.MouseLeave
        Lbl_Product.BackColor = Color.Chocolate
    End Sub
    Private Sub Lbl_Category_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_Category.MouseEnter
        Lbl_Category.BackColor = Color.PeachPuff
    End Sub
    Private Sub Lbl_Category_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_Category.MouseLeave
        Lbl_Category.BackColor = Color.Chocolate
    End Sub

    Private Sub Lbl_Customer_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_Customer.MouseEnter
        Lbl_Customer.BackColor = Color.PeachPuff
    End Sub
    Private Sub Lbl_Customer_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_Customer.MouseLeave
        Lbl_Customer.BackColor = Color.Chocolate
    End Sub
    Private Sub Lbl_Order_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_Order.MouseEnter
        Lbl_Order.BackColor = Color.PeachPuff
    End Sub
    Private Sub Lbl_Order_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_Order.MouseLeave
        Lbl_Order.BackColor = Color.Chocolate
    End Sub

    Private Sub Lbl_Product_MouseHover(sender As Object, e As EventArgs) Handles Lbl_Product.MouseHover
        TT_Product.SetToolTip(Lbl_Product, "PRODUCT")
    End Sub
    Private Sub Lbl_Category_MouseHover(sender As Object, e As EventArgs) Handles Lbl_Category.MouseHover
        TT_Category.SetToolTip(Lbl_Category, "CATEGORY")
    End Sub
    Private Sub Lbl_Customer_MouseHover(sender As Object, e As EventArgs) Handles Lbl_Customer.MouseHover
        TT_Customer.SetToolTip(Lbl_Customer, "CUSTOMER")
    End Sub
    Private Sub Lbl_Order_MouseHover(sender As Object, e As EventArgs) Handles Lbl_Order.MouseHover
        TT_Order.SetToolTip(Lbl_Order, "ORDER")
    End Sub

    Private Sub Frm_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TT_Product_Popup(sender As Object, e As PopupEventArgs) Handles TT_Product.Popup

    End Sub
End Class