Public Class Package ' *** Victor Velasco ***

    ' Constructor
    Public Sub New(id As String, city As String, state As String)
        PackageID = id
        DestinationCity = city
        DestinationState = state
    End Sub

    ' Auto Implemented Properties
    Public Property PackageID As String
    Public Property DestinationCity As String

    Private _destinationState As String
    Public Property DestinationState() As String
        Get
            Return _destinationState
        End Get
        Set(ByVal value As String)
            If value.Equals("WI") Or value.Equals("IL") Or value.Equals("MO") Then
                _destinationState = value
            Else
                _destinationState = "??"
            End If
        End Set
    End Property
End Class
