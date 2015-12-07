Imports System.IO

Public Class OpenProject
    Public DevelopForMCVer As String
    Public PrjName As String
    Public ModName As String
    Private Sub OpenProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadProjectInfoFile()

    End Sub

    Function ReadLineOfFiles(filePath As String, ByVal lineNumber As Integer) As String
        Using file As New StreamReader(filePath)
            ' skip all lines we dont want to read
            For i As Integer = 1 To lineNumber - 1
                If file.ReadLine() Is Nothing Then
                    Throw New ArgumentOutOfRangeException("lineNumber")
                End If
            Next
            ' read the line that we want to read
            Dim line As String = file.ReadLine()
            If line Is Nothing Then
                Throw New ArgumentOutOfRangeException("lineNumber")
            End If

            Return line
        End Using
    End Function

    Private Sub bgw1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgw1.DoWork

    End Sub

    Sub ChangeLblText(ByVal lbl As Label, text As String) 'If you change the Label text in the backgroundworker thread, you will get an error, this is why i do this :)
        lbl.Text = text
    End Sub

    Private Sub ReadProjectInfoFile()
        DevelopForMCVer = ReadLineOfFiles(WelcomeForm.cpsFileLoc, 5)
        PrjName = ReadLineOfFiles(WelcomeForm.cpsFileLoc, 3)
        ModName = ReadLineOfFiles(WelcomeForm.cpsFileLoc, 4)

        If PrjName & ModName & DevelopForMCVer.ToString IsNot Nothing Then 'If Project Name, Mod Name and DevelopForMCVer is loaded then do next step
            ChangeLblText(Label2, "Loading other files...")
            ReadOtherFiles()

        Else

        End If

    End Sub

    Private Sub ReadOtherFiles()

    End Sub
End Class