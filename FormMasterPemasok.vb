Imports System.Data.OleDb
Public Class Formpemasok

    Sub tampil5()
        Call koneksi()

        cmd = New OleDbCommand("select * from suplier", conn)
        rd = cmd.ExecuteReader
        DGVPemasok.Rows.Clear()
        Do While rd.Read = True
            DGVPemasok.Rows.Add(rd.Item("id_suplier"), rd.Item("nama_suplier"), rd.Item("alamat"), rd.Item("no_telepon"))
        Loop
    End Sub
    Sub kosongkan()
        LbisiId.Text = ""
        TbNamaPemasok.Text = ""
        TBAlamatPemasok.Text = ""
        TBTeleponPemasok.Text = ""
        TbNamaPemasok.Focus()

    End Sub

    Private Sub Form_pemasok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbUASDataSet.suplier' table. You can move, or remove it, as needed.
        Me.SuplierTableAdapter.Fill(Me.DbUASDataSet.suplier)

        TbNamaPemasok.MaxLength = 30
        TBAlamatPemasok.MaxLength = 50
        TBTeleponPemasok.MaxLength = 15

        Call koneksi()
        cmd = New OleDbCommand("select * from [suplier] where id_suplier in (select max(id_suplier) from [suplier] )", conn)
        Dim urut As String
        Dim hitung As String
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urut = "0621" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 3) + 1
            urut = "0621" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        LbisiId.Text = urut


    End Sub


    Private Sub BtnSimpanPemasok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpanPemasok.Click
        ds = New DataSet

        
        If Trim(TbNamaPemasok.Text) = "" Then
            MsgBox("Nama tidak boleh kosong!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TBAlamatPemasok.Text) = "" Then
            MsgBox("Alamat tidak boleh kosong!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TBTeleponPemasok.Text) = "" Then
            MsgBox("Nomor telepon tidak boleh kosong!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        End If

        da = New OleDbDataAdapter("insert into [suplier] values" & "('" & LbisiId.Text & "','" & TbNamaPemasok.Text & "','" &
         TBAlamatPemasok.Text & "','" & TBTeleponPemasok.Text & "')", conn)

        da.Fill(ds, "suplier")
        MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")

        Call kosongkan()
    End Sub

    Private Sub BtnAmbil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAmbil.Click
        Dim i As Integer
        i = DGVPemasok.CurrentRow.Index

        LbisiId.Text = DGVPemasok.Item(0, i).Value.ToString()
        TbNamaPemasok.Text = DGVPemasok.Item(1, i).Value.ToString()
        TBAlamatPemasok.Text = DGVPemasok.Item(2, i).Value.ToString()
        TBTeleponPemasok.Text = DGVPemasok.Item(3, i).Value.ToString()
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        If TbNamaPemasok.Text = "" Or TBAlamatPemasok.Text = "" Or TBTeleponPemasok.Text = "" Then
            MsgBox("Update data gagal!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")

        Else
            BtnUbah.Enabled = True
            ds = New DataSet
            da = New OleDbDataAdapter("update [suplier] set nama_suplier = '" & TbNamaPemasok.Text &
                                      "', alamat = '" & TBAlamatPemasok.Text &
                                      "', no_telepon = '" & TBTeleponPemasok.Text &
                                      "' where id_suplier = '" & LbisiId.Text & "' ", conn)
            da.Fill(ds, "suplier")
            MsgBox("Update data berhasil!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")


        End If
        Call koneksi()
        Call kosongkan()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If TbNamaPemasok.Text = "" Or TBAlamatPemasok.Text = "" Or TBTeleponPemasok.Text = "" Then
            MsgBox("Hapus data gagal!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
        ElseIf MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ds = New DataSet
            da = New OleDbDataAdapter("delete from [suplier] where id_suplier = '" & LbisiId.Text & "' ", conn)
            da.Fill(ds, "suplier")
            MsgBox("Hapus data berhasil!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
            Call koneksi()
        End If

        Call kosongkan()
    End Sub

    Private Sub TBIdPemasok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka!", MsgBoxStyle.Information, "Peringatan")
        End If

        If e.KeyChar = Chr(13) Then
            TbNamaPemasok.Focus()
        End If
    End Sub

    Private Sub TbNamaPemasok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbNamaPemasok.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar = " ") Or
          e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya huruf!", MsgBoxStyle.Information, "Peringatan")
        End If
        If e.KeyChar = Chr(13) Then
            TBAlamatPemasok.Focus()
        End If
    End Sub

    Private Sub TBAlamatPemasok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBAlamatPemasok.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar = " ") Or (e.KeyChar = ".") Or
                  e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya huruf dan angka!", MsgBoxStyle.Information, "Peringatan")
        End If
        If e.KeyChar = Chr(13) Then
            TBTeleponPemasok.Focus()
        End If
    End Sub

    Private Sub TBTeleponPemasok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBTeleponPemasok.KeyPress
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

    Private Sub BtnJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJual.Click
        Me.Hide()
        FormPenjualan.Show()

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