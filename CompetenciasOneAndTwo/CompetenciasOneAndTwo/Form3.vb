Public Class Form3
    Dim SeparadorDecimal As String
    Dim SeparadorMiles As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SeparadorDecimal = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator
        'MessageBox.Show("El separador decimal es: '" & SeparadorDecimal & "'", "du")

        'SeparadorMiles = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyGroupSeparator
        'MessageBox.Show("El separador de miles es: '" & SeparadorMiles & "'")

        RtextReadme.Text = "Leer una cantidad en dolares, imprimir la cantidad en pesos colombianos."
    End Sub

    Sub Limpiar()
        TxtTrm.Clear()
        TxtUSD.Clear()
        TxtConversion.Clear()
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        If TxtTrm.Text.Trim().Length > 0 And TxtUSD.Text.Trim().Length > 0 Then
            TxtConversion.Text = Format(Val(TxtTrm.Text) * Val(TxtUSD.Text), "$#,###.00")
        Else
            MessageBox.Show("Los campos TRM y la cantidad de dolares a convertir son obligatorios")
            Return
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub TxtTrm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTrm.KeyPress
        'If Not IsNumeric(e.KeyChar) Then
        '    e.Handled = True
        'End If
        'e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)

        'Para que el primer caracter no sea el punto
        If TxtTrm.Text.Trim().Length = 0 And Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            'verificar la existencia del punto para no volverlo a insertar
            Dim ContPunto As Integer = TxtTrm.Text.Trim().IndexOf(".")
            If ContPunto > -1 And e.KeyChar = "." Then
                e.Handled = True
            Else
                e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "."
            End If
        End If
    End Sub

    Private Sub TxtUSD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUSD.KeyPress
        If TxtUSD.Text.Trim().Length = 0 And Char.IsPunctuation(e.KeyChar) Then 'para que el primer caracter no sea el punto
            e.Handled = True
        Else
            'verificar la existencia del punto para no volverlo a insertar
            Dim ContPunto As Integer = TxtUSD.Text.Trim().IndexOf(".")
            If ContPunto > -1 And e.KeyChar = "." Then
                e.Handled = True
            Else
                e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "."
            End If
        End If
    End Sub
End Class
