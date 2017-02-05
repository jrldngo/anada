<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.input1 = New System.Windows.Forms.TextBox()
        Me.output1 = New System.Windows.Forms.Label()
        Me.clicker = New System.Windows.Forms.Button()
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
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input a Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(84, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Factorial"
        '
        'input1
        '
        Me.input1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input1.Location = New System.Drawing.Point(88, 76)
        Me.input1.Name = "input1"
        Me.input1.Size = New System.Drawing.Size(73, 28)
        Me.input1.TabIndex = 1
        Me.input1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'output1
        '
        Me.output1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.output1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.output1.Location = New System.Drawing.Point(88, 184)
        Me.output1.Name = "output1"
        Me.output1.Size = New System.Drawing.Size(73, 35)
        Me.output1.TabIndex = 3
        Me.output1.Text = "0"
        Me.output1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'clicker
        '
        Me.clicker.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clicker.Location = New System.Drawing.Point(31, 281)
        Me.clicker.Name = "clicker"
        Me.clicker.Size = New System.Drawing.Size(70, 33)
        Me.clicker.TabIndex = 4
        Me.clicker.Text = "Find"
        Me.clicker.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(218, 107)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 137)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(216, 99)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(13, 269)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 58)
        Me.Button3.TabIndex = 7
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
        Me.btnReset.Location = New System.Drawing.Point(132, 281)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(79, 33)
        Me.btnReset.TabIndex = 18
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(118, 269)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(108, 58)
        Me.Button5.TabIndex = 19
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.algo4.My.Resources.Resources.clouds
        Me.ClientSize = New System.Drawing.Size(244, 353)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.clicker)
        Me.Controls.Add(Me.output1)
        Me.Controls.Add(Me.input1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.Text = "Factorial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents input1 As TextBox
    Friend WithEvents output1 As Label
    Friend WithEvents clicker As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Button5 As Button
End Class
