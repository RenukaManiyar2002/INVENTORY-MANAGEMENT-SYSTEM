Imports System.Threading

Public Class Frm_Loadingpg
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Me.Timer1.Stop()
            Dim open As New Frm_login()
            Me.Hide()
            open.Show()
        Else
            ProgressBar1.Value = ProgressBar1.Value + 1
            Label2.Text = ProgressBar1.Value & "%"
        End If
        If ProgressBar1.Value = 10 Then Lbl_txt.Text = "Turning on Modules....."
        Thread.Sleep(10)
        If ProgressBar1.Value = 20 Then Lbl_txt.Text = "Loading Modules....."
        Thread.Sleep(10)
        If ProgressBar1.Value = 30 Then Lbl_txt.Text = "Connectiong to Database....."
        Thread.Sleep(10)
        If ProgressBar1.Value = 50 Then Lbl_txt.Text = "Successfully Connected....."
        Thread.Sleep(10)
        If ProgressBar1.Value = 70 Then Lbl_txt.Text = "Launching Application....."


        If ProgressBar1.Value = 20 Then BackgroundImage = Image.FromFile("C:\Users\renuka\OneDrive\Desktop\Galaxy Inventory Management\Galaxy Inventory Management\Images\pic20.jpg")
        If ProgressBar1.Value = 40 Then BackgroundImage = Image.FromFile("C:\Users\renuka\OneDrive\Desktop\Galaxy Inventory Management\Galaxy Inventory Management\Images\pic40.jpg")
        If ProgressBar1.Value = 60 Then BackgroundImage = Image.FromFile("C:\Users\renuka\OneDrive\Desktop\Galaxy Inventory Management\Galaxy Inventory Management\Images\pic50.png")
        If ProgressBar1.Value = 80 Then BackgroundImage = Image.FromFile("C:\Users\renuka\OneDrive\Desktop\Galaxy Inventory Management\Galaxy Inventory Management\Images\inventory-3428087-2930640.png")

    End Sub
    Private Sub Frm_Loadingpg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
