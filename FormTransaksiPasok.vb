Imports System.Data.OleDb
Public Class FormPasok

    Sub tampil6()
        Call koneksi()

        cmd = New OleDbCommand("select * from data_suply", conn)
        rd = cmd.ExecuteReader
        DGVPasok.Rows.Clear()
        Do While rd.Read = True
            DGVPasok.Rows.Add(rd.Item("no_penerimaan"), rd.Item("tanggal_terima"), rd.Item("id_user"), rd.Item("id_suplier"), rd.Item("kode_buku"), rd.Item("harga_beli"), rd.Item("jumlah_buku"), rd.Item("total_biaya"))
        Loop
    End Sub

    Sub kosongkan()
        LbIsiTerima.Text = ""
        DTPTglTerima.Text = ""
        TbIdUser.Text = ""
        TbIdPemasok.Text = ""
        TbKodeBuku.Text = ""
        LbIsiHarga.Text = ""
        TbJmlh.Text = ""
        TbIdUser.Focus()

    End Sub

    Sub noauto()

        Call koneksi()
        cmd = New OleDbCommand("select * from [data_suply] where no_penerimaan in (select max(no_penerimaan) from [data_suply] )", conn)
        Dim urut As String
        Dim hitung As String
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urut = "BY" + "2021001"
        Else
            hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 7) + 1
            urut = "BY" + Microsoft.VisualBasic.Right("2021000" & hitung, 7)
        End If
        LbIsiTerima.Text = urut

    End Sub

    Private Sub FormPasok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbUASDataSet.data_suply' table. You can move, or remove it, as needed.
        Me.Data_suplyTableAdapter.Fill(Me.DbUASDataSet.data_suply)

        Call noauto()
        
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        If Trim(DTPTglTerima.Text) = "" Then
            MsgBox("Tanggal tidak boleh kosong!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TbIdUser.Text) = "" Then
            MsgBox("Id Pengguna tidak boleh kosong!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TbIdPemasok.Text) = "" Then
            MsgBox("Id Pemasok tidak boleh kosong!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TbKodeBuku.Text) = "" Then
            MsgBox("Kode buku tidak boleh kosong!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TbJmlh.Text) = "" Then
            MsgBox("Jumlah tidak boleh kosong!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        End If

        Dim row As Integer
        DGVPasok.Rows.Add()
        row = DGVPasok.Rows.Count - 2
        DGVPasok("no_penerimaan", row).Value = LbIsiTerima.Text
        DGVPasok("tanggal_terima", row).Value = DTPTglTerima.Text
        DGVPasok("id_user", row).Value = TbIdUser.Text
        DGVPasok("id_suplier", row).Value = TbIdPemasok.Text
        DGVPasok("kode_buku", row).Value = TbKodeBuku.Text
        DGVPasok("harga_beli", row).Value = LbIsiHarga.Text
        DGVPasok("jumlah_buku", row).Value = TbJmlh.Text
        DGVPasok("total_biaya", row).Value = LbIsiTotal.Text
        Call kosongkan()

        For i As Integer = 0 To DGVPasok.Rows.Count - 2 Step 1
            cmd = New OleDbCommand("select * from [data_buku] where kode_buku='" & DGVPasok.Rows(i).Cells(4).Value & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                cmd = New OleDbCommand("update [data_buku] set jumlah_stok= '" & rd.Item("jumlah_stok") + Val(DGVPasok.Rows(i).Cells(6).Value) & _
                                       "' where kode_buku= '" & DGVPasok.Rows(i).Cells(4).Value & "' ", conn)
                cmd.ExecuteNonQuery()
            End If
        Next i


    End Sub

    Private Sub BtnSimpanPasok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpanPasok.Click

        ds = New DataSet
        For i As Integer = 0 To DGVPasok.Rows.Count - 2 Step 1
            da = New OleDbDataAdapter("insert into [data_suply] values('" & DGVPasok.Rows(i).Cells(0).Value & "','" & DGVPasok.Rows(i).Cells(1).Value & "','" & DGVPasok.Rows(i).Cells(2).Value & "','" & DGVPasok.Rows(i).Cells(3).Value & "','" & DGVPasok.Rows(i).Cells(4).Value & "','" & DGVPasok.Rows(i).Cells(5).Value & "','" & DGVPasok.Rows(i).Cells(6).Value & "','" & DGVPasok.Rows(i).Cells(7).Value & "')", conn)

            da.Fill(ds, "data_suply")
        Next i

        For i As Integer = 0 To DGVPasok.Rows.Count - 2 Step 1
            da = New OleDbDataAdapter("insert into [invoice_suply] values ('" & FormLpPasok.LbNomor.Text & "','" & DGVPasok.Rows(i).Cells(0).Value & "','" &
            DGVPasok.Rows(i).Cells(1).Value & "','" & DGVPasok.Rows(i).Cells(3).Value & "','" & DGVPasok.Rows(i).Cells(4).Value & "','" &
            DGVPasok.Rows(i).Cells(5).Value & "','" & DGVPasok.Rows(i).Cells(6).Value & "','" & DGVPasok.Rows(i).Cells(7).Value & "')", conn)

            da.Fill(ds, "invoice_suply")
        Next i

        MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
        Call kosongkan()
        Call noauto()

    End Sub

    Private Sub BtnAmbilJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAmbilJual.Click
        Dim i As Integer
        i = DGVPasok.CurrentRow.Index

        LbIsiTerima.Text = DGVPasok.Item(0, i).Value.ToString()
        DTPTglTerima.Text = DGVPasok.Item(1, i).Value.ToString()
        TbIdUser.Text = DGVPasok.Item(2, i).Value.ToString()
        TbIdPemasok.Text = DGVPasok.Item(3, i).Value.ToString()
        TbKodeBuku.Text = DGVPasok.Item(4, i).Value.ToString()
        LbIsiHarga.Text = DGVPasok.Item(5, i).Value.ToString()
        TbJmlh.Text = DGVPasok.Item(6, i).Value.ToString()
        LbIsiTotal.Text = DGVPasok.Item(7, i).Value.ToString()
    End Sub

    Private Sub BtnUbahJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbahJual.Click
        If DTPTglTerima.Text = "" Or TbIdUser.Text = "" Or TbIdPemasok.Text = "" Or TbKodeBuku.Text = "" Or LbIsiHarga.Text = "" Or TbJmlh.Text = "" Or LbIsiTotal.Text = "" Then
            MsgBox("Update data gagal!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")

        Else
            BtnUbahJual.Enabled = True
            ds = New DataSet
            da = New OleDbDataAdapter("update [data_suply] set tanggal_terima = '" & DTPTglTerima.Text &
                                      "', id_user = '" & TbIdUser.Text &
                                      "', id_suplier = '" & TbIdPemasok.Text &
                                      "', kode_buku = '" & TbKodeBuku.Text &
                                      "', harga_beli = '" & LbIsiHarga.Text &
                                      "', jumlah_buku = '" & TbJmlh.Text &
                                      "', total_biaya = '" & LbIsiTotal.Text &
                                      "' where no_penerimaan = '" & LbIsiTerima.Text & "' ", conn)
            da.Fill(ds, "data_suply")
            MsgBox("Update data berhasil!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")

            For i As Integer = 0 To DGVPasok.Rows.Count - 2 Step 1
                cmd = New OleDbCommand("select * from [data_buku] where kode_buku='" & DGVPasok.Rows(i).Cells(4).Value & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    cmd = New OleDbCommand("update [data_buku] set jumlah_stok= '" & rd.Item("jumlah_stok") + Val(DGVPasok.Rows(i).Cells(6).Value) & _
                                           "' where kode_buku= '" & DGVPasok.Rows(i).Cells(4).Value & "' ", conn)
                    cmd.ExecuteNonQuery()
                End If
            Next i


        End If
        Call koneksi()
        Call kosongkan()
    End Sub

    Private Sub BtnHapusJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapusJual.Click
        If DTPTglTerima.Text = "" Or TbIdUser.Text = "" Or TbIdPemasok.Text = "" Or TbKodeBuku.Text = "" Or LbIsiHarga.Text = "" Or TbJmlh.Text = "" Or LbIsiTotal.Text = "" Then
            MsgBox("Hapus data gagal!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
        ElseIf MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ds = New DataSet
            da = New OleDbDataAdapter("delete from [data_suply] where no_penerimaan = '" & LbIsiTerima.Text & "' ", conn)
            da.Fill(ds, "data_suply")
            MsgBox("Hapus data berhasil!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")

            For i As Integer = 0 To DGVPasok.Rows.Count - 2 Step 1
                cmd = New OleDbCommand("select * from [data_buku] where kode_buku='" & DGVPasok.Rows(i).Cells(4).Value & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    cmd = New OleDbCommand("update [data_buku] set jumlah_stok= '" & rd.Item("jumlah_stok") - Val(DGVPasok.Rows(i).Cells(6).Value) & _
                                           "' where kode_buku= '" & DGVPasok.Rows(i).Cells(4).Value & "' ", conn)
                    cmd.ExecuteNonQuery()
                End If
            Next i

            Call koneksi()
        End If

        Call kosongkan()
    End Sub

    Private Sub TbKodeBuku_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbKodeBuku.KeyPress
        If e.KeyChar = Chr(13) Then
            LbIsiHarga.Focus()
            Dim harga As String
            cmd = New OleDbCommand("select * from [data_buku] where kode_buku= '" & TbKodeBuku.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                harga = rd.Item("harga_beli")
                LbIsiHarga.Text = harga
            Else
                LbIsiHarga.Text = ""
                TbKodeBuku.Focus()
                MsgBox("Barang tidak terdaftar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
            End If

        End If
    End Sub


    Private Sub TbHargaBeli_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim harga As String
        cmd = New OleDbCommand("select * from [data_buku] where kode_buku= '" & TbKodeBuku.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            harga = rd.Item("harga_beli")
            LbIsiHarga.Text = harga
        Else
            LbIsiHarga.Text = ""
            TbKodeBuku.Focus()
            MsgBox("Barang tidak terdaftar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
        End If

    End Sub

    Private Sub TbJmlh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbJmlh.TextChanged
        Try
            LbIsiTotal.Text = Val(LbIsiHarga.Text) * Val(TbJmlh.Text)
        Catch ex As Exception
            LbIsiTotal.Text = " "
        End Try
    End Sub

    Private Sub TbIdUser_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbIdUser.KeyPress
        If e.KeyChar = Chr(13) Then
            TbIdPemasok.Focus()
        End If

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka!", MsgBoxStyle.Information, "Peringatan")
        End If
    End Sub

    Private Sub TbIdPemasok_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbIdPemasok.KeyPress
        If e.KeyChar = Chr(13) Then
            TbKodeBuku.Focus()
        End If

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka !", MsgBoxStyle.Information, "Peringatan")
        End If
    End Sub

    Private Sub TbHargaBeli_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            TbJmlh.Focus()
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

    End Sub

    Private Sub TbJmlh_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbJmlh.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka !", MsgBoxStyle.Information, "Peringatan")
        End If
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