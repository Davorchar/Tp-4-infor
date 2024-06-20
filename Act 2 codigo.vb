Public Class Form1
    Private Sub cmdCargar_Click(sender As Object, e As EventArgs) Handles cmdCargar.Click
        Dim matriz(4, 3) As Integer
        Dim rnd As New Random
        Dim sumafila1 As Integer = 0
        Dim sumafila2 As Integer = 0
        Dim sumafila3 As Integer = 0
        Dim sumafila4 As Integer = 0
        DataGridView1.ColumnCount = 4
        DataGridView1.RowCount = 5
        For f As Integer = 0 To 4
            For c As Integer = 0 To 3
                matriz(f, c) = rnd.Next(1, 40)
            Next
        Next
        For f As Integer = 0 To 4
            For c As Integer = 0 To 3
                DataGridView1.Rows(f).Cells(c).Value = matriz(f, c)
            Next
        Next
        For c = 1 To 3
            sumafila1 += matriz(1, c)
            sumafila2 += matriz(2, c)
            sumafila3 += matriz(3, c)
            sumafila4 += matriz(4, c)
        Next
        MessageBox.Show("la suma de la fila 1 es" & sumafila1)
        MessageBox.Show("la suma de la fila 2 es" & sumafila2)
        MessageBox.Show("la Suma de la fila 4 es" & sumafila3)
        MessageBox.Show("la Suma de la fila 5 es " & sumafila4)
        Dim total As Integer
        total = sumafila1 + sumafila2 + sumafila3 + sumafila4
        lblSuma.Text = " la suma de las filas 2,3,4 y 5 es " & total
    End Sub
End Class
