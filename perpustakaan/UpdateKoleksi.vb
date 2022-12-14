Public Class UpdateKoleksi

    Private bahasa As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FotoKoleksi.Load(Perpustakaan.fungsiKoleksi.GSFoto)
        FotoKoleksi.SizeMode = PictureBoxSizeMode.StretchImage
        tanggalMasuk.Format = DateTimePickerFormat.Custom
        tanggalMasuk.CustomFormat = "yyyy/MM/dd"
        txtNama.Text = Perpustakaan.fungsiKoleksi.GSNama
        ComboBoxJenis.SelectedItem() = Perpustakaan.fungsiKoleksi.GSJenis
        deskripsi.Text = Perpustakaan.fungsiKoleksi.GSDeskripsi
        txtPenerbit.Text = Perpustakaan.fungsiKoleksi.GSPenerbit
        txtTahunTerbit.Text = Perpustakaan.fungsiKoleksi.GSTahunTerbit
        txtLokasiRak.Text = Perpustakaan.fungsiKoleksi.GSLokasiRak
        tanggalMasuk.Value = Perpustakaan.fungsiKoleksi.GSTanggal
        txtStock.Text = Perpustakaan.fungsiKoleksi.GSStock

        If String.Compare(Perpustakaan.fungsiKoleksi.GSBahasa, "Bahasa Indonesia") = 0 Then
            BtnIndonesia.Checked = True
        ElseIf String.Compare(Perpustakaan.fungsiKoleksi.GSBahasa, "Bahasa Inggirs") = 0 Then
            BtnInggris.Checked = True
        End If

        For Each kategoriItem In Perpustakaan.fungsiKoleksi.getKategoriItem
            If String.Compare(kategoriItem, "Sains") = 0 Then
                ChkSains.Checked = True
            ElseIf String.Compare(kategoriItem, "Sosial") = 0 Then
                ChkSosial.Checked = True
            ElseIf String.Compare(kategoriItem, "Teknologi") = 0 Then
                ChkTeknologi.Checked = True
            ElseIf String.Compare(kategoriItem, "Budaya") = 0 Then
                ChkBudaya.Checked = True
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Title = "Open Picture"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF |*.gif|All Format|*.*"
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

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Perpustakaan.fungsiKoleksi.GSNama = txtNama.Text
        Perpustakaan.fungsiKoleksi.GSJenis = ComboBoxJenis.Text
        Perpustakaan.fungsiKoleksi.GSDeskripsi = deskripsi.Text
        Perpustakaan.fungsiKoleksi.GSPenerbit = txtPenerbit.Text
        Perpustakaan.fungsiKoleksi.GSTahunTerbit = Integer.Parse(txtTahunTerbit.Text)
        Perpustakaan.fungsiKoleksi.GSLokasiRak = txtLokasiRak.Text
        Perpustakaan.fungsiKoleksi.GSTanggal = tanggalMasuk.Value.ToString("dd MMMM yyyy")
        Perpustakaan.fungsiKoleksi.GSStock = Integer.Parse(txtStock.Text)
        Perpustakaan.fungsiKoleksi.GSBahasa = bahasa

        If ChkBudaya.Checked() Then
            Perpustakaan.fungsiKoleksi.AddKategori("Budaya")
        End If

        If ChkSains.Checked() Then
            Perpustakaan.fungsiKoleksi.AddKategori("Sains")
        End If

        If ChkSosial.Checked() Then
            Perpustakaan.fungsiKoleksi.AddKategori("Sosial")
        End If

        If ChkTeknologi.Checked() Then
            Perpustakaan.fungsiKoleksi.AddKategori("Teknologi")
        End If

        Perpustakaan.fungsiKoleksi.AddKoleksi(txtNama.Text.ToString())

        Dim convertedKoleksi = Perpustakaan.fungsiKoleksi.ConvertKoleksiToString(Perpustakaan.fungsiKoleksi.getKategoriItem)

        Perpustakaan.fungsiKoleksi.UpdateDataKoleksiByIDDatabase(Perpustakaan.selectedTableKoleksi,
                                                                 Perpustakaan.fungsiKoleksi.GSFoto,
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
        Dim infoTambah = New InfoTambahKoleksi()
        infoTambah.Show()

        Me.Close()

    End Sub
End Class