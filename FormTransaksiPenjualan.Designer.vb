<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPenjualan))
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
        Me.GrupInputPenjualan = New System.Windows.Forms.GroupBox()
        Me.LbIsiTotal = New System.Windows.Forms.Label()
        Me.LbIsiDiskon = New System.Windows.Forms.Label()
        Me.LbIsiHarga = New System.Windows.Forms.Label()
        Me.LbIsiNomor = New System.Windows.Forms.Label()
        Me.LbDiskon = New System.Windows.Forms.Label()
        Me.LbTotal = New System.Windows.Forms.Label()
        Me.TbJmlh = New System.Windows.Forms.TextBox()
        Me.TbKodeBukuJual = New System.Windows.Forms.TextBox()
        Me.LbJumlah = New System.Windows.Forms.Label()
        Me.LbIdMemberJual = New System.Windows.Forms.Label()
        Me.TbIdMbrJual = New System.Windows.Forms.TextBox()
        Me.TbIdUserJual = New System.Windows.Forms.TextBox()
        Me.DTPTglJual = New System.Windows.Forms.DateTimePicker()
        Me.LbHargaJual = New System.Windows.Forms.Label()
        Me.LbKodeBukuJual = New System.Windows.Forms.Label()
        Me.LbIdUserJual = New System.Windows.Forms.Label()
        Me.LbTglJual = New System.Windows.Forms.Label()
        Me.LbNoNota = New System.Windows.Forms.Label()
        Me.DatapenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbUASDataSet = New WindowsApplication1.DbUASDataSet()
        Me.BtnSimpanJual = New System.Windows.Forms.Button()
        Me.BtnAmbilJual = New System.Windows.Forms.Button()
        Me.BtnUbahJual = New System.Windows.Forms.Button()
        Me.BtnHapusJual = New System.Windows.Forms.Button()
        Me.LbDataJual = New System.Windows.Forms.Label()
        Me.Data_penjualanTableAdapter = New WindowsApplication1.DbUASDataSetTableAdapters.data_penjualanTableAdapter()
        Me.LbBayar = New System.Windows.Forms.Label()
        Me.LbKembali = New System.Windows.Forms.Label()
        Me.GrupPenjualan = New System.Windows.Forms.GroupBox()
        Me.BtnNota = New System.Windows.Forms.Button()
        Me.TbKembali = New System.Windows.Forms.TextBox()
        Me.TbBayar = New System.Windows.Forms.TextBox()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.total_biaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_jual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode_buku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_member = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal_jual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_nota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVPenjualan = New System.Windows.Forms.DataGridView()
        Me.LbKasir = New System.Windows.Forms.Label()
        Me.LbNamaKasir = New System.Windows.Forms.Label()
        Me.CrNota = New AxCrystal.AxCrystalReport()
        Me.Tab.SuspendLayout()
        Me.TabMaster.SuspendLayout()
        Me.TabTransaksi.SuspendLayout()
        Me.TabLaporan.SuspendLayout()
        Me.TabPengaturan.SuspendLayout()
        Me.GrupInputPenjualan.SuspendLayout()
        CType(Me.DatapenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbUASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupPenjualan.SuspendLayout()
        CType(Me.DGVPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CrNota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tab
        '
        Me.Tab.Controls.Add(Me.TabMaster)
        Me.Tab.Controls.Add(Me.TabTransaksi)
        Me.Tab.Controls.Add(Me.TabLaporan)
        Me.Tab.Controls.Add(Me.TabPengaturan)
        Me.Tab.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab.Location = New System.Drawing.Point(-1, -2)
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
        'GrupInputPenjualan
        '
        Me.GrupInputPenjualan.BackColor = System.Drawing.Color.Transparent
        Me.GrupInputPenjualan.Controls.Add(Me.LbIsiTotal)
        Me.GrupInputPenjualan.Controls.Add(Me.LbIsiDiskon)
        Me.GrupInputPenjualan.Controls.Add(Me.LbIsiHarga)
        Me.GrupInputPenjualan.Controls.Add(Me.LbIsiNomor)
        Me.GrupInputPenjualan.Controls.Add(Me.LbDiskon)
        Me.GrupInputPenjualan.Controls.Add(Me.LbTotal)
        Me.GrupInputPenjualan.Controls.Add(Me.TbJmlh)
        Me.GrupInputPenjualan.Controls.Add(Me.TbKodeBukuJual)
        Me.GrupInputPenjualan.Controls.Add(Me.LbJumlah)
        Me.GrupInputPenjualan.Controls.Add(Me.LbIdMemberJual)
        Me.GrupInputPenjualan.Controls.Add(Me.TbIdMbrJual)
        Me.GrupInputPenjualan.Controls.Add(Me.TbIdUserJual)
        Me.GrupInputPenjualan.Controls.Add(Me.DTPTglJual)
        Me.GrupInputPenjualan.Controls.Add(Me.LbHargaJual)
        Me.GrupInputPenjualan.Controls.Add(Me.LbKodeBukuJual)
        Me.GrupInputPenjualan.Controls.Add(Me.LbIdUserJual)
        Me.GrupInputPenjualan.Controls.Add(Me.LbTglJual)
        Me.GrupInputPenjualan.Controls.Add(Me.LbNoNota)
        Me.GrupInputPenjualan.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupInputPenjualan.Location = New System.Drawing.Point(552, 118)
        Me.GrupInputPenjualan.Name = "GrupInputPenjualan"
        Me.GrupInputPenjualan.Size = New System.Drawing.Size(293, 308)
        Me.GrupInputPenjualan.TabIndex = 4
        Me.GrupInputPenjualan.TabStop = False
        Me.GrupInputPenjualan.Text = "Tambah Penjualan"
        '
        'LbIsiTotal
        '
        Me.LbIsiTotal.AutoSize = True
        Me.LbIsiTotal.Location = New System.Drawing.Point(105, 279)
        Me.LbIsiTotal.Name = "LbIsiTotal"
        Me.LbIsiTotal.Size = New System.Drawing.Size(0, 18)
        Me.LbIsiTotal.TabIndex = 26
        '
        'LbIsiDiskon
        '
        Me.LbIsiDiskon.AutoSize = True
        Me.LbIsiDiskon.Location = New System.Drawing.Point(100, 218)
        Me.LbIsiDiskon.Name = "LbIsiDiskon"
        Me.LbIsiDiskon.Size = New System.Drawing.Size(0, 18)
        Me.LbIsiDiskon.TabIndex = 25
        '
        'LbIsiHarga
        '
        Me.LbIsiHarga.AutoSize = True
        Me.LbIsiHarga.Location = New System.Drawing.Point(100, 188)
        Me.LbIsiHarga.Name = "LbIsiHarga"
        Me.LbIsiHarga.Size = New System.Drawing.Size(0, 18)
        Me.LbIsiHarga.TabIndex = 24
        '
        'LbIsiNomor
        '
        Me.LbIsiNomor.AutoSize = True
        Me.LbIsiNomor.Location = New System.Drawing.Point(100, 31)
        Me.LbIsiNomor.Name = "LbIsiNomor"
        Me.LbIsiNomor.Size = New System.Drawing.Size(0, 18)
        Me.LbIsiNomor.TabIndex = 23
        '
        'LbDiskon
        '
        Me.LbDiskon.AutoSize = True
        Me.LbDiskon.Location = New System.Drawing.Point(8, 218)
        Me.LbDiskon.Name = "LbDiskon"
        Me.LbDiskon.Size = New System.Drawing.Size(48, 18)
        Me.LbDiskon.TabIndex = 22
        Me.LbDiskon.Text = "Diskon"
        '
        'LbTotal
        '
        Me.LbTotal.AutoSize = True
        Me.LbTotal.Location = New System.Drawing.Point(9, 279)
        Me.LbTotal.Name = "LbTotal"
        Me.LbTotal.Size = New System.Drawing.Size(40, 18)
        Me.LbTotal.TabIndex = 19
        Me.LbTotal.Text = "Total"
        '
        'TbJmlh
        '
        Me.TbJmlh.Location = New System.Drawing.Point(103, 246)
        Me.TbJmlh.Name = "TbJmlh"
        Me.TbJmlh.Size = New System.Drawing.Size(183, 26)
        Me.TbJmlh.TabIndex = 18
        '
        'TbKodeBukuJual
        '
        Me.TbKodeBukuJual.Location = New System.Drawing.Point(103, 151)
        Me.TbKodeBukuJual.Name = "TbKodeBukuJual"
        Me.TbKodeBukuJual.Size = New System.Drawing.Size(183, 26)
        Me.TbKodeBukuJual.TabIndex = 15
        '
        'LbJumlah
        '
        Me.LbJumlah.AutoSize = True
        Me.LbJumlah.Location = New System.Drawing.Point(8, 248)
        Me.LbJumlah.Name = "LbJumlah"
        Me.LbJumlah.Size = New System.Drawing.Size(55, 18)
        Me.LbJumlah.TabIndex = 17
        Me.LbJumlah.Text = "Jumlah "
        '
        'LbIdMemberJual
        '
        Me.LbIdMemberJual.AutoSize = True
        Me.LbIdMemberJual.Location = New System.Drawing.Point(7, 123)
        Me.LbIdMemberJual.Name = "LbIdMemberJual"
        Me.LbIdMemberJual.Size = New System.Drawing.Size(87, 18)
        Me.LbIdMemberJual.TabIndex = 14
        Me.LbIdMemberJual.Text = "Id Pelanggan"
        '
        'TbIdMbrJual
        '
        Me.TbIdMbrJual.Location = New System.Drawing.Point(103, 120)
        Me.TbIdMbrJual.Name = "TbIdMbrJual"
        Me.TbIdMbrJual.Size = New System.Drawing.Size(183, 26)
        Me.TbIdMbrJual.TabIndex = 13
        '
        'TbIdUserJual
        '
        Me.TbIdUserJual.Location = New System.Drawing.Point(103, 89)
        Me.TbIdUserJual.Name = "TbIdUserJual"
        Me.TbIdUserJual.Size = New System.Drawing.Size(183, 26)
        Me.TbIdUserJual.TabIndex = 12
        '
        'DTPTglJual
        '
        Me.DTPTglJual.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPTglJual.Location = New System.Drawing.Point(103, 58)
        Me.DTPTglJual.Name = "DTPTglJual"
        Me.DTPTglJual.Size = New System.Drawing.Size(183, 26)
        Me.DTPTglJual.TabIndex = 11
        '
        'LbHargaJual
        '
        Me.LbHargaJual.AutoSize = True
        Me.LbHargaJual.Location = New System.Drawing.Point(6, 188)
        Me.LbHargaJual.Name = "LbHargaJual"
        Me.LbHargaJual.Size = New System.Drawing.Size(95, 18)
        Me.LbHargaJual.TabIndex = 5
        Me.LbHargaJual.Text = "Harga Satuan "
        '
        'LbKodeBukuJual
        '
        Me.LbKodeBukuJual.AutoSize = True
        Me.LbKodeBukuJual.Location = New System.Drawing.Point(6, 155)
        Me.LbKodeBukuJual.Name = "LbKodeBukuJual"
        Me.LbKodeBukuJual.Size = New System.Drawing.Size(75, 18)
        Me.LbKodeBukuJual.TabIndex = 4
        Me.LbKodeBukuJual.Text = "Kode Buku "
        '
        'LbIdUserJual
        '
        Me.LbIdUserJual.AutoSize = True
        Me.LbIdUserJual.Location = New System.Drawing.Point(6, 92)
        Me.LbIdUserJual.Name = "LbIdUserJual"
        Me.LbIdUserJual.Size = New System.Drawing.Size(83, 18)
        Me.LbIdUserJual.TabIndex = 2
        Me.LbIdUserJual.Text = "Id Pengguna"
        '
        'LbTglJual
        '
        Me.LbTglJual.AutoSize = True
        Me.LbTglJual.Location = New System.Drawing.Point(6, 61)
        Me.LbTglJual.Name = "LbTglJual"
        Me.LbTglJual.Size = New System.Drawing.Size(60, 18)
        Me.LbTglJual.TabIndex = 1
        Me.LbTglJual.Text = "Tanggal "
        '
        'LbNoNota
        '
        Me.LbNoNota.AutoSize = True
        Me.LbNoNota.Location = New System.Drawing.Point(6, 31)
        Me.LbNoNota.Name = "LbNoNota"
        Me.LbNoNota.Size = New System.Drawing.Size(65, 18)
        Me.LbNoNota.TabIndex = 0
        Me.LbNoNota.Text = "No. Nota "
        '
        'DatapenjualanBindingSource
        '
        Me.DatapenjualanBindingSource.DataMember = "data_penjualan"
        Me.DatapenjualanBindingSource.DataSource = Me.DbUASDataSet
        '
        'DbUASDataSet
        '
        Me.DbUASDataSet.DataSetName = "DbUASDataSet"
        Me.DbUASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnSimpanJual
        '
        Me.BtnSimpanJual.BackColor = System.Drawing.Color.Orange
        Me.BtnSimpanJual.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpanJual.Location = New System.Drawing.Point(660, 431)
        Me.BtnSimpanJual.Name = "BtnSimpanJual"
        Me.BtnSimpanJual.Size = New System.Drawing.Size(80, 31)
        Me.BtnSimpanJual.TabIndex = 10
        Me.BtnSimpanJual.Text = "Simpan"
        Me.BtnSimpanJual.UseVisualStyleBackColor = False
        '
        'BtnAmbilJual
        '
        Me.BtnAmbilJual.BackColor = System.Drawing.Color.Orange
        Me.BtnAmbilJual.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAmbilJual.Location = New System.Drawing.Point(758, 431)
        Me.BtnAmbilJual.Name = "BtnAmbilJual"
        Me.BtnAmbilJual.Size = New System.Drawing.Size(80, 31)
        Me.BtnAmbilJual.TabIndex = 11
        Me.BtnAmbilJual.Text = "Ambil Data"
        Me.BtnAmbilJual.UseVisualStyleBackColor = False
        '
        'BtnUbahJual
        '
        Me.BtnUbahJual.BackColor = System.Drawing.Color.Gold
        Me.BtnUbahJual.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUbahJual.Location = New System.Drawing.Point(611, 462)
        Me.BtnUbahJual.Name = "BtnUbahJual"
        Me.BtnUbahJual.Size = New System.Drawing.Size(80, 31)
        Me.BtnUbahJual.TabIndex = 12
        Me.BtnUbahJual.Text = "Ubah "
        Me.BtnUbahJual.UseVisualStyleBackColor = False
        '
        'BtnHapusJual
        '
        Me.BtnHapusJual.BackColor = System.Drawing.Color.Gold
        Me.BtnHapusJual.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusJual.Location = New System.Drawing.Point(716, 462)
        Me.BtnHapusJual.Name = "BtnHapusJual"
        Me.BtnHapusJual.Size = New System.Drawing.Size(80, 31)
        Me.BtnHapusJual.TabIndex = 13
        Me.BtnHapusJual.Text = "Hapus"
        Me.BtnHapusJual.UseVisualStyleBackColor = False
        '
        'LbDataJual
        '
        Me.LbDataJual.AutoSize = True
        Me.LbDataJual.BackColor = System.Drawing.Color.Transparent
        Me.LbDataJual.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDataJual.Location = New System.Drawing.Point(12, 113)
        Me.LbDataJual.Name = "LbDataJual"
        Me.LbDataJual.Size = New System.Drawing.Size(191, 21)
        Me.LbDataJual.TabIndex = 14
        Me.LbDataJual.Text = "Data Transaksi Penjualan"
        '
        'Data_penjualanTableAdapter
        '
        Me.Data_penjualanTableAdapter.ClearBeforeFill = True
        '
        'LbBayar
        '
        Me.LbBayar.AutoSize = True
        Me.LbBayar.Location = New System.Drawing.Point(25, 21)
        Me.LbBayar.Name = "LbBayar"
        Me.LbBayar.Size = New System.Drawing.Size(49, 20)
        Me.LbBayar.TabIndex = 0
        Me.LbBayar.Text = "Bayar"
        '
        'LbKembali
        '
        Me.LbKembali.AutoSize = True
        Me.LbKembali.Location = New System.Drawing.Point(240, 21)
        Me.LbKembali.Name = "LbKembali"
        Me.LbKembali.Size = New System.Drawing.Size(78, 20)
        Me.LbKembali.TabIndex = 1
        Me.LbKembali.Text = "Kembalian"
        '
        'GrupPenjualan
        '
        Me.GrupPenjualan.BackColor = System.Drawing.Color.Orange
        Me.GrupPenjualan.Controls.Add(Me.CrNota)
        Me.GrupPenjualan.Controls.Add(Me.LbNamaKasir)
        Me.GrupPenjualan.Controls.Add(Me.LbKasir)
        Me.GrupPenjualan.Controls.Add(Me.BtnNota)
        Me.GrupPenjualan.Controls.Add(Me.TbKembali)
        Me.GrupPenjualan.Controls.Add(Me.TbBayar)
        Me.GrupPenjualan.Controls.Add(Me.LbKembali)
        Me.GrupPenjualan.Controls.Add(Me.LbBayar)
        Me.GrupPenjualan.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupPenjualan.Location = New System.Drawing.Point(0, 495)
        Me.GrupPenjualan.Name = "GrupPenjualan"
        Me.GrupPenjualan.Size = New System.Drawing.Size(877, 96)
        Me.GrupPenjualan.TabIndex = 0
        Me.GrupPenjualan.TabStop = False
        Me.GrupPenjualan.Text = "Transaksi Penjualan"
        '
        'BtnNota
        '
        Me.BtnNota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNota.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNota.Image = CType(resources.GetObject("BtnNota.Image"), System.Drawing.Image)
        Me.BtnNota.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNota.Location = New System.Drawing.Point(769, 13)
        Me.BtnNota.Name = "BtnNota"
        Me.BtnNota.Size = New System.Drawing.Size(77, 78)
        Me.BtnNota.TabIndex = 5
        Me.BtnNota.Text = "Cetak Nota"
        Me.BtnNota.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNota.UseVisualStyleBackColor = True
        '
        'TbKembali
        '
        Me.TbKembali.BackColor = System.Drawing.Color.Black
        Me.TbKembali.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbKembali.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TbKembali.Location = New System.Drawing.Point(244, 41)
        Me.TbKembali.Multiline = True
        Me.TbKembali.Name = "TbKembali"
        Me.TbKembali.ReadOnly = True
        Me.TbKembali.Size = New System.Drawing.Size(171, 43)
        Me.TbKembali.TabIndex = 3
        Me.TbKembali.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbBayar
        '
        Me.TbBayar.BackColor = System.Drawing.Color.Black
        Me.TbBayar.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbBayar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TbBayar.Location = New System.Drawing.Point(29, 40)
        Me.TbBayar.Multiline = True
        Me.TbBayar.Name = "TbBayar"
        Me.TbBayar.Size = New System.Drawing.Size(167, 44)
        Me.TbBayar.TabIndex = 2
        Me.TbBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.Orange
        Me.BtnTambah.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Location = New System.Drawing.Point(561, 431)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(80, 31)
        Me.BtnTambah.TabIndex = 15
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'total_biaya
        '
        Me.total_biaya.HeaderText = "total_biaya"
        Me.total_biaya.Name = "total_biaya"
        '
        'jumlah_buku
        '
        Me.jumlah_buku.HeaderText = "jumlah_buku"
        Me.jumlah_buku.Name = "jumlah_buku"
        '
        'harga_jual
        '
        Me.harga_jual.HeaderText = "harga_jual"
        Me.harga_jual.Name = "harga_jual"
        '
        'kode_buku
        '
        Me.kode_buku.HeaderText = "kode_buku"
        Me.kode_buku.Name = "kode_buku"
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
        'tanggal_jual
        '
        Me.tanggal_jual.HeaderText = "tanggal_jual"
        Me.tanggal_jual.Name = "tanggal_jual"
        '
        'no_nota
        '
        Me.no_nota.HeaderText = "no_nota"
        Me.no_nota.Name = "no_nota"
        '
        'DGVPenjualan
        '
        Me.DGVPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPenjualan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no_nota, Me.tanggal_jual, Me.id_user, Me.id_member, Me.kode_buku, Me.harga_jual, Me.jumlah_buku, Me.total_biaya})
        Me.DGVPenjualan.Location = New System.Drawing.Point(14, 137)
        Me.DGVPenjualan.Name = "DGVPenjualan"
        Me.DGVPenjualan.Size = New System.Drawing.Size(520, 289)
        Me.DGVPenjualan.TabIndex = 5
        '
        'LbKasir
        '
        Me.LbKasir.AutoSize = True
        Me.LbKasir.Location = New System.Drawing.Point(454, 24)
        Me.LbKasir.Name = "LbKasir"
        Me.LbKasir.Size = New System.Drawing.Size(52, 20)
        Me.LbKasir.TabIndex = 6
        Me.LbKasir.Text = "Kasir :"
        '
        'LbNamaKasir
        '
        Me.LbNamaKasir.AutoSize = True
        Me.LbNamaKasir.Location = New System.Drawing.Point(512, 24)
        Me.LbNamaKasir.Name = "LbNamaKasir"
        Me.LbNamaKasir.Size = New System.Drawing.Size(0, 20)
        Me.LbNamaKasir.TabIndex = 7
        '
        'CrNota
        '
        Me.CrNota.Enabled = True
        Me.CrNota.Location = New System.Drawing.Point(733, 60)
        Me.CrNota.Name = "CrNota"
        Me.CrNota.OcxState = CType(resources.GetObject("CrNota.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CrNota.Size = New System.Drawing.Size(28, 28)
        Me.CrNota.TabIndex = 8
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(875, 592)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.GrupPenjualan)
        Me.Controls.Add(Me.LbDataJual)
        Me.Controls.Add(Me.BtnHapusJual)
        Me.Controls.Add(Me.BtnUbahJual)
        Me.Controls.Add(Me.BtnAmbilJual)
        Me.Controls.Add(Me.BtnSimpanJual)
        Me.Controls.Add(Me.DGVPenjualan)
        Me.Controls.Add(Me.GrupInputPenjualan)
        Me.Controls.Add(Me.Tab)
        Me.Name = "FormPenjualan"
        Me.Text = "Transaksi Penjualan"
        Me.Tab.ResumeLayout(False)
        Me.TabMaster.ResumeLayout(False)
        Me.TabTransaksi.ResumeLayout(False)
        Me.TabLaporan.ResumeLayout(False)
        Me.TabPengaturan.ResumeLayout(False)
        Me.GrupInputPenjualan.ResumeLayout(False)
        Me.GrupInputPenjualan.PerformLayout()
        CType(Me.DatapenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbUASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupPenjualan.ResumeLayout(False)
        Me.GrupPenjualan.PerformLayout()
        CType(Me.DGVPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CrNota, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GrupInputPenjualan As System.Windows.Forms.GroupBox
    Friend WithEvents LbHargaJual As System.Windows.Forms.Label
    Friend WithEvents LbKodeBukuJual As System.Windows.Forms.Label
    Friend WithEvents LbIdUserJual As System.Windows.Forms.Label
    Friend WithEvents LbTglJual As System.Windows.Forms.Label
    Friend WithEvents DTPTglJual As System.Windows.Forms.DateTimePicker
    Friend WithEvents TbIdUserJual As System.Windows.Forms.TextBox
    Friend WithEvents TbIdMbrJual As System.Windows.Forms.TextBox
    Friend WithEvents LbIdMemberJual As System.Windows.Forms.Label
    Friend WithEvents TbKodeBukuJual As System.Windows.Forms.TextBox
    Friend WithEvents TbJmlh As System.Windows.Forms.TextBox
    Friend WithEvents LbJumlah As System.Windows.Forms.Label
    Friend WithEvents BtnSimpanJual As System.Windows.Forms.Button
    Friend WithEvents BtnAmbilJual As System.Windows.Forms.Button
    Friend WithEvents BtnUbahJual As System.Windows.Forms.Button
    Friend WithEvents BtnHapusJual As System.Windows.Forms.Button
    Friend WithEvents LbDataJual As System.Windows.Forms.Label
    Friend WithEvents DbUASDataSet As WindowsApplication1.DbUASDataSet
    Friend WithEvents DatapenjualanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Data_penjualanTableAdapter As WindowsApplication1.DbUASDataSetTableAdapters.data_penjualanTableAdapter
    Friend WithEvents LbTotal As System.Windows.Forms.Label
    Friend WithEvents LbDiskon As System.Windows.Forms.Label
    Friend WithEvents GrupPenjualan As System.Windows.Forms.GroupBox
    Friend WithEvents LbBayar As System.Windows.Forms.Label
    Friend WithEvents LbKembali As System.Windows.Forms.Label
    Friend WithEvents TbKembali As System.Windows.Forms.TextBox
    Friend WithEvents TbBayar As System.Windows.Forms.TextBox
    Friend WithEvents BtnNota As System.Windows.Forms.Button
    Friend WithEvents LbNoNota As System.Windows.Forms.Label
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents total_biaya As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah_buku As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga_jual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kode_buku As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_member As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_user As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tanggal_jual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents no_nota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGVPenjualan As System.Windows.Forms.DataGridView
    Friend WithEvents LbIsiNomor As System.Windows.Forms.Label
    Friend WithEvents LbIsiHarga As System.Windows.Forms.Label
    Friend WithEvents LbIsiDiskon As System.Windows.Forms.Label
    Friend WithEvents LbIsiTotal As System.Windows.Forms.Label
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents LbNamaKasir As System.Windows.Forms.Label
    Friend WithEvents LbKasir As System.Windows.Forms.Label
    Friend WithEvents CrNota As AxCrystal.AxCrystalReport
End Class
