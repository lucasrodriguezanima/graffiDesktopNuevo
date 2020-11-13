Public Class ModificarGraffitii
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Agregar_Graffiti.Click
        Dim nombre As String
        Dim diseño As String
        Dim id_graffiti As Integer


        diseño = txt_Diseño.Text
        nombre = txt_nombre.Text
        id_graffiti = txt_id_Graffiti.Text

        Dim new_Graffiti As New graffiti With {
       ._diseño = diseño,
       ._nombre = nombre,
       ._id_graffiti = id_graffiti
       }

        Dim logica As New Graffiti_logica
        logica.Alta_graffiti(new_Graffiti)

        List_listar_graffiti.Clear()
        Dim listGraffiti As New List(Of graffiti)
        listGraffiti = logica.Listar_graffiti()
        Dim graffitilista(3) As String

        For i = 0 To listGraffiti.Count - 1
            graffitilista(0) = listGraffiti(i)._id_graffiti
            graffitilista(1) = listGraffiti(i)._nombre
            graffitilista(2) = listGraffiti(i)._diseño
            Dim item = New ListViewItem()

            List_listar_graffiti.Items.Add(item)
        Next
    End Sub

    Private Sub Eliminar_Graffiti_Click(sender As Object, e As EventArgs) Handles Eliminar_Graffiti.Click
        Dim nombre As String
        Dim diseño As String
        Dim id_graffiti As Integer


        diseño = txt_Diseño.Text
        nombre = txt_nombre.Text
        id_graffiti = txt_id_Graffiti.Text

        Dim new_Graffiti As New graffiti With {
       ._diseño = diseño,
       ._nombre = nombre,
       ._id_graffiti = id_graffiti
       }

        Dim logica As New Graffiti_logica
        logica.ModificarGraffiti(new_Graffiti)
    End Sub

    Private Sub listar_Graffiti_Click(sender As Object, e As EventArgs) Handles listar_Graffiti.Click
        Dim nombre As String
        Dim diseño As String
        Dim id_graffiti As Integer

        Dim new_Graffiti As New graffiti With {
            ._diseño = diseño,
            ._nombre = nombre,
            ._id_graffiti = id_graffiti
        }
    End Sub

    Private Sub ModificarGraffitii_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim logicas As New Graffiti_logica
    End Sub
End Class