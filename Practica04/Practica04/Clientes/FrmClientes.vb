Public Class FrmClientes

    Private Sub BtnBuscarProducto_Click(sender As Object, e As EventArgs) Handles BtnBuscarProducto.Click

    End Sub

    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click

    End Sub

    Private Sub TxtIdProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIdProducto.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub TxtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrecio.KeyPress
        If TxtPrecio.Text.Trim().Length = 0 And Char.IsPunctuation(e.KeyChar) Then 'para que el primer caracter no sea el punto
            e.Handled = True
        Else
            'verificar la existencia del punto para no volverlo a insertar
            Dim ContPunto As Integer = TxtPrecio.Text.Trim().IndexOf(".")
            If ContPunto > -1 And e.KeyChar = "." Then
                e.Handled = True
            Else
                e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "."
            End If
        End If
    End Sub

    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub TxtNit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNit.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not (Char.IsLetter(e.KeyChar)) And Not Char.IsControl(e.KeyChar)
    End Sub

End Class
