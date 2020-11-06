Public Class Artista_logica
    Public Sub alta_artista(artista As artista)
        Dim Artista_persistencia As New Artista_persistencia
        Artista_persistencia.alta_Artista(artista)
    End Sub
    Public Function buscar_artista(_correo_electronico_artista As String, _nombre_artistico As String) As artista
        Dim Artista_persistencia As New Artista_persistencia
        Return Artista_persistencia.Buscar_graffiti(_correo_electronico_artista, _nombre_artistico)
    End Function
    ' Public Function modificarGraffiti()
End Class
