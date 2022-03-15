Public Class Form1
    Sub Limpiar()
        CbTipo.Items.Clear()
        CbPeliculas.Items.Clear()
        CbHorarios.Items.Clear()
        LblPlan.Text = "PLAN"
        TxtEdad.Text = ""
        TxtPrecio.Text = ""
        TxtEdad.Enabled = True
        GbDatos.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
    End Sub


    Private Sub BtnPlanes_Click(sender As Object, e As EventArgs) Handles BtnPlanes.Click
        CbTipo.Items.Clear()
        CbPeliculas.Items.Clear()
        CbHorarios.Items.Clear()

        If (BtnPlanes.Text = "Mostrar plan") Then

            If TxtEdad.Text = "" Then
                MessageBox.Show("El campo edad es requerido",
                "CINEMAR",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button2)
                Return
            End If

            TxtEdad.Enabled = False
            BtnPlanes.Text = "Nuevo plan"

            If Val(TxtEdad.Text) < 18 Then
                LblPlan.Text = "PLAN INFANTIL"
                'tipo peliculas
                CbTipo.Items.Clear()
                CbTipo.Items.Add("Infantil")
                CbTipo.Text = "Infantil"
                'Peliculas
                CbPeliculas.Items.Clear()
                CbPeliculas.Items.Add("Encanto")
                CbPeliculas.Items.Add("Hotel transylvania")
                CbPeliculas.Items.Add("Lucas")
                CbPeliculas.Items.Add("Tom y Jerry")
                CbPeliculas.Items.Add("Coco")
                'Horarios
                CbHorarios.Items.Clear()
                CbHorarios.Items.Add("10:00")
                CbHorarios.Items.Add("12:00")
                CbHorarios.Items.Add("14:00")
                CbHorarios.Items.Add("16:00")
            Else
                LblPlan.Text = "PLAN ADULTO"
            'tipo peliculas
            CbTipo.Items.Clear()
            CbTipo.Items.Add("Acción")
            CbTipo.Items.Add("Drama")
            CbTipo.Items.Add("Terror")
            CbTipo.Text = "Acción"
            'Peliculas, ESTO ESTA EN EL CHANGE
            'Horarios
            CbHorarios.Items.Clear()
            CbHorarios.Items.Add("10:00")
            CbHorarios.Items.Add("12:00")
            CbHorarios.Items.Add("14:00")
            CbHorarios.Items.Add("16:00")
            CbHorarios.Items.Add("18:00")
            CbHorarios.Items.Add("20:00")
            CbHorarios.Items.Add("22:00")
            CbHorarios.Items.Add("00:00")
        End If
            GbDatos.Enabled = True

        Else
            BtnPlanes.Text = "Mostrar plan"
            TxtEdad.Clear()
            TxtEdad.Enabled = True
            GbDatos.Enabled = False
        End If
    End Sub

    Private Sub TxtEdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEdad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub CbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTipo.SelectedIndexChanged
        'If CbTipo.Text.ToUpper <> "INFANTIL" Then
        '    CbPeliculas.Items.Clear()
        '    CbPeliculas.Items.Add("Peli " & CbTipo.Text.ToLower & " 1")
        '    CbPeliculas.Items.Add("Peli " & CbTipo.Text.ToLower & " 2")
        '    CbPeliculas.Items.Add("Peli " & CbTipo.Text.ToLower & " 3")
        'End If
    End Sub
    Private Sub CbTipo_TextChanged(sender As Object, e As EventArgs) Handles CbTipo.TextChanged
        If CbTipo.Text.ToUpper <> "INFANTIL" Then
            CbPeliculas.Items.Clear()
            CbPeliculas.Items.Add("Peli " & CbTipo.Text.ToLower & " 1")
            CbPeliculas.Items.Add("Peli " & CbTipo.Text.ToLower & " 2")
            CbPeliculas.Items.Add("Peli " & CbTipo.Text.ToLower & " 3")
        End If
    End Sub

    Private Sub CbHorarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbHorarios.SelectedIndexChanged
        If Val(CbHorarios.Text.Substring(0, 2)) >= 16 Or Val(CbHorarios.Text.Substring(0, 2)) = 0 Then
            TxtPrecio.Text = 8500
        Else
            TxtPrecio.Text = 5500
        End If

    End Sub

    Private Sub BtnComprar_Click(sender As Object, e As EventArgs) Handles BtnComprar.Click
        Dim errores As Integer = 0
        Dim sala As New Random
        Dim silla As New Random
        If (CbTipo.Text = "") Then
            errores += 1
        End If
        If (CbPeliculas.Text = "") Then
            errores += 1
        End If
        If (CbHorarios.Text = "") Then
            errores += 1
        End If

        If errores > 0 Then
            MessageBox.Show("Faltan algunos datos para procesar la compra revisa el formulario",
           "CINEMAR",
           MessageBoxButtons.OK,
           MessageBoxIcon.Error,
           MessageBoxDefaultButton.Button2)
            Return
        End If

        Dim datos As String = ""
        datos = datos & "Tipo de película : " & CbTipo.Text & System.Environment.NewLine
        datos = datos & "Película : " & CbPeliculas.Text & System.Environment.NewLine
        datos = datos & "Sala : " & sala.Next(1, 5) & System.Environment.NewLine
        datos = datos & "Silla : " & silla.Next(1, 32) & System.Environment.NewLine
        datos = datos & "Hora : " & CbHorarios.Text & System.Environment.NewLine
        datos = datos & "Valor entrada : " & TxtPrecio.Text & System.Environment.NewLine
        MessageBox.Show(LblPlan.Text.ToUpper & System.Environment.NewLine & System.Environment.NewLine & datos,
           "CINEMAR",
           MessageBoxButtons.OK,
           MessageBoxIcon.Information,
           MessageBoxDefaultButton.Button2)
        Limpiar()
    End Sub


End Class
