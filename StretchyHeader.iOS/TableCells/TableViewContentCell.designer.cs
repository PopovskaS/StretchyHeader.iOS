// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace StretchyHeader.iOS.TableCells
{
	[Register ("TableViewContentCell")]
	partial class TableViewContentCell
	{
		[Outlet]
		UIKit.UILabel DescriptionUILabel { get; set; }

		[Outlet]
		UIKit.UILabel TitleUILabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TitleUILabel != null) {
				TitleUILabel.Dispose ();
				TitleUILabel = null;
			}

			if (DescriptionUILabel != null) {
				DescriptionUILabel.Dispose ();
				DescriptionUILabel = null;
			}
		}
	}
}
