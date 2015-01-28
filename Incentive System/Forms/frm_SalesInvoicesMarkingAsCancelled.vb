Public Class frm_SalesInvoicesMarkingAsCancelled

    Dim si As New cls_SalesInvoice
    Public _si_id As Integer = 0

    Private Sub LoadData()
        Try
            Dim ds As New DataSet

            Me.txtClient.Text = ""
            Me.txtReferenceNumber.Text = Nothing
            Me.dtpInvoiceDate.Value = Now.Date
            Me.txtBillingAmount.Text = "0.00"
            Me.txtVAT.Text = "12"
            Me.txtBillingAmountWithVAT.Text = "0.00"
            Me.txtEWT.Text = "0.00"
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
                    'Me.rtbParticulars.Text = .Item("particulars")
                    Me.txtBillingAmount.Text = Format(.Item("billing_amount"), "Standard")
                    Me.txtVAT.Text = .Item("vat")
                    Me.txtBillingAmountWithVAT.Text = Format(.Item("billing_amount_with_vat"), "Standard")
                    Me.txtEWT.Text = .Item("ewt")
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

    Private Sub frm_SalesInvoicesMarkingAsCancelled_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.LoadData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnMarkAsCancelled_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkAsCancelled.Click

        Try
            Dim check As Boolean = False

            If Me.txtClient.Text = Nothing Then
                MsgBox("Client is required", MsgBoxStyle.Critical)
                Me.btnMarkAsCancelled.Focus()
                Exit Sub
            End If


            If Me.txtReferenceNumber.Text = Nothing Then
                MsgBox("Reference number is required", MsgBoxStyle.Critical)
                Me.btnMarkAsCancelled.Focus()
                Exit Sub
            End If

            If Me.txtStatus.Text = "Collected" Or Me.txtStatus.Text = "Cancelled" Then
                MsgBox("Status should not be COLLECTED/CANCELLED.", MsgBoxStyle.Critical)
                Me.btnMarkAsCancelled.Focus()
                Exit Sub
            End If

            If Me.txtNetARAmount.Text = Nothing Or Me.txtNetARAmount.Text = "0.00" Then
                MsgBox("Net A/R amount should not be equal to 0 or nothing.", MsgBoxStyle.Critical)
                Me.btnMarkAsCancelled.Focus()
                Exit Sub
            End If

            If MessageBox.Show("Do you really want to save this information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                Me.si.si_id = Me._si_id
                Me.si.details.updated_by = mod_Login.LoginLastName & ", " & mod_Login.LoginFirstName & " " & mod_Login.LoginMiddleName
                check = Me.si.CancelSalesInvoice

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
End Class