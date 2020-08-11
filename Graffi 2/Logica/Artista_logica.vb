Public Class Artista_logica
    Dim conexion As New Npgsql.NpgsqlConnection()
    Public Sub alta_Artista(artista As Artista_logica)
        Try
            Dim clasecnn = New Conexion
            conexion = clasecnn.AbrirConexion()
            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = conexion
            Dim cadenadeconexion = "INSERT INTO artista_logica ()"
        Catch ex As Exception

        End Try
    End Sub
End Class
