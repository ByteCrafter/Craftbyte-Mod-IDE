Imports System.ComponentModel
Imports System.IO
Imports System.Text

Public Class Form1
    Public CurrentPrjName As String
    Public CurrentModName As String
    Public CurrentCpsFileLoc As String


    Private Sub NewProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProjectToolStripMenuItem.Click
        If RichTextBox1.Text.Length > 10 Then
            If MessageBox.Show("Are you sure you want to create a new Project without saving your current file/project?", "Save before creating new Project?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                CreateProject.ShowDialog()
                Me.Close()

            Else

            End If
        End If
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Craftbyte Mod IDE - Initializing"

        Label2.Text = ""
        Label5.Text = ""


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






        Label3.Text = "New file"


    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        Dim opf As New OpenFileDialog
        If opf.ShowDialog = DialogResult.OK Then
            Using sr As New System.IO.StreamReader(opf.FileName)
                RichTextBox1.Text = sr.ReadToEnd()
            End Using
        End If

    End Sub

    Private Sub InitIDE()

    End Sub

    Private Sub SaveFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveFileToolStripMenuItem.Click
        Dim sfd As New SaveFileDialog
        If sfd.ShowDialog = DialogResult.OK Then
            NewFileWriter(sfd.FileName)
            Dim fi As New IO.FileInfo(sfd.FileName)
            Label3.Text = (fi.Name + ".java")
        End If
    End Sub

    Private Async Sub NewFileWriter(filename As String)
        Try
            Dim sb As StringBuilder = New StringBuilder()
            sb.Append(RichTextBox1.Text)

            Using outfile As StreamWriter = New StreamWriter(filename + ".java", True)
                Await outfile.WriteAsync(sb.ToString())
            End Using

            MessageBox.Show("Save successfully saved!", "File saved!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occured. Error: " & ex.Message & " - Please contact the developer for help and informations!", "An error occured while saving an file!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NewFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewFileToolStripMenuItem.Click
        Dim newFileMainFrmIDEWindow As New Form1
        newFileMainFrmIDEWindow.Text = "Craftbyte Mod IDE - " & " - New File"
        newFileMainFrmIDEWindow.Show()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
        End
    End Sub

    Private Sub ProjectInformationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectInformationsToolStripMenuItem.Click
        MessageBox.Show("Currently not available!", "Craftbyte Mod IDE", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub DeselectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeselectAllToolStripMenuItem.Click
        RichTextBox1.DeselectAll()
    End Sub

    Private Sub SearchForToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchForToolStripMenuItem.Click

    End Sub

    Private Sub LoadProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadProjectToolStripMenuItem.Click
        MessageBox.Show("This function got broken by Visual Studio, so you can currently not use this! Sorry! :(", "Function currently broken", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    Private Sub ReportAnBugToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportAnBugToolStripMenuItem.Click
        MessageBox.Show("Report an Bug to the official Craftbyte Mod IDE GitHub Repo or the official Minecraft Forum thread!", "Report an Bug", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Craftbyte Mod IDE -- Version PREVIEW-002-0.0.0.1prealpha" & Environment.NewLine & "(C)2016 Craftbyte Developments" & Environment.NewLine & "")
    End Sub

    Private Sub ProjectSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectSettingsToolStripMenuItem.Click

    End Sub
End Class
