Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim correo_electronico_artista As String
        Dim nombre_artistico As String
        Dim username As String
        Dim password As String

        ' If txt_correoelectronico.Text = "" Then
        '  Else
        '   If txt_nombre_artistico.Text = "" Then
        '   Else
        'If txt_username.Text = "" Then
        'Else
        'If txt_password.Text = "" Then
        'Else
        '  HOME.Show()
        '            End If
        'End If
        'End If
        ' End If
        correo_electronico_artista = txt_correoelectronico.Text
        nombre_artistico = txt_nombre_artistico.Text
        username = txt_username.Text
        password = txt_password.Text

        Dim new_artista As New artista With {
            ._correo_electronico_artista = correo_electronico_artista,
            ._nombre_artistico = nombre_artistico,
            ._username = username,
            ._password = password
        }

        Dim logica As New Artista_logica
        logica.alta_artista(new_artista)

        If txt_correoelectronico.Text = "" Then
        Else
            If txt_nombre_artistico.Text = "" Then
            Else
                If txt_username.Text = "" Then
                Else
                    If txt_password.Text = "" Then
                    Else
                        HOME.Show()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Usuario_vista.Show()
    End Sub
End Class