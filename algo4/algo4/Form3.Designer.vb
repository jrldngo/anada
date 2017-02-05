<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.input1 = New System.Windows.Forms.TextBox()
        Me.input2 = New System.Windows.Forms.TextBox()
        Me.input4 = New System.Windows.Forms.TextBox()
        Me.input3 = New System.Windows.Forms.TextBox()
        Me.clicker = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.output1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.output2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input 4 Numbers"
        '
        'input1
        '
        Me.input1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input1.Location = New System.Drawing.Point(39, 71)
        Me.input1.Name = "input1"
        Me.input1.Size = New System.Drawing.Size(43, 30)
        Me.input1.TabIndex = 1
        Me.input1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'input2
        '
        Me.input2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input2.Location = New System.Drawing.Point(88, 71)
        Me.input2.Name = "input2"
        Me.input2.Size = New System.Drawing.Size(43, 30)
        Me.input2.TabIndex = 2
        Me.input2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'input4
        '
        Me.input4.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input4.Location = New System.Drawing.Point(186, 71)
        Me.input4.Name = "input4"
        Me.input4.Size = New System.Drawing.Size(43, 30)
        Me.input4.TabIndex = 4
        Me.input4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'input3
        '
        Me.input3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input3.Location = New System.Drawing.Point(137, 71)
        Me.input3.Name = "input3"
        Me.input3.Size = New System.Drawing.Size(43, 30)
        Me.input3.TabIndex = 3
        Me.input3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'clicker
        '
        Me.clicker.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clicker.Location = New System.Drawing.Point(24, 307)
        Me.clicker.Name = "clicker"
        Me.clicker.Size = New System.Drawing.Size(96, 33)
        Me.clicker.TabIndex = 10
        Me.clicker.Text = "Find Largest"
        Me.clicker.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Largest"
        '
        'output1
        '
        Me.output1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.output1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.output1.Location = New System.Drawing.Point(35, 197)
        Me.output1.Name = "output1"
        Me.output1.Size = New System.Drawing.Size(45, 40)
        Me.output1.TabIndex = 8
        Me.output1.Text = "0"
        Me.output1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Output1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(181, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Output2"
        '
        'output2
        '
        Me.output2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.output2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.output2.Location = New System.Drawing.Point(184, 197)
        Me.output2.Name = "output2"
        Me.output2.Size = New System.Drawing.Size(46, 40)
        Me.output2.TabIndex = 9
        Me.output2.Text = "0"
        Me.output2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(245, 116)
        Me.Button1.TabIndex = 11
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(10, 149)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(245, 113)
        Me.Button2.TabIndex = 12
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(10, 295)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 58)
        Me.Button3.TabIndex = 13
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnReset.FlatAppearance.BorderSize = 3
        Me.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnReset.Location = New System.Drawing.Point(153, 307)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(94, 33)
        Me.btnReset.TabIndex = 18
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(139, 295)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(123, 58)
        Me.Button5.TabIndex = 19
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.algo4.My.Resources.Resources.clouds
        Me.ClientSize = New System.Drawing.Size(272, 376)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.output2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.output1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.clicker)
        Me.Controls.Add(Me.input4)
        Me.Controls.Add(Me.input3)
        Me.Controls.Add(Me.input2)
        Me.Controls.Add(Me.input1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.Text = "Largest Among 4 Input"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents input1 As TextBox
    Friend WithEvents input2 As TextBox
    Friend WithEvents input4 As TextBox
    Friend WithEvents input3 As TextBox
    Friend WithEvents clicker As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents output1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents output2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Button5 As Button
End Class
