Public Class Form1

    Private Sub RedBtn_Click(sender As Object, e As EventArgs) Handles RedBtn.Click
        RedBtn.BackColor = Color.Red
    End Sub

    Private Sub BlueBtn_Click(sender As Object, e As EventArgs) Handles BlueBtn.Click
        BlueBtn.BackColor = Color.Blue
    End Sub

    Private Sub GreenBtn_Click(sender As Object, e As EventArgs) Handles GreenBtn.Click
        GreenBtn.BackColor = Color.Green
    End Sub

    Private Sub YellowBtn_Click(sender As Object, e As EventArgs) Handles YellowBtn.Click
        YellowBtn.BackColor = Color.Yellow
    End Sub

    Private Sub BrownBtn_Click(sender As Object, e As EventArgs) Handles BrownBtn.Click
        BrownBtn.BackColor = Color.Brown
    End Sub

    Private Sub PinkBtn_Click(sender As Object, e As EventArgs) Handles PinkBtn.Click
        PinkBtn.BackColor = Color.Pink
    End Sub

    Private Sub PurpleBtn_Click(sender As Object, e As EventArgs) Handles PurpleBtn.Click
        PurpleBtn.BackColor = Color.Purple
    End Sub

    Private Sub GrayBtn_Click(sender As Object, e As EventArgs) Handles GrayBtn.Click
        GrayBtn.BackColor = Color.Gray
    End Sub

    Private Sub OrangeBtn_Click(sender As Object, e As EventArgs) Handles OrangeBtn.Click
        OrangeBtn.BackColor = Color.Orange
    End Sub

    Private Sub StartOver_Click(sender As Object, e As EventArgs) Handles StartOver.Click
        RedBtn.BackColor = Color.FromKnownColor(KnownColor.Control)
        BlueBtn.BackColor = Color.FromKnownColor(KnownColor.Control)
        GreenBtn.BackColor = Color.FromKnownColor(KnownColor.Control)
        YellowBtn.BackColor = Color.FromKnownColor(KnownColor.Control)
        BrownBtn.BackColor = Color.FromKnownColor(KnownColor.Control)
        PinkBtn.BackColor = Color.FromKnownColor(KnownColor.Control)
        PurpleBtn.BackColor = Color.FromKnownColor(KnownColor.Control)
        GrayBtn.BackColor = Color.FromKnownColor(KnownColor.Control)
        OrangeBtn.BackColor = Color.FromKnownColor(KnownColor.Control)
    End Sub

    Private Sub Print_Click(sender As Object, e As EventArgs) Handles Print.Click
        PrintForm.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm.Print()
    End Sub

    Private Sub Fnt_Click(sender As Object, e As EventArgs) Handles Fnt.Click
        FontDialog.Font = RedBtn.Font
        FontDialog.Font = BlueBtn.Font
        FontDialog.Font = GreenBtn.Font
        FontDialog.Font = YellowBtn.Font
        FontDialog.Font = BrownBtn.Font
        FontDialog.Font = PinkBtn.Font
        FontDialog.Font = PurpleBtn.Font
        FontDialog.Font = GrayBtn.Font
        FontDialog.Font = OrangeBtn.Font
        FontDialog.ShowDialog()
        RedBtn.Font = FontDialog.Font
        BlueBtn.Font = FontDialog.Font
        GreenBtn.Font = FontDialog.Font
        YellowBtn.Font = FontDialog.Font
        BrownBtn.Font = FontDialog.Font
        PinkBtn.Font = FontDialog.Font
        PurpleBtn.Font = FontDialog.Font
        GrayBtn.Font = FontDialog.Font
        OrangeBtn.Font = FontDialog.Font
    End Sub

    Private Sub Ext_Click(sender As Object, e As EventArgs) Handles Ext.Click
        Me.Close()
    End Sub

End Class
