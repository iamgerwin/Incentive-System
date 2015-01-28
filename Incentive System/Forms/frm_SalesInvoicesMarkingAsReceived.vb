Public Class frm_SalesInvoicesMarkingAsReceived

    Dim si As New cls_SalesInvoice
    Dim _terms_days As Integer = 0
    Public _si_id As Integer = 0

    Private Sub LoadData()
        Try
            Dim ds As New DataSet

            Me.txtClient.Text = ""
            Me.txtReferenceNumber.Text = Nothing
            Me.txtTermsDays.Text = Nothing
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
                    Me.txtTermsDays.Text = .Item("terms_days")
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
                    Me._terms_days = .Item("terms_days")
                End With
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frm_SalesInvoicesMarkingAsReceived_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.LoadData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnMarkAsReceived_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkAsReceived.Click
        Try
            Dim check As Boolean = False

            If Me.txtClient.Text = Nothing Then
                MsgBox("Client is required", MsgBoxStyle.Critical)
                Me.btnMarkAsReceived.Focus()
                Exit Sub
            End If


            If Me.txtReferenceNumber.Text = Nothing Then
                MsgBox("Reference number is required", MsgBoxStyle.Critical)
                Me.btnMarkAsReceived.Focus()
                Exit Sub
            End If

            If Me.txtStatus.Text <> "Open" Then
                MsgBox("Status should be OPEN.", MsgBoxStyle.Critical)
                Me.btnMarkAsReceived.Focus()
                Exit Sub
            End If

            If Me.txtNetARAmount.Text = Nothing Or Me.txtNetARAmount.Text = "0.00" Then
                MsgBox("Net A/R amount should not be equal to 0 or nothing.", MsgBoxStyle.Critical)
                Me.btnMarkAsReceived.Focus()
                Exit Sub
            End If

            If MessageBox.Show("Do you really want to save this information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then


                Me.si.si_id = Me._si_id
                Me.si.receiving_date = Me.dtpReceivedDate.Text
                Me.si.due_date = Me.dtpReceivedDate.Value.AddDays(Me._terms_days)
                Me.si.details.updated_by = mod_Login.LoginLastName & ", " & mod_Login.LoginFirstName & " " & mod_Login.LoginMiddleName
                check = Me.si.MarkSalesInvoiceAsReceived

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