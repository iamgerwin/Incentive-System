<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Advances_Insert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Advances_Insert))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.cbo_Bank = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btn_Save = New System.Windows.Forms.Button
        Me.btn_Close = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbl_Amount = New System.Windows.Forms.Label
        Me.lbl_Number = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_ReferenceNumber = New System.Windows.Forms.TextBox
        Me.cbo_Client = New System.Windows.Forms.ComboBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.rdo_BankDeposit = New System.Windows.Forms.RadioButton
        Me.rdo_Cheque = New System.Windows.Forms.RadioButton
        Me.dtp_DateDeposited = New System.Windows.Forms.DateTimePicker
        Me.txt_ChequeAmount = New System.Windows.Forms.TextBox
        Me.txt_ChequeNumber = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.cbo_Bank, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_Save, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_Close, 2, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_Amount, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_Number, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_ReferenceNumber, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cbo_Client, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.dtp_DateDeposited, 2, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_ChequeAmount, 2, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_ChequeNumber, 2, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(543, 226)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'cbo_Bank
        '
        Me.cbo_Bank.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo_Bank.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Bank.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbo_Bank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_Bank.FormattingEnabled = True
        Me.cbo_Bank.Location = New System.Drawing.Point(274, 59)
        Me.cbo_Bank.Name = "cbo_Bank"
        Me.cbo_Bank.Size = New System.Drawing.Size(211, 21)
        Me.cbo_Bank.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(226, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 28)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Bank:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(225, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 28)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Type:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(162, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 28)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Date Deposited:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Save
        '
        Me.btn_Save.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Save.Location = New System.Drawing.Point(193, 199)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 24)
        Me.btn_Save.TabIndex = 3
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Close
        '
        Me.btn_Close.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.Location = New System.Drawing.Point(274, 199)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 24)
        Me.btn_Close.TabIndex = 4
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(143, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Reference Number:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Amount
        '
        Me.lbl_Amount.AutoSize = True
        Me.lbl_Amount.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_Amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Amount.Location = New System.Drawing.Point(63, 140)
        Me.lbl_Amount.Name = "lbl_Amount"
        Me.lbl_Amount.Size = New System.Drawing.Size(205, 28)
        Me.lbl_Amount.TabIndex = 2
        Me.lbl_Amount.Text = "Cheque Amount/Deposit Amount:"
        Me.lbl_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Number
        '
        Me.lbl_Number.AutoSize = True
        Me.lbl_Number.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_Number.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Number.Location = New System.Drawing.Point(84, 112)
        Me.lbl_Number.Name = "lbl_Number"
        Me.lbl_Number.Size = New System.Drawing.Size(184, 28)
        Me.lbl_Number.TabIndex = 1
        Me.lbl_Number.Text = "Cheque Number/Deposit Info:"
        Me.lbl_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_ReferenceNumber
        '
        Me.txt_ReferenceNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ReferenceNumber.Location = New System.Drawing.Point(274, 3)
        Me.txt_ReferenceNumber.Name = "txt_ReferenceNumber"
        Me.txt_ReferenceNumber.ReadOnly = True
        Me.txt_ReferenceNumber.Size = New System.Drawing.Size(211, 20)
        Me.txt_ReferenceNumber.TabIndex = 0
        Me.txt_ReferenceNumber.TabStop = False
        Me.txt_ReferenceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbo_Client
        '
        Me.cbo_Client.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo_Client.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Client.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbo_Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_Client.FormattingEnabled = True
        Me.cbo_Client.Location = New System.Drawing.Point(274, 31)
        Me.cbo_Client.Name = "cbo_Client"
        Me.cbo_Client.Size = New System.Drawing.Size(211, 21)
        Me.cbo_Client.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.rdo_BankDeposit, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.rdo_Cheque, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(274, 87)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(211, 22)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'rdo_BankDeposit
        '
        Me.rdo_BankDeposit.AutoSize = True
        Me.rdo_BankDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdo_BankDeposit.Location = New System.Drawing.Point(108, 3)
        Me.rdo_BankDeposit.Name = "rdo_BankDeposit"
        Me.rdo_BankDeposit.Size = New System.Drawing.Size(88, 16)
        Me.rdo_BankDeposit.TabIndex = 1
        Me.rdo_BankDeposit.TabStop = True
        Me.rdo_BankDeposit.Text = "Bank Deposit"
        Me.rdo_BankDeposit.UseVisualStyleBackColor = True
        '
        'rdo_Cheque
        '
        Me.rdo_Cheque.AutoSize = True
        Me.rdo_Cheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdo_Cheque.Location = New System.Drawing.Point(3, 3)
        Me.rdo_Cheque.Name = "rdo_Cheque"
        Me.rdo_Cheque.Size = New System.Drawing.Size(61, 16)
        Me.rdo_Cheque.TabIndex = 0
        Me.rdo_Cheque.TabStop = True
        Me.rdo_Cheque.Text = "Cheque"
        Me.rdo_Cheque.UseVisualStyleBackColor = True
        '
        'dtp_DateDeposited
        '
        Me.dtp_DateDeposited.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtp_DateDeposited.Location = New System.Drawing.Point(274, 171)
        Me.dtp_DateDeposited.Name = "dtp_DateDeposited"
        Me.dtp_DateDeposited.Size = New System.Drawing.Size(211, 20)
        Me.dtp_DateDeposited.TabIndex = 7
        '
        'txt_ChequeAmount
        '
        Me.txt_ChequeAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ChequeAmount.Location = New System.Drawing.Point(274, 143)
        Me.txt_ChequeAmount.Name = "txt_ChequeAmount"
        Me.txt_ChequeAmount.Size = New System.Drawing.Size(211, 20)
        Me.txt_ChequeAmount.TabIndex = 2
        Me.txt_ChequeAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_ChequeNumber
        '
        Me.txt_ChequeNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ChequeNumber.Location = New System.Drawing.Point(274, 115)
        Me.txt_ChequeNumber.Name = "txt_ChequeNumber"
        Me.txt_ChequeNumber.Size = New System.Drawing.Size(211, 20)
        Me.txt_ChequeNumber.TabIndex = 1
        Me.txt_ChequeNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frm_Advances_Insert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 226)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Advances_Insert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advances"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_Amount As System.Windows.Forms.Label
    Friend WithEvents lbl_Number As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents txt_ChequeAmount As System.Windows.Forms.TextBox
    Friend WithEvents txt_ChequeNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_ReferenceNumber As System.Windows.Forms.TextBox
    Friend WithEvents cbo_Client As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rdo_BankDeposit As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Cheque As System.Windows.Forms.RadioButton
    Friend WithEvents dtp_DateDeposited As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbo_Bank As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
