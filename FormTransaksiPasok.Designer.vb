<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPasok
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPasok))
        Me.Tab = New System.Windows.Forms.TabControl()
        Me.TabMaster = New System.Windows.Forms.TabPage()
        Me.BtnPenerbit = New System.Windows.Forms.Button()
        Me.BtnSuplier = New System.Windows.Forms.Button()
        Me.BtnBuku = New System.Windows.Forms.Button()
        Me.BtnMember = New System.Windows.Forms.Button()
        Me.BtnUser = New System.Windows.Forms.Button()
        Me.TabTransaksi = New System.Windows.Forms.TabPage()
        Me.BtnRetur = New System.Windows.Forms.Button()
        Me.BtnSupply = New System.Windows.Forms.Button()
        Me.BtnJual = New System.Windows.Forms.Button()
        Me.TabLaporan = New System.Windows.Forms.TabPage()
        Me.BtnInvoiceRetur = New System.Windows.Forms.Button()
        Me.BtnInvoiceSupply = New System.Windows.Forms.Button()
        Me.BtnInvoiceJual = New System.Windows.Forms.Button()
        Me.TabPengaturan = New System.Windows.Forms.TabPage()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtnInfo = New System.Windows.Forms.Button()
        Me.LbDataPasok = New System.Windows.Forms.Label()
        Me.DGVPasok = New System.Windows.Forms.DataGridView()
        Me.no_penerimaan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal_terima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_suplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_beli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_biaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatasuplyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbUASDataSet = New WindowsApplication1.DbUASDataSet()
        Me.GrupInputPasok = New System.Windows.Forms.GroupBox()
        Me.LbIsiTotal = New System.Windows.Forms.Label()
        Me.LbIsiHarga = New System.Windows.Forms.Label()
        Me.LbIsiTerima = New System.Windows.Forms.Label()
        Me.LbTotal = New System.Windows.Forms.Label()
        Me.TbJmlh = New System.Windows.Forms.TextBox()
        Me.TbKodeBuku = New System.Windows.Forms.TextBox()
        Me.LbJumlah = New System.Windows.Forms.Label()
        Me.LbIdPemasok = New System.Windows.Forms.Label()
        Me.TbIdPemasok = New System.Windows.Forms.TextBox()
        Me.TbIdUser = New System.Windows.Forms.TextBox()
        Me.DTPTglTerima = New System.Windows.Forms.DateTimePicker()
        Me.LbHargaBeli = New System.Windows.Forms.Label()
        Me.LbKodeBuku = New System.Windows.Forms.Label()
        Me.LbIdUserPasok = New System.Windows.Forms.Label()
        Me.LbTglTerima = New System.Windows.Forms.Label()
        Me.LbNoTerima = New System.Windows.Forms.Label()
        Me.BtnHapusJual = New System.Windows.Forms.Button()
        Me.BtnUbahJual = New System.Windows.Forms.Button()
        Me.BtnAmbilJual = New System.Windows.Forms.Button()
        Me.BtnSimpanPasok = New System.Windows.Forms.Button()
        Me.LbMotivasi = New System.Windows.Forms.Label()
        Me.LbJudul = New System.Windows.Forms.Label()
        Me.Data_suplyTableAdapter = New WindowsApplication1.DbUASDataSetTableAdapters.data_suplyTableAdapter()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.Tab.SuspendLayout()
        Me.TabMaster.SuspendLayout()
        Me.TabTransaksi.SuspendLayout()
        Me.TabLaporan.SuspendLayout()
        Me.TabPengaturan.SuspendLayout()
        CType(Me.DGVPasok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatasuplyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbUASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupInputPasok.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab
        '
        Me.Tab.Controls.Add(Me.TabMaster)
        Me.Tab.Controls.Add(Me.TabTransaksi)
        Me.Tab.Controls.Add(Me.TabLaporan)
        Me.Tab.Controls.Add(Me.TabPengaturan)
        Me.Tab.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab.Location = New System.Drawing.Point(-4, 0)
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(882, 114)
        Me.Tab.TabIndex = 3
        '
        'TabMaster
        '
        Me.TabMaster.BackColor = System.Drawing.Color.Gold
        Me.TabMaster.Controls.Add(Me.BtnPenerbit)
        Me.TabMaster.Controls.Add(Me.BtnSuplier)
        Me.TabMaster.Controls.Add(Me.BtnBuku)
        Me.TabMaster.Controls.Add(Me.BtnMember)
        Me.TabMaster.Controls.Add(Me.BtnUser)
        Me.TabMaster.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabMaster.Location = New System.Drawing.Point(4, 26)
        Me.TabMaster.Name = "TabMaster"
        Me.TabMaster.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMaster.Size = New System.Drawing.Size(874, 84)
        Me.TabMaster.TabIndex = 0
        Me.TabMaster.Text = "Master"
        '
        'BtnPenerbit
        '
        Me.BtnPenerbit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPenerbit.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnPenerbit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPenerbit.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPenerbit.Image = CType(resources.GetObject("BtnPenerbit.Image"), System.Drawing.Image)
        Me.BtnPenerbit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPenerbit.Location = New System.Drawing.Point(331, 3)
        Me.BtnPenerbit.Name = "BtnPenerbit"
        Me.BtnPenerbit.Size = New System.Drawing.Size(98, 78)
        Me.BtnPenerbit.TabIndex = 4
        Me.BtnPenerbit.Text = "Data Penerbit"
        Me.BtnPenerbit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPenerbit.UseVisualStyleBackColor = True
        '
        'BtnSuplier
        '
        Me.BtnSuplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSuplier.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnSuplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSuplier.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSuplier.Image = CType(resources.GetObject("BtnSuplier.Image"), System.Drawing.Image)
        Me.BtnSuplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSuplier.Location = New System.Drawing.Point(237, 3)
        Me.BtnSuplier.Name = "BtnSuplier"
        Me.BtnSuplier.Size = New System.Drawing.Size(94, 78)
        Me.BtnSuplier.TabIndex = 3
        Me.BtnSuplier.Text = "Data Pemasok"
        Me.BtnSuplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSuplier.UseVisualStyleBackColor = True
        '
        'BtnBuku
        '
        Me.BtnBuku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnBuku.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuku.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuku.Image = CType(resources.GetObject("BtnBuku.Image"), System.Drawing.Image)
        Me.BtnBuku.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBuku.Location = New System.Drawing.Point(160, 3)
        Me.BtnBuku.Name = "BtnBuku"
        Me.BtnBuku.Size = New System.Drawing.Size(77, 78)
        Me.BtnBuku.TabIndex = 2
        Me.BtnBuku.Text = "Data Buku"
        Me.BtnBuku.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBuku.UseVisualStyleBackColor = True
        '
        'BtnMember
        '
        Me.BtnMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnMember.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMember.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMember.Image = CType(resources.GetObject("BtnMember.Image"), System.Drawing.Image)
        Me.BtnMember.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnMember.Location = New System.Drawing.Point(80, 3)
        Me.BtnMember.Name = "BtnMember"
        Me.BtnMember.Size = New System.Drawing.Size(80, 78)
        Me.BtnMember.TabIndex = 1
        Me.BtnMember.Text = "Pelanggan"
        Me.BtnMember.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnMember.UseVisualStyleBackColor = True
        '
        'BtnUser
        '
        Me.BtnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnUser.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUser.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUser.Image = CType(resources.GetObject("BtnUser.Image"), System.Drawing.Image)
        Me.BtnUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnUser.Location = New System.Drawing.Point(3, 3)
        Me.BtnUser.Name = "BtnUser"
        Me.BtnUser.Size = New System.Drawing.Size(77, 78)
        Me.BtnUser.TabIndex = 0
        Me.BtnUser.Text = "Pengguna"
        Me.BtnUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnUser.UseVisualStyleBackColor = True
        '
        'TabTransaksi
        '
        Me.TabTransaksi.BackColor = System.Drawing.Color.Gold
        Me.TabTransaksi.Controls.Add(Me.BtnRetur)
        Me.TabTransaksi.Controls.Add(Me.BtnSupply)
        Me.TabTransaksi.Controls.Add(Me.BtnJual)
        Me.TabTransaksi.Location = New System.Drawing.Point(4, 26)
        Me.TabTransaksi.Name = "TabTransaksi"
        Me.TabTransaksi.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTransaksi.Size = New System.Drawing.Size(874, 84)
        Me.TabTransaksi.TabIndex = 1
        Me.TabTransaksi.Text = "Transaksi"
        '
        'BtnRetur
        '
        Me.BtnRetur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnRetur.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnRetur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRetur.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRetur.Image = CType(resources.GetObject("BtnRetur.Image"), System.Drawing.Image)
        Me.BtnRetur.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnRetur.Location = New System.Drawing.Point(157, 3)
        Me.BtnRetur.Name = "BtnRetur"
        Me.BtnRetur.Size = New System.Drawing.Size(99, 78)
        Me.BtnRetur.TabIndex = 3
        Me.BtnRetur.Text = "Pengembalian"
        Me.BtnRetur.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRetur.UseVisualStyleBackColor = True
        '
        'BtnSupply
        '
        Me.BtnSupply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSupply.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnSupply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSupply.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSupply.Image = CType(resources.GetObject("BtnSupply.Image"), System.Drawing.Image)
        Me.BtnSupply.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSupply.Location = New System.Drawing.Point(80, 3)
        Me.BtnSupply.Name = "BtnSupply"
        Me.BtnSupply.Size = New System.Drawing.Size(77, 78)
        Me.BtnSupply.TabIndex = 2
        Me.BtnSupply.Text = "Pasok"
        Me.BtnSupply.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSupply.UseVisualStyleBackColor = True
        '
        'BtnJual
        '
        Me.BtnJual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnJual.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnJual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnJual.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJual.Image = CType(resources.GetObject("BtnJual.Image"), System.Drawing.Image)
        Me.BtnJual.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnJual.Location = New System.Drawing.Point(3, 3)
        Me.BtnJual.Name = "BtnJual"
        Me.BtnJual.Size = New System.Drawing.Size(77, 78)
        Me.BtnJual.TabIndex = 1
        Me.BtnJual.Text = "Penjualan"
        Me.BtnJual.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnJual.UseVisualStyleBackColor = True
        '
        'TabLaporan
        '
        Me.TabLaporan.BackColor = System.Drawing.Color.Gold
        Me.TabLaporan.Controls.Add(Me.BtnInvoiceRetur)
        Me.TabLaporan.Controls.Add(Me.BtnInvoiceSupply)
        Me.TabLaporan.Controls.Add(Me.BtnInvoiceJual)
        Me.TabLaporan.Location = New System.Drawing.Point(4, 26)
        Me.TabLaporan.Name = "TabLaporan"
        Me.TabLaporan.Size = New System.Drawing.Size(874, 84)
        Me.TabLaporan.TabIndex = 2
        Me.TabLaporan.Text = "Laporan"
        '
        'BtnInvoiceRetur
        '
        Me.BtnInvoiceRetur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnInvoiceRetur.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnInvoiceRetur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInvoiceRetur.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInvoiceRetur.Image = CType(resources.GetObject("BtnInvoiceRetur.Image"), System.Drawing.Image)
        Me.BtnInvoiceRetur.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnInvoiceRetur.Location = New System.Drawing.Point(222, 0)
        Me.BtnInvoiceRetur.Name = "BtnInvoiceRetur"
        Me.BtnInvoiceRetur.Size = New System.Drawing.Size(131, 84)
        Me.BtnInvoiceRetur.TabIndex = 4
        Me.BtnInvoiceRetur.Text = "Laporan Pengembalian"
        Me.BtnInvoiceRetur.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnInvoiceRetur.UseVisualStyleBackColor = True
        '
        'BtnInvoiceSupply
        '
        Me.BtnInvoiceSupply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnInvoiceSupply.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnInvoiceSupply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInvoiceSupply.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInvoiceSupply.Image = CType(resources.GetObject("BtnInvoiceSupply.Image"), System.Drawing.Image)
        Me.BtnInvoiceSupply.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnInvoiceSupply.Location = New System.Drawing.Point(111, 0)
        Me.BtnInvoiceSupply.Name = "BtnInvoiceSupply"
        Me.BtnInvoiceSupply.Size = New System.Drawing.Size(111, 84)
        Me.BtnInvoiceSupply.TabIndex = 3
        Me.BtnInvoiceSupply.Text = "Laporan Pasok"
        Me.BtnInvoiceSupply.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnInvoiceSupply.UseVisualStyleBackColor = True
        '
        'BtnInvoiceJual
        '
        Me.BtnInvoiceJual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnInvoiceJual.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnInvoiceJual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInvoiceJual.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInvoiceJual.Image = CType(resources.GetObject("BtnInvoiceJual.Image"), System.Drawing.Image)
        Me.BtnInvoiceJual.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnInvoiceJual.Location = New System.Drawing.Point(0, 0)
        Me.BtnInvoiceJual.Name = "BtnInvoiceJual"
        Me.BtnInvoiceJual.Size = New System.Drawing.Size(111, 84)
        Me.BtnInvoiceJual.TabIndex = 2
        Me.BtnInvoiceJual.Text = "Laporan Penjualan"
        Me.BtnInvoiceJual.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnInvoiceJual.UseVisualStyleBackColor = True
        '
        'TabPengaturan
        '
        Me.TabPengaturan.BackColor = System.Drawing.Color.Gold
        Me.TabPengaturan.Controls.Add(Me.BtnKeluar)
        Me.TabPengaturan.Controls.Add(Me.BtnInfo)
        Me.TabPengaturan.Location = New System.Drawing.Point(4, 26)
        Me.TabPengaturan.Name = "TabPengaturan"
        Me.TabPengaturan.Size = New System.Drawing.Size(874, 84)
        Me.TabPengaturan.TabIndex = 3
        Me.TabPengaturan.Text = "Pengaturan"
        '
        'BtnKeluar
        '
        Me.BtnKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnKeluar.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKeluar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Image = CType(resources.GetObject("BtnKeluar.Image"), System.Drawing.Image)
        Me.BtnKeluar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnKeluar.Location = New System.Drawing.Point(93, 0)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(93, 84)
        Me.BtnKeluar.TabIndex = 6
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtnInfo
        '
        Me.BtnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnInfo.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInfo.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInfo.Image = CType(resources.GetObject("BtnInfo.Image"), System.Drawing.Image)
        Me.BtnInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnInfo.Location = New System.Drawing.Point(0, 0)
        Me.BtnInfo.Name = "BtnInfo"
        Me.BtnInfo.Size = New System.Drawing.Size(93, 84)
        Me.BtnInfo.TabIndex = 5
        Me.BtnInfo.Text = "Info Operator "
        Me.BtnInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnInfo.UseVisualStyleBackColor = True
        '
        'LbDataPasok
        '
        Me.LbDataPasok.AutoSize = True
        Me.LbDataPasok.BackColor = System.Drawing.Color.Transparent
        Me.LbDataPasok.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDataPasok.Location = New System.Drawing.Point(12, 119)
        Me.LbDataPasok.Name = "LbDataPasok"
        Me.LbDataPasok.Size = New System.Drawing.Size(164, 21)
        Me.LbDataPasok.TabIndex = 15
        Me.LbDataPasok.Text = "Data Transaksi Pasok"
        '
        'DGVPasok
        '
        Me.DGVPasok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPasok.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no_penerimaan, Me.tanggal_terima, Me.id_user, Me.id_suplier, Me.kode_buku, Me.harga_beli, Me.jumlah_buku, Me.total_biaya})
        Me.DGVPasok.Location = New System.Drawing.Point(16, 143)
        Me.DGVPasok.Name = "DGVPasok"
        Me.DGVPasok.Size = New System.Drawing.Size(517, 308)
        Me.DGVPasok.TabIndex = 16
        '
        'no_penerimaan
        '
        Me.no_penerimaan.HeaderText = "no_penerimaan"
        Me.no_penerimaan.Name = "no_penerimaan"
        '
        'tanggal_terima
        '
        Me.tanggal_terima.HeaderText = "tanggal_terima"
        Me.tanggal_terima.Name = "tanggal_terima"
        '
        'id_user
        '
        Me.id_user.HeaderText = "id_user"
        Me.id_user.Name = "id_user"
        '
        'id_suplier
        '
        Me.id_suplier.HeaderText = "id_suplier"
        Me.id_suplier.Name = "id_suplier"
        '
        'kode_buku
        '
        Me.kode_buku.HeaderText = "kode_buku"
        Me.kode_buku.Name = "kode_buku"
        '
        'harga_beli
        '
        Me.harga_beli.HeaderText = "harga_beli"
        Me.harga_beli.Name = "harga_beli"
        '
        'jumlah_buku
        '
        Me.jumlah_buku.HeaderText = "jumlah_buku"
        Me.jumlah_buku.Name = "jumlah_buku"
        '
        'total_biaya
        '
        Me.total_biaya.HeaderText = "total_biaya"
        Me.total_biaya.Name = "total_biaya"
        '
        'DatasuplyBindingSource
        '
        Me.DatasuplyBindingSource.DataMember = "data_suply"
        Me.DatasuplyBindingSource.DataSource = Me.DbUASDataSet
        '
        'DbUASDataSet
        '
        Me.DbUASDataSet.DataSetName = "DbUASDataSet"
        Me.DbUASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GrupInputPasok
        '
        Me.GrupInputPasok.BackColor = System.Drawing.Color.Transparent
        Me.GrupInputPasok.Controls.Add(Me.LbIsiTotal)
        Me.GrupInputPasok.Controls.Add(Me.LbIsiHarga)
        Me.GrupInputPasok.Controls.Add(Me.LbIsiTerima)
        Me.GrupInputPasok.Controls.Add(Me.LbTotal)
        Me.GrupInputPasok.Controls.Add(Me.TbJmlh)
        Me.GrupInputPasok.Controls.Add(Me.TbKodeBuku)
        Me.GrupInputPasok.Controls.Add(Me.LbJumlah)
        Me.GrupInputPasok.Controls.Add(Me.LbIdPemasok)
        Me.GrupInputPasok.Controls.Add(Me.TbIdPemasok)
        Me.GrupInputPasok.Controls.Add(Me.TbIdUser)
        Me.GrupInputPasok.Controls.Add(Me.DTPTglTerima)
        Me.GrupInputPasok.Controls.Add(Me.LbHargaBeli)
        Me.GrupInputPasok.Controls.Add(Me.LbKodeBuku)
        Me.GrupInputPasok.Controls.Add(Me.LbIdUserPasok)
        Me.GrupInputPasok.Controls.Add(Me.LbTglTerima)
        Me.GrupInputPasok.Controls.Add(Me.LbNoTerima)
        Me.GrupInputPasok.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupInputPasok.Location = New System.Drawing.Point(555, 133)
        Me.GrupInputPasok.Name = "GrupInputPasok"
        Me.GrupInputPasok.Size = New System.Drawing.Size(293, 284)
        Me.GrupInputPasok.TabIndex = 17
        Me.GrupInputPasok.TabStop = False
        Me.GrupInputPasok.Text = "Tambah Pasokan"
        '
        'LbIsiTotal
        '
        Me.LbIsiTotal.AutoSize = True
        Me.LbIsiTotal.Location = New System.Drawing.Point(100, 248)
        Me.LbIsiTotal.Name = "LbIsiTotal"
        Me.LbIsiTotal.Size = New System.Drawing.Size(0, 18)
        Me.LbIsiTotal.TabIndex = 23
        '
        'LbIsiHarga
        '
        Me.LbIsiHarga.AutoSize = True
        Me.LbIsiHarga.Location = New System.Drawing.Point(100, 188)
        Me.LbIsiHarga.Name = "LbIsiHarga"
        Me.LbIsiHarga.Size = New System.Drawing.Size(0, 18)
        Me.LbIsiHarga.TabIndex = 22
        '
        'LbIsiTerima
        '
        Me.LbIsiTerima.AutoSize = True
        Me.LbIsiTerima.Location = New System.Drawing.Point(108, 31)
        Me.LbIsiTerima.Name = "LbIsiTerima"
        Me.LbIsiTerima.Size = New System.Drawing.Size(0, 18)
        Me.LbIsiTerima.TabIndex = 21
        '
        'LbTotal
        '
        Me.LbTotal.AutoSize = True
        Me.LbTotal.Location = New System.Drawing.Point(9, 248)
        Me.LbTotal.Name = "LbTotal"
        Me.LbTotal.Size = New System.Drawing.Size(40, 18)
        Me.LbTotal.TabIndex = 19
        Me.LbTotal.Text = "Total"
        '
        'TbJmlh
        '
        Me.TbJmlh.Location = New System.Drawing.Point(103, 215)
        Me.TbJmlh.Name = "TbJmlh"
        Me.TbJmlh.Size = New System.Drawing.Size(183, 26)
        Me.TbJmlh.TabIndex = 18
        '
        'TbKodeBuku
        '
        Me.TbKodeBuku.Location = New System.Drawing.Point(103, 151)
        Me.TbKodeBuku.Name = "TbKodeBuku"
        Me.TbKodeBuku.Size = New System.Drawing.Size(183, 26)
        Me.TbKodeBuku.TabIndex = 15
        '
        'LbJumlah
        '
        Me.LbJumlah.AutoSize = True
        Me.LbJumlah.Location = New System.Drawing.Point(8, 220)
        Me.LbJumlah.Name = "LbJumlah"
        Me.LbJumlah.Size = New System.Drawing.Size(55, 18)
        Me.LbJumlah.TabIndex = 17
        Me.LbJumlah.Text = "Jumlah "
        '
        'LbIdPemasok
        '
        Me.LbIdPemasok.AutoSize = True
        Me.LbIdPemasok.Location = New System.Drawing.Point(7, 123)
        Me.LbIdPemasok.Name = "LbIdPemasok"
        Me.LbIdPemasok.Size = New System.Drawing.Size(77, 18)
        Me.LbIdPemasok.TabIndex = 14
        Me.LbIdPemasok.Text = "Id Pemasok"
        '
        'TbIdPemasok
        '
        Me.TbIdPemasok.Location = New System.Drawing.Point(103, 120)
        Me.TbIdPemasok.Name = "TbIdPemasok"
        Me.TbIdPemasok.Size = New System.Drawing.Size(183, 26)
        Me.TbIdPemasok.TabIndex = 13
        '
        'TbIdUser
        '
        Me.TbIdUser.Location = New System.Drawing.Point(103, 89)
        Me.TbIdUser.Name = "TbIdUser"
        Me.TbIdUser.Size = New System.Drawing.Size(183, 26)
        Me.TbIdUser.TabIndex = 12
        '
        'DTPTglTerima
        '
        Me.DTPTglTerima.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPTglTerima.Location = New System.Drawing.Point(103, 58)
        Me.DTPTglTerima.Name = "DTPTglTerima"
        Me.DTPTglTerima.Size = New System.Drawing.Size(183, 26)
        Me.DTPTglTerima.TabIndex = 11
        '
        'LbHargaBeli
        '
        Me.LbHargaBeli.AutoSize = True
        Me.LbHargaBeli.Location = New System.Drawing.Point(6, 188)
        Me.LbHargaBeli.Name = "LbHargaBeli"
        Me.LbHargaBeli.Size = New System.Drawing.Size(95, 18)
        Me.LbHargaBeli.TabIndex = 5
        Me.LbHargaBeli.Text = "Harga Satuan "
        '
        'LbKodeBuku
        '
        Me.LbKodeBuku.AutoSize = True
        Me.LbKodeBuku.Location = New System.Drawing.Point(6, 155)
        Me.LbKodeBuku.Name = "LbKodeBuku"
        Me.LbKodeBuku.Size = New System.Drawing.Size(75, 18)
        Me.LbKodeBuku.TabIndex = 4
        Me.LbKodeBuku.Text = "Kode Buku "
        '
        'LbIdUserPasok
        '
        Me.LbIdUserPasok.AutoSize = True
        Me.LbIdUserPasok.Location = New System.Drawing.Point(6, 92)
        Me.LbIdUserPasok.Name = "LbIdUserPasok"
        Me.LbIdUserPasok.Size = New System.Drawing.Size(83, 18)
        Me.LbIdUserPasok.TabIndex = 2
        Me.LbIdUserPasok.Text = "Id Pengguna"
        '
        'LbTglTerima
        '
        Me.LbTglTerima.AutoSize = True
        Me.LbTglTerima.Location = New System.Drawing.Point(6, 61)
        Me.LbTglTerima.Name = "LbTglTerima"
        Me.LbTglTerima.Size = New System.Drawing.Size(60, 18)
        Me.LbTglTerima.TabIndex = 1
        Me.LbTglTerima.Text = "Tanggal "
        '
        'LbNoTerima
        '
        Me.LbNoTerima.AutoSize = True
        Me.LbNoTerima.Location = New System.Drawing.Point(4, 31)
        Me.LbNoTerima.Name = "LbNoTerima"
        Me.LbNoTerima.Size = New System.Drawing.Size(100, 18)
        Me.LbNoTerima.TabIndex = 0
        Me.LbNoTerima.Text = "No. Penerimaan"
        '
        'BtnHapusJual
        '
        Me.BtnHapusJual.BackColor = System.Drawing.Color.Orange
        Me.BtnHapusJual.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusJual.Location = New System.Drawing.Point(714, 460)
        Me.BtnHapusJual.Name = "BtnHapusJual"
        Me.BtnHapusJual.Size = New System.Drawing.Size(80, 31)
        Me.BtnHapusJual.TabIndex = 21
        Me.BtnHapusJual.Text = "Hapus"
        Me.BtnHapusJual.UseVisualStyleBackColor = False
        '
        'BtnUbahJual
        '
        Me.BtnUbahJual.BackColor = System.Drawing.Color.Gold
        Me.BtnUbahJual.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUbahJual.Location = New System.Drawing.Point(612, 460)
        Me.BtnUbahJual.Name = "BtnUbahJual"
        Me.BtnUbahJual.Size = New System.Drawing.Size(80, 31)
        Me.BtnUbahJual.TabIndex = 20
        Me.BtnUbahJual.Text = "Ubah "
        Me.BtnUbahJual.UseVisualStyleBackColor = False
        '
        'BtnAmbilJual
        '
        Me.BtnAmbilJual.BackColor = System.Drawing.Color.Orange
        Me.BtnAmbilJual.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAmbilJual.Location = New System.Drawing.Point(761, 423)
        Me.BtnAmbilJual.Name = "BtnAmbilJual"
        Me.BtnAmbilJual.Size = New System.Drawing.Size(80, 31)
        Me.BtnAmbilJual.TabIndex = 19
        Me.BtnAmbilJual.Text = "Ambil Data"
        Me.BtnAmbilJual.UseVisualStyleBackColor = False
        '
        'BtnSimpanPasok
        '
        Me.BtnSimpanPasok.BackColor = System.Drawing.Color.Gold
        Me.BtnSimpanPasok.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpanPasok.Location = New System.Drawing.Point(663, 423)
        Me.BtnSimpanPasok.Name = "BtnSimpanPasok"
        Me.BtnSimpanPasok.Size = New System.Drawing.Size(80, 31)
        Me.BtnSimpanPasok.TabIndex = 18
        Me.BtnSimpanPasok.Text = "Simpan"
        Me.BtnSimpanPasok.UseVisualStyleBackColor = False
        '
        'LbMotivasi
        '
        Me.LbMotivasi.AutoSize = True
        Me.LbMotivasi.BackColor = System.Drawing.Color.Transparent
        Me.LbMotivasi.Font = New System.Drawing.Font("Harrington", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMotivasi.Location = New System.Drawing.Point(326, 547)
        Me.LbMotivasi.Name = "LbMotivasi"
        Me.LbMotivasi.Size = New System.Drawing.Size(274, 22)
        Me.LbMotivasi.TabIndex = 23
        Me.LbMotivasi.Text = "Kehidupan adalah sebuah buku "
        '
        'LbJudul
        '
        Me.LbJudul.AutoSize = True
        Me.LbJudul.BackColor = System.Drawing.Color.Transparent
        Me.LbJudul.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbJudul.Location = New System.Drawing.Point(261, 502)
        Me.LbJudul.Name = "LbJudul"
        Me.LbJudul.Size = New System.Drawing.Size(383, 40)
        Me.LbJudul.TabIndex = 22
        Me.LbJudul.Text = "TOKO BUKU PRAMIDITA"
        '
        'Data_suplyTableAdapter
        '
        Me.Data_suplyTableAdapter.ClearBeforeFill = True
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.Orange
        Me.BtnTambah.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Location = New System.Drawing.Point(565, 423)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(80, 31)
        Me.BtnTambah.TabIndex = 24
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'FormPasok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(875, 592)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.LbMotivasi)
        Me.Controls.Add(Me.LbJudul)
        Me.Controls.Add(Me.BtnHapusJual)
        Me.Controls.Add(Me.BtnUbahJual)
        Me.Controls.Add(Me.BtnAmbilJual)
        Me.Controls.Add(Me.BtnSimpanPasok)
        Me.Controls.Add(Me.GrupInputPasok)
        Me.Controls.Add(Me.DGVPasok)
        Me.Controls.Add(Me.LbDataPasok)
        Me.Controls.Add(Me.Tab)
        Me.Name = "FormPasok"
        Me.Text = "Transaksi Pasok"
        Me.Tab.ResumeLayout(False)
        Me.TabMaster.ResumeLayout(False)
        Me.TabTransaksi.ResumeLayout(False)
        Me.TabLaporan.ResumeLayout(False)
        Me.TabPengaturan.ResumeLayout(False)
        CType(Me.DGVPasok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatasuplyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbUASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupInputPasok.ResumeLayout(False)
        Me.GrupInputPasok.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tab As System.Windows.Forms.TabControl
    Friend WithEvents TabMaster As System.Windows.Forms.TabPage
    Friend WithEvents BtnPenerbit As System.Windows.Forms.Button
    Friend WithEvents BtnSuplier As System.Windows.Forms.Button
    Friend WithEvents BtnBuku As System.Windows.Forms.Button
    Friend WithEvents BtnMember As System.Windows.Forms.Button
    Friend WithEvents BtnUser As System.Windows.Forms.Button
    Friend WithEvents TabTransaksi As System.Windows.Forms.TabPage
    Friend WithEvents BtnRetur As System.Windows.Forms.Button
    Friend WithEvents BtnSupply As System.Windows.Forms.Button
    Friend WithEvents BtnJual As System.Windows.Forms.Button
    Friend WithEvents TabLaporan As System.Windows.Forms.TabPage
    Friend WithEvents BtnInvoiceRetur As System.Windows.Forms.Button
    Friend WithEvents BtnInvoiceSupply As System.Windows.Forms.Button
    Friend WithEvents BtnInvoiceJual As System.Windows.Forms.Button
    Friend WithEvents TabPengaturan As System.Windows.Forms.TabPage
    Friend WithEvents BtnInfo As System.Windows.Forms.Button
    Friend WithEvents LbDataPasok As System.Windows.Forms.Label
    Friend WithEvents DGVPasok As System.Windows.Forms.DataGridView
    Friend WithEvents GrupInputPasok As System.Windows.Forms.GroupBox
    Friend WithEvents LbTotal As System.Windows.Forms.Label
    Friend WithEvents TbJmlh As System.Windows.Forms.TextBox
    Friend WithEvents TbKodeBuku As System.Windows.Forms.TextBox
    Friend WithEvents LbJumlah As System.Windows.Forms.Label
    Friend WithEvents LbIdPemasok As System.Windows.Forms.Label
    Friend WithEvents TbIdPemasok As System.Windows.Forms.TextBox
    Friend WithEvents TbIdUser As System.Windows.Forms.TextBox
    Friend WithEvents DTPTglTerima As System.Windows.Forms.DateTimePicker
    Friend WithEvents LbHargaBeli As System.Windows.Forms.Label
    Friend WithEvents LbKodeBuku As System.Windows.Forms.Label
    Friend WithEvents LbIdUserPasok As System.Windows.Forms.Label
    Friend WithEvents LbTglTerima As System.Windows.Forms.Label
    Friend WithEvents LbNoTerima As System.Windows.Forms.Label
    Friend WithEvents BtnHapusJual As System.Windows.Forms.Button
    Friend WithEvents BtnUbahJual As System.Windows.Forms.Button
    Friend WithEvents BtnAmbilJual As System.Windows.Forms.Button
    Friend WithEvents BtnSimpanPasok As System.Windows.Forms.Button
    Friend WithEvents LbMotivasi As System.Windows.Forms.Label
    Friend WithEvents LbJudul As System.Windows.Forms.Label
    Friend WithEvents DbUASDataSet As WindowsApplication1.DbUASDataSet
    Friend WithEvents DatasuplyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Data_suplyTableAdapter As WindowsApplication1.DbUASDataSetTableAdapters.data_suplyTableAdapter
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents no_penerimaan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tanggal_terima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_user As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_suplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kode_buku As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga_beli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah_buku As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_biaya As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LbIsiTerima As System.Windows.Forms.Label
    Friend WithEvents LbIsiHarga As System.Windows.Forms.Label
    Friend WithEvents LbIsiTotal As System.Windows.Forms.Label
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
End Class
