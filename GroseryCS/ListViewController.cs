using Foundation;
using System;
using UIKit;

namespace GroseryCS
{
    public partial class ListViewController : UIViewController
    {
        public ListViewController (IntPtr handle) : base (handle){}

        ListDataSource liststDS;
        public override void ViewDidLoad () {
            base.ViewDidLoad();
            liststDS = new ListDataSource(this);
            listTableView.Source = liststDS;

        }

        partial void NewListButton_TouchUpInside(UIButton sender)
        {
            throw new NotImplementedException();
        }

        partial void ProfileButton_TouchUpInside(UIButton sender)
        {
            throw new NotImplementedException();
        }
    }
}