Public Class IOClass
#Region "Directory region"
    Public Class DirWriter ' I am also too lazy to use IO xD
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dir">The directory where the new directory should be created in</param>
        ''' <param name="directoryName">The directory name of the dir that should be created</param>
        Public Sub CreateDir(dir As String, directoryName As String)
            IO.Directory.CreateDirectory(dir & directoryName)
        End Sub
    End Class
#End Region
#Region "File region"
    Public Class FileWriter ' I created this because i am too lazy to do the same thing again and again xD
        ''' <summary>
        ''' Creates an file with text in it
        ''' </summary>
        ''' <param name="dir">The directory where the file should be created</param>
        ''' <param name="filename">The filename with the file extension</param>
        ''' <param name="content">The content that should be written in the file</param>
        Public Sub CreateFile(dir As String, filename As String, content As String)
            Try
                IO.File.Create(dir & filename)
                If IO.File.Exists(dir & filename) Then
                    IO.File.WriteAllText(dir & filename, content)
                End If
            Catch ex As Exception

            End Try
        End Sub
    End Class
#End Region
End Class