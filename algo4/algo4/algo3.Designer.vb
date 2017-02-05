<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class algo3
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.clicker = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Perpetua", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(99, 66)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(73, 32)
        Me.txtInput.TabIndex = 4
        Me.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(99, 146)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(73, 40)
        Me.lblOutput.TabIndex = 7
        Me.lblOutput.Text = "0"
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'clicker
        '
        Me.clicker.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clicker.Location = New System.Drawing.Point(26, 252)
        Me.clicker.Name = "clicker"
        Me.clicker.Size = New System.Drawing.Size(85, 33)
        Me.clicker.TabIndex = 8
        Me.clicker.Text = "Submit"
        Me.clicker.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Enter Fibonacci Index"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(244, 108)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(52, 126)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 88)
        Me.Button2.TabIndex = 11
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 240)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 58)
        Me.Button3.TabIndex = 12
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
        Me.btnReset.Location = New System.Drawing.Point(146, 252)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(94, 33)
        Me.btnReset.TabIndex = 18
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(132, 240)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(123, 58)
        Me.Button5.TabIndex = 19
        Me.Button5.UseVisualStyleBackColor = True
        '
        'algo3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.algo4.My.Resources.Resources.clouds
        Me.ClientSize = New System.Drawing.Size(267, 321)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clicker)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "algo3"
        Me.Text = "Fibonacci"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents clicker As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Button5 As Button
End Class
