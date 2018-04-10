Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32

Public Class AIP4

    Dim forreport As New SqlDataAdapter
    Public afterdel As String
    Dim objdataadapter As New SqlDataAdapter
    Public objdataview As New DataView
    Dim objdataset As New DataSet


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim d As String, t As Date, s As String
        d = Dir(Application.StartupPath & "\*.*")
        Do Until d = ""
            If FileDateTime(Application.StartupPath & "\" & d) > t Then
                t = FileDateTime(Application.StartupPath & "\" & d)
                s = Application.StartupPath & "\" & d
            End If
            d = Dir()
        Loop
        MessageBox.Show("最新的文件是" & s)
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub
 

    Public Sub OpenWord(ByVal winWordControl1 As WinWordControl, ByVal wordUrl As String)

        Try
            winWordControl1.CloseControl()
        Catch
        Finally
            winWordControl1.document = Nothing
            WinWordControl.wd = Nothing
            WinWordControl.wordWnd = 0
        End Try
        Try
            winWordControl1.LoadDocument(wordUrl)
        Catch ex As Exception
            Dim err As [String] = ex.Message
        End Try
    End Sub


    Public Function GetPath() As String
        Return Application.StartupPath
    End Function

    Private Sub ShowData()
        Try

 
        If Len(YearSum.Text) > 0 Then
            objdataadapter = New SqlClient.SqlDataAdapter
            objdataadapter.SelectCommand = New SqlClient.SqlCommand
            objdataadapter.SelectCommand.Connection = objconnection
            objdataadapter.SelectCommand.CommandType = CommandType.Text
            If isadmin Then
                objdataadapter.SelectCommand.CommandText = "select [id],[FileName] ,[FileSize] ,[FileExtension] ,[FileType] ,[FileID] ,[UploadTime] ,[UploadUser] ,[UploadUserID] ,[UploadUserCompany] ,[UploadUserCompanyID] ,[UploadUserGroup] ,[AIPSealType] ,[AIPDone] ,[Remarks] from AIP_Ing where Datename(yyyy,UploadTime)='" & Trim(YearSum.Text) & "' and FileName like '%" & Trim(FILE_NAME.Text) & "%' and (FileExtension='.doc' OR FileExtension='.docx') "
            Else
                objdataadapter.SelectCommand.CommandText = "select [id],[FileName] ,[FileSize] ,[FileExtension] ,[FileType] ,[FileID] ,[UploadTime] ,[UploadUser] ,[UploadUserID] ,[UploadUserCompany] ,[UploadUserCompanyID] ,[UploadUserGroup] ,[AIPSealType] ,[AIPDone] ,[Remarks] from AIP_Ing where Datename(yyyy,UploadTime)='" & Trim(YearSum.Text) & "' and FileName like '%" & Trim(FILE_NAME.Text) & "%' and " & "[UploadUserCompany] =‘" & Trim(isCompany.Text) & "' and " & "[UploadUserGroup] =‘" & Trim(isDept.Text) & "'"

                End If



            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objdataset = New DataSet
            objdataadapter.Fill(objdataset, "DOC")

            objdataview = New DataView(objdataset.Tables("DOC"))

            yidengji.DataSource = objdataview

            yidengji.Columns(0).Width = 0

        Else
            MessageBox.Show("请先选择年度!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub AIP4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        WinWord.CloseControl()
    End Sub

    Private Sub AIP4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isadmin = True Then
            isCompany.Enabled = True
        Else
            isCompany.Enabled = False
        End If
        isCompany.Text = Usercompanyvar

        '--------------------------------------------------------------------------
        objconnection = New SqlConnection("Data Source= '10.229.17.6,1433';Initial Catalog = AIP;User ID='sa'; Password='chen dong'")
        WinWord.CloseControl()
        ADDCOMBO()
        yidengji.AllowUserToAddRows = False
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

    Private Sub yidengji_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles yidengji.CellContentClick
        ing.Visible = True
        IDID.Text = Trim(yidengji.Rows(e.RowIndex).Cells(0).Value)
        FileExtension.Text = Trim(yidengji.Rows(e.RowIndex).Cells(3).Value)
        FileName.Text = Trim(yidengji.Rows(e.RowIndex).Cells(1).Value)
        ShowDataToWord()
        ing.Visible = False
    End Sub

    Private Sub ShowDataToWord()
        Try
            Dim SEL As String = "C:\windows\temp\lkfjlksfjlflksjfkfjkslf.docj"
            System.IO.File.Delete(SEL)
            Dim SQLSEL As String = "Select id,FileData from AIP_ing where id = " & IDID.Text
            Dim myRow As DataRow
            Dim da As New SqlClient.SqlDataAdapter(SQLSEL, objconnection)
            Dim MyCB As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)
            Dim ds As New DataSet()
            da.Fill(ds, "DOC")
            objdataview = New DataView(ds.Tables("DOC"))
            If objdataview.Count > 0 Then
                myRow = ds.Tables("DOC").Rows(0)
                Dim MyData() As Byte
                MyData = myRow("Filedata")
                Dim ArraySize As Integer
                ArraySize = MyData.GetUpperBound(0)
                Dim fs As New IO.FileStream(SEL, IO.FileMode.OpenOrCreate, IO.FileAccess.Write)
                fs.Write(MyData, 0, ArraySize)
                fs.Close()
                OpenWord(WinWord, SEL)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub FILE_NAME_KeyDown(sender As Object, e As KeyEventArgs) Handles FILE_NAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            ShowData()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim path As String = SaveWord(WinWord, "")

    End Sub

    Public Function SaveWord(ByVal winWordControl1 As WinWordControl, ByVal pFileName As String) As String
        If String.IsNullOrEmpty(pFileName) Then
            pFileName = DateTime.Now.ToString("yyMMddHHmmss")
        End If
        Dim path As String = "\SystemWord\" + DateTime.Now.ToShortDateString() + "\"
        Dim savePath As String = path + pFileName + ".doc"
        Dim dic As String = GetPath() + path
        If Not System.IO.Directory.Exists(dic) Then
            System.IO.Directory.CreateDirectory(dic)
        End If
        Dim wordUrl As String = dic + pFileName + ".doc"
        Dim myNothing As Object = System.Reflection.Missing.Value
        Dim myFileName As Object = wordUrl
        Dim myWordFormatDocument As Object = Word.WdSaveFormat.wdFormatDocument
        Dim myLockd As Object = False
        Dim myPassword As Object = ""
        Dim myAddto As Object = True
        Try

            winWordControl1.document.SaveAs(myFileName, myWordFormatDocument, myLockd, myPassword, myAddto, myPassword, _
             myLockd, myLockd, myLockd, myNothing, myNothing)
            MessageBox.Show("文件已保存至本地:" & myFileName, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            WinWord.CloseControl()
            '-----------------------------------------------------------------------------------------------------------------------------------
            Dim fi As IO.FileInfo
            Dim fs As IO.FileStream
            fi = New IO.FileInfo(myFileName)
            fs = New IO.FileStream(myFileName, IO.FileMode.OpenOrCreate, IO.FileAccess.Read)
            Dim MyData(fs.Length) As Byte
            fs.Read(MyData, 0, fs.Length)
            fs.Close()
            fs = Nothing

            Dim objcommandpassword As New SqlCommand
            objcommandpassword.Connection = objconnection
            objcommandpassword.CommandText = "Update AIP_Ing set  Filedata=@Filedata where id=" & Val(IDID.Text)
            objcommandpassword.Parameters.AddWithValue("@Filedata", MyData)
            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If
            objcommandpassword.ExecuteNonQuery()
            objconnection.Close()
            MessageBox.Show("文件已更新至数据库!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "出问题啦！", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try
        Return myFileName
    End Function
End Class