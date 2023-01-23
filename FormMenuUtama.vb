
Public Class FormUtama

    Private Sub BtnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUser.Click
        Me.Hide()
        FormUser.Show()
    End Sub

    Private Sub FormUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LbRekom.Text = ""
        TimerRekom.Start()

        TimerKoleksi.Start()
    End Sub

    Private Sub BtnMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMember.Click
        Me.Hide()
        FormMember.Show()
    End Sub

    Private Sub BtnJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJual.Click
        Me.Hide()
        FormPenjualan.Show()

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

    Private Sub TimerRekom_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerRekom.Tick
        Select Case LbRekom.Text
            Case ""
                LbRekom.Text = "T"
            Case "T"
                LbRekom.Text = "TE"
            Case "TE"
                LbRekom.Text = "TER"
            Case "TER"
                LbRekom.Text = "TERL"
            Case "TERL"
                LbRekom.Text = "TERLA"
            Case "TERLA"
                LbRekom.Text = "TERLAR"
            Case "TERLAR"
                LbRekom.Text = "TERLARI"
            Case "TERLARI"
                LbRekom.Text = "TERLARIS"
            Case "TERLARIS"
                LbRekom.Text = ""


        End Select
    End Sub

    Private Sub TimerKoleksi_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerKoleksi.Tick

        If Pic.Visible = True Then
            Pic.Visible = False
            Pic2.Visible = True
        ElseIf Pic2.Visible = True Then
            Pic2.Visible = False
            Pic3.Visible = True
        ElseIf Pic3.Visible = True Then
            Pic3.Visible = False
            Pic4.Visible = True
        ElseIf Pic4.Visible = True Then
            Pic4.Visible = False
            Pic5.Visible = True
        End If


    End Sub
End Class