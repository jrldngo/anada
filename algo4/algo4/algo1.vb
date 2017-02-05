Public Class algo1
    Private Sub algo1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles clicker.Click

        clicker.BackColor = Color.Silver

        If txtinput1.Text = String.Empty Then
            MessageBox.Show("Textbox 1 is empty. Please input 3 numbers!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtinput1.Focus()

        ElseIf txtinput2.Text = String.Empty Then
            MessageBox.Show("Textbox 2 is empty. Please input 3 numbers!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtinput1.Focus()

        ElseIf txtinput3.Text = String.Empty Then
            MessageBox.Show("Textbox 3 is empty. Please input 3 numbers!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtinput1.Focus()
        Else

            Dim x, y, z, high, mid, low As Double
            Dim xs, ys, zs As String
            x = Convert.ToDouble(txtinput1.Text)
            y = Convert.ToDouble(txtinput2.Text)
            z = Convert.ToDouble(txtinput3.Text)



            If x > y And x > z Then
                high = x
                If y > z Then
                    mid = y
                    low = z

                Else
                    mid = x
                    low = y
                End If

            ElseIf y > x And y > z Then
                high = y
                If x > z Then
                    mid = x
                    low = z

                Else
                    mid = z
                    low = x
                End If
            Else
                high = z
                If y > x Then
                    mid = y
                    low = x
                Else
                    mid = x
                    low = y
                End If
            End If

            xs = high.ToString()
            ys = mid.ToString()
            zs = low.ToString()

            output1.Text = xs
            output2.Text = ys
            output3.Text = zs
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            Button5.BackColor = Color.Red
        End If
    End Sub

    Private Sub hover(sender As Object, e As EventArgs) Handles clicker.MouseHover

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtinput1.Text = String.Empty
        txtinput2.Text = String.Empty
        txtinput3.Text = String.Empty
        output1.Text = "0"
        output2.Text = "0"
        output3.Text = "0"
        Button1.BackColor = Color.Empty
        Button2.BackColor = Color.Empty
        Button3.BackColor = Color.Empty
        Button5.BackColor = Color.Empty

    End Sub
End Class