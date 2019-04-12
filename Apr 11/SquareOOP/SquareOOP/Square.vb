Public Class Square
    ' Instance variables (Class variables, Member Variables, or "Fields")
    Private _side As Integer
    ' Constructors
    Public Sub New(p As Integer)
        _side = p
    End Sub

    ' Properties
    Public Property Side As Integer
        Get
            Return _side
        End Get
        Set(value As Integer)
            If value >= 2 And value <= 6 Then
                _side = value
            End If
        End Set
    End Property

    Public ReadOnly Property Area As Integer
        Get
            Return _side ^ 2
        End Get
    End Property

    ' Methods
    Public Function GetSquare() As String
        Dim s As String

        For j = 1 To Side
            For i = 1 To Side
                s &= "*".PadLeft(4)
            Next
            s &= vbCrLf
        Next

        Return s
    End Function

End Class
