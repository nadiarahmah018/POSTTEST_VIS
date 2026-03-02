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
		lblIPSemester = New Label()
		lblIPKomulatif = New Label()
		lblPredikat = New Label()
		txtIPSemester = New TextBox()
		txtIPKomulatif = New TextBox()
		btnTambah = New Button()
		btnReset = New Button()
		SuspendLayout()
		' 
		' lblIPSemester
		' 
		lblIPSemester.AutoSize = True
		lblIPSemester.Location = New Point(74, 103)
		lblIPSemester.Name = "lblIPSemester"
		lblIPSemester.Size = New Size(86, 20)
		lblIPSemester.TabIndex = 0
		lblIPSemester.Text = "IP Semester"
		' 
		' lblIPKomulatif
		' 
		lblIPKomulatif.AutoSize = True
		lblIPKomulatif.Location = New Point(74, 185)
		lblIPKomulatif.Name = "lblIPKomulatif"
		lblIPKomulatif.Size = New Size(90, 20)
		lblIPKomulatif.TabIndex = 1
		lblIPKomulatif.Text = "IP Komulatif"
		' 
		' lblPredikat
		' 
		lblPredikat.AutoSize = True
		lblPredikat.Location = New Point(197, 225)
		lblPredikat.Name = "lblPredikat"
		lblPredikat.Size = New Size(88, 20)
		lblPredikat.TabIndex = 2
		lblPredikat.Text = "Predikat IPK"
		' 
		' txtIPSemester
		' 
		txtIPSemester.Location = New Point(197, 103)
		txtIPSemester.Name = "txtIPSemester"
		txtIPSemester.Size = New Size(194, 27)
		txtIPSemester.TabIndex = 3
		' 
		' txtIPKomulatif
		' 
		txtIPKomulatif.Location = New Point(197, 182)
		txtIPKomulatif.Name = "txtIPKomulatif"
		txtIPKomulatif.Size = New Size(194, 27)
		txtIPKomulatif.TabIndex = 4
		' 
		' btnTambah
		' 
		btnTambah.Location = New Point(197, 136)
		btnTambah.Name = "btnTambah"
		btnTambah.Size = New Size(94, 29)
		btnTambah.TabIndex = 0
		btnTambah.Text = "Tambah"
		btnTambah.UseVisualStyleBackColor = True
		' 
		' btnReset
		' 
		btnReset.Location = New Point(297, 136)
		btnReset.Name = "btnReset"
		btnReset.Size = New Size(94, 29)
		btnReset.TabIndex = 5
		btnReset.Text = "Reset"
		btnReset.UseVisualStyleBackColor = True
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(610, 450)
		Controls.Add(btnReset)
		Controls.Add(btnTambah)
		Controls.Add(txtIPKomulatif)
		Controls.Add(txtIPSemester)
		Controls.Add(lblPredikat)
		Controls.Add(lblIPKomulatif)
		Controls.Add(lblIPSemester)
		Name = "Form1"
		Text = "Form1"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents lblIPSemester As Label
	Friend WithEvents lblIPKomulatif As Label
	Friend WithEvents lblPredikat As Label
	Friend WithEvents txtIPSemester As TextBox
	Friend WithEvents txtIPKomulatif As TextBox
	Friend WithEvents btnTambah As Button
	Friend WithEvents btnReset As Button

End Class
