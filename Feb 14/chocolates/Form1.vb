Option Strict On ' Victor Velasco
Class Form1
    Private Sub txtChocPerBox_TextChanged(sender As Object, e As EventArgs) Handles txtChocPerBox.TextChanged
        lstChocolates.Items.Clear() ' Clear ListBox
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim boxSize As Integer ' Box size
        Dim sum As Double      ' Total cost 

        If Integer.TryParse(txtChocPerBox.Text, boxSize) Then ' TextBox contains correct data

            If boxSize >= 1 And boxSize <= 4 Then ' Within Range?
                ' Clear ListBox before looping
                lstChocolates.Items.Clear()

                lstChocolates.Items.Add("Boxes" & vbTab & "Cost of Order") ' Columns

                ' Loop
                For i = 1 To 10
                    sum = i * (boxSize * 3.75 + 2.5) ' Cost of Order

                    ' More than 7?
                    If i > 7 Then
                        sum = sum - 3.0 ' Discount
                    End If

                    ' Add to ListBox
                    lstChocolates.Items.Add(i.ToString & vbTab & sum.ToString("c"))
                Next
            Else
                MessageBox.Show("You may order 1-4 dozen per box only. Please try again.", "Invalid Range", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else
            MessageBox.Show("The dozen per box size is non-numeric or empty. Please try again.", "Non-Numeric Or Empty", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
