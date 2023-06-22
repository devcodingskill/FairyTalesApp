using FairyTalesApp.Views;

namespace FairyTalesApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new HomePage();
	}
}
