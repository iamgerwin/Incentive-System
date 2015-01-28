<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_UpdateClient
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
        Me.btn_Close = New System.Windows.Forms.Button
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.txtTermsDays = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtClient = New System.Windows.Forms.TextBox
        Me.txtClientAddress = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rbNoVatable = New System.Windows.Forms.RadioButton
        Me.rbYesVatable = New System.Windows.Forms.RadioButton
        Me.btn_Save = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtEWT = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rbNoFlexibleVAT = New System.Windows.Forms.RadioButton
        Me.rbYesFlexibleVAT = New System.Windows.Forms.RadioButton
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Close
        '
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.Location = New System.Drawing.Point(134, 214)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 26)
        Me.btn_Close.TabIndex = 6
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtTermsDays, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtClient, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtClientAddress, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.txtEWT, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_Save, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_Close, 2, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 2, 5)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76552!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.4138!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76552!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76552!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76552!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76199!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76211!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(343, 243)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'txtTermsDays
        '
        Me.txtTermsDays.Location = New System.Drawing.Point(134, 130)
        Me.txtTermsDays.Name = "txtTermsDays"
        Me.txtTermsDays.Size = New System.Drawing.Size(75, 21)
        Me.txtTermsDays.TabIndex = 3
        Me.txtTermsDays.Text = "0"
        Me.txtTermsDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(84, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Client:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Terms(days):"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Vatable:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 71)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client Address:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtClient
        '
        Me.txtClient.Location = New System.Drawing.Point(134, 3)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.ReadOnly = True
        Me.txtClient.Size = New System.Drawing.Size(179, 21)
        Me.txtClient.TabIndex = 0
        Me.txtClient.TabStop = False
        '
        'txtClientAddress
        '
        Me.txtClientAddress.Location = New System.Drawing.Point(134, 31)
        Me.txtClientAddress.Multiline = True
        Me.txtClientAddress.Name = "txtClientAddress"
        Me.txtClientAddress.Size = New System.Drawing.Size(179, 65)
        Me.txtClientAddress.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbNoVatable)
        Me.Panel1.Controls.Add(Me.rbYesVatable)
        Me.Panel1.Location = New System.Drawing.Point(134, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(179, 22)
        Me.Panel1.TabIndex = 0
        '
        'rbNoVatable
        '
        Me.rbNoVatable.AutoSize = True
        Me.rbNoVatable.Location = New System.Drawing.Point(61, 1)
        Me.rbNoVatable.Name = "rbNoVatable"
        Me.rbNoVatable.Size = New System.Drawing.Size(41, 19)
        Me.rbNoVatable.TabIndex = 1
        Me.rbNoVatable.TabStop = True
        Me.rbNoVatable.Text = "No"
        Me.rbNoVatable.UseVisualStyleBackColor = True
        '
        'rbYesVatable
        '
        Me.rbYesVatable.AutoSize = True
        Me.rbYesVatable.Location = New System.Drawing.Point(3, 1)
        Me.rbYesVatable.Name = "rbYesVatable"
        Me.rbYesVatable.Size = New System.Drawing.Size(45, 19)
        Me.rbYesVatable.TabIndex = 0
        Me.rbYesVatable.Text = "Yes"
        Me.rbYesVatable.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Save.Location = New System.Drawing.Point(30, 214)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 26)
        Me.btn_Save.TabIndex = 5
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Location = New System.Drawing.Point(73, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 28)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "EWT(%):"
        '
        'txtEWT
        '
        Me.txtEWT.Location = New System.Drawing.Point(134, 158)
        Me.txtEWT.Name = "txtEWT"
        Me.txtEWT.Size = New System.Drawing.Size(75, 21)
        Me.txtEWT.TabIndex = 4
        Me.txtEWT.Text = "0.00"
        Me.txtEWT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label6.Location = New System.Drawing.Point(54, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 28)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Flexible VAT"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbNoFlexibleVAT)
        Me.Panel2.Controls.Add(Me.rbYesFlexibleVAT)
        Me.Panel2.Location = New System.Drawing.Point(134, 186)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(179, 22)
        Me.Panel2.TabIndex = 9
        '
        'rbNoFlexibleVAT
        '
        Me.rbNoFlexibleVAT.AutoSize = True
        Me.rbNoFlexibleVAT.Location = New System.Drawing.Point(61, 1)
        Me.rbNoFlexibleVAT.Name = "rbNoFlexibleVAT"
        Me.rbNoFlexibleVAT.Size = New System.Drawing.Size(41, 19)
        Me.rbNoFlexibleVAT.TabIndex = 1
        Me.rbNoFlexibleVAT.TabStop = True
        Me.rbNoFlexibleVAT.Text = "No"
        Me.rbNoFlexibleVAT.UseVisualStyleBackColor = True
        '
        'rbYesFlexibleVAT
        '
        Me.rbYesFlexibleVAT.AutoSize = True
        Me.rbYesFlexibleVAT.Location = New System.Drawing.Point(3, 1)
        Me.rbYesFlexibleVAT.Name = "rbYesFlexibleVAT"
        Me.rbYesFlexibleVAT.Size = New System.Drawing.Size(45, 19)
        Me.rbYesFlexibleVAT.TabIndex = 0
        Me.rbYesFlexibleVAT.Text = "Yes"
        Me.rbYesFlexibleVAT.UseVisualStyleBackColor = True
        '
        'frm_UpdateClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 243)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_UpdateClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Client"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtTermsDays As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtClient As System.Windows.Forms.TextBox
    Friend WithEvents txtClientAddress As System.Windows.Forms.TextBox
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbNoVatable As System.Windows.Forms.RadioButton
    Friend WithEvents rbYesVatable As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEWT As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rbNoFlexibleVAT As System.Windows.Forms.RadioButton
    Friend WithEvents rbYesFlexibleVAT As System.Windows.Forms.RadioButton
End Class
