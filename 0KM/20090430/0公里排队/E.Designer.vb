<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_Guard
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("油类")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("已登记车辆")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("可进厂车辆")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("已完成车辆")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("--超时车辆")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("--退回车辆")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("粕类")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("可进厂车辆")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("已完成车辆")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("--超时车辆")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("--退回车辆")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_Guard))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chaxun = New System.Windows.Forms.TextBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.idid = New System.Windows.Forms.Label()
        Me.box2 = New System.Windows.Forms.GroupBox()
        Me.AxHWPostil1 = New AxHWPOSTILLib.AxHWPostil()
        Me.yidengji = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.kehumingcheng = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.pinming = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.tidanhao = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.shuliang = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.chehao = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.dianhuahaoma = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.beizhu = New System.Windows.Forms.ToolStripTextBox()
        Me.PrintBill = New System.Windows.Forms.ToolStripButton()
        Me.box2.SuspendLayout()
        CType(Me.AxHWPostil1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yidengji, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView2
        '
        Me.TreeView2.BackColor = System.Drawing.Color.White
        Me.TreeView2.Enabled = False
        Me.TreeView2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TreeView2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TreeView2.ItemHeight = 30
        Me.TreeView2.Location = New System.Drawing.Point(5, 288)
        Me.TreeView2.Name = "TreeView2"
        TreeNode1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        TreeNode1.ImageIndex = -2
        TreeNode1.Name = "节点0"
        TreeNode1.NodeFont = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        TreeNode1.Text = "油类"
        TreeNode2.Name = "节点1"
        TreeNode2.Text = "已登记车辆"
        TreeNode3.Name = "节点0"
        TreeNode3.Text = "可进厂车辆"
        TreeNode4.Name = "节点0"
        TreeNode4.Text = "已完成车辆"
        TreeNode5.ForeColor = System.Drawing.Color.OliveDrab
        TreeNode5.Name = "节点0"
        TreeNode5.Text = "--超时车辆"
        TreeNode6.ForeColor = System.Drawing.Color.OliveDrab
        TreeNode6.Name = "节点0"
        TreeNode6.Text = "--退回车辆"
        Me.TreeView2.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6})
        Me.TreeView2.Size = New System.Drawing.Size(126, 201)
        Me.TreeView2.TabIndex = 191
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Red
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(8, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 190
        Me.Label7.Text = "车号查询"
        '
        'chaxun
        '
        Me.chaxun.BackColor = System.Drawing.Color.Red
        Me.chaxun.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chaxun.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chaxun.Location = New System.Drawing.Point(5, 52)
        Me.chaxun.Name = "chaxun"
        Me.chaxun.Size = New System.Drawing.Size(126, 29)
        Me.chaxun.TabIndex = 189
        Me.chaxun.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.White
        Me.TreeView1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TreeView1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TreeView1.Indent = 5
        Me.TreeView1.ItemHeight = 30
        Me.TreeView1.Location = New System.Drawing.Point(5, 85)
        Me.TreeView1.Name = "TreeView1"
        TreeNode7.BackColor = System.Drawing.Color.White
        TreeNode7.ForeColor = System.Drawing.Color.Black
        TreeNode7.ImageIndex = -2
        TreeNode7.Name = "节点0"
        TreeNode7.NodeFont = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        TreeNode7.Text = "粕类"
        TreeNode8.BackColor = System.Drawing.Color.White
        TreeNode8.ForeColor = System.Drawing.Color.Red
        TreeNode8.Name = "节点0"
        TreeNode8.NodeFont = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        TreeNode8.Text = "可进厂车辆"
        TreeNode9.BackColor = System.Drawing.Color.White
        TreeNode9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        TreeNode9.Name = "节点0"
        TreeNode9.NodeFont = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        TreeNode9.Text = "已完成车辆"
        TreeNode10.BackColor = System.Drawing.Color.White
        TreeNode10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        TreeNode10.Name = "节点0"
        TreeNode10.NodeFont = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        TreeNode10.Text = "--超时车辆"
        TreeNode11.BackColor = System.Drawing.Color.White
        TreeNode11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        TreeNode11.Name = "节点0"
        TreeNode11.NodeFont = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        TreeNode11.Text = "--退回车辆"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11})
        Me.TreeView1.Size = New System.Drawing.Size(126, 197)
        Me.TreeView1.TabIndex = 188
        '
        'idid
        '
        Me.idid.AutoSize = True
        Me.idid.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.idid.Location = New System.Drawing.Point(-4, 29)
        Me.idid.Name = "idid"
        Me.idid.Size = New System.Drawing.Size(24, 20)
        Me.idid.TabIndex = 166
        Me.idid.Text = "ID"
        '
        'box2
        '
        Me.box2.Controls.Add(Me.AxHWPostil1)
        Me.box2.Controls.Add(Me.yidengji)
        Me.box2.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.box2.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.box2.Location = New System.Drawing.Point(149, 52)
        Me.box2.Name = "box2"
        Me.box2.Size = New System.Drawing.Size(1115, 690)
        Me.box2.TabIndex = 187
        Me.box2.TabStop = False
        Me.box2.Text = "Guard Data View"
        '
        'AxHWPostil1
        '
        Me.AxHWPostil1.Enabled = True
        Me.AxHWPostil1.Location = New System.Drawing.Point(9, 206)
        Me.AxHWPostil1.Name = "AxHWPostil1"
        Me.AxHWPostil1.OcxState = CType(resources.GetObject("AxHWPostil1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxHWPostil1.Size = New System.Drawing.Size(1094, 471)
        Me.AxHWPostil1.TabIndex = 145
        '
        'yidengji
        '
        Me.yidengji.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.yidengji.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.yidengji.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.yidengji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.yidengji.Location = New System.Drawing.Point(9, 23)
        Me.yidengji.Name = "yidengji"
        Me.yidengji.ReadOnly = True
        Me.yidengji.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.yidengji.RowHeadersVisible = False
        Me.yidengji.RowTemplate.Height = 23
        Me.yidengji.Size = New System.Drawing.Size(1094, 177)
        Me.yidengji.TabIndex = 144
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.kehumingcheng, Me.ToolStripLabel2, Me.pinming, Me.ToolStripLabel3, Me.tidanhao, Me.ToolStripLabel4, Me.shuliang, Me.ToolStripLabel5, Me.chehao, Me.ToolStripLabel6, Me.dianhuahaoma, Me.ToolStripLabel7, Me.beizhu, Me.PrintBill})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1264, 25)
        Me.ToolStrip1.TabIndex = 193
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(59, 22)
        Me.ToolStripLabel1.Text = "客户名称:"
        '
        'kehumingcheng
        '
        Me.kehumingcheng.ForeColor = System.Drawing.Color.Red
        Me.kehumingcheng.Name = "kehumingcheng"
        Me.kehumingcheng.Size = New System.Drawing.Size(150, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(59, 22)
        Me.ToolStripLabel2.Text = "货物名称:"
        '
        'pinming
        '
        Me.pinming.ForeColor = System.Drawing.Color.Red
        Me.pinming.Name = "pinming"
        Me.pinming.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripLabel3.Text = "提单号:"
        '
        'tidanhao
        '
        Me.tidanhao.ForeColor = System.Drawing.Color.Red
        Me.tidanhao.Name = "tidanhao"
        Me.tidanhao.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripLabel4.Text = "提单量:"
        '
        'shuliang
        '
        Me.shuliang.ForeColor = System.Drawing.Color.Red
        Me.shuliang.Name = "shuliang"
        Me.shuliang.Size = New System.Drawing.Size(30, 25)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripLabel5.Text = "车号："
        '
        'chehao
        '
        Me.chehao.ForeColor = System.Drawing.Color.Red
        Me.chehao.Name = "chehao"
        Me.chehao.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripLabel6.Text = "电话号码："
        '
        'dianhuahaoma
        '
        Me.dianhuahaoma.ForeColor = System.Drawing.Color.Red
        Me.dianhuahaoma.Name = "dianhuahaoma"
        Me.dianhuahaoma.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripLabel7.Text = "备注："
        '
        'beizhu
        '
        Me.beizhu.ForeColor = System.Drawing.Color.Red
        Me.beizhu.Name = "beizhu"
        Me.beizhu.Size = New System.Drawing.Size(100, 25)
        '
        'PrintBill
        '
        Me.PrintBill.Image = CType(resources.GetObject("PrintBill.Image"), System.Drawing.Image)
        Me.PrintBill.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintBill.Name = "PrintBill"
        Me.PrintBill.Size = New System.Drawing.Size(76, 22)
        Me.PrintBill.Text = "打印提单"
        '
        'E_Guard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 741)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TreeView2)
        Me.Controls.Add(Me.idid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chaxun)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.box2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "E_Guard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "提单管理界面"
        Me.box2.ResumeLayout(False)
        CType(Me.AxHWPostil1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yidengji, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeView2 As System.Windows.Forms.TreeView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chaxun As System.Windows.Forms.TextBox
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents idid As System.Windows.Forms.Label
    Friend WithEvents box2 As System.Windows.Forms.GroupBox
    Friend WithEvents yidengji As System.Windows.Forms.DataGridView

    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents kehumingcheng As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents pinming As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tidanhao As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents shuliang As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents chehao As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents dianhuahaoma As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel7 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents beizhu As System.Windows.Forms.ToolStripTextBox
    Private WithEvents AxHWPostil1 As AxHWPOSTILLib.AxHWPostil
    Friend WithEvents PrintBill As System.Windows.Forms.ToolStripButton
End Class
