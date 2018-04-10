Imports System.Windows.Forms

Public Class Mdi
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Dim sendsomething As New sendmessage.CTEnterprisesSoapClient
    Dim VehicleinPark As New lygport_outside.Service1SoapClient
    Dim objdataview As New DataView
    Dim objdataset As New DataSet
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewWindowToolStripMenuItem.Click
        ' 创建此子窗体的一个新实例。
        Dim ChildForm As New System.Windows.Forms.Form
        ' 在显示该窗体前使其成为此 MDI 窗体的子窗体。
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "窗口 " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: 在此处添加打开文件的代码。
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: 在此处添加代码，将窗体的当前内容保存到一个文件中。
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' 使用 My.Computer.Clipboard 将选择的文本或图像插入剪贴板
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' 使用 My.Computer.Clipboard 将选择的文本或图像插入剪贴板
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        '使用 My.Computer.Clipboard.GetText() 或 My.Computer.Clipboard.GetData 从剪贴板检索信息。
    End Sub

   

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' 关闭此父窗体的所有子窗体。
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

  



    Private Sub Mdi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If IO.File.Exists(Application.StartupPath & " \客户名称.txt") = False Then
        '    Dim fs As New IO.FileStream(Application.StartupPath & " \客户名称.txt", IO.FileMode.Create)
        '    fs.Close()

        dgv.AllowUserToAddRows = False '消除最后一行
        'End If



        If isadmin = True Then '这里包含了admin
            A.Enabled = True
            B.Enabled = True
            C.Enabled = True
            bill.Enabled = True
            F.Enabled = True
            SETALL.Enabled = True
        End If


        If private_data = "A" Then
            A.Enabled = True
        End If



        If private_data = "B" Then
            B.Enabled = True
        End If

        If private_data = "C" Or private_data = "C1" Then

            C.Enabled = True
        End If


        If private_data = "E" Then

            bill.Enabled = True
        End If

        '-------------------------------------------------------------------------------



        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select top 1 * from message order by time desc"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "message")

        objdataview = New DataView(objdataset.Tables("message"))

        If objdataview.Count = 1 Then
            Me.neirong.Text = Trim(objdataview.Item(0).Item("context"))
            Me.fabuzhe.Text = "发布者:" & Trim(objdataview.Item(0).Item("name"))
            Me.fabushijian.Text = "发布时间:" & Trim(objdataview.Item(0).Item("time"))

        End If

        '-------------------------------------------------------------------------------------------------------------

        objdataadapter.SelectCommand.CommandText = "select  * from message order by time desc"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "message")

        objdataview = New DataView(objdataset.Tables("message"))
        dgv.DataSource = objdataview
        dgv.Columns(0).Width = 1
        dgv.Columns(1).Width = 650
        dgv.Columns(3).Width = 150
        objconnection.Close()
    End Sub

  

  

    Private Sub 贸易开票ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles A.Click

        MAOYI.Show()

    End Sub

    Private Sub 车场登记ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles B.Click
        PARKING.Show()
    End Sub

    Private Sub 调度管理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles C.Click
        CONTROL.Show()
    End Sub

    Private Sub 司机信息ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles D.Click
        View_it.Show()
    End Sub

    Private Sub 报表打印ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles E.Click

        Trade_Report.Show()
    End Sub

    Private Sub 数据维护ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles F.Click
        TEST_READ_SAVE.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Process_OUTTIME_CAR()  '30分钟更新一次稽查



        On Error Resume Next
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select top 1 * from message order by time desc"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "message")

        objdataview = New DataView(objdataset.Tables("message"))




        If objdataview.Count = 1 Then
            Me.neirong.Text = Trim(objdataview.Item(0).Item("context"))
            Me.fabuzhe.Text = "发布者:" & Trim(objdataview.Item(0).Item("name"))
            Me.fabushijian.Text = "发布时间:" & Trim(objdataview.Item(0).Item("time"))

        End If


    End Sub

    Private Sub 广播发送ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 广播发送ToolStripMenuItem.Click
        MessageSend.Show()
    End Sub

    Private Sub 物流界面ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 物流界面ToolStripMenuItem.Click
        wuliu.Show()
    End Sub


    Private Sub 申报放行ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 申报放行ToolStripMenuItem.Click
        港务局测试一卡通专用.Show()
        港务局测试一卡通专用.chehao.Enabled = True
        港务局测试一卡通专用.dianhuahaoma.Enabled = True
        港务局测试一卡通专用.chehao.ReadOnly = False
        港务局测试一卡通专用.dianhuahaoma.ReadOnly = False



    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click

    End Sub

    Private Sub TESTTIMEADDHOURSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim time1 As Date

        time1 = "2017/4/14 12:27"

        MessageBox.Show(time1)
        time1 = time1.AddHours(2)

        MessageBox.Show(time1)

    End Sub

    Private Sub 车辆放行追溯ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SETALL.Click
        CheatCheck.Show()
    End Sub

    Private Sub 提单管理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles bill.Click
        E_Adobe.Show()
    End Sub



    Private Sub Process_OUTTIME_CAR()
        Try

   
        objdataadapter.SelectCommand.CommandText = "select 车号 from TRUCK_QUEUE where 粕类=1 and 已登记=1"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "isReserved")

        objdataview = New DataView(objdataset.Tables("isReserved"))
        ' MessageBox.Show("处理前已登记记录数为:" & objdataview.Count - 1, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '-----------------------------------------------------------------------------------------------------

        ProgressBarX1.Maximum = objdataview.Count - 1


        Dim jishu As Integer

        For jishu = 0 To objdataview.Count - 1
            System.Windows.Forms.Application.DoEvents()
            System.Windows.Forms.Application.DoEvents()
            ProgressBarX1.Value = jishu
            Dim drOperateCheHao As DataRow = objdataset.Tables("isReserved").Rows(jishu)

            Dim a As String
            Dim VehicleParkQuit As New DataTable
                a = VehicleinPark.VehiclePark(VehicleParkQuit, "VehiclePark_yhwebs", Trim(drOperateCheHao("车号")), 3)



                If VehicleParkQuit.Rows.Count > 0 Then
                    Dim drOperate As DataRow = VehicleParkQuit.Rows(0)

                    If Len(Trim(drOperate("out_time").ToString)) = 0 Then
                        ' MessageBox.Show("该车还在停车场", "2号接口检测提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                    Else
                        '  MessageBox.Show(drOperate("VEHICLE") & drOperate("in_time") & "至" & drOperate("out_time"))
                        '   MessageBox.Show("该车已出停车场", "2号接口检测提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                        System.Windows.Forms.Application.DoEvents()
                        '---------------------------------------------------------------------------
                        Dim objcommandpassword As New SqlClient.SqlCommand
                        objcommandpassword.Connection = objconnection
                        objcommandpassword.CommandText = "Update TRUCK_QUEUE set 可登记=1,已登记=0,可进厂=0,退回时间=@退回时间,备注=@备注 where 车号='" & Trim(drOperateCheHao("车号")) & "'"
                        objcommandpassword.Parameters.AddWithValue("@退回时间", sendsomething.getDateTime())
                        objcommandpassword.Parameters.AddWithValue("@备注", drOperate("VEHICLE") & "在停车场的时间为:" & drOperate("in_time") & "至" & drOperate("out_time"))
                        MessageBox.Show("退回事件")
                        System.Windows.Forms.Application.DoEvents()

                        If objconnection.State = ConnectionState.Closed Then
                            objconnection.Open()
                        End If
                        objcommandpassword.ExecuteNonQuery()
                        objconnection.Close()

                        '----------------------------------------------------------------
                        System.Windows.Forms.Application.DoEvents()


                    End If


                Else
                    '---------------------过去3天根本没进过停车场

                    System.Windows.Forms.Application.DoEvents()
                    '---------------------------------------------------------------------------
                    Dim objcommandpassword As New SqlClient.SqlCommand
                    objcommandpassword.Connection = objconnection
                    objcommandpassword.CommandText = "Update TRUCK_QUEUE set 可登记=1,已登记=0,可进厂=0,退回时间=@退回时间,备注=@备注 where 车号='" & Trim(drOperateCheHao("车号")) & "'"
                    objcommandpassword.Parameters.AddWithValue("@退回时间", sendsomething.getDateTime())
                    objcommandpassword.Parameters.AddWithValue("@备注", "停车场3天内查无此车")
                    System.Windows.Forms.Application.DoEvents()

                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objcommandpassword.ExecuteNonQuery()
                    objconnection.Close()

                    '----------------------------------------------------------------
                    System.Windows.Forms.Application.DoEvents()

                End If


      
            System.Windows.Forms.Application.DoEvents()

        Next

        ProcessOutCarTime.Text = "最后一次稽查时间:" & Now


        '--------------------------------------------------------------------------------------------

        'objdataadapter.SelectCommand.CommandText = "select 车号 from TRUCK_QUEUE where 粕类=1 and 已登记=1"
        'If objconnection.State = ConnectionState.Closed Then
        '    objconnection.Open()
        'End If
        'objdataset = New DataSet
        'objdataadapter.Fill(objdataset, "isReserved")

        'objdataview = New DataView(objdataset.Tables("isReserved"))






        'MessageBox.Show("处理后已登记记录数为:" & objdataview.Count - 1, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)





        '' MessageBox.Show(VehicleParkQuit.Rows.Count)


        'If Len(chehao.Text) > 0 And VehicleParkQuit.Rows.Count > 0 Then

        '    
        '    ' 表字段 VEHICLE,exter_no,in_time,out_time（车号，卡号，进门时间，出门时间）


        '    flag_park = VehicleinPark.VehicleInPark("VehicleInPark_yhwebs", Trim(chehao.Text))
        '    If flag_park = 1 Then
        '        MessageBox.Show("当前车辆正位于停车场", "1号接口检测提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Else
        '        MessageBox.Show("当前车辆已离开停车场", "1号接口检测提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    End If

        '    'If isTure() Then
        '    '    MessageBox.Show("当前数据状态有效!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    'Else
        '    '    MessageBox.Show("当前数据状态无效，请更新当前列表!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    'End If
        'Else
        '    MessageBox.Show("无焦点数据或3天内无进出场记录!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        End Try
    End Sub


    Private Sub 稽查ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 稽查ToolStripMenuItem.Click
        Process_OUTTIME_CAR()
    End Sub
End Class
