Imports System.Threading

Public Class Graphical
    ' ASCII Art
    Public title As String = vbCrLf & vbCrLf & vbTab & " .d8888b.  d8b                 888                      d8888                   " _
                                    & vbCrLf & vbTab & "d88P  Y88b Y8P                 888                     d88888                   " _
                                    & vbCrLf & vbTab & "888    888                     888                    d88P888                   " _
                                    & vbCrLf & vbTab & "888        888 888d888 .d8888b 888  .d88b.           d88P 888 88888b.  88888b.  " _
                                    & vbCrLf & vbTab & "888        888 888P""  d88P""    888 d8P  Y8b         d88P  888 888 ""88b 888 ""88b " _
                                    & vbCrLf & vbTab & "888    888 888 888    888      888 88888888        d88P   888 888  888 888  888 " _
                                    & vbCrLf & vbTab & "Y88b  d88P 888 888    Y88b.    888 Y8b.           d8888888888 888 d88P 888 d88P " _
                                    & vbCrLf & vbTab & " ""Y8888P""  888 888     ""Y8888P 888  ""Y8888       d88P     888 88888P""  88888P""  " _
                                    & vbCrLf & vbTab & "                                                              888      888      " _
                                    & vbCrLf & vbTab & "                                                              888      888      " _
                                    & vbCrLf & vbTab & "                                                              888      888      " _
                                    & vbCrLf & vbCrLf

    Public intro As String = vbTab & "Welcome to the Circle program! I instantiated a new circle for you with a radius of " _
                  & vbCrLf & vbTab & "5. Use the menu below to get information about the object or to change it."

    Public menu As String = vbTab & "╔══════════════════════════╗" _
                 & vbCrLf & vbTab & "║         MAIN MENU        ║" _
                 & vbCrLf & vbTab & "╠══════════════════════════╣" _
                 & vbCrLf & vbTab & "║ 1. Get The Radius        ║" _
                 & vbCrLf & vbTab & "║ 2. Set The Radius        ║" _
                 & vbCrLf & vbTab & "║ 3. Get The Diameter      ║" _
                 & vbCrLf & vbTab & "║ 4. Get The Area          ║" _
                 & vbCrLf & vbTab & "║ 5. Get the Circumference ║" _
                 & vbCrLf & vbTab & "║ 6. Exit The Program      ║" _
                 & vbCrLf & vbTab & "╚══════════════════════════╝" _
                 & vbCrLf & vbCrLf & vbTab & "Selection: "

    Public errMsg As String = vbTab & "╔══════════════════════════╗" _
                   & vbCrLf & vbTab & "║ Error: Please try again. ║" _
                   & vbCrLf & vbTab & "╚══════════════════════════╝"

    Public menuSetRadius As String = vbTab & "╔════════════╗" _
                          & vbCrLf & vbTab & "║ SET RADIUS ║" _
                          & vbCrLf & vbTab & "╚════════════╝"

    Public menuGetRadius As String = vbTab & "╔════════════╗" _
                          & vbCrLf & vbTab & "║ GET RADIUS ║" _
                          & vbCrLf & vbTab & "╚════════════╝"

    Public menuDiameter As String = vbTab & "╔══════════════╗" _
                         & vbCrLf & vbTab & "║ GET DIAMETER ║" _
                         & vbCrLf & vbTab & "╚══════════════╝"

    Public menuArea As String = vbTab & "╔══════════╗" _
                     & vbCrLf & vbTab & "║ GET AREA ║" _
                     & vbCrLf & vbTab & "╚══════════╝"

    Public menuCircumference As String = vbTab & "╔═══════════════════╗" _
                              & vbCrLf & vbTab & "║ GET CIRCUMFERENCE ║" _
                              & vbCrLf & vbTab & "╚═══════════════════╝"


    Public Sub DelayedPrint(msg As String)
        Dim charMsg() As Char = msg.ToCharArray()

        ' Prints each letter slowly
        For Each c As Char In charMsg
            Console.Write(c)
            Thread.Sleep(50)
        Next
        Console.WriteLine(vbCrLf)
    End Sub

    Public Function DisplayMenu() As Integer
        Dim selection As Integer

        Console.Write(menu) ' Prints the menu

        If Integer.TryParse(Console.ReadLine().Trim(), selection) Then ' Valid int?
            Return selection ' Success
        Else
            Return -1 ' Error
        End If
    End Function

    Public Sub ExitProgram()
        Console.Write(vbCrLf & vbTab & "Exiting program in 3...")
        Thread.Sleep(1000)
        Console.Write(" 2...")
        Thread.Sleep(1000)
        Console.Write(" 1...")
        Thread.Sleep(1000)
        Console.Write(" Goodbye!")
        Thread.Sleep(1000)
    End Sub
End Class
