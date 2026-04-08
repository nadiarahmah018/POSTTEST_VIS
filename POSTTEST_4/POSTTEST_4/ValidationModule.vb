Module ValidationModule
    'validasi huruf
    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse
           Char.IsWhiteSpace(e.KeyChar) OrElse
           Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
	'validasi angka
	Public Sub HanyaAngka(e As KeyPressEventArgs)
		If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
			e.Handled = False
		Else
			e.Handled = True
		End If
	End Sub
	'validasi textbox 
	Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
		If txt.Text.Trim() = "" Then
			ep.SetError(txt, pesan)
			Return False
		Else
			ep.SetError(txt, "")
			Return True
		End If
	End Function
	'validasi combobox
	Public Function ValidasiComboBox(ep As ErrorProvider, cbo As ComboBox, pesan As String) As Boolean
		If cbo.SelectedIndex = -1 OrElse cbo.Text.Trim() = "" Then
			ep.SetError(cbo, pesan)
			Return False
		Else
			ep.SetError(cbo, "")
			Return True
		End If
	End Function
	'validasi maskedtextbox
	Public Function ValidasiMaskedTextBox(ep As ErrorProvider, mtb As MaskedTextBox, pesan As String) As Boolean
        If Not mtb.MaskCompleted Then
            ep.SetError(mtb, pesan)
            Return False
        Else
            ep.SetError(mtb, "")
            Return True
        End If
    End Function
    'validasi radio button
    Public Function ValidasiRadioButton(grp As GroupBox, pesan As String) As Boolean
        For Each ctrl As Control In grp.Controls
            If TypeOf ctrl Is RadioButton Then
                If CType(ctrl, RadioButton).Checked Then
                    Return True
                End If
            End If
        Next

        MessageBox.Show(pesan, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return False
    End Function
	'validasi chekbox
	Public Function ValidasiCheckBox(grp As GroupBox, pesan As String) As Boolean
		For Each ctrl As Control In grp.Controls
			If TypeOf ctrl Is CheckBox Then
				If CType(ctrl, CheckBox).Checked Then
					Return True
				End If
			End If
		Next

		MessageBox.Show(pesan, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		Return False
	End Function
	'validasi email
	Public Function ValidasiEmail(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
		If txt.Text.Contains("@") AndAlso txt.Text.Contains(".") Then
			ep.SetError(txt, "")
			Return True
		Else
			ep.SetError(txt, pesan)
			Return False
		End If
	End Function

	Public Function ValidasiSemuaInput(
		ep As ErrorProvider,
		txtNama As TextBox,
		txtID As TextBox,
		cmbDivisi As ComboBox,
		mtbNoHP As MaskedTextBox,
		txtEmail As TextBox,
		txtAlamat As TextBox,
		grupJK As GroupBox,
		grupPeran As GroupBox,
		grupAktivitas As GroupBox
	) As Boolean

		Dim namaValid As Boolean = ValidasiTextBox(ep, txtNama, "Nama tidak boleh kosong")
		Dim idValid As Boolean = ValidasiTextBox(ep, txtID, "ID tidak boleh kosong")
		Dim divisiValid As Boolean = ValidasiComboBox(ep, cmbDivisi, "Divisi harus dipilih")
		Dim noHpValid As Boolean = ValidasiMaskedTextBox(ep, mtbNoHP, "Nomor HP belum lengkap")
		Dim alamatValid As Boolean = ValidasiTextBox(ep, txtAlamat, "Alamat tidak boleh kosong")
		Dim emailValid As Boolean = ValidasiTextBox(ep, txtEmail, "Email tidak boleh kosong")
		Dim jkValid As Boolean = ValidasiRadioButton(grupJK, "Pilih jenis kelamin")
		Dim peranValid As Boolean = ValidasiRadioButton(grupPeran, "Pilih peran")
		Dim aktivitasValid As Boolean = ValidasiCheckBox(grupAktivitas, "Pilih minimal 1 aktivitas")

		Return namaValid And idValid And divisiValid And noHpValid And alamatValid And jkValid And peranValid And aktivitasValid
	End Function

End Module
