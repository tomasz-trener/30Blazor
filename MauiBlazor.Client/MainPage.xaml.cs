namespace MauiBlazor.Client
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "Hello from Maui!", "OK");
        }
    }
}
