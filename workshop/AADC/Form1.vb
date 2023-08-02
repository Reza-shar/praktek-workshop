Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox2.Image = New Bitmap(PictureBox1.Image)
            Dim pic As New Bitmap(PictureBox1.Image)

            'set max trackbar
            TrackBar1.Maximum = MathF.Max(1, pic.Width - 1)
            TrackBar2.Maximum = MathF.Max(1, pic.Width - 1)
            TrackBar3.Maximum = MathF.Max(1, pic.Width - 1)
            TrackBar4.Maximum = MathF.Max(1, pic.Width - 1)
        End If

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        TextBox1.Text = TrackBar1.Value

        'minimumkan semua trackbar
        TrackBar2.Minimum = TrackBar1.Value + 1
        TextBox2.Text = TrackBar1.Value

        TrackBar3.Minimum = TrackBar1.Value + 1
        TextBox3.Text = TrackBar3.Value

        TrackBar4.Minimum = TrackBar1.Value + 1
        TextBox4.Text = TrackBar4.Value


    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        TextBox2.Text = TrackBar2.Value

        'minimumkan semua trackbar
        TrackBar3.Minimum = TrackBar2.Value + 1
        TextBox3.Text = TrackBar2.Value

        TrackBar4.Minimum = TrackBar2.Value + 1
        TextBox4.Text = TrackBar2.Value

    End Sub

    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.Scroll
        TextBox3.Text = TrackBar3.Value


        TrackBar4.Minimum = TrackBar3.Value + 1
        TextBox4.Text = TrackBar4.Value


    End Sub

    Private Sub TrackBar4_Scroll(sender As Object, e As EventArgs) Handles TrackBar4.Scroll
        TextBox4.Text = TrackBar4.Value
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r, g, b As Integer
        Dim picSource As New Bitmap(PictureBox1.Image)
        Dim picDest = picSource
        PictureBox2.Image = picDest

        For i = 1 To picSource.Width - 1
            For j = 1 To picSource.Height - 1
                r = picSource.GetPixel(i, j).R
                g = picSource.GetPixel(i, j).G
                b = picSource.GetPixel(i, j).B

                If i < TrackBar1.Value Then
                    picDest.SetPixel(i, j, Color.FromArgb(r, g, 0))

                ElseIf i < TrackBar2.Value Then
                    picDest.SetPixel(i, j, Color.FromArgb(r, 0, 0))

                ElseIf i < TrackBar3.Value Then
                    picDest.SetPixel(i, j, Color.FromArgb(r, 0, b))

                ElseIf i < TrackBar4.Value Then
                    picDest.SetPixel(i, j, Color.FromArgb(0, g, b))

                Else
                    Dim gray As Integer = CInt((r + g + b) / 3)
                    picDest.SetPixel(i, j, Color.FromArgb(gray, gray, gray))
                End If

            Next
        Next

    End Sub

End Class
