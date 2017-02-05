Public Class mainpage


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (input1.Text = String.Empty) Then
            MessageBox.Show("Textbox 1 is empty. Please input 2 numbers!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            input1.Focus()
        ElseIf (input2.Text = String.Empty) Then
            MessageBox.Show("Textbox 2 is empty. Please input 2 numbers!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            input1.Focus()
        Else


            Dim x, y, num, ctr, gcf As Integer
            x = Convert.ToInt32(input1.Text)
            y = Convert.ToInt32(input2.Text)
            ctr = 0
            gcf = 0


            If (x > y) Then
                num = y
            Else
                num = x
            End If

            For ctr = num To 1 Step -1
                If (x Mod ctr = 0 And y Mod ctr = 0) Then
                    gcf = ctr
                    ctr = 1
                End If
            Next

            output.Text = gcf.ToString()
            Button1.BackColor = Color.Green
            Button2.BackColor = Color.Green
            Button3.BackColor = Color.Green
            Button6.BackColor = Color.Green

        End If


    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        input1.Text = String.Empty
        input2.Text = String.Empty
        output.Text = "0"
        Button1.BackColor = Color.Empty
        Button2.BackColor = Color.Empty
        Button3.BackColor = Color.Empty
        Button6.BackColor = Color.Empty

    End Sub
End Class