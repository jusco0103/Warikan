// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Warikan
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel KekkaLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField KingakuForm { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField NinzuForm { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ResetButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton WarikanButton { get; set; }

        [Action ("ResetButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ResetButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("WarikanButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void WarikanButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (KekkaLabel != null) {
                KekkaLabel.Dispose ();
                KekkaLabel = null;
            }

            if (KingakuForm != null) {
                KingakuForm.Dispose ();
                KingakuForm = null;
            }

            if (NinzuForm != null) {
                NinzuForm.Dispose ();
                NinzuForm = null;
            }

            if (ResetButton != null) {
                ResetButton.Dispose ();
                ResetButton = null;
            }

            if (WarikanButton != null) {
                WarikanButton.Dispose ();
                WarikanButton = null;
            }
        }
    }
}