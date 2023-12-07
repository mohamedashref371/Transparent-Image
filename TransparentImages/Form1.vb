Public Class Form1
    Dim hm As String = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData.Replace("0.0.0.0", "")
    Dim rd1 As New Random
    Dim img1, back1, img2, back2, pic, temp As Bitmap
    Dim file As String
    Dim listOfFiles As New List(Of String)
    Dim aaaa As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(hm + "lang") Then Lg2(sender, e)

        If rd1.Next(0, 2) = 1 Then
            Label1.BackColor = Color.Lime : Label3.BackColor = Color.Lime
            Label6.BackColor = Color.Yellow : Label7.BackColor = Color.Yellow
        End If

        If My.Computer.FileSystem.FileExists(hm + "ab") Then T2.Stop()
        Lwh_Click(Nothing, Nothing)
        imageFormat.SelectedIndex = 0
    End Sub

    Private Sub Pg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles x0.KeyPress, y0.KeyPress, redDecimal2.KeyPress, greenDecimal2.KeyPress, blueDecimal2.KeyPress, redDecimal4.KeyPress, greenDecimal4.KeyPress, blueDecimal4.KeyPress
        If e.KeyChar = "0" Or e.KeyChar = "1" Or e.KeyChar = "2" Or e.KeyChar = "3" Or e.KeyChar = "4" Or e.KeyChar = "5" Or e.KeyChar = "6" Or e.KeyChar = "7" Or e.KeyChar = "8" Or e.KeyChar = "9" Or e.KeyChar = "" Then
            Exit Sub
        Else
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Pg2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles redHexadecimal2.KeyPress, greenHexadecimal2.KeyPress, blueHexadecimal2.KeyPress, redHexadecimal4.KeyPress, greenHexadecimal4.KeyPress, blueHexadecimal4.KeyPress
        If e.KeyChar = "0" Or e.KeyChar = "1" Or e.KeyChar = "2" Or e.KeyChar = "3" Or e.KeyChar = "4" Or e.KeyChar = "5" Or e.KeyChar = "6" Or e.KeyChar = "7" Or e.KeyChar = "8" Or e.KeyChar = "9" Or e.KeyChar = "a" Or e.KeyChar = "b" Or e.KeyChar = "c" Or e.KeyChar = "d" Or e.KeyChar = "e" Or e.KeyChar = "f" Or e.KeyChar = "A" Or e.KeyChar = "B" Or e.KeyChar = "C" Or e.KeyChar = "D" Or e.KeyChar = "E" Or e.KeyChar = "F" Or e.KeyChar = "" Then
            Exit Sub
        Else
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Folder_Click(sender As Object, e As EventArgs) Handles folder.Click
        listOfFiles.Clear()
        If FBD.ShowDialog = DialogResult.OK Then listOfFiles = My.Computer.FileSystem.GetFiles(FBD.SelectedPath).ToList()
    End Sub

    Private Sub Lg2(sender As Object, e As EventArgs) Handles language.Click
        If language.Text = "English" Then
            language.Text = "عربي"
            My.Computer.FileSystem.WriteAllText(hm + "lang", "1", False)

        ElseIf language.Text = "عربي" Then
            language.Text = "English"
            Kill(hm + "lang")

        End If
    End Sub

    Private Sub Lwh_Click(sender As Object, e As EventArgs) Handles help.Click
        If loadImage1.Enabled = True Then

            redDecimal2.Text = rd1.Next(0, 256)
            greenDecimal2.Text = rd1.Next(0, 256)
            blueDecimal2.Text = rd1.Next(0, 256)
            Dim Bb5 As New Bitmap(256, 256)
            Dim G5 As Graphics = Graphics.FromImage(Bb5)
            G5.Clear(Color.FromArgb(redDecimal2.Text, greenDecimal2.Text, blueDecimal2.Text))
            G5.DrawImage(My.Resources.zx0, 0, 0)
            image1.BackgroundImage = Bb5
            img1 = Bb5

            redDecimal4.Text = rd1.Next(0, 256)
            greenDecimal4.Text = rd1.Next(0, 256)
            blueDecimal4.Text = rd1.Next(0, 256)
            Bb5 = New Bitmap(256, 256)
            G5 = Graphics.FromImage(Bb5)
            G5.Clear(Color.FromArgb(redDecimal4.Text, greenDecimal4.Text, blueDecimal4.Text))
            G5.DrawImage(My.Resources.zx0, 0, 0)
            image2.BackgroundImage = Bb5
            img2 = Bb5

            Bb5 = New Bitmap(256, 256)
            G5 = Graphics.FromImage(Bb5)
            G5.DrawImage(My.Resources.trpt2, 0, 0)
            G5.DrawImage(My.Resources.zx0, 0, 0)
            finalImage.BackgroundImage = Bb5
            pic = My.Resources.zx0

            y0.Text = "0"
            x0.Text = "0"
        End If
    End Sub

    Private Sub VSB_Scroll(sender As Object, e As ScrollEventArgs) Handles VSB.Scroll
        image1.Top = VSB.Value * (150 - image1.Height) / 90
        background1.Top = VSB.Value * (150 - background1.Height) / 90
        image2.Top = VSB.Value * (150 - image2.Height) / 90
        background2.Top = VSB.Value * (150 - background2.Height) / 90
        finalImage.Top = VSB.Value * (150 - finalImage.Height) / 90
    End Sub

    Private Sub HSB_Scroll(sender As Object, e As ScrollEventArgs) Handles HSB.Scroll
        image1.Left = HSB.Value * (150 - image1.Width) / 90
        background1.Left = HSB.Value * (150 - background1.Width) / 90
        image2.Left = HSB.Value * (150 - image2.Width) / 90
        background2.Left = HSB.Value * (150 - background2.Width) / 90
        finalImage.Left = HSB.Value * (150 - finalImage.Width) / 90
    End Sub

    Private Sub Lbl_Click(sender As Object, e As EventArgs) Handles about.Click
        T2.Stop()
        Html2.Show()
        My.Computer.FileSystem.WriteAllText(hm + "ab", "1", False)
    End Sub

    Private Sub Sg_Click(sender As Object, e As EventArgs) Handles seagaegy.Click
        Process.Start("http://www.mediafire.com/file/0wv97m4n96q5y0v")
    End Sub

    Private Sub Sv_Click(sender As Object, e As EventArgs) Handles save.Click
        If imageFormat.SelectedIndex = 1 Then
            SFD.Filter = "ICON Files|*.ico"
        Else
            SFD.Filter = "PNG Files|*.png"
        End If

        If SFD.ShowDialog() = DialogResult.OK Then
            If imageFormat.SelectedIndex = 1 Then
                pic.Save(SFD.FileName, Imaging.ImageFormat.Icon)
            Else
                pic.Save(SFD.FileName, Imaging.ImageFormat.Png)
            End If
        End If
    End Sub

    Private Sub LocationZero(sender As Object, e As EventArgs)
        VSB.Value = 0 : HSB.Value = 0
        image1.Location = New Point(0, 0) : background1.Location = New Point(0, 0) : image2.Location = New Point(0, 0) : background2.Location = New Point(0, 0) : finalImage.Location = New Point(0, 0)
    End Sub

    Private Sub LoadImage1_Click(sender As Object, e As EventArgs) Handles loadImage1.Click
        Try
            If OFD.ShowDialog() = DialogResult.OK Then
                temp = Image.FromFile(OFD.FileName)
                If temp.Width >= 16 And temp.Height >= 16 Then
                    img1 = temp
                    image1.BackgroundImage = img1
                    image1.Width = img1.Width : image1.Height = img1.Height
                    LocationZero(sender, e)
                    If img2 IsNot Nothing AndAlso (img2.Width < img1.Width OrElse img2.Height < img1.Height) Then
                        image2.BackgroundImage = Nothing
                    End If
                    x0.Text = "0" : y0.Text = "0"
                    xMax.Text = img1.Width : yMax.Text = img1.Height
                Else
                    MsgBox("غير مسموح بصورة أقل من 16*16")
                End If
            End If
        Catch
            MsgBox("حدث خطأ")
        End Try
    End Sub

    Private Sub LoadBackground1_Click(sender As Object, e As EventArgs) Handles loadBackground1.Click
        Try
            If OFD.ShowDialog() = DialogResult.OK Then
                temp = Image.FromFile(OFD.FileName)
                If temp.Width >= 16 AndAlso temp.Height >= 16 Then
                    If temp.Width < img1.Width OrElse temp.Height < img1.Height Then
                        MsgBox("الصورة أصغر من الصورة الرئيسية")
                    Else
                        back1 = temp
                        background1.BackColor = Nothing
                        background1.BackgroundImage = back1
                        background1.Width = back1.Width : background1.Height = back1.Height
                        LocationZero(sender, e)
                    End If
                Else
                    MsgBox("غير مسموح بصورة أقل من 16*16")
                End If
            End If
        Catch
            MsgBox("حدث خطأ")
        End Try
    End Sub

    Private Sub LoadImage2_Click(sender As Object, e As EventArgs) Handles loadImage2.Click
        Try
            If OFD.ShowDialog() = DialogResult.OK Then
                temp = Image.FromFile(OFD.FileName)
                If temp.Width >= 16 AndAlso temp.Height >= 16 Then
                    If temp.Width < img1.Width OrElse temp.Height < img1.Height Then
                        MsgBox("الصورة أصغر من الصورة الرئيسية")
                    Else
                        img2 = temp
                        image2.BackgroundImage = img2
                        image2.Width = img2.Width : image2.Height = img2.Height
                        LocationZero(sender, e)
                    End If
                Else
                    MsgBox("غير مسموح بصورة أقل من 16*16")
                End If
            End If
        Catch
            MsgBox("حدث خطأ")
        End Try
    End Sub

    Private Sub LoadBackground2_Click(sender As Object, e As EventArgs) Handles loadBackground2.Click
        Try
            If OFD.ShowDialog() = DialogResult.OK Then
                temp = Image.FromFile(OFD.FileName)
                If temp.Width >= 16 And temp.Height >= 16 Then
                    If temp.Width < img1.Width Or temp.Height < img1.Height Then
                        MsgBox("الصورة أصغر من الصورة الرئيسية")
                    Else
                        back2 = temp
                        background2.BackColor = Nothing
                        background2.BackgroundImage = back2
                        background2.Width = back2.Width : background2.Height = back2.Height
                        LocationZero(sender, e)
                    End If
                Else
                    MsgBox("غير مسموح بصورة أقل من 16*16")
                End If
            End If
        Catch
            MsgBox("حدث خطأ")
        End Try
    End Sub

    Private Sub T2_Tick(sender As Object, e As EventArgs) Handles T2.Tick
        If about.ForeColor = Color.Black Then
            T2.Interval = 150
            about.ForeColor = Color.Red
        ElseIf about.ForeColor = Color.Red Then
            about.ForeColor = Color.Orange
        ElseIf about.ForeColor = Color.Orange Then
            about.ForeColor = Color.Yellow
        ElseIf about.ForeColor = Color.Yellow Then
            about.ForeColor = Color.Green
        ElseIf about.ForeColor = Color.Green Then
            about.ForeColor = Color.Cyan
        ElseIf about.ForeColor = Color.Cyan Then
            about.ForeColor = Color.Blue
        ElseIf about.ForeColor = Color.Blue Then
            about.ForeColor = Color.Purple
        ElseIf about.ForeColor = Color.Purple Then
            about.ForeColor = Color.Magenta
        ElseIf about.ForeColor = Color.Magenta Then
            T2.Interval = 4321
            about.ForeColor = Color.Black
        End If
    End Sub
End Class
