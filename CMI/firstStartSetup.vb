Public Class firstStartSetup
    Private path As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fbd As New FolderBrowserDialog
        If fbd.ShowDialog = DialogResult.OK Then
            TextBox1.Text = fbd.SelectedPath

            path = fbd.SelectedPath
        Else

        End If
    End Sub

    Private Sub firstStartSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckForJDKFiles()
        Dim checkPath As String = path
        If IO.File.Exists(checkPath & "\" & "javac.exe") Then
            MsgBox("OK!")
        Else
            MsgBox("NOT OK!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Enabled = False
        Button1.Enabled = False
        ProgressBar1.Enabled = True
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.MarqueeAnimationSpeed = 30
        CheckForJDKFiles()
    End Sub
End Class