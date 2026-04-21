<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Panel1 = New Panel()
		Label7 = New Label()
		PictureBox1 = New PictureBox()
		lblId = New Label()
		lblJudul = New Label()
		lblGenre = New Label()
		lblAuthor = New Label()
		lblRating = New Label()
		lblStatus = New Label()
		btnTutup = New Button()
		Label6 = New Label()
		Label5 = New Label()
		Label4 = New Label()
		Label3 = New Label()
		Label2 = New Label()
		Label1 = New Label()
		Panel2 = New Panel()
		Panel1.SuspendLayout()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		Panel2.SuspendLayout()
		SuspendLayout()
		' 
		' Panel1
		' 
		Panel1.BackColor = Color.MistyRose
		Panel1.Controls.Add(Label7)
		Panel1.Location = New Point(2, 2)
		Panel1.Name = "Panel1"
		Panel1.Size = New Size(471, 45)
		Panel1.TabIndex = 1
		' 
		' Label7
		' 
		Label7.AutoSize = True
		Label7.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label7.ForeColor = Color.RosyBrown
		Label7.Location = New Point(21, 7)
		Label7.Name = "Label7"
		Label7.Size = New Size(195, 28)
		Label7.TabIndex = 0
		Label7.Text = "DETAIL WEBTOON"
		' 
		' PictureBox1
		' 
		PictureBox1.BackColor = Color.Transparent
		PictureBox1.Image = My.Resources.Resources.webtoon2
		PictureBox1.Location = New Point(362, 110)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(153, 232)
		PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
		PictureBox1.TabIndex = 23
		PictureBox1.TabStop = False
		' 
		' lblId
		' 
		lblId.AutoSize = True
		lblId.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
		lblId.ForeColor = Color.RosyBrown
		lblId.Location = New Point(131, 11)
		lblId.Name = "lblId"
		lblId.Size = New Size(57, 23)
		lblId.TabIndex = 24
		lblId.Text = "Label1"
		' 
		' lblJudul
		' 
		lblJudul.AutoSize = True
		lblJudul.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
		lblJudul.ForeColor = Color.RosyBrown
		lblJudul.Location = New Point(130, 45)
		lblJudul.Name = "lblJudul"
		lblJudul.Size = New Size(57, 23)
		lblJudul.TabIndex = 25
		lblJudul.Text = "Label1"
		' 
		' lblGenre
		' 
		lblGenre.AutoSize = True
		lblGenre.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
		lblGenre.ForeColor = Color.RosyBrown
		lblGenre.Location = New Point(130, 80)
		lblGenre.Name = "lblGenre"
		lblGenre.Size = New Size(57, 23)
		lblGenre.TabIndex = 26
		lblGenre.Text = "Label1"
		' 
		' lblAuthor
		' 
		lblAuthor.AutoSize = True
		lblAuthor.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
		lblAuthor.ForeColor = Color.RosyBrown
		lblAuthor.Location = New Point(130, 116)
		lblAuthor.Name = "lblAuthor"
		lblAuthor.Size = New Size(57, 23)
		lblAuthor.TabIndex = 27
		lblAuthor.Text = "Label1"
		' 
		' lblRating
		' 
		lblRating.AutoSize = True
		lblRating.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
		lblRating.ForeColor = Color.RosyBrown
		lblRating.Location = New Point(130, 152)
		lblRating.Name = "lblRating"
		lblRating.Size = New Size(57, 23)
		lblRating.TabIndex = 28
		lblRating.Text = "Label1"
		' 
		' lblStatus
		' 
		lblStatus.AutoSize = True
		lblStatus.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
		lblStatus.ForeColor = Color.RosyBrown
		lblStatus.Location = New Point(130, 190)
		lblStatus.Name = "lblStatus"
		lblStatus.Size = New Size(57, 23)
		lblStatus.TabIndex = 29
		lblStatus.Text = "Label1"
		' 
		' btnTutup
		' 
		btnTutup.BackColor = Color.MistyRose
		btnTutup.Location = New Point(126, 296)
		btnTutup.Name = "btnTutup"
		btnTutup.Size = New Size(92, 34)
		btnTutup.TabIndex = 30
		btnTutup.Text = "Tutup"
		btnTutup.UseVisualStyleBackColor = False
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.BackColor = Color.MistyRose
		Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Label6.Location = New Point(16, 80)
		Label6.Name = "Label6"
		Label6.Size = New Size(56, 23)
		Label6.TabIndex = 36
		Label6.Text = "Genre"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.BackColor = Color.MistyRose
		Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Label5.Location = New Point(15, 190)
		Label5.Name = "Label5"
		Label5.Size = New Size(56, 23)
		Label5.TabIndex = 35
		Label5.Text = "Status"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.BackColor = Color.MistyRose
		Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Label4.Location = New Point(16, 152)
		Label4.Name = "Label4"
		Label4.Size = New Size(59, 23)
		Label4.TabIndex = 34
		Label4.Text = "Rating"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.BackColor = Color.MistyRose
		Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Label3.Location = New Point(16, 116)
		Label3.Name = "Label3"
		Label3.Size = New Size(63, 23)
		Label3.TabIndex = 33
		Label3.Text = "Author"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.BackColor = Color.MistyRose
		Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Label2.Location = New Point(16, 45)
		Label2.Name = "Label2"
		Label2.Size = New Size(50, 23)
		Label2.TabIndex = 32
		Label2.Text = "Judul"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.BackColor = Color.MistyRose
		Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Label1.Location = New Point(16, 11)
		Label1.Name = "Label1"
		Label1.Size = New Size(102, 23)
		Label1.TabIndex = 31
		Label1.Text = "ID Webtoon"
		' 
		' Panel2
		' 
		Panel2.BackColor = Color.Snow
		Panel2.Controls.Add(Label6)
		Panel2.Controls.Add(lblId)
		Panel2.Controls.Add(Label5)
		Panel2.Controls.Add(lblJudul)
		Panel2.Controls.Add(Label4)
		Panel2.Controls.Add(lblGenre)
		Panel2.Controls.Add(Label3)
		Panel2.Controls.Add(lblAuthor)
		Panel2.Controls.Add(Label2)
		Panel2.Controls.Add(lblRating)
		Panel2.Controls.Add(Label1)
		Panel2.Controls.Add(lblStatus)
		Panel2.Location = New Point(23, 65)
		Panel2.Name = "Panel2"
		Panel2.Size = New Size(333, 225)
		Panel2.TabIndex = 37
		' 
		' Form2
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.SeaShell
		ClientSize = New Size(474, 342)
		Controls.Add(Panel2)
		Controls.Add(btnTutup)
		Controls.Add(PictureBox1)
		Controls.Add(Panel1)
		Name = "Form2"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Form2"
		Panel1.ResumeLayout(False)
		Panel1.PerformLayout()
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		Panel2.ResumeLayout(False)
		Panel2.PerformLayout()
		ResumeLayout(False)
	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents Label7 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents lblId As Label
	Friend WithEvents lblJudul As Label
	Friend WithEvents lblGenre As Label
	Friend WithEvents lblAuthor As Label
	Friend WithEvents lblRating As Label
	Friend WithEvents lblStatus As Label
	Friend WithEvents btnTutup As Button
	Friend WithEvents Label6 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Panel2 As Panel
End Class
