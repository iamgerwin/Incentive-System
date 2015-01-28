Public Class frm_Login

    Public Sub Login()
        Dim acct As New cls_Accounts
        Dim temp As Boolean = True
        Dim DS As New DataSet


        Try
            temp = acct.LoginUser(Me.txt_username.Text, Me.txt_password.Text)

            If temp = True Then
                'Me.lbl_message.Visible = True
                'Me.lbl_message.ForeColor = Color.Black
                'Me.lbl_message.Text = "Login Successful."
                DS = acct.GetAccountInfo(Me.txt_username.Text, Me.txt_password.Text)
                LoginUsername = Me.txt_username.Text
                LoginPassword = Me.txt_password.Text
                LoginFirstName = DS.Tables("tbl_Account").Rows(0).Item("FirstName")
                LoginMiddleName = DS.Tables("tbl_Account").Rows(0).Item("MiddleName")
                LoginLastName = DS.Tables("tbl_Account").Rows(0).Item("LastName")
                LoginPositionID = DS.Tables("tbl_Account").Rows(0).Item("PositionID")
                LoginUserID = DS.Tables("tbl_Account").Rows(0).Item("UserID")
                'logs.InsertLogs(Me.fullname, "Login", "Login")

                If DS.Tables("tbl_Account").Rows(0).Item("Access_Type") = 0 Then
                    'frm.MenuMaintenance.Visible = False
                End If

                Me.Hide()
                frm_MainMenu.ShowDialog()
            Else
                Me.lbl_message.Visible = True
                Me.lbl_message.ForeColor = Color.Red
                Me.lbl_message.Text = "Login Failed."
                Me.txt_username.Focus()
                Me.txt_username.SelectAll()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub btn_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exit.Click
        Application.Exit()
    End Sub

    Private Sub btn_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Login.Click
        Login()
    End Sub

    Private Sub frm_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lbl_message.Text = "Incentive System"
    End Sub
End Class