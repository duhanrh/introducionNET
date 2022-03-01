Public Class Form2
    Dim salario As Double
    Dim empleado As String
    Dim utilidades As Double
    Dim porcentaje As Double
    Sub Limpiar()
        salario = 0
        empleado = ""
        utilidades = 0
        porcentaje = 0

        TxtNombre.Clear()
        TxtSalario.Clear()
        TxtAntiguedad.Clear()
        TxtUtilidad.Clear()
        TxtPorcentajeUtilidad.Clear()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RtextReadme.Text = "Calcular la utilidad que un trabajador recibe en el reparto anual de utilidades si este se le asigna como un porcentaje de su salario mensual que depende de su antigüedad en la empresa de acuerdo con la siguiente información.

Menos de 1 año 5% del salario
1 año o más y menos de 2 años 8 % del salario
2 años o más y menos de 5 años 11% del salario
5 años o más y menos de 10 años 15% del salario
10 años o más 20% del salario

Mostrar, las utilidades anuales, el porcentaje mensual y el nombre del empleado."
    End Sub
    Private Sub TxtSalario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSalario.KeyPress
        If TxtSalario.Text.Trim().Length = 0 And Char.IsPunctuation(e.KeyChar) Then 'para que el primer caracter no sea el punto
            e.Handled = True
        Else
            'verificar la existencia del punto para no volverlo a insertar
            Dim ContPunto As Integer = TxtSalario.Text.Trim().IndexOf(".")
            If ContPunto > -1 And e.KeyChar = "." Then
                e.Handled = True
            Else
                e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "."
            End If
        End If
    End Sub

    Private Sub TxtAntiguedad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAntiguedad.KeyPress
        If TxtAntiguedad.Text.Trim().Length = 0 And Char.IsPunctuation(e.KeyChar) Then 'para que el primer caracter no sea el punto
            e.Handled = True
        Else
            'verificar la existencia del punto para no volverlo a insertar
            Dim ContPunto As Integer = TxtAntiguedad.Text.Trim().IndexOf(".")
            If ContPunto > -1 And e.KeyChar = "." Then
                e.Handled = True
            Else
                e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "."
            End If
        End If
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        If TxtNombre.Text.Trim().Length > 0 And TxtSalario.Text.Trim().Length > 0 And TxtAntiguedad.Text.Trim().Length > 0 Then
            salario = Val(TxtSalario.Text)
            empleado = TxtNombre.Text
            If Val(TxtAntiguedad.Text) >= 10 Then
                porcentaje = 0.2
            ElseIf Val(TxtAntiguedad.Text) >= 5 Then
                porcentaje = 0.15
            ElseIf Val(TxtAntiguedad.Text) >= 2 Then
                porcentaje = 0.11
            ElseIf Val(TxtAntiguedad.Text) >= 1 Then
                porcentaje = 0.08
            Else
                porcentaje = 0.05
            End If
        Else
            MessageBox.Show("Los campos nombre del empleado, salario y antiguedad son requeridos")
            Return
        End If

        utilidades = Val(salario) * porcentaje
        TxtUtilidad.Text = Format(utilidades, "$#,###.00")
        TxtPorcentajeUtilidad.Text = Format(porcentaje * 100, "##.00")

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub
End Class
