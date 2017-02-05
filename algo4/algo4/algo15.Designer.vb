<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class algo15
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.inputSize = New System.Windows.Forms.TextBox()
        Me.inputList = New System.Windows.Forms.TextBox()
        Me.btnSize = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.output = New System.Windows.Forms.Label()
        Me.btnEval = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input Size:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Add to List:"
        '
        'inputSize
        '
        Me.inputSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputSize.Location = New System.Drawing.Point(148, 24)
        Me.inputSize.Name = "inputSize"
        Me.inputSize.Size = New System.Drawing.Size(100, 29)
        Me.inputSize.TabIndex = 2
        '
        'inputList
        '
        Me.inputList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputList.Location = New System.Drawing.Point(148, 56)
        Me.inputList.Name = "inputList"
        Me.inputList.Size = New System.Drawing.Size(100, 29)
        Me.inputList.TabIndex = 3
        '
        'btnSize
        '
        Me.btnSize.Location = New System.Drawing.Point(254, 29)
        Me.btnSize.Name = "btnSize"
        Me.btnSize.Size = New System.Drawing.Size(75, 23)
        Me.btnSize.TabIndex = 4
        Me.btnSize.Text = "Enter"
        Me.btnSize.UseVisualStyleBackColor = True
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(254, 59)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(75, 23)
        Me.btnList.TabIndex = 5
        Me.btnList.Text = "Enter"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'output
        '
        Me.output.AutoSize = True
        Me.output.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.output.Location = New System.Drawing.Point(185, 238)
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(0, 24)
        Me.output.TabIndex = 6
        '
        'btnEval
        '
        Me.btnEval.Location = New System.Drawing.Point(267, 268)
        Me.btnEval.Name = "btnEval"
        Me.btnEval.Size = New System.Drawing.Size(75, 23)
        Me.btnEval.TabIndex = 7
        Me.btnEval.Text = "Evaluate"
        Me.btnEval.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(45, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(536, 157)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = False
        '
        'algo15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 338)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEval)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.btnSize)
        Me.Controls.Add(Me.inputList)
        Me.Controls.Add(Me.inputSize)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "algo15"
        Me.Text = "algo15"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents inputSize As TextBox
    Friend WithEvents inputList As TextBox
    Friend WithEvents btnSize As Button
    Friend WithEvents btnList As Button
    Friend WithEvents output As Label
    Friend WithEvents btnEval As Button
    Friend WithEvents Button1 As Button
End Class
