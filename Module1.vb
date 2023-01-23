Imports System.Data.OleDb

Module Module1

    Public cmd As OleDbCommand
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public rd As OleDbDataReader
    Public conn As OleDbConnection
    Public lokasidb As String
    Public perintah As String


    Sub koneksi()
        Try
            lokasidb = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =DbUAS.accdb"
            conn = New OleDbConnection(lokasidb)
            If conn.State = ConnectionState.Closed Then conn.Open()
        Catch ex As Exception
            MsgBox("Koneksi Database Gagal", MsgBoxStyle.OkOnly, "Informasi")
        End Try
        

    End Sub

    Sub unkoneksi()
        conn.Close()
    End Sub

End Module
