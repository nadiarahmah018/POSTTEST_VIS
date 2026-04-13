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
		Panel1 = New Panel()
		Label7 = New Label()
		Label1 = New Label()
		Label2 = New Label()
		Label3 = New Label()
		Label4 = New Label()
		Label5 = New Label()
		Label6 = New Label()
		txtIdWebtoon = New TextBox()
		txtJudul = New TextBox()
		txtAuthor = New TextBox()
		cmbGenre = New ComboBox()
		cmbStatus = New ComboBox()
		dgvWebtoon = New DataGridView()
		btnSimpan = New Button()
		btnUbah = New Button()
		btnHapus = New Button()
		btnBatal = New Button()
		txtSearch = New TextBox()
		Label8 = New Label()
		Label9 = New Label()
		Panel2 = New Panel()
		numRating = New NumericUpDown()
		ErrorProvider1 = New ErrorProvider(components)
		btnDetail = New Button()
		Panel1.SuspendLayout()
		CType(dgvWebtoon, ComponentModel.ISupportInitialize).BeginInit()
		Panel2.SuspendLayout()
		CType(numRating, ComponentModel.ISupportInitialize).BeginInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' Panel1
		' 
		Panel1.BackColor = Color.MistyRose
		Panel1.Controls.Add(Label7)
		Panel1.Location = New Point(0, 0)
		Panel1.Name = "Panel1"
		Panel1.Size = New Size(801, 50)
		Panel1.TabIndex = 0
		' 
		' Label7
		' 
		Label7.AutoSize = True
		Label7.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label7.ForeColor = Color.RosyBrown
		Label7.Location = New Point(12, 9)
		Label7.Name = "Label7"
		Label7.Size = New Size(503, 28)
		Label7.TabIndex = 0
		Label7.Text = "SISTEM MANAJEMEN JUDUL WEBTOON FAVORIT"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.BackColor = Color.MistyRose
		Label1.Location = New Point(27, 99)
		Label1.Name = "Label1"
		Label1.Size = New Size(89, 20)
		Label1.TabIndex = 1
		Label1.Text = "ID Webtoon"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.BackColor = Color.MistyRose
		Label2.Location = New Point(28, 128)
		Label2.Name = "Label2"
		Label2.Size = New Size(43, 20)
		Label2.TabIndex = 2
		Label2.Text = "Judul"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.BackColor = Color.MistyRose
		Label3.Location = New Point(28, 199)
		Label3.Name = "Label3"
		Label3.Size = New Size(54, 20)
		Label3.TabIndex = 3
		Label3.Text = "Author"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.BackColor = Color.MistyRose
		Label4.Location = New Point(28, 233)
		Label4.Name = "Label4"
		Label4.Size = New Size(52, 20)
		Label4.TabIndex = 4
		Label4.Text = "Rating"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.BackColor = Color.MistyRose
		Label5.Location = New Point(27, 273)
		Label5.Name = "Label5"
		Label5.Size = New Size(49, 20)
		Label5.TabIndex = 5
		Label5.Text = "Status"
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.BackColor = Color.MistyRose
		Label6.Location = New Point(28, 163)
		Label6.Name = "Label6"
		Label6.Size = New Size(48, 20)
		Label6.TabIndex = 6
		Label6.Text = "Genre"
		' 
		' txtIdWebtoon
		' 
		txtIdWebtoon.Location = New Point(123, 96)
		txtIdWebtoon.Name = "txtIdWebtoon"
		txtIdWebtoon.Size = New Size(183, 27)
		txtIdWebtoon.TabIndex = 7
		' 
		' txtJudul
		' 
		txtJudul.Location = New Point(123, 129)
		txtJudul.Name = "txtJudul"
		txtJudul.Size = New Size(183, 27)
		txtJudul.TabIndex = 8
		' 
		' txtAuthor
		' 
		txtAuthor.Location = New Point(123, 199)
		txtAuthor.Name = "txtAuthor"
		txtAuthor.Size = New Size(183, 27)
		txtAuthor.TabIndex = 9
		' 
		' cmbGenre
		' 
		cmbGenre.FormattingEnabled = True
		cmbGenre.Items.AddRange(New Object() {"Drama", "Fantasi", "Kerajaan", "Komedi", "Aksi", "Slice of life", "Romantis", "Thiller", "Horor"})
		cmbGenre.Location = New Point(123, 165)
		cmbGenre.Name = "cmbGenre"
		cmbGenre.Size = New Size(183, 28)
		cmbGenre.TabIndex = 10
		' 
		' cmbStatus
		' 
		cmbStatus.FormattingEnabled = True
		cmbStatus.Items.AddRange(New Object() {"On Going", "Hiatus", "Tamat", "Daily Pass", "Canvas"})
		cmbStatus.Location = New Point(123, 270)
		cmbStatus.Name = "cmbStatus"
		cmbStatus.Size = New Size(183, 28)
		cmbStatus.TabIndex = 11
		' 
		' dgvWebtoon
		' 
		dgvWebtoon.BackgroundColor = SystemColors.ButtonHighlight
		dgvWebtoon.BorderStyle = BorderStyle.None
		dgvWebtoon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvWebtoon.Dock = DockStyle.Fill
		dgvWebtoon.Location = New Point(0, 0)
		dgvWebtoon.Name = "dgvWebtoon"
		dgvWebtoon.RowHeadersWidth = 51
		dgvWebtoon.Size = New Size(424, 248)
		dgvWebtoon.TabIndex = 12
		' 
		' btnSimpan
		' 
		btnSimpan.BackColor = Color.MistyRose
		btnSimpan.Location = New Point(32, 315)
		btnSimpan.Name = "btnSimpan"
		btnSimpan.Size = New Size(71, 29)
		btnSimpan.TabIndex = 13
		btnSimpan.Text = "Simpan"
		btnSimpan.UseVisualStyleBackColor = False
		' 
		' btnUbah
		' 
		btnUbah.BackColor = Color.MistyRose
		btnUbah.Location = New Point(109, 315)
		btnUbah.Name = "btnUbah"
		btnUbah.Size = New Size(63, 29)
		btnUbah.TabIndex = 14
		btnUbah.Text = "Ubah"
		btnUbah.UseVisualStyleBackColor = False
		' 
		' btnHapus
		' 
		btnHapus.BackColor = Color.MistyRose
		btnHapus.Location = New Point(178, 315)
		btnHapus.Name = "btnHapus"
		btnHapus.Size = New Size(60, 29)
		btnHapus.TabIndex = 15
		btnHapus.Text = "Hapus"
		btnHapus.UseVisualStyleBackColor = False
		' 
		' btnBatal
		' 
		btnBatal.BackColor = Color.MistyRose
		btnBatal.Location = New Point(244, 315)
		btnBatal.Name = "btnBatal"
		btnBatal.Size = New Size(63, 29)
		btnBatal.TabIndex = 16
		btnBatal.Text = "Batal"
		btnBatal.UseVisualStyleBackColor = False
		' 
		' txtSearch
		' 
		txtSearch.Location = New Point(418, 63)
		txtSearch.Name = "txtSearch"
		txtSearch.Size = New Size(354, 27)
		txtSearch.TabIndex = 17
		' 
		' Label8
		' 
		Label8.AutoSize = True
		Label8.BackColor = Color.RosyBrown
		Label8.ForeColor = SystemColors.ButtonHighlight
		Label8.Location = New Point(348, 66)
		Label8.Name = "Label8"
		Label8.Size = New Size(56, 20)
		Label8.TabIndex = 18
		Label8.Text = "Search:"
		' 
		' Label9
		' 
		Label9.AutoSize = True
		Label9.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label9.ForeColor = Color.RosyBrown
		Label9.Location = New Point(27, 58)
		Label9.Name = "Label9"
		Label9.Size = New Size(155, 28)
		Label9.TabIndex = 1
		Label9.Text = "Data Webtoon"
		' 
		' Panel2
		' 
		Panel2.Controls.Add(dgvWebtoon)
		Panel2.Location = New Point(348, 96)
		Panel2.Name = "Panel2"
		Panel2.Size = New Size(424, 248)
		Panel2.TabIndex = 19
		' 
		' numRating
		' 
		numRating.Location = New Point(124, 233)
		numRating.Name = "numRating"
		numRating.Size = New Size(183, 27)
		numRating.TabIndex = 20
		' 
		' ErrorProvider1
		' 
		ErrorProvider1.ContainerControl = Me
		' 
		' btnDetail
		' 
		btnDetail.BackColor = Color.MistyRose
		btnDetail.Location = New Point(525, 350)
		btnDetail.Name = "btnDetail"
		btnDetail.Size = New Size(94, 29)
		btnDetail.TabIndex = 21
		btnDetail.Text = "Lihat Detail"
		btnDetail.UseVisualStyleBackColor = False
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.SeaShell
		ClientSize = New Size(801, 390)
		Controls.Add(btnDetail)
		Controls.Add(numRating)
		Controls.Add(Panel2)
		Controls.Add(Label9)
		Controls.Add(Label8)
		Controls.Add(txtSearch)
		Controls.Add(btnBatal)
		Controls.Add(btnHapus)
		Controls.Add(btnUbah)
		Controls.Add(btnSimpan)
		Controls.Add(cmbStatus)
		Controls.Add(cmbGenre)
		Controls.Add(txtAuthor)
		Controls.Add(txtJudul)
		Controls.Add(txtIdWebtoon)
		Controls.Add(Label6)
		Controls.Add(Label5)
		Controls.Add(Label4)
		Controls.Add(Label3)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(Panel1)
		Name = "Form1"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Form1"
		Panel1.ResumeLayout(False)
		Panel1.PerformLayout()
		CType(dgvWebtoon, ComponentModel.ISupportInitialize).EndInit()
		Panel2.ResumeLayout(False)
		CType(numRating, ComponentModel.ISupportInitialize).EndInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents txtIdWebtoon As TextBox
	Friend WithEvents txtJudul As TextBox
	Friend WithEvents txtAuthor As TextBox
	Friend WithEvents cmbGenre As ComboBox
	Friend WithEvents cmbStatus As ComboBox
	Friend WithEvents dgvWebtoon As DataGridView
	Friend WithEvents btnSimpan As Button
	Friend WithEvents btnUbah As Button
	Friend WithEvents btnHapus As Button
	Friend WithEvents btnBatal As Button
	Friend WithEvents txtSearch As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents Panel2 As Panel
	Friend WithEvents numRating As NumericUpDown
	Friend WithEvents ErrorProvider1 As ErrorProvider
	Friend WithEvents btnDetail As Button

End Class
