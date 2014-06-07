using System;
using MonoTouch.UIKit;
using System.Collections.Generic;

namespace Tomboy.iOS
{
	partial class NotesTableViewController : UITableViewController
	{
		readonly List<string> Notes;
		public NotesTableViewController (IntPtr handle) : base (handle)
		{
			Title = "Notes";

			Notes = new List<string> ();
			BuildFakeData ();
		}

		void BuildFakeData ()
		{
			for (int i = 0; i < 4; i++)
				Notes.Add ("Note " + i);
		}

		#region View Lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			TableView.Source = new NotesTableViewSource (Notes);
		}

		partial void AddNewNoteClicked (UIBarButtonItem sender)
		{
			using (var alert = new UIAlertView ("Notes", "Note added", null, "OK", null))
				alert.Show ();
			Notes.Insert (0, "_Note " + Notes.Count);
			TableView.ReloadData ();
		}

		#endregion
	}
}
