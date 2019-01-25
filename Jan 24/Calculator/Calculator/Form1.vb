Public Class Form1 ' *** Victor Velasco ***
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Addition

        Dim firstNum, secondNum, result As Double

        If txtFirstNumber.Text = String.Empty Or txtSecondNumber.Text = "" Then ' Empty?
            MessageBox.Show("Please enter a number in both fields and try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Error!
            If Double.TryParse(txtFirstNumber.Text, firstNum) And Double.TryParse(txtSecondNumber.Text, secondNum) Then
                result = firstNum + secondNum
                lblOutput.Text = result
            Else
                MessageBox.Show("Please check the entries and try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ' Can't parsed
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MessageBox.Show("Enter two numbers to begin.", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
