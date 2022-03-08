Public Class LoginForm1
    Dim cont As Integer = 0
    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim frm As New MDIParent1
        If (TxtUsername.Text.Trim().Length = 0) Or (TxtPassword.Text.Trim().Length = 0) Then
            MessageBox.Show("los campos de usuario y contraseña son requeridos")
        End If

        If (TxtUsername.Text.Trim() = "admin") And (TxtPassword.Text.Trim() = "admin") Then
            Me.Hide()
            frm.Show()
        Else
            cont += 1
            MessageBox.Show("Datos de usuario o contraseña invalidos")
        End If

        If cont = 3 Then
            MessageBox.Show("Cuenta inhabilitada intenta más tarde")
            End
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'UsernameLabel.ForeColor = My.Settings.ColorSecondary
    End Sub
End Class
