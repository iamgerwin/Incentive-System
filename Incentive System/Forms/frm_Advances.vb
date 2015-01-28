Public Class frm_Advances
    Dim CL_Client As New cls_Clients
    Dim CL_Advances As New cls_Advances
    Dim Arr_Client As New ArrayList

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

            Me.DataGridView1.Rows.Clear()

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                With ds.Tables(0).Rows(i)
                    If Me.rdo_Open.Checked = True Then
                        If .Item("Liquidated") = 0 Then
                            Me.DataGridView1.Rows.Add()
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("Client").Value = .Item("client_name")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("ReferenceNumber").Value = .Item("ReferenceNumber")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("ChequeNumber").Value = .Item("ChequeNumber")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("ChequeAmount").Value = .Item("ChequeAmount")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("DisbursedAmount").Value = .Item("DisbursedAmount")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("Balance").Value = .Item("Balance")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("RemainingBalanceStatus").Value = IIf(IsDBNull(.Item("RemainingBalanceStatus")), "", .Item("RemainingBalanceStatus"))
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("Bank_Code").Value = .Item("Bank_Code")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("Date_Deposited").Value = .Item("Date_Deposited")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("isCheque").Value = .Item("isCheque")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("isDeposited").Value = .Item("isDeposited")
                        End If
                    ElseIf Me.rdo_Liquidated.Checked = True Then
                        If .Item("Liquidated") = 1 Then
                            Me.DataGridView1.Rows.Add()
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("Client").Value = .Item("client_name")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("ReferenceNumber").Value = .Item("ReferenceNumber")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("ChequeNumber").Value = .Item("ChequeNumber")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("ChequeAmount").Value = .Item("ChequeAmount")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("DisbursedAmount").Value = .Item("DisbursedAmount")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("Balance").Value = .Item("Balance")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("RemainingBalanceStatus").Value = IIf(IsDBNull(.Item("RemainingBalanceStatus")), "", .Item("RemainingBalanceStatus"))
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("Bank_Code").Value = .Item("Bank_Code")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("Date_Deposited").Value = .Item("Date_Deposited")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("isCheque").Value = .Item("isCheque")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("isDeposited").Value = .Item("isDeposited")

                        End If
                    ElseIf Me.rdo_All.Checked = True Then
                        Me.DataGridView1.Rows.Add()
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("Client").Value = .Item("client_name")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("ReferenceNumber").Value = .Item("ReferenceNumber")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("ChequeNumber").Value = .Item("ChequeNumber")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("ChequeAmount").Value = .Item("ChequeAmount")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("DisbursedAmount").Value = .Item("DisbursedAmount")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("Balance").Value = .Item("Balance")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("RemainingBalanceStatus").Value = IIf(IsDBNull(.Item("RemainingBalanceStatus")), "", .Item("RemainingBalanceStatus"))
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("Bank_Code").Value = .Item("Bank_Code")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("Date_Deposited").Value = .Item("Date_Deposited")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("isCheque").Value = .Item("isCheque")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("isDeposited").Value = .Item("isDeposited")
                    End If
                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frm_Advances_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frm_Advances_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBOClientLoad()
        Me.cbo_Client.SelectedIndex = 0
        Me.rdo_All.Checked = True
    End Sub

  
    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        Try
            frm_Advances_Insert.ShowDialog()
            'frm_Advances_Insert.cbo_Client.SelectedText = Me.cbo_Client.SelectedText
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbo_Client_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_Client.SelectedIndexChanged
        LoadDataGrid()
    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Try
            If Me.DataGridView1.SelectedRows.Count > 0 Then
                If Me.DataGridView1.SelectedRows(0).Cells("Liquidated").Value = 1 Then
                    MessageBox.Show("Item is already liquidated. Edit not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    frm_Advances_Insert.EditMode = True
                    frm_Advances_Insert.cbo_Client.SelectedText = Me.cbo_Client.SelectedText
                    frm_Advances_Insert.ShowDialog()
                End If
            Else
                MessageBox.Show("Please select a Reference Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        Try
            If Me.DataGridView1.SelectedRows.Count > 0 Then
                If MessageBox.Show("Are you want to delete selected record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    CL_Advances.Delete_Advances(Me.DataGridView1.SelectedRows(0).Cells("ReferenceNumber").Value)
                    MessageBox.Show("Record deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    LoadDataGrid()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub rdo_All_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_All.CheckedChanged
        LoadDataGrid()
    End Sub

    Private Sub rdo_Open_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Open.CheckedChanged
        LoadDataGrid()
    End Sub

    Private Sub rdo_Liquidated_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Liquidated.CheckedChanged
        LoadDataGrid()
    End Sub
End Class