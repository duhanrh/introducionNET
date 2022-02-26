Public Class Form1
    Private Sub Btncalcular_Click(sender As Object, e As EventArgs) Handles Btncalcular.Click

        If (Txtbase.Text.Trim().Length = 0) Or (Txtaltura.Text.Trim().Length = 0) Then
            MessageBox.Show("Los campos son obligatorios")
        Else
            Txtarea.Text = (Val(Txtbase.Text) * Val(Txtaltura.Text)) / 2
        End If

    End Sub
    Sub Limpiar()
        Txtaltura.Clear()
        Txtbase.Clear()
        Txtarea.Clear()
    End Sub

    Private Sub Btnlimpiar_Click(sender As Object, e As EventArgs) Handles Btnlimpiar.Click
        Limpiar()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName + " - " + Application.ProductVersion
        Txtbase.Select()
    End Sub
End Class
