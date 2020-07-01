using XFFurniture.ViewModel;

namespace XFFurniture.Models
{
    public class Category : BaseViewModel
    {
        public string description { get; set; }
        public int numberItems { get; set; }
        public string image { get; set; }

        private string _backgroundColor;
        public string backgroundColor
        {
            get { return _backgroundColor; }
            set { SetProperty(ref _backgroundColor, value); }
        }

        private string _textColor;
        public string textColor
        {
            get { return _textColor; }
            set { SetProperty(ref _textColor, value); }
        }

        private bool _selected;
        public bool selected
        {
            get { return _selected; }
            set { SetProperty(ref _selected, value); }
        }
    }
}
