<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUser))
        Me.DGVUser = New System.Windows.Forms.DataGridView()
        Me.IduserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamauserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JabatanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JeniskelaminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteleponDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbUASDataSet = New WindowsApplication1.DbUASDataSet()
        Me.UserTableAdapter = New WindowsApplication1.DbUASDataSetTableAdapters.userTableAdapter()
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
        Me.LbDataUser = New System.Windows.Forms.Label()
        Me.GrupTambahUser = New System.Windows.Forms.GroupBox()
        Me.TBTeleponUser = New System.Windows.Forms.TextBox()
        Me.CBGenderUser = New System.Windows.Forms.ComboBox()
        Me.TBAlamatUser = New System.Windows.Forms.TextBox()
        Me.CBJabatanUser = New System.Windows.Forms.ComboBox()
        Me.TBNamaUser = New System.Windows.Forms.TextBox()
        Me.TBIdUser = New System.Windows.Forms.TextBox()
        Me.LbTeleponUser = New System.Windows.Forms.Label()
        Me.LbGenderUser = New System.Windows.Forms.Label()
        Me.LbAlamatUser = New System.Windows.Forms.Label()
        Me.LbJabatanUser = New System.Windows.Forms.Label()
        Me.LbNamaUser = New System.Windows.Forms.Label()
        Me.LbIdUser = New System.Windows.Forms.Label()
        Me.BtnSimpanUser = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.LbJudul = New System.Windows.Forms.Label()
        Me.LbMotivasi = New System.Windows.Forms.Label()
        Me.BtnAmbil = New System.Windows.Forms.Button()
        CType(Me.DGVUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbUASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab.SuspendLayout()
        Me.TabMaster.SuspendLayout()
        Me.TabTransaksi.SuspendLayout()
        Me.TabLaporan.SuspendLayout()
        Me.TabPengaturan.SuspendLayout()
        Me.GrupTambahUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVUser
        '
        Me.DGVUser.AutoGenerateColumns = False
        Me.DGVUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IduserDataGridViewTextBoxColumn, Me.NamauserDataGridViewTextBoxColumn, Me.JabatanDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.JeniskelaminDataGridViewTextBoxColumn, Me.NoteleponDataGridViewTextBoxColumn})
        Me.DGVUser.DataSource = Me.UserBindingSource
        Me.DGVUser.Location = New System.Drawing.Point(25, 140)
        Me.DGVUser.Name = "DGVUser"
        Me.DGVUser.Size = New System.Drawing.Size(498, 286)
        Me.DGVUser.TabIndex = 0
        '
        'IduserDataGridViewTextBoxColumn
        '
        Me.IduserDataGridViewTextBoxColumn.DataPropertyName = "id_user"
        Me.IduserDataGridViewTextBoxColumn.HeaderText = "id_user"
        Me.IduserDataGridViewTextBoxColumn.Name = "IduserDataGridViewTextBoxColumn"
        '
        'NamauserDataGridViewTextBoxColumn
        '
        Me.NamauserDataGridViewTextBoxColumn.DataPropertyName = "nama_user"
        Me.NamauserDataGridViewTextBoxColumn.HeaderText = "nama_user"
        Me.NamauserDataGridViewTextBoxColumn.Name = "NamauserDataGridViewTextBoxColumn"
        '
        'JabatanDataGridViewTextBoxColumn
        '
        Me.JabatanDataGridViewTextBoxColumn.DataPropertyName = "jabatan"
        Me.JabatanDataGridViewTextBoxColumn.HeaderText = "jabatan"
        Me.JabatanDataGridViewTextBoxColumn.Name = "JabatanDataGridViewTextBoxColumn"
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        '
        'JeniskelaminDataGridViewTextBoxColumn
        '
        Me.JeniskelaminDataGridViewTextBoxColumn.DataPropertyName = "jenis_kelamin"
        Me.JeniskelaminDataGridViewTextBoxColumn.HeaderText = "jenis_kelamin"
        Me.JeniskelaminDataGridViewTextBoxColumn.Name = "JeniskelaminDataGridViewTextBoxColumn"
        '
        'NoteleponDataGridViewTextBoxColumn
        '
        Me.NoteleponDataGridViewTextBoxColumn.DataPropertyName = "no_telepon"
        Me.NoteleponDataGridViewTextBoxColumn.HeaderText = "no_telepon"
        Me.NoteleponDataGridViewTextBoxColumn.Name = "NoteleponDataGridViewTextBoxColumn"
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "user"
        Me.UserBindingSource.DataSource = Me.DbUASDataSet
        '
        'DbUASDataSet
        '
        Me.DbUASDataSet.DataSetName = "DbUASDataSet"
        Me.DbUASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'Tab
        '
        Me.Tab.Controls.Add(Me.TabMaster)
        Me.Tab.Controls.Add(Me.TabTransaksi)
        Me.Tab.Controls.Add(Me.TabLaporan)
        Me.Tab.Controls.Add(Me.TabPengaturan)
        Me.Tab.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab.Location = New System.Drawing.Point(-1, 0)
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(882, 114)
        Me.Tab.TabIndex = 1
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
        Me.BtnInfo.Text = "Info Operator" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnInfo.UseVisualStyleBackColor = True
        '
        'LbDataUser
        '
        Me.LbDataUser.AutoSize = True
        Me.LbDataUser.BackColor = System.Drawing.Color.Transparent
        Me.LbDataUser.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDataUser.Location = New System.Drawing.Point(23, 117)
        Me.LbDataUser.Name = "LbDataUser"
        Me.LbDataUser.Size = New System.Drawing.Size(115, 21)
        Me.LbDataUser.TabIndex = 2
        Me.LbDataUser.Text = "Data Pengguna"
        '
        'GrupTambahUser
        '
        Me.GrupTambahUser.BackColor = System.Drawing.Color.Transparent
        Me.GrupTambahUser.Controls.Add(Me.TBTeleponUser)
        Me.GrupTambahUser.Controls.Add(Me.CBGenderUser)
        Me.GrupTambahUser.Controls.Add(Me.TBAlamatUser)
        Me.GrupTambahUser.Controls.Add(Me.CBJabatanUser)
        Me.GrupTambahUser.Controls.Add(Me.TBNamaUser)
        Me.GrupTambahUser.Controls.Add(Me.TBIdUser)
        Me.GrupTambahUser.Controls.Add(Me.LbTeleponUser)
        Me.GrupTambahUser.Controls.Add(Me.LbGenderUser)
        Me.GrupTambahUser.Controls.Add(Me.LbAlamatUser)
        Me.GrupTambahUser.Controls.Add(Me.LbJabatanUser)
        Me.GrupTambahUser.Controls.Add(Me.LbNamaUser)
        Me.GrupTambahUser.Controls.Add(Me.LbIdUser)
        Me.GrupTambahUser.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupTambahUser.Location = New System.Drawing.Point(551, 132)
        Me.GrupTambahUser.Name = "GrupTambahUser"
        Me.GrupTambahUser.Size = New System.Drawing.Size(293, 257)
        Me.GrupTambahUser.TabIndex = 3
        Me.GrupTambahUser.TabStop = False
        Me.GrupTambahUser.Text = "Tambah Pengguna"
        '
        'TBTeleponUser
        '
        Me.TBTeleponUser.Location = New System.Drawing.Point(103, 214)
        Me.TBTeleponUser.Name = "TBTeleponUser"
        Me.TBTeleponUser.Size = New System.Drawing.Size(183, 26)
        Me.TBTeleponUser.TabIndex = 10
        '
        'CBGenderUser
        '
        Me.CBGenderUser.FormattingEnabled = True
        Me.CBGenderUser.Items.AddRange(New Object() {"wanita", "pria"})
        Me.CBGenderUser.Location = New System.Drawing.Point(103, 182)
        Me.CBGenderUser.Name = "CBGenderUser"
        Me.CBGenderUser.Size = New System.Drawing.Size(183, 26)
        Me.CBGenderUser.TabIndex = 9
        '
        'TBAlamatUser
        '
        Me.TBAlamatUser.Location = New System.Drawing.Point(103, 131)
        Me.TBAlamatUser.Multiline = True
        Me.TBAlamatUser.Name = "TBAlamatUser"
        Me.TBAlamatUser.Size = New System.Drawing.Size(183, 45)
        Me.TBAlamatUser.TabIndex = 8
        '
        'CBJabatanUser
        '
        Me.CBJabatanUser.FormattingEnabled = True
        Me.CBJabatanUser.Items.AddRange(New Object() {"super_admin", "admin", "kasir", "warehouse", "manajer"})
        Me.CBJabatanUser.Location = New System.Drawing.Point(103, 99)
        Me.CBJabatanUser.Name = "CBJabatanUser"
        Me.CBJabatanUser.Size = New System.Drawing.Size(183, 26)
        Me.CBJabatanUser.TabIndex = 4
        '
        'TBNamaUser
        '
        Me.TBNamaUser.Location = New System.Drawing.Point(103, 67)
        Me.TBNamaUser.Name = "TBNamaUser"
        Me.TBNamaUser.Size = New System.Drawing.Size(183, 26)
        Me.TBNamaUser.TabIndex = 7
        '
        'TBIdUser
        '
        Me.TBIdUser.Location = New System.Drawing.Point(103, 35)
        Me.TBIdUser.Name = "TBIdUser"
        Me.TBIdUser.Size = New System.Drawing.Size(183, 26)
        Me.TBIdUser.TabIndex = 6
        '
        'LbTeleponUser
        '
        Me.LbTeleponUser.AutoSize = True
        Me.LbTeleponUser.Location = New System.Drawing.Point(6, 217)
        Me.LbTeleponUser.Name = "LbTeleponUser"
        Me.LbTeleponUser.Size = New System.Drawing.Size(84, 18)
        Me.LbTeleponUser.TabIndex = 5
        Me.LbTeleponUser.Text = "No. Telepon "
        '
        'LbGenderUser
        '
        Me.LbGenderUser.AutoSize = True
        Me.LbGenderUser.Location = New System.Drawing.Point(6, 185)
        Me.LbGenderUser.Name = "LbGenderUser"
        Me.LbGenderUser.Size = New System.Drawing.Size(95, 18)
        Me.LbGenderUser.TabIndex = 4
        Me.LbGenderUser.Text = "Jenis Kelamin "
        '
        'LbAlamatUser
        '
        Me.LbAlamatUser.AutoSize = True
        Me.LbAlamatUser.Location = New System.Drawing.Point(6, 135)
        Me.LbAlamatUser.Name = "LbAlamatUser"
        Me.LbAlamatUser.Size = New System.Drawing.Size(49, 18)
        Me.LbAlamatUser.TabIndex = 3
        Me.LbAlamatUser.Text = "Alamat"
        '
        'LbJabatanUser
        '
        Me.LbJabatanUser.AutoSize = True
        Me.LbJabatanUser.Location = New System.Drawing.Point(6, 102)
        Me.LbJabatanUser.Name = "LbJabatanUser"
        Me.LbJabatanUser.Size = New System.Drawing.Size(58, 18)
        Me.LbJabatanUser.TabIndex = 2
        Me.LbJabatanUser.Text = "Jabatan"
        '
        'LbNamaUser
        '
        Me.LbNamaUser.AutoSize = True
        Me.LbNamaUser.Location = New System.Drawing.Point(6, 70)
        Me.LbNamaUser.Name = "LbNamaUser"
        Me.LbNamaUser.Size = New System.Drawing.Size(101, 18)
        Me.LbNamaUser.TabIndex = 1
        Me.LbNamaUser.Text = "Nama Pengguna"
        '
        'LbIdUser
        '
        Me.LbIdUser.AutoSize = True
        Me.LbIdUser.Location = New System.Drawing.Point(6, 38)
        Me.LbIdUser.Name = "LbIdUser"
        Me.LbIdUser.Size = New System.Drawing.Size(83, 18)
        Me.LbIdUser.TabIndex = 0
        Me.LbIdUser.Text = "Id Pengguna"
        '
        'BtnSimpanUser
        '
        Me.BtnSimpanUser.BackColor = System.Drawing.Color.Gold
        Me.BtnSimpanUser.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpanUser.Location = New System.Drawing.Point(533, 395)
        Me.BtnSimpanUser.Name = "BtnSimpanUser"
        Me.BtnSimpanUser.Size = New System.Drawing.Size(80, 31)
        Me.BtnSimpanUser.TabIndex = 4
        Me.BtnSimpanUser.Text = "Simpan"
        Me.BtnSimpanUser.UseVisualStyleBackColor = False
        '
        'BtnUbah
        '
        Me.BtnUbah.BackColor = System.Drawing.Color.Gold
        Me.BtnUbah.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUbah.Location = New System.Drawing.Point(696, 395)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(80, 31)
        Me.BtnUbah.TabIndex = 5
        Me.BtnUbah.Text = "Ubah "
        Me.BtnUbah.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.Orange
        Me.BtnHapus.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Location = New System.Drawing.Point(778, 395)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(80, 31)
        Me.BtnHapus.TabIndex = 6
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'LbJudul
        '
        Me.LbJudul.AutoSize = True
        Me.LbJudul.BackColor = System.Drawing.Color.Transparent
        Me.LbJudul.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbJudul.Location = New System.Drawing.Point(248, 455)
        Me.LbJudul.Name = "LbJudul"
        Me.LbJudul.Size = New System.Drawing.Size(383, 40)
        Me.LbJudul.TabIndex = 7
        Me.LbJudul.Text = "TOKO BUKU PRAMIDITA"
        '
        'LbMotivasi
        '
        Me.LbMotivasi.AutoSize = True
        Me.LbMotivasi.BackColor = System.Drawing.Color.Transparent
        Me.LbMotivasi.Font = New System.Drawing.Font("Harrington", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMotivasi.Location = New System.Drawing.Point(313, 500)
        Me.LbMotivasi.Name = "LbMotivasi"
        Me.LbMotivasi.Size = New System.Drawing.Size(274, 22)
        Me.LbMotivasi.TabIndex = 8
        Me.LbMotivasi.Text = "Kehidupan adalah sebuah buku "
        '
        'BtnAmbil
        '
        Me.BtnAmbil.BackColor = System.Drawing.Color.Orange
        Me.BtnAmbil.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAmbil.Location = New System.Drawing.Point(615, 395)
        Me.BtnAmbil.Name = "BtnAmbil"
        Me.BtnAmbil.Size = New System.Drawing.Size(80, 31)
        Me.BtnAmbil.TabIndex = 9
        Me.BtnAmbil.Text = "Ambil Data"
        Me.BtnAmbil.UseVisualStyleBackColor = False
        '
        'FormUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(875, 540)
        Me.Controls.Add(Me.BtnAmbil)
        Me.Controls.Add(Me.LbMotivasi)
        Me.Controls.Add(Me.LbJudul)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnSimpanUser)
        Me.Controls.Add(Me.GrupTambahUser)
        Me.Controls.Add(Me.LbDataUser)
        Me.Controls.Add(Me.Tab)
        Me.Controls.Add(Me.DGVUser)
        Me.Name = "FormUser"
        Me.Text = "Master Pengguna"
        CType(Me.DGVUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbUASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab.ResumeLayout(False)
        Me.TabMaster.ResumeLayout(False)
        Me.TabTransaksi.ResumeLayout(False)
        Me.TabLaporan.ResumeLayout(False)
        Me.TabPengaturan.ResumeLayout(False)
        Me.GrupTambahUser.ResumeLayout(False)
        Me.GrupTambahUser.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVUser As System.Windows.Forms.DataGridView
    Friend WithEvents DbUASDataSet As WindowsApplication1.DbUASDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As WindowsApplication1.DbUASDataSetTableAdapters.userTableAdapter
    Friend WithEvents IduserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamauserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JabatanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JeniskelaminDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoteleponDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents LbDataUser As System.Windows.Forms.Label
    Friend WithEvents GrupTambahUser As System.Windows.Forms.GroupBox
    Friend WithEvents LbIdUser As System.Windows.Forms.Label
    Friend WithEvents LbJabatanUser As System.Windows.Forms.Label
    Friend WithEvents LbNamaUser As System.Windows.Forms.Label
    Friend WithEvents LbAlamatUser As System.Windows.Forms.Label
    Friend WithEvents LbTeleponUser As System.Windows.Forms.Label
    Friend WithEvents LbGenderUser As System.Windows.Forms.Label
    Friend WithEvents TBNamaUser As System.Windows.Forms.TextBox
    Friend WithEvents TBIdUser As System.Windows.Forms.TextBox
    Friend WithEvents CBJabatanUser As System.Windows.Forms.ComboBox
    Friend WithEvents TBAlamatUser As System.Windows.Forms.TextBox
    Friend WithEvents CBGenderUser As System.Windows.Forms.ComboBox
    Friend WithEvents TBTeleponUser As System.Windows.Forms.TextBox
    Friend WithEvents BtnSimpanUser As System.Windows.Forms.Button
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents LbJudul As System.Windows.Forms.Label
    Friend WithEvents LbMotivasi As System.Windows.Forms.Label
    Friend WithEvents BtnAmbil As System.Windows.Forms.Button
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
End Class
