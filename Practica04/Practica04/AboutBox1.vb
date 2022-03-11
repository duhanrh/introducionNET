Public NotInheritable Class AboutBox1

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = String.Format("Acerca de {0}", Application.ProductName)
        Me.LabelProductName.Text = Application.ProductName
        Me.LabelVersion.Text = String.Format("Versión {0}", Application.ProductVersion.ToString)
        Me.LabelCopyright.Text = Application.ProductName & "@" & "Soluciones integrales TIC R&H"
        Me.LabelCompanyName.Text = "Soluciones integrales TIC R&H"
        Me.TextBoxDescription.Text = ""
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
