Public Class frm_LiquidationReport
    Dim CL_Client As New cls_Clients
    Dim CL_Advances As New cls_Advances
    Dim CL_Disbursement As New cls_Disbursement
    Dim CL_SysPara As New cls_SystemParameters
    Dim CL_Bank As New cls_BankAdvice
    Dim Arr_Client As New ArrayList
    Public ReleaseDate As Date

    Private Sub CBOClientLoad()
        Try
            Dim DSClient As New DataSet
            DSClient = CL_Client.DisplayClients
            Me.Arr_Client.Clear()
            Me.cbo_Client.Items.Clear()

            Me.Arr_Client.Add("All")
            Me.cbo_Client.Items.Add("All")

            For ctr As Integer = 0 To DSClient.Tables("tbl_Client").Rows.Count - 1
                Me.cbo_Client.Items.Add(DSClient.Tables("tbl_Client").Rows(ctr).Item(1))
                Me.Arr_Client.Add(DSClient.Tables("tbl_Client").Rows(ctr).Item(0))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
       
        End Try
    End Sub

    Public Sub LoadDataGrid()
        Try
            Dim ds As New DataSet

            ds = CL_Advances.Search_Advances_By_Client_Code(Me.Arr_Client(Me.cbo_Client.SelectedIndex))

            Me.DataGridView1.Rows.Clear()
            Me.dgv_Employee.Rows.Clear()

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                With ds.Tables(0).Rows(i)
                    If Me.rdo_Open.Checked = True Then
                        If .Item("Liquidated") = 0 Then
                            Me.DataGridView1.Rows.Add()
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("Client").Value = .Item("client_name")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("ReferenceNumber").Value = .Item("ReferenceNumber")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("ChequeNumber").Value = .Item("ChequeNumber")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("ChequeAmount").Value = .Item("ChequeAmount")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("DisbursedAmount").Value = .Item("DisbursedAmount")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("Balance").Value = .Item("Balance")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("bank_name").Value = .Item("bank_name")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("bank_code").Value = .Item("bank_code")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("bank_manager").Value = .Item("bank_manager")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("bank_address").Value = .Item("bank_address")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("Liquidated").Value = .Item("Liquidated")
                        End If
                    ElseIf Me.rdo_Liquidated.Checked = True Then
                        If .Item("Liquidated") = 1 Then
                            Me.DataGridView1.Rows.Add()
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("Client").Value = .Item("client_name")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("ReferenceNumber").Value = .Item("ReferenceNumber")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("ChequeNumber").Value = .Item("ChequeNumber")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("ChequeAmount").Value = .Item("ChequeAmount")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("DisbursedAmount").Value = .Item("DisbursedAmount")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("Balance").Value = .Item("Balance")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("bank_name").Value = .Item("bank_name")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("bank_code").Value = .Item("bank_code")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("bank_manager").Value = .Item("bank_manager")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("bank_address").Value = .Item("bank_address")
                            Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("Liquidated").Value = .Item("Liquidated")
                        End If
                    ElseIf Me.rdo_All.Checked = True Then
                        Me.DataGridView1.Rows.Add()
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("Client").Value = .Item("client_name")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("ReferenceNumber").Value = .Item("ReferenceNumber")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("ChequeNumber").Value = .Item("ChequeNumber")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("ChequeAmount").Value = .Item("ChequeAmount")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("DisbursedAmount").Value = .Item("DisbursedAmount")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("Balance").Value = .Item("Balance")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("bank_name").Value = .Item("bank_name")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("bank_code").Value = .Item("bank_code")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("bank_manager").Value = .Item("bank_manager")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("bank_address").Value = .Item("bank_address")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("Liquidated").Value = .Item("Liquidated")
                    End If


                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadEmployees()
        If Me.DataGridView1.SelectedRows.Count > 0 Then
            Dim ds As New DataSet
            ds = CL_Disbursement.Search_Disbursement_By_ReferenceID(Me.DataGridView1.SelectedRows(0).Cells("ReferenceNumber").Value)

            Me.dgv_Employee.Rows.Clear()

            Try
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    With ds.Tables(0).Rows(i)
                        If Me.rdo_Disbursement_Open.Checked = True Then
                            If .Item("Status") = "Open" Then
                                dgv_Employee.Rows.Add()
                                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("DisbursedID").Value = .Item("DisbursedID").ToString
                                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("EmployeeNo").Value = .Item("EmployeeNo").ToString
                                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("EmployeeName").Value = .Item("EmpLastName").ToString & ", " & .Item("EmpFirstName").ToString
                                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("EmployeeDisbursedAmount").Value = .Item("EmployeeDisbursedAmount")
                                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("DisbursedStatus").Value = .Item("Status").ToString
                                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("ScheduleOfRelease").Value = CDate(IIf(IsDBNull(.Item("ScheduleOfRelease")), Nothing, .Item("ScheduleOfRelease"))).Date
                                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("CheckDetails").Value = .Item("CheckDetails").ToString
                                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("Employment_Status").Value = .Item("IncentiveEmploymentStatus").ToString
                                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("Current_Employment_Status").Value = .Item("Employment_Status").ToString
                                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("Payment_Mode").Value = IIf(.Item("On_ATM") = 1, "ATM", "Cheque")
                            End If
                        ElseIf Me.rdo_Disbursement_Released.Checked = True Then
                            If .Item("Status") = "Released" Then
                                dgv_Employee.Rows.Add()
                                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("DisbursedID").Value = .Item("DisbursedID").ToString
                                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("EmployeeNo").Value = .Item("EmployeeNo").ToString
                                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("EmployeeName").Value = .Item("EmpLastName").ToString & ", " & .Item("EmpFirstName").ToString
                                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("EmployeeDisbursedAmount").Value = .Item("EmployeeDisbursedAmount")
                                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("DisbursedStatus").Value = .Item("Status").ToString
                                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("ScheduleOfRelease").Value = CDate(IIf(IsDBNull(.Item("ScheduleOfRelease")), Nothing, .Item("ScheduleOfRelease"))).Date
                                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("CheckDetails").Value = .Item("CheckDetails").ToString
                                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("Employment_Status").Value = .Item("IncentiveEmploymentStatus").ToString
                                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("Current_Employment_Status").Value = .Item("Employment_Status").ToString
                                dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("Payment_Mode").Value = IIf(.Item("On_ATM") = 1, "ATM", "Cheque")
                            End If
                        ElseIf Me.rdo_Disbursement_All.Checked = True Then
                            dgv_Employee.Rows.Add()
                            dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("DisbursedID").Value = .Item("DisbursedID").ToString
                            dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("EmployeeNo").Value = .Item("EmployeeNo").ToString
                            dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("EmployeeName").Value = .Item("EmpLastName").ToString & ", " & .Item("EmpFirstName").ToString
                            dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("EmployeeDisbursedAmount").Value = .Item("EmployeeDisbursedAmount")
                            dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("DisbursedStatus").Value = .Item("Status").ToString
                            dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("ScheduleOfRelease").Value = CDate(IIf(IsDBNull(.Item("ScheduleOfRelease")), Nothing, .Item("ScheduleOfRelease"))).Date
                            dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("CheckDetails").Value = .Item("CheckDetails").ToString
                            dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("Employment_Status").Value = .Item("IncentiveEmploymentStatus").ToString
                            dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("Current_Employment_Status").Value = .Item("Employment_Status").ToString
                            dgv_Employee.Rows(dgv_Employee.Rows.Count - 1).Cells("Payment_Mode").Value = IIf(.Item("On_ATM") = 1, "ATM", "Cheque")
                        End If

                    End With
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        

    End Sub
    Private Sub frm_LiquidationReport_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frm_LiquidationReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBOClientLoad()
        Me.cbo_Client.SelectedIndex = 0
        Me.rdo_All.Checked = True
    End Sub

    Private Sub cbo_Client_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_Client.SelectedIndexChanged
        LoadDataGrid()
    End Sub

    Private Sub rdo_All_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_All.CheckedChanged
        LoadDataGrid()
    End Sub

    Private Sub rdo_Open_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Open.CheckedChanged
        LoadDataGrid()
    End Sub

    Private Sub rdo_Liquidated_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Liquidated.CheckedChanged
        LoadDataGrid()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        LoadEmployees()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub btn_ExportClients_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExportClients.Click
        Try
            'DSReferralDetails = Ref.SearchReferralDetails(Me.txt_Search_FirstName.Text, Me.txt_Search_LastName.Text, Me.txt_Search_ContactNumber.Text, CITYID, POSID, ACID, AID, RefDateFrom, RefDateTo)

            'verfying the datagridview having data or not
            If ((DataGridView1.Columns.Count = 0) Or (DataGridView1.Rows.Count = 0)) Then
                Exit Sub
            End If

            'Creating dataset to export
            Dim dset As New DataSet
            'add table to dataset
            dset.Tables.Add()
            'add column to that table
            '15 count
            For i As Integer = 0 To DataGridView1.ColumnCount - 1
                If Me.DataGridView1.Columns(i).Visible = True Then
                    dset.Tables(0).Columns.Add(DataGridView1.Columns(i).HeaderText)
                End If
            Next

            'add rows to the table
            Dim dr1 As DataRow
            For i As Integer = 0 To DataGridView1.RowCount - 1
                dr1 = dset.Tables(0).NewRow
                For j As Integer = 0 To DataGridView1.Columns.Count - 1
                    If Me.DataGridView1.Columns(j).Visible = True Then
                        dr1(Me.DataGridView1.Columns(j).HeaderText) = DataGridView1.Rows(i).Cells(j).Value
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
                excel.Cells(10, colIndex) = dc.ColumnName
                excel.Cells(10, colIndex).borders.weight = 2
                excel.Cells(10, colIndex).interior.color = System.Drawing.ColorTranslator.ToOle(Color.LightGray)

            Next

            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    excel.Cells(rowIndex + 10, colIndex) = dr(dc.ColumnName)
                    excel.Cells(rowIndex + 10, colIndex).Borders.Weight = 2
                    If colIndex >= 4 Then
                        excel.Cells(rowIndex + 10, colIndex).numberformat = "_(#,##0.00_);_((#,##0.00);_("" - ""??_);_(@_)"
                    End If

                Next
            Next
            'wSheet.Range(excel.Cells(rowIndex + 10, 1), excel.Cells(rowIndex + 10, colIndex)).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightGray)


            'Details
            excel.Cells(1, 1) = "Customer Touchpoint Resources, Inc."
            'excel.Range(excel.Cells(1, 1), excel.Cells(1, colIndex)).Merge()
            excel.Range(excel.Cells(1, 1), excel.Cells(1, colIndex)).HorizontalAlignment = HorizontalAlignment.Center
            excel.Cells(2, 1) = "6th Floor, Admiralty Bldg. 1101 Madrigal Business Park Alabang – Zapote Rd., Muntinlupa City"

            If Me.cbo_Client.SelectedIndex <> 0 Then
                excel.Cells(4, 1) = "Liquidation report for " & Me.cbo_Client.Text
            Else
                excel.Cells(4, 1) = "Liquidation report for clients"
            End If

            'excel.Cells(5, 1) = "Pay Period: "
            'excel.Cells(5, 1) = "Pay Coverage: " & Me.txt_PayPeriod.Text
            'excel.Cells(6, 1) = "Pay Coverage: " & CDate(Me.dtp_From.Text).ToString("MMMM dd") & "-" & CDate(Me.dtp_To.Text).ToString("dd, yyyy")

            'excel.Cells(rowIndex + 15, 1) = "Prepared by:"
            'excel.Cells(rowIndex + 16, 1) = mod_Login.LoginFirstName & " " & mod_Login.LoginLastName
            'excel.Cells(rowIndex + 17, 1) = mod_Login.LoginPositionID

            'excel.Range("D1").EntireColumn.NumberFormat = "_(#,##0.00_);_((#,##0.00);_("" - ""??_);_(@_)"

            'wSheet.Columns.AutoFit()
            Dim SaveString As String
            SaveFileDialog1.DefaultExt = "xlsx"
            SaveFileDialog1.Filter = "Excel|*.xlsx|Excel 97-2003|*.xls|All Files|*.*"
            If Me.cbo_Client.SelectedIndex <> 0 Then
                SaveFileDialog1.FileName = "Liquidation Report for all clients"
            Else
                SaveFileDialog1.FileName = "Liquidation Report for " & Me.cbo_Client.Text
            End If

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
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub

    Private Sub btn_Export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Export.Click
        Try
            'DSReferralDetails = Ref.SearchReferralDetails(Me.txt_Search_FirstName.Text, Me.txt_Search_LastName.Text, Me.txt_Search_ContactNumber.Text, CITYID, POSID, ACID, AID, RefDateFrom, RefDateTo)

            'verfying the datagridview having data or not
            If ((dgv_Employee.Columns.Count = 0) Or (dgv_Employee.Rows.Count = 0)) Then
                Exit Sub
            End If

            'Creating dataset to export
            Dim dset As New DataSet
            'add table to dataset
            dset.Tables.Add()
            'add column to that table
            '15 count
            For i As Integer = 0 To dgv_Employee.ColumnCount - 1
                If Me.dgv_Employee.Columns(i).Visible = True Then
                    dset.Tables(0).Columns.Add(dgv_Employee.Columns(i).HeaderText)
                End If
            Next

            Dim TotalAmount As Decimal
            'add rows to the table
            Dim dr1 As DataRow
            For i As Integer = 0 To dgv_Employee.RowCount - 1
                dr1 = dset.Tables(0).NewRow
                For j As Integer = 0 To dgv_Employee.Columns.Count - 1
                    If Me.dgv_Employee.Columns(j).Visible = True Then
                        dr1(Me.dgv_Employee.Columns(j).HeaderText) = dgv_Employee.Rows(i).Cells(j).Value
                    End If

                Next
                dset.Tables(0).Rows.Add(dr1)
                TotalAmount += CDec(dgv_Employee.Rows(i).Cells("EmployeeDisbursedAmount").Value)
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
                excel.Cells(10, colIndex) = dc.ColumnName
                excel.Cells(10, colIndex).borders.weight = 2
                excel.Cells(10, colIndex).interior.color = System.Drawing.ColorTranslator.ToOle(Color.LightGray)

            Next

            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    excel.Cells(rowIndex + 10, colIndex) = dr(dc.ColumnName)
                    excel.Cells(rowIndex + 10, colIndex).Borders.Weight = 2
                    'If colIndex > 2 Then
                    '    excel.Cells(rowIndex + 10, colIndex).numberformat = "_(#,##0.00_);_((#,##0.00);_("" - ""??_);_(@_)"
                    'End If
                    excel.Cells(rowIndex + 10, 4).numberformat = "_(#,##0.00_);_((#,##0.00);_("" - ""??_);_(@_)"
                    excel.Cells(rowIndex + 10, 6).numberformat = "mm/dd/yyyy"
                Next
            Next


            'wSheet.Range(excel.Cells(rowIndex + 10, 1), excel.Cells(rowIndex + 10, colIndex)).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightGray)


            'Details
            excel.Cells(1, 1) = "Customer Touchpoint Resources, Inc."
            'excel.Range(excel.Cells(1, 1), excel.Cells(1, colIndex)).Merge()
            excel.Range(excel.Cells(1, 1), excel.Cells(1, colIndex)).HorizontalAlignment = HorizontalAlignment.Center
            excel.Cells(2, 1) = "6th Floor, Admiralty Bldg. 1101 Madrigal Business Park Alabang – Zapote Rd., Muntinlupa City"

            excel.Cells(4, 1) = "Detailed Liquidation Report for " & Me.DataGridView1.SelectedRows(0).Cells("Client").Value


            excel.Cells(5, 1) = "Cheque Number:"
            excel.Cells(5, 2) = Me.DataGridView1.SelectedRows(0).Cells("ChequeNumber").Value
            excel.Cells(6, 1) = "Cheque Amount:"
            excel.Cells(6, 2) = Me.DataGridView1.SelectedRows(0).Cells("ChequeAmount").Value
            excel.Cells(7, 1) = "Disbursed Amount:"
            excel.Cells(7, 2) = Me.DataGridView1.SelectedRows(0).Cells("DisbursedAmount").Value
            excel.Cells(8, 1) = "Balance:"
            excel.Cells(8, 2) = Me.DataGridView1.SelectedRows(0).Cells("Balance").Value

            excel.Cells(dset.Tables(0).Rows.Count + 11, 2) = "Total:"
            excel.Cells(dset.Tables(0).Rows.Count + 11, 4) = TotalAmount


            'excel.Cells(rowIndex + 15, 1) = "Prepared by:"
            'excel.Cells(rowIndex + 16, 1) = mod_Login.LoginFirstName & " " & mod_Login.LoginLastName
            'excel.Cells(rowIndex + 17, 1) = mod_Login.LoginPositionID

            'excel.Range("D1").EntireColumn.NumberFormat = "_(#,##0.00_);_((#,##0.00);_("" - ""??_);_(@_)"

            'wSheet.Columns.AutoFit()
            Dim SaveString As String
            SaveFileDialog1.DefaultExt = "xlsx"
            SaveFileDialog1.Filter = "Excel|*.xlsx|Excel 97-2003|*.xls|All Files|*.*"
            SaveFileDialog1.FileName = "Detailed Liquidation Report for " & Me.DataGridView1.SelectedRows(0).Cells("Client").Value


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
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub btn_BankAdvice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BankAdvice.Click
        If Me.DataGridView1.SelectedRows.Count > 0 Then
            frm_BankAdvice.ReferenceID = Me.DataGridView1.SelectedRows(0).Cells("ReferenceNumber").Value
            frm_BankAdvice.txt_Bank.Text = Me.DataGridView1.SelectedRows(0).Cells("bank_name").Value
            frm_BankAdvice.Bank_Code = Me.DataGridView1.SelectedRows(0).Cells("bank_code").Value
            frm_BankAdvice.Bank_Manager = Me.DataGridView1.SelectedRows(0).Cells("bank_manager").Value
            frm_BankAdvice.Bank_Address = Me.DataGridView1.SelectedRows(0).Cells("bank_address").Value
            frm_BankAdvice.ShowDialog()
        Else
            MessageBox.Show("Please choose a client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub rdo_Disbursement_Open_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Disbursement_Open.CheckedChanged
        LoadEmployees()
    End Sub

    Private Sub rdo_Disbursement_Released_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Disbursement_Released.CheckedChanged
        LoadEmployees()
    End Sub

    Private Sub btn_Release_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Release.Click
        If Me.DataGridView1.SelectedRows.Count > 0 Then
            If Me.DataGridView1.SelectedRows(0).Cells("Liquidated").Value = 1 Then
                MessageBox.Show("Release forbidden, item already liquidated", "Releasing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If
        If Me.dgv_Employee.SelectedRows.Count > 0 Then
            If MessageBox.Show("Release selected items?", "Releasing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                frm_LiquidationReport_ReleaseDate.ShowDialog()
                For i As Integer = 0 To Me.dgv_Employee.Rows.Count - 1
                    If Me.dgv_Employee.Rows(i).Cells("Release").Value = True Then
                        CL_Disbursement.Release_Disbursement(Me.dgv_Employee.Rows(i).Cells("DisbursedID").Value, ReleaseDate)
                    End If
                Next
                MessageBox.Show("Items successfully released.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                LoadDataGrid()
                Me.ReleaseDate = Nothing
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btn_ExportClients_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim Arr_Employee_ATM As New ArrayList
            Dim Arr_Employee_Cheque As New ArrayList

            For i As Integer = 0 To Me.dgv_Employee.Rows.Count - 1
                With dgv_Employee.Rows(i)
                    If .Cells("Payment_Mode").Value = "ATM" Then
                        Arr_Employee_ATM.Add(i)
                    ElseIf .Cells("Payment_Mode").Value = "Cheque" Then
                        Arr_Employee_Cheque.Add(i)
                    End If
                End With
            Next

            If ((dgv_Employee.Columns.Count = 0) Or (dgv_Employee.Rows.Count = 0)) Then
                Exit Sub
            End If

            'Creating dataset to export
            Dim dset As New DataSet
            'add table to dataset
            dset.Tables.Add()
            'add column to that table
            '15 count
            For i As Integer = 0 To dgv_Employee.ColumnCount - 1
                If Me.dgv_Employee.Columns(i).Visible = True Then
                    dset.Tables(0).Columns.Add(dgv_Employee.Columns(i).HeaderText)
                End If
            Next

            'add rows to the table
            Dim dr1 As DataRow

            Dim TotalATM As New Decimal
            Dim TotalCheque As New Decimal

            For atm As Integer = 0 To Arr_Employee_ATM.Count - 1
                dr1 = dset.Tables(0).NewRow
                For j As Integer = 0 To dgv_Employee.Columns.Count - 1
                    If Me.dgv_Employee.Columns(j).Visible = True Then
                        dr1(Me.dgv_Employee.Columns(j).HeaderText) = dgv_Employee.Rows(Arr_Employee_ATM(atm)).Cells(j).Value
                    End If
                Next
                dset.Tables(0).Rows.Add(dr1)
                TotalATM += CDec(dgv_Employee.Rows(Arr_Employee_ATM(atm)).Cells("EmployeeDisbursedAmount").Value)
            Next

            dr1 = dset.Tables(0).NewRow
            dset.Tables(0).Rows.Add(dr1)

            For cheque As Integer = 0 To Arr_Employee_Cheque.Count - 1
                dr1 = dset.Tables(0).NewRow
                For j As Integer = 0 To dgv_Employee.Columns.Count - 1
                    If Me.dgv_Employee.Columns(j).Visible = True Then
                        dr1(Me.dgv_Employee.Columns(j).HeaderText) = dgv_Employee.Rows(Arr_Employee_Cheque(cheque)).Cells(j).Value
                    End If
                Next
                dset.Tables(0).Rows.Add(dr1)
                TotalCheque += CDec(dgv_Employee.Rows(Arr_Employee_Cheque(cheque)).Cells("EmployeeDisbursedAmount").Value)
            Next

            dr1 = dset.Tables(0).NewRow
            dset.Tables(0).Rows.Add(dr1)


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
                excel.Cells(10, colIndex) = dc.ColumnName
                excel.Cells(10, colIndex).borders.weight = 2
                excel.Cells(10, colIndex).interior.color = System.Drawing.ColorTranslator.ToOle(Color.LightGray)

            Next

            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    excel.Cells(rowIndex + 10, colIndex) = dr(dc.ColumnName)
                    excel.Cells(rowIndex + 10, colIndex).Borders.Weight = 2
                    'If colIndex > 2 Then
                    '    excel.Cells(rowIndex + 10, colIndex).numberformat = "_(#,##0.00_);_((#,##0.00);_("" - ""??_);_(@_)"
                    'End If
                    excel.Cells(rowIndex + 10, 3).numberformat = "_(#,##0.00_);_((#,##0.00);_("" - ""??_);_(@_)"
                    excel.Cells(rowIndex + 10, 6).numberformat = "mm/dd/yyyy"
                Next
            Next

            'wSheet.Range(excel.Cells(rowIndex + 10, 1), excel.Cells(rowIndex + 10, colIndex)).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightGray)


            'Details
            excel.Cells(1, 1) = "Customer Touchpoint Resources, Inc."
            'excel.Range(excel.Cells(1, 1), excel.Cells(1, colIndex)).Merge()
            excel.Range(excel.Cells(1, 1), excel.Cells(1, colIndex)).HorizontalAlignment = HorizontalAlignment.Center
            excel.Cells(2, 1) = "6th Floor, Admiralty Bldg. 1101 Madrigal Business Park Alabang – Zapote Rd., Muntinlupa City"

            excel.Cells(4, 1) = "Detailed Liquidation Report for " & Me.DataGridView1.SelectedRows(0).Cells("Client").Value


            excel.Cells(5, 1) = "Cheque Number: " & Me.DataGridView1.SelectedRows(0).Cells("ChequeNumber").Value
            excel.Cells(6, 1) = "Cheque Amount: " & Me.DataGridView1.SelectedRows(0).Cells("ChequeAmount").Value
            excel.Cells(7, 1) = "Disbursed Amount: " & Me.DataGridView1.SelectedRows(0).Cells("DisbursedAmount").Value
            'excel.Cells(rowIndex + 15, 1) = "Prepared by:"
            'excel.Cells(rowIndex + 16, 1) = mod_Login.LoginFirstName & " " & mod_Login.LoginLastName
            'excel.Cells(rowIndex + 17, 1) = mod_Login.LoginPositionID

            'excel.Range("D1").EntireColumn.NumberFormat = "_(#,##0.00_);_((#,##0.00);_("" - ""??_);_(@_)"

            'wSheet.Columns.AutoFit()

            excel.Cells(Arr_Employee_ATM.Count + 11, 2) = "Total"
            excel.Cells(Arr_Employee_ATM.Count + 11, 4) = TotalATM

            excel.Cells(Arr_Employee_ATM.Count + Arr_Employee_Cheque.Count + 12, 2) = "Total"
            excel.Cells(Arr_Employee_ATM.Count + Arr_Employee_Cheque.Count + 12, 4) = TotalCheque

            Dim SaveString As String
            SaveFileDialog1.DefaultExt = "xlsx"
            SaveFileDialog1.Filter = "Excel|*.xlsx|Excel 97-2003|*.xls|All Files|*.*"
            SaveFileDialog1.FileName = "Detailed Liquidation Report for " & Me.DataGridView1.SelectedRows(0).Cells("Client").Value


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
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try

    End Sub

   
    Private Sub btn_ReleaseAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ReleaseAll.Click
        If Me.DataGridView1.SelectedRows.Count > 0 Then
            If Me.DataGridView1.SelectedRows(0).Cells("Liquidated").Value = 1 Then
                MessageBox.Show("Release forbidden, item already liquidated", "Releasing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If
        If Me.dgv_Employee.SelectedRows.Count > 0 Then
            If MessageBox.Show("Release all active employees?", "Releasing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

                For i As Integer = 0 To Me.dgv_Employee.Rows.Count - 1
                    If Me.dgv_Employee.Rows(i).Cells("Current_Employment_Status").Value = "Active" Then
                        CL_Disbursement.Release_Disbursement(Me.dgv_Employee.Rows(i).Cells("DisbursedID").Value, ReleaseDate)
                    End If
                Next
                MessageBox.Show("Active employees successfully released.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.ReleaseDate = Nothing
                LoadDataGrid()
            End If
        End If
    End Sub
End Class