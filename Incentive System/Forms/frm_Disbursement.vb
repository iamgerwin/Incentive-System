Public Class frm_Disbursement
    Dim CL_Client As New cls_Clients
    Dim CL_Advances As New cls_Advances
    Dim CL_Disbursement As New cls_Disbursement
    Dim Arr_Client As New ArrayList
    Public Sub ClearData()
        Me.dgv_Employee.Rows.Clear()
      
        Me.txt_ReferenceNumber.Text = Nothing
        Me.txt_ChequeNumber.Text = Nothing
        Me.txt_ChequeAmount.Text = Nothing
        Me.txt_Disbursed.Text = Nothing
        Me.txt_Balance.Text = Nothing

        Me.txt_Amount.Text = Nothing
        Me.txt_CheckDetails.Text = Nothing
        Me.txt_ChequeReferenceNumber.Text = Nothing
        Me.txt_EmployeeNo.Text = Nothing
        Me.txt_EmployeeName.Text = Nothing

    End Sub

    Private Sub LoadEmployees()
        Dim ds As New DataSet
        ds = CL_Disbursement.Search_Disbursement_By_ReferenceID(Me.txt_ReferenceNumber.Text)

        Me.dgv_Employee.Rows.Clear()

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            With ds.Tables(0).Rows(i)
                dgv_Employee.Rows.Add()
                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("EmployeeNo").Value = .Item("EmployeeNo").ToString
                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("EmployeeName").Value = .Item("EmpLastName").ToString & ", " & .Item("EmpFirstName").ToString
                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("EmployeeDisbursedAmount").Value = .Item("EmployeeDisbursedAmount")
                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("DisbursedStatus").Value = .Item("Status").ToString
                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("ScheduleOfRelease").Value = IIf(IsDBNull(.Item("ScheduleOfRelease")), Nothing, .Item("ScheduleOfRelease"))
                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("CheckDetails").Value = .Item("CheckDetails").ToString
                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("On_ATM").Value = .Item("On_ATM").ToString
                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("On_Cheque").Value = .Item("On_Cheque").ToString
                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("Bank_Name").Value = .Item("Bank_Name").ToString
                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("Bank_PayCard").Value = .Item("Bank_PayCard").ToString
                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("Bank_Account").Value = .Item("Bank_Account").ToString
                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("Payment_Mode").Value = IIf(.Item("On_ATM") = 1, "ATM", "Cheque")
            End With
        Next
    End Sub

    Private Sub CBOClientLoad()
        Try
            Dim DSClient As New DataSet
            DSClient = CL_Client.DisplayClients
            Me.Arr_Client.Clear()
            Me.cbo_Client.Items.Clear()

            Me.Arr_Client.Add("All")
            Me.cbo_Client.Items.Add("All")

            For ctr As Integer = 0 To DSClient.Tables("tbl_Client").Rows.Count - 1
                Me.cbo_Client.Items.Add(DSClient.Tables("tbl_Client").Rows(ctr).Item(1))
                Me.Arr_Client.Add(DSClient.Tables("tbl_Client").Rows(ctr).Item(0))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub LoadDataGrid()
        Try
            Dim ds As New DataSet

            ds = CL_Advances.Search_Advances_By_Client_Code(Me.Arr_Client(Me.cbo_Client.SelectedIndex))

            Me.dgv_Advances.Rows.Clear()

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                With ds.Tables(0).Rows(i)
                    If .Item("Liquidated") = 0 Then
                        Me.dgv_Advances.Rows.Add()
                        Me.dgv_Advances.Rows(Me.dgv_Advances.Rows.Count - 1).Cells("Client_Code").Value = .Item("Client_Code")
                        Me.dgv_Advances.Rows(Me.dgv_Advances.Rows.Count - 1).Cells("Client").Value = .Item("client_name")
                        Me.dgv_Advances.Rows(Me.dgv_Advances.Rows.Count - 1).Cells("ReferenceNumber").Value = .Item("ReferenceNumber")
                        Me.dgv_Advances.Rows(Me.dgv_Advances.Rows.Count - 1).Cells("ChequeNumber").Value = .Item("ChequeNumber")
                        Me.dgv_Advances.Rows(Me.dgv_Advances.Rows.Count - 1).Cells("ChequeAmount").Value = .Item("ChequeAmount")
                        Me.dgv_Advances.Rows(Me.dgv_Advances.Rows.Count - 1).Cells("DisbursedAmount").Value = .Item("DisbursedAmount")
                        Me.dgv_Advances.Rows(Me.dgv_Advances.Rows.Count - 1).Cells("Balance").Value = .Item("Balance")
                    End If
                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frm_Disbursement_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    
    Private Sub frm_Disbursement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBOClientLoad()
        Me.cbo_Client.SelectedIndex = 0
       
    End Sub

    Private Sub cbo_Client_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_Client.SelectedIndexChanged
        LoadDataGrid()
        ClearData()
    End Sub

    Private Sub dgv_Advances_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Advances.CellClick
        If Me.dgv_Advances.SelectedRows.Count > 0 Then
            With Me.dgv_Advances.SelectedRows(0)
                Me.txt_ReferenceNumber.Text = .Cells("ReferenceNumber").Value
                Me.txt_ChequeNumber.Text = .Cells("ChequeNumber").Value
                Me.txt_ChequeAmount.Text = Format(.Cells("ChequeAmount").Value, "#,##0.00")
                Me.txt_Disbursed.Text = Format(IIf(IsDBNull(.Cells("DisbursedAmount").Value), 0, .Cells("DisbursedAmount").Value), "#,##0.00")
                Me.txt_Balance.Text = Format(.Cells("Balance").Value, "#,##0.00")
            End With
            LoadEmployees()
        End If
    End Sub

   
    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add.Click
        Try
            'frm_EmployeeSearch.LoadEmployee(Me.Arr_Client(Me.cbo_Client.SelectedIndex))
            'frm_EmployeeSearch.txt_Client.Text = Me.cbo_Client.Text
            'frm_EmployeeSearch.ReferenceID = Me.txt_ReferenceNumber.Text
            If Me.txt_ReferenceNumber.Text = Nothing Then
                MessageBox.Show("Please choose a cheque", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            frm_EmployeeAdd.LoadEmployee(Me.dgv_Advances.SelectedRows(0).Cells("Client_Code").Value)
            frm_EmployeeAdd.txt_Client.Text = Me.dgv_Advances.SelectedRows(0).Cells("Client").Value
            frm_EmployeeAdd.txt_ChequeReferenceNumber.Text = Me.txt_ReferenceNumber.Text
            frm_EmployeeAdd.ShowDialog()
            LoadEmployees()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub btn_Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Remove.Click
        If Me.dgv_Employee.SelectedRows.Count > 0 Then
            If Me.dgv_Employee.SelectedRows(0).Cells("DisbursedStatus").Value = "Released" Then
                MessageBox.Show("Item already released. Deletion is disabled.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If MessageBox.Show("Are you sure you want to remove " & Me.dgv_Employee.SelectedRows(0).Cells("EmployeeName").Value & "?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                CL_Disbursement.Delete_Disbursement(Me.dgv_Employee.SelectedRows(0).Cells("EmployeeNo").Value, Me.txt_ReferenceNumber.Text)
                CL_Disbursement.Search_Disbursement_By_ReferenceID(Me.txt_ReferenceNumber.Text)

                LoadEmployees()

                Me.txt_Amount.Text = Nothing
                Me.txt_CheckDetails.Text = Nothing
                Me.txt_ChequeReferenceNumber.Text = Nothing
                Me.txt_EmployeeNo.Text = Nothing
                Me.txt_EmployeeName.Text = Nothing

            End If
        End If
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        
    End Sub


    Private Sub dgv_Employee_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Employee.CellClick
        Try
            If Me.dgv_Employee.SelectedRows.Count > 0 Then
                With Me.dgv_Employee.SelectedRows(0)
                    Me.txt_ChequeReferenceNumber.Text = Me.txt_ReferenceNumber.Text
                    Me.txt_EmployeeNo.Text = .Cells("EmployeeNO").Value
                    Me.txt_EmployeeName.Text = .Cells("EmployeeName").Value
                    Me.txt_Amount.Text = CDec(IIf(IsDBNull(.Cells("EmployeeDisbursedAmount").Value), 0, .Cells("EmployeeDisbursedAmount").Value))
                    Me.txt_CheckDetails.Text = IIf(IsDBNull(.Cells("CheckDetails").Value), 0, .Cells("CheckDetails").Value)
                    Me.dtp_ScheduleOfRelease.Text = IIf(IsDBNull(.Cells("ScheduleOfRelease").Value), 0, .Cells("ScheduleOfRelease").Value)
                    Me.cbo_Status.Text = IIf(IsDBNull(.Cells("DisbursedStatus").Value), 0, .Cells("DisbursedStatus").Value)

                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

  
    Private Sub dgv_Employee_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Employee.CellContentClick

    End Sub

    Private Sub dgv_Advances_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Advances.CellContentClick

    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Try
            If Me.dgv_Employee.SelectedRows.Count > 0 Then
                With Me.dgv_Employee.SelectedRows(0)
                    If .Cells("DisbursedStatus").Value = "Open" Then
                        frm_EmployeeEdit.txt_ChequeReferenceNumber.Text = Me.txt_ReferenceNumber.Text
                        frm_EmployeeEdit.txt_EmployeeNo.Text = .Cells("EmployeeNO").Value
                        frm_EmployeeEdit.txt_EmployeeName.Text = .Cells("EmployeeName").Value
                        frm_EmployeeEdit.txt_Amount.Text = CDec(IIf(IsDBNull(.Cells("EmployeeDisbursedAmount").Value), 0, .Cells("EmployeeDisbursedAmount").Value))
                        frm_EmployeeEdit.txt_CheckDetails.Text = IIf(IsDBNull(.Cells("CheckDetails").Value), 0, .Cells("CheckDetails").Value)
                        frm_EmployeeEdit.dtp_ScheduleOfRelease.Text = IIf(IsDBNull(.Cells("ScheduleOfRelease").Value), 0, .Cells("ScheduleOfRelease").Value)
                        frm_EmployeeEdit.cbo_Status.Text = IIf(IsDBNull(.Cells("DisbursedStatus").Value), 0, .Cells("DisbursedStatus").Value)
                        frm_EmployeeEdit.rdo_ATM.Checked = .Cells("On_ATM").Value
                        frm_EmployeeEdit.rdo_Cheque.Checked = .Cells("On_Cheque").Value
                        frm_EmployeeEdit.Bank_Name = .Cells("Bank_Name").Value
                        frm_EmployeeEdit.Bank_PayCard = .Cells("Bank_PayCard").Value
                        frm_EmployeeEdit.Bank_Account = .Cells("Bank_Account").Value
                        frm_EmployeeEdit.ShowDialog()
                        LoadEmployees()
                    Else
                        MessageBox.Show("Item already released. Edit disabled.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    
                End With
            Else
                MessageBox.Show("Please select a employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub
End Class