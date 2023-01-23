Imports System.Data.OleDb
Public Class FormPenjualan

    Sub tampil3()
        'Call koneksi()
        'cmd = New OleDbCommand("select * from data_penjualan", conn)
        'rd = cmd.ExecuteReader
        ''DGVPenjualan.Rows.Clear()

        'Do While rd.Read = True
        '    DGVPenjualan.Rows.Add(rd.Item("no_nota"), rd.Item("tanggal_jual"), rd.Item("id_user"), rd.Item("id_member"), rd.Item("kode_buku"), rd.Item("harga_jual"), rd.Item("jumlah_buku"), rd.Item("total_biaya"))
        'Loop


        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter("select * from [data_penjualan]", conn)
        Dim ds As New DataSet

        DGVPenjualan.Visible = True
        Try
            da.Fill(dt)
            DGVPenjualan.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'da.Fill(ds, "data_penjualan")
        'DGVPenjualan.DataSource = ds.Tables("data_penjualan")
        DGVPenjualan.ReadOnly = True


    End Sub

    Sub noauto()
        Call koneksi()
        cmd = New OleDbCommand("select * from [data_penjualan] where no_nota in (select max(no_nota) from [data_penjualan] )", conn)
        Dim urut As String
        Dim hitung As String
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urut = "SL" + "2021001"
        Else
            hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 7) + 1
            urut = "SL" + Microsoft.VisualBasic.Right("2021000" & hitung, 7)
        End If
        LbIsiNomor.Text = urut
    End Sub

    Sub kosongkan1()
        LbIsiNomor.Text = ""
        DTPTglJual.Text = ""
        TbIdUserJual.Text = ""
        TbIdMbrJual.Text = ""
        TbKodeBukuJual.Text = ""
        LbIsiHarga.Text = ""
        LbIsiDiskon.Text = ""
        TbJmlh.Text = ""
        TbIdUserJual.Focus()

    End Sub

    Private Sub FormPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbUASDataSet.data_penjualan' table. You can move, or remove it, as needed.
        Me.Data_penjualanTableAdapter.Fill(Me.DbUASDataSet.data_penjualan)

        TbBayar.Text = "0"
        TbKembali.Text = "0"
        Call noauto()


    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click

        If Trim(DTPTglJual.Text) = "" Then
            MsgBox("Tanggal tidak boleh kosong!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TbIdUserJual.Text) = "" Then
            MsgBox("Id User tidak boleh kosong!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TbIdMbrJual.Text) = "" Then
            MsgBox("Id Member tidak boleh kosong!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TbKodeBukuJual.Text) = "" Then
            MsgBox("Kode buku tidak boleh kosong!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TbJmlh.Text) = "" Then
            MsgBox("Jumlah tidak boleh kosong!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        End If

        Dim row As Integer
        DGVPenjualan.Rows.Add()
        row = DGVPenjualan.Rows.Count - 2
        DGVPenjualan("no_nota", row).Value = LbIsiNomor.Text
        DGVPenjualan("tanggal_jual", row).Value = DTPTglJual.Text
        DGVPenjualan("id_user", row).Value = TbIdUserJual.Text
        DGVPenjualan("id_member", row).Value = TbIdMbrJual.Text
        DGVPenjualan("kode_buku", row).Value = TbKodeBukuJual.Text
        DGVPenjualan("harga_jual", row).Value = LbIsiHarga.Text
        DGVPenjualan("jumlah_buku", row).Value = TbJmlh.Text
        DGVPenjualan("total_biaya", row).Value = LbIsiTotal.Text
        Call kosongkan1()

        For i As Integer = 0 To DGVPenjualan.RowCount - 2 Step 1
            cmd = New OleDbCommand("select * from [data_buku] where kode_buku='" & DGVPenjualan.Rows(i).Cells(4).Value & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                Dim stok As Integer = rd.Item("jumlah_stok")
                Dim jumlah As Integer = Val(DGVPenjualan.Rows(i).Cells(6).Value)
                Dim sisa As Integer = stok - jumlah
                cmd = New OleDbCommand("update [data_buku] set jumlah_stok= '" & sisa & _
                                       "' where kode_buku= '" & DGVPenjualan.Rows(i).Cells(4).Value & "' ", conn)
                cmd.ExecuteNonQuery()
            End If
        Next i

    End Sub


    Private Sub BtnSimpanJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpanJual.Click

        ds = New DataSet
        For i As Integer = 0 To DGVPenjualan.RowCount - 2 Step 1
        da = New OleDbDataAdapter("insert into [data_penjualan] values('" & DGVPenjualan.Rows(i).Cells(0).Value & "','" & DGVPenjualan.Rows(i).Cells(1).Value & "','" & DGVPenjualan.Rows(i).Cells(2).Value & "','" & DGVPenjualan.Rows(i).Cells(3).Value & "','" & DGVPenjualan.Rows(i).Cells(4).Value & "','" & DGVPenjualan.Rows(i).Cells(5).Value & "','" & DGVPenjualan.Rows(i).Cells(6).Value & "','" & DGVPenjualan.Rows(i).Cells(7).Value & "')", conn)

            da.Fill(ds, "data_penjualan")
        Next i


        For i As Integer = 0 To DGVPenjualan.RowCount - 2 Step 1
            da = New OleDbDataAdapter("insert into [invoice_jual] values ('" & FormLpJual.LbNoJual.Text & "','" & DGVPenjualan.Rows(i).Cells(0).Value & "','" &
           DGVPenjualan.Rows(i).Cells(1).Value & "','" & DGVPenjualan.Rows(i).Cells(2).Value & "','" & DGVPenjualan.Rows(i).Cells(4).Value & "','" &
           DGVPenjualan.Rows(i).Cells(6).Value & "','" & DGVPenjualan.Rows(i).Cells(5).Value & "','" & "','" & DGVPenjualan.Rows(i).Cells(7).Value & "')", conn)

            da.Fill(ds, "invoice_jual")
        Next i

        MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")
        Call kosongkan1()
        Call noauto()


    End Sub

    Private Sub BtnAmbilJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAmbilJual.Click
        Dim i As Integer
        i = DGVPenjualan.CurrentRow.Index

        LbIsiNomor.Text = DGVPenjualan.Item(0, i).Value.ToString()
        DTPTglJual.Text = DGVPenjualan.Item(1, i).Value.ToString()
        TbIdUserJual.Text = DGVPenjualan.Item(2, i).Value.ToString()
        TbIdMbrJual.Text = DGVPenjualan.Item(3, i).Value.ToString()
        TbKodeBukuJual.Text = DGVPenjualan.Item(4, i).Value.ToString()
        LbIsiHarga.Text = DGVPenjualan.Item(5, i).Value.ToString()
        TbJmlh.Text = DGVPenjualan.Item(6, i).Value.ToString()
        LbIsiTotal.Text = DGVPenjualan.Item(7, i).Value.ToString()

    End Sub

    Private Sub BtnUbahJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbahJual.Click
        If DTPTglJual.Text = "" Or TbIdUserJual.Text = "" Or TbIdMbrJual.Text = "" Or TbKodeBukuJual.Text = "" Or LbIsiHarga.Text = "" Or TbJmlh.Text = "" Or LbIsiTotal.Text = "" Then
            MsgBox("Update data gagal!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")

        Else
            BtnUbahJual.Enabled = True

            ds = New DataSet
            da = New OleDbDataAdapter("update [data_penjualan] set tanggal_jual = '" & DTPTglJual.Text &
                                      "', id_user = '" & TbIdUserJual.Text &
                                      "', id_member = '" & TbIdMbrJual.Text &
                                      "', kode_buku = '" & TbKodeBukuJual.Text &
                                      "', harga_jual = '" & LbIsiHarga.Text &
                                      "', jumlah_buku = '" & TbJmlh.Text &
                                      "', total_biaya = '" & LbIsiTotal.Text &
                                      "' where no_nota = '" & LbIsiNomor.Text & "' ", conn)
            da.Fill(ds, "data_penjualan")
            MsgBox("Update data berhasil!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")

            For i As Integer = 0 To DGVPenjualan.RowCount - 2 Step 1
                cmd = New OleDbCommand("select * from [data_buku] where kode_buku='" & DGVPenjualan.Rows(i).Cells(4).Value & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    Dim stok As Integer = rd.Item("jumlah_stok")
                    Dim jumlah As Integer = Val(DGVPenjualan.Rows(i).Cells(6).Value)
                    Dim sisa As Integer = stok - jumlah
                    cmd = New OleDbCommand("update [data_buku] set jumlah_stok= '" & sisa & _
                                           "' where kode_buku= '" & DGVPenjualan.Rows(i).Cells(4).Value & "' ", conn)
                    cmd.ExecuteNonQuery()
                End If
            Next i
        End If
        Call koneksi()
        Call kosongkan1()

    End Sub

    Private Sub BtnHapusJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapusJual.Click
        If DTPTglJual.Text = "" Or TbIdUserJual.Text = "" Or TbIdMbrJual.Text = "" Or TbKodeBukuJual.Text = "" Or LbIsiHarga.Text = "" Or TbJmlh.Text = "" Or LbIsiTotal.Text = "" Then
            MsgBox("Hapus data gagal!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
        ElseIf MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ds = New DataSet
            da = New OleDbDataAdapter("delete from [data_penjualan] where no_nota = '" & LbIsiNomor.Text & "' ", conn)
            da.Fill(ds, "data_penjualan")
            MsgBox("Hapus data berhasil!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")

            For i As Integer = 0 To DGVPenjualan.RowCount - 2 Step 1
                cmd = New OleDbCommand("select * from [data_buku] where kode_buku='" & DGVPenjualan.Rows(i).Cells(4).Value & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    Dim stok As Integer = rd.Item("jumlah_stok")
                    Dim jumlah As Integer = Val(DGVPenjualan.Rows(i).Cells(6).Value)
                    Dim sisa As Integer = stok + jumlah
                    cmd = New OleDbCommand("update [data_buku] set jumlah_stok= '" & sisa & _
                                           "' where kode_buku= '" & DGVPenjualan.Rows(i).Cells(4).Value & "' ", conn)
                    cmd.ExecuteNonQuery()
                End If
            Next i
            Call koneksi()
        End If

        Call kosongkan1()

    End Sub

    Private Sub TBNoNota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            DTPTglJual.Focus()
        End If
    End Sub


    Private Sub DTPTglJual_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DTPTglJual.KeyPress
        If e.KeyChar = Chr(13) Then
            TbIdUserJual.Focus()
        End If
    End Sub

    Private Sub TbIdUserJual_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbIdUserJual.KeyPress
        If e.KeyChar = Chr(13) Then
            TbIdMbrJual.Focus()
        End If

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka!", MsgBoxStyle.Information, "Peringatan")
        End If
    End Sub

    Private Sub TbIdMbrJual_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbIdMbrJual.KeyPress
        If e.KeyChar = Chr(13) Then
            TbKodeBukuJual.Focus()
        End If

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka!", MsgBoxStyle.Information, "Peringatan")
        End If
    End Sub

    Private Sub TbKodeBukuJual_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbKodeBukuJual.KeyPress
        If e.KeyChar = Chr(13) Then
            LbIsiHarga.Focus()
            Dim diskon As String
            Dim harga As String
            cmd = New OleDbCommand("select * from [data_buku] where kode_buku= '" & TbKodeBukuJual.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                harga = rd.Item("harga_jual")
                diskon = rd.Item("diskon")
                LbIsiHarga.Text = harga
                LbIsiDiskon.Text = diskon
            Else
                LbIsiHarga.Text = ""
                TbKodeBukuJual.Focus()
                MsgBox("Barang tidak terdaftar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
            End If

        End If

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka dan huruf!", MsgBoxStyle.Information, "Peringatan")
        End If
    End Sub

    Private Sub TbHarga_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            TbJmlh.Focus()
        End If

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
        e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka!", MsgBoxStyle.Information, "Peringatan")
        End If
    End Sub

    Private Sub TbJmlh_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbJmlh.KeyPress
        If e.KeyChar = Chr(13) Then
            LbIsiTotal.Focus()
        End If

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka!", MsgBoxStyle.Information, "Peringatan")
        End If
    End Sub


    Private Sub TbHarga_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub TbHarga_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim harga As String
        Dim diskon As String
        cmd = New OleDbCommand("select * from [data_buku] where kode_buku= '" & TbKodeBukuJual.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            harga = rd.Item("harga_jual")
            diskon = rd.Item("diskon")
            LbIsiHarga.Text = harga
            LbIsiDiskon.Text = diskon

        Else
            LbIsiHarga.Text = ""
            TbKodeBukuJual.Focus()
            MsgBox("Barang tidak terdaftar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
        End If
    End Sub

    Private Sub TbJmlh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbJmlh.TextChanged
        Try
            LbIsiTotal.Text = (Val(TbJmlh.Text)) * (Val(LbIsiHarga.Text) - (Val(LbIsiHarga.Text) * Val(LbIsiDiskon.Text / 100)))
            If LbIsiDiskon.Text = "0" Then
                LbIsiTotal.Text = Val(LbIsiHarga.Text) * Val(TbJmlh.Text)
            End If
        Catch ex As Exception
            LbIsiTotal.Text = ""
        End Try
    End Sub

    Private Sub GrupTotal_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnNota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNota.Click
        CrNota.ReportFileName = "NotaJual.rpt"
        CrNota.WindowState = Crystal.WindowStateConstants.crptMaximized
        ' AxCrystalReport1.RetrieveDataFiles()
        CrNota.Action = 1
    End Sub

    Private Sub TbBayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbBayar.TextChanged

        Try
            TbKembali.Text = Val(TbBayar.Text) - Val(LbIsiTotal.Text)
        Catch ex As Exception
            TbKembali.Text = "0"
        End Try
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