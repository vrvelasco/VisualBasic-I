Public Class Form1
    Dim mySquare As New Square(4)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplaySquare()
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        mySquare.Side = InputBox("Side:")
        DisplaySquare()
    End Sub

    Private Sub DisplaySquare()
        lblSide.Text = mySquare.Side
        lblArea.Text = mySquare.Area
        lblSquare.Text = mySquare.GetSquare()
    End Sub
End Class
