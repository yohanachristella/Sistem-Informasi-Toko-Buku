Imports System.Data.OleDb
Public Class FormLpPasok
    Sub tampil9()
        Call koneksi()

        cmd = New OleDbCommand("select * from invoice_suply", conn)
        rd = cmd.ExecuteReader
        DGVLpPasok.Rows.Clear()
        Do While rd.Read = True
            DGVLpPasok.Rows.Add(rd.Item("no_invoicesuply"), rd.Item("no_penerimaan"), rd.Item("tanggal_terima"), rd.Item("id_suplier"), rd.Item("kode_buku"), rd.Item("harga_beli"), rd.Item("jumlah_buku"), rd.Item("total_biaya"))
        Loop
    End Sub
    Private Sub FormLpPasok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbUASDataSet.invoice_suply' table. You can move, or remove it, as needed.
        Me.Invoice_suplyTableAdapter.Fill(Me.DbUASDataSet.invoice_suply)

        Call koneksi()
        cmd = New OleDbCommand("select * from [invoice_suply] where no_invoicesuply in (select max(no_invoicesuply) from [invoice_suply] )", conn)
        Dim urut As String
        Dim hitung As String
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urut = "IS" + "0521001"
        Else
            hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 7) + 1
            urut = "IS" + Microsoft.VisualBasic.Right("0521000" & hitung, 7)
        End If
        LbNomor.Text = urut

        Call koneksi()
        Dim str As String = "select * from [invoice_suply]"
        Dim dt As New DataTable
        da = New OleDb.OleDbDataAdapter(str, conn)
        dt = New DataTable
        da.Fill(dt)
        DGVLpPasok.DataSource = dt

    End Sub

    Private Sub BtnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCetak.Click
        CrPasok.ReportFileName = "LaporanSuply.rpt"
        CrPasok.WindowState = Crystal.WindowStateConstants.crptMaximized
        CrPasok.Action = 1
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
        FormPasok.Show()
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

    Private Sub BtnInvoiceJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInvoiceJual.Click
        Me.Hide()
        FormLpJual.Show()
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