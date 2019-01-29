Public Class Form1 ' *** Victor Velasco ***
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, MyBase.Load
        ' Addition
        Dim firstNum, secondNum, result As Double

        If txtFirstNumber.Text = String.Empty Or txtSecondNumber.Text = "" Then ' Empty?
            MessageBox.Show("Please enter a number in both fields and try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Error!
        Else
            If Double.TryParse(txtFirstNumber.Text, firstNum) And Double.TryParse(txtSecondNumber.Text, secondNum) Then
                result = firstNum + secondNum
                lblOutput.Text = String.Format("{0} + {1} = {2}", firstNum, secondNum, result)
            Else
                MessageBox.Show("Please check the entries and try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ' Can't parse
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MessageBox.Show("Enter two numbers to begin.", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub txtFirstNumber_TextChanged(sender As Object, e As EventArgs) Handles txtFirstNumber.TextChanged, txtSecondNumber.TextChanged
        lblOutput.Text = "" ' Clear results when the inputs change
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        ' Subtraction
        Dim firstNum, secondNum, result As Double

        If txtFirstNumber.Text = String.Empty Or txtSecondNumber.Text = "" Then ' Empty?
            MessageBox.Show("Please enter a number in both fields and try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Error!
        Else
            If Double.TryParse(txtFirstNumber.Text, firstNum) And Double.TryParse(txtSecondNumber.Text, secondNum) Then
                result = firstNum - secondNum
                lblOutput.Text = String.Format("{0} - {1} = {2}", firstNum, secondNum, result)
            Else
                MessageBox.Show("Please check the entries and try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ' Can't parse
            End If
        End If
    End Sub

    Private Sub btnMul_Click(sender As Object, e As EventArgs) Handles btnMul.Click
        ' Multiplication
        Dim firstNum, secondNum, result As Double

        If txtFirstNumber.Text = String.Empty Or txtSecondNumber.Text = "" Then ' Empty?
            MessageBox.Show("Please enter a number in both fields and try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Error!
        Else
            If Double.TryParse(txtFirstNumber.Text, firstNum) And Double.TryParse(txtSecondNumber.Text, secondNum) Then
                result = firstNum * secondNum
                lblOutput.Text = String.Format("{0} x {1} = {2}", firstNum, secondNum, result)
            Else
                MessageBox.Show("Please check the entries and try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ' Can't parse
            End If
        End If
    End Sub
End Class
