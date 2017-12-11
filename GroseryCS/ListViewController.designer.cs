// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace GroseryCS
{
    [Register ("ListViewController")]
    partial class ListViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView listTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton NewListButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ProfileButton { get; set; }

        [Action ("NewListButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void NewListButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("ProfileButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ProfileButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (listTableView != null) {
                listTableView.Dispose ();
                listTableView = null;
            }

            if (NewListButton != null) {
                NewListButton.Dispose ();
                NewListButton = null;
            }

            if (ProfileButton != null) {
                ProfileButton.Dispose ();
                ProfileButton = null;
            }
        }
    }
}