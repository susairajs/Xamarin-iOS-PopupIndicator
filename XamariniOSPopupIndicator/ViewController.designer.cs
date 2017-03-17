// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamariniOSPopupIndicator
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnPopup { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIActivityIndicatorView indicator1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDisplay { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView view1 { get; set; }

        [Action ("BtnPopup_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnPopup_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnPopup != null) {
                btnPopup.Dispose ();
                btnPopup = null;
            }

            if (indicator1 != null) {
                indicator1.Dispose ();
                indicator1 = null;
            }

            if (lblDisplay != null) {
                lblDisplay.Dispose ();
                lblDisplay = null;
            }

            if (view1 != null) {
                view1.Dispose ();
                view1 = null;
            }
        }
    }
}