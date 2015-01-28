<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ARScheduleAging
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
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnClose = New System.Windows.Forms.Button
        Me.dgvAR = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnExport = New System.Windows.Forms.Button
        Me.btnLoad = New System.Windows.Forms.Button
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.client_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.reference_number = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.particulars = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.period = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.billing_amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vat_amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ar_amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.due_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.aging = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.no_due_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.onetothirty_days = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.thirtyonetosixty_days = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sixtyonetoninety_days = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ninetyonetoonetwenty_days = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.onetwentyoneup_days = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(339, 20)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dgvAR
        '
        Me.dgvAR.AllowUserToAddRows = False
        Me.dgvAR.AllowUserToDeleteRows = False
        Me.dgvAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.client_name, Me.reference_number, Me.particulars, Me.period, Me.billing_amount, Me.vat_amount, Me.ar_amount, Me.due_date, Me.aging, Me.no_due_date, Me.onetothirty_days, Me.thirtyonetosixty_days, Me.sixtyonetoninety_days, Me.ninetyonetoonetwenty_days, Me.onetwentyoneup_days})
        Me.dgvAR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAR.Location = New System.Drawing.Point(0, 80)
        Me.dgvAR.Name = "dgvAR"
        Me.dgvAR.ReadOnly = True
        Me.dgvAR.Size = New System.Drawing.Size(709, 353)
        Me.dgvAR.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(709, 80)
        Me.Panel1.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnExport)
        Me.GroupBox1.Controls.Add(Me.btnLoad)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(685, 59)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'btnExport
        '
        Me.btnExport.Enabled = False
        Me.btnExport.Location = New System.Drawing.Point(258, 20)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 2
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(177, 20)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(65, 22)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(106, 21)
        Me.dtpDate.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date:"
        '
        'client_name
        '
        Me.client_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.client_name.HeaderText = "Client"
        Me.client_name.Name = "client_name"
        Me.client_name.ReadOnly = True
        Me.client_name.Width = 63
        '
        'reference_number
        '
        Me.reference_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.reference_number.HeaderText = "Ref #"
        Me.reference_number.Name = "reference_number"
        Me.reference_number.ReadOnly = True
        Me.reference_number.Width = 61
        '
        'particulars
        '
        Me.particulars.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.particulars.HeaderText = "Particulars"
        Me.particulars.Name = "particulars"
        Me.particulars.ReadOnly = True
        Me.particulars.Width = 90
        '
        'period
        '
        Me.period.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.period.HeaderText = "Period"
        Me.period.Name = "period"
        Me.period.ReadOnly = True
        Me.period.Width = 68
        '
        'billing_amount
        '
        Me.billing_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle34.Format = "N2"
        DataGridViewCellStyle34.NullValue = Nothing
        Me.billing_amount.DefaultCellStyle = DataGridViewCellStyle34
        Me.billing_amount.HeaderText = "Total Invoice Amt"
        Me.billing_amount.Name = "billing_amount"
        Me.billing_amount.ReadOnly = True
        Me.billing_amount.Width = 95
        '
        'vat_amount
        '
        Me.vat_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle35.Format = "N2"
        DataGridViewCellStyle35.NullValue = Nothing
        Me.vat_amount.DefaultCellStyle = DataGridViewCellStyle35
        Me.vat_amount.HeaderText = "Withholding Tax"
        Me.vat_amount.Name = "vat_amount"
        Me.vat_amount.ReadOnly = True
        Me.vat_amount.Width = 110
        '
        'ar_amount
        '
        Me.ar_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle36.Format = "N2"
        DataGridViewCellStyle36.NullValue = Nothing
        Me.ar_amount.DefaultCellStyle = DataGridViewCellStyle36
        Me.ar_amount.HeaderText = "Net Collectible"
        Me.ar_amount.Name = "ar_amount"
        Me.ar_amount.ReadOnly = True
        Me.ar_amount.Width = 102
        '
        'due_date
        '
        Me.due_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle37.Format = "d"
        DataGridViewCellStyle37.NullValue = Nothing
        Me.due_date.DefaultCellStyle = DataGridViewCellStyle37
        Me.due_date.HeaderText = "Due Date"
        Me.due_date.Name = "due_date"
        Me.due_date.ReadOnly = True
        Me.due_date.Width = 78
        '
        'aging
        '
        Me.aging.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle38.Format = "N0"
        DataGridViewCellStyle38.NullValue = Nothing
        Me.aging.DefaultCellStyle = DataGridViewCellStyle38
        Me.aging.HeaderText = "Aging"
        Me.aging.Name = "aging"
        Me.aging.ReadOnly = True
        Me.aging.Width = 63
        '
        'no_due_date
        '
        Me.no_due_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle39.Format = "N2"
        Me.no_due_date.DefaultCellStyle = DataGridViewCellStyle39
        Me.no_due_date.HeaderText = "Current"
        Me.no_due_date.Name = "no_due_date"
        Me.no_due_date.ReadOnly = True
        Me.no_due_date.Width = 72
        '
        'onetothirty_days
        '
        Me.onetothirty_days.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle40.Format = "N2"
        DataGridViewCellStyle40.NullValue = Nothing
        Me.onetothirty_days.DefaultCellStyle = DataGridViewCellStyle40
        Me.onetothirty_days.HeaderText = "1-30 days"
        Me.onetothirty_days.Name = "onetothirty_days"
        Me.onetothirty_days.ReadOnly = True
        Me.onetothirty_days.Width = 79
        '
        'thirtyonetosixty_days
        '
        Me.thirtyonetosixty_days.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle41.Format = "N2"
        DataGridViewCellStyle41.NullValue = Nothing
        Me.thirtyonetosixty_days.DefaultCellStyle = DataGridViewCellStyle41
        Me.thirtyonetosixty_days.HeaderText = "31-60 days"
        Me.thirtyonetosixty_days.Name = "thirtyonetosixty_days"
        Me.thirtyonetosixty_days.ReadOnly = True
        Me.thirtyonetosixty_days.Width = 85
        '
        'sixtyonetoninety_days
        '
        Me.sixtyonetoninety_days.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle42.Format = "N2"
        Me.sixtyonetoninety_days.DefaultCellStyle = DataGridViewCellStyle42
        Me.sixtyonetoninety_days.HeaderText = "61-90 days"
        Me.sixtyonetoninety_days.Name = "sixtyonetoninety_days"
        Me.sixtyonetoninety_days.ReadOnly = True
        Me.sixtyonetoninety_days.Width = 85
        '
        'ninetyonetoonetwenty_days
        '
        Me.ninetyonetoonetwenty_days.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle43.Format = "N2"
        Me.ninetyonetoonetwenty_days.DefaultCellStyle = DataGridViewCellStyle43
        Me.ninetyonetoonetwenty_days.HeaderText = "91-120 days"
        Me.ninetyonetoonetwenty_days.Name = "ninetyonetoonetwenty_days"
        Me.ninetyonetoonetwenty_days.ReadOnly = True
        Me.ninetyonetoonetwenty_days.Width = 91
        '
        'onetwentyoneup_days
        '
        Me.onetwentyoneup_days.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle44.Format = "N2"
        Me.onetwentyoneup_days.DefaultCellStyle = DataGridViewCellStyle44
        Me.onetwentyoneup_days.HeaderText = "121 up days"
        Me.onetwentyoneup_days.Name = "onetwentyoneup_days"
        Me.onetwentyoneup_days.ReadOnly = True
        Me.onetwentyoneup_days.Width = 90
        '
        'frm_ARScheduleAging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 433)
        Me.Controls.Add(Me.dgvAR)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(725, 471)
        Me.Name = "frm_ARScheduleAging"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AR Schedule Aging"
        CType(Me.dgvAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents dgvAR As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents client_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents reference_number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents particulars As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents period As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents billing_amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vat_amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ar_amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents due_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents aging As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents no_due_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents onetothirty_days As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents thirtyonetosixty_days As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sixtyonetoninety_days As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ninetyonetoonetwenty_days As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents onetwentyoneup_days As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
