Imports System.Data.OleDb
Public Class FormMember

    Sub tampil3()
        Call koneksi()

        cmd = New OleDbCommand("select * from member", conn)
        rd = cmd.ExecuteReader
        DGVMember.Rows.Clear()
        Do While rd.Read = True
            DGVMember.Rows.Add(rd.Item("id_member"), rd.Item("nama_member"), rd.Item("alamat"), rd.Item("jenis_kelamin"), rd.Item("no_telepon"))
        Loop
    End Sub

    Sub kosongkan2()
        LbIsiId.Text = ""
        TBNamaMember.Text = ""
        TBAlamatMember.Text = ""
        CBGenderMember.Text = ""
        TBTeleponMember.Text = ""
        TBNamaMember.Focus()
    End Sub
    Private Sub FormMember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbUASDataSet.member' table. You can move, or remove it, as needed.
        Me.MemberTableAdapter.Fill(Me.DbUASDataSet.member)

        TBNamaMember.CharacterCasing = CharacterCasing.Lower
        TBNamaMember.MaxLength = 30
        TBAlamatMember.CharacterCasing = CharacterCasing.Lower
        TBAlamatMember.MaxLength = 50
        TBTeleponMember.MaxLength = 15

        Call koneksi()
        cmd = New OleDbCommand("select * from [member] where id_member in (select max(id_member) from [member] )", conn)
        Dim urut As String
        Dim hitung As String
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urut = "0521" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 3) + 1
            urut = "0521" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        LbIsiId.Text = urut
    End Sub

    Private Sub BtnSimpanMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpanMember.Click
        ds = New DataSet

       
        If Trim(TBNamaMember.Text) = "" Then
            MsgBox("Nama tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TBAlamatMember.Text) = "" Then
            MsgBox("Alamat tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(CBGenderMember.Text) = "" Then
            MsgBox("Jenis kelamin tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        ElseIf Trim(TBTeleponMember.Text) = "" Then
            MsgBox("Nomor telepon tidak boleh kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi") : Exit Sub
        End If

        da = New OleDbDataAdapter("insert into [member] values" & "('" & LbIsiId.Text & "','" & TBNamaMember.Text & "','" &
          TBAlamatMember.Text & "','" & CBGenderMember.Text & "','" & TBTeleponMember.Text & "')", conn)

        da.Fill(ds, "member")
        MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Information")

        Call kosongkan2()
    End Sub

    Private Sub BtnAmbil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAmbil.Click
        Dim i As Integer
        i = DGVMember.CurrentRow.Index

        LbIsiId.Text = DGVMember.Item(0, i).Value.ToString()
        TBNamaMember.Text = DGVMember.Item(1, i).Value.ToString()
        TBAlamatMember.Text = DGVMember.Item(2, i).Value.ToString()
        CBGenderMember.Text = DGVMember.Item(3, i).Value.ToString()
        TBTeleponMember.Text = DGVMember.Item(4, i).Value.ToString()
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        If TBNamaMember.Text = "" Or TBAlamatMember.Text = "" Or TBTeleponMember.Text = "" Or CBGenderMember.Text = "" Then
            MsgBox("Update data gagal!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")

        Else
            BtnUbah.Enabled = True
            ds = New DataSet
            da = New OleDbDataAdapter("update [member] set nama_member = '" & TBNamaMember.Text &
                                      "', alamat = '" & TBAlamatMember.Text &
                                      "', jenis_kelamin = '" & CBGenderMember.Text &
                                      "', no_telepon = '" & TBTeleponMember.Text &
                                      "' where id_member = '" & LbIsiId.Text & "' ", conn)
            da.Fill(ds, "member")
            MsgBox("Update data berhasil!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")


        End If
        Call koneksi()
        Call kosongkan2()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If TBNamaMember.Text = "" Or TBAlamatMember.Text = "" Or TBTeleponMember.Text = "" Or CBGenderMember.Text = "" Then
            MsgBox("Hapus data gagal!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
        ElseIf MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ds = New DataSet
            da = New OleDbDataAdapter("delete from [member] where id_member = '" & LbIsiId.Text & "' ", conn)
            da.Fill(ds, "member")
            MsgBox("Hapus data berhasil!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
            Call koneksi()
        End If

        Call kosongkan2()
    End Sub

    Private Sub TBIdMember_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
      e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka!", MsgBoxStyle.Information, "Peringatan")
        End If

        If e.KeyChar = Chr(13) Then
            TBNamaMember.Focus()
        End If
    End Sub

    Private Sub TBNamaMember_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBNamaMember.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar = " ") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya huruf!", MsgBoxStyle.Information, "Peringatan")
        End If

        If e.KeyChar = Chr(13) Then
            TBAlamatMember.Focus()
        End If
    End Sub

    Private Sub TBAlamatMember_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBAlamatMember.KeyPress
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar = " ") Or (e.KeyChar = ".") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya angka dan huruf!", MsgBoxStyle.Information, "Peringatan")
        End If

        If e.KeyChar = Chr(13) Then
            CBGenderMember.Focus()
        End If
    End Sub

    Private Sub CBGenderMember_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBGenderMember.KeyPress
        If e.KeyChar = Chr(13) Then
            TBTeleponMember.Focus()
        End If

        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or
       e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Inputan hanya huruf!", MsgBoxStyle.Information, "Peringatan")
        End If

    End Sub

    Private Sub TBTeleponMember_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBTeleponMember.KeyPress
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

    Private Sub BtnBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuku.Click
        Me.Hide()
        FormBuku.Show()
    End Sub

    Private Sub BtnMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMember.Click

    End Sub

    Private Sub BtnJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJual.Click
        Me.Hide()
        FormPenjualan.Show()
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