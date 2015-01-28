Public Class cls_Clients

    Private _client_id As Integer
    Private _client_name As String
    Private _client_code As String
    Private _working_days As Integer
    Private _cut_off_code As String
    Private _current_cut_off As Date
    Private _current_cut_off_first As Integer
    Private _current_cut_off_second As Integer
    'Private _bank As New Bank
    Private _consultant_tax_rate As Decimal
    Private _active As Integer = 0
    Private _client_address As String
    Private _is_vatable As Integer
    Private _terms_days As Integer
    Private _ewt As Decimal
    Private _is_flexible_vat As Integer
    Dim con As New cls_Connection

    Public Sub New()
        Me._client_id = 0
        Me._client_name = Nothing
        Me._client_code = Nothing
        Me._working_days = 0
        Me._cut_off_code = Nothing
        Me._current_cut_off = Nothing
        Me._current_cut_off_first = 0
        Me._current_cut_off_second = 0
        Me._consultant_tax_rate = 0
        'Me._include_in_group = 0
        'Me._night_diff_code = Nothing
        Me._active = 0
        Me._client_address = Nothing
        Me._is_vatable = 0
        Me._terms_days = 0
        Me._ewt = 0
        Me._is_flexible_vat = 0
    End Sub

    'Property bank() As Bank
    '    Get
    '        Return Me._bank
    '    End Get
    '    Set(ByVal value As Bank)
    '        Me._bank = value
    '    End Set
    'End Property
    Property client_id() As Integer
        Get
            Return Me._client_id
        End Get
        Set(ByVal value As Integer)
            Me._client_id = value
        End Set
    End Property
    Property working_days() As Integer
        Get
            Return Me._working_days
        End Get
        Set(ByVal value As Integer)
            Me._working_days = value
        End Set
    End Property

    Property client_code() As String
        Get
            Return Me._client_code
        End Get
        Set(ByVal value As String)
            Me._client_code = value
        End Set
    End Property

    Property client_name() As String
        Get
            Return Me._client_name
        End Get
        Set(ByVal value As String)
            Me._client_name = value
        End Set
    End Property
    Property cut_off_code() As String
        Get
            Return Me._cut_off_code
        End Get
        Set(ByVal value As String)
            Me._cut_off_code = value
        End Set
    End Property

    Property current_cut_off_first() As Integer
        Get
            Return Me._current_cut_off_first
        End Get
        Set(ByVal value As Integer)
            Me._current_cut_off_first = value
        End Set
    End Property

    Property current_cut_off_second() As Integer
        Get
            Return Me._current_cut_off_second
        End Get
        Set(ByVal value As Integer)
            Me._current_cut_off_second = value
        End Set
    End Property

    Property current_cut_off() As Date
        Get
            Return Me._current_cut_off
        End Get
        Set(ByVal value As Date)
            Me._current_cut_off = value
        End Set
    End Property

    Property consultant_tax_rate() As Decimal
        Get
            Return Me._consultant_tax_rate
        End Get
        Set(ByVal value As Decimal)
            Me._consultant_tax_rate = value
        End Set
    End Property

    'Property include_in_group() As Integer
    '    Get
    '        Return Me._include_in_group
    '    End Get
    '    Set(ByVal value As Integer)
    '        Me._include_in_group = value
    '    End Set
    'End Property

    'Property night_diff_code() As String
    '    Get
    '        Return Me._night_diff_code
    '    End Get
    '    Set(ByVal value As String)
    '        Me._night_diff_code = value
    '    End Set
    'End Property

    Property active() As Integer
        Get
            Return Me._active
        End Get
        Set(ByVal value As Integer)
            Me._active = value
        End Set
    End Property

    Property client_address() As String
        Get
            Return Me._client_address
        End Get
        Set(ByVal value As String)
            Me._client_address = value
        End Set
    End Property

    Property is_vatable() As Integer
        Get
            Return Me._is_vatable
        End Get
        Set(ByVal value As Integer)
            Me._is_vatable = value
        End Set
    End Property

    Property terms_days() As Integer
        Get
            Return Me._terms_days
        End Get
        Set(ByVal value As Integer)
            Me._terms_days = value
        End Set
    End Property

    Property ewt() As Decimal
        Get
            Return Me._ewt
        End Get
        Set(ByVal value As Decimal)
            Me._ewt = value
        End Set
    End Property

    Property is_flexible_vat() As Integer
        Get
            Return Me._is_flexible_vat
        End Get
        Set(ByVal value As Integer)
            Me._is_flexible_vat = value
        End Set
    End Property

    Public Function DisplayClients()
        Dim con As New cls_Connection

        Dim DS As New DataSet

        Try
            con.ConnectPayroll()
            Dim query As String = "EXEC proc_Client_CBO_Load"
            Dim dscmd As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(query, con.ConString)
            dscmd.Fill(DS, "tbl_Client")


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.ConString.Close()
            GC.Collect()
        End Try
        Return DS
    End Function

    Public Function SearchClient(ByVal search As String)
        Dim con As New cls_Connection

        con.ConnectHRIS2014()

        Dim query As String = "EXEC proc_search_client '" & search & "'"
        Dim dscmd As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(query, con.ConString)
        Dim ds As New DataSet

        dscmd.Fill(ds, "tbl_Client")
        con.ConString.Close()
        Return ds

    End Function

    Public Function SearchClientCutOffByClientCode()
        Dim con As New cls_Connection

        con.ConnectHRIS2014()

        Dim query As String = "EXEC proc_search_client_cut_off_by_client_code '" & Me._client_code & "'"
        Dim dscmd As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(query, con.ConString)
        Dim ds As New DataSet

        dscmd.Fill(ds, "tbl_Client")
        con.ConString.Close()
        Return ds

    End Function

    Public Function UpdateClientBillingDetails()
        Dim check As Boolean = False
        Dim retval As Integer = 0

        Try
            con.ConnectPayroll()
            con.cmd.CommandText = "EXEC proc_update_client_billing_details '" & Me._client_code & "','" & Me._client_address & "','" & Me._is_vatable & "','" & Me._terms_days & "','" & Me._ewt & "','" & Me._is_flexible_vat & "'"
            retval = con.cmd.ExecuteNonQuery

            If retval > 0 Then
                check = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            con.ConString.Close()
        Finally
            con.ConString.Close()
        End Try
        Return check
    End Function

    Public Function UpdateSyncClientBillingDetails()
        Dim check As Boolean = False
        Dim retval As Integer = 0

        Try
            con.ConnectPayroll()
            con.cmd.CommandText = "EXEC proc_update_sync_client_billing_details '" & Me._client_code & "','" & Me._client_address & "','" & Me._is_vatable & "','" & Me._terms_days & "','" & Me._ewt & "','" & Me._is_flexible_vat & "'"
            retval = con.cmd.ExecuteNonQuery

            If retval > 0 Then
                check = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            con.ConString.Close()
        Finally
            con.ConString.Close()
        End Try
        Return check
    End Function


End Class
