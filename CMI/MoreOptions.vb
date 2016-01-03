Public Class MoreOptions
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fbd As New FolderBrowserDialog
        fbd.Description = "Select an Project Folder..."

        If fbd.ShowDialog = DialogResult.OK Then
            If MessageBox.Show("Are you really sure that you want to delete the selected Project? This cannot be undone!", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                IO.Directory.Delete(fbd.SelectedPath)
            Else

            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        MessageBox.Show("Currently not available yet!", "Not available yet!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub MoreOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class