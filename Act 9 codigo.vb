Public Class Form1
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim matriz(6, 6) As Integer
        Dim vector(4) As Integer
        Dim nuevaMatriz(2, 3) As Integer
        Dim rnd As New Random()
        For f As Integer = 0 To 6
            For c As Integer = 0 To 6
                matriz(f, c) = rnd.Next(1, 21)
            Next
        Next
        DataGridView1.ColumnCount = 7
        DataGridView1.RowCount = 7
        For f As Integer = 0 To 6
            For c As Integer = 0 To 6
                DataGridView1.Rows(f).Cells(c).Value = matriz(f, c)
            Next
        Next
        vector(0) = matriz(1, 2)
        vector(1) = matriz(2, 3)
        vector(2) = matriz(3, 4)
        vector(3) = matriz(4, 5)
        vector(4) = matriz(5, 6)
        DataGridView2.ColumnCount = 5
        DataGridView2.RowCount = 1
        For f As Integer = 0 To 4
            DataGridView2.Rows(0).Cells(f).Value = vector(f)
        Next
        nuevaMatriz(0, 0) = matriz(3, 2)
        nuevaMatriz(0, 1) = matriz(3, 3)
        nuevaMatriz(0, 2) = matriz(3, 4)
        nuevaMatriz(0, 3) = matriz(3, 5)
        nuevaMatriz(1, 0) = matriz(4, 2)
        nuevaMatriz(1, 1) = matriz(4, 3)
        nuevaMatriz(1, 2) = matriz(4, 4)
        nuevaMatriz(1, 3) = matriz(4, 5)
        nuevaMatriz(2, 0) = matriz(5, 2)
        nuevaMatriz(2, 1) = matriz(5, 3)
        nuevaMatriz(2, 2) = matriz(5, 4)
        nuevaMatriz(2, 3) = matriz(5, 5)
        DataGridView3.ColumnCount = 4
        DataGridView3.RowCount = 3
        For f As Integer = 0 To 2
            For c As Integer = 0 To 3
                DataGridView3.Rows(f).Cells(c).Value = nuevaMatriz(f, c)
            Next
        Next
    End Sub
End Class
