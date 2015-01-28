Public Class frm_ARScheduleAging

    Dim si As New cls_SalesInvoice
    Dim billingamount As Decimal = 0
    Dim vatamount As Decimal = 0
    Dim aramount As Decimal = 0
    Dim currentamt As Decimal = 0
    Dim onetothirtydays As Decimal = 0
    Dim thirtyonetosixtydays As Decimal = 0
    Dim sixtyonetoninetydays As Decimal = 0
    Dim ninetyonetoonetwentydays As Decimal = 0
    Dim onetwentyoneupdays As Decimal = 0

    Private Function VerifyIfThereAreRecords()
        Try
            Dim check As Boolean = False
            Dim ds As New DataSet

            ds = Me.si.SearchSalesInvoiceByDate(Me.dtpDate.Text)

            If ds.Tables("vw_BillingSalesInvoices").Rows.Count = 0 Then
                check = False
            Else
                check = True
            End If

            Return check

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub LoadData()
        Try
            Dim aging As Integer = 0
            Dim ds As New DataSet
            Dim days As Integer = 0
            Dim total_ar_amount As Decimal = 0

            Me.dgvAR.Rows.Clear()

            ds = Me.si.SearchSalesInvoiceByDateAging(Me.dtpDate.Text)

            If ds.Tables("vw_BillingSalesInvoices").Rows.Count = 0 Then
                MsgBox("No records found.", MsgBoxStyle.Critical)
                Me.btnExport.Enabled = False
                Exit Sub
            End If


            For i As Integer = 0 To ds.Tables("vw_BillingSalesInvoices").Rows.Count - 1
                With ds.Tables("vw_BillingSalesInvoices").Rows(i)
                    Me.dgvAR.Rows.Add()
                    Me.dgvAR.Rows(i).Cells("client_name").Value = .Item("client_name")
                    Me.dgvAR.Rows(i).Cells("reference_number").Value = .Item("reference_number")
                    Me.dgvAR.Rows(i).Cells("particulars").Value = .Item("particulars")
                    Me.dgvAR.Rows(i).Cells("period").Value = .Item("cut_off_from") & "-" & .Item("cut_off_to")
                    Me.billingamount += .Item("billing_amount")
                    Me.dgvAR.Rows(i).Cells("billing_amount").Value = .Item("billing_amount")
                    Me.vatamount += .Item("vat_amount")
                    Me.dgvAR.Rows(i).Cells("vat_amount").Value = .Item("vat_amount")
                    Me.aramount += .Item("ar_amount")
                    Me.dgvAR.Rows(i).Cells("ar_amount").Value = .Item("ar_amount")



                    'Me.dgvAR.Rows(i).Cells("invoice_date").Value = Format(.Item("invoice_date"), "d")



                    If .Item("si_status") = "Open" Then
                        Me.dgvAR.Rows(i).Cells("no_due_date").Value = Format(.Item("ar_amount"), "Standard")
                        Me.currentamt += .Item("ar_amount")
                        Me.dgvAR.Rows(i).Cells("no_due_date").Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    Else
                        Me.dgvAR.Rows(i).Cells("due_date").Value = Format(.Item("due_date"), "d")

                        aging = DateDiff(DateInterval.Day, CDate(.Item("due_date")), CDate(Me.dtpDate.Text))

                        If aging < 0 Then
                            Me.dgvAR.Rows(i).Cells("aging").Value = ""
                        Else
                            Me.dgvAR.Rows(i).Cells("aging").Value = DateDiff(DateInterval.Day, CDate(.Item("due_date")), CDate(Me.dtpDate.Text))
                        End If

                        'Me.dgvAR.Rows(i).Cells("aging").Value = DateDiff(DateInterval.Day, CDate(.Item("due_date")), CDate(Me.dtpDate.Text))

                        days = DateDiff(DateInterval.Day, CDate(Me.dtpDate.Text), CDate(.Item("due_date")))

                        If days <= 30 Then
                            Me.dgvAR.Rows(i).Cells("onetothirty_days").Value = Format(.Item("ar_amount"), "Standard")
                            Me.onetothirtydays += .Item("ar_amount")
                            Me.dgvAR.Rows(i).Cells("onetothirty_days").Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        ElseIf days > 30 And days <= 60 Then
                            Me.dgvAR.Rows(i).Cells("thirtyonetosixty_days").Value = Format(.Item("ar_amount"), "Standard")
                            Me.thirtyonetosixtydays += .Item("ar_amount")
                            Me.dgvAR.Rows(i).Cells("thirtyonetosixty_days").Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        ElseIf days > 60 And days <= 90 Then
                            Me.dgvAR.Rows(i).Cells("sixtyonetoninety_days").Value = Format(.Item("ar_amount"), "Standard")
                            Me.sixtyonetoninetydays += .Item("ar_amount")
                            Me.dgvAR.Rows(i).Cells("sixtyonetoninety_days").Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        ElseIf days > 90 And days <= 120 Then
                            Me.dgvAR.Rows(i).Cells("ninetyonetoonetwenty_days").Value = Format(.Item("ar_amount"), "Standard")
                            Me.ninetyonetoonetwentydays += .Item("ar_amount")
                            Me.dgvAR.Rows(i).Cells("ninetyonetoonetwenty_days").Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        Else
                            Me.dgvAR.Rows(i).Cells("onetwentyoneup_days").Value = Format(.Item("ar_amount"), "Standard")
                            onetwentyoneupdays += .Item("ar_amount")
                            Me.dgvAR.Rows(i).Cells("onetwentyoneup_days").Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        End If

                    End If
                End With
            Next

            Me.dgvAR.Rows.Add()
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("client_name").Value = "TOTAL:"
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("client_name").Style.Font = New Font(Me.dgvAR.Font, FontStyle.Bold)
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("client_name").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("reference_number").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("particulars").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("period").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("billing_amount").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("ar_amount").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("vat_amount").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("no_due_date").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("due_date").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("aging").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("onetothirty_days").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("thirtyonetosixty_days").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("sixtyonetoninety_days").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("ninetyonetoonetwenty_days").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("onetwentyoneup_days").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("billing_amount").Value = Me.billingamount
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("vat_amount").Value = Me.vatamount
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("ar_amount").Value = Me.aramount
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("no_due_date").Value = Me.currentamt
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("onetothirty_days").Value = Me.onetothirtydays
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("thirtyonetosixty_days").Value = Me.thirtyonetosixtydays
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("sixtyonetoninety_days").Value = Me.sixtyonetoninetydays
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("ninetyonetoonetwenty_days").Value = Me.ninetyonetoonetwentydays
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("onetwentyoneup_days").Value = Me.onetwentyoneupdays

            Me.btnExport.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub frm_ARScheduleAging_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.dtpDate.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Try

            If Me.VerifyIfThereAreRecords = True Then
                Me.LoadData()
                'Me.ComputeTotalAR()
            Else
                MsgBox("No records found.", MsgBoxStyle.Critical)
                Me.dtpDate.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Try

            If Me.dgvAR.Rows.Count = 0 Then
                MsgBox("No records to export.", MsgBoxStyle.Critical)
                Me.btnLoad.Focus()
                Exit Sub
            End If


            'Creating dataset to export
            Dim dset As New DataSet
            'add table to dataset
            dset.Tables.Add()
            'add column to that table
            '15 count
            For i As Integer = 0 To dgvAR.ColumnCount - 1
                If Me.dgvAR.Columns(i).Visible = True Then
                    dset.Tables(0).Columns.Add(dgvAR.Columns(i).HeaderText)
                End If
            Next

            'add rows to the table
            Dim dr1 As DataRow
            For i As Integer = 0 To dgvAR.RowCount - 1
                dr1 = dset.Tables(0).NewRow
                For j As Integer = 0 To dgvAR.Columns.Count - 1
                    If Me.dgvAR.Columns(j).Visible = True Then
                        dr1(Me.dgvAR.Columns(j).HeaderText) = dgvAR.Rows(i).Cells(j).Value
                    End If
                Next
                dset.Tables(0).Rows.Add(dr1)
            Next

            Dim excel As New Microsoft.Office.Interop.Excel.ApplicationClass
            Dim wBook As Microsoft.Office.Interop.Excel.Workbook
            Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

            wBook = excel.Workbooks.Add()
            wSheet = wBook.ActiveSheet()

            Dim dt As System.Data.DataTable = dset.Tables(0)
            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            For Each dc In dt.Columns
                colIndex = colIndex + 1
                excel.Cells(7, colIndex) = dc.ColumnName
                excel.Cells(7, colIndex).borders.weight = 2
                excel.Cells(7, colIndex).interior.color = System.Drawing.ColorTranslator.ToOle(Color.LightGray)

            Next

            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns


                    colIndex = colIndex + 1

                    If colIndex = 2 Then
                        excel.Cells(rowIndex + 7, colIndex) = "'" & dr(dc.ColumnName)
                    Else
                        excel.Cells(rowIndex + 7, colIndex) = dr(dc.ColumnName)
                    End If

                    excel.Cells(rowIndex + 7, colIndex).Borders.Weight = 2

                    If colIndex > 3 Then
                        excel.Cells(rowIndex + 7, colIndex).numberformat = "_(#,##0.00_);_((#,##0.00);_("" - ""??_);_(@_)"
                    End If

                Next
            Next

            'Details
            excel.Cells(1, 1) = "Customer Touchpoint Resources, Inc."
            'excel.Range(excel.Cells(1, 1), excel.Cells(1, colIndex)).Merge()
            excel.Range(excel.Cells(1, 1), excel.Cells(1, colIndex)).HorizontalAlignment = HorizontalAlignment.Center
            excel.Cells(2, 1) = "6th Floor, Admiralty Bldg. 1101 Madrigal Business Park Alabang – Zapote Rd., Muntinlupa City"
            excel.Cells(4, 1) = "A/R SCHEDULE"
            excel.Cells(5, 1) = "RUN DATE:" & Me.dtpDate.Text


            Dim SaveString As String
            SaveFileDialog1.DefaultExt = "xlsx"
            SaveFileDialog1.Filter = "Excel|*.xlsx|Excel 97-2003|*.xls|All Files|*.*"

            If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                SaveString = Me.SaveFileDialog1.FileName
            Else
                'wBook.Close()
                excel.Quit()
                Exit Sub
            End If

            Dim strFileName As String = SaveString
            Dim blnFileOpen As Boolean = False
            Try
                Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
                fileTemp.Close()
            Catch ex As Exception
                blnFileOpen = False
            End Try

            If System.IO.File.Exists(strFileName) Then
                System.IO.File.Delete(strFileName)
            End If

            wBook.SaveAs(strFileName)
            excel.Workbooks.Open(strFileName)
            excel.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class