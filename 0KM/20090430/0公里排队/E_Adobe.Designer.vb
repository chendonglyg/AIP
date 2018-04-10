<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_Adobe
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_Adobe))
        Me.yidengji = New System.Windows.Forms.DataGridView()
        Me.shuliang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.box2 = New System.Windows.Forms.GroupBox()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.PrintBill = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.IDID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dianhuahaoma = New System.Windows.Forms.TextBox()
        Me.chehao = New System.Windows.Forms.TextBox()
        Me.pinming = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.tidanhao = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.kehumingcheng = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.beizhu = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chaxun = New System.Windows.Forms.TextBox()
        Me.jichuxinxi = New System.Windows.Forms.GroupBox()
        Me.TreeView1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        CType(Me.yidengji, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.box2.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.jichuxinxi.SuspendLayout()
        Me.SuspendLayout()
        '
        'yidengji
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.yidengji.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.yidengji.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.yidengji.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.yidengji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle3.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.yidengji.DefaultCellStyle = DataGridViewCellStyle3
        Me.yidengji.GridColor = System.Drawing.Color.White
        Me.yidengji.Location = New System.Drawing.Point(9, 23)
        Me.yidengji.Name = "yidengji"
        Me.yidengji.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle4.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.yidengji.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.yidengji.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.yidengji.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.yidengji.RowTemplate.Height = 23
        Me.yidengji.Size = New System.Drawing.Size(826, 136)
        Me.yidengji.TabIndex = 144
        '
        'shuliang
        '
        Me.shuliang.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.shuliang.Enabled = False
        Me.shuliang.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.shuliang.Location = New System.Drawing.Point(93, 218)
        Me.shuliang.Name = "shuliang"
        Me.shuliang.Size = New System.Drawing.Size(67, 23)
        Me.shuliang.TabIndex = 181
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 180
        Me.Label5.Text = "提单量"
        '
        'box2
        '
        Me.box2.Controls.Add(Me.PrintBill)
        Me.box2.Controls.Add(Me.AxAcroPDF1)
        Me.box2.Controls.Add(Me.yidengji)
        Me.box2.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.box2.ForeColor = System.Drawing.Color.Red
        Me.box2.Location = New System.Drawing.Point(411, 18)
        Me.box2.Name = "box2"
        Me.box2.Size = New System.Drawing.Size(841, 525)
        Me.box2.TabIndex = 194
        Me.box2.TabStop = False
        Me.box2.Text = "Guard Data View"
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(9, 234)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(826, 282)
        Me.AxAcroPDF1.TabIndex = 224
        '
        'PrintBill
        '
        Me.PrintBill.ForeColor = System.Drawing.Color.Red
        Me.PrintBill.Location = New System.Drawing.Point(9, 161)
        Me.PrintBill.Name = "PrintBill"
        Me.PrintBill.Size = New System.Drawing.Size(826, 67)
        Me.PrintBill.TabIndex = 223
        Me.PrintBill.Text = "下载PDF文件"
        Me.PrintBill.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(262, 130)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(143, 29)
        Me.Button5.TabIndex = 216
        Me.Button5.Text = "已完成车辆"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'IDID
        '
        Me.IDID.AutoSize = True
        Me.IDID.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.IDID.Location = New System.Drawing.Point(34, 25)
        Me.IDID.Name = "IDID"
        Me.IDID.Size = New System.Drawing.Size(0, 17)
        Me.IDID.TabIndex = 167
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "ID"
        '
        'dianhuahaoma
        '
        Me.dianhuahaoma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dianhuahaoma.Enabled = False
        Me.dianhuahaoma.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.dianhuahaoma.Location = New System.Drawing.Point(93, 306)
        Me.dianhuahaoma.Name = "dianhuahaoma"
        Me.dianhuahaoma.Size = New System.Drawing.Size(122, 23)
        Me.dianhuahaoma.TabIndex = 158
        '
        'chehao
        '
        Me.chehao.Enabled = False
        Me.chehao.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chehao.Location = New System.Drawing.Point(93, 266)
        Me.chehao.Name = "chehao"
        Me.chehao.Size = New System.Drawing.Size(122, 23)
        Me.chehao.TabIndex = 157
        '
        'pinming
        '
        Me.pinming.Enabled = False
        Me.pinming.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.pinming.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.pinming.FormattingEnabled = True
        Me.pinming.Items.AddRange(New Object() {"经销出", "赠品出", "食堂领用", "礼品领用", "品控抽检", "回填", "换货出"})
        Me.pinming.Location = New System.Drawing.Point(27, 134)
        Me.pinming.Name = "pinming"
        Me.pinming.Size = New System.Drawing.Size(188, 25)
        Me.pinming.TabIndex = 155
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label25.Location = New System.Drawing.Point(22, 106)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 17)
        Me.Label25.TabIndex = 156
        Me.Label25.Text = "货物名称"
        '
        'tidanhao
        '
        Me.tidanhao.Enabled = False
        Me.tidanhao.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tidanhao.Location = New System.Drawing.Point(93, 179)
        Me.tidanhao.Name = "tidanhao"
        Me.tidanhao.Size = New System.Drawing.Size(122, 23)
        Me.tidanhao.TabIndex = 154
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 153
        Me.Label6.Text = "提单号"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 361)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 17)
        Me.Label15.TabIndex = 115
        Me.Label15.Text = "备注"
        '
        'kehumingcheng
        '
        Me.kehumingcheng.Enabled = False
        Me.kehumingcheng.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.kehumingcheng.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.kehumingcheng.FormattingEnabled = True
        Me.kehumingcheng.Location = New System.Drawing.Point(27, 76)
        Me.kehumingcheng.Name = "kehumingcheng"
        Me.kehumingcheng.Size = New System.Drawing.Size(188, 25)
        Me.kehumingcheng.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "电话号码"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "客户名称"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 17)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "车号"
        '
        'beizhu
        '
        Me.beizhu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.beizhu.Enabled = False
        Me.beizhu.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.beizhu.Location = New System.Drawing.Point(13, 381)
        Me.beizhu.Name = "beizhu"
        Me.beizhu.Size = New System.Drawing.Size(202, 80)
        Me.beizhu.TabIndex = 159
        Me.beizhu.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Red
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(264, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.TabIndex = 197
        Me.Label7.Text = "车号查询"
        '
        'chaxun
        '
        Me.chaxun.BackColor = System.Drawing.Color.Red
        Me.chaxun.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chaxun.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chaxun.Location = New System.Drawing.Point(262, 32)
        Me.chaxun.Name = "chaxun"
        Me.chaxun.Size = New System.Drawing.Size(143, 39)
        Me.chaxun.TabIndex = 196
        Me.chaxun.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'jichuxinxi
        '
        Me.jichuxinxi.Controls.Add(Me.TreeView1)
        Me.jichuxinxi.Controls.Add(Me.shuliang)
        Me.jichuxinxi.Controls.Add(Me.Label5)
        Me.jichuxinxi.Controls.Add(Me.IDID)
        Me.jichuxinxi.Controls.Add(Me.Label1)
        Me.jichuxinxi.Controls.Add(Me.dianhuahaoma)
        Me.jichuxinxi.Controls.Add(Me.chehao)
        Me.jichuxinxi.Controls.Add(Me.pinming)
        Me.jichuxinxi.Controls.Add(Me.Label25)
        Me.jichuxinxi.Controls.Add(Me.tidanhao)
        Me.jichuxinxi.Controls.Add(Me.Label6)
        Me.jichuxinxi.Controls.Add(Me.Label15)
        Me.jichuxinxi.Controls.Add(Me.kehumingcheng)
        Me.jichuxinxi.Controls.Add(Me.Label4)
        Me.jichuxinxi.Controls.Add(Me.Label3)
        Me.jichuxinxi.Controls.Add(Me.Label2)
        Me.jichuxinxi.Controls.Add(Me.beizhu)
        Me.jichuxinxi.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.jichuxinxi.Location = New System.Drawing.Point(22, 18)
        Me.jichuxinxi.Name = "jichuxinxi"
        Me.jichuxinxi.Size = New System.Drawing.Size(227, 525)
        Me.jichuxinxi.TabIndex = 193
        Me.jichuxinxi.TabStop = False
        Me.jichuxinxi.Text = "基础信息"
        '
        'TreeView1
        '
        Me.TreeView1.AutoSize = True
        Me.TreeView1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(151, 499)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(71, 17)
        Me.TreeView1.TabIndex = 182
        Me.TreeView1.Text = "TreeFlagID"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(262, 77)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 29)
        Me.Button1.TabIndex = 212
        Me.Button1.Text = "豆粕类"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(262, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 29)
        Me.Button2.TabIndex = 213
        Me.Button2.Text = "可进厂车辆"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(332, 159)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 29)
        Me.Button3.TabIndex = 214
        Me.Button3.Text = "退回车辆"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(262, 159)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(67, 29)
        Me.Button4.TabIndex = 215
        Me.Button4.Text = "超时车辆"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(262, 337)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(143, 29)
        Me.Button6.TabIndex = 221
        Me.Button6.Text = "可进厂车辆"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(262, 396)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(67, 29)
        Me.Button7.TabIndex = 220
        Me.Button7.Text = "超时车辆"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(332, 396)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(73, 29)
        Me.Button8.TabIndex = 219
        Me.Button8.Text = "退回车辆"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(262, 310)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(143, 29)
        Me.Button9.TabIndex = 218
        Me.Button9.Text = "已登记车辆"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(262, 282)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(143, 29)
        Me.Button10.TabIndex = 217
        Me.Button10.Text = "油脂类"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(262, 367)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(143, 29)
        Me.Button11.TabIndex = 222
        Me.Button11.Text = "已完成车辆"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'E_Adobe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 561)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.box2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chaxun)
        Me.Controls.Add(Me.jichuxinxi)
        Me.Name = "E_Adobe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "提单打印界面（Adobe版)"
        CType(Me.yidengji, System.ComponentModel.ISupportInitialize).EndInit()
        Me.box2.ResumeLayout(False)
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.jichuxinxi.ResumeLayout(False)
        Me.jichuxinxi.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents yidengji As System.Windows.Forms.DataGridView
    Friend WithEvents shuliang As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents box2 As System.Windows.Forms.GroupBox
    Friend WithEvents IDID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dianhuahaoma As System.Windows.Forms.TextBox
    Friend WithEvents chehao As System.Windows.Forms.TextBox
    Friend WithEvents pinming As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents tidanhao As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents kehumingcheng As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents beizhu As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chaxun As System.Windows.Forms.TextBox
    Friend WithEvents jichuxinxi As System.Windows.Forms.GroupBox
    Friend WithEvents TreeView1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents PrintBill As System.Windows.Forms.Button
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
End Class
