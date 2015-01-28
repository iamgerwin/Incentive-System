Public Class frm_CollectionORTrackingReport

    Dim rpt As New cls_Reports
    Dim dataseries As String = Nothing
    Dim delimiter As String = ","

    Private Sub CreateSeries(ByVal fromnum As Integer, ByVal tonum As Integer)
        Try
            Dim temprange As Integer = 0

            Me.dataseries = Nothing

            temprange = tonum - fromnum

            For i As Integer = 0 To temprange

                If i = temprange Then
                    dataseries &= fromnum + temprange
                Else
                    dataseries &= fromnum + i & ","
                End If

            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoadData()
        Try
            Dim ds As New DataSet

            Me.dgvOR.Rows.Clear()

            Me.CreateSeries(CInt(Me.txtSeriesFrom.Text), CInt(Me.txtSeriesTo.Text))

            ds = Me.rpt.rptCollectionORNumberTrackingBySeries(Me.dataseries, Me.delimiter)

            If ds.Tables("vw_BillingSalesInvoices").Rows.Count = 0 Then
                MsgBox("Records not found.", MsgBoxStyle.Critical)
                Me.txtSeriesFrom.Focus()
                Me.btnExport.Enabled = False
                Exit Sub
            End If

            For i As Integer = 0 To ds.Tables("vw_BillingSalesInvoices").Rows.Count - 1
                With ds.Tables("vw_BillingSalesInvoices").Rows(i)
                    Me.dgvOR.Rows.Add()
                    Me.dgvOR.Rows(i).Cells("or_number").Value = .Item("splitdata")
                    Me.dgvOR.Rows(i).Cells("or_date").Value = .Item("or_date")
                    Me.dgvOR.Rows(i).Cells("bank_name").Value = .Item("bank_name")
                    Me.dgvOR.Rows(i).Cells("check_number").Value = .Item("check_number")
                    Me.dgvOR.Rows(i).Cells("client_name").Value = .Item("client_name")
                    Me.dgvOR.Rows(i).Cells("particulars").Value = .Item("particulars")
                    Me.dgvOR.Rows(i).Cells("amount_received").Value = .Item("amount_received")
                End With
            Next

            Me.btnExport.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frm_CollectionORTrackingReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.txtSeriesFrom.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Try

            If Me.txtSeriesFrom.Text = Nothing Then
                MsgBox("From series is required.", MsgBoxStyle.Critical)
                Me.txtSeriesFrom.Focus()
                Exit Sub
            End If

            If Me.txtSeriesTo.Text = Nothing Then
                MsgBox("To series is required.", MsgBoxStyle.Critical)
                Me.txtSeriesTo.Focus()
                Exit Sub
            End If

            If CInt(Me.txtSeriesFrom.Text) > CInt(Me.txtSeriesTo.Text) Then
                MsgBox("Invalid series value. From should be less than To.", MsgBoxStyle.Critical)
                Me.txtSeriesFrom.Focus()
                Exit Sub
            End If

            Me.LoadData()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Try

            If Me.dgvOR.Rows.Count = 0 Then
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
            For i As Integer = 0 To dgvOR.ColumnCount - 1
                If Me.dgvOR.Columns(i).Visible = True Then
                    dset.Tables(0).Columns.Add(dgvOR.Columns(i).HeaderText)
                End If
            Next

            'add rows to the table
            Dim dr1 As DataRow
            For i As Integer = 0 To dgvOR.RowCount - 1
                dr1 = dset.Tables(0).NewRow
                For j As Integer = 0 To dgvOR.Columns.Count - 1
                    If Me.dgvOR.Columns(j).Visible = True Then
                        dr1(Me.dgvOR.Columns(j).HeaderText) = dgvOR.Rows(i).Cells(j).Value
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
            excel.Cells(4, 1) = "COLLECTION O.R. TRACKING REPORT"
            excel.Cells(5, 1) = "RUN DATE:" & Now.Date


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