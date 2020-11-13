Public Class artista
    Private correo_electronico_artista As String
    Private nombre_artistico As String
    Private username As String
    Private password As Integer

    Public Property _username As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property _password As Integer
        Get
            Return password
        End Get
        Set(value As Integer)
            password = value
        End Set
    End Property
    Public Property _nombre_artistico As String
        Get
            Return nombre_artistico
        End Get
        Set(value As String)
            nombre_artistico = value
        End Set
    End Property
    Public Property _correo_electronico_artista As String
        Get
            Return correo_electronico_artista
        End Get
        Set(value As String)
            correo_electronico_artista = value
        End Set
    End Property
    Public Sub artista(_correo_electronico_artista As String, _nombre_artistico As String, _username As String, _password As Integer)
        _nombre_artistico = nombre_artistico
        _correo_electronico_artista = correo_electronico_artista
        _username = username
        _password = password
    End Sub
End Class
