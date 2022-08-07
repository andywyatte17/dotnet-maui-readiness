using CommunityToolkit.Mvvm.Input;
using NetMauiReadiness.Views;
using System.Windows.Input;
using CommunityToolkit.Maui.Views;

namespace NetMauiReadiness.ViewModels;

public partial class MainPageViewModel : ViewModelBase
{
	readonly INavigationService _navigationService;
	readonly IServiceProvider _servicesProvider;

	protected MainPageViewModel()
	{
		_pickFileAndShow = new AsyncRelayCommand(() => OnPickFileAndShow());
		_showPopup = new RelayCommand(() => OnShowPopup());
		_goToSomePage = new AsyncRelayCommand(() => OnGoToSomePage());
	}

	public MainPageViewModel(IServiceProvider servicesProvider, INavigationService navigationService) : this()
	{
		_servicesProvider = servicesProvider;
		_navigationService = navigationService;
	}

	private ICommand _showPopup;

	public ICommand ShowPopup => _showPopup;

	private void OnShowPopup()
	{
		var popup = new SomePopup();
		App.Current?.MainPage?.ShowPopup(popup);
	}

	private ICommand _goToSomePage;

	public ICommand GoToSomePage => _goToSomePage;

	private async Task OnGoToSomePage()
	{
		await App.Current.MainPage.Navigation?.PushAsync(new SomePage());
	}
}