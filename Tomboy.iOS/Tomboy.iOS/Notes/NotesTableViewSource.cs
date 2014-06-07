using System;
using System.Collections.Generic;
using MonoTouch.UIKit;

namespace Tomboy.iOS
{
	public class NotesTableViewSource : UITableViewSource
	{
		const string CellIdentifier = "NoteCell";

		readonly List<string> _notes;

		public NotesTableViewSource (List<string> notebooks)
		{
			_notes = notebooks;
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			return _notes.Count;
		}


		public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (CellIdentifier);

			cell.TextLabel.Text = _notes [indexPath.Row];
			return cell;
		}

		public string GetItem (int id) {
			return _notes [id];
		}
	}
}
