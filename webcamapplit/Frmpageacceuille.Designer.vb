<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmpageacceuille
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ACCEUILLEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouvelleCaptureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DESCRIPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ACCEUILLEToolStripMenuItem, Me.DESCRIPTIONToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(947, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ACCEUILLEToolStripMenuItem
        '
        Me.ACCEUILLEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouvelleCaptureToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.ACCEUILLEToolStripMenuItem.Name = "ACCEUILLEToolStripMenuItem"
        Me.ACCEUILLEToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ACCEUILLEToolStripMenuItem.Text = "Fichier"
        '
        'NouvelleCaptureToolStripMenuItem
        '
        Me.NouvelleCaptureToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.NouvelleCaptureToolStripMenuItem.Name = "NouvelleCaptureToolStripMenuItem"
        Me.NouvelleCaptureToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.NouvelleCaptureToolStripMenuItem.Text = "Nouvelle Capture"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'DESCRIPTIONToolStripMenuItem
        '
        Me.DESCRIPTIONToolStripMenuItem.Name = "DESCRIPTIONToolStripMenuItem"
        Me.DESCRIPTIONToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.DESCRIPTIONToolStripMenuItem.Text = "Description"
        '
        'Frmpageacceuille
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.webcamapplit.My.Resources.Resources.images_21
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(947, 486)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frmpageacceuille"
        Me.Text = "Frmpageacceuille"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ACCEUILLEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DESCRIPTIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouvelleCaptureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
