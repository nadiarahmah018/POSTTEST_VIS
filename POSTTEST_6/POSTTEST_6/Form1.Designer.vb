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
		Panel2 = New Panel()
		numRating = New NumericUpDown()
		ErrorProvider1 = New ErrorProvider(components)
		btnDetail = New Button()
		Panel1 = New Panel()
		Label7 = New Label()
		Panel3 = New Panel()
		Label10 = New Label()
		btnGenre = New Button()
		CType(dgvWebtoon, ComponentModel.ISupportInitialize).BeginInit()
		Panel2.SuspendLayout()
		CType(numRating, ComponentModel.ISupportInitialize).BeginInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
		Panel1.SuspendLayout()
		Panel3.SuspendLayout()
		SuspendLayout()
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.BackColor = Color.MistyRose
		Label1.Location = New Point(36, 125)
		Label1.Name = "Label1"
		Label1.Size = New Size(89, 20)
		Label1.TabIndex = 1
		Label1.Text = "ID Webtoon"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.BackColor = Color.MistyRose
		Label2.Location = New Point(37, 154)
		Label2.Name = "Label2"
		Label2.Size = New Size(43, 20)
		Label2.TabIndex = 2
		Label2.Text = "Judul"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.BackColor = Color.MistyRose
		Label3.Location = New Point(37, 225)
		Label3.Name = "Label3"
		Label3.Size = New Size(54, 20)
		Label3.TabIndex = 3
		Label3.Text = "Author"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.BackColor = Color.MistyRose
		Label4.Location = New Point(37, 259)
		Label4.Name = "Label4"
		Label4.Size = New Size(52, 20)
		Label4.TabIndex = 4
		Label4.Text = "Rating"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.BackColor = Color.MistyRose
		Label5.Location = New Point(36, 299)
		Label5.Name = "Label5"
		Label5.Size = New Size(49, 20)
		Label5.TabIndex = 5
		Label5.Text = "Status"
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.BackColor = Color.MistyRose
		Label6.Location = New Point(37, 189)
		Label6.Name = "Label6"
		Label6.Size = New Size(48, 20)
		Label6.TabIndex = 6
		Label6.Text = "Genre"
		' 
		' txtIdWebtoon
		' 
		txtIdWebtoon.Location = New Point(132, 122)
		txtIdWebtoon.Name = "txtIdWebtoon"
		txtIdWebtoon.Size = New Size(183, 27)
		txtIdWebtoon.TabIndex = 7
		' 
		' txtJudul
		' 
		txtJudul.Location = New Point(132, 155)
		txtJudul.Name = "txtJudul"
		txtJudul.Size = New Size(183, 27)
		txtJudul.TabIndex = 8
		' 
		' txtAuthor
		' 
		txtAuthor.Location = New Point(132, 225)
		txtAuthor.Name = "txtAuthor"
		txtAuthor.Size = New Size(183, 27)
		txtAuthor.TabIndex = 9
		' 
		' cmbGenre
		' 
		cmbGenre.FormattingEnabled = True
		cmbGenre.Location = New Point(132, 191)
		cmbGenre.Name = "cmbGenre"
		cmbGenre.Size = New Size(183, 28)
		cmbGenre.TabIndex = 10
		' 
		' cmbStatus
		' 
		cmbStatus.FormattingEnabled = True
		cmbStatus.Items.AddRange(New Object() {"On Going", "Hiatus", "Tamat", "Daily Pass", "Canvas"})
		cmbStatus.Location = New Point(132, 296)
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
		btnSimpan.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnSimpan.ForeColor = Color.RosyBrown
		btnSimpan.Location = New Point(129, 330)
		btnSimpan.Name = "btnSimpan"
		btnSimpan.Size = New Size(90, 47)
		btnSimpan.TabIndex = 13
		btnSimpan.Text = "Simpan"
		btnSimpan.UseVisualStyleBackColor = False
		' 
		' btnUbah
		' 
		btnUbah.BackColor = Color.RosyBrown
		btnUbah.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnUbah.ForeColor = Color.MistyRose
		btnUbah.Location = New Point(129, 383)
		btnUbah.Name = "btnUbah"
		btnUbah.Size = New Size(90, 49)
		btnUbah.TabIndex = 14
		btnUbah.Text = "Ubah"
		btnUbah.UseVisualStyleBackColor = False
		' 
		' btnHapus
		' 
		btnHapus.BackColor = Color.RosyBrown
		btnHapus.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
		btnHapus.ForeColor = Color.MistyRose
		btnHapus.Location = New Point(225, 383)
		btnHapus.Name = "btnHapus"
		btnHapus.Size = New Size(91, 49)
		btnHapus.TabIndex = 15
		btnHapus.Text = "Hapus"
		btnHapus.UseVisualStyleBackColor = False
		' 
		' btnBatal
		' 
		btnBatal.BackColor = Color.MistyRose
		btnBatal.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnBatal.ForeColor = Color.RosyBrown
		btnBatal.Location = New Point(225, 330)
		btnBatal.Name = "btnBatal"
		btnBatal.Size = New Size(91, 47)
		btnBatal.TabIndex = 16
		btnBatal.Text = "Batal"
		btnBatal.UseVisualStyleBackColor = False
		' 
		' txtSearch
		' 
		txtSearch.Location = New Point(421, 119)
		txtSearch.Name = "txtSearch"
		txtSearch.Size = New Size(354, 27)
		txtSearch.TabIndex = 17
		' 
		' Label8
		' 
		Label8.AutoSize = True
		Label8.BackColor = Color.RosyBrown
		Label8.ForeColor = SystemColors.ButtonHighlight
		Label8.Location = New Point(351, 122)
		Label8.Name = "Label8"
		Label8.Size = New Size(56, 20)
		Label8.TabIndex = 18
		Label8.Text = "Search:"
		' 
		' Panel2
		' 
		Panel2.Controls.Add(dgvWebtoon)
		Panel2.Location = New Point(351, 152)
		Panel2.Name = "Panel2"
		Panel2.Size = New Size(424, 248)
		Panel2.TabIndex = 19
		' 
		' numRating
		' 
		numRating.Location = New Point(133, 259)
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
		btnDetail.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
		btnDetail.ForeColor = Color.RosyBrown
		btnDetail.Location = New Point(351, 408)
		btnDetail.Name = "btnDetail"
		btnDetail.Size = New Size(116, 41)
		btnDetail.TabIndex = 21
		btnDetail.Text = "Lihat Detail"
		btnDetail.UseVisualStyleBackColor = False
		' 
		' Panel1
		' 
		Panel1.BackColor = Color.RosyBrown
		Panel1.Controls.Add(Label7)
		Panel1.Location = New Point(2, 40)
		Panel1.Name = "Panel1"
		Panel1.Size = New Size(815, 33)
		Panel1.TabIndex = 24
		' 
		' Label7
		' 
		Label7.AutoSize = True
		Label7.BackColor = Color.Transparent
		Label7.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label7.ForeColor = Color.MistyRose
		Label7.Location = New Point(254, 0)
		Label7.Name = "Label7"
		Label7.Size = New Size(225, 28)
		Label7.TabIndex = 9
		Label7.Text = "Data Utama Webtoon"
		' 
		' Panel3
		' 
		Panel3.BackColor = Color.MistyRose
		Panel3.Controls.Add(Label10)
		Panel3.Location = New Point(2, 1)
		Panel3.Name = "Panel3"
		Panel3.Size = New Size(815, 50)
		Panel3.TabIndex = 23
		' 
		' Label10
		' 
		Label10.AutoSize = True
		Label10.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label10.ForeColor = Color.RosyBrown
		Label10.Location = New Point(130, 8)
		Label10.Name = "Label10"
		Label10.Size = New Size(503, 28)
		Label10.TabIndex = 0
		Label10.Text = "SISTEM MANAJEMEN JUDUL WEBTOON FAVORIT"
		' 
		' btnGenre
		' 
		btnGenre.BackColor = Color.MistyRose
		btnGenre.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
		btnGenre.ForeColor = Color.RosyBrown
		btnGenre.Location = New Point(668, 408)
		btnGenre.Name = "btnGenre"
		btnGenre.Size = New Size(107, 40)
		btnGenre.TabIndex = 25
		btnGenre.Text = "Atur Genre"
		btnGenre.UseVisualStyleBackColor = False
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.SeaShell
		ClientSize = New Size(819, 460)
		Controls.Add(btnGenre)
		Controls.Add(Panel1)
		Controls.Add(Panel3)
		Controls.Add(btnDetail)
		Controls.Add(numRating)
		Controls.Add(Panel2)
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
		Name = "Form1"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Form1"
		CType(dgvWebtoon, ComponentModel.ISupportInitialize).EndInit()
		Panel2.ResumeLayout(False)
		CType(numRating, ComponentModel.ISupportInitialize).EndInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
		Panel1.ResumeLayout(False)
		Panel1.PerformLayout()
		Panel3.ResumeLayout(False)
		Panel3.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
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
	Friend WithEvents Panel2 As Panel
	Friend WithEvents numRating As NumericUpDown
	Friend WithEvents ErrorProvider1 As ErrorProvider
	Friend WithEvents btnDetail As Button
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Label7 As Label
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Label10 As Label
	Friend WithEvents btnGenre As Button

End Class
