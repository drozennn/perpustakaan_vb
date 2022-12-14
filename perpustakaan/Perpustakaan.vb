Public Class Perpustakaan

    Public Shared fungsiKoleksi As FungsiKoleksi
    Public Shared selectedCollection As String
    Public selectedTableKoleksi
    Dim selectedTableKoleksiNama

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        fungsiKoleksi = New FungsiKoleksi()
        ' Add any initialization after the InitializeComponent() call.
        UpdateDataTableArrayList()
        ReloadDataTableDatabase()

    End Sub

    Private Sub Perpustakaan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UpdateDataTableArrayList()
        ReloadDataTableDatabase()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim tambah_Koleksi = New TambahKoleksi()
        tambah_Koleksi.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If (ListBox1.SelectedIndex = -1) Then
            MessageBox.Show("Please select an item to delete")
        Else
            Dim hapus_koleksi = New HapusKoleksi()
            hapus_koleksi.Show()
        End If
    End Sub

    Public Sub UpdateDataTableArrayList()
        'DataGridKoleksi.Rows.Clear()
        For Each rowKoleksi In fungsiKoleksi.getKoleksiDataTable()
            Dim datatable As String() = {rowKoleksi(1),
                                         rowKoleksi(2),
                                         rowKoleksi(3),
                                         rowKoleksi(4),
                                         rowKoleksi(5),
                                         rowKoleksi(6),
                                         rowKoleksi(7),
                                         rowKoleksi(8),
                                         rowKoleksi(9),
                                         rowKoleksi(10)}
            DataGridKoleksi.Rows.Add(datatable)
        Next
    End Sub

    Private Sub DataGridKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKoleksi.CellClick
        'selectedTableKoleksi = DataGridKoleksi.CurrentRow.Index
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridKoleksi.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Dim selectedKoleksi = fungsiKoleksi.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

        fungsiKoleksi.GSFoto = selectedKoleksi(2)
        fungsiKoleksi.GSNama = selectedKoleksi(1)
        fungsiKoleksi.GSJenis = selectedKoleksi(5)
        fungsiKoleksi.GSDeskripsi = selectedKoleksi(3)
        fungsiKoleksi.GSPenerbit = selectedKoleksi(4)
        fungsiKoleksi.GSTahunTerbit = selectedKoleksi(6)
        fungsiKoleksi.GSLokasiRak = selectedKoleksi(7)
        fungsiKoleksi.GSTanggal = selectedKoleksi(8)
        fungsiKoleksi.GSStock = selectedKoleksi(9)
        fungsiKoleksi.GSBahasa = selectedKoleksi(10)

        Dim data_kategori As List(Of String) = fungsiKoleksi.ConvertStringToKoleksi(selectedKoleksi(11))

        For Each info_kategori In data_kategori
            fungsiKoleksi.AddKategori(info_kategori)
        Next

        Dim infoTambah = New InfoTambahKoleksi()
        infoTambah.Show()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridKoleksi.DataSource = fungsiKoleksi.GetDataKoleksiDatabase()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim selectedKoleksi As List(Of String) = fungsiKoleksi.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

        fungsiKoleksi.GSFoto = selectedKoleksi(2)

        fungsiKoleksi.GSNama = selectedKoleksi(1)
        fungsiKoleksi.GSJenis = selectedKoleksi(5)
        fungsiKoleksi.GSDeskripsi = selectedKoleksi(3)
        fungsiKoleksi.GSPenerbit = selectedKoleksi(4)
        fungsiKoleksi.GSTahunTerbit = selectedKoleksi(6)
        fungsiKoleksi.GSLokasiRak = selectedKoleksi(7)
        fungsiKoleksi.GSTanggal = selectedKoleksi(8)
        fungsiKoleksi.GSStock = selectedKoleksi(9)
        fungsiKoleksi.GSBahasa = selectedKoleksi(10)
        Dim data_kategori As List(Of String) = fungsiKoleksi.ConvertStringToKoleksi(selectedKoleksi(11))

        For Each info_kategori In data_kategori
            fungsiKoleksi.AddKategori(info_kategori)
        Next

        Dim formUpdate = New UpdateKoleksi()
        formUpdate.Show()
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Dim formHapus = New HapusKoleksi()
        formHapus.Show()
    End Sub
End Class
