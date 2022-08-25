Public Class Form1
    Private Sub Purchasebutton_Click(sender As Object, e As EventArgs) Handles Purchasebutton.Click
        Dim Amount As Decimal
        Decimal.TryParse(AmountTextBox.Text, Amount)
        NameTextBox.Clear()
        CCTextBox.Clear()
        expTextBox.Clear()
        ZipTextBox.Clear()
        AmountTextBox.Clear()
        Dim Fee as Decimal
        Fee = Amount * 0.03
        FeeTextBox.Text = Fee.ToString("C2")
    End Sub

    Private Sub Cancelbutton_Click(sender As Object, e As EventArgs) Handles Cancelbutton.Click
        Me.Close()
    End Sub
End Class
