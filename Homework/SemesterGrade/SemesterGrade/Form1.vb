Option Strict On ' *** Victor Velasco ***
Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        If Not txtName.Text = "" Then ' Name field empty?
            If Not txtFirst.Text = "" And Not txtSecond.Text = "" And Not txtThird.Text = "" Then ' Any test scores missing?
                ' Send name and test scores
                CallsFunction(txtName.Text, CInt(txtFirst.Text), CInt(txtSecond.Text), CInt(txtThird.Text))
            Else
                ErrMsg("Please enter three test scores.") ' Some (or all) scores missing error
                txtFirst.Focus() ' Focus to first test grades
            End If
        Else
            ErrMsg("Please enter a name.") ' Name missing error
            txtName.Focus() ' Focus to name field
        End If
    End Sub

    Sub CallsFunction(n As String, f As Integer, s As Integer, t As Integer)
        lblOutput.Text = n & ": " & TheFunction(f, s, t).ToString() ' Print results to output label
    End Sub

    Function TheFunction(f As Integer, s As Integer, t As Integer) As String
        Dim letter As String                ' The letter grade
        Dim sum, average As Integer         ' Variables to hold the sum and then the average
        Dim grades = New Integer() {f, s, t} ' Array holds the test scores

        ' Loop through array to add the scores
        For Each grade In grades
            sum += grade
        Next

        sum -= grades.Min() ' Find the lowest number in the array and then subtract from the sum

        average = CInt(sum / 2) ' Calculate the average from the two highest scores... Converting to int to round

        ' Assign the letter grade based on the average
        Select Case average
            Case 90 To 100
                letter = "A"
            Case 80 To 89
                letter = "B"
            Case 70 To 79
                letter = "C"
            Case 60 - 69
                letter = "D"
            Case Else
                letter = "F"
        End Select

        Return letter ' Returns the letter grade for printing result
    End Function

    Sub ErrMsg(m As String) ' Handles errors
        MessageBox.Show(m, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged, txtFirst.TextChanged, txtSecond.TextChanged, txtThird.TextChanged
        lblOutput.Text = ""
    End Sub
End Class
