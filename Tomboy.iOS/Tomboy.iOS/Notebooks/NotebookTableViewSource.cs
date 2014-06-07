using System;
using System.Collections.Generic;
using MonoTouch.UIKit;

namespace Tomboy.iOS
{
	public class NotebookTableViewSource : UITableViewSource
	{
		const string CellIdentifier = "NotebookCell";

		readonly List<string> _notebooks;

		public NotebookTableViewSource (List<string> notebooks)
		{
			_notebooks = notebooks;
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			return _notebooks.Count;
		}


		public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (CellIdentifier);

			cell.TextLabel.Text = _notebooks [indexPath.Row];
			return cell;
		}

		public string GetItem (int id) {
			return _notebooks [id];
		}
	}
}
