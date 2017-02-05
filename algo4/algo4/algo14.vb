Public Class algo14
    Private Sub algo14_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim list() As Integer
    Dim sze As Integer
    Dim counter As Integer = 0
    Dim temp As Integer
    Dim szedet As Boolean = False
    Dim finallist As String = ""



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSize.Click
        If inputSize.Text = "" Then
            MessageBox.Show("Please have an input!")
        Else
            sze = Convert.ToInt32(inputSize.Text)
            ReDim list(sze - 1)
            szedet = True
        End If
    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        If szedet = False Then
            MessageBox.Show("Please enter Size!")
        ElseIf inputList.Text = "" Then
            MessageBox.Show("Please enter an Input!")
        Else

            If counter <= sze - 1 Then
                list(counter) = Convert.ToInt32(inputList.Text)

                lblList.Text = lblList.Text + " " + list(counter).ToString

                counter += 1
            End If
        End If


    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        If szedet = False Then
            MessageBox.Show("Please enter Size!")

        Else
            For index = sze - 2 To 0 Step -1
                For index2 = 0 To index
                    finallist = ""
                    If list(index2) > list(index2 + 1) Then
                        temp = list(index2)
                        list(index2) = list(index2 + 1)
                        list(index2 + 1) = temp

                        For index3 = 0 To sze - 1
                            finallist = finallist + " " + list(index3).ToString
                        Next
                        rtbList.Text = rtbList.Text + finallist + vbCrLf


                    Else
                        For index3 = 0 To sze - 1
                            finallist = finallist + " " + list(index3).ToString
                        Next
                        rtbList.Text = rtbList.Text + finallist + vbCrLf

                    End If


                Next
            Next
        End If
    End Sub

    Private Sub press1(sender As Object, e As KeyPressEventArgs) Handles inputSize.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If

    End Sub

    Private Sub press2(sender As Object, e As KeyPressEventArgs) Handles inputList.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If

    End Sub
End Class