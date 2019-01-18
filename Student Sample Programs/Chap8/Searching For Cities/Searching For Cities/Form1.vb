Public Class Form1
    Private Sub btnFindCity_Click(sender As Object, e As EventArgs) Handles btnFindCity.Click
        For Each strCity As String In lstCities.Items
            If strCity = txtCity.Text Then
                lblResult.Text = "The city was found!"
            End If
        Next
    End Sub
End Class
