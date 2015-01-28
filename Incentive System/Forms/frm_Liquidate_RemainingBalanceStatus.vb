Public Class frm_Liquidate_RemainingBalanceStatus
    Dim CL_Liquidate As New cls_Liquidate

    Private Sub frm_Liquidate_RemainingBalanceStatus_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frm_Liquidate_RemainingBalanceStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbo_RemainingBalanceStatus.SelectedIndex = 0
    End Sub

    Private Sub btn_Liquidate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Liquidate.Click
        Try
            If frm_Liquidate.DataGridView1.SelectedRows.Count > 0 Then
                If MessageBox.Show("Are you want to liquidate selected record?", "Liquidate", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    CL_Liquidate.Liquidate_Advances(frm_Liquidate.DataGridView1.SelectedRows(0).Cells("ReferenceNumber").Value, Me.cbo_RemainingBalanceStatus.Text)
                    MessageBox.Show("Record liquidated", "Liquidate", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    'LoadDataGrid()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub
End Class