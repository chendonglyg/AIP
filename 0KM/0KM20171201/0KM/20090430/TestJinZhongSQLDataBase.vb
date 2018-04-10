Public Class TestJinZhongSQLDataBase
    Dim objdataset As New DataSet
    Dim objdatatable As New DataTable
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Dim objjinzhong As New SqlClient.SqlConnection
    Dim sa, jinzhongpassword, ipaddressvalues As String
    Dim is_shutdown As Boolean
    Dim i, RowCount As Integer

    Dim data_row As DataRow

    Private Sub TestJinZhongSQLDataBase_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = "27" Then
            End
        End If

    End Sub

  

   

    Private Sub TestJinZhongSQLDataBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 一卡通测试服务器地址：胡章艮 2-28 15:31数据库名称:  GoldBell_Wilmar 接口视图名称 : TaskInfoForOutSys

        '连接用户：Interface_DLFY  密码：Yikatong@)17
    
        sa = "Interface_DLFY"
        jinzhongpassword = "Yikatong@)17"
        ipaddressvalues = "10.229.17.44"

        objjinzhong = New SqlClient.SqlConnection("Data Source= " & Trim(ipaddressvalues) & ";Initial Catalog = GoldBell_Wilmar;User ID=" & sa & "; Password=" & jinzhongpassword)


        On Error Resume Next
        Dim p As New Net.NetworkInformation.Ping
        Dim pr As Net.NetworkInformation.PingReply

        pr = p.Send(ipipip)


        If pr.Status = Net.NetworkInformation.IPStatus.Success Then

            Total_record() '--------获取数据和总条目

            i = 0

            is_shutdown = False
        Else

            is_shutdown = True
            SHOWERROR.Visible = True
            dgv.DataSource = Nothing


        End If
        dgv.AllowUserToAddRows = False '消除最后一行

        'objdataadapter.SelectCommand = New SqlClient.SqlCommand
        'objdataadapter.SelectCommand.Connection = objjinzhong
        'objdataadapter.SelectCommand.CommandText = "select TruckNO as 车号,MaterialName as 物料,PlanWeigh as 计划重量,isfirstweight as 完成一磅,BeginTallyTime as 开始理货,EndTallyTime as 结束理货,IssecondWeight as 完成二磅, FinalNet as 净重 from TaskInfoForOutSys where iscomplete=0 "

        'objjinzhong.Open()
        'objdataset = New DataSet
        'objdataadapter.Fill(objdataset, "OneCardPass")


        'dgv.DataSource = objdataset.Tables("OneCardPass")
        'objdataview = New DataView(objdataset.Tables("OneCardPass"))
        'showcount.Text = objdataview.Count

        'dgv.AllowUserToAddRows = False
        'dgv.Columns(0).Width = 120
        'dgv.Columns(1).Width = 250

        'dgv.Columns(2).Width = 120
        'dgv.Columns(3).Width = 80
        'dgv.Columns(4).Width = 200
        'dgv.Columns(5).Width = 200
        'dgv.Columns(6).Width = 80
        'dgv.Columns(7).Width = 80




    End Sub





   




    Private Sub Total_record()
        SHOWERROR.Visible = False


        '---------------

        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objjinzhong
        objdataadapter.SelectCommand.CommandText = "select TruckNO as 车号,MaterialName as 物料,PlanWeigh as 计划重量,isfirstweight as 完成一磅,BeginTallyTime as 开始理货,EndTallyTime as 结束理货,IssecondWeight as 完成二磅, FinalNet as 净重 from TaskInfoForOutSys where iscomplete=0 "

        If objjinzhong.State = ConnectionState.Closed = True Then
            objjinzhong.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "OneCardPass")


        objdatatable = objdataset.Tables("OneCardPass")
        dgv.DataSource = objdatatable

        objdataview = New DataView(objdataset.Tables("OneCardPass"))
        showcount.Text = "共计" & objdataview.Count & "车"

        RowCount = objdataview.Count


        dgv.AllowUserToAddRows = False
        dgv.Columns(0).Width = 120
        dgv.Columns(1).Width = 330

        dgv.Columns(2).Width = 120
        dgv.Columns(3).Width = 80
        dgv.Columns(4).Width = 200
        dgv.Columns(5).Width = 200
        dgv.Columns(6).Width = 80
        dgv.Columns(7).Width = 120



        If objjinzhong.State = ConnectionState.Open Then
            objjinzhong.Close()
        End If


    End Sub
    Private Sub showdatatable()

        'On Error Resume Next
        objdatatable = objdataset.Tables("OneCardPass")
        data_row = objdatatable.NewRow
        data_row("车号") = objdataset.Tables("OneCardPass").Rows(0).Item(0).ToString
        data_row("物料") = objdataset.Tables("OneCardPass").Rows(0).Item(1).ToString

        data_row("计划重量") = objdataset.Tables("OneCardPass").Rows(0).Item(2).ToString

        data_row("完成一磅") = objdataset.Tables("OneCardPass").Rows(0).Item(3).ToString

        data_row("开始理货") = objdataset.Tables("OneCardPass").Rows(0).Item(4).ToString
        data_row("结束理货") = objdataset.Tables("OneCardPass").Rows(0).Item(5).ToString
        data_row("完成二磅") = objdataset.Tables("OneCardPass").Rows(0).Item(6).ToString
        data_row("净重") = objdataset.Tables("OneCardPass").Rows(0).Item(7).ToString






        objdataset.Tables("OneCardPass").Rows.Add(data_row)
        objdataset.Tables("OneCardPass").Rows.RemoveAt(0)


        i = i + 1


        If i >= RowCount Then
            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objjinzhong
            objdataadapter.SelectCommand.CommandText = "select TruckNO as 车号,MaterialName as 物料,PlanWeigh as 计划重量,isfirstweight as 完成一磅,BeginTallyTime as 开始理货,EndTallyTime as 结束理货,IssecondWeight as 完成二磅, FinalNet as 净重 from TaskInfoForOutSys where iscomplete=0 "
            If objjinzhong.State = ConnectionState.Closed = True Then
                objjinzhong.Open()
            End If

            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "OneCardPass")


            objdatatable = objdataset.Tables("OneCardPass")

            dgv.DataSource = objdatatable

            objdataview = New DataView(objdataset.Tables("OneCardPass"))
            showcount.Text = "共计" & objdataview.Count & "车"
            RowCount = objdataview.Count


            dgv.AllowUserToAddRows = False
            dgv.Columns(0).Width = 120
            dgv.Columns(1).Width = 330

            dgv.Columns(2).Width = 120
            dgv.Columns(3).Width = 80
            dgv.Columns(4).Width = 200
            dgv.Columns(5).Width = 200
            dgv.Columns(6).Width = 80
            dgv.Columns(7).Width = 120
            i = 0
        End If


        If objjinzhong.State = ConnectionState.Open Then
            objjinzhong.Close()
        End If
    End Sub




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Doit.Tick

        Dim p As New Net.NetworkInformation.Ping
        Dim pr As Net.NetworkInformation.PingReply


        pr = p.Send("10.229.17.44")

        If pr.Status = Net.NetworkInformation.IPStatus.Success Then
            SHOWERROR.Visible = False
            If is_shutdown = True Then

                Total_record() '--------主要用于获取数据集的数目，用于滚动

                i = 0

                is_shutdown = False
            Else

                showdatatable()

            End If

        Else

            is_shutdown = True
            SHOWERROR.Visible = True
            dgv.DataSource = Nothing

        End If
    End Sub





    Private Sub dgv_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv.CellFormatting
        On Error Resume Next

        dgv.Rows(e.RowIndex).Cells("车号").Style.BackColor = Color.DarkGreen
        dgv.Rows(e.RowIndex).Cells("物料").Style.BackColor = Color.DarkGreen
        dgv.Rows(e.RowIndex).Cells("计划重量").Style.BackColor = Color.DarkGreen



        If dgv.Rows(e.RowIndex).Cells("完成一磅").Value = 1 Then
            dgv.Rows(e.RowIndex).Cells("完成一磅").Style.BackColor = Color.DarkGreen
        End If

        If dgv.Rows(e.RowIndex).Cells("完成一磅").Value = 0 Then
            dgv.Rows(e.RowIndex).Cells("完成一磅").Style.BackColor = Color.Black
        End If

        If dgv.Rows(e.RowIndex).Cells("开始理货").Value <> "1900/01/01" Then
            dgv.Rows(e.RowIndex).Cells("开始理货").Style.BackColor = Color.DarkGreen

        End If

        If dgv.Rows(e.RowIndex).Cells("结束理货").Value <> "1900/01/01" Then
            dgv.Rows(e.RowIndex).Cells("结束理货").Style.BackColor = Color.DarkGreen
       

        End If

        If dgv.Rows(e.RowIndex).Cells("完成二磅").Value = 1 Then
            dgv.Rows(e.RowIndex).Cells("完成二磅").Style.BackColor = Color.DarkGreen
        End If

        If dgv.Rows(e.RowIndex).Cells("净重").Value > 0 Then
            dgv.Rows(e.RowIndex).Cells("净重").Style.BackColor = Color.DarkGreen
        End If
        'dgv.Columns(0).HeaderCell.Style.BackColor = Color.DarkGreen


    End Sub

   
    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        End

    End Sub

   

    Private Sub dgv_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv.KeyDown
        If e.KeyCode = "27" Then
            End
        End If
    End Sub
End Class