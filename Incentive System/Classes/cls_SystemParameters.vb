Public Class cls_SystemParameters
    Friend CompanyName As String
    Friend CompanyAddress As String
    Friend NotedBy As String
    Friend NotedByPosition As String
    Friend ApprovedBy As String
    Friend ApprovedByPosition As String

    Public Sub GetSystemParameters()

        Dim con As New cls_Connection

        Dim DS As New DataSet

        Try
            con.ConnectPayroll()
            Dim query As String = "EXEC proc_Incentive_SystemParameters_Display"
            Dim dscmd As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(query, con.ConString)
            dscmd.Fill(DS, "tbl_Bank")


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.ConString.Close()
            GC.Collect()
        End Try

        If DS.Tables(0).Rows.Count > 0 Then
            Me.CompanyName = DS.Tables(0).Rows(0).Item("CompanyName").ToString
            Me.CompanyAddress = DS.Tables(0).Rows(0).Item("CompanyName").ToString
            Me.NotedBy = DS.Tables(0).Rows(0).Item("NotedBy").ToString
            Me.NotedByPosition = DS.Tables(0).Rows(0).Item("NotedByPosition").ToString
            Me.ApprovedBy = DS.Tables(0).Rows(0).Item("ApprovedBy").ToString
            Me.ApprovedByPosition = DS.Tables(0).Rows(0).Item("ApprovedByPosition").ToString
        End If

    End Sub
End Class
