Public Class Artista_vista
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim correo_electronico_artista As String
        Dim nombre_artistico As String

        correo_electronico_artista = txt_correoelectronico.Text
        nombre_artistico = txt_nombre_artistico.Text

        Dim new_artista As New artista With {
            ._correo_electronico_artista = correo_electronico_artista,
            ._nombre_artistico = nombre_artistico
        }

        Dim logica As New Artista_logica
        logica.alta_artista(new_artista)
    End Sub

End Class