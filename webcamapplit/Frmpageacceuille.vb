Public Class Frmpageacceuille

    Private Sub DESCRIPTIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DESCRIPTIONToolStripMenuItem.Click
        Dim frmf As New Frmdescription
        frmf.MdiParent = Me
        frmf.Show()

    End Sub

    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitterToolStripMenuItem.Click
        End
    End Sub

    Private Sub NouvelleCaptureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouvelleCaptureToolStripMenuItem.Click
        Dim frmf As New frmwebcam
        frmf.MdiParent = Me
        frmf.Show()

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class