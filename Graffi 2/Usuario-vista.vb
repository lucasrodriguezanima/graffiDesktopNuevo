Public Class Usuario_vista
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim correo_electronico As String
        Dim nombre_completo As String
        Dim dir_nro As Integer
        Dim calle As String
        Dim barrio As String
        Dim nombre_de_usuario As String
        Dim password As Integer

        correo_electronico = txt_correoelectronico.Text
        nombre_completo = txt_nombre_completo.Text
        dir_nro = txt_dir_nro.Text
        calle = txt_calle.Text
        barrio = txt_barrio.Text
        nombre_de_usuario = txt_nombre_de_usuario.Text
        password = txt_password.Text

        Dim new_usuario As New usuarios With {
       ._correo_electronico = correo_electronico,
       ._nombre_completo = nombre_completo,
       ._dir_nro = dir_nro,
       ._calle = calle,
       ._barrio = barrio,
       ._nombre_de_usuario = nombre_de_usuario,
       ._password = password
        }

        Dim logica As New Usuarios_logica
        logica.alta_usuario(new_usuario)
    End Sub
End Class