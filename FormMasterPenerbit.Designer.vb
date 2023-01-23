<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenerbit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPenerbit))
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
        Me.LbDataPenerbit = New System.Windows.Forms.Label()
        Me.GrupTambahPenerbit = New System.Windows.Forms.GroupBox()
        Me.LbIsiId = New System.Windows.Forms.Label()
        Me.TBTeleponPenerbit = New System.Windows.Forms.TextBox()
        Me.TBAlamatPenerbit = New System.Windows.Forms.TextBox()
        Me.TbNamaPenerbit = New System.Windows.Forms.TextBox()
        Me.LbTeleponPenerbit = New System.Windows.Forms.Label()
        Me.LbAlamatPenerbit = New System.Windows.Forms.Label()
        Me.LbNamaPenerbit = New System.Windows.Forms.Label()
        Me.LbIdPenerbit = New System.Windows.Forms.Label()
        Me.DGVPenerbit = New System.Windows.Forms.DataGridView()
        Me.KodepenerbitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamapenerbitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteleponDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatapenerbitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbUASDataSet = New WindowsApplication1.DbUASDataSet()
        Me.BtnAmbil = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnSimpanPenerbit = New System.Windows.Forms.Button()
        Me.LbMotivasi = New System.Windows.Forms.Label()
        Me.LbJudul = New System.Windows.Forms.Label()
        Me.Data_penerbitTableAdapter = New WindowsApplication1.DbUASDataSetTableAdapters.data_penerbitTableAdapter()
        Me.Tab.SuspendLayout()
        Me.TabMaster.SuspendLayout()
        Me.TabTransaksi.SuspendLayout()
        Me.TabLaporan.SuspendLayout()
        Me.TabPengaturan.SuspendLayout()
        Me.GrupTambahPenerbit.SuspendLayout()
        CType(Me.DGVPenerbit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatapenerbitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Tab.Location = New System.Drawing.Point(-4, -1)
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
        Me.BtnPenerbit.Location = New System.Drawing.Point(329, 3)
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
        Me.BtnSuplier.Location = New System.Drawing.Point(236, 3)
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
        Me.BtnBuku.Location = New System.Drawing.Point(159, 3)
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
        Me.BtnMember.Size = New System.Drawing.Size(79, 78)
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
        Me.BtnInfo.Text = "Info Operator"
        Me.BtnInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnInfo.UseVisualStyleBackColor = True
        '
        'LbDataPenerbit
        '
        Me.LbDataPenerbit.AutoSize = True
        Me.LbDataPenerbit.BackColor = System.Drawing.Color.Transparent
        Me.LbDataPenerbit.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDataPenerbit.Location = New System.Drawing.Point(43, 126)
        Me.LbDataPenerbit.Name = "LbDataPenerbit"
        Me.LbDataPenerbit.Size = New System.Drawing.Size(117, 21)
        Me.LbDataPenerbit.TabIndex = 5
        Me.LbDataPenerbit.Text = "Data Penerbit "
        '
        'GrupTambahPenerbit
        '
        Me.GrupTambahPenerbit.BackColor = System.Drawing.Color.Transparent
        Me.GrupTambahPenerbit.Controls.Add(Me.LbIsiId)
        Me.GrupTambahPenerbit.Controls.Add(Me.TBTeleponPenerbit)
        Me.GrupTambahPenerbit.Controls.Add(Me.TBAlamatPenerbit)
        Me.GrupTambahPenerbit.Controls.Add(Me.TbNamaPenerbit)
        Me.GrupTambahPenerbit.Controls.Add(Me.LbTeleponPenerbit)
        Me.GrupTambahPenerbit.Controls.Add(Me.LbAlamatPenerbit)
        Me.GrupTambahPenerbit.Controls.Add(Me.LbNamaPenerbit)
        Me.GrupTambahPenerbit.Controls.Add(Me.LbIdPenerbit)
        Me.GrupTambahPenerbit.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupTambahPenerbit.Location = New System.Drawing.Point(528, 153)
        Me.GrupTambahPenerbit.Name = "GrupTambahPenerbit"
        Me.GrupTambahPenerbit.Size = New System.Drawing.Size(295, 218)
        Me.GrupTambahPenerbit.TabIndex = 6
        Me.GrupTambahPenerbit.TabStop = False
        Me.GrupTambahPenerbit.Text = "Tambah Penerbit "
        '
        'LbIsiId
        '
        Me.LbIsiId.AutoSize = True
        Me.LbIsiId.Location = New System.Drawing.Point(100, 38)
        Me.LbIsiId.Name = "LbIsiId"
        Me.LbIsiId.Size = New System.Drawing.Size(0, 18)
        Me.LbIsiId.TabIndex = 11
        '
        'TBTeleponPenerbit
        '
        Me.TBTeleponPenerbit.Location = New System.Drawing.Point(103, 159)
        Me.TBTeleponPenerbit.Name = "TBTeleponPenerbit"
        Me.TBTeleponPenerbit.Size = New System.Drawing.Size(183, 26)
        Me.TBTeleponPenerbit.TabIndex = 10
        '
        'TBAlamatPenerbit
        '
        Me.TBAlamatPenerbit.Location = New System.Drawing.Point(103, 104)
        Me.TBAlamatPenerbit.Multiline = True
        Me.TBAlamatPenerbit.Name = "TBAlamatPenerbit"
        Me.TBAlamatPenerbit.Size = New System.Drawing.Size(183, 45)
        Me.TBAlamatPenerbit.TabIndex = 8
        '
        'TbNamaPenerbit
        '
        Me.TbNamaPenerbit.Location = New System.Drawing.Point(103, 69)
        Me.TbNamaPenerbit.Name = "TbNamaPenerbit"
        Me.TbNamaPenerbit.Size = New System.Drawing.Size(183, 26)
        Me.TbNamaPenerbit.TabIndex = 7
        '
        'LbTeleponPenerbit
        '
        Me.LbTeleponPenerbit.AutoSize = True
        Me.LbTeleponPenerbit.Location = New System.Drawing.Point(6, 163)
        Me.LbTeleponPenerbit.Name = "LbTeleponPenerbit"
        Me.LbTeleponPenerbit.Size = New System.Drawing.Size(84, 18)
        Me.LbTeleponPenerbit.TabIndex = 5
        Me.LbTeleponPenerbit.Text = "No. Telepon "
        '
        'LbAlamatPenerbit
        '
        Me.LbAlamatPenerbit.AutoSize = True
        Me.LbAlamatPenerbit.Location = New System.Drawing.Point(6, 108)
        Me.LbAlamatPenerbit.Name = "LbAlamatPenerbit"
        Me.LbAlamatPenerbit.Size = New System.Drawing.Size(49, 18)
        Me.LbAlamatPenerbit.TabIndex = 3
        Me.LbAlamatPenerbit.Text = "Alamat"
        '
        'LbNamaPenerbit
        '
        Me.LbNamaPenerbit.AutoSize = True
        Me.LbNamaPenerbit.Location = New System.Drawing.Point(6, 70)
        Me.LbNamaPenerbit.Name = "LbNamaPenerbit"
        Me.LbNamaPenerbit.Size = New System.Drawing.Size(96, 18)
        Me.LbNamaPenerbit.TabIndex = 1
        Me.LbNamaPenerbit.Text = "Nama Penerbit"
        '
        'LbIdPenerbit
        '
        Me.LbIdPenerbit.AutoSize = True
        Me.LbIdPenerbit.Location = New System.Drawing.Point(6, 38)
        Me.LbIdPenerbit.Name = "LbIdPenerbit"
        Me.LbIdPenerbit.Size = New System.Drawing.Size(78, 18)
        Me.LbIdPenerbit.TabIndex = 0
        Me.LbIdPenerbit.Text = "Id Penerbit"
        '
        'DGVPenerbit
        '
        Me.DGVPenerbit.AutoGenerateColumns = False
        Me.DGVPenerbit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPenerbit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodepenerbitDataGridViewTextBoxColumn, Me.NamapenerbitDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.NoteleponDataGridViewTextBoxColumn})
        Me.DGVPenerbit.DataSource = Me.DatapenerbitBindingSource
        Me.DGVPenerbit.Location = New System.Drawing.Point(42, 154)
        Me.DGVPenerbit.Name = "DGVPenerbit"
        Me.DGVPenerbit.Size = New System.Drawing.Size(446, 267)
        Me.DGVPenerbit.TabIndex = 7
        '
        'KodepenerbitDataGridViewTextBoxColumn
        '
        Me.KodepenerbitDataGridViewTextBoxColumn.DataPropertyName = "kode_penerbit"
        Me.KodepenerbitDataGridViewTextBoxColumn.HeaderText = "kode_penerbit"
        Me.KodepenerbitDataGridViewTextBoxColumn.Name = "KodepenerbitDataGridViewTextBoxColumn"
        '
        'NamapenerbitDataGridViewTextBoxColumn
        '
        Me.NamapenerbitDataGridViewTextBoxColumn.DataPropertyName = "nama_penerbit"
        Me.NamapenerbitDataGridViewTextBoxColumn.HeaderText = "nama_penerbit"
        Me.NamapenerbitDataGridViewTextBoxColumn.Name = "NamapenerbitDataGridViewTextBoxColumn"
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        '
        'NoteleponDataGridViewTextBoxColumn
        '
        Me.NoteleponDataGridViewTextBoxColumn.DataPropertyName = "no_telepon"
        Me.NoteleponDataGridViewTextBoxColumn.HeaderText = "no_telepon"
        Me.NoteleponDataGridViewTextBoxColumn.Name = "NoteleponDataGridViewTextBoxColumn"
        '
        'DatapenerbitBindingSource
        '
        Me.DatapenerbitBindingSource.DataMember = "data_penerbit"
        Me.DatapenerbitBindingSource.DataSource = Me.DbUASDataSet
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
        Me.BtnAmbil.Location = New System.Drawing.Point(592, 381)
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
        Me.BtnHapus.Location = New System.Drawing.Point(755, 381)
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
        Me.BtnUbah.Location = New System.Drawing.Point(673, 381)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(80, 31)
        Me.BtnUbah.TabIndex = 15
        Me.BtnUbah.Text = "Ubah "
        Me.BtnUbah.UseVisualStyleBackColor = False
        '
        'BtnSimpanPenerbit
        '
        Me.BtnSimpanPenerbit.BackColor = System.Drawing.Color.Gold
        Me.BtnSimpanPenerbit.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpanPenerbit.Location = New System.Drawing.Point(510, 381)
        Me.BtnSimpanPenerbit.Name = "BtnSimpanPenerbit"
        Me.BtnSimpanPenerbit.Size = New System.Drawing.Size(80, 31)
        Me.BtnSimpanPenerbit.TabIndex = 14
        Me.BtnSimpanPenerbit.Text = "Simpan"
        Me.BtnSimpanPenerbit.UseVisualStyleBackColor = False
        '
        'LbMotivasi
        '
        Me.LbMotivasi.AutoSize = True
        Me.LbMotivasi.BackColor = System.Drawing.Color.Transparent
        Me.LbMotivasi.Font = New System.Drawing.Font("Harrington", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMotivasi.Location = New System.Drawing.Point(331, 496)
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
        Me.LbJudul.Location = New System.Drawing.Point(266, 451)
        Me.LbJudul.Name = "LbJudul"
        Me.LbJudul.Size = New System.Drawing.Size(383, 40)
        Me.LbJudul.TabIndex = 18
        Me.LbJudul.Text = "TOKO BUKU PRAMIDITA"
        '
        'Data_penerbitTableAdapter
        '
        Me.Data_penerbitTableAdapter.ClearBeforeFill = True
        '
        'FormPenerbit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(875, 540)
        Me.Controls.Add(Me.LbMotivasi)
        Me.Controls.Add(Me.LbJudul)
        Me.Controls.Add(Me.BtnAmbil)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnSimpanPenerbit)
        Me.Controls.Add(Me.DGVPenerbit)
        Me.Controls.Add(Me.GrupTambahPenerbit)
        Me.Controls.Add(Me.LbDataPenerbit)
        Me.Controls.Add(Me.Tab)
        Me.Name = "FormPenerbit"
        Me.Text = "Master Penerbit"
        Me.Tab.ResumeLayout(False)
        Me.TabMaster.ResumeLayout(False)
        Me.TabTransaksi.ResumeLayout(False)
        Me.TabLaporan.ResumeLayout(False)
        Me.TabPengaturan.ResumeLayout(False)
        Me.GrupTambahPenerbit.ResumeLayout(False)
        Me.GrupTambahPenerbit.PerformLayout()
        CType(Me.DGVPenerbit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatapenerbitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LbDataPenerbit As System.Windows.Forms.Label
    Friend WithEvents GrupTambahPenerbit As System.Windows.Forms.GroupBox
    Friend WithEvents TBTeleponPenerbit As System.Windows.Forms.TextBox
    Friend WithEvents TBAlamatPenerbit As System.Windows.Forms.TextBox
    Friend WithEvents TbNamaPenerbit As System.Windows.Forms.TextBox
    Friend WithEvents LbTeleponPenerbit As System.Windows.Forms.Label
    Friend WithEvents LbAlamatPenerbit As System.Windows.Forms.Label
    Friend WithEvents LbNamaPenerbit As System.Windows.Forms.Label
    Friend WithEvents LbIdPenerbit As System.Windows.Forms.Label
    Friend WithEvents DGVPenerbit As System.Windows.Forms.DataGridView
    Friend WithEvents BtnAmbil As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnSimpanPenerbit As System.Windows.Forms.Button
    Friend WithEvents LbMotivasi As System.Windows.Forms.Label
    Friend WithEvents LbJudul As System.Windows.Forms.Label
    Friend WithEvents DbUASDataSet As WindowsApplication1.DbUASDataSet
    Friend WithEvents DatapenerbitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Data_penerbitTableAdapter As WindowsApplication1.DbUASDataSetTableAdapters.data_penerbitTableAdapter
    Friend WithEvents KodepenerbitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamapenerbitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoteleponDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LbIsiId As System.Windows.Forms.Label
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
End Class
