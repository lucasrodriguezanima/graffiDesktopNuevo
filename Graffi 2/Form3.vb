Public Class Registrate
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_name.Text = "" Then
        Else
            If txt_nombre_de_usuario.Text = "" Then
            Else
                If txt_telefono.Text = "" Then
                Else
                    If txt_apellido.Text = "" Then
                    Else
                        HOME.Show()
                    End If
                End If
            End If
        End If
    End Sub
End Class