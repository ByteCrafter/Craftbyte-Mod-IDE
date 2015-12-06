Public Class ProjectCreator
    Private Sub ProjectCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bgw1.RunWorkerAsync()
    End Sub

    Private Sub bgw1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgw1.DoWork
        ' Create project directories
        Dim dw As New IOClass.DirWriter
        dw.CreateDir("C:\Craftbyte Mod IDE\Projects\", CreateProject.TextBox1.Text)

        ' Create Project info files
        Dim fw As New IOClass.FileWriter
        fw.CreateFile("C:\Craftbyte Mod IDE\Projects\" & CreateProject.TextBox1.Text & "\", CreateProject.TextBox1.Text & "-cmi-prj.cps", "CMI Project solution file" & Environment.NewLine & "-CreatedOn:" & TimeOfDay & Environment.NewLine & "PrjName:" & CreateProject.TextBox1.Text & Environment.NewLine & "ModName:" & CreateProject.TextBox2.Text & Environment.NewLine & "DevelopForMCVer:" & CreateProject.DevelopForMCVer & "    # 1 means for 1.7.10 and 2 means for 1.8")
    End Sub
End Class