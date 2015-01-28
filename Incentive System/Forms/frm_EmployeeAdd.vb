Public Class frm_EmployeeAdd
    Dim CL_Emp As New cls_Employee
    Dim CL_Dis As New cls_Disbursement
    Public ReferenceID As Integer = 0
    Dim Arr_EmployeeNo As New ArrayList
    Dim Arr_EmployeeStatus As New ArrayList
    Dim Arr_BankName As New ArrayList
    Dim Arr_BankPayCard As New ArrayList
    Dim Arr_BankAccount As New ArrayList

    Private Sub DisplayATMDetails()
        Try
            If Me.rdo_ATM.Checked = True Then
                Me.txt_ATMDetails.Text = "Bank: " & Me.Arr_BankName(Me.cbo_EmployeeName.SelectedIndex) & Environment.NewLine & "Account: " & Me.Arr_BankAccount(Me.cbo_EmployeeName.SelectedIndex)

                If Me.Arr_BankPayCard(Me.cbo_EmployeeName.SelectedIndex) <> "" Then
                    Me.txt_ATMDetails.Text += Environment.NewLine & "Pay Card: " & Me.Arr_BankPayCard(Me.cbo_EmployeeName.SelectedIndex)
                End If
            Else
                Me.txt_ATMDetails.Text = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Public Sub LoadEmployee(ByVal Client_Code As String)
        Try
            Dim DSEmp As New DataSet
            DSEmp = CL_Emp.DisplayEmployeeByClientCode(Client_Code)

            Me.cbo_EmployeeName.Items.Clear()

            For ctr As Integer = 0 To DSEmp.Tables(0).Rows.Count - 1
                With DSEmp.Tables(0).Rows(ctr)
                    Me.cbo_EmployeeName.Items.Add(.Item("EmpLastName").ToString & ", " & .Item("EmpFirstName").ToString)
                    Me.Arr_EmployeeNo.Add(.Item("EmployeeNo").ToString)
                    Me.Arr_EmployeeStatus.Add(.Item("Employment_Status").ToString)
                    Me.Arr_BankName.Add(.Item("Bank_Name").ToString)
                    Me.Arr_BankPayCard.Add(.Item("bank_paycard").ToString)
                    Me.Arr_BankAccount.Add(.Item("bank_account").ToString)
                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frm_EmployeeAdd_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frm_EmployeeAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbo_Status.SelectedIndex = 0
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Try
            CL_Dis.Insert_Disbursement_All(Me.txt_EmployeeNo.Text, Me.txt_ChequeReferenceNumber.Text, Me.txt_Amount.Text, Me.txt_CheckDetails.Text, Me.dtp_ScheduleOfRelease.Value.Date, Me.cbo_Status.Text, IIf(Me.rdo_ATM.Checked, 1, 0), IIf(Me.rdo_Cheque.Checked = True, 1, 0), Me.txt_EmploymentStatus.Text)
            MessageBox.Show("Save complete!", "Save", MessageBoxButtons.OK)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbo_EmployeeName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_EmployeeName.SelectedIndexChanged
        Try
            Me.txt_EmployeeName.Text = Me.cbo_EmployeeName.Text
            Me.txt_EmployeeNo.Text = Me.Arr_EmployeeNo(Me.cbo_EmployeeName.SelectedIndex)
            Me.txt_EmploymentStatus.Text = Me.Arr_EmployeeStatus(Me.cbo_EmployeeName.SelectedIndex)

            Me.DisplayATMDetails()
            Me.txt_Amount.Text = Nothing
            Me.txt_CheckDetails.Text = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub rdo_Cheque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Cheque.CheckedChanged
        If Me.rdo_Cheque.Checked = True Then
            Me.txt_CheckDetails.Enabled = True

        Else
            Me.txt_CheckDetails.Enabled = False
            Me.txt_CheckDetails.Text = Nothing
        End If
        DisplayATMDetails()
    End Sub

    Private Sub TableLayoutPanel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TableLayoutPanel4.Paint

    End Sub

    Private Sub rdo_ATM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_ATM.CheckedChanged

    End Sub
End Class