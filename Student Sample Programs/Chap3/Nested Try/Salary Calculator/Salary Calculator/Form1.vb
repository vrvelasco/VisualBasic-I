﻿Public Class Form1
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim decAnnualSalary As Decimal  ' Annual salary
        Dim intPayPeriods As Integer    ' Number of pay periods
        Dim decSalary As Decimal        ' Salary per pay period

        Try
            ' Get the annual salary.
            decAnnualSalary = CDec(txtAnnualSalary.Text)

            Try
                ' Get the number of pay periods.
                intPayPeriods = CInt(txtPayPeriods.Text)

                Try
                    ' Calculate the salary per pay period.
                    decSalary = decAnnualSalary / intPayPeriods

                    ' Display the salary per pay period.
                    lblSalary.Text = decSalary.ToString("c")
                Catch
                    ' Error message for division-by-zero.
                    MessageBox.Show("Pay periods cannot be zero.")
                End Try

            Catch
                ' Error message for invalid pay periods.
                MessageBox.Show("Pay periods must be an integer.")
            End Try

        Catch
            ' Display an error message.
            MessageBox.Show("Error: Be sure to enter nonzero " &
                            "numeric values.")
        End Try
    End Sub
End Class
