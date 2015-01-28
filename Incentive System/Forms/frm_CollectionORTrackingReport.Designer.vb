<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CollectionORTrackingReport
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtSeriesTo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSeriesFrom = New System.Windows.Forms.TextBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnExport = New System.Windows.Forms.Button
        Me.btnLoad = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgvOR = New System.Windows.Forms.DataGridView
        Me.or_number = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.or_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bank_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.check_number = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.client_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.particulars = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.amount_received = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvOR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(860, 80)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtSeriesTo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSeriesFrom)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnExport)
        Me.GroupBox1.Controls.Add(Me.btnLoad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(836, 59)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'txtSeriesTo
        '
        Me.txtSeriesTo.Location = New System.Drawing.Point(302, 24)
        Me.txtSeriesTo.Name = "txtSeriesTo"
        Me.txtSeriesTo.Size = New System.Drawing.Size(100, 20)
        Me.txtSeriesTo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Series To:"
        '
        'txtSeriesFrom
        '
        Me.txtSeriesFrom.Location = New System.Drawing.Point(94, 24)
        Me.txtSeriesFrom.Name = "txtSeriesFrom"
        Me.txtSeriesFrom.Size = New System.Drawing.Size(100, 20)
        Me.txtSeriesFrom.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(586, 22)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Enabled = False
        Me.btnExport.Location = New System.Drawing.Point(505, 22)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 3
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(424, 22)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Series From:"
        '
        'dgvOR
        '
        Me.dgvOR.AllowUserToAddRows = False
        Me.dgvOR.AllowUserToDeleteRows = False
        Me.dgvOR.AllowUserToResizeColumns = False
        Me.dgvOR.AllowUserToResizeRows = False
        Me.dgvOR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.or_number, Me.or_date, Me.bank_name, Me.check_number, Me.client_name, Me.particulars, Me.amount_received})
        Me.dgvOR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOR.Location = New System.Drawing.Point(0, 80)
        Me.dgvOR.MultiSelect = False
        Me.dgvOR.Name = "dgvOR"
        Me.dgvOR.ReadOnly = True
        Me.dgvOR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOR.Size = New System.Drawing.Size(860, 379)
        Me.dgvOR.TabIndex = 1
        '
        'or_number
        '
        Me.or_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.or_number.HeaderText = "O.R. Number"
        Me.or_number.Name = "or_number"
        Me.or_number.ReadOnly = True
        Me.or_number.Width = 104
        '
        'or_date
        '
        Me.or_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.or_date.DefaultCellStyle = DataGridViewCellStyle5
        Me.or_date.HeaderText = "Date"
        Me.or_date.Name = "or_date"
        Me.or_date.ReadOnly = True
        Me.or_date.Width = 58
        '
        'bank_name
        '
        Me.bank_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.bank_name.HeaderText = "Bank"
        Me.bank_name.Name = "bank_name"
        Me.bank_name.ReadOnly = True
        Me.bank_name.Width = 60
        '
        'check_number
        '
        Me.check_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.check_number.HeaderText = "Check Number"
        Me.check_number.Name = "check_number"
        Me.check_number.ReadOnly = True
        Me.check_number.Width = 114
        '
        'client_name
        '
        Me.client_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.client_name.HeaderText = "Client"
        Me.client_name.Name = "client_name"
        Me.client_name.ReadOnly = True
        Me.client_name.Width = 63
        '
        'particulars
        '
        Me.particulars.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.particulars.HeaderText = "Particulars"
        Me.particulars.Name = "particulars"
        Me.particulars.ReadOnly = True
        Me.particulars.Width = 90
        '
        'amount_received
        '
        Me.amount_received.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Format = "N2"
        Me.amount_received.DefaultCellStyle = DataGridViewCellStyle6
        Me.amount_received.HeaderText = "Amount"
        Me.amount_received.Name = "amount_received"
        Me.amount_received.ReadOnly = True
        Me.amount_received.Width = 74
        '
        'frm_CollectionORTrackingReport
        '
        Me.AcceptButton = Me.btnLoad
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 459)
        Me.Controls.Add(Me.dgvOR)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_CollectionORTrackingReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Collection OR Number Tracking"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvOR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSeriesTo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSeriesFrom As System.Windows.Forms.TextBox
    Friend WithEvents dgvOR As System.Windows.Forms.DataGridView
    Friend WithEvents or_number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents or_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bank_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents check_number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents client_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents particulars As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount_received As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
