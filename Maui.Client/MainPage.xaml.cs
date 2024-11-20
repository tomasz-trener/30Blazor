using Maui.Client.ViewModels;

namespace Maui.Client
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage(ProductViewModel productViewModel)
        {
            BindingContext = productViewModel;
            InitializeComponent();
        }

      
    }

}
