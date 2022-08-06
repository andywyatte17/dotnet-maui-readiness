using System.Windows.Input;

namespace NetMauiReadiness.ViewModels;

public class MainViewModel : ViewModelBase
{
	public MainViewModel() { }

	public ICommand ShowPopup => new Command(() => OnShowPopup(), () => true);

	private void OnShowPopup()
	{
		throw new NotImplementedException();
	}
}
