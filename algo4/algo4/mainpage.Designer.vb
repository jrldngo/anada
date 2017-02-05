<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainpage
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.output = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.input2 = New System.Windows.Forms.TextBox()
        Me.input1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(25, 308)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 33)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Find GCF"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'output
        '
        Me.output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.output.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.output.Location = New System.Drawing.Point(119, 198)
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(53, 38)
        Me.output.TabIndex = 22
        Me.output.Text = "0"
        Me.output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 24)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "GCF"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'input2
        '
        Me.input2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input2.Location = New System.Drawing.Point(157, 83)
        Me.input2.Name = "input2"
        Me.input2.Size = New System.Drawing.Size(56, 30)
        Me.input2.TabIndex = 20
        Me.input2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'input1
        '
        Me.input1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input1.Location = New System.Drawing.Point(85, 83)
        Me.input1.Name = "input1"
        Me.input1.Size = New System.Drawing.Size(56, 30)
        Me.input1.TabIndex = 19
        Me.input1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(224, 24)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Enter 2 Unequal Integers"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(275, 104)
        Me.Button1.TabIndex = 24
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(67, 151)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 98)
        Me.Button2.TabIndex = 25
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(10, 296)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 58)
        Me.Button3.TabIndex = 26
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
        Me.btnReset.Location = New System.Drawing.Point(166, 308)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(94, 33)
        Me.btnReset.TabIndex = 27
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(152, 296)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(123, 58)
        Me.Button6.TabIndex = 28
        Me.Button6.UseVisualStyleBackColor = True
        '
        'mainpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.algo4.My.Resources.Resources.clouds
        Me.ClientSize = New System.Drawing.Size(299, 372)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.input2)
        Me.Controls.Add(Me.input1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mainpage"
        Me.Text = "Greatest Common Factor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As Button
    Friend WithEvents output As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents input2 As TextBox
    Friend WithEvents input1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Button6 As Button
End Class
