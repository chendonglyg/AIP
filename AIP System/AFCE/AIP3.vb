Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Public Class AIP3
    Dim forreport As New SqlDataAdapter
    Public afterdel As String
    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet
    Dim TabNo As Integer
    Dim AIPSealLevelTotal, AIPSealLevelNow As Integer '存放所选流程审批节点的数量
    Dim AIPSealLevelNowUser As String
    Dim GetTimeNow As New GetTimeNow.CTEnterprisesSoapClient




   
    Private Sub AIP3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isadmin = True Then
            isCompany.Enabled = True
        Else
            isCompany.Enabled = False
        End If
        isCompany.Text = Usercompanyvar
        Username.Text = Usernamevar
        UserCompany.Text = Usercompanyvar
        UserGroup.Text = Usergroupvar
        UserDept.Text = UserDeptvar
        'Dim axHWPostil1 = New AxHWPOSTILLib.AxHWPostil()
        '--------------------------------------------------------------------------
        'objconnection = New SqlConnection("Data Source= '10.229.17.6,1433';Initial Catalog = AIP;User ID='sa'; Password='chen dong'")
        AxHWPostil1.ShowDefMenu = 0
        AxHWPostil1.ShowScrollBarButton = 0
        AxHWPostil1.ShowToolBar = 0
        ADDCOMBO()
        yidengji1.AllowUserToAddRows = False
        yidengji2.AllowUserToAddRows = False
        yidengji3.AllowUserToAddRows = False
        TabNo = 1
        ing.Visible = False
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

    Private Sub ShowDataPDF()

        '  Try



        If Len(IDID.Text) > 0 Then



            Dim SEL As String = "C:\windows\temp\lkfjlksfjlflksjfkfjkslfj.PDF"

            System.IO.File.Delete(SEL)

            Dim SQLSEL As String = "Select id,FileData from AIP_ing_TEST where id = " & IDID.Text

            Dim myRow As DataRow


            Dim da As New SqlClient.SqlDataAdapter(SQLSEL, objconnection)

            Dim MyCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)
            Dim ds As New DataSet()

            da.Fill(ds, "COA")
            objdataview = New DataView(ds.Tables("COA"))

            If objdataview.Count > 0 Then

                myRow = ds.Tables("COA").Rows(0)



                Dim MyData() As Byte
                MyData = myRow("Filedata")

                Dim ArraySize As Integer
                ArraySize = MyData.GetUpperBound(0)




                Dim fs As New IO.FileStream(SEL, IO.FileMode.OpenOrCreate, IO.FileAccess.Write)
                fs.Write(MyData, 0, ArraySize)
                fs.Close()

                Select Case TabNo
                    Case 1
                        AxHWPostil1.LoadFile(SEL)
                        AxHWPostil1.SetPageMode(2, 0)
                    Case 2
                        AxHWPostil2.LoadFile(SEL)
                        AxHWPostil2.SetPageMode(2, 0)
                    Case 3
                        AxHWPostil3.LoadFile(SEL)
                        AxHWPostil3.SetPageMode(2, 0)
                End Select
            End If
        End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

        'End Try


    End Sub



    Private Sub ShowData()
        If Len(YearSum.Text) > 0 Then
            objdataadapter = New SqlClient.SqlDataAdapter
            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandType = CommandType.Text
            If isadmin Then
                objdataadapter.SelectCommand.CommandText = "select [id],[FileName] ,[FileSize] ,[FileExtension] ,[FileType] ,[FileID] ,[UploadTime] ,[UploadUser] ,[UploadUserID] ,[UploadUserCompany] ,[UploadUserCompanyID] ,[UploadUserGroup] ,[AIPSealType] ,[AIPDone] ,[Remarks] from AIP_ing_TEST where Datename(yyyy,UploadTime)='" & Trim(YearSum.Text) & "' and FileName like '%" & Trim(FILE_NAME.Text) & "%' and AIPDONE=1 "
            Else
                objdataadapter.SelectCommand.CommandText = "select [id],[FileName] ,[FileSize] ,[FileExtension] ,[FileType] ,[FileID] ,[UploadTime] ,[UploadUser] ,[UploadUserID] ,[UploadUserCompany] ,[UploadUserCompanyID] ,[UploadUserGroup] ,[AIPSealType] ,[AIPDone] ,[Remarks] from AIP_ing_TEST where Datename(yyyy,UploadTime)='" & Trim(YearSum.Text) & "' and FileName like '%" & Trim(FILE_NAME.Text) & "%' and " & "[UploadUserCompany] =‘" & Trim(isCompany.Text) & "' and " & "[UploadUserGroup] =‘" & Trim(isDept.Text) & "' and AIPDONE=1"
            End If



            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "COA")

            objdataview = New DataView(objdataset.Tables("COA"))

            yidengji1.DataSource = objdataview

            yidengji1.Columns(0).Width = 0
            yidengji1.Columns(1).Width = 500
        Else
            MessageBox.Show("请先选择年度!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


    End Sub
    Private Sub FILE_NAME_KeyDown(sender As Object, e As KeyEventArgs) Handles FILE_NAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            ShowData()
        End If
    End Sub


    Private Sub yidengji1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles yidengji1.CellContentClick
        On Error Resume Next
        TabNo = 1

        IDID.Text = Trim(yidengji1.Rows(e.RowIndex).Cells(0).Value)
        Filename.Text = Trim(yidengji1.Rows(e.RowIndex).Cells(1).Value)
   
    End Sub

    Private Sub yidengji2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles yidengji2.CellContentClick


        On Error Resume Next
        FileID.Text = Trim(yidengji2.Rows(e.RowIndex).Cells(5).Value)

        AIPSealLevelNowTxT.Text = Trim(yidengji2.Rows(e.RowIndex).Cells(13).Value)
        AIPSealLevelNow = Val(yidengji2.Rows(e.RowIndex).Cells(13).Value)

        AIPSealLevelNowUserTxT.Text = Trim(yidengji2.Rows(e.RowIndex).Cells(14).Value)
        AIPSealLevelNowUser = Trim(yidengji2.Rows(e.RowIndex).Cells(14).Value)


        AIPSealLevelTotalTxT.Text = Trim(yidengji2.Rows(e.RowIndex).Cells(15).Value)
        AIPSealLevelTotal = Val(yidengji2.Rows(e.RowIndex).Cells(15).Value)
        '---------------------------------------------------------------------------------------------


        IDID.Text = Trim(yidengji2.Rows(e.RowIndex).Cells(0).Value)
        Filename.Text = Trim(yidengji2.Rows(e.RowIndex).Cells(1).Value)

        ShowNowAndUserList()
    End Sub

    Private Sub TabItem2_Click(sender As Object, e As EventArgs) Handles TabItem2.Click
        TabNo = 2

        ShowNeedApprove()
        ShowSign.DataSource = Nothing

    End Sub

    Private Sub TabItem3_Click(sender As Object, e As EventArgs) Handles TabItem3.Click
        TabNo = 3
     

            '--------------------------------
        objdataadapter = New SqlClient.SqlDataAdapter
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandType = CommandType.Text

        objdataadapter.SelectCommand.CommandText = "SELECT TOP (100) A.[id] ,[FileName],[FileSize],[FileExtension],[FileType] ,[FileID] ,[UploadTime] ,[UploadUser]" & _
            ",[UploadUserID],[UploadUserCompany] ,[UploadUserCompanyID]" & _
            ",[UploadUserGroup],[isAIP],[AIPSealType],[AIPSealLevelNow],[AIPSealLevelNowUser] ,[AIPSealLevelTotal] ,[AIPDone],A.[Remarks],B.[flowApprovertime]" & _
            "FROM AIP_ing_TEST A,AIP_Ing_Sign B where A.FileID=B.FlowID  and B.flowApprover='" & Trim(Usernamevar) & "'"
   

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "ApproveDone")
        objdataview = New DataView(objdataset.Tables("ApproveDone"))
        yidengji3.DataSource = objdataview
        yidengji3.Columns(0).Width = 0

        If isadmin = True Then   '如果是管理员那么AIPDone功能变为有效
            ButtonItem4.Enabled = True

        Else
            ButtonItem4.Enabled = False
        End If
    End Sub

    Private Sub TabItem1_Click(sender As Object, e As EventArgs) Handles TabItem1.Click
        TabNo = 1
    End Sub

    Private Sub ShowNeedApprove()
        '--------------------------------
        objdataadapter = New SqlClient.SqlDataAdapter
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandType = CommandType.Text
        If isadmin Then
            objdataadapter.SelectCommand.CommandText = "select [id],[FileName] ,[FileSize] ,[FileExtension] ,[FileType] ,[FileID] ,[UploadTime] ,[UploadUser] ,[UploadUserID] ,[UploadUserCompany] ,[UploadUserCompanyID] ,[UploadUserGroup] ,[isAIP],[AIPSealLevelNow],[AIPSealLevelNowUser],[AIPSealLevelTotal],[AIPSealType] ,[AIPDone] ,[Remarks] from AIP_ing_TEST where [AIPSealLevelNowUser]='" & Trim(Usernamevar) & "' and AIPDONE<>1"
        Else
            objdataadapter.SelectCommand.CommandText = "select [id],[FileName] ,[FileSize] ,[FileExtension] ,[FileType] ,[FileID] ,[UploadTime] ,[UploadUser] ,[UploadUserID] ,[UploadUserCompany] ,[UploadUserCompanyID] ,[UploadUserGroup] ,[isAIP],[AIPSealLevelNow],[AIPSealLevelNowUser],[AIPSealLevelTotal][AIPSealType] ,[AIPDone] ,[Remarks] from AIP_ing_TEST where [AIPSealLevelNowUser]='" & Trim(Usernamevar) & "' and AIPDONE<>1"
        End If

        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "Approve")

        objdataview = New DataView(objdataset.Tables("Approve"))

        yidengji2.DataSource = objdataview

        yidengji2.Columns(0).Width = 0

    End Sub

  
   
   
    Private Sub ButtonItem2_Click(sender As Object, e As EventArgs) Handles ButtonItem2.Click


            Dim objcommandpassword As New SqlCommand
            objcommandpassword.Connection = objconnection
            objcommandpassword.CommandText = "Update AIP_Ing_Sign set  flowApprovertime=@flowApprovertime where flowID=" & Val(FileID.Text) & "and flowLevel=" & Val(AIPSealLevelNowTxT.Text) '这里的审批级数还是目前审批人的级数
            objcommandpassword.Parameters.AddWithValue("@flowApprovertime", GetTimeNow.getDateTime)   '说明不是最后一个人，后面应该继续设置下一级和审批人名

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objcommandpassword.ExecuteNonQuery()
            objconnection.Close()
        MessageBox.Show("审批完成!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


        If AIPSealLevelNow < AIPSealLevelTotal Then    '说明还么有签完,要设置下个级数和审批人

            SetNextLevelNowAndUser()


            Dim ObjCommandSetAIP_Ing As New SqlCommand
            ObjCommandSetAIP_Ing.Connection = objconnection
            ObjCommandSetAIP_Ing.CommandText = "Update AIP_ing_TEST set  AIPSealLevelNow=@AIPSealLevelNow,AIPSealLevelNowUser=@AIPSealLevelNowUser where fileID=" & Val(FileID.Text)  '这里的审批级数还是目前审批人的级数
            ObjCommandSetAIP_Ing.Parameters.AddWithValue("@AIPSealLevelNow", AIPSealLevelNow)
            ObjCommandSetAIP_Ing.Parameters.AddWithValue("@AIPSealLevelNowUser", AIPSealLevelNowUser)

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            ObjCommandSetAIP_Ing.ExecuteNonQuery()
            objconnection.Close()
            MessageBox.Show("文件下一审批节点设置完成!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Else
            Dim ObjCommandSetAIP_Ing As New SqlCommand  '说明审批结束，只需要设置AIPDONE=1
            ObjCommandSetAIP_Ing.Connection = objconnection
            ObjCommandSetAIP_Ing.CommandText = "Update AIP_ing_TEST set  AIPDONE=1 where fileID=" & Val(FileID.Text)

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            ObjCommandSetAIP_Ing.ExecuteNonQuery()
            objconnection.Close()
            MessageBox.Show("文件已全部审批完成!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)



        End If

    End Sub

    Private Sub SetNextLevelNowAndUser() '用于获取下一节点审批级数和审批人


        objdataadapter = New SqlClient.SqlDataAdapter
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandType = CommandType.Text

        objdataadapter.SelectCommand.CommandText = "select  * from [AIP_Ing_Sign] where flowid='" & Trim(FileID.Text) & "' order by FlowLevel"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "AIP_ing_Sign")
        objdataview = New DataView(objdataset.Tables("AIP_ing_Sign"))
        ShowSign.DataSource = objdataview


        Dim AIPCount As Integer = AIPSealLevelNow
        AIPSealLevelNow = Val(objdataview.Item(AIPCount).Item(2))
        AIPSealLevelNowUser = Trim(objdataview.Item(AIPCount).Item(3))




    End Sub
    Private Sub ShowNowAndUserList()
        objdataadapter = New SqlClient.SqlDataAdapter
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandType = CommandType.Text

        objdataadapter.SelectCommand.CommandText = "select  * from [AIP_Ing_Sign] where flowid='" & Trim(FileID.Text) & "' order by FlowLevel"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "AIP_ing_Sign")
        objdataview = New DataView(objdataset.Tables("AIP_ing_Sign"))
        ShowSign.DataSource = objdataview


    End Sub

 
  
    Private Sub ButtonItem5_Click(sender As Object, e As EventArgs) Handles ButtonItem5.Click
        ing.Visible = True
        AxHWPostil2.CloseDoc(0)
        ShowDataPDF()
        ing.Visible = False
    End Sub



    Private Sub ButtonItem7_Click(sender As Object, e As EventArgs) Handles ButtonItem7.Click
        ing.Visible = True
        AxHWPostil1.CloseDoc(0)
        ShowDataPDF()
        ing.Visible = False
    End Sub

    Private Sub yidengji3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles yidengji3.CellContentClick
        On Error Resume Next
        FileID.Text = Trim(yidengji3.Rows(e.RowIndex).Cells(5).Value)

        AIPSealLevelNowTxT.Text = Trim(yidengji3.Rows(e.RowIndex).Cells(13).Value)
        AIPSealLevelNow = Val(yidengji3.Rows(e.RowIndex).Cells(13).Value)

        AIPSealLevelNowUserTxT.Text = Trim(yidengji3.Rows(e.RowIndex).Cells(14).Value)
        AIPSealLevelNowUser = Trim(yidengji3.Rows(e.RowIndex).Cells(14).Value)


        AIPSealLevelTotalTxT.Text = Trim(yidengji3.Rows(e.RowIndex).Cells(15).Value)
        AIPSealLevelTotal = Val(yidengji3.Rows(e.RowIndex).Cells(15).Value)
        '---------------------------------------------------------------------------------------------


        IDID.Text = Trim(yidengji3.Rows(e.RowIndex).Cells(0).Value)
        Filename.Text = Trim(yidengji3.Rows(e.RowIndex).Cells(1).Value)
    End Sub



    Private Sub ButtonItem9_Click(sender As Object, e As EventArgs) Handles ButtonItem9.Click
        ing.Visible = True
        AxHWPostil3.CloseDoc(0)
        ShowDataPDF()
        ing.Visible = False
    End Sub
End Class