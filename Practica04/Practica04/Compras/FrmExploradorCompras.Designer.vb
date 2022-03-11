<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExploradorCompras
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExploradorCompras))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTNbuscar = New System.Windows.Forms.Button()
        Me.TXTconsulta = New System.Windows.Forms.TextBox()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.Footer = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BTNexportar = New System.Windows.Forms.Button()
        Me.BTNfiltro = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DGdatos = New System.Windows.Forms.DataGridView()
        Me.BTNnuevo = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RBcompras = New System.Windows.Forms.RadioButton()
        Me.RBrequisiciones = New System.Windows.Forms.RadioButton()
        Me.GBestados = New System.Windows.Forms.GroupBox()
        Me.RBestados_activos = New System.Windows.Forms.RadioButton()
        Me.RBestados_todos = New System.Windows.Forms.RadioButton()
        Me.RBestados_inactivos = New System.Windows.Forms.RadioButton()
        Me.PBimagenmodulo = New System.Windows.Forms.PictureBox()
        Me.Header = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RBsincorte = New System.Windows.Forms.RadioButton()
        Me.RBconcorte = New System.Windows.Forms.RadioButton()
        Me.TXTfecha_corte = New System.Windows.Forms.DateTimePicker()
        Me.TXTfecha_inicio = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LBLmodulo = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Footer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Footer.SuspendLayout()
        CType(Me.DGdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GBestados.SuspendLayout()
        CType(Me.PBimagenmodulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Header.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BTNbuscar)
        Me.GroupBox1.Controls.Add(Me.TXTconsulta)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(606, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 86)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'BTNbuscar
        '
        Me.BTNbuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNbuscar.BackColor = System.Drawing.SystemColors.Control
        'Me.BTNbuscar.BackgroundImage = Global.Sisbacon.My.Resources.Resources.Lupa
        Me.BTNbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNbuscar.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNbuscar.Location = New System.Drawing.Point(405, 37)
        Me.BTNbuscar.Name = "BTNbuscar"
        Me.BTNbuscar.Size = New System.Drawing.Size(37, 29)
        Me.BTNbuscar.TabIndex = 16
        Me.BTNbuscar.UseVisualStyleBackColor = False
        '
        'TXTconsulta
        '
        Me.TXTconsulta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTconsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTconsulta.Location = New System.Drawing.Point(11, 37)
        Me.TXTconsulta.Name = "TXTconsulta"
        Me.TXTconsulta.Size = New System.Drawing.Size(388, 29)
        Me.TXTconsulta.TabIndex = 15
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        Me.Footer.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Footer.CountItem = Me.BindingNavigatorCountItem
        Me.Footer.DeleteItem = Nothing
        Me.Footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Footer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Footer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.Footer.Location = New System.Drawing.Point(0, 568)
        Me.Footer.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Footer.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Footer.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Footer.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Footer.Name = "Footer"
        Me.Footer.PositionItem = Me.BindingNavigatorPositionItem
        Me.Footer.Size = New System.Drawing.Size(1282, 25)
        Me.Footer.TabIndex = 33
        Me.Footer.Text = "BindingNavigator1"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BTNexportar
        '
        Me.BTNexportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNexportar.BackColor = System.Drawing.SystemColors.Control
        'Me.BTNexportar.BackgroundImage = Global.Sisbacon.My.Resources.Resources.xls
        Me.BTNexportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNexportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNexportar.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNexportar.Location = New System.Drawing.Point(1063, 7)
        Me.BTNexportar.Name = "BTNexportar"
        Me.BTNexportar.Size = New System.Drawing.Size(98, 82)
        Me.BTNexportar.TabIndex = 28
        Me.BTNexportar.UseVisualStyleBackColor = False
        '
        'BTNfiltro
        '
        Me.BTNfiltro.BackColor = System.Drawing.SystemColors.Control
        'Me.BTNfiltro.BackgroundImage = Global.Sisbacon.My.Resources.Resources.Filtro
        Me.BTNfiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNfiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNfiltro.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNfiltro.Location = New System.Drawing.Point(501, 7)
        Me.BTNfiltro.Name = "BTNfiltro"
        Me.BTNfiltro.Size = New System.Drawing.Size(98, 82)
        Me.BTNfiltro.TabIndex = 7
        Me.BTNfiltro.UseVisualStyleBackColor = False
        '
        'DGdatos
        '
        Me.DGdatos.AllowUserToAddRows = False
        Me.DGdatos.AllowUserToDeleteRows = False
        Me.DGdatos.AllowUserToOrderColumns = True
        Me.DGdatos.BackgroundColor = System.Drawing.Color.White
        Me.DGdatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGdatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGdatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGdatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGdatos.EnableHeadersVisualStyles = False
        Me.DGdatos.Location = New System.Drawing.Point(3, 16)
        Me.DGdatos.Name = "DGdatos"
        Me.DGdatos.ReadOnly = True
        Me.DGdatos.Size = New System.Drawing.Size(1243, 362)
        Me.DGdatos.TabIndex = 9
        '
        'BTNnuevo
        '
        Me.BTNnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNnuevo.BackColor = System.Drawing.SystemColors.Control
        'Me.BTNnuevo.BackgroundImage = Global.Sisbacon.My.Resources.Resources.Add_column
        Me.BTNnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNnuevo.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNnuevo.Location = New System.Drawing.Point(1168, 7)
        Me.BTNnuevo.Name = "BTNnuevo"
        Me.BTNnuevo.Size = New System.Drawing.Size(98, 82)
        Me.BTNnuevo.TabIndex = 6
        Me.BTNnuevo.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.BTNexportar)
        Me.Panel2.Controls.Add(Me.BTNfiltro)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.BTNnuevo)
        Me.Panel2.Controls.Add(Me.GBestados)
        Me.Panel2.Location = New System.Drawing.Point(-1, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1285, 92)
        Me.Panel2.TabIndex = 32
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RBcompras)
        Me.GroupBox2.Controls.Add(Me.RBrequisiciones)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(17, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(151, 86)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TIPO"
        '
        'RBcompras
        '
        Me.RBcompras.AutoSize = True
        Me.RBcompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBcompras.Location = New System.Drawing.Point(10, 55)
        Me.RBcompras.Name = "RBcompras"
        Me.RBcompras.Size = New System.Drawing.Size(88, 24)
        Me.RBcompras.TabIndex = 14
        Me.RBcompras.Text = "Ordenes"
        Me.RBcompras.UseVisualStyleBackColor = True
        '
        'RBrequisiciones
        '
        Me.RBrequisiciones.AutoSize = True
        Me.RBrequisiciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBrequisiciones.Location = New System.Drawing.Point(10, 25)
        Me.RBrequisiciones.Name = "RBrequisiciones"
        Me.RBrequisiciones.Size = New System.Drawing.Size(104, 24)
        Me.RBrequisiciones.TabIndex = 11
        Me.RBrequisiciones.Text = "Solicitudes"
        Me.RBrequisiciones.UseVisualStyleBackColor = True
        '
        'GBestados
        '
        Me.GBestados.BackColor = System.Drawing.Color.Transparent
        Me.GBestados.Controls.Add(Me.RBestados_activos)
        Me.GBestados.Controls.Add(Me.RBestados_todos)
        Me.GBestados.Controls.Add(Me.RBestados_inactivos)
        Me.GBestados.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBestados.ForeColor = System.Drawing.Color.Black
        Me.GBestados.Location = New System.Drawing.Point(174, 3)
        Me.GBestados.Name = "GBestados"
        Me.GBestados.Size = New System.Drawing.Size(321, 86)
        Me.GBestados.TabIndex = 25
        Me.GBestados.TabStop = False
        Me.GBestados.Text = "Filtrar por estados"
        '
        'RBestados_activos
        '
        Me.RBestados_activos.AutoSize = True
        Me.RBestados_activos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBestados_activos.Location = New System.Drawing.Point(199, 35)
        Me.RBestados_activos.Name = "RBestados_activos"
        Me.RBestados_activos.Size = New System.Drawing.Size(107, 24)
        Me.RBestados_activos.TabIndex = 14
        Me.RBestados_activos.Text = "Pendientes"
        Me.RBestados_activos.UseVisualStyleBackColor = True
        '
        'RBestados_todos
        '
        Me.RBestados_todos.AutoSize = True
        Me.RBestados_todos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBestados_todos.Location = New System.Drawing.Point(12, 35)
        Me.RBestados_todos.Name = "RBestados_todos"
        Me.RBestados_todos.Size = New System.Drawing.Size(71, 24)
        Me.RBestados_todos.TabIndex = 11
        Me.RBestados_todos.Text = "Todas"
        Me.RBestados_todos.UseVisualStyleBackColor = True
        '
        'RBestados_inactivos
        '
        Me.RBestados_inactivos.AutoSize = True
        Me.RBestados_inactivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBestados_inactivos.Location = New System.Drawing.Point(92, 35)
        Me.RBestados_inactivos.Name = "RBestados_inactivos"
        Me.RBestados_inactivos.Size = New System.Drawing.Size(97, 24)
        Me.RBestados_inactivos.TabIndex = 12
        Me.RBestados_inactivos.Text = "Recibidas"
        Me.RBestados_inactivos.UseVisualStyleBackColor = True
        '
        'PBimagenmodulo
        '
        Me.PBimagenmodulo.BackColor = System.Drawing.Color.Transparent
        'Me.PBimagenmodulo.Image = Global.Sisbacon.My.Resources.Resources.compras
        Me.PBimagenmodulo.Location = New System.Drawing.Point(17, 12)
        Me.PBimagenmodulo.Name = "PBimagenmodulo"
        Me.PBimagenmodulo.Size = New System.Drawing.Size(174, 63)
        Me.PBimagenmodulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBimagenmodulo.TabIndex = 17
        Me.PBimagenmodulo.TabStop = False
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Header.Controls.Add(Me.GroupBox3)
        Me.Header.Controls.Add(Me.PBimagenmodulo)
        Me.Header.Controls.Add(Me.LBLmodulo)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1282, 87)
        Me.Header.TabIndex = 30
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.RBsincorte)
        Me.GroupBox3.Controls.Add(Me.RBconcorte)
        Me.GroupBox3.Controls.Add(Me.TXTfecha_corte)
        Me.GroupBox3.Controls.Add(Me.TXTfecha_inicio)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(836, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(429, 81)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filtrado por fecha"
        '
        'RBsincorte
        '
        Me.RBsincorte.AutoSize = True
        Me.RBsincorte.Location = New System.Drawing.Point(10, 22)
        Me.RBsincorte.Name = "RBsincorte"
        Me.RBsincorte.Size = New System.Drawing.Size(93, 24)
        Me.RBsincorte.TabIndex = 47
        Me.RBsincorte.Text = "Sin Corte"
        Me.RBsincorte.UseVisualStyleBackColor = True
        '
        'RBconcorte
        '
        Me.RBconcorte.AutoSize = True
        Me.RBconcorte.Checked = True
        Me.RBconcorte.Location = New System.Drawing.Point(10, 47)
        Me.RBconcorte.Name = "RBconcorte"
        Me.RBconcorte.Size = New System.Drawing.Size(124, 24)
        Me.RBconcorte.TabIndex = 15
        Me.RBconcorte.TabStop = True
        Me.RBconcorte.Text = "Con Corte del"
        Me.RBconcorte.UseVisualStyleBackColor = True
        '
        'TXTfecha_corte
        '
        Me.TXTfecha_corte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTfecha_corte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXTfecha_corte.Location = New System.Drawing.Point(298, 46)
        Me.TXTfecha_corte.Name = "TXTfecha_corte"
        Me.TXTfecha_corte.Size = New System.Drawing.Size(118, 26)
        Me.TXTfecha_corte.TabIndex = 46
        Me.TXTfecha_corte.Value = New Date(2019, 4, 4, 0, 0, 0, 0)
        '
        'TXTfecha_inicio
        '
        Me.TXTfecha_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTfecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXTfecha_inicio.Location = New System.Drawing.Point(153, 46)
        Me.TXTfecha_inicio.Name = "TXTfecha_inicio"
        Me.TXTfecha_inicio.Size = New System.Drawing.Size(118, 26)
        Me.TXTfecha_inicio.TabIndex = 44
        Me.TXTfecha_inicio.Value = New Date(2019, 4, 4, 0, 0, 0, 0)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(277, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 20)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "-"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLmodulo
        '
        Me.LBLmodulo.AutoSize = True
        Me.LBLmodulo.BackColor = System.Drawing.Color.Transparent
        Me.LBLmodulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLmodulo.ForeColor = System.Drawing.Color.White
        Me.LBLmodulo.Location = New System.Drawing.Point(197, 21)
        Me.LBLmodulo.Name = "LBLmodulo"
        Me.LBLmodulo.Size = New System.Drawing.Size(614, 42)
        Me.LBLmodulo.TabIndex = 19
        Me.LBLmodulo.Text = "REQUERIMIENTOS Y COMPRAS"
        Me.LBLmodulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.DGdatos)
        Me.GroupBox6.Location = New System.Drawing.Point(16, 182)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1249, 381)
        Me.GroupBox6.TabIndex = 31
        Me.GroupBox6.TabStop = False
        '
        'FrmExploradorCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 593)
        Me.Controls.Add(Me.Footer)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.GroupBox6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmExploradorCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmExploradorCompras"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Footer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Footer.ResumeLayout(False)
        Me.Footer.PerformLayout()
        CType(Me.DGdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GBestados.ResumeLayout(False)
        Me.GBestados.PerformLayout()
        CType(Me.PBimagenmodulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BTNbuscar As Button
    Friend WithEvents TXTconsulta As TextBox
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents Footer As BindingNavigator
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BTNexportar As Button
    Friend WithEvents BTNfiltro As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DGdatos As DataGridView
    Friend WithEvents BTNnuevo As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GBestados As GroupBox
    Friend WithEvents RBestados_activos As RadioButton
    Friend WithEvents RBestados_todos As RadioButton
    Friend WithEvents RBestados_inactivos As RadioButton
    Friend WithEvents PBimagenmodulo As PictureBox
    Friend WithEvents Header As Panel
    Friend WithEvents LBLmodulo As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RBcompras As RadioButton
    Friend WithEvents RBrequisiciones As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RBsincorte As RadioButton
    Friend WithEvents RBconcorte As RadioButton
    Friend WithEvents TXTfecha_corte As DateTimePicker
    Friend WithEvents TXTfecha_inicio As DateTimePicker
    Friend WithEvents Label15 As Label
End Class
