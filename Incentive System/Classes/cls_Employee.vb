Public Class cls_Employee
    Public Function DisplayEmployeeByClientCode(ByVal Client_Code As String)
        Dim con As New cls_Connection

        Dim DS As New DataSet

        Try
            con.ConnectPayroll()
            Dim query As String = "EXEC proc_EmployeeInfo_Display_By_ClientNo '" & Client_Code & "'"
            Dim dscmd As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(query, con.ConString)
            dscmd.Fill(DS, "tbl_Employee")


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.ConString.Close()
            GC.Collect()
        End Try
        Return DS
    End Function
End Class
