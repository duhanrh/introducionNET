<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.TxtPrestamo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtTotalPrestamoFabricante = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtInteresPrestamoFabricante = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMontoPrestamoFabricante = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtTotalPrestamoBanco = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtInteresPrestamoBanco = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMontoPrestamoBanco = New System.Windows.Forms.TextBox()
        Me.LblPrestamoBanco = New System.Windows.Forms.Label()
        Me.TxtRecursosPropios = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.TxtValorCompra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RtextReadme = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox1.Controls.Add(Me.TxtPrestamo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TxtRecursosPropios)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnCalcular)
        Me.GroupBox1.Controls.Add(Me.TxtValorCompra)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 273)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1085, 209)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.Brown
        Me.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLimpiar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.White
        Me.BtnLimpiar.Location = New System.Drawing.Point(683, 52)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(120, 29)
        Me.BtnLimpiar.TabIndex = 13
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'TxtPrestamo
        '
        Me.TxtPrestamo.Enabled = False
        Me.TxtPrestamo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtPrestamo.Location = New System.Drawing.Point(370, 53)
        Me.TxtPrestamo.Name = "TxtPrestamo"
        Me.TxtPrestamo.Size = New System.Drawing.Size(170, 29)
        Me.TxtPrestamo.TabIndex = 12
        Me.TxtPrestamo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(370, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 21)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Total prestamos"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtTotalPrestamoFabricante)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TxtInteresPrestamoFabricante)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TxtMontoPrestamoFabricante)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.Location = New System.Drawing.Point(543, 97)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(531, 98)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Prestamo fabricante"
        '
        'TxtTotalPrestamoFabricante
        '
        Me.TxtTotalPrestamoFabricante.Enabled = False
        Me.TxtTotalPrestamoFabricante.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtTotalPrestamoFabricante.Location = New System.Drawing.Point(355, 56)
        Me.TxtTotalPrestamoFabricante.Name = "TxtTotalPrestamoFabricante"
        Me.TxtTotalPrestamoFabricante.Size = New System.Drawing.Size(163, 29)
        Me.TxtTotalPrestamoFabricante.TabIndex = 7
        Me.TxtTotalPrestamoFabricante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(355, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 21)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Total"
        '
        'TxtInteresPrestamoFabricante
        '
        Me.TxtInteresPrestamoFabricante.Enabled = False
        Me.TxtInteresPrestamoFabricante.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtInteresPrestamoFabricante.Location = New System.Drawing.Point(185, 56)
        Me.TxtInteresPrestamoFabricante.Name = "TxtInteresPrestamoFabricante"
        Me.TxtInteresPrestamoFabricante.Size = New System.Drawing.Size(163, 29)
        Me.TxtInteresPrestamoFabricante.TabIndex = 5
        Me.TxtInteresPrestamoFabricante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(185, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 21)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Intereses"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(9, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 21)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Monto"
        '
        'TxtMontoPrestamoFabricante
        '
        Me.TxtMontoPrestamoFabricante.Enabled = False
        Me.TxtMontoPrestamoFabricante.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtMontoPrestamoFabricante.Location = New System.Drawing.Point(9, 56)
        Me.TxtMontoPrestamoFabricante.Name = "TxtMontoPrestamoFabricante"
        Me.TxtMontoPrestamoFabricante.Size = New System.Drawing.Size(170, 29)
        Me.TxtMontoPrestamoFabricante.TabIndex = 5
        Me.TxtMontoPrestamoFabricante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtTotalPrestamoBanco)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtInteresPrestamoBanco)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtMontoPrestamoBanco)
        Me.GroupBox2.Controls.Add(Me.LblPrestamoBanco)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 97)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(531, 98)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Prestamo banco"
        '
        'TxtTotalPrestamoBanco
        '
        Me.TxtTotalPrestamoBanco.Enabled = False
        Me.TxtTotalPrestamoBanco.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtTotalPrestamoBanco.Location = New System.Drawing.Point(355, 56)
        Me.TxtTotalPrestamoBanco.Name = "TxtTotalPrestamoBanco"
        Me.TxtTotalPrestamoBanco.Size = New System.Drawing.Size(163, 29)
        Me.TxtTotalPrestamoBanco.TabIndex = 7
        Me.TxtTotalPrestamoBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(355, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total"
        '
        'TxtInteresPrestamoBanco
        '
        Me.TxtInteresPrestamoBanco.Enabled = False
        Me.TxtInteresPrestamoBanco.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtInteresPrestamoBanco.Location = New System.Drawing.Point(182, 56)
        Me.TxtInteresPrestamoBanco.Name = "TxtInteresPrestamoBanco"
        Me.TxtInteresPrestamoBanco.Size = New System.Drawing.Size(163, 29)
        Me.TxtInteresPrestamoBanco.TabIndex = 5
        Me.TxtInteresPrestamoBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(182, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Intereses"
        '
        'TxtMontoPrestamoBanco
        '
        Me.TxtMontoPrestamoBanco.Enabled = False
        Me.TxtMontoPrestamoBanco.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtMontoPrestamoBanco.Location = New System.Drawing.Point(10, 56)
        Me.TxtMontoPrestamoBanco.Name = "TxtMontoPrestamoBanco"
        Me.TxtMontoPrestamoBanco.Size = New System.Drawing.Size(163, 29)
        Me.TxtMontoPrestamoBanco.TabIndex = 3
        Me.TxtMontoPrestamoBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblPrestamoBanco
        '
        Me.LblPrestamoBanco.AutoSize = True
        Me.LblPrestamoBanco.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblPrestamoBanco.Location = New System.Drawing.Point(10, 28)
        Me.LblPrestamoBanco.Name = "LblPrestamoBanco"
        Me.LblPrestamoBanco.Size = New System.Drawing.Size(56, 21)
        Me.LblPrestamoBanco.TabIndex = 2
        Me.LblPrestamoBanco.Text = "Monto"
        '
        'TxtRecursosPropios
        '
        Me.TxtRecursosPropios.Enabled = False
        Me.TxtRecursosPropios.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtRecursosPropios.Location = New System.Drawing.Point(188, 53)
        Me.TxtRecursosPropios.Name = "TxtRecursosPropios"
        Me.TxtRecursosPropios.Size = New System.Drawing.Size(170, 29)
        Me.TxtRecursosPropios.TabIndex = 8
        Me.TxtRecursosPropios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(188, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Recursos propios"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.Brown
        Me.BtnCalcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCalcular.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCalcular.ForeColor = System.Drawing.Color.White
        Me.BtnCalcular.Location = New System.Drawing.Point(552, 52)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(120, 29)
        Me.BtnCalcular.TabIndex = 6
        Me.BtnCalcular.Text = "Procesar"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'TxtValorCompra
        '
        Me.TxtValorCompra.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtValorCompra.Location = New System.Drawing.Point(6, 53)
        Me.TxtValorCompra.Name = "TxtValorCompra"
        Me.TxtValorCompra.Size = New System.Drawing.Size(170, 29)
        Me.TxtValorCompra.TabIndex = 1
        Me.TxtValorCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor a comprar"
        '
        'RtextReadme
        '
        Me.RtextReadme.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RtextReadme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RtextReadme.Enabled = False
        Me.RtextReadme.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RtextReadme.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RtextReadme.Location = New System.Drawing.Point(12, 12)
        Me.RtextReadme.Name = "RtextReadme"
        Me.RtextReadme.Size = New System.Drawing.Size(1085, 255)
        Me.RtextReadme.TabIndex = 3
        Me.RtextReadme.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 494)
        Me.Controls.Add(Me.RtextReadme)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Competencia 1 ::: Ejercicio 1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RtextReadme As RichTextBox
    Friend WithEvents TxtMontoPrestamoFabricante As TextBox
    Friend WithEvents LblPrestamoFabricante As Label
    Friend WithEvents TxtMontoPrestamoBanco As TextBox
    Friend WithEvents LblPrestamoBanco As Label
    Friend WithEvents TxtValorCompra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents TxtRecursosPropios As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtTotalPrestamoFabricante As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtInteresPrestamoFabricante As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtTotalPrestamoBanco As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtInteresPrestamoBanco As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPrestamo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnLimpiar As Button
End Class
