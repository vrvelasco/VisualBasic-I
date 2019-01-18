Public Class Form1
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        TextBox2.ForeColor = Color.Red
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.ForeColor = Color.Blue
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        TextBox2.ForeColor = Color.Black
    End Sub
End Class
