Public Class Form2
	Public Sub TampilDetail(id As String, judul As String, genre As String,
						author As String, rating As Decimal, status As String)

		lblId.Text = id
		lblJudul.Text = judul
		lblGenre.Text = genre
		lblAuthor.Text = author
		lblRating.Text = rating.ToString()
		lblStatus.Text = status

	End Sub

	Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
		Me.Close()
		Form1.Show()
	End Sub

End Class