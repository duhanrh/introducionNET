Public Class Form4
    ReadOnly SeparadorDecimal As String = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator
    ReadOnly SeparadorMiles As String = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyGroupSeparator
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RtextReadme.Text = "Leer la edad y estado civil de una persona, si es mayor de edad y soltera, mostrar un mensaje que diga, puede entrar a la fiesta, de lo contrario, mostrar No aceptada."
    End Sub

    Sub Limpiar()
        TxtEdad.Clear()
        CbEstadoCivil.Text = ""
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnVerificar.Click
        If TxtEdad.Text.Trim().Length > 0 And CbEstadoCivil.Text <> "" Then
            If (Val(TxtEdad.Text) >= 18 And CbEstadoCivil.Text = "Soltero(a)") Then
                MessageBox.Show("Puede entrar a la fiesta")
            Else
                MessageBox.Show("No aceptada")
            End If
        Else
            MessageBox.Show("Los campos edad y estado civil son obligatorios")
            Return
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub TxtEdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEdad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

End Class
