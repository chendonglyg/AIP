	Partial Class WinWordControl
		Private components As System.ComponentModel.IContainer = Nothing
		Protected Overloads Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (Not components Is Nothing) Then
            components.Dispose()
        End If
			MyBase.Dispose(disposing)
		End Sub
		Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'WinWordControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Name = "WinWordControl"
        Me.Size = New System.Drawing.Size(440, 336)
        Me.ResumeLayout(False)

    End Sub
	End Class
