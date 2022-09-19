Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        Dim total As Decimal

        Decimal.TryParse(TotalTextBox.Text, total)

        Dim tip As Decimal
        Dim tax As Decimal
        Dim grandtotal As Decimal

        If RadioButton1.Checked Then
            tip = total * 0.1
        End If

        If RadioButton2.Checked Then
            tip = total * 0.15
        End If

        If RadioButton3.Checked Then
            tip = total * 0.2
        End If

        tax = total * 1.056
        subtotalLabel.Text = tax.ToString("C2")
        grandtotal = tip + tax
        GrandTotalLabel.Text = grandtotal.ToString("C2")

    End Sub
End Class
