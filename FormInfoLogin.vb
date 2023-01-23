Imports System.Data.OleDb
Public Class FormInfo

    Sub tampil()
        Call koneksi()

        cmd = New OleDbCommand("select * from login", conn)
        rd = cmd.ExecuteReader
        DGVLogin.Rows.Clear()
        Do While rd.Read = True
            DGVLogin.Rows.Add(rd.Item("id_user"), rd.Item("nama_user"), rd.Item("username"), rd.Item("password"))
        Loop
    End Sub

    Sub kosongkan()
        TBNamaUser.Text = ""
        TBIdUser.Text = ""
        TBUsername.Text = ""
        TBPass.Text = ""
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbUASDataSet.login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.DbUASDataSet.login)

        Call koneksi()
        Call tampil()

        TBNamaUser.CharacterCasing = CharacterCasing.Lower
        TBUsername.CharacterCasing = CharacterCasing.Lower
        TBPass.CharacterCasing = CharacterCasing.Lower
    

    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        ds = New DataSet

        If Trim(TBIdUser.Text) = "" Then
            MsgBox("Id User tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TBNamaUser.Text) = "" Then
            MsgBox("Nama tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TBUsername.Text) = "" Then
            MsgBox("Akun Pengguna tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TBPass.Text) = "" Then
            MsgBox("Kata Sandi tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        End If

        da = New OleDbDataAdapter("insert into [login] values" & "('" & TBIdUser.Text & "','" & TBNamaUser.Text & "','" &
       TBUsername.Text & "','" & TBPass.Text & "')", conn)

        da.Fill(ds, "login")
        MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")

        Call kosongkan()

    End Sub

    Private Sub BtnAmbil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAmbil.Click
        Dim i As Integer
        i = DGVLogin.CurrentRow.Index

        TBIdUser.Text = DGVLogin.Item(0, i).Value.ToString()
        TBNamaUser.Text = DGVLogin.Item(1, i).Value.ToString()
        TBUsername.Text = DGVLogin.Item(2, i).Value.ToString()
        TBPass.Text = DGVLogin.Item(3, i).Value.ToString()
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        If TBIdUser.Text = "" Or TBNamaUser.Text = "" Or TBUsername.Text = "" Or TBPass.Text = "" Then
            MsgBox("Update data gagal!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")

        Else

            BtnUbah.Enabled = True
            ds = New DataSet
            da = New OleDbDataAdapter("update login set [nama_user] = '" & TBNamaUser.Text &
                                      "', [username] = '" & TBUsername.Text &
                                      "', [password] = '" & TBPass.Text &
                                      "' where [id_user] = '" & TBIdUser.Text & "' ", conn)
            da.Fill(ds, "login")
            MsgBox("Update data berhasil!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")


        End If
        Call koneksi()
        Call kosongkan()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If TBIdUser.Text = "" Or TBNamaUser.Text = "" Or TBUsername.Text = "" Or TBPass.Text = "" Then
            MsgBox("Hapus data gagal!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")

        ElseIf MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ds = New DataSet
            da = New OleDbDataAdapter("delete from [login] where id_user = '" & TBIdUser.Text & "' ", conn)
            da.Fill(ds, "login")
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
            TBUsername.Focus()
        End If
    End Sub

    Private Sub TBUsername_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBUsername.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar = "_") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya huruf!", MsgBoxStyle.Information, "Peringatan")
        End If

        If e.KeyChar = Chr(13) Then
            TBPass.Focus()
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

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Hide()
        FormLogin.Show()
        FormLogin.TBUsername.Text = ""
        FormLogin.TBPw.Text = ""
    End Sub

    Private Sub DGVLogin_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVLogin.CellContentClick

    End Sub
End Class