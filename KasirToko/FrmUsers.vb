Imports System.Data.OleDb
Public Class FrmUsers
    Dim baru As Boolean = True
    Dim UserId As Integer

    Sub DataView()
        'tampilkan data di DataGridView
        Try
            koneksi()
            Tabel = New OleDbDataAdapter("SELECT * FROM Users", Database)
            Data = New DataSet
            Tabel.Fill(Data)
            Record.DataSource = Data
            Record.DataMember = Data.Tables(0).ToString
            DgvUsers.DataSource = Record

            DgvUsers.Columns(0).Width = 75
            DgvUsers.Columns(1).Width = 100
            DgvUsers.Columns(3).Width = 50

            DgvUsers.Columns(2).Visible = False

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub FrmAwal()
        TxtUsername.Text = ""
        TxtPassword.Text = ""
        TxtUsername.ReadOnly = True
        TxtPassword.ReadOnly = True
        CbAdmin.Checked = False
        CbAdmin.Enabled = False

        BtnEdit.Enabled = False
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = False
    End Sub

    Private Sub FrmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmAwal()
        DataView()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TxtUsername.Text.Equals("") Then TxtUsername.Focus() : Exit Sub
        If TxtPassword.Text.Equals("") Then TxtPassword.Focus() : Exit Sub

        Dim isAdmin As Integer = IIf(CbAdmin.Checked = True, 1, 0)
        Dim pesan As String

        Try
            Call koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            If baru.Equals(True) Then
                'baru
                pesan = "Data berhasil ditambahkan"
                DML.CommandText = "INSERT INTO Users(username, [password], admin) VALUES ('" & TxtUsername.Text & "','" & TxtPassword.Text & "'," & isAdmin & ")"
            Else
                'edit
                pesan = "Data berhasil diperbarui"
                DML.CommandText = "UPDATE Users SET username='" & TxtUsername.Text & "', [password]='" & TxtPassword.Text & "', admin=" & isAdmin & " WHERE iduser=" & UserId & ""
            End If

            DML.ExecuteNonQuery()
            MsgBox(pesan)
            DataView()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        FrmAwal()
    End Sub

    Private Sub DgvUsers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUsers.CellDoubleClick
        'ambil data utk ditampilkan di form
        Try
            Dim i As Integer
            Dim isAdmin As Integer

            i = e.RowIndex
            isAdmin = DgvUsers.Rows(i).Cells(3).Value

            UserId = DgvUsers.Rows(i).Cells(0).Value
            TxtUsername.Text = DgvUsers.Rows(i).Cells(1).Value
            TxtPassword.Text = DgvUsers.Rows(i).Cells(2).Value

            If isAdmin = 1 Then
                CbAdmin.Checked = True
            Else
                CbAdmin.Checked = False
            End If

            'enable-disable tombol
            BtnBaru.Enabled = True
            BtnEdit.Enabled = True
            BtnHapus.Enabled = True

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnBaru_Click(sender As Object, e As EventArgs) Handles BtnBaru.Click
        baru = True
        BtnSimpan.Text = "Simpan"
        BtnSimpan.Enabled = True
        TxtUsername.ReadOnly = False
        TxtUsername.Focus()
        TxtPassword.ReadOnly = False
        CbAdmin.Enabled = True
        'buka form tambah
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        baru = False
        BtnSimpan.Text = "Update"
        BtnSimpan.Enabled = True
        TxtUsername.ReadOnly = False
        TxtUsername.Focus()
        TxtPassword.ReadOnly = False
        CbAdmin.Enabled = True
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If TxtUsername.Text.Equals("admin") Then
            MsgBox("Admin yang ini tidak boleh dihapus!")
            Exit Sub
        End If

        Try
            koneksi()
            DML.Connection = Database
            DML.CommandType = CommandType.Text
            DML.CommandText = "DELETE FROM Users WHERE iduser=" & UserId & ""
            DML.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus.")

            DataView()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        FrmAwal()
    End Sub
End Class