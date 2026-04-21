Imports MySqlConnector

Module DataModule

    ' =========================
    ' GENRE MODULE
    ' =========================
    Public Function GetAllGenre() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT genre, nama_genre FROM tbgenre ORDER BY genre ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal tampil genre: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function KodeSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbgenre WHERE genre = @kode"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal cek kode: " & ex.Message)
            Return True
        End Try
    End Function

    Public Function SimpanGenre(kode As String, nama As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tbgenre (genre, nama_genre) VALUES (@kode, @nama)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal simpan genre: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahGenre(kode As String, nama As String) As Boolean
        Try
            Dim query As String = "UPDATE tbgenre SET nama_genre=@nama WHERE genre=@kode"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal ubah genre: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function HapusGenre(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbgenre WHERE genre=@kode"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal hapus genre: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function SearchGenre(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM tbgenre WHERE genre LIKE @key OR nama_genre LIKE @key"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal cari genre: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function GetGenreByKode(kode As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM tbgenre WHERE genre = @kode"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kode", kode)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data genre: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    ' =========================
    ' WEBTOON (SUDAH BENAR, TIDAK DIUBAH)
    ' =========================

    ' Ambil semua data
    Public Function GetAllWebtoon() As DataTable
        Dim dt As New DataTable()
        Try
            ' Kita gunakan INNER JOIN untuk menggabungkan dua tabel
            ' tbwebtoons.genre (ID) disambungkan dengan tbgenre.genre (ID)
            ' Lalu yang kita ambil adalah tbgenre.nama_genre
            Dim query As String =
            "SELECT w.idwebtoon, w.judul, g.nama_genre, w.author, w.rating, w.status " &
            "FROM tbwebtoons w " &
            "INNER JOIN tbgenre g ON w.genre = g.genre " &
            "ORDER BY w.idwebtoon ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' Search
    Public Function SearchWebtoon(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT * FROM tbwebtoons WHERE " &
                "idwebtoon LIKE @keyword OR judul LIKE @keyword OR author LIKE @keyword " &
                "ORDER BY idwebtoon DESC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' Ambil berdasarkan ID
    Public Function GetWebtoonById(id As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT * FROM tbwebtoons WHERE idwebtoon = @id"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", id)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' Cek ID sudah ada
    Public Function IdSudahAda(id As String) As Boolean
        Try
            Dim query As String =
                "SELECT COUNT(*) FROM tbwebtoons WHERE idwebtoon = @id"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    ' Simpan
    Public Function SimpanWebtoon(id As String, judul As String, genre As String,
                                 author As String, rating As Decimal, status As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbwebtoons (idwebtoon, judul, genre, author, rating, status) " &
                "VALUES (@id, @judul, @genre, @author, @rating, @status)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@genre", genre)
                    cmd.Parameters.AddWithValue("@author", author)
                    cmd.Parameters.AddWithValue("@rating", rating)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Update
    Public Function UbahWebtoon(id As String, judul As String, genre As String,
                               author As String, rating As Decimal, status As String) As Boolean
        Try
            Dim query As String =
                "UPDATE tbwebtoons SET " &
                "judul = @judul, genre = @genre, author = @author, rating = @rating, status = @status " &
                "WHERE idwebtoon = @id"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@genre", genre)
                    cmd.Parameters.AddWithValue("@author", author)
                    cmd.Parameters.AddWithValue("@rating", rating)
                    cmd.Parameters.AddWithValue("@status", status)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Hapus
    Public Function HapusWebtoon(id As String) As Boolean
        Try
            Dim query As String =
                "DELETE FROM tbwebtoons WHERE idwebtoon = @id"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module