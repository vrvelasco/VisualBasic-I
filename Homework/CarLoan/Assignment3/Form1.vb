﻿Option Strict On
Public Class Form1 '*** Victor Velasco ***
    Private Sub btnAnalyze_Click(sender As Object, e As EventArgs) Handles btnAnalyze.Click
        ' Variables
        Dim loanAmount As Integer
        Dim interest As Double
        Dim duration As Integer
        Dim payment As Double

        If Integer.TryParse(txtLoanAmount.Text, loanAmount) Then
            If Double.TryParse(txtInterestRate.Text, interest) And interest >= 0 And interest <= 100 Then
                If Integer.TryParse(txtDuration.Text, duration) Then
                    payment = carPayment(loanAmount, interest, duration)

                    lblPayment.Text = payment.ToString("c")
                    lblInterest.Text = totalInterest(duration, payment, loanAmount).ToString("c")

                    ' Reveal results
                    Height = 250
                Else
                    MessageBox.Show("Please enter a valid duration.", "Invalid Duration", MessageBoxButtons.OK, MessageBoxIcon.Error
                                )
                End If
            Else
                MessageBox.Show("Please enter a valid interest rate.", "Invalid Interest Rate", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please enter a valid loan amount.", "Invalid Loan Amount", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Function carPayment(ByVal p As Integer, ByVal i As Double, ByVal n As Integer) As Double
        ' Convert rate and take annual rate divided by 12
        Dim r As Double = (i / 100) / 12

        ' Return Car Payment
        Return (p * r) / (1 - ((1 + r) ^ -n))
    End Function

    Function totalInterest(ByVal n As Integer, ByVal m As Double, ByVal p As Integer) As Double
        ' Total Interest
        Return n * m - p
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Height = 185
    End Sub

    Private Sub txtLoanAmount_TextChanged(sender As Object, e As EventArgs) Handles txtLoanAmount.TextChanged, txtInterestRate.TextChanged, txtDuration.TextChanged
        ' Clear results
        lblPayment.Text = ""
        lblInterest.Text = ""

        ' Hide results
        Height = 185
    End Sub
End Class
