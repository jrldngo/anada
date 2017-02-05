Public Class Form2
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles input1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles clicker.Click
        If input1.Text = String.Empty Then
            MessageBox.Show("Textbox is empty. Please input a number!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            input1.Focus()
        Else
            Dim num, factorial, ctr As Integer
            num = Convert.ToInt32(input1.Text)
            factorial = 1
            For ctr = 1 To num
                factorial = factorial * ctr
            Next

            output1.Text = factorial.ToString()
            Button1.BackColor = Color.Blue
            Button2.BackColor = Color.Blue
            Button3.BackColor = Color.Blue
            Button5.BackColor = Color.Blue
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        input1.Text = String.Empty
        output1.Text = "0"
        Button1.BackColor = Color.Empty
        Button2.BackColor = Color.Empty
        Button3.BackColor = Color.Empty
        Button5.BackColor = Color.Empty
    End Sub
End Class