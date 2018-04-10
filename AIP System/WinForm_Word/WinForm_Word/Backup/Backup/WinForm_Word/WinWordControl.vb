Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
'本代码Fangxp_mr 2012-10-15 修改自C# WinForm_Word
'在此感谢原作者
'原压缩包:word嵌入winfrom(winfrom_word)_2010-3-22
'下载自www.csdn.com
Partial Public Class WinWordControl
    Inherits UserControl
    Public Sub New()
        InitializeComponent()
    End Sub
    <DllImport("user32.dll")> _
    Public Shared Function FindWindow(ByVal strclassName As String, ByVal strWindowName As String) As Integer
    End Function

    <DllImport("user32.dll")> _
    Shared Function SetParent(ByVal hWndChild As Integer, ByVal hWndNewParent As Integer) As Integer
    End Function
    <DllImport("user32.dll", EntryPoint:="SetWindowPos")> _
    Shared Function SetWindowPos(ByVal hWnd As Integer, ByVal hWndInsertAfter As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, _
    ByVal uFlags As UInteger) As Boolean
    End Function
    <DllImport("user32.dll", EntryPoint:="MoveWindow")> _
    Shared Function MoveWindow(ByVal Wnd As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal Width As Integer, ByVal Height As Integer, ByVal Repaint As Boolean) As Boolean
    End Function
    <DllImport("user32.dll", EntryPoint:="DrawMenuBar")> _
    Shared Function DrawMenuBar(ByVal hWnd As Int32) As Int32
    End Function
    <DllImport("user32.dll", EntryPoint:="GetMenuItemCount")> _
    Shared Function GetMenuItemCount(ByVal hMenu As Int32) As Int32
    End Function
    <DllImport("user32.dll", EntryPoint:="GetSystemMenu")> _
    Shared Function GetSystemMenu(ByVal hWnd As Int32, ByVal Revert As Boolean) As Int32
    End Function
    <DllImport("user32.dll", EntryPoint:="RemoveMenu")> _
  Shared Function RemoveMenu(ByVal hMenu As Int32, ByVal nPosition As Int32, ByVal wFlags As Int32) As Int32
    End Function
    Private Const MF_BYPOSITION As Integer = &H400
    Private Const MF_REMOVE As Integer = &H1000
    Const SWP_DRAWFRAME As Integer = &H20
    Const SWP_NOMOVE As Integer = &H2
    Const SWP_NOSIZE As Integer = &H1
    Const SWP_NOZORDER As Integer = &H4
    Public document As Word.Document
    Public Shared wd As Word.ApplicationClass = Nothing
    Public Shared wordWnd As Integer = 0
    Public Shared filename As String = Nothing
    Private Shared deactivateevents As Boolean = False
    Public Sub PreActivate()
        If wd Is Nothing Then
            wd = New Word.ApplicationClass()
        End If
    End Sub
    Public Sub CloseControl()
        Try
            deactivateevents = True
            Dim dummy As Object = Nothing
            Dim dummy2 As Object = DirectCast(False, Object)
            document.Close(dummy, dummy, dummy)
            wd.Quit(dummy2, dummy, dummy)
            wd = Nothing
            deactivateevents = False
        Catch ex As Exception
            Dim strErr As [String] = ex.Message
        End Try
    End Sub
    Private Sub OnClose(ByVal doc As Word.Document, ByRef cancel As Boolean)
        If Not deactivateevents Then
            cancel = True
        End If
    End Sub

    Private Sub OnOpenDoc(ByVal doc As Word.Document)
        OnNewDoc(doc)
    End Sub
    Private Sub OnNewDoc(ByVal doc As Word.Document)
        If Not deactivateevents Then
            deactivateevents = True
            Dim dummy As Object = Nothing
            doc.Close(dummy, dummy, dummy)
            deactivateevents = False
        End If
    End Sub
    Private Sub OnQuit()
    End Sub
    Public Sub LoadDocument(ByVal t_filename As String)
        deactivateevents = True
        filename = t_filename
        If wd Is Nothing Then
            wd = New Word.ApplicationClass()
        End If
        Try
            wd.CommandBars.AdaptiveMenus = False
            'wd.DocumentBeforeClose += New Word.ApplicationEvents2_DocumentBeforeCloseEventHandler(OnClose)
            'wd.NewDocument += New Word.ApplicationEvents2_NewDocumentEventHandler(OnNewDoc)
            'wd.DocumentOpen += New Word.ApplicationEvents2_DocumentOpenEventHandler(OnOpenDoc)
            '        wd.ApplicationEvents2_Event_Quit += New Word.ApplicationEvents2_QuitEventHandler(OnQuit)
            AddHandler wd.DocumentBeforeClose, AddressOf OnClose
            AddHandler wd.NewDocument, AddressOf OnNewDoc
            AddHandler wd.DocumentOpen, AddressOf OnOpenDoc
            AddHandler wd.ApplicationEvents2_Event_Quit, AddressOf OnQuit
        Catch
        End Try
        If Not document Is Nothing Then
            Try
                Dim dummy As Object = Nothing
                wd.Documents.Close(dummy, dummy, dummy)
            Catch
            End Try
        End If
        If wordWnd = 0 Then
            wordWnd = FindWindow("Opusapp", Nothing)
        End If
        If wordWnd <> 0 Then
            SetParent(wordWnd, Me.Handle.ToInt32())
            Dim xfileName As Object = filename
            Dim newTemplate As Object = False
            Dim docType As Object = 0
            Dim [readOnly] As Object = True
            Dim isVisible As Object = True
            Dim missing As Object = System.Reflection.Missing.Value
            Try
                If wd Is Nothing Then
                    Throw New WordInstanceException()
                End If
                If wd.Documents Is Nothing Then
                    Throw New DocumentInstanceException()
                End If
                If Not wd Is Nothing AndAlso Not wd.Documents Is Nothing Then
                    document = wd.Documents.Add(xfileName, newTemplate, docType, isVisible)
                End If
                If document Is Nothing Then
                    Throw New ValidDocumentException()
                End If
            Catch
            End Try
            Try
                wd.ActiveWindow.DisplayRightRuler = False
                wd.ActiveWindow.DisplayScreenTips = False
                wd.ActiveWindow.DisplayVerticalRuler = False
                wd.ActiveWindow.DisplayRightRuler = False
                wd.ActiveWindow.ActivePane.DisplayRulers = False
                wd.ActiveWindow.ActivePane.View.Type = Word.WdViewType.wdWebView
            Catch
            End Try
            Dim counter As Integer = wd.ActiveWindow.Application.CommandBars.Count
            Dim i As Integer = 1
            While i <= counter
                Try
                    Dim nm As [String] = wd.ActiveWindow.Application.CommandBars(i).Name
                    If nm = "Standard" Then
                        Dim count_control As Integer = wd.ActiveWindow.Application.CommandBars(i).Controls.Count
                        Dim j As Integer = 1
                        While j <= 2
                            wd.ActiveWindow.Application.CommandBars(i).Controls(j).Enabled = False
                            System.Math.Max(System.Threading.Interlocked.Increment(j), j - 1)
                        End While
                    End If
                    If nm = "Menu Bar" Then
                        wd.ActiveWindow.Application.CommandBars(i).Enabled = False
                    End If
                    nm = ""
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
                System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
            End While
            Try
                wd.Visible = True
                wd.Activate()
                SetWindowPos(wordWnd, Me.Handle.ToInt32(), 0, 0, Me.Bounds.Width, Me.Bounds.Height, _
                 SWP_NOZORDER Or SWP_NOMOVE Or SWP_DRAWFRAME Or SWP_NOSIZE)
                OnResize()
            Catch
                MessageBox.Show("Error: do not load the document into the control until the parent window is shown!")
            End Try
            Try
                Dim hMenu As Integer = GetSystemMenu(wordWnd, False)
                If hMenu > 0 Then
                    Dim menuItemCount As Integer = GetMenuItemCount(hMenu)
                    RemoveMenu(hMenu, menuItemCount - 1, MF_REMOVE Or MF_BYPOSITION)
                    RemoveMenu(hMenu, menuItemCount - 2, MF_REMOVE Or MF_BYPOSITION)
                    RemoveMenu(hMenu, menuItemCount - 3, MF_REMOVE Or MF_BYPOSITION)
                    RemoveMenu(hMenu, menuItemCount - 4, MF_REMOVE Or MF_BYPOSITION)
                    RemoveMenu(hMenu, menuItemCount - 5, MF_REMOVE Or MF_BYPOSITION)
                    RemoveMenu(hMenu, menuItemCount - 6, MF_REMOVE Or MF_BYPOSITION)
                    RemoveMenu(hMenu, menuItemCount - 7, MF_REMOVE Or MF_BYPOSITION)
                    RemoveMenu(hMenu, menuItemCount - 8, MF_REMOVE Or MF_BYPOSITION)
                    DrawMenuBar(wordWnd)
                End If
            Catch
            End Try


            Me.Parent.Focus()
        End If
        deactivateevents = False
    End Sub

    Public Sub RestoreWord()
        Try
            Dim counter As Integer = wd.ActiveWindow.Application.CommandBars.Count
            Dim i As Integer = 0
            While i < counter
                Try
                    wd.ActiveWindow.Application.CommandBars(i).Enabled = True
                Catch
                End Try
                System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
            End While
        Catch
        End Try
    End Sub
    Private Overloads Sub OnResize()
        Dim borderWidth As Integer = SystemInformation.Border3DSize.Width
        Dim borderHeight As Integer = SystemInformation.Border3DSize.Height
        Dim captionHeight As Integer = SystemInformation.CaptionHeight
        Dim statusHeight As Integer = SystemInformation.ToolWindowCaptionHeight
        MoveWindow(wordWnd, -2 * borderWidth, -2 * borderHeight - captionHeight, Me.Bounds.Width + 4 * borderWidth, Me.Bounds.Height + captionHeight + 4 * borderHeight + statusHeight, True)
    End Sub
    Private Overloads Sub OnResize(ByVal sender As Object, ByVal e As System.EventArgs)
        OnResize()
    End Sub
    Public Sub RestoreCommandBars()
        Try
            Dim counter As Integer = wd.ActiveWindow.Application.CommandBars.Count
            Dim i As Integer = 1
            While i <= counter
                Try
                    Dim nm As [String] = wd.ActiveWindow.Application.CommandBars(i).Name
                    If nm = "Standard" Then
                        Dim count_control As Integer = wd.ActiveWindow.Application.CommandBars(i).Controls.Count
                        Dim j As Integer = 1
                        While j <= 2
                            wd.ActiveWindow.Application.CommandBars(i).Controls(j).Enabled = True
                            System.Math.Max(System.Threading.Interlocked.Increment(j), j - 1)
                        End While
                    End If
                    If nm = "Menu Bar" Then
                        wd.ActiveWindow.Application.CommandBars(i).Enabled = True
                    End If
                    nm = ""
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
                System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
            End While
        Catch
        End Try
    End Sub
End Class
Public Class DocumentInstanceException

    Inherits Exception
End Class

Public Class ValidDocumentException

    Inherits Exception
End Class

Public Class WordInstanceException

    Inherits Exception
End Class

