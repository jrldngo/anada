Public Class algo12
    Dim arr() As String
    Dim counter As Integer = 0
    Dim sze As Integer
    Dim sizedet As Boolean = False
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSize.Click
        If inputSize.Text = "" And Convert.ToInt32(inputSize.Text) < 0 Then
            MessageBox.Show("Please enter Input!")
        Else
            counter = 0
            lblList.Text = ""
            inputFind.Text = ""
            sze = Convert.ToInt32(inputSize.Text)
            ReDim arr(sze - 1)
            sizedet = True
        End If

    End Sub

    Public Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If inputAdd.Text = "" Then
            MessageBox.Show("Please enter Input!")
        ElseIf sizedet = False Then
            MessageBox.Show("Please Input Size!")
        Else
            If counter <= sze - 1 Then
                arr(counter) = inputAdd.Text
                lblList.Text = lblList.Text + " " + (inputAdd.Text)
                counter += 1
                inputAdd.Text = ""
                inputAdd.Focus()
            End If
        End If

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim key As String
        Dim det As Boolean = False
        If inputFind.Text = "" Then
            MessageBox.Show("Please enter Input!")
        ElseIf sizedet = False Then
            MessageBox.Show("Please enter Size!")
        Else
            key = inputFind.Text
            For index = 0 To sze - 1
                If key = arr(index) Then
                    rtbOutput.Text = ""
                    rtbOutput.Text = "Character is number " + (index + 1).ToString + " on the list!"
                    det = True
                    index = sze - 1
                End If
            Next

            If det = False Then
                MessageBox.Show("Character was not found :(")

            End If
        End If
    End Sub

    Private Sub press(sender As Object, e As KeyPressEventArgs) Handles inputSize.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If

    End Sub
End Class