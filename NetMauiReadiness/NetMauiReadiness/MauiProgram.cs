using NetMauiReadiness.ViewModels;
using NetMauiReadiness.Views;
using Prism.Ioc;

namespace NetMauiReadiness;

public static class PlatformInitializer
{
	public static void RegisterTypes(IContainerRegistry containerRegistry)
	{
		//containerRegistry.RegisterPopupNavigationService();
		//containerRegistry.RegisterPopupDialogService();
	}
}

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
#if MAUI
//#if !PRISM
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddTransient<MainPage>();
		builder.Services.AddSingleton<MainPageViewModel>();			
#else
		builder
			.UsePrismApp<App>(prism =>
					prism.RegisterTypes(container => {
						PlatformInitializer.RegisterTypes(container);
						// ...
						container.RegisterForNavigation<SomePopup>();
					}));

		builder
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainPageViewModel>();
#endif
		return builder.Build();
	}
}
