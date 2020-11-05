Public Class Artista_logica
    Dim conexion As New Npgsql.NpgsqlConnection()
    Public Sub alta_Artista(artista As Artista_logica)
        Try
            Dim clasecnn = New Conexion
            conexion = clasecnn.AbrirConexion()
            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = conexion
            Dim cadenadeconexion = "INSERT INTO artista_logica ( correo_electronico_artista, nombre_artistico) values (@correo_electronico_artista,@nombre_artistico)"

            'cmd.Parameters.Add("@correo_electronico_artista", NpgsqlTypes.NpgsqlDbType.Integer).Value = artista.correo_electronico_artista
            '          cmd.Parameters.Add("@nombre_artistico", NpgsqlTypes.NpgsqlDbType.Integer).Value = artista.nombre_artistico

        Catch ex As Exception

        End Try
    End Sub
End Class
