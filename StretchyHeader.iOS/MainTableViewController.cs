using System;
using System.IO;
using CoreGraphics;
using StretchyHeader.iOS.TableCells;
using StretchyHeader.iOS.TableSource;
using UIKit;
using Newtonsoft.Json;
using Foundation;
using Microsoft.AppCenter.Crashes;

namespace StretchyHeader.iOS
{
    public partial class MainTableViewController : UITableViewController
    {
        private TableViewHeaderCell tableViewHeaderCell;

        private DataModel dataModel;

        private TableViewDelegate tableViewDelegate;

        private const int TABLE_HEADER_VIEW_HEIGHT = 300;

        private int effectiveHeight; 

        public MainTableViewController(UITableViewStyle withStyle) : base(withStyle) { }

        protected MainTableViewController(IntPtr handle) : base(handle) { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            SetBaseTableSettings();

            SetResourceData();

            TableView.DataSource = new TableViewDataSource(dataModel);

            tableViewDelegate = new TableViewDelegate();

            tableViewDelegate.DidTableScrolled += UpdateHeaderView;

            TableView.Delegate = tableViewDelegate;

            InitTableViewHeader();

            TableView.ReloadData();
        }

        private void SetResourceData()
        {
            string json = File.ReadAllText(@"Branding/AppResources.json");

            dataModel = JsonConvert.DeserializeObject<DataModel>(json);
        }

        private void InitTableViewHeader()
        {
            tableViewHeaderCell = TableView.DequeueReusableHeaderFooterView(TableViewHeaderCell.Key) 
                                           as TableViewHeaderCell ?? 
                                           TableViewHeaderCell.Create();

            tableViewHeaderCell.UserInteractionEnabled = true;

            TableView.TableHeaderView = null;

            TableView.AddSubview(tableViewHeaderCell);

            tableViewHeaderCell.StretchyHeaderImageView.Image = UIImage.LoadFromData(NSData.FromUrl(new NSUrl(dataModel.HeaderResource)));

            effectiveHeight = TABLE_HEADER_VIEW_HEIGHT;

            TableView.ContentInset = new UIEdgeInsets(effectiveHeight, 0, 0, 0);

            TableView.ContentOffset = new CGPoint(0, -effectiveHeight);

            UpdateHeaderView();
        }

        public void UpdateHeaderView()
        {
            var headerRect = new CGRect(0, -effectiveHeight, UIScreen.MainScreen.Bounds.Width, TABLE_HEADER_VIEW_HEIGHT);

            if (TableView.ContentOffset.Y < -effectiveHeight)
            {
                headerRect.Y = TableView.ContentOffset.Y;
                headerRect.Height = (-TableView.ContentOffset.Y);
            }

            tableViewHeaderCell.Frame = headerRect;
        }

        private void SetBaseTableSettings()
        {
            this.NavigationController.NavigationBar.Hidden = true;

            this.TableView.BackgroundColor = UIColor.White;

            this.TableView.SeparatorStyle = UITableViewCellSeparatorStyle.None;
        }
    }
}
