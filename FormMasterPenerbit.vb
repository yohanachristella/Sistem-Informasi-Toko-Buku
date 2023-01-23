Imports System.Data.OleDb
Public Class FormPenerbit

    Sub tampil6()
        Call koneksi()

        cmd = New OleDbCommand("select * from data_penerbit", conn)
        rd = cmd.ExecuteReader
        DGVPenerbit.Rows.Clear()
        Do While rd.Read = True
            DGVPenerbit.Rows.Add(rd.Item("kode_penerbit"), rd.Item("nama_penerbit"), rd.Item("alamat"), rd.Item("no_telepon"))
        Loop
    End Sub
    Sub kosongkan()
        LbIsiId.Text = ""
        TbNamaPenerbit.Text = ""
        TBAlamatPenerbit.Text = ""
        TBTeleponPenerbit.Text = ""
        TbNamaPenerbit.Focus()

    End Sub
    Private Sub FormPenerbit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbUASDataSet.data_penerbit' table. You can move, or remove it, as needed.
        Me.Data_penerbitTableAdapter.Fill(Me.DbUASDataSet.data_penerbit)

        TbNamaPenerbit.MaxLength = 30
        TBAlamatPenerbit.MaxLength = 50
        TBTeleponPenerbit.MaxLength = 15

        Call koneksi()
        cmd = New OleDbCommand("select * from [data_penerbit] where kode_penerbit in (select max(kode_penerbit) from [data_penerbit] )", conn)
        Dim urut As String
        Dim hitung As String
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urut = "70021" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 3) + 1
            urut = "70021" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        LbIsiId.Text = urut
    End Sub

    Private Sub BtnSimpanPenerbit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpanPenerbit.Click
        ds = New DataSet
        
        If Trim(TbNamaPenerbit.Text) = "" Then
            MsgBox("Nama tidak boleh kosong!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TBAlamatPenerbit.Text) = "" Then
            MsgBox("Alamat tidak boleh kosong!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TBTeleponPenerbit.Text) = "" Then
            MsgBox("Nomor telepon tidak boleh kosong!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        End If

        da = New OleDbDataAdapter("insert into [data_penerbit] values" & "('" & LbIsiId.Text & "','" & TbNamaPenerbit.Text & "','" &
         TBAlamatPenerbit.Text & "','" & TBTeleponPenerbit.Text & "')", conn)

        da.Fill(ds, "data_penerbit")
        MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")

        Call kosongkan()
    End Sub

    Private Sub BtnAmbil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAmbil.Click
        Dim i As Integer
        i = DGVPenerbit.CurrentRow.Index

        LbIsiId.Text = DGVPenerbit.Item(0, i).Value.ToString()
        TbNamaPenerbit.Text = DGVPenerbit.Item(1, i).Value.ToString()
        TBAlamatPenerbit.Text = DGVPenerbit.Item(2, i).Value.ToString()
        TBTeleponPenerbit.Text = DGVPenerbit.Item(3, i).Value.ToString()
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        If TbNamaPenerbit.Text = "" Or TBAlamatPenerbit.Text = "" Or TBTeleponPenerbit.Text = "" Then
            MsgBox("Update data gagal!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")

        Else
            BtnUbah.Enabled = True
            ds = New DataSet
            da = New OleDbDataAdapter("update [data_penerbit] set nama_penerbit = '" & TbNamaPenerbit.Text &
                                      "', alamat = '" & TBAlamatPenerbit.Text &
                                      "', no_telepon = '" & TBTeleponPenerbit.Text &
                                      "' where kode_penerbit = '" & LbIsiId.Text & "' ", conn)
            da.Fill(ds, "data_penerbit")
            MsgBox("Update data berhasil!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")


        End If
        Call koneksi()
        Call kosongkan()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If TbNamaPenerbit.Text = "" Or TBAlamatPenerbit.Text = "" Or TBTeleponPenerbit.Text = "" Then
            MsgBox("Hapus data gagal!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
        ElseIf MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ds = New DataSet
            da = New OleDbDataAdapter("delete from [data_penerbit] where kode_penerbit = '" & LbIsiId.Text & "' ", conn)
            da.Fill(ds, "data_penerbit")
            MsgBox("Hapus data berhasil!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
            Call koneksi()
        End If

        Call kosongkan()
    End Sub

    Private Sub TBKodePenerbit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka!", MsgBoxStyle.Information, "Peringatan")
        End If

        If e.KeyChar = Chr(13) Then
            TbNamaPenerbit.Focus()
        End If
    End Sub

    Private Sub TbNamaPenerbit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbNamaPenerbit.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar = " ") Or (e.KeyChar = ".") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka dan huruf!", MsgBoxStyle.Information, "Peringatan")
        End If

        If e.KeyChar = Chr(13) Then
            TBAlamatPenerbit.Focus()
        End If
    End Sub

    Private Sub TBAlamatPenerbit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBAlamatPenerbit.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar = " ") Or (e.KeyChar = ".") Or
      e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka dan huruf!", MsgBoxStyle.Information, "Peringatan")
        End If

        If e.KeyChar = Chr(13) Then
            TBTeleponPenerbit.Focus()
        End If
    End Sub

    Private Sub TBTeleponPenerbit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBTeleponPenerbit.KeyPress
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

    Private Sub BtnBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuku.Click
        Me.Hide()
        FormBuku.Show()
    End Sub

    Private Sub BtnSuplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSuplier.Click
        Me.Hide()
        Formpemasok.Show()
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