Public Class Graffiti_logica
    Public Sub Alta_graffiti(graffitii As graffiti)
        Dim Graffiti_persistencia As New Graffiti_persistencia
        Graffiti_persistencia.Alta_graffiti(graffitii)
    End Sub
    Public Function Listar_graffiti() As List(Of graffiti)
        Dim Graffiti_persistencia As New Graffiti_persistencia
        Return Graffiti_persistencia.Listar_graffiti()
    End Function

    Public Sub ModificarGraffiti(graffitii As graffiti)
        Dim Graffiti_persistencia As New Graffiti_persistencia
        Graffiti_persistencia.ModificarGraffiti(graffitii)
    End Sub
End Class
