Public Class Employee

    Private _employeeName As String
    Private _monthlySalary As Integer

    Public Sub New(name As String, salary As Integer)
        _employeeName = name
        _monthlySalary = salary
    End Sub

    Public Property EmployeeName() As String
        Get
            Return _employeeName
        End Get
        Set(ByVal value As String)
            _employeeName = value
        End Set
    End Property

    Public Property MonthlySalary() As Integer
        Get
            Return _monthlySalary
        End Get
        Set(ByVal value As Integer)
            If value > 0 Then
                _monthlySalary = value
            Else
                _monthlySalary = 0
            End If
        End Set
    End Property

    Public ReadOnly Property AnnualSalary() As Integer
        Get
            Return MonthlySalary * 12
        End Get
    End Property

    Public Sub RaisePay()
        MonthlySalary += MonthlySalary * 0.1
    End Sub

End Class
