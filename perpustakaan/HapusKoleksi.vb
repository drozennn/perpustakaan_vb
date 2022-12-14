Public Class HapusKoleksi

    Dim indexItem As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Label2.Text = Perpustakaan.ListBox1.SelectedItem()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Perpustakaan.ListBox1.Items.RemoveAt(Perpustakaan.ListBox1.SelectedIndex)

        For Each item In Perpustakaan.fungsiKoleksi.getKoleksiDataTable()
            If item(0) Is Perpustakaan.selectedCollection Then
                indexItem = Perpustakaan.fungsiKoleksi.getKoleksiDataTable().IndexOf(item)
            End If
        Next

        Perpustakaan.fungsiKoleksi.RemoveKoleksiDataTable(indexItem)
        Perpustakaan.fungsiKoleksi.DeleteDataKoleksiByIDDatabase(Perpustakaan.selectedTableKoleksi)
        Me.Close()
    End Sub
End Class