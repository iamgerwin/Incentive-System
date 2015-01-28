Public Class cls_Details

    Private _date_created As Date
    Private _created_by As String
    Private _updated_by As String
    Private _last_update As Date

    Public Sub New()
        Me._date_created = Nothing
        Me._created_by = Nothing
        Me._updated_by = Nothing
        Me._last_update = Nothing
    End Sub

    Property date_created() As Date
        Get
            Return Me._date_created
        End Get
        Set(ByVal value As Date)
            Me._date_created = value
        End Set
    End Property

    Property created_by() As String
        Get
            Return Me._created_by
        End Get
        Set(ByVal value As String)
            Me._created_by = value
        End Set
    End Property

    Property updated_by() As String
        Get
            Return Me._updated_by
        End Get
        Set(ByVal value As String)
            Me._updated_by = value
        End Set
    End Property

    Property last_update() As Date
        Get
            Return Me._last_update
        End Get
        Set(ByVal value As Date)
            Me._last_update = value
        End Set
    End Property


End Class
