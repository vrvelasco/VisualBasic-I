Public Class Form1
    Dim students As New List(Of Student) From {
        New Student("Larry", "Limbo"),
        New Student("Becky", "Blue", 21),
        New Student("Simon", "Smith", 15),
        New Student("Fanny", "Fargo"),
        New Student("Pete", "Smith", 9),
        New Student("Bill", "Bailey"),
        New Student("John", "Long"),
        New Student("Van", "Hill", 36),
        New Student("Cindy", "Jones"),
        New Student("Marcy", "Michaels", 18)
        }
    Dim s As Integer = 0 ' Current students index
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayStudent()
    End Sub

    Private Sub DisplayStudent()
        lblStudentName.Text = students(s).StudentFullName
        lblCurrentCredits.Text = students(s).CurrCredits
        lblTotalCredits.Text = students(s).TotCredits
        dgvStudents.DataSource = Nothing
        dgvStudents.DataSource = students
    End Sub

    Private Sub btnAddCredit_Click(sender As Object, e As EventArgs) Handles btnAddCredit.Click
        students(s).AddCredits(1)
        DisplayStudent()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        students(s).ResetCredits()
        DisplayStudent()
    End Sub

    Private Sub btnAdd3_Click(sender As Object, e As EventArgs) Handles btnAdd3.Click
        students(s).AddCredits()
        DisplayStudent()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        s = students.Count - 1
        DisplayStudent()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        s = 0
        DisplayStudent()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If s > 0 Then
            s -= 1
            DisplayStudent()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If s < students.Count - 1 Then
            s += 1
            DisplayStudent()
        End If
    End Sub

    Private Sub btnAdd3All_Click(sender As Object, e As EventArgs) Handles btnAdd3All.Click
        For Each stu In students
            stu.AddCredits()
        Next
        DisplayStudent()
    End Sub

    Private Sub btnResetAll_Click(sender As Object, e As EventArgs) Handles btnResetAll.Click
        For Each stu In students
            stu.ResetCredits()
        Next
        DisplayStudent()
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        s = students.Count - 1 ' Go to new student added
        Dim newFirst As String = InputBox("First Name:")
        Dim newLast As String = InputBox("Last Name:")
        students.Add(New Student() With {.StudentFirstName = newFirst, .StudentLastName = newLast}) ' If no constructor was provided
        DisplayStudent()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        students.RemoveAt(s)
        DisplayStudent()
    End Sub
End Class
