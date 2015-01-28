Public Class frm_RptCollectionReport


    Dim cl As New cls_Clients
    Dim arr_client_code As New ArrayList
    Dim rpt As New cls_Reports

    Private Sub PopulateClientCombobox()
        Try
            Dim ds As New DataSet

            Me.cmbClient.Text = Nothing
            Me.cmbClient.Items.Clear()
            Me.arr_client_code.Clear()

            ds = Me.cl.SearchClient(Nothing)

            Me.cmbClient.Items.Add("All")
            Me.arr_client_code.Add("0")

            For i As Integer = 0 To ds.Tables("tbl_Client").Rows.Count - 1
                With ds.Tables("tbl_Client").Rows(i)
                    Me.arr_client_code.Add(.Item("client_code"))
                    Me.cmbClient.Items.Add(.Item("client_name"))
                End With
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Try
            Dim ds As New DataSet
            Dim frm As New frm_ReportViewer
            Dim cr As New rptCollectionReportNew

            ds = Me.rpt.rptCollectionReport(Me.arr_client_code.Item(Me.cmbClient.SelectedIndex), Me.dtpDateFrom.Text, Me.dtpDateTo.Text)

            If ds.Tables("vw_BillingSalesInvoices").Rows.Count = 0 Then
                MsgBox("No records found.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            cr.SetDataSource(ds.Tables("vw_BillingSalesInvoices"))
            cr.SetParameterValue("paramDateFrom", Me.dtpDateFrom.Text)
            cr.SetParameterValue("paramDateTo", Me.dtpDateTo.Text)
            frm.CrystalReportViewer1.ReportSource = cr
            frm.ShowDialog()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frm_RptCollectionReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.PopulateClientCombobox()
            Me.cmbClient.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class