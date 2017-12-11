using System;
using Foundation;
using UIKit;
namespace GroseryCS
{
    public class ListDataSource : UITableViewSource
    {
        readonly UIViewController dataSourceController;

        public ListDataSource(UIViewController inpCtrl){
            dataSourceController = inpCtrl;
        }
        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return 5;
        }
        
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell("listCell");
            cell.TextLabel.Text = "Test";
            cell.DetailTextLabel.Text = "Sub Text";
            return cell;
        }

       
    }
}