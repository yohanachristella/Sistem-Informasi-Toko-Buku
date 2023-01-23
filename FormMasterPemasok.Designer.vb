<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formpemasok
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formpemasok))
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
        Me.DGVPemasok = New System.Windows.Forms.DataGridView()
        Me.IdsuplierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamasuplierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteleponDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbUASDataSet = New WindowsApplication1.DbUASDataSet()
        Me.LbDataPemasok = New System.Windows.Forms.Label()
        Me.GrupTambahPemasok = New System.Windows.Forms.GroupBox()
        Me.LbisiId = New System.Windows.Forms.Label()
        Me.TBTeleponPemasok = New System.Windows.Forms.TextBox()
        Me.TBAlamatPemasok = New System.Windows.Forms.TextBox()
        Me.TbNamaPemasok = New System.Windows.Forms.TextBox()
        Me.LbTeleponPemasok = New System.Windows.Forms.Label()
        Me.LbAlamatPemasok = New System.Windows.Forms.Label()
        Me.LbNamaPemasok = New System.Windows.Forms.Label()
        Me.LbIdPemasok = New System.Windows.Forms.Label()
        Me.BtnAmbil = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnSimpanPemasok = New System.Windows.Forms.Button()
        Me.LbMotivasi = New System.Windows.Forms.Label()
        Me.LbJudul = New System.Windows.Forms.Label()
        Me.SuplierTableAdapter = New WindowsApplication1.DbUASDataSetTableAdapters.suplierTableAdapter()
        Me.Tab.SuspendLayout()
        Me.TabMaster.SuspendLayout()
        Me.TabTransaksi.SuspendLayout()
        Me.TabLaporan.SuspendLayout()
        Me.TabPengaturan.SuspendLayout()
        CType(Me.DGVPemasok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbUASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupTambahPemasok.SuspendLayout()
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
        Me.BtnInfo.Text = "Info Operator "
        Me.BtnInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnInfo.UseVisualStyleBackColor = True
        '
        'DGVPemasok
        '
        Me.DGVPemasok.AutoGenerateColumns = False
        Me.DGVPemasok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPemasok.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdsuplierDataGridViewTextBoxColumn, Me.NamasuplierDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.NoteleponDataGridViewTextBoxColumn})
        Me.DGVPemasok.DataSource = Me.SuplierBindingSource
        Me.DGVPemasok.Location = New System.Drawing.Point(42, 146)
        Me.DGVPemasok.Name = "DGVPemasok"
        Me.DGVPemasok.Size = New System.Drawing.Size(446, 267)
        Me.DGVPemasok.TabIndex = 3
        '
        'IdsuplierDataGridViewTextBoxColumn
        '
        Me.IdsuplierDataGridViewTextBoxColumn.DataPropertyName = "id_suplier"
        Me.IdsuplierDataGridViewTextBoxColumn.HeaderText = "id_suplier"
        Me.IdsuplierDataGridViewTextBoxColumn.Name = "IdsuplierDataGridViewTextBoxColumn"
        '
        'NamasuplierDataGridViewTextBoxColumn
        '
        Me.NamasuplierDataGridViewTextBoxColumn.DataPropertyName = "nama_suplier"
        Me.NamasuplierDataGridViewTextBoxColumn.HeaderText = "nama_suplier"
        Me.NamasuplierDataGridViewTextBoxColumn.Name = "NamasuplierDataGridViewTextBoxColumn"
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
        'SuplierBindingSource
        '
        Me.SuplierBindingSource.DataMember = "suplier"
        Me.SuplierBindingSource.DataSource = Me.DbUASDataSet
        '
        'DbUASDataSet
        '
        Me.DbUASDataSet.DataSetName = "DbUASDataSet"
        Me.DbUASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LbDataPemasok
        '
        Me.LbDataPemasok.AutoSize = True
        Me.LbDataPemasok.BackColor = System.Drawing.Color.Transparent
        Me.LbDataPemasok.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDataPemasok.Location = New System.Drawing.Point(39, 122)
        Me.LbDataPemasok.Name = "LbDataPemasok"
        Me.LbDataPemasok.Size = New System.Drawing.Size(110, 21)
        Me.LbDataPemasok.TabIndex = 4
        Me.LbDataPemasok.Text = "Data Pemasok"
        '
        'GrupTambahPemasok
        '
        Me.GrupTambahPemasok.BackColor = System.Drawing.Color.Transparent
        Me.GrupTambahPemasok.Controls.Add(Me.LbisiId)
        Me.GrupTambahPemasok.Controls.Add(Me.TBTeleponPemasok)
        Me.GrupTambahPemasok.Controls.Add(Me.TBAlamatPemasok)
        Me.GrupTambahPemasok.Controls.Add(Me.TbNamaPemasok)
        Me.GrupTambahPemasok.Controls.Add(Me.LbTeleponPemasok)
        Me.GrupTambahPemasok.Controls.Add(Me.LbAlamatPemasok)
        Me.GrupTambahPemasok.Controls.Add(Me.LbNamaPemasok)
        Me.GrupTambahPemasok.Controls.Add(Me.LbIdPemasok)
        Me.GrupTambahPemasok.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupTambahPemasok.Location = New System.Drawing.Point(548, 146)
        Me.GrupTambahPemasok.Name = "GrupTambahPemasok"
        Me.GrupTambahPemasok.Size = New System.Drawing.Size(295, 218)
        Me.GrupTambahPemasok.TabIndex = 5
        Me.GrupTambahPemasok.TabStop = False
        Me.GrupTambahPemasok.Text = "Tambah Pemasok "
        '
        'LbisiId
        '
        Me.LbisiId.AutoSize = True
        Me.LbisiId.Location = New System.Drawing.Point(100, 38)
        Me.LbisiId.Name = "LbisiId"
        Me.LbisiId.Size = New System.Drawing.Size(0, 18)
        Me.LbisiId.TabIndex = 11
        '
        'TBTeleponPemasok
        '
        Me.TBTeleponPemasok.Location = New System.Drawing.Point(103, 159)
        Me.TBTeleponPemasok.Name = "TBTeleponPemasok"
        Me.TBTeleponPemasok.Size = New System.Drawing.Size(183, 26)
        Me.TBTeleponPemasok.TabIndex = 10
        '
        'TBAlamatPemasok
        '
        Me.TBAlamatPemasok.Location = New System.Drawing.Point(103, 104)
        Me.TBAlamatPemasok.Multiline = True
        Me.TBAlamatPemasok.Name = "TBAlamatPemasok"
        Me.TBAlamatPemasok.Size = New System.Drawing.Size(183, 45)
        Me.TBAlamatPemasok.TabIndex = 8
        '
        'TbNamaPemasok
        '
        Me.TbNamaPemasok.Location = New System.Drawing.Point(103, 69)
        Me.TbNamaPemasok.Name = "TbNamaPemasok"
        Me.TbNamaPemasok.Size = New System.Drawing.Size(183, 26)
        Me.TbNamaPemasok.TabIndex = 7
        '
        'LbTeleponPemasok
        '
        Me.LbTeleponPemasok.AutoSize = True
        Me.LbTeleponPemasok.Location = New System.Drawing.Point(6, 163)
        Me.LbTeleponPemasok.Name = "LbTeleponPemasok"
        Me.LbTeleponPemasok.Size = New System.Drawing.Size(84, 18)
        Me.LbTeleponPemasok.TabIndex = 5
        Me.LbTeleponPemasok.Text = "No. Telepon "
        '
        'LbAlamatPemasok
        '
        Me.LbAlamatPemasok.AutoSize = True
        Me.LbAlamatPemasok.Location = New System.Drawing.Point(6, 108)
        Me.LbAlamatPemasok.Name = "LbAlamatPemasok"
        Me.LbAlamatPemasok.Size = New System.Drawing.Size(49, 18)
        Me.LbAlamatPemasok.TabIndex = 3
        Me.LbAlamatPemasok.Text = "Alamat"
        '
        'LbNamaPemasok
        '
        Me.LbNamaPemasok.AutoSize = True
        Me.LbNamaPemasok.Location = New System.Drawing.Point(6, 70)
        Me.LbNamaPemasok.Name = "LbNamaPemasok"
        Me.LbNamaPemasok.Size = New System.Drawing.Size(95, 18)
        Me.LbNamaPemasok.TabIndex = 1
        Me.LbNamaPemasok.Text = "Nama Pemasok"
        '
        'LbIdPemasok
        '
        Me.LbIdPemasok.AutoSize = True
        Me.LbIdPemasok.Location = New System.Drawing.Point(6, 38)
        Me.LbIdPemasok.Name = "LbIdPemasok"
        Me.LbIdPemasok.Size = New System.Drawing.Size(77, 18)
        Me.LbIdPemasok.TabIndex = 0
        Me.LbIdPemasok.Text = "Id Pemasok"
        '
        'BtnAmbil
        '
        Me.BtnAmbil.BackColor = System.Drawing.Color.Orange
        Me.BtnAmbil.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAmbil.Location = New System.Drawing.Point(619, 382)
        Me.BtnAmbil.Name = "BtnAmbil"
        Me.BtnAmbil.Size = New System.Drawing.Size(80, 31)
        Me.BtnAmbil.TabIndex = 13
        Me.BtnAmbil.Text = "Ambil Data"
        Me.BtnAmbil.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.Orange
        Me.BtnHapus.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Location = New System.Drawing.Point(782, 382)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(80, 31)
        Me.BtnHapus.TabIndex = 12
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'BtnUbah
        '
        Me.BtnUbah.BackColor = System.Drawing.Color.Gold
        Me.BtnUbah.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUbah.Location = New System.Drawing.Point(700, 382)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(80, 31)
        Me.BtnUbah.TabIndex = 11
        Me.BtnUbah.Text = "Ubah "
        Me.BtnUbah.UseVisualStyleBackColor = False
        '
        'BtnSimpanPemasok
        '
        Me.BtnSimpanPemasok.BackColor = System.Drawing.Color.Gold
        Me.BtnSimpanPemasok.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpanPemasok.Location = New System.Drawing.Point(537, 382)
        Me.BtnSimpanPemasok.Name = "BtnSimpanPemasok"
        Me.BtnSimpanPemasok.Size = New System.Drawing.Size(80, 31)
        Me.BtnSimpanPemasok.TabIndex = 10
        Me.BtnSimpanPemasok.Text = "Simpan"
        Me.BtnSimpanPemasok.UseVisualStyleBackColor = False
        '
        'LbMotivasi
        '
        Me.LbMotivasi.AutoSize = True
        Me.LbMotivasi.BackColor = System.Drawing.Color.Transparent
        Me.LbMotivasi.Font = New System.Drawing.Font("Harrington", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMotivasi.Location = New System.Drawing.Point(340, 502)
        Me.LbMotivasi.Name = "LbMotivasi"
        Me.LbMotivasi.Size = New System.Drawing.Size(274, 22)
        Me.LbMotivasi.TabIndex = 15
        Me.LbMotivasi.Text = "Kehidupan adalah sebuah buku "
        '
        'LbJudul
        '
        Me.LbJudul.AutoSize = True
        Me.LbJudul.BackColor = System.Drawing.Color.Transparent
        Me.LbJudul.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbJudul.Location = New System.Drawing.Point(275, 457)
        Me.LbJudul.Name = "LbJudul"
        Me.LbJudul.Size = New System.Drawing.Size(383, 40)
        Me.LbJudul.TabIndex = 14
        Me.LbJudul.Text = "TOKO BUKU PRAMIDITA"
        '
        'SuplierTableAdapter
        '
        Me.SuplierTableAdapter.ClearBeforeFill = True
        '
        'Formpemasok
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
        Me.Controls.Add(Me.BtnSimpanPemasok)
        Me.Controls.Add(Me.GrupTambahPemasok)
        Me.Controls.Add(Me.LbDataPemasok)
        Me.Controls.Add(Me.DGVPemasok)
        Me.Controls.Add(Me.Tab)
        Me.Name = "Formpemasok"
        Me.Text = "Master Pemasok "
        Me.Tab.ResumeLayout(False)
        Me.TabMaster.ResumeLayout(False)
        Me.TabTransaksi.ResumeLayout(False)
        Me.TabLaporan.ResumeLayout(False)
        Me.TabPengaturan.ResumeLayout(False)
        CType(Me.DGVPemasok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbUASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupTambahPemasok.ResumeLayout(False)
        Me.GrupTambahPemasok.PerformLayout()
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
    Friend WithEvents DGVPemasok As System.Windows.Forms.DataGridView
    Friend WithEvents LbDataPemasok As System.Windows.Forms.Label
    Friend WithEvents GrupTambahPemasok As System.Windows.Forms.GroupBox
    Friend WithEvents TBTeleponPemasok As System.Windows.Forms.TextBox
    Friend WithEvents TBAlamatPemasok As System.Windows.Forms.TextBox
    Friend WithEvents TbNamaPemasok As System.Windows.Forms.TextBox
    Friend WithEvents LbTeleponPemasok As System.Windows.Forms.Label
    Friend WithEvents LbAlamatPemasok As System.Windows.Forms.Label
    Friend WithEvents LbNamaPemasok As System.Windows.Forms.Label
    Friend WithEvents LbIdPemasok As System.Windows.Forms.Label
    Friend WithEvents BtnAmbil As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnSimpanPemasok As System.Windows.Forms.Button
    Friend WithEvents LbMotivasi As System.Windows.Forms.Label
    Friend WithEvents LbJudul As System.Windows.Forms.Label
    Friend WithEvents DbUASDataSet As WindowsApplication1.DbUASDataSet
    Friend WithEvents SuplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SuplierTableAdapter As WindowsApplication1.DbUASDataSetTableAdapters.suplierTableAdapter
    Friend WithEvents IdsuplierDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamasuplierDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoteleponDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LbisiId As System.Windows.Forms.Label
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
End Class
