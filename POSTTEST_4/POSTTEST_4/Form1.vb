Imports System.IO

Public Class Form1

	' validasi input
	Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
		HanyaHuruf(e)
	End Sub

	Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged
		ValidasiTextBox(ErrorProvider1, txtNama, "Nama tidak boleh kosong")
	End Sub

	Private Sub mtxtNoHP_TextChanged(sender As Object, e As EventArgs) Handles mtxtNoHP.TextChanged
		ValidasiMaskedTextBox(ErrorProvider1, mtxtNoHP, "Nomor HP belum lengkap")
	End Sub

	Private Sub txtAlamat_TextChanged(sender As Object, e As EventArgs) Handles txtAlamat.TextChanged
		ValidasiTextBox(ErrorProvider1, txtAlamat, "Alamat tidak boleh kosong")
	End Sub

	Private Sub mtxtNoHP_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtxtNoHP.MaskInputRejected
	End Sub

	Private Sub KumpulkanData()
		Nama = txtNama.Text.Trim()
		ID = txtID.Text.Trim()
		TLahir = dtpLahir.Value
		JK = GetSelectedRadioButton({rbLaki, rbPerempuan})
		Divisi = cmbDivisi.Text
		Telpon = mtxtNoHP.Text
		Email = txtEmail.Text.Trim()
		Alamat = txtAlamat.Text.Trim()
		Peran = GetSelectedRadioButton({rbKetua, rbAnggota, rbAdmin})
		Aktivitas = GetSelectedCheckBox({
			cbMengajar, cbDonasi, cbEvent, cbSosial,
			cbKampanye, cbKesehatan, cbBantuan, cbLingkungan
		})
	End Sub

	Private Sub IsiFormDariData()
		txtNama.Text = Nama
		txtID.Text = ID
		dtpLahir.Value = If(TLahir = Nothing, Now, TLahir)
		cmbDivisi.Text = Divisi
		mtxtNoHP.Text = Telpon
		txtEmail.Text = Email
		txtAlamat.Text = Alamat

		'jenis kelamin
		rbLaki.Checked = (JK = rbLaki.Text)
		rbPerempuan.Checked = (JK = rbPerempuan.Text)

		'peran
		rbKetua.Checked = (Peran = rbKetua.Text)
		rbAnggota.Checked = (Peran = rbAnggota.Text)
		rbAdmin.Checked = (Peran = rbAdmin.Text)

		'aktivitas
		Dim listAktivitas As List(Of String) =
			Aktivitas.Split(","c).Select(Function(s) s.Trim()).ToList()

		For Each cb As CheckBox In {cbMengajar, cbDonasi, cbEvent, cbSosial,
									 cbKampanye, cbKesehatan, cbBantuan, cbLingkungan}
			cb.Checked = listAktivitas.Contains(cb.Text)
		Next

		'foto
		If Foto <> "" AndAlso File.Exists(Foto) Then
			picFoto.Image = Image.FromFile(Foto)
			picFoto.SizeMode = PictureBoxSizeMode.StretchImage
		End If
	End Sub

	'input Data
	Private Sub mnuInput_Click(sender As Object, e As EventArgs) Handles mnuInput.Click
		TabControl1.SelectedTab = tcDataUtama
	End Sub

	'lihat kartu
	Private Sub mnuKartu_Click(sender As Object, e As EventArgs) Handles mnuKartu.Click

		If Not dataTersimpan Then
			MessageBox.Show(
			"Data belum tersimpan." & vbCrLf &
			"Silakan simpan data terlebih dahulu melalui menu 'Simpan Data'.",
			"Perhatian",
			MessageBoxButtons.OK,
			MessageBoxIcon.Warning
		)
			Exit Sub
		End If

		Dim formHasil As New FormHasil()
		formHasil.ShowDialog()

	End Sub

	'simpan Data
	Private Sub mnuSimpan_Click(sender As Object, e As EventArgs) Handles mnuSimpan.Click

		' validasi semua input
		If Not ValidasiSemuaInput(ErrorProvider1, txtNama, txtID, cmbDivisi,
								   mtxtNoHP, txtEmail, txtAlamat,
								   grupJK, grupPeran, grupAktivitas) Then
			MessageBox.Show("Masih ada input yang belum valid. Periksa kembali form.",
							"Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Exit Sub
		End If

		'konfirmasi simpan
		Dim hasil As DialogResult = MessageBox.Show(
			"Apakah data ingin disimpan?",
			"Konfirmasi",
			MessageBoxButtons.YesNoCancel,
			MessageBoxIcon.Question
		)

		Select Case hasil
			Case DialogResult.Yes
				KumpulkanData()

				Dim isi As String = BuatIsiFile(
					Nama, ID, TLahir.ToShortDateString(),
					JK, Divisi, Telpon, Email, Alamat,
					Peran, Aktivitas, Foto
				)

				If SimpanDataKeFile(SaveFileDialog1, isi, Nama & ".txt") Then
					dataTersimpan = True
					MessageBox.Show("Data berhasil disimpan!",
									"Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
				End If

			Case DialogResult.No
				MessageBox.Show("Data tidak jadi disimpan.", "Info",
								MessageBoxButtons.OK, MessageBoxIcon.Information)

			Case DialogResult.Cancel
		End Select
	End Sub
	'menu buka data
	Private Sub mnuBukaData_Click(sender As Object, e As EventArgs) Handles mnuBuka.Click

		Dim data = BukaDataDariFile(OpenFileDialog1)
		If data Is Nothing Then Exit Sub
		Nama = AmbilNilai(data, "Nama")
		ID = AmbilNilai(data, "ID")

		Dim tglStr As String = AmbilNilai(data, "TanggalLahir")
		Dim tglParsed As Date
		If Date.TryParse(tglStr, tglParsed) Then
			TLahir = tglParsed
		Else
			TLahir = Now
		End If

		JK = AmbilNilai(data, "JK")
		Divisi = AmbilNilai(data, "Divisi")
		Telpon = AmbilNilai(data, "NoHP")
		Email = AmbilNilai(data, "Email")
		Alamat = AmbilNilai(data, "Alamat")
		Peran = AmbilNilai(data, "Peran")
		Aktivitas = AmbilNilai(data, "Aktivitas")
		Foto = AmbilNilai(data, "Foto")

		RemoveHandler txtNama.TextChanged, AddressOf txtNama_TextChanged
		RemoveHandler mtxtNoHP.TextChanged, AddressOf mtxtNoHP_TextChanged
		RemoveHandler txtAlamat.TextChanged, AddressOf txtAlamat_TextChanged
		IsiFormDariData()
		AddHandler txtNama.TextChanged, AddressOf txtNama_TextChanged
		AddHandler mtxtNoHP.TextChanged, AddressOf mtxtNoHP_TextChanged
		AddHandler txtAlamat.TextChanged, AddressOf txtAlamat_TextChanged
		dataTersimpan = True

		MessageBox.Show("Data berhasil dibuka! Silakan pilih Lihat Kartu.",
					"Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
	End Sub

	'menu keluar 
	Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles mnuKeluar.Click
		Dim hasil As DialogResult = MessageBox.Show(
			"Apakah yakin ingin keluar?",
			"Konfirmasi Keluar",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Question
		)

		If hasil = DialogResult.Yes Then
			Me.Close()
		End If
	End Sub

	'button browse Foto
	Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

		If Not ValidasiTextBox(ErrorProvider1, txtNama, "Nama tidak boleh kosong") Then
			Exit Sub
		End If

		Dim namaFile As String = txtNama.Text.Trim()
		Dim openFileDialog As New OpenFileDialog()
		openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
		openFileDialog.Title = "Pilih Gambar"

		If openFileDialog.ShowDialog() = DialogResult.OK Then
			Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")

			If Not Directory.Exists(folderPath) Then
				Directory.CreateDirectory(folderPath)
			End If

			Dim fileName As String = namaFile & Path.GetExtension(openFileDialog.FileName)
			Dim destinationPath As String = Path.Combine(folderPath, fileName)

			File.Copy(openFileDialog.FileName, destinationPath, True)

			Foto = destinationPath
			picFoto.Image = Image.FromFile(destinationPath)
			picFoto.SizeMode = PictureBoxSizeMode.StretchImage

			MessageBox.Show("Gambar berhasil disimpan!", "Sukses",
							MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If
	End Sub

	'button simpan dan Cetak Kartu
	Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

		' Validasi semua input
		If Not ValidasiSemuaInput(ErrorProvider1, txtNama, txtID, cmbDivisi,
								   mtxtNoHP, txtEmail, txtAlamat,
								   grupJK, grupPeran, grupAktivitas) Then
			MessageBox.Show("Masih ada input yang belum valid. Periksa kembali form.",
							"Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Exit Sub
		End If

		KumpulkanData()

		Dim isi As String = BuatIsiFile(
			Nama, ID, TLahir.ToShortDateString(),
			JK, Divisi, Telpon, Email, Alamat,
			Peran, Aktivitas, Foto
		)

		If SimpanDataKeFile(SaveFileDialog1, isi, Nama & ".txt") Then
			dataTersimpan = True

			Dim formHasil As New FormHasil()
			formHasil.ShowDialog()
		Else
			MessageBox.Show("Penyimpanan dibatalkan. Kartu tidak ditampilkan.",
							"Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If
	End Sub
	'menu reset
	Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
		Dim konfirmasi As DialogResult = MessageBox.Show(
			"Reset semua data form?",
			"Konfirmasi Reset",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Question
		)

		If konfirmasi = DialogResult.Yes Then
			ResetForm()
			TabControl1.SelectedTab = tcDataUtama
		End If
	End Sub
	Private Sub ResetForm()
		txtNama.Clear()
		txtID.Clear()
		dtpLahir.Value = Now
		cmbDivisi.SelectedIndex = -1
		mtxtNoHP.Clear()
		txtEmail.Clear()
		txtAlamat.Clear()
		rbLaki.Checked = False
		rbPerempuan.Checked = False
		rbKetua.Checked = False
		rbAnggota.Checked = False
		rbAdmin.Checked = False
		For Each cb As CheckBox In {cbMengajar, cbDonasi, cbEvent, cbSosial,
								 cbKampanye, cbKesehatan, cbBantuan, cbLingkungan}
			cb.Checked = False
		Next
		picFoto.Image = Nothing
		Foto = ""
		dataTersimpan = False
		dataBerasalDariFile = False  ' ← reset juga
		ErrorProvider1.Clear()
	End Sub

End Class