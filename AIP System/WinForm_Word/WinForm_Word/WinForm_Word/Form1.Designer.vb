	Partial Class Form1
		Private components As System.ComponentModel.IContainer = Nothing
		Protected Overloads Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (Not components Is Nothing) Then
            components.Dispose()
        End If
			MyBase.Dispose(disposing)
		End Sub
		Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.winWordControl1 = New WinForm_Word.WinWordControl()
        Me.OPD = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(944, 691)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "打开Word"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1048, 691)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 29)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "保存Word"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1156, 691)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 29)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "关闭Word"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'winWordControl1
        '
        Me.winWordControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.winWordControl1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.winWordControl1.Location = New System.Drawing.Point(3, 1)
        Me.winWordControl1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.winWordControl1.Name = "winWordControl1"
        Me.winWordControl1.Size = New System.Drawing.Size(1511, 671)
        Me.winWordControl1.TabIndex = 0
        '
        'OPD
        '
        Me.OPD.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1529, 752)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.winWordControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Private winWordControl1 As WinWordControl
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents OPD As System.Windows.Forms.OpenFileDialog
End Class
