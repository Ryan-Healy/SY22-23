Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Age As Integer
        Integer.TryParse(TextBox1.Text, Age)
        Label1.Text = Age
        If Age > 17 Then
            Label1.Text = "You Can Vote"
            Me.BackColor = Color.Green
        Else
            Label1.Text = "You Can't Vote"
            Me.BackColor = Color.Red
        End If
        If CheckBox1.Checked Then
            Label1.Text = "Thanks For Donating"
        Else
            Label1.Text = ""
        End If
    End Sub
End Class
