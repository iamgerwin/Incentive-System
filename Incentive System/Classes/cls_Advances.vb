Public Class cls_Advances

    Public Sub Delete_Advances(ByVal ReferenceNumber As Integer)
        Dim con As New cls_Connection
        Dim success As New Decimal

        Try
            con.ConnectPayroll()
            con.cmd.CommandText = "EXEC proc_Incentive_Advances_Delete " & ReferenceNumber & "," & mod_Login.LoginUserID
            con.cmd.ExecuteReader()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.ConString.Close()
            GC.Collect()
        End Try
    End Sub

    Public Sub Update_Advances(ByVal Client_Code As String, ByVal ChequeNumber As String, ByVal ChequeAmount As Decimal, ByVal ReferenceNumber As Integer)
        Dim con As New cls_Connection
        Dim success As New Decimal

        Try
            con.ConnectPayroll()
            con.cmd.CommandText = "EXEC proc_Incentive_Advances_Update '" & Client_Code & "','" & ChequeNumber & "'," & ChequeAmount & "," & ReferenceNumber
            con.cmd.ExecuteReader()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.ConString.Close()
            GC.Collect()
        End Try


    End Sub
    Public Function Insert_Advances(ByVal Client_Code As String, ByVal ChequeNumber As String, ByVal ChequeAmount As Decimal, ByVal Bank_Code As String, ByVal Date_Deposited As Date, ByVal isCheque As Integer, ByVal isDeposited As Integer)
        Dim con As New cls_Connection
        Dim success As New Decimal

        Try
            con.ConnectPayroll()
            con.cmd.CommandText = "EXEC proc_Incentive_Advances_Insert '" & Client_Code & "','" & ChequeNumber & "'," & ChequeAmount & "," & mod_Login.LoginUserID & ",'" & Bank_Code & "','" & Date_Deposited & "'," & Math.Abs(isCheque) & "," & Math.Abs(isDeposited)
            success = con.cmd.ExecuteScalar

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.ConString.Close()
            GC.Collect()
        End Try

        Return success
    End Function

    Public Function Search_Advances_By_Client_Code(ByVal Client_Code As String)
        Dim con As New cls_Connection
        Dim ds As New DataSet

        Try
            con.ConnectPayroll()
            Dim query As String
            If Client_Code = "All" Then
                query = "EXEC proc_Incentive_Advances_Search"
            Else
                query = "EXEC proc_Incentive_Advances_Search_By_Client '" & Client_Code & "'"
            End If

            Dim dscmd As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(query, con.ConString)
            dscmd.Fill(ds, "tbl_IncentiveAdvances")


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.ConString.Close()
            GC.Collect()
        End Try

        Return ds
    End Function

    Public Function Check_Advances(ByVal ReferenceNumber As String)
        Dim con As New cls_Connection
        Dim count As New Decimal

        Try
            con.ConnectPayroll()
            con.cmd.CommandText = "EXEC proc_Incentive_Advances_Check_Release " & ReferenceNumber
            count = con.cmd.ExecuteScalar

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.ConString.Close()
            GC.Collect()
        End Try

        Return count
    End Function
End Class
