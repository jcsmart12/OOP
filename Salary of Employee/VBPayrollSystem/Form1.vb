Public Class Form1
    Dim s As Integer
    Dim pg As Integer
    Dim phil As Integer
    Dim tax As Single
    Dim deduc As Single
    Dim gp As Single
    Dim net As Single

    Private Sub CALC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CALC.Click
        gp = (RATE.Text * DAYS.Text)
        GROSSPAY.Text = gp.ToString("0.00")

        s = 390
        SSS.Text = s

        pg = 200
        PAGIBIG.Text = pg

        phil = 350
        PHILHEALTH.Text = phil

        tax = gp * 0.1
        TAXS.Text = tax

        deduc = (s + pg + phil + tax)
        DEDUCS.Text = deduc.ToString("0.00")

        net = (GROSSPAY.Text - DEDUCS.Text)
        NETPAY.Text = net.ToString("0.00")

    End Sub

    Private Sub EXT_Click(sender As Object, e As EventArgs) Handles EXT.Click
        Me.Close()
    End Sub

    Private Sub CLS_Click(sender As Object, e As EventArgs) Handles CLS.Click
        For Each Control As Control In Me.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = String.Empty
            End If
        Next
    End Sub
End Class
