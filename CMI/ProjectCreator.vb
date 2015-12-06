Imports System.IO
Imports System.Text

Public Class ProjectCreator
    Private Sub ProjectCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create project directories
        IO.Directory.CreateDirectory("C:\Craftbyte Mod IDE\Projects\" & CreateProject.PrjName & "\")

        ' Create Project info files
        Writer()
    End Sub

    Private Async Sub Writer()

        Dim prjPath As String = "C:\Craftbyte Mod IDE\Projects\" & CreateProject.PrjName & "\"

        Dim sb As StringBuilder = New StringBuilder()
        sb.AppendLine("CMI Project solution file")
        sb.AppendLine("-CreatedOn:" & TimeOfDay)
        sb.AppendLine("PrjName:" & CreateProject.PrjName)
        sb.AppendLine("ModName:" & CreateProject.ModName)
        sb.AppendLine("DevelopForMCVer:" & CreateProject.DevelopForMCVer & "  # 1 means for 1.7.10 and 2 means for 1.8")

        Using outfile As StreamWriter = New StreamWriter(prjPath + "\" & CreateProject.ModName & ".cps", True)
            Await outfile.WriteAsync(sb.ToString())
        End Using


    End Sub
End Class