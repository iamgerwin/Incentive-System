Public Class frm_UpdateClient

    Dim cl As New cls_Clients
    Dim is_vatable As Integer = 0
    Dim _is_flexible_vat As Integer = 0
    Public _client_code As String = Nothing

    Private Sub LoadData()
        Try
            Dim ds As New DataSet

            Me.txtClient.Text = Nothing
            Me.txtClientAddress.Text = Nothing
            Me.txtTermsDays.Text = 0
            Me.txtEWT.Text = 0

            Me.cl.client_code = Me._client_code
            ds = Me.cl.SearchClientCutOffByClientCode

            For i As Integer = 0 To ds.Tables("tbl_Client").Rows.Count - 1
                With ds.Tables("tbl_Client").Rows(i)
                    Me.txtClient.Text = .Item("client_name")
                    Me.txtClientAddress.Text = IIf(IsDBNull(.Item("client_address")) = True, Nothing, .Item("client_address"))

                    Try
                        If .Item("is_vatable") = 1 Then
                            Me.rbYesVatable.Checked = True
                        Else
                            Me.rbNoVatable.Checked = True
                        End If
                    Catch ex As Exception
                        Me.rbNoVatable.Checked = True
                    End Try

                    Me.txtTermsDays.Text = IIf(IsDBNull(.Item("terms_days")) = True, Nothing, .Item("terms_days"))
                    Me.txtEWT.Text = IIf(IsDBNull(.Item("ewt")) = True, Nothing, .Item("ewt"))


                    Try
                        If .Item("is_flexible_vat") = 1 Then
                            Me.rbYesFlexibleVAT.Checked = True
                        Else
                            Me.rbNoFlexibleVAT.Checked = True
                        End If
                    Catch ex As Exception
                        Me.rbNoFlexibleVAT.Checked = True
                    End Try

                End With
            Next

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frm_UpdateClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.LoadData()
            Me.txtClientAddress.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Try
            Dim check As Boolean = False

            If Me.txtClientAddress.Text = Nothing Then
                MsgBox("Address is required.", MsgBoxStyle.Critical)
                Me.txtClientAddress.Focus()
                Exit Sub
            End If

            If Me.rbYesVatable.Checked = False And Me.rbNoVatable.Checked = False Then
                MsgBox("Please choose if the client is vatable or not.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If Me.txtTermsDays.Text = 0 Or Me.txtTermsDays.Text = Nothing Then
                MsgBox("Terms is required.", MsgBoxStyle.Critical)
                Me.txtTermsDays.Focus()
                Exit Sub
            End If

            If Me.rbYesVatable.Checked = True And (Me.txtEWT.Text = 0 Or Me.txtEWT.Text = Nothing) Then
                MsgBox("EWT is required.", MsgBoxStyle.Critical)
                Me.txtEWT.Focus()
                Exit Sub
            End If

            If MessageBox.Show("Do you really want to save this information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                Me.cl.client_code = Me._client_code
                Me.cl.client_address = Trim(Me.txtClientAddress.Text)
                Me.cl.is_vatable = Me.is_vatable
                Me.cl.terms_days = CDec(Me.txtTermsDays.Text)
                Me.cl.ewt = CDec(Me.txtEWT.Text)
                Me.cl.is_flexible_vat = Me._is_flexible_vat
                check = Me.cl.UpdateClientBillingDetails

                If check = True Then
                    Me.cl.UpdateSyncClientBillingDetails()
                    MsgBox("Record saved.", MsgBoxStyle.Information)
                    Me.Close()
                Else
                    MsgBox("Error in saving.", MsgBoxStyle.Critical)
                    Me.txtClientAddress.Focus()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub txtTermsDays_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTermsDays.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEWT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEWT.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub rbYesVatable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbYesVatable.CheckedChanged
        If Me.rbYesVatable.Checked = True Then
            Me.is_vatable = 1
            Me.txtEWT.Enabled = True
        End If
    End Sub

    Private Sub rbNoVatable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNoVatable.CheckedChanged
        If Me.rbNoVatable.Checked = True Then
            Me.is_vatable = 0
            Me.txtEWT.Text = "0.00"
            Me.txtEWT.Enabled = False
        End If
    End Sub

    Private Sub txtTermsDays_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTermsDays.TextChanged
        If Me.txtTermsDays.Text = Nothing Then
            Me.txtTermsDays.Text = "0"
            Me.txtTermsDays.SelectAll()
            Me.txtTermsDays.Focus()
        End If
    End Sub

    Private Sub txtEWT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEWT.TextChanged
        If Me.txtEWT.Text = Nothing Or Me.txtEWT.Text = 0 Then
            Me.txtEWT.Text = "0.00"
            Me.txtEWT.SelectAll()
            Me.txtEWT.Focus()
        End If
    End Sub

    Private Sub rbYesFlexibleVAT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbYesFlexibleVAT.CheckedChanged
        If Me.rbYesFlexibleVAT.Checked = True Then
            Me._is_flexible_vat = 1
        End If
    End Sub

    Private Sub rbNoFlexibleVAT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNoFlexibleVAT.CheckedChanged
        If Me.rbNoFlexibleVAT.Checked = True Then
            Me._is_flexible_vat = 0
        End If
    End Sub
End Class