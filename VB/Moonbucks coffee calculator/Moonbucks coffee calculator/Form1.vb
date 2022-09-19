Public Class Form1
    Dim Decaf As Decimal
    Dim Regular As Decimal
    Private Sub Calculateorder_Click(sender As Object, e As EventArgs) Handles Calculateorder.Click
        Decimal.TryParse(DecafTextBox.Text, Decaf)
        Decimal.TryParse(RegularTextBox.Text, Regular)
        PoundsorderTextBox.Text = Regular + Decaf
        TotalTextBox.Text = ((Regular + Decaf) * 4.99).ToString("C2")

    End Sub

    Private Sub Clearorder_Click(sender As Object, e As EventArgs) Handles Clearorder.Click
        TotalTextBox.Clear()
        PoundsorderTextBox.Clear()
        DecafTextBox.Clear()
        RegularTextBox.Clear()
    End Sub

    Private Sub Exitorder_Click(sender As Object, e As EventArgs) Handles Exitorder.Click
        Me.Close()
    End Sub
End Class
