Public Class InfoTambahKoleksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not String.IsNullOrEmpty(Perpustakaan.fungsiKoleksi.GSFoto) Then
            PictureBox1.Load(Perpustakaan.fungsiKoleksi.GSFoto)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        Label11.Text = Perpustakaan.fungsiKoleksi.GSNama
        Label13.Text = Perpustakaan.fungsiKoleksi.GSDeskripsi
        Label14.Text = Perpustakaan.fungsiKoleksi.GSPenerbit
        Label15.Text = Perpustakaan.fungsiKoleksi.GSTahunTerbit
        Label16.Text = Perpustakaan.fungsiKoleksi.GSLokasiRak
        Label17.Text = Perpustakaan.fungsiKoleksi.GSTanggal
        Label18.Text = Perpustakaan.fungsiKoleksi.GSStock
        Label12.Text = Perpustakaan.fungsiKoleksi.GSJenis
        Label19.Text = Perpustakaan.fungsiKoleksi.GSBahasa



        For Each kel In Perpustakaan.fungsiKoleksi.GSKategori
            ListBox1.Items.Add(kel)
        Next

        Perpustakaan.fungsiKoleksi.GSKategori.Clear()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class