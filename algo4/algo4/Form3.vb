Public Class Form3
    Private Sub clicker_Click(sender As Object, e As EventArgs) Handles clicker.Click
        If input1.Text = String.Empty Then
            MessageBox.Show("Textbox 1 is empty. Please input 4 numbers!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            input1.Focus()
        ElseIf input2.Text = String.Empty Then
            MessageBox.Show("Textbox 2 is empty. Please input 4 numbers!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            input1.Focus()
        ElseIf input3.Text = String.Empty Then
            MessageBox.Show("Textbox 3 is empty. Please input 4 numbers!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            input1.Focus()
        ElseIf input4.Text = String.Empty Then
            MessageBox.Show("Textbox 4 is empty. Please input 4 numbers!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            input1.Focus()
        Else
            Dim a, b, c, d, largest As Integer
        a = Convert.ToInt32(input1.Text)
        b = Convert.ToInt32(input2.Text)
        c = Convert.ToInt32(input3.Text)
        d = Convert.ToInt32(input4.Text)

        largest = a

        If (b > largest) Then
            largest = b
        End If
        If (c > largest) Then
            largest = c
        End If
        If (d > largest) Then
            largest = d
        End If

            output1.Text = largest.ToString()
            Button1.BackColor = Color.Purple
            Button2.BackColor = Color.Purple
            Button3.BackColor = Color.Purple
            Button5.BackColor = Color.Purple


            If (b > a) Then
            a = b
        End If
        If (c > a) Then
            a = c
        End If
        If (d > a) Then
            a = d
        End If
            output2.Text = a.ToString()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        input1.Text = String.Empty
        input2.Text = String.Empty
        input3.Text = String.Empty
        input4.Text = String.Empty
        output1.Text = "0"
        output2.Text = "0"
        Button1.BackColor = Color.Empty
        Button2.BackColor = Color.Empty
        Button3.BackColor = Color.Empty
        Button5.BackColor = Color.Empty

    End Sub
End Class