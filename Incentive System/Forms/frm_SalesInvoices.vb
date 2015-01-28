Public Class frm_SalesInvoices

    Dim si As New cls_SalesInvoice
    Dim cl As New cls_Clients
    Dim arr_client_code As New ArrayList
    Dim _status As String = Nothing

    Private Sub PopulateClientCombobox()
        Try
            Dim ds As New DataSet

            Me.cmbClient.Items.Clear()
            Me.cmbClient.Text = Nothing
            Me.arr_client_code.Clear()

            ds = Me.cl.SearchClient(Nothing)

            Me.cmbClient.Items.Add("All")
            Me.arr_client_code.Add("0")

            For i As Integer = 0 To ds.Tables("tbl_Client").Rows.Count - 1
                With ds.Tables("tbl_Client").Rows(i)
                    Me.arr_client_code.Add(.Item("client_code"))
                    Me.cmbClient.Items.Add(.Item("client_name"))
                End With
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoadData()
        Try
            Dim ds As New DataSet


            If Me._status = Nothing Then
                Me.rbAll.Checked = True
            End If

            Me.dgvSalesInvoice.Rows.Clear()

            Me.si.client.client_code = Me.arr_client_code.Item(Me.cmbClient.SelectedIndex)
            ds = Me.si.SearchSalesInvoiceByClientCodeAndStatus(Me._status)

            If ds.Tables("vw_BillingSalesInvoices").Rows.Count = 0 Then
                Me.DisableFields()
                Exit Sub
            End If

            For i As Integer = 0 To ds.Tables("vw_BillingSalesInvoices").Rows.Count - 1
                With ds.Tables("vw_BillingSalesInvoices").Rows(i)
                    Me.dgvSalesInvoice.Rows.Add()
                    Me.dgvSalesInvoice.Rows(i).Cells("si_id").Value = .Item("si_id")
                    Me.dgvSalesInvoice.Rows(i).Cells("reference_number").Value = .Item("reference_number")
                    Me.dgvSalesInvoice.Rows(i).Cells("invoice_date").Value = .Item("invoice_date")
                    Me.dgvSalesInvoice.Rows(i).Cells("client_code").Value = .Item("client_code")
                    Me.dgvSalesInvoice.Rows(i).Cells("client_name").Value = .Item("client_name")
                    Me.dgvSalesInvoice.Rows(i).Cells("cut_off_from").Value = .Item("cut_off_from")
                    Me.dgvSalesInvoice.Rows(i).Cells("cut_off_to").Value = .Item("cut_off_to")
                    Me.dgvSalesInvoice.Rows(i).Cells("particulars").Value = .Item("particulars")
                    Me.dgvSalesInvoice.Rows(i).Cells("remarks").Value = .Item("remarks")
                    Me.dgvSalesInvoice.Rows(i).Cells("ar_amount").Value = .Item("ar_amount")
                    Me.dgvSalesInvoice.Rows(i).Cells("amount_received").Value = IIf(IsDBNull(.Item("amount_received")) = True, 0, .Item("amount_received"))
                    Me.dgvSalesInvoice.Rows(i).Cells("due_date").Value = IIf(IsDBNull(.Item("due_date")) = True, Nothing, .Item("due_date"))
                    Me.dgvSalesInvoice.Rows(i).Cells("balance").Value = CDec(Me.dgvSalesInvoice.Rows(i).Cells("ar_amount").Value) - CDec(Me.dgvSalesInvoice.Rows(i).Cells("amount_received").Value)
                    Me.dgvSalesInvoice.Rows(i).Cells("receiving_date").Value = IIf(IsDBNull(.Item("receiving_date")) = True, Nothing, .Item("receiving_date"))
                    Me.dgvSalesInvoice.Rows(i).Cells("collection_date").Value = IIf(IsDBNull(.Item("collection_date")) = True, Nothing, .Item("collection_date"))
                    Me.dgvSalesInvoice.Rows(i).Cells("date_cancelled").Value = IIf(IsDBNull(.Item("date_cancelled")) = True, Nothing, .Item("date_cancelled"))
                    Me.dgvSalesInvoice.Rows(i).Cells("si_status").Value = .Item("si_status")
                End With
            Next

            Me.EnableFields()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frm_SalesInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.PopulateClientCombobox()
            Me.cmbClient.SelectedIndex = 0
            Me.cmbClient.Focus()
            Me.rbAll.Checked = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Try
            Dim frm As New frm_NewSalesInvoices
            frm.ShowDialog()
            Me.LoadData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rbAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAll.CheckedChanged
        Try
            Me._status = "All"
            Me.LoadData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rbOpen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbOpen.CheckedChanged
        Try
            Me._status = "Open"
            Me.LoadData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rbCancelled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCancelled.CheckedChanged
        Try
            Me._status = "Cancelled"
            Me.LoadData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rbCollected_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCollected.CheckedChanged
        Try
            Me._status = "Collected"
            Me.LoadData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbClient_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbClient.SelectedIndexChanged
        Try
            Me.LoadData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            Dim frm As New frm_UpdateSalesInvoices
            frm._si_id = Me.dgvSalesInvoice.CurrentRow.Cells("si_id").Value
            frm.ShowDialog()
            Me.LoadData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim check As Boolean = False

            If Me.dgvSalesInvoice.CurrentRow.Cells("si_status").Value = "Collected" Then
                MsgBox("Unable to delete record with COLLECTED status.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If MessageBox.Show("Do you really want to delete the selected record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Me.si.si_id = Me.dgvSalesInvoice.CurrentRow.Cells("si_id").Value
                check = Me.si.DeleteSalesInvoice

                If check = True Then
                    MsgBox("Record deleted.", MsgBoxStyle.Information)
                    Me.LoadData()
                Else
                    MsgBox("Error in deletion.", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelSI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelSI.Click
        Try
            Dim check As Boolean = False

            If Me.dgvSalesInvoice.CurrentRow.Cells("si_status").Value = "Collected" Or Me.dgvSalesInvoice.CurrentRow.Cells("si_status").Value = "Cancelled" Then
                MsgBox("Unable to cancel invoice with COLLECETED/CANCELLED status.", MsgBoxStyle.Critical)
                Me.btnCancelSI.Focus()
                Exit Sub
            End If

            Dim frm As New frm_SalesInvoicesMarkingAsCancelled
            frm._si_id = Me.dgvSalesInvoice.CurrentRow.Cells("si_id").Value
            frm.ShowDialog()
            Me.LoadData()

            'If MessageBox.Show("Do you really want to cancel Reference #:" & Me.dgvSalesInvoice.CurrentRow.Cells("reference_number").Value & "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            '    Me.si.si_id = Me.dgvSalesInvoice.CurrentRow.Cells("si_id").Value
            '    Me.si.details.updated_by = mod_Login.LoginLastName & ", " & mod_Login.LoginFirstName & " " & mod_Login.LoginMiddleName
            '    check = Me.si.CancelSalesInvoice

            '    If check = True Then
            '        MsgBox("Sales invoiced cancelled.", MsgBoxStyle.Information)
            '        Me.LoadData()
            '    Else
            '        MsgBox("Cancellation failed.", MsgBoxStyle.Critical)
            '    End If
            'End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EnableFields()
        Me.btnEdit.Enabled = True
        Me.btnDelete.Enabled = True
        Me.btnCancelSI.Enabled = True
        Me.btnMarkAsCollected.Enabled = True
        Me.btnReceivedByClient.Enabled = True
    End Sub

    Private Sub DisableFields()
        Me.btnEdit.Enabled = False
        Me.btnDelete.Enabled = False
        Me.btnCancelSI.Enabled = False
        Me.btnMarkAsCollected.Enabled = False
        Me.btnReceivedByClient.Enabled = False
    End Sub

    Private Sub btnMarkAsCollected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkAsCollected.Click
        Try

            If Me.dgvSalesInvoice.CurrentRow.Cells("si_status").Value <> "Received" Then
                MsgBox("Only RECEIVED in status can be mark as collected.", MsgBoxStyle.Critical)
                Me.btnMarkAsCollected.Focus()
                Exit Sub
            End If

            Dim frm As New frm_SalesInvoicesMarkingAsCollected
            frm._si_id = Me.dgvSalesInvoice.CurrentRow.Cells("si_id").Value
            frm.Showdialog()
            Me.LoadData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnReceivedByClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceivedByClient.Click
        Try
            If Me.dgvSalesInvoice.CurrentRow.Cells("si_status").Value <> "Open" Then
                MsgBox("Only OPEN in status can be mark as received.", MsgBoxStyle.Critical)
                Me.btnMarkAsCollected.Focus()
                Exit Sub
            End If

            Dim frm As New frm_SalesInvoicesMarkingAsReceived
            frm._si_id = Me.dgvSalesInvoice.CurrentRow.Cells("si_id").Value
            frm.ShowDialog()
            Me.LoadData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rbReceived_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbReceived.CheckedChanged
        Try
            Me._status = "Received"
            Me.LoadData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class