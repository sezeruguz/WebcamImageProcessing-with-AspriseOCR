<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SEZER
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
        Dim tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.comboLang = New System.Windows.Forms.ComboBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.buttonOcr = New System.Windows.Forms.Button()
        Me.checkRecognizeText = New System.Windows.Forms.CheckBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.radioOutputText = New System.Windows.Forms.RadioButton()
        Me.label3 = New System.Windows.Forms.Label()
        Me.buttonBrowse = New System.Windows.Forms.Button()
        Me.textImage = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.textbox = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.imgVideo = New System.Windows.Forms.PictureBox()
        Me.imgCapture = New System.Windows.Forms.PictureBox()
        Me.Baslat = New System.Windows.Forms.Button()
        Me.Durdur = New System.Windows.Forms.Button()
        Me.DevamEt = New System.Windows.Forms.Button()
        Me.FotografiTut = New System.Windows.Forms.Button()
        Me.FotografiKaydet = New System.Windows.Forms.Button()
        tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        tableLayoutPanel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.imgVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCapture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableLayoutPanel1
        '
        tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        tableLayoutPanel1.ColumnCount = 1
        tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        tableLayoutPanel1.Controls.Add(Me.groupBox1, 0, 0)
        tableLayoutPanel1.Controls.Add(Me.textbox, 0, 1)
        tableLayoutPanel1.Location = New System.Drawing.Point(0, 279)
        tableLayoutPanel1.Name = "tableLayoutPanel1"
        tableLayoutPanel1.RowCount = 4
        tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109.0!))
        tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107.0!))
        tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        tableLayoutPanel1.Size = New System.Drawing.Size(846, 261)
        tableLayoutPanel1.TabIndex = 9
        AddHandler tableLayoutPanel1.Paint, AddressOf Me.tableLayoutPanel1_Paint
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.Controls.Add(Me.comboLang)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.buttonOcr)
        Me.groupBox1.Controls.Add(Me.checkRecognizeText)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.radioOutputText)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.buttonBrowse)
        Me.groupBox1.Controls.Add(Me.textImage)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.groupBox1.Location = New System.Drawing.Point(8, 6)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(830, 97)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Görüntü İşleme"
        '
        'comboLang
        '
        Me.comboLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboLang.FormattingEnabled = True
        Me.comboLang.Items.AddRange(New Object() {"eng", "spa", "por", "deu", "fra"})
        Me.comboLang.Location = New System.Drawing.Point(546, 57)
        Me.comboLang.Name = "comboLang"
        Me.comboLang.Size = New System.Drawing.Size(74, 21)
        Me.comboLang.TabIndex = 12
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(518, 61)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(22, 13)
        Me.label5.TabIndex = 11
        Me.label5.Text = "Dil:"
        '
        'buttonOcr
        '
        Me.buttonOcr.BackColor = System.Drawing.Color.RoyalBlue
        Me.buttonOcr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonOcr.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.buttonOcr.Location = New System.Drawing.Point(675, 58)
        Me.buttonOcr.Name = "buttonOcr"
        Me.buttonOcr.Size = New System.Drawing.Size(149, 23)
        Me.buttonOcr.TabIndex = 8
        Me.buttonOcr.Text = "GÖRÜNTÜ İŞLEME"
        Me.buttonOcr.UseVisualStyleBackColor = False
        '
        'checkRecognizeText
        '
        Me.checkRecognizeText.AutoSize = True
        Me.checkRecognizeText.Checked = True
        Me.checkRecognizeText.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkRecognizeText.Location = New System.Drawing.Point(379, 61)
        Me.checkRecognizeText.Name = "checkRecognizeText"
        Me.checkRecognizeText.Size = New System.Drawing.Size(52, 17)
        Me.checkRecognizeText.TabIndex = 6
        Me.checkRecognizeText.Text = "Metin"
        Me.checkRecognizeText.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(330, 62)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(43, 13)
        Me.label4.TabIndex = 5
        Me.label4.Text = "Onayla:"
        '
        'radioOutputText
        '
        Me.radioOutputText.AutoSize = True
        Me.radioOutputText.Checked = True
        Me.radioOutputText.Location = New System.Drawing.Point(162, 62)
        Me.radioOutputText.Name = "radioOutputText"
        Me.radioOutputText.Size = New System.Drawing.Size(73, 17)
        Me.radioOutputText.TabIndex = 2
        Me.radioOutputText.TabStop = True
        Me.radioOutputText.Text = "Düz Metin"
        Me.radioOutputText.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(87, 64)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(69, 13)
        Me.label3.TabIndex = 1
        Me.label3.Text = "Çıkış Formatı:"
        '
        'buttonBrowse
        '
        Me.buttonBrowse.Location = New System.Drawing.Point(626, 25)
        Me.buttonBrowse.Name = "buttonBrowse"
        Me.buttonBrowse.Size = New System.Drawing.Size(75, 23)
        Me.buttonBrowse.TabIndex = 2
        Me.buttonBrowse.Text = "Seçiniz ..."
        Me.buttonBrowse.UseVisualStyleBackColor = True
        '
        'textImage
        '
        Me.textImage.Location = New System.Drawing.Point(87, 27)
        Me.textImage.Name = "textImage"
        Me.textImage.Size = New System.Drawing.Size(533, 20)
        Me.textImage.TabIndex = 1
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(42, 30)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(48, 13)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Görüntü:"
        '
        'textbox
        '
        Me.textbox.Dock = System.Windows.Forms.DockStyle.Top
        Me.textbox.Location = New System.Drawing.Point(8, 115)
        Me.textbox.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.textbox.Multiline = True
        Me.textbox.Name = "textbox"
        Me.textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textbox.Size = New System.Drawing.Size(830, 209)
        Me.textbox.TabIndex = 4
        Me.textbox.WordWrap = False
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.label1.Location = New System.Drawing.Point(0, 0)
        Me.label1.Margin = New System.Windows.Forms.Padding(0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(846, 276)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Bilgi: Seçtiğiniz Resmi İşlemek İçin GÖRÜNTÜ İŞLEME Butonuna Tıklayınız"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'imgVideo
        '
        Me.imgVideo.BackColor = System.Drawing.Color.Transparent
        Me.imgVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgVideo.Location = New System.Drawing.Point(49, 0)
        Me.imgVideo.Name = "imgVideo"
        Me.imgVideo.Size = New System.Drawing.Size(332, 196)
        Me.imgVideo.TabIndex = 10
        Me.imgVideo.TabStop = False
        '
        'imgCapture
        '
        Me.imgCapture.BackColor = System.Drawing.Color.Transparent
        Me.imgCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgCapture.Location = New System.Drawing.Point(468, 0)
        Me.imgCapture.Name = "imgCapture"
        Me.imgCapture.Size = New System.Drawing.Size(332, 196)
        Me.imgCapture.TabIndex = 11
        Me.imgCapture.TabStop = False
        '
        'Baslat
        '
        Me.Baslat.BackColor = System.Drawing.Color.BurlyWood
        Me.Baslat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Baslat.Location = New System.Drawing.Point(49, 211)
        Me.Baslat.Name = "Baslat"
        Me.Baslat.Size = New System.Drawing.Size(85, 23)
        Me.Baslat.TabIndex = 12
        Me.Baslat.Text = "Başlat"
        Me.Baslat.UseVisualStyleBackColor = False
        '
        'Durdur
        '
        Me.Durdur.BackColor = System.Drawing.Color.BurlyWood
        Me.Durdur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Durdur.Location = New System.Drawing.Point(170, 211)
        Me.Durdur.Name = "Durdur"
        Me.Durdur.Size = New System.Drawing.Size(85, 23)
        Me.Durdur.TabIndex = 13
        Me.Durdur.Text = "Durdur"
        Me.Durdur.UseVisualStyleBackColor = False
        '
        'DevamEt
        '
        Me.DevamEt.BackColor = System.Drawing.Color.BurlyWood
        Me.DevamEt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DevamEt.Location = New System.Drawing.Point(296, 211)
        Me.DevamEt.Name = "DevamEt"
        Me.DevamEt.Size = New System.Drawing.Size(85, 23)
        Me.DevamEt.TabIndex = 14
        Me.DevamEt.Text = "Devam Et"
        Me.DevamEt.UseVisualStyleBackColor = False
        '
        'FotografiTut
        '
        Me.FotografiTut.BackColor = System.Drawing.Color.BurlyWood
        Me.FotografiTut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FotografiTut.Location = New System.Drawing.Point(468, 210)
        Me.FotografiTut.Name = "FotografiTut"
        Me.FotografiTut.Size = New System.Drawing.Size(130, 24)
        Me.FotografiTut.TabIndex = 15
        Me.FotografiTut.Text = "Fotoğrafı Tut"
        Me.FotografiTut.UseVisualStyleBackColor = False
        '
        'FotografiKaydet
        '
        Me.FotografiKaydet.BackColor = System.Drawing.Color.BurlyWood
        Me.FotografiKaydet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FotografiKaydet.Location = New System.Drawing.Point(670, 210)
        Me.FotografiKaydet.Name = "FotografiKaydet"
        Me.FotografiKaydet.Size = New System.Drawing.Size(130, 24)
        Me.FotografiKaydet.TabIndex = 16
        Me.FotografiKaydet.Text = "Fotoğrafı Kaydet"
        Me.FotografiKaydet.UseVisualStyleBackColor = False
        '
        'SEZER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 540)
        Me.Controls.Add(Me.FotografiKaydet)
        Me.Controls.Add(Me.FotografiTut)
        Me.Controls.Add(Me.DevamEt)
        Me.Controls.Add(Me.Durdur)
        Me.Controls.Add(Me.Baslat)
        Me.Controls.Add(Me.imgCapture)
        Me.Controls.Add(Me.imgVideo)
        Me.Controls.Add(tableLayoutPanel1)
        Me.Controls.Add(Me.label1)
        Me.Name = "SEZER"
        Me.Text = "SEZER | Webcam & Görüntü İşleme"
        tableLayoutPanel1.ResumeLayout(False)
        tableLayoutPanel1.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.imgVideo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCapture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents buttonOcr As System.Windows.Forms.Button
    Private WithEvents checkRecognizeText As System.Windows.Forms.CheckBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents radioOutputText As System.Windows.Forms.RadioButton
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents buttonBrowse As System.Windows.Forms.Button
    Private WithEvents textImage As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents textbox As System.Windows.Forms.TextBox
    Private WithEvents comboLang As System.Windows.Forms.ComboBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents imgVideo As System.Windows.Forms.PictureBox
    Private WithEvents imgCapture As System.Windows.Forms.PictureBox
    Private WithEvents Baslat As System.Windows.Forms.Button
    Private WithEvents Durdur As System.Windows.Forms.Button
    Private WithEvents DevamEt As System.Windows.Forms.Button
    Private WithEvents FotografiTut As System.Windows.Forms.Button
    Private WithEvents FotografiKaydet As System.Windows.Forms.Button

End Class
