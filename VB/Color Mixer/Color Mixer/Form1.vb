Public Class Form1
    Dim inputred As Integer
    Dim inputgreen As Integer
    Dim inputblue As Integer
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ViewcolorButton_Click(sender As Object, e As EventArgs) Handles ViewcolorButton.Click
        Integer.TryParse(RedTextBox.Text, inputred)
        Integer.TryParse(GreenTextBox.Text, inputgreen)
        Integer.TryParse(BlueTextBox.Text, inputblue)
        ColorButton.BackColor = Color.FromArgb(inputred, inputgreen, inputblue)
    End Sub
End Class
