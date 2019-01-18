Public Class Form1
    Private Sub btnClickMe_Click(sender As Object, e As EventArgs) Handles btnClickMe.Click
        lblWelcome.Text = "Welcome to CIS 184!"
        lblWelcome.ForeColor = Color.Red
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' MessageBox.Show("Bye", "Closing App...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MessageBox.Show("Bye", "Closing App...", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
