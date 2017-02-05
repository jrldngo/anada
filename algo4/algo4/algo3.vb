Public Class algo3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles clicker.Click

        Dim num As Integer
        If txtInput.Text = String.Empty Then
            MessageBox.Show("Textbox is Empty! Please input a number!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtInput.Focus()
        Else
            If IsNumeric(txtInput.Text) Then
                num = Val(txtInput.Text)
                If num <= 0 Then
                    MessageBox.Show("Number less than zero is not allowed!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtInput.Focus()

                Else

                    Button1.BackColor = Color.Yellow
                    Button2.BackColor = Color.Yellow
                    Button3.BackColor = Color.Yellow
                    Button5.BackColor = Color.Yellow

                    Dim first As Integer = 0
                    Dim second As Integer = 1
                    Dim ctr As Integer = 2
                    Dim fibo As Integer = 0



                    If num = 1 Then
                        lblOutput.Text = first
                    ElseIf num = 2 Then
                        lblOutput.Text = second
                    Else
                        Do Until (ctr = num)
                            fibo = first + second
                            first = second
                            second = fibo
                            ctr = ctr + 1

                            lblOutput.Text = fibo


                        Loop
                    End If
                End If
            Else
                MessageBox.Show("Invalid Input!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                SendKeys.Send("{Home}+{End}")
                txtInput.Focus()
            End If

        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtInput.Text = String.Empty
        lblOutput.Text = "0"
        Button1.BackColor = Color.Empty
        Button2.BackColor = Color.Empty
        Button3.BackColor = Color.Empty
        Button5.BackColor = Color.Empty

    End Sub
End Class