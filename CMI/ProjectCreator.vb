Imports System.IO
Imports System.Text

Public Class ProjectCreator
    Public newProject = True
    Private Sub ProjectCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create project directories
        IO.Directory.CreateDirectory("C:\Craftbyte Mod IDE\Projects\" & CreateProject.PrjName & "\")

        ' Create Project info files
        PrjSolutionFileWriter() ' This needs to be changed.
    End Sub

    Private Async Sub PrjSolutionFileWriter(ByVal time As String, ByVal prjName As String, ByVal modName As String, ByVal mcVer As Integer)

        Dim prjPath As String = "C:\Craftbyte Mod IDE\Projects\" & CreateProject.PrjName & "\"

        Dim sb As StringBuilder = New StringBuilder()
        sb.AppendLine("CMI Project solution file")
        sb.AppendLine("-CreatedOn: " & time)
        sb.AppendLine(prjName)
        sb.AppendLine(modName)
        sb.AppendLine("DevelopForMCVer: " & mcVer & "  # 1 means for 1.7.10 and 2 means for 1.8")

        Using outfile As StreamWriter = New StreamWriter(prjPath + "\" & CreateProject.ModName & ".cps", True)
            Await outfile.WriteAsync(sb.ToString())
        End Using

        CreateDirectories()
    End Sub

    Private Sub CreateDirectories()
        Dim path As String = "C:\Craftbyte Mod IDE\Projects\" & CreateProject.PrjName & "\"
        IO.Directory.CreateDirectory(path & "Files")
        IO.Directory.CreateDirectory(path & "Mod")
        IO.Directory.CreateDirectory(path & "Workspace")

        Me.Close()

        Form1.Show()
    End Sub

End Class
