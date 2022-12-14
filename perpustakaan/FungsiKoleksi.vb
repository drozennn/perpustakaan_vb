Imports System.Text
Imports MySql.Data.MySqlClient

Public Class FungsiKoleksi

    Private nama As String
    Private jenis As String
    Private deskripsi As String
    Private penerbit As String
    Private tahunterbit As String
    Private lokasirak As String
    Private tanggal As String
    Private stock As String
    Private bahasa As String
    Private kategori As New List(Of String)
    Private foto As String
    Private listKoleksi As New List(Of String)
    Private koleksiDataTable As New ArrayList()

    'Database Global Variable
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "perpustakaan"

    Public Property GSNama() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property GSJenis() As String
        Get
            Return jenis
        End Get
        Set(value As String)
            jenis = value
        End Set
    End Property

    Public Property GSDeskripsi() As String
        Get
            Return deskripsi
        End Get
        Set(value As String)
            deskripsi = value
        End Set
    End Property

    Public Property GSPenerbit() As String
        Get
            Return penerbit
        End Get
        Set(value As String)
            penerbit = value
        End Set
    End Property

    Public Property GSTahunTerbit() As String
        Get
            Return tahunterbit
        End Get
        Set(value As String)
            tahunterbit = value
        End Set
    End Property

    Public Property GSLokasiRak() As String
        Get
            Return lokasirak
        End Get
        Set(value As String)
            lokasirak = value
        End Set
    End Property

    Public Property GSTanggal() As String
        Get
            Return tanggal
        End Get
        Set(value As String)
            tanggal = value
        End Set
    End Property

    Public Property GSStock() As String
        Get
            Return stock
        End Get
        Set(value As String)
            stock = value
        End Set
    End Property

    Public Property GSBahasa() As String
        Get
            Return bahasa
        End Get
        Set(value As String)
            bahasa = value
        End Set
    End Property

    Public Property GSKategori() As List(Of String)
        Get
            Return kategori
        End Get
        Set(value As List(Of String))
            kategori = value
        End Set
    End Property

    Public Property GSFoto() As String
        Get
            Return foto
        End Get
        Set(value As String)
            foto = value
        End Set
    End Property

    Public Function AddKategori(value As String)
        kategori.Add(value)
        Return ""
    End Function

    Public ReadOnly Property getKategoriItem() As List(Of String)
        Get
            Return kategori
        End Get
    End Property

    Public Function resetKategori()
        kategori.Clear()
    End Function

    Public Function AddKoleksi(value As String)
        listKoleksi.Add(value)
        Return ""
    End Function

    Public Function RemoveKoleksi(value As String)
        listKoleksi.Remove(value)
        Return ""
    End Function

    Public ReadOnly Property getKoleksiItem() As List(Of String)
        Get
            Return listKoleksi
        End Get
    End Property

    Public Function AddKoleksiDataTable(dir_gambar As String,
                                        nama_koleksi As String,
                                        jenis_koleksi As String,
                                        penerbit_koleksi As String,
                                        deskripsi_koleksi As String,
                                        tahun_terbit As String,
                                        lokasi_rak As String,
                                        tanggal_masuk As String,
                                        stock_koleksi As Integer,
                                        bahasa_koleksi As String,
                                        kategori_koleksi As String)
        koleksiDataTable.Add({dir_gambar,
                             nama_koleksi,
                             jenis_koleksi,
                             penerbit_koleksi,
                             deskripsi_koleksi,
                             tahun_terbit,
                             lokasi_rak,
                             tanggal_masuk,
                             stock_koleksi,
                             bahasa_koleksi,
                             kategori_koleksi})
    End Function

    Public Function RemoveKoleksiDataTable(index As Integer)
        koleksiDataTable.RemoveAt(index)
    End Function

    Public ReadOnly Property getKoleksiDataTable() As ArrayList
        Get
            Return koleksiDataTable
        End Get
    End Property

    Public Function ConvertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        ' Convert to String
        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        'Convert to List
        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_koleksi AS 'ID',
                                  nama_koleksi AS 'Nama Koleksi',
                                  jenis_koleksi AS 'Jenis Koleksi',
                                  penerbit AS 'Penerbit',
                                  tahun_terbit AS 'Tahun Terbit',
                                  tanggal_masuk_koleksi AS 'Tanggal Masuk',
                                  lokasi AS 'Lokasi',
                                  stock AS 'Stock',
                                  bahasa AS 'Bahasa'
                                  FROM koleksi"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataKoleksiDatabase(dir_gambar As String,
                                           nama_koleksi As String,
                                           jenis_koleksi As String,
                                           penerbit_koleksi As String,
                                           deskripsi_koleksi As String,
                                           tahun_terbit As String,
                                           lokasi_rak As String,
                                           tanggal_masuk As String,
                                           stock_koleksi As String,
                                           bahasa_koleksi As String,
                                           kategori_koleksi As String)
        dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO koleksi(nama_koleksi, dir_gambar, deskripsi, penerbit, jenis_koleksi, tahun_terbit, lokasi, tanggal_masuk_koleksi, stock, bahasa, kategori)
                        VALUES('', '" & nama_koleksi & "', '" & dir_gambar & "', '" & deskripsi_koleksi & "', '" & penerbit_koleksi & "', '" & jenis_koleksi & "', '" & tahun_terbit & "', '" & lokasi_rak & "', '" & tanggal_masuk.ToString("yyyy/MM/dd") & "', '" & stock_koleksi & "', '" & bahasa_koleksi & "', '" & kategori_koleksi & "')"
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataKoleksiByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_koleksi, nama_koleksi, dir_gambar, deskripsi, penerbit, jenis_koleksi, tahun_terbit, lokasi, tanggal_masuk_koleksi, stock, bahasa, kategori FROM koleksi WHERE id_koleksi='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
            result.Add(sqlRead.GetString(7).ToString())
            result.Add(sqlRead.GetString(8).ToString())
            result.Add(sqlRead.GetString(9).ToString())
            result.Add(sqlRead.GetString(10).ToString())
            result.Add(sqlRead.GetString(11).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataKoleksiByIDDatabase(ID As Integer,
                                                  dir_gambar As String,
                                                  nama_koleksi As String,
                                                  jenis_koleksi As String,
                                                  penerbit_koleksi As String,
                                                  deskripsi_koleksi As String,
                                                  tahun_terbit As String,
                                                  lokasi_rak As String,
                                                  tanggal_masuk As String,
                                                  stock_koleksi As String,
                                                  bahasa_koleksi As String,
                                                  kategori_koleksi As String)

        tahun_terbit = tahun_terbit.ToString()

        dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlQuery = "UPDATE koleksi SET " &
                       "nama_koleksi='" & nama_koleksi & "', " &
                       "dir_gambar='" & dir_gambar & "', " &
                       "deskripsi='" & deskripsi_koleksi & "', " &
                       "penerbit='" & penerbit_koleksi & "', " &
                       "jenis_koleksi='" & jenis_koleksi & "', " &
                       "tahun_terbit='" & tahun_terbit & "', " &
                       "lokasi='" & lokasi_rak & "', " &
                       "tanggal_masuk_koleksi='" & tanggal_masuk & "', " &
                       "stock='" & stock_koleksi & "', " &
                       "bahasa='" & bahasa_koleksi & "', " &
                       "kategori='" & kategori_koleksi & "' " &
                       "WHERE id_koleksi='" & ID & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            dbConn.Close()
            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM koleksi " &
                        "WHERE id_koleksi='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function


End Class
