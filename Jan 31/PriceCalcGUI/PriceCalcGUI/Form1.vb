Option Strict On
Public Class Form1 ' *** Victor Velasco ***
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click, Me.Load
        ' Constants
        Const TAX_RATE As Double = 0.07

        ' Declarations
        Dim quantity As Integer
        Dim price, subtotal, totalSale, taxAmount, discountDollars As Double

        ' Input quantity and price
        quantity = CInt(txtQuantity.Text)
        price = CDbl(txtPrice.Text)

        ' Calculate tax and total sales
        subtotal = quantity * price

        If quantity >= 30 Then
            discountDollars = subtotal * 0.4
        ElseIf quantity >= 20 Then
            discountDollars = subtotal * 0.25
        ElseIf quantity >= 10 Then
            discountDollars = subtotal * 0.1
        End If

        subtotal = subtotal - discountDollars

        taxAmount = subtotal * TAX_RATE
        totalSale = subtotal + taxAmount

        ' Output results
        lblOutput.Text = String.Format("Discount: {0}".PadRight(15), discountDollars.ToString("c").PadLeft(15) & vbNewLine)
        lblOutput.Text &= String.Format("Sub Total: {0}".PadRight(15), subtotal.ToString("c").PadLeft(15) & vbNewLine)
        lblOutput.Text &= String.Format("Tax Amount: {0}".PadRight(15), taxAmount.ToString("c").PadLeft(15) & vbNewLine)
        lblOutput.Text &= String.Format("Total sale: {0}".PadRight(15), totalSale.ToString("c").PadLeft(15))
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged, txtPrice.TextChanged
        lblOutput.Text = String.Empty
    End Sub
End Class
