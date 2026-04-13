Module ValidationModule
	Public Sub HanyaHuruf(e As KeyPressEventArgs)
		If Char.IsLetter(e.KeyChar) OrElse
Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then

			e.Handled = False
		Else
			e.Handled = True
		End If
	End Sub
	Public Sub HanyaAngka(e As KeyPressEventArgs)
		If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
			e.Handled = False
		Else
			e.Handled = True
		End If
	End Sub
	Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
		If txt.Text.Trim() = "" Then
			ep.SetError(txt, pesan)
			Return False
		Else
			ep.SetError(txt, "")
			Return True
		End If
	End Function

    Public Function ValidasiWebtoon(ep As ErrorProvider, txtID As TextBox, txtJudul As TextBox,
                                   cmbGenre As ComboBox, txtAuthor As TextBox, numRating As NumericUpDown,
                                   cmbStatus As ComboBox) As Boolean

        Dim idValid As Boolean = ValidasiTextBox(ep, txtID, "ID Webtoon tidak boleh kosong")
        Dim judulValid As Boolean = ValidasiTextBox(ep, txtJudul, "Judul tidak boleh kosong")
        Dim authorValid As Boolean = ValidasiTextBox(ep, txtAuthor, "Nama author tidak boleh kosong")

        Dim genreValid As Boolean = True
        If cmbGenre.SelectedIndex = -1 Then
            ep.SetError(cmbGenre, "Pilih genre webtoon")
            genreValid = False
        Else
            ep.SetError(cmbGenre, "")
        End If

        Dim statusValid As Boolean = True
        If cmbStatus.SelectedIndex = -1 Then
            ep.SetError(cmbStatus, "Pilih status webtoon")
            statusValid = False
        Else
            ep.SetError(cmbStatus, "")
        End If

        Dim ratingValid As Boolean = True
        If numRating.Value < 1 Or numRating.Value > 5 Then
            ep.SetError(numRating, "Rating harus antara 1 - 5")
            ratingValid = False
        Else
            ep.SetError(numRating, "")
        End If

        Return idValid And judulValid And authorValid And genreValid And statusValid And ratingValid
    End Function
    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function
End Module
