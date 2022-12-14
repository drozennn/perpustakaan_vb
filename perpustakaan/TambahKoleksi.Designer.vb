<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahKoleksi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.ComboBoxJenis = New System.Windows.Forms.ComboBox()
        Me.deskripsi = New System.Windows.Forms.RichTextBox()
        Me.txtPenerbit = New System.Windows.Forms.TextBox()
        Me.txtTahunTerbit = New System.Windows.Forms.TextBox()
        Me.txtLokasiRak = New System.Windows.Forms.TextBox()
        Me.tanggalMasuk = New System.Windows.Forms.DateTimePicker()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.BtnIndonesia = New System.Windows.Forms.RadioButton()
        Me.BtnInggris = New System.Windows.Forms.RadioButton()
        Me.ChkSains = New System.Windows.Forms.CheckBox()
        Me.ChkBudaya = New System.Windows.Forms.CheckBox()
        Me.ChkTeknologi = New System.Windows.Forms.CheckBox()
        Me.ChkSosial = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FotoKoleksi = New System.Windows.Forms.PictureBox()
        Me.BtnTambah = New System.Windows.Forms.Button()
        CType(Me.FotoKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Koleksi :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis Koleksi :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Deskripsi :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Penerbit :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 481)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Stock :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 454)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tanggal Masuk Koleksi :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 427)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Lokasi Rak :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(45, 400)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Tahun Terbit :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(45, 529)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Kategori :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(45, 506)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Bahasa :"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(179, 206)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(349, 20)
        Me.txtNama.TabIndex = 10
        '
        'ComboBoxJenis
        '
        Me.ComboBoxJenis.FormattingEnabled = True
        Me.ComboBoxJenis.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.ComboBoxJenis.Location = New System.Drawing.Point(179, 232)
        Me.ComboBoxJenis.Name = "ComboBoxJenis"
        Me.ComboBoxJenis.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxJenis.TabIndex = 11
        '
        'deskripsi
        '
        Me.deskripsi.Location = New System.Drawing.Point(179, 265)
        Me.deskripsi.Name = "deskripsi"
        Me.deskripsi.Size = New System.Drawing.Size(349, 96)
        Me.deskripsi.TabIndex = 12
        Me.deskripsi.Text = ""
        '
        'txtPenerbit
        '
        Me.txtPenerbit.Location = New System.Drawing.Point(179, 371)
        Me.txtPenerbit.Name = "txtPenerbit"
        Me.txtPenerbit.Size = New System.Drawing.Size(349, 20)
        Me.txtPenerbit.TabIndex = 13
        '
        'txtTahunTerbit
        '
        Me.txtTahunTerbit.Location = New System.Drawing.Point(179, 397)
        Me.txtTahunTerbit.Name = "txtTahunTerbit"
        Me.txtTahunTerbit.Size = New System.Drawing.Size(349, 20)
        Me.txtTahunTerbit.TabIndex = 14
        '
        'txtLokasiRak
        '
        Me.txtLokasiRak.Location = New System.Drawing.Point(179, 424)
        Me.txtLokasiRak.Name = "txtLokasiRak"
        Me.txtLokasiRak.Size = New System.Drawing.Size(349, 20)
        Me.txtLokasiRak.TabIndex = 15
        '
        'tanggalMasuk
        '
        Me.tanggalMasuk.Location = New System.Drawing.Point(179, 451)
        Me.tanggalMasuk.Name = "tanggalMasuk"
        Me.tanggalMasuk.Size = New System.Drawing.Size(200, 20)
        Me.tanggalMasuk.TabIndex = 16
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(179, 478)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 20)
        Me.txtStock.TabIndex = 17
        '
        'BtnIndonesia
        '
        Me.BtnIndonesia.AutoSize = True
        Me.BtnIndonesia.Location = New System.Drawing.Point(179, 505)
        Me.BtnIndonesia.Name = "BtnIndonesia"
        Me.BtnIndonesia.Size = New System.Drawing.Size(71, 17)
        Me.BtnIndonesia.TabIndex = 18
        Me.BtnIndonesia.TabStop = True
        Me.BtnIndonesia.Text = "Indonesia"
        Me.BtnIndonesia.UseVisualStyleBackColor = True
        '
        'BtnInggris
        '
        Me.BtnInggris.AutoSize = True
        Me.BtnInggris.Location = New System.Drawing.Point(256, 506)
        Me.BtnInggris.Name = "BtnInggris"
        Me.BtnInggris.Size = New System.Drawing.Size(56, 17)
        Me.BtnInggris.TabIndex = 19
        Me.BtnInggris.TabStop = True
        Me.BtnInggris.Text = "Inggris"
        Me.BtnInggris.UseVisualStyleBackColor = True
        '
        'ChkSains
        '
        Me.ChkSains.AutoSize = True
        Me.ChkSains.Location = New System.Drawing.Point(179, 529)
        Me.ChkSains.Name = "ChkSains"
        Me.ChkSains.Size = New System.Drawing.Size(52, 17)
        Me.ChkSains.TabIndex = 20
        Me.ChkSains.Text = "Sains"
        Me.ChkSains.UseVisualStyleBackColor = True
        '
        'ChkBudaya
        '
        Me.ChkBudaya.AutoSize = True
        Me.ChkBudaya.Location = New System.Drawing.Point(269, 552)
        Me.ChkBudaya.Name = "ChkBudaya"
        Me.ChkBudaya.Size = New System.Drawing.Size(62, 17)
        Me.ChkBudaya.TabIndex = 21
        Me.ChkBudaya.Text = "Budaya"
        Me.ChkBudaya.UseVisualStyleBackColor = True
        '
        'ChkTeknologi
        '
        Me.ChkTeknologi.AutoSize = True
        Me.ChkTeknologi.Location = New System.Drawing.Point(179, 552)
        Me.ChkTeknologi.Name = "ChkTeknologi"
        Me.ChkTeknologi.Size = New System.Drawing.Size(73, 17)
        Me.ChkTeknologi.TabIndex = 22
        Me.ChkTeknologi.Text = "Teknologi"
        Me.ChkTeknologi.UseVisualStyleBackColor = True
        '
        'ChkSosial
        '
        Me.ChkSosial.AutoSize = True
        Me.ChkSosial.Location = New System.Drawing.Point(269, 529)
        Me.ChkSosial.Name = "ChkSosial"
        Me.ChkSosial.Size = New System.Drawing.Size(54, 17)
        Me.ChkSosial.TabIndex = 23
        Me.ChkSosial.Text = "Sosial"
        Me.ChkSosial.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(248, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Pilih Gambar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FotoKoleksi
        '
        Me.FotoKoleksi.Location = New System.Drawing.Point(227, 12)
        Me.FotoKoleksi.Name = "FotoKoleksi"
        Me.FotoKoleksi.Size = New System.Drawing.Size(116, 142)
        Me.FotoKoleksi.TabIndex = 25
        Me.FotoKoleksi.TabStop = False
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(12, 601)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(551, 23)
        Me.BtnTambah.TabIndex = 26
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'TambahKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 639)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.FotoKoleksi)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ChkSosial)
        Me.Controls.Add(Me.ChkTeknologi)
        Me.Controls.Add(Me.ChkBudaya)
        Me.Controls.Add(Me.ChkSains)
        Me.Controls.Add(Me.BtnInggris)
        Me.Controls.Add(Me.BtnIndonesia)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.tanggalMasuk)
        Me.Controls.Add(Me.txtLokasiRak)
        Me.Controls.Add(Me.txtTahunTerbit)
        Me.Controls.Add(Me.txtPenerbit)
        Me.Controls.Add(Me.deskripsi)
        Me.Controls.Add(Me.ComboBoxJenis)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TambahKoleksi"
        Me.Text = "Tambah Koleksi"
        CType(Me.FotoKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents ComboBoxJenis As ComboBox
    Friend WithEvents deskripsi As RichTextBox
    Friend WithEvents txtPenerbit As TextBox
    Friend WithEvents txtTahunTerbit As TextBox
    Friend WithEvents txtLokasiRak As TextBox
    Friend WithEvents tanggalMasuk As DateTimePicker
    Friend WithEvents txtStock As TextBox
    Friend WithEvents BtnIndonesia As RadioButton
    Friend WithEvents BtnInggris As RadioButton
    Friend WithEvents ChkSains As CheckBox
    Friend WithEvents ChkBudaya As CheckBox
    Friend WithEvents ChkTeknologi As CheckBox
    Friend WithEvents ChkSosial As CheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents FotoKoleksi As PictureBox
    Friend WithEvents BtnTambah As Button
End Class
