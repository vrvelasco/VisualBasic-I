Option Strict On ' *** Victor Velasco ***

Module Program

    Sub Main()
        ' Variables
        Dim choice As Integer

        ' Instantiate Printing Class
        Dim myGraphical As New Graphical()

        ' Prints the name of the app
        Console.WriteLine(myGraphical.title)

        ' Prints the intro message
        myGraphical.DelayedPrint(myGraphical.intro)

        ' Creates the Cirlce object
        Dim myCircle As New Circle(5)

        ' Display menu and get the user's selection
        choice = myGraphical.DisplayMenu()

        ' Loop until the user exits program
        While (choice <> 6)
            If choice >= 1 And choice <= 5 Then
                Select Case choice
                    Case 1 ' Get Radius
                        Console.WriteLine(vbCrLf & myGraphical.menuGetRadius)
                        myGraphical.DelayedPrint(vbCrLf & vbTab & "The Radius is: " & myCircle.Radius.ToString())
                    Case 2 ' Set Radius
                        Console.WriteLine(vbCrLf & myGraphical.menuSetRadius & vbCrLf)
                        Console.Write(vbTab & "Value of the new Radius: ") ' Ask user for the new value

                        Dim tempRadius As Integer ' To hold the user's new radius value

                        If Integer.TryParse(Console.ReadLine().Trim(), tempRadius) Then ' Valid?
                            Try
                                Console.Write(vbCrLf) ' For formating
                                myCircle.Radius = tempRadius ' Let's try the new value
                            Catch ex As Exception
                                ' There was an error. Display message to user.
                                Console.WriteLine(myGraphical.errMsg & vbCrLf)
                                myGraphical.DelayedPrint(vbTab & ex.Message)
                            End Try
                        Else
                            Console.WriteLine(vbCrLf & myGraphical.errMsg & vbCrLf) ' Not an int
                        End If
                    Case 3 ' Get Diameter
                        Console.WriteLine(vbCrLf & myGraphical.menuDiameter)
                        myGraphical.DelayedPrint(vbCrLf & vbTab & "The Diameter is: " & myCircle.Diameter.ToString("n2"))
                    Case 4 ' Get Area
                        Console.WriteLine(vbCrLf & myGraphical.menuArea)
                        myGraphical.DelayedPrint(vbCrLf & vbTab & "The Area is: " & myCircle.Area.ToString("n2"))
                    Case 5 ' Get Circumference
                        Console.WriteLine(vbCrLf & myGraphical.menuCircumference)
                        myGraphical.DelayedPrint(vbCrLf & vbTab & "The Circumference is: " & myCircle.Circumference.ToString("n2"))
                End Select
            Else
                ' Wrong selection
                Console.WriteLine(vbCrLf & myGraphical.errMsg & vbCrLf)
            End If
            ' Get their selection again
            choice = myGraphical.DisplayMenu()
        End While

        ' Display Goodbye message
        myGraphical.ExitProgram()
    End Sub
End Module
