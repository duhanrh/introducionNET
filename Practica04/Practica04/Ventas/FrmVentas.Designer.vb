﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVentas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVentas))
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtIdVenta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.GbProducto = New System.Windows.Forms.GroupBox()
        Me.BtnAdicionar = New System.Windows.Forms.Button()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtProducto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnBuscarProducto = New System.Windows.Forms.Button()
        Me.TxtIdProducto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GbDetalles = New System.Windows.Forms.GroupBox()
        Me.DgDetallesVenta = New System.Windows.Forms.DataGridView()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbCliente.SuspendLayout()
        Me.GbProducto.SuspendLayout()
        Me.GbDetalles.SuspendLayout()
        CType(Me.DgDetallesVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelHeader.Controls.Add(Me.DtpFecha)
        Me.PanelHeader.Controls.Add(Me.Label9)
        Me.PanelHeader.Controls.Add(Me.TxtIdVenta)
        Me.PanelHeader.Controls.Add(Me.Label3)
        Me.PanelHeader.Controls.Add(Me.PictureBox1)
        Me.PanelHeader.Location = New System.Drawing.Point(2, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1033, 74)
        Me.PanelHeader.TabIndex = 0
        '
        'DtpFecha
        '
        Me.DtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpFecha.Enabled = False
        Me.DtpFecha.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(498, 17)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(166, 39)
        Me.DtpFecha.TabIndex = 4
        Me.DtpFecha.Value = New Date(2022, 3, 7, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(405, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 32)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Fecha"
        '
        'TxtIdVenta
        '
        Me.TxtIdVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtIdVenta.Enabled = False
        Me.TxtIdVenta.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtIdVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtIdVenta.Location = New System.Drawing.Point(803, 17)
        Me.TxtIdVenta.Name = "TxtIdVenta"
        Me.TxtIdVenta.Size = New System.Drawing.Size(215, 39)
        Me.TxtIdVenta.TabIndex = 2
        Me.TxtIdVenta.Text = "000001"
        Me.TxtIdVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtIdVenta.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(681, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 32)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "VENTA #"
        Me.Label3.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Practica04.My.Resources.Resources.ShopNet
        Me.PictureBox1.Location = New System.Drawing.Point(11, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        Me.GbCliente.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GbCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GbCliente.Location = New System.Drawing.Point(13, 77)
        Me.GbCliente.Name = "GbCliente"
        Me.GbCliente.Size = New System.Drawing.Size(435, 133)
        Me.GbCliente.TabIndex = 2
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
        Me.BtnBuscarCliente.Location = New System.Drawing.Point(384, 43)
        Me.BtnBuscarCliente.Name = "BtnBuscarCliente"
        Me.BtnBuscarCliente.Size = New System.Drawing.Size(40, 25)
        Me.BtnBuscarCliente.TabIndex = 4
        Me.BtnBuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBuscarCliente.UseVisualStyleBackColor = False
        '
        'TxtIdCliente
        '
        Me.TxtIdCliente.Enabled = False
        Me.TxtIdCliente.Location = New System.Drawing.Point(10, 43)
        Me.TxtIdCliente.Name = "TxtIdCliente"
        Me.TxtIdCliente.Size = New System.Drawing.Size(203, 25)
        Me.TxtIdCliente.TabIndex = 1
        Me.TxtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(10, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Código"
        '
        'TxtNit
        '
        Me.TxtNit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNit.Location = New System.Drawing.Point(221, 43)
        Me.TxtNit.Name = "TxtNit"
        Me.TxtNit.Size = New System.Drawing.Size(163, 25)
        Me.TxtNit.TabIndex = 3
        Me.TxtNit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(221, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Identificación"
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(221, 97)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(203, 25)
        Me.TxtApellidos.TabIndex = 3
        '
        'TxtNombres
        '
        Me.TxtNombres.Location = New System.Drawing.Point(10, 97)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(203, 25)
        Me.TxtNombres.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(221, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido"
        '
        'GbProducto
        '
        Me.GbProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbProducto.Controls.Add(Me.BtnAdicionar)
        Me.GbProducto.Controls.Add(Me.TxtCantidad)
        Me.GbProducto.Controls.Add(Me.Label8)
        Me.GbProducto.Controls.Add(Me.TxtPrecio)
        Me.GbProducto.Controls.Add(Me.Label7)
        Me.GbProducto.Controls.Add(Me.TxtProducto)
        Me.GbProducto.Controls.Add(Me.Label6)
        Me.GbProducto.Controls.Add(Me.BtnBuscarProducto)
        Me.GbProducto.Controls.Add(Me.TxtIdProducto)
        Me.GbProducto.Controls.Add(Me.Label5)
        Me.GbProducto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GbProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GbProducto.Location = New System.Drawing.Point(454, 77)
        Me.GbProducto.Name = "GbProducto"
        Me.GbProducto.Size = New System.Drawing.Size(569, 133)
        Me.GbProducto.TabIndex = 3
        Me.GbProducto.TabStop = False
        Me.GbProducto.Text = "Productos"
        '
        'BtnAdicionar
        '
        Me.BtnAdicionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAdicionar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnAdicionar.ForeColor = System.Drawing.Color.White
        Me.BtnAdicionar.Location = New System.Drawing.Point(327, 97)
        Me.BtnAdicionar.Name = "BtnAdicionar"
        Me.BtnAdicionar.Size = New System.Drawing.Size(40, 25)
        Me.BtnAdicionar.TabIndex = 9
        Me.BtnAdicionar.Text = "+"
        Me.BtnAdicionar.UseVisualStyleBackColor = False
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(172, 97)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(149, 25)
        Me.TxtCantidad.TabIndex = 8
        Me.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(172, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Cantidad"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Enabled = False
        Me.TxtPrecio.Location = New System.Drawing.Point(11, 97)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(155, 25)
        Me.TxtPrecio.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(11, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Precio"
        '
        'TxtProducto
        '
        Me.TxtProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtProducto.Enabled = False
        Me.TxtProducto.Location = New System.Drawing.Point(172, 43)
        Me.TxtProducto.Name = "TxtProducto"
        Me.TxtProducto.Size = New System.Drawing.Size(387, 25)
        Me.TxtProducto.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(172, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
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
        Me.BtnBuscarProducto.Location = New System.Drawing.Point(126, 43)
        Me.BtnBuscarProducto.Name = "BtnBuscarProducto"
        Me.BtnBuscarProducto.Size = New System.Drawing.Size(40, 25)
        Me.BtnBuscarProducto.TabIndex = 2
        Me.BtnBuscarProducto.UseVisualStyleBackColor = False
        '
        'TxtIdProducto
        '
        Me.TxtIdProducto.Location = New System.Drawing.Point(11, 43)
        Me.TxtIdProducto.Name = "TxtIdProducto"
        Me.TxtIdProducto.Size = New System.Drawing.Size(115, 25)
        Me.TxtIdProducto.TabIndex = 1
        Me.TxtIdProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(11, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Código"
        '
        'GbDetalles
        '
        Me.GbDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbDetalles.Controls.Add(Me.DgDetallesVenta)
        Me.GbDetalles.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GbDetalles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GbDetalles.Location = New System.Drawing.Point(13, 216)
        Me.GbDetalles.Name = "GbDetalles"
        Me.GbDetalles.Size = New System.Drawing.Size(1010, 211)
        Me.GbDetalles.TabIndex = 4
        Me.GbDetalles.TabStop = False
        Me.GbDetalles.Text = "Detalles de la venta"
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
        Me.DgDetallesVenta.Size = New System.Drawing.Size(1004, 187)
        Me.DgDetallesVenta.TabIndex = 0
        Me.DgDetallesVenta.Visible = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Location = New System.Drawing.Point(4, 3)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(77, 27)
        Me.BtnGuardar.TabIndex = 0
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(89, 3)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(77, 27)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnGuardar, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnCancelar, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(853, 465)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(170, 33)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 507)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.GbDetalles)
        Me.Controls.Add(Me.GbProducto)
        Me.Controls.Add(Me.GbCliente)
        Me.Controls.Add(Me.PanelHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1051, 499)
        Me.Name = "FrmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbCliente.ResumeLayout(False)
        Me.GbCliente.PerformLayout()
        Me.GbProducto.ResumeLayout(False)
        Me.GbProducto.PerformLayout()
        Me.GbDetalles.ResumeLayout(False)
        CType(Me.DgDetallesVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents GbCliente As GroupBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtIdVenta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNit As TextBox
    Friend WithEvents GbProducto As GroupBox
    Friend WithEvents GbDetalles As GroupBox
    Friend WithEvents DgDetallesVenta As DataGridView
    Friend WithEvents TxtProducto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnBuscarProducto As Button
    Friend WithEvents TxtIdProducto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtIdCliente As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnBuscarCliente As Button
End Class
