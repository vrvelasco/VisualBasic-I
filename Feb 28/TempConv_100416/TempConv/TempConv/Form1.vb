Option Strict On

Public Class Form1

    Sub ErrMsg(errCode As Integer)
        If errCode = 1 Then
            MessageBox.Show("Enter a number greater than -50")
        ElseIf errCode = 2 Then
            MessageBox.Show("Enter a number less than 150")
        Else
            MessageBox.Show("An error has occurred. Please try again")
        End If
    End Sub

    Function FtoC(f As Integer) As Double
        Dim c As Double
        c = 5 / 9 * (f - 32)
        Return c
    End Function

    Sub InputData(ByRef f As Integer)
        f = CInt(txtFahr.Text)
    End Sub

    Sub DisplayResults(f As Integer, c As Double)
        lblOutput.Text = f & " F. is " & c.ToString("N") & " C."
    End Sub
    Function ValidateInput(f As Integer) As Boolean
        Dim v As Boolean

        If f <= -50 Then
            ErrMsg(1)
            v = False
        ElseIf f > 150 Then
            ErrMsg(2)
            v = False
        Else
            v = True
        End If

        Return v
    End Function
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        Dim fahr As Integer
        Dim celsius As Double

        InputData(fahr)

        If ValidateInput(fahr) Then
            celsius = FtoC(fahr)
            DisplayResults(fahr, celsius)
        End If

    End Sub
End Class
