Public Class Form2
	Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		lblNama.Text = DataModule.Nama
		lblUmur.Text = DataModule.Umur
		lblTLahir.Text = DataModule.TLahir
		lblNTelpon.Text = DataModule.Telpon
		lblAlamat.Text = DataModule.Alamat
		lblJK.Text = DataModule.JK
		lblHobi.Text = DataModule.Hobi
		picProfil.Image = Image.FromFile(DataModule.Foto)
	End Sub

	Private Sub picProfil_Click(sender As Object, e As EventArgs) Handles picProfil.Click

	End Sub

	Private Sub Label6_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub lblUmur_Click(sender As Object, e As EventArgs) Handles lblUmur.Click

	End Sub
End Class