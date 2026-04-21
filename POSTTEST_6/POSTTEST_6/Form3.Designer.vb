<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		components = New ComponentModel.Container()
		Panel1 = New Panel()
		Label7 = New Label()
		Label9 = New Label()
		txtGenre = New TextBox()
		txtKodeGenre = New TextBox()
		Label4 = New Label()
		Label5 = New Label()
		dgvGenre = New DataGridView()
		Label8 = New Label()
		txtSearch = New TextBox()
		btnBatal = New Button()
		btnHapus = New Button()
		btnUbah = New Button()
		btnSimpan = New Button()
		Panel2 = New Panel()
		ErrorProvider1 = New ErrorProvider(components)
		btnkeForm1 = New Button()
		Panel1.SuspendLayout()
		CType(dgvGenre, ComponentModel.ISupportInitialize).BeginInit()
		Panel2.SuspendLayout()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' Panel1
		' 
		Panel1.BackColor = Color.MistyRose
		Panel1.Controls.Add(Label7)
		Panel1.Location = New Point(1, 1)
		Panel1.Name = "Panel1"
		Panel1.Size = New Size(801, 50)
		Panel1.TabIndex = 1
		' 
		' Label7
		' 
		Label7.AutoSize = True
		Label7.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label7.ForeColor = Color.RosyBrown
		Label7.Location = New Point(130, 8)
		Label7.Name = "Label7"
		Label7.Size = New Size(503, 28)
		Label7.TabIndex = 0
		Label7.Text = "SISTEM MANAJEMEN JUDUL WEBTOON FAVORIT"
		' 
		' Label9
		' 
		Label9.AutoSize = True
		Label9.BackColor = Color.Transparent
		Label9.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label9.ForeColor = Color.MistyRose
		Label9.Location = New Point(235, 0)
		Label9.Name = "Label9"
		Label9.Size = New Size(290, 28)
		Label9.TabIndex = 9
		Label9.Text = "Pengaturan Genre Webtoon"
		' 
		' txtGenre
		' 
		txtGenre.Location = New Point(157, 142)
		txtGenre.Name = "txtGenre"
		txtGenre.Size = New Size(183, 27)
		txtGenre.TabIndex = 13
		' 
		' txtKodeGenre
		' 
		txtKodeGenre.Location = New Point(157, 92)
		txtKodeGenre.Name = "txtKodeGenre"
		txtKodeGenre.Size = New Size(183, 27)
		txtKodeGenre.TabIndex = 12
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.BackColor = Color.Transparent
		Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label4.ForeColor = Color.RosyBrown
		Label4.Location = New Point(27, 146)
		Label4.Name = "Label4"
		Label4.Size = New Size(57, 23)
		Label4.TabIndex = 11
		Label4.Text = "Genre"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.BackColor = Color.Transparent
		Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label5.ForeColor = Color.RosyBrown
		Label5.Location = New Point(27, 96)
		Label5.Name = "Label5"
		Label5.Size = New Size(103, 23)
		Label5.TabIndex = 10
		Label5.Text = "Kode Genre"
		' 
		' dgvGenre
		' 
		dgvGenre.BackgroundColor = SystemColors.ButtonHighlight
		dgvGenre.BorderStyle = BorderStyle.None
		dgvGenre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvGenre.Location = New Point(356, 131)
		dgvGenre.Name = "dgvGenre"
		dgvGenre.RowHeadersWidth = 51
		dgvGenre.Size = New Size(414, 177)
		dgvGenre.TabIndex = 14
		' 
		' Label8
		' 
		Label8.AutoSize = True
		Label8.BackColor = Color.RosyBrown
		Label8.ForeColor = SystemColors.ButtonHighlight
		Label8.Location = New Point(356, 92)
		Label8.Name = "Label8"
		Label8.Size = New Size(56, 20)
		Label8.TabIndex = 20
		Label8.Text = "Search:"
		' 
		' txtSearch
		' 
		txtSearch.Location = New Point(428, 89)
		txtSearch.Name = "txtSearch"
		txtSearch.Size = New Size(342, 27)
		txtSearch.TabIndex = 19
		' 
		' btnBatal
		' 
		btnBatal.BackColor = Color.MistyRose
		btnBatal.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnBatal.ForeColor = Color.RosyBrown
		btnBatal.Location = New Point(252, 192)
		btnBatal.Name = "btnBatal"
		btnBatal.Size = New Size(88, 42)
		btnBatal.TabIndex = 24
		btnBatal.Text = "Batal"
		btnBatal.UseVisualStyleBackColor = False
		' 
		' btnHapus
		' 
		btnHapus.BackColor = Color.RosyBrown
		btnHapus.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnHapus.ForeColor = Color.SeaShell
		btnHapus.Location = New Point(248, 240)
		btnHapus.Name = "btnHapus"
		btnHapus.Size = New Size(92, 43)
		btnHapus.TabIndex = 23
		btnHapus.Text = "Hapus"
		btnHapus.UseVisualStyleBackColor = False
		' 
		' btnUbah
		' 
		btnUbah.BackColor = Color.RosyBrown
		btnUbah.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnUbah.ForeColor = Color.SeaShell
		btnUbah.Location = New Point(143, 240)
		btnUbah.Name = "btnUbah"
		btnUbah.Size = New Size(92, 43)
		btnUbah.TabIndex = 22
		btnUbah.Text = "Ubah"
		btnUbah.UseVisualStyleBackColor = False
		' 
		' btnSimpan
		' 
		btnSimpan.BackColor = Color.MistyRose
		btnSimpan.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnSimpan.ForeColor = Color.RosyBrown
		btnSimpan.Location = New Point(143, 192)
		btnSimpan.Name = "btnSimpan"
		btnSimpan.Size = New Size(92, 42)
		btnSimpan.TabIndex = 21
		btnSimpan.Text = "Simpan"
		btnSimpan.UseVisualStyleBackColor = False
		' 
		' Panel2
		' 
		Panel2.BackColor = Color.RosyBrown
		Panel2.Controls.Add(Label9)
		Panel2.Location = New Point(1, 40)
		Panel2.Name = "Panel2"
		Panel2.Size = New Size(801, 33)
		Panel2.TabIndex = 2
		' 
		' ErrorProvider1
		' 
		ErrorProvider1.ContainerControl = Me
		' 
		' btnkeForm1
		' 
		btnkeForm1.BackColor = Color.RosyBrown
		btnkeForm1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnkeForm1.ForeColor = Color.SeaShell
		btnkeForm1.Location = New Point(475, 323)
		btnkeForm1.Name = "btnkeForm1"
		btnkeForm1.Size = New Size(159, 34)
		btnkeForm1.TabIndex = 25
		btnkeForm1.Text = "Data Webtoon->"
		btnkeForm1.UseVisualStyleBackColor = False
		' 
		' Form3
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.SeaShell
		ClientSize = New Size(800, 382)
		Controls.Add(btnkeForm1)
		Controls.Add(Panel2)
		Controls.Add(btnBatal)
		Controls.Add(btnHapus)
		Controls.Add(btnUbah)
		Controls.Add(btnSimpan)
		Controls.Add(Label8)
		Controls.Add(txtSearch)
		Controls.Add(dgvGenre)
		Controls.Add(txtGenre)
		Controls.Add(txtKodeGenre)
		Controls.Add(Label4)
		Controls.Add(Label5)
		Controls.Add(Panel1)
		Name = "Form3"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Form3"
		Panel1.ResumeLayout(False)
		Panel1.PerformLayout()
		CType(dgvGenre, ComponentModel.ISupportInitialize).EndInit()
		Panel2.ResumeLayout(False)
		Panel2.PerformLayout()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents Label7 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents txtGenre As TextBox
	Friend WithEvents txtKodeGenre As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents dgvGenre As DataGridView
	Friend WithEvents Label8 As Label
	Friend WithEvents txtSearch As TextBox
	Friend WithEvents btnBatal As Button
	Friend WithEvents btnHapus As Button
	Friend WithEvents btnUbah As Button
	Friend WithEvents btnSimpan As Button
	Friend WithEvents Panel2 As Panel
	Friend WithEvents ErrorProvider1 As ErrorProvider
	Friend WithEvents btnkeForm1 As Button
End Class
