Public Class Usuarios_logica
    Public Sub alta_usuario(usuarioss As usuarios)
        Dim Usuarios_persistencia As New Usuarios_persistencia
        Usuarios_persistencia.alta_usuario(usuarioss)
    End Sub


End Class
