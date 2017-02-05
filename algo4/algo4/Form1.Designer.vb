<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.clicker = New System.Windows.Forms.Button()
        Me.output1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbx1 = New System.Windows.Forms.ComboBox()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.btnColor2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'clicker
        '
        Me.clicker.BackColor = System.Drawing.Color.White
        Me.clicker.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clicker.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clicker.Location = New System.Drawing.Point(68, 155)
        Me.clicker.Name = "clicker"
        Me.clicker.Size = New System.Drawing.Size(138, 55)
        Me.clicker.TabIndex = 9
        Me.clicker.Text = "Launch!"
        Me.clicker.UseVisualStyleBackColor = False
        '
        'output1
        '
        Me.output1.Enabled = False
        Me.output1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.output1.ForeColor = System.Drawing.Color.Black
        Me.output1.Location = New System.Drawing.Point(285, 65)
        Me.output1.Name = "output1"
        Me.output1.Size = New System.Drawing.Size(245, 145)
        Me.output1.TabIndex = 8
        Me.output1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Select Algorithm"
        '
        'cbx1
        '
        Me.cbx1.BackColor = System.Drawing.Color.Gainsboro
        Me.cbx1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbx1.DropDownHeight = 50
        Me.cbx1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbx1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx1.ForeColor = System.Drawing.Color.Black
        Me.cbx1.FormattingEnabled = True
        Me.cbx1.IntegralHeight = False
        Me.cbx1.Items.AddRange(New Object() {"Largest Among 3 Input", "Sum of the First 10 Even Numbers", "Fibonacci", "GCF", "Factorial", "Largest Among 4 Input", "Prime or Composite", "Largest Among Array", "Distinct or Not Distinct", "Swap 2 Variables", "Linear Search", "Vowel in an Array", "Vowel and Consonants", "Bubble Sort", "Insertion Sort"})
        Me.cbx1.Location = New System.Drawing.Point(16, 65)
        Me.cbx1.Name = "cbx1"
        Me.cbx1.Size = New System.Drawing.Size(232, 26)
        Me.cbx1.TabIndex = 5
        Me.cbx1.Text = "List of Algorithms"
        '
        'btnColor
        '
        Me.btnColor.BackColor = System.Drawing.Color.Transparent
        Me.btnColor.Location = New System.Drawing.Point(266, 25)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(288, 206)
        Me.btnColor.TabIndex = 10
        Me.btnColor.UseVisualStyleBackColor = False
        '
        'btnColor2
        '
        Me.btnColor2.BackColor = System.Drawing.Color.Transparent
        Me.btnColor2.Location = New System.Drawing.Point(46, 136)
        Me.btnColor2.Name = "btnColor2"
        Me.btnColor2.Size = New System.Drawing.Size(180, 95)
        Me.btnColor2.TabIndex = 11
        Me.btnColor2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(281, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Description"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = Global.algo4.My.Resources.Resources._3
        Me.ClientSize = New System.Drawing.Size(568, 267)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.clicker)
        Me.Controls.Add(Me.output1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbx1)
        Me.Controls.Add(Me.btnColor2)
        Me.Controls.Add(Me.btnColor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Algorithms"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents clicker As Button
    Friend WithEvents output1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbx1 As ComboBox
    Friend WithEvents btnColor As Button
    Friend WithEvents btnColor2 As Button
    Friend WithEvents Label2 As Label
End Class
