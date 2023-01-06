<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmwebcam
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btnstart = New System.Windows.Forms.Button()
        Me.Btncapture = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(988, 616)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Btnstart
        '
        Me.Btnstart.Location = New System.Drawing.Point(123, 660)
        Me.Btnstart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btnstart.Name = "Btnstart"
        Me.Btnstart.Size = New System.Drawing.Size(150, 35)
        Me.Btnstart.TabIndex = 1
        Me.Btnstart.Text = "start_cameras"
        Me.Btnstart.UseVisualStyleBackColor = True
        '
        'Btncapture
        '
        Me.Btncapture.Location = New System.Drawing.Point(754, 660)
        Me.Btncapture.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btncapture.Name = "Btncapture"
        Me.Btncapture.Size = New System.Drawing.Size(150, 35)
        Me.Btncapture.TabIndex = 2
        Me.Btncapture.Text = "capture"
        Me.Btncapture.UseVisualStyleBackColor = True
        '
        'frmwebcam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.webcamapplit.My.Resources.Resources.images1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(988, 714)
        Me.Controls.Add(Me.Btncapture)
        Me.Controls.Add(Me.Btnstart)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmwebcam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WebcamApplication"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Btnstart As System.Windows.Forms.Button
    Friend WithEvents Btncapture As System.Windows.Forms.Button
End Class
