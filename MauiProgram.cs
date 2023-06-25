using FairyTalesApp.ViewModels;
using Microsoft.Extensions.Logging;
using FairyTalesApp.Views;
namespace FairyTalesApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Epilogue-Medium 500.ttf", "Epilogue");
                fonts.AddFont("fontello.ttf", "Icons");
            });
#if DEBUG
		builder.Logging.AddDebug();
#endif
		//do need to this register hack on app()
		////register the viewmodel
		//builder.Services.AddSingleton<HomePageViewModel>();

		////register the page
		//builder.Services.AddSingleton<HomePage>();
		
		return builder.Build();
	}
}
