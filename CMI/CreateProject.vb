Public Class CreateProject
    Public DevelopForMCVer As Integer = 0
    Public ModName As String
    Public PrjName As String

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then ' Check if the User wants to select an Mod name later
            TextBox2.Enabled = False
        Else
            TextBox2.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Length < 3 Or TextBox2.Text.Length < 3 Then

            MessageBox.Show("The Project Name/Mod Name Textbox can't be empty or be under 3 letters!", "Project/Mod Name too short!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else


            If RadioButton1.Checked = True Then
                DevelopForMCVer = 1
            ElseIf RadioButton2.Checked = True Then
                DevelopForMCVer = 2
            End If


            ModName = TextBox2.Text
            PrjName = TextBox1.Text

            CreateProject()
        End If











    End Sub

    Private Sub CreateProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub CreateProject()
        ProjectCreator.ShowDialog()
    End Sub
End Class