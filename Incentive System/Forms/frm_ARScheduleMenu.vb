Public Class frm_ARScheduleMenu

    Private Sub btnARSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnARSchedule.Click
        Dim frm As New frm_ARSchedule
        frm.ShowDialog()
    End Sub

    Private Sub btnARSchedulePerDateRange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnARSchedulePerDateRange.Click
        Dim frm As New frm_ARSchedulePerDateRange
        frm.ShowDialog()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnARScheduleAging_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnARScheduleAging.Click
        Dim frm As New frm_ARScheduleAging
        frm.ShowDialog()
    End Sub

    Private Sub btnARTrackingReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnARTrackingReport.Click
        Dim frm As New frm_ARTrackingReportPerClient
        frm.ShowDialog()
    End Sub
End Class