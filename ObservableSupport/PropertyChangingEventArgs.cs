using System;
using System.Security.Permissions;

namespace Newtonsoft.Json.ObservableSupport
{
	//[HostProtectionAttribute(SecurityAction.LinkDemand, SharedState = true)]
	public class PropertyChangingEventArgs : EventArgs
	{
		public PropertyChangingEventArgs(string propertyName)
		{
			PropertyName = propertyName;
		}

		public virtual string PropertyName { get; set; }
	}
}
