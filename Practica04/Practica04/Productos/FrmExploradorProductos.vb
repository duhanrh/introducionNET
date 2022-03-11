Imports Practica04.Conexion
Public Class FrmExploradorProductos
    Dim ObjConexion As New Conexion
    'Dim SqlCompras As String = "SELECT com.IDcompra, com.fecha_creacion, com.IDsolicitante as CodSolicitante, (SELECT tere.nombre FROM tblterceros as tere WHERE tere.IDtercero=IDsolicitante) AS Solicitante, com.IDproveedor as CodProveedo, CONCAT(terp.nombre, ' (',tn.codigo, ' ', terp.nit ,')') as Proveedor, com.observaciones as Nota, com.estado as Estado, com.activo as Activa FROM tblcompras as com INNER JOIN tblterceros AS terp ON com.IDproveedor=terp.IDtercero LEFT JOIN tbltipos_nit as tn ON terp.IDtipo_nit=tn.IDtipo_nit" 'prioridad proveedor
    Dim SqlString As String = "SELECT * FROM productos " '"SELECT req.IDrequisicion, req.fecha_creacion, req.IDsolicitante as CodSolicitante, ter.nombre as Solicitante, req.IDproveedor as CodProveedor, IFNULL(FC_NOMBRE_TERCERO(req.IDproveedor),'SIN PROVEEDOR') as Proveedor, req.IDproducto, pro.nombre, req.cantidad, req.origen, req.destino, req.aprobada, req.activo FROM tblcompras_requisiciones as req LEFT JOIN tblterceros as ter ON ter.IDtercero=req.IDsolicitante left JOIN tblproductos as pro ON req.IDproducto=pro.IDproducto"
    Dim tituloAPP As String = Application.ProductName
    Private Sub FrmExploradorProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        If ObjConexion.Consulta(BindingSource1, Trim(SqlString)) = "OK" Then
            Footer.BindingSource = BindingSource1
            DGdatos.DataSource = BindingSource1
            DGpropiedades()
        End If
    End Sub

    Sub DGpropiedades()
        'DGdatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGdatos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGdatos.ReadOnly = True
        DGdatos.Columns(0).Width = 90
        DGdatos.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGdatos.Columns(2).Width = 120
        DGdatos.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGdatos.Columns(4).Width = 100
        DGdatos.Columns(0).HeaderText = "CODIGO"
        DGdatos.Columns(1).HeaderText = "NOMBRE"
        DGdatos.Columns(2).HeaderText = "PRECIO UNITARIO"
        DGdatos.Columns(3).HeaderText = "IMAGEN"
        DGdatos.Columns(4).HeaderText = "ESTADO"
        DGdatos.Columns(3).Visible = False
        DGdatos.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGdatos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DGdatos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGdatos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DGdatos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGdatos.Columns(0).DefaultCellStyle.Format = "00000"
        DGdatos.Columns(2).DefaultCellStyle.Format = "#,###.00"
    End Sub
    Private Sub BTNnuevo_Click(sender As Object, e As EventArgs) Handles BTNnuevo.Click
        Dim FRM As New FrmProducto
        FRM.StartPosition = FormStartPosition.CenterScreen
        'SinChecked()
        FRM.RBnuevo.Enabled = True
        FRM.RBnuevo.Checked = True
        FRM.GBdatos.Enabled = True
        FRM.RBactualizar.Enabled = False
        FRM.RBrestaurar.Enabled = False
        FRM.RBeliminar.Enabled = False
        FRM.BTNguardar.Text = "Guardar"
        'FRM.LBLinformador.Text = ""
        'FRM.TabEntregas.Parent = Nothing
        'FRM.WindowState = FormWindowState.Maximized
        FRM.Text = "Nuevo producto o servicio"
        FRM.Show()
        RBestados_activos.Checked = True
        BTNfiltro.PerformClick()
    End Sub

    Private Sub BTNfiltro_Click(sender As Object, e As EventArgs) Handles BTNfiltro.Click
        Dim condicion As String = ""
        If RBestados_activos.Checked = True Then
            condicion = " WHERE activo='S'"
        ElseIf RBestados_inactivos.Checked = True Then
            condicion = " WHERE activo='N'"
        ElseIf RBestados_todos.Checked = True Then
            condicion = ""
        End If

        DGdatos.DataSource = Nothing
        DGdatos.Refresh()
        BindingSource1.DataSource = Nothing

        If ObjConexion.Consulta(BindingSource1, Trim(SqlString & condicion)) = "OK" Then
            Footer.BindingSource = BindingSource1
            DGdatos.DataSource = BindingSource1
            DGpropiedades()
        End If
    End Sub

    Private Sub DGdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGdatos.CellDoubleClick

        Try
            Dim frm As New FrmProducto
            frm.TXTid.Text = Format(DGdatos.CurrentRow.Cells(0).Value, "00000")
            frm.Text = "Producto # " & Format(DGdatos.CurrentRow.Cells(0).Value, "00000")
            frm.RBnuevo.Enabled = False
            frm.RBnuevo.Checked = False
            frm.GBdatos.Enabled = False
            If DGdatos.CurrentRow.Cells(4).Value.ToString = "N" Then
                frm.RBactualizar.Enabled = False
                frm.RBactualizar.Checked = False
                frm.RBrestaurar.Enabled = True
                frm.RBrestaurar.Checked = False
                frm.RBeliminar.Enabled = False
                frm.RBeliminar.Checked = False
            Else
                frm.RBactualizar.Enabled = True
                frm.RBactualizar.Checked = False
                frm.RBrestaurar.Enabled = False
                frm.RBrestaurar.Checked = False
                frm.RBeliminar.Enabled = True
                frm.RBeliminar.Checked = False
            End If
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show()
            BTNfiltro.PerformClick()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTNbuscar_Click(sender As Object, e As EventArgs) Handles BTNbuscar.Click
        Dim peticion As Integer = 0
        Dim where1 As String = ""
        Dim SQLconsulta As String = Nothing
        If Len(TXTconsulta.Text.Trim) >= 1 Then
            peticion = 1
            SQLconsulta = SqlString
            'If IsNumeric(TXTconsulta.Text.Trim) = False Then
            '    where1 = " WHERE nombre Like '%" & TXTconsulta.Text.Trim & "%' ORDER BY nombre ASC"
            'Else
            '    where1 = " WHERE IdProducto=" & Val(TXTconsulta.Text.Trim) & ""
            'End If
            where1 = " WHERE IdProducto Like '%" & TXTconsulta.Text.Trim & "%' OR nombre Like '%" & TXTconsulta.Text.Trim & "%' ORDER BY nombre ASC"
        End If

        If peticion = 1 Then
            BindingSource1.DataSource = Nothing
            DGdatos.DataSource = Nothing
            DGdatos.Refresh()
            Dim respuesta As String = ObjConexion.Consulta(BindingSource1, Trim(SQLconsulta & where1))
            If respuesta = "OK" Then
                Footer.BindingSource = BindingSource1
                DGdatos.DataSource = BindingSource1
                DGpropiedades()
                RBestados_todos.Checked = True
            ElseIf respuesta = "KO" Then
                MessageBox.Show("No hay datos que coincidan con tus criterios de búsqueda",
           tituloAPP,
           MessageBoxButtons.OK,
           MessageBoxIcon.Information)
                BTNfiltro.PerformClick()
            Else
                BTNfiltro.PerformClick()
            End If
        End If
        TXTconsulta.Text = ""
    End Sub
    Private Sub TXTconsulta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTconsulta.KeyPress
        'Utilidades.AceptaNumerosLetrasEspacio(e)
    End Sub

    Private Sub TXTconsulta_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTconsulta.KeyDown
        If e.KeyData = Keys.Enter Then
            BTNbuscar.PerformClick()
        End If
    End Sub

    Private Sub TXTconsulta_MouseHover(sender As Object, e As EventArgs) Handles TXTconsulta.MouseHover
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(TXTconsulta, "Búsqueda por código o nombre del producto o servicio")
    End Sub
    Private Sub BTNexportar_Click(sender As Object, e As EventArgs) Handles BTNexportar.Click
        Dim dtSource As DataTable
        dtSource = Nothing
        dtSource = BindingSource1.DataSource 'DGdatos.DataSource
        Dim NombreArchivo As String = ""
        If BindingSource1.Count > 0 Then
            'DGdatos.RowCount > 0 Then
            Dim save As New SaveFileDialog
            save.Filter = "ARCHIVO XML (*.xml)|*.xml"
            If RBestados_activos.Checked = True Then
                NombreArchivo = "(Activos)"
            ElseIf RBestados_inactivos.Checked = True Then
                NombreArchivo = "(Inactivos)"
            Else
                NombreArchivo = "(Todos)"
            End If

            save.FileName = Trim("REPORTE DE " & LBLmodulo.Text & " " & NombreArchivo & " GENERADO EL " & Format(Now.Day, "00") & "-" & Format(Now.Month, "00") & " - " & Now.Year & ".xls") 'xml
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                'If Not IO.File.Exists(save.FileName) Then
                Dim fs As System.IO.FileStream
                Dim xtw As System.Xml.XmlTextWriter
                dtSource.TableName = "items"
                fs = New System.IO.FileStream(save.FileName, IO.FileMode.Create)
                xtw = New System.Xml.XmlTextWriter(fs, System.Text.Encoding.Unicode)
                xtw.WriteProcessingInstruction("xml", "version='1.0'")
                xtw.WriteProcessingInstruction("mso-application", "progid='Excel.Sheet'")
                dtSource.WriteXml(xtw)
                xtw.Close()
                'MsgBox("SE EXPORTO CORRECTAMENTE", MsgBoxStyle.Information, Utilidades.tituloAPP)
                'Utilidades.OpenCualquierArchivo(save.FileName)
            End If
        Else
            ''MsgBox("NO HAY DATOS QUE EXPORTAR", MsgBoxStyle.Critical, Utilidades.tituloAPP)
            Exit Sub
        End If

    End Sub


    Private Sub DGdatos_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGdatos.CellMouseEnter
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        Try
            If e.RowIndex >= 0 Then
                dgv(e.ColumnIndex, e.RowIndex).ToolTipText = "Doble clic en la celda para visualizar la información o realizar modificaciones"
                'String.Format("Col {0}, Fila {1}", e.ColumnIndex, e.RowIndex)
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class