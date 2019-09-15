using System;
using Foundation;
using StretchyHeader.iOS.TableCells;
using UIKit;

namespace StretchyHeader.iOS.TableSource
{
    public class TableViewDataSource : UITableViewDataSource
    {
        private const int numberOfRowsInSection = 1;
        private DataModel dataModel;

        public TableViewDataSource(DataModel dataModel)
        {
            this.dataModel = dataModel;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(TableViewContentCell.Key) as TableViewContentCell ?? TableViewContentCell.Create();
            cell.SetTextColors();
            cell.TitleLabel.Text = dataModel.Title;
            cell.DescriptionLabel.Text = dataModel.Description;
            return cell;
        }

        public override nint RowsInSection(UITableView tableView, nint section) => numberOfRowsInSection;
    }
}
