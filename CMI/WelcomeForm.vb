Imports System.IO
Public Class WelcomeForm
    Private Sub WelcomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each folder As String In Directory.GetDirectories("C:\Craftbyte Mod IDE\Projects\")
            ListBox1.Items.Add(Path.GetFileName(folder))
        Next
    End Sub
End Class