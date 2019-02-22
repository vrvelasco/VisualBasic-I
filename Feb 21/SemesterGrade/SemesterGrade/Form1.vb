Option Strict On
Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        RenameMe()
    End Sub

    Sub RenameMe()
        lblOutput.Text = RenameMe2(100, 100, 100)
    End Sub

    Function RenameMe2(f As Integer, s As Integer, t As Integer) As String
        Dim letter As String
        Dim average As Integer

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

        Return letter
    End Function
End Class
