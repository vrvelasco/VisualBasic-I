Public Class Form1
    Private Sub btnCalcFor_Click(sender As Object, e As EventArgs) Handles btnCalcFor.Click
        ' Declare variables
        Dim strSpeed As String ' InputBox for speed
        Dim strTimeTraveled As String ' InputBox for time
        Dim intSpeed As Integer ' Integer version of above
        Dim intTimeTraveled As Integer ' Integer version of above
        Dim intHours As Integer = 1 ' Inititalize

        ' Get user input
        strSpeed = InputBox("Please enter the speed (in MPH)", "Speed Value", "60")
        strTimeTraveled = InputBox("Please enter the time traveled (in hours)", "Time Traveled", "7")

        ' Convert and Validate
        If Integer.TryParse(strSpeed, intSpeed) Then
            If Integer.TryParse(strTimeTraveled, intTimeTraveled) Then
                If intSpeed > 0 Then
                    If intTimeTraveled > 0 Then
                        ' Just in case
                        lstInfo.Items.Clear() ' Clear ListBox
                        ' Display Speed and Time Traveled
                        lstInfo.Items.Add("Vehicle Speed: " & strSpeed & " MPH")
                        lstInfo.Items.Add("Time Traveled: " & strTimeTraveled & " hour(s)")
                        lstInfo.Items.Add("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈")
                        lstInfo.Items.Add("Hours" & vbTab & "Distance Traveled")
                        lstInfo.Items.Add("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈")
                        For intHours = 1 To intTimeTraveled
                            lstInfo.Items.Add(intHours & vbTab & (intSpeed * intHours))
                        Next
                        lblMessage.Text = "Finished processing!" & vbCrLf & "Results displayed above." ' Below are the error messages
                    Else
                        lblMessage.Text = "Please enter positive value for the hours."
                    End If
                Else
                    lblMessage.Text = "Please enter a positive value for the speed."
                End If
            Else
                lblMessage.Text = "Please enter a valid amount of hours."
            End If
        Else
            lblMessage.Text = "Please enter a valid speed value."
        End If
    End Sub

    Private Sub btnCalcDo_Click(sender As Object, e As EventArgs) Handles btnCalcDo.Click
        ' Declare variables
        Dim strSpeed As String ' InputBox for speed
        Dim strTimeTraveled As String ' InputBox for time
        Dim intSpeed As Integer ' Integer version of above
        Dim intTimeTraveled As Integer ' Integer version of above
        Dim intHours As Integer = 1 ' Inititalize

        ' Get user input
        strSpeed = InputBox("Please enter the speed (in MPH)", "Speed Value", "60")
        strTimeTraveled = InputBox("Please enter the time traveled (in hours)", "Time Traveled", "7")

        ' Convert and Validate
        If Integer.TryParse(strSpeed, intSpeed) Then
            If Integer.TryParse(strTimeTraveled, intTimeTraveled) Then
                If intSpeed > 0 Then
                    If intTimeTraveled > 0 Then
                        ' Just in case
                        lstInfo.Items.Clear() ' Clear ListBox
                        ' Display Speed and Time Traveled
                        lstInfo.Items.Add("Vehicle Speed: " & strSpeed & " MPH")
                        lstInfo.Items.Add("Time Traveled: " & strTimeTraveled & " hour(s)")
                        lstInfo.Items.Add("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈")
                        lstInfo.Items.Add("Hours" & vbTab & "Distance Traveled")
                        lstInfo.Items.Add("≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈")
                        Do While intHours <= intTimeTraveled
                            lstInfo.Items.Add(intHours & vbTab & (intSpeed * intHours))
                            intHours += 1 'Increment
                        Loop
                        lblMessage.Text = "Finished processing!" & vbCrLf & "Results displayed above." ' Below are the error message
                    Else
                        lblMessage.Text = "Please enter positive value for the hours."
                    End If
                Else
                    lblMessage.Text = "Please enter a positive value for the speed."
                End If
            Else
                lblMessage.Text = "Please enter a valid amount of hours."
            End If
        Else
            lblMessage.Text = "Please enter a valid speed value."
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstInfo.Items.Clear() ' Clear ListBox
        lblMessage.Text = "Click on a button above..." ' Clear Label
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Close form
    End Sub
End Class