Public Class cls_Liquidate
    Public Sub Liquidate_Advances(ByVal ReferenceNumber As Integer, ByVal RemainingBalanceStatus As String)
        Dim con As New cls_Connection
        Dim success As New Decimal

        Try
            con.ConnectPayroll()
            con.cmd.CommandText = "EXEC proc_Incentive_Advances_Liquidate " & ReferenceNumber & "," & mod_Login.LoginUserID & ",'" & RemainingBalanceStatus & "'"
            con.cmd.ExecuteReader()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.ConString.Close()
            GC.Collect()
        End Try
    End Sub

    
End Class
