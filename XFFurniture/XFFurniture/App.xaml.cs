using Plugin.SharedTransitions;
using Xamarin.Forms;

namespace XFFurniture
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new SharedTransitionNavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
