<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class algo14
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
        Me.inputSize = New System.Windows.Forms.TextBox()
        Me.inputList = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSize = New System.Windows.Forms.Button()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.rtbList = New System.Windows.Forms.RichTextBox()
        Me.btnList = New System.Windows.Forms.Button()
        Me.lblList = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'inputSize
        '
        Me.inputSize.Location = New System.Drawing.Point(109, 12)
        Me.inputSize.MaxLength = 2
        Me.inputSize.Name = "inputSize"
        Me.inputSize.Size = New System.Drawing.Size(67, 20)
        Me.inputSize.TabIndex = 0
        '
        'inputList
        '
        Me.inputList.Location = New System.Drawing.Point(109, 48)
        Me.inputList.MaxLength = 3
        Me.inputList.Name = "inputList"
        Me.inputList.Size = New System.Drawing.Size(67, 20)
        Me.inputList.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Input Size:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Add to List:"
        '
        'btnSize
        '
        Me.btnSize.Location = New System.Drawing.Point(182, 10)
        Me.btnSize.Name = "btnSize"
        Me.btnSize.Size = New System.Drawing.Size(75, 23)
        Me.btnSize.TabIndex = 4
        Me.btnSize.Text = "GO!"
        Me.btnSize.UseVisualStyleBackColor = True
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(226, 283)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(75, 23)
        Me.btnSort.TabIndex = 7
        Me.btnSort.Text = "SORT !"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'rtbList
        '
        Me.rtbList.Location = New System.Drawing.Point(263, 9)
        Me.rtbList.Name = "rtbList"
        Me.rtbList.Size = New System.Drawing.Size(372, 183)
        Me.rtbList.TabIndex = 8
        Me.rtbList.Text = ""
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(182, 47)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(75, 23)
        Me.btnList.TabIndex = 9
        Me.btnList.Text = "GO!"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'lblList
        '
        Me.lblList.AutoSize = True
        Me.lblList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblList.Location = New System.Drawing.Point(30, 89)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(0, 24)
        Me.lblList.TabIndex = 10
        '
        'algo14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 447)
        Me.Controls.Add(Me.lblList)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.rtbList)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.btnSize)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.inputList)
        Me.Controls.Add(Me.inputSize)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "algo14"
        Me.Text = "Bubble Sort"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inputSize As TextBox
    Friend WithEvents inputList As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSize As Button
    Friend WithEvents btnSort As Button
    Friend WithEvents rtbList As RichTextBox
    Friend WithEvents btnList As Button
    Friend WithEvents lblList As Label
End Class
