Public Class Form7
    ReadOnly SeparadorDecimal As String = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator
    ReadOnly SeparadorMiles As String = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyGroupSeparator
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show("El separador decimal es: '" & SeparadorDecimal & "'", "du")
        'MessageBox.Show("El separador de miles es: '" & SeparadorMiles & "'")
        RtextReadme.Text = "En la empresa se requiere autorizar la entrada al personal de acuerdo a la temperatura corporal detectada en el sensor, si la temperatura es igual o superior a 37, mostrar, No abrir puerta, de lo contrario, mostrar, puede ingresar."
    End Sub

    Sub Limpiar()
        TxtTemperatura.Clear()
        TxtAutorizado.Clear()
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        If TxtTemperatura.Text.Trim().Length > 0 Then
            If Val(TxtTemperatura.Text) > 37 Then
                TxtAutorizado.Text = "No"
                MessageBox.Show("No abrir puerta")
            Else
                TxtAutorizado.Text = "Si"
                MessageBox.Show("Puede ingresar")
            End If
        Else
            MessageBox.Show("El campo temperatura es requerido")
            Return
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub TxtEdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTemperatura.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

End Class
