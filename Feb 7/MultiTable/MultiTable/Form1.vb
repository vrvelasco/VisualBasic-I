Option Strict On
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0 ' Counter
        Dim item As String
        Dim multiplier As Integer

        multiplier = CInt(InputBox("Please enter a multiplier:", "Enter Multiplier", "5"))
        Do While i < 10
            item = CStr(i + 1) & " x " & multiplier.ToString() & " = " & (i + 1) * multiplier
            lstOutput.Items.Add(item)
            i += 1 ' Increment
        Loop
    End Sub
End Class