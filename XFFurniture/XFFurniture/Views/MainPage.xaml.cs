using System.ComponentModel;
using Xamarin.Forms;
using XFFurniture.Interfaces;
using XFFurniture.ViewModels;

namespace XFFurniture
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(Navigation);
        }

        protected override void OnAppearing()
        {
            DependencyService.Get<IStatusBarStyle>().ChangeTextColor();
        }
    }
}
