Public Class E_Guard
    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Dim OK43, Tree_No As Integer
    Dim sendsomething As New sendmessage.CTEnterprisesSoapClient
    Dim VehicleinPark As New lygport_outside.Service1SoapClient

    Dim veh_return, in_date, stre, stre_2, stre_3, phone_no As String
    Dim crytogram, vehicle, externo As String


    

    Private Sub C_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        objconnection = New SqlClient.SqlConnection("Data Source= 222.189.4.146;Initial Catalog = package;User ID= sa; Password=chen dong")

        yidengji.AllowUserToAddRows = False '消除最后一行
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection

        TreeView1.Enabled = True
        TreeView2.Enabled = False

        axHWPostil1.ShowDefMenu = 0
        axHWPostil1.ShowScrollBarButton = 0
        AxHWPostil1.ShowToolBar = 0
        idid.Text = Nothing

    End Sub

    Private Sub showall()

        On Error Resume Next


        If Tree_No = 1 Then

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
                yidengji.ContextMenuStrip = Nothing
                yidengji.DataSource = objdataview

            End If
            '---------------------------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "--超时车辆" Then
                objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where  粕类=1 and Overtimeflag=1 order by 进厂时间"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "chaoshi")

                objdataview = New DataView(objdataset.Tables("chaoshi"))

                yidengji.DataSource = objdataview
                yidengji.ContextMenuStrip = Nothing
                box2.Text = "超时车辆"

            End If

            '------------------------------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "--退回车辆" Then
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

    Private Sub yidengji_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles yidengji.CellClick
        On Error Resume Next
        kehumingcheng.Text = Trim(yidengji.Rows(e.RowIndex).Cells(1).Value)
        IDID.Text = Trim(yidengji.Rows(e.RowIndex).Cells(0).Value)
        shuliang.Text = Trim(yidengji.Rows(e.RowIndex).Cells(5).Value)
        pinming.Text = Trim(yidengji.Rows(e.RowIndex).Cells(2).Value)
        tidanhao.Text = Trim(yidengji.Rows(e.RowIndex).Cells(3).Value)
        chehao.Text = Trim(yidengji.Rows(e.RowIndex).Cells(6).Value)
        dianhuahaoma.Text = Trim(yidengji.Rows(e.RowIndex).Cells(7).Value)
        beizhu.Text = Trim(yidengji.Rows(e.RowIndex).Cells(17).Value)

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
        '--------------------------------------------------------------------------------------------------------------------------
        On Error Resume Next
        If Len(idid.Text) > 0 Then

         

                Dim SEL As String = "C:\windows\temp\lkfjlksfjlflksjfkfjkslfj.PDF"

                System.IO.File.Delete(SEL)

                Dim SQLSEL As String = "Select id,filedata from TRUCK_QUEUE_INPUT where id = " & idid.Text

                Dim myRow As DataRow


                Dim da As New SqlClient.SqlDataAdapter(SQLSEL, objconnection)

                Dim MyCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)
                Dim ds As New DataSet()

                da.Fill(ds, "PICI")
                objdataview = New DataView(ds.Tables("PICI"))

                If objdataview.Count > 0 Then

                    myRow = ds.Tables("PICI").Rows(0)



                    Dim MyData() As Byte
                    MyData = myRow("filedata")

                    Dim ArraySize As Integer
                    ArraySize = MyData.GetUpperBound(0)




                    Dim fs As New IO.FileStream(SEL, IO.FileMode.OpenOrCreate, IO.FileAccess.Write)
                    fs.Write(MyData, 0, ArraySize)
                    fs.Close()

                AxHWPostil1.LoadFile(SEL)
                AxHWPostil1.SetPageMode(2, 2)


                End If



                '--------------------------------------------------------------------------------------------------------------------就算没有提单的记录也将被确认并清除记录

     





        Else
            MessageBox.Show("您没有选择记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

   

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Tree_No = 1

        TreeView2.SelectedNode = Nothing

   
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

            yidengji.DataSource = objdataview
            box2.Text = "已完成车辆"

        End If
        '---------------------------------------------------------------------------------------
        If TreeView1.SelectedNode.Text = "--超时车辆" Then
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
        If TreeView1.SelectedNode.Text = "--退回车辆" Then
            objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where  粕类=1 and 已退回=1 order by 进厂时间"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "tuihui")

            objdataview = New DataView(objdataset.Tables("tuihui"))

            yidengji.DataSource = objdataview

            box2.Text = "退回车辆"

        End If

        '-------------------------------------------------------------------------------------------
        On Error Resume Next


        yidengji.Columns(0).Width = 0
        objconnection.Close()

    End Sub

    Private Sub chaxun_KeyDown(sender As Object, e As KeyEventArgs) Handles chaxun.KeyDown
        Try

  

        If e.KeyCode = Keys.Enter Then


            ''--------------------------------------------------------------
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
            '----------------------------------------------------------------------------------------------------
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
            If TreeView1.SelectedNode.Text = "--超时车辆" Then
                objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where  可进厂=1 and Overtimeflag=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "tuihui")
                objdataview = New DataView(objdataset.Tables("tuihui"))
                yidengji.DataSource = objdataview

                box2.Text = "超时车辆"

            End If




            '-------------------------------------------------------------------------------------------
            If TreeView1.SelectedNode.Text = "--退回车辆" Then
                objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 已退回=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If
                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "tuihui")

                objdataview = New DataView(objdataset.Tables("tuihui"))

                yidengji.DataSource = objdataview

                box2.Text = "退回车辆"

            End If

            '---------------------------------------------------------------------------------------------------------------------
            yidengji.Columns(0).Width = 0
            objconnection.Close()





            '-------------------------------------------------------------------------------------///////////////////////////////////////////////////////////22222222
        End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

  

    Private Sub TreeView2_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView2.AfterSelect
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
            yidengji.ContextMenuStrip = Nothing
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
            yidengji.ContextMenuStrip = Nothing
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
            yidengji.ContextMenuStrip = Nothing
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


   


    
  

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub yidengji_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles yidengji.CellFormatting
        On Error Resume Next
        If yidengji.Rows(e.RowIndex).Cells("ExistBill").Value Is DBNull.Value Then

        Else

            e.CellStyle.BackColor = Color.YellowGreen

        End If

    End Sub

 
    Private Sub PrintBill_Click(sender As Object, e As EventArgs) Handles PrintBill.Click
        If MessageBox.Show("是否要发放提单？（Y/N)", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK And Len(Trim(tidanhao.Text)) > 0 Then

            Dim Errcode As Integer = -1104
            If AxHWPostil1.PrintDoc(1, 1) <> Errcode Then





                Dim objcommandpassword As New SqlClient.SqlCommand
                objcommandpassword.Connection = objconnection
                objcommandpassword.CommandText = "Update TRUCK_QUEUE set 可登记=0,已登记=0,可进厂=0,已完成=1,完成时间=@完成时间,billflag=1,billtime=@billtime,billwho=@billwho" & " where id=" & Val(idid.Text)
                objcommandpassword.Parameters.AddWithValue("@完成时间", sendsomething.getDateTime())
                objcommandpassword.Parameters.AddWithValue("@billwho", username)
                objcommandpassword.Parameters.AddWithValue("@billtime", sendsomething.getDateTime())



                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommandpassword.ExecuteNonQuery()
                objconnection.Close()

                MessageBox.Show("提单已打印！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                showall()


                AxHWPostil1.CloseDoc(0)
            End If

        End If
    End Sub
End Class