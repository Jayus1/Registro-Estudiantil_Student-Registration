Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand

Public Class FrmLogin
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click



    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New SqlConnection("Data Source=DESKTOP-0SC2BM1;Initial Catalog=prog3;Integrated Security=True")
        Dim dr As SqlDataReader
        Dim ds As New DataSet

        Try
            conn.Open()
            Dim cmd As New SqlCommand("Select*From Registro where Usuario='" & Me.TextBox1.Text & "'" & " and Clave= '" & Me.TextBox2.Text & "'", conn)
            dr = cmd.ExecuteReader

            If (dr.HasRows = True) Then
                MessageBox.Show("BIENVENIDOS A NUESTRO SISTEMA ESCOLAR")
                Me.Hide()
                FrmMenu.Show()

            ElseIf (dr.HasRows = False) Then
                MessageBox.Show("Nombre de usuario o la clave esta incorrecta")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox1.Focus()
            End If
        Catch ex As Exception

        End Try

        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged



    End Sub


End Class