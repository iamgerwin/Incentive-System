Public Class frm_Liquidate
    Dim CL_Advances As New cls_Advances
    Dim CL_Client As New cls_Clients
    Dim CL_Liquidate As New cls_Liquidate
    Dim Arr_client As New ArrayList


    Private Sub CBOClientLoad()
        Try
            Dim DSClient As New DataSet
            DSClient = CL_Client.DisplayClients
            Me.Arr_Client.Clear()
            Me.cbo_Client.Items.Clear()

            Me.Arr_Client.Add("All")
            Me.cbo_Client.Items.Add("All")

            For ctr As Integer = 0 To DSClient.Tables("tbl_Client").Rows.Count - 1
                Me.cbo_Client.Items.Add(DSClient.Tables("tbl_Client").Rows(ctr).Item(1))
                Me.Arr_Client.Add(DSClient.Tables("tbl_Client").Rows(ctr).Item(0))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub LoadDataGrid()
        Try
            Dim ds As New DataSet

            ds = CL_Advances.Search_Advances_By_Client_Code(Me.Arr_Client(Me.cbo_Client.SelectedIndex))

            Me.DataGridView1.Rows.Clear()

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                With ds.Tables(0).Rows(i)
                    If .Item("Liquidated") = 0 Then
                        Me.DataGridView1.Rows.Add()
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("Client").Value = .Item("client_name")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("ReferenceNumber").Value = .Item("ReferenceNumber")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("ChequeNumber").Value = .Item("ChequeNumber")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("ChequeAmount").Value = .Item("ChequeAmount")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("DisbursedAmount").Value = .Item("DisbursedAmount")
                        Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("Balance").Value = .Item("Balance")
                    End If
                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frm_Liquidate_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frm_Liquidate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBOClientLoad()
        Me.cbo_Client.SelectedIndex = 0
    End Sub

    Private Sub cbo_Client_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_Client.SelectedIndexChanged
        LoadDataGrid()
    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub btn_Liquidate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Liquidate.Click
        Try
            Dim count As Integer

            count = CL_Advances.Check_Advances(Me.DataGridView1.SelectedRows(0).Cells("ReferenceNumber").Value)

            If count = 0 Then
                MessageBox.Show("No employee has been released in this item", "Liquidate", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Exit Sub
            Else
                frm_Liquidate_RemainingBalanceStatus.ShowDialog()
                LoadDataGrid()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class