using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TipCalculator.iOS.Views
{
    [Register("HomeView")]
    partial class HomeView
    {
        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode("iOS Designer", "1.0")]
        UIKit.UITextField TextField { get; set; }

        void ReleaseDesignerOutlets()
        {
            if (Button != null)
            {
                Button.Dispose();
                Button = null;
            }

            if (TextField != null)
            {
                TextField.Dispose();
                TextField = null;
            }
        }

    }
}