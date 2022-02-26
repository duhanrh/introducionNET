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
        Me.Txtnumero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtnumeroabs = New System.Windows.Forms.TextBox()
        Me.Lblispar = New System.Windows.Forms.Label()
        Me.Btnprocesar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número"
        '
        'Txtnumero
        '
        Me.Txtnumero.Location = New System.Drawing.Point(87, 14)
        Me.Txtnumero.Name = "Txtnumero"
        Me.Txtnumero.Size = New System.Drawing.Size(222, 23)
        Me.Txtnumero.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Absoluto"
        '
        'Txtnumeroabs
        '
        Me.Txtnumeroabs.Enabled = False
        Me.Txtnumeroabs.Location = New System.Drawing.Point(87, 55)
        Me.Txtnumeroabs.Name = "Txtnumeroabs"
        Me.Txtnumeroabs.Size = New System.Drawing.Size(222, 23)
        Me.Txtnumeroabs.TabIndex = 3
        '
        'Lblispar
        '
        Me.Lblispar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lblispar.Location = New System.Drawing.Point(12, 106)
        Me.Lblispar.Name = "Lblispar"
        Me.Lblispar.Size = New System.Drawing.Size(297, 71)
        Me.Lblispar.TabIndex = 4
        '
        'Btnprocesar
        '
        Me.Btnprocesar.Location = New System.Drawing.Point(234, 190)
        Me.Btnprocesar.Name = "Btnprocesar"
        Me.Btnprocesar.Size = New System.Drawing.Size(75, 23)
        Me.Btnprocesar.TabIndex = 5
        Me.Btnprocesar.Text = "Procesar"
        Me.Btnprocesar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 223)
        Me.Controls.Add(Me.Btnprocesar)
        Me.Controls.Add(Me.Lblispar)
        Me.Controls.Add(Me.Txtnumeroabs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtnumero)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txtnumero As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtnumeroabs As TextBox
    Friend WithEvents Lblispar As Label
    Friend WithEvents Btnprocesar As Button
End Class
