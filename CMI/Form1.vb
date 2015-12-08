Imports System.ComponentModel
Imports System.IO
Imports System.Text

Public Class Form1
    Public newFile As Boolean
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mainIDEStr.ItemClicked

    End Sub

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
        Me.Text = "Craftbyte Mod IDE - " & CurrentPrjName

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

        Label2.Text = CurrentPrjName
        Label3.Text = "New file"
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ideStatStr1.ItemClicked

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
        newFileMainFrmIDEWindow.Text = "Craftbyte Mod IDE - " & CurrentPrjName & " - New File"
        newFileMainFrmIDEWindow.Show()
    End Sub

    Private Sub SaveProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveProjectToolStripMenuItem.Click

    End Sub

    Public ReadOnly Property CurrentPrjName As String
        Get
            CurrentPrjName = prjNameFileReader()
        End Get
    End Property


    Function prjNameFileReader() As String
        Using filereader As New StreamReader("C:\Craftbyte Mod IDE\Projects\" & CreateProject.PrjName & "\" & CreateProject.ModName & ".cps")
            ' skip all lines we dont want to read
            For i As Integer = 1 To 3 - 1
                If filereader.ReadLine() Is Nothing Then
                    Throw New ArgumentOutOfRangeException("lineNumber")
                End If
            Next
            ' read the line that we want to read
            Dim line As String = filereader.ReadLine()
            If line Is Nothing Then
                Throw New ArgumentOutOfRangeException("lineNumber")
            End If

            Return line
        End Using
    End Function

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
        End
    End Sub
End Class
