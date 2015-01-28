Public Class frm_CollectionReportMenu

    Private Sub btnCollectionORNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCollectionORNumber.Click
        Dim frm As New frm_CollectionORTrackingReport
        frm.ShowDialog()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class