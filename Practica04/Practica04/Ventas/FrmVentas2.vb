'Importamos la librería necesaria para nuestra conexión
Imports System.Data.SQLite
Imports System.Data.SqlClient
Public Class FrmVentas2
    Private Const V As String = "productos"
    'Creamos un objeto de nombre "con" de tipo SQLiteConnetion y le asignamos nuestra cadena de conexión con la ruta de nuestra base de datos
    Dim con As New SQLiteConnection("Data Source=practica4.db; Version=3")
    Dim consecutivo As Integer
    Private Sub TxtIdProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIdProducto.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub TxtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrecio.KeyPress
        If TxtPrecio.Text.Trim().Length = 0 And Char.IsPunctuation(e.KeyChar) Then 'para que el primer caracter no sea el punto
            e.Handled = True
        Else
            'verificar la existencia del punto para no volverlo a insertar
            Dim ContPunto As Integer = TxtPrecio.Text.Trim().IndexOf(".")
            If ContPunto > -1 And e.KeyChar = "." Then
                e.Handled = True
            Else
                e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "."
            End If
        End If
    End Sub

    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub TxtNit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNit.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not (Char.IsLetter(e.KeyChar)) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ':::Abrimos la conexión
            con.Open()
            ':::Si se estableció conexión correctamente dirá "Conectado"
            MessageBox.Show("Conectado")
        Catch ex As Exception
            ':::Si no se conecta nos mostrara el posible fallo en la conexión
            MessageBox.Show("No se conecto por: " & ex.Message)
        End Try
        CargarProductos()
    End Sub

    Private Sub CargarProductos()
        Dim ds As New DataSet
        Dim da As New SQLiteDataAdapter("select * from productos ", con)
        da.Fill(ds, "productos")

        Dim dataViewLocal As DataView = New DataView(ds.Tables(V))
        DgDetallesVenta.DataSource = dataViewLocal
    End Sub
End Class
