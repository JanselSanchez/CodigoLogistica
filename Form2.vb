Public Class Form2

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "1" And TextBox2.Text = "1" Then

            Form1.Show()
            Me.Hide()
        Else
            MsgBox("Usuario o Contraseña incorrecto")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class