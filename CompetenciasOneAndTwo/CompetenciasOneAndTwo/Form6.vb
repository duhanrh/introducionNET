Public Class Form6
    ReadOnly SeparadorDecimal As String = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator
    ReadOnly SeparadorMiles As String = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyGroupSeparator
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show("El separador decimal es: '" & SeparadorDecimal & "'", "du")
        'MessageBox.Show("El separador de miles es: '" & SeparadorMiles & "'")
        RtextReadme.Text = "Una empresa requiere contratar personal para el trabajo en alturas, si la edad es mayor de 40, mostrar, no aceptado, de lo contrario, sigue el proceso."
    End Sub

    Sub Limpiar()
        TxtEdad.Clear()
        TxtContinue.Clear()
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        If TxtEdad.Text.Trim().Length > 0 Then
            If Val(TxtEdad.Text) > 40 Then
                TxtContinue.Text = "No"
                MessageBox.Show("No aceptado")
            Else
                TxtContinue.Text = "Si"
                MessageBox.Show("Sigue en el proceso")
            End If
        Else
            MessageBox.Show("El campo edad es requerido")
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
