Public Class FrmCambio

    Dim abc As Integer = 0
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Select Case abc
            Case 1
                Dim A, B As Double
                A = Convert.ToInt32(TextBox1.Text)
                B = A * 57
                MessageBox.Show("El cambio de " + Convert.ToString(A) + " dolares a pesos dominicanos es " + Convert.ToString(B) + " peso / pesos dominicanos")
                TextBox1.Clear()
            Case 2
                Dim A, B As Double
                A = Convert.ToInt32(TextBox1.Text)
                B = A / 57
                MessageBox.Show("El cambio de " + Convert.ToString(A) + " pesos dominicanos a dolar es " + Convert.ToString(B) + " dolar/ dolares")
                TextBox1.Clear()
            Case Else
                MessageBox.Show("No ha elegido aun el tipo de cambio que desea realizar")
        End Select


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        FrmMenu.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        abc = 1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        abc = 2
    End Sub
End Class