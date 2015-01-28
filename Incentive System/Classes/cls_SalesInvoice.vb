Public Class cls_SalesInvoice

    Private _si_id As Integer
    Private _client As cls_Clients
    Private _is_sales_invoice As Integer
    Private _reference_number As String
    Private _invoice_date As Date
    Private _receiving_date As Date
    Private _collection_date As Date
    Private _due_date As Date
    Private _date_cancelled As Date
    Private _particulars As String
    Private _billing_amount As Decimal
    Private _vat As Decimal
    Private _vat_amount As Decimal
    Private _billing_amount_with_vat As Decimal
    Private _ewt As Decimal
    Private _ewt_amount As Decimal
    Private _ar_amount As Decimal
    Private _cut_off_from As Date
    Private _cut_off_to As Date
    Private _remarks As String
    Private _si_status As String
    Private _active As Integer = 0
    Private _details As cls_Details
    Private _or_number As String
    Private _or_date As Date
    Private _bank_name As String
    Private _check_number As String
    Private _amount_received As Decimal
    Dim con As New cls_Connection

    Public Sub New()
        Me._si_id = 0
        Me._client = New cls_Clients
        Me._is_sales_invoice = 0
        Me._reference_number = Nothing
        Me._invoice_date = Nothing
        Me._receiving_date = Nothing
        Me._collection_date = Nothing
        Me._due_date = Nothing
        Me._date_cancelled = Nothing
        Me._particulars = Nothing
        Me._billing_amount = 0
        Me._vat = 0
        Me._vat_amount = 0
        Me._billing_amount_with_vat = 0
        Me._ewt = 0
        Me._ewt_amount = 0
        Me._ar_amount = 0
        Me._cut_off_from = Nothing
        Me._cut_off_to = Nothing
        Me._remarks = Nothing
        Me._si_status = Nothing
        Me._active = 0
        Me._details = New cls_Details
        Me._or_number = Nothing
        Me._or_date = Nothing
        Me._bank_name = Nothing
        Me._check_number = Nothing
        Me._amount_received = 0
    End Sub

    Property si_id() As Integer
        Get
            Return Me._si_id
        End Get
        Set(ByVal value As Integer)
            Me._si_id = value
        End Set
    End Property

    Property client() As cls_Clients
        Get
            Return Me._client
        End Get
        Set(ByVal value As cls_Clients)
            Me._client = value
        End Set
    End Property

    Property is_sales_invoice() As Integer
        Get
            Return Me._is_sales_invoice
        End Get
        Set(ByVal value As Integer)
            Me._is_sales_invoice = value
        End Set
    End Property

    Property reference_number() As String
        Get
            Return Me._reference_number
        End Get
        Set(ByVal value As String)
            Me._reference_number = value
        End Set
    End Property

    Property invoice_date() As Date
        Get
            Return Me._invoice_date
        End Get
        Set(ByVal value As Date)
            Me._invoice_date = value
        End Set
    End Property

    Property receiving_date() As Date
        Get
            Return Me._receiving_date
        End Get
        Set(ByVal value As Date)
            Me._receiving_date = value
        End Set
    End Property

    Property collection_date() As Date
        Get
            Return Me._collection_date
        End Get
        Set(ByVal value As Date)
            Me._collection_date = value
        End Set
    End Property

    Property due_date() As Date
        Get
            Return Me._due_date
        End Get
        Set(ByVal value As Date)
            Me._due_date = value
        End Set
    End Property

    Property date_cancelled() As Date
        Get
            Return Me._date_cancelled
        End Get
        Set(ByVal value As Date)
            Me._date_cancelled = value
        End Set
    End Property

    Property particulars() As String
        Get
            Return Me._particulars
        End Get
        Set(ByVal value As String)
            Me._particulars = value
        End Set
    End Property

    Property billing_amount() As Decimal
        Get
            Return Me._billing_amount
        End Get
        Set(ByVal value As Decimal)
            Me._billing_amount = value
        End Set
    End Property

    Property vat() As Decimal
        Get
            Return Me._vat
        End Get
        Set(ByVal value As Decimal)
            Me._vat = value
        End Set
    End Property

    Property vat_amount() As Decimal
        Get
            Return Me._vat_amount
        End Get
        Set(ByVal value As Decimal)
            Me._vat_amount = value
        End Set
    End Property

    Property billing_amount_with_vat() As Decimal
        Get
            Return Me._billing_amount_with_vat
        End Get
        Set(ByVal value As Decimal)
            Me._billing_amount_with_vat = value
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

    Property ewt_amount() As Decimal
        Get
            Return Me._ewt_amount
        End Get
        Set(ByVal value As Decimal)
            Me._ewt_amount = value
        End Set
    End Property

    Property ar_amount() As Decimal
        Get
            Return Me._ar_amount
        End Get
        Set(ByVal value As Decimal)
            Me._ar_amount = value
        End Set
    End Property

    Property cut_off_from() As Date
        Get
            Return Me._cut_off_from
        End Get
        Set(ByVal value As Date)
            Me._cut_off_from = value
        End Set
    End Property

    Property cut_off_to() As Date
        Get
            Return Me._cut_off_to
        End Get
        Set(ByVal value As Date)
            Me._cut_off_to = value
        End Set
    End Property

    Property remarks() As String
        Get
            Return Me._remarks
        End Get
        Set(ByVal value As String)
            Me._remarks = value
        End Set
    End Property

    Property details() As cls_Details
        Get
            Return Me._details
        End Get
        Set(ByVal value As cls_Details)
            Me._details = value
        End Set
    End Property

    Property si_status() As String
        Get
            Return Me._si_status
        End Get
        Set(ByVal value As String)
            Me._si_status = value
        End Set
    End Property

    Property active() As Integer
        Get
            Return Me._active
        End Get
        Set(ByVal value As Integer)
            Me._active = value
        End Set
    End Property

    Property or_number() As String
        Get
            Return Me._or_number
        End Get
        Set(ByVal value As String)
            Me._or_number = value
        End Set
    End Property

    Property or_date() As Date
        Get
            Return Me._or_date
        End Get
        Set(ByVal value As Date)
            Me._or_date = value
        End Set
    End Property

    Property bank_name() As String
        Get
            Return Me._bank_name
        End Get
        Set(ByVal value As String)
            Me._bank_name = value
        End Set
    End Property

    Property check_number() As String
        Get
            Return Me._check_number
        End Get
        Set(ByVal value As String)
            Me._check_number = value
        End Set
    End Property

    Property amount_received() As Decimal
        Get
            Return Me._amount_received
        End Get
        Set(ByVal value As Decimal)
            Me._amount_received = value
        End Set
    End Property

    Public Function InsertSalesInvoice()
        Dim check As Boolean = False
        Dim retval As Integer = 0

        Try
            con.ConnectPayroll()
            con.cmd.CommandText = "EXEC proc_insert_sales_invoice '" & Me._client.client_code & "','" & Me._is_sales_invoice & "','" & Me._reference_number & "','" & Me._invoice_date & "','" & Me._particulars & "','" & Me._billing_amount & "','" & Me._vat & "','" & Me._vat_amount & "','" & Me._billing_amount_with_vat & "','" & Me._ewt & "','" & Me._ewt_amount & "','" & Me._ar_amount & "','" & Me._cut_off_from & "','" & Me._cut_off_to & "','" & Me._remarks & "','" & Me._details.created_by & "'"
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

    Public Function UpdateSalesInvoice()
        Dim check As Boolean = False
        Dim retval As Integer = 0

        Try
            con.ConnectPayroll()
            con.cmd.CommandText = "EXEC proc_update_sales_invoice '" & Me._si_id & "','" & Me._client.client_code & "','" & Me._is_sales_invoice & "','" & Me._reference_number & "','" & Me._invoice_date & "','" & Me._particulars & "','" & Me._billing_amount & "','" & Me._vat & "','" & Me._vat_amount & "','" & Me._billing_amount_with_vat & "','" & Me._ewt & "','" & Me._ewt_amount & "','" & Me._ar_amount & "','" & Me._cut_off_from & "','" & Me._cut_off_to & "','" & Me._remarks & "','" & Me._details.updated_by & "'"
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

    Public Function CancelSalesInvoice()
        Dim check As Boolean = False
        Dim retval As Integer = 0

        Try
            con.ConnectPayroll()
            con.cmd.CommandText = "EXEC proc_update_cancel_sales_invoice '" & Me._si_id & "','" & Me._details.updated_by & "'"
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

    Public Function MarkSalesInvoiceAsCollected()
        Dim check As Boolean = False
        Dim retval As Integer = 0

        Try
            con.ConnectPayroll()
            con.cmd.CommandText = "EXEC proc_update_mark_sales_invoice_as_collected '" & Me._si_id & "','" & Me._collection_date & "','" & Me._or_number & "','" & Me._or_date & "','" & Me._bank_name & "','" & Me._check_number & "','" & Me._amount_received & "','" & Me._details.updated_by & "'"
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

    Public Function MarkSalesInvoiceAsReceived()
        Dim check As Boolean = False
        Dim retval As Integer = 0

        Try
            con.ConnectPayroll()
            con.cmd.CommandText = "EXEC proc_update_mark_sales_invoice_as_received '" & Me._si_id & "','" & Me._details.updated_by & "','" & Me._receiving_date & "','" & Me._due_date & "'"
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

    Public Function SearchSalesInvoiceByClientCodeAndStatus(ByVal status As String)
        Dim con As New cls_Connection

        con.ConnectPayroll()

        Dim query As String = "EXEC proc_search_sales_invoice_by_client_code_and_status '" & Me._client.client_code & "','" & status & "'"
        Dim dscmd As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(query, con.ConString)
        Dim ds As New DataSet

        dscmd.Fill(ds, "vw_BillingSalesInvoices")
        con.ConString.Close()
        Return ds

    End Function

    Public Function SearchSalesInvoiceBySIId()
        Dim con As New cls_Connection

        con.ConnectPayroll()

        Dim query As String = "EXEC proc_search_sales_invoice_by_si_id '" & Me._si_id & "'"
        Dim dscmd As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(query, con.ConString)
        Dim ds As New DataSet

        dscmd.Fill(ds, "vw_BillingSalesInvoices")
        con.ConString.Close()
        Return ds

    End Function

    Public Function SearchSalesInvoiceByDate(ByVal run_date As Date)
        Dim con As New cls_Connection

        con.ConnectPayroll()

        Dim query As String = "EXEC proc_search_sales_invoice_by_date '" & run_date & "'"
        Dim dscmd As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(query, con.ConString)
        Dim ds As New DataSet

        dscmd.Fill(ds, "vw_BillingSalesInvoices")
        con.ConString.Close()
        Return ds

    End Function

    Public Function SearchSalesInvoiceByDateAging(ByVal run_date As Date)
        Dim con As New cls_Connection

        con.ConnectPayroll()

        Dim query As String = "EXEC proc_search_sales_invoice_by_date_aging '" & run_date & "'"
        Dim dscmd As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(query, con.ConString)
        Dim ds As New DataSet

        dscmd.Fill(ds, "vw_BillingSalesInvoices")
        con.ConString.Close()
        Return ds

    End Function

    Public Function SearchSalesInvoiceByDateRange(ByVal DateFrom As Date, ByVal DateTo As Date)
        Dim con As New cls_Connection

        con.ConnectPayroll()

        Dim query As String = "EXEC proc_search_sales_invoice_by_date_range '" & DateFrom & "','" & DateTo & "'"
        Dim dscmd As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(query, con.ConString)
        Dim ds As New DataSet

        dscmd.Fill(ds, "vw_BillingSalesInvoices")
        con.ConString.Close()
        Return ds

    End Function

    Public Function SearchSalesInvoicesByClientName(ByVal DateFrom As Date, ByVal DateTo As Date)
        Dim con As New cls_Connection

        con.ConnectPayroll()

        Dim query As String = "EXEC proc_search_sales_invoice_by_client_name '" & Me._si_status & "','" & DateFrom & "','" & DateTo & "'"
        Dim dscmd As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(query, con.ConString)
        Dim ds As New DataSet

        dscmd.Fill(ds, "vw_BillingSalesInvoices")
        con.ConString.Close()
        Return ds

    End Function

    Public Function DeleteSalesInvoice()
        Dim check As Boolean = False
        Dim retval As Integer = 0

        Try
            con.ConnectPayroll()
            con.cmd.CommandText = "EXEC proc_delete_sales_invoice '" & Me._si_id & "'"
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
