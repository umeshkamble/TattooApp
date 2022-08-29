using TattooApp.ViewModel;

namespace TattooApp;

public partial class HomePage : ContentPage
{

    public HomePage()
    {
        InitializeComponent();
        BindingContext = new HomePageViewModel();
    }
}
