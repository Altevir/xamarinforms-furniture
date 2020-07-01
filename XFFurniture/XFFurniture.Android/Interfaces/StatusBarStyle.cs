using Android.OS;
using Android.Views;
using Xamarin.Forms;
using XFFurniture.Droid.Interfaces;
using XFFurniture.Interfaces;

[assembly: Dependency(typeof(StatusBarStyle))]
namespace XFFurniture.Droid.Interfaces
{
    public class StatusBarStyle : IStatusBarStyle
    {
        public void ChangeTextColor(bool darkContent = false)
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    var window = CurrentWindow();
                    window.DecorView.SystemUiVisibility = (StatusBarVisibility)SystemUiFlags.LightStatusBar;
                    window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#FFFFFF"));
                });
            }
        }

        Window CurrentWindow()
        {
            var window = MainActivity.CurrentActivity.Window;
            window.ClearFlags(WindowManagerFlags.TranslucentStatus);
            window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
            return window;
        }
    }
}