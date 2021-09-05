Imports System.Data.SqlClient


Public Class FrmConsultas

    Dim cn As New SqlClient.SqlConnection("Data Source=DESKTOP-0SC2BM1;Initial Catalog=prog3;Integrated Security=True")

    Sub Mostrar()
        Dim cmd As New SqlClient.SqlCommand("Select*From Registro where Id=' " & TextBox1.Text & "' ", cn)
        Dim Da As New SqlDataAdapter(cmd)
        Dim DR As SqlClient.SqlDataReader
        Dim ds As New DataSet

        Da.Fill(ds, "Registro")
        DataGridView1.DataSource = ds.Tables("Registro")
        cn.Open()
        DR = cmd.ExecuteReader

        If DR.Read Then
            TextBox1.Clear()
            TextBox1.Focus()
        Else
            MsgBox("Este codigo no esta en el sistema")
        End If
        cn.Close()

    End Sub
    Sub Nuevo()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        DataGridView1.DataSource = CloseReason.UserClosing
        TextBox1.Focus()

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FrmConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Mostrar()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New SqlCommand("Insert into Registro values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')", cn)

        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Then
            MsgBox("Debe llenar todos los campos")
        Else
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Registro Guardado")
            Mostrar()

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Nuevo()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cmd As New SqlClient.SqlCommand("Delete from Registro where Id='" & TextBox1.Text & "'", cn)
        If TextBox1.Text = "" Then
            MsgBox("Debe ingresar el Id para Borrar el registro")
        Else
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            Nuevo()
            MsgBox("El registro se ha eliminado completamente")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        FrmMenu.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DataGridView1.ClearSelection()
    End Sub
End Class