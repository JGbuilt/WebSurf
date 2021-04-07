Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
WebBrowser1.GoBack()

    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        WebBrowser1.GoForward()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        WebBrowser1.Refresh()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WebBrowser1.Navigate(TextBox1.Text)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

