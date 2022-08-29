using TattooApp.Pages;

namespace TattooApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(InfoTattooPage), typeof(InfoTattooPage));
    }
}

