Public Class Form1

    ' **************
    ' First TextBox
    ' **************
    Private Sub txtOne_Enter(sender As Object, e As EventArgs) Handles txtOne.Enter
        txtOne.ForeColor = Color.Red
    End Sub

    Private Sub txtOne_Leave(sender As Object, e As EventArgs) Handles txtOne.Leave
        txtOne.ForeColor = Color.Black
    End Sub

    ' ***************
    ' Second TextBox
    ' ***************
    Private Sub txtTwo_Enter(sender As Object, e As EventArgs) Handles txtTwo.Enter
        txtTwo.ForeColor = Color.Red
    End Sub

    Private Sub txtTwo_Leave(sender As Object, e As EventArgs) Handles txtTwo.Leave
        txtTwo.ForeColor = Color.Black
    End Sub

    ' **************
    ' Third TextBox
    ' **************
    Private Sub txtThree_Enter(sender As Object, e As EventArgs) Handles txtThree.Enter
        txtThree.ForeColor = Color.Red
    End Sub

    Private Sub txtThree_Leave(sender As Object, e As EventArgs) Handles txtThree.Leave
        txtThree.ForeColor = Color.Black
    End Sub

    ' ********
    ' Buttons
    ' ********
    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        txtOne.TextAlign = HorizontalAlignment.Left
        txtTwo.TextAlign = HorizontalAlignment.Left
        txtThree.TextAlign = HorizontalAlignment.Left
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        txtOne.TextAlign = HorizontalAlignment.Right
        txtTwo.TextAlign = HorizontalAlignment.Right
        txtThree.TextAlign = HorizontalAlignment.Right
    End Sub
End Class
