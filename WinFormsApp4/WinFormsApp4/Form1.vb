Public Class Form1
    Dim numero As Integer
    Dim resultado As Integer
    Private Sub Btnprocesar_Click(sender As Object, e As EventArgs) Handles Btnprocesar.Click
        If Val(Txtnumero.Text) < 0 Then
            Txtnumeroabs.Text = Math.Abs(Val(Txtnumero.Text))
        End If
        numero = Math.Abs(Val(Txtnumero.Text))
        If numero Mod 2 = 0 Then
            Lblispar.Text = "El número es par"
        Else
            Lblispar.Text = "El número es impar"
        End If
    End Sub
End Class
