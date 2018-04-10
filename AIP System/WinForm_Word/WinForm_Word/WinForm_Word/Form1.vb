Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms


Partial Public Class Form1

    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnOpenWord_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        OPD.Filter = "DOC文件|*.doc;*.docx"
        OPD.ShowDialog()
        OpenWord(winWordControl1, OPD.FileName)
    End Sub
    Private Sub btnSaveWord_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim path As String = SaveWord(winWordControl1, "lkfjlksfjlflksjfkfjkslfj")
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
        Catch
            Throw New Exception("导出word文档失败!")
        End Try
        Return savePath
    End Function

    Public Function GetPath() As String
        Return Application.StartupPath
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        winWordControl1.CloseControl()
    End Sub

 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
