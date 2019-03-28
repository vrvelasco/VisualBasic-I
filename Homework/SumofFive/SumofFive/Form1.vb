Option Strict On ' *** Victor Velasco ***

Public Class Form1
    Dim ints(4) As Integer ' Array to hold integers from the user

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' Clear Output Label
        lblOutput.Text = String.Empty

        ' Loop to get numbers from the user
        For i = 0 To ints.Length - 1
            ints(i) = CInt(InputBox("Please enter an integer.", "Enter Number", "5")) ' Default number in InputBox is for easy testing
        Next

        lblOutput.Text = "Now click ""Find Sum"" →" ' Message to user
    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Dim str As String = "" ' Holds the numbers
        Dim sum As Integer ' Holds the sum

        ' Loop
        For i = 0 To ints.Length - 1
            Dim num As Integer = ints(i) ' Hold element

            str &= num.ToString() ' Appends the numbers
            sum += num ' Adds the numbers

            If Not i = ints.Length - 1 Then str &= " + " ' For formating
        Next

        ' Display sum to user
        lblOutput.Text = String.Format("{0} = {1}", str, sum)
    End Sub
End Class