Public Class NewDesignMainFrm
    Dim GripDrag As Boolean
    Dim InitialSizeX As Integer
    Dim InitialSizeY As Integer

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If MessageBox.Show("Are you sure you want to revert to the old design? If you work on an project, all unsaved changes will be gone.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MessageBox.Show("Craftbyte Mod IDE will now revert to the old design. All changes will be gone if you have unsaved changes.", "Reverting to old design", MessageBoxButtons.OK, MessageBoxIcon.None)

        End If
    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then '
            GripDrag = True
            InitialSizeX = Me.Width
            InitialSizeY = Me.Height
        End If
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        If GripDrag = True Then
            Me.Width = InitialSizeX + (Windows.Forms.Cursor.Position.X - (Me.Width + Me.Location.X))
            Me.Height = InitialSizeY + (Windows.Forms.Cursor.Position.Y - (Me.Height + Me.Location.Y)) '

            InitialSizeX = Me.Width
            InitialSizeY = Me.Height

            Me.Refresh()
        End If

    End Sub

    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp
        GripDrag = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
            Button3.Text = "V"
        Else
            Me.WindowState = FormWindowState.Normal
            Button3.Text = "^"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class