Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = Image.FromFile("D:\DESKTOP - DATA DRIVE\HORSE.jpg")
        Label1.Text = "ABBY"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = Image.FromFile("D:\DESKTOP - DATA DRIVE\HORSE2.jpg")
        Label1.Text = "RASCAL"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
