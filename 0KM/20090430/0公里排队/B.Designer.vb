﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PARKING
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PARKING))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("功能选择菜单")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("可登记")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("已登记")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("可进厂")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("已完成")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("--超时车辆")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("--退回车辆")
        Me.beizhu = New System.Windows.Forms.RichTextBox()
        Me.dianhuahaoma = New System.Windows.Forms.TextBox()
        Me.chehao = New System.Windows.Forms.TextBox()
        Me.pinming = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.tidanhao = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.kehumingcheng = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.jichuxinxi = New System.Windows.Forms.GroupBox()
        Me.isReserved = New System.Windows.Forms.CheckBox()
        Me.Reservedtime2 = New System.Windows.Forms.TextBox()
        Me.Reservedtime1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.success = New System.Windows.Forms.Label()
        Me.dengjiReserverd = New System.Windows.Forms.Button()
        Me.dengji = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.shuliang = New System.Windows.Forms.TextBox()
        Me.IDID = New System.Windows.Forms.Label()
        Me.Color = New System.Windows.Forms.CheckBox()
        Me.kedengji = New System.Windows.Forms.DataGridView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.chaxun = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.C1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReturnTOA = New System.Windows.Forms.ToolStripMenuItem()
        Me.C2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.box2 = New System.Windows.Forms.Label()
        Me.jichuxinxi.SuspendLayout()
        CType(Me.kedengji, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1.SuspendLayout()
        Me.C2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'beizhu
        '
        Me.beizhu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.beizhu.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.beizhu.Location = New System.Drawing.Point(17, 464)
        Me.beizhu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.beizhu.Name = "beizhu"
        Me.beizhu.Size = New System.Drawing.Size(287, 32)
        Me.beizhu.TabIndex = 159
        Me.beizhu.Text = ""
        '
        'dianhuahaoma
        '
        Me.dianhuahaoma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dianhuahaoma.Enabled = False
        Me.dianhuahaoma.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.dianhuahaoma.Location = New System.Drawing.Point(16, 269)
        Me.dianhuahaoma.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dianhuahaoma.Name = "dianhuahaoma"
        Me.dianhuahaoma.Size = New System.Drawing.Size(287, 26)
        Me.dianhuahaoma.TabIndex = 158
        Me.dianhuahaoma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chehao
        '
        Me.chehao.BackColor = System.Drawing.Color.Yellow
        Me.chehao.Enabled = False
        Me.chehao.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chehao.Location = New System.Drawing.Point(16, 348)
        Me.chehao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chehao.Name = "chehao"
        Me.chehao.Size = New System.Drawing.Size(287, 33)
        Me.chehao.TabIndex = 157
        Me.chehao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pinming
        '
        Me.pinming.Enabled = False
        Me.pinming.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.pinming.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.pinming.FormattingEnabled = True
        Me.pinming.Items.AddRange(New Object() {"经销出", "赠品出", "食堂领用", "礼品领用", "品控抽检", "回填", "换货出"})
        Me.pinming.Location = New System.Drawing.Point(17, 134)
        Me.pinming.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pinming.Name = "pinming"
        Me.pinming.Size = New System.Drawing.Size(285, 25)
        Me.pinming.TabIndex = 155
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label25.Location = New System.Drawing.Point(11, 108)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(65, 20)
        Me.Label25.TabIndex = 156
        Me.Label25.Text = "货物名称"
        '
        'tidanhao
        '
        Me.tidanhao.Enabled = False
        Me.tidanhao.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tidanhao.Location = New System.Drawing.Point(16, 195)
        Me.tidanhao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tidanhao.Name = "tidanhao"
        Me.tidanhao.Size = New System.Drawing.Size(287, 26)
        Me.tidanhao.TabIndex = 154
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 199)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 153
        Me.Label6.Text = "提单号"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.Location = New System.Drawing.Point(23, 469)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.kehumingcheng.Location = New System.Drawing.Point(17, 79)
        Me.kehumingcheng.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kehumingcheng.Name = "kehumingcheng"
        Me.kehumingcheng.Size = New System.Drawing.Size(285, 25)
        Me.kehumingcheng.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 52)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "客户名称"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 359)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "车号："
        '
        'jichuxinxi
        '
        Me.jichuxinxi.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.jichuxinxi.Controls.Add(Me.isReserved)
        Me.jichuxinxi.Controls.Add(Me.Reservedtime2)
        Me.jichuxinxi.Controls.Add(Me.Reservedtime1)
        Me.jichuxinxi.Controls.Add(Me.Label8)
        Me.jichuxinxi.Controls.Add(Me.Label6)
        Me.jichuxinxi.Controls.Add(Me.Label5)
        Me.jichuxinxi.Controls.Add(Me.success)
        Me.jichuxinxi.Controls.Add(Me.dengjiReserverd)
        Me.jichuxinxi.Controls.Add(Me.Label2)
        Me.jichuxinxi.Controls.Add(Me.dengji)
        Me.jichuxinxi.Controls.Add(Me.Label4)
        Me.jichuxinxi.Controls.Add(Me.shuliang)
        Me.jichuxinxi.Controls.Add(Me.IDID)
        Me.jichuxinxi.Controls.Add(Me.dianhuahaoma)
        Me.jichuxinxi.Controls.Add(Me.pinming)
        Me.jichuxinxi.Controls.Add(Me.Label25)
        Me.jichuxinxi.Controls.Add(Me.tidanhao)
        Me.jichuxinxi.Controls.Add(Me.Label15)
        Me.jichuxinxi.Controls.Add(Me.kehumingcheng)
        Me.jichuxinxi.Controls.Add(Me.Label3)
        Me.jichuxinxi.Controls.Add(Me.Color)
        Me.jichuxinxi.Controls.Add(Me.chehao)
        Me.jichuxinxi.Controls.Add(Me.beizhu)
        Me.jichuxinxi.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.jichuxinxi.Location = New System.Drawing.Point(21, 9)
        Me.jichuxinxi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.jichuxinxi.Name = "jichuxinxi"
        Me.jichuxinxi.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.jichuxinxi.Size = New System.Drawing.Size(312, 688)
        Me.jichuxinxi.TabIndex = 168
        Me.jichuxinxi.TabStop = False
        Me.jichuxinxi.Text = "基础信息"
        '
        'isReserved
        '
        Me.isReserved.AutoSize = True
        Me.isReserved.Enabled = False
        Me.isReserved.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.isReserved.ForeColor = System.Drawing.Color.Red
        Me.isReserved.Location = New System.Drawing.Point(16, 400)
        Me.isReserved.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.isReserved.Name = "isReserved"
        Me.isReserved.Size = New System.Drawing.Size(63, 21)
        Me.isReserved.TabIndex = 188
        Me.isReserved.Text = "预约否"
        Me.isReserved.UseVisualStyleBackColor = True
        '
        'Reservedtime2
        '
        Me.Reservedtime2.BackColor = System.Drawing.Color.Yellow
        Me.Reservedtime2.Enabled = False
        Me.Reservedtime2.Font = New System.Drawing.Font("微软雅黑 Light", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Reservedtime2.Location = New System.Drawing.Point(108, 430)
        Me.Reservedtime2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Reservedtime2.Name = "Reservedtime2"
        Me.Reservedtime2.ReadOnly = True
        Me.Reservedtime2.Size = New System.Drawing.Size(195, 21)
        Me.Reservedtime2.TabIndex = 187
        '
        'Reservedtime1
        '
        Me.Reservedtime1.BackColor = System.Drawing.Color.Yellow
        Me.Reservedtime1.Enabled = False
        Me.Reservedtime1.Font = New System.Drawing.Font("微软雅黑 Light", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Reservedtime1.Location = New System.Drawing.Point(108, 399)
        Me.Reservedtime1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Reservedtime1.Name = "Reservedtime1"
        Me.Reservedtime1.ReadOnly = True
        Me.Reservedtime1.Size = New System.Drawing.Size(195, 21)
        Me.Reservedtime1.TabIndex = 186
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 430)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 19)
        Me.Label8.TabIndex = 185
        Me.Label8.Text = "预约时间"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 236)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 180
        Me.Label5.Text = "提单量"
        '
        'success
        '
        Me.success.AutoSize = True
        Me.success.Font = New System.Drawing.Font("微软雅黑 Light", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.success.ForeColor = System.Drawing.Color.Red
        Me.success.Location = New System.Drawing.Point(24, 582)
        Me.success.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.success.Name = "success"
        Me.success.Size = New System.Drawing.Size(14, 16)
        Me.success.TabIndex = 182
        Me.success.Text = "..."
        '
        'dengjiReserverd
        '
        Me.dengjiReserverd.BackColor = System.Drawing.Color.White
        Me.dengjiReserverd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dengjiReserverd.Font = New System.Drawing.Font("微软雅黑 Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.dengjiReserverd.ForeColor = System.Drawing.Color.Green
        Me.dengjiReserverd.Image = CType(resources.GetObject("dengjiReserverd.Image"), System.Drawing.Image)
        Me.dengjiReserverd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.dengjiReserverd.Location = New System.Drawing.Point(16, 509)
        Me.dengjiReserverd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dengjiReserverd.Name = "dengjiReserverd"
        Me.dengjiReserverd.Size = New System.Drawing.Size(288, 74)
        Me.dengjiReserverd.TabIndex = 184
        Me.dengjiReserverd.Text = "预约登记"
        Me.dengjiReserverd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dengjiReserverd.UseVisualStyleBackColor = False
        '
        'dengji
        '
        Me.dengji.Location = New System.Drawing.Point(16, 590)
        Me.dengji.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dengji.Name = "dengji"
        Me.dengji.Size = New System.Drawing.Size(288, 76)
        Me.dengji.TabIndex = 189
        Me.dengji.Text = "正常登记"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 275)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "电话号码"
        '
        'shuliang
        '
        Me.shuliang.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.shuliang.Enabled = False
        Me.shuliang.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.shuliang.Location = New System.Drawing.Point(16, 232)
        Me.shuliang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.shuliang.Name = "shuliang"
        Me.shuliang.Size = New System.Drawing.Size(287, 26)
        Me.shuliang.TabIndex = 181
        '
        'IDID
        '
        Me.IDID.AutoSize = True
        Me.IDID.Font = New System.Drawing.Font("微软雅黑 Light", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.IDID.Location = New System.Drawing.Point(48, 31)
        Me.IDID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IDID.Name = "IDID"
        Me.IDID.Size = New System.Drawing.Size(11, 9)
        Me.IDID.TabIndex = 167
        Me.IDID.Text = "id"
        '
        'Color
        '
        Me.Color.AutoSize = True
        Me.Color.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Color.ForeColor = System.Drawing.Color.Red
        Me.Color.Location = New System.Drawing.Point(17, 321)
        Me.Color.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Color.Name = "Color"
        Me.Color.Size = New System.Drawing.Size(159, 21)
        Me.Color.TabIndex = 183
        Me.Color.Text = "蓝牌（不选默认为黄牌）"
        Me.Color.UseVisualStyleBackColor = True
        '
        'kedengji
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.kedengji.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.kedengji.BackgroundColor = System.Drawing.SystemColors.Control
        Me.kedengji.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.kedengji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.kedengji.Location = New System.Drawing.Point(594, 21)
        Me.kedengji.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kedengji.Name = "kedengji"
        Me.kedengji.ReadOnly = True
        Me.kedengji.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("微软雅黑 Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.kedengji.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.kedengji.RowTemplate.Height = 23
        Me.kedengji.Size = New System.Drawing.Size(786, 675)
        Me.kedengji.TabIndex = 144
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "right_arrow_16px_1205486_easyicon.net.png")
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.White
        Me.TreeView1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TreeView1.ForeColor = System.Drawing.Color.Black
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.LineColor = System.Drawing.Color.White
        Me.TreeView1.Location = New System.Drawing.Point(344, 65)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TreeView1.Name = "TreeView1"
        TreeNode8.ForeColor = System.Drawing.Color.Black
        TreeNode8.ImageIndex = -2
        TreeNode8.Name = "节点0"
        TreeNode8.Text = "功能选择菜单"
        TreeNode9.Name = "节点1"
        TreeNode9.SelectedImageIndex = 0
        TreeNode9.Text = "可登记"
        TreeNode10.Name = "节点4"
        TreeNode10.Text = "已登记"
        TreeNode11.Name = "节点5"
        TreeNode11.Text = "可进厂"
        TreeNode12.Name = "节点0"
        TreeNode12.Text = "已完成"
        TreeNode13.ForeColor = System.Drawing.Color.Black
        TreeNode13.Name = "节点0"
        TreeNode13.Text = "--超时车辆"
        TreeNode14.ForeColor = System.Drawing.Color.Black
        TreeNode14.Name = "节点1"
        TreeNode14.Text = "--退回车辆"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14})
        Me.TreeView1.SelectedImageKey = "化工.gif"
        Me.TreeView1.Size = New System.Drawing.Size(242, 204)
        Me.TreeView1.TabIndex = 173
        '
        'chaxun
        '
        Me.chaxun.BackColor = System.Drawing.Color.Red
        Me.chaxun.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chaxun.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chaxun.Location = New System.Drawing.Point(344, 21)
        Me.chaxun.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chaxun.Name = "chaxun"
        Me.chaxun.Size = New System.Drawing.Size(242, 33)
        Me.chaxun.TabIndex = 178
        Me.chaxun.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Red
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(349, 26)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 26)
        Me.Label7.TabIndex = 179
        Me.Label7.Text = "车号查询："
        '
        'C1
        '
        Me.C1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.C1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.C1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReturnTOA})
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(135, 28)
        '
        'ReturnTOA
        '
        Me.ReturnTOA.BackColor = System.Drawing.Color.Silver
        Me.ReturnTOA.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ReturnTOA.ForeColor = System.Drawing.Color.Red
        Me.ReturnTOA.Name = "ReturnTOA"
        Me.ReturnTOA.Size = New System.Drawing.Size(134, 24)
        Me.ReturnTOA.Text = "重新登记"
        '
        'C2
        '
        Me.C2.BackColor = System.Drawing.Color.Lime
        Me.C2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.C2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.C2.Name = "C1"
        Me.C2.Size = New System.Drawing.Size(147, 28)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.Lime
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(146, 24)
        Me.ToolStripMenuItem1.Text = "配卡放行"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(344, 486)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(242, 210)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 177
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(344, 278)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(242, 201)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 176
        Me.PictureBox1.TabStop = False
        '
        'box2
        '
        Me.box2.AutoSize = True
        Me.box2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.box2.Location = New System.Drawing.Point(947, 0)
        Me.box2.Name = "box2"
        Me.box2.Size = New System.Drawing.Size(80, 17)
        Me.box2.TabIndex = 186
        Me.box2.Text = "车辆状态显示"
        '
        'PARKING
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1384, 701)
        Me.Controls.Add(Me.box2)
        Me.Controls.Add(Me.kedengji)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chaxun)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.jichuxinxi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "PARKING"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "停车场管理处数据登记界面"
        Me.jichuxinxi.ResumeLayout(False)
        Me.jichuxinxi.PerformLayout()
        CType(Me.kedengji, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1.ResumeLayout(False)
        Me.C2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dengji As System.Windows.Forms.Button
    Friend WithEvents beizhu As System.Windows.Forms.RichTextBox
    Friend WithEvents dianhuahaoma As System.Windows.Forms.TextBox
    Friend WithEvents chehao As System.Windows.Forms.TextBox
    Friend WithEvents pinming As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents tidanhao As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents kehumingcheng As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents jichuxinxi As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents kedengji As System.Windows.Forms.DataGridView
    Friend WithEvents IDID As System.Windows.Forms.Label
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents shuliang As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chaxun As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents C1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ReturnTOA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents success As System.Windows.Forms.Label
    Friend WithEvents C2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Color As System.Windows.Forms.CheckBox
    Friend WithEvents dengjiReserverd As System.Windows.Forms.Button
    Friend WithEvents Reservedtime2 As System.Windows.Forms.TextBox
    Friend WithEvents Reservedtime1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents isReserved As System.Windows.Forms.CheckBox
    Friend WithEvents box2 As System.Windows.Forms.Label
End Class
