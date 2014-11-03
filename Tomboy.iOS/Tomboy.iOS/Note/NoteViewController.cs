using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace Tomboy.iOS
{
	partial class NoteViewController : UIViewController
	{
		public NoteViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad () 
		{
			TextEditor.Text = "Enter Note Here..";
		}


	}
}
