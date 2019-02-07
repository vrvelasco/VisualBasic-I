Option Strict On
Public Class Form1 '*** Victor Velasco ***
    Private Sub btnAnalyze_Click(sender As Object, e As EventArgs) Handles btnAnalyze.Click
        ' Variables
        Dim loanAmount As Integer
        Dim interest As Double
        Dim duration As Integer
        Dim payment As Double

        If Integer.TryParse(txtLoanAmount.Text, loanAmount) Then
            If Double.TryParse(txtInterestRate.Text, interest) Then
                If Integer.TryParse(txtDuration.Text, duration) Then
                    payment = carPayment(loanAmount, interest, duration)

                    lblPayment.Text = payment.ToString("c")
                    lblInterest.Text = totalInterest(duration, payment, loanAmount).ToString("c")
                Else
                    MessageBox.Show("Please enter a valid duration.")
                End If
            Else
                MessageBox.Show("Please enter a valid interest rate.")
            End If
        Else
            MessageBox.Show("Please enter a valid loan amount.")
        End If

        ' Reveal results
        Height = 250
    End Sub

    Function carPayment(ByVal p As Integer, ByVal i As Double, ByVal n As Integer) As Double
        Dim r As Double = i / 12D
        Return (p * r) / (1 - ((1 + r) ^ -n))
    End Function

    Function totalInterest(ByVal n As Integer, ByVal m As Double, ByVal p As Integer) As Double
        Return n * m - p
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Height = 185
    End Sub
End Class
