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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtbase = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtaltura = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtarea = New System.Windows.Forms.TextBox()
        Me.Btncalcular = New System.Windows.Forms.Button()
        Me.Btnlimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calculo area de un triangulo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Base"
        '
        'Txtbase
        '
        Me.Txtbase.Location = New System.Drawing.Point(114, 58)
        Me.Txtbase.Name = "Txtbase"
        Me.Txtbase.Size = New System.Drawing.Size(100, 23)
        Me.Txtbase.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Altura"
        '
        'Txtaltura
        '
        Me.Txtaltura.Location = New System.Drawing.Point(114, 109)
        Me.Txtaltura.Name = "Txtaltura"
        Me.Txtaltura.Size = New System.Drawing.Size(100, 23)
        Me.Txtaltura.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Area"
        '
        'Txtarea
        '
        Me.Txtarea.Enabled = False
        Me.Txtarea.Location = New System.Drawing.Point(114, 153)
        Me.Txtarea.Name = "Txtarea"
        Me.Txtarea.Size = New System.Drawing.Size(100, 23)
        Me.Txtarea.TabIndex = 6
        '
        'Btncalcular
        '
        Me.Btncalcular.Location = New System.Drawing.Point(17, 203)
        Me.Btncalcular.Name = "Btncalcular"
        Me.Btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.Btncalcular.TabIndex = 7
        Me.Btncalcular.Text = "Calcular"
        Me.Btncalcular.UseVisualStyleBackColor = True
        '
        'Btnlimpiar
        '
        Me.Btnlimpiar.Location = New System.Drawing.Point(139, 203)
        Me.Btnlimpiar.Name = "Btnlimpiar"
        Me.Btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.Btnlimpiar.TabIndex = 8
        Me.Btnlimpiar.Text = "Limpiar"
        Me.Btnlimpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 247)
        Me.Controls.Add(Me.Btnlimpiar)
        Me.Controls.Add(Me.Btncalcular)
        Me.Controls.Add(Me.Txtarea)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txtaltura)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txtbase)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtbase As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txtaltura As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txtarea As TextBox
    Friend WithEvents Btncalcular As Button
    Friend WithEvents Btnlimpiar As Button
End Class
