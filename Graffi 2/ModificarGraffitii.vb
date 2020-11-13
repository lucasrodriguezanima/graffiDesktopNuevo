Public Class ModificarGraffitii

    Dim lista As New List(Of graffiti)

    Private Sub ModificarGraffitii_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Diseño.Enabled = True
        txt_id_Graffiti.Enabled = True
        txt_nombre.Enabled = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Agregar_Graffiti.Click
        Dim nombre As String
        Dim diseño As String
        Dim id_Graffiti As Integer


        nombre = txt_nombre.Text
        diseño = txt_Diseño.Text
        id_Graffiti = txt_id_Graffiti.Text

        List_listar_graffiti.Items.Add(nombre)
        List_listar_graffiti.Items.Add(diseño)
        List_listar_graffiti.Items.Add(id_Graffiti)


        txt_nombre.Text = ""
        txt_Diseño.Text = ""
        txt_id_Graffiti.Text = ""


        Dim new_Graffiti As New graffiti With {
        ._nombre = nombre,
        ._diseño = diseño,
        ._id_graffiti = id_Graffiti
         }

        Dim logica As New Graffiti_logica
        logica.Alta_graffiti(new_Graffiti)

    End Sub

    Private Sub Eliminar_Graffiti_Click(sender As Object, e As EventArgs) Handles Eliminar_Graffiti.Click
        Dim nombre As String
        Dim diseño As String
        Dim id_graffiti As Integer


        nombre = txt_nombre.Text
        diseño = txt_Diseño.Text
        id_graffiti = txt_id_Graffiti.Text


        Dim lista As New List(Of graffiti)

        List_listar_graffiti.Clear()




        Dim new_Graffiti As New graffiti With {
       ._nombre = nombre,
        ._diseño = diseño,
       ._id_graffiti = id_graffiti
       }


        Dim logica As New Graffiti_logica
        logica.ModificarGraffiti(new_Graffiti)




        txt_Diseño.Text = ""
        txt_nombre.Text = ""
        txt_id_Graffiti.Text = ""

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
End Class