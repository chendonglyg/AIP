﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CVR100
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

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SatusMessage = New System.Windows.Forms.Label()
        Me.lblNation = New System.Windows.Forms.Label()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StausMessage2 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.lblValidDate = New System.Windows.Forms.Label()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblIdCard = New System.Windows.Forms.Label()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SatusMessage
        '
        Me.SatusMessage.AutoSize = True
        Me.SatusMessage.Location = New System.Drawing.Point(16, 569)
        Me.SatusMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SatusMessage.Name = "SatusMessage"
        Me.SatusMessage.Size = New System.Drawing.Size(103, 15)
        Me.SatusMessage.TabIndex = 26
        Me.SatusMessage.Text = "StausMessage"
        '
        'lblNation
        '
        Me.lblNation.AutoSize = True
        Me.lblNation.Location = New System.Drawing.Point(389, 91)
        Me.lblNation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNation.Name = "lblNation"
        Me.lblNation.Size = New System.Drawing.Size(0, 15)
        Me.lblNation.TabIndex = 21
        '
        'timer1
        '
        Me.timer1.Enabled = True
        Me.timer1.Interval = 1000
        '
        'StausMessage2
        '
        Me.StausMessage2.AutoSize = True
        Me.StausMessage2.Location = New System.Drawing.Point(212, 569)
        Me.StausMessage2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StausMessage2.Name = "StausMessage2"
        Me.StausMessage2.Size = New System.Drawing.Size(111, 15)
        Me.StausMessage2.TabIndex = 25
        Me.StausMessage2.Text = "StausMessage2"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(392, 508)
        Me.button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(479, 72)
        Me.button2.TabIndex = 24
        Me.button2.Text = "退出"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(392, 426)
        Me.button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(259, 74)
        Me.button1.TabIndex = 23
        Me.button1.Text = "读卡"
        Me.button1.UseVisualStyleBackColor = True
        '
        'lblValidDate
        '
        Me.lblValidDate.AutoSize = True
        Me.lblValidDate.Location = New System.Drawing.Point(193, 315)
        Me.lblValidDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValidDate.Name = "lblValidDate"
        Me.lblValidDate.Size = New System.Drawing.Size(0, 15)
        Me.lblValidDate.TabIndex = 20
        '
        'lblDept
        '
        Me.lblDept.AutoSize = True
        Me.lblDept.Location = New System.Drawing.Point(193, 271)
        Me.lblDept.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(0, 15)
        Me.lblDept.TabIndex = 19
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(193, 221)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(0, 15)
        Me.lblAddress.TabIndex = 18
        '
        'lblIdCard
        '
        Me.lblIdCard.AutoSize = True
        Me.lblIdCard.Location = New System.Drawing.Point(193, 176)
        Me.lblIdCard.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIdCard.Name = "lblIdCard"
        Me.lblIdCard.Size = New System.Drawing.Size(0, 15)
        Me.lblIdCard.TabIndex = 17
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Location = New System.Drawing.Point(193, 131)
        Me.lblBirthday.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(0, 15)
        Me.lblBirthday.TabIndex = 22
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Location = New System.Drawing.Point(193, 91)
        Me.lblSex.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(0, 15)
        Me.lblSex.TabIndex = 16
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(193, 56)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 15)
        Me.lblName.TabIndex = 15
        '
        'pictureBox1
        '
        Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBox1.Location = New System.Drawing.Point(613, 28)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(171, 208)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 14
        Me.pictureBox1.TabStop = False
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(52, 352)
        Me.label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(62, 15)
        Me.label11.TabIndex = 12
        Me.label11.Text = "SAMID："
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(52, 315)
        Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(82, 15)
        Me.label8.TabIndex = 11
        Me.label8.Text = "有效期限："
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(52, 271)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(82, 15)
        Me.label7.TabIndex = 10
        Me.label7.Text = "签发机关："
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(52, 221)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(52, 15)
        Me.label6.TabIndex = 9
        Me.label6.Text = "地址："
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(52, 131)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(82, 15)
        Me.label4.TabIndex = 8
        Me.label4.Text = "出生日期："
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(52, 91)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(52, 15)
        Me.label3.TabIndex = 7
        Me.label3.Text = "性别："
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(52, 176)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(82, 15)
        Me.label5.TabIndex = 6
        Me.label5.Text = "身份证号："
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(327, 91)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(52, 15)
        Me.label2.TabIndex = 13
        Me.label2.Text = "民族："
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(52, 56)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(52, 15)
        Me.label1.TabIndex = 5
        Me.label1.Text = "姓名："
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(659, 426)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(212, 74)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "开始扫描"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CVR100
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(893, 595)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.SatusMessage)
        Me.Controls.Add(Me.lblNation)
        Me.Controls.Add(Me.StausMessage2)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.lblValidDate)
        Me.Controls.Add(Me.lblDept)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblIdCard)
        Me.Controls.Add(Me.lblBirthday)
        Me.Controls.Add(Me.lblSex)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "CVR100"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Moveform"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents SatusMessage As System.Windows.Forms.Label
    Private WithEvents lblNation As System.Windows.Forms.Label
    Private WithEvents timer1 As System.Windows.Forms.Timer
    Private WithEvents StausMessage2 As System.Windows.Forms.Label
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents lblValidDate As System.Windows.Forms.Label
    Private WithEvents lblDept As System.Windows.Forms.Label
    Private WithEvents lblAddress As System.Windows.Forms.Label
    Private WithEvents lblIdCard As System.Windows.Forms.Label
    Private WithEvents lblBirthday As System.Windows.Forms.Label
    Private WithEvents lblSex As System.Windows.Forms.Label
    Private WithEvents lblName As System.Windows.Forms.Label
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents Button3 As System.Windows.Forms.Button
End Class
