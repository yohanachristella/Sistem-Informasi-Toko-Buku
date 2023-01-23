Imports System.Data.OleDb
Public Class FormLpJual

    Sub tampil8()
        Call koneksi()

        cmd = New OleDbCommand("select * from invoice_jual", conn)
        rd = cmd.ExecuteReader
        DGVLaporJual.Rows.Clear()
        Do While rd.Read = True
            DGVLaporJual.Rows.Add(rd.Item("no_invoicejual"), rd.Item("no_nota"), rd.Item("tanggal_jual"), rd.Item("id_user"), rd.Item("kode_buku"), rd.Item("jumlah_laku"), rd.Item("harga_jual"), rd.Item("sisa_stok"), rd.Item("total_pendapatan"))
        Loop
    End Sub
    Private Sub BtnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCetak.Click
        CrJual.ReportFileName = "LaporanJual.rpt"
        CrJual.WindowState = Crystal.WindowStateConstants.crptMaximized
        ' AxCrystalReport1.RetrieveDataFiles()
        CrJual.Action = 1
    End Sub

    Private Sub FormLpJual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbUASDataSet.invoice_jual' table. You can move, or remove it, as needed.
        Me.Invoice_jualTableAdapter.Fill(Me.DbUASDataSet.invoice_jual)

        Call koneksi()
        cmd = New OleDbCommand("select * from [invoice_jual] where no_invoicejual in (select max(no_invoicejual) from [invoice_jual] )", conn)
        Dim urut As String
        Dim hitung As String
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urut = "IJ" + "0521001"
        Else
            hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 7) + 1
            urut = "IJ" + Microsoft.VisualBasic.Right("0521000" & hitung, 7)
        End If
        LbNoJual.Text = urut

        Call koneksi()
        da = New OleDbDataAdapter("insert into [invoice_jual] values" & "('" & "','" & LbNoJual.Text & "')", conn)
        da.Fill(ds, "invoice_jual")


        Call koneksi()
        Dim str As String = "select * from [invoice_jual]"
        Dim dt As New DataTable
        da = New OleDb.OleDbDataAdapter(str, conn)
        dt = New DataTable
        da.Fill(dt)
        DGVLaporJual.DataSource = dt

    End Sub

    Private Sub BtnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUser.Click
        Me.Hide()
        FormUser.Show()
    End Sub

    Private Sub BtnMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMember.Click
        Me.Hide()
        FormMember.Show()
    End Sub

    Private Sub BtnBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuku.Click
        Me.Hide()
        FormBuku.Show()
    End Sub

    Private Sub BtnSuplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSuplier.Click
        Me.Hide()
        Formpemasok.Show()
    End Sub

    Private Sub BtnPenerbit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPenerbit.Click
        Me.Hide()
        FormPenerbit.Show()
    End Sub

    Private Sub BtnJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJual.Click
        Me.Hide()
        FormPenjualan.Show()
    End Sub

    Private Sub BtnSupply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupply.Click
        Me.Hide()
        FormPasok.Show()
    End Sub

    Private Sub BtnRetur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRetur.Click
        Me.Hide()
        FormPengembalian.Show()
    End Sub

    Private Sub BtnInvoiceSupply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInvoiceSupply.Click
        Me.Hide()
        FormLpPasok.Show()
    End Sub

    Private Sub BtnInvoiceRetur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInvoiceRetur.Click
        Me.Hide()
        FormLpKembali.Show()
    End Sub

    Private Sub BtnInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInfo.Click
        Me.Hide()
        FormInfo.Show()
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Hide()
        FormLogin.Show()
        FormLogin.TBUsername.Text = ""
        FormLogin.TBPw.Text = ""
    End Sub
End Class