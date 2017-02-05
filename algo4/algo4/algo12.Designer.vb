<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class algo12
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.inputAdd = New System.Windows.Forms.TextBox()
        Me.btnSize = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.inputFind = New System.Windows.Forms.TextBox()
        Me.lblList = New System.Windows.Forms.Label()
        Me.rtbOutput = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'inputSize
        '
        Me.inputSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputSize.Location = New System.Drawing.Point(125, 18)
        Me.inputSize.Name = "inputSize"
        Me.inputSize.Size = New System.Drawing.Size(45, 29)
        Me.inputSize.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Input Size:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Add to List:"
        '
        'inputAdd
        '
        Me.inputAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputAdd.Location = New System.Drawing.Point(125, 58)
        Me.inputAdd.MaxLength = 1
        Me.inputAdd.Name = "inputAdd"
        Me.inputAdd.Size = New System.Drawing.Size(64, 29)
        Me.inputAdd.TabIndex = 3
        '
        'btnSize
        '
        Me.btnSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSize.Location = New System.Drawing.Point(176, 20)
        Me.btnSize.Name = "btnSize"
        Me.btnSize.Size = New System.Drawing.Size(46, 23)
        Me.btnSize.TabIndex = 5
        Me.btnSize.Text = "GO"
        Me.btnSize.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(195, 62)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(44, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "GO"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.Location = New System.Drawing.Point(461, 18)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(100, 83)
        Me.btnFind.TabIndex = 7
        Me.btnFind.Text = "Evaluate"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(277, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Find:"
        '
        'inputFind
        '
        Me.inputFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputFind.Location = New System.Drawing.Point(336, 40)
        Me.inputFind.MaxLength = 1
        Me.inputFind.Name = "inputFind"
        Me.inputFind.Size = New System.Drawing.Size(100, 29)
        Me.inputFind.TabIndex = 9
        '
        'lblList
        '
        Me.lblList.AutoSize = True
        Me.lblList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblList.Location = New System.Drawing.Point(55, 106)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(0, 24)
        Me.lblList.TabIndex = 10
        '
        'rtbOutput
        '
        Me.rtbOutput.Location = New System.Drawing.Point(155, 152)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.Size = New System.Drawing.Size(281, 96)
        Me.rtbOutput.TabIndex = 11
        Me.rtbOutput.Text = ""
        '
        'algo12
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.algo4.My.Resources.Resources._4
        Me.ClientSize = New System.Drawing.Size(636, 319)
        Me.Controls.Add(Me.rtbOutput)
        Me.Controls.Add(Me.lblList)
        Me.Controls.Add(Me.inputFind)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSize)
        Me.Controls.Add(Me.inputAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.inputSize)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "algo12"
        Me.Text = "Vowel in an Array"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inputSize As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents inputAdd As TextBox
    Friend WithEvents btnSize As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents inputFind As TextBox
    Friend WithEvents lblList As Label
    Friend WithEvents rtbOutput As RichTextBox
End Class
