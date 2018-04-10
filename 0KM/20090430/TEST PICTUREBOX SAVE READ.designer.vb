<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TEST_READ_SAVE
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.result = New System.Windows.Forms.RichTextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.sqlport = New System.Windows.Forms.TextBox()
        Me.ipaddress = New System.Windows.Forms.ComboBox()
        Me.vehicleID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(28, 169)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(410, 290)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 175
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(364, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(260, 43)
        Me.Button1.TabIndex = 176
        Me.Button1.Text = "从lygport_outside读取"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(640, 99)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(319, 43)
        Me.Button2.TabIndex = 177
        Me.Button2.Text = "保存到TRUCK_QUEUE_IMAGE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(28, 465)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(410, 284)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 178
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(566, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 27)
        Me.Label1.TabIndex = 179
        Me.Label1.Text = "图像数据测试区域"
        '
        'result
        '
        Me.result.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.result.Location = New System.Drawing.Point(28, 12)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(182, 130)
        Me.result.TabIndex = 180
        Me.result.Text = ""
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(839, 169)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(413, 290)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 181
        Me.PictureBox3.TabStop = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(976, 99)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(260, 43)
        Me.Button3.TabIndex = 182
        Me.Button3.Text = "从TRUCK_QUEUE_IMAGE读取"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(216, 99)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(142, 43)
        Me.Button4.TabIndex = 183
        Me.Button4.Text = "显示Webservices时间"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'sqlport
        '
        Me.sqlport.BackColor = System.Drawing.SystemColors.Info
        Me.sqlport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sqlport.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.sqlport.Location = New System.Drawing.Point(1059, 44)
        Me.sqlport.Name = "sqlport"
        Me.sqlport.ReadOnly = True
        Me.sqlport.Size = New System.Drawing.Size(72, 23)
        Me.sqlport.TabIndex = 185
        Me.sqlport.Text = "1433"
        '
        'ipaddress
        '
        Me.ipaddress.BackColor = System.Drawing.SystemColors.Info
        Me.ipaddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ipaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ipaddress.FormattingEnabled = True
        Me.ipaddress.Items.AddRange(New Object() {"222.189.4.146", "218.92.113.9", "10.229.17.10", "218.92.115.4"})
        Me.ipaddress.Location = New System.Drawing.Point(839, 42)
        Me.ipaddress.Name = "ipaddress"
        Me.ipaddress.Size = New System.Drawing.Size(214, 25)
        Me.ipaddress.TabIndex = 184
        Me.ipaddress.Text = "222.189.4.146"
        '
        'vehicleID
        '
        '
        '
        '
        Me.vehicleID.Border.Class = "TextBoxBorder"
        Me.vehicleID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.vehicleID.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.vehicleID.Location = New System.Drawing.Point(365, 64)
        Me.vehicleID.Name = "vehicleID"
        Me.vehicleID.PreventEnterBeep = True
        Me.vehicleID.Size = New System.Drawing.Size(223, 34)
        Me.vehicleID.TabIndex = 186
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(839, 465)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(413, 284)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 187
        Me.PictureBox4.TabStop = False
        '
        'TEST_READ_SAVE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 761)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.vehicleID)
        Me.Controls.Add(Me.sqlport)
        Me.Controls.Add(Me.ipaddress)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "TEST_READ_SAVE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "图片读取和保存测试区"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents result As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents sqlport As System.Windows.Forms.TextBox
    Friend WithEvents ipaddress As System.Windows.Forms.ComboBox
    Friend WithEvents vehicleID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class
