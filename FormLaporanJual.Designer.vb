<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLpJual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLpJual))
        Me.BtnCetak = New System.Windows.Forms.Button()
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
        Me.GrupLaporJual = New System.Windows.Forms.GroupBox()
        Me.LbNoJual = New System.Windows.Forms.Label()
        Me.LbNoNota = New System.Windows.Forms.Label()
        Me.CrJual = New AxCrystal.AxCrystalReport()
        Me.DGVLaporJual = New System.Windows.Forms.DataGridView()
        Me.no_invoicejual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_nota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal_jual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_laku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_jual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sisa_stok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoinvoicejualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NonotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggaljualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IduserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodebukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahlakuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargajualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SisastokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalpendapatanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoicejualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbUASDataSet = New WindowsApplication1.DbUASDataSet()
        Me.Invoice_jualTableAdapter = New WindowsApplication1.DbUASDataSetTableAdapters.invoice_jualTableAdapter()
        Me.Tab.SuspendLayout()
        Me.TabMaster.SuspendLayout()
        Me.TabTransaksi.SuspendLayout()
        Me.TabLaporan.SuspendLayout()
        Me.TabPengaturan.SuspendLayout()
        Me.GrupLaporJual.SuspendLayout()
        CType(Me.CrJual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVLaporJual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoicejualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbUASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCetak
        '
        Me.BtnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCetak.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCetak.Image = CType(resources.GetObject("BtnCetak.Image"), System.Drawing.Image)
        Me.BtnCetak.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCetak.Location = New System.Drawing.Point(687, 15)
        Me.BtnCetak.Name = "BtnCetak"
        Me.BtnCetak.Size = New System.Drawing.Size(105, 78)
        Me.BtnCetak.TabIndex = 0
        Me.BtnCetak.Text = "Cetak Laporan"
        Me.BtnCetak.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCetak.UseVisualStyleBackColor = True
        '
        'Tab
        '
        Me.Tab.Controls.Add(Me.TabMaster)
        Me.Tab.Controls.Add(Me.TabTransaksi)
        Me.Tab.Controls.Add(Me.TabLaporan)
        Me.Tab.Controls.Add(Me.TabPengaturan)
        Me.Tab.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab.Location = New System.Drawing.Point(0, -1)
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(797, 114)
        Me.Tab.TabIndex = 2
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
        Me.TabMaster.Size = New System.Drawing.Size(789, 84)
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
        Me.BtnPenerbit.Location = New System.Drawing.Point(341, 3)
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
        Me.BtnSuplier.Size = New System.Drawing.Size(95, 78)
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
        Me.BtnBuku.Size = New System.Drawing.Size(87, 78)
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
        Me.TabTransaksi.Size = New System.Drawing.Size(789, 84)
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
        Me.TabLaporan.Size = New System.Drawing.Size(789, 84)
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
        Me.TabPengaturan.Size = New System.Drawing.Size(789, 84)
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
        'GrupLaporJual
        '
        Me.GrupLaporJual.BackColor = System.Drawing.Color.Orange
        Me.GrupLaporJual.Controls.Add(Me.LbNoJual)
        Me.GrupLaporJual.Controls.Add(Me.LbNoNota)
        Me.GrupLaporJual.Controls.Add(Me.CrJual)
        Me.GrupLaporJual.Controls.Add(Me.BtnCetak)
        Me.GrupLaporJual.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupLaporJual.Location = New System.Drawing.Point(-1, 422)
        Me.GrupLaporJual.Name = "GrupLaporJual"
        Me.GrupLaporJual.Size = New System.Drawing.Size(815, 96)
        Me.GrupLaporJual.TabIndex = 16
        Me.GrupLaporJual.TabStop = False
        Me.GrupLaporJual.Text = "Laporan Penjualan"
        '
        'LbNoJual
        '
        Me.LbNoJual.AutoSize = True
        Me.LbNoJual.Location = New System.Drawing.Point(147, 32)
        Me.LbNoJual.Name = "LbNoJual"
        Me.LbNoJual.Size = New System.Drawing.Size(0, 20)
        Me.LbNoJual.TabIndex = 4
        '
        'LbNoNota
        '
        Me.LbNoNota.AutoSize = True
        Me.LbNoNota.Location = New System.Drawing.Point(8, 32)
        Me.LbNoNota.Name = "LbNoNota"
        Me.LbNoNota.Size = New System.Drawing.Size(133, 20)
        Me.LbNoNota.TabIndex = 3
        Me.LbNoNota.Text = "No. Invoice Jual : "
        '
        'CrJual
        '
        Me.CrJual.Enabled = True
        Me.CrJual.Location = New System.Drawing.Point(662, 65)
        Me.CrJual.Name = "CrJual"
        Me.CrJual.OcxState = CType(resources.GetObject("CrJual.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CrJual.Size = New System.Drawing.Size(28, 28)
        Me.CrJual.TabIndex = 2
        '
        'DGVLaporJual
        '
        Me.DGVLaporJual.AutoGenerateColumns = False
        Me.DGVLaporJual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVLaporJual.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no_invoicejual, Me.no_nota, Me.tanggal_jual, Me.id_user, Me.kode_buku, Me.jumlah_laku, Me.harga_jual, Me.sisa_stok, Me.NoinvoicejualDataGridViewTextBoxColumn, Me.NonotaDataGridViewTextBoxColumn, Me.TanggaljualDataGridViewTextBoxColumn, Me.IduserDataGridViewTextBoxColumn, Me.KodebukuDataGridViewTextBoxColumn, Me.JumlahlakuDataGridViewTextBoxColumn, Me.HargajualDataGridViewTextBoxColumn, Me.SisastokDataGridViewTextBoxColumn, Me.TotalpendapatanDataGridViewTextBoxColumn})
        Me.DGVLaporJual.DataSource = Me.InvoicejualBindingSource
        Me.DGVLaporJual.Location = New System.Drawing.Point(7, 131)
        Me.DGVLaporJual.Name = "DGVLaporJual"
        Me.DGVLaporJual.Size = New System.Drawing.Size(795, 267)
        Me.DGVLaporJual.TabIndex = 17
        '
        'no_invoicejual
        '
        Me.no_invoicejual.HeaderText = "no_invoicejual"
        Me.no_invoicejual.Name = "no_invoicejual"
        '
        'no_nota
        '
        Me.no_nota.HeaderText = "no_nota"
        Me.no_nota.Name = "no_nota"
        '
        'tanggal_jual
        '
        Me.tanggal_jual.HeaderText = "tanggal_jual"
        Me.tanggal_jual.Name = "tanggal_jual"
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
        'jumlah_laku
        '
        Me.jumlah_laku.HeaderText = "jumlah_laku"
        Me.jumlah_laku.Name = "jumlah_laku"
        '
        'harga_jual
        '
        Me.harga_jual.HeaderText = "harga_jual"
        Me.harga_jual.Name = "harga_jual"
        '
        'sisa_stok
        '
        Me.sisa_stok.HeaderText = "sisa_stok"
        Me.sisa_stok.Name = "sisa_stok"
        '
        'NoinvoicejualDataGridViewTextBoxColumn
        '
        Me.NoinvoicejualDataGridViewTextBoxColumn.DataPropertyName = "no_invoicejual"
        Me.NoinvoicejualDataGridViewTextBoxColumn.HeaderText = "no_invoicejual"
        Me.NoinvoicejualDataGridViewTextBoxColumn.Name = "NoinvoicejualDataGridViewTextBoxColumn"
        '
        'NonotaDataGridViewTextBoxColumn
        '
        Me.NonotaDataGridViewTextBoxColumn.DataPropertyName = "no_nota"
        Me.NonotaDataGridViewTextBoxColumn.HeaderText = "no_nota"
        Me.NonotaDataGridViewTextBoxColumn.Name = "NonotaDataGridViewTextBoxColumn"
        '
        'TanggaljualDataGridViewTextBoxColumn
        '
        Me.TanggaljualDataGridViewTextBoxColumn.DataPropertyName = "tanggal_jual"
        Me.TanggaljualDataGridViewTextBoxColumn.HeaderText = "tanggal_jual"
        Me.TanggaljualDataGridViewTextBoxColumn.Name = "TanggaljualDataGridViewTextBoxColumn"
        '
        'IduserDataGridViewTextBoxColumn
        '
        Me.IduserDataGridViewTextBoxColumn.DataPropertyName = "id_user"
        Me.IduserDataGridViewTextBoxColumn.HeaderText = "id_user"
        Me.IduserDataGridViewTextBoxColumn.Name = "IduserDataGridViewTextBoxColumn"
        '
        'KodebukuDataGridViewTextBoxColumn
        '
        Me.KodebukuDataGridViewTextBoxColumn.DataPropertyName = "kode_buku"
        Me.KodebukuDataGridViewTextBoxColumn.HeaderText = "kode_buku"
        Me.KodebukuDataGridViewTextBoxColumn.Name = "KodebukuDataGridViewTextBoxColumn"
        '
        'JumlahlakuDataGridViewTextBoxColumn
        '
        Me.JumlahlakuDataGridViewTextBoxColumn.DataPropertyName = "jumlah_laku"
        Me.JumlahlakuDataGridViewTextBoxColumn.HeaderText = "jumlah_laku"
        Me.JumlahlakuDataGridViewTextBoxColumn.Name = "JumlahlakuDataGridViewTextBoxColumn"
        '
        'HargajualDataGridViewTextBoxColumn
        '
        Me.HargajualDataGridViewTextBoxColumn.DataPropertyName = "harga_jual"
        Me.HargajualDataGridViewTextBoxColumn.HeaderText = "harga_jual"
        Me.HargajualDataGridViewTextBoxColumn.Name = "HargajualDataGridViewTextBoxColumn"
        '
        'SisastokDataGridViewTextBoxColumn
        '
        Me.SisastokDataGridViewTextBoxColumn.DataPropertyName = "sisa_stok"
        Me.SisastokDataGridViewTextBoxColumn.HeaderText = "sisa_stok"
        Me.SisastokDataGridViewTextBoxColumn.Name = "SisastokDataGridViewTextBoxColumn"
        '
        'TotalpendapatanDataGridViewTextBoxColumn
        '
        Me.TotalpendapatanDataGridViewTextBoxColumn.DataPropertyName = "total_pendapatan"
        Me.TotalpendapatanDataGridViewTextBoxColumn.HeaderText = "total_pendapatan"
        Me.TotalpendapatanDataGridViewTextBoxColumn.Name = "TotalpendapatanDataGridViewTextBoxColumn"
        '
        'InvoicejualBindingSource
        '
        Me.InvoicejualBindingSource.DataMember = "invoice_jual"
        Me.InvoicejualBindingSource.DataSource = Me.DbUASDataSet
        '
        'DbUASDataSet
        '
        Me.DbUASDataSet.DataSetName = "DbUASDataSet"
        Me.DbUASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Invoice_jualTableAdapter
        '
        Me.Invoice_jualTableAdapter.ClearBeforeFill = True
        '
        'FormLpJual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(811, 518)
        Me.Controls.Add(Me.DGVLaporJual)
        Me.Controls.Add(Me.GrupLaporJual)
        Me.Controls.Add(Me.Tab)
        Me.Name = "FormLpJual"
        Me.Text = "Laporan Penjualan"
        Me.Tab.ResumeLayout(False)
        Me.TabMaster.ResumeLayout(False)
        Me.TabTransaksi.ResumeLayout(False)
        Me.TabLaporan.ResumeLayout(False)
        Me.TabPengaturan.ResumeLayout(False)
        Me.GrupLaporJual.ResumeLayout(False)
        Me.GrupLaporJual.PerformLayout()
        CType(Me.CrJual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVLaporJual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoicejualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbUASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCetak As System.Windows.Forms.Button
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
    Friend WithEvents GrupLaporJual As System.Windows.Forms.GroupBox
    Friend WithEvents DGVLaporJual As System.Windows.Forms.DataGridView
    Friend WithEvents DbUASDataSet As WindowsApplication1.DbUASDataSet
    Friend WithEvents InvoicejualBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Invoice_jualTableAdapter As WindowsApplication1.DbUASDataSetTableAdapters.invoice_jualTableAdapter
    Friend WithEvents CrJual As AxCrystal.AxCrystalReport
    Friend WithEvents LbNoNota As System.Windows.Forms.Label
    Friend WithEvents no_invoicejual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents no_nota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tanggal_jual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_user As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kode_buku As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah_laku As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga_jual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sisa_stok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoinvoicejualDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NonotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TanggaljualDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IduserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodebukuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahlakuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargajualDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SisastokDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalpendapatanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LbNoJual As System.Windows.Forms.Label
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
End Class
