Public Class cls_Accounts
    Public Function LoginUser(ByVal Username, ByVal Password)
        Dim con As New cls_Connection
        Dim temp As Boolean = True

        Try
            con.ConnectPayroll()

            con.cmd.CommandText = "EXEC proc_Account_Search '" & Username & "','" & Password & "'"
            con.sqlRead = con.cmd.ExecuteReader

            Do Until con.sqlRead.Read = False
                If con.sqlRead.GetInt32(0) = 0 Then
                    temp = False
                Else
                    temp = True
                End If
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.ConString.Close()
            GC.Collect()
        End Try

        Return temp

    End Function
    Public Function GetAccountInfo(ByVal Username, ByVal Password)
        Dim con As New cls_Connection
        Dim ds As New DataSet
        con.ConnectPayroll()
        Try
            Dim query As String = "EXEC proc_Account_SelectInfo '" & Username & "','" & Password & "'"
            Dim dscmd As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(query, con.ConString)

            dscmd.Fill(ds, "tbl_Account")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.ConString.Close()
            GC.Collect()
        End Try

        Return ds
    End Function
End Class
