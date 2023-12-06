Public Class Form3
    Private Sub cls2_Click(sender As Object, e As EventArgs) Handles cls2.Click
        T1.Stop()
    End Sub

    Private Sub TT(sender As Object, e As EventArgs)
        T1.Stop()
        sc.Text = "59"
        Close()
    End Sub


    Private Sub T1_Tick(sender As Object, e As EventArgs) Handles T1.Tick
        sc.Text -= 1
        If sc.Text = "0" Then
            Oo2(sender, e)
        End If
    End Sub

    Private Sub Oo2(sender As Object, e As EventArgs) Handles oo.Click
        If o3.Visible = True Then
            o3_Click(sender, e)
        Else
            o5_Click(sender, e)
        End If
        TT(sender, e)
    End Sub

    Private Sub clsC(sender As Object, e As EventArgs) Handles cls.Click
        op.Text = "0"
        TT(sender, e)
    End Sub

    Private Sub o1_Click(sender As Object, e As EventArgs) Handles o1.Click
        op.Text = "1"
        TT(sender, e)
    End Sub

    Private Sub o2_Click(sender As Object, e As EventArgs) Handles o2.Click
        op.Text = "2"
        TT(sender, e)
    End Sub

    Private Sub o3_Click(sender As Object, e As EventArgs) Handles o3.Click
        op.Text = "3"
        TT(sender, e)
    End Sub

    Private Sub o4_Click(sender As Object, e As EventArgs) Handles o4.Click
        op.Text = "4"
        TT(sender, e)
    End Sub

    Private Sub o5_Click(sender As Object, e As EventArgs) Handles o5.Click
        op.Text = "5"
        TT(sender, e)
    End Sub

    Private Sub CB2_ChCh(sender As Object, e As EventArgs) Handles CB2.CheckedChanged
        If CB2.Checked = False Then
            op4.Text = "0"
        Else
            op4.Text = "1"
        End If
    End Sub

    Private Sub Pg(sender As Object, e As KeyPressEventArgs) Handles r1.KeyPress, g1.KeyPress, b1.KeyPress, a1.KeyPress
        If e.KeyChar = "0" Or e.KeyChar = "1" Or e.KeyChar = "2" Or e.KeyChar = "3" Or e.KeyChar = "4" Or e.KeyChar = "5" Or e.KeyChar = "6" Or e.KeyChar = "7" Or e.KeyChar = "8" Or e.KeyChar = "9" Or e.KeyChar = "" Then
            Exit Sub
        Else
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Pg3(sender As Object, e As KeyPressEventArgs) Handles CB3.KeyPress, CB4.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub CB3_SeIn(sender As Object, e As EventArgs) Handles CB3.SelectedIndexChanged
        op2.Text = CB3.SelectedIndex
    End Sub

    Private Sub o6_Click(sender As Object, e As EventArgs) Handles o6.Click
        op.Text = "6"
        TT(sender, e)
    End Sub

    Private Sub cls3_Click(sender As Object, e As EventArgs) Handles cls3.Click
        clsC(sender, e)
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        T1.Start()
    End Sub
End Class