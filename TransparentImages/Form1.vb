Public Class Form1
    Dim hm As String = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData.Replace("0.0.0.0", "")
    Dim rd1 As New Random
    Dim pic1, pic2, pic3, pic4, pic5 As Bitmap
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

    Private Sub Pg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles x0.KeyPress, y0.KeyPress, x2.KeyPress, y2.KeyPress, x03.KeyPress, y03.KeyPress, x4.KeyPress, y4.KeyPress, redDecimal2.KeyPress, greenDecimal2.KeyPress, blueDecimal2.KeyPress, redDecimal4.KeyPress, greenDecimal4.KeyPress, blueDecimal4.KeyPress
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

    Private Sub start1_Click(sender As Object, e As EventArgs)
        pic1 = Image.FromFile(folderPath + "\" + ListBox1.Items(aaaa))
        aaaa += 1
        image1.BackgroundImage = pic1
        image1.Width = pic1.Width : image1.Height = pic1.Height
        MG5(sender, e)
        If mg3.Text = "1" Then
            If pic3.Width < pic1.Width Or pic3.Height < pic1.Height Then
                image2.BackgroundImage = Nothing : mg3.Text = "0" : x03.Text = "0" : y03.Text = "0" : x03.ReadOnly = True : y03.ReadOnly = True
            End If
        End If
        x0.Text = "" : x0.Text = "0" : y0.Text = "0"
        xMax.Text = pic1.Width : yMax.Text = pic1.Height

        loadImage1.Enabled = False : loadBackground1.Enabled = False : loadImage2.Enabled = False : loadBackground2.Enabled = False : start.Enabled = False : save.Enabled = False : num.Enabled = False : x0.Enabled = False : y0.Enabled = False : redDecimal2.Enabled = False : greenDecimal2.Enabled = False : blueDecimal2.Enabled = False : redDecimal4.Enabled = False : greenDecimal4.Enabled = False : blueDecimal4.Enabled = False : redHexadecimal2.Enabled = False : greenHexadecimal2.Enabled = False : blueHexadecimal2.Enabled = False : redHexadecimal4.Enabled = False : greenHexadecimal4.Enabled = False : blueHexadecimal4.Enabled = False
        If x2.Text = "" Then
            x2.Text = "0"
        End If
        If y2.Text = "" Then
            y2.Text = "0"
        End If
        If x03.Text = "" Then
            x03.Text = "0"
        End If
        If y03.Text = "" Then
            y03.Text = "0"
        End If
        If x4.Text = "" Then
            x4.Text = "0"
        End If
        If y4.Text = "" Then
            y4.Text = "0"
        End If
        p21 = x2.Text : p22 = y2.Text : p31 = x03.Text : p32 = y03.Text : p41 = x4.Text : p42 = y4.Text
        If p31 + pic1.Width > pic3.Width Then
            p31 = pic3.Width - pic1.Width : x03.Text = p31
        End If
        If p32 + pic1.Height > pic3.Height Then
            p32 = pic3.Height - pic1.Height : y03.Text = p32
        End If
        If mg2.Text = "1" Then
            If p21 + pic1.Width > pic2.Width Then
                p21 = pic2.Width - pic1.Width : x2.Text = p21
            End If
            If p22 + pic1.Height > pic2.Height Then
                p22 = pic2.Height - pic1.Height : y2.Text = p22
            End If
        End If
        If mg4.Text = "1" Then
            If p41 + pic1.Width > pic4.Width Then
                p41 = pic4.Width - pic1.Width : x4.Text = p41
            End If
            If p42 + pic1.Height > pic4.Height Then
                p42 = pic4.Height - pic1.Height : y4.Text = p42
            End If
        End If
        finalImage.BackgroundImage = Nothing
        qw = 0 : xmm = xMax.Text : ymm = yMax.Text
        q1 = (xmm * ymm) / ((num.SelectedIndex + 1) * 100)
        Lb2.Text = q1
        q1 = 0 : q2 = 0
        Dim Bb5 As New Bitmap(xmm, ymm)
        Dim G5 As Graphics = Graphics.FromImage(Bb5)
        G5.DrawImage(My.Resources.trpt2, 0, 0)
        finalImage.BackgroundImage = Bb5 : finalImage.Width = xmm : finalImage.Height = ymm
        pic5 = finalImage.BackgroundImage : nl = "" : k2 = 0
        T3.Start()

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
            pic1 = Bb5

            redDecimal4.Text = rd1.Next(0, 256)
            greenDecimal4.Text = rd1.Next(0, 256)
            blueDecimal4.Text = rd1.Next(0, 256)
            Bb5 = New Bitmap(256, 256)
            G5 = Graphics.FromImage(Bb5)
            G5.Clear(Color.FromArgb(redDecimal4.Text, greenDecimal4.Text, blueDecimal4.Text))
            G5.DrawImage(My.Resources.zx0, 0, 0)
            image2.BackgroundImage = Bb5 : mg3.Text = "1"
            pic3 = Bb5

            Bb5 = New Bitmap(256, 256)
            G5 = Graphics.FromImage(Bb5)
            G5.DrawImage(My.Resources.trpt2, 0, 0)
            G5.DrawImage(My.Resources.zx0, 0, 0)
            finalImage.BackgroundImage = Bb5
            pic5 = My.Resources.zx0

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

        pic5.Save("C:\Users\Mohamed\Desktop\noon\" + ListBox1.Items(aaaa - 1), Imaging.ImageFormat.Png)

        'If SFD.ShowDialog() = DialogResult.OK Then
        'If cb3.Text = "ico" Then
        '  pic5.Save(SFD.FileName, Imaging.ImageFormat.Icon)
        '   Else
        '  pic5.Save(SFD.FileName, Imaging.ImageFormat.Png)
        ' End If
        '   End If
    End Sub

    Private Sub St_Click(sender As Object, e As EventArgs) Handles start.Click
        If mg3.Text = "1" Then
            loadImage1.Enabled = False : loadBackground1.Enabled = False : loadImage2.Enabled = False : loadBackground2.Enabled = False : start.Enabled = False : save.Enabled = False : num.Enabled = False : x0.Enabled = False : y0.Enabled = False : redDecimal2.Enabled = False : greenDecimal2.Enabled = False : blueDecimal2.Enabled = False : redDecimal4.Enabled = False : greenDecimal4.Enabled = False : blueDecimal4.Enabled = False : redHexadecimal2.Enabled = False : greenHexadecimal2.Enabled = False : blueHexadecimal2.Enabled = False : redHexadecimal4.Enabled = False : greenHexadecimal4.Enabled = False : blueHexadecimal4.Enabled = False
            If x2.Text = "" Then
                x2.Text = "0"
            End If
            If y2.Text = "" Then
                y2.Text = "0"
            End If
            If x03.Text = "" Then
                x03.Text = "0"
            End If
            If y03.Text = "" Then
                y03.Text = "0"
            End If
            If x4.Text = "" Then
                x4.Text = "0"
            End If
            If y4.Text = "" Then
                y4.Text = "0"
            End If
            p21 = x2.Text : p22 = y2.Text : p31 = x03.Text : p32 = y03.Text : p41 = x4.Text : p42 = y4.Text
            If p31 + pic1.Width > pic3.Width Then
                p31 = pic3.Width - pic1.Width : x03.Text = p31
            End If
            If p32 + pic1.Height > pic3.Height Then
                p32 = pic3.Height - pic1.Height : y03.Text = p32
            End If
            If mg2.Text = "1" Then
                If p21 + pic1.Width > pic2.Width Then
                    p21 = pic2.Width - pic1.Width : x2.Text = p21
                End If
                If p22 + pic1.Height > pic2.Height Then
                    p22 = pic2.Height - pic1.Height : y2.Text = p22
                End If
            End If
            If mg4.Text = "1" Then
                If p41 + pic1.Width > pic4.Width Then
                    p41 = pic4.Width - pic1.Width : x4.Text = p41
                End If
                If p42 + pic1.Height > pic4.Height Then
                    p42 = pic4.Height - pic1.Height : y4.Text = p42
                End If
            End If
            finalImage.BackgroundImage = Nothing
            qw = 0 : xmm = xMax.Text : ymm = yMax.Text
            q1 = (xmm * ymm) / ((num.SelectedIndex + 1) * 100)
            Lb2.Text = q1
            q1 = 0 : q2 = 0
            Dim Bb5 As New Bitmap(xmm, ymm)
            Dim G5 As Graphics = Graphics.FromImage(Bb5)
            G5.DrawImage(My.Resources.trpt2, 0, 0)
            finalImage.BackgroundImage = Bb5 : finalImage.Width = xmm : finalImage.Height = ymm
            pic5 = finalImage.BackgroundImage : nl = "" : k2 = 0
            T3.Start()
        Else
            MsgBox("أضف الصورة الثانية أولاً")
        End If
    End Sub

    Private Sub TF(sender As Object, e As EventArgs)
        Lb1.Text = "0" : Lb2.Text = "∞"
        loadImage1.Enabled = True : loadBackground1.Enabled = True : loadImage2.Enabled = True : loadBackground2.Enabled = True : start.Enabled = True : save.Enabled = True : num.Enabled = True : x0.Enabled = True : y0.Enabled = True : redDecimal2.Enabled = True : greenDecimal2.Enabled = True : blueDecimal2.Enabled = True : redDecimal4.Enabled = True : greenDecimal4.Enabled = True : blueDecimal4.Enabled = True : redHexadecimal2.Enabled = True : greenHexadecimal2.Enabled = True : blueHexadecimal2.Enabled = True : redHexadecimal4.Enabled = True : greenHexadecimal4.Enabled = True : blueHexadecimal4.Enabled = True
    End Sub

    Private Sub RGB(sender As Object, e As EventArgs)
        If Math.Abs(w4 - w10) > Math.Abs(w5 - w11) And Math.Abs(w4 - w10) > Math.Abs(w6 - w12) Then
            o1 = w4 : o2 = w10 : o3 = "1"
        ElseIf Math.Abs(w5 - w11) > Math.Abs(w4 - w10) And Math.Abs(w5 - w11) > Math.Abs(w6 - w12) Then
            o1 = w5 : o2 = w11 : o3 = "2"
        ElseIf Math.Abs(w6 - w12) > Math.Abs(w4 - w10) And Math.Abs(w6 - w12) > Math.Abs(w5 - w11) Then
            o1 = w6 : o2 = w12 : o3 = "3"
        Else
            If w4 = w10 Then
                If w5 = w11 Then
                    o1 = w6 : o2 = w12 : o3 = "3"
                Else
                    o1 = w5 : o2 = w11 : o3 = "2"
                End If
            Else
                o1 = w4 : o2 = w10 : o3 = "1"
            End If
        End If
    End Sub

    Private Sub RGB8(sender As Object, e As EventArgs)
        If o3 = 2 Then
            w0 = 255 * ((o2 + w2) - (o1 + w8)) / (o2 - o1)
        ElseIf o3 = 3 Then
            w0 = 255 * ((o2 + w3) - (o1 + w9)) / (o2 - o1)
        Else
            w0 = 255 * ((o2 + w1) - (o1 + w7)) / (o2 - o1)
        End If
        w0 = Math.Abs(w0)
        If w0 = 0 Then
            pic5.SetPixel(q1, q2, Color.FromArgb(0, 0, 0, 0))
        ElseIf w0 = 255 Then
            pic5.SetPixel(q1, q2, Color.FromArgb(w1, w2, w3))
        Else
            ' If w0 > 255 Or w0 < 0 Then
            'pic5.SetPixel(q1, q2, Color.FromArgb(w1, w2, w3))
            '   Exit Sub
            'end If
            If w10 < w4 Then
                w1 = (w7 * 255 - (255 - w0) * w10) / w0
            Else
                w1 = (w1 * 255 - (255 - w0) * w4) / w0
            End If
            If w11 < w5 Then
                w2 = (w8 * 255 - (255 - w0) * w11) / w0
            Else
                w2 = (w2 * 255 - (255 - w0) * w5) / w0
            End If
            If w12 < w6 Then
                w3 = (w9 * 255 - (255 - w0) * w12) / w0
            Else
                w3 = (w3 * 255 - (255 - w0) * w6) / w0
            End If
            If w1 < 0 Then
                w1 = 0
            ElseIf w1 > 255 Then
                w1 = 255
            End If
            If w2 < 0 Then
                w2 = 0
            ElseIf w2 > 255 Then
                w2 = 255
            End If
            If w3 < 0 Then
                w3 = 0
            ElseIf w3 > 255 Then
                w3 = 255
            End If
            w0 = Math.Round(w0)
            If w0 > 255 Then
                w0 = 255
            End If
            pic5.SetPixel(q1, q2, Color.FromArgb(w0, w1, w2, w3))
        End If
    End Sub

    Private Sub RGB9(sender As Object, e As EventArgs)
        Form3.x.Text = q1 : Form3.y.Text = q2
        If q1 = 0 And q2 = 0 Then
            Form3.o3.Visible = False : Form3.CB4.Visible = False : Form3.L24.Visible = True
        Else
            Form3.L24.Visible = False : Form3.o3.Visible = True : Form3.CB4.Visible = True
            If q1 = 0 Then
                Form3.CB4.Items.AddRange(New Object() {"فوق"}) : Form3.CB4.Text = "فوق"
            ElseIf q2 = 0 Then
                Form3.CB4.Items.AddRange(New Object() {"يمين"}) : Form3.CB4.Text = "يمين"
            Else
                Form3.CB4.Items.AddRange(New Object() {"يمين", "فوق"})
            End If
        End If
        If Form3.op4.Text = "0" Then
            Form3.ShowDialog()
        End If
        If Form3.op.Text = "0" Then
        Else
            If Form3.CB1.Checked = True And k2 < 1000 Then
                gh = q1 : tt = q2 : k2 += 1
                nl += "x=" + gh + "," + "y=" + tt + " &&& إختيار رقم " + Form3.op.Text + " 
"
            End If
        End If
        If Form3.op.Text = "1" Then
            If Form3.op2.Text = "0" Then
                pic5.SetPixel(q1, q2, Color.FromArgb(255, 0, 0))
            ElseIf Form3.op2.Text = "1" Then
                pic5.SetPixel(q1, q2, Color.FromArgb(255, 128, 0))
            ElseIf Form3.op2.Text = "2" Then
                pic5.SetPixel(q1, q2, Color.FromArgb(255, 255, 0))
            ElseIf Form3.op2.Text = "3" Then
                pic5.SetPixel(q1, q2, Color.FromArgb(0, 255, 0))
            ElseIf Form3.op2.Text = "4" Then
                pic5.SetPixel(q1, q2, Color.FromArgb(0, 255, 255))
            ElseIf Form3.op2.Text = "5" Then
                pic5.SetPixel(q1, q2, Color.FromArgb(0, 0, 255))
            ElseIf Form3.op2.Text = "6" Then
                pic5.SetPixel(q1, q2, Color.FromArgb(128, 0, 255))
            ElseIf Form3.op2.Text = "7" Then
                pic5.SetPixel(q1, q2, Color.FromArgb(255, 0, 255))
            ElseIf Form3.op2.Text = "8" Then
                pic5.SetPixel(q1, q2, Color.FromArgb(255, 255, 255))
            ElseIf Form3.op2.Text = "9" Then
                pic5.SetPixel(q1, q2, Color.FromArgb(0, 0, 0))
            End If
        ElseIf Form3.op.Text = "2" Then
            pic5.SetPixel(q1, q2, Color.FromArgb(0, 0, 0, 0))
        ElseIf Form3.op.Text = "3" Then
            If Form3.CB3.Text = "يمين" Then
                pic5.SetPixel(q1, q2, pic5.GetPixel(q1 - 1, q2))
            ElseIf Form3.CB3.Text = "فوق" Then
                pic5.SetPixel(q1, q2, pic5.GetPixel(q1, q2 - 1))
            End If
        ElseIf Form3.op.Text = "4" Then

        ElseIf Form3.op.Text = "5" Then
            pic5.SetPixel(q1, q2, Color.FromArgb(w1, w2, w3))
        ElseIf Form3.op.Text = "6" Then
            pic5.SetPixel(q1, q2, Color.FromArgb(Form3.r1.Text, Form3.g1.Text, Form3.b1.Text, Form3.a1.Text))
        End If
    End Sub

    Private Sub T33(sender As Object, e As EventArgs) Handles T3.Tick
        T3.Stop()
        Dim P1 As Color = pic1.GetPixel(q1, q2)
        w1 = P1.R : w2 = P1.G : w3 = P1.B
        If mg2.Text = "1" Then
            Dim P2 As Color = pic2.GetPixel(q1 + p21, q2 + p22)
            w4 = P2.R : w5 = P2.G : w6 = P2.B
        ElseIf q1 = 0 And q2 = 0 Then
            w4 = r5.Text : w5 = g5.Text : w6 = b5.Text
        End If
        Dim P3 As Color = pic3.GetPixel(q1 + p31, q2 + p32)
        w7 = P3.R : w8 = P3.G : w9 = P3.B
        If mg4.Text = "1" Then
            Dim P4 As Color = pic4.GetPixel(q1 + p41, q2 + p42)
            w10 = P4.R : w11 = P4.G : w12 = P4.B
        ElseIf q1 = 0 And q2 = 0 Then
            w10 = r6.Text : w11 = g6.Text : w12 = b6.Text
        End If
        If mg2.Text = "0" And mg4.Text = "0" Then
            If q1 = 0 And q2 = 0 Then
                If w4 = w10 And w5 = w11 And w6 = w12 Then
                    MsgBox("البيكسل الذي اخترته ليس لون الخلفية أو الصورتان متشابهان")
                    TF(sender, e)
                    Exit Sub
                Else
                    RGB(sender, e)
                End If
            End If
        ElseIf mg2.Text = "1" Or mg4.Text = "1" Then
            If w4 = w10 And w5 = w11 And w6 = w12 Then
                RGB9(sender, e)
                If Form3.op.Text = "0" Then
                    TF(sender, e)
                    Exit Sub
                End If
            Else
                RGB(sender, e)
            End If
        End If
        If w4 = w10 And w5 = w11 And w6 = w12 Then
        Else
            RGB8(sender, e)
        End If
        If q1 < xmm - 1 Then
            q1 += 1 : qw += 1
        ElseIf q1 = xmm - 1 And q2 < ymm - 1 Then
            q1 = 0 : q2 += 1 : qw += 1
        ElseIf q1 = xmm - 1 And q2 = ymm - 1 Then
            q1 = 0 : q2 = 0 : qw = 9999
        End If
        If qw < ((num.SelectedIndex + 1) * 100) Then
            T33(sender, e)
        ElseIf qw = 9999 Then
            Doo(sender, e)
        Else
            qw = 0 : T3.Start() : Lb1.Text += 1
        End If
    End Sub

    Private Sub Doo(sender As Object, e As EventArgs)
        Dim Bb5 As New Bitmap(xmm, ymm)
        Dim G5 As Graphics = Graphics.FromImage(Bb5)
        G5.DrawImage(My.Resources.trpt2, 0, 0)
        G5.DrawImage(pic5, 0, 0)
        finalImage.BackgroundImage = Bb5 : TF(sender, e)
        pic5.Save("C:\Users\Mohamed\Desktop\noon\" + ListBox1.Items(aaaa - 1), Imaging.ImageFormat.Png)
        start1_Click(sender, e)
        '  If nl = "" Then
        ' Else
        '     My.Computer.FileSystem.WriteAllText("Pixels2.txt", nl, False)
        ' End If
        ' My.Computer.FileSystem.WriteAllText(hm + "err", num.SelectedIndex, False)
    End Sub

    Private Sub MG5(sender As Object, e As EventArgs)
        VSB.Value = 0 : HSB.Value = 0
        image1.Location = New Point(0, 0) : background1.Location = New Point(0, 0) : image2.Location = New Point(0, 0) : background2.Location = New Point(0, 0) : finalImage.Location = New Point(0, 0)
    End Sub

    Private Sub Img1_Click(sender As Object, e As EventArgs) Handles loadImage1.Click
        On Error Resume Next
        If OFD.ShowDialog() = DialogResult.OK Then
            If Image.FromFile(OFD.FileName).Width >= 16 And Image.FromFile(OFD.FileName).Height >= 16 Then
                pic1 = Image.FromFile(OFD.FileName)
                image1.BackgroundImage = pic1
                image1.Width = pic1.Width : image1.Height = pic1.Height
                MG5(sender, e)
                If mg3.Text = "1" Then
                    If pic3.Width < pic1.Width Or pic3.Height < pic1.Height Then
                        image2.BackgroundImage = Nothing : mg3.Text = "0" : x03.Text = "0" : y03.Text = "0" : x03.ReadOnly = True : y03.ReadOnly = True
                    End If
                End If
                x0.Text = "" : x0.Text = "0" : y0.Text = "0"
                xMax.Text = pic1.Width : yMax.Text = pic1.Height
            Else
                MsgBox("غير مسموح بصورة أقل من 16*16")
            End If
        End If
    End Sub

    Private Sub Img2_Click(sender As Object, e As EventArgs) Handles loadBackground1.Click
        On Error Resume Next
        If OFD.ShowDialog() = DialogResult.OK Then
            If Image.FromFile(OFD.FileName).Width >= 16 And Image.FromFile(OFD.FileName).Height >= 16 Then
                If Image.FromFile(OFD.FileName).Width < pic1.Width Or Image.FromFile(OFD.FileName).Height < pic1.Height Then
                    MsgBox("الصورة أصغر من الصورة الرئيسية")
                Else
                    pic2 = Image.FromFile(OFD.FileName)
                    background1.BackColor = Nothing
                    background1.BackgroundImage = pic2 : mg2.Text = 1
                    background1.Width = pic2.Width : background1.Height = pic2.Height
                    x2.Text = "0" : y2.Text = "0"
                    If pic2.Width > pic1.Width Then
                        x2.ReadOnly = False
                    Else
                        x2.ReadOnly = True
                    End If
                    If pic2.Height > pic1.Height Then
                        y2.ReadOnly = False
                    Else
                        y2.ReadOnly = True
                    End If
                    MG5(sender, e)
                End If
            Else
                MsgBox("غير مسموح بصورة أقل من 16*16")
            End If
        End If
    End Sub

    Private Sub Img3_Click(sender As Object, e As EventArgs) Handles loadImage2.Click
        On Error Resume Next
        If OFD.ShowDialog() = DialogResult.OK Then
            If Image.FromFile(OFD.FileName).Width >= 16 And Image.FromFile(OFD.FileName).Height >= 16 Then
                If Image.FromFile(OFD.FileName).Width < pic1.Width Or Image.FromFile(OFD.FileName).Height < pic1.Height Then
                    MsgBox("الصورة أصغر من الصورة الرئيسية")
                Else
                    pic3 = Image.FromFile(OFD.FileName)
                    image2.BackgroundImage = pic3
                    image2.Width = pic3.Width : image2.Height = pic3.Height
                    x03.Text = "0" : y03.Text = "0"
                    If pic3.Width > pic1.Width Then
                        x03.ReadOnly = False
                    Else
                        x03.ReadOnly = True
                    End If
                    If pic3.Height > pic1.Height Then
                        y03.ReadOnly = False
                    Else
                        y03.ReadOnly = True
                    End If
                    MG5(sender, e) : mg3.Text = "1"
                    x0.Text = "" : x0.Text = "0" : y0.Text = "0"
                End If
            Else
                MsgBox("غير مسموح بصورة أقل من 16*16")
            End If
        End If
    End Sub

    Private Sub Img4_Click(sender As Object, e As EventArgs) Handles loadBackground2.Click
        If OFD.ShowDialog() = DialogResult.OK Then
            If Image.FromFile(OFD.FileName).Width >= 16 And Image.FromFile(OFD.FileName).Height >= 16 Then
                If Image.FromFile(OFD.FileName).Width < pic1.Width Or Image.FromFile(OFD.FileName).Height < pic1.Height Then
                    MsgBox("الصورة أصغر من الصورة الرئيسية")
                Else
                    pic4 = Image.FromFile(OFD.FileName)
                    background2.BackColor = Nothing
                    background2.BackgroundImage = pic4 : mg4.Text = 1
                    background2.Width = pic4.Width : background2.Height = pic4.Height
                    x4.Text = "0" : y4.Text = "0"
                    If pic4.Width > pic1.Width Then
                        x4.ReadOnly = False
                    Else
                        x4.ReadOnly = True
                    End If
                    If pic4.Height > pic1.Height Then
                        y4.ReadOnly = False
                    Else
                        y4.ReadOnly = True
                    End If
                    MG5(sender, e)
                End If
            Else
                MsgBox("غير مسموح بصورة أقل من 16*16")
            End If
        End If
    End Sub

    Private Sub RGB1(sender As Object, e As EventArgs) Handles redDecimal2.TextChanged, greenDecimal2.TextChanged, blueDecimal2.TextChanged
        If redDecimal2.Text = "" Or greenDecimal2.Text = "" Or blueDecimal2.Text = "" Then
        Else
            If redDecimal2.Text > 255 Then
                redDecimal2.Text = 255
            End If
            If greenDecimal2.Text > 255 Then
                greenDecimal2.Text = 255
            End If
            If blueDecimal2.Text > 255 Then
                blueDecimal2.Text = 255
            End If
            nl = redDecimal2.Text : Nuli(sender, e) : redHexadecimal2.Text = nl
            nl = greenDecimal2.Text : Nuli(sender, e) : greenHexadecimal2.Text = nl
            nl = blueDecimal2.Text : Nuli(sender, e) : blueHexadecimal2.Text = nl
            pic2 = Nothing : mg2.Text = 0
            background1.BackgroundImage = Nothing : background1.BackColor = Color.FromArgb(redDecimal2.Text, greenDecimal2.Text, blueDecimal2.Text)
            x2.Text = "0" : y2.Text = "0" : x2.ReadOnly = True : y2.ReadOnly = True
            r5.Text = redDecimal2.Text : g5.Text = greenDecimal2.Text : b5.Text = blueDecimal2.Text
        End If
    End Sub

    Private Sub RGB2(sender As Object, e As EventArgs) Handles redDecimal4.TextChanged, greenDecimal4.TextChanged, blueDecimal4.TextChanged
        If redDecimal4.Text = "" Or greenDecimal4.Text = "" Or blueDecimal4.Text = "" Then
        Else
            If redDecimal4.Text > 255 Then
                redDecimal4.Text = 255
            End If
            If greenDecimal4.Text > 255 Then
                greenDecimal4.Text = 255
            End If
            If blueDecimal4.Text > 255 Then
                blueDecimal4.Text = 255
            End If
            nl = redDecimal4.Text : Nuli(sender, e) : redHexadecimal4.Text = nl
            nl = greenDecimal4.Text : Nuli(sender, e) : greenHexadecimal4.Text = nl
            nl = blueDecimal4.Text : Nuli(sender, e) : blueHexadecimal4.Text = nl
            pic4 = Nothing : mg4.Text = 0
            background2.BackgroundImage = Nothing : background2.BackColor = Color.FromArgb(redDecimal4.Text, greenDecimal4.Text, blueDecimal4.Text)
            x4.Text = "0" : y4.Text = "0" : x4.ReadOnly = True : y4.ReadOnly = True
            r6.Text = redDecimal4.Text : g6.Text = greenDecimal4.Text : b6.Text = blueDecimal4.Text
        End If
    End Sub

    Private Sub RGB3(sender As Object, e As EventArgs) Handles redHexadecimal2.TextChanged, greenHexadecimal2.TextChanged, blueHexadecimal2.TextChanged
        If Len(Trim$(redHexadecimal2.Text)) = 2 And Len(Trim$(greenHexadecimal2.Text)) = 2 And Len(Trim$(blueHexadecimal2.Text)) = 2 Then
            nl = redHexadecimal2.Text : Linu(sender, e) : redDecimal2.Text = nl
            nl = greenHexadecimal2.Text : Linu(sender, e) : greenDecimal2.Text = nl
            nl = blueHexadecimal2.Text : Linu(sender, e) : blueDecimal2.Text = nl
        End If
    End Sub

    Private Sub RGB4(sender As Object, e As EventArgs) Handles redHexadecimal4.TextChanged, greenHexadecimal4.TextChanged, blueHexadecimal4.TextChanged
        If Len(Trim$(redHexadecimal4.Text)) = 2 And Len(Trim$(greenHexadecimal4.Text)) = 2 And Len(Trim$(blueHexadecimal4.Text)) = 2 Then
            nl = redHexadecimal4.Text : Linu(sender, e) : redDecimal4.Text = nl
            nl = greenHexadecimal4.Text : Linu(sender, e) : greenDecimal4.Text = nl
            nl = blueHexadecimal4.Text : Linu(sender, e) : blueDecimal4.Text = nl
        End If
    End Sub

    Private Sub XY0_TextChanged(sender As Object, e As EventArgs) Handles x0.TextChanged, y0.TextChanged
        If x0.Text = "" Or y0.Text = "" Then
        ElseIf x0.Text >= background1.Width Or y0.Text >= background1.Height Or x0.Text >= background2.Width Or y0.Text >= background2.Height Then

        Else
            q1 = x0.Text : q2 = y0.Text
            Dim P5 As Color = pic1.GetPixel(q1, q2)
            redDecimal2.Text = "" : redDecimal2.Text = P5.R : greenDecimal2.Text = P5.G : blueDecimal2.Text = P5.B
            If mg3.Text = "1" Then
                If x03.Text = "" Then
                    x03.Text = "0"
                End If
                If y03.Text = "" Then
                    y03.Text = "0"
                End If
                p31 = x03.Text : p32 = y03.Text
                If p31 + pic1.Width > pic3.Width Then
                    p31 = pic3.Width - pic1.Width : x03.Text = p31
                End If
                If p32 + pic1.Height > pic3.Height Then
                    p32 = pic3.Height - pic1.Height : y03.Text = p32
                End If
                Dim P6 As Color = pic3.GetPixel(q1 + p31, q2 + p32)
                redDecimal4.Text = "" : redDecimal4.Text = P6.R : greenDecimal4.Text = P6.G : blueDecimal4.Text = P6.B
            Else
                redDecimal4.Text = "" : redDecimal4.Text = "255" : greenDecimal4.Text = "255" : blueDecimal4.Text = "255"
            End If
        End If
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

    Private Sub Nuli(sender As Object, e As EventArgs) ' تحويل الأرقام لحروف
        nmp1 = nl / 16
        nmp2 = nmp1
        If nmp2 > nmp1 Then
            nmp2 -= 1
        End If
        tt = nmp2
        If nmp2 = 10 Then
            tt = "a"
        ElseIf nmp2 = 11 Then
            tt = "b"
        ElseIf nmp2 = 12 Then
            tt = "c"
        ElseIf nmp2 = 13 Then
            tt = "d"
        ElseIf nmp2 = 14 Then
            tt = "e"
        ElseIf nmp2 = 15 Then
            tt = "f"
        End If
        nl = tt
        nmp1 = (nmp1 - nmp2) * 16
        nmp2 = nmp1 : tt = nmp2
        If nmp2 = 10 Then
            tt = "a"
        ElseIf nmp2 = 11 Then
            tt = "b"
        ElseIf nmp2 = 12 Then
            tt = "c"
        ElseIf nmp2 = 13 Then
            tt = "d"
        ElseIf nmp2 = 14 Then
            tt = "e"
        ElseIf nmp2 = 15 Then
            tt = "f"
        End If
        nl += tt
    End Sub

    Private Sub Linu(sender As Object, e As EventArgs) 'تحويل الحروف لأرقام
        gh = nl.ToList(0)
        If gh = "a" Or gh = "A" Then
            nmp2 = 160
        ElseIf gh = "b" Or gh = "B" Then
            nmp2 = 176
        ElseIf gh = "c" Or gh = "C" Then
            nmp2 = 192
        ElseIf gh = "d" Or gh = "D" Then
            nmp2 = 208
        ElseIf gh = "e" Or gh = "E" Then
            nmp2 = 224
        ElseIf gh = "0" Or gh = "1" Or gh = "2" Or gh = "3" Or gh = "4" Or gh = "5" Or gh = "6" Or gh = "7" Or gh = "8" Or gh = "9" Then
            nmp2 = gh
            nmp2 *= 16
        Else
            nmp2 = 240 ' gh = "f"
        End If
        gh = nl.ToList(1)
        If gh = "a" Or gh = "A" Then
            nmp2 += 10
        ElseIf gh = "b" Or gh = "B" Then
            nmp2 += 11
        ElseIf gh = "c" Or gh = "C" Then
            nmp2 += 12
        ElseIf gh = "d" Or gh = "D" Then
            nmp2 += 13
        ElseIf gh = "e" Or gh = "E" Then
            nmp2 += 14
        ElseIf gh = "0" Or gh = "1" Or gh = "2" Or gh = "3" Or gh = "4" Or gh = "5" Or gh = "6" Or gh = "7" Or gh = "8" Or gh = "9" Then
            nmp3 = gh
            nmp2 += nmp3
        Else
            nmp2 += 15 ' gh = "f"
        End If
        nl = nmp2
    End Sub
End Class
