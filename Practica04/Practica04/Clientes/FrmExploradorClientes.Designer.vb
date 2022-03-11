<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmExploradorClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExploradorClientes))
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
        Me.GBestados = New System.Windows.Forms.GroupBox()
        Me.RBestados_activos = New System.Windows.Forms.RadioButton()
        Me.RBestados_todos = New System.Windows.Forms.RadioButton()
        Me.RBestados_inactivos = New System.Windows.Forms.RadioButton()
        Me.PBimagenmodulo = New System.Windows.Forms.PictureBox()
        Me.Header = New System.Windows.Forms.Panel()
        Me.LBLmodulo = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Footer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Footer.SuspendLayout()
        CType(Me.DGdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GBestados.SuspendLayout()
        CType(Me.PBimagenmodulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Header.SuspendLayout()
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
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(435, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(468, 99)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'BTNbuscar
        '
        Me.BTNbuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNbuscar.BackColor = System.Drawing.SystemColors.Control
        Me.BTNbuscar.BackgroundImage = CType(resources.GetObject("BTNbuscar.BackgroundImage"), System.Drawing.Image)
        Me.BTNbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNbuscar.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNbuscar.Location = New System.Drawing.Point(415, 42)
        Me.BTNbuscar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BTNbuscar.Name = "BTNbuscar"
        Me.BTNbuscar.Size = New System.Drawing.Size(43, 29)
        Me.BTNbuscar.TabIndex = 16
        Me.BTNbuscar.UseVisualStyleBackColor = False
        '
        'TXTconsulta
        '
        Me.TXTconsulta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTconsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TXTconsulta.Location = New System.Drawing.Point(13, 43)
        Me.TXTconsulta.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TXTconsulta.Name = "TXTconsulta"
        Me.TXTconsulta.Size = New System.Drawing.Size(398, 29)
        Me.TXTconsulta.TabIndex = 15
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
        Me.Footer.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Footer.CountItem = Me.BindingNavigatorCountItem
        Me.Footer.DeleteItem = Nothing
        Me.Footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Footer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Footer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.Footer.Location = New System.Drawing.Point(0, 470)
        Me.Footer.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Footer.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Footer.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Footer.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Footer.Name = "Footer"
        Me.Footer.PositionItem = Me.BindingNavigatorPositionItem
        Me.Footer.Size = New System.Drawing.Size(1134, 25)
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
        Me.BTNexportar.BackgroundImage = CType(resources.GetObject("BTNexportar.BackgroundImage"), System.Drawing.Image)
        Me.BTNexportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNexportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNexportar.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNexportar.Location = New System.Drawing.Point(911, 8)
        Me.BTNexportar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BTNexportar.Name = "BTNexportar"
        Me.BTNexportar.Size = New System.Drawing.Size(103, 93)
        Me.BTNexportar.TabIndex = 28
        Me.BTNexportar.UseVisualStyleBackColor = False
        '
        'BTNfiltro
        '
        Me.BTNfiltro.BackColor = System.Drawing.SystemColors.Control
        Me.BTNfiltro.BackgroundImage = CType(resources.GetObject("BTNfiltro.BackgroundImage"), System.Drawing.Image)
        Me.BTNfiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNfiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNfiltro.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNfiltro.Location = New System.Drawing.Point(313, 8)
        Me.BTNfiltro.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BTNfiltro.Name = "BTNfiltro"
        Me.BTNfiltro.Size = New System.Drawing.Size(114, 93)
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
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGdatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGdatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGdatos.EnableHeadersVisualStyles = False
        Me.DGdatos.Location = New System.Drawing.Point(4, 19)
        Me.DGdatos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DGdatos.Name = "DGdatos"
        Me.DGdatos.ReadOnly = True
        Me.DGdatos.Size = New System.Drawing.Size(1087, 229)
        Me.DGdatos.TabIndex = 9
        '
        'BTNnuevo
        '
        Me.BTNnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNnuevo.BackColor = System.Drawing.SystemColors.Control
        Me.BTNnuevo.BackgroundImage = CType(resources.GetObject("BTNnuevo.BackgroundImage"), System.Drawing.Image)
        Me.BTNnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNnuevo.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNnuevo.Location = New System.Drawing.Point(1001, 8)
        Me.BTNnuevo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BTNnuevo.Name = "BTNnuevo"
        Me.BTNnuevo.Size = New System.Drawing.Size(114, 93)
        Me.BTNnuevo.TabIndex = 6
        Me.BTNnuevo.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.BTNexportar)
        Me.Panel2.Controls.Add(Me.BTNfiltro)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.BTNnuevo)
        Me.Panel2.Controls.Add(Me.GBestados)
        Me.Panel2.Location = New System.Drawing.Point(-1, 102)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1134, 106)
        Me.Panel2.TabIndex = 32
        '
        'GBestados
        '
        Me.GBestados.BackColor = System.Drawing.Color.Transparent
        Me.GBestados.Controls.Add(Me.RBestados_activos)
        Me.GBestados.Controls.Add(Me.RBestados_todos)
        Me.GBestados.Controls.Add(Me.RBestados_inactivos)
        Me.GBestados.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GBestados.ForeColor = System.Drawing.Color.Black
        Me.GBestados.Location = New System.Drawing.Point(20, 3)
        Me.GBestados.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GBestados.Name = "GBestados"
        Me.GBestados.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GBestados.Size = New System.Drawing.Size(285, 99)
        Me.GBestados.TabIndex = 25
        Me.GBestados.TabStop = False
        Me.GBestados.Text = "Filtrar por estados"
        '
        'RBestados_activos
        '
        Me.RBestados_activos.AutoSize = True
        Me.RBestados_activos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RBestados_activos.Location = New System.Drawing.Point(191, 40)
        Me.RBestados_activos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RBestados_activos.Name = "RBestados_activos"
        Me.RBestados_activos.Size = New System.Drawing.Size(78, 24)
        Me.RBestados_activos.TabIndex = 14
        Me.RBestados_activos.Text = "Activos"
        Me.RBestados_activos.UseVisualStyleBackColor = True
        '
        'RBestados_todos
        '
        Me.RBestados_todos.AutoSize = True
        Me.RBestados_todos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RBestados_todos.Location = New System.Drawing.Point(14, 40)
        Me.RBestados_todos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RBestados_todos.Name = "RBestados_todos"
        Me.RBestados_todos.Size = New System.Drawing.Size(71, 24)
        Me.RBestados_todos.TabIndex = 11
        Me.RBestados_todos.Text = "Todos"
        Me.RBestados_todos.UseVisualStyleBackColor = True
        '
        'RBestados_inactivos
        '
        Me.RBestados_inactivos.AutoSize = True
        Me.RBestados_inactivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RBestados_inactivos.Location = New System.Drawing.Point(93, 40)
        Me.RBestados_inactivos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RBestados_inactivos.Name = "RBestados_inactivos"
        Me.RBestados_inactivos.Size = New System.Drawing.Size(90, 24)
        Me.RBestados_inactivos.TabIndex = 12
        Me.RBestados_inactivos.Text = "Inactivos"
        Me.RBestados_inactivos.UseVisualStyleBackColor = True
        '
        'PBimagenmodulo
        '
        Me.PBimagenmodulo.BackColor = System.Drawing.Color.Transparent
        Me.PBimagenmodulo.Image = CType(resources.GetObject("PBimagenmodulo.Image"), System.Drawing.Image)
        Me.PBimagenmodulo.Location = New System.Drawing.Point(20, 14)
        Me.PBimagenmodulo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PBimagenmodulo.Name = "PBimagenmodulo"
        Me.PBimagenmodulo.Size = New System.Drawing.Size(203, 73)
        Me.PBimagenmodulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBimagenmodulo.TabIndex = 17
        Me.PBimagenmodulo.TabStop = False
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Header.Controls.Add(Me.PBimagenmodulo)
        Me.Header.Controls.Add(Me.LBLmodulo)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1134, 100)
        Me.Header.TabIndex = 30
        '
        'LBLmodulo
        '
        Me.LBLmodulo.AutoSize = True
        Me.LBLmodulo.BackColor = System.Drawing.Color.Transparent
        Me.LBLmodulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LBLmodulo.ForeColor = System.Drawing.Color.White
        Me.LBLmodulo.Location = New System.Drawing.Point(231, 28)
        Me.LBLmodulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLmodulo.Name = "LBLmodulo"
        Me.LBLmodulo.Size = New System.Drawing.Size(208, 42)
        Me.LBLmodulo.TabIndex = 19
        Me.LBLmodulo.Text = "CLIENTES"
        Me.LBLmodulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.DGdatos)
        Me.GroupBox6.Location = New System.Drawing.Point(19, 210)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox6.Size = New System.Drawing.Size(1095, 251)
        Me.GroupBox6.TabIndex = 31
        Me.GroupBox6.TabStop = False
        '
        'FrmExploradorClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 495)
        Me.Controls.Add(Me.Footer)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.GroupBox6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MinimumSize = New System.Drawing.Size(1150, 534)
        Me.Name = "FrmExploradorClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmExploradorClientes"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Footer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Footer.ResumeLayout(False)
        Me.Footer.PerformLayout()
        CType(Me.DGdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GBestados.ResumeLayout(False)
        Me.GBestados.PerformLayout()
        CType(Me.PBimagenmodulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
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
End Class
