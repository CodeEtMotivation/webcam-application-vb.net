Public Class frmacceuille

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 1
        Else
            Timer1.Enabled = False
            Frmpageacceuille.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub frmacceuille_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub
End Class