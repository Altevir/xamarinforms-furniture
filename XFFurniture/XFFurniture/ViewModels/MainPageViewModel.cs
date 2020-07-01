using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using XFFurniture.Models;
using XFFurniture.Service;
using XFFurniture.ViewModel;
using XFFurniture.Views;

namespace XFFurniture.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            SelectCategoryCommand = new Command<Category>((param) => ExecuteSelectCategoryCommand(param));
            NavigateToDetailPageCommand = new Command<Product>(async (param) => await ExeccuteNavigateToDetailPageCommand(param));
            GetCategories();
            GetProducts();
        }

        public Command NavigateToDetailPageCommand { get; }
        public Command SelectCategoryCommand { get; }
        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<Product> Products { get; set; }

        void GetCategories()
        {
            Categories = new ObservableCollection<Category>(DataService.GetCategories());
        }

        void GetProducts()
        {
            Products = new ObservableCollection<Product>(DataService.GetProducts());
        }

        private void ExecuteSelectCategoryCommand(Category model)
        {
            var index = Categories
               .ToList()
               .FindIndex(p => p.description == model.description);

            if (index > -1)
            {
                UnselectGroupItems();

                Categories[index].selected = true;
                Categories[index].textColor = "#FFFFFF";
                Categories[index].backgroundColor = "#F4C03E";
            }
        }

        void UnselectGroupItems()
        {
            Categories.ForEach((item) =>
            {
                item.selected = false;
                item.textColor = "#000000";
                item.backgroundColor = "#EAEDF6";
            });
        }

        private async Task ExeccuteNavigateToDetailPageCommand(Product param)
        {
            await Navigation.PushAsync(new DetailPage(param));
        }
    }
}
