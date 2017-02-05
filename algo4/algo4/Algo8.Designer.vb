<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Algo8
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
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.lblLargest = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(116, 254)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(78, 35)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.Location = New System.Drawing.Point(15, 58)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(50, 25)
        Me.txt1.TabIndex = 1
        '
        'txt2
        '
        Me.txt2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.Location = New System.Drawing.Point(72, 58)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(50, 25)
        Me.txt2.TabIndex = 2
        '
        'txt3
        '
        Me.txt3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3.Location = New System.Drawing.Point(128, 58)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(50, 25)
        Me.txt3.TabIndex = 3
        '
        'txt4
        '
        Me.txt4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4.Location = New System.Drawing.Point(184, 58)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(50, 25)
        Me.txt4.TabIndex = 4
        '
        'txt5
        '
        Me.txt5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5.Location = New System.Drawing.Point(240, 58)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(50, 25)
        Me.txt5.TabIndex = 5
        '
        'lblLargest
        '
        Me.lblLargest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLargest.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLargest.Location = New System.Drawing.Point(72, 145)
        Me.lblLargest.Name = "lblLargest"
        Me.lblLargest.Size = New System.Drawing.Size(162, 63)
        Me.lblLargest.TabIndex = 6
        '
        'Algo8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 328)
        Me.Controls.Add(Me.lblLargest)
        Me.Controls.Add(Me.txt5)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Algo8"
        Me.Text = "Largest Input (Array)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOk As Button
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt3 As TextBox
    Friend WithEvents txt4 As TextBox
    Friend WithEvents txt5 As TextBox
    Friend WithEvents lblLargest As Label
End Class
