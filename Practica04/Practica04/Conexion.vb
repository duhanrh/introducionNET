Imports System.Data.SQLite
Imports System.Data.SqlClient
Public Class Conexion
    Dim InstruccionSQL As String
    Dim con As New SQLiteConnection("Data Source=practica4.db; Version=3")
    Dim DaMySQL As New SQLiteDataAdapter
    Dim cmdMySQL As New SQLiteCommand
    Dim msnSoporte As String = ""
    Dim tituloAPP As String = Application.ProductName
    Function Conectar()
        Try
            con.Open()
            Return "OK"
        Catch ex As Exception
            MessageBox.Show("No se logró realizar la conexión a la base de datos " & ex.Message & System.Environment.NewLine & System.Environment.NewLine & msnSoporte,
            tituloAPP,
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button2)
            Return "KO"
        End Try
        con.Close()
    End Function

    Function InstanciaUnicaDetalles(ByVal TextoABuscar As String, ByVal Columna As String, ByRef grid As DataGridView) As Integer
        Dim cont As Integer = 0
        If TextoABuscar = String.Empty Then Return False
        If grid.RowCount = 0 Then Return -1
        grid.ClearSelection()
        If Columna <> String.Empty Then
            For Each row As DataGridViewRow In grid.Rows
                cont = cont + 1
                'If row.IsNewRow Then Return 0
                If row.Cells(Columna).Value.ToString() = TextoABuscar Then
                    Return cont - 1
                    Exit Function
                End If
            Next
        End If
        Return -1
    End Function

    Function Buscar2(ByVal TextoABuscar As String, ByVal Columna As String, ByRef grid As DataGridView) As Boolean
        Dim encontrado As Boolean = False
        If TextoABuscar = String.Empty Then Return False
        If grid.RowCount = 0 Then Return False
        grid.ClearSelection()
        If Columna = String.Empty Then
            For Each row As DataGridViewRow In grid.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Value.ToString() = TextoABuscar Then
                        row.Selected = True
                        Return True
                    End If
                Next
            Next
        Else
            For Each row As DataGridViewRow In grid.Rows
                If row.IsNewRow Then Return False
                If row.Cells(Columna).Value.ToString() = TextoABuscar Then
                    row.Selected = True
                    Return True
                End If

            Next
        End If
        Return encontrado
    End Function

    Function UltimoID(ByVal Clave As String, ByVal Tabla As String) As Integer
        Dim StrSQL As String
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Try
            ':::Creamos el objeto DataAdapter y le pasamos los dos parametros (Instruccion, conexión)
            'SELECT IF(ISNULL(Max(IDorden)), 0, Max(IDorden)) AS ULTIMO FROM tblordenes
            StrSQL = Trim("SELECT MAX(" & Clave & ") AS ULTIMOID FROM " & Tabla & "")
                Dim DA As New SQLiteDataAdapter(StrSQL, con)
            ':::Creamos el objeto DataTable que recibe la informacion del DataAdapter
            Dim DT As New DataTable 'Es como si fuera una tabla de esa base de datos, recomendao para uso de una solsa tbl

            DA.Fill(DT)

            If DT.Rows.Count > 0 Then
                'MsgBox("Ultimo ID : " & Val(DT.Rows(0).Item(0).ToString),messagebox.showStyle.Critical, utilidades.tituloAPP)
                Dim ultID As Integer = Val(DT.Rows(0).Item("ULTIMOID").ToString)
                Return Val(ultID)
            Else
                Return -1
            End If
        Catch ex As Exception
            MessageBox.Show("No se logró realizar la consulta ((Ultimo ID)), " & ex.Message,
            tituloAPP,
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button2)
            Return -1
        End Try
        con.Close()
    End Function

    Function PrimerID(ByVal Clave As String, ByVal Tabla As String) As Integer
        Dim StrSQL As String
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Try
            ':::Creamos el objeto DataAdapter y le pasamos los dos parametros (Instruccion, conexión)
            StrSQL = Trim("Select If(ISNULL(MIN(" & Clave & ")), 0, MIN(" & Clave & ")) As PRIMERID FROM " & Tabla & "")
            Dim DA As New SQLiteDataAdapter(StrSQL, con)
            ':::Creamos el objeto DataTable que recibe la informacion del DataAdapter
            Dim DT As New DataTable 'Es como si fuera una tabla de esa base de datos, recomendao para uso de una solsa tbl

            DA.Fill(DT)

            If DT.Rows.Count > 0 Then
                Dim ultID As Integer = Val(DT.Rows(0).Item("PRIMERID").ToString)
                Return Val(ultID)
            Else
                Return -1
            End If
        Catch ex As Exception
            MessageBox.Show("No se logró realizar la consulta ((Primer ID)), " & ex.Message,
            tituloAPP,
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button2)
            Return -1
        End Try
        con.Close()
    End Function
    Function ConsultaValorXcampo(ByVal Campo As String, ByVal Tabla As String, ByVal Condicion As String) As String
        Dim StrSQL As String
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Try
            StrSQL = Trim("SELECT " & Campo & " AS Valor FROM " & Tabla & " " & Condicion & "")
            Dim DA As New SQLiteDataAdapter(Trim(StrSQL), con)
            Dim DT As New DataTable
            DA.Fill(DT)
            If DT.Rows.Count > 0 Then
                Return (DT.Rows(0).Item("VALOR").ToString)
            Else
                Return ""
            End If
        Catch ex As Exception
            MessageBox.Show("No se logró realizar la consulta (Valor por campo), " & ex.Message,
            tituloAPP,
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button2)
            Return ""
        End Try
        con.Close()
    End Function
    Function SumaCantidad(ByVal Campo As String, ByVal Tabla As String, ByVal Condicion As String) As Double
        Dim StrSQL As String
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Try
            ':::Creamos el objeto DataAdapter y le pasamos los dos parametros (Instruccion, conexión)
            StrSQL = "SELECT IF(ISNULL(SUM(" & Campo & ")), 0, SUM(" & Campo & ")) AS SALDO FROM " & Tabla & " " & Condicion & ""
            Dim DA As New SQLiteDataAdapter(Trim(StrSQL), con)
            ':::Creamos el objeto DataTable que recibe la informacion del DataAdapter
            Dim DT As New DataTable 'Es como si fuera una tabla de esa base de datos, recomendao para uso de una solsa tbl
            DA.Fill(DT)
            If DT.Rows.Count > 0 Then
                Dim ultID As Double = CDbl(DT.Rows(0).Item("SALDO").ToString)
                Return ultID
            Else
                Return 0
            End If
        Catch ex As Exception
            MessageBox.Show("No se logró realizar la consulta (Suma Cantidades), " & ex.Message,
            tituloAPP,
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button2)
            Return 0
        End Try
        con.Close()
    End Function

    Function CuentaRegistro(ByVal Campo As String, ByVal Tabla As String, ByVal Condicion As String) As Integer
        Dim StrSQL As String
        Dim Total As Integer = 0
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Try
            StrSQL = "SELECT COUNT(" & Campo & ") AS TotalRegistros FROM " & Tabla & " " & Condicion
            Dim DA As New SQLiteDataAdapter(Trim(StrSQL), con)
            Dim DT As New DataTable
            DA.Fill(DT)
            Total = Val(DT.Rows(0).Item("TotalRegistros").ToString)
        Catch ex As Exception
            MessageBox.Show("No se logró realizar la consulta (Cuenta Registros), " & ex.Message,
            tituloAPP,
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button2)
        End Try
        Return Val(Total)
        con.Close()
    End Function

    Function CuentaRegistroID(ByVal Clave As String, ByVal Tabla As String) As Integer
        Dim StrSQL As String
        Dim Total As Integer = -1
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Try
            StrSQL = "SELECT COUNT(" & Clave & ") AS TotalRegistros FROM " & Tabla & " WHERE " & Clave & "=" & Clave & ""
            Dim DA As New SQLiteDataAdapter(StrSQL, con)
            Dim DT As New DataTable
            DA.Fill(DT)
            Total = Val(DT.Rows(0).Item("TotalRegistros").ToString)
        Catch ex As Exception
            MessageBox.Show("No se logró realizar la consulta (Cuenta Registros por ID), " & ex.Message,
            tituloAPP,
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button2)
        End Try
        Return Val(Total)
        con.Close()
    End Function

    Function Consulta(ByVal Contenedor As Object, ByVal Sql As String)
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Try
            ':::Creamos el objeto DataAdapter y le pasamos los dos parametros (Instruccion, conexión)
            Dim DA As New SQLiteDataAdapter(Sql, con)
            ':::Creamos el objeto DataTable que recibe la informacion del DataAdapter
            Dim DT As New DataTable 'Es como si fuera una tabla de esa base de datos, recomendao para uso de una solsa tbl
            Dim DS As New DataSet 'Es como si fuera una base de datos de SQL Server, recomendado para varias tablas y relacion
            ':::Pasamos la informacion del DataAdapter al DataTable mediante la propiedad Fill
            DA.Fill(DT) 'DS
            If DT.Rows.Count > 0 Then
                'Return DT
                Contenedor.DataSource = DT
                Return "OK"
            Else
                Return "KO"
            End If
        Catch ex As Exception
            MessageBox.Show("No se logró realizar la consulta, " & ex.Message,
            tituloAPP,
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
            Return "KO"
        End Try
        con.Close()
    End Function
    Function ConsultaAddItem0CB(ByVal Contenedor As Object, ByVal TextoIndex0 As String, ByVal Sql As String)
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Try
            ':::Creamos el objeto DataAdapter y le pasamos los dos parametros (Instruccion, conexión)
            Dim DA As New SQLiteDataAdapter(Sql, con)
            ':::Creamos el objeto DataTable que recibe la informacion del DataAdapter
            Dim DT As New DataTable 'Es como si fuera una tabla de esa base de datos, recomendao para uso de una solsa tbl
            Dim DS As New DataSet 'Es como si fuera una base de datos de SQL Server, recomendado para varias tablas y relacion
            ':::Pasamos la informacion del DataAdapter al DataTable mediante la propiedad Fill
            DA.Fill(DT) 'DS
            If DT.Rows.Count > 0 Then
                'Return DT
                'DT.Rows.Add(0, TextoIndex0)
                Dim Row As DataRow
                Row = DT.NewRow()
                Row(0) = 0
                Row(1) = TextoIndex0.ToString
                DT.Rows.InsertAt(Row, 0)
                Contenedor.DataSource = DT
                Return "OK"
            Else
                Return "KO"
            End If
        Catch ex As Exception
            MessageBox.Show("No se logró realizar la consulta (Agregar Item 0)," & ex.Message,
            tituloAPP,
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button2)
            Return "KO"
        End Try
        con.Close()
    End Function

    Sub Consulta2(ByVal contenedor As Object, ByVal Sql As String)
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Try
            ':::Creamos el objeto DataAdapter y le pasamos los dos parametros (Instruccion, conexión)
            Dim DA As New SQLiteDataAdapter(Sql, con)
            ':::Creamos el objeto DataTable que recibe la informacion del DataAdapter
            Dim DT As New DataTable
            ':::Pasamos la informacion del DataAdapter al DataTable mediante la propiedad Fill
            DA.Fill(DT)
            ':::Ahora mostramos los datos en el DataGridView
            'Tabla.DataSource = DT

            ' para combos utilizar
            'Combobox1.DataSource = MysqlDset
            'Combobox1.DisplayMember = "nombre"  'el nombre de la columna de la tbl que se desea mostrar
            'Combobox1.ValueMember = "id"  'el id de la tabla relacionada con el nombre que muestras muy importante para saber el ide de la seleccion en el combobox
            If DT.Rows.Count > 0 Then
                contenedor.Datasource = DT
            End If
        Catch ex As Exception
            MessageBox.Show("No se logró realizar la consulta, " & ex.Message,
            tituloAPP,
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button2)
        End Try
        con.Close()

    End Sub

    Public Function AbrirRegistros(ByVal Sql As String) As DataTable
        Dim Tabla As New DataTable
        'refrescar
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Try
            Dim Adaptador As New SQLiteDataAdapter(Sql, con)
            Tabla.Clear()
            Adaptador.Fill(Tabla)
            If Tabla.Rows.Count > 0 Then
                ' contenedor.Datasource = DT
            End If
        Catch ex As Exception
            MessageBox.Show("No se logró realizar la consulta (Abrir Registros), " & ex.Message,
            tituloAPP,
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button2)
        End Try
        con.Close()
        Return Tabla
    End Function
    Public Function Abrir(ByVal strSQL As String) As DataTable
        Return AbrirRegistros(strSQL)
    End Function

    Function Operaciones(ByVal Sql As String) As String
        ':::Abrimos nuestra conexion
        If con.State = ConnectionState.Open Then
            con.Close()
        End If

        con.Open()
        ':::Usamos el capturador de errores Try
        Try
            ':::Creamos un objeto de tipo Command para ejecutar las consultas
            ':::de ingreso, actualizacion y eliminación (Insert, Update, Delete)
            ':::Nos pide 2 parametros (la consulta SQL que recibe el procedimiento y la conexion)
            Dim cmd As New SQLiteCommand(Sql, con)
            ':::Ejecutamos la consulta mediante la propiedad ExecuteNonQuery() del SQLiteCommand
            If cmd.ExecuteNonQuery() Then
                'MessageBox.Show("Operación realizada correctamente")
                Return "OK"
            Else
                Return "KO"
            End If

        Catch ex As Exception
            MessageBox.Show("Error al realizar operación debido a: " & ex.Message,
            tituloAPP,
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button2)
            Return "KO"
        End Try
        ':::Cerramos la conexion
        con.Close()

    End Function
    Function OperacionesDT(ByVal Tabla As DataGridView, ByVal Sql As String)
        Dim con As Object = Nothing
        Dim DaMySQL As New SQLiteDataAdapter
        Dim cmdMySQL As New SQLiteCommand
        con.Open()
        Try
            ':::Creamos nuestro objeto de tipo Command que almacenara nuestras instrucciones
            ':::Necesita 2 parametros (Instruccion, conexion)
            Dim cmd As New SQLiteCommand(Sql, con)
            ':::Ejecutamos la instruccion mediante la propiedad ExecuteNonQuery del command
            If cmd.ExecuteNonQuery() Then
                Return "OK"
            Else
                'MsgBox("No se logró realizar la operación , " & cmdMySQL.,messagebox.showStyle.Critical, utilidades.tituloAPP)
                Return "KO"
            End If

        Catch ex As Exception
            MessageBox.Show("No se logró realizar la operación, " & ex.Message,
            tituloAPP,
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button2)
            Return "KO"
        End Try
        con.Close()

    End Function
End Class

