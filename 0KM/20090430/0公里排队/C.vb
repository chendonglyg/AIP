Public Class CONTROL
    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Dim OK43, Tree_No As Integer
    Dim sendsomething As New SendMessage.CTEnterprisesSoapClient
    Dim VehicleinPark As New LYGPORT_OUTSIDE.Service1SoapClient
    Dim objconnection = New SqlClient.SqlConnection("Data Source= " & Trim("222.189.4.146") & "," & Trim("1433") & ";Initial Catalog = package;User ID=" & "sa" & "; Password=" & "chen dong")

    Dim veh_return, in_date, stre, stre_2, stre_3, phone_no As String
    Dim crytogram, vehicle, externo As String


    'Private Function InsertConsignVehicle()
    '    '车辆申报


    '    Dim insertsomething As New lygport_outside.Service1SoapClient

    '    vehicle = Trim(chehao.Text)
    '    phone_no = Trim(dianhuahaoma.Text)

    '    stre_2 = insertsomething.InsertConsignVehicle("siewn%%iu#$W*insert_yh", vehicle, phone_no)
    '    If stre_2 = "success" Then
    '        MessageBox.Show("车号已报备港口集团!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Else
    '        MessageBox.Show(stre_2, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If

    '    '注意:
    '    '(1)对于传入的参数vehicle，phone_no,均不能为空
    '    '(2)当strE返回的是success表明申报成功
    '    '        未申报成功原因请参照strE返回值的内容()
    '    Return stre_2
    'End Function

    'Private Function UpdateConsignVehicle()
    '    '车辆放行
    '    Dim updatesomething As New lygport_outside.Service1SoapClient
    '    stre_3 = updatesomething.UpdateConsignVehicle("ygygdn%hjiu**W*update_yh", Trim(chehao.Text))

    '    If stre_3 = "success" Then
    '        MessageBox.Show("通行证已开始启用，请到隔壁进行绑定后方可入港！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Else
    '        MessageBox.Show(stre_3, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    '    Return stre_3
    'End Function

    '-----------------以上两个配卡放行的过程最终决定依然不放在调度环节，还是放在停车场比较合适，因为停车场可以清楚知道车牌颜色.

    Private Sub C_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        yidengji.AllowUserToAddRows = False '消除最后一行
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        If private_data = "C" Then
            TreeView1.Enabled = True
            TreeView2.Enabled = False
        End If
        If private_data = "C1" Then
            TreeView1.Enabled = False
            TreeView2.Enabled = True
        End If


        If private_data = "A" Then
            'VehicleBack.Enabled = True
            C3.Enabled = True
        End If

    End Sub
    Private Sub clearall()
        For Each c As Windows.Forms.Control In Me.jichuxinxi.Controls
            If TypeOf c Is Windows.Forms.ComboBox Then
                c.Text = "请选择"
            ElseIf TypeOf c Is Windows.Forms.TextBox Then
                c.Text = "0"
            End If
        Next

        IDID.Text = ""


    End Sub
    Private Sub showall()
        clearall()

        On Error Resume Next
        If Tree_No = 2 Then

            If TreeView2.SelectedNode.Text = "已登记车辆" Then
                Dim objcommandpassword As New SqlClient.SqlCommand
                objcommandpassword.Connection = objconnection
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  油脂=1  and 已登记=1 order by 登记时间"

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "kedengji")

                objdataview = New DataView(objdataset.Tables("kedengji"))
                yidengji.ContextMenuStrip = Oil
                yidengji.DataSource = objdataview
                box2.Text = "已登记油脂类车辆"
            End If


            '----------------------------------------------------------------------------------

            If TreeView1.SelectedNode.Text = "已登记新货类车辆" Then
                Dim objcommandpassword As New SqlClient.SqlCommand
                objcommandpassword.Connection = objconnection
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 粕类=1 and 自派车 <>1 and 已登记=1 and 货物名称 not in (select LimitName from TRUCK_QUEUE_LimitName_OTHER) and 货物名称 not in (select LimitName from TRUCK_QUEUE_LimitName) and 货物名称 not in (select LimitName from TRUCK_QUEUE_LimitName_BULKLOAD) and 可登记=0 order by 登记时间"

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "OTHER")

                objdataview = New DataView(objdataset.Tables("OTHER"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C2
                box2.Text = "已登记新货类车辆"

            End If


            '------------------------------------------------------------------------------

            '-------------------------------------------------------------------
            If TreeView2.SelectedNode.Text = "可进厂车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 可进厂=1 and 油脂=1 order by 进厂时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "kejinchang")

                objdataview = New DataView(objdataset.Tables("kejinchang"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C3
                box2.Text = "可进厂车辆"
            End If
            '-----------------------------------------------------------------------------------------
            If TreeView2.SelectedNode.Text = "已完成车辆" Then
                objdataadapter.SelectCommand.CommandText = "select top 100 * from TRUCK_QUEUE_BAK where 已完成=1 and 油脂=1 order by 完成时间 desc"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "yiwancheng")

                objdataview = New DataView(objdataset.Tables("yiwancheng"))
                yidengji.ContextMenuStrip = Nothing
                yidengji.DataSource = objdataview
                box2.Text = "已完成车辆"

            End If
            '---------------------------------------------------------------------------------------
            If TreeView2.SelectedNode.Text = "超时车辆" Then
                objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 可进厂=1 and  datediff(n,进厂时间,getdate())>120 and 油脂=1 order by 进厂时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "chaoshi")

                objdataview = New DataView(objdataset.Tables("chaoshi"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C3
                box2.Text = "超时车辆"

            End If

            '------------------------------------------------------------------------------------------
            If TreeView2.SelectedNode.Text = "退回车辆" Then
                objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 已退回=1 and 油脂=1 order by 进厂时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "tuihui")

                objdataview = New DataView(objdataset.Tables("tuihui"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = Nothing
                box2.Text = "退回车辆"

            End If
            '------------------------------===========================================

        End If

        If Tree_No = 1 Then

            If TreeView1.SelectedNode.Text = "已登记预约车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 粕类=1 and 已登记=1 and isReserved=1  order by 登记时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "isReserved")
                yidengji.ContextMenuStrip = C2
                objdataview = New DataView(objdataset.Tables("isReserved"))
                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = Nothing
                box2.Text = "已登记预约车辆"
            End If




            If TreeView1.SelectedNode.Text = "已登记卸货车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  粕类=1 and 是否卸车=1 and 已登记=1 order by 登记时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "xiehuo")

                objdataview = New DataView(objdataset.Tables("xiehuo"))
                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C1
                box2.Text = "已登记卸货车辆"
            End If


            If TreeView1.SelectedNode.Text = "已登记43%粕车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where   粕类=1 and 自派车 <>1 and 已登记=1 and 货物名称 in (select LimitName from TRUCK_QUEUE_LimitName) order by 登记时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "yidengji")

                objdataview = New DataView(objdataset.Tables("yidengji"))

                If objdataview.Count > 0 Then
                    OK43 = objdataview.Item(0).Item(0)
                End If
                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C1
            End If

  
            '--------------------------------------------------------------------------

            If TreeView1.SelectedNode.Text = "已登记散货类车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  (粕类=1 and 自派车 <>1 and 已登记=1 and 货物名称 in (select LimitName from TRUCK_QUEUE_LimitName_BULKLOAD) and 可登记=0  order by 登记时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "yidengji")

                objdataview = New DataView(objdataset.Tables("yidengji"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C2
            End If
        

            '---------------------------------------------------------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "已登记其他类车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  (粕类=1 and 自派车 <>1 and 已登记=1 and 货物名称 in (select LimitName from TRUCK_QUEUE_LimitName) and 可登记=0  order by 登记时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "yidengji")

                objdataview = New DataView(objdataset.Tables("yidengji"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C2
            End If
            '-------------------------------------------------------------------

            '-------------------------------------
            If TreeView1.SelectedNode.Text = "已登记自派车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 粕类=1 and 自派车=1 and 已登记=1  order by 登记时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "yidengji")

                objdataview = New DataView(objdataset.Tables("yidengji"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C4
            End If
            '-------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "可进厂车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 粕类=1 and 可进厂=1 order by 进厂时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "kejinchang")

                objdataview = New DataView(objdataset.Tables("kejinchang"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C3
            End If
            '--------------------------------------
            If TreeView1.SelectedNode.Text = "已完成车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE_BAK where 粕类=1 and 已完成=1 order by 完成时间 desc"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "yiwancheng")

                objdataview = New DataView(objdataset.Tables("yiwancheng"))

                yidengji.DataSource = objdataview

            End If
            '---------------------------------------------------------------------------------------
            '---------------------------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "超时车辆" Then
                objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where  粕类=1 and Overtimeflag=1 order by 进厂时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "chaoshi")

                objdataview = New DataView(objdataset.Tables("chaoshi"))

                yidengji.DataSource = objdataview

                box2.Text = "超时车辆"

            End If

            '------------------------------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "退回车辆" Then
                objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where  粕类=1 and 已退回=1 order by 进厂时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "tuihui")

                objdataview = New DataView(objdataset.Tables("tuihui"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = Nothing
                box2.Text = "退回车辆"

            End If

            '-------------------------------------------------------------------------------------------
        End If
        objconnection.Close()




    End Sub

    Private Sub yidengji_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles yidengji.CellContentClick
        On Error Resume Next
        kehumingcheng.Text = Trim(yidengji.Rows(e.RowIndex).Cells(1).Value)
        IDID.Text = Trim(yidengji.Rows(e.RowIndex).Cells(0).Value)
        shuliang.Text = Trim(yidengji.Rows(e.RowIndex).Cells(5).Value)
        pinming.Text = Trim(yidengji.Rows(e.RowIndex).Cells(2).Value)
        tidanhao.Text = Trim(yidengji.Rows(e.RowIndex).Cells(3).Value)
        chehao.Text = Trim(yidengji.Rows(e.RowIndex).Cells(6).Value)
        dianhuahaoma.Text = Trim(yidengji.Rows(e.RowIndex).Cells(7).Value)
        beizhu.Text = Trim(yidengji.Rows(e.RowIndex).Cells(17).Value)
        pici.Text = Trim(yidengji.Rows(e.RowIndex).Cells(22).Value)
    End Sub







    Private Sub 粕可进厂ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 粕可进厂ToolStripMenuItem.Click




        If isTure() Then '判断这个车是否还是处于可放行状态，避免其他同界面重复操作

            Dim a As String
            Dim VehicleParkQuit As New DataTable
            a = VehicleinPark.VehiclePark(VehicleParkQuit, "VehiclePark_yhwebs", Trim(chehao.Text), 3)

            If VehicleParkQuit.Rows.Count > 0 Then '判断过去72小时是否进出入过，抓作弊和避免系统错误



                Dim drOperate As DataRow = VehicleParkQuit.Rows(0)





                If Val(IDID.Text) = OK43 And (Len(IDID.Text) > 0) Then
                    'Dim flag_park As String

                    'flag_park = VehicleinPark.VehicleInPark("VehicleInPark_yhwebs", Trim(chehao.Text))

                    'If flag_park = 1 Then  '车辆在停车场，将按照正常程序放行进厂

                    'If (Len(IDID.Text) > 0) Then '启用它即可任何车辆放行，无需排队

                    If Len(drOperate("out_time").ToString) = 0 Then '说明车还在停车场，没有乱跑



                        Dim objcommandpassword As New SqlClient.SqlCommand
                        objcommandpassword.Connection = objconnection
                        objcommandpassword.CommandText = "Update TRUCK_QUEUE set 可登记=0,已登记=0,可进厂=1,进厂时间=@进厂时间 where 已登记=1 and 车号='" & Trim(chehao.Text) & "'" '--------------------只要放管制车辆，那么该车号所有其他非管制货物也将全部放行
                        objcommandpassword.Parameters.AddWithValue("@进厂时间", sendsomething.getDateTime())

                        If objconnection.State = ConnectionState.Closed Then
                            objconnection.Open()
                        End If

                        objcommandpassword.ExecuteNonQuery()
                        objconnection.Close()
                        MessageBox.Show("已放行受排队管制的车辆!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        sendsomething.sendOneMessage(Trim(dianhuahaoma.Text), "<<进厂装货提醒>>" & Trim(kehumingcheng.Text) & "," & Trim(pinming.Text) & ",提单量:" & Trim(shuliang.Text) & "吨," & Trim(chehao.Text) & "," & "可进厂装货!", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

                        showall()
                        clearall()
                    Else 'outtime字段带值了，显然车跑了
                        Dim objcommandpassword As New SqlClient.SqlCommand
                        objcommandpassword.Connection = objconnection
                        objcommandpassword.CommandText = "Update TRUCK_QUEUE set 可登记=1,已登记=0,可进厂=0,已退回=1,退回时间=@退回时间,备注=@备注 where 已登记=1 and 车号='" & Trim(chehao.Text) & "'"
                        objcommandpassword.Parameters.AddWithValue("@退回时间", sendsomething.getDateTime())
                        objcommandpassword.Parameters.AddWithValue("@备注", drOperate("VEHICLE") & "在停车场的时间为:" & drOperate("in_time") & "至" & drOperate("out_time"))

                        If objconnection.State = ConnectionState.Closed Then
                            objconnection.Open()
                        End If

                        objcommandpassword.ExecuteNonQuery()
                        objconnection.Close()


                        MessageBox.Show("因未放行前车辆就已离开停车场,离开时间为:" & drOperate("out_time") & ",该车辆被强制退回至可登记状态!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)



                        sendsomething.sendOneMessage(Trim(dianhuahaoma.Text), "<<车辆退回提醒>>" & Trim(kehumingcheng.Text) & "," & Trim(pinming.Text) & ",提单量:" & Trim(shuliang.Text) & "吨," & Trim(chehao.Text) & "," & "因未放行前车辆就已离开停车场，故请重新登记排队!", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

                        showall()
                        clearall()

                    End If  '在不在停车场或出没出停车场的结束语句



                Else
                    MessageBox.Show("禁止插队/没有可操作记录", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If  '有没有插队的结束语句


                'Catch ex As Exception
                '    MessageBox.Show(ex.Message)
                'End Try

            Else  '3天内都没数据，太假了

                Dim objcommandpassword As New SqlClient.SqlCommand
                objcommandpassword.Connection = objconnection
                objcommandpassword.CommandText = "Update TRUCK_QUEUE set 可登记=1,已登记=0,可进厂=0,已退回=1,退回时间=@退回时间,备注=@备注 where 已登记=1 and 车号='" & Trim(chehao.Text) & "'"
                objcommandpassword.Parameters.AddWithValue("@退回时间", sendsomething.getDateTime())
                objcommandpassword.Parameters.AddWithValue("@备注", "过去72小时内该车无任何进出记录")

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommandpassword.ExecuteNonQuery()
                objconnection.Close()


                MessageBox.Show("过去72小时内该车无任何进出记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)



                sendsomething.sendOneMessage(Trim(dianhuahaoma.Text), "<<车辆退回提醒>>" & Trim(kehumingcheng.Text) & "," & Trim(pinming.Text) & ",提单量:" & Trim(shuliang.Text) & "吨," & Trim(chehao.Text) & "," & "过去72小时内该车无任何进出记录！", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

                showall()
                clearall()

            End If  '72小时根本无任何进出记录，作弊！！

        Else
            MessageBox.Show("当前数据状态已经改变，请更新列表后再操作!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If '有没有重复操作的结束语句






    End Sub

    Private Sub 其他货物可进厂ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 其他货物可进厂ToolStripMenuItem.Click
        Dim a As String
        Dim VehicleParkQuit As New DataTable
        a = VehicleinPark.VehiclePark(VehicleParkQuit, "VehiclePark_yhwebs", Trim(chehao.Text), 3)

        If VehicleParkQuit.Rows.Count > 0 Then '判断过去72小时是否进出入过，抓作弊和避免系统错误



            Dim drOperate As DataRow = VehicleParkQuit.Rows(0)



            If (Len(IDID.Text) > 0) Then
                Dim tidanliang As Integer


                tidanliang = Val(shuliang.Text) '数量判断变量，很重要



                'Dim flag_park As String

                'flag_park = VehicleinPark.VehicleInPark("VehicleInPark_yhwebs", Trim(chehao.Text))

                'If flag_park = 1 Then  '车辆在停车场，将按照正常程序放行进厂

                If Len(drOperate("out_time").ToString) = 0 Then

                    If tidanliang >= 20 Then

                        Dim objcommandpassword As New SqlClient.SqlCommand
                        objcommandpassword.Connection = objconnection
                        objcommandpassword.CommandText = "Update TRUCK_QUEUE set 可登记=0,已登记=0,可进厂=1,进厂时间=@进厂时间  where 已登记=1 and 车号='" & Trim(chehao.Text) & "'"
                        objcommandpassword.Parameters.AddWithValue("@进厂时间", sendsomething.getDateTime())

                        If objconnection.State = ConnectionState.Closed Then
                            objconnection.Open()
                        End If

                        objcommandpassword.ExecuteNonQuery()
                        objconnection.Close()
                        MessageBox.Show("超过20吨的货（可能含A类货)放行完成!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        sendsomething.sendOneMessage(Trim(dianhuahaoma.Text), "<<进厂装货提醒>>" & Trim(kehumingcheng.Text) & "," & Trim(pinming.Text) & ",提单量:" & Trim(shuliang.Text) & "吨," & Trim(chehao.Text) & "," & "可进厂装货!", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

                        showall()
                        clearall()
                    Else


                        '-------------------------------------------------不足20吨的货物处理----------------------------------------------------------------------------

                        objdataadapter.SelectCommand.CommandText = "Select * from TRUCK_QUEUE where 车号='" & Trim(chehao.Text) & "' and 导入批次='" & Trim(pici.Text) & "' and ( 货物名称 in (select LimitName from TRUCK_QUEUE_LimitName))"
                        If objconnection.State = ConnectionState.Closed Then
                            objconnection.Open()
                        End If
                        objdataset = New DataSet
                        objdataadapter.Fill(objdataset, "LimitName")
                        objdataview = New DataView(objdataset.Tables("LimitName"))

                        If objdataview.Count >= 1 Then
                            MessageBox.Show("当前货物不足20吨且该车含A类货（如：42,43,46等),需从强制排队界面放行!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            GoTo iSLimit
                        Else '虽然小于20吨，但是并没有A类货物，所以全部放行

                            Dim objcommandpassword As New SqlClient.SqlCommand
                            objcommandpassword.Connection = objconnection
                            objcommandpassword.CommandText = "Update TRUCK_QUEUE set 可登记=0,已登记=0,可进厂=1,进厂时间=@进厂时间  where 车号='" & Trim(chehao.Text) & "'"
                            objcommandpassword.Parameters.AddWithValue("@进厂时间", sendsomething.getDateTime())

                            If objconnection.State = ConnectionState.Closed Then
                                objconnection.Open()
                            End If

                            objcommandpassword.ExecuteNonQuery()
                            objconnection.Close()
                            MessageBox.Show("低于20吨的B类货放行完成!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            sendsomething.sendOneMessage(Trim(dianhuahaoma.Text), "<<进厂装货提醒>>" & Trim(kehumingcheng.Text) & "," & Trim(pinming.Text) & ",提单量:" & Trim(shuliang.Text) & "吨," & Trim(chehao.Text) & "," & "可进厂装货!", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

                            showall()
                            clearall()

                        End If '低于20吨范围中有无A类货的判断结束语句



                    End If  '是否超过20吨的结束语句



                    '-----------------------------------------------------------------车辆确定没有拉关键货物，可以放行该车的所有数据--------------------------------------------------------------------


                Else '否则说明不在停车场，立刻踢回可登记


                    Dim objcommandpassword As New SqlClient.SqlCommand
                    objcommandpassword.Connection = objconnection
                    objcommandpassword.CommandText = "Update TRUCK_QUEUE set 可登记=1,已登记=0,可进厂=0,退回时间=@退回时间,备注=@备注 where 车号='" & Trim(chehao.Text) & "'"
                    objcommandpassword.Parameters.AddWithValue("@退回时间", sendsomething.getDateTime())
                    objcommandpassword.Parameters.AddWithValue("@备注", drOperate("VEHICLE") & "在停车场的时间为:" & drOperate("in_time") & "至" & drOperate("out_time"))

                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objcommandpassword.ExecuteNonQuery()
                    objconnection.Close()




                    MessageBox.Show("该车在过去3天内无进出停车场记录，所以该车辆将被强制退回至可登记状态!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    sendsomething.sendOneMessage(Trim(dianhuahaoma.Text), "<<车辆退回提醒>>" & Trim(kehumingcheng.Text) & "," & Trim(pinming.Text) & ",提单量:" & Trim(shuliang.Text) & "吨," & Trim(chehao.Text) & "," & "因未放行前车辆就已离开停车场，故请重新登记排队!", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

                    showall()
                    clearall()


                End If '没有在停车场的结束记录


        


        Else
            MessageBox.Show("没有可操作记录", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If  '没有选择记录的结束语句


        Else


            Dim objcommandpassword As New SqlClient.SqlCommand
            objcommandpassword.Connection = objconnection
            objcommandpassword.CommandText = "Update TRUCK_QUEUE set 可登记=1,已登记=0,可进厂=0,已退回=1,退回时间=@退回时间 where 已登记=1 and 车号='" & Trim(chehao.Text) & "'"
            objcommandpassword.Parameters.AddWithValue("@退回时间", sendsomething.getDateTime())

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objcommandpassword.ExecuteNonQuery()
            objconnection.Close()


            MessageBox.Show("过去72小时内该车无任何进出记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)



            sendsomething.sendOneMessage(Trim(dianhuahaoma.Text), "<<车辆退回提醒>>" & Trim(kehumingcheng.Text) & "," & Trim(pinming.Text) & ",提单量:" & Trim(shuliang.Text) & "吨," & Trim(chehao.Text) & "," & "过去72小时内该车无任何进出记录！", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

            showall()
            clearall()
        End If


iSLimit:



    End Sub




    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try


            Dim objcommandpassword As New SqlClient.SqlCommand
            objcommandpassword.Connection = objconnection
            objcommandpassword.CommandText = "Update TRUCK_QUEUE set 可登记=0,已登记=0,可进厂=0,已完成=1,完成时间=@完成时间" & " where id=" & Val(IDID.Text)
            objcommandpassword.Parameters.AddWithValue("@完成时间", sendsomething.getDateTime())

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objcommandpassword.ExecuteNonQuery()
            objconnection.Close()
            MessageBox.Show("装车已完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            showall()
            clearall()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub 车辆退回ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehicleBack.Click
        Try


            Dim objcommandpassword As New SqlClient.SqlCommand
            objcommandpassword.Connection = objconnection
            objcommandpassword.CommandText = "Update TRUCK_QUEUE set 可登记=1,已登记=0,可进厂=0,已退回=1,退回时间=@退回时间" & " where id=" & Val(IDID.Text)
            objcommandpassword.Parameters.AddWithValue("@退回时间", sendsomething.getDateTime())

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objcommandpassword.ExecuteNonQuery()
            objconnection.Close()
            MessageBox.Show("车辆已退回,需贸易开票处重新计划！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)
            showall()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Try
            If (Len(IDID.Text) > 0) Then

                Dim objcommandpassword As New SqlClient.SqlCommand
                objcommandpassword.Connection = objconnection
                objcommandpassword.CommandText = "Update TRUCK_QUEUE set 可登记=0,已登记=0,可进厂=1,进厂时间=@进厂时间" & " where 已登记=1 and 车号='" & Trim(chehao.Text) & "'"
                objcommandpassword.Parameters.AddWithValue("@进厂时间", sendsomething.getDateTime())

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommandpassword.ExecuteNonQuery()
                objconnection.Close()
                MessageBox.Show("自派车放行完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)


                sendsomething.sendOneMessage(Trim(dianhuahaoma.Text), "<<进厂装货提醒>>" & Trim(kehumingcheng.Text) & "," & Trim(pinming.Text) & ",提单量:" & Trim(shuliang.Text) & "吨," & Trim(chehao.Text) & "," & "可进厂装货!", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

                showall()
                clearall()
            Else
                MessageBox.Show("没有可操作记录", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

        Try

 
        clearall()

        Tree_No = 1
        TreeView2.SelectedNode = Nothing

        If TreeView1.SelectedNode.Text = "已登记预约车辆" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 粕类=1 and 已登记=1 and isReserved=1  order by 登记时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "isReserved")

            objdataview = New DataView(objdataset.Tables("isReserved"))
            yidengji.DataSource = objdataview
            yidengji.ContextMenuStrip = isReserved
            box2.Text = "已登记预约车辆"
        End If



        '----------------------------------------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "已登记卸货车辆" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where   粕类=1 and 是否卸车=1 and 已登记=1  order by 登记时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "xiehuo")

            objdataview = New DataView(objdataset.Tables("xiehuo"))
            yidengji.DataSource = objdataview
            yidengji.ContextMenuStrip = C5
            box2.Text = "已登记卸货车辆"
        End If

        '----------------------------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "已登记43%粕车辆" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 粕类=1 and 自派车 <>1 and 已登记=1  and 货物名称 in (select LimitName from TRUCK_QUEUE_LimitName) order by 登记时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "yidengji")

            objdataview = New DataView(objdataset.Tables("yidengji"))

            If objdataview.Count > 0 Then
                OK43 = objdataview.Item(0).Item(0)
            End If
            yidengji.DataSource = objdataview
            yidengji.ContextMenuStrip = C1
            box2.Text = "已登记43%粕车辆"
        End If
        '--------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "已登记其他类车辆" Then
                Dim objcommandpassword As New SqlClient.SqlCommand
                objcommandpassword.Connection = objconnection
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 粕类=1 and 自派车 <>1 and 已登记=1 and 货物名称 in (select LimitName from TRUCK_QUEUE_LimitName_OTHER) and 可登记=0 order by 登记时间"

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "OTHER")

                objdataview = New DataView(objdataset.Tables("OTHER"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C2
                box2.Text = "已登记其他类车辆"

            End If
            '------------------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "已登记散货类车辆" Then
                Dim objcommandpassword As New SqlClient.SqlCommand
                objcommandpassword.Connection = objconnection
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 粕类=1 and 自派车 <>1 and 已登记=1 and 货物名称 in (select LimitName from TRUCK_QUEUE_LimitName_BULKLOAD) and 可登记=0 order by 登记时间"

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "BULKLOAD")

                objdataview = New DataView(objdataset.Tables("BULKLOAD"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C2
                box2.Text = "已登记散货类车辆"

            End If
            '------------------------------------------------------------------------------



            If TreeView1.SelectedNode.Text = "已登记新货类车辆" Then
                Dim objcommandpassword As New SqlClient.SqlCommand
                objcommandpassword.Connection = objconnection
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 粕类=1 and 自派车 <>1 and 已登记=1 and 货物名称 not in (select LimitName from TRUCK_QUEUE_LimitName_OTHER) and 货物名称 not in (select LimitName from TRUCK_QUEUE_LimitName) and 货物名称 not in (select LimitName from TRUCK_QUEUE_LimitName_BULKLOAD) and 可登记=0 order by 登记时间"

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "OTHER")

                objdataview = New DataView(objdataset.Tables("OTHER"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C2
                box2.Text = "已登记新货类车辆"

            End If


            '------------------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "已登记小型类车辆" Then
                Dim objcommandpassword As New SqlClient.SqlCommand
                objcommandpassword.Connection = objconnection
                '  objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 粕类=1 and 自派车 <>1 and 已登记=1 and 货物名称 not in (select LimitName from TRUCK_QUEUE_LimitName_OTHER) and 货物名称 not in (select LimitName from TRUCK_QUEUE_LimitName) and 货物名称 not in (select LimitName from TRUCK_QUEUE_LimitName_BULKLOAD) and 可登记=0 order by 登记时间"
                objdataadapter.SelectCommand.CommandText = "Select * From TRUCK_QUEUE Where 提单数量<=20 and 车号 In (Select 车号 From TRUCK_QUEUE where 已登记=1 Group By 车号 Having Count(*)=1)"


                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "OTHER")

                objdataview = New DataView(objdataset.Tables("OTHER"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C2
                box2.Text = "已登记新货类车辆"

            End If
            '----------------------------------------------------------------------------------------------






            If TreeView1.SelectedNode.Text = "已登记自派车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  粕类=1 and 自派车=1 and 已登记=1  order by 登记时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "yidengji")

                objdataview = New DataView(objdataset.Tables("yidengji"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C4
                box2.Text = "已登记自派车辆"
            End If
        '-------------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "可进厂车辆" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  粕类=1 and 可进厂=1 order by 进厂时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "kejinchang")

            objdataview = New DataView(objdataset.Tables("kejinchang"))

            yidengji.DataSource = objdataview
            yidengji.ContextMenuStrip = C3
            box2.Text = "可进厂车辆"
        End If
        '-----------------------------------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "已完成车辆" Then
            objdataadapter.SelectCommand.CommandText = "select top 100 * from TRUCK_QUEUE_BAK where  粕类=1 and 已完成=1  order by 完成时间 desc"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "yiwancheng1")

            objdataview = New DataView(objdataset.Tables("yiwancheng1"))
            yidengji.ContextMenuStrip = Nothing
            yidengji.DataSource = objdataview
            box2.Text = "已完成车辆"

        End If
        '---------------------------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "超时车辆" Then
                objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where  粕类=1 and Overtimeflag=1 order by 进厂时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "chaoshi")

                objdataview = New DataView(objdataset.Tables("chaoshi"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = C3
                box2.Text = "超时车辆"

            End If

        '------------------------------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "退回车辆" Then
                objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where  粕类=1 and 已退回=1 order by 进厂时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "tuihui")

                objdataview = New DataView(objdataset.Tables("tuihui"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = Nothing
                box2.Text = "退回车辆"

            End If

        '-------------------------------------------------------------------------------------------



        yidengji.Columns(0).Width = 0
        objconnection.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

  

    Private Sub chaxun_KeyDown(sender As Object, e As KeyEventArgs) Handles chaxun.KeyDown
        Try

      
        clearall()

        If e.KeyCode = Keys.Enter Then


            If TreeView1.SelectedNode.Text = "已登记预约车辆" Then
                objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 粕类=1 and 已登记=1 and isReserved=1and 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "isReserved")
                yidengji.ContextMenuStrip = isReserved
                objdataview = New DataView(objdataset.Tables("isReserved"))
                yidengji.DataSource = objdataview

                box2.Text = "已登记预约车辆"
            End If


                '--------------------------------------------------------------------------------------------------
                If TreeView1.SelectedNode.Text = "已登记卸货车辆" Then
                    objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  粕类=1 and 是否卸车=1 and 已登记=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objdataset = New DataSet
                    objdataadapter.Fill(objdataset, "xiehuo")

                    objdataview = New DataView(objdataset.Tables("xiehuo"))
                    yidengji.DataSource = objdataview
                    yidengji.ContextMenuStrip = C1
                    box2.Text = "已登记卸货车辆"
                End If

                '----------------------------------------------------------------------------------- 43,46,47不给查询，一查就会影响放插队机制


                If TreeView1.SelectedNode.Text = "已登记其他类车辆" Then
                    objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 粕类=1 and 自派车 <>1 and 已登记=1 and 货物名称 in (select LimitName from TRUCK_QUEUE_LimitName_OTHER) and 车号 like '%" & Trim(chaxun.Text) & "%'"
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objdataset = New DataSet
                    objdataadapter.Fill(objdataset, "yidengji")

                    objdataview = New DataView(objdataset.Tables("yidengji"))

                    yidengji.DataSource = objdataview
                    box2.Text = "已登记其他类车辆"
                End If
                '----------------------------------------------------------

                If TreeView1.SelectedNode.Text = "已登记散货类车辆" Then
                    objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 粕类=1 and 自派车 <>1 and 已登记=1 and 货物名称 in (select LimitName from TRUCK_QUEUE_LimitName_BULKOTHER) and 车号 like '%" & Trim(chaxun.Text) & "%'"
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objdataset = New DataSet
                    objdataadapter.Fill(objdataset, "yidengji")

                    objdataview = New DataView(objdataset.Tables("yidengji"))

                    yidengji.DataSource = objdataview
                    box2.Text = "已登记散货类车辆"
                End If
                '----------------------------------------------------------

                If TreeView1.SelectedNode.Text = "已登记新货类车辆" Then
                    Dim objcommandpassword As New SqlClient.SqlCommand
                    objcommandpassword.Connection = objconnection
                    objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 粕类=1 and 自派车 <>1 and 已登记=1 and 货物名称 not in (select LimitName from TRUCK_QUEUE_LimitName_OTHER) and 货物名称 not in (select LimitName from TRUCK_QUEUE_LimitName) and 货物名称 not in (select LimitName from TRUCK_QUEUE_LimitName_BULKLOAD) and 可登记=0 and 车号 like '%" & Trim(chaxun.Text) & "%'"

                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objdataset = New DataSet
                    objdataadapter.Fill(objdataset, "OTHER")

                    objdataview = New DataView(objdataset.Tables("OTHER"))

                    yidengji.DataSource = objdataview
                    yidengji.ContextMenuStrip = C2
                    box2.Text = "已登记新货类车辆"

                End If


                '------------------------------------------------------------------------------

                If TreeView1.SelectedNode.Text = "已登记自派车辆" Then
                    objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  粕类=1 and 自派车=1 and 已登记=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objdataset = New DataSet
                    objdataadapter.Fill(objdataset, "kejinchang")

                    objdataview = New DataView(objdataset.Tables("kejinchang"))

                    yidengji.DataSource = objdataview
                    box2.Text = "已登记自派车辆"
                End If
                '--------------------------------------------------------------
                If TreeView1.SelectedNode.Text = "可进厂车辆" Then
                    objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  可进厂=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objdataset = New DataSet
                    objdataadapter.Fill(objdataset, "yiwancheng")

                    objdataview = New DataView(objdataset.Tables("yiwancheng"))

                    yidengji.DataSource = objdataview
                    box2.Text = "可进厂车辆"
                End If
                '-----------------------------------------------------------------------------------------------------
                If TreeView1.SelectedNode.Text = "已完成车辆" Then
                    objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE_BAK where  已完成=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objdataset = New DataSet
                    objdataadapter.Fill(objdataset, "chaoshi")

                    objdataview = New DataView(objdataset.Tables("chaoshi"))

                    yidengji.DataSource = objdataview

                    box2.Text = "已完成车辆"

                End If
                '------------------------------------------------------------------------------------------
                If TreeView1.SelectedNode.Text = "超时车辆" Then
                    objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where  可进厂=1 and Overtimeflag=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objdataset = New DataSet
                    objdataadapter.Fill(objdataset, "tuihui")

                    objdataview = New DataView(objdataset.Tables("tuihui"))

                    yidengji.DataSource = objdataview
                    yidengji.ContextMenuStrip = Nothing
                    box2.Text = "超时车辆"

                End If




                '-------------------------------------------------------------------------------------------
                If TreeView1.SelectedNode.Text = "退回车辆" Then
                    objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 已退回=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objdataset = New DataSet
                    objdataadapter.Fill(objdataset, "tuihui")

                    objdataview = New DataView(objdataset.Tables("tuihui"))

                    yidengji.DataSource = objdataview
                    yidengji.ContextMenuStrip = Nothing
                    box2.Text = "退回车辆"

                End If
                '-------------------------------------------------------------------

                '---------------------------------------------------------------------------------------------------------------------
                yidengji.Columns(0).Width = 0
                objconnection.Close()


            End If



            '-------------------------------------------------------------------------------------///////////////////////////////////////////////////////////22222222
        Catch ex As Exception
            MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        End Try

    End Sub

  

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Try
            If (Len(IDID.Text) > 0) Then

                Dim objcommandpassword As New SqlClient.SqlCommand
                objcommandpassword.Connection = objconnection
                objcommandpassword.CommandText = "Update TRUCK_QUEUE set 可登记=0,已登记=0,可进厂=1,进厂时间=@进厂时间" & " where id=" & Val(IDID.Text)
                objcommandpassword.Parameters.AddWithValue("@进厂时间", sendsomething.getDateTime())

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommandpassword.ExecuteNonQuery()
                objconnection.Close()
                MessageBox.Show("卸货车辆进厂操作设置完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                sendsomething.sendOneMessage(Trim(dianhuahaoma.Text), "<<进厂卸货提醒>>" & Trim(kehumingcheng.Text) & "," & Trim(pinming.Text) & ",提单量:" & Trim(shuliang.Text) & "吨," & Trim(chehao.Text) & "," & "可进厂卸货!", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

                showall()
                clearall()
            Else
                MessageBox.Show("没有可操作记录", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    


    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        'Try
        If (Len(IDID.Text) > 0) Then

            Dim objcommandpassword As New SqlClient.SqlCommand
            objcommandpassword.Connection = objconnection
            objcommandpassword.CommandText = "Update TRUCK_QUEUE set 可登记=0,已登记=0,可进厂=1,进厂时间=@进厂时间" & " where id=" & Val(IDID.Text)
            objcommandpassword.Parameters.AddWithValue("@进厂时间", sendsomething.getDateTime())

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objcommandpassword.ExecuteNonQuery()
            objconnection.Close()
            MessageBox.Show("油脂货物车辆设置完成", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            sendsomething.sendOneMessage(Trim(dianhuahaoma.Text), "<<进厂装货提醒>>" & Trim(kehumingcheng.Text) & "," & Trim(pinming.Text) & ",提单量:" & Trim(shuliang.Text) & "吨," & Trim(chehao.Text) & "," & "可进厂装货!", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

            showall()
            clearall()
        Else
            MessageBox.Show("没有可操作记录", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        ' Catch ex As Exception
        'MessageBox.Show(ex.Message)
        '  End Try
    End Sub

    
    Private Sub TreeView3_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView3.AfterSelect
        Tree_No = 3
        clearall()
    End Sub

   
  
   

    Private Sub TreeView2_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView2.AfterSelect
        clearall()
        Tree_No = 2
        TreeView1.SelectedNode = Nothing
        On Error Resume Next
        If TreeView2.SelectedNode.Text = "已登记车辆" Then
            Dim objcommandpassword As New SqlClient.SqlCommand
            objcommandpassword.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  油脂=1  and 已登记=1 order by 登记时间"

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "kedengji")

            objdataview = New DataView(objdataset.Tables("kedengji"))
            yidengji.ContextMenuStrip = Oil
            yidengji.DataSource = objdataview
            box2.Text = "已登记油脂类车辆"
        End If


        '----------------------------------------------------------------------------------


        '-------------------------------------------------------------------
        If TreeView2.SelectedNode.Text = "可进厂车辆" Then
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 可进厂=1 and 油脂=1 order by 进厂时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "kejinchang")

            objdataview = New DataView(objdataset.Tables("kejinchang"))

            yidengji.DataSource = objdataview
            yidengji.ContextMenuStrip = C3
            box2.Text = "可进厂车辆"
        End If
        '-----------------------------------------------------------------------------------------
        If TreeView2.SelectedNode.Text = "已完成车辆" Then

            objdataadapter.SelectCommand.CommandText = "select top 100 * from TRUCK_QUEUE_BAK where 已完成=1 and 油脂=1 order by 完成时间 desc"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "yiwancheng2")

            objdataview = New DataView(objdataset.Tables("yiwancheng2"))
            yidengji.ContextMenuStrip = Nothing
            yidengji.DataSource = objdataview
            box2.Text = "已完成车辆"

        End If
        '---------------------------------------------------------------------------------------
        If TreeView2.SelectedNode.Text = "--超时车辆" Then
            objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 可进厂=1 and  datediff(n,进厂时间,getdate())>120 and 油脂=1 order by 进厂时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "chaoshi")

            objdataview = New DataView(objdataset.Tables("chaoshi"))

            yidengji.DataSource = objdataview
            yidengji.ContextMenuStrip = C3
            box2.Text = "超时车辆"

        End If

        '------------------------------------------------------------------------------------------
        If TreeView2.SelectedNode.Text = "--退回车辆" Then
            objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 已退回=1 and 油脂=1 order by 进厂时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "tuihui")

            objdataview = New DataView(objdataset.Tables("tuihui"))

            yidengji.DataSource = objdataview
            yidengji.ContextMenuStrip = Nothing
            box2.Text = "退回车辆"

        End If

        '-------------------------------------------------------------------------------------------



        yidengji.Columns(0).Width = 0
        objconnection.Close()
    End Sub

  
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowMessage.Visible = True
        objdataadapter.SelectCommand.CommandText = "select 车号 from TRUCK_QUEUE where 粕类=1 and 已登记=1"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "isReserved")

        objdataview = New DataView(objdataset.Tables("isReserved"))
        MessageBox.Show("处理前已登记记录数为:" & objdataview.Count - 1, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '-----------------------------------------------------------------------------------------------------



        Dim jishu As Integer

        For jishu = 0 To objdataview.Count - 1
            System.Windows.Forms.Application.DoEvents()
            ShowMessage.Text = "正在后台处理未放行即出厂的车辆..." & jishu & "/" & objdataview.Count - 1
            Dim drOperateCheHao As DataRow = objdataset.Tables("isReserved").Rows(jishu)

            Dim a As String
            Dim VehicleParkQuit As New DataTable
            a = VehicleinPark.VehiclePark(VehicleParkQuit, "VehiclePark_yhwebs", Trim(drOperateCheHao("车号")), 3)

            Dim drOperate As DataRow = VehicleParkQuit.Rows(0)
            ' MessageBox.Show(drOperate("VEHICLE") & drOperate("in_time") & "至" & drOperate("out_time"))

            If Len(Trim(drOperate("out_time").ToString)) < 1 And VehicleParkQuit.Rows.Count >= 1 Then
                'MessageBox.Show("该车还在停车场", "2号接口检测提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
            Else
                'MessageBox.Show("该车已出停车场", "2号接口检测提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)

                '----------------------------------------------------------------
                Dim objcommandpassword As New SqlClient.SqlCommand
                objcommandpassword.Connection = objconnection
                objcommandpassword.CommandText = "Update TRUCK_QUEUE set 可登记=1,已登记=0,可进厂=0,退回时间=@退回时间,备注=@备注 where 车号='" & Trim(drOperateCheHao("车号")) & "'"
                objcommandpassword.Parameters.AddWithValue("@退回时间", sendsomething.getDateTime())
                objcommandpassword.Parameters.AddWithValue("@备注", drOperate("VEHICLE") & "在停车场的时间为:" & drOperate("in_time") & "至" & drOperate("out_time"))

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objcommandpassword.ExecuteNonQuery()
                objconnection.Close()

                '----------------------------------------------------------------



            End If
            System.Windows.Forms.Application.DoEvents()


        Next



        '--------------------------------------------------------------------------------------------

        objdataadapter.SelectCommand.CommandText = "select 车号 from TRUCK_QUEUE where 粕类=1 and 已登记=1"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "isReserved")

        objdataview = New DataView(objdataset.Tables("isReserved"))

        MessageBox.Show("处理后已登记记录数为:" & objdataview.Count - 1, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)





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
        ShowMessage.Visible = False
    End Sub

   
    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Try
            If (Len(IDID.Text) > 0) Then

                Dim objcommandpassword As New SqlClient.SqlCommand
                objcommandpassword.Connection = objconnection
                objcommandpassword.CommandText = "update TRUCK_QUEUE set 可登记=0,已登记=0,可进厂=1,进厂时间=@进厂时间" & " where id=" & Val(IDID.Text)
                objcommandpassword.Parameters.AddWithValue("@进厂时间", sendsomething.getDateTime())

                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommandpassword.ExecuteNonQuery()
                objconnection.Close()
                MessageBox.Show("预约车辆放行完成!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                sendsomething.sendOneMessage(Trim(dianhuahaoma.Text), "<<预约车辆进厂装货提醒>>" & Trim(kehumingcheng.Text) & "," & Trim(pinming.Text) & ",提单量:" & Trim(shuliang.Text) & "吨," & Trim(chehao.Text) & "," & "可进厂装货!", "益海贸易部", "fpiyx,LUGXH^7673bxgs.68423#$%##dwt")

                showall()
                clearall()
            Else
                MessageBox.Show("没有可操作记录", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Function isTure()

        objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  已登记=1 and 车号='" & Trim(chehao.Text) & "'"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "isTrue")

        objdataview = New DataView(objdataset.Tables("isTrue"))

        If objdataview.Count > 0 Then
            Return 1
        Else
            Return 0
        End If




    End Function

    Private Sub 测试Limit数据ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 测试Limit数据ToolStripMenuItem.Click
        Try
            If (Len(IDID.Text) > 0) Then
                Dim tidanliang As Integer


                tidanliang = Val(shuliang.Text) '数量判断变量，很重要



                Dim flag_park As String

                flag_park = VehicleinPark.VehicleInPark("VehicleInPark_yhwebs", Trim(chehao.Text))

                If flag_park = 1 Then  '车辆在停车场，将按照正常程序放行进厂

                    If tidanliang >= 20 Then

                    
                        MessageBox.Show("超过20吨的货（可能含A类货)放行完成!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                   
                    Else


                        '-------------------------------------------------不足20吨的货物处理----------------------------------------------------------------------------

                        objdataadapter.SelectCommand.CommandText = "Select * from TRUCK_QUEUE where 车号='" & Trim(chehao.Text) & "' and 导入批次='" & Trim(pici.Text) & "' and ( 货物名称 in (select LimitName from TRUCK_QUEUE_LimitName) or  客户物料号 in (select LimitName from TRUCK_QUEUE_LimitName))"
                        If objconnection.State = ConnectionState.Closed Then
                            objconnection.Open()
                        End If
                        objdataset = New DataSet
                        objdataadapter.Fill(objdataset, "LimitName")
                        objdataview = New DataView(objdataset.Tables("LimitName"))

                        If objdataview.Count >= 1 Then
                            MessageBox.Show("当前货物不足20吨且该车含A类货（如：42,43,46等),需从强制排队界面放行!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            GoTo iSLimit
                        Else '虽然小于20吨，但是并没有A类货物，所以全部放行

                        
                            MessageBox.Show("低于20吨的B类货放行完成!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                      

                        End If '低于20吨范围中有无A类货的判断结束语句



                    End If  '是否超过20吨的结束语句



                    '-----------------------------------------------------------------车辆确定没有拉关键货物，可以放行该车的所有数据--------------------------------------------------------------------


                Else '否则说明不在停车场，立刻踢回可登记


               
                    MessageBox.Show("因未放行前车辆就已离开停车场，故该车辆被强制退回至可登记状态!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                  


                End If '没有在停车场的结束记录






            Else
                MessageBox.Show("没有可操作记录", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If  '没有选择记录的结束语句



iSLimit:



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

   
  
  
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim a As String
        Dim VehicleParkQuit As New DataTable
        a = VehicleinPark.VehiclePark(VehicleParkQuit, "VehiclePark_yhwebs", Trim(chehao.Text), 3)

        MessageBox.Show(VehicleParkQuit.Rows.Count)

    End Sub

   
End Class