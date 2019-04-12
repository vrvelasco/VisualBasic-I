Option Strict On ' *** Victor Velasco ***
Public Class Form1
    ' Arrays
    Dim items(-1) As String
    Dim amounts(-1) As Double

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' Get user input
        If txtItem.Text = String.Empty Or txtAmount.Text = "" Then ' Missing data?
            ' Error message
            MessageBox.Show("Please enter the item and amount.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Resize arrays
            ReDim Preserve items(items.Length)
            ReDim Preserve amounts(amounts.Length)

            ' Assign user input to arrays
            items(items.Length - 1) = txtItem.Text
            amounts(amounts.Length - 1) = CDbl(txtAmount.Text)

            ' Clear TextBoxes and then print receipt
            txtItem.Clear()
            txtAmount.Clear()
            txtItem.Focus()
            PrintReceipt()
        End If
    End Sub

    Sub PrintReceipt()
        ' Variables
        Const SALES_TAX As Double = 0.07
        Dim subtotal As Double = amounts.Sum()
        Dim tax As Double = subtotal * SALES_TAX

        ' Clear the ListBox
        lstReceipt.Items.Clear()

        ' Prints heading
        lstReceipt.Items.Add("Sales Receipt".PadLeft(17))
        lstReceipt.Items.Add("")

        ' Go through arrays
        For i = 0 To items.Length - 1
            lstReceipt.Items.Add(items(i).PadRight(15) & amounts(i).ToString("c"))
        Next

        'Print subtotal and tax
        lstReceipt.Items.Add("")
        lstReceipt.Items.Add("Subtotal:".PadRight(15) & subtotal.ToString("c"))
        lstReceipt.Items.Add("Tax:".PadRight(15) & tax.ToString("c"))
        lstReceipt.Items.Add("")
        lstReceipt.Items.Add("Total:" & (subtotal + tax).ToString("C").PadLeft(14))
    End Sub
End Class
