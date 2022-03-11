Imports Practica04.Conexion
Imports vb = Microsoft.VisualBasic
Public Class FrmProducto
    Dim ObjConexion As New Conexion
    Function VerificarCampos()
        If Len(Trim(TXTnombre.Text)) = 0 Or Len(Trim(TXTprecio.Text)) = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Sub CargarConsultaDatos(ByVal IDproducto As Integer)
        Dim SqlConsultaDatos As String = "SELECT * FROM productos WHERE IdProducto=" & Val(IDproducto) & ""
        Dim Tabla As DataTable = Nothing
        Dim y As Integer = 0
        If IDproducto > 0 Then
            Tabla = ObjConexion.Abrir(SqlConsultaDatos)
            While (y < Tabla.Rows.Count)
                'TXTcodigo.Text = Tabla.Rows(y).Item("IDproducto").ToString
                TXTnombre.Text = Tabla.Rows(y).Item("nombre").ToString
                TXTprecio.Text = Val(Tabla.Rows(y).Item("precio").ToString)
                LBLestado.Text = Tabla.Rows(y).Item("activo").ToString
                y = y + 1
            End While
        End If
    End Sub

    Sub Propiedades()
        'Me.BackColor = My.Settings.ColorForm
        'HEADER.BackColor = My.Settings.ColorPrimary
        'HEADER.ForeColor = My.Settings.ColorThird
        'LBLmodulo.BackColor = My.Settings.ColorPrimary
        'LBLmodulo.ForeColor = My.Settings.ColorThird
        'TXTid.BackColor = My.Settings.ColorSecondary
        'TXTid.ForeColor = My.Settings.ColorThird
        'FOOTER.BackColor = My.Settings.ColorPrimary
        'FOOTER.ForeColor = My.Settings.ColorThird
    End Sub

    Sub LoadForm()
        Call Propiedades()
        Me.CenterToScreen()
        If (Val(TXTid.Text) > 0) Then
            CargarConsultaDatos(Val(TXTid.Text))
            GBacciones.Enabled = True
        Else
            GBacciones.Enabled = False
        End If

        If LBLestado.Text = "N" Then
            RBactualizar.Enabled = False
            RBrestaurar.Enabled = True
            RBeliminar.Enabled = False
            RBnuevo.Enabled = False
        ElseIf LBLestado.Text = "S" Then
            GBacciones.Enabled = True
            RBactualizar.Enabled = True
            RBrestaurar.Enabled = False
            RBeliminar.Enabled = True
            RBnuevo.Enabled = False
        Else
            RBactualizar.Enabled = False
            RBrestaurar.Enabled = False
            RBeliminar.Enabled = False
            RBnuevo.Enabled = True
            GBacciones.Enabled = True
        End If

    End Sub
    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadForm()
    End Sub
    Private Sub BTNcancelar_Click(sender As Object, e As EventArgs) Handles BTNcancelar.Click
        If BTNguardar.Text.ToUpper = "GUARDAR" Then
            Close()
        Else
            If Val(TXTid.Text) > 0 Then
                LoadForm()
            End If
            BTNguardar.Text = "Cerrar"
            RBnuevo.Checked = False
            RBactualizar.Checked = False
            RBeliminar.Checked = False
            RBrestaurar.Checked = False
            GBdatos.Enabled = False
            GBacciones.Enabled = True
        End If
    End Sub
    Private Sub BTNguardar_Click(sender As Object, e As EventArgs) Handles BTNguardar.Click
        Dim Sql As String = ""
        Dim SQLAgregado As String = ""
        Dim MSN As String = ""

        If BTNguardar.Text = "Actualizar" Then
            Sql = "UPDATE productos SET nombre='" & Trim(TXTnombre.Text) & "', precio=" & Val(TXTprecio.Text) & " WHERE IdProducto=" & Val(TXTid.Text) & ""
        ElseIf BTNguardar.Text = "Eliminar" Then
            Sql = "UPDATE productos SET activo='N' WHERE IdProducto=" & TXTid.Text & ""
        ElseIf BTNguardar.Text = "Restaurar" Then
            Sql = "UPDATE productos SET activo='S' WHERE IdProducto=" & TXTid.Text & ""
        ElseIf Trim(BTNguardar.Text.ToLower()) = "guardar" Then
            Sql = "INSERT INTO productos (nombre, precio, activo) VALUES ('" & Trim(TXTnombre.Text) & "', " & Val(TXTprecio.Text) & ", 'S')"
            SQLAgregado = "INSERT"
        End If

        If Sql <> "" Then
            If VerificarCampos() Then
                'Dim respuesta As String = ObjConexion.Operaciones(Sql)
                If ObjConexion.Operaciones(Sql) = "OK" Then
                    If SQLAgregado = "" Then
                        MSN = "Operación " & BTNguardar.Text & " producto #" & Format(Val(TXTid.Text), "00000") & " realizada correctamente"
                    ElseIf SQLAgregado = "INSERT" Then
                        Dim insertar As Integer = ObjConexion.UltimoID("IdProducto", "productos")
                        If (insertar > -1) Then
                            insertar = Val(insertar) '+ 1
                            TXTid.Text = insertar
                            MSN = "Se creó el producto #" & Format(Val(TXTid.Text), "00000")
                        End If
                    End If
                    MessageBox.Show(MSN,
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)
                    Close()
                Else
                    MessageBox.Show("Operación " & BTNguardar.Text & " producto #" & Format(Val(TXTid.Text), "00000") & " no fue correcta",
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Existen campos obligatorios no diligenciados, favor verificar la información a procesar.",
                Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
                Exit Sub
            End If
        Else
            Close()
        End If
        Sql = ""
        SQLAgregado = ""
        'If Len(Val(TXTid.Text)) > 0 Then
        '    RBnuevo.Checked = False
        '    RBactualizar.Checked = False
        '    RBeliminar.Checked = False
        '    RBrestaurar.Checked = False
        '    LoadForm()
        '    BTNguardar.Text = "Cerrar"
        'End If
    End Sub

    Private Sub RBactualizar_CheckedChanged(sender As Object, e As EventArgs) Handles RBactualizar.CheckedChanged
        If RBactualizar.Checked = True Then
            GBdatos.Enabled = True
            BTNguardar.Text = "Actualizar"
            GBacciones.Enabled = False
            BTNcancelar.Enabled = True
        Else
            BTNcancelar.Enabled = False
        End If
    End Sub

    Private Sub RBeliminar_CheckedChanged(sender As Object, e As EventArgs) Handles RBeliminar.CheckedChanged
        If RBeliminar.Checked = True Then
            GBdatos.Enabled = False
            BTNguardar.Text = "Eliminar"
            GBacciones.Enabled = False
            BTNcancelar.Enabled = True
        Else
            BTNcancelar.Enabled = False
        End If
    End Sub

    Private Sub RBrestaurar_CheckedChanged(sender As Object, e As EventArgs) Handles RBrestaurar.CheckedChanged
        If RBrestaurar.Checked = True Then
            GBdatos.Enabled = False
            BTNguardar.Text = "Restaurar"
            GBacciones.Enabled = False
            BTNcancelar.Enabled = True
        Else
            BTNcancelar.Enabled = False
        End If
    End Sub

    Private Sub RBnuevo_CheckedChanged(sender As Object, e As EventArgs) Handles RBnuevo.CheckedChanged
        If RBnuevo.Checked = True Then
            GBdatos.Enabled = True
            BTNguardar.Text = "Guardar"
        Else
            BTNcancelar.Enabled = False
        End If
    End Sub

End Class