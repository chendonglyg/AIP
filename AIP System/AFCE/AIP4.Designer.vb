<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AIP4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AIP4))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OPD = New System.Windows.Forms.OpenFileDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Username = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UserGroup = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UserCompany = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UnloadTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.YearSum = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripLabel()
        Me.FILE_NAME = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.isCompany = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.isDept = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.yidengji = New System.Windows.Forms.DataGridView()
        Me.IDID = New System.Windows.Forms.Label()
        Me.FileExtension = New System.Windows.Forms.Label()
        Me.FileName = New System.Windows.Forms.Label()
        Me.WinWord = New AIPMS.WinWordControl()
        Me.ing = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.yidengji, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(1334, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 15)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "指定目录里最新文件"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OPD
        '
        Me.OPD.FileName = "OpenFileDialog1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Username, Me.UserGroup, Me.UserCompany, Me.UnloadTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 715)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1384, 22)
        Me.StatusStrip1.TabIndex = 187
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Username
        '
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(67, 17)
        Me.Username.Text = "Username"
        '
        'UserGroup
        '
        Me.UserGroup.Name = "UserGroup"
        Me.UserGroup.Size = New System.Drawing.Size(72, 17)
        Me.UserGroup.Text = "UserGroup"
        '
        'UserCompany
        '
        Me.UserCompany.Name = "UserCompany"
        Me.UserCompany.Size = New System.Drawing.Size(90, 17)
        Me.UserCompany.Text = "UserCompany"
        '
        'UnloadTime
        '
        Me.UnloadTime.Name = "UnloadTime"
        Me.UnloadTime.Size = New System.Drawing.Size(78, 17)
        Me.UnloadTime.Text = "UnloadTime"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripSeparator5, Me.ToolStripLabel1, Me.ToolStripLabel4, Me.YearSum, Me.ToolStripSeparator10, Me.FILE_NAME, Me.ToolStripButton3, Me.ToolStripSeparator3, Me.ToolStripLabel3, Me.isCompany, Me.ToolStripSeparator2, Me.ToolStripLabel5, Me.isDept, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1384, 25)
        Me.ToolStrip1.TabIndex = 186
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 22)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripLabel4.Text = "文件年份："
        '
        'YearSum
        '
        Me.YearSum.BackColor = System.Drawing.SystemColors.Window
        Me.YearSum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YearSum.Items.AddRange(New Object() {"2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025"})
        Me.YearSum.Name = "YearSum"
        Me.YearSum.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripSeparator10.Text = "文件名"
        '
        'FILE_NAME
        '
        Me.FILE_NAME.Font = New System.Drawing.Font("Microsoft YaHei UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FILE_NAME.Name = "FILE_NAME"
        Me.FILE_NAME.Size = New System.Drawing.Size(150, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(0, 22)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripLabel3.Text = "所属公司"
        '
        'isCompany
        '
        Me.isCompany.Enabled = False
        Me.isCompany.Name = "isCompany"
        Me.isCompany.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripLabel5.Text = "所属部门"
        '
        'isDept
        '
        Me.isDept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.isDept.Enabled = False
        Me.isDept.Name = "isDept"
        Me.isDept.Size = New System.Drawing.Size(99, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(75, 22)
        Me.ToolStripButton1.Text = "UPDATE"
        '
        'yidengji
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.yidengji.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.yidengji.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.yidengji.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.yidengji.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.yidengji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.yidengji.DefaultCellStyle = DataGridViewCellStyle8
        Me.yidengji.Location = New System.Drawing.Point(13, 33)
        Me.yidengji.Margin = New System.Windows.Forms.Padding(4)
        Me.yidengji.Name = "yidengji"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.yidengji.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.yidengji.RowHeadersVisible = False
        DataGridViewCellStyle10.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.yidengji.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.yidengji.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.yidengji.Size = New System.Drawing.Size(1360, 199)
        Me.yidengji.TabIndex = 188
        '
        'IDID
        '
        Me.IDID.AutoSize = True
        Me.IDID.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.IDID.Location = New System.Drawing.Point(1347, 74)
        Me.IDID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IDID.Name = "IDID"
        Me.IDID.Size = New System.Drawing.Size(24, 20)
        Me.IDID.TabIndex = 189
        Me.IDID.Text = "ID"
        '
        'FileExtension
        '
        Me.FileExtension.AutoSize = True
        Me.FileExtension.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FileExtension.Location = New System.Drawing.Point(1242, 74)
        Me.FileExtension.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FileExtension.Name = "FileExtension"
        Me.FileExtension.Size = New System.Drawing.Size(97, 20)
        Me.FileExtension.TabIndex = 190
        Me.FileExtension.Text = "FileExtension"
        '
        'FileName
        '
        Me.FileName.AutoSize = True
        Me.FileName.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FileName.Location = New System.Drawing.Point(1181, 74)
        Me.FileName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FileName.Name = "FileName"
        Me.FileName.Size = New System.Drawing.Size(72, 20)
        Me.FileName.TabIndex = 191
        Me.FileName.Text = "FileName"
        '
        'WinWord
        '
        Me.WinWord.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.WinWord.Location = New System.Drawing.Point(13, 236)
        Me.WinWord.Margin = New System.Windows.Forms.Padding(4)
        Me.WinWord.Name = "WinWord"
        Me.WinWord.Size = New System.Drawing.Size(1360, 465)
        Me.WinWord.TabIndex = 1
        '
        'ing
        '
        Me.ing.AutoSize = True
        Me.ing.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ing.Font = New System.Drawing.Font("微软雅黑", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ing.Location = New System.Drawing.Point(575, 348)
        Me.ing.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ing.Name = "ing"
        Me.ing.Size = New System.Drawing.Size(234, 41)
        Me.ing.TabIndex = 192
        Me.ing.Text = "正在转换数据..."
        Me.ing.Visible = False
        '
        'AIP4
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1384, 737)
        Me.Controls.Add(Me.ing)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.yidengji)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.WinWord)
        Me.Controls.Add(Me.FileName)
        Me.Controls.Add(Me.FileExtension)
        Me.Controls.Add(Me.IDID)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AIP4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "文档编辑室（目前只支持Word）"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.yidengji, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents WinWord As AIPMS.WinWordControl
    Friend WithEvents OPD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Username As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UserGroup As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UserCompany As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UnloadTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents YearSum As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents FILE_NAME As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents isCompany As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents isDept As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents yidengji As System.Windows.Forms.DataGridView
    Friend WithEvents IDID As System.Windows.Forms.Label
    Friend WithEvents FileExtension As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents FileName As System.Windows.Forms.Label
    Friend WithEvents ing As System.Windows.Forms.Label
End Class
