namespace NetMauiReadiness.ViewModels;

public abstract class ViewModelBase : BindableBase, IInitialize
{
	protected ViewModelBase()
	{
	}

	// TODO: IAnalytics

	protected virtual string ScreenName
	{
		get => GetType().Name;
	}

	public virtual void Initialize(INavigationParameters parameters)
	{
	}
}
