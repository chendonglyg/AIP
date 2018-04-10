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
    Dim AIPSealLevelTotal, AIPSealLevelNow As Integer '�����ѡ���������ڵ������

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
                    Case "����������"
                        HR_Manager = Trim(objdataview.Item(A).Item("Username"))
                    Case "����"
                        FICO_Manager = Trim(objdataview.Item(A).Item("Username"))
                    Case "���˲�"
                        Storage_Manager = Trim(objdataview.Item(A).Item("Username"))
                    Case "ó�ײ�"
                        Trade_Manager = Trim(objdataview.Item(A).Item("Username"))
                    Case "Ʒ�ܲ�"
                        QCQA_Manager = Trim(objdataview.Item(A).Item("Username"))
                    Case "������"
                        Production_Manager = Trim(objdataview.Item(A).Item("Username"))
                    Case "�豸��"
                        Equipment_Manager = Trim(objdataview.Item(A).Item("Username"))
                    Case "��ȫ��"
                        Safe_Manager = Trim(objdataview.Item(A).Item("Username"))
                    Case "IT��"
                        IT_Manager = Trim(objdataview.Item(A).Item("Username"))
                End Select

            Next


        End If

        Select Case UserDeptvar
            Case "����������"
                DeptManager = HR_Manager
            Case "����"
                DeptManager = FICO_Manager
            Case "���˲�"
                DeptManager = Storage_Manager
            Case "ó�ײ�"
                DeptManager = Trade_Manager
            Case "Ʒ�ܲ�"
                DeptManager = QCQA_Manager
            Case "������"
                DeptManager = Production_Manager
            Case "�豸��"
                DeptManager = Equipment_Manager
            Case "��ȫ��"
                DeptManager = Safe_Manager
            Case "IT��"
                DeptManager = IT_Manager
        End Select

        '�����DataTable:
        '  this.TableName.Rows[0]["����"].ToString();   
        '�����DataView:
        '  DataView   dv=new   DataView("tablename");   
        '  dv[0]   
        '�����DataSet:
        '  DataSet   ds=new   DataSet();   
        '  ds.Tables[0].Rows[0]["����"].TosString();




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
                Case "����"

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

                Case "��ͬ��-���ۺ�ͬ"
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

                Case "��ͬ��-�������ۺ�ͬ"
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
                Case "��ͬ��-����Ͳɹ�-���ۺ�ͬ-800T����"
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

                Case "��ͬ��-����Ͳɹ�-���ۺ�ͬ-800T����"
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


                Case "��ͬ��-����ɹ�-���ۺ�ͬ-200T����"
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
                Case "��ͬ��-����ɹ�-���ۺ�ͬ-200T����"
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
                Case "��ͬ��-���ۺ�ͬ�����ͬ"
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


                Case "������"
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
                Case "������"
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

                    MessageBox.Show("�����ڵ���ȫ��������ɣ�", "�ļ���ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    '---------------------------------------------------------------------------------------

            End Select
        End If

     
    End Sub
    Private Sub SetLevelNowAndUser()    '��ȡ�¸������ڵ��level��username
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


        MessageBox.Show("�ѻ�ȡ�¸������ڵ㣡", "�ļ���ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
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
        AIPWORK = "yihuimen"      'ǩ����
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
        ' opd.Filter = "��ǩ�ļ�|*.pdf;*.doc;*.docx;*.xls;*.xlsx;*.jpg"
        opd.Filter = "��ǩ�ļ�|*.pdf;*.doc;*.docx;*.xls;*.xlsx;*.jpg"
        opd.ShowDialog()
        ing.Visible = True
        axHWPostil1.LoadFile(opd.FileName)
        'axHWPostil1.SetPageMode(1, 100)

        'TXT_PATH.Text = axHWPostil1.PathName
        filename.Text = opd.SafeFileName.Substring(0, Len(opd.SafeFileName) - Len(System.IO.Path.GetExtension(opd.FileName)))
        FileExtemsion.Text = System.IO.Path.GetExtension(opd.FileName)

        FILEID.Text = Format(Now, "yyyyMMddHHmmss") + Int(Rnd() * 100)
        ing.Visible = False

        '��
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




            '------------------------------------------------------------------------------------------------����ǰ��Ҫɾ���ظ��ļ�����
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
            'For Each fname In opd.FileNames  '�ʺ��ڶ�ѡ�ļ��ı����������õ�

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

            SQLManager() '���ž�����
            SQLFlow()   '���̽ڵ�Ĵ���

            SetLevelNowAndUser()  '���ҵ���һ�ڵ��No������

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

            MessageBox.Show("ǩ���ļ��ѱ���!", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            'axHWPostil1.LoadFile("")
            ' axHWPostil1.SetPageMode(2, 0)
            'axHWPostil1.CloseDoc(0)
            ShowData()

        Else
            MessageBox.Show("�ļ���Ϣ������!", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


        '  Catch ex As Exception
        ' MessageBox.Show(ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
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
            Case "����"
                AIPSealLevelTotal = 3
            Case "������"
                AIPSealLevelTotal = 4
            Case "��ͬ��-���ۺ�ͬ"
                AIPSealLevelTotal = 4
            Case "��ͬ��-�������ۺ�ͬ"
                AIPSealLevelTotal = 5
            Case "��ͬ��-����Ͳɹ�-���ۺ�ͬ-800T����"
                AIPSealLevelTotal = 5
            Case "��ͬ��-����Ͳɹ�-���ۺ�ͬ-800T����"
                AIPSealLevelTotal = 6
            Case "��ͬ��-����ɹ�-���ۺ�ͬ-200T����"
                AIPSealLevelTotal = 5
            Case "��ͬ��-����ɹ�-���ۺ�ͬ-200T����"
                AIPSealLevelTotal = 6
            Case "��ͬ��-���ۺ�ͬ�����ͬ"
                AIPSealLevelTotal = 5
            Case "������"
                AIPSealLevelTotal = 4
        End Select

        'MessageBox.Show(AIPSealLevelTotal)
    End Sub
End Class