Public Class Form1
    ReadOnly user As String = "admin"
    ReadOnly password As String = "admin"
    Dim contador As Integer = 0
    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click

        If Txtuser.Text = user And Txtpassword.Text = password Then
            GBdatos.Visible = True
            GBlogin.Visible = False
        Else
            contador += 1
            MessageBox.Show("Datos invalidos")
        End If

        If contador = 3 Then
            Txtuser.Enabled = False
            Txtpassword.Enabled = False
            Btnlogin.Enabled = False
            MessageBox.Show("Cuenta inhabilitada")
        End If
    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabPagedatos.Visible = False
    End Sub
End Class
