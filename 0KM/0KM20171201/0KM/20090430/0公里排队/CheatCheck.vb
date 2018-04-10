Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Public Class CheatCheck
    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Dim objconnection = New SqlClient.SqlConnection("Data Source= " & Trim("222.189.4.146") & "," & Trim("1433") & ";Initial Catalog = package;User ID=" & "sa" & "; Password=" & "chen dong")
    Dim VehicleinPark As New lygport_outside.Service1SoapClient
    Private Sub CheatCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '  dgv.AllowUserToAddRows = False '消除最后一行


        '----------------------------------------------------------------------------------------------
        Try


            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandType = CommandType.Text
            objdataadapter.SelectCommand.CommandText = "select distinct(vehicleNo),Passtime,Operator  from TRUCK_QUEUE_PermitOCP where 1=1 order by PassTime desc "
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "TRUCK_QUEUE_PermitOCP")

            objdataview = New DataView(objdataset.Tables("TRUCK_QUEUE_PermitOCP"))

            dgv1.DataSource = objdataview

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellClick
        VehicleNo.Text = Trim(dgv1.Rows(e.RowIndex).Cells(0).Value)

        Try


            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandType = CommandType.Text
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 车号='" & Trim(VehicleNo.Text) & "'"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "TRUCK_QUEUE")

            objdataview = New DataView(objdataset.Tables("TRUCK_QUEUE"))

            dgv2.DataSource = objdataview

            '-------------------------------------------------------------------------------------------------------
            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandType = CommandType.Text
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE_BAK where 车号='" & Trim(VehicleNo.Text) & "'order by 完成时间 desc"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "TRUCK_QUEUE_BAK")

            objdataview = New DataView(objdataset.Tables("TRUCK_QUEUE_BAK"))

            dgv3.DataSource = objdataview





        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        VehicleNo.Text = Trim(dgv1.Rows(e.RowIndex).Cells(0).Value)

        Try


            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandType = CommandType.Text
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where 车号='" & Trim(VehicleNo.Text) & "'"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "TRUCK_QUEUE")

            objdataview = New DataView(objdataset.Tables("TRUCK_QUEUE"))

            dgv2.DataSource = objdataview

            '-------------------------------------------------------------------------------------------------------
            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandType = CommandType.Text
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE_BAK where 车号='" & Trim(VehicleNo.Text) & "'order by 完成时间 desc"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "TRUCK_QUEUE_BAK")

            objdataview = New DataView(objdataset.Tables("TRUCK_QUEUE_BAK"))

            dgv3.DataSource = objdataview
            GroupBox3.Text = "已完成记录"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub RichTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles days.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click

        Dim flag_park As String

        If Len(chehao.Text) > 0 And Len(days.Text) > 0 Then


            ShowMessage.Visible = True
            Dim a As String
            Dim VehicleParkQuit As New DataTable

            If BlueSel.Checked = True Then
                a = VehicleinPark.VehiclePark(VehicleParkQuit, "VehiclePark_yhwebs", Trim(chehao.Text) & "蓝", Val(days.Text) + 1)
            Else
                a = VehicleinPark.VehiclePark(VehicleParkQuit, "VehiclePark_yhwebs", Trim(chehao.Text), Val(days.Text) + 1)
            End If
            dgv3.DataSource = VehicleParkQuit
            GroupBox3.Text = "停车场进出入记录"
            ShowMessage.Visible = False
            '-------------------------------判断车辆是否在停车场



            flag_park = VehicleinPark.VehicleInPark("VehicleInPark_yhwebs", Trim(chehao.Text))
            If flag_park = 1 Then
                MessageBox.Show("当前车辆正位于停车场!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("当前车辆不在停车场内!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else

            MessageBox.Show("车号或周期不能为空...", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SCB As SqlCommandBuilder = New SqlCommandBuilder(objdataadapter)
        objdataadapter.Update(objdataset.Tables("TRUCK_QUEUE_LimitName"))
        MessageBox.Show("更新完毕", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Button2_Click(Me, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

     
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "Select * from TRUCK_QUEUE_LimitName order by id desc"


        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "TRUCK_QUEUE_LimitName")

        objdataview = New DataView(objdataset.Tables("TRUCK_QUEUE_LimitName"))

        objconnection.Close()

        dgv.DataSource = objdataview
            dgv.Columns(0).Width = 0
            dgv.Columns(1).Width = 200
        Catch ex As Exception
            MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim objcommanddel As New SqlClient.SqlCommand
        objcommanddel.Connection = objconnection
        objcommanddel.CommandText = "Delete from TRUCK_QUEUE_LimitName where id=" & Val(idid.Text)

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If

        objcommanddel.ExecuteNonQuery()
        Button2_Click(Me, e)
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        On Error Resume Next
        idid.Text = Trim(dgv.Rows(e.RowIndex).Cells(0).Value)
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        On Error Resume Next
        idid.Text = Trim(dgv.Rows(e.RowIndex).Cells(0).Value)
    End Sub

    Private Sub dgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
        On Error Resume Next
        idid.Text = Trim(dgv.Rows(e.RowIndex).Cells(0).Value)
    End Sub
End Class