Imports System.IO
Imports System.Text

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Craftbyte Mod IDE - " & CreateProject.PrjName

        ToolStripProgressBar1.Style = ProgressBarStyle.Marquee
        ToolStripStatusLabel1.Text = "Creating files, options and more. You can use all full functions of the IDE after this task has finished!"
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If ProjectCreator.Visible = True Then
            ProjectCreator.Hide()
            ProjectCreator.Visible = False
        End If

        If CreateProject.Visible = True Then
            CreateProject.Hide()
            CreateProject.Visible = False
        End If
        If WelcomeForm.Visible = True Then
            WelcomeForm.Hide()
            WelcomeForm.Visible = False
        End If
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        Dim opf As New OpenFileDialog
        If opf.ShowDialog = DialogResult.OK Then
            Using sr As New System.IO.StreamReader(opf.FileName)
                RichTextBox1.Text = sr.ReadToEnd()
            End Using
        End If



    End Sub

    Private Sub SaveFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveFileToolStripMenuItem.Click
        Dim sfd As New SaveFileDialog
        If sfd.ShowDialog = DialogResult.OK Then
            PrjSolutionFileWriter(sfd.FileName)
        End If
    End Sub

    Private Async Sub PrjSolutionFileWriter(filename As String)

        Dim sb As StringBuilder = New StringBuilder()
        sb.Append(RichTextBox1.Text)

        Using outfile As StreamWriter = New StreamWriter(filename + ".java", True)
            Await outfile.WriteAsync(sb.ToString())
        End Using

    End Sub
End Class
