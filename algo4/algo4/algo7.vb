Public Class algo7
    Private Sub clicker_Click(sender As Object, e As EventArgs) Handles clicker.Click
        If input1.Text = String.Empty Then
            MessageBox.Show("Textbox is empty. Please input a numbers!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            input1.Focus()
        ElseIf Convert.ToInt32(Input1.Text) < 0 Then
            MessageBox.Show("Input cannot be negative!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            input1.Focus()

        Else

            clicker.BackColor = Color.Silver

            Dim num, ctr, counter As Integer
            Dim composite As String = "Composite!"
            Dim prime As String = "Prime!"
            counter = 0
            num = Convert.ToInt32(input1.Text)

            For ctr = num - 1 To 2 Step -1
                If (num Mod ctr = 0) Then
                    counter = counter + 1
                    ctr = 2
                End If
            Next

            If (counter > 0) Then
                output1.Text = composite

                Button1.BackColor = Color.HotPink
                Button2.BackColor = Color.HotPink
                Button3.BackColor = Color.HotPink

            Else
                output1.Text = prime
                Button1.BackColor = Color.HotPink
                Button2.BackColor = Color.HotPink
                Button3.BackColor = Color.HotPink
                Button5.BackColor = Color.HotPink

            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        input1.Text = String.Empty
        output1.Text = String.Empty
        Button1.BackColor = Color.Empty
        Button2.BackColor = Color.Empty
        Button3.BackColor = Color.Empty
        Button5.BackColor = Color.Empty

    End Sub
End Class