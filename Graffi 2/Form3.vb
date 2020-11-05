Public Class Registrate
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
        Else
            If TextBox2.Text = "" Then
            Else
                If TextBox3.Text = "" Then
                Else
                    If TextBox4.Text = "" Then
                    Else
                        HOME.Show()
                    End If
                End If
            End If
        End If
    End Sub
End Class