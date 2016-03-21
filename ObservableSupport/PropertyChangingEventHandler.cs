using System;
using System.Security.Permissions;

namespace Newtonsoft.Json.ObservableSupport
{
	//[HostProtectionAttribute(SecurityAction.LinkDemand, SharedState = true)]
	public delegate void PropertyChangingEventHandler(Object sender, PropertyChangingEventArgs e);

}
