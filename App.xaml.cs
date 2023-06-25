using FairyTalesApp.ViewModels;
using FairyTalesApp.Views;

namespace FairyTalesApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		//hack
		HomePageViewModel viewModel = new HomePageViewModel();
		MainPage = new HomePage(viewModel);
	}
}
