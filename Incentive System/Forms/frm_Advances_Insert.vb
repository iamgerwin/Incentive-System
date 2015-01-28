Public Class frm_Advances_Insert
    Dim CL_Client As New cls_Clients
    Dim CL_Advances As New cls_Advances
    Dim CL_Bank As New cls_BankAdvice
    Dim Arr_Client As New ArrayList
    Dim Arr_Bank As New ArrayList
    Public EditMode As New Boolean

    Private Sub CBOBankLoad()
        Dim DSBank As New DataSet
        DSBank = CL_Bank.SearchBanks(Nothing)
        cbo_Bank.Items.Clear()
        Arr_Bank.Clear()
        For ctr As Integer = 0 To DSBank.Tables("tbl_Bank").Rows.Count - 1
            Me.cbo_Bank.Items.Add(DSBank.Tables("tbl_Bank").Rows(ctr).Item("bank_name"))
            Me.Arr_Bank.Add(DSBank.Tables("tbl_Bank").Rows(ctr).Item("bank_code"))
            'Me.Arr_Bank_Manager.Add(DSBank.Tables("tbl_Bank").Rows(ctr).Item("bank_manager"))
            'Me.Arr_Bank_Address.Add(DSBank.Tables("tbl_Bank").Rows(ctr).Item("bank_address"))
        Next
    End Sub

    Private Sub CBOClientLoad()
        Try
            Dim DSClient As New DataSet
            DSClient = CL_Client.DisplayClients
            For ctr As Integer = 0 To DSClient.Tables("tbl_Client").Rows.Count - 1
                Me.cbo_Client.Items.Add(DSClient.Tables("tbl_Client").Rows(ctr).Item(1))
                Me.Arr_Client.Add(DSClient.Tables("tbl_Client").Rows(ctr).Item(0))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frm_Advances_Insert_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frm_Advances.LoadDataGrid()
        Me.Dispose()
    End Sub

    Private Sub frm_Advances_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBOClientLoad()
        CBOBankLoad()

        If Me.EditMode = True Then
            Me.cbo_Client.Enabled = False
            Me.txt_ReferenceNumber.Text = frm_Advances.DataGridView1.SelectedRows(0).Cells("ReferenceNumber").Value
            Me.cbo_Client.SelectedText = frm_Advances.DataGridView1.SelectedRows(0).Cells("Client").Value
            Me.txt_ChequeNumber.Text = frm_Advances.DataGridView1.SelectedRows(0).Cells("ChequeNumber").Value
            Me.txt_ChequeAmount.Text = frm_Advances.DataGridView1.SelectedRows(0).Cells("ChequeAmount").Value
            Me.dtp_DateDeposited.Value = CDate(frm_Advances.DataGridView1.SelectedRows(0).Cells("Date_Deposited").Value).Date
            Me.rdo_Cheque.Checked = frm_Advances.DataGridView1.SelectedRows(0).Cells("isCheque").Value
            Me.rdo_BankDeposit.Checked = frm_Advances.DataGridView1.SelectedRows(0).Cells("isDeposited").Value

            For i As Integer = 0 To Me.Arr_Bank.Count - 1
                If Arr_Bank(i) = frm_Advances.DataGridView1.SelectedRows(0).Cells("bank_code").Value Then
                    Me.cbo_Bank.SelectedIndex = i
                    Exit For
                End If
            Next
        End If
    End Sub

    
    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click

        Try
            If EditMode = False Then
                Dim success As Decimal
                success = CL_Advances.Insert_Advances(Me.Arr_Client(Me.cbo_Client.SelectedIndex), Trim(Me.txt_ChequeNumber.Text), Trim(Me.txt_ChequeAmount.Text), Me.Arr_Bank(Me.cbo_Bank.SelectedIndex), Me.dtp_DateDeposited.Value.Date, Me.rdo_Cheque.Checked, Me.rdo_BankDeposit.Checked)

                If success = 0 Then
                    MessageBox.Show("Client Advance saved!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.Close()
                Else
                    MessageBox.Show("Cheque Number already existing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.txt_ChequeNumber.Focus()
                    Me.txt_ChequeNumber.SelectAll()
                End If

            ElseIf EditMode = True Then
                'Me.cbo_Client.Enabled = False
                CL_Advances.Update_Advances(Me.Arr_Client(Me.cbo_Client.SelectedIndex), Trim(Me.txt_ChequeNumber.Text), Trim(Me.txt_ChequeAmount.Text), Trim(Me.txt_ReferenceNumber.Text))
                MessageBox.Show("Client Advance updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
            End If
            

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub
End Class