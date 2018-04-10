Namespace winfrom_word.Properties
	<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")> _
	<System.Diagnostics.DebuggerNonUserCodeAttribute> _
	<System.Runtime.CompilerServices.CompilerGeneratedAttribute> _
	Friend Class Resources
		Private Shared resourceMan As Global.System.Resources.ResourceManager
		Private Shared resourceCulture As Global.System.Globalization.CultureInfo
		<System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")> _
		Friend Sub New()
		End Sub
		<System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
		Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
			Get
				If (resourceMan = Nothing) Then
					Dim temp As New Global.System.Resources.ResourceManager("winfrom_word.Properties.Resources", GetType(Resources).Assembly)
					resourceMan = temp
				End If
				Return resourceMan
			End Get
		End Property
		<System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
		Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
			Get
				Return resourceCulture
			End Get
			Set
				resourceCulture = value
			End Set
		End Property
	End Class
End Namespace
