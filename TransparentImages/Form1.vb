Public Class Form1
    ReadOnly hm As String = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData.Replace("0.0.0.0", "")
    ReadOnly rd1 As New Random
    Dim img1, back1, img2, back2, finalImg, temp As Bitmap
    Dim folderOpen, folderSave As String
    ReadOnly listOfFiles As New List(Of String)
    Dim G5 As Graphics

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
        If e.KeyChar = "0" OrElse e.KeyChar = "1" OrElse e.KeyChar = "2" OrElse e.KeyChar = "3" OrElse e.KeyChar = "4" OrElse e.KeyChar = "5" OrElse e.KeyChar = "6" OrElse e.KeyChar = "7" OrElse e.KeyChar = "8" OrElse e.KeyChar = "9" OrElse e.KeyChar = "" Then
            Exit Sub
        Else
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Pg2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles redHexadecimal2.KeyPress, greenHexadecimal2.KeyPress, blueHexadecimal2.KeyPress, redHexadecimal4.KeyPress, greenHexadecimal4.KeyPress, blueHexadecimal4.KeyPress
        If e.KeyChar = "0" OrElse e.KeyChar = "1" OrElse e.KeyChar = "2" OrElse e.KeyChar = "3" OrElse e.KeyChar = "4" OrElse e.KeyChar = "5" OrElse e.KeyChar = "6" OrElse e.KeyChar = "7" OrElse e.KeyChar = "8" OrElse e.KeyChar = "9" OrElse e.KeyChar = "a" OrElse e.KeyChar = "b" OrElse e.KeyChar = "c" OrElse e.KeyChar = "d" OrElse e.KeyChar = "e" OrElse e.KeyChar = "f" OrElse e.KeyChar = "A" OrElse e.KeyChar = "B" OrElse e.KeyChar = "C" OrElse e.KeyChar = "D" OrElse e.KeyChar = "E" OrElse e.KeyChar = "F" OrElse e.KeyChar = "" Then
            Exit Sub
        Else
            e.KeyChar = ""
        End If
    End Sub

    ReadOnly pictureExtensions As String() = {".bmp", ".gif", ".jpeg", ".jpg", ".png", ".tif", ".tiff", ".ico"}
    Private Sub Folder_Click(sender As Object, e As EventArgs) Handles folder.Click
        listOfFiles.Clear()
        If FBD.ShowDialog = DialogResult.OK Then
            folderOpen = FBD.SelectedPath
            For Each file In My.Computer.FileSystem.GetFiles(folderOpen)
                If pictureExtensions.Contains(IO.Path.GetExtension(file).ToLower()) Then listOfFiles.Add(file)
            Next
            If listOfFiles.Count = 1 Then
                LoadImage1_(listOfFiles(0))
                length.Text = "∞"
            ElseIf listOfFiles.Count > 1 Then
                length.Text = listOfFiles.Count
                counter.Text = 0
                background1ColorCheck.Enabled = True
            Else
                background1ColorCheck.Enabled = False
                length.Text = "∞"
            End If
            If folderOpen = folderSave Then folderSave = ""
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

        If listOfFiles.Count > 0 AndAlso folderSave = "" Then
            MessageBox.Show("اختر مجلد الحفظ")

        ElseIf listOfFiles.Count > 0 Then
            For i = 0 To listOfFiles.Count - 1
                img1 = New Bitmap(listOfFiles(i))
                If background1ColorCheck.Checked AndAlso x1.Text < img1.Width AndAlso y1.Text < img1.Height Then
                    background1color = img1.GetPixel(x1.Text, y1.Text)
                    redDecimal2.Text = background1color.R
                    greenDecimal2.Text = background1color.G
                    blueDecimal2.Text = background1color.B
                    SetBackcolorForBackground1_Click(Nothing, Nothing)
                End If
                TheGameBoss()
                counter.Text += 1
                Refresh() : Application.DoEvents()
                If imageFormat.SelectedIndex = 1 Then
                    finalImg.Save(folderSave + "\" + listOfFiles(i).Split("\").Last, Imaging.ImageFormat.Icon)
                Else
                    finalImg.Save(folderSave + "\" + listOfFiles(i).Split("\").Last, Imaging.ImageFormat.Png)
                End If
            Next

        Else
            TheGameBoss()
#Region "Display the output image"
            temp = New Bitmap(img1.Width, img1.Height)
            G5 = Graphics.FromImage(temp)
            G5.DrawImage(My.Resources.trpt2, 0, 0)
            G5.DrawImage(finalImg, 0, 0)
            finalImage.BackgroundImage = temp
#End Region
        End If
    End Sub

    Dim alpha As Decimal
    Dim tmpR, tmpG, tmpB As Integer
    Dim image1color, image2color, background1color, background2color As Color
    Private Sub TheGameBoss()
        finalImg = New Bitmap(img1.Width, img1.Height)

        For i = 0 To img1.Width - 1
            For j = 0 To img1.Height - 1

#Region "The Pixel Color"
                image1color = img1.GetPixel(i, j)
                If image1color.A = 0 Then Continue For

                If i < back1.Width AndAlso j < back1.Height Then
                    background1color = back1.GetPixel(i, j)
                Else
                    background1color = Color.FromArgb(redDecimal2.Text, greenDecimal2.Text, blueDecimal2.Text)
                End If

                If i < img2.Width AndAlso j < img2.Height Then
                    image2color = img2.GetPixel(i, j)
                Else
                    image2color = Color.FromArgb(redDecimal3.Text, greenDecimal3.Text, blueDecimal3.Text)
                End If
                If i < back2.Width AndAlso j < back2.Height Then
                    background2color = back2.GetPixel(i, j)
                Else
                    background2color = Color.FromArgb(redDecimal4.Text, greenDecimal4.Text, blueDecimal4.Text)
                End If
#End Region

#Region "Alpha Value"
                tmpR = background1color.R - 1 * background2color.R
                tmpG = background1color.G - 1 * background2color.G
                tmpB = background1color.B - 1 * background2color.B

                alpha = -371
                If tmpR <> 0 AndAlso tmpG <> 0 AndAlso tmpB <> 0 Then

                    If Math.Abs(tmpR) >= Math.Abs(tmpG) AndAlso Math.Abs(tmpR) >= Math.Abs(tmpB) Then
                        alpha = 1 - (image1color.R - 1 * image2color.R) / tmpR
                    End If
                    If alpha < 0 OrElse alpha > 1 OrElse Math.Abs(tmpG) >= Math.Abs(tmpR) AndAlso Math.Abs(tmpG) >= Math.Abs(tmpB) Then
                        alpha = 1 - (image1color.G - 1 * image2color.G) / tmpG
                    End If
                    If alpha < 0 OrElse alpha > 1 OrElse Math.Abs(tmpB) >= Math.Abs(tmpR) AndAlso Math.Abs(tmpB) >= Math.Abs(tmpG) Then
                        alpha = 1 - (image1color.B - 1 * image2color.B) / tmpB
                    End If
                End If

                If alpha > 1 Then
                    alpha = 1
                ElseIf alpha < 0 AndAlso alpha <> -371 Then
                    alpha = 0
                End If
#End Region

#Region "Alpha is not equal to zero"
                If alpha > 0 Then
                    tmpR = (image1color.R - (1 - alpha) * background1color.R) / alpha
                    If tmpR < 0 Then
                        tmpR = 0
                    ElseIf tmpR > 255 Then
                        tmpR = 255
                    End If

                    tmpG = (image1color.G - (1 - alpha) * background1color.G) / alpha
                    If tmpG < 0 Then
                        tmpG = 0
                    ElseIf tmpG > 255 Then
                        tmpG = 255
                    End If

                    tmpB = (image1color.B - (1 - alpha) * background1color.B) / alpha
                    If tmpB < 0 Then
                        tmpB = 0
                    ElseIf tmpB > 255 Then
                        tmpB = 255
                    End If
#End Region
#Region "Set Color"
                    finalImg.SetPixel(i, j, Color.FromArgb(alpha * 255, tmpR, tmpG, tmpB))
                ElseIf alpha < 0 Then
                    finalImg.SetPixel(i, j, image1color)
                End If
#End Region
            Next
        Next
    End Sub

    Private Sub Lwh_Click(sender As Object, e As EventArgs) Handles help.Click
        If loadImage1.Enabled = True Then

            redDecimal2.Text = rd1.Next(0, 256)
            greenDecimal2.Text = rd1.Next(0, 256)
            blueDecimal2.Text = rd1.Next(0, 256)
            img1 = New Bitmap(256, 256)
            G5 = Graphics.FromImage(img1)
            G5.Clear(Color.FromArgb(redDecimal2.Text, greenDecimal2.Text, blueDecimal2.Text))
            G5.DrawImage(My.Resources.zx0, 0, 0)
            image1.BackgroundImage = img1
            BackgroundColorFromImage1_Click(Nothing, Nothing)

            redDecimal4.Text = rd1.Next(0, 256)
            greenDecimal4.Text = rd1.Next(0, 256)
            blueDecimal4.Text = rd1.Next(0, 256)
            img2 = New Bitmap(img1.Width, img1.Height)
            G5 = Graphics.FromImage(img2)
            G5.Clear(Color.FromArgb(redDecimal4.Text, greenDecimal4.Text, blueDecimal4.Text))
            G5.DrawImage(My.Resources.zx0, 0, 0)
            image2.BackgroundImage = img2
            BackgroundColorFromImage2_Click(Nothing, Nothing)

            temp = New Bitmap(256, 256)
            G5 = Graphics.FromImage(temp)
            G5.DrawImage(My.Resources.trpt2, 0, 0)
            G5.DrawImage(My.Resources.zx0, 0, 0)
            finalImage.BackgroundImage = temp
            finalImg = My.Resources.zx0
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
                    finalImg.Save(SFD.FileName, Imaging.ImageFormat.Icon)
                Else
                    finalImg.Save(SFD.FileName, Imaging.ImageFormat.Png)
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

    Private Sub LocationZero()
        VSB.Value = 0 : HSB.Value = 0
        image1.Location = New Point(0, 0) : background1.Location = New Point(0, 0) : image2.Location = New Point(0, 0) : background2.Location = New Point(0, 0) : finalImage.Location = New Point(0, 0)
    End Sub

    Dim clr As Color
    Private Sub BackgroundColorFromImage1_Click(sender As Object, e As EventArgs) Handles backColorFromImage1.Click
        If x1.Text = "" Then x1.Text = "0"
        If y1.Text = "" Then y1.Text = "0"
        If x1.Text < img1.Width AndAlso y1.Text < img1.Height Then
            clr = img1.GetPixel(x1.Text, y1.Text)

            back1 = New Bitmap(img1.Width, img1.Height)
            Graphics.FromImage(back1).Clear(Color.FromArgb(clr.R, clr.G, clr.B))
            background1.BackgroundImage = back1

            redDecimal2.Text = clr.R : greenDecimal2.Text = clr.G : blueDecimal2.Text = clr.B
        End If
    End Sub

    Private Sub BackgroundColorFromImage2_Click(sender As Object, e As EventArgs) Handles backColorFromImage2.Click
        If x1.Text = "" Then x1.Text = "0"
        If y1.Text = "" Then y1.Text = "0"

        If x1.Text < img2.Width AndAlso y1.Text < img2.Height Then
            clr = img2.GetPixel(x1.Text, y1.Text)

            back2 = New Bitmap(img1.Width, img1.Height)
            Graphics.FromImage(back2).Clear(Color.FromArgb(clr.R, clr.G, clr.B))
            background2.BackgroundImage = back2

            redDecimal4.Text = clr.R : greenDecimal4.Text = clr.G : blueDecimal4.Text = clr.B
        End If
    End Sub

    Sub LoadImage1_(file As String)
        Try
            listOfFiles.Clear()
            background1ColorCheck.Enabled = False
            temp = New Bitmap(file) 'Image.FromFile(file)
            If temp.Width >= 16 AndAlso temp.Height >= 16 Then
                img1 = temp
                image1.BackgroundImage = img1
                image1.Width = img1.Width : image1.Height = img1.Height
                LocationZero()
                If back1.Width < img1.Width OrElse back1.Height < img1.Height Then
                    'SetBackcolorForBackground1_Click(Nothing, Nothing)
                    BackgroundColorFromImage1_Click(Nothing, Nothing)
                End If

                If img2.Width < img1.Width OrElse img2.Height < img1.Height Then SetBackcolorForImage2_Click(Nothing, Nothing)
                If back2.Width < img1.Width OrElse back2.Height < img1.Height Then
                    'SetBackcolorForBackground2_Click(Nothing, Nothing)
                    BackgroundColorFromImage2_Click(Nothing, Nothing)
                End If
                xMax.Text = img1.Width : yMax.Text = img1.Height
            Else
                MsgBox("غير مسموح بصورة أقل من 16*16")
            End If
        Catch
            MsgBox("حدث خطأ")
        End Try
    End Sub

    Private Sub LoadImage1_Click(sender As Object, e As EventArgs) Handles loadImage1.Click
        If OFD.ShowDialog() = DialogResult.OK Then LoadImage1_(OFD.FileName)
    End Sub

    Private Sub LoadBackground1_Click(sender As Object, e As EventArgs) Handles loadBackground1.Click
        Try
            If OFD.ShowDialog() = DialogResult.OK Then
                temp = New Bitmap(OFD.FileName) 'Image.FromFile(OFD.FileName)
                If temp.Width >= 16 AndAlso temp.Height >= 16 Then
                    If temp.Width < img1.Width OrElse temp.Height < img1.Height Then
                        MsgBox("الصورة أصغر من الصورة الرئيسية")
                    Else
                        back1 = temp
                        background1.BackgroundImage = back1
                        background1.Width = back1.Width : background1.Height = back1.Height
                        LocationZero()
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
                temp = New Bitmap(OFD.FileName) 'Image.FromFile(OFD.FileName)
                If temp.Width >= 16 AndAlso temp.Height >= 16 Then
                    If temp.Width < img1.Width OrElse temp.Height < img1.Height Then
                        MsgBox("الصورة أصغر من الصورة الرئيسية")
                    Else
                        img2 = temp
                        image2.BackgroundImage = img2
                        image2.Width = img2.Width : image2.Height = img2.Height
                        LocationZero()
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
                temp = New Bitmap(OFD.FileName) 'Image.FromFile(OFD.FileName)
                If temp.Width >= 16 AndAlso temp.Height >= 16 Then
                    If temp.Width < img1.Width OrElse temp.Height < img1.Height Then
                        MsgBox("الصورة أصغر من الصورة الرئيسية")
                    Else
                        back2 = temp
                        background2.BackgroundImage = back2
                        background2.Width = back2.Width : background2.Height = back2.Height
                        LocationZero()
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
        back1 = New Bitmap(img1.Width, img1.Height)
        Graphics.FromImage(back1).Clear(Color.FromArgb(redDecimal2.Text, greenDecimal2.Text, blueDecimal2.Text))
        background1.BackgroundImage = back1
    End Sub

    Private Sub SetBackcolorForImage2_Click(sender As Object, e As EventArgs) Handles setBackcolorForImage2.Click
        img2 = New Bitmap(img1.Width, img1.Height)
        Graphics.FromImage(img2).Clear(Color.FromArgb(redDecimal3.Text, greenDecimal3.Text, blueDecimal3.Text))
        image2.BackgroundImage = img2
    End Sub

    Private Sub SetBackcolorForBackground2_Click(sender As Object, e As EventArgs) Handles setBackcolorForBackground2.Click
        back2 = New Bitmap(img1.Width, img1.Height)
        Graphics.FromImage(back2).Clear(Color.FromArgb(redDecimal4.Text, greenDecimal4.Text, blueDecimal4.Text))
        background2.BackgroundImage = back2
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

    'Function OperationOnTwoColors(c1 As Color, c2 As Color, oper As Char) As Color
    '    If oper = "+"c Then
    '        Return Color.FromArgb(If(c1.A + c2.A <= 255, c1.A + c2.A, 255), If(c1.R + c2.R <= 255, c1.R + c2.R, 255), If(c1.G + c2.G <= 255, c1.G + c2.G, 255), If(c1.B + c2.B <= 255, c1.B + c2.B, 255))
    '    ElseIf oper = "-"c Then
    '        Return Color.FromArgb(If(c1.A - c2.A >= 0, c1.A - c2.A, 0), If(c1.R - c2.R >= 0, c1.R - c2.R, 0), If(c1.G - c2.G >= 0, c1.G - c2.G, 0), If(c1.B - c2.B >= 0, c1.B - c2.B, 0))
    '    ElseIf oper = "*"c Then
    '        Return Color.FromArgb(If(c1.A * c2.A <= 255, c1.A * c2.A, 255), If(c1.R * c2.R <= 255, c1.R * c2.R, 255), If(c1.G * c2.G <= 255, c1.G * c2.G, 255), If(c1.B * c2.B <= 255, c1.B * c2.B, 255))
    '    ElseIf oper = "/"c Then
    '        If c1.A = 0 AndAlso c2.A = 0 OrElse c1.R = 0 AndAlso c2.R = 0 OrElse c1.G = 0 AndAlso c2.G = 0 OrElse c1.B = 0 AndAlso c2.B = 0 Then
    '            Return Color.Empty
    '        Else
    '            Return Color.FromArgb(If(c2.A >= 1, c1.A / c2.A, 255), If(c2.R >= 1, c1.R / c2.R, 255), If(c2.G >= 1, c1.G / c2.G, 255), If(c2.B >= 1, c1.B / c2.B, 255))
    '        End If
    '    Else
    '        Return Color.Empty
    '    End If
    'End Function
End Class
