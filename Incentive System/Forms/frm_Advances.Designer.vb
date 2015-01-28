<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Advances
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Advances))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.btn_Close = New System.Windows.Forms.Button
        Me.btn_Delete = New System.Windows.Forms.Button
        Me.btn_Edit = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbo_Client = New System.Windows.Forms.ComboBox
        Me.btn_New = New System.Windows.Forms.Button
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.rdo_All = New System.Windows.Forms.RadioButton
        Me.rdo_Liquidated = New System.Windows.Forms.RadioButton
        Me.rdo_Open = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Client = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReferenceNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChequeNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChequeAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DisbursedAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Balance = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Liquidated = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RemainingBalanceStatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bank_code = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Date_Deposited = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.isCheque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.isDeposited = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(748, 81)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Close, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Delete, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Edit, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cbo_Client, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_New, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(742, 61)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btn_Close
        '
        Me.btn_Close.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.Location = New System.Drawing.Point(583, 3)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(74, 28)
        Me.btn_Close.TabIndex = 5
        Me.btn_Close.Text = "&Close"
        Me.btn_Close.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'btn_Delete
        '
        Me.btn_Delete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Delete.Location = New System.Drawing.Point(503, 3)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(74, 28)
        Me.btn_Delete.TabIndex = 4
        Me.btn_Delete.Text = "&Delete"
        Me.btn_Delete.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Delete.UseVisualStyleBackColor = True
        '
        'btn_Edit
        '
        Me.btn_Edit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Edit.Location = New System.Drawing.Point(423, 3)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(74, 28)
        Me.btn_Edit.TabIndex = 3
        Me.btn_Edit.Text = "&Edit"
        Me.btn_Edit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Edit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbo_Client
        '
        Me.cbo_Client.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo_Client.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Client.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbo_Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_Client.FormattingEnabled = True
        Me.cbo_Client.Location = New System.Drawing.Point(63, 3)
        Me.cbo_Client.Name = "cbo_Client"
        Me.cbo_Client.Size = New System.Drawing.Size(274, 23)
        Me.cbo_Client.TabIndex = 0
        '
        'btn_New
        '
        Me.btn_New.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_New.Location = New System.Drawing.Point(343, 3)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(74, 28)
        Me.btn_New.TabIndex = 2
        Me.btn_New.Text = "&New"
        Me.btn_New.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.rdo_All, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.rdo_Liquidated, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.rdo_Open, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(63, 37)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(274, 68)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'rdo_All
        '
        Me.rdo_All.AutoSize = True
        Me.rdo_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdo_All.Location = New System.Drawing.Point(3, 3)
        Me.rdo_All.Name = "rdo_All"
        Me.rdo_All.Size = New System.Drawing.Size(37, 19)
        Me.rdo_All.TabIndex = 1
        Me.rdo_All.TabStop = True
        Me.rdo_All.Text = "&All"
        Me.rdo_All.UseVisualStyleBackColor = True
        '
        'rdo_Liquidated
        '
        Me.rdo_Liquidated.AutoSize = True
        Me.rdo_Liquidated.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdo_Liquidated.Location = New System.Drawing.Point(185, 3)
        Me.rdo_Liquidated.Name = "rdo_Liquidated"
        Me.rdo_Liquidated.Size = New System.Drawing.Size(82, 19)
        Me.rdo_Liquidated.TabIndex = 3
        Me.rdo_Liquidated.TabStop = True
        Me.rdo_Liquidated.Text = "&Liquidated"
        Me.rdo_Liquidated.UseVisualStyleBackColor = True
        '
        'rdo_Open
        '
        Me.rdo_Open.AutoSize = True
        Me.rdo_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdo_Open.Location = New System.Drawing.Point(94, 3)
        Me.rdo_Open.Name = "rdo_Open"
        Me.rdo_Open.Size = New System.Drawing.Size(54, 19)
        Me.rdo_Open.TabIndex = 2
        Me.rdo_Open.TabStop = True
        Me.rdo_Open.Text = "&Open"
        Me.rdo_Open.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Status:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Client, Me.ReferenceNumber, Me.ChequeNumber, Me.ChequeAmount, Me.DisbursedAmount, Me.Balance, Me.Liquidated, Me.RemainingBalanceStatus, Me.bank_code, Me.Date_Deposited, Me.isCheque, Me.isDeposited})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 81)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(748, 312)
        Me.DataGridView1.TabIndex = 1
        '
        'Client
        '
        Me.Client.HeaderText = "Client"
        Me.Client.Name = "Client"
        Me.Client.ReadOnly = True
        '
        'ReferenceNumber
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ReferenceNumber.DefaultCellStyle = DataGridViewCellStyle1
        Me.ReferenceNumber.HeaderText = "Reference Number"
        Me.ReferenceNumber.Name = "ReferenceNumber"
        Me.ReferenceNumber.ReadOnly = True
        '
        'ChequeNumber
        '
        Me.ChequeNumber.HeaderText = "Cheque Number"
        Me.ChequeNumber.Name = "ChequeNumber"
        Me.ChequeNumber.ReadOnly = True
        '
        'ChequeAmount
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "n2"
        DataGridViewCellStyle2.NullValue = "-"
        Me.ChequeAmount.DefaultCellStyle = DataGridViewCellStyle2
        Me.ChequeAmount.HeaderText = "Cheque Amount"
        Me.ChequeAmount.Name = "ChequeAmount"
        Me.ChequeAmount.ReadOnly = True
        '
        'DisbursedAmount
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "n2"
        DataGridViewCellStyle3.NullValue = "-"
        Me.DisbursedAmount.DefaultCellStyle = DataGridViewCellStyle3
        Me.DisbursedAmount.HeaderText = "Disbursed Amount"
        Me.DisbursedAmount.Name = "DisbursedAmount"
        Me.DisbursedAmount.ReadOnly = True
        '
        'Balance
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "n2"
        DataGridViewCellStyle4.NullValue = "-"
        Me.Balance.DefaultCellStyle = DataGridViewCellStyle4
        Me.Balance.HeaderText = "Balance"
        Me.Balance.Name = "Balance"
        Me.Balance.ReadOnly = True
        '
        'Liquidated
        '
        Me.Liquidated.HeaderText = "Liquidated"
        Me.Liquidated.Name = "Liquidated"
        Me.Liquidated.ReadOnly = True
        Me.Liquidated.Visible = False
        '
        'RemainingBalanceStatus
        '
        Me.RemainingBalanceStatus.HeaderText = "Remaining Balance to be"
        Me.RemainingBalanceStatus.Name = "RemainingBalanceStatus"
        Me.RemainingBalanceStatus.ReadOnly = True
        '
        'bank_code
        '
        Me.bank_code.HeaderText = "bank_code"
        Me.bank_code.Name = "bank_code"
        Me.bank_code.ReadOnly = True
        Me.bank_code.Visible = False
        '
        'Date_Deposited
        '
        Me.Date_Deposited.HeaderText = "Date_Deposited"
        Me.Date_Deposited.Name = "Date_Deposited"
        Me.Date_Deposited.ReadOnly = True
        Me.Date_Deposited.Visible = False
        '
        'isCheque
        '
        Me.isCheque.HeaderText = "isCheque"
        Me.isCheque.Name = "isCheque"
        Me.isCheque.ReadOnly = True
        Me.isCheque.Visible = False
        '
        'isDeposited
        '
        Me.isDeposited.HeaderText = "isDeposited"
        Me.isDeposited.Name = "isDeposited"
        Me.isDeposited.ReadOnly = True
        Me.isDeposited.Visible = False
        '
        'frm_Advances
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 393)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Advances"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advances"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents btn_Delete As System.Windows.Forms.Button
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents cbo_Client As System.Windows.Forms.ComboBox
    Friend WithEvents btn_New As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rdo_Liquidated As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Open As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_All As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Client As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReferenceNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChequeNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChequeAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DisbursedAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Balance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Liquidated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemainingBalanceStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bank_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Date_Deposited As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents isCheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents isDeposited As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
