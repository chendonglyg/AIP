<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NULL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NULL))
        Me.yidengji = New System.Windows.Forms.DataGridView()
        Me.axHWPostil1 = New AxHWPOSTILLib.AxHWPostil()
        Me.IDID = New System.Windows.Forms.Label()
        Me.Filename = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.YearSum = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.FILETYPE = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripLabel()
        Me.AIPTYPE = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripLabel()
        Me.FILE_NAME = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BUT_START = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.FILEID = New System.Windows.Forms.ToolStripTextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Username = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UserGroup = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UserCompany = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UnloadTime = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.yidengji, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.axHWPostil1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'yidengji
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.yidengji.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.yidengji.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.yidengji.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.yidengji.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.yidengji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.yidengji.DefaultCellStyle = DataGridViewCellStyle3
        Me.yidengji.Location = New System.Drawing.Point(12, 38)
        Me.yidengji.Margin = New System.Windows.Forms.Padding(4)
        Me.yidengji.Name = "yidengji"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.yidengji.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.yidengji.RowHeadersVisible = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.yidengji.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.yidengji.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.yidengji.Size = New System.Drawing.Size(1360, 228)
        Me.yidengji.TabIndex = 175
        '
        'axHWPostil1
        '
        Me.axHWPostil1.Enabled = True
        Me.axHWPostil1.Location = New System.Drawing.Point(13, 274)
        Me.axHWPostil1.Margin = New System.Windows.Forms.Padding(4)
        Me.axHWPostil1.Name = "axHWPostil1"
        Me.axHWPostil1.OcxState = CType(resources.GetObject("axHWPostil1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.axHWPostil1.Size = New System.Drawing.Size(1359, 339)
        Me.axHWPostil1.TabIndex = 174
        '
        'IDID
        '
        Me.IDID.AutoSize = True
        Me.IDID.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.IDID.Location = New System.Drawing.Point(8, 574)
        Me.IDID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IDID.Name = "IDID"
        Me.IDID.Size = New System.Drawing.Size(24, 20)
        Me.IDID.TabIndex = 176
        Me.IDID.Text = "ID"
        '
        'Filename
        '
        Me.Filename.AutoSize = True
        Me.Filename.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Filename.Location = New System.Drawing.Point(48, 574)
        Me.Filename.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Filename.Name = "Filename"
        Me.Filename.Size = New System.Drawing.Size(70, 20)
        Me.Filename.TabIndex = 177
        Me.Filename.Text = "Filename"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripSeparator5, Me.ToolStripLabel1, Me.ToolStripLabel4, Me.YearSum, Me.ToolStripLabel5, Me.FILETYPE, Me.ToolStripSeparator9, Me.AIPTYPE, Me.ToolStripSeparator10, Me.FILE_NAME, Me.ToolStripButton3, Me.ToolStripSeparator3, Me.BUT_START, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.FILEID})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1385, 25)
        Me.ToolStrip1.TabIndex = 178
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
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripLabel5.Text = "文件类型："
        '
        'FILETYPE
        '
        Me.FILETYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FILETYPE.Items.AddRange(New Object() {"全部", "------------------------", "证照", "政府批文", "三级文件", "内部行文", "董事会决议", "合同协议", "工程档案", "荣誉证书", "身份证"})
        Me.FILETYPE.Name = "FILETYPE"
        Me.FILETYPE.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripSeparator9.Text = "签章类型"
        '
        'AIPTYPE
        '
        Me.AIPTYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AIPTYPE.Name = "AIPTYPE"
        Me.AIPTYPE.Size = New System.Drawing.Size(120, 25)
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
        'BUT_START
        '
        Me.BUT_START.BackColor = System.Drawing.Color.White
        Me.BUT_START.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BUT_START.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BUT_START.Name = "BUT_START"
        Me.BUT_START.Size = New System.Drawing.Size(58, 22)
        Me.BUT_START.Text = "<-OR->"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripLabel2.Text = "文件ID:"
        '
        'FILEID
        '
        Me.FILEID.Name = "FILEID"
        Me.FILEID.Size = New System.Drawing.Size(132, 25)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Username, Me.UserGroup, Me.UserCompany, Me.UnloadTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 617)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1385, 22)
        Me.StatusStrip1.TabIndex = 179
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
        'AIP4
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1385, 639)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.axHWPostil1)
        Me.Controls.Add(Me.yidengji)
        Me.Controls.Add(Me.IDID)
        Me.Controls.Add(Me.Filename)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AIP4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "电子档案室"
        CType(Me.yidengji, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.axHWPostil1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents yidengji As System.Windows.Forms.DataGridView
    Private WithEvents axHWPostil1 As AxHWPOSTILLib.AxHWPostil
    Friend WithEvents IDID As System.Windows.Forms.Label
    Friend WithEvents Filename As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents YearSum As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents FILETYPE As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents FILE_NAME As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents AIPTYPE As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents BUT_START As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents FILEID As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Username As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UserGroup As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UserCompany As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UnloadTime As System.Windows.Forms.ToolStripStatusLabel
End Class
