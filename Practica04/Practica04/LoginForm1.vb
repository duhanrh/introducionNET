Public Class LoginForm1

    ' TODO: inserte el c�digo para realizar autenticaci�n personalizada usando el nombre de usuario y la contrase�a proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuaci�n: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementaci�n de IPrincipal utilizada para realizar la autenticaci�n. 
    ' Posteriormente, My.User devolver� la informaci�n de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim frm As New MDIParent1
        Me.Hide()
        frm.Show()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'UsernameLabel.ForeColor = My.Settings.ColorSecondary
    End Sub
End Class
