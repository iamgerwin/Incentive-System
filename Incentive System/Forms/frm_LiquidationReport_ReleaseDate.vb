Public Class frm_LiquidationReport_ReleaseDate

    
    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub frm_LiquidationReport_ReleaseDate_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frm_LiquidationReport_ReleaseDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Release_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Release.Click
        frm_LiquidationReport.ReleaseDate = Me.dtp_ReleaseDate.Value.Date
        Me.Close()
    End Sub
End Class