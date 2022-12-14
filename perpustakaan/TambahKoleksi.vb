Public Class TambahKoleksi

    Private bahasa As String
    Dim kategori_list As New List(Of String)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        tanggalMasuk.Format = DateTimePickerFormat.Custom
        tanggalMasuk.CustomFormat = "yyyy/MM/dd"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Title = "Open Picture"
        OpenFileDialog1.Filter = "All Format|*.*|Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF |*.gif"
        OpenFileDialog1.ShowDialog()

        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        FotoKoleksi.Load(picKoleksiDir)
        FotoKoleksi.SizeMode = PictureBoxSizeMode.StretchImage
        Perpustakaan.fungsiKoleksi.GSFoto = picKoleksiDir.ToString
        Perpustakaan.fungsiKoleksi.GSFoto = Perpustakaan.fungsiKoleksi.GSFoto.Replace("\", "/")
    End Sub
    Private Sub BtnIndonesia_CheckedChanged(sender As Object, e As EventArgs) Handles BtnIndonesia.CheckedChanged
        bahasa = "Bahasa Indonesia"
    End Sub
    Private Sub BtnInggris_CheckedChanged(sender As Object, e As EventArgs) Handles BtnInggris.CheckedChanged
        bahasa = "Bahasa Inggris"
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If ChkBudaya.Checked() Then
            kategori_list.Add("Budaya")
        End If

        If ChkSains.Checked() Then
            kategori_list.Add("Sains")
        End If

        If ChkSosial.Checked() Then
            kategori_list.Add("Sosial")
        End If

        If ChkTeknologi.Checked() Then
            kategori_list.Add("Teknologi")
        End If


        Perpustakaan.fungsiKoleksi.GSNama = txtNama.Text
        Perpustakaan.fungsiKoleksi.GSJenis = ComboBoxJenis.Text
        Perpustakaan.fungsiKoleksi.GSDeskripsi = deskripsi.Text
        Perpustakaan.fungsiKoleksi.GSPenerbit = txtPenerbit.Text
        Perpustakaan.fungsiKoleksi.GSTahunTerbit = txtTahunTerbit.Text
        Perpustakaan.fungsiKoleksi.GSLokasiRak = txtLokasiRak.Text
        Perpustakaan.fungsiKoleksi.GSTanggal = tanggalMasuk.Value.ToString("dd MMMM yyyy")
        Perpustakaan.fungsiKoleksi.GSStock = txtStock.Text
        Perpustakaan.fungsiKoleksi.GSBahasa = bahasa
        Perpustakaan.fungsiKoleksi.GSKategori = kategori_list

        Dim tambah = Perpustakaan.fungsiKoleksi.GSNama
        Perpustakaan.ListBox1.Items.Add(tambah)

        Dim convertedKoleksi = Perpustakaan.fungsiKoleksi.ConvertKoleksiToString(Perpustakaan.fungsiKoleksi.GSKategori)
        Perpustakaan.fungsiKoleksi.AddDataKoleksiDatabase(Perpustakaan.fungsiKoleksi.GSFoto,
                                                       Perpustakaan.fungsiKoleksi.GSNama,
                                                       Perpustakaan.fungsiKoleksi.GSJenis,
                                                       Perpustakaan.fungsiKoleksi.GSPenerbit,
                                                       Perpustakaan.fungsiKoleksi.GSDeskripsi,
                                                       Perpustakaan.fungsiKoleksi.GSTahunTerbit,
                                                       Perpustakaan.fungsiKoleksi.GSLokasiRak,
                                                       Perpustakaan.fungsiKoleksi.GSTanggal,
                                                       Perpustakaan.fungsiKoleksi.GSStock,
                                                       Perpustakaan.fungsiKoleksi.GSBahasa,
                                                       convertedKoleksi)


        Dim tambah_koleksi = New InfoTambahKoleksi()
        tambah_koleksi.Show()
    End Sub


End Class