﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProducto))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXTnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNguardar = New System.Windows.Forms.Button()
        Me.RBactualizar = New System.Windows.Forms.RadioButton()
        Me.GBacciones = New System.Windows.Forms.GroupBox()
        Me.RBrestaurar = New System.Windows.Forms.RadioButton()
        Me.RBeliminar = New System.Windows.Forms.RadioButton()
        Me.RBnuevo = New System.Windows.Forms.RadioButton()
        Me.GBdatos = New System.Windows.Forms.GroupBox()
        Me.TXTprecio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTid = New System.Windows.Forms.TextBox()
        Me.HEADER = New System.Windows.Forms.Panel()
        Me.LBLestado = New System.Windows.Forms.Label()
        Me.PBimagenmodulo = New System.Windows.Forms.PictureBox()
        Me.LBLmodulo = New System.Windows.Forms.Label()
        Me.FOOTER = New System.Windows.Forms.StatusStrip()
        Me.BTNcancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GBacciones.SuspendLayout()
        Me.GBdatos.SuspendLayout()
        Me.HEADER.SuspendLayout()
        CType(Me.PBimagenmodulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.DarkRed
        Me.Label11.Location = New System.Drawing.Point(80, 22)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 20)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "*"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTnombre
        '
        Me.TXTnombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TXTnombre.Location = New System.Drawing.Point(12, 48)
        Me.TXTnombre.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TXTnombre.Name = "TXTnombre"
        Me.TXTnombre.Size = New System.Drawing.Size(708, 26)
        Me.TXTnombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre"
        '
        'BTNguardar
        '
        Me.BTNguardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNguardar.BackColor = System.Drawing.Color.DarkRed
        Me.BTNguardar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTNguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTNguardar.ForeColor = System.Drawing.Color.White
        Me.BTNguardar.Location = New System.Drawing.Point(911, 302)
        Me.BTNguardar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BTNguardar.Name = "BTNguardar"
        Me.BTNguardar.Size = New System.Drawing.Size(139, 44)
        Me.BTNguardar.TabIndex = 25
        Me.BTNguardar.Text = "Cerrar"
        Me.BTNguardar.UseVisualStyleBackColor = False
        '
        'RBactualizar
        '
        Me.RBactualizar.AutoSize = True
        Me.RBactualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RBactualizar.ForeColor = System.Drawing.Color.DarkRed
        Me.RBactualizar.Location = New System.Drawing.Point(212, 16)
        Me.RBactualizar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RBactualizar.Name = "RBactualizar"
        Me.RBactualizar.Size = New System.Drawing.Size(97, 24)
        Me.RBactualizar.TabIndex = 1
        Me.RBactualizar.Text = "Actualizar"
        Me.RBactualizar.UseVisualStyleBackColor = True
        '
        'GBacciones
        '
        Me.GBacciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBacciones.Controls.Add(Me.RBrestaurar)
        Me.GBacciones.Controls.Add(Me.RBeliminar)
        Me.GBacciones.Controls.Add(Me.RBactualizar)
        Me.GBacciones.Controls.Add(Me.RBnuevo)
        Me.GBacciones.Location = New System.Drawing.Point(28, 295)
        Me.GBacciones.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GBacciones.Name = "GBacciones"
        Me.GBacciones.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GBacciones.Size = New System.Drawing.Size(731, 51)
        Me.GBacciones.TabIndex = 26
        Me.GBacciones.TabStop = False
        '
        'RBrestaurar
        '
        Me.RBrestaurar.AutoSize = True
        Me.RBrestaurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RBrestaurar.ForeColor = System.Drawing.Color.DarkRed
        Me.RBrestaurar.Location = New System.Drawing.Point(558, 16)
        Me.RBrestaurar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RBrestaurar.Name = "RBrestaurar"
        Me.RBrestaurar.Size = New System.Drawing.Size(98, 24)
        Me.RBrestaurar.TabIndex = 3
        Me.RBrestaurar.Text = "Restaurar"
        Me.RBrestaurar.UseVisualStyleBackColor = True
        '
        'RBeliminar
        '
        Me.RBeliminar.AutoSize = True
        Me.RBeliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RBeliminar.ForeColor = System.Drawing.Color.DarkRed
        Me.RBeliminar.Location = New System.Drawing.Point(391, 16)
        Me.RBeliminar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RBeliminar.Name = "RBeliminar"
        Me.RBeliminar.Size = New System.Drawing.Size(83, 24)
        Me.RBeliminar.TabIndex = 2
        Me.RBeliminar.Text = "Eliminar"
        Me.RBeliminar.UseVisualStyleBackColor = True
        '
        'RBnuevo
        '
        Me.RBnuevo.AutoSize = True
        Me.RBnuevo.Checked = True
        Me.RBnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RBnuevo.ForeColor = System.Drawing.Color.DarkRed
        Me.RBnuevo.Location = New System.Drawing.Point(64, 16)
        Me.RBnuevo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RBnuevo.Name = "RBnuevo"
        Me.RBnuevo.Size = New System.Drawing.Size(72, 24)
        Me.RBnuevo.TabIndex = 0
        Me.RBnuevo.TabStop = True
        Me.RBnuevo.Text = "Nuevo"
        Me.RBnuevo.UseVisualStyleBackColor = True
        '
        'GBdatos
        '
        Me.GBdatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBdatos.Controls.Add(Me.TXTprecio)
        Me.GBdatos.Controls.Add(Me.Label1)
        Me.GBdatos.Controls.Add(Me.Label7)
        Me.GBdatos.Controls.Add(Me.Label11)
        Me.GBdatos.Controls.Add(Me.TXTnombre)
        Me.GBdatos.Controls.Add(Me.Label2)
        Me.GBdatos.Enabled = False
        Me.GBdatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GBdatos.Location = New System.Drawing.Point(28, 74)
        Me.GBdatos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GBdatos.Name = "GBdatos"
        Me.GBdatos.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GBdatos.Size = New System.Drawing.Size(731, 215)
        Me.GBdatos.TabIndex = 24
        Me.GBdatos.TabStop = False
        '
        'TXTprecio
        '
        Me.TXTprecio.Location = New System.Drawing.Point(12, 125)
        Me.TXTprecio.Name = "TXTprecio"
        Me.TXTprecio.Size = New System.Drawing.Size(252, 26)
        Me.TXTprecio.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(129, 93)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "*"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(12, 93)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Precio unitario"
        '
        'TXTid
        '
        Me.TXTid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTid.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.TXTid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTid.Enabled = False
        Me.TXTid.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TXTid.ForeColor = System.Drawing.Color.White
        Me.TXTid.Location = New System.Drawing.Point(789, 11)
        Me.TXTid.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TXTid.Name = "TXTid"
        Me.TXTid.Size = New System.Drawing.Size(260, 49)
        Me.TXTid.TabIndex = 3
        Me.TXTid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HEADER
        '
        Me.HEADER.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HEADER.Controls.Add(Me.LBLestado)
        Me.HEADER.Controls.Add(Me.PBimagenmodulo)
        Me.HEADER.Controls.Add(Me.LBLmodulo)
        Me.HEADER.Controls.Add(Me.TXTid)
        Me.HEADER.Dock = System.Windows.Forms.DockStyle.Top
        Me.HEADER.Location = New System.Drawing.Point(0, 0)
        Me.HEADER.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.HEADER.Name = "HEADER"
        Me.HEADER.Size = New System.Drawing.Size(1080, 72)
        Me.HEADER.TabIndex = 27
        '
        'LBLestado
        '
        Me.LBLestado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLestado.AutoSize = True
        Me.LBLestado.BackColor = System.Drawing.Color.Transparent
        Me.LBLestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LBLestado.Location = New System.Drawing.Point(-102, 13)
        Me.LBLestado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLestado.Name = "LBLestado"
        Me.LBLestado.Size = New System.Drawing.Size(46, 42)
        Me.LBLestado.TabIndex = 29
        Me.LBLestado.Text = "D"
        Me.LBLestado.Visible = False
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
        Me.PBimagenmodulo.TabIndex = 28
        Me.PBimagenmodulo.TabStop = False
        '
        'LBLmodulo
        '
        Me.LBLmodulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLmodulo.AutoSize = True
        Me.LBLmodulo.BackColor = System.Drawing.Color.Transparent
        Me.LBLmodulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LBLmodulo.ForeColor = System.Drawing.Color.White
        Me.LBLmodulo.Location = New System.Drawing.Point(497, 14)
        Me.LBLmodulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLmodulo.Name = "LBLmodulo"
        Me.LBLmodulo.Size = New System.Drawing.Size(284, 42)
        Me.LBLmodulo.TabIndex = 19
        Me.LBLmodulo.Text = "PRODUCTO # "
        Me.LBLmodulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FOOTER
        '
        Me.FOOTER.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FOOTER.Location = New System.Drawing.Point(0, 359)
        Me.FOOTER.Name = "FOOTER"
        Me.FOOTER.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.FOOTER.Size = New System.Drawing.Size(1080, 22)
        Me.FOOTER.TabIndex = 28
        Me.FOOTER.Text = "StatusStrip"
        '
        'BTNcancelar
        '
        Me.BTNcancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNcancelar.BackColor = System.Drawing.Color.DarkRed
        Me.BTNcancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTNcancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTNcancelar.ForeColor = System.Drawing.Color.White
        Me.BTNcancelar.Location = New System.Drawing.Point(767, 302)
        Me.BTNcancelar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BTNcancelar.Name = "BTNcancelar"
        Me.BTNcancelar.Size = New System.Drawing.Size(139, 44)
        Me.BTNcancelar.TabIndex = 29
        Me.BTNcancelar.Text = "Cancelar"
        Me.BTNcancelar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(767, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 215)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1080, 381)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNcancelar)
        Me.Controls.Add(Me.BTNguardar)
        Me.Controls.Add(Me.GBacciones)
        Me.Controls.Add(Me.FOOTER)
        Me.Controls.Add(Me.GBdatos)
        Me.Controls.Add(Me.HEADER)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1096, 420)
        Me.MinimumSize = New System.Drawing.Size(1096, 420)
        Me.Name = "FrmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Producto"
        Me.GBacciones.ResumeLayout(False)
        Me.GBacciones.PerformLayout()
        Me.GBdatos.ResumeLayout(False)
        Me.GBdatos.PerformLayout()
        Me.HEADER.ResumeLayout(False)
        Me.HEADER.PerformLayout()
        CType(Me.PBimagenmodulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents TXTnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BTNguardar As Button
    Friend WithEvents RBactualizar As RadioButton
    Friend WithEvents GBacciones As GroupBox
    Friend WithEvents RBrestaurar As RadioButton
    Friend WithEvents RBeliminar As RadioButton
    Friend WithEvents RBnuevo As RadioButton
    Friend WithEvents GBdatos As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TXTid As TextBox
    Friend WithEvents HEADER As Panel
    Friend WithEvents LBLmodulo As Label
    Friend WithEvents PBimagenmodulo As PictureBox
    Friend WithEvents FOOTER As StatusStrip
    Friend WithEvents LBLestado As Label
    Friend WithEvents BTNcancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXTprecio As TextBox
End Class
