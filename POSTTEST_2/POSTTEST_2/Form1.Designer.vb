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
		Label1 = New Label()
		Label2 = New Label()
		Label3 = New Label()
		Label4 = New Label()
		txtJudul = New TextBox()
		txtGenre = New TextBox()
		txtHapus = New TextBox()
		GroupBox1 = New GroupBox()
		btnTambah = New Button()
		btnHapus = New Button()
		GroupBox2 = New GroupBox()
		lstBuku = New ListBox()
		GroupBox1.SuspendLayout()
		GroupBox2.SuspendLayout()
		SuspendLayout()
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(12, 31)
		Label1.Name = "Label1"
		Label1.Size = New Size(79, 20)
		Label1.TabIndex = 0
		Label1.Text = "Judul Buku"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(12, 69)
		Label2.Name = "Label2"
		Label2.Size = New Size(48, 20)
		Label2.TabIndex = 1
		Label2.Text = "Genre"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(28, 28)
		Label3.Name = "Label3"
		Label3.Size = New Size(79, 20)
		Label3.TabIndex = 2
		Label3.Text = "Judul Buku"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Font = New Font("Segoe UI Emoji", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label4.ForeColor = SystemColors.ActiveCaption
		Label4.Location = New Point(31, 18)
		Label4.Name = "Label4"
		Label4.Size = New Size(324, 33)
		Label4.TabIndex = 3
		Label4.Text = "Kelola Buku Perpustakaan"
		' 
		' txtJudul
		' 
		txtJudul.Location = New Point(140, 27)
		txtJudul.Margin = New Padding(3, 4, 3, 4)
		txtJudul.Name = "txtJudul"
		txtJudul.Size = New Size(125, 27)
		txtJudul.TabIndex = 4
		' 
		' txtGenre
		' 
		txtGenre.Location = New Point(140, 66)
		txtGenre.Margin = New Padding(3, 4, 3, 4)
		txtGenre.Name = "txtGenre"
		txtGenre.Size = New Size(125, 27)
		txtGenre.TabIndex = 5
		' 
		' txtHapus
		' 
		txtHapus.Location = New Point(126, 27)
		txtHapus.Margin = New Padding(3, 4, 3, 4)
		txtHapus.Name = "txtHapus"
		txtHapus.Size = New Size(125, 27)
		txtHapus.TabIndex = 6
		' 
		' GroupBox1
		' 
		GroupBox1.BackColor = SystemColors.GradientInactiveCaption
		GroupBox1.Controls.Add(btnTambah)
		GroupBox1.Controls.Add(txtGenre)
		GroupBox1.Controls.Add(txtJudul)
		GroupBox1.Controls.Add(Label2)
		GroupBox1.Controls.Add(Label1)
		GroupBox1.Location = New Point(31, 65)
		GroupBox1.Margin = New Padding(3, 4, 3, 4)
		GroupBox1.Name = "GroupBox1"
		GroupBox1.Padding = New Padding(3, 4, 3, 4)
		GroupBox1.Size = New Size(274, 169)
		GroupBox1.TabIndex = 7
		GroupBox1.TabStop = False
		GroupBox1.Text = "Tambah Buku"
		' 
		' btnTambah
		' 
		btnTambah.BackColor = SystemColors.ControlLight
		btnTambah.Location = New Point(171, 134)
		btnTambah.Margin = New Padding(3, 4, 3, 4)
		btnTambah.Name = "btnTambah"
		btnTambah.Size = New Size(94, 29)
		btnTambah.TabIndex = 8
		btnTambah.Text = "Tambah"
		btnTambah.UseVisualStyleBackColor = False
		' 
		' btnHapus
		' 
		btnHapus.BackColor = SystemColors.ControlLight
		btnHapus.Location = New Point(157, 132)
		btnHapus.Margin = New Padding(3, 4, 3, 4)
		btnHapus.Name = "btnHapus"
		btnHapus.Size = New Size(94, 29)
		btnHapus.TabIndex = 8
		btnHapus.Text = "Hapus"
		btnHapus.UseVisualStyleBackColor = False
		' 
		' GroupBox2
		' 
		GroupBox2.BackColor = SystemColors.GradientInactiveCaption
		GroupBox2.Controls.Add(btnHapus)
		GroupBox2.Controls.Add(txtHapus)
		GroupBox2.Controls.Add(Label3)
		GroupBox2.Location = New Point(386, 67)
		GroupBox2.Margin = New Padding(3, 4, 3, 4)
		GroupBox2.Name = "GroupBox2"
		GroupBox2.Padding = New Padding(3, 4, 3, 4)
		GroupBox2.Size = New Size(267, 169)
		GroupBox2.TabIndex = 9
		GroupBox2.TabStop = False
		GroupBox2.Text = "Hapus Buku"
		' 
		' lstBuku
		' 
		lstBuku.BackColor = SystemColors.ActiveCaption
		lstBuku.FormattingEnabled = True
		lstBuku.Location = New Point(175, 279)
		lstBuku.Margin = New Padding(3, 4, 3, 4)
		lstBuku.Name = "lstBuku"
		lstBuku.Size = New Size(318, 124)
		lstBuku.TabIndex = 10
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = SystemColors.MenuBar
		ClientSize = New Size(710, 449)
		Controls.Add(lstBuku)
		Controls.Add(GroupBox2)
		Controls.Add(GroupBox1)
		Controls.Add(Label4)
		Margin = New Padding(3, 4, 3, 4)
		Name = "Form1"
		Text = "Form1"
		GroupBox1.ResumeLayout(False)
		GroupBox1.PerformLayout()
		GroupBox2.ResumeLayout(False)
		GroupBox2.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents txtJudul As TextBox
	Friend WithEvents txtGenre As TextBox
	Friend WithEvents txtHapus As TextBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents btnTambah As Button
	Friend WithEvents btnHapus As Button
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents lstBuku As ListBox

End Class
