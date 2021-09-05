Public Class FrmMenu
    Private Sub SumadoraToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SumadoraToolStripMenuItem1.Click
        Me.Hide()
        FrmSuamdora.Show()

    End Sub

    Private Sub CasaDeCambioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CasaDeCambioToolStripMenuItem.Click
        Me.Hide()
        FrmCambio.Show()
    End Sub

    Private Sub NominaSemanalToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NominaSemanalToolStripMenuItem1.Click
        Me.Hide()
        FrmNomina.Show()
    End Sub

    Private Sub SalirDelSistemaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirDelSistemaToolStripMenuItem1.Click
        Application.Exit()

    End Sub

    Private Sub ReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteToolStripMenuItem.Click
        FrmReporte.Show()
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click
        Me.Hide()
        FrmConsultas.Show()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("https://www.utesa.edu/home/")
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        LinkLabel2.LinkVisited = True
        System.Diagnostics.Process.Start("http://utesa.edu/webutesa/progaca/carreraf.asp?facul=CIENCIAS%20Y%20HUMANIDADES")
    End Sub
End Class