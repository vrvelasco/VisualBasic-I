Public Class Form1

    Const TAX_RATE As Double = 0.07

    Sub InputData(ByRef q As Integer, ByRef p As Double)
        q = txtQuantity.Text
        p = txtPrice.Text
    End Sub

    Sub CalcResults(q As Integer, p As Double, ByRef t As Double, ByRef subtotal As Double, ByRef taxAmount As Double)
        'Dim subtotal, taxAmount As Double

        subtotal = q * p
        taxAmount = subtotal * TAX_RATE
        t = subtotal + taxAmount
    End Sub

    Sub ShowPrice(t As Double, subtotal As Double, taxAmount As Double)
        lblOutput.Text = ("Subtotal: " & subtotal.ToString("C")) & ControlChars.CrLf
        lblOutput.Text &= ("Tax: " & taxAmount.ToString("C")) & ControlChars.CrLf
        lblOutput.Text &= ("Total price: " & t.ToString("C"))
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click, Me.Load

        'Declarations
        Dim quantity As Integer
        Dim price As Double
        Dim totalPrice, subtotal, taxAmount As Double


        'Input quantity and price
        InputData(quantity, price)

        'Calculate and display results
        CalcResults(quantity, price, totalPrice, subtotal, taxAmount)

        ' Display results
        ShowPrice(totalPrice, subtotal, taxAmount)

    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        lblOutput.Text = ""
    End Sub

End Class
