Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow

Public Class frmwebcam
    Dim camera As VideoCaptureDevice
    Dim bmp As Bitmap
    Private Sub captured(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)

    End Sub

    Private Sub Btnstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnstart.Click
        Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If cameras.ShowDialog = Windows.Forms.DialogResult.OK Then
            camera = cameras.VideoDevice
            AddHandler camera.NewFrame, New NewFrameEventHandler(AddressOf captured)
            camera.Start()

        End If
    End Sub

    Private Sub Btncapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncapture.Click
        camera.Stop()

    End Sub

    Private Sub frmwebcam_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            camera.Stop()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmwebcam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class