// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace Tomboy.iOS
{
	[Register ("NoteViewController")]
	partial class NoteViewController
	{
		[Outlet]
		MonoTouch.UIKit.UITextField[] NoteTitle { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextView TextEditor { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField Title { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIWebView WebView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIWebView WebViewer { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Title != null) {
				Title.Dispose ();
				Title = null;
			}

			if (WebView != null) {
				WebView.Dispose ();
				WebView = null;
			}

			if (WebViewer != null) {
				WebViewer.Dispose ();
				WebViewer = null;
			}

			if (TextEditor != null) {
				TextEditor.Dispose ();
				TextEditor = null;
			}
		}
	}
}
