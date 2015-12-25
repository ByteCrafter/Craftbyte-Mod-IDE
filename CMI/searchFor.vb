Public Class searchFor
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Form1.RichTextBox1.Text.Contains(TextBox1.Text) Then
            Form1.RichTextBox1.Select(TextBox1.Text.Length, TextBox1.Text.Length)
        End If

    End Sub
End Class