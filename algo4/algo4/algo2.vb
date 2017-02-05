Public Class algo2
    Private Sub clicker_Click(sender As Object, e As EventArgs) Handles clicker.Click
        Dim ctr As Integer = 1
        Dim num As Integer = 2
        Dim sum As Integer = 0
        Dim sum2 As Integer = 0
        Dim sum3 As Integer = 0



        'While Loop
        While (ctr <= 10)
            sum = sum + num
            num = num + 2
            ctr = ctr + 1
        End While
        ctr = 1
        num = 2
        output1.Text = sum.ToString()
        Button1.BackColor = Color.Orange



        'Repeat Until
        Do Until (ctr > 10)
            sum2 = sum2 + num
            num = num + 2
            ctr = ctr + 1
        Loop
        ctr = 1
        num = 2
        output2.Text = sum2.ToString()
        Button2.BackColor = Color.Orange


        'For Loop
        For ctr = 1 To 10
            sum3 = sum3 + num
            num = num + 2
        Next

        output3.Text = sum3.ToString()
        Button3.BackColor = Color.Orange
        Button4.BackColor = Color.Orange
        Button5.BackColor = Color.Orange

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        output1.Text = "While Loop"
        output2.Text = "Repeat Until"
        output3.Text = "For Loop"
        Button1.BackColor = Color.Empty
        Button2.BackColor = Color.Empty
        Button3.BackColor = Color.Empty
        Button4.BackColor = Color.Empty
        Button5.BackColor = Color.Empty
    End Sub
End Class