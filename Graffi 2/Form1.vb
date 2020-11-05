Imports System.Windows

Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
        Else
            If TextBox2.Text = "" Then
            Else
                HOME.Show()
            End If

        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Registrate.Show()
    End Sub
End Class
