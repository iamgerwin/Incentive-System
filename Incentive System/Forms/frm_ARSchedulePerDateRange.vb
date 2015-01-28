Public Class frm_ARSchedulePerDateRange

    Dim si As New cls_SalesInvoice
    Dim start_column As Integer = 3

    Private Sub LoadData()
        Try
            Dim ds As New DataSet
            Dim days As Integer = 0
            Dim total_ar_amount As Decimal = 0
            Dim days_lapsed As Integer = 0

            Me.dgvAR.Rows.Clear()

            ds = Me.si.SearchSalesInvoiceByDateRange(Me.dtpDateFrom.Text, Me.dtpDateTo.Text)

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
                    Me.dgvAR.Rows(i).Cells("remarks").Value = .Item("remarks")
                    Me.dgvAR.Rows(i).Cells("invoice_date").Value = .Item("invoice_date")
                    Me.dgvAR.Rows(i).Cells("receiving_date").Value = .Item("receiving_date")
                    Me.dgvAR.Rows(i).Cells("due_date").Value = .Item("due_date")

                    days_lapsed = DateDiff(DateInterval.Day, CDate(.Item("due_date")), CDate(Now.Date))

                    If days_lapsed > 0 Then
                        Me.dgvAR.Rows(i).Cells("days_lapsed").Value = days_lapsed
                    Else
                        Me.dgvAR.Rows(i).Cells("days_lapsed").Value = Nothing
                    End If


                    Me.dgvAR.Rows(i).Cells("billing_amount").Value = .Item("billing_amount")
                    Me.dgvAR.Rows(i).Cells("vat_percentage").Value = .Item("vat")
                    Me.dgvAR.Rows(i).Cells("vat_amount").Value = .Item("vat_amount")
                    Me.dgvAR.Rows(i).Cells("billing_amount_with_vat").Value = .Item("billing_amount_with_vat")
                    Me.dgvAR.Rows(i).Cells("ewt").Value = .Item("ewt")
                    Me.dgvAR.Rows(i).Cells("ewt_amount").Value = .Item("ewt_amount")
                    Me.dgvAR.Rows(i).Cells("ar_amount").Value = .Item("ar_amount")
                    total_ar_amount += .Item("ar_amount")
                End With
            Next

            Me.dgvAR.Rows.Add()
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("client_name").Value = "TOTAL:"
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("client_name").Style.Font = New Font(Me.dgvAR.Font, FontStyle.Bold)
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("ar_amount").Value = total_ar_amount
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("ar_amount").Style.Font = New Font(Me.dgvAR.Font, FontStyle.Bold)
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("client_name").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("reference_number").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("remarks").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("receiving_date").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("invoice_date").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("due_date").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("days_lapsed").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("billing_amount").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("vat_percentage").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("vat_amount").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("billing_amount_with_vat").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("ewt").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("ewt_amount").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("ar_amount").Style.BackColor = Color.SkyBlue

            Me.btnExport.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Try
            Me.LoadData()
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

                    If (colIndex = 2 Or colIndex = 4) And rowIndex <> Me.dgvAR.Rows.Count Then
                        excel.Cells(rowIndex + 7, colIndex) = CDate(dr(dc.ColumnName))
                    Else
                        excel.Cells(rowIndex + 7, colIndex) = dr(dc.ColumnName)
                    End If


                    If colIndex = 3 Then
                        excel.Cells(rowIndex + 7, colIndex) = "'" & dr(dc.ColumnName)
                    Else
                        excel.Cells(rowIndex + 7, colIndex) = dr(dc.ColumnName)
                    End If

                    excel.Cells(rowIndex + 7, colIndex).Borders.Weight = 2

                    If colIndex > 4 Then
                        excel.Cells(rowIndex + 7, colIndex).numberformat = "_(#,##0.00_);_((#,##0.00);_("" - ""??_);_(@_)"
                    End If

                Next
            Next

            'Details
            excel.Cells(1, 1) = "Customer Touchpoint Resources, Inc."
            'excel.Range(excel.Cells(1, 1), excel.Cells(1, colIndex)).Merge()
            excel.Range(excel.Cells(1, 1), excel.Cells(1, colIndex)).HorizontalAlignment = HorizontalAlignment.Center
            excel.Cells(2, 1) = "6th Floor, Admiralty Bldg. 1101 Madrigal Business Park Alabang – Zapote Rd., Muntinlupa City"
            excel.Cells(4, 1) = "A/R SCHEDULE PER DATE RANGE"
            excel.Cells(5, 1) = "DATE COVERED:" & Me.dtpDateFrom.Text & "-" & Me.dtpDateTo.Text


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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frm_SalesInvoices
        frm.ShowDialog()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class