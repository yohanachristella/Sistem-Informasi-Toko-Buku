<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.LbToko = New System.Windows.Forms.Label()
        Me.GBLogin = New System.Windows.Forms.GroupBox()
        Me.TBPw = New System.Windows.Forms.TextBox()
        Me.TBUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbUsername = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.PicBuku = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.GBLogin.SuspendLayout()
        CType(Me.PicBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbToko
        '
        Me.LbToko.AutoSize = True
        Me.LbToko.BackColor = System.Drawing.Color.Transparent
        Me.LbToko.Font = New System.Drawing.Font("Algerian", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbToko.Location = New System.Drawing.Point(66, 19)
        Me.LbToko.Name = "LbToko"
        Me.LbToko.Size = New System.Drawing.Size(303, 30)
        Me.LbToko.TabIndex = 0
        Me.LbToko.Text = "TOKO BUKU PRAMIDITA"
        '
        'GBLogin
        '
        Me.GBLogin.BackColor = System.Drawing.Color.Transparent
        Me.GBLogin.Controls.Add(Me.TBPw)
        Me.GBLogin.Controls.Add(Me.TBUsername)
        Me.GBLogin.Controls.Add(Me.Label1)
        Me.GBLogin.Controls.Add(Me.LbUsername)
        Me.GBLogin.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBLogin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GBLogin.Location = New System.Drawing.Point(120, 67)
        Me.GBLogin.Name = "GBLogin"
        Me.GBLogin.Size = New System.Drawing.Size(291, 152)
        Me.GBLogin.TabIndex = 1
        Me.GBLogin.TabStop = False
        Me.GBLogin.Text = "Masuk Aplikasi"
        '
        'TBPw
        '
        Me.TBPw.Location = New System.Drawing.Point(133, 81)
        Me.TBPw.Name = "TBPw"
        Me.TBPw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBPw.Size = New System.Drawing.Size(152, 27)
        Me.TBPw.TabIndex = 4
        '
        'TBUsername
        '
        Me.TBUsername.Location = New System.Drawing.Point(133, 46)
        Me.TBUsername.Name = "TBUsername"
        Me.TBUsername.Size = New System.Drawing.Size(152, 27)
        Me.TBUsername.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kata Sandi"
        '
        'LbUsername
        '
        Me.LbUsername.AutoSize = True
        Me.LbUsername.Location = New System.Drawing.Point(7, 48)
        Me.LbUsername.Name = "LbUsername"
        Me.LbUsername.Size = New System.Drawing.Size(120, 19)
        Me.LbUsername.TabIndex = 0
        Me.LbUsername.Text = "Akun Pengguna"
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.Gold
        Me.BtnLogin.Font = New System.Drawing.Font("Bodoni MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.Location = New System.Drawing.Point(214, 225)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(79, 40)
        Me.BtnLogin.TabIndex = 2
        Me.BtnLogin.Text = "Masuk Aplikasi"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'PicBuku
        '
        Me.PicBuku.BackColor = System.Drawing.Color.Transparent
        Me.PicBuku.BackgroundImage = CType(resources.GetObject("PicBuku.BackgroundImage"), System.Drawing.Image)
        Me.PicBuku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicBuku.Location = New System.Drawing.Point(172, 227)
        Me.PicBuku.Name = "PicBuku"
        Me.PicBuku.Size = New System.Drawing.Size(39, 34)
        Me.PicBuku.TabIndex = 3
        Me.PicBuku.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(299, 227)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 34)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.Color.Orange
        Me.BtnBatal.Font = New System.Drawing.Font("Bodoni MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatal.Location = New System.Drawing.Point(340, 224)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(79, 40)
        Me.BtnBatal.TabIndex = 5
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(430, 271)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PicBuku)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.GBLogin)
        Me.Controls.Add(Me.LbToko)
        Me.Name = "FormLogin"
        Me.Text = "Form Login"
        Me.GBLogin.ResumeLayout(False)
        Me.GBLogin.PerformLayout()
        CType(Me.PicBuku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbToko As System.Windows.Forms.Label
    Friend WithEvents GBLogin As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LbUsername As System.Windows.Forms.Label
    Friend WithEvents TBPw As System.Windows.Forms.TextBox
    Friend WithEvents TBUsername As System.Windows.Forms.TextBox
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents PicBuku As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnBatal As System.Windows.Forms.Button

End Class
