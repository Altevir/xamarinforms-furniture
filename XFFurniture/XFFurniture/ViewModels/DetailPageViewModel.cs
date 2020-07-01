using System.Threading.Tasks;
using Xamarin.Forms;
using XFFurniture.Interfaces;
using XFFurniture.Models;
using XFFurniture.ViewModel;

namespace XFFurniture.ViewModels
{
    public class DetailPageViewModel : BaseViewModel
    {
        public DetailPageViewModel(INavigation navigation, Product product)
        {
            Navigation = navigation;
            DependencyService.Get<IStatusBarStyle>().ChangeTextColor(true);
            PopDetailPageCommand = new Command(async () => await ExecutePopDetailPageCommand());
            Product = product;
        }

        public Command PopDetailPageCommand { get; }
        public Product Product { get; set; }

        private async Task ExecutePopDetailPageCommand()
        {
            await Navigation.PopAsync();
        }
    }
}
