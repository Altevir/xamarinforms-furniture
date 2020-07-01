using UIKit;
using Xamarin.Forms;
using XFFurniture.Interfaces;
using XFFurniture.iOS.Interfaces;

[assembly: Dependency(typeof(StatusBarStyle))]
namespace XFFurniture.iOS.Interfaces
{
    public class StatusBarStyle : IStatusBarStyle
    {
        public void ChangeTextColor(bool darkContent = false)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                var currentUIViewController = GetCurrentViewController();
                UIApplication.SharedApplication.SetStatusBarStyle(darkContent ? UIStatusBarStyle.LightContent : UIStatusBarStyle.DarkContent, false);
                currentUIViewController.SetNeedsStatusBarAppearanceUpdate();
            });
        }

        UIViewController GetCurrentViewController()
        {
            var window = UIApplication.SharedApplication.KeyWindow;
            var vc = window.RootViewController;
            while (vc.PresentedViewController != null)
                vc = vc.PresentedViewController;
            return vc;
        }
    }
}