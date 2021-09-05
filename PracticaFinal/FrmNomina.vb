Public Class FrmNomina
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A, B As Integer
        A = Convert.ToInt32(TextBox1.Text)
        B = 22 * (A * 8)

        MessageBox.Show("Tu salaio en nomida mensual seria: " + Convert.ToString(B))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        FrmMenu.Show()

    End Sub
End Class