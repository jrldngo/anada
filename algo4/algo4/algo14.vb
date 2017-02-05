Public Class algo14
    Private Sub algo14_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim list() As Integer
    Dim sze As Integer
    Dim counter As Integer = 0
    Dim temp As Integer
    Dim strl1 As String
    Dim strl2 As String
    Dim finallist As String = ""
    Dim loc1 As Integer
    Dim loc2 As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSize.Click
        sze = Convert.ToInt32(inputSize.Text)
        ReDim list(sze - 1)
    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        If counter <= sze - 1 Then
            list(counter) = Convert.ToInt32(inputList.Text)

            lblList.Text = lblList.Text + " " + list(counter).ToString

            counter += 1
        End If

    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        For index = sze - 2 To 0 Step -1
            For index2 = 0 To index
                finallist = ""
                If list(index2) > list(index2 + 1) Then
                    temp = list(index2)
                    list(index2) = list(index2 + 1)
                    list(index2 + 1) = temp
                    strl1 = list(index2).ToString.Length
                    strl2 = list(index2 + 1).ToString.Length
                    For index3 = 0 To sze - 1
                        finallist = finallist + " " + list(index3).ToString
                    Next
                    rtbList.Text = rtbList.Text + finallist + vbCrLf

                    loc1 = rtbList.Find(list(index2).ToString)
                    loc2 = rtbList.Find(list(index2 + 1).ToString)
                    rtbList.Select(loc1, strl1)
                    rtbList.SelectionColor = Color.Red
                    rtbList.Select(loc2, strl2)
                    rtbList.SelectionColor = Color.Red

                Else
                    For index3 = 0 To sze - 1
                        finallist = finallist + " " + list(index3).ToString
                    Next
                    rtbList.Text = rtbList.Text + finallist + vbNewLine

                End If


            Next
        Next

    End Sub
End Class