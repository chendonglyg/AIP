﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AIP2
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AIP2))
        Me.yidengji = New System.Windows.Forms.DataGridView()
        Me.UnloadTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UserCompany = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UserGroup = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Username = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.FILEID = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.BUT_START = New System.Windows.Forms.ToolStripButton()
        Me.FILETYPE = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.FileExtemsion = New System.Windows.Forms.ToolStripTextBox()
        Me.filename = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripLabel()
        Me.LABEL_BILL = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.isCompany = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.isCompanyid = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.isDept = New System.Windows.Forms.ToolStripComboBox()
        Me.opd = New System.Windows.Forms.OpenFileDialog()
        Me.axHWPostil1 = New AxHWPOSTILLib.AxHWPostil()
        Me.ing = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.fileLocation = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        CType(Me.yidengji, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.axHWPostil1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'yidengji
        '
        Me.yidengji.AllowUserToResizeColumns = False
        Me.yidengji.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.yidengji.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.yidengji.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.yidengji.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.yidengji.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.yidengji.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.yidengji.DefaultCellStyle = DataGridViewCellStyle3
        Me.yidengji.Location = New System.Drawing.Point(13, 54)
        Me.yidengji.Margin = New System.Windows.Forms.Padding(4)
        Me.yidengji.Name = "yidengji"
        Me.yidengji.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.yidengji.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.yidengji.RowHeadersVisible = False
        Me.yidengji.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle5.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.yidengji.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.yidengji.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.yidengji.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.yidengji.Size = New System.Drawing.Size(1360, 280)
        Me.yidengji.TabIndex = 181
        '
        'UnloadTime
        '
        Me.UnloadTime.Name = "UnloadTime"
        Me.UnloadTime.Size = New System.Drawing.Size(78, 17)
        Me.UnloadTime.Text = "UnloadTime"
        '
        'UserCompany
        '
        Me.UserCompany.Name = "UserCompany"
        Me.UserCompany.Size = New System.Drawing.Size(90, 17)
        Me.UserCompany.Text = "UserCompany"
        '
        'UserGroup
        '
        Me.UserGroup.Name = "UserGroup"
        Me.UserGroup.Size = New System.Drawing.Size(72, 17)
        Me.UserGroup.Text = "UserGroup"
        '
        'Username
        '
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(67, 17)
        Me.Username.Text = "Username"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Username, Me.UserGroup, Me.UserCompany, Me.UnloadTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 718)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1384, 22)
        Me.StatusStrip1.TabIndex = 179
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'FILEID
        '
        Me.FILEID.Name = "FILEID"
        Me.FILEID.Size = New System.Drawing.Size(132, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripLabel2.Text = "文件ID:"
        '
        'BUT_START
        '
        Me.BUT_START.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BUT_START.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BUT_START.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BUT_START.Name = "BUT_START"
        Me.BUT_START.Size = New System.Drawing.Size(44, 22)
        Me.BUT_START.Text = "PUSH"
        '
        'FILETYPE
        '
        Me.FILETYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FILETYPE.Items.AddRange(New Object() {"证照", "政府批文", "三级文件", "内部行文", "董事会决议", "合同协议", "工程档案", "荣誉证书", "身份证"})
        Me.FILETYPE.Name = "FILETYPE"
        Me.FILETYPE.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripLabel4.Text = "文件类型？"
        '
        'FileExtemsion
        '
        Me.FileExtemsion.Enabled = False
        Me.FileExtemsion.Font = New System.Drawing.Font("微软雅黑", 6.75!)
        Me.FileExtemsion.Name = "FileExtemsion"
        Me.FileExtemsion.Size = New System.Drawing.Size(50, 25)
        '
        'filename
        '
        Me.filename.Enabled = False
        Me.filename.Font = New System.Drawing.Font("微软雅黑", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.filename.Name = "filename"
        Me.filename.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(0, 22)
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripSeparator10.Text = "文件名"
        '
        'LABEL_BILL
        '
        Me.LABEL_BILL.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.LABEL_BILL.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LABEL_BILL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LABEL_BILL.Name = "LABEL_BILL"
        Me.LABEL_BILL.Size = New System.Drawing.Size(84, 22)
        Me.LABEL_BILL.Text = "选择上传文件"
        Me.LABEL_BILL.ToolTipText = "选择上传文件"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 22)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripSeparator5, Me.ToolStripLabel1, Me.LABEL_BILL, Me.ToolStripSeparator10, Me.ToolStripButton3, Me.ToolStripSeparator3, Me.filename, Me.FileExtemsion, Me.ToolStripLabel4, Me.FILETYPE, Me.ToolStripLabel6, Me.isCompany, Me.ToolStripLabel3, Me.isCompanyid, Me.ToolStripLabel5, Me.isDept, Me.ToolStripLabel2, Me.FILEID, Me.BUT_START})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1384, 25)
        Me.ToolStrip1.TabIndex = 178
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripLabel6.Text = "所属公司"
        '
        'isCompany
        '
        Me.isCompany.Name = "isCompany"
        Me.isCompany.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripLabel3.Text = "公司代码"
        '
        'isCompanyid
        '
        Me.isCompanyid.Name = "isCompanyid"
        Me.isCompanyid.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripLabel5.Text = "所属部门"
        '
        'isDept
        '
        Me.isDept.Name = "isDept"
        Me.isDept.Size = New System.Drawing.Size(100, 25)
        '
        'opd
        '
        Me.opd.FileName = "OpenFileDialog1"
        '
        'axHWPostil1
        '
        Me.axHWPostil1.Enabled = True
        Me.axHWPostil1.Location = New System.Drawing.Point(13, 333)
        Me.axHWPostil1.Margin = New System.Windows.Forms.Padding(4)
        Me.axHWPostil1.Name = "axHWPostil1"
        Me.axHWPostil1.OcxState = CType(resources.GetObject("axHWPostil1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.axHWPostil1.Size = New System.Drawing.Size(1358, 386)
        Me.axHWPostil1.TabIndex = 177
        '
        'ing
        '
        Me.ing.AutoSize = True
        Me.ing.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ing.Font = New System.Drawing.Font("微软雅黑", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ing.Location = New System.Drawing.Point(556, 430)
        Me.ing.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ing.Name = "ing"
        Me.ing.Size = New System.Drawing.Size(234, 41)
        Me.ing.TabIndex = 180
        Me.ing.Text = "正在转换数据..."
        Me.ing.Visible = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel7, Me.fileLocation})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1384, 25)
        Me.ToolStrip2.TabIndex = 182
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'fileLocation
        '
        Me.fileLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fileLocation.Name = "fileLocation"
        Me.fileLocation.Size = New System.Drawing.Size(1000, 25)
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripLabel7.Text = "文件物理存放位置："
        '
        'AIP2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1384, 740)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.yidengji)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ing)
        Me.Controls.Add(Me.axHWPostil1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AIP2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "其他类文件上传界面"
        CType(Me.yidengji, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.axHWPostil1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents yidengji As System.Windows.Forms.DataGridView
    Friend WithEvents UnloadTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UserCompany As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UserGroup As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Username As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents FILEID As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BUT_START As System.Windows.Forms.ToolStripButton
    Friend WithEvents FILETYPE As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents FileExtemsion As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents filename As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LABEL_BILL As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents opd As System.Windows.Forms.OpenFileDialog
    Private WithEvents axHWPostil1 As AxHWPOSTILLib.AxHWPostil
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents isCompanyid As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents isDept As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents isCompany As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ing As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel7 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents fileLocation As System.Windows.Forms.ToolStripTextBox
End Class
