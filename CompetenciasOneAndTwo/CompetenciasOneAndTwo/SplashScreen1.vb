Public NotInheritable Class SplashScreen1
    Dim time As Integer = 3
    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()

        'Título de la aplicación
        'If My.Application.Info.Title <> "" Then
        '    ApplicationTitle.Text = My.Application.Info.Title
        'Else
        '    'Si falta el título de la aplicación, utilice el nombre de la aplicación sin la extensión
        '    ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        'End If

        ApplicationTitle.Text = Application.ProductName

        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        'Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        Version.Text = Application.ProductVersion

        'Información de Copyright
        'Copyright.Text = My.Application.Info.Copyright
        Copyright.Text = Application.CompanyName
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If time > 0 Then
            time -= 1
            'Label1.Text = time
        Else
            Timer1.Enabled = False
            Me.Hide()
            Dim frm As New MDIParent1
            frm.Show()
        End If
    End Sub
End Class
