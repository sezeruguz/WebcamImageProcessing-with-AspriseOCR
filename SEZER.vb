Imports asprise_ocr_api
Imports System.IO
Imports System.Threading

Public Class SEZER

    Private webcam As WebCam
    Private Sub Sezer_WebcamdenGoruntuIsleme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        webcam = New WebCam()
        webcam.InitializeWebCam(imgVideo)
    End Sub

    Private Sub bntStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Baslat.Click
        webcam.Start()
    End Sub

    Private Sub bntStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Durdur.Click
        webcam.Stop()
    End Sub

    Private Sub bntContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevamEt.Click
        webcam.Continue()
    End Sub

    Private Sub bntCapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FotografiTut.Click
        imgCapture.Image = imgVideo.Image
    End Sub

    Private Sub bntSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FotografiKaydet.Click
        Helper.SaveImageCapture(imgCapture.Image)
    End Sub

    Private Sub bntVideoFormat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        webcam.ResolutionSetting()
    End Sub

    Private Sub bntVideoSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        webcam.AdvanceSetting()
    End Sub



    Public Sub New()
        InitializeComponent()
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        asprise_init()
    End Sub

    Private Shared Function GetLastImagePath() As String
        Return AspriseOCR.firstNonNull(My.Settings.IMAGE_FILE, "").ToString()
    End Function

    Private Shared Sub SetLastImagePath(path As String)
        My.Settings.IMAGE_FILE = path
        My.Settings.Save()
    End Sub

    Private Shared Sub SetLastLang(lang As String)
        My.Settings.LAST_LANG = lang
        My.Settings.Save()
    End Sub

    Private Shared Function GetLastLang() As String
        Return AspriseOCR.firstNonNull(My.Settings.LAST_LANG, "").ToString()
    End Function


    Private ocr As AspriseOCR
    Private currentLang As String
    Private Sub asprise_init()
        Dim browsed As Boolean = False
        Dim count As Integer = 0

        Dim dllFilePath As String = AspriseOCR.getOcrDllPath()
        If dllFilePath Is Nothing Then
            Dim parentFolder As String = AspriseOCR.detectOcrDllInParentFolders()
            If parentFolder IsNot Nothing Then
                AspriseOCR.addToSystemPath(parentFolder)
                log(Convert.ToString("Görüntü İşleme dll dosyası klasörde tespit edildi: ") & parentFolder)
            End If
        End If

        Dim lang As String = GetLastLang()
        If lang Is Nothing Or lang.Length = 0 Then
            comboLang.SelectedIndex = 0
            currentLang = "eng"
        Else
            For i As Integer = 0 To comboLang.Items.Count - 1
                If comboLang.Items(i).ToString().Equals(lang) Then
                    comboLang.SelectedIndex = i
                    Exit For
                End If
            Next
            currentLang = lang
        End If

        ' Let user browse the ocr dll if it is not found in PATH.
        While True
            dllFilePath = AspriseOCR.getOcrDllPath()
            If dllFilePath Is Nothing Then
                log("OCR dll (" + AspriseOCR.getOcrDllName() + ") is not found in PATH.")
                Dim fileDialog As New OpenFileDialog()
                fileDialog.RestoreDirectory = True
                fileDialog.Title = "Please select " + AspriseOCR.getOcrDllName()
                fileDialog.FileName = AspriseOCR.getOcrDllName()
                If fileDialog.ShowDialog(Me) = DialogResult.OK Then
                    log("User browsed dll: " + fileDialog.FileName)
                    AspriseOCR.addToSystemPath(Path.GetDirectoryName(fileDialog.FileName))
                    browsed = True
                End If
                count += 1
                If count = 2 Then
                    showMessageBox("Görüntü İşleme dll bulunamadı. ", "Hata")
                    Exit While
                End If
            Else
                log(Convert.ToString("Görüntü İşleme dll bulundu: ") & dllFilePath)
                If browsed Then
                    log("Kopyalanılanı Düşünün " + AspriseOCR.getOcrDllName() + " dizine: " + Directory.GetCurrentDirectory())
                End If

                log(AspriseOCR.GetLibraryVersion())

                Try
                    log("Görüntü İşleme sürücüsü başlatılıyor ...")
                    AspriseOCR.SetUp()
                    ocr = New AspriseOCR()
                    ocr.StartEngine(currentLang, AspriseOCR.SPEED_FASTEST)
                    log("Görüntü İşleme sürücüsü başarıyla başlatıldı.")
                Catch e As Exception
                    log("HATA: Görüntü İşleme sürücüsü başlatılamadı: " & e.ToString())
                    log(e.StackTrace)
                End Try
                Exit While
            End If
        End While

        ' user preference
        textImage.Text = GetLastImagePath()
    End Sub

    Public Sub showMessageBox(message As String, title As String)
        If Me.InvokeRequired Then
            Dim delegatedMethod As delegate_showMessageBox = AddressOf showMessageBox
            Invoke(delegatedMethod, message, title)
            Return
        End If

        MessageBox.Show(Me, message, title, MessageBoxButtons.OK)
    End Sub
    Private Delegate Sub delegate_showMessageBox(message As String, title As String)

    Public Sub log(s As String, Optional clear As Boolean = False)
        If textbox.InvokeRequired Then
            Dim delegatedMethod As delegate_log = AddressOf log
            Invoke(delegatedMethod, s, clear)
            Return
        End If

        If clear Then
            textbox.Text = ""
        End If

        If textbox.Text.Length > 1 Then
            textbox.Text += vbCr & vbLf
        End If
        textbox.Text += s.Replace(vbLf, vbCr & vbLf)
        ' to properly display in textbox
    End Sub
    Private Delegate Sub delegate_log(s As String, clear As Boolean)

    Private _Color1 As Color = Color.White
    Private _Color2 As Color = Color.LightBlue
    Private _ColorAngle As Single = 60.0F

    Protected Overrides Sub OnPaintBackground(pevent As PaintEventArgs)
        ' Getting the graphics object
        Dim g As Graphics = pevent.Graphics

        ' Creating the rectangle for the gradient
        Dim rBackground As New Rectangle(0, 0, Me.Width, Me.Height)

        ' Creating the lineargradient
        Dim bBackground As New System.Drawing.Drawing2D.LinearGradientBrush(rBackground, _Color1, _Color2, _ColorAngle)

        ' Draw the gradient onto the form
        g.FillRectangle(bBackground, rBackground)

        ' Disposing of the resources held by the brush
        bBackground.Dispose()
    End Sub

    Private Sub buttonBrowse_Click(sender As Object, e As EventArgs) Handles buttonBrowse.Click
        Dim dialog As New OpenFileDialog()
        ' settings
        If Not AspriseOCR.isEmpty(textImage.Text) Then
            Try
                dialog.InitialDirectory = Path.GetDirectoryName(textImage.Text.Trim())
            Catch exception As Exception
            End Try
        End If
        dialog.Title = "Lütfen Görüntü İşleme için görüntüyü seçiniz"
        dialog.Filter = "Görüntü Dosyaları:(*.BMP;*.GIF;*.JPG;*PNG;*TIF;*TIFF)|*.BMP;*.GIF;*.JPG;*PNG;*TIF;*TIFF|Tüm Dosyalar (*.*)|*.*"
        dialog.RestoreDirectory = True
        If dialog.ShowDialog(Me) = DialogResult.OK Then
            textImage.Text = dialog.FileName
        End If
    End Sub

    Private threadOcr As Thread
    Private langOnUI As String
    Private Sub buttonOcr_Click(sender As Object, e As EventArgs) Handles buttonOcr.Click
        If threadOcr IsNot Nothing AndAlso threadOcr.IsAlive Then
            showMessageBox("Görüntü İşleme işleniyor, lütfen bekleyiniz ...", "Bilgi")
            Return
        End If

        langOnUI = comboLang.Text
        threadOcr = New Thread(AddressOf Me.doOcr)
        threadOcr.Start()
    End Sub

    Private Sub doOcr()
        If textImage.Text.Trim().Length = 0 Then
            showMessageBox("Lütfen öncelikle görüntüyü seçiniz.", "Hata")
            Return
        End If

        If Not File.Exists(textImage.Text.Trim()) Then
            showMessageBox("Image file does not exist: " + textImage.Text, "Error")
            Return
        End If

        If Not langOnUI.Equals(currentLang) Then
            ocr.StopEngine()
            currentLang = Nothing

            ocr = New AspriseOCR()
            ocr.StartEngine(langOnUI, AspriseOCR.SPEED_FASTEST)
            currentLang = langOnUI
        End If

        If ocr Is Nothing OrElse Not ocr.IsEngineRunning Then
            showMessageBox("Görüntü İşleme sürücüsü çalıştırılamadı. ", "Hata")
            Return
        End If



        Dim recognizeType As String = AspriseOCR.RECOGNIZE_TYPE_ALL
        If Not checkRecognizeText.Checked Then
            recognizeType = AspriseOCR.RECOGNIZE_TYPE_BARCODE
        End If


        Dim outputFormat As String = AspriseOCR.OUTPUT_FORMAT_PLAINTEXT



        Dim dict As New Dictionary(Of String, String)()
        Dim pdfOutputFile As String = Nothing
        If outputFormat.Equals(AspriseOCR.OUTPUT_FORMAT_PDF) Then
            pdfOutputFile = Path.Combine(Directory.GetCurrentDirectory(), DateTime.Now.ToString("O").Replace(":"c, "-"c) + ".pdf")
            dict.Add(AspriseOCR.PROP_PDF_OUTPUT_FILE, pdfOutputFile)
            dict.Add(AspriseOCR.PROP_PDF_OUTPUT_TEXT_VISIBLE, "true")
            dict.Add(AspriseOCR.PROP_PDF_OUTPUT_IMAGE_FORCE_BW, "true")
        End If

        log("Görüntü İşleme devam ediyor, lütfen bekleyiniz ...", True)
        Dim timeStart As DateTime = DateTime.Now
        ' Performs the actual recognition
        Dim s As String = ocr.Recognize(textImage.Text.Trim(), -1, -1, -1, -1, -1, _
            recognizeType, outputFormat, dict)
        Dim timeEnd As DateTime = DateTime.Now

        ' open pdf file
        If outputFormat.Equals(AspriseOCR.OUTPUT_FORMAT_PDF) Then
            If s IsNot Nothing AndAlso s.Trim().Length > 0 Then
                log(Convert.ToString(s & Convert.ToString(vbLf & "PDF file: ")) & pdfOutputFile, True)
            Else
                log(Convert.ToString("PDF file created: ") & pdfOutputFile, True)
                Try
                    System.Diagnostics.Process.Start(pdfOutputFile)
                    ' ignore
                Catch e As Exception
                End Try
            End If
            log("For illustration purpose, text has been rendered in color instead of transparent.")
        Else
            log(s, True)
        End If

        ' user preference
        SetLastImagePath(textImage.Text)
        SetLastLang(currentLang)
    End Sub

    Private Sub tableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
