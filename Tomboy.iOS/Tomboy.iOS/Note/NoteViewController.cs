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
			Editing = true;

			WebViewer.LoadHtmlString ("<html id=\"content\" contenteditable=\"true\" style=\"font-family: Helvetica\">\n\n <body>\n\n   <div>Enter Note Content here..</div>\n\n  </body>\n\n</html>", null);
		}
	}
}
