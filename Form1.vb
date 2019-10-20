Public Class Form1
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            If soma.Checked = True Then
                Resultado.text = Double.Parse(valor1.Text) + Double.Parse(valor2.Text)
            End If
            If multiplicação.Checked = True Then
                Resultado.text = Double.Parse(valor1.Text) * Double.Parse(valor2.Text)
            End If
            If divisão.Checked = True Then
                Resultado.text = Double.Parse(valor1.Text) / Double.Parse(valor2.Text)
            End If
            If subtração.Checked = True Then
                Resultado.text = Double.Parse(valor1.Text) - Double.Parse(valor2.Text)
            End If
        Catch
            MessageBox.Show("APENAS NÚMEROS")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form1 As Form1 = Me
        form1 Close()
    End Sub
End Class