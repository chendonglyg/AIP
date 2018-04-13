<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MAOYI
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("功能选择菜单")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("可登记")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("已登记")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("可进厂")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("已完成")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("--超时车辆")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("--退回车辆")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MAOYI))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.C1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.C1_1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.C1_2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.C1_3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.C1_4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.jichuxinxi = New System.Windows.Forms.GroupBox()
        Me.pici = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pinming = New System.Windows.Forms.TextBox()
        Me.kehumingcheng = New System.Windows.Forms.TextBox()
        Me.tidanhao = New System.Windows.Forms.TextBox()
        Me.shuliang = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.zipaiche = New System.Windows.Forms.CheckBox()
        Me.chehao = New System.Windows.Forms.TextBox()
        Me.dianhuahaoma = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Reservedtime1 = New System.Windows.Forms.TextBox()
        Me.isReserved = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Reservedtime2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.beizhu = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.loading = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.idid = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chaxun = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Button4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.BackToParking = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoneToParking = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.kedengji = New System.Windows.Forms.DataGridView()
        Me.box2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.sijiname = New System.Windows.Forms.TextBox()
        Me.sijiID = New System.Windows.Forms.TextBox()
        Me.C1.SuspendLayout()
        Me.jichuxinxi.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.BackToParking.SuspendLayout()
        Me.DoneToParking.SuspendLayout()
        CType(Me.kedengji, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1
        '
        Me.C1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.C1_1, Me.C1_2, Me.C1_3, Me.C1_4})
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(125, 92)
        '
        'C1_1
        '
        Me.C1_1.Name = "C1_1"
        Me.C1_1.Size = New System.Drawing.Size(124, 22)
        Me.C1_1.Text = "删除记录"
        '
        'C1_2
        '
        Me.C1_2.ForeColor = System.Drawing.Color.Red
        Me.C1_2.Name = "C1_2"
        Me.C1_2.Size = New System.Drawing.Size(124, 22)
        Me.C1_2.Text = "强制登记"
        '
        'C1_3
        '
        Me.C1_3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.C1_3.Name = "C1_3"
        Me.C1_3.Size = New System.Drawing.Size(124, 22)
        Me.C1_3.Text = "配卡通行"
        '
        'C1_4
        '
        Me.C1_4.Name = "C1_4"
        Me.C1_4.Size = New System.Drawing.Size(124, 22)
        Me.C1_4.Text = "强制放行"
        '
        'jichuxinxi
        '
        Me.jichuxinxi.Controls.Add(Me.pici)
        Me.jichuxinxi.Controls.Add(Me.GroupBox3)
        Me.jichuxinxi.Controls.Add(Me.GroupBox2)
        Me.jichuxinxi.Controls.Add(Me.GroupBox1)
        Me.jichuxinxi.Controls.Add(Me.Label15)
        Me.jichuxinxi.Controls.Add(Me.beizhu)
        Me.jichuxinxi.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.jichuxinxi.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.jichuxinxi.Location = New System.Drawing.Point(16, 60)
        Me.jichuxinxi.Margin = New System.Windows.Forms.Padding(4)
        Me.jichuxinxi.Name = "jichuxinxi"
        Me.jichuxinxi.Padding = New System.Windows.Forms.Padding(4)
        Me.jichuxinxi.Size = New System.Drawing.Size(397, 625)
        Me.jichuxinxi.TabIndex = 162
        Me.jichuxinxi.TabStop = False
        Me.jichuxinxi.Text = "基础信息"
        '
        'pici
        '
        Me.pici.AutoSize = True
        Me.pici.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.pici.Location = New System.Drawing.Point(17, 31)
        Me.pici.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pici.Name = "pici"
        Me.pici.Size = New System.Drawing.Size(35, 20)
        Me.pici.TabIndex = 185
        Me.pici.Text = "PICI"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.pinming)
        Me.GroupBox3.Controls.Add(Me.kehumingcheng)
        Me.GroupBox3.Controls.Add(Me.tidanhao)
        Me.GroupBox3.Controls.Add(Me.shuliang)
        Me.GroupBox3.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(23, 60)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(351, 184)
        Me.GroupBox3.TabIndex = 145
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "客户信息"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 146)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 186
        Me.Label5.Text = "提单量"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label25.Location = New System.Drawing.Point(15, 75)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 17)
        Me.Label25.TabIndex = 185
        Me.Label25.Text = "货物名称"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 111)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 183
        Me.Label6.Text = "提单号"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 182
        Me.Label3.Text = "客户名称"
        '
        'pinming
        '
        Me.pinming.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pinming.Enabled = False
        Me.pinming.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.pinming.Location = New System.Drawing.Point(11, 71)
        Me.pinming.Margin = New System.Windows.Forms.Padding(4)
        Me.pinming.Name = "pinming"
        Me.pinming.Size = New System.Drawing.Size(291, 23)
        Me.pinming.TabIndex = 189
        Me.pinming.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'kehumingcheng
        '
        Me.kehumingcheng.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kehumingcheng.Enabled = False
        Me.kehumingcheng.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.kehumingcheng.Location = New System.Drawing.Point(11, 35)
        Me.kehumingcheng.Margin = New System.Windows.Forms.Padding(4)
        Me.kehumingcheng.Name = "kehumingcheng"
        Me.kehumingcheng.Size = New System.Drawing.Size(291, 23)
        Me.kehumingcheng.TabIndex = 188
        Me.kehumingcheng.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tidanhao
        '
        Me.tidanhao.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tidanhao.Enabled = False
        Me.tidanhao.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tidanhao.Location = New System.Drawing.Point(11, 108)
        Me.tidanhao.Margin = New System.Windows.Forms.Padding(4)
        Me.tidanhao.Name = "tidanhao"
        Me.tidanhao.Size = New System.Drawing.Size(291, 23)
        Me.tidanhao.TabIndex = 184
        Me.tidanhao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'shuliang
        '
        Me.shuliang.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.shuliang.Enabled = False
        Me.shuliang.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.shuliang.Location = New System.Drawing.Point(11, 142)
        Me.shuliang.Margin = New System.Windows.Forms.Padding(4)
        Me.shuliang.Name = "shuliang"
        Me.shuliang.Size = New System.Drawing.Size(291, 23)
        Me.shuliang.TabIndex = 187
        Me.shuliang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.sijiname)
        Me.GroupBox2.Controls.Add(Me.sijiID)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.zipaiche)
        Me.GroupBox2.Controls.Add(Me.chehao)
        Me.GroupBox2.Controls.Add(Me.dianhuahaoma)
        Me.GroupBox2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(23, 250)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(351, 126)
        Me.GroupBox2.TabIndex = 184
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "车辆信息"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 17)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "车号"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 50)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "电话号码"
        '
        'zipaiche
        '
        Me.zipaiche.AutoSize = True
        Me.zipaiche.BackColor = System.Drawing.Color.Yellow
        Me.zipaiche.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.zipaiche.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.zipaiche.Location = New System.Drawing.Point(246, 23)
        Me.zipaiche.Margin = New System.Windows.Forms.Padding(4)
        Me.zipaiche.Name = "zipaiche"
        Me.zipaiche.Size = New System.Drawing.Size(69, 22)
        Me.zipaiche.TabIndex = 168
        Me.zipaiche.Text = "自派车"
        Me.zipaiche.UseVisualStyleBackColor = False
        '
        'chehao
        '
        Me.chehao.BackColor = System.Drawing.Color.Yellow
        Me.chehao.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chehao.Location = New System.Drawing.Point(11, 22)
        Me.chehao.Margin = New System.Windows.Forms.Padding(4)
        Me.chehao.Name = "chehao"
        Me.chehao.Size = New System.Drawing.Size(229, 23)
        Me.chehao.TabIndex = 157
        Me.chehao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dianhuahaoma
        '
        Me.dianhuahaoma.BackColor = System.Drawing.Color.Yellow
        Me.dianhuahaoma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dianhuahaoma.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.dianhuahaoma.Location = New System.Drawing.Point(11, 48)
        Me.dianhuahaoma.Margin = New System.Windows.Forms.Padding(4)
        Me.dianhuahaoma.Name = "dianhuahaoma"
        Me.dianhuahaoma.Size = New System.Drawing.Size(229, 23)
        Me.dianhuahaoma.TabIndex = 158
        Me.dianhuahaoma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Reservedtime1)
        Me.GroupBox1.Controls.Add(Me.isReserved)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Reservedtime2)
        Me.GroupBox1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 386)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(351, 115)
        Me.GroupBox1.TabIndex = 184
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "预约信息"
        '
        'Reservedtime1
        '
        Me.Reservedtime1.BackColor = System.Drawing.Color.Yellow
        Me.Reservedtime1.Enabled = False
        Me.Reservedtime1.Font = New System.Drawing.Font("微软雅黑 Light", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Reservedtime1.Location = New System.Drawing.Point(120, 35)
        Me.Reservedtime1.Margin = New System.Windows.Forms.Padding(4)
        Me.Reservedtime1.Name = "Reservedtime1"
        Me.Reservedtime1.ReadOnly = True
        Me.Reservedtime1.Size = New System.Drawing.Size(195, 21)
        Me.Reservedtime1.TabIndex = 190
        '
        'isReserved
        '
        Me.isReserved.AutoSize = True
        Me.isReserved.Enabled = False
        Me.isReserved.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.isReserved.ForeColor = System.Drawing.Color.Red
        Me.isReserved.Location = New System.Drawing.Point(28, 40)
        Me.isReserved.Margin = New System.Windows.Forms.Padding(4)
        Me.isReserved.Name = "isReserved"
        Me.isReserved.Size = New System.Drawing.Size(63, 21)
        Me.isReserved.TabIndex = 192
        Me.isReserved.Text = "预约否"
        Me.isReserved.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 70)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 19)
        Me.Label8.TabIndex = 189
        Me.Label8.Text = "预约时间"
        '
        'Reservedtime2
        '
        Me.Reservedtime2.BackColor = System.Drawing.Color.Yellow
        Me.Reservedtime2.Enabled = False
        Me.Reservedtime2.Font = New System.Drawing.Font("微软雅黑 Light", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Reservedtime2.Location = New System.Drawing.Point(120, 72)
        Me.Reservedtime2.Margin = New System.Windows.Forms.Padding(4)
        Me.Reservedtime2.Name = "Reservedtime2"
        Me.Reservedtime2.ReadOnly = True
        Me.Reservedtime2.Size = New System.Drawing.Size(195, 21)
        Me.Reservedtime2.TabIndex = 191
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label15.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.Location = New System.Drawing.Point(172, 556)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 17)
        Me.Label15.TabIndex = 115
        Me.Label15.Text = "备注"
        '
        'beizhu
        '
        Me.beizhu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.beizhu.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.beizhu.Location = New System.Drawing.Point(23, 524)
        Me.beizhu.Margin = New System.Windows.Forms.Padding(4)
        Me.beizhu.Name = "beizhu"
        Me.beizhu.Size = New System.Drawing.Size(349, 75)
        Me.beizhu.TabIndex = 159
        Me.beizhu.Text = ""
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(435, 448)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 42)
        Me.Button1.TabIndex = 175
        Me.Button1.Text = "读取客户名称"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'loading
        '
        Me.loading.AutoSize = True
        Me.loading.BackColor = System.Drawing.Color.WhiteSmoke
        Me.loading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.loading.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.loading.ForeColor = System.Drawing.Color.Red
        Me.loading.Location = New System.Drawing.Point(455, 500)
        Me.loading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.loading.Name = "loading"
        Me.loading.Size = New System.Drawing.Size(118, 19)
        Me.loading.TabIndex = 166
        Me.loading.Text = "数据读取中,请稍后..."
        Me.loading.Visible = False
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TreeView1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(427, 119)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(4)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        TreeNode1.ImageIndex = -2
        TreeNode1.Name = "节点0"
        TreeNode1.Text = "功能选择菜单"
        TreeNode2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        TreeNode2.Name = "节点1"
        TreeNode2.Text = "可登记"
        TreeNode3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        TreeNode3.Name = "节点4"
        TreeNode3.Text = "已登记"
        TreeNode4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        TreeNode4.Name = "节点5"
        TreeNode4.Text = "可进厂"
        TreeNode5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        TreeNode5.Name = "节点0"
        TreeNode5.Text = "已完成"
        TreeNode6.ForeColor = System.Drawing.Color.Red
        TreeNode6.Name = "节点0"
        TreeNode6.Text = "--超时车辆"
        TreeNode7.ForeColor = System.Drawing.Color.Red
        TreeNode7.Name = "节点1"
        TreeNode7.Text = "--退回车辆"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7})
        Me.TreeView1.Size = New System.Drawing.Size(221, 566)
        Me.TreeView1.TabIndex = 174
        '
        'idid
        '
        Me.idid.AutoSize = True
        Me.idid.Font = New System.Drawing.Font("微软雅黑", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.idid.Location = New System.Drawing.Point(660, 8)
        Me.idid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.idid.Name = "idid"
        Me.idid.Size = New System.Drawing.Size(11, 9)
        Me.idid.TabIndex = 176
        Me.idid.Text = "id"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Red
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(429, 70)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.TabIndex = 181
        Me.Label7.Text = "车号查询"
        '
        'chaxun
        '
        Me.chaxun.BackColor = System.Drawing.Color.Red
        Me.chaxun.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chaxun.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chaxun.Location = New System.Drawing.Point(427, 60)
        Me.chaxun.Margin = New System.Windows.Forms.Padding(4)
        Me.chaxun.Name = "chaxun"
        Me.chaxun.Size = New System.Drawing.Size(221, 39)
        Me.chaxun.TabIndex = 180
        Me.chaxun.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Button4, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1384, 25)
        Me.ToolStrip1.TabIndex = 183
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(76, 22)
        Me.Button4.Text = "车号变更"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripButton2.Text = "豆粕推送"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripButton3.Text = "卸货推送"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripButton4.Text = "油脂推送"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripButton5.Text = "化工推送"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(98, 22)
        Me.ToolStripButton1.Text = "PDF提单管理"
        '
        'BackToParking
        '
        Me.BackToParking.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.BackToParking.Name = "C1"
        Me.BackToParking.Size = New System.Drawing.Size(125, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.ToolStripMenuItem1.Text = "重新登记"
        '
        'DoneToParking
        '
        Me.DoneToParking.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.DoneToParking.Name = "C1"
        Me.DoneToParking.Size = New System.Drawing.Size(185, 26)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(184, 22)
        Me.ToolStripMenuItem2.Text = "完成记录返回可登记"
        '
        'kedengji
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.kedengji.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.kedengji.BackgroundColor = System.Drawing.Color.White
        Me.kedengji.ColumnHeadersHeight = 20
        Me.kedengji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.kedengji.ContextMenuStrip = Me.C1
        Me.kedengji.Location = New System.Drawing.Point(656, 60)
        Me.kedengji.Margin = New System.Windows.Forms.Padding(4)
        Me.kedengji.Name = "kedengji"
        Me.kedengji.ReadOnly = True
        Me.kedengji.RowHeadersVisible = False
        Me.kedengji.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.kedengji.RowTemplate.Height = 23
        Me.kedengji.Size = New System.Drawing.Size(715, 625)
        Me.kedengji.TabIndex = 184
        '
        'box2
        '
        Me.box2.AutoSize = True
        Me.box2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.box2.Location = New System.Drawing.Point(969, 39)
        Me.box2.Name = "box2"
        Me.box2.Size = New System.Drawing.Size(80, 17)
        Me.box2.TabIndex = 185
        Me.box2.Text = "车辆状态显示"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 169
        Me.Label1.Text = "司机姓名"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 100)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 17)
        Me.Label9.TabIndex = 170
        Me.Label9.Text = "司机二代证"
        '
        'sijiname
        '
        Me.sijiname.BackColor = System.Drawing.Color.Yellow
        Me.sijiname.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.sijiname.Location = New System.Drawing.Point(11, 73)
        Me.sijiname.Margin = New System.Windows.Forms.Padding(4)
        Me.sijiname.Name = "sijiname"
        Me.sijiname.Size = New System.Drawing.Size(153, 23)
        Me.sijiname.TabIndex = 171
        Me.sijiname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'sijiID
        '
        Me.sijiID.BackColor = System.Drawing.Color.Yellow
        Me.sijiID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sijiID.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.sijiID.Location = New System.Drawing.Point(11, 98)
        Me.sijiID.Margin = New System.Windows.Forms.Padding(4)
        Me.sijiID.Name = "sijiID"
        Me.sijiID.Size = New System.Drawing.Size(229, 23)
        Me.sijiID.TabIndex = 172
        Me.sijiID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MAOYI
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1384, 698)
        Me.Controls.Add(Me.box2)
        Me.Controls.Add(Me.kedengji)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chaxun)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.idid)
        Me.Controls.Add(Me.loading)
        Me.Controls.Add(Me.jichuxinxi)
        Me.Controls.Add(Me.TreeView1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MAOYI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "可登记数据推送界面"
        Me.C1.ResumeLayout(False)
        Me.jichuxinxi.ResumeLayout(False)
        Me.jichuxinxi.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.BackToParking.ResumeLayout(False)
        Me.DoneToParking.ResumeLayout(False)
        CType(Me.kedengji, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents jichuxinxi As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents beizhu As System.Windows.Forms.RichTextBox
    Friend WithEvents dianhuahaoma As System.Windows.Forms.TextBox
    Friend WithEvents chehao As System.Windows.Forms.TextBox
    Friend WithEvents loading As System.Windows.Forms.Label
    Friend WithEvents C1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents zipaiche As System.Windows.Forms.CheckBox
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents C1_1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents idid As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chaxun As System.Windows.Forms.TextBox
    Friend WithEvents C1_2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents C1_3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Button4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Reservedtime1 As System.Windows.Forms.TextBox
    Friend WithEvents isReserved As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Reservedtime2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pinming As System.Windows.Forms.TextBox
    Friend WithEvents kehumingcheng As System.Windows.Forms.TextBox
    Friend WithEvents tidanhao As System.Windows.Forms.TextBox
    Friend WithEvents shuliang As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BackToParking As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents C1_4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pici As System.Windows.Forms.Label
    Friend WithEvents DoneToParking As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kedengji As System.Windows.Forms.DataGridView
    Friend WithEvents box2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents sijiname As System.Windows.Forms.TextBox
    Friend WithEvents sijiID As System.Windows.Forms.TextBox
End Class
