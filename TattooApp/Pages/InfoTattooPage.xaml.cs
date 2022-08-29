using TattooApp.ViewModel;

namespace TattooApp.Pages;

public partial class InfoTattooPage : ContentPage
{
	public InfoTattooPage()
	{
		InitializeComponent();
		BindingContext = new InfoTattooViewModel();
    }
}
