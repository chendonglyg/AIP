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

Namespace sendmessage
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="sendmessage.ICTEnterprisesSoap")>  _
    Public Interface ICTEnterprisesSoap
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/HelloWorld", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function HelloWorld() As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/sendMessageMulti", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Sub sendMessageMulti(ByVal ds As System.Data.DataSet, ByVal sendPassword As String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/sendOneMessage", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Sub sendOneMessage(ByVal receiveNumble As String, ByVal sendContent As String, ByVal sendUser As String, ByVal sendPassword As String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/sendInReadyToSend", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Sub sendInReadyToSend()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/getDateTime", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function getDateTime() As String
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ICTEnterprisesSoapChannel
        Inherits sendmessage.ICTEnterprisesSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class CTEnterprisesSoapClient
        Inherits System.ServiceModel.ClientBase(Of sendmessage.ICTEnterprisesSoap)
        Implements sendmessage.ICTEnterprisesSoap
        
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
        
        Public Function HelloWorld() As String Implements sendmessage.ICTEnterprisesSoap.HelloWorld
            Return MyBase.Channel.HelloWorld
        End Function
        
        Public Sub sendMessageMulti(ByVal ds As System.Data.DataSet, ByVal sendPassword As String) Implements sendmessage.ICTEnterprisesSoap.sendMessageMulti
            MyBase.Channel.sendMessageMulti(ds, sendPassword)
        End Sub
        
        Public Sub sendOneMessage(ByVal receiveNumble As String, ByVal sendContent As String, ByVal sendUser As String, ByVal sendPassword As String) Implements sendmessage.ICTEnterprisesSoap.sendOneMessage
            MyBase.Channel.sendOneMessage(receiveNumble, sendContent, sendUser, sendPassword)
        End Sub
        
        Public Sub sendInReadyToSend() Implements sendmessage.ICTEnterprisesSoap.sendInReadyToSend
            MyBase.Channel.sendInReadyToSend
        End Sub
        
        Public Function getDateTime() As String Implements sendmessage.ICTEnterprisesSoap.getDateTime
            Return MyBase.Channel.getDateTime
        End Function
    End Class
End Namespace