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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.LblLetrero = New System.Windows.Forms.Label()
        Me.PbPlay = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PbPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(27, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número"
        '
        'TxtNumero
        '
        Me.TxtNumero.Enabled = False
        Me.TxtNumero.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtNumero.Location = New System.Drawing.Point(27, 62)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(217, 33)
        Me.TxtNumero.TabIndex = 1
        '
        'LblLetrero
        '
        Me.LblLetrero.AutoSize = True
        Me.LblLetrero.Location = New System.Drawing.Point(27, 112)
        Me.LblLetrero.Name = "LblLetrero"
        Me.LblLetrero.Size = New System.Drawing.Size(44, 15)
        Me.LblLetrero.TabIndex = 2
        Me.LblLetrero.Text = "0 de 10"
        '
        'PbPlay
        '
        Me.PbPlay.Image = Global.WinFormsApp5.My.Resources.Resources.play
        Me.PbPlay.Location = New System.Drawing.Point(250, 62)
        Me.PbPlay.Name = "PbPlay"
        Me.PbPlay.Size = New System.Drawing.Size(43, 33)
        Me.PbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbPlay.TabIndex = 3
        Me.PbPlay.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(250, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 145)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PbPlay)
        Me.Controls.Add(Me.LblLetrero)
        Me.Controls.Add(Me.TxtNumero)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Random"
        CType(Me.PbPlay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents LblLetrero As Label
    Friend WithEvents PbPlay As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
End Class
