Public Class Form1
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles MJPictureBox.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Displaypicturebox.Image = MJPictureBox.Image
        Label1.Text = "Micheal Jordan"
        Label2.Text = "During his vertical jump, his feet are 4 feet off the ground"
        Label3.Text = "He is 6 foot 6 inches"
        Label4.Text = "His signature move was his mastered fadeaway from the basket"
        Label5.Text = "Micheal Jordans top speed was a 4.38 40 yard dash which is crazy fast"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Displaypicturebox.Image = LebronPictureBox.Image
        Label1.Text = "Lebron James"
        Label2.Text = "His vertical jump is just above 40 inches or close to 4 feet "
        Label3.Text = "He is 6 foot 8 inches"
        Label4.Text = "His signature move is the Tomahawk dunk"
        Label5.Text = "Lebron's top speed was a 4.4 40 yard dash"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Displaypicturebox.Image = KareemPictureBox.Image
        Label1.Text = "Kareem Abdul-Jebar"
        Label2.Text = "He had a 44 inch vertical"
        Label3.Text = "Kareem is 7 foot 2 inches"
        Label4.Text = "His signature move was his famous Skyhook"
        Label5.Text = "He never did a 40 yard dash so we dont know what it was"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Displaypicturebox.Image = MagicPictureBox.Image
        Label1.Text = "Magic Johnson"
        Label2.Text = "His vertical was 30 inches"
        Label3.Text = "He was 6 foot 9 inches"
        Label4.Text = "He was known for his no look passes"
        Label5.Text = "He never did a 40 yard dash"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Displaypicturebox.Image = KobePictureBox.Image
        Label1.Text = "Kobe Bryant"
        Label2.Text = "His vertical was 38 inches"
        Label3.Text = "He was 6 foot 6 inches"
        Label4.Text = "His signature move was his mastered fadeaway"
        Label5.Text = "He ran a 4.30 40 yard dash"
    End Sub
End Class
