Public Class frm_EmployeeEdit
    Dim CL_Disbursement As New cls_Disbursement
    Public Bank_Name As String
    Public Bank_PayCard As String
    Public Bank_Account As String
    Private Sub DisplayATMDetails()
        Try
            If Me.rdo_ATM.Checked = True Then
                Me.txt_ATMDetails.Text = "Bank: " & Bank_Name & Environment.NewLine & "Account: " & Bank_Account

                If Bank_PayCard <> "" Then
                    Me.txt_ATMDetails.Text += Environment.NewLine & "Pay Card: " & Bank_PayCard
                End If
            Else
                Me.txt_ATMDetails.Text = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Try
            If MessageBox.Show("Are you sure you want to save this information?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                CL_Disbursement.Update_Disbursement(Me.txt_EmployeeNo.Text, Me.txt_ChequeReferenceNumber.Text, Me.txt_Amount.Text, Me.txt_CheckDetails.Text, Me.dtp_ScheduleOfRelease.Value.Date, Me.cbo_Status.Text, IIf(Me.rdo_ATM.Checked, 1, 0), IIf(Me.rdo_Cheque.Checked, 1, 0))
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frm_EmployeeEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplayATMDetails()
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
End Class