Public Class graffiti
    Private nombre As String
    Private diseño As String
    Private id_graffiti As Integer

    Public Property _nombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property _diseño As String
        Get
            Return diseño
        End Get
        Set(value As String)
            diseño = value
        End Set
    End Property

    Public Property _id_graffiti As Integer
        Get
            Return id_graffiti
        End Get
        Set(value As Integer)
            id_graffiti = value
        End Set
    End Property

    Public Sub graffiti(_nombre As String, _diseño As String, _id_graffiti As Integer)
        _nombre = nombre
        _diseño = diseño
        _id_graffiti = id_graffiti
    End Sub
End Class
