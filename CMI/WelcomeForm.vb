Imports System.ComponentModel
Imports System.IO
Public Class WelcomeForm
    Public cpsFileLoc As String
    Private Sub WelcomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.Directory.Exists("C:\Craftbyte Mod IDE\Projects\") = True Then
            For Each folder As String In Directory.GetDirectories("C:\Craftbyte Mod IDE\Projects\")
                ListBox1.Items.Add(Path.GetFileName(folder))
            Next
        Else
            If IO.Directory.Exists("C:\Craftbyte Mod IDE") = False Then
                IO.Directory.CreateDirectory("C:\Craftbyte Mod IDE")
                IO.Directory.CreateDirectory("C:\Craftbyte Mod IDE\Projects")
            End If
        End If

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CreateProject.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ofd As New OpenFileDialog
        If ofd.ShowDialog = DialogResult.OK Then
            OpenProject.ShowDialog()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MoreOptions.ShowDialog()
    End Sub
End Class