Public Class frm_BankAdvice
    Dim CL_Bank As New cls_BankAdvice
    Dim CL_SysPara As New cls_SystemParameters
    Public ReferenceID As Integer
    Public Bank_Code As String
    Public Bank_Address As String
    Public Bank_Manager As String

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click

        If Me.Bank_Code = "ALLIEDLP" Then
            Try
                Dim frm As New frm_CrystalReportViewer
                Dim cr As New rpt_BankAdvice_Paycard




                Dim ds As New DataSet
                ds = CL_Bank.BankAdviceDisplay(ReferenceID, Bank_Code)


                CL_SysPara.GetSystemParameters()

                cr.SetDataSource(ds.Tables(0))
                cr.SetParameterValue("PreparedBy", UCase(mod_Login.LoginFirstName & " " & Strings.Left(mod_Login.LoginMiddleName, 1) & ". " & mod_Login.LoginLastName))
                cr.SetParameterValue("PreparedByPosition", mod_Login.LoginPositionID.ToString)
                cr.SetParameterValue("PayOutDate", CDate((Me.dtp_PayOutDate.Value)).ToString("MMMM dd, yyyy"))
                cr.SetParameterValue("Bank", Me.txt_Bank.Text)
                cr.SetParameterValue("BankAddress", Bank_Address)
                cr.SetParameterValue("BankManager", Bank_Manager)
                cr.SetParameterValue("CheckDate", CDate(Me.dtp_CheckDate.Value.Date).ToString("MMMM dd, yyyy"))
                cr.SetParameterValue("CheckNumber", Me.txt_CheckNumber.Text)
                cr.SetParameterValue("NotedBy", UCase(CL_SysPara.NotedBy))
                cr.SetParameterValue("NotedByPosition", CL_SysPara.NotedByPosition)
                cr.SetParameterValue("ApprovedBy", UCase(CL_SysPara.ApprovedBy))
                cr.SetParameterValue("ApprovedByPosition", CL_SysPara.ApprovedByPosition)

                frm.CrystalReportViewer1.ReportSource = cr
                frm.ShowDialog()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else

            Try
                Dim frm As New frm_CrystalReportViewer
                Dim cr As New rpt_BankAdvice_BankAccount





                Dim ds As New DataSet
                ds = CL_Bank.BankAdviceDisplay(ReferenceID, Bank_Code)


                CL_SysPara.GetSystemParameters()

                cr.SetDataSource(ds.Tables(0))
                cr.SetParameterValue("PreparedBy", UCase(mod_Login.LoginFirstName & " " & Strings.Left(mod_Login.LoginMiddleName, 1) & ". " & mod_Login.LoginLastName))
                cr.SetParameterValue("PreparedByPosition", mod_Login.LoginPositionID.ToString)
                cr.SetParameterValue("PayOutDate", CDate(Me.dtp_PayOutDate.Value).ToString("MMMM dd, yyyy"))
                cr.SetParameterValue("Bank", Me.txt_Bank.Text)
                cr.SetParameterValue("BankAddress", Bank_Address)
                cr.SetParameterValue("BankManager", Bank_Manager)
                cr.SetParameterValue("CheckDate", CDate(Me.dtp_CheckDate.Value.Date).ToString("MMMM dd, yyyy"))
                cr.SetParameterValue("CheckNumber", Me.txt_CheckNumber.Text)
                cr.SetParameterValue("NotedBy", UCase(CL_SysPara.NotedBy))
                cr.SetParameterValue("NotedByPosition", CL_SysPara.NotedByPosition)
                cr.SetParameterValue("ApprovedBy", UCase(CL_SysPara.ApprovedBy))
                cr.SetParameterValue("ApprovedByPosition", CL_SysPara.ApprovedByPosition)

                frm.CrystalReportViewer1.ReportSource = cr
                frm.ShowDialog()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub frm_BankAdvice_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frm_BankAdvice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class