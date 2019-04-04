Option Strict On ' *** Victor Velasco ***

Public Class Form1
    Dim names(-1), phones(-1) As String ' Array that will hold info

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtName.Text = "" Or txtPhone.Text = "" Then
            NotifyUser("Please enter a name and phone number.", "err")
        Else
            ' Adds one to both arrays
            ReDim Preserve names(names.Length)
            ReDim Preserve phones(phones.Length)

            ' Add entry to array
            names(names.Length - 1) = txtName.Text
            phones(phones.Length - 1) = txtPhone.Text

            ' Clear the TextBoxes and return focus
            txtName.Clear()
            txtPhone.Clear()
            txtName.Focus()
            PhoneBookEntries() ' NotifyUser("Added successfully!", "info")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close() ' Closes form
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim userSearch As String
        Dim flag As Boolean = False

        ' Get user input
        userSearch = InputBox("Enter a partial or full name to search for.")

        ' Loop through array
        For i = 0 To names.Length - 1
            If names(i).ToUpper().Contains(userSearch.ToUpper()) Then ' Does it match?
                NotifyUser(String.Format("{0} {1}", names(i), phones(i)), "info") ' MessageBox to user
                flag = True
                Exit For ' Only need the first occurance
            End If
        Next

        If flag = False Then NotifyUser("Name not found.", "info") ' Not found
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim msgReturn As Integer ' Holds the return value of the MessageBox

        ' Confirm with the user
        msgReturn = MessageBox.Show("Are you sure you want to erase EVERYTHING?" & vbCrLf & vbCrLf & "This action cannot be undone.", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If msgReturn = DialogResult.Yes Then ' Delete entries?
            ' Clears the arrays
            ReDim names(-1)
            ReDim phones(-1)

            ' Clear out the rest of the form too
            txtName.Clear()
            txtPhone.Clear()
            txtSearch.Clear()
            lstOutput.Items.Clear()
            chkCase.Checked = False
            PhoneBookEntries()

            ' Notify user that it was done
            NotifyUser("Everything has been erased.", "info")
        Else
            ' The user did not want to clear 
            NotifyUser("Nothing was erased.", "info")
            PhoneBookEntries()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = String.Empty Then ' Empty field?
            lstOutput.Items.Clear() ' Search TextBox is empty
        Else
            lstOutput.Items.Clear() ' We need to clear the previous results

            If chkCase.Checked Then ' Case-Sensitive
                ' Loop through array
                For i = 0 To names.Length - 1
                    If names(i).Contains(txtSearch.Text) Then ' Does it match?
                        lstOutput.Items.Add(String.Format("{0} {1}", names(i).PadRight(20), phones(i))) ' Add to ListBox
                    End If
                Next
            Else ' Case-Insensitive
                ' Loop through array
                For i = 0 To names.Length - 1
                    If names(i).ToUpper().Contains(txtSearch.Text.ToUpper()) Then ' Does it match?
                        lstOutput.Items.Add(String.Format("{0} {1}", names(i).PadRight(20), phones(i))) ' Add to ListBox
                    End If
                Next
            End If
        End If
    End Sub

    Sub NotifyUser(msg As String, icon As String) 'Handles MessageBox
        Select Case icon
            Case "err"
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case "info"
                MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PhoneBookEntries()
    End Sub

    Sub PhoneBookEntries()
        lblItems.Text = "# of Entries: " & names.Count()
    End Sub
End Class
