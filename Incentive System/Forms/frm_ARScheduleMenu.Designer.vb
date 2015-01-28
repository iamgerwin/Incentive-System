<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ARScheduleMenu
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
        Me.btnARSchedule = New System.Windows.Forms.Button
        Me.btnARSchedulePerDateRange = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnARScheduleAging = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnARTrackingReport = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnARSchedule
        '
        Me.btnARSchedule.Location = New System.Drawing.Point(67, 31)
        Me.btnARSchedule.Name = "btnARSchedule"
        Me.btnARSchedule.Size = New System.Drawing.Size(270, 60)
        Me.btnARSchedule.TabIndex = 0
        Me.btnARSchedule.Text = "A/R Schedule Per Day(30 days forecast)"
        Me.btnARSchedule.UseVisualStyleBackColor = True
        '
        'btnARSchedulePerDateRange
        '
        Me.btnARSchedulePerDateRange.Location = New System.Drawing.Point(67, 97)
        Me.btnARSchedulePerDateRange.Name = "btnARSchedulePerDateRange"
        Me.btnARSchedulePerDateRange.Size = New System.Drawing.Size(270, 60)
        Me.btnARSchedulePerDateRange.TabIndex = 1
        Me.btnARSchedulePerDateRange.Text = "A/R Schedule(Date Range)"
        Me.btnARSchedulePerDateRange.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnARTrackingReport)
        Me.GroupBox1.Controls.Add(Me.btnARScheduleAging)
        Me.GroupBox1.Controls.Add(Me.btnARSchedulePerDateRange)
        Me.GroupBox1.Controls.Add(Me.btnARSchedule)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 303)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
        '
        'btnARScheduleAging
        '
        Me.btnARScheduleAging.Location = New System.Drawing.Point(67, 163)
        Me.btnARScheduleAging.Name = "btnARScheduleAging"
        Me.btnARScheduleAging.Size = New System.Drawing.Size(270, 60)
        Me.btnARScheduleAging.TabIndex = 2
        Me.btnARScheduleAging.Text = "A/R Schedule(Aging)"
        Me.btnARScheduleAging.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(343, 321)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnARTrackingReport
        '
        Me.btnARTrackingReport.Location = New System.Drawing.Point(67, 229)
        Me.btnARTrackingReport.Name = "btnARTrackingReport"
        Me.btnARTrackingReport.Size = New System.Drawing.Size(270, 60)
        Me.btnARTrackingReport.TabIndex = 3
        Me.btnARTrackingReport.Text = "A/R Tracking"
        Me.btnARTrackingReport.UseVisualStyleBackColor = True
        '
        'frm_ARScheduleMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(430, 354)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(446, 392)
        Me.MinimumSize = New System.Drawing.Size(446, 392)
        Me.Name = "frm_ARScheduleMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "A/R Schedule Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnARSchedule As System.Windows.Forms.Button
    Friend WithEvents btnARSchedulePerDateRange As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnARScheduleAging As System.Windows.Forms.Button
    Friend WithEvents btnARTrackingReport As System.Windows.Forms.Button
End Class
