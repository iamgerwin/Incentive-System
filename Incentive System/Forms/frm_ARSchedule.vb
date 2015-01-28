Public Class frm_ARSchedule

    Dim si As New cls_SalesInvoice
    Dim start_column As Integer = 5

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

    Private Sub NewColumn(ByVal header_text As String, ByVal column_name As String)
        Try

            Dim col As New DataGridViewTextBoxColumn
            col.HeaderText = header_text
            col.Name = column_name
            col.ReadOnly = True
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Me.dgvAR.Columns.Add(col)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddColumnstoGrid()
        Try
            Dim days As Integer = 30

            Me.dgvAR.Columns.Clear()

            Me.NewColumn("Client", "client_name")
            Me.NewColumn("SI/SOA #", "reference_number")
            Me.dgvAR.Columns("reference_number").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.NewColumn("Invoice Date", "invoice_date")
            Me.NewColumn("Particulars", "particulars")
            Me.NewColumn("Period", "period")


            For i As Integer = 0 To days
                Me.NewColumn(Format(Me.dtpDate.Value.AddDays(i), "d"), Format(Me.dtpDate.Text, "yyyyMMdd"))
            Next

            Me.NewColumn("> 30 days", "greater_than_30_days")
            Me.NewColumn("No Due Date", "no_due_date")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoadData()
        Try
            Dim ds As New DataSet
            Dim days As Integer = 0
            Dim total_ar_amount As Decimal = 0

            Me.dgvAR.Rows.Clear()

            ds = Me.si.SearchSalesInvoiceByDate(Me.dtpDate.Text)

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
                    Me.dgvAR.Rows(i).Cells("invoice_date").Value = Format(.Item("invoice_date"), "d")
                    Me.dgvAR.Rows(i).Cells("particulars").Value = .Item("particulars")
                    Me.dgvAR.Rows(i).Cells("period").Value = .Item("cut_off_from") & "-" & .Item("cut_off_to")

                    If .Item("si_status") = "Open" Then
                        Me.dgvAR.Rows(i).Cells("no_due_date").Value = Format(.Item("ar_amount"), "Standard")
                        Me.dgvAR.Rows(i).Cells("no_due_date").Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    Else

                        days = DateDiff(DateInterval.Day, CDate(Me.dtpDate.Text), CDate(.Item("due_date")))

                        If days > 30 Then
                            Me.dgvAR.Rows(i).Cells("greater_than_30_days").Value = Format(.Item("ar_amount"), "Standard")
                            Me.dgvAR.Rows(i).Cells("greater_than_30_days").Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        Else
                            Me.dgvAR.Rows(i).Cells(days + Me.start_column).Value = Format(.Item("ar_amount"), "Standard")
                            Me.dgvAR.Rows(i).Cells(days + Me.start_column).Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        End If
                    End If
                End With
            Next

            Me.dgvAR.Rows.Add()
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("client_name").Value = "TOTAL:"
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("client_name").Style.Font = New Font(Me.dgvAR.Font, FontStyle.Bold)
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("client_name").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("reference_number").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("invoice_date").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("particulars").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("period").Style.BackColor = Color.SkyBlue

            Me.btnExport.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComputeTotalAR()
        Try
            Dim total_ar_amount As Decimal = 0

            'compute total ar amount for 30 days less
            For i As Integer = 5 To 35
                'For i As Integer = 3 To 33

                total_ar_amount = 0

                For j As Integer = 0 To Me.dgvAR.Rows.Count - 1
                    With Me.dgvAR.Rows(j)
                        total_ar_amount += .Cells(i).Value
                    End With
                Next

                Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells(i).Value = Format(total_ar_amount, "Standard")
                Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells(i).Style.BackColor = Color.SkyBlue
                Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells(i).Style.Font = New Font(Me.dgvAR.Font, FontStyle.Bold)
                Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells(i).Style.Alignment = DataGridViewContentAlignment.MiddleRight
            Next

            'compute total ar amount for greater than 30 days column
            total_ar_amount = 0

            For i As Integer = 0 To Me.dgvAR.Rows.Count - 1
                With Me.dgvAR.Rows(i)
                    total_ar_amount += .Cells("greater_than_30_days").Value
                End With
            Next

            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("greater_than_30_days").Value = Format(total_ar_amount, "Standard")
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("greater_than_30_days").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("greater_than_30_days").Style.Font = New Font(Me.dgvAR.Font, FontStyle.Bold)
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("greater_than_30_days").Style.Alignment = DataGridViewContentAlignment.MiddleRight


            'compute total ar amount for no due date
            total_ar_amount = 0

            For i As Integer = 0 To Me.dgvAR.Rows.Count - 1
                With Me.dgvAR.Rows(i)
                    total_ar_amount += .Cells("no_due_date").Value
                End With
            Next

            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("no_due_date").Value = Format(total_ar_amount, "Standard")
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("no_due_date").Style.BackColor = Color.SkyBlue
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("no_due_date").Style.Font = New Font(Me.dgvAR.Font, FontStyle.Bold)
            Me.dgvAR.Rows(Me.dgvAR.Rows.Count - 1).Cells("no_due_date").Style.Alignment = DataGridViewContentAlignment.MiddleRight

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub frm_ARSchedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.dtpDate.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Try

            If Me.VerifyIfThereAreRecords = True Then
                Me.AddColumnstoGrid()
                Me.LoadData()
                Me.ComputeTotalAR()
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