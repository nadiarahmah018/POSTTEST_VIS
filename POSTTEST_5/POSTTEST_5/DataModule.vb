Imports MySqlConnector

Module DataModule

    ' Ambil semua data
    Public Function GetAllWebtoon() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT idwebtoon, judul, genre, author, rating, status " &
                "FROM tbwebtoons ORDER BY idwebtoon ASC"

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