Imports System.Data.OleDb
Public Class FormLpKembali
    Sub tampil10()
        Call koneksi()

        cmd = New OleDbCommand("select * from invoice_retur", conn)
        rd = cmd.ExecuteReader
        DGVLpKembali.Rows.Clear()
        Do While rd.Read = True
            DGVLpKembali.Rows.Add(rd.Item("no_invoiceretur"), rd.Item("no_retur"), rd.Item("tanggal_jual"), rd.Item("tanggal_retur"), rd.Item("id_member"), rd.Item("id_user"), rd.Item("kode_buku"), rd.Item("jumlah_buku"), rd.Item("total_retur"))
        Loop
    End Sub
    Private Sub FormLpKembali_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbUASDataSet.invoice_retur' table. You can move, or remove it, as needed.
        Me.Invoice_returTableAdapter.Fill(Me.DbUASDataSet.invoice_retur)

        Call koneksi()
        cmd = New OleDbCommand("select * from [invoice_retur] where no_invoiceretur in (select max(no_invoiceretur) from [invoice_retur] )", conn)
        Dim urut As String
        Dim hitung As String
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urut = "IR" + "0521001"
        Else
            hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 7) + 1
            urut = "IR" + Microsoft.VisualBasic.Right("0521000" & hitung, 7)
        End If
        LbNomor.Text = urut

        Call koneksi()
        Dim str As String = "select * from [invoice_retur]"
        Dim dt As New DataTable
        da = New OleDb.OleDbDataAdapter(str, conn)
        dt = New DataTable
        da.Fill(dt)
        DGVLpKembali.DataSource = dt
    End Sub

    Private Sub BtnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCetak.Click
        CrKembali.ReportFileName = "LaporanRetur.rpt"
        CrKembali.WindowState = Crystal.WindowStateConstants.crptMaximized
        CrKembali.Action = 1
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

    Private Sub BtnInvoiceJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInvoiceJual.Click
        Me.Hide()
        FormLpJual.Show()
    End Sub

    Private Sub BtnInvoiceSupply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInvoiceSupply.Click
        Me.Hide()
        FormLpPasok.Show()
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