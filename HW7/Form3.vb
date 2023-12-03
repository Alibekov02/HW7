Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As Double = Convert.ToDouble(TextBox1.Text)
        Dim s As Double = r * r
        Dim c As Double = 4 * r
        ResultLabel.Text = "Квадраттын периметри :" & c & " аянты :" & s
    End Sub
End Class