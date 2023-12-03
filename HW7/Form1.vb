Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Form2 = New Form2
        i.MdiParent = Me
        i.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Form3 = New Form3
        i.MdiParent = Me
        i.Show()
    End Sub
End Class
