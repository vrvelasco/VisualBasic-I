Public Class Circle
    ' Fields
    Private _radius As Integer

    ' Constructor
    Public Sub New(rad As Integer)
        _radius = rad
    End Sub

    ' Properties
    Public Property Radius As Integer
        Get
            Return _radius
        End Get
        Set(value As Integer)
            ' Check the value
            If value <= 0 Then
                Throw New Exception("The radius value was invalid.")
            Else
                _radius = value
            End If
        End Set
    End Property

    Public ReadOnly Property Diameter() As Integer
        Get
            Return _radius * 2
        End Get
    End Property

    Public ReadOnly Property Area() As Double
        Get
            Return Math.PI * _radius ^ 2
        End Get
    End Property

    Public ReadOnly Property Circumference() As Double
        Get
            Return 2 * Math.PI * _radius
        End Get
    End Property
End Class
