Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class Form1
    Private printDocument As New PrintDocument()
    Private uploadedImage As Image
    Private uploadedImage1 As Image

    Sub bersihkan()
        PictureBox1.Image = Nothing
        txtnama.Clear()
        TextBox4.Clear()
        cbkecamatan.Text = ""
        txttanggal.Value = Today
        cbkabupaten.SelectedIndex = -1
        cbkecamatan.SelectedIndex = -1
        cbkelamin.SelectedIndex = -1
        cbSIM.SelectedIndex = -1
        cbpekerjaan.SelectedIndex = -1
        For Each control As Control In gbgoldar.Controls
            If TypeOf control Is RadioButton Then
                Dim radioButton As RadioButton = DirectCast(control, RadioButton)
                radioButton.Checked = False
            End If
        Next
    End Sub

    Private Sub cbkabupaten_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbkabupaten.SelectedIndexChanged
        koneksi()

        Dim idKota As Integer = cbkabupaten.SelectedIndex

        Dim query As String = "SELECT tbkecamatan.nama_kecamatan " &
                              "FROM tbkecamatan " &
                              "INNER JOIN tbkota ON tbkecamatan.id_kota = tbkota.id_kota " &
                              "WHERE tbkota.id_kota = " & idKota

        Using connection As MySqlConnection = CONN
            Using command As MySqlCommand = New MySqlCommand(query, connection)
                Try
                    If connection.State = ConnectionState.Closed Then
                        connection.Open()
                    End If

                    cbkecamatan.Items.Clear()

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            cbkecamatan.Items.Add(reader("nama_kecamatan").ToString())
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        bersihkan()
    End Sub

    Private Function ResizeImage(ByVal image As Image, ByVal width As Integer, ByVal height As Integer) As Image
        Dim resizedImage As New Bitmap(width, height)
        Using g As Graphics = Graphics.FromImage(resizedImage)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(image, 0, 0, width, height)
        End Using
        Return resizedImage
    End Function

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Simpan gambar yang diunggah ke dalam variabel uploadedImage
                Dim imagePath As String = openFileDialog.FileName
                uploadedImage = Image.FromFile(imagePath)

                ' Ubah ukuran gambar sesuai dengan kebutuhan
                uploadedImage = ResizeImage(uploadedImage, 94, 114)
                uploadedImage1 = ResizeImage(uploadedImage, 70, 70)

                PictureBox2.Image = uploadedImage
                PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub OnPrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        e.Graphics.FillRectangle(Brushes.Gray, e.PageBounds)

        Dim imagePath As String = "C:\Users\hexor\Downloads\TugasPemvis\TugasPemvis\Resources\1. Nama (4).png"
        Dim image As Image = Image.FromFile(imagePath)

        Dim xPos As Single = e.MarginBounds.Left
        Dim yPos As Single = e.MarginBounds.Top

        e.Graphics.DrawImage(image, xPos, yPos)

        'Posisi Avatar
        Dim xPosAvatar As Single = 160
        Dim yPosAvatar As Single = 202

        ' Gambar Utama Foto ORang
        e.Graphics.DrawImage(uploadedImage, xPosAvatar, yPosAvatar)


        'Gambar Dibawah TTD
        e.Graphics.DrawImage(uploadedImage1, 505, 325)


        Dim nama As String = "1." & txtnama.Text
        Dim ttl As String = "2." & txttanggal.Text
        Dim goldar_kelamin As String = ""
        If rbA.Checked Then
            goldar_kelamin = "3." & "A "
        ElseIf rbB.Checked Then
            goldar_kelamin = "3." & "B "
        ElseIf RadioButton5.Checked Then
            goldar_kelamin = "3." & "AB "
        ElseIf rbO.Checked Then
            goldar_kelamin = "3." & "O "
        End If
        Dim alamat_kec_kota As String = "4." & TextBox4.Text
        Dim pekerjaan As String = "5." & cbpekerjaan.Text
        Dim prov As String = "6." & txtprov.Text

        Dim font As New Font("Sans serif", 13, FontStyle.Bold)

        Dim brush As New SolidBrush(Color.Black)

        Dim textPosX As Single = 265
        Dim textPosY As Single = 202

        e.Graphics.DrawString(nama & vbCrLf & ttl & vbCrLf & goldar_kelamin & vbCrLf & alamat_kec_kota & vbCrLf & pekerjaan & vbCrLf & prov, font, brush, textPosX, textPosY)


        Dim cbSimText As String = cbSIM.Text

        Dim randomCode As String = GenerateRandomCode()


        e.Graphics.DrawString(randomCode, font, brush, 433, 147 + 20)

        Dim cbSimFont As New Font("Sans Serif", 17, FontStyle.Bold)

        e.Graphics.DrawString(cbSimText, cbSimFont, brush, 521, 124 + 20)

        Dim selectedDate As DateTime = Today


        Dim newDate As DateTime = selectedDate.AddYears(5)

        Dim ttlBawah As String = newDate.ToString("dd/MM/yyyy")

        e.Graphics.DrawString(ttlBawah, font, brush, 486, 378 + 20)




    End Sub

    Private Function GenerateRandomCode() As String
        Dim random As New Random()
        Dim code As String = ""
        For i As Integer = 1 To 4
            code &= random.Next(1000, 9999).ToString()
            If i < 4 Then
                code &= "-"
            End If
        Next
        Return code
    End Function


    ' Handler untuk event Load form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Atur handler untuk event PrintPage dari PrintDocument
        AddHandler printDocument.PrintPage, AddressOf OnPrintPage
    End Sub

    ' Handler untuk button Print
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If String.IsNullOrEmpty(cbpekerjaan.Text) Then
            MessageBox.Show("Pekerjaan harus dipilih.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(cbkecamatan.Text) Then
            MessageBox.Show("Kecamatan harus dipilih.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(cbkabupaten.Text) Then
            MessageBox.Show("Kabupaten harus dipilih.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(cbSIM.Text) Then
            MessageBox.Show("SIM harus dipilih.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrEmpty(cbkelamin.Text) Then
            MessageBox.Show("Jenis kelamin harus dipilih.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validasi untuk DateTimePicker
        If txttanggal.Value = DateTimePicker.MinimumDateTime Then
            MessageBox.Show("Tanggal harus dipilih.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validasi untuk TextBox
        If String.IsNullOrEmpty(txtnama.Text) OrElse String.IsNullOrEmpty(TextBox4.Text) OrElse String.IsNullOrEmpty(txtprov.Text) Then
            MessageBox.Show("Semua TextBox harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validasi untuk RadioButton
        If Not (rbA.Checked OrElse rbB.Checked OrElse RadioButton5.Checked OrElse rbO.Checked) Then
            MessageBox.Show("Salah satu RadioButton untuk golongan darah harus dipilih.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validasi untuk PictureBox
        If PictureBox2.Image Is Nothing Then
            MessageBox.Show("Gambar harus diunggah ke PictureBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Tampilkan dialog PrintPreviewDialog dengan PrintDocument
        Dim printPreviewDialog As New PrintPreviewDialog()
        printPreviewDialog.Document = printDocument
        printPreviewDialog.ShowDialog()
    End Sub

    Private Sub txttanggal_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txttanggal.Validating
        Dim selectedDate As Date = txttanggal.Value
        Dim currentDate As Date = Date.Now

        Dim age As Integer = currentDate.Year - selectedDate.Year

        If (selectedDate > currentDate.AddYears(-age)) Then
            age -= 1
        End If

        If age < 17 Then
            MessageBox.Show("Tanggal lahir tidak valid. Umur harus minimal 17 tahun.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        End If
    End Sub


End Class