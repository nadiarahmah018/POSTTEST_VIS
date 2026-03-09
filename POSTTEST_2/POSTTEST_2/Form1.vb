Public Class Form1
    Sub tampilBuku()
        lstBuku.Items.Clear()

        For i As Integer = 0 To jumlahBuku - 1
            lstBuku.Items.Add(daftarBuku(i, 0) & " ( " & daftarBuku(i, 1) & " ) ")
        Next

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        If txtJudul.Text <> "" And txtGenre.Text <> "" Then

            tambahBuku(txtJudul.Text, txtGenre.Text)

            tampilBuku()

            txtJudul.Text = ""
            txtGenre.Text = ""
        Else

            MessageBox.Show("Judul dan Genre harus diisi ya, ga boleh kosong")

        End If

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Dim hasil As Integer

        If txtHapus.Text = "" Then

            MessageBox.Show("Masukkan judul buku yang mau dihapus")

        Else

            hasil = cariBuku(txtHapus.Text)

            If hasil = -1 Then

                MessageBox.Show("Buku tidak ditemukan")

            Else

                hapusBuku(hasil)

                tampilBuku()

                MessageBox.Show("Buku berhasil dihapus")

            End If

        End If

        txtHapus.Text = ""

    End Sub

End Class