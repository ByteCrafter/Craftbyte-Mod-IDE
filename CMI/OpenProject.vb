Imports System.IO

Public Class OpenProject
    Private Sub OpenProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bgw1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgw1.DoWork

    End Sub

    Sub ChangeLblText(ByVal lbl As Label, text As String) 'If you change the Label text in the backgroundworker thread, you will get an error, this is why i do this :)
        lbl.Text = text
    End Sub
End Class