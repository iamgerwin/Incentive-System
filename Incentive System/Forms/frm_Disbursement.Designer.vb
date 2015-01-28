<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Disbursement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Disbursement))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.btn_Close = New System.Windows.Forms.Button
        Me.btn_Save = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgv_Advances = New System.Windows.Forms.DataGridView
        Me.Client = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Client_Code = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReferenceNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChequeAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Balance = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DisbursedAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChequeNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cbo_Client = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.grp_ChequeDetails = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.txt_ChequeAmount = New System.Windows.Forms.TextBox
        Me.txt_Balance = New System.Windows.Forms.TextBox
        Me.txt_ChequeNumber = New System.Windows.Forms.TextBox
        Me.txt_Disbursed = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_ReferenceNumber = New System.Windows.Forms.TextBox
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
        Me.dtp_ScheduleOfRelease = New System.Windows.Forms.DateTimePicker
        Me.txt_ChequeReferenceNumber = New System.Windows.Forms.TextBox
        Me.txt_CheckDetails = New System.Windows.Forms.TextBox
        Me.txt_Amount = New System.Windows.Forms.TextBox
        Me.txt_EmployeeName = New System.Windows.Forms.TextBox
        Me.txt_EmployeeNo = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgv_Employee = New System.Windows.Forms.DataGridView
        Me.EmployeeNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Payment_Mode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmployeeDisbursedAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DisbursedStatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ScheduleOfRelease = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CheckDetails = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.On_ATM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.On_Cheque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Bank_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Bank_PayCard = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Bank_Account = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.btn_Remove = New System.Windows.Forms.Button
        Me.btn_Add = New System.Windows.Forms.Button
        Me.btn_Edit = New System.Windows.Forms.Button
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_Advances, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.grp_ChequeDetails.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.grp_DisbursementEmployees.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_Employee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Close, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 391)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(748, 31)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btn_Close
        '
        Me.btn_Close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.Location = New System.Drawing.Point(670, 3)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 25)
        Me.btn_Close.TabIndex = 0
        Me.btn_Close.Text = "&Close"
        Me.btn_Close.UseVisualStyleBackColor = True
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_Advances)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 391)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'dgv_Advances
        '
        Me.dgv_Advances.AllowUserToAddRows = False
        Me.dgv_Advances.AllowUserToDeleteRows = False
        Me.dgv_Advances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Advances.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Client, Me.Client_Code, Me.ReferenceNumber, Me.ChequeAmount, Me.Balance, Me.DisbursedAmount, Me.ChequeNumber})
        Me.dgv_Advances.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Advances.Location = New System.Drawing.Point(3, 45)
        Me.dgv_Advances.MultiSelect = False
        Me.dgv_Advances.Name = "dgv_Advances"
        Me.dgv_Advances.ReadOnly = True
        Me.dgv_Advances.RowHeadersVisible = False
        Me.dgv_Advances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Advances.Size = New System.Drawing.Size(404, 343)
        Me.dgv_Advances.TabIndex = 1
        '
        'Client
        '
        Me.Client.HeaderText = "Client"
        Me.Client.Name = "Client"
        Me.Client.ReadOnly = True
        '
        'Client_Code
        '
        Me.Client_Code.HeaderText = "Client_Code"
        Me.Client_Code.Name = "Client_Code"
        Me.Client_Code.ReadOnly = True
        Me.Client_Code.Visible = False
        '
        'ReferenceNumber
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ReferenceNumber.DefaultCellStyle = DataGridViewCellStyle1
        Me.ReferenceNumber.HeaderText = "Reference Number"
        Me.ReferenceNumber.Name = "ReferenceNumber"
        Me.ReferenceNumber.ReadOnly = True
        '
        'ChequeAmount
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "-"
        Me.ChequeAmount.DefaultCellStyle = DataGridViewCellStyle2
        Me.ChequeAmount.HeaderText = "Cheque Amount"
        Me.ChequeAmount.Name = "ChequeAmount"
        Me.ChequeAmount.ReadOnly = True
        '
        'Balance
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "-"
        Me.Balance.DefaultCellStyle = DataGridViewCellStyle3
        Me.Balance.HeaderText = "Balance"
        Me.Balance.Name = "Balance"
        Me.Balance.ReadOnly = True
        '
        'DisbursedAmount
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "-"
        Me.DisbursedAmount.DefaultCellStyle = DataGridViewCellStyle4
        Me.DisbursedAmount.HeaderText = "Disbursed Amount"
        Me.DisbursedAmount.Name = "DisbursedAmount"
        Me.DisbursedAmount.ReadOnly = True
        Me.DisbursedAmount.Visible = False
        '
        'ChequeNumber
        '
        Me.ChequeNumber.HeaderText = "Cheque Number"
        Me.ChequeNumber.Name = "ChequeNumber"
        Me.ChequeNumber.ReadOnly = True
        Me.ChequeNumber.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbo_Client)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(404, 29)
        Me.Panel1.TabIndex = 0
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
        Me.cbo_Client.TabIndex = 1
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
        'grp_ChequeDetails
        '
        Me.grp_ChequeDetails.Controls.Add(Me.TableLayoutPanel2)
        Me.grp_ChequeDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp_ChequeDetails.Location = New System.Drawing.Point(410, 0)
        Me.grp_ChequeDetails.Name = "grp_ChequeDetails"
        Me.grp_ChequeDetails.Size = New System.Drawing.Size(338, 86)
        Me.grp_ChequeDetails.TabIndex = 6
        Me.grp_ChequeDetails.TabStop = False
        Me.grp_ChequeDetails.Text = "Cheque Details"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txt_ChequeAmount, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Balance, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_ChequeNumber, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Disbursed, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_ReferenceNumber, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.06383!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.93617!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(332, 67)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'txt_ChequeAmount
        '
        Me.txt_ChequeAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ChequeAmount.Location = New System.Drawing.Point(96, 49)
        Me.txt_ChequeAmount.Name = "txt_ChequeAmount"
        Me.txt_ChequeAmount.ReadOnly = True
        Me.txt_ChequeAmount.Size = New System.Drawing.Size(82, 20)
        Me.txt_ChequeAmount.TabIndex = 12
        Me.txt_ChequeAmount.TabStop = False
        '
        'txt_Balance
        '
        Me.txt_Balance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Balance.Location = New System.Drawing.Point(247, 27)
        Me.txt_Balance.Name = "txt_Balance"
        Me.txt_Balance.ReadOnly = True
        Me.txt_Balance.Size = New System.Drawing.Size(82, 20)
        Me.txt_Balance.TabIndex = 11
        Me.txt_Balance.TabStop = False
        '
        'txt_ChequeNumber
        '
        Me.txt_ChequeNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ChequeNumber.Location = New System.Drawing.Point(96, 27)
        Me.txt_ChequeNumber.Name = "txt_ChequeNumber"
        Me.txt_ChequeNumber.ReadOnly = True
        Me.txt_ChequeNumber.Size = New System.Drawing.Size(82, 20)
        Me.txt_ChequeNumber.TabIndex = 10
        Me.txt_ChequeNumber.TabStop = False
        '
        'txt_Disbursed
        '
        Me.txt_Disbursed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Disbursed.Location = New System.Drawing.Point(247, 3)
        Me.txt_Disbursed.Name = "txt_Disbursed"
        Me.txt_Disbursed.ReadOnly = True
        Me.txt_Disbursed.Size = New System.Drawing.Size(82, 20)
        Me.txt_Disbursed.TabIndex = 9
        Me.txt_Disbursed.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(184, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 22)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Balance:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(184, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 24)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Disbursed:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cheque Amount:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cheque Number:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Reference No:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ReferenceNumber
        '
        Me.txt_ReferenceNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ReferenceNumber.Location = New System.Drawing.Point(96, 3)
        Me.txt_ReferenceNumber.Name = "txt_ReferenceNumber"
        Me.txt_ReferenceNumber.ReadOnly = True
        Me.txt_ReferenceNumber.Size = New System.Drawing.Size(82, 20)
        Me.txt_ReferenceNumber.TabIndex = 0
        Me.txt_ReferenceNumber.TabStop = False
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgv_Employee)
        Me.GroupBox3.Controls.Add(Me.grp_DisbursementEmployees)
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(410, 86)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(338, 305)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Employee"
        '
        'dgv_Employee
        '
        Me.dgv_Employee.AllowUserToAddRows = False
        Me.dgv_Employee.AllowUserToDeleteRows = False
        Me.dgv_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Employee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeNo, Me.EmployeeName, Me.Payment_Mode, Me.EmployeeDisbursedAmount, Me.DisbursedStatus, Me.ScheduleOfRelease, Me.CheckDetails, Me.On_ATM, Me.On_Cheque, Me.Bank_Name, Me.Bank_PayCard, Me.Bank_Account})
        Me.dgv_Employee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Employee.Location = New System.Drawing.Point(3, 47)
        Me.dgv_Employee.MultiSelect = False
        Me.dgv_Employee.Name = "dgv_Employee"
        Me.dgv_Employee.ReadOnly = True
        Me.dgv_Employee.RowHeadersVisible = False
        Me.dgv_Employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Employee.Size = New System.Drawing.Size(332, 255)
        Me.dgv_Employee.TabIndex = 1
        '
        'EmployeeNo
        '
        Me.EmployeeNo.HeaderText = "Employee No"
        Me.EmployeeNo.Name = "EmployeeNo"
        Me.EmployeeNo.ReadOnly = True
        '
        'EmployeeName
        '
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "-"
        Me.EmployeeDisbursedAmount.DefaultCellStyle = DataGridViewCellStyle5
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
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.ScheduleOfRelease.DefaultCellStyle = DataGridViewCellStyle6
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
        'On_ATM
        '
        Me.On_ATM.HeaderText = "On_ATM"
        Me.On_ATM.Name = "On_ATM"
        Me.On_ATM.ReadOnly = True
        Me.On_ATM.Visible = False
        '
        'On_Cheque
        '
        Me.On_Cheque.HeaderText = "On_Cheque"
        Me.On_Cheque.Name = "On_Cheque"
        Me.On_Cheque.ReadOnly = True
        Me.On_Cheque.Visible = False
        '
        'Bank_Name
        '
        Me.Bank_Name.HeaderText = "Bank_Name"
        Me.Bank_Name.Name = "Bank_Name"
        Me.Bank_Name.ReadOnly = True
        Me.Bank_Name.Visible = False
        '
        'Bank_PayCard
        '
        Me.Bank_PayCard.HeaderText = "Bank_PayCard"
        Me.Bank_PayCard.Name = "Bank_PayCard"
        Me.Bank_PayCard.ReadOnly = True
        Me.Bank_PayCard.Visible = False
        '
        'Bank_Account
        '
        Me.Bank_Account.HeaderText = "Bank_Account"
        Me.Bank_Account.Name = "Bank_Account"
        Me.Bank_Account.ReadOnly = True
        Me.Bank_Account.Visible = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.btn_Add, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btn_Edit, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btn_Remove, 2, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(332, 31)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'btn_Remove
        '
        Me.btn_Remove.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Remove.Location = New System.Drawing.Point(135, 3)
        Me.btn_Remove.Name = "btn_Remove"
        Me.btn_Remove.Size = New System.Drawing.Size(60, 25)
        Me.btn_Remove.TabIndex = 3
        Me.btn_Remove.Text = "&Remove"
        Me.btn_Remove.UseVisualStyleBackColor = True
        '
        'btn_Add
        '
        Me.btn_Add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Add.Location = New System.Drawing.Point(3, 3)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(60, 25)
        Me.btn_Add.TabIndex = 2
        Me.btn_Add.Text = "&Add"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'btn_Edit
        '
        Me.btn_Edit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Edit.Location = New System.Drawing.Point(69, 3)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(60, 25)
        Me.btn_Edit.TabIndex = 4
        Me.btn_Edit.Text = "&Edit"
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'frm_Disbursement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 422)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grp_ChequeDetails)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Disbursement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Disbursement"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_Advances, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grp_ChequeDetails.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.grp_DisbursementEmployees.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgv_Employee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_Advances As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbo_Client As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grp_ChequeDetails As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents txt_ChequeAmount As System.Windows.Forms.TextBox
    Friend WithEvents txt_Balance As System.Windows.Forms.TextBox
    Friend WithEvents txt_ChequeNumber As System.Windows.Forms.TextBox
    Friend WithEvents txt_Disbursed As System.Windows.Forms.TextBox
    Friend WithEvents txt_ReferenceNumber As System.Windows.Forms.TextBox
    Friend WithEvents grp_DisbursementEmployees As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txt_ChequeReferenceNumber As System.Windows.Forms.TextBox
    Friend WithEvents txt_CheckDetails As System.Windows.Forms.TextBox
    Friend WithEvents txt_Amount As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_EmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents dtp_ScheduleOfRelease As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbo_Status As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_Employee As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_Remove As System.Windows.Forms.Button
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents txt_EmployeeNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents EmployeeNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Payment_Mode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeDisbursedAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DisbursedStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ScheduleOfRelease As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckDetails As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents On_ATM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents On_Cheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bank_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bank_PayCard As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bank_Account As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Client As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Client_Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReferenceNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChequeAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Balance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DisbursedAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChequeNumber As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
