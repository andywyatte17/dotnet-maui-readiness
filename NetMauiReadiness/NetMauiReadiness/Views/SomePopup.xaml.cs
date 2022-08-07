using CommunityToolkit.Maui.Views;
using NetMauiReadiness.ViewModels;

namespace NetMauiReadiness.Views;

public partial class SomePopup : Popup
{
	protected SomePopup()
	{
		InitializeComponent();
	}

	public SomePopup(SomePanelViewModel vm) : this()
	{
		BindingContext = vm;
	}
}