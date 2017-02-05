Public Class Algo8
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim i As Integer
        Dim list As New ArrayList


        For i = 1 To 5
            [i] = txt1.Text
        Next
        txt1.Text = i

    End Sub
End Class