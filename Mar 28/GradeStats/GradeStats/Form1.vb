Public Class Form1
    Dim scores(-1) As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayStats()
    End Sub
    Sub DisplayStats()
        lstGrades.Items.Clear()

        For Each grade In scores
            lstGrades.Items.Add(grade)
        Next

        lblOutput.Text = "Sum of scores: " & scores.Sum() & vbCrLf
        If scores.Count > 0 Then lblOutput.Text &= "Average of scores: " & scores.Average.ToString("n1") & vbCrLf
        lblOutput.Text &= "Number of scores: " & scores.Count & vbCrLf
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ReDim Preserve scores(scores.Length)

        scores(scores.Length - 1) = InputBox("Enter new score:", "New Score")

        DisplayStats()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ReDim scores(-1)
        DisplayStats()
    End Sub
End Class
