Public Class Form1
    Dim students(9) As Student
    Dim stu As New Student("Biff", "Arfus", 34)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        students(0) = New Student("Larry", "Limbo")
        students(1) = New Student("Becky", "Blue", 21)
        students(2) = New Student("Simon", "Smith", 15)
        students(3) = New Student("Fanny", "Fargo")
        students(4) = New Student("Pete", "Smith", 9)
        students(5) = New Student("Bill", "Bailey")
        students(6) = New Student("John", "Long")
        students(7) = New Student("Van", "Hill", 36)
        students(8) = New Student("Cindy", "Jones")
        students(9) = New Student("Marcy", "Michaels", 18)

        dgvStudents.DataSource = students

        DisplayStudent()
    End Sub

    Private Sub DisplayStudent()
        lblStudentName.Text = stu.StudentFullName
        lblCurrentCredits.Text = stu.CurrCredits
        lblTotalCredits.Text = stu.TotCredits
    End Sub

    Private Sub btnAddCredit_Click(sender As Object, e As EventArgs) Handles btnAddCredit.Click
        stu.AddCredits(1)
        DisplayStudent()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        stu.ResetCredits()
        DisplayStudent()
    End Sub

    Private Sub btnAdd3_Click(sender As Object, e As EventArgs) Handles btnAdd3.Click
        stu.AddCredits()
        DisplayStudent()
    End Sub
End Class
