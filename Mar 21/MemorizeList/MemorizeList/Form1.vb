Public Class Form1

    Dim myList(5) As String ' Declare list
    Dim counter As Integer = 0 'Array index

    Private Sub btnRecall_Click(sender As Object, e As EventArgs) Handles btnRecall.Click
        Dim items As String = ""

        ' Display array elements
        For i = 0 To counter - 1
            items &= myList(i) & vbCrLf
        Next

        MessageBox.Show(items)
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        If counter < myList.Length Then
            myList(counter) = txtItem.Text ' Assign value
            counter += 1
        Else
            MessageBox.Show("List is full")
        End If

        ' Clear field
        txtItem.Clear()
        txtItem.Focus()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        counter = 0 ' Reset array index counter
    End Sub
End Class
