using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFFurniture.Models;
using XFFurniture.ViewModels;

namespace XFFurniture.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Product product)
        {
            InitializeComponent();
            BindingContext = new DetailPageViewModel(Navigation, product);
        }
    }
}