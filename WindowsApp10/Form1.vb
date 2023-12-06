Public Class Form1
    Dim hm As String = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData.Replace("0.0.0.0", "")
    Dim rd1 As New Random
    Dim pic1, pic2, pic3, pic4, pic5 As Bitmap
    Dim folderPath, file As String
    Dim aaaa As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(hm + "lang") Then Lg2(sender, e)

        If rd1.Next(0, 2) = 1 Then
            Label1.BackColor = Color.Lime : Label3.BackColor = Color.Lime
            Label6.BackColor = Color.Yellow : Label7.BackColor = Color.Yellow
        End If

        If My.Computer.FileSystem.FileExists(hm + "ab") Then T2.Stop()
        T1.Start()
    End Sub

    Private Sub Pg(sender As Object, e As KeyPressEventArgs) Handles x0.KeyPress, y0.KeyPress, x02.KeyPress, y02.KeyPress, x03.KeyPress, y03.KeyPress, x04.KeyPress, y04.KeyPress, r1.KeyPress, g1.KeyPress, b1.KeyPress, r2.KeyPress, g2.KeyPress, b2.KeyPress
        If e.KeyChar = "0" Or e.KeyChar = "1" Or e.KeyChar = "2" Or e.KeyChar = "3" Or e.KeyChar = "4" Or e.KeyChar = "5" Or e.KeyChar = "6" Or e.KeyChar = "7" Or e.KeyChar = "8" Or e.KeyChar = "9" Or e.KeyChar = "" Then
            Exit Sub
        Else
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Pg2(sender As Object, e As KeyPressEventArgs) Handles r3.KeyPress, g3.KeyPress, b3.KeyPress, r4.KeyPress, g4.KeyPress, b4.KeyPress
        If e.KeyChar = "0" Or e.KeyChar = "1" Or e.KeyChar = "2" Or e.KeyChar = "3" Or e.KeyChar = "4" Or e.KeyChar = "5" Or e.KeyChar = "6" Or e.KeyChar = "7" Or e.KeyChar = "8" Or e.KeyChar = "9" Or e.KeyChar = "a" Or e.KeyChar = "b" Or e.KeyChar = "c" Or e.KeyChar = "d" Or e.KeyChar = "e" Or e.KeyChar = "f" Or e.KeyChar = "A" Or e.KeyChar = "B" Or e.KeyChar = "C" Or e.KeyChar = "D" Or e.KeyChar = "E" Or e.KeyChar = "F" Or e.KeyChar = "" Then
            Exit Sub
        Else
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Pg3(sender As Object, e As KeyPressEventArgs) Handles cb3.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub Wh1(sender As Object, e As EventArgs)
        x8 = rd1.Next(0, 256)
    End Sub

    Private Sub Cb6_ChCh(sender As Object, e As EventArgs)
        cb6.Visible = False
        SR.Visible = True
        num.Visible = True
        My.Computer.FileSystem.WriteAllText(hm + "err", "9", False)
    End Sub

    Private Sub start1_Click(sender As Object, e As EventArgs)
        pic1 = Image.FromFile(folderPath + "\" + ListBox1.Items(aaaa))
        aaaa += 1
        PB1.BackgroundImage = pic1
        PB1.Width = pic1.Width : PB1.Height = pic1.Height
        MG5(sender, e)
        If mg3.Text = "1" Then
            If pic3.Width < pic1.Width Or pic3.Height < pic1.Height Then
                PB3.BackgroundImage = Nothing : mg3.Text = "0" : x03.Text = "0" : y03.Text = "0" : x03.ReadOnly = True : y03.ReadOnly = True
            End If
        End If
        x0.Text = "" : x0.Text = "0" : y0.Text = "0"
        xm.Text = pic1.Width : ym.Text = pic1.Height



        Img1.Enabled = False : Img2.Enabled = False : Img3.Enabled = False : Img4.Enabled = False : st.Enabled = False : sv.Enabled = False : num.Enabled = False : x0.Enabled = False : y0.Enabled = False : r1.Enabled = False : g1.Enabled = False : b1.Enabled = False : r2.Enabled = False : g2.Enabled = False : b2.Enabled = False : r3.Enabled = False : g3.Enabled = False : b3.Enabled = False : r4.Enabled = False : g4.Enabled = False : b4.Enabled = False
        If x02.Text = "" Then
            x02.Text = "0"
        End If
        If y02.Text = "" Then
            y02.Text = "0"
        End If
        If x03.Text = "" Then
            x03.Text = "0"
        End If
        If y03.Text = "" Then
            y03.Text = "0"
        End If
        If x04.Text = "" Then
            x04.Text = "0"
        End If
        If y04.Text = "" Then
            y04.Text = "0"
        End If
        p21 = x02.Text : p22 = y02.Text : p31 = x03.Text : p32 = y03.Text : p41 = x04.Text : p42 = y04.Text
        If p31 + pic1.Width > pic3.Width Then
            p31 = pic3.Width - pic1.Width : x03.Text = p31
        End If
        If p32 + pic1.Height > pic3.Height Then
            p32 = pic3.Height - pic1.Height : y03.Text = p32
        End If
        If mg2.Text = "1" Then
            If p21 + pic1.Width > pic2.Width Then
                p21 = pic2.Width - pic1.Width : x02.Text = p21
            End If
            If p22 + pic1.Height > pic2.Height Then
                p22 = pic2.Height - pic1.Height : y02.Text = p22
            End If
        End If
        If mg4.Text = "1" Then
            If p41 + pic1.Width > pic4.Width Then
                p41 = pic4.Width - pic1.Width : x04.Text = p41
            End If
            If p42 + pic1.Height > pic4.Height Then
                p42 = pic4.Height - pic1.Height : y04.Text = p42
            End If
        End If
        PB5.BackgroundImage = Nothing
        qw = 0 : xmm = xm.Text : ymm = ym.Text
        q1 = (xmm * ymm) / ((num.SelectedIndex + 1) * 100)
        Lb2.Text = q1
        q1 = 0 : q2 = 0
        Dim Bb5 As New Bitmap(xmm, ymm)
        Dim G5 As Graphics = Graphics.FromImage(Bb5)
        G5.DrawImage(My.Resources.trpt2, 0, 0)
        PB5.BackgroundImage = Bb5 : PB5.Width = xmm : PB5.Height = ymm
        pic5 = PB5.BackgroundImage : nl = "" : k2 = 0
        T3.Start()




    End Sub

    Private Sub Folder_Click(sender As Object, e As EventArgs) Handles folder.Click
        If FBD.ShowDialog = DialogResult.OK Then
            folderPath = FBD.SelectedPath
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(folderPath)
                file = My.Computer.FileSystem.GetName(foundFile)
                Dim fi As New IO.FileInfo(file)
                ' format = fi.Extension.ToLower
                ListBox1.Items.Add(file)
            Next
        End If
    End Sub

    Private Sub Lg2(sender As Object, e As EventArgs) Handles lg.Click
        If lg.Text = "English" Then
            lg.Text = "عربي"
            My.Computer.FileSystem.WriteAllText(hm + "lang", "1", False)

        ElseIf lg.Text = "عربي" Then
            lg.Text = "English"
            Kill(hm + "lang")

        End If
    End Sub

    Private Sub Lwh_Click(sender As Object, e As EventArgs) Handles Lwh.Click
        T1.Start()
    End Sub

    Private Sub T1_Tick(sender As Object, e As EventArgs) Handles T1.Tick
        T1.Stop()
        If Img1.Enabled = True Then
            If x9 = 0 Then
                x9 = 1
                Wh1(sender, e)
                r1.Text = x8
                Wh1(sender, e)
                g1.Text = x8
                Wh1(sender, e)
                b1.Text = x8
                Dim Bb5 As New Bitmap(256, 256)
                Dim G5 As Graphics = Graphics.FromImage(Bb5)
                G5.Clear(Color.FromArgb(r1.Text, g1.Text, b1.Text))
                G5.DrawImage(My.Resources.zx0, 0, 0)
                PB1.BackgroundImage = Bb5
                pic1 = Bb5
                T1.Start()
            ElseIf x9 = 1 Then
                x9 = 2
                Wh1(sender, e)
                r2.Text = x8
                Wh1(sender, e)
                g2.Text = x8
                Wh1(sender, e)
                b2.Text = x8
                Dim Bb5 As New Bitmap(256, 256)
                Dim G5 As Graphics = Graphics.FromImage(Bb5)
                G5.Clear(Color.FromArgb(r2.Text, g2.Text, b2.Text))
                G5.DrawImage(My.Resources.zx0, 0, 0)
                PB3.BackgroundImage = Bb5 : mg3.Text = "1"
                pic3 = Bb5
                T1.Start()
            ElseIf x9 = 2 Then
                x9 = 0
                Dim Bb5 As New Bitmap(256, 256)
                Dim G5 As Graphics = Graphics.FromImage(Bb5)
                G5.DrawImage(My.Resources.trpt2, 0, 0)
                G5.DrawImage(My.Resources.zx0, 0, 0)
                PB5.BackgroundImage = Bb5
                pic5 = My.Resources.zx0
            End If
            y0.Text = "0"
            x0.Text = "0"
        End If
    End Sub

    Private Sub VSB_Scroll(sender As Object, e As ScrollEventArgs) Handles VSB.Scroll
        PB1.Top = VSB.Value * (150 - PB1.Height) / 90
        PB2.Top = VSB.Value * (150 - PB2.Height) / 90
        PB3.Top = VSB.Value * (150 - PB3.Height) / 90
        PB4.Top = VSB.Value * (150 - PB4.Height) / 90
        PB5.Top = VSB.Value * (150 - PB5.Height) / 90
    End Sub

    Private Sub HSB_Scroll(sender As Object, e As ScrollEventArgs) Handles HSB.Scroll
        PB1.Left = HSB.Value * (150 - PB1.Width) / 90
        PB2.Left = HSB.Value * (150 - PB2.Width) / 90
        PB3.Left = HSB.Value * (150 - PB3.Width) / 90
        PB4.Left = HSB.Value * (150 - PB4.Width) / 90
        PB5.Left = HSB.Value * (150 - PB5.Width) / 90
    End Sub

    Private Sub Lbl_Click(sender As Object, e As EventArgs) Handles lbl.Click
        T2.Stop()
        Html2.Show()
        My.Computer.FileSystem.WriteAllText(hm + "ab", "1", False)
    End Sub

    Private Sub Sg_Click(sender As Object, e As EventArgs) Handles sg.Click
        Process.Start("http://www.mediafire.com/file/0wv97m4n96q5y0v")
    End Sub

    Private Sub Sv_Click(sender As Object, e As EventArgs) Handles sv.Click
        If cb3.Text = "ico" Then
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

    Private Sub St_Click(sender As Object, e As EventArgs) Handles st.Click
        If mg3.Text = "1" Then
            Img1.Enabled = False : Img2.Enabled = False : Img3.Enabled = False : Img4.Enabled = False : st.Enabled = False : sv.Enabled = False : num.Enabled = False : x0.Enabled = False : y0.Enabled = False : r1.Enabled = False : g1.Enabled = False : b1.Enabled = False : r2.Enabled = False : g2.Enabled = False : b2.Enabled = False : r3.Enabled = False : g3.Enabled = False : b3.Enabled = False : r4.Enabled = False : g4.Enabled = False : b4.Enabled = False
            If x02.Text = "" Then
                x02.Text = "0"
            End If
            If y02.Text = "" Then
                y02.Text = "0"
            End If
            If x03.Text = "" Then
                x03.Text = "0"
            End If
            If y03.Text = "" Then
                y03.Text = "0"
            End If
            If x04.Text = "" Then
                x04.Text = "0"
            End If
            If y04.Text = "" Then
                y04.Text = "0"
            End If
            p21 = x02.Text : p22 = y02.Text : p31 = x03.Text : p32 = y03.Text : p41 = x04.Text : p42 = y04.Text
            If p31 + pic1.Width > pic3.Width Then
                p31 = pic3.Width - pic1.Width : x03.Text = p31
            End If
            If p32 + pic1.Height > pic3.Height Then
                p32 = pic3.Height - pic1.Height : y03.Text = p32
            End If
            If mg2.Text = "1" Then
                If p21 + pic1.Width > pic2.Width Then
                    p21 = pic2.Width - pic1.Width : x02.Text = p21
                End If
                If p22 + pic1.Height > pic2.Height Then
                    p22 = pic2.Height - pic1.Height : y02.Text = p22
                End If
            End If
            If mg4.Text = "1" Then
                If p41 + pic1.Width > pic4.Width Then
                    p41 = pic4.Width - pic1.Width : x04.Text = p41
                End If
                If p42 + pic1.Height > pic4.Height Then
                    p42 = pic4.Height - pic1.Height : y04.Text = p42
                End If
            End If
            PB5.BackgroundImage = Nothing
            qw = 0 : xmm = xm.Text : ymm = ym.Text
            q1 = (xmm * ymm) / ((num.SelectedIndex + 1) * 100)
            Lb2.Text = q1
            q1 = 0 : q2 = 0
            Dim Bb5 As New Bitmap(xmm, ymm)
            Dim G5 As Graphics = Graphics.FromImage(Bb5)
            G5.DrawImage(My.Resources.trpt2, 0, 0)
            PB5.BackgroundImage = Bb5 : PB5.Width = xmm : PB5.Height = ymm
            pic5 = PB5.BackgroundImage : nl = "" : k2 = 0
            T3.Start()
        Else
            MsgBox("أضف الصورة الثانية أولاً")
        End If
    End Sub

    Private Sub TF(sender As Object, e As EventArgs)
        Lb1.Text = "0" : Lb2.Text = "∞"
        Img1.Enabled = True : Img2.Enabled = True : Img3.Enabled = True : Img4.Enabled = True : st.Enabled = True : sv.Enabled = True : num.Enabled = True : x0.Enabled = True : y0.Enabled = True : r1.Enabled = True : g1.Enabled = True : b1.Enabled = True : r2.Enabled = True : g2.Enabled = True : b2.Enabled = True : r3.Enabled = True : g3.Enabled = True : b3.Enabled = True : r4.Enabled = True : g4.Enabled = True : b4.Enabled = True
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
        PB5.BackgroundImage = Bb5 : TF(sender, e)
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
        PB1.Location = New Point(0, 0) : PB2.Location = New Point(0, 0) : PB3.Location = New Point(0, 0) : PB4.Location = New Point(0, 0) : PB5.Location = New Point(0, 0)
    End Sub

    Private Sub Img1_Click(sender As Object, e As EventArgs) Handles Img1.Click
        On Error Resume Next
        If OFD.ShowDialog() = DialogResult.OK Then
            If Image.FromFile(OFD.FileName).Width >= 16 And Image.FromFile(OFD.FileName).Height >= 16 Then
                pic1 = Image.FromFile(OFD.FileName)
                PB1.BackgroundImage = pic1
                PB1.Width = pic1.Width : PB1.Height = pic1.Height
                MG5(sender, e)
                If mg3.Text = "1" Then
                    If pic3.Width < pic1.Width Or pic3.Height < pic1.Height Then
                        PB3.BackgroundImage = Nothing : mg3.Text = "0" : x03.Text = "0" : y03.Text = "0" : x03.ReadOnly = True : y03.ReadOnly = True
                    End If
                End If
                x0.Text = "" : x0.Text = "0" : y0.Text = "0"
                xm.Text = pic1.Width : ym.Text = pic1.Height
            Else
                MsgBox("غير مسموح بصورة أقل من 16*16")
            End If
        End If
    End Sub

    Private Sub Img2_Click(sender As Object, e As EventArgs) Handles Img2.Click
        On Error Resume Next
        If OFD.ShowDialog() = DialogResult.OK Then
            If Image.FromFile(OFD.FileName).Width >= 16 And Image.FromFile(OFD.FileName).Height >= 16 Then
                If Image.FromFile(OFD.FileName).Width < pic1.Width Or Image.FromFile(OFD.FileName).Height < pic1.Height Then
                    MsgBox("الصورة أصغر من الصورة الرئيسية")
                Else
                    pic2 = Image.FromFile(OFD.FileName)
                    PB2.BackColor = Nothing
                    PB2.BackgroundImage = pic2 : mg2.Text = 1
                    PB2.Width = pic2.Width : PB2.Height = pic2.Height
                    x02.Text = "0" : y02.Text = "0"
                    If pic2.Width > pic1.Width Then
                        x02.ReadOnly = False
                    Else
                        x02.ReadOnly = True
                    End If
                    If pic2.Height > pic1.Height Then
                        y02.ReadOnly = False
                    Else
                        y02.ReadOnly = True
                    End If
                    MG5(sender, e)
                End If
            Else
                MsgBox("غير مسموح بصورة أقل من 16*16")
            End If
        End If
    End Sub

    Private Sub Img3_Click(sender As Object, e As EventArgs) Handles Img3.Click
        On Error Resume Next
        If OFD.ShowDialog() = DialogResult.OK Then
            If Image.FromFile(OFD.FileName).Width >= 16 And Image.FromFile(OFD.FileName).Height >= 16 Then
                If Image.FromFile(OFD.FileName).Width < pic1.Width Or Image.FromFile(OFD.FileName).Height < pic1.Height Then
                    MsgBox("الصورة أصغر من الصورة الرئيسية")
                Else
                    pic3 = Image.FromFile(OFD.FileName)
                    PB3.BackgroundImage = pic3
                    PB3.Width = pic3.Width : PB3.Height = pic3.Height
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

    Private Sub Img4_Click(sender As Object, e As EventArgs) Handles Img4.Click
        If OFD.ShowDialog() = DialogResult.OK Then
            If Image.FromFile(OFD.FileName).Width >= 16 And Image.FromFile(OFD.FileName).Height >= 16 Then
                If Image.FromFile(OFD.FileName).Width < pic1.Width Or Image.FromFile(OFD.FileName).Height < pic1.Height Then
                    MsgBox("الصورة أصغر من الصورة الرئيسية")
                Else
                    pic4 = Image.FromFile(OFD.FileName)
                    PB4.BackColor = Nothing
                    PB4.BackgroundImage = pic4 : mg4.Text = 1
                    PB4.Width = pic4.Width : PB4.Height = pic4.Height
                    x04.Text = "0" : y04.Text = "0"
                    If pic4.Width > pic1.Width Then
                        x04.ReadOnly = False
                    Else
                        x04.ReadOnly = True
                    End If
                    If pic4.Height > pic1.Height Then
                        y04.ReadOnly = False
                    Else
                        y04.ReadOnly = True
                    End If
                    MG5(sender, e)
                End If
            Else
                MsgBox("غير مسموح بصورة أقل من 16*16")
            End If
        End If
    End Sub

    Private Sub RGB1(sender As Object, e As EventArgs) Handles r1.TextChanged, g1.TextChanged, b1.TextChanged
        If r1.Text = "" Or g1.Text = "" Or b1.Text = "" Then
        Else
            If r1.Text > 255 Then
                r1.Text = 255
            End If
            If g1.Text > 255 Then
                g1.Text = 255
            End If
            If b1.Text > 255 Then
                b1.Text = 255
            End If
            nl = r1.Text : Nuli(sender, e) : r3.Text = nl
            nl = g1.Text : Nuli(sender, e) : g3.Text = nl
            nl = b1.Text : Nuli(sender, e) : b3.Text = nl
            pic2 = Nothing : mg2.Text = 0
            PB2.BackgroundImage = Nothing : PB2.BackColor = Color.FromArgb(r1.Text, g1.Text, b1.Text)
            x02.Text = "0" : y02.Text = "0" : x02.ReadOnly = True : y02.ReadOnly = True
            r5.Text = r1.Text : g5.Text = g1.Text : b5.Text = b1.Text
        End If
    End Sub

    Private Sub RGB2(sender As Object, e As EventArgs) Handles r2.TextChanged, g2.TextChanged, b2.TextChanged
        If r2.Text = "" Or g2.Text = "" Or b2.Text = "" Then
        Else
            If r2.Text > 255 Then
                r2.Text = 255
            End If
            If g2.Text > 255 Then
                g2.Text = 255
            End If
            If b2.Text > 255 Then
                b2.Text = 255
            End If
            nl = r2.Text : Nuli(sender, e) : r4.Text = nl
            nl = g2.Text : Nuli(sender, e) : g4.Text = nl
            nl = b2.Text : Nuli(sender, e) : b4.Text = nl
            pic4 = Nothing : mg4.Text = 0
            PB4.BackgroundImage = Nothing : PB4.BackColor = Color.FromArgb(r2.Text, g2.Text, b2.Text)
            x04.Text = "0" : y04.Text = "0" : x04.ReadOnly = True : y04.ReadOnly = True
            r6.Text = r2.Text : g6.Text = g2.Text : b6.Text = b2.Text
        End If
    End Sub

    Private Sub RGB3(sender As Object, e As EventArgs) Handles r3.TextChanged, g3.TextChanged, b3.TextChanged
        If Len(Trim$(r3.Text)) = 2 And Len(Trim$(g3.Text)) = 2 And Len(Trim$(b3.Text)) = 2 Then
            nl = r3.Text : Linu(sender, e) : r1.Text = nl
            nl = g3.Text : Linu(sender, e) : g1.Text = nl
            nl = b3.Text : Linu(sender, e) : b1.Text = nl
        End If
    End Sub

    Private Sub RGB4(sender As Object, e As EventArgs) Handles r4.TextChanged, g4.TextChanged, b4.TextChanged
        If Len(Trim$(r4.Text)) = 2 And Len(Trim$(g4.Text)) = 2 And Len(Trim$(b4.Text)) = 2 Then
            nl = r4.Text : Linu(sender, e) : r2.Text = nl
            nl = g4.Text : Linu(sender, e) : g2.Text = nl
            nl = b4.Text : Linu(sender, e) : b2.Text = nl
        End If
    End Sub

    Private Sub XY0_TextChanged(sender As Object, e As EventArgs) Handles x0.TextChanged, y0.TextChanged
        If x0.Text = "" Or y0.Text = "" Then
        ElseIf x0.Text >= PB2.Width Or y0.Text >= PB2.Height Or x0.Text >= PB4.Width Or y0.Text >= PB4.Height Then

        Else
            q1 = x0.Text : q2 = y0.Text
            Dim P5 As Color = pic1.GetPixel(q1, q2)
            r1.Text = "" : r1.Text = P5.R : g1.Text = P5.G : b1.Text = P5.B
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
                r2.Text = "" : r2.Text = P6.R : g2.Text = P6.G : b2.Text = P6.B
            Else
                r2.Text = "" : r2.Text = "255" : g2.Text = "255" : b2.Text = "255"
            End If
        End If
    End Sub

    Private Sub T2_Tick(sender As Object, e As EventArgs) Handles T2.Tick
        If lbl.ForeColor = Color.Black Then
            T2.Interval = 150
            lbl.ForeColor = Color.Red
        ElseIf lbl.ForeColor = Color.Red Then
            lbl.ForeColor = Color.Orange
        ElseIf lbl.ForeColor = Color.Orange Then
            lbl.ForeColor = Color.Yellow
        ElseIf lbl.ForeColor = Color.Yellow Then
            lbl.ForeColor = Color.Green
        ElseIf lbl.ForeColor = Color.Green Then
            lbl.ForeColor = Color.Cyan
        ElseIf lbl.ForeColor = Color.Cyan Then
            lbl.ForeColor = Color.Blue
        ElseIf lbl.ForeColor = Color.Blue Then
            lbl.ForeColor = Color.Purple
        ElseIf lbl.ForeColor = Color.Purple Then
            lbl.ForeColor = Color.Magenta
        ElseIf lbl.ForeColor = Color.Magenta Then
            T2.Interval = 4321
            lbl.ForeColor = Color.Black
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
