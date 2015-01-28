Public Class frm_UpdateSalesInvoices

    Dim si As New cls_SalesInvoice
    Dim cl As New cls_Clients
    Dim arr_client_code As New ArrayList
    Dim arr_is_vatable As New ArrayList
    Dim arr_ewt As New ArrayList
    Dim arr_terms_days As New ArrayList
    Dim arr_is_flexible_vat As New ArrayList
    Dim _is_sales_invoice As Integer = 0
    Dim _status As String = Nothing
    Public _si_id As Integer = 0

    Private Sub PopulateClientCombobox()
        Try
            Dim ds As New DataSet

            Me.cmbClient.Text = Nothing
            Me.cmbClient.Items.Clear()
            Me.arr_client_code.Clear()
            Me.arr_is_vatable.Clear()
            Me.arr_ewt.Clear()
            Me.arr_terms_days.Clear()

            ds = Me.cl.SearchClient(Nothing)

            For i As Integer = 0 To ds.Tables("tbl_Client").Rows.Count - 1
                With ds.Tables("tbl_Client").Rows(i)
                    Me.arr_client_code.Add(.Item("client_code"))
                    Me.arr_is_vatable.Add(.Item("is_vatable"))
                    Me.arr_ewt.Add(.Item("ewt"))
                    Me.arr_terms_days.Add(.Item("terms_days"))
                    Me.arr_is_flexible_vat.Add(.Item("is_flexible_vat"))
                    Me.cmbClient.Items.Add(.Item("client_name"))
                End With
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Compute()
        Try

            'computation for vatable client(sales invoice)
            If Me.rbSalesInvoice.Checked = True Then

                If Me.txtBillingAmount.Text = "0.00" Then
                    Me.txtBillingAmountWithVAT.Text = "0.00"
                    Me.txtNetARAmount.Text = "0.00"
                    Exit Sub
                End If

                Me.txtVatAmount.Text = Format((CDec(Me.txtVAT.Text / 100) * CDec(Me.txtBillingAmount.Text)), "Standard")
                Me.txtBillingAmountWithVAT.Text = Format(CDec(Me.txtBillingAmount.Text) + ((Me.txtBillingAmount.Text) * (CDec(Me.txtVAT.Text) / 100)), "Standard")
                Me.txtEWTAmount.Text = Format(CDec(Me.txtBillingAmount.Text) * (CDec(Me.txtEWT.Text) / 100), "Standard")
                Me.txtNetARAmount.Text = Format(CDec(Me.txtBillingAmountWithVAT.Text) - ((CDec(Me.txtEWT.Text) / 100) * CDec(Me.txtBillingAmount.Text)), "Standard")
            Else
                'computation for non vat client soa
                Me.txtNetARAmount.Text = Format(CDec(Me.txtBillingAmount.Text), "Standard")
            End If


            ''computation for vatable client(sales invoice)
            'If Me.arr_is_vatable.Item(Me.cmbClient.SelectedIndex) = 1 Then

            '    If Me.txtBillingAmount.Text = "0.00" Then
            '        Me.txtBillingAmountWithVAT.Text = "0.00"
            '        Me.txtNetARAmount.Text = "0.00"
            '        Exit Sub
            '    End If

            '    Me.txtVatAmount.Text = Format((CDec(Me.txtVAT.Text / 100) * CDec(Me.txtBillingAmount.Text)), "Standard")
            '    Me.txtBillingAmountWithVAT.Text = Format(CDec(Me.txtBillingAmount.Text) + ((Me.txtBillingAmount.Text) * (CDec(Me.txtVAT.Text) / 100)), "Standard")
            '    Me.txtEWTAmount.Text = Format(CDec(Me.txtBillingAmount.Text) * (CDec(Me.txtEWT.Text) / 100), "Standard")
            '    Me.txtNetARAmount.Text = Format(CDec(Me.txtBillingAmountWithVAT.Text) - ((CDec(Me.txtEWT.Text) / 100) * CDec(Me.txtBillingAmount.Text)), "Standard")
            'Else
            '    'computation for non vat client soa
            '    Me.txtNetARAmount.Text = Format(CDec(Me.txtBillingAmount.Text), "Standard")
            'End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadData()
        Try
            Dim ds As New DataSet

            Me.cmbClient.Text = ""
            Me.txtReferenceNumber.Text = Nothing
            Me.dtpInvoiceDate.Value = Now.Date
            Me.rtbParticulars.Text = Nothing
            Me.txtBillingAmount.Text = "0.00"
            Me.txtVAT.Text = "12"
            Me.txtVatAmount.text = "0.00"
            Me.txtBillingAmountWithVAT.Text = "0.00"
            Me.txtEWT.Text = "0.00"
            Me.txtEWTAmount.text = "0.00"
            Me.txtNetARAmount.Text = "0.00"
            Me.dtpCutOffFrom.Value = Now.Date
            Me.dtpCutOffTo.Value = Now.Date
            Me.txtRemarks.Text = Nothing
            Me.rbSalesInvoice.Checked = False
            Me.rbSOA.Checked = False

            Me.si.si_id = Me._si_id
            ds = Me.si.SearchSalesInvoiceBySIId

            For i As Integer = 0 To ds.Tables("vw_BillingSalesInvoices").Rows.Count - 1
                With ds.Tables("vw_BillingSalesInvoices").Rows(i)
                    Me.cmbClient.SelectedItem = .Item("client_name")

                    'check if client has flexible vat
                    If .Item("is_flexible_vat") = 1 Then
                        Me.rbSalesInvoice.Enabled = True
                        Me.rbSOA.Enabled = True
                    Else
                        Me.rbSalesInvoice.Enabled = False
                        Me.rbSOA.Enabled = False
                    End If

                    'set si/soa depending on client profile
                    If .Item("is_sales_invoice") = 1 Then
                        Me._is_sales_invoice = 1
                        Me.lblReferenceNumber.Text = "S.I #:"
                        Me.lblReferenceNumber.Location = New System.Drawing.Point(61, 52)
                        Me.rbSalesInvoice.Checked = True
                    Else
                        Me._is_sales_invoice = 0
                        Me.lblReferenceNumber.Text = "SOA #:"
                        Me.lblReferenceNumber.Location = New System.Drawing.Point(51, 52)
                        Me.rbSOA.Checked = True
                    End If

                    Me.txtReferenceNumber.Text = .Item("reference_number")
                    Me.txtTermsDays.Text = .Item("terms_days")
                    Me.dtpInvoiceDate.Value = .Item("invoice_date")
                    Me.rtbParticulars.Text = .Item("particulars")
                    Me.txtBillingAmount.Text = Format(.Item("billing_amount"), "Standard")
                    Me.txtVAT.Text = Format(.Item("vat"), "Standard")
                    Me.txtVatAmount.Text = Format(.Item("vat_amount"), "Standard")
                    Me.txtBillingAmountWithVAT.Text = Format(.Item("billing_amount_with_vat"), "Standard")
                    Me.txtEWT.Text = Format(.Item("ewt"), "Standard")
                    Me.txtEWTAmount.Text = Format(.Item("ewt_amount"), "Standard")
                    Me.txtNetARAmount.Text = Format(.Item("ar_amount"), "Standard")
                    Me.dtpCutOffFrom.Value = IIf(IsDBNull(.Item("cut_off_from")) = True, "1900-01-01", .Item("cut_off_from"))
                    Me.dtpCutOffTo.Value = IIf(IsDBNull(.Item("cut_off_to")) = True, "1900-01-01", .Item("cut_off_to"))
                    Me.txtRemarks.Text = .Item("remarks")
                    Me._status = .Item("si_status")

                End With
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frm_UpdateSalesInvoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.PopulateClientCombobox()
            Me.LoadData()
            Me.cmbClient.Focus()

            If Me._status = "Open" Then
                Me.EnableFields()
            Else
                Me.DisableFields()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtBillingAmount_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBillingAmount.Click
        Me.txtBillingAmount.SelectAll()
        Me.txtBillingAmount.Focus()
    End Sub

    Private Sub txtBillingAmount_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBillingAmount.Enter
        Me.txtBillingAmount.SelectAll()
        Me.txtBillingAmount.Focus()
    End Sub

    Private Sub txtBillingAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBillingAmount.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtVAT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVAT.Click
        Me.txtVAT.SelectAll()
        Me.txtVAT.Focus()
    End Sub

    Private Sub txtVAT_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVAT.Enter
        Me.txtVAT.SelectAll()
        Me.txtVAT.Focus()
    End Sub

    Private Sub txtVAT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVAT.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEWT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEWT.Click
        Me.txtEWT.SelectAll()
        Me.txtEWT.Focus()
    End Sub

    Private Sub txtEWT_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEWT.Enter
        Me.txtEWT.SelectAll()
        Me.txtEWT.Focus()
    End Sub

    Private Sub txtEWT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEWT.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBillingAmount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBillingAmount.Leave
        Me.txtBillingAmount.Text = Format(Me.txtBillingAmount.Text, "Standard")
    End Sub

    Private Sub txtBillingAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBillingAmount.TextChanged
        Try
            If Me.txtBillingAmount.Text = Nothing Then
                Me.txtBillingAmount.Text = "0.00"
                Me.txtBillingAmount.SelectAll()
                Me.txtBillingAmount.Focus()
                Exit Sub
            End If

            If Me.txtBillingAmount.Text = 0 Then
                Me.txtBillingAmount.Text = "0.00"
                Me.txtBillingAmount.SelectAll()
                Me.txtBillingAmount.Focus()
            End If


            Me.Compute()

        Catch ex As Exception
            Me.txtBillingAmount.Text = "0.00"
            Me.txtBillingAmount.SelectAll()
            Me.txtBillingAmount.Focus()
        End Try
    End Sub

    Private Sub txtVAT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVAT.TextChanged
        Try
            If Me.txtVAT.Text = Nothing Or Me.txtVAT.Text = 0 Then
                Me.txtVAT.Text = "0.00"
                Me.txtVAT.SelectAll()
                Me.txtVAT.Focus()
            End If

            Me.Compute()

        Catch ex As Exception
            Me.txtVAT.Text = "0.00"
            Me.txtVAT.SelectAll()
            Me.txtVAT.Focus()
        End Try
    End Sub

    Private Sub txtEWT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEWT.TextChanged
        Try
            If Me.txtEWT.Text = Nothing Or Me.txtEWT.Text = 0 Then
                Me.txtEWT.Text = "0.00"
                Me.txtEWT.SelectAll()
                Me.txtEWT.Focus()
            End If

            Me.Compute()

        Catch ex As Exception
            Me.txtEWT.Text = "0.00"
            Me.txtEWT.SelectAll()
            Me.txtEWT.Focus()
        End Try
    End Sub

    Private Sub cmbClient_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbClient.SelectedIndexChanged
        Try

            'check if client has flexible vat

            Try
                If Me.arr_is_flexible_vat.Item(Me.cmbClient.SelectedIndex) = 1 Then
                    Me.rbSalesInvoice.Enabled = True
                    Me.rbSOA.Enabled = True
                    Me.rbSalesInvoice.Checked = True
                    Exit Sub
                Else
                    Me.rbSalesInvoice.Enabled = False
                    Me.rbSOA.Enabled = False
                End If

            Catch ex As Exception

            End Try


            'if not flexible check client vat
            If Me.arr_is_vatable.Item(Me.cmbClient.SelectedIndex) = 1 Then
                Me.lblReferenceNumber.Text = "S.I #:"
                Me.lblReferenceNumber.Location = New System.Drawing.Point(61, 52)
                Me.txtEWT.Text = CDec(Me.arr_ewt.Item(Me.cmbClient.SelectedIndex))
                Me.txtVAT.Text = "12"
                'Me.txtVAT.Enabled = True
                'Me.txtEWT.Enabled = True
                Me._is_sales_invoice = 1
                Me.rbSalesInvoice.Checked = True
            Else
                Me.lblReferenceNumber.Text = "SOA #:"
                Me.lblReferenceNumber.Location = New System.Drawing.Point(51, 52)
                Me.txtVAT.Text = "0.00"
                Me.txtEWT.Text = "0.00"
                Me.txtBillingAmountWithVAT.Text = "0.00"
                'Me.txtVAT.Enabled = False
                Me.txtBillingAmountWithVAT.Enabled = False
                Me.txtEWT.Enabled = False
                Me.txtBillingAmount.SelectAll()
                Me.txtBillingAmount.Focus()
                Me._is_sales_invoice = 0
                Me.rbSOA.Checked = True
            End If

            Me.txtTermsDays.Text = Me.arr_terms_days.Item(Me.cmbClient.SelectedIndex)
            Me.txtBillingAmount.Text = "0.00"
            Me.txtVatAmount.Text = "0.00"
            Me.txtEWTAmount.Text = "0.00"
            Me.txtReferenceNumber.Focus()

            'If Me.arr_is_vatable.Item(Me.cmbClient.SelectedIndex) = 1 Then
            '    Me.lblReferenceNumber.Text = "S.I #:"
            '    Me.lblReferenceNumber.Location = New System.Drawing.Point(61, 52)
            '    Me.txtEWT.Text = CDec(Me.arr_ewt.Item(Me.cmbClient.SelectedIndex))
            '    Me.txtVAT.Text = "12"
            '    'Me.txtVAT.Enabled = True
            '    'Me.txtEWT.Enabled = True
            '    Me._is_sales_invoice = 1
            'Else
            '    Me.lblReferenceNumber.Text = "SOA #:"
            '    Me.lblReferenceNumber.Location = New System.Drawing.Point(51, 52)
            '    Me.txtVAT.Text = "0.00"
            '    Me.txtEWT.Text = "0.00"
            '    Me.txtBillingAmountWithVAT.Text = "0.00"
            '    'Me.txtVAT.Enabled = False
            '    Me.txtBillingAmountWithVAT.Enabled = False
            '    Me.txtEWT.Enabled = False
            '    Me.txtBillingAmount.SelectAll()
            '    Me.txtBillingAmount.Focus()
            '    Me._is_sales_invoice = 0
            'End If

            'Me.txtTermsDays.Text = Me.arr_terms_days.Item(Me.cmbClient.SelectedIndex)
            'Me.txtBillingAmount.Text = "0.00"
            'Me.txtVatAmount.Text = "0.00"
            'Me.txtEWTAmount.Text = "0.00"
            'Me.txtReferenceNumber.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Dim check As Boolean = False

            If Me.cmbClient.Text = Nothing Then
                MsgBox("Client is required.", MsgBoxStyle.Critical)
                Me.cmbClient.Focus()
                Exit Sub
            End If

            If Me.txtReferenceNumber.Text = Nothing Then
                MsgBox("Reference number.", MsgBoxStyle.Critical)
                Me.txtReferenceNumber.Focus()
                Exit Sub
            End If

            If Me.rtbParticulars.Text = Nothing Then
                MsgBox("Particulars is required.", MsgBoxStyle.Critical)
                Me.rtbParticulars.Focus()
                Exit Sub
            End If

            If Me.txtNetARAmount.Text = "0.00" Or Me.txtNetARAmount.Text = Nothing Then
                MsgBox("Net A/R is required.", MsgBoxStyle.Critical)
                Me.txtBillingAmount.Focus()
                Exit Sub
            End If

            If MessageBox.Show("Do you really want to save this information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                Me.si.si_id = Me._si_id
                Me.si.client.client_code = Me.arr_client_code.Item(Me.cmbClient.SelectedIndex)
                Me.si.is_sales_invoice = Me._is_sales_invoice
                Me.si.reference_number = Trim(Me.txtReferenceNumber.Text)
                Me.si.invoice_date = Me.dtpInvoiceDate.Text
                Me.si.particulars = Trim(Me.rtbParticulars.Text)
                Me.si.billing_amount = CDec(Me.txtBillingAmount.Text)
                Me.si.vat = CDec(Me.txtVAT.Text)
                Me.si.vat_amount = CDec(Me.txtVatAmount.Text)
                Me.si.billing_amount_with_vat = CDec(Me.txtBillingAmountWithVAT.Text)
                Me.si.ewt = CDec(Me.txtEWT.Text)
                Me.si.ewt_amount = CDec(Me.txtEWTAmount.Text)
                Me.si.ar_amount = CDec(Me.txtNetARAmount.Text)
                Me.si.cut_off_from = Me.dtpCutOffFrom.Text
                Me.si.cut_off_to = Me.dtpCutOffTo.Text
                Me.si.remarks = Trim(Me.txtRemarks.Text)
                Me.si.details.updated_by = mod_Login.LoginLastName & ", " & mod_Login.LoginFirstName & " " & mod_Login.LoginMiddleName
                check = Me.si.UpdateSalesInvoice

                If check = True Then
                    MsgBox("Record saved.", MsgBoxStyle.Information)
                    Me.Close()
                Else
                    MsgBox("Record already exist.", MsgBoxStyle.Critical)
                    Me.txtReferenceNumber.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EnableFields()
        Me.cmbClient.Enabled = True
        Me.txtReferenceNumber.Enabled = True
        Me.dtpInvoiceDate.Enabled = True
        Me.rtbParticulars.ReadOnly = False
        Me.txtBillingAmount.Enabled = True
        Me.dtpCutOffFrom.Enabled = True
        Me.dtpCutOffTo.Enabled = True
        Me.txtRemarks.Enabled = True
        Me.btnSave.Enabled = True
    End Sub

    Private Sub DisableFields()
        Me.cmbClient.Enabled = False
        Me.txtReferenceNumber.Enabled = False
        Me.dtpInvoiceDate.Enabled = False
        Me.rtbParticulars.ReadOnly = True
        Me.txtBillingAmount.Enabled = False
        Me.dtpCutOffFrom.Enabled = False
        Me.dtpCutOffTo.Enabled = False
        Me.txtRemarks.Enabled = False
        Me.rbSalesInvoice.Enabled = False
        Me.rbSOA.Enabled = False
        Me.btnSave.Enabled = False
    End Sub

    Private Sub rbSalesInvoice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSalesInvoice.CheckedChanged
        If Me.rbSalesInvoice.Checked = True Then
            Me.SetIfSOAorSI()
        End If
    End Sub

    Private Sub rbSOA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSOA.CheckedChanged
        If Me.rbSOA.Checked = True Then
            Me.SetIfSOAorSI()
        End If
    End Sub

    Private Sub SetIfSOAorSI()
        Try
            If Me.rbSalesInvoice.Checked = True Then
                Me.lblReferenceNumber.Text = "S.I #:"
                Me.lblReferenceNumber.Location = New System.Drawing.Point(61, 52)
                Me.txtEWT.Text = CDec(Me.arr_ewt.Item(Me.cmbClient.SelectedIndex))
                Me.txtVAT.Text = "12"
                'Me.txtVAT.Enabled = True
                'Me.txtEWT.Enabled = True
                Me._is_sales_invoice = 1
            Else
                Me.lblReferenceNumber.Text = "SOA #:"
                Me.lblReferenceNumber.Location = New System.Drawing.Point(51, 52)
                Me.txtVAT.Text = "0.00"
                Me.txtEWT.Text = "0.00"
                Me.txtBillingAmountWithVAT.Text = "0.00"
                'Me.txtVAT.Enabled = False
                Me.txtBillingAmountWithVAT.Enabled = False
                Me.txtEWT.Enabled = False
                Me.txtBillingAmount.SelectAll()
                Me.txtBillingAmount.Focus()
                Me._is_sales_invoice = 0
            End If

            Me.txtTermsDays.Text = Me.arr_terms_days.Item(Me.cmbClient.SelectedIndex)
            Me.txtBillingAmount.Text = "0.00"
            Me.txtVatAmount.Text = "0.00"
            Me.txtEWTAmount.Text = "0.00"
            Me.txtReferenceNumber.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class