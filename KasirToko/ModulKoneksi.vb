Imports System.Data.OleDb

Module ModulKoneksi
    Public Database As OleDbConnection
    Public Tabel As OleDbDataAdapter
    Public Data As DataSet
    Public Record, Record2, RecordX As New BindingSource
    Public DML As New OleDbCommand
    Public Cari As OleDbDataReader

    Public Sub koneksi()
        Try
            Database = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=KasirToko.accdb;Persist Security Info=True;")
            Database.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
