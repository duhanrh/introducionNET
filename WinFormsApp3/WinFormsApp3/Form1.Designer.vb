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
        Me.Txtuser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtpassword = New System.Windows.Forms.TextBox()
        Me.Btnlogin = New System.Windows.Forms.Button()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.GBdatos = New System.Windows.Forms.GroupBox()
        Me.Cbestado = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GBlogin = New System.Windows.Forms.GroupBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPagelogin = New System.Windows.Forms.TabPage()
        Me.TabPagedatos = New System.Windows.Forms.TabPage()
        Me.GBdatos.SuspendLayout()
        Me.GBlogin.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPagelogin.SuspendLayout()
        Me.TabPagedatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Txtuser
        '
        Me.Txtuser.Location = New System.Drawing.Point(92, 30)
        Me.Txtuser.Name = "Txtuser"
        Me.Txtuser.Size = New System.Drawing.Size(170, 23)
        Me.Txtuser.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña"
        '
        'Txtpassword
        '
        Me.Txtpassword.Location = New System.Drawing.Point(92, 65)
        Me.Txtpassword.Name = "Txtpassword"
        Me.Txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtpassword.Size = New System.Drawing.Size(170, 23)
        Me.Txtpassword.TabIndex = 3
        '
        'Btnlogin
        '
        Me.Btnlogin.Location = New System.Drawing.Point(17, 146)
        Me.Btnlogin.Name = "Btnlogin"
        Me.Btnlogin.Size = New System.Drawing.Size(100, 23)
        Me.Btnlogin.TabIndex = 4
        Me.Btnlogin.Text = "Ingresar"
        Me.Btnlogin.UseVisualStyleBackColor = True
        '
        'Btnsalir
        '
        Me.Btnsalir.Location = New System.Drawing.Point(287, 228)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(100, 23)
        Me.Btnsalir.TabIndex = 5
        Me.Btnsalir.Text = "Salir"
        Me.Btnsalir.UseVisualStyleBackColor = True
        '
        'GBdatos
        '
        Me.GBdatos.Controls.Add(Me.Cbestado)
        Me.GBdatos.Controls.Add(Me.Label5)
        Me.GBdatos.Controls.Add(Me.TextBox2)
        Me.GBdatos.Controls.Add(Me.Label4)
        Me.GBdatos.Controls.Add(Me.TextBox1)
        Me.GBdatos.Controls.Add(Me.Label3)
        Me.GBdatos.Location = New System.Drawing.Point(6, 6)
        Me.GBdatos.Name = "GBdatos"
        Me.GBdatos.Size = New System.Drawing.Size(334, 170)
        Me.GBdatos.TabIndex = 6
        Me.GBdatos.TabStop = False
        Me.GBdatos.Text = "Datos"
        '
        'Cbestado
        '
        Me.Cbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbestado.FormattingEnabled = True
        Me.Cbestado.Items.AddRange(New Object() {"Solteroa)", "Casadoa)", "Viudo(a)", "Unión libre"})
        Me.Cbestado.Location = New System.Drawing.Point(89, 108)
        Me.Cbestado.Name = "Cbestado"
        Me.Cbestado.Size = New System.Drawing.Size(223, 23)
        Me.Cbestado.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Estado civil"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(90, 73)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(222, 23)
        Me.TextBox2.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nombre"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(90, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(222, 23)
        Me.TextBox1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cédula"
        '
        'GBlogin
        '
        Me.GBlogin.Controls.Add(Me.Txtuser)
        Me.GBlogin.Controls.Add(Me.Label1)
        Me.GBlogin.Controls.Add(Me.Label2)
        Me.GBlogin.Controls.Add(Me.Txtpassword)
        Me.GBlogin.Location = New System.Drawing.Point(17, 22)
        Me.GBlogin.Name = "GBlogin"
        Me.GBlogin.Size = New System.Drawing.Size(329, 110)
        Me.GBlogin.TabIndex = 7
        Me.GBlogin.TabStop = False
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPagelogin)
        Me.TabControl.Controls.Add(Me.TabPagedatos)
        Me.TabControl.Location = New System.Drawing.Point(12, 12)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(375, 210)
        Me.TabControl.TabIndex = 8
        '
        'TabPagelogin
        '
        Me.TabPagelogin.Controls.Add(Me.GBlogin)
        Me.TabPagelogin.Controls.Add(Me.Btnlogin)
        Me.TabPagelogin.Location = New System.Drawing.Point(4, 24)
        Me.TabPagelogin.Name = "TabPagelogin"
        Me.TabPagelogin.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagelogin.Size = New System.Drawing.Size(367, 182)
        Me.TabPagelogin.TabIndex = 0
        Me.TabPagelogin.Text = "Formulario login"
        Me.TabPagelogin.UseVisualStyleBackColor = True
        '
        'TabPagedatos
        '
        Me.TabPagedatos.Controls.Add(Me.GBdatos)
        Me.TabPagedatos.Location = New System.Drawing.Point(4, 24)
        Me.TabPagedatos.Name = "TabPagedatos"
        Me.TabPagedatos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagedatos.Size = New System.Drawing.Size(367, 182)
        Me.TabPagedatos.TabIndex = 1
        Me.TabPagedatos.Text = "Datos"
        Me.TabPagedatos.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(404, 261)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.Btnsalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fomulario login"
        Me.GBdatos.ResumeLayout(False)
        Me.GBdatos.PerformLayout()
        Me.GBlogin.ResumeLayout(False)
        Me.GBlogin.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabPagelogin.ResumeLayout(False)
        Me.TabPagedatos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txtuser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtpassword As TextBox
    Friend WithEvents Btnlogin As Button
    Friend WithEvents Btnsalir As Button
    Friend WithEvents GBdatos As GroupBox
    Friend WithEvents Cbestado As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GBlogin As GroupBox
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPagelogin As TabPage
    Friend WithEvents TabPagedatos As TabPage
End Class
