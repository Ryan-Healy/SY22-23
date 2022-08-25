Public Class Form1
    Private Sub Pesos_Click(sender As Object, e As EventArgs) Handles Pesos.Click
        Dim Dollars As Decimal
        Decimal.TryParse(InputTextBox.Text, Dollars)
        Dim Pesos As Decimal
        Pesos = Dollars * 20
        OuputTextBox.Text = Pesos.ToString("n2")
    End Sub
End Class
