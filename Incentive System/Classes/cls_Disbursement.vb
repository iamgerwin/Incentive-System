Public Class cls_Disbursement
    Public Sub Insert_Disbursement(ByVal EmployeeNo As String, ByVal ReferenceNumber As Integer)
        Dim con As New cls_Connection
        Dim success As New Decimal

        Try
            con.ConnectPayroll()
            con.cmd.CommandText = "EXEC proc_Incentive_Disbursement_Insert '" & EmployeeNo & "'," & ReferenceNumber & "," & mod_Login.LoginUserID
            con.cmd.ExecuteReader()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.ConString.Close()
            GC.Collect()
        End Try
    End Sub
    Public Sub Insert_Disbursement_All(ByVal EmployeeNo As String, ByVal ReferenceNumber As Integer, ByVal DisbursedAmount As Decimal, ByVal CheckDetails As String, ByVal ScheduleOfRelease As Date, ByVal Status As String, ByVal On_ATM As Integer, ByVal On_Cheque As Integer, ByVal Employment_Status As String)
        Dim con As New cls_Connection
        Dim success As New Decimal

        Try
            con.ConnectPayroll()
            con.cmd.CommandText = "EXEC proc_Incentive_Disbursement_Insert_All '" & EmployeeNo & "'," & ReferenceNumber & "," & DisbursedAmount & ",'" & CheckDetails & "','" & ScheduleOfRelease & "','" & Status & "'," & mod_Login.LoginUserID & "," & On_ATM & "," & On_Cheque & ",'" & Employment_Status & "'"
            con.cmd.ExecuteReader()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.ConString.Close()
            GC.Collect()
        End Try
    End Sub

    Public Function Search_Disbursement_By_ReferenceID(ByVal ReferenceID As Integer)
        Dim con As New cls_Connection
        Dim ds As New DataSet

        Try
            con.ConnectPayroll()
            Dim query As String = "EXEC proc_Incentive_Disbursement_Search_By_ReferenceID " & ReferenceID & ""
            Dim dscmd As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(query, con.ConString)
            dscmd.Fill(ds, "tbl_IncentiveDisbursement")


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.ConString.Close()
            GC.Collect()
        End Try

        Return ds
    End Function

    Public Sub Delete_Disbursement(ByVal EmployeeNo As String, ByVal ReferenceNumber As Integer)
        Dim con As New cls_Connection
        Dim success As New Decimal

        Try
            con.ConnectPayroll()
            con.cmd.CommandText = "EXEC proc_Incentive_Disbursement_Delete '" & EmployeeNo & "'," & ReferenceNumber & "," & mod_Login.LoginUserID
            con.cmd.ExecuteReader()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.ConString.Close()
            GC.Collect()
        End Try
    End Sub

    Public Sub Update_Disbursement(ByVal EmployeeNo As String, ByVal ReferenceNumber As Integer, ByVal DisbursedAmount As Decimal, ByVal CheckDetails As String, ByVal ScheduleOfRelease As Date, ByVal Status As String, ByVal On_ATM As Integer, ByVal On_Cheque As Integer)
        Dim con As New cls_Connection
        Dim success As New Decimal

        Try
            con.ConnectPayroll()
            con.cmd.CommandText = "EXEC proc_Incentive_Disbursement_Update '" & EmployeeNo & "'," & ReferenceNumber & "," & DisbursedAmount & ",'" & CheckDetails & "','" & ScheduleOfRelease & "','" & Status & "'," & On_ATM & "," & On_Cheque
            con.cmd.ExecuteReader()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.ConString.Close()
            GC.Collect()
        End Try
    End Sub

    Public Sub Release_Disbursement(ByVal DisbursedID As Integer, ByVal ReleaseDate As Date)
        Dim con As New cls_Connection
        Dim success As New Decimal

        Try
            con.ConnectPayroll()
            con.cmd.CommandText = "EXEC proc_Incentive_Disbursement_Released " & DisbursedID & "," & mod_Login.LoginUserID & ",'" & ReleaseDate & "'"
            con.cmd.ExecuteReader()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.ConString.Close()
            GC.Collect()

        End Try
    End Sub
End Class
