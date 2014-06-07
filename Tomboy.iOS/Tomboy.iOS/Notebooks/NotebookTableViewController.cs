using System;
using MonoTouch.UIKit;
using System.Collections.Generic;

namespace Tomboy.iOS
{
	partial class NotebookTableViewController : UITableViewController
	{
		readonly List<string> Notebooks;

		public NotebookTableViewController (IntPtr handle) : base (handle)
		{
			Title = "Notebooks";

			Notebooks = new List<string> ();
			BuildFakeData ();
		}

		void BuildFakeData ()
		{
			for (int i = 0; i < 4; i++)
				Notebooks.Add ("Notebook " + i);
		}

		#region View Lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			TableView.Source = new NotebookTableViewSource (Notebooks);
		}

		partial void AddNotebookClicked (UIBarButtonItem sender)
		{
			using (var alert = new UIAlertView ("Notebooks", "Notebook added", null, "OK", null))
				alert.Show ();
			Notebooks.Insert (0, "_Notebook " + Notebooks.Count);
			TableView.ReloadData ();
		}

		#endregion
	}
}
