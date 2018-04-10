Public Class A5
    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Dim kehumingcheng, huowumingcheng, tidanhao, chehao, dianhuahaoma As String
  

   

    Private Sub TXT_PICI_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_PICI.KeyDown
        If e.KeyCode = Keys.Enter Then
            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where ��������= '" & Trim(TXT_PICI.Text) & "'"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "trade")
            objdataview = New DataView(objdataset.Tables("trade"))
            DGV.DataSource = objdataview

            DGV.AllowUserToAddRows = False '�������һ��
        End If
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        On Error Resume Next

        kehumingcheng = Trim(DGV.Rows(e.RowIndex).Cells(1).Value)

        huowumingcheng = Trim(DGV.Rows(e.RowIndex).Cells(2).Value)

        tidanhao = Trim(DGV.Rows(e.RowIndex).Cells(3).Value)

        chehao = Trim(DGV.Rows(e.RowIndex).Cells(6).Value)

        dianhuahaoma = Trim(DGV.Rows(e.RowIndex).Cells(7).Value)

        TXT_INFO.Text = Trim(DGV.Rows(e.RowIndex).Cells(0).Value)

    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        On Error Resume Next

        kehumingcheng = Trim(DGV.Rows(e.RowIndex).Cells(1).Value)

        huowumingcheng = Trim(DGV.Rows(e.RowIndex).Cells(2).Value)

        tidanhao = Trim(DGV.Rows(e.RowIndex).Cells(3).Value)

        chehao = Trim(DGV.Rows(e.RowIndex).Cells(6).Value)

        dianhuahaoma = Trim(DGV.Rows(e.RowIndex).Cells(7).Value)

        TXT_INFO.Text = Trim(DGV.Rows(e.RowIndex).Cells(0).Value)



    End Sub

    Private Sub LABEL_BILL_Click(sender As Object, e As EventArgs) Handles LABEL_BILL.Click
        opd.Filter = "PDF�ļ�|*.PDF"

        opd.ShowDialog()

        TXT_PATH.Text = opd.FileName
    End Sub

 
    Private Sub A5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'objconnection = New SqlClient.SqlConnection("Data Source= 222.189.4.146;Initial Catalog = package;User ID= sa; Password=chen dong")
        addcombo()
        DGV.AllowUserToAddRows = False
    End Sub

    Private Sub BUT_START_Click(sender As Object, e As EventArgs) Handles BUT_START.Click
        Try

            Dim objcommanddel As New SqlClient.SqlCommand
            objcommanddel.Connection = objconnection
            objcommanddel.CommandText = "Delete from TRUCK_QUEUE_INPUT where id=" & Val(TXT_INFO.Text)

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            objcommanddel.ExecuteNonQuery()


            '---------------------------------------------------------------------------------------------


            If Len(TXT_INFO.Text) And Len(TXT_PATH.Text) > 0 Then

                Dim fi As IO.FileInfo
                Dim fs As IO.FileStream




                Dim da As New SqlClient.SqlDataAdapter("Select * from TRUCK_QUEUE_INPUT where id=0", objconnection)

                Dim MyCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)

                Dim ds As New DataSet()

                da.MissingSchemaAction = MissingSchemaAction.AddWithKey


                Dim myRow As DataRow
                Dim fname As String



                For Each fname In opd.FileNames

                    fi = New IO.FileInfo(fname)

                    ''MessageBox.Show(fname)
                    fs = New IO.FileStream(fname, IO.FileMode.OpenOrCreate, IO.FileAccess.Read)

                    Dim MyData(fs.Length) As Byte

                    fs.Read(MyData, 0, fs.Length)

                    fs.Close()




                    If objconnection.State = ConnectionState.Closed Then
                        objconnection.Open()
                    End If








                    da.Fill(ds, "UPLOADPDFFILE")

                    myRow = ds.Tables("UPLOADPDFFILE").NewRow()

                    myRow("ID") = Trim(TXT_INFO.Text)
                    myRow("filedata") = MyData


                    ' myRow("��������") = Trim(fujianleixing.Text)
                    myRow("filesize") = fi.Length
                    myRow("filename") = fi.Name
                    myRow("filetype") = fi.Extension



                    myRow("uploadtime") = Now
                    myRow("whoupload") = username



                    ds.Tables("UPLOADPDFFILE").Rows.Add(myRow)

                    da.Update(ds, "UPLOADPDFFILE")


                Next


                fs = Nothing
                MyCB = Nothing
                ds = Nothing
                da = Nothing


                MessageBox.Show("�ᵥPDF�ļ����ϴ�������!", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                '' Catch ex As Exception
                '' MessageBox.Show(ex.Message)
                '' End Try

                '------------------------------------------------------------------------  
                Dim OBJCOMMANDUPDATEEXISTBILL As New SqlClient.SqlCommand
                OBJCOMMANDUPDATEEXISTBILL.Connection = objconnection
                OBJCOMMANDUPDATEEXISTBILL.CommandText = "UPDATE TRUCK_QUEUE set ExistBill=1 " & " WHERE id=" & Val(TXT_INFO.Text)


                If objconnection.State = ConnectionState.Closed Then
                    objconnection.Open()
                End If

                OBJCOMMANDUPDATEEXISTBILL.ExecuteNonQuery()
                showall()
                objconnection.Close()

            Else
                MessageBox.Show("������û��ѡ��PDF�ļ���û��ѡ����Ӧ��¼��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "������һЩ���⣿", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub showall()

       objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where ��������= '" & Trim(TXT_PICI.Text) & "'"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "trade")
        objdataview = New DataView(objdataset.Tables("trade"))
        DGV.DataSource = objdataview
    End Sub
   
    Private Sub addcombo()

        ' Application.DoEvents()

        TXT_PICI.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        TXT_PICI.AutoCompleteSource = AutoCompleteSource.ListItems

        ' Application.DoEvents()

        Dim a As Integer


        objdataadapter.SelectCommand = New System.Data.SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select DISTINCT(��������) from TRUCK_QUEUE where 1=1 order by �������� desc"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "PICI")

        objdataview = New DataView(objdataset.Tables("PICI"))
        ' Application.DoEvents()
        ' MessageBox.Show(objdataview.Count)
        TXT_PICI.Items.Clear()
        ' On Error Resume Next
        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                If Len(objdataview.Item(a).Item("��������").ToString) <> 0 Then
                    Application.DoEvents()
                    TXT_PICI.Items.Add(Trim(objdataview.Item(a).Item("��������")))
                End If
            Next
        End If
        '  Application.DoEvents()

 




        objconnection.Close()




    End Sub

   

    Private Sub TXT_PICI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_PICI.SelectedIndexChanged
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from TRUCK_QUEUE where ��������= '" & Trim(TXT_PICI.Text) & "'"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "trade")
        objdataview = New DataView(objdataset.Tables("trade"))
        DGV.DataSource = objdataview

        DGV.AllowUserToAddRows = False '�������һ��
    End Sub

 

    Private Sub DGV_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        On Error Resume Next
        If DGV.Rows(e.RowIndex).Cells("ExistBill").Value Is DBNull.Value Then

        Else

            e.CellStyle.BackColor = Color.YellowGreen

        End If

    End Sub

  
    Private Sub TXT_PATH_Click(sender As Object, e As EventArgs) Handles TXT_PATH.Click

    End Sub
End Class