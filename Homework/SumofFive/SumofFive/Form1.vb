Public Class Form1
    Dim ints(4) As Integer ' Array to hold integers from the user

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' Loop to get numbers from the user
        For i = 0 To ints.Length - 1
            ints(i) = InputBox("Please enter an integer.", "Enter Number")
        Next
    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        ' Loop

        ' Display sum to user
        lblOutput.Text = String.Format("{0} + {1} + {2} + {3} + {4} = {5}", ints(1), ints(2), ints(3), ints(4), ints.Sum)
    End Sub
End Class
