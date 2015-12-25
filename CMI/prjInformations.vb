Imports System.IO

Public Class prjInformations
    Private Sub prjInformations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prjNameLbl1.Text = Form1.CurrentPrjName
        modNameLbl1.Text = Form1.CurrentModName

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub


End Class