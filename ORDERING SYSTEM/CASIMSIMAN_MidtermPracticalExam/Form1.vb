Public Class Form1
    Dim item As Double
    Dim vat As Double
    Dim subtotal As Double
    Dim discount As Double
    Dim total As Double

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim itemName As String = " "

        If MCRb1.Checked = True Then
            item = 518.0
            itemName = "Motor Cycle Cover - Php 518.00"
        ElseIf FRRb2.Checked = True Then
            item = 31.0
            itemName = "Flasher Relay - Php 31.00"
        ElseIf HGRb3.Checked = True Then
            item = 290.0
            itemName = "Handle Grip - Php 290.00"
        ElseIf SARb4.Checked = True Then
            item = 1500.0
            itemName = "Shock Absorber - Php 1500.00"
        ElseIf TTRb5.Checked = True Then
            item = 800.0
            itemName = "Tricycle Tire - Php 800.00"
        ElseIf SWRb6.Checked = True Then
            item = 1695.0
            itemName = "Sidewheels - Php 1695.00"
        ElseIf PSRb7.Checked = True Then
            item = 1763.0
            itemName = "Piston Set - Php 1763.00"
        ElseIf MORb8.Checked = True Then
            item = 315.0
            itemName = "Motorcycle Oil - Php 315.00"
        ElseIf OTRb9.Checked = True Then
            item = 100.0
            itemName = "Oil Treatment - Php 100.00"
        ElseIf OPRb10.Checked = True Then
            item = 240.0
            itemName = "Oil Pump - Php 240.00"
        End If

        subtotal = subtotal + item
        vat = subtotal * 0.12

        If FiveDsc.Checked = True Then
            discount = (subtotal + vat) * 0.05
            total = (subtotal + vat) - discount
        Else
            total = subtotal + vat
        End If

        SubTotalLbl.Text = subtotal.ToString("0.00")
        VatLbl.Text = vat.ToString("0.00")
        DscLbl.Text = discount.ToString("0.00")
        TotalLbl.Text = total.ToString("0.00")
        OrderTxt.Text = OrderTxt.Text & itemName & ControlChars.NewLine

    End Sub

    Private Sub ClrBtn_Click(sender As Object, e As EventArgs) Handles ClrBtn.Click
        subtotal = 0
        vat = 0
        discount = 0
        total = 0

        SubTotalLbl.Text = ("0.00")
        VatLbl.Text = ("0.00")
        DscLbl.Text = ("0.00")
        TotalLbl.Text = ("0.00")

        OrderTxt.Clear()
    End Sub

End Class
