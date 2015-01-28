Public Class frm_EmployeeSearch
    Dim CL_Emp As New cls_Employee
    Dim CL_Dis As New cls_Disbursement
    Public ReferenceID As Integer = 0
    Public Sub LoadEmployee(ByVal Client_Code As String)
        Try
            Dim DSEmp As New DataSet
            DSEmp = CL_Emp.DisplayEmployeeByClientCode(Client_Code)

            Me.DataGridView1.Rows.Clear()

            For ctr As Integer = 0 To DSEmp.Tables(0).Rows.Count - 1
                With DSEmp.Tables(0).Rows(ctr)
                    Me.DataGridView1.Rows.Add()

                    Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("EmployeeNo").Value = .Item("EmployeeNo").ToString
                    Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("LastName").Value = .Item("EmpLastName").ToString
                    Me.DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells("FirstName").Value = .Item("EmpFirstName").ToString

                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub frm_EmployeeSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_LastName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_LastName.TextChanged
        Try
            Dim i As Integer

            For i = 0 To Me.DataGridView1.Rows.Count - 1
                If Me.DataGridView1.Rows(i).Cells("EmployeeNo").Value = "" Then


                Else
                    'Dim FullName As String = Me.DataGridView1.Rows(i).Cells("EmployeeName").Value.ToString
                    'Dim LastName As String = FullName.Substring(0, InStr(FullName, ",") - 1)
                    Dim LastName = Me.DataGridView1.Rows(i).Cells("LastName").Value
                    Dim SearchString As String = UCase(Me.txt_LastName.Text) + "*"

                    If UCase(LastName) Like SearchString Then
                        Me.DataGridView1.Rows(i).Visible = True
                    Else
                        Me.DataGridView1.Rows(i).Visible = False

                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    

    Private Sub btn_Select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Select.Click
        'For i As Integer = 0 To Me.DataGridView1.Rows.Count - 1
        '    Dim count As Integer = 0
        '    If Me.DataGridView1.Rows(i).Cells("CheckEmployee").Value = True Then
        '        For a As Integer = 0 To frm_Disbursement.dgv_Employee.Rows.Count - 1

        '            If Me.DataGridView1.Rows(i).Cells("EmployeeNo").Value = frm_Disbursement.dgv_Employee.Rows(a).Cells("EmployeeNo").Value Then
        '                count = count + 1

        '            End If
        '        Next
        '        If count = 0 Then
        '            frm_Disbursement.dgv_Employee.Rows.Add()
        '            frm_Disbursement.dgv_Employee.Rows(frm_Disbursement.dgv_Employee.Rows.Count - 1).Cells("EmployeeNo").Value = Me.DataGridView1.Rows(i).Cells("EmployeeNo").Value
        '            frm_Disbursement.dgv_Employee.Rows(frm_Disbursement.dgv_Employee.Rows.Count - 1).Cells("EmployeeName").Value = Me.DataGridView1.Rows(i).Cells("LastName").Value & "," & Me.DataGridView1.Rows(i).Cells("FirstName").Value
        '        End If
        '    End If
        'Next
        Try
            For i As Integer = 0 To Me.DataGridView1.Rows.Count - 1
                If Me.DataGridView1.Rows(i).Cells("CheckEmployee").Value = True Then
                    CL_Dis.Insert_Disbursement(Me.DataGridView1.Rows(i).Cells("EmployeeNo").Value, Me.ReferenceID)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub
End Class