﻿Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Class Program
    <STAThread()> _
    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Form1())
    End Sub
End Class
