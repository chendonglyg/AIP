Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Public Class NULL
    Dim forreport As New SqlDataAdapter
    Public afterdel As String
    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet





    Private Sub ShowData()
        If Len(YearSum.Text) > 0 And Len(FILETYPE.Text) > 0 And Len(AIPTYPE.Text) > 0 And Len(AIPTYPE.Text) > 0 Then
            objdataadapter = New SqlClient.SqlDataAdapter
            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandType = CommandType.Text
            objdataadapter.SelectCommand.CommandText = "select id,Filename,[FileSize] ,[FileExtension] ,[FileType],[FileID] ,[UploadTime]  ,[UploadUser]  ,[UploadUserID]  ,[UploadUserCompany]  ,[UploadUserGroup]  ,[AIPType]  ,[LayerUserName]  ,[LayerUserID]  ,[AIPDone]  ,[Remarks]  from AIPDATA2018 where Datename(yyyy,UploadTime)='" & Trim(YearSum.Text) & "' and FileName like '%" & Trim(FILE_NAME.Text) & "%'"


            If Trim(FILETYPE.Text) <> "全部" Then
                objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and FILETYPE=' " & Trim(FILETYPE.Text) & "'"
            End If

            If Trim(AIPTYPE.Text) <> "全部" Then
                objdataadapter.SelectCommand.CommandText = objdataadapter.SelectCommand.CommandText & "and AIPTYPE=' " & Trim(AIPTYPE.Text) & "'"
            End If

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "AIP")

            objdataview = New DataView(objdataset.Tables("AIP"))

            yidengji.DataSource = objdataview


        Else
            MessageBox.Show("年份、文件类型、签章类型或文件名信息不完整!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


    End Sub
    Private Sub ADDCOMBO()
        '-----------------------------------------------------------------------------------
        Dim A As Integer
        objdataadapter.SelectCommand = New SqlCommand
        objdataadapter.SelectCommand.Connection = objconnection
        objdataadapter.SelectCommand.CommandText = "select distinct(AIPSealType) from AIP_Ing_SealKeeper "
        If objconnection.State = ConnectionState.Closed Then
            objconnection.Open()
        End If
        objdataset = New DataSet
        objdataadapter.Fill(objdataset, "AIPSealType")

        objdataview = New DataView(objdataset.Tables("AIPSealType"))

        ' MessageBox.Show(objdataview.Count)
        AIPTYPE.Items.Clear()
        AIPTYPE.Items.Add("全部")
        If objdataview.Count >= 1 Then
            For A = 0 To objdataview.Count - 1
                AIPTYPE.Items.Add(objdataview.Item(A).Item("AIPSealType"))
            Next
        End If



        YearSum.Text = Year(Now)
        FILETYPE.Text = "全部"
        AIPTYPE.Text = "全部"
    End Sub

    Private Sub TXT_PATH_KeyDown(sender As Object, e As KeyEventArgs) Handles FILE_NAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            ShowData()
        End If
    End Sub

    Private Sub AIP3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        objconnection = New SqlConnection("Data Source= '10.229.17.6,1433';Initial Catalog = AIP;User ID='sa'; Password='chen dong'")
        axHWPostil1.ShowDefMenu = 0
        axHWPostil1.ShowScrollBarButton = 0
        axHWPostil1.ShowToolBar = 0
        yidengji.AllowUserToAddRows = False
        ADDCOMBO()
    End Sub


    Private Sub FILEID_KeyDown(sender As Object, e As KeyEventArgs) Handles FILEID.KeyDown
        If e.KeyCode = Keys.Enter Then
            objdataadapter = New SqlClient.SqlDataAdapter
            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandType = CommandType.Text
            objdataadapter.SelectCommand.CommandText = "select id,Filename,[FileSize] ,[FileExtension] ,[FileType],[FileID] ,[UploadTime]  ,[UploadUser]  ,[UploadUserID]  ,[UploadUserCompany]  ,[UploadUserGroup]  ,[AIPType]  ,[LayerUserName]  ,[LayerUserID]  ,[AIPDone]  ,[Remarks]  from AIPDATA2018 where  FileID='" & Trim(FILEID.Text) & "'"
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "AIP")

            objdataview = New DataView(objdataset.Tables("AIP"))

            yidengji.DataSource = objdataview

        End If

    End Sub

End Class