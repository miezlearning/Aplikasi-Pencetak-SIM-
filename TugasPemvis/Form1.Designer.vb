<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txttanggal = New System.Windows.Forms.DateTimePicker()
        Me.cbpekerjaan = New System.Windows.Forms.ComboBox()
        Me.cbkecamatan = New System.Windows.Forms.ComboBox()
        Me.cbkabupaten = New System.Windows.Forms.ComboBox()
        Me.gbgoldar = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.rbB = New System.Windows.Forms.RadioButton()
        Me.rbA = New System.Windows.Forms.RadioButton()
        Me.rbO = New System.Windows.Forms.RadioButton()
        Me.cbSIM = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.cbkelamin = New System.Windows.Forms.ComboBox()
        Me.txtprov = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbgoldar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(12, 14)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1114, 179)
        Me.Panel3.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(385, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(474, 38)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "FORM PENGISIAN PEMBUATAN SIM"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FormPengisian.My.Resources.Resources.Lambang_Polri
        Me.PictureBox1.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 162)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(237, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(794, 50)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "KEPOLISIAN NEGARA REPUBLIK INDONESIA"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.txttanggal)
        Me.Panel1.Controls.Add(Me.cbpekerjaan)
        Me.Panel1.Controls.Add(Me.cbkecamatan)
        Me.Panel1.Controls.Add(Me.cbkabupaten)
        Me.Panel1.Controls.Add(Me.gbgoldar)
        Me.Panel1.Controls.Add(Me.cbSIM)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.btnSubmit)
        Me.Panel1.Controls.Add(Me.cbkelamin)
        Me.Panel1.Controls.Add(Me.txtprov)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.txtnama)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Location = New System.Drawing.Point(12, 198)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1114, 715)
        Me.Panel1.TabIndex = 45
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.PictureBox2.BackgroundImage = Global.FormPengisian.My.Resources.Resources._1_zdq66lWAw68K27bjTR7Dtg
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(640, 241)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(455, 338)
        Me.PictureBox2.TabIndex = 47
        Me.PictureBox2.TabStop = False
        '
        'txttanggal
        '
        Me.txttanggal.Location = New System.Drawing.Point(180, 84)
        Me.txttanggal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.Size = New System.Drawing.Size(271, 22)
        Me.txttanggal.TabIndex = 46
        '
        'cbpekerjaan
        '
        Me.cbpekerjaan.FormattingEnabled = True
        Me.cbpekerjaan.Items.AddRange(New Object() {"", "BELUM / TIDAK BEKERJA", "APARATUR / PEJABAT NEGARA", "TENAGA PENGAJAR", "WIRASWASTA", "PERTANIAN / PETERNAKAN", "NELAYAN", "AGAMA DAN KEPERCAYAAN", "PELAJAR / MAHASISWA", "TENAGA KESEHATAN", "PENSIUNAN", "LAINNYA"})
        Me.cbpekerjaan.Location = New System.Drawing.Point(185, 578)
        Me.cbpekerjaan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbpekerjaan.Name = "cbpekerjaan"
        Me.cbpekerjaan.Size = New System.Drawing.Size(231, 24)
        Me.cbpekerjaan.TabIndex = 45
        '
        'cbkecamatan
        '
        Me.cbkecamatan.FormattingEnabled = True
        Me.cbkecamatan.Items.AddRange(New Object() {""})
        Me.cbkecamatan.Location = New System.Drawing.Point(185, 510)
        Me.cbkecamatan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbkecamatan.Name = "cbkecamatan"
        Me.cbkecamatan.Size = New System.Drawing.Size(231, 24)
        Me.cbkecamatan.TabIndex = 44
        '
        'cbkabupaten
        '
        Me.cbkabupaten.FormattingEnabled = True
        Me.cbkabupaten.Items.AddRange(New Object() {"", "Samarinda", "Tenggarong", "Balikpapan"})
        Me.cbkabupaten.Location = New System.Drawing.Point(185, 447)
        Me.cbkabupaten.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbkabupaten.Name = "cbkabupaten"
        Me.cbkabupaten.Size = New System.Drawing.Size(231, 24)
        Me.cbkabupaten.TabIndex = 43
        '
        'gbgoldar
        '
        Me.gbgoldar.Controls.Add(Me.RadioButton5)
        Me.gbgoldar.Controls.Add(Me.rbB)
        Me.gbgoldar.Controls.Add(Me.rbA)
        Me.gbgoldar.Controls.Add(Me.rbO)
        Me.gbgoldar.Location = New System.Drawing.Point(185, 159)
        Me.gbgoldar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbgoldar.Name = "gbgoldar"
        Me.gbgoldar.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbgoldar.Size = New System.Drawing.Size(267, 194)
        Me.gbgoldar.TabIndex = 42
        Me.gbgoldar.TabStop = False
        Me.gbgoldar.Text = "Pilih"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(24, 156)
        Me.RadioButton5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(77, 20)
        Me.RadioButton5.TabIndex = 7
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Gol - AB"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'rbB
        '
        Me.rbB.AutoSize = True
        Me.rbB.Location = New System.Drawing.Point(24, 118)
        Me.rbB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbB.Name = "rbB"
        Me.rbB.Size = New System.Drawing.Size(68, 20)
        Me.rbB.TabIndex = 6
        Me.rbB.TabStop = True
        Me.rbB.Text = "Gol - B"
        Me.rbB.UseVisualStyleBackColor = True
        '
        'rbA
        '
        Me.rbA.AutoSize = True
        Me.rbA.Location = New System.Drawing.Point(24, 82)
        Me.rbA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbA.Name = "rbA"
        Me.rbA.Size = New System.Drawing.Size(68, 20)
        Me.rbA.TabIndex = 5
        Me.rbA.TabStop = True
        Me.rbA.Text = "Gol - A"
        Me.rbA.UseVisualStyleBackColor = True
        '
        'rbO
        '
        Me.rbO.AutoSize = True
        Me.rbO.Location = New System.Drawing.Point(24, 44)
        Me.rbO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbO.Name = "rbO"
        Me.rbO.Size = New System.Drawing.Size(69, 20)
        Me.rbO.TabIndex = 4
        Me.rbO.TabStop = True
        Me.rbO.Text = "Gol - O"
        Me.rbO.UseVisualStyleBackColor = True
        '
        'cbSIM
        '
        Me.cbSIM.FormattingEnabled = True
        Me.cbSIM.Items.AddRange(New Object() {"", "A", "B1", "B2", "C ", "D"})
        Me.cbSIM.Location = New System.Drawing.Point(185, 380)
        Me.cbSIM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbSIM.Name = "cbSIM"
        Me.cbSIM.Size = New System.Drawing.Size(271, 24)
        Me.cbSIM.TabIndex = 41
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Gill Sans MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(81, 378)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 27)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Jenis SIM"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(640, 603)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(229, 66)
        Me.btnReset.TabIndex = 39
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(875, 603)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(221, 66)
        Me.btnSubmit.TabIndex = 38
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'cbkelamin
        '
        Me.cbkelamin.FormattingEnabled = True
        Me.cbkelamin.Items.AddRange(New Object() {"", "Laki - Laki", "Perempuan"})
        Me.cbkelamin.Location = New System.Drawing.Point(640, 82)
        Me.cbkelamin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbkelamin.Name = "cbkelamin"
        Me.cbkelamin.Size = New System.Drawing.Size(231, 24)
        Me.cbkelamin.TabIndex = 36
        '
        'txtprov
        '
        Me.txtprov.Location = New System.Drawing.Point(640, 23)
        Me.txtprov.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtprov.Name = "txtprov"
        Me.txtprov.ReadOnly = True
        Me.txtprov.Size = New System.Drawing.Size(231, 22)
        Me.txtprov.TabIndex = 35
        Me.txtprov.Text = "Kalimantan Timur"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(640, 132)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox4.MaxLength = 26
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(455, 74)
        Me.TextBox4.TabIndex = 31
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(180, 27)
        Me.txtnama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(268, 22)
        Me.txtnama.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Gill Sans MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(531, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 27)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Provinsi"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Gill Sans MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(17, 576)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(143, 27)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Jenis Pekerjaan"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Gill Sans MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Control
        Me.Label16.Location = New System.Drawing.Point(59, 507)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(109, 27)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Kecamatan"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Gill Sans MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.Control
        Me.Label17.Location = New System.Drawing.Point(59, 444)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 27)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Kabupaten"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Gill Sans MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Control
        Me.Label18.Location = New System.Drawing.Point(539, 130)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 27)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Alamat"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Gill Sans MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.Control
        Me.Label19.Location = New System.Drawing.Point(531, 80)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 27)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "Kelamin"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Gill Sans MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.Control
        Me.Label20.Location = New System.Drawing.Point(11, 156)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(154, 27)
        Me.Label20.TabIndex = 22
        Me.Label20.Text = "Golongan Darah"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Gill Sans MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.Control
        Me.Label21.Location = New System.Drawing.Point(32, 82)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(131, 27)
        Me.Label21.TabIndex = 21
        Me.Label21.Text = "Tanggal Lahir"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Gill Sans MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.Control
        Me.Label22.Location = New System.Drawing.Point(96, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(69, 27)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "Nama "
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1141, 927)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbgoldar.ResumeLayout(False)
        Me.gbgoldar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbpekerjaan As ComboBox
    Friend WithEvents cbkecamatan As ComboBox
    Friend WithEvents cbkabupaten As ComboBox
    Friend WithEvents gbgoldar As GroupBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents rbB As RadioButton
    Friend WithEvents rbA As RadioButton
    Friend WithEvents rbO As RadioButton
    Friend WithEvents cbSIM As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents cbkelamin As ComboBox
    Friend WithEvents txtprov As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txttanggal As DateTimePicker
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
