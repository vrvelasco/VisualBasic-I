Option Strict On ' *** Victor Velasco ***

Public Class Form1

    ' Collection
    Dim packages As New List(Of Package) From {
        New Package("Z111", "Los Angeles", "CA"),
        New Package("Z112", "Collinsville", "IL"),
        New Package("Z113", "Saint Louis", "MO"),
        New Package("Z114", "Creve Coeur", "MO"),
        New Package("Z115", "Edwardsville", "IL"),
        New Package("Z116", "Madison", "WI")
        }

    Dim i As Integer = 0 ' Package index

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshForm()
    End Sub

    Private Sub RefreshForm()
        ' Display info
        txtID.Text = packages(i).PackageID
        txtCity.Text = packages(i).DestinationCity
        txtState.Text = packages(i).DestinationState
        lblNumPackage.Text = String.Format("Package # {0}", i + 1)
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        i = 0
        RefreshForm()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If i > 0 Then
            i -= 1
            RefreshForm()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If i < packages.Count - 1 Then
            i += 1
            RefreshForm()
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        i = packages.Count - 1
        RefreshForm()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Clear ListBox
        lstResults.Items.Clear()

        ' Search Collection
        For Each p In packages
            If p.DestinationState.Equals(txtStateSearch.Text.ToUpper()) Then
                lstResults.Items.Add(p.PackageID)
            End If
        Next
    End Sub

    Private Sub lstResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResults.SelectedIndexChanged
        ' Get selected package info
        For index = 0 To packages.Count - 1
            If packages(index).PackageID.Equals(lstResults.SelectedItem.ToString()) Then
                i = index
            End If

            RefreshForm()
        Next
    End Sub
End Class
