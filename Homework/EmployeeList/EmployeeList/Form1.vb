Option Strict On ' *** Victor Velasco ***

Public Class Form1
    Dim employees As New List(Of Employee) From {
        New Employee("Tom Thompson", 1100),
        New Employee("Pete Peterson", 1188),
        New Employee("Georgia Kennedy", 1320),
        New Employee("Meredith Jones", 1795),
        New Employee("Jean Cummings", 1716),
        New Employee("Michael Robbins", 1200),
        New Employee("Polly Marks", 1520)
        }
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshView()
    End Sub

    Private Sub RefreshView()
        lblEmployeeNum.Text = employees.Count.ToString()
        lblSalary.Text = GetAnnual().ToString("c")
        dgvEmployeeList.DataSource = Nothing
        dgvEmployeeList.DataSource = employees
    End Sub

    Private Sub btnRaise_Click(sender As Object, e As EventArgs) Handles btnRaise.Click
        For Each employee In employees
            employee.RaisePay()
        Next

        RefreshView()

    End Sub

    Private Function GetAnnual() As Integer
        Dim sum As Integer

        For Each employee In employees
            sum += employee.AnnualSalary
        Next

        Return sum

    End Function
End Class
