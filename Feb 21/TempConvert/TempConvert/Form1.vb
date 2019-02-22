Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim fahr As Integer
        Dim celsius As Double

        If Not Integer.TryParse(txtFahr.Text, fahr) Then
            'MessageBox.Show("Please enter an integer.")
            ErrMsg(1)

        ElseIf fahr < -50 Or fahr > 150 Then
            'MessageBox.Show("Please enter an integer between -50 and 150")
            ErrMsg(2)

        Else
            celsius = FtoC(fahr)

            lblOutput.Text = fahr & " F. is " & celsius.ToString("N") & " C."
        End If

        txtFahr.Focus()
    End Sub

    Function FtoC(f As Integer) As Double
        Dim c As Double
        c = 5 / 9 * (f - 32)
        Return c
    End Function

    Sub ErrMsg(errCode As Integer)
        Dim errMsg As String

        If errCode = 1 Then
            errMsg = "Please enter an integer."
        ElseIf errCode = 2 Then
            errMsg = "Please enter an integer between -50 and 150"
        Else
            errMsg = "Error. Please try again."
        End If

        MessageBox.Show(errMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class
