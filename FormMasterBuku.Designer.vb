<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuku
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBuku))
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
        Me.GrupTambahBuku = New System.Windows.Forms.GroupBox()
        Me.LbIsiJual = New System.Windows.Forms.Label()
        Me.LbIsiKode = New System.Windows.Forms.Label()
        Me.TbDiskon = New System.Windows.Forms.TextBox()
        Me.LbDiskon = New System.Windows.Forms.Label()
        Me.LbHargaJual = New System.Windows.Forms.Label()
        Me.TbHargaBeli = New System.Windows.Forms.TextBox()
        Me.LbHargaBeli = New System.Windows.Forms.Label()
        Me.TbJmlhBuku = New System.Windows.Forms.TextBox()
        Me.LbJumlah = New System.Windows.Forms.Label()
        Me.TbThnTerbit = New System.Windows.Forms.TextBox()
        Me.LbThnTerbit = New System.Windows.Forms.Label()
        Me.TbKodePenerbit = New System.Windows.Forms.TextBox()
        Me.TbPenulis = New System.Windows.Forms.TextBox()
        Me.TbKategori = New System.Windows.Forms.TextBox()
        Me.TbJudul = New System.Windows.Forms.TextBox()
        Me.LbKategori = New System.Windows.Forms.Label()
        Me.LbKodePenerbit = New System.Windows.Forms.Label()
        Me.LbPenulis = New System.Windows.Forms.Label()
        Me.LbJudulBuku = New System.Windows.Forms.Label()
        Me.LbKodeBuku = New System.Windows.Forms.Label()
        Me.DGVBuku = New System.Windows.Forms.DataGridView()
        Me.KodebukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JudulbukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamapenulisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodepenerbitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TahunterbitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KategoriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahstokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargabeliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargajualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatabukuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbUASDataSet = New WindowsApplication1.DbUASDataSet()
        Me.BtnAmbil = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnSimpanBuku = New System.Windows.Forms.Button()
        Me.LbMotivasi = New System.Windows.Forms.Label()
        Me.LbJudul = New System.Windows.Forms.Label()
        Me.Data_bukuTableAdapter = New WindowsApplication1.DbUASDataSetTableAdapters.data_bukuTableAdapter()
        Me.LbDataBuku = New System.Windows.Forms.Label()
        Me.Tab.SuspendLayout()
        Me.TabMaster.SuspendLayout()
        Me.TabTransaksi.SuspendLayout()
        Me.TabLaporan.SuspendLayout()
        Me.TabPengaturan.SuspendLayout()
        Me.GrupTambahBuku.SuspendLayout()
        CType(Me.DGVBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbUASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tab
        '
        Me.Tab.Controls.Add(Me.TabMaster)
        Me.Tab.Controls.Add(Me.TabTransaksi)
        Me.Tab.Controls.Add(Me.TabLaporan)
        Me.Tab.Controls.Add(Me.TabPengaturan)
        Me.Tab.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab.Location = New System.Drawing.Point(-3, -1)
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
        Me.BtnPenerbit.Location = New System.Drawing.Point(339, 3)
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
        Me.BtnSuplier.Location = New System.Drawing.Point(246, 3)
        Me.BtnSuplier.Name = "BtnSuplier"
        Me.BtnSuplier.Size = New System.Drawing.Size(93, 78)
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
        Me.BtnBuku.Location = New System.Drawing.Point(161, 3)
        Me.BtnBuku.Name = "BtnBuku"
        Me.BtnBuku.Size = New System.Drawing.Size(85, 78)
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
        Me.BtnMember.Size = New System.Drawing.Size(81, 78)
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
        Me.BtnInvoiceRetur.Size = New System.Drawing.Size(130, 84)
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
        'GrupTambahBuku
        '
        Me.GrupTambahBuku.BackColor = System.Drawing.Color.Transparent
        Me.GrupTambahBuku.Controls.Add(Me.LbIsiJual)
        Me.GrupTambahBuku.Controls.Add(Me.LbIsiKode)
        Me.GrupTambahBuku.Controls.Add(Me.TbDiskon)
        Me.GrupTambahBuku.Controls.Add(Me.LbDiskon)
        Me.GrupTambahBuku.Controls.Add(Me.LbHargaJual)
        Me.GrupTambahBuku.Controls.Add(Me.TbHargaBeli)
        Me.GrupTambahBuku.Controls.Add(Me.LbHargaBeli)
        Me.GrupTambahBuku.Controls.Add(Me.TbJmlhBuku)
        Me.GrupTambahBuku.Controls.Add(Me.LbJumlah)
        Me.GrupTambahBuku.Controls.Add(Me.TbThnTerbit)
        Me.GrupTambahBuku.Controls.Add(Me.LbThnTerbit)
        Me.GrupTambahBuku.Controls.Add(Me.TbKodePenerbit)
        Me.GrupTambahBuku.Controls.Add(Me.TbPenulis)
        Me.GrupTambahBuku.Controls.Add(Me.TbKategori)
        Me.GrupTambahBuku.Controls.Add(Me.TbJudul)
        Me.GrupTambahBuku.Controls.Add(Me.LbKategori)
        Me.GrupTambahBuku.Controls.Add(Me.LbKodePenerbit)
        Me.GrupTambahBuku.Controls.Add(Me.LbPenulis)
        Me.GrupTambahBuku.Controls.Add(Me.LbJudulBuku)
        Me.GrupTambahBuku.Controls.Add(Me.LbKodeBuku)
        Me.GrupTambahBuku.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupTambahBuku.Location = New System.Drawing.Point(550, 145)
        Me.GrupTambahBuku.Name = "GrupTambahBuku"
        Me.GrupTambahBuku.Size = New System.Drawing.Size(293, 342)
        Me.GrupTambahBuku.TabIndex = 5
        Me.GrupTambahBuku.TabStop = False
        Me.GrupTambahBuku.Text = "Tambah Data Buku"
        '
        'LbIsiJual
        '
        Me.LbIsiJual.AutoSize = True
        Me.LbIsiJual.Location = New System.Drawing.Point(100, 280)
        Me.LbIsiJual.Name = "LbIsiJual"
        Me.LbIsiJual.Size = New System.Drawing.Size(0, 18)
        Me.LbIsiJual.TabIndex = 24
        '
        'LbIsiKode
        '
        Me.LbIsiKode.AutoSize = True
        Me.LbIsiKode.Location = New System.Drawing.Point(100, 32)
        Me.LbIsiKode.Name = "LbIsiKode"
        Me.LbIsiKode.Size = New System.Drawing.Size(0, 18)
        Me.LbIsiKode.TabIndex = 23
        '
        'TbDiskon
        '
        Me.TbDiskon.Location = New System.Drawing.Point(103, 308)
        Me.TbDiskon.Name = "TbDiskon"
        Me.TbDiskon.Size = New System.Drawing.Size(183, 26)
        Me.TbDiskon.TabIndex = 22
        '
        'LbDiskon
        '
        Me.LbDiskon.AutoSize = True
        Me.LbDiskon.Location = New System.Drawing.Point(6, 311)
        Me.LbDiskon.Name = "LbDiskon"
        Me.LbDiskon.Size = New System.Drawing.Size(48, 18)
        Me.LbDiskon.TabIndex = 21
        Me.LbDiskon.Text = "Diskon"
        '
        'LbHargaJual
        '
        Me.LbHargaJual.AutoSize = True
        Me.LbHargaJual.Location = New System.Drawing.Point(6, 280)
        Me.LbHargaJual.Name = "LbHargaJual"
        Me.LbHargaJual.Size = New System.Drawing.Size(76, 18)
        Me.LbHargaJual.TabIndex = 19
        Me.LbHargaJual.Text = "Harga Jual"
        '
        'TbHargaBeli
        '
        Me.TbHargaBeli.Location = New System.Drawing.Point(103, 245)
        Me.TbHargaBeli.Name = "TbHargaBeli"
        Me.TbHargaBeli.Size = New System.Drawing.Size(183, 26)
        Me.TbHargaBeli.TabIndex = 18
        '
        'LbHargaBeli
        '
        Me.LbHargaBeli.AutoSize = True
        Me.LbHargaBeli.Location = New System.Drawing.Point(6, 248)
        Me.LbHargaBeli.Name = "LbHargaBeli"
        Me.LbHargaBeli.Size = New System.Drawing.Size(76, 18)
        Me.LbHargaBeli.TabIndex = 17
        Me.LbHargaBeli.Text = "Harga Beli "
        '
        'TbJmlhBuku
        '
        Me.TbJmlhBuku.Location = New System.Drawing.Point(103, 214)
        Me.TbJmlhBuku.Name = "TbJmlhBuku"
        Me.TbJmlhBuku.Size = New System.Drawing.Size(183, 26)
        Me.TbJmlhBuku.TabIndex = 16
        '
        'LbJumlah
        '
        Me.LbJumlah.AutoSize = True
        Me.LbJumlah.Location = New System.Drawing.Point(6, 216)
        Me.LbJumlah.Name = "LbJumlah"
        Me.LbJumlah.Size = New System.Drawing.Size(55, 18)
        Me.LbJumlah.TabIndex = 15
        Me.LbJumlah.Text = "Jumlah "
        '
        'TbThnTerbit
        '
        Me.TbThnTerbit.Location = New System.Drawing.Point(103, 152)
        Me.TbThnTerbit.Name = "TbThnTerbit"
        Me.TbThnTerbit.Size = New System.Drawing.Size(183, 26)
        Me.TbThnTerbit.TabIndex = 14
        '
        'LbThnTerbit
        '
        Me.LbThnTerbit.AutoSize = True
        Me.LbThnTerbit.Location = New System.Drawing.Point(6, 155)
        Me.LbThnTerbit.Name = "LbThnTerbit"
        Me.LbThnTerbit.Size = New System.Drawing.Size(88, 18)
        Me.LbThnTerbit.TabIndex = 13
        Me.LbThnTerbit.Text = "Tahun Terbit"
        '
        'TbKodePenerbit
        '
        Me.TbKodePenerbit.Location = New System.Drawing.Point(103, 121)
        Me.TbKodePenerbit.Name = "TbKodePenerbit"
        Me.TbKodePenerbit.Size = New System.Drawing.Size(183, 26)
        Me.TbKodePenerbit.TabIndex = 12
        '
        'TbPenulis
        '
        Me.TbPenulis.Location = New System.Drawing.Point(103, 91)
        Me.TbPenulis.Name = "TbPenulis"
        Me.TbPenulis.Size = New System.Drawing.Size(183, 26)
        Me.TbPenulis.TabIndex = 11
        '
        'TbKategori
        '
        Me.TbKategori.Location = New System.Drawing.Point(103, 183)
        Me.TbKategori.Name = "TbKategori"
        Me.TbKategori.Size = New System.Drawing.Size(183, 26)
        Me.TbKategori.TabIndex = 10
        '
        'TbJudul
        '
        Me.TbJudul.Location = New System.Drawing.Point(103, 60)
        Me.TbJudul.Name = "TbJudul"
        Me.TbJudul.Size = New System.Drawing.Size(183, 26)
        Me.TbJudul.TabIndex = 7
        '
        'LbKategori
        '
        Me.LbKategori.AutoSize = True
        Me.LbKategori.Location = New System.Drawing.Point(6, 186)
        Me.LbKategori.Name = "LbKategori"
        Me.LbKategori.Size = New System.Drawing.Size(63, 18)
        Me.LbKategori.TabIndex = 5
        Me.LbKategori.Text = "Kategori "
        '
        'LbKodePenerbit
        '
        Me.LbKodePenerbit.AutoSize = True
        Me.LbKodePenerbit.Location = New System.Drawing.Point(6, 125)
        Me.LbKodePenerbit.Name = "LbKodePenerbit"
        Me.LbKodePenerbit.Size = New System.Drawing.Size(93, 18)
        Me.LbKodePenerbit.TabIndex = 4
        Me.LbKodePenerbit.Text = "Kode Penerbit"
        '
        'LbPenulis
        '
        Me.LbPenulis.AutoSize = True
        Me.LbPenulis.Location = New System.Drawing.Point(6, 94)
        Me.LbPenulis.Name = "LbPenulis"
        Me.LbPenulis.Size = New System.Drawing.Size(87, 18)
        Me.LbPenulis.TabIndex = 3
        Me.LbPenulis.Text = "Nama Penulis"
        '
        'LbJudulBuku
        '
        Me.LbJudulBuku.AutoSize = True
        Me.LbJudulBuku.Location = New System.Drawing.Point(6, 63)
        Me.LbJudulBuku.Name = "LbJudulBuku"
        Me.LbJudulBuku.Size = New System.Drawing.Size(80, 18)
        Me.LbJudulBuku.TabIndex = 1
        Me.LbJudulBuku.Text = "Judul Buku "
        '
        'LbKodeBuku
        '
        Me.LbKodeBuku.AutoSize = True
        Me.LbKodeBuku.Location = New System.Drawing.Point(6, 32)
        Me.LbKodeBuku.Name = "LbKodeBuku"
        Me.LbKodeBuku.Size = New System.Drawing.Size(71, 18)
        Me.LbKodeBuku.TabIndex = 0
        Me.LbKodeBuku.Text = "Kode Buku"
        '
        'DGVBuku
        '
        Me.DGVBuku.AutoGenerateColumns = False
        Me.DGVBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBuku.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodebukuDataGridViewTextBoxColumn, Me.JudulbukuDataGridViewTextBoxColumn, Me.NamapenulisDataGridViewTextBoxColumn, Me.KodepenerbitDataGridViewTextBoxColumn, Me.TahunterbitDataGridViewTextBoxColumn, Me.KategoriDataGridViewTextBoxColumn, Me.JumlahstokDataGridViewTextBoxColumn, Me.HargabeliDataGridViewTextBoxColumn, Me.HargajualDataGridViewTextBoxColumn, Me.DiskonDataGridViewTextBoxColumn})
        Me.DGVBuku.DataSource = Me.DatabukuBindingSource
        Me.DGVBuku.Location = New System.Drawing.Point(24, 145)
        Me.DGVBuku.Name = "DGVBuku"
        Me.DGVBuku.Size = New System.Drawing.Size(495, 342)
        Me.DGVBuku.TabIndex = 6
        '
        'KodebukuDataGridViewTextBoxColumn
        '
        Me.KodebukuDataGridViewTextBoxColumn.DataPropertyName = "kode_buku"
        Me.KodebukuDataGridViewTextBoxColumn.HeaderText = "kode_buku"
        Me.KodebukuDataGridViewTextBoxColumn.Name = "KodebukuDataGridViewTextBoxColumn"
        '
        'JudulbukuDataGridViewTextBoxColumn
        '
        Me.JudulbukuDataGridViewTextBoxColumn.DataPropertyName = "judul_buku"
        Me.JudulbukuDataGridViewTextBoxColumn.HeaderText = "judul_buku"
        Me.JudulbukuDataGridViewTextBoxColumn.Name = "JudulbukuDataGridViewTextBoxColumn"
        '
        'NamapenulisDataGridViewTextBoxColumn
        '
        Me.NamapenulisDataGridViewTextBoxColumn.DataPropertyName = "nama_penulis"
        Me.NamapenulisDataGridViewTextBoxColumn.HeaderText = "nama_penulis"
        Me.NamapenulisDataGridViewTextBoxColumn.Name = "NamapenulisDataGridViewTextBoxColumn"
        '
        'KodepenerbitDataGridViewTextBoxColumn
        '
        Me.KodepenerbitDataGridViewTextBoxColumn.DataPropertyName = "kode_penerbit"
        Me.KodepenerbitDataGridViewTextBoxColumn.HeaderText = "kode_penerbit"
        Me.KodepenerbitDataGridViewTextBoxColumn.Name = "KodepenerbitDataGridViewTextBoxColumn"
        '
        'TahunterbitDataGridViewTextBoxColumn
        '
        Me.TahunterbitDataGridViewTextBoxColumn.DataPropertyName = "tahun_terbit"
        Me.TahunterbitDataGridViewTextBoxColumn.HeaderText = "tahun_terbit"
        Me.TahunterbitDataGridViewTextBoxColumn.Name = "TahunterbitDataGridViewTextBoxColumn"
        '
        'KategoriDataGridViewTextBoxColumn
        '
        Me.KategoriDataGridViewTextBoxColumn.DataPropertyName = "kategori"
        Me.KategoriDataGridViewTextBoxColumn.HeaderText = "kategori"
        Me.KategoriDataGridViewTextBoxColumn.Name = "KategoriDataGridViewTextBoxColumn"
        '
        'JumlahstokDataGridViewTextBoxColumn
        '
        Me.JumlahstokDataGridViewTextBoxColumn.DataPropertyName = "jumlah_stok"
        Me.JumlahstokDataGridViewTextBoxColumn.HeaderText = "jumlah_stok"
        Me.JumlahstokDataGridViewTextBoxColumn.Name = "JumlahstokDataGridViewTextBoxColumn"
        '
        'HargabeliDataGridViewTextBoxColumn
        '
        Me.HargabeliDataGridViewTextBoxColumn.DataPropertyName = "harga_beli"
        Me.HargabeliDataGridViewTextBoxColumn.HeaderText = "harga_beli"
        Me.HargabeliDataGridViewTextBoxColumn.Name = "HargabeliDataGridViewTextBoxColumn"
        '
        'HargajualDataGridViewTextBoxColumn
        '
        Me.HargajualDataGridViewTextBoxColumn.DataPropertyName = "harga_jual"
        Me.HargajualDataGridViewTextBoxColumn.HeaderText = "harga_jual"
        Me.HargajualDataGridViewTextBoxColumn.Name = "HargajualDataGridViewTextBoxColumn"
        '
        'DiskonDataGridViewTextBoxColumn
        '
        Me.DiskonDataGridViewTextBoxColumn.DataPropertyName = "diskon"
        Me.DiskonDataGridViewTextBoxColumn.HeaderText = "diskon"
        Me.DiskonDataGridViewTextBoxColumn.Name = "DiskonDataGridViewTextBoxColumn"
        '
        'DatabukuBindingSource
        '
        Me.DatabukuBindingSource.DataMember = "data_buku"
        Me.DatabukuBindingSource.DataSource = Me.DbUASDataSet
        '
        'DbUASDataSet
        '
        Me.DbUASDataSet.DataSetName = "DbUASDataSet"
        Me.DbUASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnAmbil
        '
        Me.BtnAmbil.BackColor = System.Drawing.Color.Orange
        Me.BtnAmbil.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAmbil.Location = New System.Drawing.Point(610, 500)
        Me.BtnAmbil.Name = "BtnAmbil"
        Me.BtnAmbil.Size = New System.Drawing.Size(80, 31)
        Me.BtnAmbil.TabIndex = 17
        Me.BtnAmbil.Text = "Ambil Data"
        Me.BtnAmbil.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.Orange
        Me.BtnHapus.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Location = New System.Drawing.Point(773, 500)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(80, 31)
        Me.BtnHapus.TabIndex = 16
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'BtnUbah
        '
        Me.BtnUbah.BackColor = System.Drawing.Color.Gold
        Me.BtnUbah.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUbah.Location = New System.Drawing.Point(691, 500)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(80, 31)
        Me.BtnUbah.TabIndex = 15
        Me.BtnUbah.Text = "Ubah "
        Me.BtnUbah.UseVisualStyleBackColor = False
        '
        'BtnSimpanBuku
        '
        Me.BtnSimpanBuku.BackColor = System.Drawing.Color.Gold
        Me.BtnSimpanBuku.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpanBuku.Location = New System.Drawing.Point(528, 500)
        Me.BtnSimpanBuku.Name = "BtnSimpanBuku"
        Me.BtnSimpanBuku.Size = New System.Drawing.Size(80, 31)
        Me.BtnSimpanBuku.TabIndex = 14
        Me.BtnSimpanBuku.Text = "Simpan"
        Me.BtnSimpanBuku.UseVisualStyleBackColor = False
        '
        'LbMotivasi
        '
        Me.LbMotivasi.AutoSize = True
        Me.LbMotivasi.BackColor = System.Drawing.Color.Transparent
        Me.LbMotivasi.Font = New System.Drawing.Font("Harrington", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMotivasi.Location = New System.Drawing.Point(330, 612)
        Me.LbMotivasi.Name = "LbMotivasi"
        Me.LbMotivasi.Size = New System.Drawing.Size(274, 22)
        Me.LbMotivasi.TabIndex = 19
        Me.LbMotivasi.Text = "Kehidupan adalah sebuah buku "
        '
        'LbJudul
        '
        Me.LbJudul.AutoSize = True
        Me.LbJudul.BackColor = System.Drawing.Color.Transparent
        Me.LbJudul.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbJudul.Location = New System.Drawing.Point(266, 572)
        Me.LbJudul.Name = "LbJudul"
        Me.LbJudul.Size = New System.Drawing.Size(383, 40)
        Me.LbJudul.TabIndex = 18
        Me.LbJudul.Text = "TOKO BUKU PRAMIDITA"
        '
        'Data_bukuTableAdapter
        '
        Me.Data_bukuTableAdapter.ClearBeforeFill = True
        '
        'LbDataBuku
        '
        Me.LbDataBuku.AutoSize = True
        Me.LbDataBuku.BackColor = System.Drawing.Color.Transparent
        Me.LbDataBuku.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDataBuku.Location = New System.Drawing.Point(22, 120)
        Me.LbDataBuku.Name = "LbDataBuku"
        Me.LbDataBuku.Size = New System.Drawing.Size(84, 21)
        Me.LbDataBuku.TabIndex = 20
        Me.LbDataBuku.Text = "Data Buku"
        '
        'FormBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(875, 660)
        Me.Controls.Add(Me.LbDataBuku)
        Me.Controls.Add(Me.LbMotivasi)
        Me.Controls.Add(Me.LbJudul)
        Me.Controls.Add(Me.BtnAmbil)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnSimpanBuku)
        Me.Controls.Add(Me.DGVBuku)
        Me.Controls.Add(Me.GrupTambahBuku)
        Me.Controls.Add(Me.Tab)
        Me.Name = "FormBuku"
        Me.Text = "Master Data Buku "
        Me.Tab.ResumeLayout(False)
        Me.TabMaster.ResumeLayout(False)
        Me.TabTransaksi.ResumeLayout(False)
        Me.TabLaporan.ResumeLayout(False)
        Me.TabPengaturan.ResumeLayout(False)
        Me.GrupTambahBuku.ResumeLayout(False)
        Me.GrupTambahBuku.PerformLayout()
        CType(Me.DGVBuku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbUASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GrupTambahBuku As System.Windows.Forms.GroupBox
    Friend WithEvents TbKategori As System.Windows.Forms.TextBox
    Friend WithEvents TbJudul As System.Windows.Forms.TextBox
    Friend WithEvents LbKategori As System.Windows.Forms.Label
    Friend WithEvents LbKodePenerbit As System.Windows.Forms.Label
    Friend WithEvents LbPenulis As System.Windows.Forms.Label
    Friend WithEvents LbJudulBuku As System.Windows.Forms.Label
    Friend WithEvents LbKodeBuku As System.Windows.Forms.Label
    Friend WithEvents DGVBuku As System.Windows.Forms.DataGridView
    Friend WithEvents BtnAmbil As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnSimpanBuku As System.Windows.Forms.Button
    Friend WithEvents TbPenulis As System.Windows.Forms.TextBox
    Friend WithEvents TbThnTerbit As System.Windows.Forms.TextBox
    Friend WithEvents LbThnTerbit As System.Windows.Forms.Label
    Friend WithEvents TbKodePenerbit As System.Windows.Forms.TextBox
    Friend WithEvents TbHargaBeli As System.Windows.Forms.TextBox
    Friend WithEvents LbHargaBeli As System.Windows.Forms.Label
    Friend WithEvents TbJmlhBuku As System.Windows.Forms.TextBox
    Friend WithEvents LbJumlah As System.Windows.Forms.Label
    Friend WithEvents LbHargaJual As System.Windows.Forms.Label
    Friend WithEvents TbDiskon As System.Windows.Forms.TextBox
    Friend WithEvents LbDiskon As System.Windows.Forms.Label
    Friend WithEvents LbMotivasi As System.Windows.Forms.Label
    Friend WithEvents LbJudul As System.Windows.Forms.Label
    Friend WithEvents DbUASDataSet As WindowsApplication1.DbUASDataSet
    Friend WithEvents DatabukuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Data_bukuTableAdapter As WindowsApplication1.DbUASDataSetTableAdapters.data_bukuTableAdapter
    Friend WithEvents KodebukuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JudulbukuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamapenulisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodepenerbitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TahunterbitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KategoriDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahstokDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargabeliDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargajualDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiskonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LbDataBuku As System.Windows.Forms.Label
    Friend WithEvents LbIsiKode As System.Windows.Forms.Label
    Friend WithEvents LbIsiJual As System.Windows.Forms.Label
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
End Class
