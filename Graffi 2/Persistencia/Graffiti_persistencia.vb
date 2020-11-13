Imports NpgsqlTypes
Public Class Graffiti_persistencia
    Dim conexion As New Npgsql.NpgsqlConnection()
    Public Sub Alta_graffiti(graffitii As graffiti)
        Try
            Dim clasecnn = New Conexion
            conexion = clasecnn.AbrirConexion()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = conexion
            Dim cadenadeconexion As String

            cadenadeconexion = "INSERT INTO graffiti(id_graffiti, diseño, nombre) values (@id_graffiti, @diseño, @nombre);"
            cmd.CommandText = cadenadeconexion
            cmd.Parameters.Add("@id_graffiti", NpgsqlTypes.NpgsqlDbType.Integer).Value = graffitii._id_graffiti
            cmd.Parameters.Add("@diseño", NpgsqlTypes.NpgsqlDbType.Varchar, 15).Value = graffitii._diseño
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = graffitii._nombre

            Dim resultados As Integer
            resultados = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex

        Finally
            conexion.Close()
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




        Catch ex As Exception

        End Try
        Return graffitiNuevo

    End Function
    Public Sub ModificarGraffiti(graffitiii As graffiti)
        Try
            Dim cadenadecomandoS As String
            Dim classconexion = New Conexion
            conexion = classconexion.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion

            cadenadecomandoS = "delete  from graffiti  where id_graffiti = @id_graffiti;"
            cmd.CommandText = cadenadecomandoS

            Dim Resultados As Integer
            Resultados = cmd.ExecuteNonQuery()
        Catch ex As Exception

        Finally
            conexion.Close()
        End Try
    End Sub
    Public Function Listar_graffiti() As List(Of graffiti)
        Dim lista As New List(Of graffiti)
        Try
            Dim clasecnn = New Conexion
            conexion = clasecnn.AbrirConexion()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = conexion

            Dim cadenadeconexion As String
            cadenadeconexion = "select * from graffiti"
            cmd.CommandText = cadenadeconexion

            'Dim resultado As Integer
            ' resultado = cmd.ExecuteReader()

            Dim Lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader

            While Lector.Read()
                Dim graffitinuevo As New graffiti
                graffitinuevo._id_graffiti = (Lector(0).ToString)
                graffitinuevo._nombre = Lector(1).ToString
                graffitinuevo._diseño = Lector(2).ToString
                lista.Add(graffitinuevo)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
        Return lista
    End Function

End Class
