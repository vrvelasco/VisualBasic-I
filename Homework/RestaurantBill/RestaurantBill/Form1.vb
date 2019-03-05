Option Strict On '*** Victor Velasco ***

Class Form1
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        ' Variables
        Dim qtyPizza, qtyFries, qtyDrinks As Integer

        lstBill.Items.Clear() ' Just in case something is in the list

        ' Sub procedure to input quantities.
        GetQuantity(qtyPizza, qtyFries, qtyDrinks)

        ' Function to validate inpute
        If ValidateInpute(qtyPizza, qtyFries, qtyDrinks) Then
            DisplayItemizedBill(qtyPizza, qtyFries, qtyDrinks)
        Else
            MessageBox.Show("Please check the quantities.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub GetQuantity(ByRef p As Integer, ByRef f As Integer, ByRef d As Integer)
        ' Get values from TextBoxes
        p = CInt(txtPizza.Text)
        f = CInt(txtFries.Text)
        d = CInt(txtDrinks.Text)
    End Sub

    Function ValidateInpute(p As Integer, f As Integer, d As Integer) As Boolean
        ' Negative quantities?
        If p > 0 And f > 0 And d > 0 Then
            Return True
        Else
            Return False ' Error
        End If
    End Function

    Sub DisplayItemizedBill(p As Integer, f As Integer, d As Integer)
        ' Variables
        Dim costPizza, costFries, costDrinks, total As Double

        ' Calculate total
        total = CalculateTotal(p, f, d, costPizza, costFries, costDrinks)

        ' Output to user
        lstBill.Items.Add("ITEM".PadRight(25) & "QUANTITY" & "PRICE".PadLeft(15))
        lstBill.Items.Add("=====================================")
        lstBill.Items.Add("Pizza Slices".PadRight(23) & p.ToString() & costPizza.ToString("c").PadLeft(32))
        lstBill.Items.Add("Fries".PadRight(27) & f.ToString() & costFries.ToString("c").PadLeft(32))
        lstBill.Items.Add("Soft Drinks".PadRight(23) & d.ToString() & costDrinks.ToString("c").PadLeft(32))
        lstBill.Items.Add("=====================================")
        lstBill.Items.Add("TOTAL" & total.ToString("c").PadLeft(51))

    End Sub

    Function CalculateTotal(qP As Integer, qF As Integer, qD As Integer, ByRef cP As Double, ByRef cF As Double, ByRef cD As Double) As Double
        cP = qP * 1.75
        cF = qF * 2.0
        cD = qD * 1.25

        Return cP + cF + cD
    End Function
End Class
