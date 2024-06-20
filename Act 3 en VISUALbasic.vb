Public Class Form1
    Dim matriz(4, 4) As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ColumnCount = 5
        DataGridView1.Rows.Add(5)
        For i As Integer = 0 To 4
            DataGridView1.Width = 60
        Next
    End Sub
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdCargar.Click
        Dim rnd As New Random
        For i = 0 To 4
            For j = 0 To 4
                matriz(i, j) = rnd.Next(1, 31)
                DataGridView1.Rows(i).Cells(j).Value = matriz(i, j)
            Next
        Next


    End Sub

    Private Sub cmdEjecutar_Click_1(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim D1, D2, D3, D4, D5 As Integer
        Dim C1, C2, C3, C4, C5 As Integer
        D1 = matriz(0, 0)
        D2 = matriz(1, 1)
        D3 = matriz(2, 2)
        D4 = matriz(3, 3)
        D5 = matriz(4, 4)

        C1 = matriz(0, 4)
        C2 = matriz(1, 3)
        C3 = matriz(2, 2)
        C4 = matriz(3, 1)
        C5 = matriz(4, 0)

        TextBox1.Text = "los elementos de la primera diagonal son" & D1 & " " & D2 & " " & D3 & " " & " " & D4 & " " & D5
        TextBox2.Text = "los elementos de la contradiagonal son" & C1 & " " & C2 & " " & C3 & " " & " " & C4 & " " & C5

    End Sub
End Class
