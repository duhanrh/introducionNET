Public Class CheckForm
    Public Function VerificarForm(_form As Form) As Form

        For Each f As Form In Application.OpenForms
            If f.Name = _form.Name Then
                Return f
            End If
        Next

        Return Nothing

    End Function


    'Método para abrir el formulario una sola vez.
    Public Function OpenSubForm(ByVal form As Form) As Boolean
        'Chequeo si ya está abierto.
        For Each f As Form In Application.OpenForms
            'Si está abierto devuelvo False (no se puede abrir).
            If f.Name = form.Name Then
                form.ActiveControl = form
                Return False
            End If
        Next
        'Si se llega a este punto es porque no está abierto.
        'Abro el formulario.
        form.Show()
        'Indico apertura exitosa.
        Return True
    End Function

    Public Function EstaAbierto(ByVal Myform As Form)
        Dim objForm As Form
        Dim isOpen As Boolean = False
        For Each objForm In Application.OpenForms
            If (Trim(objForm.Name) = Trim(Myform.Name)) Then
                isOpen = True
            End If
        Next
        Return isOpen
    End Function
End Class
