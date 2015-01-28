<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_LiquidationReport
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_LiquidationReport))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.btn_Close = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgv_Employee = New System.Windows.Forms.DataGridView
        Me.DisbursedID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmployeeNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Payment_Mode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmployeeDisbursedAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DisbursedStatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ScheduleOfRelease = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CheckDetails = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Employment_Status = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Current_Employment_Status = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Release = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel
        Me.rdo_Disbursement_Open = New System.Windows.Forms.RadioButton
        Me.rdo_Disbursement_All = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.rdo_Disbursement_Released = New System.Windows.Forms.RadioButton
        Me.grp_DisbursementEmployees = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.cbo_Status = New System.Windows.Forms.ComboBox
        Me.btn_Save = New System.Windows.Forms.Button
        Me.dtp_ScheduleOfRelease = New System.Windows.Forms.DateTimePicker
        Me.txt_ChequeReferenceNumber = New System.Windows.Forms.TextBox
        Me.txt_CheckDetails = New System.Windows.Forms.TextBox
        Me.txt_Amount = New System.Windows.Forms.TextBox
        Me.txt_EmployeeName = New System.Windows.Forms.TextBox
        Me.txt_EmployeeNo = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.btn_ReleaseAll = New System.Windows.Forms.Button
        Me.btn_Release = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Client = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReferenceNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChequeNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChequeAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DisbursedAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Balance = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Liquidated = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bank_code = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bank_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bank_address = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bank_manager = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel
        Me.btn_ExportClients = New System.Windows.Forms.Button
        Me.btn_Export = New System.Windows.Forms.Button
        Me.btn_BankAdvice = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.rdo_All = New System.Windows.Forms.RadioButton
        Me.rdo_Liquidated = New System.Windows.Forms.RadioButton
        Me.rdo_Open = New System.Windows.Forms.RadioButton
        Me.cbo_Client = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_Employee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.grp_DisbursementEmployees.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Close, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 392)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(771, 39)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btn_Close
        '
        Me.btn_Close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.Location = New System.Drawing.Point(693, 3)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 33)
        Me.btn_Close.TabIndex = 0
        Me.btn_Close.Text = "&Close"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "&Export Details"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(771, 392)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgv_Employee)
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel6)
        Me.GroupBox3.Controls.Add(Me.grp_DisbursementEmployees)
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(349, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(419, 386)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Employee"
        '
        'dgv_Employee
        '
        Me.dgv_Employee.AllowUserToAddRows = False
        Me.dgv_Employee.AllowUserToDeleteRows = False
        Me.dgv_Employee.AllowUserToResizeRows = False
        Me.dgv_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Employee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DisbursedID, Me.EmployeeNo, Me.EmployeeName, Me.Payment_Mode, Me.EmployeeDisbursedAmount, Me.DisbursedStatus, Me.ScheduleOfRelease, Me.CheckDetails, Me.Employment_Status, Me.Current_Employment_Status, Me.Release})
        Me.dgv_Employee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Employee.Location = New System.Drawing.Point(3, 45)
        Me.dgv_Employee.MultiSelect = False
        Me.dgv_Employee.Name = "dgv_Employee"
        Me.dgv_Employee.RowHeadersVisible = False
        Me.dgv_Employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Employee.Size = New System.Drawing.Size(413, 309)
        Me.dgv_Employee.TabIndex = 11
        '
        'DisbursedID
        '
        Me.DisbursedID.Frozen = True
        Me.DisbursedID.HeaderText = "DisbursedID"
        Me.DisbursedID.Name = "DisbursedID"
        Me.DisbursedID.Visible = False
        '
        'EmployeeNo
        '
        Me.EmployeeNo.Frozen = True
        Me.EmployeeNo.HeaderText = "Employee No"
        Me.EmployeeNo.Name = "EmployeeNo"
        Me.EmployeeNo.ReadOnly = True
        '
        'EmployeeName
        '
        Me.EmployeeName.Frozen = True
        Me.EmployeeName.HeaderText = "Employee Name"
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.ReadOnly = True
        '
        'Payment_Mode
        '
        Me.Payment_Mode.HeaderText = "Payment Mode"
        Me.Payment_Mode.Name = "Payment_Mode"
        Me.Payment_Mode.ReadOnly = True
        '
        'EmployeeDisbursedAmount
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "-"
        Me.EmployeeDisbursedAmount.DefaultCellStyle = DataGridViewCellStyle1
        Me.EmployeeDisbursedAmount.HeaderText = "Amount"
        Me.EmployeeDisbursedAmount.Name = "EmployeeDisbursedAmount"
        Me.EmployeeDisbursedAmount.ReadOnly = True
        '
        'DisbursedStatus
        '
        Me.DisbursedStatus.HeaderText = "Status"
        Me.DisbursedStatus.Name = "DisbursedStatus"
        Me.DisbursedStatus.ReadOnly = True
        '
        'ScheduleOfRelease
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ScheduleOfRelease.DefaultCellStyle = DataGridViewCellStyle2
        Me.ScheduleOfRelease.HeaderText = "Schedule Of Release"
        Me.ScheduleOfRelease.Name = "ScheduleOfRelease"
        Me.ScheduleOfRelease.ReadOnly = True
        '
        'CheckDetails
        '
        Me.CheckDetails.HeaderText = "Check Details"
        Me.CheckDetails.Name = "CheckDetails"
        Me.CheckDetails.ReadOnly = True
        '
        'Employment_Status
        '
        Me.Employment_Status.HeaderText = "Disbursement Employment Status"
        Me.Employment_Status.Name = "Employment_Status"
        Me.Employment_Status.ReadOnly = True
        '
        'Current_Employment_Status
        '
        Me.Current_Employment_Status.HeaderText = "Current Employment Status"
        Me.Current_Employment_Status.Name = "Current_Employment_Status"
        Me.Current_Employment_Status.ReadOnly = True
        '
        'Release
        '
        Me.Release.HeaderText = "Release"
        Me.Release.Name = "Release"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel7, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(413, 29)
        Me.TableLayoutPanel6.TabIndex = 9
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 4
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.rdo_Disbursement_Open, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.rdo_Disbursement_All, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.rdo_Disbursement_Released, 3, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(324, 23)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'rdo_Disbursement_Open
        '
        Me.rdo_Disbursement_Open.AutoSize = True
        Me.rdo_Disbursement_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdo_Disbursement_Open.Location = New System.Drawing.Point(90, 3)
        Me.rdo_Disbursement_Open.Name = "rdo_Disbursement_Open"
        Me.rdo_Disbursement_Open.Size = New System.Drawing.Size(50, 17)
        Me.rdo_Disbursement_Open.TabIndex = 12
        Me.rdo_Disbursement_Open.Text = "Open"
        Me.rdo_Disbursement_Open.UseVisualStyleBackColor = True
        '
        'rdo_Disbursement_All
        '
        Me.rdo_Disbursement_All.AutoSize = True
        Me.rdo_Disbursement_All.Checked = True
        Me.rdo_Disbursement_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdo_Disbursement_All.Location = New System.Drawing.Point(49, 3)
        Me.rdo_Disbursement_All.Name = "rdo_Disbursement_All"
        Me.rdo_Disbursement_All.Size = New System.Drawing.Size(35, 17)
        Me.rdo_Disbursement_All.TabIndex = 10
        Me.rdo_Disbursement_All.TabStop = True
        Me.rdo_Disbursement_All.Text = "All"
        Me.rdo_Disbursement_All.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Status:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rdo_Disbursement_Released
        '
        Me.rdo_Disbursement_Released.AutoSize = True
        Me.rdo_Disbursement_Released.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdo_Disbursement_Released.Location = New System.Drawing.Point(146, 3)
        Me.rdo_Disbursement_Released.Name = "rdo_Disbursement_Released"
        Me.rdo_Disbursement_Released.Size = New System.Drawing.Size(69, 17)
        Me.rdo_Disbursement_Released.TabIndex = 11
        Me.rdo_Disbursement_Released.Text = "Released"
        Me.rdo_Disbursement_Released.UseVisualStyleBackColor = True
        '
        'grp_DisbursementEmployees
        '
        Me.grp_DisbursementEmployees.Controls.Add(Me.TableLayoutPanel3)
        Me.grp_DisbursementEmployees.Location = New System.Drawing.Point(91, 96)
        Me.grp_DisbursementEmployees.Name = "grp_DisbursementEmployees"
        Me.grp_DisbursementEmployees.Size = New System.Drawing.Size(188, 210)
        Me.grp_DisbursementEmployees.TabIndex = 8
        Me.grp_DisbursementEmployees.TabStop = False
        Me.grp_DisbursementEmployees.Text = "Disbursement Of Employee"
        Me.grp_DisbursementEmployees.Visible = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label15, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Label13, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label11, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label17, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.cbo_Status, 1, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_Save, 1, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.dtp_ScheduleOfRelease, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_ChequeReferenceNumber, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_CheckDetails, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_Amount, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_EmployeeName, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_EmployeeNo, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 9
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(182, 191)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label7.Location = New System.Drawing.Point(16, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 26)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Employee Number:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label15.Location = New System.Drawing.Point(3, 161)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 29)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Schedule of Release:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label13.Location = New System.Drawing.Point(8, 134)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 27)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Check Reference #:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label11.Location = New System.Drawing.Point(36, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 56)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Check Details:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label8.Location = New System.Drawing.Point(66, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 26)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Amount:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Location = New System.Drawing.Point(25, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 26)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Employee Name:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label17.Location = New System.Drawing.Point(72, 190)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 33)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Status:"
        '
        'cbo_Status
        '
        Me.cbo_Status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo_Status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Status.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbo_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_Status.FormattingEnabled = True
        Me.cbo_Status.Items.AddRange(New Object() {"Released", "Open"})
        Me.cbo_Status.Location = New System.Drawing.Point(118, 193)
        Me.cbo_Status.Name = "cbo_Status"
        Me.cbo_Status.Size = New System.Drawing.Size(61, 21)
        Me.cbo_Status.TabIndex = 18
        '
        'btn_Save
        '
        Me.btn_Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Save.Location = New System.Drawing.Point(118, 226)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(61, 22)
        Me.btn_Save.TabIndex = 1
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'dtp_ScheduleOfRelease
        '
        Me.dtp_ScheduleOfRelease.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_ScheduleOfRelease.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ScheduleOfRelease.Location = New System.Drawing.Point(118, 164)
        Me.dtp_ScheduleOfRelease.Name = "dtp_ScheduleOfRelease"
        Me.dtp_ScheduleOfRelease.Size = New System.Drawing.Size(61, 20)
        Me.dtp_ScheduleOfRelease.TabIndex = 17
        '
        'txt_ChequeReferenceNumber
        '
        Me.txt_ChequeReferenceNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ChequeReferenceNumber.Location = New System.Drawing.Point(118, 137)
        Me.txt_ChequeReferenceNumber.Name = "txt_ChequeReferenceNumber"
        Me.txt_ChequeReferenceNumber.ReadOnly = True
        Me.txt_ChequeReferenceNumber.Size = New System.Drawing.Size(61, 20)
        Me.txt_ChequeReferenceNumber.TabIndex = 14
        Me.txt_ChequeReferenceNumber.TabStop = False
        '
        'txt_CheckDetails
        '
        Me.txt_CheckDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CheckDetails.Location = New System.Drawing.Point(118, 81)
        Me.txt_CheckDetails.Multiline = True
        Me.txt_CheckDetails.Name = "txt_CheckDetails"
        Me.txt_CheckDetails.Size = New System.Drawing.Size(61, 50)
        Me.txt_CheckDetails.TabIndex = 13
        '
        'txt_Amount
        '
        Me.txt_Amount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Amount.Location = New System.Drawing.Point(118, 55)
        Me.txt_Amount.Name = "txt_Amount"
        Me.txt_Amount.Size = New System.Drawing.Size(61, 20)
        Me.txt_Amount.TabIndex = 12
        Me.txt_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_EmployeeName
        '
        Me.txt_EmployeeName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_EmployeeName.Location = New System.Drawing.Point(118, 29)
        Me.txt_EmployeeName.Name = "txt_EmployeeName"
        Me.txt_EmployeeName.ReadOnly = True
        Me.txt_EmployeeName.Size = New System.Drawing.Size(61, 20)
        Me.txt_EmployeeName.TabIndex = 11
        Me.txt_EmployeeName.TabStop = False
        '
        'txt_EmployeeNo
        '
        Me.txt_EmployeeNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_EmployeeNo.Location = New System.Drawing.Point(118, 3)
        Me.txt_EmployeeNo.Name = "txt_EmployeeNo"
        Me.txt_EmployeeNo.ReadOnly = True
        Me.txt_EmployeeNo.Size = New System.Drawing.Size(61, 20)
        Me.txt_EmployeeNo.TabIndex = 19
        Me.txt_EmployeeNo.TabStop = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.btn_ReleaseAll, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btn_Release, 2, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 354)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(413, 29)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'btn_ReleaseAll
        '
        Me.btn_ReleaseAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_ReleaseAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ReleaseAll.Location = New System.Drawing.Point(3, 3)
        Me.btn_ReleaseAll.Name = "btn_ReleaseAll"
        Me.btn_ReleaseAll.Size = New System.Drawing.Size(97, 23)
        Me.btn_ReleaseAll.TabIndex = 11
        Me.btn_ReleaseAll.Text = "R&elease All"
        Me.btn_ReleaseAll.UseVisualStyleBackColor = True
        '
        'btn_Release
        '
        Me.btn_Release.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Release.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Release.Location = New System.Drawing.Point(312, 3)
        Me.btn_Release.Name = "btn_Release"
        Me.btn_Release.Size = New System.Drawing.Size(98, 23)
        Me.btn_Release.TabIndex = 9
        Me.btn_Release.Text = "&Release"
        Me.btn_Release.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel5)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 386)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Client, Me.ReferenceNumber, Me.ChequeNumber, Me.ChequeAmount, Me.DisbursedAmount, Me.Balance, Me.Liquidated, Me.bank_code, Me.bank_name, Me.bank_address, Me.bank_manager})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 67)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(334, 287)
        Me.DataGridView1.TabIndex = 5
        '
        'Client
        '
        Me.Client.Frozen = True
        Me.Client.HeaderText = "Client"
        Me.Client.Name = "Client"
        Me.Client.ReadOnly = True
        Me.Client.Width = 58
        '
        'ReferenceNumber
        '
        Me.ReferenceNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ReferenceNumber.DefaultCellStyle = DataGridViewCellStyle3
        Me.ReferenceNumber.HeaderText = "Reference Number"
        Me.ReferenceNumber.Name = "ReferenceNumber"
        Me.ReferenceNumber.ReadOnly = True
        Me.ReferenceNumber.Width = 112
        '
        'ChequeNumber
        '
        Me.ChequeNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ChequeNumber.HeaderText = "Cheque Number"
        Me.ChequeNumber.Name = "ChequeNumber"
        Me.ChequeNumber.ReadOnly = True
        '
        'ChequeAmount
        '
        Me.ChequeAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "n2"
        DataGridViewCellStyle4.NullValue = "-"
        Me.ChequeAmount.DefaultCellStyle = DataGridViewCellStyle4
        Me.ChequeAmount.HeaderText = "Cheque Amount"
        Me.ChequeAmount.Name = "ChequeAmount"
        Me.ChequeAmount.ReadOnly = True
        Me.ChequeAmount.Width = 99
        '
        'DisbursedAmount
        '
        Me.DisbursedAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "n2"
        DataGridViewCellStyle5.NullValue = "-"
        Me.DisbursedAmount.DefaultCellStyle = DataGridViewCellStyle5
        Me.DisbursedAmount.HeaderText = "Disbursed Amount"
        Me.DisbursedAmount.Name = "DisbursedAmount"
        Me.DisbursedAmount.ReadOnly = True
        Me.DisbursedAmount.Width = 108
        '
        'Balance
        '
        Me.Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "n2"
        DataGridViewCellStyle6.NullValue = "-"
        Me.Balance.DefaultCellStyle = DataGridViewCellStyle6
        Me.Balance.HeaderText = "Balance"
        Me.Balance.Name = "Balance"
        Me.Balance.ReadOnly = True
        Me.Balance.Width = 71
        '
        'Liquidated
        '
        Me.Liquidated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Liquidated.HeaderText = "Liquidated"
        Me.Liquidated.Name = "Liquidated"
        Me.Liquidated.ReadOnly = True
        Me.Liquidated.Visible = False
        '
        'bank_code
        '
        Me.bank_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.bank_code.HeaderText = "Bank_code"
        Me.bank_code.Name = "bank_code"
        Me.bank_code.ReadOnly = True
        Me.bank_code.Visible = False
        '
        'bank_name
        '
        Me.bank_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.bank_name.HeaderText = "bank_name"
        Me.bank_name.Name = "bank_name"
        Me.bank_name.ReadOnly = True
        Me.bank_name.Visible = False
        '
        'bank_address
        '
        Me.bank_address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.bank_address.HeaderText = "bank_address"
        Me.bank_address.Name = "bank_address"
        Me.bank_address.ReadOnly = True
        Me.bank_address.Visible = False
        '
        'bank_manager
        '
        Me.bank_manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.bank_manager.HeaderText = "bank_manager"
        Me.bank_manager.Name = "bank_manager"
        Me.bank_manager.ReadOnly = True
        Me.bank_manager.Visible = False
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 5
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.btn_ExportClients, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btn_Export, 4, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btn_BankAdvice, 2, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 354)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(334, 29)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'btn_ExportClients
        '
        Me.btn_ExportClients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_ExportClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ExportClients.Location = New System.Drawing.Point(3, 3)
        Me.btn_ExportClients.Name = "btn_ExportClients"
        Me.btn_ExportClients.Size = New System.Drawing.Size(94, 23)
        Me.btn_ExportClients.TabIndex = 5
        Me.btn_ExportClients.Text = "E&xport Header"
        Me.btn_ExportClients.UseVisualStyleBackColor = True
        '
        'btn_Export
        '
        Me.btn_Export.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Export.Location = New System.Drawing.Point(235, 3)
        Me.btn_Export.Name = "btn_Export"
        Me.btn_Export.Size = New System.Drawing.Size(96, 23)
        Me.btn_Export.TabIndex = 8
        Me.btn_Export.Text = "Export &Details"
        Me.btn_Export.UseVisualStyleBackColor = True
        '
        'btn_BankAdvice
        '
        Me.btn_BankAdvice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_BankAdvice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_BankAdvice.Location = New System.Drawing.Point(119, 3)
        Me.btn_BankAdvice.Name = "btn_BankAdvice"
        Me.btn_BankAdvice.Size = New System.Drawing.Size(94, 23)
        Me.btn_BankAdvice.TabIndex = 9
        Me.btn_BankAdvice.Text = "&Bank Advice"
        Me.btn_BankAdvice.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.rdo_All)
        Me.Panel1.Controls.Add(Me.rdo_Liquidated)
        Me.Panel1.Controls.Add(Me.rdo_Open)
        Me.Panel1.Controls.Add(Me.cbo_Client)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(334, 51)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Status:"
        '
        'rdo_All
        '
        Me.rdo_All.AutoSize = True
        Me.rdo_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdo_All.Location = New System.Drawing.Point(53, 32)
        Me.rdo_All.Name = "rdo_All"
        Me.rdo_All.Size = New System.Drawing.Size(35, 17)
        Me.rdo_All.TabIndex = 1
        Me.rdo_All.TabStop = True
        Me.rdo_All.Text = "&All"
        Me.rdo_All.UseVisualStyleBackColor = True
        '
        'rdo_Liquidated
        '
        Me.rdo_Liquidated.AutoSize = True
        Me.rdo_Liquidated.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdo_Liquidated.Location = New System.Drawing.Point(235, 32)
        Me.rdo_Liquidated.Name = "rdo_Liquidated"
        Me.rdo_Liquidated.Size = New System.Drawing.Size(73, 17)
        Me.rdo_Liquidated.TabIndex = 3
        Me.rdo_Liquidated.TabStop = True
        Me.rdo_Liquidated.Text = "&Liquidated"
        Me.rdo_Liquidated.UseVisualStyleBackColor = True
        '
        'rdo_Open
        '
        Me.rdo_Open.AutoSize = True
        Me.rdo_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdo_Open.Location = New System.Drawing.Point(144, 32)
        Me.rdo_Open.Name = "rdo_Open"
        Me.rdo_Open.Size = New System.Drawing.Size(50, 17)
        Me.rdo_Open.TabIndex = 2
        Me.rdo_Open.TabStop = True
        Me.rdo_Open.Text = "&Open"
        Me.rdo_Open.UseVisualStyleBackColor = True
        '
        'cbo_Client
        '
        Me.cbo_Client.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo_Client.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_Client.FormattingEnabled = True
        Me.cbo_Client.Location = New System.Drawing.Point(51, 5)
        Me.cbo_Client.Name = "cbo_Client"
        Me.cbo_Client.Size = New System.Drawing.Size(257, 21)
        Me.cbo_Client.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client:"
        '
        'frm_LiquidationReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 431)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(787, 469)
        Me.Name = "frm_LiquidationReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liquidation Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgv_Employee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.grp_DisbursementEmployees.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents grp_DisbursementEmployees As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cbo_Status As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents dtp_ScheduleOfRelease As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_ChequeReferenceNumber As System.Windows.Forms.TextBox
    Friend WithEvents txt_CheckDetails As System.Windows.Forms.TextBox
    Friend WithEvents txt_Amount As System.Windows.Forms.TextBox
    Friend WithEvents txt_EmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents txt_EmployeeNo As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_Export As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rdo_All As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Liquidated As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Open As System.Windows.Forms.RadioButton
    Friend WithEvents cbo_Client As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_BankAdvice As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_ExportClients As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgv_Employee As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Client As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReferenceNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChequeNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChequeAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DisbursedAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Balance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Liquidated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bank_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bank_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bank_address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bank_manager As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rdo_Disbursement_Open As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Disbursement_All As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Disbursement_Released As System.Windows.Forms.RadioButton
    Friend WithEvents btn_Release As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DisbursedID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Payment_Mode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeDisbursedAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DisbursedStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ScheduleOfRelease As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckDetails As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Employment_Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Current_Employment_Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Release As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btn_ReleaseAll As System.Windows.Forms.Button
End Class
