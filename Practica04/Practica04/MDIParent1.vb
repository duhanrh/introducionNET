Imports System.Windows.Forms
Imports Practica04.CheckForm
Public Class MDIParent1
    ReadOnly title As String = "SHOPNET" 'ShopNet
    Dim VerFRM As New CheckForm
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NuevoVentasMenu.Click, NewWindowToolStripMenuItem.Click
        ' Cree una nueva instancia del formulario secundario.
        ListarVentasMenu.PerformClick()
        Dim FRM As New FrmVentas
        FRM.StartPosition = FormStartPosition.CenterScreen
        FRM.RBnuevo.Enabled = True
        FRM.RBnuevo.Checked = True
        FRM.GBdatos.Enabled = True
        FRM.RBactualizar.Enabled = False
        FRM.RBrestaurar.Enabled = False
        FRM.RBeliminar.Enabled = False
        Dim fechaActual As Date = Date.Now
        FRM.DtpFecha.Value = fechaActual
        FRM.BtnGuardar.Text = "Guardar"
        FRM.Text = "Nueva venta"
        FRM.Show()
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = title
    End Sub

    Private Sub MDIParent1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim frm As New AboutBox1
        frm.Text = "Acerca de " & title
        frm.ShowDialog()
    End Sub

    Private Sub ListarProductosMenu_Click(sender As Object, e As EventArgs) Handles ListarProductosMenu.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim frm As New FrmExploradorProductos
        frm.MdiParent = Me
        CenterToParent()
        m_ChildFormNumber += 1
        frm.Text = "Productos y servicios"
        frm.WindowState = FormWindowState.Maximized
        frm.StartPosition = FormStartPosition.CenterParent
        If VerFRM.EstaAbierto(frm) Then
            For Each ChildForm As Form In Me.MdiChildren
                If ChildForm.Name = frm.Name Then
                    ChildForm.Activate()
                    Exit For
                End If
            Next
        Else
            frm.RBestados_activos.Checked = True
            frm.Show()
        End If

    End Sub

    Private Sub NuevoProductosMenu_Click(sender As Object, e As EventArgs) Handles NuevoProductosMenu.Click
        ' Cree una nueva instancia del formulario secundario.
        ListarProductosMenu.PerformClick()
        Dim FRM As New FrmProducto
        FRM.StartPosition = FormStartPosition.CenterScreen
        FRM.RBnuevo.Enabled = True
        FRM.RBnuevo.Checked = True
        FRM.GBdatos.Enabled = True
        FRM.RBactualizar.Enabled = False
        FRM.RBrestaurar.Enabled = False
        FRM.RBeliminar.Enabled = False
        FRM.BTNguardar.Text = "Guardar"
        FRM.Text = "Nuevo producto o servicio"
        FRM.Show()
    End Sub

    Private Sub ListarClientesMenu_Click(sender As Object, e As EventArgs) Handles ListarClientesMenu.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim frm As New FrmExploradorClientes
        frm.MdiParent = Me
        CenterToParent()
        m_ChildFormNumber += 1
        frm.Text = "Clientes"
        frm.WindowState = FormWindowState.Maximized
        frm.StartPosition = FormStartPosition.CenterParent
        If VerFRM.EstaAbierto(frm) Then
            For Each ChildForm As Form In Me.MdiChildren
                If ChildForm.Name = frm.Name Then
                    ChildForm.Activate()
                    Exit For
                End If
            Next
        Else
            frm.RBestados_activos.Checked = True
            frm.Show()
        End If
    End Sub
    Private Sub NuevoClientesMenu_Click(sender As Object, e As EventArgs) Handles NuevoClientesMenu.Click
        ' Cree una nueva instancia del formulario secundario.
        ListarClientesMenu.PerformClick()
        Dim FRM As New FrmCliente
        FRM.StartPosition = FormStartPosition.CenterScreen
        FRM.RBnuevo.Enabled = True
        FRM.RBnuevo.Checked = True
        FRM.GBdatos.Enabled = True
        FRM.RBactualizar.Enabled = False
        FRM.RBrestaurar.Enabled = False
        FRM.RBeliminar.Enabled = False
        FRM.BTNguardar.Text = "Guardar"
        FRM.Text = "Nuevo cliente"
        FRM.Show()
    End Sub

    Private Sub ListarVentasMenu_Click(sender As Object, e As EventArgs) Handles ListarVentasMenu.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim frm As New FrmExploradorVentas
        frm.MdiParent = Me
        CenterToParent()
        m_ChildFormNumber += 1
        frm.Text = "Ventas"
        frm.WindowState = FormWindowState.Maximized
        frm.StartPosition = FormStartPosition.CenterParent
        If VerFRM.EstaAbierto(frm) Then
            For Each ChildForm As Form In Me.MdiChildren
                If ChildForm.Name = frm.Name Then
                    ChildForm.Activate()
                    Exit For
                End If
            Next
        Else
            'frm.RBestados_activos.Checked = True
            frm.Show()
        End If
    End Sub
End Class
