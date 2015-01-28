<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SalesInvoices
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnCancelSI = New System.Windows.Forms.Button
        Me.btnMarkAsCollected = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbClient = New System.Windows.Forms.ComboBox
        Me.btnNew = New System.Windows.Forms.Button
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel
        Me.rbCancelled = New System.Windows.Forms.RadioButton
        Me.rbOpen = New System.Windows.Forms.RadioButton
        Me.rbAll = New System.Windows.Forms.RadioButton
        Me.rbCollected = New System.Windows.Forms.RadioButton
        Me.rbReceived = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnReceivedByClient = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dgvSalesInvoice = New System.Windows.Forms.DataGridView
        Me.si_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.reference_number = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.invoice_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.client_code = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.client_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cut_off_from = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cut_off_to = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.particulars = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.remarks = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ar_amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.amount_received = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.balance = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.receiving_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.collection_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.due_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.date_cancelled = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.si_status = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSalesInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btn_Close
        '
        Me.btn_Close.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.Location = New System.Drawing.Point(578, 3)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(74, 94)
        Me.btn_Close.TabIndex = 5
        Me.btn_Close.Text = "&Close"
        Me.btn_Close.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'btn_Delete
        '
        Me.btn_Delete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Delete.Location = New System.Drawing.Point(498, 3)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(74, 94)
        Me.btn_Delete.TabIndex = 4
        Me.btn_Delete.Text = "&Delete"
        Me.btn_Delete.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Delete.UseVisualStyleBackColor = True
        '
        'btn_Edit
        '
        Me.btn_Edit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Edit.Location = New System.Drawing.Point(418, 3)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(74, 94)
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
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 100)
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
        Me.cbo_Client.Location = New System.Drawing.Point(58, 3)
        Me.cbo_Client.Name = "cbo_Client"
        Me.cbo_Client.Size = New System.Drawing.Size(274, 21)
        Me.cbo_Client.TabIndex = 0
        '
        'btn_New
        '
        Me.btn_New.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_New.Location = New System.Drawing.Point(338, 3)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(74, 94)
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'rdo_All
        '
        Me.rdo_All.AutoSize = True
        Me.rdo_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdo_All.Location = New System.Drawing.Point(3, 3)
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
        Me.rdo_Liquidated.Location = New System.Drawing.Point(185, 3)
        Me.rdo_Liquidated.Name = "rdo_Liquidated"
        Me.rdo_Liquidated.Size = New System.Drawing.Size(82, 19)
        Me.rdo_Liquidated.TabIndex = 3
        Me.rdo_Liquidated.TabStop = True
        Me.rdo_Liquidated.Text = "&Liquidated"
        Me.rdo_Liquidated.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 7
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Button1, 5, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Button2, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Button3, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ComboBox1, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Button4, 2, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(578, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 94)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "&Close"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(498, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 94)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "&Delete"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(418, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 94)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "&Edit"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 100)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Client:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(58, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(274, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(338, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(74, 94)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "&New"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Controls.Add(Me.RadioButton1, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton1.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(35, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "&All"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton2.Location = New System.Drawing.Point(185, 3)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(73, 17)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "&Liquidated"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel5)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1065, 81)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 9
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.846261!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.38504!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.020163!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.020163!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.020163!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.19411!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.706018!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.09208!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.716007!))
        Me.TableLayoutPanel5.Controls.Add(Me.btnClose, 8, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnCancelSI, 6, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnMarkAsCollected, 7, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnDelete, 4, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnEdit, 3, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.cmbClient, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnNew, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.btnReceivedByClient, 5, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(1059, 61)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(1007, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(49, 28)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCancelSI
        '
        Me.btnCancelSI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancelSI.Enabled = False
        Me.btnCancelSI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelSI.Location = New System.Drawing.Point(798, 3)
        Me.btnCancelSI.Name = "btnCancelSI"
        Me.btnCancelSI.Size = New System.Drawing.Size(75, 28)
        Me.btnCancelSI.TabIndex = 4
        Me.btnCancelSI.Text = "C&ancel S.I"
        Me.btnCancelSI.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelSI.UseVisualStyleBackColor = True
        '
        'btnMarkAsCollected
        '
        Me.btnMarkAsCollected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMarkAsCollected.Enabled = False
        Me.btnMarkAsCollected.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarkAsCollected.Location = New System.Drawing.Point(879, 3)
        Me.btnMarkAsCollected.Name = "btnMarkAsCollected"
        Me.btnMarkAsCollected.Size = New System.Drawing.Size(122, 28)
        Me.btnMarkAsCollected.TabIndex = 5
        Me.btnMarkAsCollected.Text = "Mark as C&ollected"
        Me.btnMarkAsCollected.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMarkAsCollected.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDelete.Enabled = False
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(596, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(57, 28)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEdit.Enabled = False
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Location = New System.Drawing.Point(533, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(57, 28)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 34)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Client:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbClient
        '
        Me.cmbClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbClient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbClient.FormattingEnabled = True
        Me.cmbClient.Location = New System.Drawing.Point(96, 3)
        Me.cmbClient.Name = "cmbClient"
        Me.cmbClient.Size = New System.Drawing.Size(368, 23)
        Me.cmbClient.TabIndex = 0
        '
        'btnNew
        '
        Me.btnNew.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Location = New System.Drawing.Point(470, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(57, 28)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "&New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 5
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.20321!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.99561!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.11689!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.434!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.25029!))
        Me.TableLayoutPanel6.Controls.Add(Me.rbCancelled, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.rbOpen, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.rbAll, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.rbCollected, 4, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.rbReceived, 3, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(96, 37)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(368, 68)
        Me.TableLayoutPanel6.TabIndex = 6
        '
        'rbCancelled
        '
        Me.rbCancelled.AutoSize = True
        Me.rbCancelled.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbCancelled.Location = New System.Drawing.Point(113, 3)
        Me.rbCancelled.Name = "rbCancelled"
        Me.rbCancelled.Size = New System.Drawing.Size(79, 19)
        Me.rbCancelled.TabIndex = 2
        Me.rbCancelled.TabStop = True
        Me.rbCancelled.Text = "Cancelled"
        Me.rbCancelled.UseVisualStyleBackColor = True
        '
        'rbOpen
        '
        Me.rbOpen.AutoSize = True
        Me.rbOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbOpen.Location = New System.Drawing.Point(47, 3)
        Me.rbOpen.Name = "rbOpen"
        Me.rbOpen.Size = New System.Drawing.Size(54, 19)
        Me.rbOpen.TabIndex = 1
        Me.rbOpen.TabStop = True
        Me.rbOpen.Text = "O&pen"
        Me.rbOpen.UseVisualStyleBackColor = True
        '
        'rbAll
        '
        Me.rbAll.AutoSize = True
        Me.rbAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbAll.Location = New System.Drawing.Point(3, 3)
        Me.rbAll.Name = "rbAll"
        Me.rbAll.Size = New System.Drawing.Size(37, 19)
        Me.rbAll.TabIndex = 0
        Me.rbAll.TabStop = True
        Me.rbAll.Text = "A&ll"
        Me.rbAll.UseVisualStyleBackColor = True
        '
        'rbCollected
        '
        Me.rbCollected.AutoSize = True
        Me.rbCollected.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbCollected.Location = New System.Drawing.Point(290, 3)
        Me.rbCollected.Name = "rbCollected"
        Me.rbCollected.Size = New System.Drawing.Size(75, 19)
        Me.rbCollected.TabIndex = 4
        Me.rbCollected.TabStop = True
        Me.rbCollected.Text = "Collected"
        Me.rbCollected.UseVisualStyleBackColor = True
        '
        'rbReceived
        '
        Me.rbReceived.AutoSize = True
        Me.rbReceived.Location = New System.Drawing.Point(201, 3)
        Me.rbReceived.Name = "rbReceived"
        Me.rbReceived.Size = New System.Drawing.Size(76, 19)
        Me.rbReceived.TabIndex = 3
        Me.rbReceived.TabStop = True
        Me.rbReceived.Text = "Received"
        Me.rbReceived.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 74)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Status:"
        '
        'btnReceivedByClient
        '
        Me.btnReceivedByClient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReceivedByClient.Enabled = False
        Me.btnReceivedByClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReceivedByClient.Location = New System.Drawing.Point(659, 3)
        Me.btnReceivedByClient.Name = "btnReceivedByClient"
        Me.btnReceivedByClient.Size = New System.Drawing.Size(133, 28)
        Me.btnReceivedByClient.TabIndex = 6
        Me.btnReceivedByClient.Text = "Mark as &Received"
        Me.btnReceivedByClient.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReceivedByClient.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1087, 102)
        Me.Panel1.TabIndex = 0
        '
        'dgvSalesInvoice
        '
        Me.dgvSalesInvoice.AllowUserToAddRows = False
        Me.dgvSalesInvoice.AllowUserToDeleteRows = False
        Me.dgvSalesInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalesInvoice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.si_id, Me.reference_number, Me.invoice_date, Me.client_code, Me.client_name, Me.cut_off_from, Me.cut_off_to, Me.particulars, Me.remarks, Me.ar_amount, Me.amount_received, Me.balance, Me.receiving_date, Me.collection_date, Me.due_date, Me.date_cancelled, Me.si_status})
        Me.dgvSalesInvoice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSalesInvoice.Location = New System.Drawing.Point(0, 102)
        Me.dgvSalesInvoice.MultiSelect = False
        Me.dgvSalesInvoice.Name = "dgvSalesInvoice"
        Me.dgvSalesInvoice.ReadOnly = True
        Me.dgvSalesInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSalesInvoice.Size = New System.Drawing.Size(1087, 377)
        Me.dgvSalesInvoice.TabIndex = 1
        '
        'si_id
        '
        Me.si_id.HeaderText = "si_id"
        Me.si_id.Name = "si_id"
        Me.si_id.ReadOnly = True
        Me.si_id.Visible = False
        '
        'reference_number
        '
        Me.reference_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.reference_number.DefaultCellStyle = DataGridViewCellStyle1
        Me.reference_number.HeaderText = "Ref #"
        Me.reference_number.Name = "reference_number"
        Me.reference_number.ReadOnly = True
        Me.reference_number.Width = 61
        '
        'invoice_date
        '
        Me.invoice_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.invoice_date.DefaultCellStyle = DataGridViewCellStyle2
        Me.invoice_date.HeaderText = "Invoice Date"
        Me.invoice_date.Name = "invoice_date"
        Me.invoice_date.ReadOnly = True
        Me.invoice_date.Width = 99
        '
        'client_code
        '
        Me.client_code.HeaderText = "client_code"
        Me.client_code.Name = "client_code"
        Me.client_code.ReadOnly = True
        Me.client_code.Visible = False
        '
        'client_name
        '
        Me.client_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.client_name.HeaderText = "Client"
        Me.client_name.Name = "client_name"
        Me.client_name.ReadOnly = True
        Me.client_name.Width = 63
        '
        'cut_off_from
        '
        Me.cut_off_from.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.cut_off_from.DefaultCellStyle = DataGridViewCellStyle3
        Me.cut_off_from.HeaderText = "Cut-Off From"
        Me.cut_off_from.Name = "cut_off_from"
        Me.cut_off_from.ReadOnly = True
        Me.cut_off_from.Width = 101
        '
        'cut_off_to
        '
        Me.cut_off_to.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.cut_off_to.DefaultCellStyle = DataGridViewCellStyle4
        Me.cut_off_to.HeaderText = "Cut-Off To"
        Me.cut_off_to.Name = "cut_off_to"
        Me.cut_off_to.ReadOnly = True
        Me.cut_off_to.Width = 86
        '
        'particulars
        '
        Me.particulars.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.particulars.HeaderText = "Particulars"
        Me.particulars.Name = "particulars"
        Me.particulars.ReadOnly = True
        Me.particulars.Width = 90
        '
        'remarks
        '
        Me.remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.remarks.HeaderText = "Remarks"
        Me.remarks.Name = "remarks"
        Me.remarks.ReadOnly = True
        Me.remarks.Width = 82
        '
        'ar_amount
        '
        Me.ar_amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.ar_amount.DefaultCellStyle = DataGridViewCellStyle5
        Me.ar_amount.HeaderText = "A/R Amount"
        Me.ar_amount.Name = "ar_amount"
        Me.ar_amount.ReadOnly = True
        Me.ar_amount.Width = 96
        '
        'amount_received
        '
        Me.amount_received.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.amount_received.DefaultCellStyle = DataGridViewCellStyle6
        Me.amount_received.HeaderText = "Amount Received"
        Me.amount_received.Name = "amount_received"
        Me.amount_received.ReadOnly = True
        Me.amount_received.Width = 117
        '
        'balance
        '
        Me.balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.balance.DefaultCellStyle = DataGridViewCellStyle7
        Me.balance.HeaderText = "Balance"
        Me.balance.Name = "balance"
        Me.balance.ReadOnly = True
        Me.balance.Width = 77
        '
        'receiving_date
        '
        Me.receiving_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Format = "d"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.receiving_date.DefaultCellStyle = DataGridViewCellStyle8
        Me.receiving_date.HeaderText = "Receiving Date"
        Me.receiving_date.Name = "receiving_date"
        Me.receiving_date.ReadOnly = True
        Me.receiving_date.Width = 106
        '
        'collection_date
        '
        Me.collection_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle9.Format = "d"
        Me.collection_date.DefaultCellStyle = DataGridViewCellStyle9
        Me.collection_date.HeaderText = "Collection Date"
        Me.collection_date.Name = "collection_date"
        Me.collection_date.ReadOnly = True
        Me.collection_date.Width = 106
        '
        'due_date
        '
        Me.due_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle10.Format = "d"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.due_date.DefaultCellStyle = DataGridViewCellStyle10
        Me.due_date.HeaderText = "Due Date"
        Me.due_date.Name = "due_date"
        Me.due_date.ReadOnly = True
        Me.due_date.Width = 78
        '
        'date_cancelled
        '
        Me.date_cancelled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle11.Format = "d"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.date_cancelled.DefaultCellStyle = DataGridViewCellStyle11
        Me.date_cancelled.HeaderText = "Date Cancelled"
        Me.date_cancelled.Name = "date_cancelled"
        Me.date_cancelled.ReadOnly = True
        Me.date_cancelled.Width = 106
        '
        'si_status
        '
        Me.si_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.si_status.HeaderText = "Status"
        Me.si_status.Name = "si_status"
        Me.si_status.ReadOnly = True
        Me.si_status.Width = 66
        '
        'frm_SalesInvoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 479)
        Me.Controls.Add(Me.dgvSalesInvoice)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(1047, 517)
        Me.Name = "frm_SalesInvoices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Invoices"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvSalesInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents btn_Delete As System.Windows.Forms.Button
    Friend WithEvents btn_Edit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_Client As System.Windows.Forms.ComboBox
    Friend WithEvents btn_New As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rdo_All As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Liquidated As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbClient As System.Windows.Forms.ComboBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rbAll As System.Windows.Forms.RadioButton
    Friend WithEvents rbCancelled As System.Windows.Forms.RadioButton
    Friend WithEvents rbOpen As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnReceivedByClient As System.Windows.Forms.Button
    Friend WithEvents btnMarkAsCollected As System.Windows.Forms.Button
    Friend WithEvents btnCancelSI As System.Windows.Forms.Button
    Friend WithEvents rbCollected As System.Windows.Forms.RadioButton
    Friend WithEvents dgvSalesInvoice As System.Windows.Forms.DataGridView
    Friend WithEvents rbReceived As System.Windows.Forms.RadioButton
    Friend WithEvents si_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents reference_number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents invoice_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents client_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents client_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cut_off_from As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cut_off_to As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents particulars As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents remarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ar_amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount_received As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents balance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents receiving_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents collection_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents due_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_cancelled As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents si_status As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
