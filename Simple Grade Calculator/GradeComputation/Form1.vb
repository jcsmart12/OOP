Public Class Form1
    Dim sum As Single

    Private Sub CALC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CALC.Click
        sum = ((PRELIM.Text * 0.3) + (MIDTERM.Text * 0.3) + (FINALS.Text * 0.4))
        TOTAL.Text = sum.ToString("0.00")
        If Val(TOTAL.Text) >= 98 Then
            TRANSM.Text = "1.0"
            REMARKS.Text = "PASSED"
        ElseIf Val(TOTAL.Text) >= 95 Then
            TRANSM.Text = "1.25"
            REMARKS.Text = "PASSED"
        ElseIf Val(TOTAL.Text) >= 92 Then
            TRANSM.Text = "1.50"
            REMARKS.Text = "PASSED"
        ElseIf Val(TOTAL.Text) >= 89 Then
            TRANSM.Text = "1.75"
            REMARKS.Text = "PASSED"
        ElseIf Val(TOTAL.Text) >= 86 Then
            TRANSM.Text = "2.00"
            REMARKS.Text = "PASSED"
        ElseIf Val(TOTAL.Text) >= 83 Then
            TRANSM.Text = "2.25"
            REMARKS.Text = "PASSED"
        ElseIf Val(TOTAL.Text) >= 80 Then
            TRANSM.Text = "2.50"
            REMARKS.Text = "PASSED"
        ElseIf Val(TOTAL.Text) >= 77 Then
            TRANSM.Text = "2.75"
            REMARKS.Text = "PASSED"
        ElseIf Val(TOTAL.Text) >= 75 Then
            TRANSM.Text = "3.00"
            REMARKS.Text = "PASSED"
        Else
            TRANSM.Text = "5.00"
            REMARKS.Text = "FAILED"
        End If
    End Sub

    Private Sub CLEAR_Click(sender As Object, e As EventArgs) Handles CLEAR.Click
        For Each Control As Control In Me.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = String.Empty
            End If
        Next
    End Sub

    Private Sub EXT_Click(sender As Object, e As EventArgs) Handles EXT.Click
        Me.Close()
    End Sub
End Class
