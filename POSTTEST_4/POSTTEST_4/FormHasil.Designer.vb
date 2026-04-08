<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHasil
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
		Label1 = New Label()
		PictureBox1 = New PictureBox()
		PicProfil = New PictureBox()
		Panel1 = New Panel()
		Panel2 = New Panel()
		PictureBox3 = New PictureBox()
		Label7 = New Label()
		lblAktivitas = New Label()
		lblNoHP = New Label()
		lblID = New Label()
		lblNama = New Label()
		lblDivisi = New Label()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		CType(PicProfil, ComponentModel.ISupportInitialize).BeginInit()
		Panel1.SuspendLayout()
		CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.BackColor = Color.Transparent
		Label1.Font = New Font("Perpetua Titling MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label1.ForeColor = Color.ForestGreen
		Label1.Location = New Point(156, 26)
		Label1.Name = "Label1"
		Label1.Size = New Size(475, 33)
		Label1.TabIndex = 2
		Label1.Text = "VOLUNTEER COMUNITY CARD"
		' 
		' PictureBox1
		' 
		PictureBox1.BackColor = Color.Transparent
		PictureBox1.Image = My.Resources.Resources.logo_volunteer
		PictureBox1.Location = New Point(63, 12)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(72, 62)
		PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
		PictureBox1.TabIndex = 3
		PictureBox1.TabStop = False
		' 
		' PicProfil
		' 
		PicProfil.Location = New Point(62, 164)
		PicProfil.Name = "PicProfil"
		PicProfil.Size = New Size(168, 203)
		PicProfil.SizeMode = PictureBoxSizeMode.StretchImage
		PicProfil.TabIndex = 9
		PicProfil.TabStop = False
		' 
		' Panel1
		' 
		Panel1.BackColor = Color.BlanchedAlmond
		Panel1.Controls.Add(Label1)
		Panel1.Controls.Add(PictureBox1)
		Panel1.Controls.Add(Panel2)
		Panel1.Location = New Point(-1, 0)
		Panel1.Name = "Panel1"
		Panel1.Size = New Size(801, 93)
		Panel1.TabIndex = 10
		' 
		' Panel2
		' 
		Panel2.BackColor = Color.Orange
		Panel2.Location = New Point(3, 80)
		Panel2.Name = "Panel2"
		Panel2.Size = New Size(800, 13)
		Panel2.TabIndex = 11
		' 
		' PictureBox3
		' 
		PictureBox3.BackColor = Color.Transparent
		PictureBox3.Image = My.Resources.Resources.logo_volunteer
		PictureBox3.Location = New Point(633, 137)
		PictureBox3.Name = "PictureBox3"
		PictureBox3.Size = New Size(155, 150)
		PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
		PictureBox3.TabIndex = 4
		PictureBox3.TabStop = False
		' 
		' Label7
		' 
		Label7.AutoSize = True
		Label7.BackColor = Color.Transparent
		Label7.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label7.ForeColor = Color.Green
		Label7.Location = New Point(62, 126)
		Label7.Name = "Label7"
		Label7.Size = New Size(251, 23)
		Label7.TabIndex = 4
		Label7.Text = "KARTU ANGGOTA RESMI"
		' 
		' lblAktivitas
		' 
		lblAktivitas.AutoSize = True
		lblAktivitas.BackColor = Color.Transparent
		lblAktivitas.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold)
		lblAktivitas.ForeColor = Color.DarkGreen
		lblAktivitas.Location = New Point(269, 345)
		lblAktivitas.Name = "lblAktivitas"
		lblAktivitas.Size = New Size(82, 19)
		lblAktivitas.TabIndex = 8
		lblAktivitas.Text = "Aktivitas:"
		' 
		' lblNoHP
		' 
		lblNoHP.AutoSize = True
		lblNoHP.BackColor = Color.Transparent
		lblNoHP.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold)
		lblNoHP.ForeColor = Color.DarkGreen
		lblNoHP.Location = New Point(269, 297)
		lblNoHP.Name = "lblNoHP"
		lblNoHP.Size = New Size(68, 19)
		lblNoHP.TabIndex = 7
		lblNoHP.Text = "Kontak:"
		' 
		' lblID
		' 
		lblID.AutoSize = True
		lblID.BackColor = Color.Transparent
		lblID.Font = New Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblID.ForeColor = Color.DarkGreen
		lblID.Location = New Point(269, 214)
		lblID.Name = "lblID"
		lblID.Size = New Size(34, 20)
		lblID.TabIndex = 5
		lblID.Text = "ID:"
		' 
		' lblNama
		' 
		lblNama.AutoSize = True
		lblNama.BackColor = Color.Transparent
		lblNama.Font = New Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblNama.ForeColor = Color.DarkGreen
		lblNama.Location = New Point(269, 173)
		lblNama.Name = "lblNama"
		lblNama.Size = New Size(60, 20)
		lblNama.TabIndex = 4
		lblNama.Text = "Nama:"
		' 
		' lblDivisi
		' 
		lblDivisi.AutoSize = True
		lblDivisi.BackColor = Color.Transparent
		lblDivisi.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblDivisi.ForeColor = Color.DarkGreen
		lblDivisi.Location = New Point(269, 254)
		lblDivisi.Name = "lblDivisi"
		lblDivisi.Size = New Size(95, 19)
		lblDivisi.TabIndex = 6
		lblDivisi.Text = "Komunitas:"
		' 
		' FormHasil
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		BackgroundImage = My.Resources.Resources.bg_volunteer
		BackgroundImageLayout = ImageLayout.Stretch
		ClientSize = New Size(800, 450)
		Controls.Add(lblDivisi)
		Controls.Add(lblNama)
		Controls.Add(lblID)
		Controls.Add(Label7)
		Controls.Add(lblNoHP)
		Controls.Add(PictureBox3)
		Controls.Add(lblAktivitas)
		Controls.Add(Panel1)
		Controls.Add(PicProfil)
		Name = "FormHasil"
		StartPosition = FormStartPosition.CenterScreen
		Text = "FormHasil"
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		CType(PicProfil, ComponentModel.ISupportInitialize).EndInit()
		Panel1.ResumeLayout(False)
		Panel1.PerformLayout()
		CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents PicProfil As PictureBox
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Panel2 As Panel
	Friend WithEvents PictureBox3 As PictureBox
	Friend WithEvents Label7 As Label
	Friend WithEvents lblAktivitas As Label
	Friend WithEvents lblNoHP As Label
	Friend WithEvents lblID As Label
	Friend WithEvents lblNama As Label
	Friend WithEvents lblDivisi As Label
	Friend WithEvents Label8 As Label
End Class
