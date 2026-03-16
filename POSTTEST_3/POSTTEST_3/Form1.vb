Imports System.IO
Public Class Form1
	Dim grupHobi() As CheckBox
	Dim grupJK() As RadioButton

	Private Function cekData() As Boolean
		grupHobi = {cbBaca, cbMasak, cbLukis, cbKebun, cbRenang, cbNyanyi, cbCode, cbFotografi, cbTraveling, cbGame, cbEdit, cbJournal}
		grupJK = {rbLaki, rbPerempuan}
		If Not ValidasiTextBox(txtNama, "Nama Tidak Boleh Kosong") Then Return False
		If Not ValidasiTextBox(txtUmur, "Umur Tidak Boleh Kosong") Then Return False
		If Not ValidasiTextBox(txtTelpon, "No Telpon Tidak Boleh Kosong") Then Return False
		If Not ValidasiTextBox(txtAlamat, "Alamat Tidak Boleh Kosong") Then Return False
		If Not ValidasiRadioButton(grupJK, "Harus Pilih Jenis Kelamin") Then Return False
		If Not ValidasiCheckBox(grupHobi, "Harus Pilih Minimal 1 Hobi") Then Return False
		If Not ValidasiPictureBox(picProfil, "Harus Memilih Gambar") Then Return False
		Return True
	End Function

	Private Sub btnCetak_Click(Sender As Object, e As EventArgs) Handles btnCetak.Click
		If cekData() Then
			grupHobi = {cbBaca, cbMasak, cbLukis, cbKebun, cbRenang, cbNyanyi, cbCode, cbFotografi, cbTraveling, cbGame, cbEdit, cbJournal}
			grupJK = {rbLaki, rbPerempuan}
			Dim JK_Selected As String = GetSelectedRadioButton(grupJK)
			Dim Hobi_Selected As String = GetSelectedCheckBox(grupHobi)
			DataModule.Nama = txtNama.Text
			DataModule.Umur = txtUmur.Text
			DataModule.Telpon = txtTelpon.Text
			DataModule.Alamat = txtAlamat.Text
			DataModule.TLahir = dtpLahir.Value.ToString("dd-MM-yyyy")
			DataModule.JK = JK_Selected
			DataModule.Hobi = Hobi_Selected
			Form2.Show()
		End If
	End Sub

	Private Sub btnGambar_Click(sender As Object, e As EventArgs) Handles btnGambar.Click
		If ValidasiTextBox(txtNama, "Nama Tidak Boleh Kosong") Then
			Dim NamaFile As String = txtNama.Text.Trim()
			Dim openFileDialog As New OpenFileDialog()
			openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
			openFileDialog.Title = "Pilih Gambar"
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
				Dim fileName As String = NamaFile & Path.GetExtension(openFileDialog.FileName)
				Dim destinationPath As String = Path.Combine(folderPath, fileName)
				If Not Directory.Exists(folderPath) Then
					Directory.CreateDirectory(folderPath)
				End If
				File.Copy(openFileDialog.FileName, destinationPath, True)
				DataModule.Foto = destinationPath
				picProfil.Image = Image.FromFile(destinationPath)
				MessageBox.Show("Gambar berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If

		End If

	End Sub

	Private Sub txtNama_KeyPressEventArgs(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
		ValidationModule.HanyaHuruf(sender, e)
	End Sub

	Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
		ValidationModule.HanyaAngka(sender, e)
	End Sub

	Private Sub txtTelpon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelpon.KeyPress
		ValidationModule.HanyaAngka(sender, e)
	End Sub

	Private Sub pictProfil_Click(sender As Object, e As EventArgs) Handles picProfil.Click

	End Sub

	Private Sub dtpLahir_ValueChanged(sender As Object, e As EventArgs) Handles dtpLahir.ValueChanged

	End Sub

	Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub Label6_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

	End Sub
End Class
