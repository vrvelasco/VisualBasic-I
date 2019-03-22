Option Strict On ' *** Victor Velasco ***
Public Class Form1
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' Variables
        Dim speed, time, distance As Integer

        ' Get speed and time values
        InputSpeedTime(speed, time)

        If TestSpeedTime(speed, time) Then ' Both positive?
            ' Get distance
            distance = FindDistance(time, speed)

            ' Display distance
            lblOutput.Text = distance.ToString()
        Else
            ' Error
            MessageBox.Show("Please enter values greater than zero for both speed and time.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub InputSpeedTime(ByRef s As Integer, ByRef t As Integer)
        ' Assign the value of speed to variable
        s = CInt(txtSpeed.Text)

        ' And time
        t = CInt(txtTime.Text)
    End Sub

    Function FindDistance(t As Integer, s As Integer) As Integer
        Return t * s ' Return distance
    End Function

    Function TestSpeedTime(s As Integer, t As Integer) As Boolean
        ' Determine whether Speed and Time are both positive
        If s > 0 And t > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txtSpeed_TextChanged(sender As Object, e As EventArgs) Handles txtSpeed.TextChanged, txtTime.TextChanged
        lblOutput.Text = ""
    End Sub
End Class
