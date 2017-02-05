Public Class Form1


    Dim det As Integer = 0


    Private Sub hover(sender As Object, e As EventArgs) Handles clicker.MouseHover
        If (det = 0) Then
            clicker.BackColor = Color.White
        End If
    End Sub



    Private Sub change(sender As Object, e As EventArgs) Handles cbx1.SelectedValueChanged
        If (cbx1.SelectedItem = "Largest Among 3 Input") Then
            output1.Text = Chr(9) + "Accepts 3 unequal integers, and arranges them from highest to lowest."
            btnColor.BackColor = Color.Red
            btnColor2.BackColor = Color.Red
        End If
        If (cbx1.SelectedItem = "Sum of the First 10 Even Numbers") Then
            output1.Text = Chr(9) + "Outputs the sum of the 1st 10 even numbers starting from 2. Using while, repeat..until, and for loop."
            btnColor.BackColor = Color.Orange
            btnColor2.BackColor = Color.Orange
        End If
        If (cbx1.SelectedItem = "Fibonacci") Then
            output1.Text = Chr(9) + "Outputs the number in the fibonacci sequence in the given index."
            btnColor.BackColor = Color.Yellow
            btnColor2.BackColor = Color.Yellow
        End If
        If (cbx1.SelectedItem = "GCF") Then
            output1.Text = Chr(9) + "Accepts 2 numbers and determine their GCF."
            btnColor.BackColor = Color.Green
            btnColor2.BackColor = Color.Green
        End If
        If (cbx1.SelectedItem = "Factorial") Then
            output1.Text = Chr(9) + "Accepts a number and gets its factorial."
            btnColor.BackColor = Color.Blue
            btnColor2.BackColor = Color.Blue
        End If
        If (cbx1.SelectedItem = "Largest Among 4 Input") Then
            output1.Text = Chr(9) + "Accepts 4 numbers and determine the largest among them."
            btnColor.BackColor = Color.Purple
            btnColor2.BackColor = Color.Purple
        End If
        If (cbx1.SelectedItem = "Prime or Composite") Then
            output1.Text = Chr(9) + "Accepts an integer and determines if it is a Prime or a Composite number."
            btnColor.BackColor = Color.HotPink
            btnColor2.BackColor = Color.HotPink
        End If
    End Sub

    Private Sub leaves(sender As Object, e As EventArgs) Handles clicker.MouseLeave
        If (det = 0) Then
            clicker.BackColor = Color.Silver
        End If
    End Sub

    Private Sub clicker_Click(sender As Object, e As EventArgs) Handles clicker.Click
        clicker.BackColor = Color.Silver
        det = 1
        Select Case cbx1.SelectedItem
            Case "Largest Among 3 Input"
                My.Forms.algo1.Show()
            Case "Sum of the First 10 Even Numbers"
                My.Forms.algo2.Show()
            Case "Fibonacci"
                My.Forms.algo3.Show()
            Case "GCF"
                My.Forms.mainpage.Show()
            Case "Factorial"
                My.Forms.Form2.Show()
            Case "Largest Among 4 Input"
                My.Forms.Form3.Show()
            Case "Prime or Composite"
                My.Forms.algo7.Show()
            Case "Largest Among Input (Array)"
                My.Forms.Algo8.Show()
            Case "Distinct Or Not Distinct"
                My.Forms.algo9.Show()
            Case "Swap 2 Variables"
                My.Forms.algo10.Show()
            Case "Linear Search"
                My.Forms.algo11.Show()
            Case "Vowel in an Array"
                My.Forms.algo12.Show()
            Case "Vowel And Consonants"
                My.Forms.algo13.Show()
            Case "Bubble Sort"
                My.Forms.algo14.Show()
            Case "Insertion Sort"
                My.Forms.algo15.Show()

        End Select
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnColor2_Click(sender As Object, e As EventArgs) Handles btnColor2.Click

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Exit Program?", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.Cancel Then
            e.Cancel = True
        Else
            e.Cancel = False
            MessageBox.Show("Project in Analysis and Design of Algorithms Submitted by Steffi Gaile Hernando & Jerald Ngo. Thank you!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If




    End Sub

    Private Sub cbx1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx1.SelectedIndexChanged

    End Sub
End Class
