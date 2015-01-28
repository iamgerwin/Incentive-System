Public Class cls_Reports

    Public Function rptCollectionReport(ByVal client_code As String, ByVal datefrom As Date, ByVal dateto As Date)
        Dim con As New cls_Connection

        con.ConnectPayroll()

        Dim query As String = "EXEC proc_rpt_collection_report '" & client_code & "','" & datefrom & "','" & dateto & "'"
        Dim dscmd As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(query, con.ConString)
        Dim ds As New DataSet

        dscmd.Fill(ds, "vw_BillingSalesInvoices")
        con.ConString.Close()
        Return ds

    End Function


    Public Function rptCollectionORNumberTrackingBySeries(ByVal data As String, ByVal delimiter As String)
        Dim con As New cls_Connection

        con.ConnectPayroll()

        Dim query As String = "EXEC proc_rpt_collection_by_or_number_series '" & data & "','" & delimiter & "'"
        Dim dscmd As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(query, con.ConString)
        Dim ds As New DataSet

        dscmd.Fill(ds, "vw_BillingSalesInvoices")
        con.ConString.Close()
        Return ds

    End Function

    Public Function rptARTrackingReport(ByVal client_code As String, ByVal si_status As String, ByVal from_date As Date, ByVal to_date As Date)
        Dim con As New cls_Connection

        con.ConnectPayroll()

        Dim query As String = "EXEC proc_rpt_ar_tracking_report '" & client_code & "','" & si_status & "','" & from_date & "','" & to_date & "'"
        Dim dscmd As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(query, con.ConString)
        Dim ds As New DataSet

        dscmd.Fill(ds, "vw_BillingSalesInvoices")
        con.ConString.Close()
        Return ds

    End Function

End Class
