Public Class cls_Bank

    Private _bank_id As Integer
    Private _bank_code As String
    Private _bank_name As String
    Private _bank_manager As String
    Private _bank_address As String
    Private _active As Integer = 0
    Dim con As New cls_Connection

    Public Sub New()
        Me._bank_id = 0
        Me._bank_code = Nothing
        Me._bank_name = Nothing
        Me._bank_manager = Nothing
        Me._bank_address = Nothing
        Me._active = 0
    End Sub

    Property bank_id() As Integer
        Get
            Return Me._bank_id
        End Get
        Set(ByVal value As Integer)
            Me._bank_id = value
        End Set
    End Property

    Property bank_code() As String
        Get
            Return Me._bank_code
        End Get
        Set(ByVal value As String)
            Me._bank_code = value
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

    Property bank_manager() As String
        Get
            Return Me._bank_manager
        End Get
        Set(ByVal value As String)
            Me._bank_manager = value
        End Set
    End Property

    Property bank_address() As String
        Get
            Return Me._bank_address
        End Get
        Set(ByVal value As String)
            Me._bank_address = value
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

    Public Function SearchBank(ByVal search As String)
        Dim con As New cls_Connection

        con.ConnectHRIS2014()
        Dim query As String = "EXEC proc_search_bank '" & search & "'"
        Dim dscmd As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(query, con.ConString)
        Dim ds As New DataSet

        dscmd.Fill(ds, "tbl_Bank")
        con.ConString.Close()
        Return ds

    End Function
End Class
