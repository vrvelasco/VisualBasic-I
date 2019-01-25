Public Class Form1 ' *** Victor Velasco ***
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Constants
        Const TAX_RATE As Double = 0.07

        ' Declarations
        Dim quantity As Integer
        Dim price, subtotal, totalSale, taxAmount As Double

        ' Input quantity and price
        quantity = txtQuantity.Text
        price = txtPrice.Text

        ' Calculate tax and total sales
        subtotal = quantity * price
        taxAmount = subtotal * TAX_RATE
        totalSale = subtotal + taxAmount

        ' Output results
        lblOutput.Text = String.Format("Sub Total: {0}".PadRight(15), subtotal.ToString("c").PadLeft(15) & vbNewLine)
        lblOutput.Text &= String.Format("Tax Amount: {0}".PadRight(15), taxAmount.ToString("c").PadLeft(15) & vbNewLine)
        lblOutput.Text &= String.Format("Total sale: {0}".PadRight(15), totalSale.ToString("c").PadLeft(15))
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged, txtPrice.TextChanged
        lblOutput.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class
