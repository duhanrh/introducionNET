<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.BtnPlanes = New System.Windows.Forms.Button()
        Me.LblPlan = New System.Windows.Forms.Label()
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnComprar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbTipo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbHorarios = New System.Windows.Forms.ComboBox()
        Me.CbPeliculas = New System.Windows.Forms.ComboBox()
        Me.GbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Edad"
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(69, 26)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(100, 23)
        Me.TxtEdad.TabIndex = 1
        Me.TxtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnPlanes
        '
        Me.BtnPlanes.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPlanes.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnPlanes.ForeColor = System.Drawing.Color.White
        Me.BtnPlanes.Location = New System.Drawing.Point(175, 26)
        Me.BtnPlanes.Name = "BtnPlanes"
        Me.BtnPlanes.Size = New System.Drawing.Size(104, 23)
        Me.BtnPlanes.TabIndex = 2
        Me.BtnPlanes.Text = "Mostrar plan"
        Me.BtnPlanes.UseVisualStyleBackColor = False
        '
        'LblPlan
        '
        Me.LblPlan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblPlan.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblPlan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblPlan.Location = New System.Drawing.Point(28, 28)
        Me.LblPlan.Name = "LblPlan"
        Me.LblPlan.Size = New System.Drawing.Size(693, 77)
        Me.LblPlan.TabIndex = 3
        Me.LblPlan.Text = "Titulo plan"
        Me.LblPlan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.TxtPrecio)
        Me.GbDatos.Controls.Add(Me.Label5)
        Me.GbDatos.Controls.Add(Me.BtnComprar)
        Me.GbDatos.Controls.Add(Me.Label4)
        Me.GbDatos.Controls.Add(Me.CbTipo)
        Me.GbDatos.Controls.Add(Me.Label3)
        Me.GbDatos.Controls.Add(Me.Label2)
        Me.GbDatos.Controls.Add(Me.CbHorarios)
        Me.GbDatos.Controls.Add(Me.CbPeliculas)
        Me.GbDatos.Controls.Add(Me.LblPlan)
        Me.GbDatos.Enabled = False
        Me.GbDatos.Location = New System.Drawing.Point(13, 68)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(752, 244)
        Me.GbDatos.TabIndex = 4
        Me.GbDatos.TabStop = False
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Enabled = False
        Me.TxtPrecio.Location = New System.Drawing.Point(435, 207)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(194, 23)
        Me.TxtPrecio.TabIndex = 12
        Me.TxtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(339, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Valor a cancelar"
        '
        'BtnComprar
        '
        Me.BtnComprar.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnComprar.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnComprar.ForeColor = System.Drawing.Color.White
        Me.BtnComprar.Location = New System.Drawing.Point(635, 207)
        Me.BtnComprar.Name = "BtnComprar"
        Me.BtnComprar.Size = New System.Drawing.Size(86, 23)
        Me.BtnComprar.TabIndex = 10
        Me.BtnComprar.Text = "Comprar"
        Me.BtnComprar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tipo de película"
        '
        'CbTipo
        '
        Me.CbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTipo.FormattingEnabled = True
        Me.CbTipo.Items.AddRange(New Object() {"10:30", "14:00", "16:00"})
        Me.CbTipo.Location = New System.Drawing.Point(162, 129)
        Me.CbTipo.Name = "CbTipo"
        Me.CbTipo.Size = New System.Drawing.Size(171, 23)
        Me.CbTipo.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Horarios disponibles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Películas disponibles"
        '
        'CbHorarios
        '
        Me.CbHorarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbHorarios.FormattingEnabled = True
        Me.CbHorarios.Items.AddRange(New Object() {"10:30", "14:00", "16:00"})
        Me.CbHorarios.Location = New System.Drawing.Point(162, 207)
        Me.CbHorarios.Name = "CbHorarios"
        Me.CbHorarios.Size = New System.Drawing.Size(171, 23)
        Me.CbHorarios.TabIndex = 6
        '
        'CbPeliculas
        '
        Me.CbPeliculas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPeliculas.FormattingEnabled = True
        Me.CbPeliculas.Location = New System.Drawing.Point(162, 168)
        Me.CbPeliculas.Name = "CbPeliculas"
        Me.CbPeliculas.Size = New System.Drawing.Size(559, 23)
        Me.CbPeliculas.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 327)
        Me.Controls.Add(Me.GbDatos)
        Me.Controls.Add(Me.BtnPlanes)
        Me.Controls.Add(Me.TxtEdad)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CINEMAR"
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents BtnPlanes As Button
    Friend WithEvents LblPlan As Label
    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CbPeliculas As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CbHorarios As ComboBox
    Friend WithEvents BtnComprar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CbTipo As ComboBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label5 As Label
End Class
