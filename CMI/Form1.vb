Public Class Form1
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub NewProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProjectToolStripMenuItem.Click
        If RichTextBox1.Text.Length > 5 Then
            If MessageBox.Show("Are you sure you want to create a new Project without saving your current file/project?", "Save before creating new Project?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                ' todo
            Else

            End If
        End If
    End Sub
End Class
