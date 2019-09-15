using System;
using UIKit;

namespace StretchyHeader.iOS.TableSource
{
    public class TableViewDelegate : UITableViewDelegate
    {
        public delegate void DidScrollEventHandler();

        public event DidScrollEventHandler DidTableScrolled;

        public override void Scrolled(UIScrollView scrollView)
        {
            DidTableScrolled();
        }

        public override nfloat EstimatedHeight(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            return tableView.RowHeight;
        }

        public override nfloat GetHeightForRow(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            return UITableView.AutomaticDimension;
        }
    }
}
