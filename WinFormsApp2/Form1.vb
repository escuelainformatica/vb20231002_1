Imports WinFormsApp2.Models

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New CAppBaseoctubreMdfContext
        Dim productos As New List(Of Producto)
        productos = con.Productos.ToList() ' usando la conexion, traer la lista de productos
        DataGridView1.DataSource = productos ' y esa lista de productos se la envie a la grilla
    End Sub
End Class
