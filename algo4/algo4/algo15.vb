Public Class algo15
    Dim list() As Integer
    Dim sze As Integer
    Dim counter As Integer = 0
    Dim v As Integer
    Dim j As Integer
    Dim outstring As String = ""
    Dim szedet As Boolean = False



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSize.Click
        If inputSize.Text = "" And Convert.ToInt32(inputSize.Text) < 0 Then
            MessageBox.Show("Please enter Input!")
        Else
            sze = Convert.ToInt32(inputSize.Text)
            ReDim list(sze - 1)
            szedet = True
        End If
    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        If inputList.Text = "" Then
            MessageBox.Show("Please enter Input!")
        ElseIf szedet = False Then
            MessageBox.Show("Please Input Size!")
        Else
            If counter <= sze - 1 Then
                list(counter) = Convert.ToInt32(inputList.Text)
                lblList.Text = lblList.Text + " " + list(counter).ToString
                counter += 1

            End If
        End If
    End Sub

    Private Sub btnEval_Click(sender As Object, e As EventArgs) Handles btnEval.Click

        If szedet = False Then
            MessageBox.Show("Please enter Size!")
        Else
            For index = 1 To sze - 1
                v = list(index)
                j = (index - 1)

                While (j >= 0)
                    If j >= 0 Then
                        If list(j) > v Then
                            list(j + 1) = list(j)
                            j = j - 1
                        End If

                    End If

                End While

                list(j + 1) = v
                outstring = ""
                For z = 0 To sze - 1
                    outstring = outstring + " " + list(z).ToString
                Next
                output.Text = output.Text + outstring + vbCrLf
            Next

        End If
    End Sub

    Private Sub press2(sender As Object, e As KeyPressEventArgs) Handles inputList.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub press1(sender As Object, e As KeyPressEventArgs) Handles inputSize.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub
End Class