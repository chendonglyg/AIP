﻿Imports System.Data.SqlClient

Public Class Trade_Report
    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter

  
    Private Sub addcombo()

        Application.DoEvents()

        kehumingcheng.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        kehumingcheng.AutoCompleteSource = AutoCompleteSource.ListItems

        Application.DoEvents()

        Dim a As Integer


        objdataadapter.SelectCommand = New System.Data.SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 客户名称 from DATA_QUEUE"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "kehu")

        objdataview = New DataView(objdataset.Tables("kehu"))
        Application.DoEvents()
        ' MessageBox.Show(objdataview.Count)
        kehumingcheng.Items.Clear()
        On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                If Len(objdataview.Item(a).Item("客户名称").ToString) <> 0 Then
                    Application.DoEvents()
                    kehumingcheng.Items.Add(Trim(objdataview.Item(a).Item("客户名称")))
                End If
            Next
        End If
        Application.DoEvents()

        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select 物料名称 from DATA_QUEUE"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "wuliao")

        objdataview = New DataView(objdataset.Tables("wuliao"))

        ' MessageBox.Show(objdataview.Count)
        pinming.Items.Clear()


        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                If Len(objdataview.Item(a).Item("物料名称").ToString) <> 0 Then
                    pinming.Items.Add(Trim(objdataview.Item(a).Item("物料名称")))
                End If
            Next
        End If




        objconnection.Close()




    End Sub


    Private Function BytesToImage(buffer As Byte()) As Image

        Dim ms As IO.MemoryStream = New IO.MemoryStream(buffer)
        Dim image As Image = System.Drawing.Image.FromStream(ms)
        Return image
    End Function



    

  


    Private Sub Trade_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objconnection = New SqlConnection("Data Source= " & Trim("10.229.17.10") & "," & Trim("80") & ";Initial Catalog = package;User ID=" & "sa" & "; Password='chen dong'")

    End Sub

  

    
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim dm11 As New Date
        dm11 = dt11.Value
        Dim dm12 As New Date
        dm12 = dt12.Value
        objdataadapter = New SqlClient.SqlDataAdapter
        objdataadapter.SelectCommand = New SqlClient.SqlCommand



        objconnection = New SqlConnection("Data Source= " & Trim("10.229.17.10") & "," & Trim("1433") & ";Initial Catalog = package;User ID=" & "sa" & "; Password=" & "chen dong")

        objdataadapter.SelectCommand.Connection = objconnection

        objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE_IMAGE "


        '  objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & " And (完成时间 between  '" & dm11.ToString("yyyy/MM/dd") & "' and '" & dm12.ToString("yyyy/MM/dd") & "')"






        If cb1.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & " and 客户名称 = " & "'" & Trim(kehumingcheng.Text) & "'"
        End If

        If cb2.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & " and 货物名称 = '" & Trim(pinming.Text) & "'"
        End If

        If cb3.Checked = True Then
            objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & " and 车号 = '" & Trim(chehao.Text) & "'"
        End If





        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "TOTAL")
        objdataview = New DataView(objdataset.Tables("TOTAL"))
        dgv.DataSource = objdataview

        '-----------------------------------------------------------------------------------
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        Dim oRpt As New TestPicImport
        'Dim Pic As CrystalDecisions.CrystalReports.Engine.PictureObject = oRpt.ReportDefinition.ReportObjects.Item("Pic")
        'Dim Pic As CrystalDecisions.CrystalReports.Engine.PictureObject = oRpt.ReportDefinition.ReportObjects.Item("Pic")
        'Dim Txt As CrystalDecisions.CrystalReports.Engine.TextObject = oRpt.ReportDefinition.ReportObjects.Item("Txt")
        'Dim Field As CrystalDecisions.CrystalReports.Engine.FieldObject = oRpt.ReportDefinition.ReportObjects.Item("车号1")



        '-----------------------------------------------------------------------------------------------------------------------

        Dim fsread As New IO.FileStream("D:\barcode.png", IO.FileMode.Open)

        Dim fsLen As Integer = fsread.Length

        Dim img_byte(fsLen) As Byte

        fsread.Read(img_byte, 0, fsread.Length)

        Dim xdatatable As New DataTable
        '------------------------------------------------------------------------------------------------------------------------
        Dim xrow As DataRow
        xdatatable.Columns.Add("提单号", System.Type.GetType("System.String"))
        xdatatable.Columns.Add("车号", System.Type.GetType("System.String"))
        xdatatable.Columns.Add("图像2", System.Type.GetType("System.Byte[]"))

        xrow = xdatatable.NewRow

        xrow("提单号") = "提单号DONG!"
        xrow("车号") = "车号DONG!"
        xrow("图像2") = img_byte

        xdatatable.Rows.Add(xrow)

        objdataset.Tables.Add(xdatatable)
        'xdatatable.Rows(0).Item("图像2") = img_byte







        ' objdataset.Tables("TOTAL").Rows(0).Item("图像2") = img_byte
        ' oRpt.SetDataSource(objdataset.Tables("TOTAL"))

        oRpt.SetDataSource(xdatatable)


        PRINT.Show()
        PRINT.CrystalReportViewer1.ReportSource = oRpt
        PRINT.Visible = False

        '-------------------------------------------------------------------


        'Dim img As Image
        'Dim imagedata As New IO.MemoryStream(img_byte)
        'img = Image.FromStream(imagedata)
        'PRINT.PictureBox1.Image = img











        oRpt.PrintOptions.PrinterName = "Adobe PDF"
        oRpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA3
        oRpt.PrintToPrinter(1, True, 1, 0)


    End Sub

  
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.Close()
    End Sub
End Class