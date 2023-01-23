Public Class FormLogin

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TBUsername.CharacterCasing = CharacterCasing.Lower
        TBUsername.MaxLength = 20
        TBPw.MaxLength = 20
        TBUsername.Focus()
        Call koneksi()

        
    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        If TBUsername.Text = "admin" And TBPw.Text = "administrator" Then
            FormUtama.Show()
            Me.Hide()
        ElseIf TBUsername.Text = "putri_kuryana" And TBPw.Text = "admin1" Then
            FormUtama.Show()
            FormUtama.BtnJual.Enabled = False
            FormUtama.BtnSupply.Enabled = False
            FormUtama.BtnRetur.Enabled = False
            FormLpJual.BtnJual.Enabled = False
            FormLpJual.BtnSupply.Enabled = False
            FormLpJual.BtnRetur.Enabled = False
            FormLpKembali.BtnJual.Enabled = False
            FormLpKembali.BtnSupply.Enabled = False
            FormLpKembali.BtnRetur.Enabled = False
            FormLpPasok.BtnJual.Enabled = False
            FormLpPasok.BtnSupply.Enabled = False
            FormLpPasok.BtnRetur.Enabled = False
            FormBuku.BtnJual.Enabled = False
            FormBuku.BtnSupply.Enabled = False
            FormBuku.BtnRetur.Enabled = False
            FormMember.BtnJual.Enabled = False
            FormMember.BtnSupply.Enabled = False
            FormMember.BtnRetur.Enabled = False
            FormUser.BtnJual.Enabled = False
            FormUser.BtnSupply.Enabled = False
            FormUser.BtnRetur.Enabled = False
            Formpemasok.BtnJual.Enabled = False
            Formpemasok.BtnSupply.Enabled = False
            Formpemasok.BtnRetur.Enabled = False
            FormPenerbit.BtnJual.Enabled = False
            FormPenerbit.BtnSupply.Enabled = False
            FormPenerbit.BtnRetur.Enabled = False
            FormInfo.BtnJual.Enabled = False
            FormInfo.BtnSupply.Enabled = False
            FormInfo.BtnRetur.Enabled = False

            Me.Hide()
        ElseIf TBUsername.Text = "franklinfranklin" And TBPw.Text = "admin2" Then
            FormUtama.Show()
            FormUtama.BtnJual.Enabled = False
            FormUtama.BtnSupply.Enabled = False
            FormUtama.BtnRetur.Enabled = False
            FormLpJual.BtnJual.Enabled = False
            FormLpJual.BtnSupply.Enabled = False
            FormLpJual.BtnRetur.Enabled = False
            FormLpKembali.BtnJual.Enabled = False
            FormLpKembali.BtnSupply.Enabled = False
            FormLpKembali.BtnRetur.Enabled = False
            FormLpPasok.BtnJual.Enabled = False
            FormLpPasok.BtnSupply.Enabled = False
            FormLpPasok.BtnRetur.Enabled = False
            FormBuku.BtnJual.Enabled = False
            FormBuku.BtnSupply.Enabled = False
            FormBuku.BtnRetur.Enabled = False
            FormMember.BtnJual.Enabled = False
            FormMember.BtnSupply.Enabled = False
            FormMember.BtnRetur.Enabled = False
            FormUser.BtnJual.Enabled = False
            FormUser.BtnSupply.Enabled = False
            FormUser.BtnRetur.Enabled = False
            Formpemasok.BtnJual.Enabled = False
            Formpemasok.BtnSupply.Enabled = False
            Formpemasok.BtnRetur.Enabled = False
            FormPenerbit.BtnJual.Enabled = False
            FormPenerbit.BtnSupply.Enabled = False
            FormPenerbit.BtnRetur.Enabled = False
            FormInfo.BtnJual.Enabled = False
            FormInfo.BtnSupply.Enabled = False
            FormInfo.BtnRetur.Enabled = False


            Me.Hide()
        ElseIf TBUsername.Text = "wahyuni_sri" And TBPw.Text = "admin3" Then
            FormUtama.Show()
            FormUtama.BtnJual.Enabled = False
            FormUtama.BtnSupply.Enabled = False
            FormUtama.BtnRetur.Enabled = False
            FormLpJual.BtnJual.Enabled = False
            FormLpJual.BtnSupply.Enabled = False
            FormLpJual.BtnRetur.Enabled = False
            FormLpKembali.BtnJual.Enabled = False
            FormLpKembali.BtnSupply.Enabled = False
            FormLpKembali.BtnRetur.Enabled = False
            FormLpPasok.BtnJual.Enabled = False
            FormLpPasok.BtnSupply.Enabled = False
            FormLpPasok.BtnRetur.Enabled = False
            FormBuku.BtnJual.Enabled = False
            FormBuku.BtnSupply.Enabled = False
            FormBuku.BtnRetur.Enabled = False
            FormMember.BtnJual.Enabled = False
            FormMember.BtnSupply.Enabled = False
            FormMember.BtnRetur.Enabled = False
            FormUser.BtnJual.Enabled = False
            FormUser.BtnSupply.Enabled = False
            FormUser.BtnRetur.Enabled = False
            Formpemasok.BtnJual.Enabled = False
            Formpemasok.BtnSupply.Enabled = False
            Formpemasok.BtnRetur.Enabled = False
            FormPenerbit.BtnJual.Enabled = False
            FormPenerbit.BtnSupply.Enabled = False
            FormPenerbit.BtnRetur.Enabled = False
            FormInfo.BtnJual.Enabled = False
            FormInfo.BtnSupply.Enabled = False
            FormInfo.BtnRetur.Enabled = False
            Me.Hide()
        ElseIf TBUsername.Text = "handoko_willy" And TBPw.Text = "kasir1" Then
            FormUtama.Show()
        

            FormPenjualan.LbNamaKasir.Text = "Willy Handoko"

            Me.Hide()
        ElseIf TBUsername.Text = "vivianvivian" And TBPw.Text = "kasir2" Then
            FormUtama.Show()
            FormUtama.BtnSuplier.Enabled = False
            FormUtama.BtnPenerbit.Enabled = False
            FormUtama.BtnSupply.Enabled = False
            FormUtama.BtnInvoiceJual.Enabled = False
            FormUtama.BtnInvoiceSupply.Enabled = False
            FormUtama.BtnInvoiceRetur.Enabled = False
            FormBuku.BtnSuplier.Enabled = False
            FormBuku.BtnPenerbit.Enabled = False
            FormBuku.BtnSupply.Enabled = False
            FormBuku.BtnInvoiceJual.Enabled = False
            FormBuku.BtnInvoiceSupply.Enabled = False
            FormBuku.BtnInvoiceRetur.Enabled = False
            FormUser.BtnSuplier.Enabled = False
            FormUser.BtnPenerbit.Enabled = False
            FormUser.BtnSupply.Enabled = False
            FormUser.BtnInvoiceJual.Enabled = False
            FormUser.BtnInvoiceSupply.Enabled = False
            FormUser.BtnInvoiceRetur.Enabled = False
            FormMember.BtnSuplier.Enabled = False
            FormMember.BtnPenerbit.Enabled = False
            FormMember.BtnSupply.Enabled = False
            FormMember.BtnInvoiceJual.Enabled = False
            FormMember.BtnInvoiceSupply.Enabled = False
            FormMember.BtnInvoiceRetur.Enabled = False
            FormPenjualan.BtnSuplier.Enabled = False
            FormPenjualan.BtnPenerbit.Enabled = False
            FormPenjualan.BtnSupply.Enabled = False
            FormPenjualan.BtnInvoiceRetur.Enabled = False
            FormPenjualan.BtnInvoiceJual.Enabled = False
            FormPenjualan.BtnInvoiceRetur.Enabled = False
            FormPengembalian.BtnSuplier.Enabled = False
            FormPengembalian.BtnPenerbit.Enabled = False
            FormPengembalian.BtnSupply.Enabled = False
            FormPengembalian.BtnInvoiceJual.Enabled = False
            FormPengembalian.BtnInvoiceSupply.Enabled = False
            FormPengembalian.BtnInvoiceRetur.Enabled = False
            FormInfo.BtnSuplier.Enabled = False
            FormInfo.BtnPenerbit.Enabled = False
            FormInfo.BtnSupply.Enabled = False
            FormInfo.BtnInvoiceJual.Enabled = False
            FormInfo.BtnInvoiceRetur.Enabled = False
            FormInfo.BtnInvoiceSupply.Enabled = False

            FormPenjualan.LbNamaKasir.Text = "Vivian"

            Me.Hide()
        ElseIf TBUsername.Text = "elisaelisa" And TBPw.Text = "kasir3" Then
            FormUtama.Show()
            FormUtama.BtnSuplier.Enabled = False
            FormUtama.BtnPenerbit.Enabled = False
            FormUtama.BtnSupply.Enabled = False
            FormUtama.BtnInvoiceJual.Enabled = False
            FormUtama.BtnInvoiceSupply.Enabled = False
            FormUtama.BtnInvoiceRetur.Enabled = False
            FormBuku.BtnSuplier.Enabled = False
            FormBuku.BtnPenerbit.Enabled = False
            FormBuku.BtnSupply.Enabled = False
            FormBuku.BtnInvoiceJual.Enabled = False
            FormBuku.BtnInvoiceSupply.Enabled = False
            FormBuku.BtnInvoiceRetur.Enabled = False
            FormUser.BtnSuplier.Enabled = False
            FormUser.BtnPenerbit.Enabled = False
            FormUser.BtnSupply.Enabled = False
            FormUser.BtnInvoiceJual.Enabled = False
            FormUser.BtnInvoiceSupply.Enabled = False
            FormUser.BtnInvoiceRetur.Enabled = False
            FormMember.BtnSuplier.Enabled = False
            FormMember.BtnPenerbit.Enabled = False
            FormMember.BtnSupply.Enabled = False
            FormMember.BtnInvoiceJual.Enabled = False
            FormMember.BtnInvoiceSupply.Enabled = False
            FormMember.BtnInvoiceRetur.Enabled = False
            FormPenjualan.BtnSuplier.Enabled = False
            FormPenjualan.BtnPenerbit.Enabled = False
            FormPenjualan.BtnSupply.Enabled = False
            FormPenjualan.BtnInvoiceRetur.Enabled = False
            FormPenjualan.BtnInvoiceJual.Enabled = False
            FormPenjualan.BtnInvoiceRetur.Enabled = False
            FormPengembalian.BtnSuplier.Enabled = False
            FormPengembalian.BtnPenerbit.Enabled = False
            FormPengembalian.BtnSupply.Enabled = False
            FormPengembalian.BtnInvoiceJual.Enabled = False
            FormPengembalian.BtnInvoiceSupply.Enabled = False
            FormPengembalian.BtnInvoiceRetur.Enabled = False
            FormInfo.BtnSuplier.Enabled = False
            FormInfo.BtnPenerbit.Enabled = False
            FormInfo.BtnSupply.Enabled = False
            FormInfo.BtnInvoiceJual.Enabled = False
            FormInfo.BtnInvoiceRetur.Enabled = False
            FormInfo.BtnInvoiceSupply.Enabled = False

            FormPenjualan.LbNamaKasir.Text = "Elisa"

            Me.Hide()
        ElseIf TBUsername.Text = "arifin_zainal" And TBPw.Text = "warehouse1" Then
            FormUtama.Show()
            FormUtama.BtnMember.Enabled = False
            FormUtama.BtnPenerbit.Enabled = False
            FormUtama.BtnJual.Enabled = False
            FormUtama.BtnRetur.Enabled = False
            FormUtama.BtnInvoiceJual.Enabled = False
            FormUtama.BtnInvoiceSupply.Enabled = False
            FormUtama.BtnInvoiceRetur.Enabled = False
            FormUser.BtnMember.Enabled = False
            FormUser.BtnPenerbit.Enabled = False
            FormUser.BtnJual.Enabled = False
            FormUser.BtnRetur.Enabled = False
            FormUser.BtnInvoiceJual.Enabled = False
            FormUser.BtnInvoiceRetur.Enabled = False
            FormUser.BtnInvoiceSupply.Enabled = False
            FormBuku.BtnMember.Enabled = False
            FormBuku.BtnPenerbit.Enabled = False
            FormBuku.BtnJual.Enabled = False
            FormBuku.BtnRetur.Enabled = False
            FormBuku.BtnInvoiceJual.Enabled = False
            FormBuku.BtnInvoiceRetur.Enabled = False
            FormBuku.BtnInvoiceSupply.Enabled = False
            Formpemasok.BtnMember.Enabled = False
            Formpemasok.BtnPenerbit.Enabled = False
            Formpemasok.BtnJual.Enabled = False
            Formpemasok.BtnRetur.Enabled = False
            Formpemasok.BtnInvoiceJual.Enabled = False
            Formpemasok.BtnInvoiceRetur.Enabled = False
            Formpemasok.BtnInvoiceSupply.Enabled = False
            FormPasok.BtnMember.Enabled = False
            FormPasok.BtnPenerbit.Enabled = False
            FormPasok.BtnJual.Enabled = False
            FormPasok.BtnRetur.Enabled = False
            FormPasok.BtnInvoiceJual.Enabled = False
            FormPasok.BtnInvoiceRetur.Enabled = False
            FormPasok.BtnInvoiceSupply.Enabled = False
            FormInfo.BtnMember.Enabled = False
            FormInfo.BtnPenerbit.Enabled = False
            FormInfo.BtnJual.Enabled = False
            FormInfo.BtnRetur.Enabled = False
            FormInfo.BtnInvoiceJual.Enabled = False
            FormInfo.BtnInvoiceRetur.Enabled = False
            FormInfo.BtnInvoiceSupply.Enabled = False

            Me.Hide()
        ElseIf TBUsername.Text = "widyawatiwidyawati" And TBPw.Text = "warehouse2" Then
            FormUtama.Show()
            FormUtama.BtnMember.Enabled = False
            FormUtama.BtnPenerbit.Enabled = False
            FormUtama.BtnJual.Enabled = False
            FormUtama.BtnRetur.Enabled = False
            FormUtama.BtnInvoiceJual.Enabled = False
            FormUtama.BtnInvoiceSupply.Enabled = False
            FormUtama.BtnInvoiceRetur.Enabled = False
            FormUser.BtnMember.Enabled = False
            FormUser.BtnPenerbit.Enabled = False
            FormUser.BtnJual.Enabled = False
            FormUser.BtnRetur.Enabled = False
            FormUser.BtnInvoiceJual.Enabled = False
            FormUser.BtnInvoiceRetur.Enabled = False
            FormUser.BtnInvoiceSupply.Enabled = False
            FormBuku.BtnMember.Enabled = False
            FormBuku.BtnPenerbit.Enabled = False
            FormBuku.BtnJual.Enabled = False
            FormBuku.BtnRetur.Enabled = False
            FormBuku.BtnInvoiceJual.Enabled = False
            FormBuku.BtnInvoiceRetur.Enabled = False
            FormBuku.BtnInvoiceSupply.Enabled = False
            Formpemasok.BtnMember.Enabled = False
            Formpemasok.BtnPenerbit.Enabled = False
            Formpemasok.BtnJual.Enabled = False
            Formpemasok.BtnRetur.Enabled = False
            Formpemasok.BtnInvoiceJual.Enabled = False
            Formpemasok.BtnInvoiceRetur.Enabled = False
            Formpemasok.BtnInvoiceSupply.Enabled = False
            FormPasok.BtnMember.Enabled = False
            FormPasok.BtnPenerbit.Enabled = False
            FormPasok.BtnJual.Enabled = False
            FormPasok.BtnRetur.Enabled = False
            FormPasok.BtnInvoiceJual.Enabled = False
            FormPasok.BtnInvoiceRetur.Enabled = False
            FormPasok.BtnInvoiceSupply.Enabled = False
            FormInfo.BtnMember.Enabled = False
            FormInfo.BtnPenerbit.Enabled = False
            FormInfo.BtnJual.Enabled = False
            FormInfo.BtnRetur.Enabled = False
            FormInfo.BtnInvoiceJual.Enabled = False
            FormInfo.BtnInvoiceRetur.Enabled = False
            FormInfo.BtnInvoiceSupply.Enabled = False

            Me.Hide()
        ElseIf TBUsername.Text = "susilo_bambang" And TBPw.Text = "manajer" Then
            FormUtama.Show()
            FormUtama.BtnMember.Enabled = False
            FormUtama.BtnPenerbit.Enabled = False
            FormUtama.BtnJual.Enabled = False
            FormUtama.BtnSupply.Enabled = False
            FormUtama.BtnRetur.Enabled = False
            FormUser.BtnMember.Enabled = False
            FormUser.BtnPenerbit.Enabled = False
            FormUser.BtnJual.Enabled = False
            FormUser.BtnSupply.Enabled = False
            FormUser.BtnRetur.Enabled = False
            FormBuku.BtnMember.Enabled = False
            FormBuku.BtnPenerbit.Enabled = False
            FormBuku.BtnJual.Enabled = False
            FormBuku.BtnSupply.Enabled = False
            FormBuku.BtnRetur.Enabled = False
            Formpemasok.BtnMember.Enabled = False
            Formpemasok.BtnPenerbit.Enabled = False
            Formpemasok.BtnJual.Enabled = False
            Formpemasok.BtnSupply.Enabled = False
            Formpemasok.BtnRetur.Enabled = False
            FormLpJual.BtnMember.Enabled = False
            FormLpJual.BtnPenerbit.Enabled = False
            FormLpJual.BtnJual.Enabled = False
            FormLpJual.BtnSupply.Enabled = False
            FormLpJual.BtnRetur.Enabled = False
            FormLpKembali.BtnMember.Enabled = False
            FormLpKembali.BtnPenerbit.Enabled = False
            FormLpKembali.BtnJual.Enabled = False
            FormLpKembali.BtnSupply.Enabled = False
            FormLpKembali.BtnRetur.Enabled = False
            FormLpPasok.BtnMember.Enabled = False
            FormLpPasok.BtnPenerbit.Enabled = False
            FormLpPasok.BtnJual.Enabled = False
            FormLpPasok.BtnSupply.Enabled = False
            FormLpPasok.BtnRetur.Enabled = False
            FormInfo.BtnMember.Enabled = False
            FormInfo.BtnPenerbit.Enabled = False
            FormInfo.BtnJual.Enabled = False
            FormInfo.BtnSupply.Enabled = False
            FormInfo.BtnRetur.Enabled = False

            Me.Hide()
        ElseIf TBUsername.Text = "" And TBPw.Text = "" Then
            MsgBox("Inputkan Username dan Password terlebih dahulu!", , "Oops!")
        Else
            MsgBox("Username atau Password Salah, Ulangi lagi!", , "Oops!")
        End If
    End Sub

    Private Sub TBUsername_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBUsername.KeyPress
        If e.KeyChar = Chr(13) Then
            TBPw.Focus()
        End If

    End Sub

    Private Sub TBPw_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBPw.KeyPress
        If e.KeyChar = Chr(13) Then
            BtnLogin.Focus()
        End If
    End Sub

    Private Sub BtnLogin_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnLogin.MouseMove
        BtnLogin.BackColor = Color.Orange
    End Sub


    Private Sub TBUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBUsername.TextChanged

    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        TBUsername.Text = ""
        TBPw.Text = ""
        TBUsername.Focus()
    End Sub
End Class
