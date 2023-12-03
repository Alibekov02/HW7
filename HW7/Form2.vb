Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As Double = Convert.ToDouble(TextBox1.Text)
        Dim s As Double = Math.PI * r * r
        Dim c As Double = 2 * Math.PI * r
        ResultLabel.Text = "Айлананын узундугу :" & c & " аянты :" & s

    End Sub
End Class