using Maui.Client.ViewModels;

namespace Maui.Client2
{
    public partial class MainPage : ContentPage
    {
      
        public MainPage(ProductViewModel productsViewModel)
        {
            BindingContext = productsViewModel;
            InitializeComponent();
        }


    }

}
