Imports Practica04.Conexion
Public Class FrmVentas
    Dim ObjConexion As New Conexion
    'Dim SqlString As String = "SELECT IdCliente, identificacion, (nombres || ' ' || apellidos) as CLIENTE, activo FROM clientes "
    Dim SqlString As String = "SELECT ventas.IdVenta, ventas.fecha, (clientes.nombres || ' ' || clientes.apellidos) as Cliente, sum(detallesVentas.precio * detallesVentas.cantidad) as total FROM ventas LEFT JOIN clientes ON clientes.IdCliente=ventas.IdCliente LEFT JOIN detallesVentas ON detallesVentas.IdVenta=ventas.IdVenta"
    Dim SqlGroup As String = " GROUP BY ventas.IdVenta"
    Dim tituloAPP As String = Application.ProductName

    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class