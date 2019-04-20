Public Class Form1
    Dim myEmployee As New Employee("", 0)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Width = 265
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim name As String
        Dim salary As Integer

        If txtName.Text <> "" Then
            If Integer.TryParse(txtSalary.Text, salary) Then
                name = txtName.Text
                myEmployee = New Employee(name, salary)
                DisplayChanges()
                Width = 600
            End If
        Else
            MessageBox.Show("Please enter the employee's name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnRaise_Click(sender As Object, e As EventArgs) Handles btnRaise.Click
        myEmployee.RaisePay()
        DisplayChanges()
    End Sub

    Public Sub DisplayChanges()
        grpInfo.Text = String.Format("          {0}'s Information", myEmployee.EmployeeName())
        lblSalary.Text = String.Format("Monthly Salary: {0:C}{1}Annual Salary: {2:C}", myEmployee.MonthlySalary(), vbCrLf, myEmployee.AnnualSalary())
    End Sub
End Class