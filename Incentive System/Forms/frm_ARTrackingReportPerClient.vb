Public Class frm_ARTrackingReportPerClient

    Dim rpt As New cls_Reports
    Dim si As New cls_SalesInvoice
    Dim arr_client_code As New ArrayList
    Dim arr_client_name As New ArrayList
    Dim arr_total_ar_amount_per_client As New ArrayList
    Dim arr_total_amount_paid As New ArrayList
    Dim totalaramount As Decimal = 0
    Dim totalamountpaid As Decimal = 0
    Dim grandtotalaramount As Decimal = 0
    Dim grandtotalamountpaid As Decimal = 0

    Private Sub LoadData2()
        Try
            Dim ds As New DataSet
            Dim dsclient As New DataSet
            Dim sheetcount As Integer = 1
            Dim cellname As String = Nothing
            Dim xlApp As Microsoft.Office.Interop.Excel.ApplicationClass = Nothing
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook = Nothing
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet = Nothing
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim fname As String = Nothing
            'Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
            Dim initialrow As Integer = 8
            Dim lastcolumn As Integer = 0
            Dim lastrow As Integer = 8


            If Me.cmbSIStatus.Text = Nothing Then
                MsgBox("Status is required.", MsgBoxStyle.Critical)
                Me.cmbSIStatus.Focus()
                Exit Sub
            End If


            Me.arr_client_name.Clear()
            Me.arr_client_code.Clear()
            Me.arr_total_ar_amount_per_client.Clear()
            Me.arr_total_amount_paid.Clear()

            xlApp = New Microsoft.Office.Interop.Excel.ApplicationClass
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("Sheet1")


            'get client_name and client_code
            Me.si.si_status = Me.cmbSIStatus.Text
            dsclient = Me.si.SearchSalesInvoicesByClientName(Me.dtpFromDate.Text, Me.dtpToDate.Text)

            If dsclient.Tables("vw_BillingSalesInvoices").Rows.Count = 0 Then
                MsgBox("No records found.", MsgBoxStyle.Critical)
                Me.dtpFromDate.Focus()
                Exit Sub
            End If

            'populate array of client code and array of client name
            For i As Integer = 0 To dsclient.Tables("vw_BillingSalesInvoices").Rows.Count - 1
                With dsclient.Tables("vw_BillingSalesInvoices").Rows(i)
                    Me.arr_client_code.Add(.Item("client_code"))
                    Me.arr_client_name.Add(.Item("client_name"))
                End With
            Next


          
            'biggest loop. search for invoices per client
            For x As Integer = 0 To Me.arr_client_code.Count - 1

                ds.Clear()


                If sheetcount > 3 Then
                    xlWorkSheet = xlWorkBook.Sheets.Add(After:=xlWorkBook.Worksheets(sheetcount - 1))
                    'xlWorkBook.Sheets.Move("sheet" & sheetcount - 1, "sheet" & sheetcount)
                    xlWorkSheet = xlWorkBook.Sheets("Sheet" & sheetcount)
                    xlWorkBook.Worksheets("Sheet" & sheetcount).Select()
                    cellname = Me.arr_client_name(x).ToString.Substring(0, 3)
                    cellname = Strings.Replace(cellname, "/", ".")
                    cellname = Strings.Replace(cellname, "(", ".")
                    cellname = Strings.Replace(cellname, ")", ".")
                    cellname = Strings.Replace(cellname, "-", ".")
                    xlWorkSheet.Name = cellname
                Else
                    xlWorkSheet = xlWorkBook.Sheets("Sheet" & sheetcount)
                    xlWorkBook.Worksheets("Sheet" & sheetcount).Select()
                    cellname = Me.arr_client_name(x).ToString.Substring(0, 3)
                    cellname = Strings.Replace(cellname, "/", ".")
                    cellname = Strings.Replace(cellname, "(", ".")
                    cellname = Strings.Replace(cellname, ")", ".")
                    cellname = Strings.Replace(cellname, "-", ".")
                    xlWorkSheet.Name = cellname
                End If


                'page header
                xlApp.Cells(1, 1) = "Customer Touchpoint Resources, Inc."
                'excel.Range(excel.Cells(1, 1), excel.Cells(1, colIndex)).Merge()
                'xlApp.Range(xlApp.Cells(1, 1), xlApp.Cells(1, colIndex)).HorizontalAlignment = HorizontalAlignment.Center
                xlApp.Cells(2, 1) = "6th Floor, Admiralty Bldg. 1101 Madrigal Business Park Alabang – Zapote Rd., Muntinlupa City"
                xlApp.Cells(3, 1) = "ACCOUNT NAME:" & Me.arr_client_name(x)
                xlApp.Cells(4, 1) = "A/R TRACKING REPORT"
                xlApp.Cells(5, 1) = "DATE:" & Me.dtpFromDate.Text & "-" & Me.dtpToDate.Text

                'report column header
                xlWorkSheet.Cells(7, 1) = "INVOICE NUMBER"
                xlWorkSheet.Cells(7, 2) = "INVOICE DATE"
                xlWorkSheet.Cells(7, 3) = "RECEIVING DATE"
                xlWorkSheet.Cells(7, 4) = "PARTICULARS"
                xlWorkSheet.Cells(7, 5) = "AMOUNT"
                xlWorkSheet.Cells(7, 6) = "VAT"
                xlWorkSheet.Cells(7, 7) = "TOTAL GROSS AMOUNT"
                xlWorkSheet.Cells(7, 8) = "EWT"
                xlWorkSheet.Cells(7, 9) = "TOTAL NET AMOUNT"
                xlWorkSheet.Cells(7, 10) = "CREDIT TERMS"
                xlWorkSheet.Cells(7, 11) = "DUE DATE FOR COLLECTION"
                xlWorkSheet.Cells(7, 12) = "DAYS PAST DUE"
                xlWorkSheet.Cells(7, 13) = "OR DATE"
                xlWorkSheet.Cells(7, 14) = "OR NUMBER"
                xlWorkSheet.Cells(7, 15) = "AMOUNT"
                xlWorkSheet.Cells(7, 16) = "VARIANCE"

                Me.totalaramount = 0
                Me.totalamountpaid = 0

                ds = Me.rpt.rptARTrackingReport(Me.arr_client_code(x), Me.cmbSIStatus.Text, Me.dtpFromDate.Text, Me.dtpToDate.Text)

                For j As Integer = 0 To ds.Tables("vw_BillingSalesInvoices").Rows.Count - 1
                    With ds.Tables("vw_BillingSalesInvoices").Rows(j)
                        'Me.dgvSalesInvoices.Rows.Add()
                        xlWorkSheet.Cells(initialrow + j, 1) = .Item("reference_number")
                        xlWorkSheet.Cells(initialrow + j, 2) = .Item("invoice_date")
                        xlWorkSheet.Cells(initialrow + j, 3) = .Item("receiving_date")
                        xlWorkSheet.Cells(initialrow + j, 4) = .Item("particulars")
                        xlWorkSheet.Cells(initialrow + j, 5) = .Item("billing_amount")
                        xlApp.Cells(initialrow + j, 5).numberformat = "_(#,##0.00_);_((#,##0.00);_("" - ""??_);_(@_)"
                        xlWorkSheet.Cells(initialrow + j, 6) = .Item("vat_amount")
                        xlApp.Cells(initialrow + j, 6).numberformat = "_(#,##0.00_);_((#,##0.00);_("" - ""??_);_(@_)"
                        xlWorkSheet.Cells(initialrow + j, 7) = .Item("billing_amount_with_vat")
                        xlApp.Cells(initialrow + j, 7).numberformat = "_(#,##0.00_);_((#,##0.00);_("" - ""??_);_(@_)"
                        xlWorkSheet.Cells(initialrow + j, 8) = .Item("ewt_amount")
                        xlApp.Cells(initialrow + j, 8).numberformat = "_(#,##0.00_);_((#,##0.00);_("" - ""??_);_(@_)"
                        xlWorkSheet.Cells(initialrow + j, 9) = .Item("ar_amount")
                        xlApp.Cells(initialrow + j, 9).numberformat = "_(#,##0.00_);_((#,##0.00);_("" - ""??_);_(@_)"
                        Me.totalaramount += .Item("ar_amount")
                        Me.grandtotalaramount += .Item("ar_amount")
                        xlWorkSheet.Cells(initialrow + j, 10) = .Item("terms_days")
                        xlWorkSheet.Cells(initialrow + j, 11) = IIf(IsDBNull(.Item("due_date")) = True, Nothing, .Item("due_date"))

                        If .Item("si_status") = "Open" Then
                            xlWorkSheet.Cells(initialrow + j, 12) = Nothing
                        Else
                            xlWorkSheet.Cells(initialrow + j, 12) = DateDiff(DateInterval.Day, CDate(.Item("due_date")), CDate(Now.Date))
                        End If


                        xlWorkSheet.Cells(initialrow + j, 13) = .Item("or_date")
                        xlWorkSheet.Cells(initialrow + j, 14) = .Item("or_number")
                        xlWorkSheet.Cells(initialrow + j, 15) = .Item("amount_received")
                        xlApp.Cells(initialrow + j, 15).numberformat = "_(#,##0.00_);_((#,##0.00);_("" - ""??_);_(@_)"
                        Me.totalamountpaid += IIf(IsDBNull(.Item("amount_received")) = True, 0, .Item("amount_received"))
                        Me.grandtotalamountpaid += IIf(IsDBNull(.Item("amount_received")) = True, 0, .Item("amount_received"))
                        xlWorkSheet.Cells(initialrow + j, 16) = CDec(.Item("ar_amount")) - CDec(IIf(IsDBNull(.Item("amount_received")) = True, 0, .Item("amount_received")))
                        xlApp.Cells(initialrow + j, 16).numberformat = "_(#,##0.00_);_((#,##0.00);_("" - ""??_);_(@_)"
                    End With
                Next


                sheetcount += 1
                Me.arr_total_ar_amount_per_client.Add(Me.totalaramount)
                Me.arr_total_amount_paid.Add(Me.totalamountpaid)

            Next

            'add summary sheet
            xlWorkSheet = xlWorkBook.Sheets.Add(Before:=xlWorkBook.Worksheets(1))
            xlWorkSheet.Name = "SUMMARY"



            'page header summary
            xlApp.Cells(1, 1) = "Customer Touchpoint Resources, Inc."
            'excel.Range(excel.Cells(1, 1), excel.Cells(1, colIndex)).Merge()
            'xlApp.Range(xlApp.Cells(1, 1), xlApp.Cells(1, colIndex)).HorizontalAlignment = HorizontalAlignment.Center
            xlApp.Cells(2, 1) = "6th Floor, Admiralty Bldg. 1101 Madrigal Business Park Alabang – Zapote Rd., Muntinlupa City"
            xlApp.Cells(3, 1) = "A/R TRACKING REPORT SUMMARY"
            xlApp.Cells(4, 1) = "DATE:" & Me.dtpFromDate.Text & "-" & Me.dtpToDate.Text


            'report column header summary
            xlWorkSheet.Cells(6, 1) = "CLIENT"
            xlWorkSheet.Cells(6, 2) = "AR AMOUNT"
            xlWorkSheet.Cells(6, 3) = "AMOUNT PAID"

            For ctr As Integer = 0 To Me.arr_client_name.Count - 1
                xlWorkSheet.Cells(7 + ctr, 1) = Me.arr_client_name(ctr)
                xlWorkSheet.Cells(7 + ctr, 2) = Me.arr_total_ar_amount_per_client(ctr)
                xlApp.Cells(7 + ctr, 2).numberformat = "_(#,##0.00_);_((#,##0.00);_("" - ""??_);_(@_)"
                xlWorkSheet.Cells(7 + ctr, 3) = Me.arr_total_amount_paid(ctr)
                xlApp.Cells(7 + 7 + ctr, 3).numberformat = "_(#,##0.00_);_((#,##0.00);_("" - ""??_);_(@_)"
            Next

            xlWorkSheet.Cells(7 + Me.arr_client_name.Count, 1) = "TOTAL:"
            xlWorkSheet.Cells(7 + Me.arr_client_name.Count, 2) = Me.grandtotalaramount
            xlApp.Cells(7 + Me.arr_client_name.Count, 2).numberformat = "_(#,##0.00_);_((#,##0.00);_("" - ""??_);_(@_)"
            xlWorkSheet.Cells(7 + Me.arr_client_name.Count, 3) = Me.grandtotalamountpaid
            xlApp.Cells(7 + Me.arr_client_name.Count, 3).numberformat = "_(#,##0.00_);_((#,##0.00);_("" - ""??_);_(@_)"

            Dim SaveString As String
            SaveFileDialog1.DefaultExt = "xlsx"
            SaveFileDialog1.Filter = "Excel|*.xlsx|Excel 97-2003|*.xls|All Files|*.*"

            If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                SaveString = Me.SaveFileDialog1.FileName
            Else
                'wBook.Close()
                xlApp.Quit()
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

            xlWorkBook.SaveAs(strFileName)
            xlApp.Workbooks.Open(strFileName)
            xlApp.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GC.Collect()
            GC.WaitForPendingFinalizers()

        End Try
    End Sub

    'Private Sub LoadData()
    '    Try
    '        Dim ds As New DataSet
    '        Dim sheetcount As Integer = 1
    '        Dim cellname As String = Nothing
    '        Dim excel As New Microsoft.Office.Interop.Excel.ApplicationClass
    '        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
    '        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

    '        Me.dgvSalesInvoices.Rows.Clear()
    '        Me.arr_client_name.Clear()

    '        ds = Me.rpt.rptARTrackingReport(Me.cmbSIStatus.Text, Me.dtpFromDate.Text, Me.dtpToDate.Text)

    '        If ds.Tables("vw_BillingSalesInvoices").Rows.Count = 0 Then
    '            MsgBox("No records found.", MsgBoxStyle.Critical)
    '            Me.dtpFromDate.Focus()
    '            Exit Sub
    '        End If

    '        For i As Integer = 0 To ds.Tables("vw_BillingSalesInvoices").Rows.Count - 1
    '            With ds.Tables("vw_BillingSalesInvoices").Rows(i)
    '                Me.dgvSalesInvoices.Rows.Add()

    '                'create array of clients

    '                If i = 0 Then
    '                    Me.arr_client_name.Add(.Item("client_name"))
    '                Else
    '                    For j As Integer = 0 To Me.arr_client_name.Count - 1
    '                        If Me.arr_client_name(j) = .Item("client_name") Then
    '                            Exit For
    '                        End If

    '                        If j = Me.arr_client_name.Count - 1 Then
    '                            Me.arr_client_name.Add(.Item("client_name"))
    '                        End If
    '                    Next
    '                End If



    '                Me.dgvSalesInvoices.Rows(i).Cells("client_name").Value = .Item("client_name")
    '                Me.dgvSalesInvoices.Rows(i).Cells("reference_number").Value = .Item("reference_number")
    '                Me.dgvSalesInvoices.Rows(i).Cells("invoice_date").Value = .Item("invoice_date")
    '                Me.dgvSalesInvoices.Rows(i).Cells("receiving_date").Value = .Item("receiving_date")
    '                Me.dgvSalesInvoices.Rows(i).Cells("particulars").Value = .Item("particulars")
    '                Me.dgvSalesInvoices.Rows(i).Cells("billing_amount").Value = .Item("billing_amount")
    '                Me.dgvSalesInvoices.Rows(i).Cells("vat_amount").Value = .Item("vat_amount")
    '                Me.dgvSalesInvoices.Rows(i).Cells("billing_amount_with_vat").Value = .Item("billing_amount_with_vat")
    '                Me.dgvSalesInvoices.Rows(i).Cells("ewt_amount").Value = .Item("ewt_amount")
    '                Me.dgvSalesInvoices.Rows(i).Cells("ar_amount").Value = .Item("ar_amount")
    '                Me.dgvSalesInvoices.Rows(i).Cells("terms_days").Value = .Item("terms_days")
    '                Me.dgvSalesInvoices.Rows(i).Cells("due_date").Value = IIf(IsDBNull(.Item("due_date")) = True, Nothing, .Item("due_date"))

    '                If .Item("si_status") = "Open" Then
    '                    Me.dgvSalesInvoices.Rows(i).Cells("aging").Value = Nothing
    '                Else
    '                    Me.dgvSalesInvoices.Rows(i).Cells("aging").Value = DateDiff(DateInterval.Day, CDate(.Item("due_date")), CDate(Now.Date))
    '                End If


    '                Me.dgvSalesInvoices.Rows(i).Cells("or_date").Value = .Item("or_date")
    '                Me.dgvSalesInvoices.Rows(i).Cells("or_number").Value = .Item("or_number")
    '                Me.dgvSalesInvoices.Rows(i).Cells("amount_received").Value = .Item("amount_received")
    '                Me.dgvSalesInvoices.Rows(i).Cells("variance").Value = CDec(.Item("ar_amount")) - CDec(IIf(IsDBNull(.Item("amount_received")) = True, 0, .Item("amount_received")))
    '            End With
    '        Next


    '        wBook = excel.Workbooks.Add()
    '        'wSheet = wBook.ActiveSheet()
    '        wSheet = wBook.Sheets.Add()


    '        For ctr As Integer = 0 To Me.arr_client_name.Count - 1


    '            'Creating dataset to export
    '            Dim dset As New DataSet
    '            'add table to dataset
    '            dset.Tables.Add()
    '            'add column to that table
    '            '15 count
    '            For i As Integer = 0 To dgvSalesInvoices.ColumnCount - 1
    '                If Me.dgvSalesInvoices.Columns(i).Visible = True Then
    '                    dset.Tables(0).Columns.Add(dgvSalesInvoices.Columns(i).HeaderText)
    '                End If
    '            Next

    '            'add rows to the table
    '            Dim dr1 As DataRow
    '            For i As Integer = 0 To dgvSalesInvoices.RowCount - 1
    '                dr1 = dset.Tables(0).NewRow
    '                For j As Integer = 0 To dgvSalesInvoices.Columns.Count - 1
    '                    If Me.dgvSalesInvoices.Columns(j).Visible = True Then
    '                        If Me.arr_client_name(ctr) = dgvSalesInvoices.Rows(i).Cells(0).Value Then
    '                            dr1(Me.dgvSalesInvoices.Columns(j).HeaderText) = dgvSalesInvoices.Rows(i).Cells(j).Value
    '                        End If
    '                    End If
    '                Next
    '                dset.Tables(0).Rows.Add(dr1)
    '            Next



    '            If sheetcount > 3 Then
    '                wSheet = wBook.Sheets.Add()
    '                'xlWorkBook.Sheets.Move("sheet" & sheetcount - 1, "sheet" & sheetcount)
    '                wSheet = wBook.Sheets("Sheet" & sheetcount)
    '                cellname = ctr
    '                'cellname = Strings.Replace(cellname, "/", ".")
    '                'cellname = Strings.Replace(cellname, "(", ".")
    '                'cellname = Strings.Replace(cellname, ")", ".")
    '                wSheet.Name = cellname
    '            Else
    '                wSheet = wBook.Sheets("Sheet" & sheetcount)
    '                cellname = ctr
    '                'cellname = Strings.Replace(cellname, "/", ".")
    '                'cellname = Strings.Replace(cellname, "(", ".")
    '                'cellname = Strings.Replace(cellname, ")", ".")
    '                wSheet.Name = cellname
    '            End If



    '            Dim dt As System.Data.DataTable = dset.Tables(0)
    '            Dim dc As System.Data.DataColumn
    '            Dim dr As System.Data.DataRow
    '            Dim colIndex As Integer = 0
    '            Dim rowIndex As Integer = 0

    '            For Each dc In dt.Columns
    '                colIndex = colIndex + 1
    '                excel.Cells(7, colIndex) = dc.ColumnName
    '                excel.Cells(7, colIndex).borders.weight = 2
    '                excel.Cells(7, colIndex).interior.color = System.Drawing.ColorTranslator.ToOle(Color.LightGray)

    '            Next

    '            For Each dr In dt.Rows
    '                rowIndex = rowIndex + 1
    '                colIndex = 0
    '                For Each dc In dt.Columns


    '                    colIndex = colIndex + 1

    '                    If colIndex = 2 Then
    '                        excel.Cells(rowIndex + 7, colIndex) = "'" & dr(dc.ColumnName)
    '                    Else
    '                        excel.Cells(rowIndex + 7, colIndex) = dr(dc.ColumnName)
    '                    End If

    '                    excel.Cells(rowIndex + 7, colIndex).Borders.Weight = 2

    '                    If colIndex > 3 Then
    '                        excel.Cells(rowIndex + 7, colIndex).numberformat = "_(#,##0.00_);_((#,##0.00);_("" - ""??_);_(@_)"
    '                    End If

    '                Next
    '            Next

    '            'Details
    '            excel.Cells(1, 1) = "Customer Touchpoint Resources, Inc."
    '            'excel.Range(excel.Cells(1, 1), excel.Cells(1, colIndex)).Merge()
    '            excel.Range(excel.Cells(1, 1), excel.Cells(1, colIndex)).HorizontalAlignment = HorizontalAlignment.Center
    '            excel.Cells(2, 1) = "6th Floor, Admiralty Bldg. 1101 Madrigal Business Park Alabang – Zapote Rd., Muntinlupa City"
    '            excel.Cells(4, 1) = "A/R TRACKING REPORT"
    '            excel.Cells(5, 1) = "DATE:" & Me.dtpFromDate.Text & "-" & Me.dtpToDate.Text

    '            sheetcount += 1
    '        Next

    '        Dim SaveString As String
    '        SaveFileDialog1.DefaultExt = "xlsx"
    '        SaveFileDialog1.Filter = "Excel|*.xlsx|Excel 97-2003|*.xls|All Files|*.*"

    '        If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            SaveString = Me.SaveFileDialog1.FileName
    '        Else
    '            'wBook.Close()
    '            excel.Quit()
    '            Exit Sub
    '        End If

    '        Dim strFileName As String = SaveString
    '        Dim blnFileOpen As Boolean = False
    '        Try
    '            Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
    '            fileTemp.Close()
    '        Catch ex As Exception
    '            blnFileOpen = False
    '        End Try

    '        If System.IO.File.Exists(strFileName) Then
    '            System.IO.File.Delete(strFileName)
    '        End If

    '        wBook.SaveAs(strFileName)
    '        excel.Workbooks.Open(strFileName)
    '        excel.Visible = True


    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        GC.Collect()
    '        GC.WaitForPendingFinalizers()
    '    End Try
    'End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Try

            Me.LoadData2()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class