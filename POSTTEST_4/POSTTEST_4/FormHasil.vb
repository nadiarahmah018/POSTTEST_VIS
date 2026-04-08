Public Class FormHasil

    Private Sub FormHasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblNama.Text = "Nama : " & Nama
        lblID.Text = "ID : " & ID
        lblDivisi.Text = "Komunitas : " & Divisi
        lblNoHP.Text = "Kontak : " & Telpon
        lblAktivitas.Text = "Aktivitas : " & vbCrLf & Aktivitas

        If Foto <> "" AndAlso IO.File.Exists(Foto) Then
            PicProfil.Image = Image.FromFile(Foto)
            PicProfil.SizeMode = PictureBoxSizeMode.StretchImage
        End If

    End Sub

End Class