Imports System.Data.OleDb
Public Class FormUser

    Sub tampil2()
        Call koneksi()

        cmd = New OleDbCommand("select * from user", conn)
        rd = cmd.ExecuteReader
        DGVUser.Rows.Clear()
        Do While rd.Read = True
            DGVUser.Rows.Add(rd.Item("id_user"), rd.Item("nama_user"), rd.Item("jabatan"), rd.Item("alamat"), rd.Item("jenis_kelamin"), rd.Item("no_telepon"))
        Loop
    End Sub
    Sub kosongkan()
        TBIdUser.Text = ""
        TBNamaUser.Text = ""
        CBJabatanUser.Text = ""
        TBAlamatUser.Text = ""
        CBGenderUser.Text = ""
        TBTeleponUser.Text = ""
        TBIdUser.Focus()

    End Sub


    Private Sub FormUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbUASDataSet.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.DbUASDataSet.user)

        TBNamaUser.CharacterCasing = CharacterCasing.Lower
        TBNamaUser.MaxLength = 30
        TBIdUser.MaxLength = 30
        TBAlamatUser.CharacterCasing = CharacterCasing.Lower
        TBAlamatUser.MaxLength = 50
        TBTeleponUser.MaxLength = 15


    End Sub

    Private Sub BtnMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMember.Click
        Me.Hide()
        FormMember.Show()

    End Sub
    Private Sub BtnSimpanUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpanUser.Click
        ds = New DataSet

        If Trim(TBIdUser.Text) = "" Then
            MsgBox("Id User tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TBNamaUser.Text) = "" Then
            MsgBox("Nama tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(CBJabatanUser.Text) = "" Then
            MsgBox("Jabatan tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TBAlamatUser.Text) = "" Then
            MsgBox("Alamat tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(CBGenderUser.Text) = "" Then
            MsgBox("Jenis kelamin tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TBTeleponUser.Text) = "" Then
            MsgBox("Nomor telepon tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        End If

        da = New OleDbDataAdapter("insert into [user] values" & "('" & TBIdUser.Text & "','" & TBNamaUser.Text & "','" &
        CBJabatanUser.Text & "','" & TBAlamatUser.Text & "','" & CBGenderUser.Text & "','" & TBTeleponUser.Text & "')", conn)

        da.Fill(ds, "user")
        MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")

        Call kosongkan()

    End Sub

    Private Sub BtnAmbil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAmbil.Click
        Dim i As Integer
        i = DGVUser.CurrentRow.Index

        TBIdUser.Text = DGVUser.Item(0, i).Value.ToString()
        TBNamaUser.Text = DGVUser.Item(1, i).Value.ToString()
        CBJabatanUser.Text = DGVUser.Item(2, i).Value.ToString()
        TBAlamatUser.Text = DGVUser.Item(3, i).Value.ToString()
        CBGenderUser.Text = DGVUser.Item(4, i).Value.ToString()
        TBTeleponUser.Text = DGVUser.Item(5, i).Value.ToString()

    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        

        If TBIdUser.Text = "" Or TBNamaUser.Text = "" Or TBAlamatUser.Text = "" Or TBTeleponUser.Text = "" Or CBGenderUser.Text = "" Or CBJabatanUser.Text = "" Then
            MsgBox("Update data gagal!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")

        Else
            BtnUbah.Enabled = True
            ds = New DataSet
            da = New OleDbDataAdapter("update [user] set nama_user = '" & TBNamaUser.Text &
                                      "', jabatan = '" & CBJabatanUser.Text &
                                      "', alamat = '" & TBAlamatUser.Text &
                                      "', jenis_kelamin = '" & CBGenderUser.Text &
                                      "', no_telepon = '" & TBTeleponUser.Text &
                                      "' where id_user = '" & TBIdUser.Text & "' ", conn)
            da.Fill(ds, "user")
            MsgBox("Update data berhasil!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")


        End If
        Call koneksi()
        Call kosongkan()

    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click

        If TBIdUser.Text = "" Or TBNamaUser.Text = "" Or TBAlamatUser.Text = "" Or TBTeleponUser.Text = "" Or CBGenderUser.Text = "" Or CBJabatanUser.Text = "" Then
            MsgBox("Hapus data gagal!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
        ElseIf MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ds = New DataSet
            da = New OleDbDataAdapter("delete from [user] where id_user = '" & TBIdUser.Text & "' ", conn)
            da.Fill(ds, "user")
            MsgBox("Hapus data berhasil!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
            Call koneksi()
        End If

        Call kosongkan()
    End Sub

    Private Sub TBIdUser_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBIdUser.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka!", MsgBoxStyle.Information, "Peringatan")
        End If

        If e.KeyChar = Chr(13) Then
            TBNamaUser.Focus()
        End If
    End Sub

    Private Sub TBNamaUser_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBNamaUser.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar = " ") Or
          e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya huruf!", MsgBoxStyle.Information, "Peringatan")
        End If
        If e.KeyChar = Chr(13) Then
            CBJabatanUser.Focus()
        End If
    End Sub

    Private Sub CBJabatanUser_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBJabatanUser.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar = " ") Or (e.KeyChar = "_") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya huruf!", MsgBoxStyle.Information, "Peringatan")
        End If

        If e.KeyChar = Chr(13) Then
            TBAlamatUser.Focus()
        End If
    End Sub

    Private Sub TBAlamatUser_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBAlamatUser.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar = " ") Or (e.KeyChar = ".") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka dan huruf!", MsgBoxStyle.Information, "Peringatan")
        End If

        If e.KeyChar = Chr(13) Then
            CBGenderUser.Focus()
        End If
    End Sub

    Private Sub CBGenderUser_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBGenderUser.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya huruf!", MsgBoxStyle.Information, "Peringatan")
        End If

        If e.KeyChar = Chr(13) Then
            TBTeleponUser.Focus()
        End If
    End Sub

    Private Sub TBIdUser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBIdUser.TextChanged

    End Sub

    Private Sub TBTeleponUser_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBTeleponUser.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka!", MsgBoxStyle.Information, "Peringatan")
        End If
    End Sub

    
    Private Sub BtnJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJual.Click
        Me.Hide()
        FormPenjualan.Show()
    End Sub

    Private Sub BtnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUser.Click

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

    Private Sub CBJabatanUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBJabatanUser.SelectedIndexChanged

    End Sub
End Class