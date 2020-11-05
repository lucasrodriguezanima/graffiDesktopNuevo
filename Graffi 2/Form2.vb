Public Class HOME
    Private Sub Like1_Click(sender As Object, e As EventArgs) Handles Like1.Click
        Like2.Show()
        Like1.Hide()
    End Sub

    Private Sub Like2_Click(sender As Object, e As EventArgs) Handles Like2.Click
        Like3.show()
    End Sub

    Private Sub Boton_panel_Click(sender As Object, e As EventArgs) Handles Boton_panel.Click
        Panel_Home.Show()
        If Panel_Home Is True Then
            Panel_Home.Hide()
        End If



    End Sub
End Class