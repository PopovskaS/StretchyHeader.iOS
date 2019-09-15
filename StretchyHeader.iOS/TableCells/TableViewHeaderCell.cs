using System;

using Foundation;
using UIKit;

namespace StretchyHeader.iOS.TableCells
{
    public partial class TableViewHeaderCell : UITableViewHeaderFooterView
    {
        public static readonly NSString Key = new NSString("TableViewHeaderCell");
        public static readonly UINib Nib;
        public UIImageView StretchyHeaderImageView => this.StretchyHeaderUIImageView;

        static TableViewHeaderCell()
        {
            Nib = UINib.FromName("TableViewHeaderCell", NSBundle.MainBundle);
        }

        public static TableViewHeaderCell Create()
        {
            return (TableViewHeaderCell)Nib.Instantiate(null, null)[0];
        }

        protected TableViewHeaderCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
