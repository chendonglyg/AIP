﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.42000
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System.Data

Namespace GetTimeNow
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="GetTimeNow.ICTEnterprisesSoap")>  _
    Public Interface ICTEnterprisesSoap
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/HelloWorld", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function HelloWorld() As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/HelloWorld", ReplyAction:="*")>  _
        Function HelloWorldAsync() As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/sendMessageMulti", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Sub sendMessageMulti(ByVal ds As System.Data.DataSet, ByVal sendPassword As String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/sendMessageMulti", ReplyAction:="*")>  _
        Function sendMessageMultiAsync(ByVal ds As System.Data.DataSet, ByVal sendPassword As String) As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/sendOneMessage", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Sub sendOneMessage(ByVal receiveNumble As String, ByVal sendContent As String, ByVal sendUser As String, ByVal sendPassword As String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/sendOneMessage", ReplyAction:="*")>  _
        Function sendOneMessageAsync(ByVal receiveNumble As String, ByVal sendContent As String, ByVal sendUser As String, ByVal sendPassword As String) As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/sendInReadyToSend", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Sub sendInReadyToSend()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/sendInReadyToSend", ReplyAction:="*")>  _
        Function sendInReadyToSendAsync() As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/getDateTime", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function getDateTime() As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/getDateTime", ReplyAction:="*")>  _
        Function getDateTimeAsync() As System.Threading.Tasks.Task(Of String)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ICTEnterprisesSoapChannel
        Inherits GetTimeNow.ICTEnterprisesSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class CTEnterprisesSoapClient
        Inherits System.ServiceModel.ClientBase(Of GetTimeNow.ICTEnterprisesSoap)
        Implements GetTimeNow.ICTEnterprisesSoap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function HelloWorld() As String Implements GetTimeNow.ICTEnterprisesSoap.HelloWorld
            Return MyBase.Channel.HelloWorld
        End Function
        
        Public Function HelloWorldAsync() As System.Threading.Tasks.Task(Of String) Implements GetTimeNow.ICTEnterprisesSoap.HelloWorldAsync
            Return MyBase.Channel.HelloWorldAsync
        End Function
        
        Public Sub sendMessageMulti(ByVal ds As System.Data.DataSet, ByVal sendPassword As String) Implements GetTimeNow.ICTEnterprisesSoap.sendMessageMulti
            MyBase.Channel.sendMessageMulti(ds, sendPassword)
        End Sub
        
        Public Function sendMessageMultiAsync(ByVal ds As System.Data.DataSet, ByVal sendPassword As String) As System.Threading.Tasks.Task Implements GetTimeNow.ICTEnterprisesSoap.sendMessageMultiAsync
            Return MyBase.Channel.sendMessageMultiAsync(ds, sendPassword)
        End Function
        
        Public Sub sendOneMessage(ByVal receiveNumble As String, ByVal sendContent As String, ByVal sendUser As String, ByVal sendPassword As String) Implements GetTimeNow.ICTEnterprisesSoap.sendOneMessage
            MyBase.Channel.sendOneMessage(receiveNumble, sendContent, sendUser, sendPassword)
        End Sub
        
        Public Function sendOneMessageAsync(ByVal receiveNumble As String, ByVal sendContent As String, ByVal sendUser As String, ByVal sendPassword As String) As System.Threading.Tasks.Task Implements GetTimeNow.ICTEnterprisesSoap.sendOneMessageAsync
            Return MyBase.Channel.sendOneMessageAsync(receiveNumble, sendContent, sendUser, sendPassword)
        End Function
        
        Public Sub sendInReadyToSend() Implements GetTimeNow.ICTEnterprisesSoap.sendInReadyToSend
            MyBase.Channel.sendInReadyToSend
        End Sub
        
        Public Function sendInReadyToSendAsync() As System.Threading.Tasks.Task Implements GetTimeNow.ICTEnterprisesSoap.sendInReadyToSendAsync
            Return MyBase.Channel.sendInReadyToSendAsync
        End Function
        
        Public Function getDateTime() As String Implements GetTimeNow.ICTEnterprisesSoap.getDateTime
            Return MyBase.Channel.getDateTime
        End Function
        
        Public Function getDateTimeAsync() As System.Threading.Tasks.Task(Of String) Implements GetTimeNow.ICTEnterprisesSoap.getDateTimeAsync
            Return MyBase.Channel.getDateTimeAsync
        End Function
    End Class
End Namespace
