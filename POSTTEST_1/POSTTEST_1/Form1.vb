Imports System.Globalization
Public Class Form1

    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIPKomulatif.Text = "0.00"
        lblPredikat.Text = ""
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ip As Double

        If txtIPSemester.Text = "" Then
            MessageBox.Show("Masukkan IP Semester!", "Peringatan!")
            Exit Sub
        End If

        txtIPSemester.Text = txtIPSemester.Text.Replace(",", ".")

        If Double.TryParse(txtIPSemester.Text, NumberStyles.Any, CultureInfo.InvariantCulture, ip) Then
            If ip < 0 Or ip > 4 Then
                MessageBox.Show("IP harus antara 0 sampai 4")
                Exit Sub
            End If

            totalIP += ip
            jumlahSemester += 1

            Dim ipk As Double = totalIP / jumlahSemester
            txtIPKomulatif.Text = ipk.ToString("0.00", CultureInfo.InvariantCulture)

            If ipk >= 3.01 Then
                lblPredikat.Text = "Sangat Memuaskan"
            ElseIf ipk >= 2.76 Then
                lblPredikat.Text = "Memuaskan"
            ElseIf ipk >= 2.0 Then
                lblPredikat.Text = "Cukup"
            Else
                lblPredikat.Text = "-"
            End If

            txtIPSemester.Clear()
            txtIPSemester.Focus()
        Else
            MessageBox.Show("Masukkan angka IP yang valid!")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIP = 0
        jumlahSemester = 0
        txtIPSemester.Clear()
        txtIPKomulatif.Clear()
        lblPredikat.Text = ""
    End Sub

End Class