Public Class usuarios
    Private correo_electronico As String
    Private nombre_completo As String
    Private dir_nro As Integer
    Private calle As String
    Private barrio As String
    Private nombre_de_usuario As String
    Private password As Integer

    Public Property _nombre_completo As String
        Get
            Return nombre_completo
        End Get
        Set(value As String)
            nombre_completo = value
        End Set
    End Property

    Public Property _dir_nro As Integer
        Get
            Return dir_nro
        End Get
        Set(value As Integer)
            dir_nro = value
        End Set
    End Property
    Public Property _calle As String
        Get
            Return calle
        End Get
        Set(value As String)
            calle = value
        End Set
    End Property
    Public Property _barrio As String
        Get
            Return barrio
        End Get
        Set(value As String)
            barrio = value
        End Set
    End Property
    Public Property _nombre_de_usuario As String
        Get
            Return nombre_de_usuario
        End Get
        Set(value As String)
            nombre_de_usuario = value
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
    Public Property _correo_electronico As String
        Get
            Return correo_electronico
        End Get
        Set(value As String)
            correo_electronico = value
        End Set
    End Property
    Public Sub usuarios(_correo_electronico As String, _nombre_completo As String, _dir_nro As Integer, _calle As String, _nombre_de_usuario As String, _password As Integer, _barrio As String)
        _correo_electronico = correo_electronico
        _nombre_completo = nombre_completo
        _dir_nro = dir_nro
        _calle = calle
        _nombre_de_usuario = nombre_de_usuario
        _password = password
        _barrio = barrio
    End Sub
End Class
