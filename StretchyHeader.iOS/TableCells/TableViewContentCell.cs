using System;

using Foundation;
using StretchyHeader.iOS.Branding;
using UIKit;

namespace StretchyHeader.iOS.TableCells
{
    public partial class TableViewContentCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("TableViewContentCell");
        public static readonly UINib Nib;
        public UILabel TitleLabel => TitleUILabel;
        public UILabel DescriptionLabel => DescriptionUILabel;

        static TableViewContentCell()
        {
            Nib = UINib.FromName("TableViewContentCell", NSBundle.MainBundle);
        }

        public static TableViewContentCell Create()
        {
            return (TableViewContentCell)Nib.Instantiate(null, null)[0];
        }

        public void SetTextColors()
        {
            TitleUILabel.TextColor = ColorPalette.PrimaryColor;

            DescriptionLabel.TextColor = ColorPalette.AccentColor;
        }

        protected TableViewContentCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
