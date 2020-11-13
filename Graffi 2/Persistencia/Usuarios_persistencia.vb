Public Class Usuarios_persistencia
    Dim conexion As New Npgsql.NpgsqlConnection()
    Public Sub Alta_usuario(usuarioss As usuarios)
        Try
            Dim clasecnn = New Conexion
            conexion = clasecnn.AbrirConexion()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = conexion
            Dim cadenadeconexion As String

            cadenadeconexion = "Insert into usuarios(correo_electronico, nombre_completo, dir_nro, calle, nombre_de_usuario, password, barrio) values  (@correo_electronico,@nombre_completo, @dir_nro, @calle ,@nombre_de_usuario, @password ,@barrio);"
            cmd.CommandText = cadenadeconexion
            cmd.Parameters.Add("@correo_electronico", NpgsqlTypes.NpgsqlDbType.Varchar, 30).Value = usuarioss._correo_electronico
            cmd.Parameters.Add("@nombre_completo", NpgsqlTypes.NpgsqlDbType.Varchar, 30).Value = usuarioss._nombre_completo
            cmd.Parameters.Add("@dir_nro", NpgsqlTypes.NpgsqlDbType.Integer).Value = usuarioss._dir_nro
            cmd.Parameters.Add("@calle", NpgsqlTypes.NpgsqlDbType.Varchar, 30).Value = usuarioss._calle
            cmd.Parameters.Add("@barrio", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = usuarioss._barrio
            cmd.Parameters.Add("@nombre_de_usuario", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = usuarioss._nombre_de_usuario
            cmd.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Integer).Value = usuarioss._password

            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Sub
End Class
