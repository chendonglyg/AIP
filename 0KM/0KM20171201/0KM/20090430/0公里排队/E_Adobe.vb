Public Class E_Adobe

    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Dim OK43, Tree_No As Integer
    Dim sendsomething As New sendmessage.CTEnterprisesSoapClient
    ' Dim VehicleinPark As New lygport_outside.Service1SoapClient

    'Dim veh_return, in_date, stre, stre_2, stre_3, phone_no As String
    ' Dim crytogram, vehicle, externo As String




    Private Sub C_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

   

        objconnection = New SqlClient.SqlConnection("Data Source= 222.189.4.146;Initial Catalog = package;User ID= sa; Password=chen dong")

        yidengji.AllowUserToAddRows = False '消除最后一行
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection

        AxAcroPDF1.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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

        On Error Resume Next




        '-------------------------------------------------------------------
        If Val(TreeView1.Text) = 1 Then
            clearall()
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
        If Val(TreeView1.Text) = 2 Then
            clearall()
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
        If Val(TreeView1.Text) = 3 Then
            clearall()
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
        If Val(TreeView1.Text) = 4 Then
            clearall()
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
        AxAcroPDF1.LoadFile("")
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
        AxAcroPDF1.LoadFile("")

    End Sub



 

    Private Sub chaxun_KeyDown(sender As Object, e As KeyEventArgs) Handles chaxun.KeyDown
        Try



            If e.KeyCode = Keys.Enter Then


                ''--------------------------------------------------------------
                If Val(TreeView1.Text) = 1 Then
                    clearall()
                    objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  可进厂=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objdataset = New DataSet
                    objdataadapter.Fill(objdataset, "yiwancheng")

                    objdataview = New DataView(objdataset.Tables("yiwancheng"))

                    yidengji.DataSource = objdataview
                    PrintBill.Enabled = True
                    box2.Text = "可进厂车辆"
                End If
                '----------------------------------------------------------------------------------------------------
                If Val(TreeView1.Text) = 2 Then
                    clearall()
                    objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE_BAK where  已完成=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objdataset = New DataSet
                    objdataadapter.Fill(objdataset, "chaoshi")

                    objdataview = New DataView(objdataset.Tables("chaoshi"))

                    yidengji.DataSource = objdataview
                    PrintBill.Enabled = True
                    box2.Text = "已完成车辆"

                End If
                '------------------------------------------------------------------------------------------
                If Val(TreeView1.Text) = 3 Then
                    clearall()
                    objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where  可进厂=1 and Overtimeflag=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objdataset = New DataSet
                    objdataadapter.Fill(objdataset, "tuihui")
                    objdataview = New DataView(objdataset.Tables("tuihui"))
                    yidengji.DataSource = objdataview
                    PrintBill.Enabled = False
                    box2.Text = "超时车辆"

                End If




                '-------------------------------------------------------------------------------------------
                If Val(TreeView1.Text) = 4 Then
                    clearall()
                    objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where 已退回=1 and 车号 like '%" & Trim(chaxun.Text) & "%'"
                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If
                    objdataset = New DataSet
                    objdataadapter.Fill(objdataset, "tuihui")

                    objdataview = New DataView(objdataset.Tables("tuihui"))

                    yidengji.DataSource = objdataview
                    PrintBill.Enabled = False
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

  

   
    Private Sub ShowPDFData()
        Dim SEL As String = "C:\windows\temp\lkfjlksfjlflksjfkfjkslfj.PDF"

        System.IO.File.Delete(SEL)

        Dim SQLSEL As String = "Select id,filedata from TRUCK_QUEUE_INPUT where id = " & IDID.Text

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

            ' Process.Start(sel)
            Dim p As Process = New Process

            AxAcroPDF1.LoadFile(SEL)
            AxAcroPDF1.setZoom(100)
            AxAcroPDF1.setPageMode("thumbs")
            AxAcroPDF1.setPageMode("none")
            AxAcroPDF1.setShowToolbar(False)
            AxAcroPDF1.setShowScrollbars(False)
            AxAcroPDF1.setPageMode("pages only")



            AxAcroPDF1.printWithDialog()


        End If


    End Sub

   

    Private Sub yidengji_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles yidengji.CellFormatting
        On Error Resume Next
        If yidengji.Rows(e.RowIndex).Cells("ExistBill").Value Is DBNull.Value Then

        Else

            e.CellStyle.BackColor = Color.Green

        End If

    End Sub



  

   
  
    

   

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        clearall()
        TreeView1.Text = 1
        objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where  粕类=1 and 可进厂=1 order by 进厂时间"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "kejinchang")
        objdataview = New DataView(objdataset.Tables("kejinchang"))
        PrintBill.Enabled = True
        yidengji.DataSource = objdataview
        box2.Text = "可进厂车辆"

        On Error Resume Next


        yidengji.Columns(0).Width = 0
        objconnection.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        clearall()
        TreeView1.Text = 2
        objdataadapter.SelectCommand.CommandText = "select top 100 * from TRUCK_QUEUE_BAK where  粕类=1 and 已完成=1  order by 完成时间 desc"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "yiwancheng1")

        objdataview = New DataView(objdataset.Tables("yiwancheng1"))
        PrintBill.Enabled = True
        yidengji.DataSource = objdataview
        box2.Text = "已完成车辆"
        On Error Resume Next


        yidengji.Columns(0).Width = 0
        objconnection.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        clearall()
        TreeView1.Text = 3
        objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where  粕类=1 and Overtimeflag=1 order by 进厂时间"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "chaoshi")

        objdataview = New DataView(objdataset.Tables("chaoshi"))

        yidengji.DataSource = objdataview
        PrintBill.Enabled = False

        box2.Text = "超时车辆"
        On Error Resume Next


        yidengji.Columns(0).Width = 0
        objconnection.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        clearall()
        TreeView1.Text = 4
        objdataadapter.SelectCommand.CommandText = " select * from TRUCK_QUEUE where  粕类=1 and 已退回=1 order by 进厂时间"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "tuihui")

        objdataview = New DataView(objdataset.Tables("tuihui"))

        yidengji.DataSource = objdataview
        PrintBill.Enabled = False
        box2.Text = "退回车辆"
        On Error Resume Next


        yidengji.Columns(0).Width = 0
        objconnection.Close()
    End Sub

    Private Sub C1Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        clearall()
        TreeView1.Text = 5
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

        yidengji.Columns(0).Width = 0
        objconnection.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        clearall()
        TreeView1.Text = 6
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

        yidengji.Columns(0).Width = 0
        objconnection.Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        clearall()
        TreeView1.Text = 7
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

        yidengji.Columns(0).Width = 0
        objconnection.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        clearall()
        TreeView1.Text = 8
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

        yidengji.Columns(0).Width = 0
        objconnection.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        clearall()
        TreeView1.Text = 9
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

        yidengji.Columns(0).Width = 0
        objconnection.Close()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles PrintBill.Click

        On Error Resume Next
        If Len(IDID.Text) > 0 Then

            If MessageBox.Show("是否要发放此提单？（Y/N)", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then




                ShowPDFData()




                Dim objcommandpassword As New SqlClient.SqlCommand
                objcommandpassword.Connection = objconnection
                objcommandpassword.CommandText = "update TRUCK_QUEUE set 可登记=0,已登记=0,可进厂=0,已完成=1,完成时间=@完成时间,billflag=1,billtime=@billtime,billwho=@billwho" & " where id=" & Val(IDID.Text)
                objcommandpassword.Parameters.AddWithValue("@完成时间", sendsomething.getDateTime())
                objcommandpassword.Parameters.AddWithValue("@billwho", username)
                objcommandpassword.Parameters.AddWithValue("@billtime", sendsomething.getDateTime())



                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                objcommandpassword.ExecuteNonQuery()
                objconnection.Close()

                '--------------------------------------------------------------------------------------------------------

                '   MessageBox.Show("提单数据已被下载,请自行打印即可！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '  showall()
                ' clearall()

            End If



            '--------------------------------------------------------------------------------------------------------------------就算没有提单的记录也将被确认并清除记


        Else
            MessageBox.Show("您没有选择记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class
