Public Class Form1
    Dim ed As Integer
    Private Sub BtnProcesar_Click(sender As Object, e As EventArgs) Handles BtnProcesar.Click

        If Txtedad.Text.Trim().Length > 0 Then
            ed = Val(Txtedad.Text)
            Dim dv = Val(Txtedad.Text) * 365
            Lbldias.Text = CStr(dv) + " días "

            If ed > 50 Then
                Txtbono.Text = 70000
            Else
                If ed > 40 Then
                    Txtbono.Text = 50000
                Else
                    Txtbono.Text = 20000
                End If
            End If
        Else
            MessageBox.Show("Debes ingresar el valor de la edad")
        End If

    End Sub

    Sub Limpiar()
        Txtedad.Clear()
        Lbldias.Text = ""
        Txtbono.Clear()
    End Sub

    Private Sub Btnlimpiar_Click(sender As Object, e As EventArgs) Handles Btnlimpiar.Click
        Limpiar()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName + " - " + Application.ProductVersion
    End Sub
End Class
