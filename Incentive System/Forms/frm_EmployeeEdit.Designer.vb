<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EmployeeEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_EmployeeEdit))
        Me.grp_DisbursementEmployees = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_EmploymentStatus = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtp_ScheduleOfRelease = New System.Windows.Forms.DateTimePicker
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.txt_ATMDetails = New System.Windows.Forms.TextBox
        Me.txt_CheckDetails = New System.Windows.Forms.TextBox
        Me.txt_EmployeeName = New System.Windows.Forms.TextBox
        Me.txt_EmployeeNo = New System.Windows.Forms.TextBox
        Me.txt_ChequeReferenceNumber = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt_Amount = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.rdo_Cheque = New System.Windows.Forms.RadioButton
        Me.rdo_ATM = New System.Windows.Forms.RadioButton
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.btn_Close = New System.Windows.Forms.Button
        Me.btn_Save = New System.Windows.Forms.Button
        Me.cbo_Status = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.grp_DisbursementEmployees.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_DisbursementEmployees
        '
        Me.grp_DisbursementEmployees.Controls.Add(Me.TableLayoutPanel3)
        Me.grp_DisbursementEmployees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_DisbursementEmployees.Location = New System.Drawing.Point(0, 0)
        Me.grp_DisbursementEmployees.Name = "grp_DisbursementEmployees"
        Me.grp_DisbursementEmployees.Size = New System.Drawing.Size(399, 331)
        Me.grp_DisbursementEmployees.TabIndex = 9
        Me.grp_DisbursementEmployees.TabStop = False
        Me.grp_DisbursementEmployees.Text = "Disbursement Of Employee"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_EmploymentStatus, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label15, 0, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.Label11, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.dtp_ScheduleOfRelease, 1, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 1, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_EmployeeName, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_EmployeeNo, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_ChequeReferenceNumber, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_Amount, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 1, 8)
        Me.TableLayoutPanel3.Controls.Add(Me.cbo_Status, 1, 9)
        Me.TableLayoutPanel3.Controls.Add(Me.Label17, 0, 9)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 10
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(393, 312)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Location = New System.Drawing.Point(61, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 29)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Payment:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Location = New System.Drawing.Point(12, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 24)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Employment Status:"
        '
        'txt_EmploymentStatus
        '
        Me.txt_EmploymentStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_EmploymentStatus.Enabled = False
        Me.txt_EmploymentStatus.Location = New System.Drawing.Point(118, 81)
        Me.txt_EmploymentStatus.Name = "txt_EmploymentStatus"
        Me.txt_EmploymentStatus.Size = New System.Drawing.Size(272, 20)
        Me.txt_EmploymentStatus.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label7.Location = New System.Drawing.Point(16, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 26)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Employee Number:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label15.Location = New System.Drawing.Point(3, 252)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 26)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Schedule of Release:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label11.Location = New System.Drawing.Point(70, 159)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 93)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Details:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label8.Location = New System.Drawing.Point(66, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 28)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Amount:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Location = New System.Drawing.Point(25, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 26)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Employee Name:"
        '
        'dtp_ScheduleOfRelease
        '
        Me.dtp_ScheduleOfRelease.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_ScheduleOfRelease.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ScheduleOfRelease.Location = New System.Drawing.Point(118, 255)
        Me.dtp_ScheduleOfRelease.Name = "dtp_ScheduleOfRelease"
        Me.dtp_ScheduleOfRelease.Size = New System.Drawing.Size(272, 20)
        Me.dtp_ScheduleOfRelease.TabIndex = 17
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txt_ATMDetails, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_CheckDetails, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(118, 162)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(272, 87)
        Me.TableLayoutPanel2.TabIndex = 22
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
        Me.txt_ATMDetails.Size = New System.Drawing.Size(130, 81)
        Me.txt_ATMDetails.TabIndex = 15
        '
        'txt_CheckDetails
        '
        Me.txt_CheckDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CheckDetails.Location = New System.Drawing.Point(139, 3)
        Me.txt_CheckDetails.Multiline = True
        Me.txt_CheckDetails.Name = "txt_CheckDetails"
        Me.txt_CheckDetails.Size = New System.Drawing.Size(130, 81)
        Me.txt_CheckDetails.TabIndex = 13
        '
        'txt_EmployeeName
        '
        Me.txt_EmployeeName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_EmployeeName.Location = New System.Drawing.Point(118, 55)
        Me.txt_EmployeeName.Name = "txt_EmployeeName"
        Me.txt_EmployeeName.ReadOnly = True
        Me.txt_EmployeeName.Size = New System.Drawing.Size(272, 20)
        Me.txt_EmployeeName.TabIndex = 11
        Me.txt_EmployeeName.TabStop = False
        '
        'txt_EmployeeNo
        '
        Me.txt_EmployeeNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_EmployeeNo.Location = New System.Drawing.Point(118, 29)
        Me.txt_EmployeeNo.Name = "txt_EmployeeNo"
        Me.txt_EmployeeNo.ReadOnly = True
        Me.txt_EmployeeNo.Size = New System.Drawing.Size(272, 20)
        Me.txt_EmployeeNo.TabIndex = 19
        Me.txt_EmployeeNo.TabStop = False
        '
        'txt_ChequeReferenceNumber
        '
        Me.txt_ChequeReferenceNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ChequeReferenceNumber.Location = New System.Drawing.Point(118, 3)
        Me.txt_ChequeReferenceNumber.Name = "txt_ChequeReferenceNumber"
        Me.txt_ChequeReferenceNumber.ReadOnly = True
        Me.txt_ChequeReferenceNumber.Size = New System.Drawing.Size(272, 20)
        Me.txt_ChequeReferenceNumber.TabIndex = 14
        Me.txt_ChequeReferenceNumber.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label13.Location = New System.Drawing.Point(8, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 26)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Check Reference #:"
        '
        'txt_Amount
        '
        Me.txt_Amount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Amount.Location = New System.Drawing.Point(118, 105)
        Me.txt_Amount.Name = "txt_Amount"
        Me.txt_Amount.Size = New System.Drawing.Size(272, 20)
        Me.txt_Amount.TabIndex = 12
        Me.txt_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.rdo_Cheque, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.rdo_ATM, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(118, 133)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(272, 23)
        Me.TableLayoutPanel4.TabIndex = 25
        '
        'rdo_Cheque
        '
        Me.rdo_Cheque.AutoSize = True
        Me.rdo_Cheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdo_Cheque.Location = New System.Drawing.Point(139, 3)
        Me.rdo_Cheque.Name = "rdo_Cheque"
        Me.rdo_Cheque.Size = New System.Drawing.Size(61, 17)
        Me.rdo_Cheque.TabIndex = 2
        Me.rdo_Cheque.Text = "Cheque"
        Me.rdo_Cheque.UseVisualStyleBackColor = True
        '
        'rdo_ATM
        '
        Me.rdo_ATM.AutoSize = True
        Me.rdo_ATM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdo_ATM.Location = New System.Drawing.Point(3, 3)
        Me.rdo_ATM.Name = "rdo_ATM"
        Me.rdo_ATM.Size = New System.Drawing.Size(47, 17)
        Me.rdo_ATM.TabIndex = 1
        Me.rdo_ATM.Text = "ATM"
        Me.rdo_ATM.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Close, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Save, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(118, 281)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(272, 30)
        Me.TableLayoutPanel1.TabIndex = 21
        '
        'btn_Close
        '
        Me.btn_Close.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.Location = New System.Drawing.Point(207, 3)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(62, 24)
        Me.btn_Close.TabIndex = 2
        Me.btn_Close.Text = "&Close"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Save.Location = New System.Drawing.Point(139, 3)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(62, 24)
        Me.btn_Save.TabIndex = 1
        Me.btn_Save.Text = "&Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'cbo_Status
        '
        Me.cbo_Status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo_Status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Status.Enabled = False
        Me.cbo_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_Status.FormattingEnabled = True
        Me.cbo_Status.Items.AddRange(New Object() {"Open", "Released"})
        Me.cbo_Status.Location = New System.Drawing.Point(118, 317)
        Me.cbo_Status.Name = "cbo_Status"
        Me.cbo_Status.Size = New System.Drawing.Size(272, 21)
        Me.cbo_Status.TabIndex = 18
        Me.cbo_Status.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 314)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Status:"
        '
        'frm_EmployeeEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 331)
        Me.Controls.Add(Me.grp_DisbursementEmployees)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_EmployeeEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit"
        Me.grp_DisbursementEmployees.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_EmploymentStatus As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rdo_ATM As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Cheque As System.Windows.Forms.RadioButton
    Friend WithEvents txt_ATMDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
