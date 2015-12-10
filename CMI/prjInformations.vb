Imports System.IO

Public Class prjInformations
    Private Sub prjInformations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prjNameLbl1.Text = Form1.CurrentPrjName
        modNameLbl1.Text = Form1.CurrentModName

        prjNameLbl2.Text = "Project Name: " & Form1.CurrentPrjName
        modNameLbl2.Text = "Mod Name: " & Form1.CurrentModName
        prjDirName1.Text = "Project Directory: " & Form1.CurrentPrjDir
        prjSolFileNameLbl1.Text = "Project Solution File: " & Form1.CurrentPrjDir & Form1.CurrentModName & ".cps"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub


End Class