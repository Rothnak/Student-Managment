Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Imports System.Drawing.Imaging
Public Class Camara
    Dim camara1 As VideoCaptureDevice
    Dim bmp As Bitmap
    Private Sub CaptureImage(sender As Object, EventArgs As NewFrameEventArgs)
        bmp = DirectCast(EventArgs.Frame(), Bitmap)
        PictureBox1.Image = DirectCast(EventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub Camara_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim camaras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If camaras.ShowDialog() = Windows.Forms.DialogResult.OK Then
            camara1 = camaras.VideoDevice
            AddHandler camara1.NewFrame, New NewFrameEventHandler(AddressOf CaptureImage)
            camara1.Start()
        End If
    End Sub

    Private Sub btnstartcamara_Click(sender As Object, e As EventArgs) Handles btnstartcamara.Click
        Dim camaras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If camaras.ShowDialog() = Windows.Forms.DialogResult.OK Then
            camara1 = camaras.VideoDevice
            AddHandler camara1.NewFrame, New NewFrameEventHandler(AddressOf CaptureImage)
            camara1.Start()
        End If
    End Sub

    Private Sub btncapture_Click(sender As Object, e As EventArgs) Handles btncapture.Click
        PictureBox2.Image = PictureBox1.Image
    End Sub

    Private Sub btnsaveimage_Click(sender As Object, e As EventArgs) Handles btnsaveimage.Click
        SaveFileDialog1.DefaultExt = ".jpg"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox2.Image.Save(SaveFileDialog1.FileName, Drawing.Imaging.ImageFormat.Jpeg)
            frmStudentRigitster.lbimage.Text = SaveFileDialog1.FileName
            Me.Close()
        Else
            frmStudentRigitster.lbimage.Text = ""
        End If

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class