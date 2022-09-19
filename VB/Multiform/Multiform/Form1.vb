Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim N As Integer
        Dim D As Decimal
        Dim S As Single
        Integer.TryParse(ATextBox.Text, N)
        Decimal.TryParse(BTextBox.Text, D)
        Single.TryParse(CTextBox.Text, S)
        Label1.Text = N
        Label2.Text = D
        Label3.Text = S
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.ShowDialog()
        Label3.Text = EmoRock
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class
