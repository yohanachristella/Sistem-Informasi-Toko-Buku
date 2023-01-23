Imports System.Data.OleDb
Public Class FormPengembalian

    Sub tampil7()
        Call koneksi()

        cmd = New OleDbCommand("select * from data_retur", conn)
        rd = cmd.ExecuteReader
        DGVPengembalian.Rows.Clear()
        Do While rd.Read = True
            DGVPengembalian.Rows.Add(rd.Item("no_retur"), rd.Item("tanggal_jual"), rd.Item("tanggal_retur"), rd.Item("id_member"), rd.Item("id_user"), rd.Item("kode_buku"), rd.Item("jumlah_buku"), rd.Item("alasan_retur"))
        Loop
    End Sub

    Sub kosongkan()
        LbIsiNomor.Text = ""
        DTPJual.Text = ""
        DTPKembali.Text = ""
        TbIdPelanggan.Text = ""
        TbIdUser.Text = ""
        TbKodeBuku.Text = ""
        TbJmlh.Text = ""
        TbAlasan.Text = ""
        TbIdPelanggan.Focus()

    End Sub

    Sub noauto()
        Call koneksi()
        cmd = New OleDbCommand("select * from [data_retur] where no_retur in (select max(no_retur) from [data_retur] )", conn)
        Dim urut As String
        Dim hitung As String
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urut = "RT" + "2021001"
        Else
            hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 7) + 1
            urut = "RT" + Microsoft.VisualBasic.Right("2021000" & hitung, 7)
        End If
        LbIsiNomor.Text = urut
    End Sub
    Private Sub FormPengembalian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbUASDataSet.data_retur' table. You can move, or remove it, as needed.
        Me.Data_returTableAdapter.Fill(Me.DbUASDataSet.data_retur)
        Call noauto()
        
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        If Trim(DTPJual.Text) = "" Then
            MsgBox("Tanggal penjualan tidak boleh kosong!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(DTPKembali.Text) = "" Then
            MsgBox("Tanggal pengembalian tidak boleh kosong!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TbIdPelanggan.Text) = "" Then
            MsgBox("Id pelanggan tidak boleh kosong!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TbIdUser.Text) = "" Then
            MsgBox("Id pengguna tidak boleh kosong!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TbKodeBuku.Text) = "" Then
            MsgBox("Kode buku tidak boleh kosong!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TbJmlh.Text) = "" Then
            MsgBox("Jumlah tidak boleh kosong!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TbAlasan.Text) = "" Then
            MsgBox("Alasan pengembalian tidak boleh kosong!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        End If

        Dim row As Integer
        DGVPengembalian.Rows.Add()
        row = DGVPengembalian.Rows.Count - 2
        DGVPengembalian("no_retur", row).Value = LbIsiNomor.Text
        DGVPengembalian("tanggal_jual", row).Value = DTPJual.Text
        DGVPengembalian("tanggal_retur", row).Value = DTPKembali.Text
        DGVPengembalian("id_member", row).Value = TbIdPelanggan.Text
        DGVPengembalian("id_user", row).Value = TbIdUser.Text
        DGVPengembalian("kode_buku", row).Value = TbKodeBuku.Text
        DGVPengembalian("jumlah_buku", row).Value = TbJmlh.Text
        DGVPengembalian("alasan_retur", row).Value = TbAlasan.Text
        Call kosongkan()

    End Sub

    Private Sub BtnSimpanKembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpanKembali.Click
        ds = New DataSet
        For i As Integer = 0 To DGVPengembalian.Rows.Count - 2 Step 1
            da = New OleDbDataAdapter("insert into [data_retur] values" & "('" & DGVPengembalian.Rows(i).Cells(0).Value & "','" & DGVPengembalian.Rows(i).Cells(1).Value & "','" & DGVPengembalian.Rows(i).Cells(2).Value & "','" & DGVPengembalian.Rows(i).Cells(3).Value & "','" & DGVPengembalian.Rows(i).Cells(4).Value & "','" & DGVPengembalian.Rows(i).Cells(5).Value & "','" & DGVPengembalian.Rows(i).Cells(6).Value & "','" & DGVPengembalian.Rows(i).Cells(7).Value & "')", conn)
            da.Fill(ds, "data_retur")
        Next i

        For i As Integer = 0 To DGVPengembalian.Rows.Count - 2 Step 1
            da = New OleDbDataAdapter("insert into [invoice_retur] values ('" & FormLpKembali.LbNomor.Text & "','" & DGVPengembalian.Rows(i).Cells(0).Value & "','" &
            DGVPengembalian.Rows(i).Cells(1).Value & "','" & DGVPengembalian.Rows(i).Cells(2).Value & "','" & DGVPengembalian.Rows(i).Cells(3).Value & "','" &
            DGVPengembalian.Rows(i).Cells(4).Value & "','" & DGVPengembalian.Rows(i).Cells(5).Value & "','" & DGVPengembalian.Rows(i).Cells(6).Value & "','" &
            DGVPengembalian.Rows(i).Cells(7).Value & "')", conn)
            da.Fill(ds, "invoice_retur")
        Next i

        MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
        Call kosongkan()
        Call noauto()

    End Sub

    Private Sub BtnAmbilJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAmbilJual.Click
        Dim i As Integer
        i = DGVPengembalian.CurrentRow.Index

        LbIsiNomor.Text = DGVPengembalian.Item(0, i).Value.ToString()
        DTPJual.Text = DGVPengembalian.Item(1, i).Value.ToString()
        DTPKembali.Text = DGVPengembalian.Item(2, i).Value.ToString()
        TbIdPelanggan.Text = DGVPengembalian.Item(3, i).Value.ToString()
        TbIdUser.Text = DGVPengembalian.Item(4, i).Value.ToString()
        TbKodeBuku.Text = DGVPengembalian.Item(5, i).Value.ToString()
        TbJmlh.Text = DGVPengembalian.Item(6, i).Value.ToString()
        TbAlasan.Text = DGVPengembalian.Item(7, i).Value.ToString()
    End Sub

    Private Sub BtnUbahJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbahJual.Click
        If DTPJual.Text = "" Or DTPKembali.Text = "" Or TbIdPelanggan.Text = "" Or TbIdUser.Text = "" Or TbKodeBuku.Text = "" Or TbJmlh.Text = "" Or TbAlasan.Text = "" Then
            MsgBox("Update data gagal!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")

        Else
            BtnUbahJual.Enabled = True
            ds = New DataSet
            da = New OleDbDataAdapter("update [data_retur] set tanggal_jual = '" & DTPJual.Text &
                                      "', tanggal_retur = '" & DTPKembali.Text &
                                      "', id_member = '" & TbIdPelanggan.Text &
                                      "', id_user = '" & TbIdUser.Text &
                                      "', kode_buku = '" & TbKodeBuku.Text &
                                      "', jumlah_buku = '" & TbJmlh.Text &
                                      "', alasan_retur = '" & TbAlasan.Text &
                                      "' where no_retur = '" & LbIsiNomor.Text & "' ", conn)
            da.Fill(ds, "data_retur")
            MsgBox("Update data berhasil!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")


        End If
        Call koneksi()
        Call kosongkan()
    End Sub

    Private Sub BtnHapusJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapusJual.Click
        If DTPJual.Text = "" Or DTPKembali.Text = "" Or TbIdPelanggan.Text = "" Or TbIdUser.Text = "" Or TbKodeBuku.Text = "" Or TbJmlh.Text = "" Or TbAlasan.Text = "" Then
            MsgBox("Hapus data gagal!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
        ElseIf MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ds = New DataSet
            da = New OleDbDataAdapter("delete from [data_retur] where no_retur = '" & LbIsiNomor.Text & "' ", conn)
            da.Fill(ds, "data_retur")
            MsgBox("Hapus data berhasil!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
            Call koneksi()
        End If

        Call kosongkan()
    End Sub

    Private Sub TbIdPelanggan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbIdPelanggan.KeyPress

        If e.KeyChar = Chr(13) Then
            TbIdUser.Focus()
        End If

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka!", MsgBoxStyle.Information, "Peringatan")
        End If
    End Sub

    Private Sub TbIdUser_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbIdUser.KeyPress
        If e.KeyChar = Chr(13) Then
            TbKodeBuku.Focus()
        End If

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka!", MsgBoxStyle.Information, "Peringatan")
        End If
    End Sub

    Private Sub TbKodeBuku_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbKodeBuku.KeyPress
        If e.KeyChar = Chr(13) Then
            TbJmlh.Focus()
        End If

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka dan huruf!", MsgBoxStyle.Information, "Peringatan")
        End If
    End Sub

    Private Sub TbJmlh_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbJmlh.KeyPress
        If e.KeyChar = Chr(13) Then
            TbAlasan.Focus()
        End If

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka!", MsgBoxStyle.Information, "Peringatan")
        End If
    End Sub

    Private Sub TbAlasan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbAlasan.KeyPress

        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar = " ") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka dan huruf!", MsgBoxStyle.Information, "Peringatan")
        End If
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

    Private Sub BtnInvoiceJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInvoiceJual.Click
        Me.Hide()
        FormLpJual.Show()
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