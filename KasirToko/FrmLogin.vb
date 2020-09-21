Public Class FrmLogin
    Public Property usrName As String
    Public Property isAdmin As Integer

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtUsername.Text.Equals("") And TxtPassword.Text.Equals("") Then
            MsgBox("Username dan Password HARUS diisi!")
            TxtPassword.Text = ""
            TxtUsername.Text = ""
            TxtUsername.Focus()
        Else
            Dim uname As String = System.Text.RegularExpressions.Regex.Replace(TxtUsername.Text, "[^0-9a-zA-Z]+", "")
            Dim upass As String = System.Text.RegularExpressions.Regex.Replace(TxtPassword.Text, "[^0-9a-zA-Z]+", "")
            Dim dr As OleDb.OleDbDataReader

            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "SELECT * FROM Users WHERE username='" & uname & "' AND password='" & upass & "'"
            dr = DML.ExecuteReader

            If dr.Read Then
                usrName = dr.Item(1).ToString
                isAdmin = Integer.Parse(dr.Item(3).ToString)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MsgBox("Login Gagal! Username dan Password tidak sesuai.")
                TxtUsername.Text = ""
                TxtPassword.Text = ""
                TxtUsername.Focus()
            End If
            dr.Close()
        End If
    End Sub

End Class
