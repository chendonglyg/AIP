Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.Windows.Forms
Public Class AIP2

    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter


    Private Sub AIP2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isCompany.Text = Usercompanyvar
        isCompanyid.Text = Usercompanyidvar
        isDept.Text = UserDeptvar
        Username.Text = Usernamevar
        yidengji.AllowUserToAddRows = False

        isCompany.Enabled = False
        isCompanyid.Enabled = False
        isDept.Enabled = False


    End Sub

    Private Sub ADDCOMBO()
        Dim A As Integer

        '---------------------------------------------------------------------------------------
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select distinct(UserCompany) from Users "
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "UserCompany")

        objdataview = New DataView(objdataset.Tables("UserCompany"))

        ' MessageBox.Show(objdataview.Count)
        isCompany.Items.Clear()

        If objdataview.Count >= 1 Then
            For A = 0 To objdataview.Count - 1
                isCompany.Items.Add(objdataview.Item(A).Item("UserCompany"))
            Next
        End If
        '-------------------------------------------------------------------------------------------



    End Sub

    Private Sub BUT_START_Click(sender As Object, e As EventArgs) Handles BUT_START.Click

        Try


            '------------------------------------------------------------------------------------------------保存前需要删除重复文件名的
            'Dim objcommanddel As New SqlClient.SqlCommand
            'objcommanddel.Connection = objconnection
            'objcommanddel.CommandText = "Delete from AIPDATA2018 where Filename='" & Trim(filename.Text) & "'"

            'If objconnection.State = ConnectionState.Closed Then
            '    objconnection.Open()
            'End If

            'objcommanddel.ExecuteNonQuery()


            '---------------------------------------------------------------------------------------------



            If Len(FILETYPE.Text) > 0 And Len(isCompany.Text) > 0 And Len(isCompanyid.Text) > 0 And Len(isDept.Text) > 0 Then
                Dim fi As IO.FileInfo
                Dim fs As IO.FileStream
                Dim da As New SqlClient.SqlDataAdapter("Select * from AIP_ing where id=0", objconnection)
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

                    myRow("filedata") = MyData
                    myRow("filesize") = fi.Length
                    myRow("filename") = fi.Name
                    myRow("fileExtension") = fi.Extension
                    myRow("Filetype") = Trim(FILETYPE.Text)
                    myRow("FileID") = Trim(FILEID.Text)

                    myRow("UploadUser") = Usernamevar
                    myRow("Uploadtime") = Now
                    myRow("UploadUserCompany") = Usercompanyvar
                    myRow("UploadUserCompanyID") = Usercompanyidvar
                    myRow("UploadUserGroup") = Usergroupvar
                    myRow("UploadUserID") = useridvar
                    myRow("isAIP") = 0
                    myRow("AIPDONE") = 1 '不需要签章的文件直接设置AIPDONE是True
                    myRow("Remarks") = Trim(fileLocation.Text)
                    ds.Tables("UPLOADPDFFILE").Rows.Add(myRow)
                    da.Update(ds, "UPLOADPDFFILE")


                Next


                fs = Nothing
                MyCB = Nothing
                ds = Nothing
                da = Nothing

                MessageBox.Show("文件已保存!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                axHWPostil1.LoadFile(opd.FileName)
                axHWPostil1.SetPageMode(2, 0)
                ShowData()

            Else
                MessageBox.Show("文件信息不完整!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Private Sub ShowData()

        objdataadapter = New SqlClient.SqlDataAdapter
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandType = CommandType.Text

        objdataadapter.SelectCommand.CommandText = "select  [FileName] ,[FileSize] ,[FileExtension],[FileType],[FileID],[UploadTime],[UploadUser],[UploadUserID],[UploadUserCompany],[UploadUserGroup],[AIPSealType],[AIPDone],Remarks from AIP_ing where fileid='" & FILEID.Text & "'"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "AIP_ing")

        objdataview = New DataView(objdataset.Tables("AIP_ing"))

        yidengji.DataSource = objdataview
    End Sub

    Private Sub LABEL_BILL_Click(sender As Object, e As EventArgs) Handles LABEL_BILL.Click
        ' opd.Filter = "代签文件|*.pdf;*.doc;*.docx;*.xls;*.xlsx;*.jpg"
        opd.Filter = "代签文件|*.pdf;*.doc;*.docx;*.xls;*.xlsx;*.jpg"
        opd.ShowDialog()
        ing.Visible = True
        axHWPostil1.LoadFile(opd.FileName)
        'axHWPostil1.SetPageMode(1, 100)


        filename.Text = opd.SafeFileName.Substring(0, Len(opd.SafeFileName) - Len(System.IO.Path.GetExtension(opd.FileName)))
        FileExtemsion.Text = System.IO.Path.GetExtension(opd.FileName)

        FILEID.Text = Format(Now, "yyyyMMddHHmmss") + Int(Rnd() * 100)
        ing.Visible = False

    End Sub
End Class