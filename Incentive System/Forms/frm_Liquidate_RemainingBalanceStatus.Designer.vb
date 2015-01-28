<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Liquidate_RemainingBalanceStatus
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbo_RemainingBalanceStatus = New System.Windows.Forms.ComboBox
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.btn_Close = New System.Windows.Forms.Button
        Me.btn_Liquidate = New System.Windows.Forms.Button
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cbo_RemainingBalanceStatus, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(349, 28)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Remaining Balance Status:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbo_RemainingBalanceStatus
        '
        Me.cbo_RemainingBalanceStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo_RemainingBalanceStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_RemainingBalanceStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbo_RemainingBalanceStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_RemainingBalanceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_RemainingBalanceStatus.FormattingEnabled = True
        Me.cbo_RemainingBalanceStatus.Items.AddRange(New Object() {"Return to Client", "Release in Last Pay"})
        Me.cbo_RemainingBalanceStatus.Location = New System.Drawing.Point(177, 3)
        Me.cbo_RemainingBalanceStatus.Name = "cbo_RemainingBalanceStatus"
        Me.cbo_RemainingBalanceStatus.Size = New System.Drawing.Size(169, 21)
        Me.cbo_RemainingBalanceStatus.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btn_Close, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_Liquidate, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 28)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(349, 29)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'btn_Close
        '
        Me.btn_Close.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.Location = New System.Drawing.Point(176, 3)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(98, 23)
        Me.btn_Close.TabIndex = 9
        Me.btn_Close.Text = "&Cancel"
        Me.btn_Close.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'btn_Liquidate
        '
        Me.btn_Liquidate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Liquidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Liquidate.Location = New System.Drawing.Point(72, 3)
        Me.btn_Liquidate.Name = "btn_Liquidate"
        Me.btn_Liquidate.Size = New System.Drawing.Size(98, 23)
        Me.btn_Liquidate.TabIndex = 8
        Me.btn_Liquidate.Text = "&Liquidate"
        Me.btn_Liquidate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Liquidate.UseVisualStyleBackColor = True
        '
        'frm_Liquidate_RemainingBalanceStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 57)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_Liquidate_RemainingBalanceStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liquidate Remaining Balance Status"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_RemainingBalanceStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Liquidate As System.Windows.Forms.Button
    Friend WithEvents btn_Close As System.Windows.Forms.Button
End Class
