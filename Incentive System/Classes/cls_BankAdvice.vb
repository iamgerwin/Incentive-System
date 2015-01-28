Public Class cls_BankAdvice
    Public Function BankAdviceDisplay(ByVal ReferenceID, ByVal BankID)
        Dim con As New cls_Connection

        Dim DS As New DataSet

        Try
            con.ConnectPayroll()
            Dim query As String = "EXEC proc_Incentive_Bank_Advice_Display '" & ReferenceID & "','" & BankID & "'"
            Dim dscmd As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(query, con.ConString)
            dscmd.Fill(DS, "tbl_BankAdvice")


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.ConString.Close()
            GC.Collect()
        End Try
        Return DS
    End Function

    Public Function SearchBanks(ByVal BankID)
        Dim con As New cls_Connection

        Dim DS As New DataSet

        Try
            con.ConnectHRIS2014()
            Dim query As String = "EXEC proc_search_bank '" & BankID & "'"
            Dim dscmd As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(query, con.ConString)
            dscmd.Fill(DS, "tbl_Bank")


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.ConString.Close()
            GC.Collect()
        End Try
        Return DS
    End Function
End Class
