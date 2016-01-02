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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CreateProject.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Filter = "Craftbyte Project Solution (*.cps)|*.cps"
            .InitialDirectory = "C:\Craftbyte Mod IDE\Projects\"
            .Title = "Open a Project"
        End With
        If ofd.ShowDialog() = DialogResult.OK Then
            cpsFileLoc = ofd.FileName
            OpenProject.ShowDialog()
        End If



    End Sub

    Private Sub WelcomeForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If MessageBox.Show("This release is currently very broken due to an Visual Studio error. By clicking 'Yes' you acknowledge that ALL functions are currently in a very early Alpha state and that ALL features and functions might not work! This is an Preview-Prealpha release! You can't compile or make Mods currently!!", "Craftbyte Mod IDE", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

        Else
            Application.Exit()

        End If
        If My.Settings.firstStart = False Then
            Me.Hide()
            firstStartSetup.Show()
        Else

        End If
    End Sub

    Private Sub WelcomeForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MoreOptions.ShowDialog()
    End Sub
End Class