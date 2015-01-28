<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ARSchedulePerDateRange
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnExport = New System.Windows.Forms.Button
        Me.btnLoad = New System.Windows.Forms.Button
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.dgvAR = New System.Windows.Forms.DataGridView
        Me.client_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.invoice_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.reference_number = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.remarks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.receiving_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.due_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.days_lapsed = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.billing_amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vat_percentage = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vat_amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.billing_amount_with_vat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ewt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ewt_amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ar_amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(859, 80)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnExport)
        Me.GroupBox1.Controls.Add(Me.btnLoad)
        Me.GroupBox1.Controls.Add(Me.dtpDateFrom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(835, 59)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(585, 20)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dtpDateTo
        '
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateTo.Location = New System.Drawing.Point(311, 22)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(106, 21)
        Me.dtpDateTo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(252, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Date To:"
        '
        'btnExport
        '
        Me.btnExport.Enabled = False
        Me.btnExport.Location = New System.Drawing.Point(504, 20)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 3
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(423, 20)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateFrom.Location = New System.Drawing.Point(97, 22)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(106, 21)
        Me.dtpDateFrom.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date From:"
        '
        'dgvAR
        '
        Me.dgvAR.AllowUserToAddRows = False
        Me.dgvAR.AllowUserToDeleteRows = False
        Me.dgvAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.client_name, Me.invoice_date, Me.reference_number, Me.remarks, Me.receiving_date, Me.due_date, Me.days_lapsed, Me.billing_amount, Me.vat_percentage, Me.vat_amount, Me.billing_amount_with_vat, Me.ewt, Me.ewt_amount, Me.ar_amount})
        Me.dgvAR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAR.Location = New System.Drawing.Point(0, 80)
        Me.dgvAR.Name = "dgvAR"
        Me.dgvAR.ReadOnly = True
        Me.dgvAR.Size = New System.Drawing.Size(859, 329)
        Me.dgvAR.TabIndex = 11
        '
        'client_name
        '
        Me.client_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.client_name.HeaderText = "Client"
        Me.client_name.Name = "client_name"
        Me.client_name.ReadOnly = True
        Me.client_name.Width = 63
        '
        'invoice_date
        '
        Me.invoice_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.invoice_date.DefaultCellStyle = DataGridViewCellStyle1
        Me.invoice_date.HeaderText = "Invoice Date"
        Me.invoice_date.Name = "invoice_date"
        Me.invoice_date.ReadOnly = True
        Me.invoice_date.Width = 99
        '
        'reference_number
        '
        Me.reference_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.reference_number.DefaultCellStyle = DataGridViewCellStyle2
        Me.reference_number.HeaderText = "Ref #"
        Me.reference_number.Name = "reference_number"
        Me.reference_number.ReadOnly = True
        Me.reference_number.Width = 61
        '
        'remarks
        '
        Me.remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.remarks.HeaderText = "Remarks"
        Me.remarks.Name = "remarks"
        Me.remarks.ReadOnly = True
        Me.remarks.Width = 82
        '
        'receiving_date
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.receiving_date.DefaultCellStyle = DataGridViewCellStyle3
        Me.receiving_date.HeaderText = "Date Received"
        Me.receiving_date.Name = "receiving_date"
        Me.receiving_date.ReadOnly = True
        '
        'due_date
        '
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.due_date.DefaultCellStyle = DataGridViewCellStyle4
        Me.due_date.HeaderText = "Due Date"
        Me.due_date.Name = "due_date"
        Me.due_date.ReadOnly = True
        '
        'days_lapsed
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.days_lapsed.DefaultCellStyle = DataGridViewCellStyle5
        Me.days_lapsed.HeaderText = "Days Lapsed"
        Me.days_lapsed.Name = "days_lapsed"
        Me.days_lapsed.ReadOnly = True
        '
        'billing_amount
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.billing_amount.DefaultCellStyle = DataGridViewCellStyle6
        Me.billing_amount.HeaderText = "Billing Amount"
        Me.billing_amount.Name = "billing_amount"
        Me.billing_amount.ReadOnly = True
        '
        'vat_percentage
        '
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.vat_percentage.DefaultCellStyle = DataGridViewCellStyle7
        Me.vat_percentage.HeaderText = "vat_percent"
        Me.vat_percentage.Name = "vat_percentage"
        Me.vat_percentage.ReadOnly = True
        Me.vat_percentage.Visible = False
        '
        'vat_amount
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.vat_amount.DefaultCellStyle = DataGridViewCellStyle8
        Me.vat_amount.HeaderText = "VAT Amount"
        Me.vat_amount.Name = "vat_amount"
        Me.vat_amount.ReadOnly = True
        '
        'billing_amount_with_vat
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.billing_amount_with_vat.DefaultCellStyle = DataGridViewCellStyle9
        Me.billing_amount_with_vat.HeaderText = "Billing Amount w/VAT"
        Me.billing_amount_with_vat.Name = "billing_amount_with_vat"
        Me.billing_amount_with_vat.ReadOnly = True
        '
        'ewt
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.ewt.DefaultCellStyle = DataGridViewCellStyle10
        Me.ewt.HeaderText = "EWT(%)"
        Me.ewt.Name = "ewt"
        Me.ewt.ReadOnly = True
        '
        'ewt_amount
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.ewt_amount.DefaultCellStyle = DataGridViewCellStyle11
        Me.ewt_amount.HeaderText = "EWT Amount"
        Me.ewt_amount.Name = "ewt_amount"
        Me.ewt_amount.ReadOnly = True
        '
        'ar_amount
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.ar_amount.DefaultCellStyle = DataGridViewCellStyle12
        Me.ar_amount.HeaderText = "A/R Amount"
        Me.ar_amount.Name = "ar_amount"
        Me.ar_amount.ReadOnly = True
        '
        'frm_ARSchedulePerDateRange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 409)
        Me.Controls.Add(Me.dgvAR)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_ARSchedulePerDateRange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "A/R Schedule Per Date Range"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents dtpDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvAR As System.Windows.Forms.DataGridView
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents client_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents invoice_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents reference_number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents remarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents receiving_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents due_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents days_lapsed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents billing_amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vat_percentage As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vat_amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents billing_amount_with_vat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ewt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ewt_amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ar_amount As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
