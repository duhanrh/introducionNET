'Imports Sisbacon.Conexion
'Imports Sisbacon.Utilidades
'Imports modpc = Sisbacon.ModUtilidadesPC
'Imports System
'Imports System.Globalization
'Imports System.Xml
'Imports System.Xml.XPath
'Imports Sisbacon.GenerarTicket
Public Class FrmExploradorCompras
    '    Dim ObjConexion As New Conexion
    '    Dim Utilidades As New Utilidades
    '    Dim Ticket As New GenerarTicket
    '    'Dim SqlCompras As String = "SELECT com.IDcompra, com.fecha_creacion, com.IDsolicitante as CodSolicitante, (SELECT tere.nombre FROM tblterceros as tere WHERE tere.IDtercero=IDsolicitante) AS Solicitante, com.IDproveedor as CodProveedo, CONCAT(terp.nombre, ' (',tn.codigo, ' ', terp.nit ,')') as Proveedor, com.observaciones as Nota, com.estado as Estado, com.activo as Activa FROM tblcompras as com INNER JOIN tblterceros AS terp ON com.IDproveedor=terp.IDtercero LEFT JOIN tbltipos_nit as tn ON terp.IDtipo_nit=tn.IDtipo_nit" 'prioridad proveedor
    '    Dim SqlCompras As String = "SELECT * FROM Vista_Explorador_Compras " '"SELECT com.IDcompra, com.fecha_creacion, com.IDsolicitante as CodSolicitante, FC_NOMBRE_TERCERO(com.IDsolicitante) AS Solicitante, com.IDproveedor as CodProveedor, terp.nombre as Proveedor, com.observaciones as Nota, com.estado as Estado, com.activo as Activa FROM tblcompras as com LEFT JOIN tblterceros AS terp ON com.IDproveedor=terp.IDtercero LEFT JOIN tbltipos_nit as tn ON terp.IDtipo_nit=tn.IDtipo_nit"
    '    Dim SqlRequesicion As String = "SELECT * FROM Vista_Explorador_Compras_Requerimientos " '"SELECT req.IDrequisicion, req.fecha_creacion, req.IDsolicitante as CodSolicitante, ter.nombre as Solicitante, req.IDproveedor as CodProveedor, IFNULL(FC_NOMBRE_TERCERO(req.IDproveedor),'SIN PROVEEDOR') as Proveedor, req.IDproducto, pro.nombre, req.cantidad, req.origen, req.destino, req.aprobada, req.activo FROM tblcompras_requisiciones as req LEFT JOIN tblterceros as ter ON ter.IDtercero=req.IDsolicitante left JOIN tblproductos as pro ON req.IDproducto=pro.IDproducto"
    '    Dim IdTercero As Integer = 0

    '    Private Sub FrmExploradorCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
    '        Me.SetStyle(ControlStyles.UserPaint, True)
    '        Utilidades.PropiedadesExplorador(Me)
    '        TXTfecha_corte.MaxDate = Today
    '        TXTfecha_corte.Value = Today
    '        TXTfecha_inicio.MaxDate = Today
    '        TXTfecha_inicio.Value = Today.AddDays(-31)
    '        RBrequisiciones.Checked = True
    '        If ObjConexion.Consulta(BindingSource1, Trim(SqlRequesicion & " WHERE Aprobada='N' AND Activo='S'")) = "OK" Then '" WHERE req.aprobada='N' AND req.activo='S'"
    '            Footer.BindingSource = BindingSource1
    '            DGdatos.DataSource = BindingSource1
    '            DGpropiedades()
    '        End If
    '        modpc.LiberarMemoria()
    '    End Sub
    '    Sub SinChecked()
    '        FrmCompras.RBnuevo.Checked = False
    '        FrmCompras.RBactualizar.Checked = False
    '        FrmCompras.RBrestaurar.Checked = False
    '        FrmCompras.RBeliminar.Checked = False
    '        FrmCompras.BTNguardar.Text = "Cerrar"
    '    End Sub

    '    Sub SinChecked2()
    '        FrmCompras2.RBnuevo.Checked = False
    '        FrmCompras2.RBactualizar.Checked = False
    '        FrmCompras2.RBrestaurar.Checked = False
    '        FrmCompras2.RBeliminar.Checked = False
    '        FrmCompras2.RBaprobar.Checked = False
    '        FrmCompras2.BTNguardar.Text = "Cerrar"
    '    End Sub
    '    Sub DGpropiedades()
    '        'DGdatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    '        DGdatos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '        DGdatos.ReadOnly = True
    '        If RBcompras.Checked = True Then
    '            DGdatos.Columns(0).Width = 90
    '            DGdatos.Columns(1).Width = 100
    '            DGdatos.Columns(2).Width = 100
    '            DGdatos.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    '            DGdatos.Columns(4).Width = 100
    '            DGdatos.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    '            DGdatos.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    '            DGdatos.Columns(7).Width = 90
    '            DGdatos.Columns(8).Width = 90
    '            DGdatos.Columns(0).HeaderText = "OC #"
    '            DGdatos.Columns(1).HeaderText = "FECHA EMISIÓN"
    '            DGdatos.Columns(2).HeaderText = "CODSOLICITANTE"
    '            DGdatos.Columns(3).HeaderText = "SOLICITANTE"
    '            DGdatos.Columns(4).HeaderText = "CODPROVEEDOR"
    '            DGdatos.Columns(5).HeaderText = "PROVEEDOR"
    '            DGdatos.Columns(6).HeaderText = "OBSERVACIONES"
    '            DGdatos.Columns(7).HeaderText = "ESTADO"
    '            DGdatos.Columns(8).HeaderText = "ACTIVA"
    '            DGdatos.Columns(2).Visible = False
    '            DGdatos.Columns(4).Visible = False
    '            DGdatos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '            DGdatos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
    '            DGdatos.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '            DGdatos.Columns(0).DefaultCellStyle.Format = "00000"
    '            DGdatos.Columns(2).DefaultCellStyle.Format = "00000"
    '            DGdatos.Columns(4).DefaultCellStyle.Format = "00000"
    '        Else
    '            DGdatos.Columns(0).Width = 90
    '            DGdatos.Columns(1).Width = 100
    '            DGdatos.Columns(2).Width = 100
    '            DGdatos.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    '            DGdatos.Columns(4).Width = 100
    '            DGdatos.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    '            DGdatos.Columns(6).Width = 100
    '            DGdatos.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    '            DGdatos.Columns(8).Width = 100
    '            DGdatos.Columns(9).Width = 100
    '            DGdatos.Columns(10).Width = 100
    '            DGdatos.Columns(11).Width = 100
    '            DGdatos.Columns(12).Width = 80
    '            DGdatos.Columns(0).HeaderText = "REQ #"
    '            DGdatos.Columns(1).HeaderText = "FECHA EMISIÓN"
    '            DGdatos.Columns(2).HeaderText = "CODSOLICITANTE"
    '            DGdatos.Columns(3).HeaderText = "SOLICITANTE"
    '            DGdatos.Columns(4).HeaderText = "CODPROVEEDOR"
    '            DGdatos.Columns(5).HeaderText = "PROVEEDOR"
    '            DGdatos.Columns(6).HeaderText = "CODPRODUCTO"
    '            DGdatos.Columns(7).HeaderText = "PRODUCTO / SERVICIO"
    '            DGdatos.Columns(8).HeaderText = "CANTIDAD"
    '            DGdatos.Columns(9).HeaderText = "ORIGEN"
    '            DGdatos.Columns(10).HeaderText = "DESTINO"
    '            DGdatos.Columns(11).HeaderText = "APROBADA"
    '            DGdatos.Columns(12).HeaderText = "ACTIVA"
    '            DGdatos.Columns(2).Visible = False
    '            DGdatos.Columns(4).Visible = False
    '            DGdatos.Columns(6).Visible = False
    '            DGdatos.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '            DGdatos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '            DGdatos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '            DGdatos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
    '            DGdatos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '            DGdatos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
    '            DGdatos.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '            DGdatos.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
    '            DGdatos.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    '            DGdatos.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
    '            DGdatos.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '            DGdatos.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '            DGdatos.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '            DGdatos.Columns(0).DefaultCellStyle.Format = "00000"
    '            DGdatos.Columns(2).DefaultCellStyle.Format = "00000"
    '            DGdatos.Columns(4).DefaultCellStyle.Format = "00000"
    '            DGdatos.Columns(6).DefaultCellStyle.Format = "00000"
    '        End If
    '    End Sub
    '    Private Sub BTNnuevo_Click(sender As Object, e As EventArgs) Handles BTNnuevo.Click
    '        If RBcompras.Checked = True Then
    '            'Dim FRM As New FrmCompras
    '            'FRM.StartPosition = FormStartPosition.CenterScreen
    '            'SinChecked()
    '            'FRM.RBnuevo.Enabled = True
    '            'FRM.RBnuevo.Checked = True
    '            'FRM.GBdatos.Enabled = True
    '            'FRM.RBactualizar.Enabled = False
    '            'FRM.RBrestaurar.Enabled = False
    '            'FRM.RBeliminar.Enabled = False
    '            'FRM.BTNguardar.Text = "Guardar"
    '            'FRM.LBLinformador.Text = ""
    '            'FRM.TabEntregas.Parent = Nothing
    '            'FRM.WindowState = FormWindowState.Maximized
    '            'FRM.ShowDialog()
    '            'RBestados_activos.Checked = True
    '            Dim FRM2 As New FrmCompras
    '            FRM2.MdiParent = Me.MdiParent
    '            SinChecked()
    '            FRM2.WindowState = FormWindowState.Maximized
    '            FRM2.StartPosition = FormStartPosition.CenterParent
    '            FRM2.RBnuevo.Enabled = True
    '            FRM2.RBnuevo.Checked = True
    '            FRM2.BTNcancelar.Enabled = True
    '            FRM2.Text = "Requerimientos y compras - Nueva solicitud"
    '            FRM2.BTNguardar.Text = "Guardar"
    '            FRM2.GBdatos.Enabled = True
    '            FRM2.GBdetalles.Enabled = True
    '            FRM2.RBactualizar.Enabled = False
    '            FRM2.RBrestaurar.Enabled = False
    '            FRM2.RBeliminar.Enabled = False
    '            FRM2.LBLinformador.Text = ""
    '            FRM2.Show()
    '            RBestados_activos.Checked = True
    '        Else
    '            Dim FRM2 As New FrmCompras2
    '            FRM2.StartPosition = FormStartPosition.CenterScreen
    '            SinChecked2()
    '            FRM2.RBnuevo.Enabled = True
    '            FRM2.RBnuevo.Checked = True
    '            FRM2.GBdatosSolicitud.Enabled = True
    '            FRM2.RBactualizar.Enabled = False
    '            FRM2.RBrestaurar.Enabled = False
    '            FRM2.RBeliminar.Enabled = False
    '            FRM2.RBaprobar.Enabled = False
    '            FRM2.BTNguardar.Text = "Guardar"
    '            FRM2.LBLinformador.Text = ""
    '            FRM2.GBacciones.Enabled = False
    '            FRM2.ShowDialog()
    '            'BTNfiltro.PerformClick()
    '        End If

    '        BTNfiltro.PerformClick()
    '    End Sub

    '    Private Sub BTNfiltro_Click(sender As Object, e As EventArgs) Handles BTNfiltro.Click
    '        Dim where1 As String = ""
    '        Dim where2 As String = ""
    '        If RBestados_activos.Checked = True Then
    '            If RBrequisiciones.Checked = True Then
    '                where1 = " WHERE Aprobada='N' AND Activo='S'" '" WHERE req.aprobada='N' AND req.activo='S'"
    '            Else
    '                where1 = " WHERE Activa='S' AND Estado<>'Recibida'" ' " WHERE com.activo='S' AND com.estado<>'Recibida'"
    '            End If
    '        ElseIf RBestados_inactivos.Checked = True Then
    '            If RBrequisiciones.Checked = True Then
    '                where1 = " WHERE Aprobada='S' AND Activo='S'" '" WHERE req.aprobada='S' AND req.activo='S'"
    '            Else
    '                where1 = " WHERE Activa='S' AND Estado='Recibida'" '" WHERE com.activo='S' AND com.estado='Recibida'"
    '            End If
    '        ElseIf RBestados_todos.Checked = True Then
    '            where1 = ""
    '        End If

    '        If RBconcorte.Checked = True Then
    '            If Trim(where1.Length) < 3 Then
    '                where2 = " WHERE "
    '            Else
    '                where2 = " AND "
    '            End If
    '            If RBrequisiciones.Checked = True Then
    '                where2 = where2 & " FechaCreacion >='" & Format(TXTfecha_inicio.Value, "yyyy-MM-dd") & "' AND FechaCreacion <='" & Format(TXTfecha_corte.Value, "yyyy-MM-dd") & "'" 'where2 & " req.fecha_creacion >='" & Format(TXTfecha_inicio.Value, "yyyy-MM-dd") & "' AND req.fecha_creacion <='" & Format(TXTfecha_corte.Value, "yyyy-MM-dd") & "'"
    '            Else
    '                where2 = where2 & " FechaCreacion >='" & Format(TXTfecha_inicio.Value, "yyyy-MM-dd") & "' AND FechaCreacion <='" & Format(TXTfecha_corte.Value, "yyyy-MM-dd") & "'" 'where2 & " com.fecha_creacion >='" & Format(TXTfecha_inicio.Value, "yyyy-MM-dd") & "' AND com.fecha_creacion <='" & Format(TXTfecha_corte.Value, "yyyy-MM-dd") & "'"
    '            End If
    '        Else
    '            where2 = ""
    '        End If
    '        'DGclientes.Rows.Clear()
    '        DGdatos.DataSource = Nothing
    '        DGdatos.Refresh()
    '        BindingSource1.DataSource = Nothing
    '        If RBrequisiciones.Checked = True Then
    '            If ObjConexion.Consulta(BindingSource1, Trim(SqlRequesicion & where1 & where2)) = "OK" Then
    '                Footer.BindingSource = BindingSource1
    '                DGdatos.DataSource = BindingSource1
    '                DGpropiedades()
    '            End If
    '        Else
    '            If ObjConexion.Consulta(BindingSource1, Trim(SqlCompras & where1 & where2)) = "OK" Then
    '                Footer.BindingSource = BindingSource1
    '                DGdatos.DataSource = BindingSource1
    '                DGpropiedades()
    '            End If
    '        End If
    '        modpc.LiberarMemoria()
    '    End Sub

    '    Private Sub DGdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGdatos.CellDoubleClick
    '        If RBcompras.Checked = True Then
    '            Try
    '                IdTercero = DGdatos.CurrentRow.Cells(0).Value
    '                FrmCompras.MdiParent = Me.MdiParent
    '                FrmCompras.TXTid.Text = Format(DGdatos.CurrentRow.Cells(0).Value, "00000")
    '                FrmCompras.Text = "Requerimientos y compras - OC # " & Format(DGdatos.CurrentRow.Cells(0).Value, "00000")
    '                FrmCompras.RBnuevo.Enabled = False
    '                FrmCompras.GBdatos.Enabled = False
    '                SinChecked()
    '                If DGdatos.CurrentRow.Cells(8).Value.ToString = "N" Then
    '                    FrmCompras.RBactualizar.Enabled = False
    '                    FrmCompras.RBrestaurar.Enabled = True
    '                    FrmCompras.RBeliminar.Enabled = False
    '                Else
    '                    FrmCompras.RBactualizar.Enabled = True
    '                    FrmCompras.RBrestaurar.Enabled = False
    '                    FrmCompras.RBeliminar.Enabled = True
    '                End If
    '                FrmCompras.WindowState = FormWindowState.Maximized
    '                'FrmCompras.ShowDialog()
    '                FrmCompras.Show()
    '                BTNfiltro.PerformClick()
    '            Catch ex As Exception

    '            End Try
    '        Else
    '            Try
    '                IdTercero = DGdatos.CurrentRow.Cells(0).Value
    '                FrmCompras2.TXTid.Text = Format(DGdatos.CurrentRow.Cells(0).Value, "00000")
    '                FrmCompras2.RBnuevo.Enabled = False
    '                FrmCompras2.GBdatosProveedor.Enabled = False
    '                SinChecked2()
    '                FrmCompras2.ShowDialog()
    '                BTNfiltro.PerformClick()
    '            Catch ex As Exception

    '            End Try
    '            'MsgBox("Las requisiciones no se pueden editar", MsgBoxStyle.Information, Utilidades.tituloAPP)
    '        End If

    '    End Sub

    '    Private Sub BTNbuscar_Click(sender As Object, e As EventArgs) Handles BTNbuscar.Click
    '        Dim peticion As Integer = 0
    '        Dim where1 As String = ""
    '        Dim SQLconsulta As String = Nothing
    '        If Len(TXTconsulta.Text.Trim) >= 1 Then
    '            peticion = 1
    '            If RBrequisiciones.Checked = True Then
    '                SQLconsulta = SqlRequesicion
    '                If IsNumeric(TXTconsulta.Text.Trim) = False Then
    '                    where1 = " WHERE Solicitante Like '%" & TXTconsulta.Text.Trim & "%' OR Proveedor Like '%" & TXTconsulta.Text.Trim & "%' OR Producto Like '%" & TXTconsulta.Text.Trim & "%' ORDER BY FechaCreacion ASC" '" WHERE ter.nombre Like '%" & TXTconsulta.Text & "%' OR pro.nombre Like '%" & TXTconsulta.Text & "%' ORDER BY req.fecha_creacion ASC"
    '                Else
    '                    where1 = " WHERE CodSolicitud=" & Val(TXTconsulta.Text.Trim) & "" '" WHERE req.IDrequisicion=" & Val(TXTconsulta.Text.Trim) & ""
    '                End If
    '            Else
    '                SQLconsulta = SqlCompras
    '                If IsNumeric(TXTconsulta.Text.Trim) = False Then
    '                    where1 = " WHERE Solicitante Like '%" & TXTconsulta.Text.Trim & "%' OR Proveedor Like '%" & TXTconsulta.Text.Trim & "%' ORDER BY CodCompra ASC" ' " WHERE terp.nombre Like '%" & TXTconsulta.Text & "%' ORDER BY com.IDcompra ASC"
    '                Else
    '                    where1 = " WHERE CodCompra=" & Val(TXTconsulta.Text.Trim) & "" '" WHERE com.IDcompra=" & Val(TXTconsulta.Text.Trim) & ""
    '                End If
    '            End If
    '        End If
    '        'DGclientes.Rows.Clear()
    '        If peticion = 1 Then
    '            BindingSource1.DataSource = Nothing
    '            DGdatos.DataSource = Nothing
    '            DGdatos.Refresh()
    '            If ObjConexion.Consulta(BindingSource1, Trim(SQLconsulta & where1)) = "OK" Then
    '                Footer.BindingSource = BindingSource1
    '                DGdatos.DataSource = BindingSource1
    '                DGpropiedades()
    '                RBestados_todos.Checked = True
    '            Else
    '                BTNfiltro.PerformClick()
    '            End If
    '        End If
    '        TXTconsulta.Text = ""
    '    End Sub
    '    Private Sub TXTconsulta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTconsulta.KeyPress
    '        Utilidades.AceptaNumerosLetrasEspacio(e)
    '    End Sub

    '    Private Sub TXTconsulta_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTconsulta.KeyDown
    '        If e.KeyData = Keys.Enter Then
    '            BTNbuscar.PerformClick()
    '        End If
    '    End Sub

    '    Private Sub TXTconsulta_MouseHover(sender As Object, e As EventArgs) Handles TXTconsulta.MouseHover
    '        Me.ToolTip1.IsBalloon = True
    '        If RBrequisiciones.Checked = True Then
    '            Me.ToolTip1.SetToolTip(TXTconsulta, "Búsqueda por solicitante, nombre de producto o por código de la requisición")
    '        Else
    '            Me.ToolTip1.SetToolTip(TXTconsulta, "Búsqueda por nombre proveedor o por código de la compra")
    '        End If
    '    End Sub
    '    Private Sub BTNexportar_Click(sender As Object, e As EventArgs) Handles BTNexportar.Click
    '        Dim dtSource As DataTable
    '        dtSource = Nothing
    '        dtSource = BindingSource1.DataSource 'DGdatos.DataSource
    '        Dim NombreArchivo As String = ""
    '        If BindingSource1.Count > 0 Then
    '            'DGdatos.RowCount > 0 Then
    '            Dim save As New SaveFileDialog
    '            save.Filter = "ARCHIVO XML (*.xml)|*.xml"
    '            If RBestados_activos.Checked = True Then
    '                NombreArchivo = "(Activos)"
    '            ElseIf RBestados_inactivos.Checked = True Then
    '                NombreArchivo = "(Inactivos)"
    '            Else
    '                NombreArchivo = "(Todos)"
    '            End If

    '            save.FileName = Trim("REPORTE DE " & LBLmodulo.Text & " " & NombreArchivo & " GENERADO EL " & Format(Now.Day, "00") & "-" & Format(Now.Month, "00") & " - " & Now.Year & ".xls") 'xml
    '            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
    '                'If Not IO.File.Exists(save.FileName) Then
    '                Dim fs As System.IO.FileStream
    '                Dim xtw As System.Xml.XmlTextWriter
    '                dtSource.TableName = "items"
    '                fs = New System.IO.FileStream(save.FileName, IO.FileMode.Create)
    '                xtw = New System.Xml.XmlTextWriter(fs, System.Text.Encoding.Unicode)
    '                xtw.WriteProcessingInstruction("xml", "version='1.0'")
    '                xtw.WriteProcessingInstruction("mso-application", "progid='Excel.Sheet'")
    '                dtSource.WriteXml(xtw)
    '                xtw.Close()
    '                'MsgBox("SE EXPORTO CORRECTAMENTE", MsgBoxStyle.Information, Utilidades.tituloAPP)
    '                Utilidades.OpenCualquierArchivo(save.FileName)
    '            End If
    '        Else
    '            MsgBox("NO HAY DATOS QUE EXPORTAR", MsgBoxStyle.Critical, Utilidades.tituloAPP)
    '            Exit Sub
    '        End If

    '    End Sub

    '    Private Sub RBrequisiciones_CheckedChanged(sender As Object, e As EventArgs) Handles RBrequisiciones.CheckedChanged
    '        If RBrequisiciones.Checked = True Then
    '            'DGdatos.Columns(0).HeaderText = "CODIGO"
    '            'GBestados.Enabled = False
    '            RBestados_todos.Checked = False
    '            RBestados_activos.Checked = True
    '            RBestados_activos.Text = "Sin aprobar"
    '            RBestados_inactivos.Text = "Aprobadas"
    '            RBestados_inactivos.Checked = False
    '            Try
    '                BTNfiltro.PerformClick()
    '            Catch ex As Exception
    '            End Try
    '        End If
    '    End Sub

    '    Private Sub RBcompras_CheckedChanged(sender As Object, e As EventArgs) Handles RBcompras.CheckedChanged
    '        If RBcompras.Checked = True Then
    '            GBestados.Enabled = True
    '            RBestados_activos.Checked = True
    '            RBestados_activos.Text = "Pendientes"
    '            RBestados_inactivos.Text = "Recibidas"
    '            Try
    '                BTNfiltro.PerformClick()
    '            Catch ex As Exception

    '            End Try
    '        Else
    '            RBestados_activos.Text = "Sin aprobar"
    '            RBestados_inactivos.Text = "Aprobadas"
    '        End If

    '    End Sub

    '    Private Sub DGdatos_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGdatos.CellMouseEnter
    '        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
    '        Try
    '            If e.RowIndex >= 0 Then
    '                dgv(e.ColumnIndex, e.RowIndex).ToolTipText = "Doble clic en la celda para visualizar la información o realizar modificaciones"
    '                'String.Format("Col {0}, Fila {1}", e.ColumnIndex, e.RowIndex)
    '            End If
    '        Catch ex As Exception
    '        End Try
    '    End Sub

End Class