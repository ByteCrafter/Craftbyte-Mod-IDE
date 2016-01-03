Imports System.IO
Public Class PrjOpener
    Public CurrentProject As String
    Public CurrentMod As String
    Dim filesList As List(Of String)
    Dim dirList As List(Of String)
    Sub OpenProject(ByVal cpsFilePath As String, ByVal dir As String)
        Dim di As New DirectoryInfo(dir)
        For Each s As String In di.GetDirectories.ToString
            dirList.Add(s) 'Adds all directories in the current dir to an list
        Next

        For Each s_ As String In di.GetFiles.ToString
            filesList.Add(s_) 'Adds all files in the current dir to an list
        Next



    End Sub
End Class
