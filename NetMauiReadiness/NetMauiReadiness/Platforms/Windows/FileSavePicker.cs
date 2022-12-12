
using System.Diagnostics;
using Windows.Storage;
using Windows.Storage.Pickers;

namespace NetMauiReadiness.Services
{
    public class FileSavePicker : IFileSavePicker
    {
        public Task<string> ShowDialogAndGetFile()
        {
            return Show();
        }

        private async Task<String> Show()
        {
            using var process = Process.GetCurrentProcess();
            var hwnd = process.MainWindowHandle;

            var picker = new Windows.Storage.Pickers.FileSavePicker();
            WinRT.Interop.InitializeWithWindow.Initialize(picker, hwnd);
            picker.FileTypeChoices.Add(
                new KeyValuePair<string, IList<string>>(
                    key: "Text Files (*.txt)",
                    value: new[] { ".txt" }
                    )
                );

            var file = await picker.PickSaveFileAsync();
            return file.Path;

            /*
            savePicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            savePicker.FileTypeChoices.Add("Plain Text", new List<string>() { ".txt" });
            savePicker.SuggestedFileName = "New Document";
            */
        /*
            StorageFile file = await savePicker.PickSaveFileAsync();
            if (file != null)
            {
                return file.Path;
            }

            return null;
        */
        }
    }
}