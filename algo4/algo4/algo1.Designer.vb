<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class algo1
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
        Me.txtinput1 = New System.Windows.Forms.TextBox()
        Me.txtinput2 = New System.Windows.Forms.TextBox()
        Me.txtinput3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.output3 = New System.Windows.Forms.Label()
        Me.output2 = New System.Windows.Forms.Label()
        Me.output1 = New System.Windows.Forms.Label()
        Me.clicker = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter 3 Numbers"
        '
        'txtinput1
        '
        Me.txtinput1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinput1.Location = New System.Drawing.Point(23, 65)
        Me.txtinput1.Name = "txtinput1"
        Me.txtinput1.Size = New System.Drawing.Size(73, 30)
        Me.txtinput1.TabIndex = 3
        Me.txtinput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtinput2
        '
        Me.txtinput2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinput2.Location = New System.Drawing.Point(102, 65)
        Me.txtinput2.Name = "txtinput2"
        Me.txtinput2.Size = New System.Drawing.Size(73, 30)
        Me.txtinput2.TabIndex = 4
        Me.txtinput2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtinput3
        '
        Me.txtinput3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinput3.Location = New System.Drawing.Point(181, 65)
        Me.txtinput3.Name = "txtinput3"
        Me.txtinput3.Size = New System.Drawing.Size(73, 30)
        Me.txtinput3.TabIndex = 5
        Me.txtinput3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Largest"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(107, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Middle"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(178, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Smallest"
        '
        'output3
        '
        Me.output3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.output3.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.output3.Location = New System.Drawing.Point(182, 169)
        Me.output3.Name = "output3"
        Me.output3.Size = New System.Drawing.Size(52, 47)
        Me.output3.TabIndex = 11
        Me.output3.Text = "0"
        Me.output3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'output2
        '
        Me.output2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.output2.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.output2.Location = New System.Drawing.Point(111, 169)
        Me.output2.Name = "output2"
        Me.output2.Size = New System.Drawing.Size(53, 47)
        Me.output2.TabIndex = 10
        Me.output2.Text = "0"
        Me.output2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'output1
        '
        Me.output1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.output1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.output1.Location = New System.Drawing.Point(45, 169)
        Me.output1.Name = "output1"
        Me.output1.Size = New System.Drawing.Size(52, 47)
        Me.output1.TabIndex = 9
        Me.output1.Text = "0"
        Me.output1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'clicker
        '
        Me.clicker.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.clicker.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.clicker.FlatAppearance.BorderSize = 3
        Me.clicker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.clicker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clicker.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clicker.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clicker.ForeColor = System.Drawing.SystemColors.ControlText
        Me.clicker.Location = New System.Drawing.Point(30, 278)
        Me.clicker.Name = "clicker"
        Me.clicker.Size = New System.Drawing.Size(94, 33)
        Me.clicker.TabIndex = 12
        Me.clicker.Text = "Determine!"
        Me.clicker.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(253, 102)
        Me.Button1.TabIndex = 13
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(254, 130)
        Me.Button2.TabIndex = 14
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(16, 266)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 58)
        Me.Button3.TabIndex = 15
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.BorderSize = 3
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button4.Location = New System.Drawing.Point(160, 278)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 33)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Reset"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(146, 266)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(123, 58)
        Me.Button5.TabIndex = 17
        Me.Button5.UseVisualStyleBackColor = True
        '
        'algo1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.algo4.My.Resources.Resources.clouds
        Me.ClientSize = New System.Drawing.Size(282, 353)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.clicker)
        Me.Controls.Add(Me.output3)
        Me.Controls.Add(Me.output2)
        Me.Controls.Add(Me.output1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtinput3)
        Me.Controls.Add(Me.txtinput2)
        Me.Controls.Add(Me.txtinput1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "algo1"
        Me.Text = "Largest Among 3 Inputs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtinput1 As TextBox
    Friend WithEvents txtinput2 As TextBox
    Friend WithEvents txtinput3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents output3 As Label
    Friend WithEvents output2 As Label
    Friend WithEvents output1 As Label
    Friend WithEvents clicker As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
