Public Class Form1
    Private Sub Pesos_Click(sender As Object, e As EventArgs) Handles Pesos.Click
        Dim Dollars As Decimal
        Decimal.TryParse(InputTextBox.Text, Dollars)
        Dim Pesos As Decimal
        Pesos = Dollars * 20
        OuputTextBox.Text = Pesos.ToString("n2")
    End Sub

    Private Sub Bahamas_Click(sender As Object, e As EventArgs) Handles Bahamas.Click
        Dim Dollars As Decimal
        Decimal.TryParse(InputTextBox.Text, Dollars)
        Dim Bahama As Decimal
        Bahama = Dollars * 1
        OuputTextBox.Text = Bahama.ToString("n2")
    End Sub

    Private Sub Euro_Click(sender As Object, e As EventArgs) Handles Euro.Click
        Dim Dollars As Decimal
        Decimal.TryParse(InputTextBox.Text, Dollars)
        Dim Euro As Decimal
        Euro = Dollars * 1
        OuputTextBox.Text = Euro.ToString("n2")
    End Sub

    Private Sub CAD_Click(sender As Object, e As EventArgs) Handles CAD.Click
        Dim Dollars As Decimal
        Decimal.TryParse(InputTextBox.Text, Dollars)
        Dim CAD As Decimal
        CAD = Dollars * 1.29
        OuputTextBox.Text = CAD.ToString("n2")
    End Sub

    Private Sub Rupee_Click(sender As Object, e As EventArgs) Handles Rupee.Click
        Dim Dollars As Decimal
        Decimal.TryParse(InputTextBox.Text, Dollars)
        Dim Rupee As Decimal
        Rupee = Dollars * 79.89
        OuputTextBox.Text = Rupee.ToString("n2")
    End Sub

    Private Sub Yen_Click(sender As Object, e As EventArgs) Handles Yen.Click
        Dim Dollars As Decimal
        Decimal.TryParse(InputTextBox.Text, Dollars)
        Dim Yen As Decimal
        Yen = Dollars * 136.72
        OuputTextBox.Text = Yen.ToString("n2")
    End Sub
End Class
