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
        Me.Txtedad = New System.Windows.Forms.TextBox()
        Me.Lblvivi = New System.Windows.Forms.Label()
        Me.BtnProcesar = New System.Windows.Forms.Button()
        Me.Lbldias = New System.Windows.Forms.Label()
        Me.Btnlimpiar = New System.Windows.Forms.Button()
        Me.Txtbono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Edad"
        '
        'Txtedad
        '
        Me.Txtedad.Location = New System.Drawing.Point(99, 23)
        Me.Txtedad.Name = "Txtedad"
        Me.Txtedad.Size = New System.Drawing.Size(171, 23)
        Me.Txtedad.TabIndex = 1
        '
        'Lblvivi
        '
        Me.Lblvivi.AutoSize = True
        Me.Lblvivi.Location = New System.Drawing.Point(26, 62)
        Me.Lblvivi.Name = "Lblvivi"
        Me.Lblvivi.Size = New System.Drawing.Size(57, 15)
        Me.Lblvivi.TabIndex = 2
        Me.Lblvivi.Text = "Ha vivido"
        '
        'BtnProcesar
        '
        Me.BtnProcesar.Location = New System.Drawing.Point(26, 151)
        Me.BtnProcesar.Name = "BtnProcesar"
        Me.BtnProcesar.Size = New System.Drawing.Size(89, 23)
        Me.BtnProcesar.TabIndex = 3
        Me.BtnProcesar.Text = "Procesar"
        Me.BtnProcesar.UseVisualStyleBackColor = True
        '
        'Lbldias
        '
        Me.Lbldias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbldias.Location = New System.Drawing.Point(99, 61)
        Me.Lbldias.Name = "Lbldias"
        Me.Lbldias.Size = New System.Drawing.Size(171, 23)
        Me.Lbldias.TabIndex = 4
        '
        'Btnlimpiar
        '
        Me.Btnlimpiar.Location = New System.Drawing.Point(195, 151)
        Me.Btnlimpiar.Name = "Btnlimpiar"
        Me.Btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.Btnlimpiar.TabIndex = 5
        Me.Btnlimpiar.Text = "Limpiar"
        Me.Btnlimpiar.UseVisualStyleBackColor = True
        '
        'Txtbono
        '
        Me.Txtbono.Enabled = False
        Me.Txtbono.Location = New System.Drawing.Point(99, 97)
        Me.Txtbono.Name = "Txtbono"
        Me.Txtbono.Size = New System.Drawing.Size(171, 23)
        Me.Txtbono.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Bono"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 193)
        Me.Controls.Add(Me.Txtbono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btnlimpiar)
        Me.Controls.Add(Me.Lbldias)
        Me.Controls.Add(Me.BtnProcesar)
        Me.Controls.Add(Me.Lblvivi)
        Me.Controls.Add(Me.Txtedad)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txtedad As TextBox
    Friend WithEvents Lblvivi As Label
    Friend WithEvents BtnProcesar As Button
    Friend WithEvents Lbldias As Label
    Friend WithEvents Btnlimpiar As Button
    Friend WithEvents Txtbono As TextBox
    Friend WithEvents Label2 As Label
End Class
