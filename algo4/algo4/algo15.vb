Public Class algo15
    Dim list() As Integer
    Dim sze As Integer
    Dim counter As Integer = 0
    Dim v As Integer
    Dim j As Integer
    Dim outstring As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSize.Click
        sze = Convert.ToInt32(inputSize.Text)
        ReDim list(sze - 1)
    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        If counter <= sze - 1 Then
            list(counter) = Convert.ToInt32(inputList.Text)
            counter += 1
        End If
    End Sub

    Private Sub btnEval_Click(sender As Object, e As EventArgs) Handles btnEval.Click
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
        Next

        For z = 0 To sze - 1
            output.Text = output.Text + " " + list(z).ToString
        Next
    End Sub
End Class