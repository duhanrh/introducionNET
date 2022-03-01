Imports System.Windows.Forms

Public Class MDIParent1
    Private m_ChildFormNumber As Integer

    Private Sub MDIParent1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub Competencia1Ejercicio1_Click(sender As Object, e As EventArgs) Handles Competencia1Ejercicio1.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New Form1
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Competencia 1 ::: Ejercicio 1"
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.Show()
    End Sub

    Private Sub Competencia1Ejercicio2_Click(sender As Object, e As EventArgs) Handles Competencia1Ejercicio2.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New Form2
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Competencia 1 ::: Ejercicio 2"
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.Show()
    End Sub

    Private Sub Competencia2Ejercicio1_Click(sender As Object, e As EventArgs) Handles Competencia2Ejercicio1.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New Form3
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Competencia 2 ::: Ejercicio 1" '::: ventana " & m_ChildFormNumber
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.Show()
    End Sub

    Private Sub Competencia2Ejercicio2_Click(sender As Object, e As EventArgs) Handles Competencia2Ejercicio2.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New Form4
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Competencia 2 ::: Ejercicio 2" ' ::: ventana " & m_ChildFormNumber
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.Show()
    End Sub

    Private Sub Competencia2Ejercicio3_Click(sender As Object, e As EventArgs) Handles Competencia2Ejercicio3.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New Form5
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Competencia 2 ::: Ejercicio 3" ' ::: ventana " & m_ChildFormNumber
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.Show()
    End Sub

    Private Sub Competencia2Ejercicio4_Click(sender As Object, e As EventArgs) Handles Competencia2Ejercicio4.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New Form6
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Competencia 2 ::: Ejercicio 4" ' ::: ventana " & m_ChildFormNumber
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.Show()
    End Sub

    Private Sub Competencia2Ejercicio5_Click(sender As Object, e As EventArgs) Handles Competencia2Ejercicio5.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New Form7
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Competencia 2 ::: Ejercicio 5" ' ::: ventana " & m_ChildFormNumber
        ChildForm.WindowState = FormWindowState.Maximized
        ChildForm.Show()
    End Sub
End Class
