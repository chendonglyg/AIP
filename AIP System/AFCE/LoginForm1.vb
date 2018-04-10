Imports System.Data.SqlClient
Imports System.IO
Imports System.Data
Imports System.Net
Imports System.Text
'Imports System.DirectoryServices


Public Class LoginForm1
    Dim sr As New Integer
    Dim srf As New Integer
    Dim sa, sapassword As String
    Dim forreport As New SqlDataAdapter

    Public isok As Boolean

    Dim objdataadapter As New SqlDataAdapter


    Public objdataview As New DataView
    Dim objdataset As New DataSet
    Dim objcurrencymanager As System.Windows.Forms.CurrencyManager
    ' TODO: 插入代码，以使用提供的用户名和密码执行自定义的身份验证
    ' (请参见 http://go.microsoft.com/fwlink/?LinkId=35339)。 
    ' 随后自定义主体可附加到当前线程的主体，如下所示: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' 其中 CustomPrincipal 是用于执行身份验证的 IPrincipal 实现。 
    ' 随后，My.User 将返回 CustomPrincipal 对象中封装的标识信息
    ' 如用户名、显示名等



    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()





    End Sub



    Private Sub UsernameTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UsernameTextBox.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub




    Private Sub PasswordTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PasswordTextBox.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim LDAPVerificationFuction As New LDAPVerification.LDAPVerificationSoapClient
            'CODE="sfjweoifj;wfjw;le%$#%$#%REGTFREGERGedwqe112423147321047(*^@^*&^
            'Dim username, userPwd As String
            'Dim domain = New DirectoryEntry
            'Usernamevar = Trim(UsernameTextBox.Text)
            '  userpwdvar = Trim(PasswordTextBox.Text)
            'domain.Path = String.Format("LDAP://wilmar.cn")
            'domain.Username = username
            'domain.Password = userPwd
            'domain.AuthenticationType = AuthenticationTypes.Secure
            'domain.RefreshCache()

            'MessageBox.Show("恭喜你,wilmar.cn合法用户!", "通过提示“, MessageBoxButtons.OK, MessageBoxIcon.Information)

            isok = LDAPVerificationFuction.LoginYesOrNo("sfjweoifj;wfjw;le%$#%$#%REGTFREGERGedwqe112423147321047(*^@^*&^", Trim(UsernameTextBox.Text), Trim(PasswordTextBox.Text))




            sa = "sa"
            sapassword = "chen dong"

            objconnection = New SqlConnection("Data Source= " & Trim(ipaddress.Text) & "," & Trim(sqlport.Text) & ";Initial Catalog = AIP;User ID=" & sa & "; Password=" & sapassword)

            If objconnection.State = ConnectionState.Closed Then
                objconnection.Open()
            End If

            If isok = True Then
                ' MessageBox.Show("Wilmar合法域用户！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '----------------------进行菜单权限的开通设置------------------------------------------------------------------------------
                objdataadapter.SelectCommand = New SqlClient.SqlCommand
                objdataadapter.SelectCommand.Connection = objconnection
                objdataadapter.SelectCommand.CommandText = "select * from Users where username ='" & Trim(UsernameTextBox.Text) & "'"



                objdataset = New DataSet
                objdataadapter.Fill(objdataset, "users")

                dataviewuser = New DataView(objdataset.Tables("users"))




                If dataviewuser.Count >= 1 Then
                    UserDeptvar = Trim(objdataset.Tables("users").Rows(0)("UserDept"))
                    Usergroupvar = Trim(objdataset.Tables("users").Rows(0)("UserGroup"))
                    useridvar = Trim(objdataset.Tables("users").Rows(0)("ID"))
                    Usernamevar = Trim(objdataset.Tables("users").Rows(0)("Username"))
                    Usercompanyvar = Trim(objdataset.Tables("users").Rows(0)("UserCompany"))
                    Permitprint = Trim(objdataset.Tables("users").Rows(0)("PermitPrint"))
                    Permitsaveto = Trim(objdataset.Tables("users").Rows(0)("PermitSaveTo"))
                    Usercompanyidvar = Trim(objdataset.Tables("users").Rows(0)("UserCompanyID"))

                    isGroupMaster = Trim(objdataset.Tables("users").Rows(0)("isGroupMaster"))
                    isDeptManager = Trim(objdataset.Tables("users").Rows(0)("isDeptManager"))
                    isGeneralManager = Trim(objdataset.Tables("users").Rows(0)("isGeneraManager"))
                    isit = Trim(objdataset.Tables("users").Rows(0)("isIT"))
                    isadmin = Trim(objdataset.Tables("users").Rows(0)("isAdmin"))

                End If

                Me.Close()
            Else
                MessageBox.Show("您不是Wilmar合法用户，请联系企业IT！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If



        Catch ex As Exception

            MessageBox.Show(ex.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End Try
    End Sub

    Private Sub ipaddress_KeyDown(sender As Object, e As KeyEventArgs) Handles ipaddress.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click
        Dim A, B, C, sum As Integer
        A = 0 '临时换行计数器
        B = 1 '行计数
        C = 1 '列计数
        sum = 1 '总计数器


        Do While A >= 0
            A = A + 1
            sum = sum + 1
            C = C + 1
            If A = B Then
                C = 1
                A = 0
                B = B + 1
            End If

            If sum = Val(UsernameTextBox.Text) Then
                MessageBox.Show(B & "行" & C & "列", "结果")
                Exit Do
            End If
        Loop
    
    End Sub
End Class
