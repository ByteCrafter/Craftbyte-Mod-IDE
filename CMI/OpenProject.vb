Imports System.IO

Public Class OpenProject
    Public DevelopForMCVer As String
    Public PrjName As String
    Public ModName As String
    Private Sub OpenProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IO.File.ReadAllText(WelcomeForm.cpsFileLoc) 'Reads all informations in the file
        DevelopForMCVer = ReadAnLine(WelcomeForm.cpsFileLoc, 4)
        PrjName = ReadAnLine(WelcomeForm.cpsFileLoc, 2)
        ModName = ReadAnLine(WelcomeForm.cpsFileLoc, 3)

    End Sub

    Function ReadAnLine(filePath As String, ByVal lineNumber As Integer) As String
        Using cpsFile As New StreamReader(filePath)
            ' Skip all other lines
            For i As Integer = 1 To lineNumber - 1

            Next
            ' Read selected line
            Dim line As String = cpsFile.ReadLine()
            Return line
        End Using
    End Function
End Class