Public Class MDIParent1
    Public uname As String
    Public ustat As Integer

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        'Dim frm As New FrmLogin
        'frm.MdiParent = Me
        'frm.Show()
        Login()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click

    End Sub

    Private Sub Login()
        Dim frm As New FrmLogin

        If frm.ShowDialog = DialogResult.OK Then
            uname = frm.usrName
            ustat = frm.isAdmin

            LoginToolStripMenuItem.Enabled = False
            LogoutToolStripMenuItem.Enabled = True

            If ustat > 0 Then
                MenuAdmin()
            Else
                MenuKasir()
            End If
        Else
            LoginToolStripMenuItem.Enabled = True
            LogoutToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub MenuAdmin()
        'yg bisa diakses admin
    End Sub

    Private Sub MenuKasir()
        'yg bisa diakses kasir
    End Sub

    Private Sub MenuOff()
        'menu di-off saat logout
    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        'tutup menu
        'tampilkan form login
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        Dim frm As New FrmUsers
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
