Public Class Form3

	Private Sub Kosong()
		txtKodeGenre.Clear()
		txtGenre.Clear()
		txtSearch.Clear()
		ErrorProvider1.Clear()
		txtKodeGenre.Focus()
	End Sub

	Private Sub TampilData()
		dgvGenre.DataSource = GetAllGenre()
	End Sub

	Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		TampilData()
		Kosong()
	End Sub

	' ================= SIMPAN =================
	Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
		ErrorProvider1.Clear()

		If Not ValidasiGenre(ErrorProvider1, txtKodeGenre, txtGenre) Then Exit Sub

		Dim kode As String = txtKodeGenre.Text.Trim()
		Dim namaGenre As String = txtGenre.Text.Trim()

		If KodeSudahAda(kode) Then
			MessageBox.Show("Kode Genre sudah terdaftar",
							"Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			txtKodeGenre.Focus()
			Exit Sub
		End If

		If SimpanGenre(kode, namaGenre) Then
			MessageBox.Show("Data berhasil disimpan", "Informasi",
							MessageBoxButtons.OK, MessageBoxIcon.Information)
			TampilData()
			Kosong()
		End If
	End Sub

	' ================= UBAH =================
	Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
		ErrorProvider1.Clear()

		If Not ValidasiGenre(ErrorProvider1, txtKodeGenre, txtGenre) Then Exit Sub

		Dim kode As String = txtKodeGenre.Text.Trim()
		Dim namaGenre As String = txtGenre.Text.Trim()

		If UbahGenre(kode, namaGenre) Then
			MessageBox.Show("Data berhasil diubah", "Informasi",
							MessageBoxButtons.OK, MessageBoxIcon.Information)
			TampilData()
			Kosong()
		Else
			MessageBox.Show("Data tidak ditemukan", "Peringatan",
							MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
	End Sub

	' ================= HAPUS =================
	Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
		If txtKodeGenre.Text.Trim = "" Then
			MessageBox.Show("Pilih data yang akan dihapus",
							"Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			txtKodeGenre.Focus()
			Exit Sub
		End If

		Dim hasil As DialogResult
		hasil = MessageBox.Show("Apakah data ingin dihapus?",
								"Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

		If hasil = DialogResult.Yes Then
			If HapusGenre(txtKodeGenre.Text.Trim) Then
				MessageBox.Show("Data berhasil dihapus", "Informasi",
								MessageBoxButtons.OK, MessageBoxIcon.Information)
				TampilData()
				Kosong()
			End If
		End If
	End Sub

	' ================= BATAL =================
	Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
		Kosong()
		TampilData()
	End Sub

	' ================= PILIH DATA =================
	Private Sub dgvGenre_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGenre.CellClick
		If e.RowIndex >= 0 Then
			txtKodeGenre.Text = dgvGenre.Rows(e.RowIndex).Cells("genre").Value.ToString()
			txtGenre.Text = dgvGenre.Rows(e.RowIndex).Cells("nama_genre").Value.ToString()
		End If
	End Sub

	' ================= CARI BERDASARKAN KODE =================
	Private Sub txtKodeGenre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeGenre.KeyPress
		If IsEnterKey(e) Then
			e.Handled = True

			Dim dt As DataTable = GetGenreByKode(txtKodeGenre.Text.Trim())

			If dt.Rows.Count > 0 Then
				txtKodeGenre.Text = dt.Rows(0)("genre").ToString()
				txtGenre.Text = dt.Rows(0)("nama_genre").ToString()
			Else
				txtGenre.Clear()
			End If

			txtGenre.Focus()
		End If
	End Sub

	' ================= VALIDASI INPUT =================
	Private Sub txtGenre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGenre.KeyPress
		HanyaHuruf(e)

		If IsEnterKey(e) Then
			e.Handled = True
			btnSimpan.Focus()
		End If
	End Sub

	' ================= SEARCH =================
	Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
		If txtSearch.Text.Trim() = "" Then
			TampilData()
		Else
			dgvGenre.DataSource = SearchGenre(txtSearch.Text.Trim())
		End If
	End Sub

	Private Sub btnkeForm1_Click(sender As Object, e As EventArgs) Handles btnkeForm1.Click
		Form1.Show()
		Me.Close()
	End Sub
End Class