Public Class frm_Client

    Dim cl As New cls_Clients
    Dim arr_client_code As New ArrayList

    Private Sub PopulateDataGrid()
        Try
            Dim ds As New DataSet

            Me.dgvClients.Rows.Clear()

            ds = Me.cl.SearchClient(Me.txtSearch.Text)

            If ds.Tables("tbl_Client").Rows.Count = 0 Then
                MsgBox("Record not found.", MsgBoxStyle.Critical)
                Me.txtSearch.Focus()
                Me.DisableButtons()
                Exit Sub
            End If

            For i As Integer = 0 To ds.Tables("tbl_Client").Rows.Count - 1
                With ds.Tables("tbl_Client").Rows(i)
                    Me.dgvClients.Rows.Add()
                    Me.dgvClients.Rows(i).Cells("client_id").Value = .Item("client_id")
                    Me.dgvClients.Rows(i).Cells("client_code").Value = .Item("client_code")
                    Me.dgvClients.Rows(i).Cells("client_name").Value = .Item("client_name")

                    Try
                        If .Item("is_vatable") = 1 Then
                            Me.dgvClients.Rows(i).Cells("is_vatable").Value = "Yes"
                        Else
                            Me.dgvClients.Rows(i).Cells("is_vatable").Value = "No"
                        End If
                    Catch ex As Exception
                        Me.dgvClients.Rows(i).Cells("is_vatable").Value = "No"
                    End Try


                    Me.dgvClients.Rows(i).Cells("terms_days").Value = IIf(IsDBNull(.Item("terms_days")) = True, 0, .Item("terms_days"))
                    Me.dgvClients.Rows(i).Cells("ewt").Value = IIf(IsDBNull(.Item("ewt")) = True, 0, .Item("ewt"))


                    Try
                        If .Item("is_flexible_vat") = 1 Then
                            Me.dgvClients.Rows(i).Cells("is_flexible_vat").Value = "Yes"
                        Else
                            Me.dgvClients.Rows(i).Cells("is_flexible_vat").Value = "No"
                        End If
                    Catch ex As Exception
                        Me.dgvClients.Rows(i).Cells("is_flexible_vat").Value = "No"
                    End Try

                End With
            Next

            Me.txtSearch.SelectAll()
            Me.EnableButtons()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Me.PopulateDataGrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EnableButtons()
        Try
            Me.btnEdit.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DisableButtons()
        Try
            Me.btnEdit.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            Dim frm As New frm_UpdateClient
            frm._client_code = Me.dgvClients.CurrentRow.Cells("client_code").Value
            frm.ShowDialog()
            Me.PopulateDataGrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class