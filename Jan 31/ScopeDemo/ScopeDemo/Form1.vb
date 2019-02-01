Option Strict On
Public Class Form1
    Dim counter As Integer
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        counter += 1
        MessageBox.Show(counter.ToString())
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        MessageBox.Show(counter.ToString())
    End Sub
End Class
