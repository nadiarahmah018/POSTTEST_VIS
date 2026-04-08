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
		components = New ComponentModel.Container()
		MenuStrip1 = New MenuStrip()
		mnuInput = New ToolStripMenuItem()
		mnuKartu = New ToolStripMenuItem()
		mnuSimpan = New ToolStripMenuItem()
		mnuBuka = New ToolStripMenuItem()
		mnuKeluar = New ToolStripMenuItem()
		ResetToolStripMenuItem = New ToolStripMenuItem()
		Label1 = New Label()
		PictureBox1 = New PictureBox()
		Panel1 = New Panel()
		TabControl1 = New TabControl()
		tcDataUtama = New TabPage()
		grupJK = New GroupBox()
		rbLaki = New RadioButton()
		rbPerempuan = New RadioButton()
		Label9 = New Label()
		Label8 = New Label()
		Label6 = New Label()
		Label5 = New Label()
		Label4 = New Label()
		cmbDivisi = New ComboBox()
		dtpLahir = New DateTimePicker()
		txtID = New TextBox()
		txtNama = New TextBox()
		tcKontakInfo = New TabPage()
		Label12 = New Label()
		Label11 = New Label()
		Label10 = New Label()
		Label3 = New Label()
		mtxtNoHP = New MaskedTextBox()
		txtAlamat = New TextBox()
		txtEmail = New TextBox()
		tcProfilAktivitas = New TabPage()
		btnCetak = New Button()
		grupAktivitas = New GroupBox()
		cbLingkungan = New CheckBox()
		cbBantuan = New CheckBox()
		cbKesehatan = New CheckBox()
		cbKampanye = New CheckBox()
		cbSosial = New CheckBox()
		cbEvent = New CheckBox()
		cbDonasi = New CheckBox()
		cbMengajar = New CheckBox()
		grupPeran = New GroupBox()
		rbAdmin = New RadioButton()
		rbAnggota = New RadioButton()
		rbKetua = New RadioButton()
		Label2 = New Label()
		btnBrowse = New Button()
		picFoto = New PictureBox()
		Panel2 = New Panel()
		ErrorProvider1 = New ErrorProvider(components)
		SaveFileDialog1 = New SaveFileDialog()
		OpenFileDialog1 = New OpenFileDialog()
		MenuStrip1.SuspendLayout()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		Panel1.SuspendLayout()
		TabControl1.SuspendLayout()
		tcDataUtama.SuspendLayout()
		grupJK.SuspendLayout()
		tcKontakInfo.SuspendLayout()
		tcProfilAktivitas.SuspendLayout()
		grupAktivitas.SuspendLayout()
		grupPeran.SuspendLayout()
		CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' MenuStrip1
		' 
		MenuStrip1.BackColor = Color.Orange
		MenuStrip1.ImageScalingSize = New Size(20, 20)
		MenuStrip1.Items.AddRange(New ToolStripItem() {mnuInput, mnuKartu, mnuSimpan, mnuBuka, mnuKeluar, ResetToolStripMenuItem})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Size = New Size(800, 28)
		MenuStrip1.TabIndex = 0
		MenuStrip1.Text = "MenuStrip1"
		' 
		' mnuInput
		' 
		mnuInput.Name = "mnuInput"
		mnuInput.Size = New Size(93, 24)
		mnuInput.Text = "Input Data"
		' 
		' mnuKartu
		' 
		mnuKartu.Name = "mnuKartu"
		mnuKartu.Size = New Size(94, 24)
		mnuKartu.Text = "Lihat Kartu"
		' 
		' mnuSimpan
		' 
		mnuSimpan.Name = "mnuSimpan"
		mnuSimpan.Size = New Size(109, 24)
		mnuSimpan.Text = "Simpan Data"
		' 
		' mnuBuka
		' 
		mnuBuka.Name = "mnuBuka"
		mnuBuka.Size = New Size(91, 24)
		mnuBuka.Text = "Buka Data"
		' 
		' mnuKeluar
		' 
		mnuKeluar.Name = "mnuKeluar"
		mnuKeluar.Size = New Size(65, 24)
		mnuKeluar.Text = "Keluar"
		' 
		' ResetToolStripMenuItem
		' 
		ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
		ResetToolStripMenuItem.Size = New Size(59, 24)
		ResetToolStripMenuItem.Text = "Reset"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.BackColor = Color.Transparent
		Label1.Font = New Font("Perpetua Titling MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label1.ForeColor = Color.ForestGreen
		Label1.Location = New Point(135, 25)
		Label1.Name = "Label1"
		Label1.Size = New Size(475, 33)
		Label1.TabIndex = 1
		Label1.Text = "VOLUNTEER COMUNITY CARD"
		' 
		' PictureBox1
		' 
		PictureBox1.BackColor = Color.Transparent
		PictureBox1.Image = My.Resources.Resources.logo_volunteer
		PictureBox1.Location = New Point(27, 3)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(87, 81)
		PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
		PictureBox1.TabIndex = 2
		PictureBox1.TabStop = False
		' 
		' Panel1
		' 
		Panel1.BackColor = Color.BlanchedAlmond
		Panel1.Controls.Add(PictureBox1)
		Panel1.Controls.Add(Label1)
		Panel1.Location = New Point(0, 31)
		Panel1.Name = "Panel1"
		Panel1.Size = New Size(800, 87)
		Panel1.TabIndex = 3
		' 
		' TabControl1
		' 
		TabControl1.Controls.Add(tcDataUtama)
		TabControl1.Controls.Add(tcKontakInfo)
		TabControl1.Controls.Add(tcProfilAktivitas)
		TabControl1.Location = New Point(27, 139)
		TabControl1.Name = "TabControl1"
		TabControl1.SelectedIndex = 0
		TabControl1.Size = New Size(598, 249)
		TabControl1.TabIndex = 4
		' 
		' tcDataUtama
		' 
		tcDataUtama.BackColor = Color.BlanchedAlmond
		tcDataUtama.Controls.Add(grupJK)
		tcDataUtama.Controls.Add(Label9)
		tcDataUtama.Controls.Add(Label8)
		tcDataUtama.Controls.Add(Label6)
		tcDataUtama.Controls.Add(Label5)
		tcDataUtama.Controls.Add(Label4)
		tcDataUtama.Controls.Add(cmbDivisi)
		tcDataUtama.Controls.Add(dtpLahir)
		tcDataUtama.Controls.Add(txtID)
		tcDataUtama.Controls.Add(txtNama)
		tcDataUtama.Location = New Point(4, 29)
		tcDataUtama.Name = "tcDataUtama"
		tcDataUtama.Padding = New Padding(3)
		tcDataUtama.Size = New Size(590, 216)
		tcDataUtama.TabIndex = 0
		tcDataUtama.Text = "Data Utama"
		' 
		' grupJK
		' 
		grupJK.Controls.Add(rbLaki)
		grupJK.Controls.Add(rbPerempuan)
		grupJK.Location = New Point(350, 50)
		grupJK.Name = "grupJK"
		grupJK.Size = New Size(229, 66)
		grupJK.TabIndex = 12
		grupJK.TabStop = False
		grupJK.Text = "Jenis Kelamin"
		' 
		' rbLaki
		' 
		rbLaki.AutoSize = True
		rbLaki.Location = New Point(6, 26)
		rbLaki.Name = "rbLaki"
		rbLaki.Size = New Size(85, 24)
		rbLaki.TabIndex = 3
		rbLaki.TabStop = True
		rbLaki.Text = "Laki-laki"
		rbLaki.UseVisualStyleBackColor = True
		' 
		' rbPerempuan
		' 
		rbPerempuan.AutoSize = True
		rbPerempuan.Location = New Point(111, 26)
		rbPerempuan.Name = "rbPerempuan"
		rbPerempuan.Size = New Size(104, 24)
		rbPerempuan.TabIndex = 4
		rbPerempuan.TabStop = True
		rbPerempuan.Text = "Perempuan"
		rbPerempuan.UseVisualStyleBackColor = True
		' 
		' Label9
		' 
		Label9.AutoSize = True
		Label9.BackColor = Color.Transparent
		Label9.Font = New Font("Perpetua Titling MT", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label9.ForeColor = Color.ForestGreen
		Label9.Location = New Point(220, 13)
		Label9.Name = "Label9"
		Label9.Size = New Size(122, 18)
		Label9.TabIndex = 11
		Label9.Text = "DATA UTAMA"
		' 
		' Label8
		' 
		Label8.AutoSize = True
		Label8.Location = New Point(351, 119)
		Label8.Name = "Label8"
		Label8.Size = New Size(48, 20)
		Label8.TabIndex = 10
		Label8.Text = "Divisi:"
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.Location = New Point(16, 124)
		Label6.Name = "Label6"
		Label6.Size = New Size(100, 20)
		Label6.TabIndex = 8
		Label6.Text = "Tanggal Lahir:"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Location = New Point(16, 89)
		Label5.Name = "Label5"
		Label5.Size = New Size(89, 20)
		Label5.TabIndex = 7
		Label5.Text = "ID Anggota:"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Location = New Point(16, 56)
		Label4.Name = "Label4"
		Label4.Size = New Size(52, 20)
		Label4.TabIndex = 6
		Label4.Text = "Nama:"
		' 
		' cmbDivisi
		' 
		cmbDivisi.FormattingEnabled = True
		cmbDivisi.Items.AddRange(New Object() {"Divisi Acara", "Divisi Humas", "Divisi Konsumsi", "Divisi Kesehatan", "Divisi Perlengkapan", "Divisi Publikasi dan Dokumentasi", "Divisi Tata ruang"})
		cmbDivisi.Location = New Point(351, 142)
		cmbDivisi.Name = "cmbDivisi"
		cmbDivisi.Size = New Size(178, 28)
		cmbDivisi.TabIndex = 5
		' 
		' dtpLahir
		' 
		dtpLahir.Format = DateTimePickerFormat.Short
		dtpLahir.Location = New Point(128, 119)
		dtpLahir.Name = "dtpLahir"
		dtpLahir.Size = New Size(178, 27)
		dtpLahir.TabIndex = 2
		' 
		' txtID
		' 
		txtID.Location = New Point(128, 86)
		txtID.Name = "txtID"
		txtID.Size = New Size(175, 27)
		txtID.TabIndex = 1
		' 
		' txtNama
		' 
		txtNama.Location = New Point(128, 53)
		txtNama.Name = "txtNama"
		txtNama.Size = New Size(175, 27)
		txtNama.TabIndex = 0
		' 
		' tcKontakInfo
		' 
		tcKontakInfo.BackColor = Color.BlanchedAlmond
		tcKontakInfo.Controls.Add(Label12)
		tcKontakInfo.Controls.Add(Label11)
		tcKontakInfo.Controls.Add(Label10)
		tcKontakInfo.Controls.Add(Label3)
		tcKontakInfo.Controls.Add(mtxtNoHP)
		tcKontakInfo.Controls.Add(txtAlamat)
		tcKontakInfo.Controls.Add(txtEmail)
		tcKontakInfo.Location = New Point(4, 29)
		tcKontakInfo.Name = "tcKontakInfo"
		tcKontakInfo.Padding = New Padding(3)
		tcKontakInfo.Size = New Size(590, 216)
		tcKontakInfo.TabIndex = 1
		tcKontakInfo.Text = "Kontak dan Info"
		' 
		' Label12
		' 
		Label12.AutoSize = True
		Label12.Location = New Point(45, 155)
		Label12.Name = "Label12"
		Label12.Size = New Size(60, 20)
		Label12.TabIndex = 9
		Label12.Text = "Alamat:"
		' 
		' Label11
		' 
		Label11.AutoSize = True
		Label11.Location = New Point(45, 112)
		Label11.Name = "Label11"
		Label11.Size = New Size(49, 20)
		Label11.TabIndex = 8
		Label11.Text = "Email:"
		' 
		' Label10
		' 
		Label10.AutoSize = True
		Label10.Location = New Point(45, 71)
		Label10.Name = "Label10"
		Label10.Size = New Size(58, 20)
		Label10.TabIndex = 7
		Label10.Text = "No. HP:"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.BackColor = Color.Transparent
		Label3.Font = New Font("Perpetua Titling MT", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label3.ForeColor = Color.ForestGreen
		Label3.Location = New Point(209, 18)
		Label3.Name = "Label3"
		Label3.Size = New Size(165, 18)
		Label3.TabIndex = 4
		Label3.Text = "KONTAK DAN INFO"
		' 
		' mtxtNoHP
		' 
		mtxtNoHP.Location = New Point(142, 68)
		mtxtNoHP.Mask = "0000-0000-0000"
		mtxtNoHP.Name = "mtxtNoHP"
		mtxtNoHP.Size = New Size(125, 27)
		mtxtNoHP.TabIndex = 2
		' 
		' txtAlamat
		' 
		txtAlamat.Location = New Point(142, 155)
		txtAlamat.Name = "txtAlamat"
		txtAlamat.Size = New Size(205, 27)
		txtAlamat.TabIndex = 1
		' 
		' txtEmail
		' 
		txtEmail.Location = New Point(142, 112)
		txtEmail.Name = "txtEmail"
		txtEmail.Size = New Size(205, 27)
		txtEmail.TabIndex = 0
		' 
		' tcProfilAktivitas
		' 
		tcProfilAktivitas.BackColor = Color.BlanchedAlmond
		tcProfilAktivitas.Controls.Add(btnCetak)
		tcProfilAktivitas.Controls.Add(grupAktivitas)
		tcProfilAktivitas.Controls.Add(grupPeran)
		tcProfilAktivitas.Controls.Add(Label2)
		tcProfilAktivitas.Controls.Add(btnBrowse)
		tcProfilAktivitas.Controls.Add(picFoto)
		tcProfilAktivitas.Location = New Point(4, 29)
		tcProfilAktivitas.Name = "tcProfilAktivitas"
		tcProfilAktivitas.Padding = New Padding(3)
		tcProfilAktivitas.Size = New Size(590, 216)
		tcProfilAktivitas.TabIndex = 2
		tcProfilAktivitas.Text = "Profil dan Aktifitas"
		' 
		' btnCetak
		' 
		btnCetak.BackColor = Color.Snow
		btnCetak.Location = New Point(263, 165)
		btnCetak.Name = "btnCetak"
		btnCetak.Size = New Size(218, 29)
		btnCetak.TabIndex = 6
		btnCetak.Text = "Simpan dan Cetak Kartu"
		btnCetak.UseVisualStyleBackColor = False
		' 
		' grupAktivitas
		' 
		grupAktivitas.BackColor = Color.SeaShell
		grupAktivitas.Controls.Add(cbLingkungan)
		grupAktivitas.Controls.Add(cbBantuan)
		grupAktivitas.Controls.Add(cbKesehatan)
		grupAktivitas.Controls.Add(cbKampanye)
		grupAktivitas.Controls.Add(cbSosial)
		grupAktivitas.Controls.Add(cbEvent)
		grupAktivitas.Controls.Add(cbDonasi)
		grupAktivitas.Controls.Add(cbMengajar)
		grupAktivitas.Location = New Point(286, 34)
		grupAktivitas.Name = "grupAktivitas"
		grupAktivitas.Size = New Size(293, 125)
		grupAktivitas.TabIndex = 5
		grupAktivitas.TabStop = False
		grupAktivitas.Text = "Aktivitas"
		' 
		' cbLingkungan
		' 
		cbLingkungan.AutoSize = True
		cbLingkungan.Location = New Point(125, 86)
		cbLingkungan.Name = "cbLingkungan"
		cbLingkungan.Size = New Size(144, 24)
		cbLingkungan.TabIndex = 7
		cbLingkungan.Text = "Bakti Lingkungan"
		cbLingkungan.UseVisualStyleBackColor = True
		' 
		' cbBantuan
		' 
		cbBantuan.AutoSize = True
		cbBantuan.Location = New Point(125, 65)
		cbBantuan.Name = "cbBantuan"
		cbBantuan.Size = New Size(151, 24)
		cbBantuan.TabIndex = 6
		cbBantuan.Text = "Distribusi Bantuan"
		cbBantuan.UseVisualStyleBackColor = True
		' 
		' cbKesehatan
		' 
		cbKesehatan.AutoSize = True
		cbKesehatan.Location = New Point(125, 46)
		cbKesehatan.Name = "cbKesehatan"
		cbKesehatan.Size = New Size(162, 24)
		cbKesehatan.TabIndex = 5
		cbKesehatan.Text = "Kegiatan Kesehatan"
		cbKesehatan.UseVisualStyleBackColor = True
		' 
		' cbKampanye
		' 
		cbKampanye.AutoSize = True
		cbKampanye.Location = New Point(125, 27)
		cbKampanye.Name = "cbKampanye"
		cbKampanye.Size = New Size(144, 24)
		cbKampanye.TabIndex = 4
		cbKampanye.Text = "Kampanye Sosial"
		cbKampanye.UseVisualStyleBackColor = True
		' 
		' cbSosial
		' 
		cbSosial.AutoSize = True
		cbSosial.Location = New Point(16, 86)
		cbSosial.Name = "cbSosial"
		cbSosial.Size = New Size(107, 24)
		cbSosial.TabIndex = 3
		cbSosial.Text = "Bakti Sosial"
		cbSosial.UseVisualStyleBackColor = True
		' 
		' cbEvent
		' 
		cbEvent.AutoSize = True
		cbEvent.Location = New Point(16, 65)
		cbEvent.Name = "cbEvent"
		cbEvent.Size = New Size(67, 24)
		cbEvent.TabIndex = 2
		cbEvent.Text = "Event"
		cbEvent.UseVisualStyleBackColor = True
		' 
		' cbDonasi
		' 
		cbDonasi.AutoSize = True
		cbDonasi.Location = New Point(16, 46)
		cbDonasi.Name = "cbDonasi"
		cbDonasi.Size = New Size(77, 24)
		cbDonasi.TabIndex = 1
		cbDonasi.Text = "Donasi"
		cbDonasi.UseVisualStyleBackColor = True
		' 
		' cbMengajar
		' 
		cbMengajar.AutoSize = True
		cbMengajar.Location = New Point(16, 26)
		cbMengajar.Name = "cbMengajar"
		cbMengajar.Size = New Size(94, 24)
		cbMengajar.TabIndex = 0
		cbMengajar.Text = "Mengajar"
		cbMengajar.UseVisualStyleBackColor = True
		' 
		' grupPeran
		' 
		grupPeran.BackColor = Color.SeaShell
		grupPeran.Controls.Add(rbAdmin)
		grupPeran.Controls.Add(rbAnggota)
		grupPeran.Controls.Add(rbKetua)
		grupPeran.Location = New Point(151, 34)
		grupPeran.Name = "grupPeran"
		grupPeran.Size = New Size(129, 125)
		grupPeran.TabIndex = 4
		grupPeran.TabStop = False
		grupPeran.Text = "Peran"
		' 
		' rbAdmin
		' 
		rbAdmin.AutoSize = True
		rbAdmin.Location = New Point(8, 85)
		rbAdmin.Name = "rbAdmin"
		rbAdmin.Size = New Size(74, 24)
		rbAdmin.TabIndex = 7
		rbAdmin.TabStop = True
		rbAdmin.Text = "Admin"
		rbAdmin.UseVisualStyleBackColor = True
		' 
		' rbAnggota
		' 
		rbAnggota.AutoSize = True
		rbAnggota.Location = New Point(8, 56)
		rbAnggota.Name = "rbAnggota"
		rbAnggota.Size = New Size(88, 24)
		rbAnggota.TabIndex = 6
		rbAnggota.TabStop = True
		rbAnggota.Text = "Anggota"
		rbAnggota.UseVisualStyleBackColor = True
		' 
		' rbKetua
		' 
		rbKetua.AutoSize = True
		rbKetua.Location = New Point(8, 26)
		rbKetua.Name = "rbKetua"
		rbKetua.Size = New Size(68, 24)
		rbKetua.TabIndex = 5
		rbKetua.TabStop = True
		rbKetua.Text = "Ketua"
		rbKetua.UseVisualStyleBackColor = True
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.BackColor = Color.Transparent
		Label2.Font = New Font("Perpetua Titling MT", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label2.ForeColor = Color.ForestGreen
		Label2.Location = New Point(221, 13)
		Label2.Name = "Label2"
		Label2.Size = New Size(197, 18)
		Label2.TabIndex = 3
		Label2.Text = "Profil dan Aktivitas"
		' 
		' btnBrowse
		' 
		btnBrowse.BackColor = Color.Snow
		btnBrowse.Location = New Point(25, 165)
		btnBrowse.Name = "btnBrowse"
		btnBrowse.Size = New Size(94, 29)
		btnBrowse.TabIndex = 1
		btnBrowse.Text = "Browse"
		btnBrowse.UseVisualStyleBackColor = False
		' 
		' picFoto
		' 
		picFoto.BackColor = Color.SeaShell
		picFoto.Location = New Point(9, 13)
		picFoto.Name = "picFoto"
		picFoto.Size = New Size(125, 146)
		picFoto.TabIndex = 0
		picFoto.TabStop = False
		' 
		' Panel2
		' 
		Panel2.BackColor = Color.Orange
		Panel2.Location = New Point(0, 121)
		Panel2.Name = "Panel2"
		Panel2.Size = New Size(800, 12)
		Panel2.TabIndex = 5
		' 
		' ErrorProvider1
		' 
		ErrorProvider1.ContainerControl = Me
		' 
		' OpenFileDialog1
		' 
		OpenFileDialog1.FileName = "OpenFileDialog1"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8.0F, 20.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackgroundImage = My.Resources.Resources.bg_volunteer
		BackgroundImageLayout = ImageLayout.Stretch
		ClientSize = New Size(800, 450)
		Controls.Add(Panel2)
		Controls.Add(TabControl1)
		Controls.Add(Panel1)
		Controls.Add(MenuStrip1)
		MainMenuStrip = MenuStrip1
		Name = "Form1"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Form1"
		MenuStrip1.ResumeLayout(False)
		MenuStrip1.PerformLayout()
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		Panel1.ResumeLayout(False)
		Panel1.PerformLayout()
		TabControl1.ResumeLayout(False)
		tcDataUtama.ResumeLayout(False)
		tcDataUtama.PerformLayout()
		grupJK.ResumeLayout(False)
		grupJK.PerformLayout()
		tcKontakInfo.ResumeLayout(False)
		tcKontakInfo.PerformLayout()
		tcProfilAktivitas.ResumeLayout(False)
		tcProfilAktivitas.PerformLayout()
		grupAktivitas.ResumeLayout(False)
		grupAktivitas.PerformLayout()
		grupPeran.ResumeLayout(False)
		grupPeran.PerformLayout()
		CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents mnuInput As ToolStripMenuItem
	Friend WithEvents mnuKartu As ToolStripMenuItem
	Friend WithEvents mnuSimpan As ToolStripMenuItem
	Friend WithEvents mnuBuka As ToolStripMenuItem
	Friend WithEvents mnuKeluar As ToolStripMenuItem
	Friend WithEvents Label1 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Panel1 As Panel
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents tcDataUtama As TabPage
	Friend WithEvents tcKontakInfo As TabPage
	Friend WithEvents tcProfilAktivitas As TabPage
	Friend WithEvents txtNama As TextBox
	Friend WithEvents rbLaki As RadioButton
	Friend WithEvents dtpLahir As DateTimePicker
	Friend WithEvents txtID As TextBox
	Friend WithEvents cmbDivisi As ComboBox
	Friend WithEvents rbPerempuan As RadioButton
	Friend WithEvents mtxtNoHP As MaskedTextBox
	Friend WithEvents txtAlamat As TextBox
	Friend WithEvents txtEmail As TextBox
	Friend WithEvents btnBrowse As Button
	Friend WithEvents picFoto As PictureBox
	Friend WithEvents Label2 As Label
	Friend WithEvents grupAktivitas As GroupBox
	Friend WithEvents btnCetak As Button
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents cbMengajar As CheckBox
	Friend WithEvents cbLingkungan As CheckBox
	Friend WithEvents cbBantuan As CheckBox
	Friend WithEvents cbKesehatan As CheckBox
	Friend WithEvents cbKampanye As CheckBox
	Friend WithEvents cbSosial As CheckBox
	Friend WithEvents cbEvent As CheckBox
	Friend WithEvents cbDonasi As CheckBox
	Friend WithEvents grupPeran As GroupBox
	Friend WithEvents rbAnggota As RadioButton
	Friend WithEvents rbKetua As RadioButton
	Friend WithEvents rbAdmin As RadioButton
	Friend WithEvents Panel2 As Panel
	Friend WithEvents grupJK As GroupBox
	Friend WithEvents ErrorProvider1 As ErrorProvider
	Friend WithEvents SaveFileDialog1 As SaveFileDialog
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem

End Class
