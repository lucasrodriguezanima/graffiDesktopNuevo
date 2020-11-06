Imports NpgsqlTypes

Public Class Artista_persistencia
    Dim conexion As New Npgsql.NpgsqlConnection()
    Public Sub Alta_Artista(artistaa As artista)
        Try
            Dim clasecnn = New Conexion
            conexion = clasecnn.AbrirConexion()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = conexion
            Dim cadenadeconexion As String
            cadenadeconexion = "INSERT INTO artista(correo_electronico_artista, nombre_artistico) values (@correo_electronico_artista, @nombre_artistico);"
            cmd.CommandText = cadenadeconexion
            cmd.Parameters.Add("@correo_electronico_artista", NpgsqlTypes.NpgsqlDbType.Varchar, 30).Value = artistaa._correo_electronico_artista
            cmd.Parameters.Add("@nombre_artistico", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = artistaa._nombre_artistico
            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub ModificarGraffiti(artista As artista)
        Try
            Dim cadenadecomandoSS
            Dim Resultado As Integer
            Dim classconexion = New Conexion
            conexion = classconexion.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion

            Dim cadenadecomandoS = "delete * from artista where  correo_electronico_artista = @correo_electronico_artista"
            ' = "delete * from artista where  nombre_artistico = @nombre_artistico"
            cmd.CommandText = cadenadecomandoS

            cadenadecomandoS = "update artista set nombre_artistico=@nombre_artistico, correo_electronico_artista = @correo_electronico_artista"
            cmd.CommandText = cadenadecomandoS

        Catch ex As Exception

        End Try
    End Sub
    Public Function Buscar_graffiti(_correo_electronico_artista As String, _nombre_artistico As String) As artista
        Dim graffitiNuevo As artista
        Try
            Dim ClaseSln As New Conexion

            conexion = ClaseSln.AbrirConexion
            Dim cmd As Npgsql.NpgsqlCommand
            cmd.Connection = conexion

            Dim cadenaDeComandos = "Select * from artista where  correo_electronico_artista = @correo_electronico_artista"
            Dim CDComandos = "Select * from artista where  nombre_artistico = @nombre_artistico"

            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@nombre_artistico", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = _nombre_artistico
            cmd.Parameters.Add("@correo_electronico_artista", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = _correo_electronico_artista

            Dim Lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader

            If Lector.HasRows Then
                Lector.Read()

                graffitiNuevo._correo_electronico_artista = (Lector(0).ToString)
                graffitiNuevo._nombre_artistico = Lector(1).ToString
            End If



        Catch ex As Exception

        End Try
        Return graffitiNuevo

    End Function
End Class
