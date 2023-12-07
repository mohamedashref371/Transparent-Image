Public Class Form1
    Dim hm As String = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData.Replace("0.0.0.0", "")
    Dim rd1 As New Random
    Dim img1, back1, img2, back2, pic, temp As Bitmap
    Dim folderOpen, folderSave, file As String
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

    Private Sub Pg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles x1.KeyPress, y1.KeyPress, redDecimal2.KeyPress, greenDecimal2.KeyPress, blueDecimal2.KeyPress, redDecimal4.KeyPress, greenDecimal4.KeyPress, blueDecimal4.KeyPress
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
        If FBD.ShowDialog = DialogResult.OK Then
            folderOpen = FBD.SelectedPath
            listOfFiles = My.Computer.FileSystem.GetFiles(folderOpen).ToList()
        End If
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

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles start.Click

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
            BackColorFromImage1_Click(Nothing, Nothing)

            redDecimal4.Text = rd1.Next(0, 256)
            greenDecimal4.Text = rd1.Next(0, 256)
            blueDecimal4.Text = rd1.Next(0, 256)
            Bb5 = New Bitmap(256, 256)
            G5 = Graphics.FromImage(Bb5)
            G5.Clear(Color.FromArgb(redDecimal4.Text, greenDecimal4.Text, blueDecimal4.Text))
            G5.DrawImage(My.Resources.zx0, 0, 0)
            image2.BackgroundImage = Bb5
            img2 = Bb5
            BackColorFromImage2_Click(Nothing, Nothing)

            Bb5 = New Bitmap(256, 256)
            G5 = Graphics.FromImage(Bb5)
            G5.DrawImage(My.Resources.trpt2, 0, 0)
            G5.DrawImage(My.Resources.zx0, 0, 0)
            finalImage.BackgroundImage = Bb5
            pic = My.Resources.zx0
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

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles save.Click
        If listOfFiles.Count = 0 Then
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
        Else
            If FBD.ShowDialog = DialogResult.OK Then
                If FBD.SelectedPath = folderOpen Then
                    MsgBox("اختر مجلدا آخر")
                Else
                    folderSave = FBD.SelectedPath
                End If
            End If
        End If
    End Sub

    Private Sub LocationZero(sender As Object, e As EventArgs)
        VSB.Value = 0 : HSB.Value = 0
        image1.Location = New Point(0, 0) : background1.Location = New Point(0, 0) : image2.Location = New Point(0, 0) : background2.Location = New Point(0, 0) : finalImage.Location = New Point(0, 0)
    End Sub

    Private Sub BackColorFromImage1_Click(sender As Object, e As EventArgs) Handles backColorFromImage1.Click
        If x1.Text = "" Then x1.Text = "0"
        If y1.Text = "" Then y1.Text = "0"
        If img1 IsNot Nothing AndAlso x1.Text < img1.Width AndAlso y1.Text < img1.Height Then
            back1 = Nothing
            background1.BackgroundImage = Nothing
            Dim clr As Color = img1.GetPixel(x1.Text, y1.Text)
            redDecimal2.Text = clr.R : greenDecimal2.Text = clr.G : blueDecimal2.Text = clr.B
            background1.BackColor = clr
        End If
    End Sub

    Private Sub BackColorFromImage2_Click(sender As Object, e As EventArgs) Handles backColorFromImage2.Click
        If x1.Text = "" Then x1.Text = "0"
        If y1.Text = "" Then y1.Text = "0"

        If img2 IsNot Nothing AndAlso x1.Text < img2.Width AndAlso y1.Text < img2.Height Then
            back2 = Nothing
            background2.BackgroundImage = Nothing
            Dim clr As Color = img2.GetPixel(x1.Text, y1.Text)
            redDecimal4.Text = clr.R : greenDecimal4.Text = clr.G : blueDecimal4.Text = clr.B
            background2.BackColor = clr
        End If
    End Sub

    Private Sub LoadImage1_Click(sender As Object, e As EventArgs) Handles loadImage1.Click
        Try
            If OFD.ShowDialog() = DialogResult.OK Then
                listOfFiles.Clear()
                temp = Image.FromFile(OFD.FileName)
                If temp.Width >= 16 And temp.Height >= 16 Then
                    img1 = temp
                    image1.BackgroundImage = img1
                    image1.Width = img1.Width : image1.Height = img1.Height
                    LocationZero(sender, e)
                    If back1 IsNot Nothing AndAlso (back1.Width < img1.Width OrElse back1.Height < img1.Height) Then
                        back1 = Nothing
                        background1.BackgroundImage = Nothing
                    End If
                    If back1 Is Nothing Then BackColorFromImage1_Click(Nothing, Nothing)
                    If img2 IsNot Nothing AndAlso (img2.Width < img1.Width OrElse img2.Height < img1.Height) Then
                        img2 = Nothing
                        image2.BackgroundImage = Nothing
                    End If
                    If back2 IsNot Nothing AndAlso (back2.Width < img1.Width OrElse back2.Height < img1.Height) Then
                        back2 = Nothing
                        background2.BackgroundImage = Nothing
                    End If
                    If back2 Is Nothing Then BackColorFromImage2_Click(Nothing, Nothing)
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
                        If back2 Is Nothing Then BackColorFromImage2_Click(Nothing, Nothing)
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

    '---------------------------------------------

    Private Sub SetBackcolorForBackground1_Click(sender As Object, e As EventArgs) Handles setBackcolorForBackground1.Click
        back1 = Nothing
        background1.BackgroundImage = Nothing
        background1.BackColor = Color.FromArgb(redDecimal2.Text, greenDecimal2.Text, blueDecimal2.Text)
    End Sub

    Private Sub SetBackcolorForImage2_Click(sender As Object, e As EventArgs) Handles setBackcolorForImage2.Click
        img2 = Nothing
        image2.BackgroundImage = Nothing
        image2.BackColor = Color.FromArgb(redDecimal3.Text, greenDecimal3.Text, blueDecimal3.Text)
    End Sub

    Private Sub SetBackcolorForBackground2_Click(sender As Object, e As EventArgs) Handles setBackcolorForBackground2.Click
        back2 = Nothing
        background2.BackgroundImage = Nothing
        background2.BackColor = Color.FromArgb(redDecimal4.Text, greenDecimal4.Text, blueDecimal4.Text)
    End Sub

    Private Sub RedDecimal2_TextChanged(sender As Object, e As EventArgs) Handles redDecimal2.TextChanged
        If redDecimal2.Text = "" Then
            redDecimal2.Text = 0
        ElseIf redDecimal2.Text > 255 Then
            redDecimal2.Text = 255
        End If
        redHexadecimal2.Text = Convert.ToInt32(redDecimal2.Text).ToString("X")
    End Sub

    Private Sub RedHexadecimal2_TextChanged(sender As Object, e As EventArgs) Handles redHexadecimal2.TextChanged
        redDecimal2.Text = Convert.ToInt32("0" + redHexadecimal2.Text, 16)
    End Sub

    Private Sub GreenDecimal2_TextChanged(sender As Object, e As EventArgs) Handles greenDecimal2.TextChanged
        If greenDecimal2.Text = "" Then
            greenDecimal2.Text = 0
        ElseIf greenDecimal2.Text > 255 Then
            greenDecimal2.Text = 255
        End If
        greenHexadecimal2.Text = Convert.ToInt32(greenDecimal2.Text).ToString("X")
    End Sub

    Private Sub GreenHexadecimal2_TextChanged(sender As Object, e As EventArgs) Handles greenHexadecimal2.TextChanged
        greenDecimal2.Text = Convert.ToInt32("0" + greenHexadecimal2.Text, 16)
    End Sub

    Private Sub BlueDecimal2_TextChanged(sender As Object, e As EventArgs) Handles blueDecimal2.TextChanged
        If blueDecimal2.Text = "" Then
            blueDecimal2.Text = 0
        ElseIf blueDecimal2.Text > 255 Then
            blueDecimal2.Text = 255
        End If
        blueHexadecimal2.Text = Convert.ToInt32(blueDecimal2.Text).ToString("X")
    End Sub

    Private Sub BlueHexadecimal2_TextChanged(sender As Object, e As EventArgs) Handles blueHexadecimal2.TextChanged
        blueDecimal2.Text = Convert.ToInt32("0" + blueHexadecimal2.Text, 16)
    End Sub

    Private Sub RedDecimal3_TextChanged(sender As Object, e As EventArgs) Handles redDecimal3.TextChanged
        If redDecimal3.Text = "" Then
            redDecimal3.Text = 0
        ElseIf redDecimal3.Text > 255 Then
            redDecimal3.Text = 255
        End If
        redHexadecimal3.Text = Convert.ToInt32(redDecimal3.Text).ToString("X")
    End Sub

    Private Sub RedHexadecimal3_TextChanged(sender As Object, e As EventArgs) Handles redHexadecimal3.TextChanged
        redDecimal3.Text = Convert.ToInt32("0" + redHexadecimal3.Text, 16)
    End Sub

    Private Sub GreenDecimal3_TextChanged(sender As Object, e As EventArgs) Handles greenDecimal3.TextChanged
        If greenDecimal3.Text = "" Then
            greenDecimal3.Text = 0
        ElseIf greenDecimal3.Text > 255 Then
            greenDecimal3.Text = 255
        End If
        greenHexadecimal3.Text = Convert.ToInt32(greenDecimal3.Text).ToString("X")
    End Sub

    Private Sub GreenHexadecimal3_TextChanged(sender As Object, e As EventArgs) Handles greenHexadecimal3.TextChanged
        greenDecimal3.Text = Convert.ToInt32("0" + greenHexadecimal3.Text, 16)
    End Sub

    Private Sub BlueDecimal3_TextChanged(sender As Object, e As EventArgs) Handles blueDecimal3.TextChanged
        If blueDecimal3.Text = "" Then
            blueDecimal3.Text = 0
        ElseIf blueDecimal3.Text > 255 Then
            blueDecimal3.Text = 255
        End If
        blueHexadecimal3.Text = Convert.ToInt32(blueDecimal3.Text).ToString("X")
    End Sub

    Private Sub BlueHexadecimal3_TextChanged(sender As Object, e As EventArgs) Handles blueHexadecimal3.TextChanged
        blueDecimal3.Text = Convert.ToInt32("0" + blueHexadecimal3.Text, 16)
    End Sub

    Private Sub RedDecimal4_TextChanged(sender As Object, e As EventArgs) Handles redDecimal4.TextChanged
        If redDecimal4.Text = "" Then
            redDecimal4.Text = 0
        ElseIf redDecimal4.Text > 255 Then
            redDecimal4.Text = 255
        End If
        redHexadecimal4.Text = Convert.ToInt32(redDecimal4.Text).ToString("X")
    End Sub

    Private Sub RedHexadecimal4_TextChanged(sender As Object, e As EventArgs) Handles redHexadecimal4.TextChanged
        redDecimal4.Text = Convert.ToInt32("0" + redHexadecimal4.Text, 16)
    End Sub

    Private Sub GreenDecimal4_TextChanged(sender As Object, e As EventArgs) Handles greenDecimal4.TextChanged
        If greenDecimal4.Text = "" Then
            greenDecimal4.Text = 0
        ElseIf greenDecimal4.Text > 255 Then
            greenDecimal4.Text = 255
        End If
        greenHexadecimal4.Text = Convert.ToInt32(greenDecimal4.Text).ToString("X")
    End Sub

    Private Sub GreenHexadecimal4_TextChanged(sender As Object, e As EventArgs) Handles greenHexadecimal4.TextChanged
        greenDecimal4.Text = Convert.ToInt32("0" + greenHexadecimal4.Text, 16)
    End Sub

    Private Sub BlueDecimal4_TextChanged(sender As Object, e As EventArgs) Handles blueDecimal4.TextChanged
        If blueDecimal4.Text = "" Then
            blueDecimal4.Text = 0
        ElseIf blueDecimal4.Text > 255 Then
            blueDecimal4.Text = 255
        End If
        blueHexadecimal4.Text = Convert.ToInt32(blueDecimal4.Text).ToString("X")
    End Sub

    Private Sub BlueHexadecimal4_TextChanged(sender As Object, e As EventArgs) Handles blueHexadecimal4.TextChanged
        blueDecimal4.Text = Convert.ToInt32("0" + blueHexadecimal4.Text, 16)
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
