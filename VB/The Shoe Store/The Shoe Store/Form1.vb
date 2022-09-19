Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.ShowDialog()
        TextBoxchips.Text = Chips
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.ShowDialog()
        TextBoxdrinks.Text = Soda
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form4.ShowDialog()
        TextBoxgum.Text = Gum
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form5.ShowDialog()
        TextBoxtoys.Text = Toys
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form6.ShowDialog()
        TextBoxfood.Text = Food
    End Sub

    Private Sub GetValues_Click(sender As Object, e As EventArgs) Handles Grandtotal.Click
        Dim grandtotal As Decimal = Chips * 1 + Soda * 1 + Gum * 1 + Toys * 1 + Food * 1
        Grandtotallabel.Text = Grandtotal.ToString("C2")
    End Sub
End Class
