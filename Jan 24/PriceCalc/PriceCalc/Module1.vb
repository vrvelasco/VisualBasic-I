Module Module1

    Sub Main()
        ' Constants
        Const TAX_RATE As Double = 0.07

        ' Declarations
        Dim quantity As Integer
        Dim price, subtotal, totalSale, taxAmount As Double

        ' Input quantity and price
        Console.Write("Quantity: ")
        quantity = Console.ReadLine()

        Console.Write("Price: ")
        price = Console.ReadLine()

        ' Calculate tax and total sales
        subtotal = quantity * price
        taxAmount = subtotal * TAX_RATE
        totalSale = subtotal + taxAmount

        ' Output results
        Console.WriteLine("Sub Total: {0}", subtotal.ToString("c"))
        Console.WriteLine("Tax Amount: {0}", taxAmount.ToString("c"))
        Console.WriteLine("Total sale: {0}", totalSale.ToString("c"))

        Console.Write("Press any key to continue...")
        Console.ReadKey()
    End Sub

End Module
