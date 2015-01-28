<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EmployeeAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_EmployeeAdd))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_EmploymentStatus = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbo_EmployeeName = New System.Windows.Forms.ComboBox
        Me.txt_Client = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_ChequeReferenceNumber = New System.Windows.Forms.TextBox
        Me.grp_DisbursementEmployees = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.cbo_Status = New System.Windows.Forms.ComboBox
        Me.txt_Amount = New System.Windows.Forms.TextBox
        Me.txt_EmployeeName = New System.Windows.Forms.TextBox
        Me.txt_EmployeeNo = New System.Windows.Forms.TextBox
        Me.dtp_ScheduleOfRelease = New System.Windows.Forms.DateTimePicker
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.rdo_Cheque = New System.Windows.Forms.RadioButton
        Me.rdo_ATM = New System.Windows.Forms.RadioButton
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel
        Me.txt_ATMDetails = New System.Windows.Forms.TextBox
        Me.txt_CheckDetails = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.btn_Save = New System.Windows.Forms.Button
        Me.btn_Close = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grp_DisbursementEmployees.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(383, 130)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_EmploymentStatus, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cbo_EmployeeName, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Client, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_ChequeReferenceNumber, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(377, 111)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Location = New System.Drawing.Point(17, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 27)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Employment Status:"
        '
        'txt_EmploymentStatus
        '
        Me.txt_EmploymentStatus.BackColor = System.Drawing.SystemColors.Control
        Me.txt_EmploymentStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_EmploymentStatus.Enabled = False
        Me.txt_EmploymentStatus.Location = New System.Drawing.Point(123, 87)
        Me.txt_EmploymentStatus.Name = "txt_EmploymentStatus"
        Me.txt_EmploymentStatus.Size = New System.Drawing.Size(251, 20)
        Me.txt_EmploymentStatus.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label13.Location = New System.Drawing.Point(13, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 28)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Check Reference #:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Location = New System.Drawing.Point(81, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client:"
        '
        'cbo_EmployeeName
        '
        Me.cbo_EmployeeName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbo_EmployeeName.FormattingEnabled = True
        Me.cbo_EmployeeName.Location = New System.Drawing.Point(123, 59)
        Me.cbo_EmployeeName.Name = "cbo_EmployeeName"
        Me.cbo_EmployeeName.Size = New System.Drawing.Size(251, 21)
        Me.cbo_EmployeeName.TabIndex = 2
        '
        'txt_Client
        '
        Me.txt_Client.BackColor = System.Drawing.SystemColors.Control
        Me.txt_Client.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Client.Enabled = False
        Me.txt_Client.Location = New System.Drawing.Point(123, 31)
        Me.txt_Client.Name = "txt_Client"
        Me.txt_Client.Size = New System.Drawing.Size(251, 20)
        Me.txt_Client.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Location = New System.Drawing.Point(30, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employee Name:"
        '
        'txt_ChequeReferenceNumber
        '
        Me.txt_ChequeReferenceNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ChequeReferenceNumber.Location = New System.Drawing.Point(123, 3)
        Me.txt_ChequeReferenceNumber.Name = "txt_ChequeReferenceNumber"
        Me.txt_ChequeReferenceNumber.ReadOnly = True
        Me.txt_ChequeReferenceNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_ChequeReferenceNumber.Size = New System.Drawing.Size(251, 20)
        Me.txt_ChequeReferenceNumber.TabIndex = 14
        Me.txt_ChequeReferenceNumber.TabStop = False
        '
        'grp_DisbursementEmployees
        '
        Me.grp_DisbursementEmployees.Controls.Add(Me.TableLayoutPanel3)
        Me.grp_DisbursementEmployees.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp_DisbursementEmployees.Location = New System.Drawing.Point(0, 130)
        Me.grp_DisbursementEmployees.Name = "grp_DisbursementEmployees"
        Me.grp_DisbursementEmployees.Size = New System.Drawing.Size(383, 271)
        Me.grp_DisbursementEmployees.TabIndex = 9
        Me.grp_DisbursementEmployees.TabStop = False
        Me.grp_DisbursementEmployees.Text = "Disbursement Of Employee"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label15, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Label11, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label17, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.cbo_Status, 1, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_Amount, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_EmployeeName, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_EmployeeNo, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.dtp_ScheduleOfRelease, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 7
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(377, 252)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label7.Location = New System.Drawing.Point(21, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 26)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Employee Number:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label15.Location = New System.Drawing.Point(8, 196)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 27)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Schedule of Release:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label11.Location = New System.Drawing.Point(75, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 88)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Details:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label8.Location = New System.Drawing.Point(71, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 26)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Amount:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Location = New System.Drawing.Point(30, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 26)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Employee Name:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label17.Location = New System.Drawing.Point(77, 223)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 29)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Status:"
        '
        'cbo_Status
        '
        Me.cbo_Status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo_Status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Status.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbo_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Status.Enabled = False
        Me.cbo_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_Status.FormattingEnabled = True
        Me.cbo_Status.Items.AddRange(New Object() {"Open", "Released"})
        Me.cbo_Status.Location = New System.Drawing.Point(123, 226)
        Me.cbo_Status.Name = "cbo_Status"
        Me.cbo_Status.Size = New System.Drawing.Size(251, 21)
        Me.cbo_Status.TabIndex = 18
        Me.cbo_Status.TabStop = False
        '
        'txt_Amount
        '
        Me.txt_Amount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Amount.Location = New System.Drawing.Point(123, 55)
        Me.txt_Amount.Name = "txt_Amount"
        Me.txt_Amount.Size = New System.Drawing.Size(251, 20)
        Me.txt_Amount.TabIndex = 12
        Me.txt_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_EmployeeName
        '
        Me.txt_EmployeeName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_EmployeeName.Location = New System.Drawing.Point(123, 29)
        Me.txt_EmployeeName.Name = "txt_EmployeeName"
        Me.txt_EmployeeName.ReadOnly = True
        Me.txt_EmployeeName.Size = New System.Drawing.Size(251, 20)
        Me.txt_EmployeeName.TabIndex = 11
        Me.txt_EmployeeName.TabStop = False
        '
        'txt_EmployeeNo
        '
        Me.txt_EmployeeNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_EmployeeNo.Location = New System.Drawing.Point(123, 3)
        Me.txt_EmployeeNo.Name = "txt_EmployeeNo"
        Me.txt_EmployeeNo.ReadOnly = True
        Me.txt_EmployeeNo.Size = New System.Drawing.Size(251, 20)
        Me.txt_EmployeeNo.TabIndex = 19
        Me.txt_EmployeeNo.TabStop = False
        '
        'dtp_ScheduleOfRelease
        '
        Me.dtp_ScheduleOfRelease.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_ScheduleOfRelease.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ScheduleOfRelease.Location = New System.Drawing.Point(123, 199)
        Me.dtp_ScheduleOfRelease.Name = "dtp_ScheduleOfRelease"
        Me.dtp_ScheduleOfRelease.Size = New System.Drawing.Size(251, 20)
        Me.dtp_ScheduleOfRelease.TabIndex = 17
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.rdo_Cheque, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.rdo_ATM, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(123, 81)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(251, 24)
        Me.TableLayoutPanel4.TabIndex = 21
        '
        'rdo_Cheque
        '
        Me.rdo_Cheque.AutoSize = True
        Me.rdo_Cheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdo_Cheque.Location = New System.Drawing.Point(128, 3)
        Me.rdo_Cheque.Name = "rdo_Cheque"
        Me.rdo_Cheque.Size = New System.Drawing.Size(61, 17)
        Me.rdo_Cheque.TabIndex = 1
        Me.rdo_Cheque.Text = "Cheque"
        Me.rdo_Cheque.UseVisualStyleBackColor = True
        '
        'rdo_ATM
        '
        Me.rdo_ATM.AutoSize = True
        Me.rdo_ATM.Checked = True
        Me.rdo_ATM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdo_ATM.Location = New System.Drawing.Point(3, 3)
        Me.rdo_ATM.Name = "rdo_ATM"
        Me.rdo_ATM.Size = New System.Drawing.Size(47, 17)
        Me.rdo_ATM.TabIndex = 0
        Me.rdo_ATM.TabStop = True
        Me.rdo_ATM.Text = "ATM"
        Me.rdo_ATM.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.txt_ATMDetails, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.txt_CheckDetails, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(123, 111)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(251, 82)
        Me.TableLayoutPanel5.TabIndex = 22
        '
        'txt_ATMDetails
        '
        Me.txt_ATMDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ATMDetails.Enabled = False
        Me.txt_ATMDetails.Location = New System.Drawing.Point(3, 3)
        Me.txt_ATMDetails.Multiline = True
        Me.txt_ATMDetails.Name = "txt_ATMDetails"
        Me.txt_ATMDetails.Size = New System.Drawing.Size(119, 76)
        Me.txt_ATMDetails.TabIndex = 14
        '
        'txt_CheckDetails
        '
        Me.txt_CheckDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CheckDetails.Enabled = False
        Me.txt_CheckDetails.Location = New System.Drawing.Point(128, 3)
        Me.txt_CheckDetails.Multiline = True
        Me.txt_CheckDetails.Name = "txt_CheckDetails"
        Me.txt_CheckDetails.Size = New System.Drawing.Size(120, 76)
        Me.txt_CheckDetails.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Location = New System.Drawing.Point(66, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 30)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Payment:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.52095!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.47905!))
        Me.TableLayoutPanel2.Controls.Add(Me.btn_Save, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_Close, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 370)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(383, 30)
        Me.TableLayoutPanel2.TabIndex = 10
        '
        'btn_Save
        '
        Me.btn_Save.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Save.Location = New System.Drawing.Point(253, 3)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 24)
        Me.btn_Save.TabIndex = 2
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Close
        '
        Me.btn_Close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.Location = New System.Drawing.Point(334, 3)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(46, 24)
        Me.btn_Close.TabIndex = 1
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'frm_EmployeeAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 400)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.grp_DisbursementEmployees)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_EmployeeAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Add"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.grp_DisbursementEmployees.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grp_DisbursementEmployees As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cbo_Status As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_ScheduleOfRelease As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_ChequeReferenceNumber As System.Windows.Forms.TextBox
    Friend WithEvents txt_CheckDetails As System.Windows.Forms.TextBox
    Friend WithEvents txt_Amount As System.Windows.Forms.TextBox
    Friend WithEvents txt_EmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents txt_EmployeeNo As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents cbo_EmployeeName As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Client As System.Windows.Forms.TextBox
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_EmploymentStatus As System.Windows.Forms.TextBox
    Friend WithEvents rdo_Cheque As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_ATM As System.Windows.Forms.RadioButton
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txt_ATMDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
