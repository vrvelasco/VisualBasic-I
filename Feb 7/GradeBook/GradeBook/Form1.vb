Public Class Form1
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim strGrade As String
        strGrade = txtGrade.Text

        If strGrade = String.Empty Then
            MessageBox.Show("Please enter a grade")
        ElseIf Not IsNumeric(strGrade) Then
            MessageBox.Show("Please enter a numeric grade")
        ElseIf strGrade < 0 Or strGrade > 100 Then
            MessageBox.Show("Please enter a number between 0 and 100")
        Else
            lstGrades.Items.Add(strGrade)
            txtGrade.Clear()
            txtGrade.Focus()
        End If
    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        Dim sum As Integer     ' Accumulator variable
        Dim average As Double  ' Output variable
        ' Dim i As Integer = 0   ' Counter variable

        'Do While i < lstGrades.Items.Count()
        '    sum += lstGrades.Items(i)
        '    i += 1
        'Loop

        For i = 0 To lstGrades.Items.Count() - 1
            sum += lstGrades.Items(i)
        Next

        average = sum / lstGrades.Items.Count()

        lblOutput.Text = average.ToString("n")
    End Sub
End Class
