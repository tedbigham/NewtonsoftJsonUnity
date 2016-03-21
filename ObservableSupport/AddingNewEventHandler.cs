using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;

namespace Newtonsoft.Json.ObservableSupport
{
	//[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
	public delegate void AddingNewEventHandler(Object sender, AddingNewEventArgs e);
}
