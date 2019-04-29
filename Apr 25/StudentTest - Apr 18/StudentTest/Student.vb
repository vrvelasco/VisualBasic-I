Public Class Student
    Public Sub New()

    End Sub

    Public Sub New(first As String, last As String)
        StudentFirstName = first
        StudentLastName = last
        CurrCredits = 0
        TotCredits = 0
    End Sub

    Public Sub New(first As String, last As String, transfer As Integer)
        StudentFirstName = first
        StudentLastName = last
        CurrCredits = 0
        TotCredits = transfer
    End Sub

    ' Auto Implemented Properties
    Public Property StudentFirstName As String

    Public Property StudentLastName As String

    Public Property TotCredits As Integer

    Public ReadOnly Property StudentFullName() As String
        Get
            Return StudentFirstName & " " & StudentLastName
        End Get
    End Property

    Private _currCredits As Integer
    Public Property CurrCredits() As Integer
        Get
            Return _currCredits
        End Get
        Private Set(ByVal value As Integer)
            If value <= 18 Then
                _currCredits = value
            End If
        End Set
    End Property

    Public Sub AddCredits(newCredits As Integer)
        CurrCredits += newCredits
    End Sub
    Public Sub AddCredits()
        CurrCredits += 3
    End Sub

    Public Sub ResetCredits()
        TotCredits += CurrCredits
        CurrCredits = 0
    End Sub

End Class
