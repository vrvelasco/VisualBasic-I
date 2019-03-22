Public Class Form1
    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Dim acctNums() As String = {"123456", "654321", "234561", "345612"} ' Array holding account numbers
        Dim aNum As String ' Input variable
        Dim valid As Boolean ' Flag variable

        aNum = txtAccount.Text ' Assign TextBox contents to variable

        ' Loop through array
        For i = 0 To acctNums.Length - 1
            If aNum = acctNums(i) Then
                valid = True ' Account matches an element
                Exit For ' No need to check other elements
            End If
        Next

        If valid Then
            MessageBox.Show("Valid account")
        Else
            MessageBox.Show("Invalid account")
        End If
    End Sub
End Class