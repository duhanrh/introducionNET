Public Class Form1
    Dim recursosPropios As Double
    Dim montoBanco As Double
    Dim interesBanco As Double
    Dim montoFabricante As Double
    Dim interesFabricante As Double
    Sub Limpiar()
        recursosPropios = 0
        montoBanco = 0
        interesBanco = 0
        montoFabricante = 0
        interesFabricante = 0

        TxtValorCompra.Clear()
        TxtRecursosPropios.Clear()
        TxtPrestamo.Clear()
        TxtMontoPrestamoBanco.Clear()
        TxtInteresPrestamoBanco.Clear()
        TxtTotalPrestamoBanco.Clear()
        TxtMontoPrestamoFabricante.Clear()
        TxtInteresPrestamoFabricante.Clear()
        TxtTotalPrestamoFabricante.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RtextReadme.Text = "Una empresa quiere hacer una compra de varias piezas de la misma clase a una fábrica. Mostrar como nombre de la empresa su NOMBRE Y APELLIDOS.

        La empresa, dependiendo del monto de la compra, decidirá qué hacer para pagar al fabricante.

        Si el monto total de la compra excede de $5000000 la empresa tendrá la capacidad de invertir de su propio dinero un 55% del monto de la compra, pedir prestado al banco un 30% y el resto lo pagará solicitando un crédito al fabricante.

        Si el monto de la compra no excede de $5000000 la empresa tendrá la capacidad de invertir de su propio dinero un 70% y el restante 30% lo pagará solicitando crédito al fabricante.

        El fabricante cobra por concepto de intereses un 20% sobre la cantidad que se le pague a crédito."
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        If TxtValorCompra.Text.Trim().Length > 0 Then
            If Val(TxtValorCompra.Text) > 5000000 Then
                recursosPropios = Val(TxtValorCompra.Text) * 0.55
                montoBanco = Val(TxtValorCompra.Text) * 0.3
                montoFabricante = Val(TxtValorCompra.Text) * 0.15
            Else
                recursosPropios = Val(TxtValorCompra.Text) * 0.7
                montoBanco = 0
                montoFabricante = Val(TxtValorCompra.Text) * 0.3
            End If
        Else
            MessageBox.Show("El campo valor de la compra es requerido")
            Return
        End If

        interesBanco = 0
        interesFabricante = montoFabricante * 0.2

        TxtRecursosPropios.Text = Format(recursosPropios, "$#,###.00")
        TxtPrestamo.Text = Format(montoBanco + interesBanco + montoFabricante + interesFabricante, "$#,###.00")

        'Prestamo banco
        TxtMontoPrestamoBanco.Text = Format(montoBanco, "$#,###.00")
        TxtInteresPrestamoBanco.Text = Format(interesBanco, "$#,###.00")
        TxtTotalPrestamoBanco.Text = Format(montoBanco + interesBanco, "$#,###.00")
        'Prestamo fabricante
        TxtMontoPrestamoFabricante.Text = Format(montoFabricante, "$#,###.00")
        TxtInteresPrestamoFabricante.Text = Format(interesFabricante, "$#,###.00")
        TxtTotalPrestamoFabricante.Text = Format(montoFabricante + interesFabricante, "$#,###.00")
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub TxtValorCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtValorCompra.KeyPress
        If TxtValorCompra.Text.Trim().Length = 0 And Char.IsPunctuation(e.KeyChar) Then 'para que el primer caracter no sea el punto
            e.Handled = True
        Else
            'verificar la existencia del punto para no volverlo a insertar
            Dim ContPunto As Integer = TxtValorCompra.Text.Trim().IndexOf(".")
            If ContPunto > -1 And e.KeyChar = "." Then
                e.Handled = True
            Else
                e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "."
            End If
        End If
    End Sub
End Class
