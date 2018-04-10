Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Win32
Module Module1

    Public objconnection As SqlConnection
    Public isDeptManager, isit, isGeneralManager, isadmin, isGroupMaster As Boolean
    Public computername As String
    Public Usernamevar, UserDeptvar, Usergroupvar, Usercompanyvar, Usercompanyidvar, Permitprint, Permitsaveto As String
    Public storestation As String
    Public stationname As String
    Public dataviewuser As DataView
    Public formno, useridvar As Integer
    Public formstr As String

    Sub main()


        isadmin = False
        isDeptManager = False
        isit = False
        isGeneralManager = False
        isGroupMaster = False

        ' ÔËÐÐµÇÂ½´°Ìå()
        Dim frmLogon As New LoginForm1

        frmLogon.ShowDialog()

        If frmLogon.isok = True Then


            Application.Run(MDIParent1)




        End If


    End Sub

End Module
