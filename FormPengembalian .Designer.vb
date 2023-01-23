<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPengembalian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPengembalian))
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
        Me.LbDataKembali = New System.Windows.Forms.Label()
        Me.DGVPengembalian = New System.Windows.Forms.DataGridView()
        Me.no_retur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal_jual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal_retur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_member = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alasan_retur = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatareturBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbUASDataSet = New WindowsApplication1.DbUASDataSet()
        Me.GrupInputKembali = New System.Windows.Forms.GroupBox()
        Me.LbIsiNomor = New System.Windows.Forms.Label()
        Me.DTPKembali = New System.Windows.Forms.DateTimePicker()
        Me.LbTglKembali = New System.Windows.Forms.Label()
        Me.LbAlasan = New System.Windows.Forms.Label()
        Me.TbJmlh = New System.Windows.Forms.TextBox()
        Me.TbAlasan = New System.Windows.Forms.TextBox()
        Me.TbKodeBuku = New System.Windows.Forms.TextBox()
        Me.LbJumlah = New System.Windows.Forms.Label()
        Me.LbIdUser = New System.Windows.Forms.Label()
        Me.TbIdUser = New System.Windows.Forms.TextBox()
        Me.TbIdPelanggan = New System.Windows.Forms.TextBox()
        Me.DTPJual = New System.Windows.Forms.DateTimePicker()
        Me.LbKodeBuku = New System.Windows.Forms.Label()
        Me.LbIdPelanggan = New System.Windows.Forms.Label()
        Me.LbTglJual = New System.Windows.Forms.Label()
        Me.LbNoTerima = New System.Windows.Forms.Label()
        Me.BtnHapusJual = New System.Windows.Forms.Button()
        Me.BtnUbahJual = New System.Windows.Forms.Button()
        Me.BtnAmbilJual = New System.Windows.Forms.Button()
        Me.BtnSimpanKembali = New System.Windows.Forms.Button()
        Me.Data_returTableAdapter = New WindowsApplication1.DbUASDataSetTableAdapters.data_returTableAdapter()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.LbMotivasi = New System.Windows.Forms.Label()
        Me.LbJudul = New System.Windows.Forms.Label()
        Me.Tab.SuspendLayout()
        Me.TabMaster.SuspendLayout()
        Me.TabTransaksi.SuspendLayout()
        Me.TabLaporan.SuspendLayout()
        Me.TabPengaturan.SuspendLayout()
        CType(Me.DGVPengembalian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatareturBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbUASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupInputKembali.SuspendLayout()
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
        Me.Tab.TabIndex = 4
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
        Me.BtnInfo.Text = "Info Operator"
        Me.BtnInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnInfo.UseVisualStyleBackColor = True
        '
        'LbDataKembali
        '
        Me.LbDataKembali.AutoSize = True
        Me.LbDataKembali.BackColor = System.Drawing.Color.Transparent
        Me.LbDataKembali.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDataKembali.Location = New System.Drawing.Point(12, 122)
        Me.LbDataKembali.Name = "LbDataKembali"
        Me.LbDataKembali.Size = New System.Drawing.Size(144, 21)
        Me.LbDataKembali.TabIndex = 16
        Me.LbDataKembali.Text = "Data Pengembalian"
        '
        'DGVPengembalian
        '
        Me.DGVPengembalian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPengembalian.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no_retur, Me.tanggal_jual, Me.tanggal_retur, Me.id_member, Me.id_user, Me.kode_buku, Me.jumlah_buku, Me.alasan_retur})
        Me.DGVPengembalian.Location = New System.Drawing.Point(16, 146)
        Me.DGVPengembalian.Name = "DGVPengembalian"
        Me.DGVPengembalian.Size = New System.Drawing.Size(475, 304)
        Me.DGVPengembalian.TabIndex = 17
        '
        'no_retur
        '
        Me.no_retur.HeaderText = "no_retur"
        Me.no_retur.Name = "no_retur"
        '
        'tanggal_jual
        '
        Me.tanggal_jual.HeaderText = "tanggal_jual"
        Me.tanggal_jual.Name = "tanggal_jual"
        '
        'tanggal_retur
        '
        Me.tanggal_retur.HeaderText = "tanggal_retur"
        Me.tanggal_retur.Name = "tanggal_retur"
        '
        'id_member
        '
        Me.id_member.HeaderText = "id_member"
        Me.id_member.Name = "id_member"
        '
        'id_user
        '
        Me.id_user.HeaderText = "id_user"
        Me.id_user.Name = "id_user"
        '
        'kode_buku
        '
        Me.kode_buku.HeaderText = "kode_buku"
        Me.kode_buku.Name = "kode_buku"
        '
        'jumlah_buku
        '
        Me.jumlah_buku.HeaderText = "jumlah_buku"
        Me.jumlah_buku.Name = "jumlah_buku"
        '
        'alasan_retur
        '
        Me.alasan_retur.HeaderText = "alasan_retur"
        Me.alasan_retur.Name = "alasan_retur"
        '
        'DatareturBindingSource
        '
        Me.DatareturBindingSource.DataMember = "data_retur"
        Me.DatareturBindingSource.DataSource = Me.DbUASDataSet
        '
        'DbUASDataSet
        '
        Me.DbUASDataSet.DataSetName = "DbUASDataSet"
        Me.DbUASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GrupInputKembali
        '
        Me.GrupInputKembali.BackColor = System.Drawing.Color.Transparent
        Me.GrupInputKembali.Controls.Add(Me.LbIsiNomor)
        Me.GrupInputKembali.Controls.Add(Me.DTPKembali)
        Me.GrupInputKembali.Controls.Add(Me.LbTglKembali)
        Me.GrupInputKembali.Controls.Add(Me.LbAlasan)
        Me.GrupInputKembali.Controls.Add(Me.TbJmlh)
        Me.GrupInputKembali.Controls.Add(Me.TbAlasan)
        Me.GrupInputKembali.Controls.Add(Me.TbKodeBuku)
        Me.GrupInputKembali.Controls.Add(Me.LbJumlah)
        Me.GrupInputKembali.Controls.Add(Me.LbIdUser)
        Me.GrupInputKembali.Controls.Add(Me.TbIdUser)
        Me.GrupInputKembali.Controls.Add(Me.TbIdPelanggan)
        Me.GrupInputKembali.Controls.Add(Me.DTPJual)
        Me.GrupInputKembali.Controls.Add(Me.LbKodeBuku)
        Me.GrupInputKembali.Controls.Add(Me.LbIdPelanggan)
        Me.GrupInputKembali.Controls.Add(Me.LbTglJual)
        Me.GrupInputKembali.Controls.Add(Me.LbNoTerima)
        Me.GrupInputKembali.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupInputKembali.Location = New System.Drawing.Point(527, 135)
        Me.GrupInputKembali.Name = "GrupInputKembali"
        Me.GrupInputKembali.Size = New System.Drawing.Size(342, 315)
        Me.GrupInputKembali.TabIndex = 18
        Me.GrupInputKembali.TabStop = False
        Me.GrupInputKembali.Text = "Tambah Pengembalian"
        '
        'LbIsiNomor
        '
        Me.LbIsiNomor.AutoSize = True
        Me.LbIsiNomor.Location = New System.Drawing.Point(145, 31)
        Me.LbIsiNomor.Name = "LbIsiNomor"
        Me.LbIsiNomor.Size = New System.Drawing.Size(0, 18)
        Me.LbIsiNomor.TabIndex = 23
        '
        'DTPKembali
        '
        Me.DTPKembali.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPKembali.Location = New System.Drawing.Point(148, 88)
        Me.DTPKembali.Name = "DTPKembali"
        Me.DTPKembali.Size = New System.Drawing.Size(183, 26)
        Me.DTPKembali.TabIndex = 22
        '
        'LbTglKembali
        '
        Me.LbTglKembali.AutoSize = True
        Me.LbTglKembali.Location = New System.Drawing.Point(4, 92)
        Me.LbTglKembali.Name = "LbTglKembali"
        Me.LbTglKembali.Size = New System.Drawing.Size(141, 18)
        Me.LbTglKembali.TabIndex = 21
        Me.LbTglKembali.Text = "Tanggal Pengembalian" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LbAlasan
        '
        Me.LbAlasan.AutoSize = True
        Me.LbAlasan.Location = New System.Drawing.Point(9, 255)
        Me.LbAlasan.Name = "LbAlasan"
        Me.LbAlasan.Size = New System.Drawing.Size(133, 18)
        Me.LbAlasan.TabIndex = 19
        Me.LbAlasan.Text = "Alasan Pengembalian"
        '
        'TbJmlh
        '
        Me.TbJmlh.Location = New System.Drawing.Point(148, 215)
        Me.TbJmlh.Name = "TbJmlh"
        Me.TbJmlh.Size = New System.Drawing.Size(183, 26)
        Me.TbJmlh.TabIndex = 18
        '
        'TbAlasan
        '
        Me.TbAlasan.Location = New System.Drawing.Point(148, 248)
        Me.TbAlasan.Multiline = True
        Me.TbAlasan.Name = "TbAlasan"
        Me.TbAlasan.Size = New System.Drawing.Size(183, 51)
        Me.TbAlasan.TabIndex = 20
        '
        'TbKodeBuku
        '
        Me.TbKodeBuku.Location = New System.Drawing.Point(148, 182)
        Me.TbKodeBuku.Name = "TbKodeBuku"
        Me.TbKodeBuku.Size = New System.Drawing.Size(183, 26)
        Me.TbKodeBuku.TabIndex = 15
        '
        'LbJumlah
        '
        Me.LbJumlah.AutoSize = True
        Me.LbJumlah.Location = New System.Drawing.Point(9, 219)
        Me.LbJumlah.Name = "LbJumlah"
        Me.LbJumlah.Size = New System.Drawing.Size(55, 18)
        Me.LbJumlah.TabIndex = 17
        Me.LbJumlah.Text = "Jumlah "
        '
        'LbIdUser
        '
        Me.LbIdUser.AutoSize = True
        Me.LbIdUser.Location = New System.Drawing.Point(7, 153)
        Me.LbIdUser.Name = "LbIdUser"
        Me.LbIdUser.Size = New System.Drawing.Size(83, 18)
        Me.LbIdUser.TabIndex = 14
        Me.LbIdUser.Text = "Id Pengguna"
        '
        'TbIdUser
        '
        Me.TbIdUser.Location = New System.Drawing.Point(148, 150)
        Me.TbIdUser.Name = "TbIdUser"
        Me.TbIdUser.Size = New System.Drawing.Size(183, 26)
        Me.TbIdUser.TabIndex = 13
        '
        'TbIdPelanggan
        '
        Me.TbIdPelanggan.Location = New System.Drawing.Point(148, 119)
        Me.TbIdPelanggan.Name = "TbIdPelanggan"
        Me.TbIdPelanggan.Size = New System.Drawing.Size(183, 26)
        Me.TbIdPelanggan.TabIndex = 12
        '
        'DTPJual
        '
        Me.DTPJual.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPJual.Location = New System.Drawing.Point(148, 58)
        Me.DTPJual.Name = "DTPJual"
        Me.DTPJual.Size = New System.Drawing.Size(183, 26)
        Me.DTPJual.TabIndex = 11
        '
        'LbKodeBuku
        '
        Me.LbKodeBuku.AutoSize = True
        Me.LbKodeBuku.Location = New System.Drawing.Point(8, 187)
        Me.LbKodeBuku.Name = "LbKodeBuku"
        Me.LbKodeBuku.Size = New System.Drawing.Size(75, 18)
        Me.LbKodeBuku.TabIndex = 4
        Me.LbKodeBuku.Text = "Kode Buku "
        '
        'LbIdPelanggan
        '
        Me.LbIdPelanggan.AutoSize = True
        Me.LbIdPelanggan.Location = New System.Drawing.Point(6, 121)
        Me.LbIdPelanggan.Name = "LbIdPelanggan"
        Me.LbIdPelanggan.Size = New System.Drawing.Size(87, 18)
        Me.LbIdPelanggan.TabIndex = 2
        Me.LbIdPelanggan.Text = "Id Pelanggan"
        '
        'LbTglJual
        '
        Me.LbTglJual.AutoSize = True
        Me.LbTglJual.Location = New System.Drawing.Point(3, 64)
        Me.LbTglJual.Name = "LbTglJual"
        Me.LbTglJual.Size = New System.Drawing.Size(118, 18)
        Me.LbTglJual.TabIndex = 1
        Me.LbTglJual.Text = "Tanggal Penjualan"
        '
        'LbNoTerima
        '
        Me.LbNoTerima.AutoSize = True
        Me.LbNoTerima.Location = New System.Drawing.Point(4, 31)
        Me.LbNoTerima.Name = "LbNoTerima"
        Me.LbNoTerima.Size = New System.Drawing.Size(113, 18)
        Me.LbNoTerima.TabIndex = 0
        Me.LbNoTerima.Text = "No. Pengembalian"
        '
        'BtnHapusJual
        '
        Me.BtnHapusJual.BackColor = System.Drawing.Color.Orange
        Me.BtnHapusJual.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusJual.Location = New System.Drawing.Point(717, 488)
        Me.BtnHapusJual.Name = "BtnHapusJual"
        Me.BtnHapusJual.Size = New System.Drawing.Size(80, 31)
        Me.BtnHapusJual.TabIndex = 25
        Me.BtnHapusJual.Text = "Hapus"
        Me.BtnHapusJual.UseVisualStyleBackColor = False
        '
        'BtnUbahJual
        '
        Me.BtnUbahJual.BackColor = System.Drawing.Color.Gold
        Me.BtnUbahJual.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUbahJual.Location = New System.Drawing.Point(592, 488)
        Me.BtnUbahJual.Name = "BtnUbahJual"
        Me.BtnUbahJual.Size = New System.Drawing.Size(80, 31)
        Me.BtnUbahJual.TabIndex = 24
        Me.BtnUbahJual.Text = "Ubah "
        Me.BtnUbahJual.UseVisualStyleBackColor = False
        '
        'BtnAmbilJual
        '
        Me.BtnAmbilJual.BackColor = System.Drawing.Color.Orange
        Me.BtnAmbilJual.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAmbilJual.Location = New System.Drawing.Point(777, 453)
        Me.BtnAmbilJual.Name = "BtnAmbilJual"
        Me.BtnAmbilJual.Size = New System.Drawing.Size(80, 31)
        Me.BtnAmbilJual.TabIndex = 23
        Me.BtnAmbilJual.Text = "Ambil Data"
        Me.BtnAmbilJual.UseVisualStyleBackColor = False
        '
        'BtnSimpanKembali
        '
        Me.BtnSimpanKembali.BackColor = System.Drawing.Color.Gold
        Me.BtnSimpanKembali.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpanKembali.Location = New System.Drawing.Point(655, 453)
        Me.BtnSimpanKembali.Name = "BtnSimpanKembali"
        Me.BtnSimpanKembali.Size = New System.Drawing.Size(80, 31)
        Me.BtnSimpanKembali.TabIndex = 22
        Me.BtnSimpanKembali.Text = "Simpan"
        Me.BtnSimpanKembali.UseVisualStyleBackColor = False
        '
        'Data_returTableAdapter
        '
        Me.Data_returTableAdapter.ClearBeforeFill = True
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.Orange
        Me.BtnTambah.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Location = New System.Drawing.Point(536, 453)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(80, 31)
        Me.BtnTambah.TabIndex = 26
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'LbMotivasi
        '
        Me.LbMotivasi.AutoSize = True
        Me.LbMotivasi.BackColor = System.Drawing.Color.Transparent
        Me.LbMotivasi.Font = New System.Drawing.Font("Harrington", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMotivasi.Location = New System.Drawing.Point(326, 587)
        Me.LbMotivasi.Name = "LbMotivasi"
        Me.LbMotivasi.Size = New System.Drawing.Size(274, 22)
        Me.LbMotivasi.TabIndex = 28
        Me.LbMotivasi.Text = "Kehidupan adalah sebuah buku "
        '
        'LbJudul
        '
        Me.LbJudul.AutoSize = True
        Me.LbJudul.BackColor = System.Drawing.Color.Transparent
        Me.LbJudul.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbJudul.Location = New System.Drawing.Point(261, 542)
        Me.LbJudul.Name = "LbJudul"
        Me.LbJudul.Size = New System.Drawing.Size(383, 40)
        Me.LbJudul.TabIndex = 27
        Me.LbJudul.Text = "TOKO BUKU PRAMIDITA"
        '
        'FormPengembalian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(875, 632)
        Me.Controls.Add(Me.LbMotivasi)
        Me.Controls.Add(Me.LbJudul)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.BtnHapusJual)
        Me.Controls.Add(Me.BtnUbahJual)
        Me.Controls.Add(Me.BtnAmbilJual)
        Me.Controls.Add(Me.BtnSimpanKembali)
        Me.Controls.Add(Me.GrupInputKembali)
        Me.Controls.Add(Me.DGVPengembalian)
        Me.Controls.Add(Me.LbDataKembali)
        Me.Controls.Add(Me.Tab)
        Me.Name = "FormPengembalian"
        Me.Text = "Transaksi Pengembalian"
        Me.Tab.ResumeLayout(False)
        Me.TabMaster.ResumeLayout(False)
        Me.TabTransaksi.ResumeLayout(False)
        Me.TabLaporan.ResumeLayout(False)
        Me.TabPengaturan.ResumeLayout(False)
        CType(Me.DGVPengembalian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatareturBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbUASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupInputKembali.ResumeLayout(False)
        Me.GrupInputKembali.PerformLayout()
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
    Friend WithEvents LbDataKembali As System.Windows.Forms.Label
    Friend WithEvents DGVPengembalian As System.Windows.Forms.DataGridView
    Friend WithEvents GrupInputKembali As System.Windows.Forms.GroupBox
    Friend WithEvents LbAlasan As System.Windows.Forms.Label
    Friend WithEvents TbJmlh As System.Windows.Forms.TextBox
    Friend WithEvents TbAlasan As System.Windows.Forms.TextBox
    Friend WithEvents TbKodeBuku As System.Windows.Forms.TextBox
    Friend WithEvents LbJumlah As System.Windows.Forms.Label
    Friend WithEvents LbIdUser As System.Windows.Forms.Label
    Friend WithEvents TbIdUser As System.Windows.Forms.TextBox
    Friend WithEvents TbIdPelanggan As System.Windows.Forms.TextBox
    Friend WithEvents DTPJual As System.Windows.Forms.DateTimePicker
    Friend WithEvents LbKodeBuku As System.Windows.Forms.Label
    Friend WithEvents LbIdPelanggan As System.Windows.Forms.Label
    Friend WithEvents LbTglJual As System.Windows.Forms.Label
    Friend WithEvents LbNoTerima As System.Windows.Forms.Label
    Friend WithEvents BtnHapusJual As System.Windows.Forms.Button
    Friend WithEvents BtnUbahJual As System.Windows.Forms.Button
    Friend WithEvents BtnAmbilJual As System.Windows.Forms.Button
    Friend WithEvents BtnSimpanKembali As System.Windows.Forms.Button
    Friend WithEvents DTPKembali As System.Windows.Forms.DateTimePicker
    Friend WithEvents LbTglKembali As System.Windows.Forms.Label
    Friend WithEvents DbUASDataSet As WindowsApplication1.DbUASDataSet
    Friend WithEvents DatareturBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Data_returTableAdapter As WindowsApplication1.DbUASDataSetTableAdapters.data_returTableAdapter
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents no_retur As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tanggal_jual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tanggal_retur As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_member As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_user As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kode_buku As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah_buku As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents alasan_retur As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LbMotivasi As System.Windows.Forms.Label
    Friend WithEvents LbJudul As System.Windows.Forms.Label
    Friend WithEvents LbIsiNomor As System.Windows.Forms.Label
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
End Class
