Public Class frm_SalesInvoicesMarkingAsCollected

    Dim si As New cls_SalesInvoice
    Public _si_id As Integer = 0

    Private Sub LoadData()
        Try
            Dim ds As New DataSet

            Me.txtClient.Text = ""
            Me.txtReferenceNumber.Text = Nothing
            Me.dtpInvoiceDate.Value = Now.Date
            Me.dtpDueDate.Value = Now.Date
            Me.txtBillingAmount.Text = "0.00"
            Me.txtVAT.Text = "12"
            Me.txtVatAmount.Text = "0.00"
            Me.txtBillingAmountWithVAT.Text = "0.00"
            Me.txtEWT.Text = "0.00"
            Me.txtEWTAmount.Text = "0.00"
            Me.txtNetARAmount.Text = "0.00"
            Me.dtpCutOffFrom.Value = Now.Date
            Me.dtpCutOffTo.Value = Now.Date
            Me.txtRemarks.Text = Nothing

            Me.si.si_id = Me._si_id
            ds = Me.si.SearchSalesInvoiceBySIId

            For i As Integer = 0 To ds.Tables("vw_BillingSalesInvoices").Rows.Count - 1
                With ds.Tables("vw_BillingSalesInvoices").Rows(i)
                    Me.txtClient.Text = .Item("client_name")

                    If .Item("is_sales_invoice") = 1 Then
                        'Me._is_sales_invoice = 1
                        Me.lblReferenceNumber.Text = "S.I #:"
                        Me.lblReferenceNumber.Location = New System.Drawing.Point(59, 60)
                    Else
                        'Me._is_sales_invoice = 0
                        Me.lblReferenceNumber.Text = "SOA #:"
                        Me.lblReferenceNumber.Location = New System.Drawing.Point(49, 60)
                    End If

                    Me.txtReferenceNumber.Text = .Item("reference_number")
                    Me.dtpInvoiceDate.Value = .Item("invoice_date")
                    Me.dtpDueDate.Value = .Item("due_date")
                    'Me.rtbParticulars.Text = .Item("particulars")
                    Me.txtBillingAmount.Text = Format(.Item("billing_amount"), "Standard")
                    Me.txtVAT.Text = .Item("vat")
                    Me.txtVatAmount.Text = .Item("vat_amount")
                    Me.txtBillingAmountWithVAT.Text = Format(.Item("billing_amount_with_vat"), "Standard")
                    Me.txtEWT.Text = .Item("ewt")
                    Me.txtEWTAmount.Text = .Item("ewt_amount")
                    Me.txtNetARAmount.Text = Format(.Item("ar_amount"), "Standard")
                    Me.dtpCutOffFrom.Value = IIf(IsDBNull(.Item("cut_off_from")) = True, "1900-01-01", .Item("cut_off_from"))
                    Me.dtpCutOffTo.Value = IIf(IsDBNull(.Item("cut_off_to")) = True, "1900-01-01", .Item("cut_off_to"))
                    Me.txtRemarks.Text = .Item("remarks")
                    Me.txtStatus.Text = .Item("si_status")

                End With
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frm_SalesInvoicesMarkingAsCollected_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.LoadData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnMarkAsCollected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkAsCollected.Click
        Try
            Dim check As Boolean = False

            If Me.txtClient.Text = Nothing Then
                MsgBox("Client is required", MsgBoxStyle.Critical)
                Me.btnMarkAsCollected.Focus()
                Exit Sub
            End If


            If Me.txtReferenceNumber.Text = Nothing Then
                MsgBox("Reference number is required", MsgBoxStyle.Critical)
                Me.btnMarkAsCollected.Focus()
                Exit Sub
            End If

            If Me.txtStatus.Text <> "Received" Then
                MsgBox("Status should be RECEIVED.", MsgBoxStyle.Critical)
                Me.btnMarkAsCollected.Focus()
                Exit Sub
            End If

            If Me.txtNetARAmount.Text = Nothing Or Me.txtNetARAmount.Text = "0.00" Then
                MsgBox("Net A/R amount should not be equal to 0 or nothing.", MsgBoxStyle.Critical)
                Me.btnMarkAsCollected.Focus()
                Exit Sub
            End If

            If Me.txtORNumber.Text = Nothing Then
                MsgBox("O.R. # is required.", MsgBoxStyle.Critical)
                Me.txtORNumber.Focus()
                Exit Sub
            End If

            If Me.txtCheckNumber.Text = Nothing Then
                MsgBox("Check # is required.", MsgBoxStyle.Critical)
                Me.txtCheckNumber.Focus()
                Exit Sub
            End If

            If Me.txtBank.Text = Nothing Then
                MsgBox("Bank is required.", MsgBoxStyle.Critical)
                Me.txtBank.Focus()
                Exit Sub
            End If

            If Me.txtAmountReceived.Text = "0.00" Or Me.txtAmountReceived.Text = Nothing Or Me.txtAmountReceived.Text = "0" Then
                MsgBox("Invalid amount received value.", MsgBoxStyle.Critical)
                Me.txtAmountReceived.Focus()
                Exit Sub
            End If

            If MessageBox.Show("Do you really want to save this information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                Me.si.si_id = Me._si_id
                Me.si.collection_date = Me.dtpCollectionDate.Text
                Me.si.or_date = Me.dtpORDate.Text
                Me.si.or_number = Trim(Me.txtORNumber.Text)
                Me.si.check_number = Trim(Me.txtCheckNumber.Text)
                Me.si.bank_name = Trim(StrConv(Me.txtBank.Text, VbStrConv.Uppercase))
                Me.si.amount_received = CDec(Me.txtAmountReceived.Text)
                Me.si.details.updated_by = mod_Login.LoginLastName & ", " & mod_Login.LoginFirstName & " " & mod_Login.LoginMiddleName
                check = Me.si.MarkSalesInvoiceAsCollected

                If check = True Then
                    MsgBox("Record saved.", MsgBoxStyle.Information)
                    Me.Close()
                Else
                    MsgBox("Transaction failed.", MsgBoxStyle.Critical)
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtAmountReceived_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmountReceived.Click
        Me.txtAmountReceived.SelectAll()
        Me.txtAmountReceived.Focus()
    End Sub

    Private Sub txtAmountReceived_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmountReceived.Enter
        Me.txtAmountReceived.SelectAll()
        Me.txtAmountReceived.Focus()
    End Sub

    Private Sub txtAmountReceived_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmountReceived.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAmountReceived_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmountReceived.Leave
        Me.txtAmountReceived.Text = Format(Me.txtAmountReceived.Text, "Standard")
    End Sub

    Private Sub txtAmountReceived_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmountReceived.TextChanged
        Try
            If Me.txtAmountReceived.Text = Nothing Then
                Me.txtAmountReceived.Text = "0.00"
                Me.txtAmountReceived.SelectAll()
                Me.txtAmountReceived.Focus()
                Exit Sub
            End If

            If Me.txtAmountReceived.Text = 0 Then
                Me.txtAmountReceived.Text = "0.00"
                Me.txtAmountReceived.SelectAll()
                Me.txtAmountReceived.Focus()
            End If
        Catch ex As Exception
            Me.txtAmountReceived.Text = "0.00"
            Me.txtAmountReceived.SelectAll()
            Me.txtAmountReceived.Focus()
        End Try
    End Sub
End Class