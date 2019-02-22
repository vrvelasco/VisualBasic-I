Public Class Form1
    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        Dim pswd As String

        pswd = txtPassword.Text

        If IsValidPassword(pswd) Then
            MessageBox.Show("Valid")
        Else
            MessageBox.Show("NOT valid")
        End If

        txtPassword.Clear()
        txtPassword.Focus()
    End Sub

    Function IsValidPassword(p As String) As Boolean
        Dim v As Boolean = False

        If p.Length >= 6 And Not IsNumeric(p) Then
            For i = 0 To p.Length - 1
                If IsNumeric(p.Substring(i, 1)) Then
                    v = True
                End If
            Next
        End If

        Return v
    End Function
End Class
