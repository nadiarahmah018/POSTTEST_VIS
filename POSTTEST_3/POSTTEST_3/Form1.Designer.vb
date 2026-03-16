<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		btnGambar = New Button()
		Label1 = New Label()
		Label2 = New Label()
		Label3 = New Label()
		Label4 = New Label()
		Label5 = New Label()
		rbLaki = New RadioButton()
		rbPerempuan = New RadioButton()
		txtNama = New TextBox()
		txtUmur = New TextBox()
		txtTelpon = New TextBox()
		txtAlamat = New TextBox()
		dtpLahir = New DateTimePicker()
		GroupBox1 = New GroupBox()
		cbBaca = New CheckBox()
		cbMasak = New CheckBox()
		cbLukis = New CheckBox()
		cbKebun = New CheckBox()
		cbRenang = New CheckBox()
		cbNyanyi = New CheckBox()
		cbFotografi = New CheckBox()
		cbTraveling = New CheckBox()
		cbGame = New CheckBox()
		cbEdit = New CheckBox()
		cbJournal = New CheckBox()
		cbCode = New CheckBox()
		GroupBox2 = New GroupBox()
		btnCetak = New Button()
		picProfil = New PictureBox()
		Label9 = New Label()
		Label7 = New Label()
		GroupBox1.SuspendLayout()
		GroupBox2.SuspendLayout()
		CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' btnGambar
		' 
		btnGambar.Location = New Point(80, 429)
		btnGambar.Name = "btnGambar"
		btnGambar.Size = New Size(112, 36)
		btnGambar.TabIndex = 1
		btnGambar.Text = "Browse"
		btnGambar.UseVisualStyleBackColor = True
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(301, 89)
		Label1.Name = "Label1"
		Label1.Size = New Size(49, 20)
		Label1.TabIndex = 2
		Label1.Text = "Nama"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(301, 131)
		Label2.Name = "Label2"
		Label2.Size = New Size(45, 20)
		Label2.TabIndex = 3
		Label2.Text = "Umur"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(301, 169)
		Label3.Name = "Label3"
		Label3.Size = New Size(97, 20)
		Label3.TabIndex = 4
		Label3.Text = "Tanggal Lahir"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Location = New Point(301, 212)
		Label4.Name = "Label4"
		Label4.Size = New Size(78, 20)
		Label4.TabIndex = 5
		Label4.Text = "No Telpon"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Location = New Point(301, 248)
		Label5.Name = "Label5"
		Label5.Size = New Size(57, 20)
		Label5.TabIndex = 6
		Label5.Text = "Alamat"
		' 
		' rbLaki
		' 
		rbLaki.AutoSize = True
		rbLaki.Location = New Point(12, 37)
		rbLaki.Name = "rbLaki"
		rbLaki.Size = New Size(85, 24)
		rbLaki.TabIndex = 7
		rbLaki.TabStop = True
		rbLaki.Text = "Laki-laki"
		rbLaki.UseVisualStyleBackColor = True
		' 
		' rbPerempuan
		' 
		rbPerempuan.AutoSize = True
		rbPerempuan.Location = New Point(12, 67)
		rbPerempuan.Name = "rbPerempuan"
		rbPerempuan.Size = New Size(104, 24)
		rbPerempuan.TabIndex = 8
		rbPerempuan.TabStop = True
		rbPerempuan.Text = "Perempuan"
		rbPerempuan.UseVisualStyleBackColor = True
		' 
		' txtNama
		' 
		txtNama.Location = New Point(450, 86)
		txtNama.Name = "txtNama"
		txtNama.Size = New Size(213, 27)
		txtNama.TabIndex = 9
		' 
		' txtUmur
		' 
		txtUmur.Location = New Point(450, 124)
		txtUmur.Name = "txtUmur"
		txtUmur.Size = New Size(213, 27)
		txtUmur.TabIndex = 10
		' 
		' txtTelpon
		' 
		txtTelpon.Location = New Point(450, 209)
		txtTelpon.Name = "txtTelpon"
		txtTelpon.Size = New Size(213, 27)
		txtTelpon.TabIndex = 11
		' 
		' txtAlamat
		' 
		txtAlamat.Location = New Point(450, 245)
		txtAlamat.Name = "txtAlamat"
		txtAlamat.Size = New Size(213, 27)
		txtAlamat.TabIndex = 12
		' 
		' dtpLahir
		' 
		dtpLahir.CalendarTitleBackColor = SystemColors.ButtonHighlight
		dtpLahir.Format = DateTimePickerFormat.Custom
		dtpLahir.Location = New Point(450, 169)
		dtpLahir.Name = "dtpLahir"
		dtpLahir.Size = New Size(213, 27)
		dtpLahir.TabIndex = 13
		' 
		' GroupBox1
		' 
		GroupBox1.Controls.Add(rbLaki)
		GroupBox1.Controls.Add(rbPerempuan)
		GroupBox1.Location = New Point(301, 290)
		GroupBox1.Name = "GroupBox1"
		GroupBox1.Size = New Size(197, 218)
		GroupBox1.TabIndex = 14
		GroupBox1.TabStop = False
		GroupBox1.Text = "Jenis Kelamin"
		' 
		' cbBaca
		' 
		cbBaca.AutoSize = True
		cbBaca.Location = New Point(38, 26)
		cbBaca.Name = "cbBaca"
		cbBaca.Size = New Size(97, 24)
		cbBaca.TabIndex = 15
		cbBaca.Text = "Membaca"
		cbBaca.ThreeState = True
		cbBaca.UseVisualStyleBackColor = True
		' 
		' cbMasak
		' 
		cbMasak.AutoSize = True
		cbMasak.Location = New Point(38, 56)
		cbMasak.Name = "cbMasak"
		cbMasak.Size = New Size(94, 24)
		cbMasak.TabIndex = 16
		cbMasak.Text = "Memasak"
		cbMasak.ThreeState = True
		cbMasak.UseVisualStyleBackColor = True
		' 
		' cbLukis
		' 
		cbLukis.AutoSize = True
		cbLukis.Location = New Point(38, 86)
		cbLukis.Name = "cbLukis"
		cbLukis.Size = New Size(81, 24)
		cbLukis.TabIndex = 17
		cbLukis.Text = "Melukis"
		cbLukis.UseVisualStyleBackColor = True
		' 
		' cbKebun
		' 
		cbKebun.AutoSize = True
		cbKebun.Location = New Point(38, 116)
		cbKebun.Name = "cbKebun"
		cbKebun.Size = New Size(93, 24)
		cbKebun.TabIndex = 18
		cbKebun.Text = "Berkebun"
		cbKebun.UseVisualStyleBackColor = True
		' 
		' cbRenang
		' 
		cbRenang.AutoSize = True
		cbRenang.Location = New Point(38, 146)
		cbRenang.Name = "cbRenang"
		cbRenang.Size = New Size(94, 24)
		cbRenang.TabIndex = 19
		cbRenang.Text = "Berenang"
		cbRenang.UseVisualStyleBackColor = True
		' 
		' cbNyanyi
		' 
		cbNyanyi.AutoSize = True
		cbNyanyi.Location = New Point(38, 176)
		cbNyanyi.Name = "cbNyanyi"
		cbNyanyi.Size = New Size(95, 24)
		cbNyanyi.TabIndex = 20
		cbNyanyi.Text = "Bernyanyi"
		cbNyanyi.UseVisualStyleBackColor = True
		' 
		' cbFotografi
		' 
		cbFotografi.AutoSize = True
		cbFotografi.Location = New Point(192, 26)
		cbFotografi.Name = "cbFotografi"
		cbFotografi.Size = New Size(92, 24)
		cbFotografi.TabIndex = 21
		cbFotografi.Text = "Fotografi"
		cbFotografi.UseVisualStyleBackColor = True
		' 
		' cbTraveling
		' 
		cbTraveling.AutoSize = True
		cbTraveling.Location = New Point(192, 56)
		cbTraveling.Name = "cbTraveling"
		cbTraveling.Size = New Size(91, 24)
		cbTraveling.TabIndex = 22
		cbTraveling.Text = "Traveling"
		cbTraveling.UseVisualStyleBackColor = True
		' 
		' cbGame
		' 
		cbGame.AutoSize = True
		cbGame.Location = New Point(192, 86)
		cbGame.Name = "cbGame"
		cbGame.Size = New Size(83, 24)
		cbGame.TabIndex = 23
		cbGame.Text = "Gaming"
		cbGame.UseVisualStyleBackColor = True
		' 
		' cbEdit
		' 
		cbEdit.AutoSize = True
		cbEdit.Location = New Point(192, 116)
		cbEdit.Name = "cbEdit"
		cbEdit.Size = New Size(78, 24)
		cbEdit.TabIndex = 24
		cbEdit.Text = "Editing"
		cbEdit.UseVisualStyleBackColor = True
		' 
		' cbJournal
		' 
		cbJournal.AutoSize = True
		cbJournal.Location = New Point(192, 146)
		cbJournal.Name = "cbJournal"
		cbJournal.Size = New Size(99, 24)
		cbJournal.TabIndex = 25
		cbJournal.Text = "Journaling"
		cbJournal.UseVisualStyleBackColor = True
		' 
		' cbCode
		' 
		cbCode.AutoSize = True
		cbCode.Location = New Point(192, 176)
		cbCode.Name = "cbCode"
		cbCode.Size = New Size(79, 24)
		cbCode.TabIndex = 9
		cbCode.Text = "Coding"
		cbCode.UseVisualStyleBackColor = True
		' 
		' GroupBox2
		' 
		GroupBox2.Controls.Add(cbTraveling)
		GroupBox2.Controls.Add(cbCode)
		GroupBox2.Controls.Add(cbBaca)
		GroupBox2.Controls.Add(cbJournal)
		GroupBox2.Controls.Add(cbMasak)
		GroupBox2.Controls.Add(cbEdit)
		GroupBox2.Controls.Add(cbLukis)
		GroupBox2.Controls.Add(cbGame)
		GroupBox2.Controls.Add(cbKebun)
		GroupBox2.Controls.Add(cbRenang)
		GroupBox2.Controls.Add(cbFotografi)
		GroupBox2.Controls.Add(cbNyanyi)
		GroupBox2.Location = New Point(514, 290)
		GroupBox2.Name = "GroupBox2"
		GroupBox2.Size = New Size(339, 218)
		GroupBox2.TabIndex = 26
		GroupBox2.TabStop = False
		GroupBox2.Text = "Hobi"
		' 
		' btnCetak
		' 
		btnCetak.Location = New Point(301, 514)
		btnCetak.Name = "btnCetak"
		btnCetak.Size = New Size(552, 29)
		btnCetak.TabIndex = 9
		btnCetak.Text = "Cetak Kartu"
		btnCetak.UseVisualStyleBackColor = True
		' 
		' picProfil
		' 
		picProfil.BackColor = SystemColors.ControlLight
		picProfil.Location = New Point(22, 89)
		picProfil.Name = "picProfil"
		picProfil.Size = New Size(236, 311)
		picProfil.TabIndex = 0
		picProfil.TabStop = False
		' 
		' Label9
		' 
		Label9.AutoSize = True
		Label9.BackColor = SystemColors.ActiveCaption
		Label9.Location = New Point(472, 20)
		Label9.Name = "Label9"
		Label9.Size = New Size(174, 20)
		Label9.TabIndex = 48
		Label9.Text = "Helping People Together"
		' 
		' Label7
		' 
		Label7.AutoSize = True
		Label7.BackColor = SystemColors.HotTrack
		Label7.Font = New Font("Segoe UI Black", 20F, FontStyle.Bold)
		Label7.ForeColor = SystemColors.ControlLight
		Label7.Location = New Point(22, 9)
		Label7.Name = "Label7"
		Label7.Size = New Size(441, 46)
		Label7.TabIndex = 47
		Label7.Text = "Volunteer Comunity Card"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = SystemColors.ActiveCaption
		ClientSize = New Size(902, 566)
		Controls.Add(Label9)
		Controls.Add(Label7)
		Controls.Add(btnCetak)
		Controls.Add(GroupBox2)
		Controls.Add(GroupBox1)
		Controls.Add(dtpLahir)
		Controls.Add(txtAlamat)
		Controls.Add(txtTelpon)
		Controls.Add(txtUmur)
		Controls.Add(txtNama)
		Controls.Add(Label5)
		Controls.Add(Label4)
		Controls.Add(Label3)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(btnGambar)
		Controls.Add(picProfil)
		Name = "Form1"
		Text = " "
		GroupBox1.ResumeLayout(False)
		GroupBox1.PerformLayout()
		GroupBox2.ResumeLayout(False)
		GroupBox2.PerformLayout()
		CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub
	Friend WithEvents btnGambar As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents rbLaki As RadioButton
	Friend WithEvents rbPerempuan As RadioButton
	Friend WithEvents txtNama As TextBox
	Friend WithEvents txtUmur As TextBox
	Friend WithEvents txtTelpon As TextBox
	Friend WithEvents txtAlamat As TextBox
	Friend WithEvents dtpLahir As DateTimePicker
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents cbBaca As CheckBox
	Friend WithEvents cbMasak As CheckBox
	Friend WithEvents cbLukis As CheckBox
	Friend WithEvents cbKebun As CheckBox
	Friend WithEvents cbRenang As CheckBox
	Friend WithEvents cbNyanyi As CheckBox
	Friend WithEvents cbFotografi As CheckBox
	Friend WithEvents cbTraveling As CheckBox
	Friend WithEvents cbGame As CheckBox
	Friend WithEvents cbEdit As CheckBox
	Friend WithEvents cbJournal As CheckBox
	Friend WithEvents cbCode As CheckBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents btnCetak As Button
	Friend WithEvents picProfil As PictureBox
	Friend WithEvents Label9 As Label
	Friend WithEvents Label7 As Label

End Class
