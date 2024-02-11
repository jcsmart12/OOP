Public Class Form1
    Private Sub Subm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Subm.Click
        Dim age As Integer
        age = Val(num.Text)

        If (age >= 18) Then
            MsgBox("At the age of " & age & " years old. You're eligible to vote.")
        Else
            MsgBox("At the age of " & age & " years old. You're too young to vote.")
        End If
    End Sub

    Private Sub num_KeyPress(sender As Object, e As KeyPressEventArgs) Handles num.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("Invalid Age, accept numbers only.")
        End If
    End Sub

    Private Sub CLS_Click(sender As Object, e As EventArgs) Handles CLS.Click
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
