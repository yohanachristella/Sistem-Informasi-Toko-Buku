Imports System.Data.OleDb
Public Class FormBuku

    Sub tampil4()
        Call koneksi()

        cmd = New OleDbCommand("select * from data_buku", conn)
        rd = cmd.ExecuteReader
        DGVBuku.Rows.Clear()
        Do While rd.Read = True
            DGVBuku.Rows.Add(rd.Item("kode_buku"), rd.Item("judul_buku"), rd.Item("nama_penulis"), rd.Item("kode_penerbit"), rd.Item("tahun_terbit"), rd.Item("kategori"), rd.Item("jumlah_stok"), rd.Item("harga_beli"), rd.Item("harga_jual"), rd.Item("diskon"))
        Loop
    End Sub

    Sub kosongkan3()
        LbIsiKode.Text = ""
        TbJudul.Text = ""
        TbPenulis.Text = ""
        TbKodePenerbit.Text = ""
        TbThnTerbit.Text = ""
        TbKategori.Text = ""
        TbJmlhBuku.Text = ""
        TbHargaBeli.Text = ""
        LbIsiJual.Text = ""
        TbDiskon.Text = ""
        TbJudul.Focus()
    End Sub
    Private Sub FormBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbUASDataSet.data_buku' table. You can move, or remove it, as needed.
        Me.Data_bukuTableAdapter.Fill(Me.DbUASDataSet.data_buku)

        Call koneksi()
        cmd = New OleDbCommand("select * from [data_buku] where kode_buku in (select max(kode_buku) from [data_buku] )", conn)
        Dim urut As String
        Dim hitung As String
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urut = "PRD" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 3) + 1
            urut = "PRD" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        LbIsiKode.Text = urut


    End Sub

    Private Sub BtnSimpanBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpanBuku.Click
        ds = New DataSet

        
        If Trim(TbJudul.Text) = "" Then
            MsgBox("Judul buku tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TbPenulis.Text) = "" Then
            MsgBox("Nama penulis tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TbKodePenerbit.Text) = "" Then
            MsgBox("Kode penerbit tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TbThnTerbit.Text) = "" Then
            MsgBox("Tahun terbit tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TbKategori.Text) = "" Then
            MsgBox("Kategori tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TbJmlhBuku.Text) = "" Then
            MsgBox("Jumlah buku tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TbHargaBeli.Text) = "" Then
            MsgBox("Harga beli tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(LbIsiJual.Text) = "" Then
            MsgBox("Harga jual tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TbDiskon.Text) = "" Then
            MsgBox("Diskon tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub

        End If

        da = New OleDbDataAdapter("insert into [data_buku] values" & "('" & LbIsiKode.Text & "','" & TbJudul.Text & "','" &
          TbPenulis.Text & "','" & TbKodePenerbit.Text & "','" & TbThnTerbit.Text & "','" & TbKategori.Text &
          "','" & TbJmlhBuku.Text & "','" & TbHargaBeli.Text & "','" & LbIsiJual.Text & "','" & TbDiskon.Text & "')", conn)

        da.Fill(ds, "data_buku")
        MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")

        Call kosongkan3()
    End Sub

    Private Sub BtnAmbil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAmbil.Click
        Dim i As Integer
        i = DGVBuku.CurrentRow.Index

        LbIsiKode.Text = DGVBuku.Item(0, i).Value.ToString()
        TbJudul.Text = DGVBuku.Item(1, i).Value.ToString()
        TbPenulis.Text = DGVBuku.Item(2, i).Value.ToString()
        TbKodePenerbit.Text = DGVBuku.Item(3, i).Value.ToString()
        TbThnTerbit.Text = DGVBuku.Item(4, i).Value.ToString()
        TbKategori.Text = DGVBuku.Item(5, i).Value.ToString()
        TbJmlhBuku.Text = DGVBuku.Item(6, i).Value.ToString()
        TbHargaBeli.Text = DGVBuku.Item(7, i).Value.ToString()
        LbIsiJual.Text = DGVBuku.Item(8, i).Value.ToString()
        TbDiskon.Text = DGVBuku.Item(9, i).Value.ToString()
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        If TbJudul.Text = "" Or TbPenulis.Text = "" Or TbKodePenerbit.Text = "" Or TbThnTerbit.Text = "" Or TbKategori.Text = "" Or TbJmlhBuku.Text = "" Or TbHargaBeli.Text = "" Or LbIsiJual.Text = "" Or TbDiskon.Text = "" Then
            MsgBox("Update data gagal!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")

        Else
            BtnUbah.Enabled = True
            ds = New DataSet
            da = New OleDbDataAdapter("update [data_buku] set judul_buku = '" & TbJudul.Text &
                                      "', nama_penulis = '" & TbPenulis.Text &
                                      "', kode_penerbit = '" & TbKodePenerbit.Text &
                                      "', tahun_terbit = '" & TbThnTerbit.Text &
                                      "', kategori = '" & TbKategori.Text &
                                      "', jumlah_stok = '" & TbJmlhBuku.Text &
                                      "', harga_beli = '" & TbHargaBeli.Text &
                                      "', harga_jual = '" & LbIsiJual.Text &
                                      "', diskon = '" & TbDiskon.Text &
                                      "' where kode_buku = '" & LbIsiKode.Text & "' ", conn)
            da.Fill(ds, "data_buku")
            MsgBox("Update data berhasil!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")


        End If
        Call koneksi()
        Call kosongkan3()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If LbIsiKode.Text = "" Or TbJudul.Text = "" Or TbPenulis.Text = "" Or TbKodePenerbit.Text = "" Or TbThnTerbit.Text = "" Or TbKategori.Text = "" Or TbJmlhBuku.Text = "" Or TbHargaBeli.Text = "" Or LbIsiJual.Text = "" Or TbDiskon.Text = "" Then
            MsgBox("Hapus data gagal!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
        ElseIf MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ds = New DataSet
            da = New OleDbDataAdapter("delete from [data_buku] where kode_buku = '" & LbIsiKode.Text & "' ", conn)
            da.Fill(ds, "data_buku")
            MsgBox("Hapus data berhasil!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
            Call koneksi()
        End If

        Call kosongkan3()
    End Sub

    
    Private Sub TbKodeBuku_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Chr(13) Then
            TbJudul.Focus()
        End If
    End Sub

    Private Sub TbJudul_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbJudul.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar = " ") Or
            e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya huruf dan angka!", MsgBoxStyle.Information, "Peringatan")
        End If

        If e.KeyChar = Chr(13) Then
            TbPenulis.Focus()
        End If

    End Sub

    Private Sub TbPenulis_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbPenulis.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar = " ") Or
            e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya huruf!", MsgBoxStyle.Information, "Peringatan")
        End If

        If e.KeyChar = Chr(13) Then
            TbKodePenerbit.Focus()
        End If

    End Sub

    Private Sub TbKodePenerbit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbKodePenerbit.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
            e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka!", MsgBoxStyle.Information, "Peringatan")
        End If

        If e.KeyChar = Chr(13) Then
            TbThnTerbit.Focus()
        End If

        
    End Sub

    Private Sub TbThnTerbit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbThnTerbit.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
            e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka!", MsgBoxStyle.Information, "Peringatan")
        End If

        If e.KeyChar = Chr(13) Then
            TbKategori.Focus()
        End If

        
    End Sub

    Private Sub TbKategori_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbKategori.KeyPress

        If e.KeyChar = Chr(13) Then
            TbJmlhBuku.Focus()
        End If
        
    End Sub

    Private Sub TbJmlhBuku_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbJmlhBuku.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
           e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka!", MsgBoxStyle.Information, "Peringatan")
        End If

        If e.KeyChar = Chr(13) Then
            TbHargaBeli.Focus()
        End If

    End Sub

    Private Sub TbHargaBeli_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbHargaBeli.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
           e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka!", MsgBoxStyle.Information, "Peringatan")
        End If

        If e.KeyChar = Chr(13) Then
            LbIsiJual.Focus()
            Try
                LbIsiJual.Text = Val(TbHargaBeli.Text) + 25000
            Catch ex As Exception
                LbIsiJual.Text = "0"
            End Try
        End If
    End Sub

    Private Sub TbHargaJual_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
           e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka!", MsgBoxStyle.Information, "Peringatan")
        End If

        If e.KeyChar = Chr(13) Then
            TbDiskon.Focus()
        End If
    End Sub

    Private Sub TbDiskon_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbDiskon.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
           e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka!", MsgBoxStyle.Information, "Peringatan")
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

    Private Sub BtnJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJual.Click
        Me.Hide()
        FormPenjualan.Show()
    End Sub

    Private Sub TbJudul_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbJudul.TextChanged

    End Sub

    Private Sub TbHargaJual_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            LbIsiJual.Text = Val(TbHargaBeli.Text) + 25000
        Catch ex As Exception
            LbIsiJual.Text = "0"
        End Try
    End Sub

    Private Sub TbHargaJual_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnSuplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSuplier.Click
        Me.Hide()
        Formpemasok.Show()
    End Sub

    Private Sub BtnPenerbit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPenerbit.Click
        Me.Hide()
        FormPenerbit.Show()
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