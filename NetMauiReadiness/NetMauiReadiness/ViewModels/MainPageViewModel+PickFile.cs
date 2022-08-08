using CommunityToolkit.Mvvm.Input;
using NetMauiReadiness.Views;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace NetMauiReadiness.ViewModels;

public partial class MainPageViewModel
{
	ICommand _pickFileAndShow;

	public ICommand PickFileAndShow => _pickFileAndShow; 

	private async Task OnPickFileAndShow()
	{
		var Win = new[] { ".jpg", ".png", ".txt" };
		var iOS = new[] { "public.jpeg", "public.png", "public.text" }; // or general UTType values
		var Droid = new[] { "image/jpeg", "image/png", "text/plain" };

		var result = await PickAndShow(new PickOptions()
		{
			
			FileTypes = new FilePickerFileType(
				new Dictionary<DevicePlatform, IEnumerable<string>>()
				{
					{ DevicePlatform.WinUI, Win },
					{ DevicePlatform.MacCatalyst, iOS },
					{ DevicePlatform.macOS, iOS },
					{ DevicePlatform.iOS, iOS },
					{ DevicePlatform.Android, Droid }
				}
			),
			PickerTitle = "Get me a file!"
		});

		if (result == null)
			return;

		var stream = await result.OpenReadAsync();
		byte[] some = new byte[50];
		var read = await stream.ReadAsync(some, 0, 50);

		_fileContents = System.Convert.ToHexString(some);
		for (int i = 0, im = 0, r = 0, len = (int)_fileContents.Length; i < len; i++, r++)
		{
			if (im == 40)
			{
				_fileContents = _fileContents.Substring(0, r) + "\n" + _fileContents.Substring(r);
				r++;
				im = 1;
			}
			else
			{
				im++;
			}
		}
		RaisePropertyChanged(nameof(FileContents));
	}

	public async Task<FileResult> PickAndShow(PickOptions options)
	{
		try
		{
			var result = await FilePicker.Default.PickAsync(options);
			if (result != null)
			{
				if (result.FileName.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
						result.FileName.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
						result.FileName.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
				{
					using var stream = await result.OpenReadAsync();
					var image = ImageSource.FromStream(() => stream);
				}
			}

			return result;
		}
		catch (Exception)
		{
			// The user canceled or something went wrong
		}

		return null;
	}

	string _fileContents;
	public string FileContents => _fileContents;
}