Public Class Form1
    Dim num1 As Decimal
    Dim num2 As Decimal
    Dim oper As String
    Dim Mem As Decimal
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles MyBase.Click, B9.Click, B8.Click, B7.Click, B6.Click, B5.Click, B4.Click, B3.Click, B2.Click, B1.Click, B0.Click, Bdot.Click
        DisplayTextBox.Text = DisplayTextBox.Text + sender.text
    End Sub

    Private Sub Bclear_Click(sender As Object, e As EventArgs) Handles Bclear.Click
        DisplayTextBox.Clear()
    End Sub

    Private Sub Bplus_Click(sender As Object, e As EventArgs) Handles Bplus.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        oper = "+"
        DisplayTextBox.Clear()
    End Sub

    Private Sub Bequal_Click(sender As Object, e As EventArgs) Handles Bequal.Click
        Decimal.TryParse(DisplayTextBox.Text, num2)
        If oper = "+" Then
            DisplayTextBox.Text = num1 + num2
        End If
        If oper = "-" Then
            DisplayTextBox.Text = num1 - num2
        End If
        If oper = "x" Then
            DisplayTextBox.Text = num1 * num2
        End If
        If oper = "/" Then
            DisplayTextBox.Text = num1 / num2
        End If
    End Sub

    Private Sub Bsubtract_Click(sender As Object, e As EventArgs) Handles Bsubtract.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        oper = "-"
        DisplayTextBox.Clear()
    End Sub

    Private Sub Btimes_Click(sender As Object, e As EventArgs) Handles Btimes.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        oper = "x"
        DisplayTextBox.Clear()
    End Sub

    Private Sub Bdivide_Click(sender As Object, e As EventArgs) Handles Bdivide.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        oper = "/"
        DisplayTextBox.Clear()
    End Sub

    Private Sub RootButton_Click(sender As Object, e As EventArgs) Handles RootButton.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        DisplayTextBox.Text = Math.Sqrt(num1)
    End Sub

    Private Sub SinButton_Click(sender As Object, e As EventArgs) Handles SinButton.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        DisplayTextBox.Text = Math.Sin(num1)
    End Sub

    Private Sub CosinButton_Click(sender As Object, e As EventArgs) Handles CosinButton.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        DisplayTextBox.Text = Math.Cos(num1)
    End Sub

    Private Sub TanButton_Click(sender As Object, e As EventArgs) Handles TanButton.Click
        Decimal.TryParse(DisplayTextBox.Text, num1)
        DisplayTextBox.Text = Math.Tan(num1)
    End Sub

    Private Sub piebutton_Click(sender As Object, e As EventArgs) Handles piebutton.Click
        DisplayTextBox.Text = Math.PI
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Decimal.TryParse(DisplayTextBox.Text, Mem)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DisplayTextBox.Text = Mem
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Mem = 0
    End Sub
End Class
