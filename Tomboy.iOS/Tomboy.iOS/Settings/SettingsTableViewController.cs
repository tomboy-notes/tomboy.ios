using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace Tomboy.iOS
{
	partial class SettingsTableViewController : UITableViewController
	{
		public SettingsTableViewController (IntPtr handle) : base (handle)
		{
			Title = "Settings";
		}
	}
}
