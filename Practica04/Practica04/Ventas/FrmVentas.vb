Imports Practica04.Conexion
Public Class FrmVentas
    Dim ObjConexion As New Conexion
    'Dim SqlString As String = "SELECT IdCliente, identificacion, (nombres || ' ' || apellidos) as CLIENTE, activo FROM clientes "
    Dim SqlString As String = "SELECT ventas.IdVenta, ventas.fecha, (clientes.nombres || ' ' || clientes.apellidos) as Cliente, sum(detallesVentas.precio * detallesVentas.cantidad) as total FROM ventas LEFT JOIN clientes ON clientes.IdCliente=ventas.IdCliente LEFT JOIN detallesVentas ON detallesVentas.IdVenta=ventas.IdVenta"
    Dim SqlGroup As String = " GROUP BY ventas.IdVenta"
    Dim tituloAPP As String = Application.ProductName
    Dim totalVenta As Double = 0
    Sub ConsultaCliente(ByVal nit As String)
        On Error Resume Next
        Dim SQLClientes As String = "SELECT * FROM clientes WHERE identificacion='" & Val(nit) & "'"
        Dim tabla As DataTable = Nothing
        tabla = ObjConexion.Abrir(SQLClientes)
        TxtNombres.Text = ""
        TxtApellidos.Text = ""
        Dim p As Integer = 0
        If tabla.Rows.Count > 0 Then
            'IdCliente, identificacion, nombres, apellidos
            While (p < tabla.Rows.Count)
                TxtIdCliente.Text = tabla.Rows(p).Item(0).ToString.PadLeft(5, "0")
                'TxtNit.Text = tabla.Rows(p).Item(1).ToString
                TxtNombres.Text = tabla.Rows(p).Item(2).ToString
                TxtApellidos.Text = tabla.Rows(p).Item(3).ToString
                p = p + 1
            End While
        Else
            Dim resultMsn As DialogResult = MessageBox.Show("No se encontró información asociada a la identificación " & nit & System.Environment.NewLine & System.Environment.NewLine & "¿Desea crear el cliente?",
            tituloAPP,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button2)

            If resultMsn = DialogResult.Yes Then
                Dim frm As New FrmCliente
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.RBnuevo.Enabled = True
                frm.RBnuevo.Checked = True
                frm.GBdatos.Enabled = True
                frm.RBactualizar.Enabled = False
                frm.RBrestaurar.Enabled = False
                frm.RBeliminar.Enabled = False
                frm.TxtNit.Text = nit
                frm.TxtNombres.Select()
                frm.BTNguardar.Text = "Guardar"
                frm.Text = "Nuevo cliente"
                frm.Show()
            End If
        End If
    End Sub

    Sub ConsultaProducto(ByVal codpro As String)
        On Error Resume Next
        Dim SQLClientes As String = "SELECT * FROM productos WHERE IdProducto=" & Val(codpro)
        Dim tabla As DataTable = Nothing
        tabla = ObjConexion.Abrir(SQLClientes)
        TxtIdProducto.Text = ""
        TxtProducto.Text = ""
        TxtIdProducto.Text = codpro.ToString().PadLeft(5, "0")
        TxtPrecio.Text = ""
        TxtCantidad.Text = ""
        Dim p As Integer = 0
        If tabla.Rows.Count > 0 Then
            'IdCliente, identificacion, nombres, apellidos
            While (p < tabla.Rows.Count)
                'TxtIdCliente.Text = tabla.Rows(p).Item(1).ToString().PadLeft(5, "0")
                TxtProducto.Text = tabla.Rows(p).Item(1).ToString
                TxtPrecio.Text = tabla.Rows(p).Item(2).ToString
                p = p + 1
            End While
        Else
            MessageBox.Show("No se encontró información asociada al producto con código " & codpro.ToString().PadLeft(5, "0"),
            tituloAPP,
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Sub ConsultaDetallesVenta(ByVal IdVenta As Integer)
        Dim SqlConsultaDatos As String = "SELECT detallesVentas.IdDetalle as CodDetalle, detallesVentas.IdVenta as CodVenta, detallesVentas.IdProducto as CodProducto, productos.nombre as Producto, detallesVentas.precio as Precio, detallesVentas.cantidad as Cantidad, (detallesVentas.precio * detallesVentas.cantidad) as SubTotal FROM detallesVentas INNER JOIN productos ON productos.IdProducto=detallesVentas.IdProducto WHERE detallesVentas.IdVenta=" & Val(IdVenta)
        Dim Tabla As DataTable = Nothing
        Dim y As Integer = 0
        Dim p As Integer = 0
        If Val(IdVenta) > 0 Then
            DgDetallesVenta.Rows.Clear()
            BindingSource1.DataSource = Nothing
            DgDetallesVenta.DataSource = Nothing
            DgDetallesVenta.Refresh()
            Dim VarIDdetalle As Integer
            Dim VarIDproducto As Integer
            Dim VarProducto As String = ""
            Dim VarPrecio As Double = 0
            Dim VarCantidad As Integer = 0
            'Dim VarTotal As Double = 0
            Tabla = ObjConexion.Abrir(SqlConsultaDatos)
            While (p < Tabla.Rows.Count)
                VarIDdetalle = Val(Tabla.Rows(p).Item("CodDetalle").ToString)
                VarIDproducto = Val(Tabla.Rows(p).Item("CodProducto").ToString)
                VarProducto = Tabla.Rows(p).Item("Producto").ToString
                VarPrecio = CDbl(Tabla.Rows(p).Item("Precio").ToString)
                VarCantidad = CInt(Tabla.Rows(p).Item("Cantidad").ToString)
                Dim Subtotal As Double = VarCantidad * VarPrecio
                'VarTotal += Subtotal
                totalVenta += Subtotal
                DgDetallesVenta.Rows.Add(VarIDdetalle, VarIDproducto, VarProducto, VarPrecio, VarCantidad, Format(Subtotal, "N2"), "L", "Eliminar")
                p = p + 1
            End While
            DgDetallesVenta.Columns("opcion").Visible = False
            TxtTotal.Text = Format(totalVenta, "$#,###.00")
        End If
    End Sub

    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultaDetallesVenta(Val(TxtIdVenta.Text))
    End Sub
    Private Sub TxtNit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNit.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub TxtIdProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIdProducto.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click
        ConsultaCliente(TxtNit.Text)
    End Sub
    Private Sub BtnBuscarProducto_Click(sender As Object, e As EventArgs) Handles BtnBuscarProducto.Click
        ConsultaProducto(TxtIdProducto.Text)
    End Sub
    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click
        If Val(TxtIdProducto.Text) = 0 Or TxtPrecio.Text = "" Or TxtProducto.Text = "" Or Val(TxtCantidad.Text) = 0 Then
            MessageBox.Show("La información del producto no debe estar vacía",
            tituloAPP,
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button2)
            Return
        End If

        Dim index As Integer = ObjConexion.InstanciaUnicaDetalles(Val(TxtIdProducto.Text), "CodProducto", DgDetallesVenta)
        If index = -1 Then
            DgDetallesVenta.Rows.Add("", Val(TxtIdProducto.Text), TxtProducto.Text, Val(TxtPrecio.Text), Val(TxtCantidad.Text), Format(Val(TxtCantidad.Text) * Val(TxtPrecio.Text), "N2"), "N", "Eliminar")
            totalVenta += Format(Val(TxtCantidad.Text) * Val(TxtPrecio.Text), "N2")
        Else
            totalVenta -= Format(Val(DgDetallesVenta.Rows(index).Cells("cantidad").Value) * Val(DgDetallesVenta.Rows(index).Cells("precio").Value), "N2")
            Dim precio As Double = DgDetallesVenta.Rows(index).Cells("precio").Value
            Dim NuevoSaldoCantidad As Integer = DgDetallesVenta.Rows(index).Cells("cantidad").Value + Val(TxtCantidad.Text)
            DgDetallesVenta.Rows(index).Cells("cantidad").Value = Val(NuevoSaldoCantidad)
            DgDetallesVenta.Rows(index).Cells("subtotal").Value = Val(NuevoSaldoCantidad) * precio
            totalVenta += Format(Val(NuevoSaldoCantidad) * precio, "N2")
        End If

        TxtIdProducto.Clear()
        TxtProducto.Clear()
        TxtPrecio.Clear()
        TxtCantidad.Clear()
        TxtTotal.Text = Format(totalVenta, "$#,###.00")

    End Sub
    Private Sub DgDetallesVenta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgDetallesVenta.CellContentClick
        If RBnuevo.Checked = True Then
            If (DgDetallesVenta.Columns(e.ColumnIndex).Name.Equals("opcion")) Then
                If DgDetallesVenta.CurrentRow.Cells("accion").Value = "N" Then
                    Dim NumDeFilaSeleccionada As Integer = DgDetallesVenta.CurrentRow.Index
                    'totalVenta -= Format(Val(DgDetallesVenta.Rows(NumDeFilaSeleccionada).Cells("cantidad").Value) * Val(DgDetallesVenta.Rows(NumDeFilaSeleccionada).Cells("precio").Value), "N2")
                    totalVenta -= DgDetallesVenta.Rows(NumDeFilaSeleccionada).Cells("subtotal").Value
                    TxtTotal.Text = Format(totalVenta, "$#,###.00")
                    DgDetallesVenta.Rows.Remove(DgDetallesVenta.CurrentRow)
                    'Else
                    'DgDetallesVenta.CurrentRow.Cells("Accion").Value = "E"
                    'DgDetallesVenta.CurrentRow.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub BTNcancelar_Click(sender As Object, e As EventArgs) Handles BTNcancelar.Click
        If BTNguardar.Text.ToUpper = "GUARDAR" Then
            Close()
        Else
            BTNguardar.Text = "Cerrar"
            RBnuevo.Checked = False
            RBeliminar.Checked = False
            GBdatos.Enabled = False
            GBacciones.Enabled = True
        End If
    End Sub

    Private Sub BTNguardar_Click(sender As Object, e As EventArgs) Handles BTNguardar.Click
        Dim Sql As String
        Dim insertarDetalles As Boolean
        Dim MSN As String = ""

        If Trim(BTNguardar.Text.ToLower()) = "guardar" Then
            Sql = "INSERT INTO ventas (IdCliente, fecha, anulada) VALUES (" & Val(TxtIdCliente.Text) & ", '" & DtpFecha.Text & "', 'N')"
            insertarDetalles = True
        ElseIf Trim(BTNguardar.Text.ToLower()) = "anular" Then
            Sql = "UPDATE ventas SET anulada='S' WHERE IdVenta=" & Val(TxtIdVenta.Text) & ""
            insertarDetalles = False
        Else
            Sql = ""
        End If

        If Sql <> "" Then
            If insertarDetalles And Val(DgDetallesVenta.Rows.Count) = 0 And Val(TxtIdCliente.Text) = 0 Then
                MessageBox.Show("Existen campos obligatorios no diligenciados, favor verificar la información a procesar.",
                Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
                Exit Sub
            End If
            If ObjConexion.Operaciones(Sql) = "OK" Then
                If insertarDetalles Then
                    Dim insertar As Integer = ObjConexion.UltimoID("IdVenta", "ventas")
                    If (insertar > -1) Then
                        insertar = Val(insertar) '+ 1
                    End If
                    MSN = "Se creó la venta #" & Format(Val(insertar), "00000")
                    MessageBox.Show(MSN,
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)
                    Dim p As Integer = 0
                    Dim errores As Integer = 0
                    Dim SqlLineas As String
                    While (p < DgDetallesVenta.Rows.Count)
                        SqlLineas = "INSERT INTO detallesVentas (IdVenta, IdProducto, cantidad, precio) VALUES (" & Val(insertar) & ", " & Val(DgDetallesVenta.Rows(p).Cells("CodProducto").Value) & ", " & Val(DgDetallesVenta.Rows(p).Cells("cantidad").Value) & ", " & CDbl(DgDetallesVenta.Rows(p).Cells("precio").Value) & ")"
                        If ObjConexion.Operaciones(SqlLineas) = "KO" Then
                            errores = errores + 1
                        End If
                        p += 1
                    End While
                    If errores > 0 Then
                        MessageBox.Show("No se pudo insertar los detalles de la venta #" & Format(Val(insertar), "00000") & ", dirígete al explorador y revisa la información en ella",
                        Application.ProductName,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
                    End If
                Else
                    MSN = "Operación anular venta #" & Format(Val(TxtIdVenta.Text), "00000") & " fue exitosa"
                    MessageBox.Show(MSN,
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)
                End If
                Close()
            Else
                If RBnuevo.Checked Then
                    MSN = "Operación crear venta no fue correcta"
                Else
                    MSN = "Operación anular venta #" & Format(Val(TxtIdVenta.Text), "00000") & " no fue correcta"
                End If
                MessageBox.Show(MSN,
                Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
            End If
        Else
            Close()
        End If



        'If Val(DgDetallesVenta.Rows.Count) > 0 And Val(TxtIdCliente.Text) > 0 Then
        '    If ObjConexion.Operaciones(Sql) = "OK" Then
        '        Dim insertar As Integer = ObjConexion.UltimoID("IdVenta", "ventas")
        '        If (insertar > -1) Then
        '            insertar = Val(insertar) '+ 1
        '            'TxtIdVenta.Text = insertar
        '            MSN = "Se creó la venta #" & Format(Val(insertar), "00000")
        '        End If
        '        MessageBox.Show(MSN,
        '            Application.ProductName,
        '            MessageBoxButtons.OK,
        '            MessageBoxIcon.Information)
        '        If insertarDetalles Then
        '            Dim p As Integer = 0
        '            Dim errores As Integer = 0
        '            While (p < DgDetallesVenta.Rows.Count)
        '                SqlLineas = "INSERT INTO detallesVentas (IdVenta, IdProducto, cantidad, precio) VALUES (" & Val(insertar) & ", " & Val(DgDetallesVenta.Rows(p).Cells("CodProducto").Value) & ", " & Val(DgDetallesVenta.Rows(p).Cells("cantidad").Value) & ", " & CDbl(DgDetallesVenta.Rows(p).Cells("precio").Value) & ")"
        '                If ObjConexion.Operaciones(SqlLineas) = "KO" Then
        '                    errores = errores + 1
        '                End If
        '                SqlLineas = ""
        '                p = p + 1
        '            End While
        '            If errores > 0 Then
        '                MessageBox.Show("No se pudo insertar los detalles de la venta #" & Format(Val(insertar), "00000") & ", dirígete al explorador y revisa la información en ella",
        '                Application.ProductName,
        '                MessageBoxButtons.OK,
        '                MessageBoxIcon.Error)
        '            End If
        '        End If
        '        Close()
        '    Else
        '        If RBnuevo.Checked Then
        '            MSN = "Operación crear venta no fue correcta"
        '        Else
        '            MSN = "Operación anular venta #" & Format(Val(TxtIdVenta.Text), "00000") & " no fue correcta"
        '        End If
        '        MessageBox.Show(MSN,
        '            Application.ProductName,
        '            MessageBoxButtons.OK,
        '            MessageBoxIcon.Information)
        '    End If
        'Else
        '    MessageBox.Show("Existen campos obligatorios no diligenciados, favor verificar la información a procesar.",
        '    Application.ProductName,
        '    MessageBoxButtons.OK,
        '    MessageBoxIcon.Information)
        '    Exit Sub
        'End If

    End Sub

    Private Sub RBeliminar_CheckedChanged(sender As Object, e As EventArgs) Handles RBeliminar.CheckedChanged
        If RBeliminar.Checked = True Then
            GBdatos.Enabled = False
            BTNguardar.Text = "Anular"
            GBacciones.Enabled = False
            BTNcancelar.Enabled = True
        Else
            BTNcancelar.Enabled = False
        End If
    End Sub
End Class