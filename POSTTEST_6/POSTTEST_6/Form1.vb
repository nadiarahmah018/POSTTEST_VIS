Public Class Form1

    Private Sub Kosong()
        txtIdWebtoon.Clear()
        txtJudul.Clear()
        cmbGenre.SelectedIndex = -1
        txtAuthor.Clear()
        numRating.Value = 1
        cmbStatus.SelectedIndex = -1
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtIdWebtoon.Focus()
    End Sub

    Private Sub TampilData()
        dgvWebtoon.DataSource = GetAllWebtoon()
    End Sub

    ' Event saat Form pertama kali dibuka
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Setting NumericUpDown Rating
        numRating.Minimum = 1
        numRating.Maximum = 5
        numRating.DecimalPlaces = 1
        numRating.Increment = 0.1

        ' Load data genre ke ComboBox
        LoadGenre()

        ' Tampilkan data ke DataGridView
        TampilData()

        ' Kosongkan input
        Kosong()

    End Sub

    ' Method untuk load data genre dari database
    Private Sub LoadGenre()
        Dim dt As DataTable = GetAllGenre()

        cmbGenre.DataSource = dt
        cmbGenre.DisplayMember = "nama_genre" ' yang ditampilkan
        cmbGenre.ValueMember = "genre"        ' kode/id untuk FK
    End Sub

    ' Tombol Simpan
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        If Not ValidasiWebtoon(ErrorProvider1, txtIdWebtoon, txtJudul, cmbGenre, txtAuthor, numRating, cmbStatus) Then Exit Sub

        Dim id As String = txtIdWebtoon.Text.Trim()

        If IdSudahAda(id) Then
            MessageBox.Show("ID Webtoon sudah ada!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If SimpanWebtoon(id, txtJudul.Text, cmbGenre.SelectedValue.ToString(), txtAuthor.Text, numRating.Value, cmbStatus.Text) Then
            MessageBox.Show("Data Webtoon berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    ' Tombol Ubah
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()

        If Not ValidasiWebtoon(ErrorProvider1, txtIdWebtoon, txtJudul, cmbGenre, txtAuthor, numRating, cmbStatus) Then Exit Sub

        Dim id As String = txtIdWebtoon.Text.Trim()

        If UbahWebtoon(id, txtJudul.Text, cmbGenre.SelectedValue.ToString(), txtAuthor.Text, numRating.Value, cmbStatus.Text) Then
            MessageBox.Show("Data berhasil diubah", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Data tidak ditemukan", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Tombol Hapus
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtIdWebtoon.Text.Trim() = "" Then
            MessageBox.Show("Pilih data yang akan dihapus", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIdWebtoon.Focus()
            Exit Sub
        End If

        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah data ingin dihapus?",
                                "Konfirmasi",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            If HapusWebtoon(txtIdWebtoon.Text.Trim()) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    ' Event Search
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvWebtoon.DataSource = SearchWebtoon(txtSearch.Text.Trim())
        End If
    End Sub

    ' Detail Data
    Private Sub btnDetail_Click(sender As Object, e As EventArgs) Handles btnDetail.Click
        If dgvWebtoon.CurrentRow Is Nothing Then
            MessageBox.Show("Pilih data terlebih dahulu!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim row As DataGridViewRow = dgvWebtoon.CurrentRow
        Dim id As String = row.Cells("idwebtoon").Value.ToString()
        Dim judul As String = row.Cells("judul").Value.ToString()
        Dim genre As String = row.Cells("nama_genre").Value.ToString()
        Dim author As String = row.Cells("author").Value.ToString()
        Dim rating As Decimal = Convert.ToDecimal(row.Cells("rating").Value)
        Dim status As String = row.Cells("status").Value.ToString()

        Dim frm As New Form2
        frm.TampilDetail(id, judul, genre, author, rating, status)
        frm.ShowDialog()
    End Sub

    ' Buka Form Genre + Refresh
    Private Sub btnGenre_Click(sender As Object, e As EventArgs) Handles btnGenre.Click
        Form3.ShowDialog()
        LoadGenre()
    End Sub

End Class