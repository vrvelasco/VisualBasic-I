Public Class Form1
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim intGrade As Integer
        Dim strGrade As String

        strGrade = txtGrade.Text

        If strGrade = "" Then
            MessageBox.Show("Please enter a grade")
        ElseIf Not IsNumeric(strGrade) Then
            MessageBox.Show("Please enter a number")
        ElseIf Not Integer.TryParse(strGrade, intGrade) Then
            MessageBox.Show("Please enter a whole number")
        ElseIf intGrade < 0 Or intGrade > 100 Then
            MessageBox.Show("Enter a number between 0 and 100")
        Else
            lstGrades.Items.Add(strGrade)
            txtGrade.Clear()
            txtGrade.Focus()
        End If
    End Sub
End Class
