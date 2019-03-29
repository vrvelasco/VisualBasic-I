Public Class Form1
    Dim weekDays() As String = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}
    Dim sales(6) As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplaySales()
        lstOutput.SelectedIndex = 0
    End Sub
    Sub DisplaySales()
        lstOutput.Items.Clear()

        For i = 0 To weekDays.Length - 1
            lstOutput.Items.Add(weekDays(i).PadRight(15) & sales(i))
        Next

        lstOutput.Items.Add("-------------------------")
        lstOutput.Items.Add("Total sales:".PadRight(15) & sales.Sum().ToString("c"))
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim d As Integer

        d = lstOutput.SelectedIndex

        If d >= 0 Then
            sales(d) = InputBox(weekDays(d) & " sales amount:")
        Else
            MessageBox.Show("Select a weekday")
        End If

        DisplaySales()
    End Sub
End Class
