Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Imports System.Windows.Forms

Public Class AIP1
    Dim objdataset As New DataSet
    Dim objdataview As New DataView
    Dim objdataadapter As New SqlClient.SqlDataAdapter
    Dim HR_Manager, FICO_Manager, General_Manager, Trade_Manager, Production_Manager, QCQA_Manager, Storage_Manager, Equipment_Manager, Safe_Manager, IT_Manager As String
    Dim HR_Group, FICO_Group, General_Group, Trade_Group, Production_Group, QCQA_Group, Storage_Group, Equipment_Group, Safe_Group, IT_Group As String
    Dim DeptManager, AIPWORK, HETONGZHANGMAOYISHENHE, HETONGZHANGCAIWUSHENHE, SILIAOManager, ZONGLVYOUManager, DADOUYOUManager, LYGGOBOSS As String
    Dim AIPSealLevelNowUser As String
    Dim AIPSealLevelTotal, AIPSealLevelNow As Integer '存放所选流程审批节点的数量

    Private Sub SQLManager()
        Dim A As Integer
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select * from Users where UserCompanyID='" & Trim(isCompanyID.Text) & "' and isDeptManagerSign=1"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "Users")

        objdataview = New DataView(objdataset.Tables("Users"))


        If objdataview.Count >= 1 Then

            For A = 0 To objdataview.Count - 1

                Select Case Trim(objdataview.Item(A).Item(3))
                    Case "人事行政部"
                        HR_Manager = Trim(objdataview.Item(A).Item("Username"))
                    Case "财务部"
                        FICO_Manager = Trim(objdataview.Item(A).Item("Username"))
                    Case "储运部"
                        Storage_Manager = Trim(objdataview.Item(A).Item("Username"))
                    Case "贸易部"
                        Trade_Manager = Trim(objdataview.Item(A).Item("Username"))
                    Case "品管部"
                        QCQA_Manager = Trim(objdataview.Item(A).Item("Username"))
                    Case "生产部"
                        Production_Manager = Trim(objdataview.Item(A).Item("Username"))
                    Case "设备部"
                        Equipment_Manager = Trim(objdataview.Item(A).Item("Username"))
                    Case "安全部"
                        Safe_Manager = Trim(objdataview.Item(A).Item("Username"))
                    Case "IT部"
                        IT_Manager = Trim(objdataview.Item(A).Item("Username"))
                End Select

            Next


        End If

        Select Case UserDeptvar
            Case "人事行政部"
                DeptManager = HR_Manager
            Case "财务部"
                DeptManager = FICO_Manager
            Case "储运部"
                DeptManager = Storage_Manager
            Case "贸易部"
                DeptManager = Trade_Manager
            Case "品管部"
                DeptManager = QCQA_Manager
            Case "生产部"
                DeptManager = Production_Manager
            Case "设备部"
                DeptManager = Equipment_Manager
            Case "安全部"
                DeptManager = Safe_Manager
            Case "IT部"
                DeptManager = IT_Manager
        End Select

        '如果是DataTable:
        '  this.TableName.Rows[0]["列名"].ToString();   
        '如果是DataView:
        '  DataView   dv=new   DataView("tablename");   
        '  dv[0]   
        '如果是DataSet:
        '  DataSet   ds=new   DataSet();   
        '  ds.Tables[0].Rows[0]["列名"].TosString();




    End Sub

    Private Sub SQLFlow()
 

        If Trim(isCompanyID.Text) = "LYG-GO" Then

            Dim da As New SqlClient.SqlDataAdapter("Select * from [AIP_Ing_Sign] where id=0", objconnection)
            Dim MyCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)
            Dim ds As New DataSet()
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey
            Dim myRow As DataRow
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            da.Fill(ds, "SignFlow")
            myRow = ds.Tables("SignFlow").NewRow()


            Select Case Trim(AIPTYPE.Text)
                Case "公章"

                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 1
                    myRow("flowApprover") = Usernamevar
                    myRow("flowApprovertime") = Now
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 2
                    myRow("flowApprover") = DeptManager
                    ' myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 3
                    myRow("flowApprover") = AIPWORK
                    ' myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------

                Case "合同章-销售合同"
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 1
                    myRow("flowApprover") = Usernamevar
                    myRow("flowApprovertime") = Now
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 2
                    myRow("flowApprover") = HETONGZHANGMAOYISHENHE
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 3
                    myRow("flowApprover") = HETONGZHANGCAIWUSHENHE
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 4
                    myRow("flowApprover") = AIPWORK
                    ' myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)

                Case "合同章-饲料销售合同"
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 1
                    myRow("flowApprover") = Usernamevar
                    myRow("flowApprovertime") = Now
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 2
                    myRow("flowApprover") = HETONGZHANGMAOYISHENHE
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 3
                    myRow("flowApprover") = SILIAOManager
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 4
                    myRow("flowApprover") = HETONGZHANGCAIWUSHENHE
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 5
                    myRow("flowApprover") = AIPWORK
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                Case "合同章-棕榈油采购-销售合同-800T以下"
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 1
                    myRow("flowApprover") = Usernamevar
                    myRow("flowApprovertime") = Now
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 2
                    myRow("flowApprover") = HETONGZHANGMAOYISHENHE
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 3
                    myRow("flowApprover") = ZONGLVYOUManager
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 4
                    myRow("flowApprover") = HETONGZHANGCAIWUSHENHE
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 5
                    myRow("flowApprover") = AIPWORK
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)

                Case "合同章-棕榈油采购-销售合同-800T以上"
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 1
                    myRow("flowApprover") = Usernamevar
                    myRow("flowApprovertime") = Now
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 2
                    myRow("flowApprover") = HETONGZHANGMAOYISHENHE
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 3
                    myRow("flowApprover") = ZONGLVYOUManager
                    ' myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 4
                    myRow("flowApprover") = FICO_Manager
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 5
                    myRow("flowApprover") = LYGGOBOSS
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '----------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 6
                    myRow("flowApprover") = AIPWORK
                    ' myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)


                Case "合同章-油类采购-销售合同-200T以下"
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 1
                    myRow("flowApprover") = Usernamevar
                    myRow("flowApprovertime") = Now
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 2
                    myRow("flowApprover") = HETONGZHANGMAOYISHENHE
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 3
                    myRow("flowApprover") = DADOUYOUManager
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 4
                    myRow("flowApprover") = HETONGZHANGCAIWUSHENHE
                    ' myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 5
                    myRow("flowApprover") = AIPWORK
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '----------------------------------------------
                Case "合同章-油类采购-销售合同-200T以上"
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 1
                    myRow("flowApprover") = Usernamevar
                    myRow("flowApprovertime") = Now
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 2
                    myRow("flowApprover") = HETONGZHANGMAOYISHENHE
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 3
                    myRow("flowApprover") = DADOUYOUManager
                    ' myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 4
                    myRow("flowApprover") = FICO_Group
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 5
                    myRow("flowApprover") = LYGGOBOSS
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '----------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 6
                    myRow("flowApprover") = AIPWORK
                    ' myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                Case "合同章-销售合同以外合同"
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 1
                    myRow("flowApprover") = Usernamevar
                    myRow("flowApprovertime") = Now
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 2
                    myRow("flowApprover") = HETONGZHANGMAOYISHENHE
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 3
                    myRow("flowApprover") = HETONGZHANGCAIWUSHENHE
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 4
                    myRow("flowApprover") = "chenqibin"
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 5
                    myRow("flowApprover") = AIPWORK
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)


                Case "法人章"
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 1
                    myRow("flowApprover") = Usernamevar
                    myRow("flowApprovertime") = Now
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 2
                    myRow("flowApprover") = FICO_Manager
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 3
                    myRow("flowApprover") = "chenqibin"
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 4
                    myRow("flowApprover") = AIPWORK
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                Case "测试章"
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 1
                    myRow("flowApprover") = Usernamevar
                    myRow("flowApprovertime") = Now
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow = ds.Tables("SignFlow").NewRow()
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 2
                    myRow("flowApprover") = Usernamevar
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow = ds.Tables("SignFlow").NewRow()
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 3
                    myRow("flowApprover") = Usernamevar
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)
                    '---------------------------------------------------------------------------------------
                    myRow = ds.Tables("SignFlow").NewRow()
                    myRow("flowID") = FILEID
                    myRow("flowLevel") = 4
                    myRow("flowApprover") = AIPWORK
                    'myRow("flowApprovertime") = NULL
                    ds.Tables("SignFlow").Rows.Add(myRow)

                    da.Update(ds, "SignFlow")

                    MessageBox.Show("审批节点已全部设置完成！", "文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    '---------------------------------------------------------------------------------------

            End Select
        End If

     
    End Sub
    Private Sub SetLevelNowAndUser()    '获取下个审批节点的level和username
        objdataadapter = New SqlClient.SqlDataAdapter
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandType = CommandType.Text

        objdataadapter.SelectCommand.CommandText = "select  * from [AIP_Ing_Sign] where flowid='" & FILEID.Text & "'"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "AIP_ing_Sign")
        objdataview = New DataView(objdataset.Tables("AIP_ing_Sign"))


        AIPSealLevelNow = objdataview.Item(AIPSealLevelNow).Item(2)
        AIPSealLevelNowUser = objdataview.Item(AIPSealLevelNow).Item(3)


        MessageBox.Show("已获取下个审批节点！", "文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub TEMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AIPSealLevelNow = 1
        Dim Resources As New System.ComponentModel.ComponentResourceManager(GetType(AIP1))
        'Dim axHWPostil1 = New AxHWPOSTILLib.AxHWPostil()
        '--------------------------------------------------------------------------
        'objconnection = New SqlConnection("Data Source= '10.229.17.6,1433';Initial Catalog = AIP;User ID='sa'; Password='chen dong'")
        axHWPostil1.ShowDefMenu = 0
        axHWPostil1.ShowScrollBarButton = 0
        axHWPostil1.ShowToolBar = 0
        ADDCOMBO()
        yidengji.AllowUserToAddRows = False
        AIPWORK = "yihuimen"      '签章人
        HETONGZHANGCAIWUSHENHE = "xuai"
        HETONGZHANGMAOYISHENHE = "yemilin"
        SILIAOManager = "zhuxiongliang"
        ZONGLVYOUManager = "xuyanqing"
        DADOUYOUManager = "xuminghong"
        LYGGOBOSS = "fangchangqing"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        axHWPostil1.Login("", 1, 65535, "", "")
        axHWPostil1.CurrAction = 2568
    End Sub


    Private Sub LABEL_BILL_Click(sender As Object, e As EventArgs) Handles LABEL_BILL.Click
        ' opd.Filter = "代签文件|*.pdf;*.doc;*.docx;*.xls;*.xlsx;*.jpg"
        opd.Filter = "代签文件|*.pdf;*.doc;*.docx;*.xls;*.xlsx;*.jpg"
        opd.ShowDialog()
        ing.Visible = True
        axHWPostil1.LoadFile(opd.FileName)
        'axHWPostil1.SetPageMode(1, 100)

        'TXT_PATH.Text = axHWPostil1.PathName
        filename.Text = opd.SafeFileName.Substring(0, Len(opd.SafeFileName) - Len(System.IO.Path.GetExtension(opd.FileName)))
        FileExtemsion.Text = System.IO.Path.GetExtension(opd.FileName)

        FILEID.Text = Format(Now, "yyyyMMddHHmmss") + Int(Rnd() * 100)
        ing.Visible = False

        '　
    End Sub

    Private Sub ADDCOMBO()
        Dim A As Integer
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select distinct(AIPSealType) from AIP_Ing_SealKeeper where isenable=1 "
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "AIPSealType")

        objdataview = New DataView(objdataset.Tables("AIPSealType"))

        ' MessageBox.Show(objdataview.Count)
        AIPTYPE.Items.Clear()

        If objdataview.Count >= 1 Then
            For A = 0 To objdataview.Count - 1
                AIPTYPE.Items.Add(objdataview.Item(A).Item("AIPSealType"))
            Next
        End If
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

        '   Try

        If Len(FILETYPE.Text) > 0 And Len(AIPTYPE.Text) > 0 And Len(AIPTYPE.Text) > 0 Then




            '------------------------------------------------------------------------------------------------保存前需要删除重复文件名的
            'Dim objcommanddel As New SqlClient.SqlCommand
            'objcommanddel.Connection = objconnection
            'objcommanddel.CommandText = "Delete from AIP_ING where Filename='" & Trim(filename.Text) & "'"

            'If objconnection.State = ConnectionState.Closed Then
            '    objconnection.Open()
            'End If

            'objcommanddel.ExecuteNonQuery()


            '---------------------------------------------------------------------------------------------

            Dim fi As IO.FileInfo
            Dim fs As IO.FileStream
            Dim da As New SqlClient.SqlDataAdapter("Select * from AIP_ing_TEST where id=0", objconnection)
            Dim MyCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)
            Dim ds As New DataSet()
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey
            Dim myRow As DataRow
            'Dim fname As String


            axHWPostil1.SaveTo(axHWPostil1.PathName, "", 0)
            'For Each fname In opd.FileNames  '适合于多选文件的遍历，今后会用到

            fi = New IO.FileInfo(axHWPostil1.PathName)

            ''MessageBox.Show(fname)
            fs = New IO.FileStream(axHWPostil1.PathName, IO.FileMode.OpenOrCreate, IO.FileAccess.Read)

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
            myRow("UploadUserCompany") = Trim(isCompany.Text)
            myRow("UploadUserCompanyID") = Trim(isCompanyID.Text)
            myRow("UploadUserGroup") = Trim(isDept.Text)
            myRow("UploadUserID") = useridvar

            SQLManager() '部门经理处理
            SQLFlow()   '流程节点的创建

            SetLevelNowAndUser()  '查找到下一节点的No和名字

            myRow("isAIP") = 1
            myRow("AIPSealType") = Trim(AIPTYPE.Text)
            myRow("AIPSealLevelNow") = AIPSealLevelNow
            myRow("AIPSealLevelTotal") = AIPSealLevelTotal
            myRow("AIPSealLevelNowUser") = AIPSealLevelNowUser

            myRow("AIPDONE") = 0
            myRow("Remarks") = Trim(fileLocation.Text)




            ds.Tables("UPLOADPDFFILE").Rows.Add(myRow)
            da.Update(ds, "UPLOADPDFFILE")


            ' Next


            fs = Nothing
            MyCB = Nothing
            ds = Nothing
            da = Nothing

            MessageBox.Show("签章文件已保存!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            'axHWPostil1.LoadFile("")
            ' axHWPostil1.SetPageMode(2, 0)
            'axHWPostil1.CloseDoc(0)
            ShowData()

        Else
            MessageBox.Show("文件信息不完整!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


        '  Catch ex As Exception
        ' MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        '  End Try

    End Sub

    Private Sub ShowData()

        objdataadapter = New SqlClient.SqlDataAdapter
        objdataadapter.SelectCommand = New SqlClient.SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandType = CommandType.Text

        objdataadapter.SelectCommand.CommandText = "select  [FileName] ,[FileSize] ,[FileExtension],[FileType],[FileID],[UploadTime],[UploadUser],[UploadUserID],[UploadUserCompany],[UploadUserGroup],[AIPSealType],[AIPDone],Remarks from AIP_ing_TEST where fileid='" & FILEID.Text & "'"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "AIP_ing")

        objdataview = New DataView(objdataset.Tables("AIP_ing"))

        yidengji.DataSource = objdataview


    End Sub







    Private Sub isCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles isCompany.SelectedIndexChanged

        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select UserCompanyID from Users where UserCompany='" & Trim(isCompany.Text) & "'"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "UserCompanyID")

        objdataview = New DataView(objdataset.Tables("UserCompanyID"))


        If objdataview.Count >= 1 Then

            isCompanyID.Text = (objdataview.Item(0).Item("UserCompanyID"))

        End If



        '------------------------------------------------------------------------------------------
        Dim a As Integer
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select distinct(UserDept) from Users where UserCompany='" & Trim(isCompany.Text) & "'"
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "UserDept")

        objdataview = New DataView(objdataset.Tables("UserDept"))

        ' MessageBox.Show(objdataview.Count)
        isDept.Items.Clear()

        If objdataview.Count >= 1 Then
            For a = 0 To objdataview.Count - 1
                isDept.Items.Add(objdataview.Item(a).Item("UserDept"))
            Next
        End If


    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        SQLManager()

    End Sub



    Private Sub AIPTYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AIPTYPE.SelectedIndexChanged
        Select Case Trim(AIPTYPE.Text)
            Case "公章"
                AIPSealLevelTotal = 3
            Case "法人章"
                AIPSealLevelTotal = 4
            Case "合同章-销售合同"
                AIPSealLevelTotal = 4
            Case "合同章-饲料销售合同"
                AIPSealLevelTotal = 5
            Case "合同章-棕榈油采购-销售合同-800T以下"
                AIPSealLevelTotal = 5
            Case "合同章-棕榈油采购-销售合同-800T以上"
                AIPSealLevelTotal = 6
            Case "合同章-油类采购-销售合同-200T以下"
                AIPSealLevelTotal = 5
            Case "合同章-油类采购-销售合同-200T以上"
                AIPSealLevelTotal = 6
            Case "合同章-销售合同以外合同"
                AIPSealLevelTotal = 5
            Case "测试章"
                AIPSealLevelTotal = 4
        End Select

        'MessageBox.Show(AIPSealLevelTotal)
    End Sub
End Class