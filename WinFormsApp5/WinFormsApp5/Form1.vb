Public Class Form1
    Dim time As Integer = 10
    Dim contador As Integer = 1
    Dim endTitulo As String = "de 10"
    Dim beginTitulo As String = ""
    Private Sub PbPlay_Click(sender As Object, e As EventArgs) Handles PbPlay.Click
        time = 10
        contador = 1
        Timer1.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblLetrero.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6.
        Dim value As Integer = CInt(Int((1000 * Rnd()) + 1))
        TxtNumero.Text = value
        LblLetrero.Text = contador & " " & endTitulo
        If Val(TxtNumero.Text) Mod 2 = 0 Then
            'MessageBox.Show("Es par")
        End If
        If time > 0 Then
            time = time - 1
            Label2.Text = time
        Else
            Timer1.Enabled = False
        End If
        contador += 1
    End Sub
End Class
