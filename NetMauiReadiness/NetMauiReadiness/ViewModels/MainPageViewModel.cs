using NetMauiReadiness.Views;
using System.Windows.Input;

namespace NetMauiReadiness.ViewModels;

public class MainPageViewModel : ViewModelBase
{
	readonly INavigationService _navigationService;
	readonly IServiceProvider _servicesProvider;


#if SINGLE
	public MainPageViewModel(IServiceProvider servicesProvider)
	{
		_servicesProvider = servicesProvider;
	}
#else
	public MainPageViewModel(IServiceProvider servicesProvider, INavigationService navigationService)
	{
		_servicesProvider = servicesProvider;
		_navigationService = navigationService;
	}
#endif
	public ICommand ShowPopup => new Command(() => OnShowPopup(), () => true);

	private async Task OnShowPopup()
	{
		App.Current.MainPage.Navigation?.PushAsync(
			_servicesProvider.GetService<SomePopup>()
		);
		//App.Current.MainPage.Navigation?.PushModalAsync(
		//	_servicesProvider.GetService<SomePopup>()
		//);
	}
}
