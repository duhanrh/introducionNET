<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVentas))
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.Footer = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PBimagenmodulo = New System.Windows.Forms.PictureBox()
        Me.Header = New System.Windows.Forms.Panel()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtIdVenta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GbProducto = New System.Windows.Forms.GroupBox()
        Me.BtnAdicionar = New System.Windows.Forms.Button()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.TxtProducto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnBuscarProducto = New System.Windows.Forms.Button()
        Me.TxtIdProducto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GbCliente = New System.Windows.Forms.GroupBox()
        Me.BtnBuscarCliente = New System.Windows.Forms.Button()
        Me.TxtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtNit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GbDetalles = New System.Windows.Forms.GroupBox()
        Me.DgDetallesVenta = New System.Windows.Forms.DataGridView()
        Me.BTNcancelar = New System.Windows.Forms.Button()
        Me.BTNguardar = New System.Windows.Forms.Button()
        Me.GBdatos = New System.Windows.Forms.GroupBox()
        Me.GBacciones = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.RBrestaurar = New System.Windows.Forms.RadioButton()
        Me.RBnuevo = New System.Windows.Forms.RadioButton()
        Me.RBeliminar = New System.Windows.Forms.RadioButton()
        Me.RBactualizar = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Footer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Footer.SuspendLayout()
        CType(Me.PBimagenmodulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Header.SuspendLayout()
        Me.GbProducto.SuspendLayout()
        Me.GbCliente.SuspendLayout()
        Me.GbDetalles.SuspendLayout()
        CType(Me.DgDetallesVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBdatos.SuspendLayout()
        Me.GBacciones.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(58, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'Footer
        '
        Me.Footer.AddNewItem = Nothing
        Me.Footer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Footer.AutoSize = False
        Me.Footer.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Footer.CountItem = Me.BindingNavigatorCountItem
        Me.Footer.DeleteItem = Nothing
        Me.Footer.Dock = System.Windows.Forms.DockStyle.None
        Me.Footer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Footer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.Footer.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.Footer.Location = New System.Drawing.Point(28, 414)
        Me.Footer.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Footer.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Footer.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Footer.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Footer.Name = "Footer"
        Me.Footer.PositionItem = Me.BindingNavigatorPositionItem
        Me.Footer.Size = New System.Drawing.Size(1040, 25)
        Me.Footer.TabIndex = 33
        Me.Footer.Text = "BindingNavigator1"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PBimagenmodulo
        '
        Me.PBimagenmodulo.BackColor = System.Drawing.Color.Transparent
        Me.PBimagenmodulo.Image = CType(resources.GetObject("PBimagenmodulo.Image"), System.Drawing.Image)
        Me.PBimagenmodulo.Location = New System.Drawing.Point(28, 9)
        Me.PBimagenmodulo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PBimagenmodulo.Name = "PBimagenmodulo"
        Me.PBimagenmodulo.Size = New System.Drawing.Size(152, 55)
        Me.PBimagenmodulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBimagenmodulo.TabIndex = 17
        Me.PBimagenmodulo.TabStop = False
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Header.Controls.Add(Me.DtpFecha)
        Me.Header.Controls.Add(Me.Label9)
        Me.Header.Controls.Add(Me.TxtIdVenta)
        Me.Header.Controls.Add(Me.Label3)
        Me.Header.Controls.Add(Me.PBimagenmodulo)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1094, 72)
        Me.Header.TabIndex = 30
        '
        'DtpFecha
        '
        Me.DtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpFecha.Enabled = False
        Me.DtpFecha.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(546, 21)
        Me.DtpFecha.MinDate = New Date(2022, 1, 1, 0, 0, 0, 0)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(166, 39)
        Me.DtpFecha.TabIndex = 21
        Me.DtpFecha.Value = New Date(2022, 3, 1, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(462, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 32)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Fecha"
        '
        'TxtIdVenta
        '
        Me.TxtIdVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtIdVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.TxtIdVenta.Enabled = False
        Me.TxtIdVenta.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtIdVenta.ForeColor = System.Drawing.Color.White
        Me.TxtIdVenta.Location = New System.Drawing.Point(853, 21)
        Me.TxtIdVenta.Name = "TxtIdVenta"
        Me.TxtIdVenta.Size = New System.Drawing.Size(215, 39)
        Me.TxtIdVenta.TabIndex = 19
        Me.TxtIdVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(730, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 32)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "VENTA #"
        '
        'GbProducto
        '
        Me.GbProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbProducto.Controls.Add(Me.BtnAdicionar)
        Me.GbProducto.Controls.Add(Me.TxtCantidad)
        Me.GbProducto.Controls.Add(Me.Label8)
        Me.GbProducto.Controls.Add(Me.TxtPrecio)
        Me.GbProducto.Controls.Add(Me.TxtProducto)
        Me.GbProducto.Controls.Add(Me.Label7)
        Me.GbProducto.Controls.Add(Me.Label6)
        Me.GbProducto.Controls.Add(Me.BtnBuscarProducto)
        Me.GbProducto.Controls.Add(Me.TxtIdProducto)
        Me.GbProducto.Controls.Add(Me.Label5)
        Me.GbProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GbProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GbProducto.Location = New System.Drawing.Point(473, 17)
        Me.GbProducto.Name = "GbProducto"
        Me.GbProducto.Size = New System.Drawing.Size(553, 158)
        Me.GbProducto.TabIndex = 35
        Me.GbProducto.TabStop = False
        Me.GbProducto.Text = "Productos"
        '
        'BtnAdicionar
        '
        Me.BtnAdicionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAdicionar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnAdicionar.ForeColor = System.Drawing.Color.White
        Me.BtnAdicionar.Location = New System.Drawing.Point(335, 108)
        Me.BtnAdicionar.Name = "BtnAdicionar"
        Me.BtnAdicionar.Size = New System.Drawing.Size(40, 26)
        Me.BtnAdicionar.TabIndex = 9
        Me.BtnAdicionar.Text = "+"
        Me.BtnAdicionar.UseVisualStyleBackColor = False
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(180, 108)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(149, 26)
        Me.TxtCantidad.TabIndex = 8
        Me.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(180, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Cantidad"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Enabled = False
        Me.TxtPrecio.Location = New System.Drawing.Point(16, 108)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(155, 26)
        Me.TxtPrecio.TabIndex = 6
        '
        'TxtProducto
        '
        Me.TxtProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtProducto.Enabled = False
        Me.TxtProducto.Location = New System.Drawing.Point(180, 51)
        Me.TxtProducto.Name = "TxtProducto"
        Me.TxtProducto.Size = New System.Drawing.Size(356, 26)
        Me.TxtProducto.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Precio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(180, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Producto"
        '
        'BtnBuscarProducto
        '
        Me.BtnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnBuscarProducto.BackgroundImage = Global.Practica04.My.Resources.Resources.buscar
        Me.BtnBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBuscarProducto.ForeColor = System.Drawing.Color.White
        Me.BtnBuscarProducto.Location = New System.Drawing.Point(131, 51)
        Me.BtnBuscarProducto.Name = "BtnBuscarProducto"
        Me.BtnBuscarProducto.Size = New System.Drawing.Size(40, 26)
        Me.BtnBuscarProducto.TabIndex = 2
        Me.BtnBuscarProducto.UseVisualStyleBackColor = False
        '
        'TxtIdProducto
        '
        Me.TxtIdProducto.Location = New System.Drawing.Point(16, 51)
        Me.TxtIdProducto.Name = "TxtIdProducto"
        Me.TxtIdProducto.Size = New System.Drawing.Size(115, 26)
        Me.TxtIdProducto.TabIndex = 1
        Me.TxtIdProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Código"
        '
        'GbCliente
        '
        Me.GbCliente.Controls.Add(Me.BtnBuscarCliente)
        Me.GbCliente.Controls.Add(Me.TxtIdCliente)
        Me.GbCliente.Controls.Add(Me.Label10)
        Me.GbCliente.Controls.Add(Me.TxtNit)
        Me.GbCliente.Controls.Add(Me.Label4)
        Me.GbCliente.Controls.Add(Me.TxtApellidos)
        Me.GbCliente.Controls.Add(Me.TxtNombres)
        Me.GbCliente.Controls.Add(Me.Label1)
        Me.GbCliente.Controls.Add(Me.Label2)
        Me.GbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GbCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GbCliente.Location = New System.Drawing.Point(15, 17)
        Me.GbCliente.Name = "GbCliente"
        Me.GbCliente.Size = New System.Drawing.Size(448, 158)
        Me.GbCliente.TabIndex = 34
        Me.GbCliente.TabStop = False
        Me.GbCliente.Text = "Cliente"
        '
        'BtnBuscarCliente
        '
        Me.BtnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnBuscarCliente.BackgroundImage = Global.Practica04.My.Resources.Resources.buscar
        Me.BtnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBuscarCliente.ForeColor = System.Drawing.Color.White
        Me.BtnBuscarCliente.Location = New System.Drawing.Point(390, 51)
        Me.BtnBuscarCliente.Name = "BtnBuscarCliente"
        Me.BtnBuscarCliente.Size = New System.Drawing.Size(40, 26)
        Me.BtnBuscarCliente.TabIndex = 4
        Me.BtnBuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBuscarCliente.UseVisualStyleBackColor = False
        '
        'TxtIdCliente
        '
        Me.TxtIdCliente.Enabled = False
        Me.TxtIdCliente.Location = New System.Drawing.Point(16, 51)
        Me.TxtIdCliente.Name = "TxtIdCliente"
        Me.TxtIdCliente.Size = New System.Drawing.Size(203, 26)
        Me.TxtIdCliente.TabIndex = 1
        Me.TxtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(16, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Código"
        '
        'TxtNit
        '
        Me.TxtNit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNit.Location = New System.Drawing.Point(227, 51)
        Me.TxtNit.Name = "TxtNit"
        Me.TxtNit.Size = New System.Drawing.Size(163, 26)
        Me.TxtNit.TabIndex = 3
        Me.TxtNit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(227, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Identificación"
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Enabled = False
        Me.TxtApellidos.Location = New System.Drawing.Point(227, 108)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(203, 26)
        Me.TxtApellidos.TabIndex = 3
        '
        'TxtNombres
        '
        Me.TxtNombres.Enabled = False
        Me.TxtNombres.Location = New System.Drawing.Point(16, 108)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(203, 26)
        Me.TxtNombres.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(227, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido"
        '
        'GbDetalles
        '
        Me.GbDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbDetalles.Controls.Add(Me.DgDetallesVenta)
        Me.GbDetalles.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GbDetalles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GbDetalles.Location = New System.Drawing.Point(28, 271)
        Me.GbDetalles.Name = "GbDetalles"
        Me.GbDetalles.Size = New System.Drawing.Size(1040, 140)
        Me.GbDetalles.TabIndex = 36
        Me.GbDetalles.TabStop = False
        '
        'DgDetallesVenta
        '
        Me.DgDetallesVenta.AllowUserToAddRows = False
        Me.DgDetallesVenta.AllowUserToDeleteRows = False
        Me.DgDetallesVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgDetallesVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgDetallesVenta.Location = New System.Drawing.Point(3, 21)
        Me.DgDetallesVenta.Name = "DgDetallesVenta"
        Me.DgDetallesVenta.ReadOnly = True
        Me.DgDetallesVenta.RowTemplate.Height = 25
        Me.DgDetallesVenta.Size = New System.Drawing.Size(1034, 116)
        Me.DgDetallesVenta.TabIndex = 0
        Me.DgDetallesVenta.Visible = False
        '
        'BTNcancelar
        '
        Me.BTNcancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNcancelar.BackColor = System.Drawing.Color.DarkRed
        Me.BTNcancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTNcancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTNcancelar.ForeColor = System.Drawing.Color.White
        Me.BTNcancelar.Location = New System.Drawing.Point(781, 449)
        Me.BTNcancelar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BTNcancelar.Name = "BTNcancelar"
        Me.BTNcancelar.Size = New System.Drawing.Size(139, 44)
        Me.BTNcancelar.TabIndex = 31
        Me.BTNcancelar.Text = "Cancelar"
        Me.BTNcancelar.UseVisualStyleBackColor = False
        '
        'BTNguardar
        '
        Me.BTNguardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNguardar.BackColor = System.Drawing.Color.DarkRed
        Me.BTNguardar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTNguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTNguardar.ForeColor = System.Drawing.Color.White
        Me.BTNguardar.Location = New System.Drawing.Point(929, 449)
        Me.BTNguardar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BTNguardar.Name = "BTNguardar"
        Me.BTNguardar.Size = New System.Drawing.Size(139, 44)
        Me.BTNguardar.TabIndex = 30
        Me.BTNguardar.Text = "Cerrar"
        Me.BTNguardar.UseVisualStyleBackColor = False
        '
        'GBdatos
        '
        Me.GBdatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBdatos.Controls.Add(Me.GbCliente)
        Me.GBdatos.Controls.Add(Me.GbProducto)
        Me.GBdatos.Location = New System.Drawing.Point(28, 83)
        Me.GBdatos.Name = "GBdatos"
        Me.GBdatos.Size = New System.Drawing.Size(1040, 186)
        Me.GBdatos.TabIndex = 38
        Me.GBdatos.TabStop = False
        '
        'GBacciones
        '
        Me.GBacciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBacciones.Controls.Add(Me.TableLayoutPanel1)
        Me.GBacciones.Location = New System.Drawing.Point(28, 442)
        Me.GBacciones.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GBacciones.Name = "GBacciones"
        Me.GBacciones.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GBacciones.Size = New System.Drawing.Size(731, 51)
        Me.GBacciones.TabIndex = 39
        Me.GBacciones.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.RBrestaurar, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RBnuevo, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RBeliminar, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RBactualizar, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(11, 11)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(708, 33)
        Me.TableLayoutPanel1.TabIndex = 13
        '
        'RBrestaurar
        '
        Me.RBrestaurar.AutoSize = True
        Me.RBrestaurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RBrestaurar.ForeColor = System.Drawing.Color.DarkRed
        Me.RBrestaurar.Location = New System.Drawing.Point(535, 3)
        Me.RBrestaurar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RBrestaurar.Name = "RBrestaurar"
        Me.RBrestaurar.Size = New System.Drawing.Size(98, 24)
        Me.RBrestaurar.TabIndex = 3
        Me.RBrestaurar.Text = "Restaurar"
        Me.RBrestaurar.UseVisualStyleBackColor = True
        '
        'RBnuevo
        '
        Me.RBnuevo.AutoSize = True
        Me.RBnuevo.Checked = True
        Me.RBnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RBnuevo.ForeColor = System.Drawing.Color.DarkRed
        Me.RBnuevo.Location = New System.Drawing.Point(4, 3)
        Me.RBnuevo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RBnuevo.Name = "RBnuevo"
        Me.RBnuevo.Size = New System.Drawing.Size(72, 24)
        Me.RBnuevo.TabIndex = 0
        Me.RBnuevo.TabStop = True
        Me.RBnuevo.Text = "Nuevo"
        Me.RBnuevo.UseVisualStyleBackColor = True
        '
        'RBeliminar
        '
        Me.RBeliminar.AutoSize = True
        Me.RBeliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RBeliminar.ForeColor = System.Drawing.Color.DarkRed
        Me.RBeliminar.Location = New System.Drawing.Point(358, 3)
        Me.RBeliminar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RBeliminar.Name = "RBeliminar"
        Me.RBeliminar.Size = New System.Drawing.Size(83, 24)
        Me.RBeliminar.TabIndex = 2
        Me.RBeliminar.Text = "Eliminar"
        Me.RBeliminar.UseVisualStyleBackColor = True
        '
        'RBactualizar
        '
        Me.RBactualizar.AutoSize = True
        Me.RBactualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RBactualizar.ForeColor = System.Drawing.Color.DarkRed
        Me.RBactualizar.Location = New System.Drawing.Point(181, 3)
        Me.RBactualizar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RBactualizar.Name = "RBactualizar"
        Me.RBactualizar.Size = New System.Drawing.Size(97, 24)
        Me.RBactualizar.TabIndex = 1
        Me.RBactualizar.Text = "Actualizar"
        Me.RBactualizar.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton1.ForeColor = System.Drawing.Color.DarkRed
        Me.RadioButton1.Location = New System.Drawing.Point(535, 3)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(98, 24)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.Text = "Restaurar"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton2.ForeColor = System.Drawing.Color.DarkRed
        Me.RadioButton2.Location = New System.Drawing.Point(4, 3)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(72, 24)
        Me.RadioButton2.TabIndex = 0
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Nuevo"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 501)
        Me.Controls.Add(Me.GBacciones)
        Me.Controls.Add(Me.GBdatos)
        Me.Controls.Add(Me.BTNcancelar)
        Me.Controls.Add(Me.GbDetalles)
        Me.Controls.Add(Me.BTNguardar)
        Me.Controls.Add(Me.Footer)
        Me.Controls.Add(Me.Header)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MinimumSize = New System.Drawing.Size(1110, 540)
        Me.Name = "FrmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmVentas"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Footer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Footer.ResumeLayout(False)
        Me.Footer.PerformLayout()
        CType(Me.PBimagenmodulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        Me.GbProducto.ResumeLayout(False)
        Me.GbProducto.PerformLayout()
        Me.GbCliente.ResumeLayout(False)
        Me.GbCliente.PerformLayout()
        Me.GbDetalles.ResumeLayout(False)
        CType(Me.DgDetallesVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBdatos.ResumeLayout(False)
        Me.GBacciones.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents Footer As BindingNavigator
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PBimagenmodulo As PictureBox
    Friend WithEvents Header As Panel
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtIdVenta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GbProducto As GroupBox
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtProducto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnBuscarProducto As Button
    Friend WithEvents TxtIdProducto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GbCliente As GroupBox
    Friend WithEvents BtnBuscarCliente As Button
    Friend WithEvents TxtIdCliente As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtNit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GbDetalles As GroupBox
    Friend WithEvents DgDetallesVenta As DataGridView
    Friend WithEvents BTNcancelar As Button
    Friend WithEvents BTNguardar As Button
    Friend WithEvents GBdatos As GroupBox
    Friend WithEvents GBacciones As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents RBrestaurar As RadioButton
    Friend WithEvents RBnuevo As RadioButton
    Friend WithEvents RBeliminar As RadioButton
    Friend WithEvents RBactualizar As RadioButton
End Class
